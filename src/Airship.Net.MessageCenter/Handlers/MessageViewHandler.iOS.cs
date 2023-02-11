using Microsoft.Maui.Handlers;
using WebKit;
using CoreGraphics;
using UIKit;

using Foundation;
using UrbanAirship;
using AirshipDotNet.MessageCenter.Controls;

namespace AirshipDotNet.MessageCenter.Handlers;

/// <summary>
/// Handler responsible for displaying a single Message Center message via the platform WKWebView.
/// </summary>
public partial class MessageViewHandler : ViewHandler<IMessageView, WKWebView>
{
    public static PropertyMapper<IMessageView, MessageViewHandler> MessageViewMapper = new(ViewHandler.ViewMapper)
    {
        [nameof(IMessageView.MessageId)] = MapMessageId
    };

    private readonly NativeBridgeDelegate nativeBridgeDelegate;
    private readonly NavigationDelegate navigationDelegate;
    private readonly UANativeBridge nativeBridge;
    private readonly UAMessageCenterNativeBridgeExtension nativeBridgeExtension;
    private string messageId;

    public MessageViewHandler() : base(MessageViewMapper)
    {
        nativeBridgeDelegate = new(this);
        navigationDelegate = new(this);
        nativeBridgeExtension = new UAMessageCenterNativeBridgeExtension();

        nativeBridge = new()
        {
            ForwardNavigationDelegate = navigationDelegate,
            NativeBridgeDelegate = nativeBridgeDelegate,
            NativeBridgeExtensionDelegate = nativeBridgeExtension
        };
    }

    protected override WKWebView CreatePlatformView()
    {
        return new(UIScreen.MainScreen.Bounds, new WKWebViewConfiguration())
        {
            AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight,
            TranslatesAutoresizingMaskIntoConstraints = true,
            NavigationDelegate = nativeBridge
        };
    }

    private static void MapMessageId(MessageViewHandler handler, IMessageView entry)
    {
        if (entry.MessageId != null)
        {
            handler.LoadMessage(entry.MessageId);
        }
    }

    protected void LoadMessage(string? messageId)
    {
        if (messageId == null) return;
        var message = UAMessageCenter.Shared.MessageList.Message(messageId);
        if (message != null)
        {
            LoadMessageBody(message);
        }
        else
        {
            UAMessageCenter.Shared.MessageList.RetrieveMessageList(() =>
                {
                    message = UAMessageCenter.Shared.MessageList.Message(messageId);
                    if (message != null && !message.IsExpired())
                    {
                        LoadMessageBody(message);
                    }
                    else
                    {
                        VirtualView.OnLoadFailed(messageId, false, MessageFailureStatus.Unavailable);
                    }
                },
                () => VirtualView.OnLoadFailed(messageId, false, MessageFailureStatus.FetchFailed)
            );
        }

    }

    protected void LoadMessageBody(UAInboxMessage message)
    {
        messageId = message.MessageID;

        UAMessageCenter.Shared.User.GetUserData((UAUserData userData) =>
        {
            if (userData == null) return;

            var auth = UAUtils.AuthHeaderString(userData.Username, userData.Password);
            NSMutableDictionary dict = new NSMutableDictionary
            {
                { new NSString("Authorization"), new NSString(auth) }
            };
            var request = new NSMutableUrlRequest(message.MessageBodyURL) {
                Headers = dict
            };

            MainThread.BeginInvokeOnMainThread(() =>
                PlatformView.LoadRequest(request)
            );

            VirtualView.OnLoadStarted(message.MessageID);
        });
    }

    private class NavigationDelegate : NSObject, IUANavigationDelegate
    {
        private MessageViewHandler Handler { get; set; }

        public NavigationDelegate(MessageViewHandler handler)
        {
            Handler = handler;
        }

        [Export("webView:decidePolicyForNavigationResponse:decisionHandler:")]
        public void DecidePolicy(WKWebView webView, WKNavigationResponse navigationResponse, Action<WKNavigationResponsePolicy> decisionHandler)
        {
            var response = navigationResponse.Response as NSHttpUrlResponse;
            if (response?.StatusCode >= 400 && response.StatusCode <= 599)
            {
                decisionHandler(WKNavigationResponsePolicy.Cancel);
                if (response.StatusCode == 410)
                {
                    Handler.VirtualView.OnLoadFailed(Handler.messageId, false, MessageFailureStatus.Unavailable);
                }
                else
                {
                    Handler.VirtualView.OnLoadFailed(Handler.messageId, true, MessageFailureStatus.LoadFailed);
                }
            }
            else
            {
                decisionHandler(WKNavigationResponsePolicy.Allow);
            }
        }

        [Export("webView:didFinishNavigation:")]
        public void DidFinishNavigation(WKWebView webView, WKNavigation navigation)
        {
            Handler.VirtualView.OnLoadFinished(Handler.messageId);
        }

        [Export("webView:didFailNavigation:withError:")]
        public void DidFailNavigation(WKWebView webView, WKNavigation navigation, NSError error)
        {
            Handler.VirtualView.OnLoadFailed(Handler.messageId, true, MessageFailureStatus.LoadFailed);
        }

        [Export("webView:didFailProvisionalNavigation:withError:")]
        public void DidFailProvisionalNavigation(WKWebView webView, WKNavigation navigation, NSError error)
        {
            webView.NavigationDelegate?.DidFailNavigation(webView, navigation, error);
        }
    }

    private class NativeBridgeDelegate : NSObject, IUANativeBridgeDelegate
    {
        private MessageViewHandler Handler { get; set; }

        public NativeBridgeDelegate(MessageViewHandler handler)
        {
            Handler = handler;
        }

        public void Close()
        {
            Handler.VirtualView.OnClosed(Handler.messageId);
        }
    }
}


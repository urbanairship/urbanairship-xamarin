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
// FIXME: IUANavigationDelegate is not available for some reason?
public partial class MessageViewHandler : ViewHandler<IMessageView, WKWebView>//, IUANavigationDelegate
{
    public static PropertyMapper<IMessageView, MessageViewHandler> MessageViewMapper = new(ViewHandler.ViewMapper)
    {
        [nameof(IMessageView.MessageId)] = MapMessageId
    };

    public MessageViewHandler() : base(MessageViewMapper)
    {
    }

    protected override WKWebView CreatePlatformView()
    {
        CGRect frame = UIScreen.MainScreen.Bounds;
        WKWebViewConfiguration configuration = new WKWebViewConfiguration();
        var webView = new WKWebView(frame, configuration);

        return webView;
    }

    private static void MapMessageId(MessageViewHandler handler, IMessageView entry)
    {
        if (entry.MessageId != null)
        {
            handler.LoadMessage(entry.MessageId);
        }
    }

    protected void LoadMessage(string messageId)
    {
        var message = UAMessageCenter.Shared.MessageList.Message(messageId);
        if (message != null)
        {
            LoadMessageBody(message);
        }

    }

    private void LoadMessageBody(UAInboxMessage message)
    {
        var request = new NSMutableUrlRequest(message.MessageBodyURL);
        UAMessageCenter.Shared.User.GetUserData((UAUserData userData) =>
        {
            if (userData == null)
            {
                return;
            }

            // TODO: Actually load the message

            //var auth = UAUtils.AuthHeaderString(userData.Username, userData.Password);

            //NSMutableDictionary dict = new NSMutableDictionary();
            //dict.Add(new NSString("Authorization"), new NSString(auth));
            //request.Headers = dict;

            //PlatformView.LoadRequest(request);

            VirtualView.OnLoadStarted(message.MessageID);
        });
    }
}


using AirshipDotNet.MessageCenter.Controls;
using Android.Runtime;
using Android.Webkit;
using Microsoft.Maui.Handlers;
using UrbanAirship;
using UrbanAirship.MessageCenter;
using UrbanAirship.MessageCenter.WebKit;
using WebView = Android.Webkit.WebView;

namespace AirshipDotNet.MessageCenter.Handlers;

/// <summary>
/// Handler responsible for displaying a single Message Center message via the platform MessageWebView.
/// </summary>
public partial class MessageViewHandler : ViewHandler<IMessageView, MessageWebView>
{
    private UrbanAirship.MessageCenter.Message? message;
    private ICancelable? fetchMessageRequest;

    public static PropertyMapper<IMessageView, MessageViewHandler> MessageViewMapper = new(ViewHandler.ViewMapper)
    {
        [nameof(IMessageView.MessageId)] = MapMessageId
    };

    public MessageViewHandler() : base(MessageViewMapper)
    {
    }

    protected override MessageWebView CreatePlatformView()
    {
        var webView = new MessageWebView(Context);
        webView.SetWebViewClient(new WebViewClient(this));
        return webView;
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

        fetchMessageRequest?.Cancel();

        message = MessageCenterClass.Shared().Inbox.GetMessage(messageId);
        if (message == null)
        {
            fetchMessageRequest = MessageCenterClass.Shared().Inbox.FetchMessages(success => {
                message = MessageCenterClass.Shared().Inbox.GetMessage(messageId);
                if (!success)
                {
                    VirtualView.OnLoadFailed(messageId, true, MessageFailureStatus.FetchFailed);
                    return;
                }
                else if (message == null || message.IsExpired)
                { 
                    VirtualView.OnLoadFailed(messageId, false, MessageFailureStatus.Unavailable);
                    return;
                }

                PlatformView.LoadMessage(message);

                VirtualView.OnLoadStarted(messageId);
            });
        }
        else
        {
            if (message.IsExpired)
            {
                VirtualView.OnLoadFailed(messageId, false, MessageFailureStatus.Unavailable);
                return;
            }

            PlatformView.LoadMessage(message);

            VirtualView.OnLoadStarted(messageId);
        }
    }

    private class WebViewClient : MessageWebViewClient
    {
        private MessageViewHandler handler;
        private bool error = false;

        public WebViewClient(MessageViewHandler handler)
        {
            this.handler = handler;
        }

        public override void OnPageFinished(WebView? view, string? url)
        {
            base.OnPageFinished(view, url);

            if (handler.message == null) return;

            if (error)
            {
                handler.VirtualView.OnLoadFailed(handler.message.MessageId, false, MessageFailureStatus.LoadFailed);
                return;
            }

            handler.message.MarkRead();

            handler.VirtualView.OnLoadFinished(handler.message.MessageId);
        }

        [Obsolete]
        public override void OnReceivedError(WebView? view, [GeneratedEnum] ClientError errorCode, string? description, string? failingUrl)
        {
            base.OnReceivedError(view, errorCode, description, failingUrl);

            if (handler.message != null && failingUrl != null && failingUrl.Equals(handler.message.MessageBodyUrl))
            {
                error = true;
            }
        }

        protected override void OnClose(WebView webView)
        {
            base.OnClose(webView);
            if (handler.message != null)
            {
                handler.VirtualView.OnClosed(handler.message.MessageId);
            }
        }
    }
}


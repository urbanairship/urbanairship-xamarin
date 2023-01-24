using Android.Runtime;
using Android.Webkit;
using Microsoft.Maui.Handlers;
using UrbanAirship;
using UrbanAirship.MessageCenter;
using UrbanAirship.MessageCenter.WebKit;
using WebView = Android.Webkit.WebView;

namespace AirshipDotNet.MessageCenter;

public partial class MessageViewHandler : ViewHandler<IMessageView, MessageWebView>
{
    private MessageWebView? webView;
    private WebViewClient? client;
    private UrbanAirship.MessageCenter.Message? message;
    private ICancelable? fetchMessageRequest;

    protected override MessageWebView CreatePlatformView()
    {
        this.webView = new(Context);
        this.client = new(this);

        webView.SetWebViewClient(client);
        return webView;
    }

    private static void MapMessageId(MessageViewHandler handler, IMessageView entry)
    {
        var message = MessageCenterClass.Shared().Inbox.GetMessage(entry.MessageId);
        if (message != null)
        {
            handler.PlatformView?.LoadMessage(message);
        }
    }

    private static void UpdateStatus(MessageViewHandler handler, IMessageView entry, object? args)
    {
        Console.WriteLine("MessageViewHandler status: " + entry.MessageId);
    }

    public void LoadMessage(string messageId)
    {
        fetchMessageRequest?.Cancel();

        message = null;
        StartLoading(messageId);
    }

    private void StartLoading(string messageId)
    {
        this.message = MessageCenterClass.Shared().Inbox.GetMessage(messageId);
        if (message == null)
        {
            fetchMessageRequest = MessageCenterClass.Shared().Inbox.FetchMessages(success => {
                message = MessageCenterClass.Shared().Inbox.GetMessage(messageId);
                if (!success)
                {
                    //messagePage.OnRendererLoadFailed(messageId, true, MessageFailureStatus.FetchFailed);
                    return;
                }
                else if (message == null || message.IsExpired)
                {
                    //messagePage.OnRendererLoadFailed(messageId, false, MessageFailureStatus.Unavailable);
                    return;
                }

                webView?.LoadMessage(message);
                //messagePage.OnRendererLoadStarted(messageId);
            });
        }
        else
        {
            if (message.IsExpired)
            {
                //messagePage?.OnRendererLoadFailed(messageId, false, MessageFailureStatus.Unavailable);
                return;
            }

            webView?.LoadMessage(message);
            //messagePage?.OnRendererLoadStarted(messageId);
        }
    }

    //Action<bool> OnFinished(bool success)
    //{
    //    message = MessageCenterClass.Shared().Inbox.GetMessage(messageId);
    //    if (!success)
    //    {
    //        //messagePage?.OnRendererLoadFailed(messageId, true, MessageFailureStatus.FetchFailed);
    //        return;
    //    }
    //    else if (message == null || message.IsExpired)
    //    {
    //        //messagePage?.OnRendererLoadFailed(messageId, false, MessageFailureStatus.Unavailable);
    //        return;
    //    }

    //    webView?.LoadMessage(message);
    //    //messagePage?.OnRendererLoadStarted(messageId);
    //}

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

            if (handler.message == null)
            {
                return;
            }

            if (error)
            {
                //renderer.messagePage?.OnRendererLoadFailed(renderer.message.MessageId, false, MessageFailureStatus.LoadFailed);
                return;
            }

            handler.message.MarkRead();

            //renderer.message.MarkRead();
            //renderer.messagePage?.OnRendererLoaded(renderer.message.MessageId);
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
            //if (renderer.message != null)
            //{
            //    renderer.messagePage?.OnRendererClosed(renderer.message.MessageId);
            //}
        }
    }
}


using System.ComponentModel;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using UrbanAirship.NETStandard.MessageCenter;
using UrbanAirship.RichPush;
using UrbanAirship.Widget;
using Xamarin.Forms.Platform.Android;

namespace UrbanAirship.NETStandard.Android
{
    public class MessagePageRenderer : PageRenderer, RichPushInbox.IFetchMessagesCallback
    {
        private class MessageWebViewClient : UAWebViewClient
        {
            private MessagePageRenderer renderer;
            private bool error = false;

            public MessageWebViewClient(MessagePageRenderer messagePageRenderer)
            {
                renderer = messagePageRenderer;
            }

            public override void OnPageFinished(WebView view, string url)
            {
                base.OnPageFinished(view, url);

                if (renderer.message == null)
                {
                    return;
                }

                if (error)
                {
                    renderer.messagePage.OnRendererLoadFailed(renderer.message.MessageId, false, MessageFailureStatus.LoadFailed);
                    return;
                }

                renderer.message.MarkRead();
                renderer.messagePage.OnRendererLoaded(renderer.message.MessageId);
            }

#pragma warning disable CS0672 // Member overrides obsolete member
            public override void OnReceivedError(WebView view, [GeneratedEnum] ClientError errorCode, string description, string failingUrl)
#pragma warning restore CS0672 // Member overrides obsolete member
            {
#pragma warning disable CS0618 // Type or member is obsolete
                base.OnReceivedError(view, errorCode, description, failingUrl);
#pragma warning restore CS0618 // Type or member is obsolete

                if (renderer.message != null && failingUrl != null && failingUrl.Equals(renderer.message.MessageBodyUrl))
                {
                    error = true;
                }
            }

            public override void OnClose(WebView webView)
            {
                base.OnClose(webView);
                if (renderer.message != null)
                {
                    renderer.messagePage.OnRendererClosed(renderer.message.MessageId);
                }
            }
        }

        private RichPushMessage message;
        private ICancelable fetchMessageRequest;
        private UAWebView webView;
        private MessagePage messagePage;
        private WebViewClient webViewClient;
        private string messageId;
        private FrameLayout nativeView;

        public MessagePageRenderer(Context context) : base(context)
        {
            webView = new UAWebView(Context);
            webViewClient = new MessageWebViewClient(this);

            var fl = new FrameLayout(Context);
            fl.LayoutParameters = new LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);

            fl.AddView(webView);

            webView.SetWebViewClient(webViewClient);
            AddView(fl);

            nativeView = fl;
        }

        public void LoadMessage(string messageId)
        {
            if (fetchMessageRequest != null)
            {
                fetchMessageRequest.Cancel();
            }

            message = null;
            StartLoading(messageId);
        }

        private void StartLoading(string messageId)
        {
            this.message = UAirship.Shared().Inbox.GetMessage(messageId);
            if (message == null)
            {
                fetchMessageRequest = UAirship.Shared().Inbox.FetchMessages(this);
            }
            else
            {
                if (message.IsExpired)
                {
                    messagePage.OnRendererLoadFailed(messageId, false, MessageFailureStatus.Unavailable);
                    return;
                }

                webView.LoadRichPushMessage(message);
                messagePage.OnRendererLoadStarted(messageId);
            }
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Page> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }

            messagePage = e.NewElement as MessagePage;
            messageId = messagePage.MessageId;

            if (messageId != null)
            {
                LoadMessage(messageId);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals(MessagePage.MessageIdProperty.PropertyName))
            {
                messageId = messagePage.MessageId;
                if (messageId != null)
                {
                    LoadMessage(messageId);
                }
            }
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);

            if (nativeView != null)
            {
                var msw = MeasureSpec.MakeMeasureSpec(r - l, MeasureSpecMode.Exactly);
                var msh = MeasureSpec.MakeMeasureSpec(b - t, MeasureSpecMode.Exactly);

                nativeView.Measure(msw, msh);
                nativeView.Layout(0, 0, r - l, b - t);
            }
        }

        void RichPushInbox.IFetchMessagesCallback.OnFinished(bool success)
        {
            message = UAirship.Shared().Inbox.GetMessage(messageId);
            if (!success)
            {
                messagePage.OnRendererLoadFailed(messageId, true, MessageFailureStatus.FetchFailed);
                return;
            }
            else if (message == null || message.IsExpired)
            {
                messagePage.OnRendererLoadFailed(messageId, false, MessageFailureStatus.Unavailable);
                return;
            }

            webView.LoadRichPushMessage(message);
            messagePage.OnRendererLoadStarted(messageId);
        }
    }
}

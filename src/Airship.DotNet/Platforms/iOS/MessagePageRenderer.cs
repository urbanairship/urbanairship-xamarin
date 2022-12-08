/*
 Copyright Airship and Contributors
*/

using CoreGraphics;
using System;
using System.ComponentModel;
using Foundation;
using UIKit;
using UrbanAirship.DotNet.MessageCenter;
using WebKit;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Embedding;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
using Microsoft.Maui.Controls.Platform;

namespace UrbanAirship.DotNet.iOS
{
    // TODO(maui): update to handler/mapper
#pragma warning disable CS0618 // Type or member is obsolete
    public class MessagePageRenderer : PageRenderer, IUANavigationDelegate, IUANativeBridgeDelegate
#pragma warning restore CS0618 // Type or member is obsolete
    {
        private WKWebView webView;
        private UANativeBridge nativeBridge;
        private MessagePage messagePage;
        private string messageId;

        public MessagePageRenderer()
        {
            CGRect frame = UIScreen.MainScreen.Bounds;
            WKWebViewConfiguration configuration = new WKWebViewConfiguration();
            webView = new WKWebView(frame, configuration);
            webView.TranslatesAutoresizingMaskIntoConstraints = false;
            nativeBridge = new UANativeBridge();
            webView.NavigationDelegate = nativeBridge;
            nativeBridge.ForwardNavigationDelegate = this;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            webView.Frame = UIScreen.MainScreen.Bounds;
            webView.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
            webView.TranslatesAutoresizingMaskIntoConstraints = true;

            View.AddSubview(webView);
        }

        public void LoadMessage(string messageId)
        {
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
                        messagePage.OnRendererLoadFailed(messageId, false, MessageFailureStatus.Unavailable);
                    }
                }, () =>
                {
                    messagePage.OnRendererLoadFailed(messageId, false, MessageFailureStatus.FetchFailed);
                });
            }
        }

        public void Close()
        {
            messagePage.OnRendererClosed(messageId);
        }

        [Export("webView:decidePolicyForNavigationResponse:decisionHandler:")]
        public void DecidePolicy(WKWebView webView, WKNavigationResponse navigationResponse, Action<WKNavigationResponsePolicy> decisionHandler)
        {
            var response = navigationResponse.Response as NSHttpUrlResponse;
            if (response.StatusCode >= 400 && response.StatusCode <= 599)
            {
                decisionHandler(WKNavigationResponsePolicy.Cancel);
                if (response.StatusCode == 410)
                {
                    messagePage.OnRendererLoadFailed(messageId, false, MessageFailureStatus.Unavailable);
                }
                else
                {
                    messagePage.OnRendererLoadFailed(messageId, true, MessageFailureStatus.LoadFailed);
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
            messagePage.OnRendererLoaded(messageId);
        }

        [Export("webView:didFailNavigation:withError:")]
        public void DidFailNavigation(WKWebView webView, WKNavigation navigation, NSError error)
        {
            messagePage.OnRendererLoadFailed(messageId, true, MessageFailureStatus.LoadFailed);
        }

        [Export("webView:didFailProvisionalNavigation:withError:")]
        public void DidFailProvisionalNavigation(WKWebView webView, WKNavigation navigation, NSError error)
        {
            webView.NavigationDelegate?.DidFailNavigation(webView, navigation, error);
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }

            messagePage = e.NewElement as MessagePage;
            messageId = messagePage.MessageId;
            messagePage.PropertyChanged += OnElementPropertyChanged;

            if (messageId != null)
            {
                LoadMessage(messageId);
            }
        }

        private void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
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

        private void LoadMessageBody(UAInboxMessage message)
        {
            var request = new NSMutableUrlRequest(message.MessageBodyURL);
            UAMessageCenter.Shared.User.GetUserData((UAUserData userData) =>
            {
                if (userData == null)
                {
                    return;
                }

                var auth = UAUtils.AuthHeaderString(userData.Username, userData.Password);

                NSMutableDictionary dict = new NSMutableDictionary();
                dict.Add(new NSString("Authorization"), new NSString(auth));
                request.Headers = dict;

                webView.LoadRequest(request);

                messagePage.OnRendererLoadStarted(messageId);
            });
        }
    }
}

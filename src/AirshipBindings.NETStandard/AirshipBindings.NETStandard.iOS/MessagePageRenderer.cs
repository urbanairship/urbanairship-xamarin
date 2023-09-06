/*
 Copyright Airship and Contributors
*/

using CoreGraphics;
using System;
using System.ComponentModel;
using Foundation;
using UIKit;
using UrbanAirship.NETStandard.MessageCenter;
using WebKit;
using Xamarin.Forms.Platform.iOS;

namespace UrbanAirship.NETStandard.iOS
{
    [Preserve(AllMembers = true)]
    public class MessagePageRenderer : PageRenderer, IUANavigationDelegate, IUANativeBridgeDelegate
    {
        private WKWebView webView;
        private UANativeBridge nativeBridge;
        private UAMessageCenterNativeBridgeExtension nativeBridgeExtension;
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
            nativeBridge.NativeBridgeDelegate = this;

            UAMessageCenter.Shared.Inbox.GetUser(user =>
            {
                UAMessageCenter.Shared.Inbox.MessageForID(messageId, message =>
                {
                    nativeBridgeExtension = new UAMessageCenterNativeBridgeExtension(message, user);
                    nativeBridge.NativeBridgeExtensionDelegate = nativeBridgeExtension;
                });
            });
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
            UAMessageCenter.Shared.Inbox.MessageForID(messageId, message =>
            {
                if (message != null)
                {
                    LoadMessageBody(message);
                }
                else
                {
                    UAMessageCenter.Shared.Inbox.RefreshMessages(result =>
                    {
                        if (result == true)
                        {

                            UAMessageCenter.Shared.Inbox.MessageForID(messageId, newMessage =>
                            {
                                if (newMessage != null && !newMessage.IsExpired)
                                {
                                    LoadMessageBody(newMessage);
                                }
                                else
                                {
                                    messagePage.OnRendererLoadFailed(messageId, false, MessageFailureStatus.Unavailable);
                                }
                            });
                        }
                        else
                        {
                            messagePage.OnRendererLoadFailed(messageId, false, MessageFailureStatus.FetchFailed);
                        }

                    });
                }
            });
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

        private void LoadMessageBody(UAMessageCenterMessage message)
        {
            var request = new NSMutableUrlRequest(message.BodyURL);
            UAMessageCenter.Shared.Inbox.GetUser(user =>
            {
                if (user == null)
                {
                    return;
                }

                var auth = UAUtils.AuthHeaderString(user.Username, user.Password);

                NSMutableDictionary dict = new NSMutableDictionary();
                dict.Add(new NSString("Authorization"), new NSString(auth));
                request.Headers = dict;

                webView.LoadRequest(request);

                messagePage.OnRendererLoadStarted(messageId);
            });
        }
    }
}

using Microsoft.Maui.Handlers;
using WebKit;
using CoreGraphics;
using UIKit;

using AirshipDotNet.MessageCenter;
using Foundation;
using UrbanAirship;

namespace AirshipDotNet.MessageCenter;

public partial class MessageViewHandler : ViewHandler<IMessageView, WKWebView>//, IUANavigationDelegate
{
  
    private static void MapMessageId(MessageViewHandler handler, IMessageView entry)
    {
        if (entry.MessageId == null)
        {
            return;
        }

        var message = UAMessageCenter.Shared.MessageList.Message(entry.MessageId);
        if (message != null)
        {
            //handler.PlatformView?.LoadRequest(message);
        }
    }

    protected override WKWebView CreatePlatformView()
    {
        CGRect frame = UIScreen.MainScreen.Bounds;
        WKWebViewConfiguration configuration = new WKWebViewConfiguration();
        var webView = new WKWebView(frame, configuration);

        return webView;
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

            //var auth = UAUtils.AuthHeaderString(userData.Username, userData.Password);

            //NSMutableDictionary dict = new NSMutableDictionary();
            //dict.Add(new NSString("Authorization"), new NSString(auth));
            //request.Headers = dict;

            //webView.LoadRequest(request);

            //messagePage.OnRendererLoadStarted(messageId);
        });
    }
}


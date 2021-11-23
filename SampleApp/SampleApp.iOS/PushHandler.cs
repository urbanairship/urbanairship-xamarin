/*
 Copyright Airship and Contributors
*/

using System;
using UserNotifications;
using UIKit;
using Foundation;

using UrbanAirship;

namespace Sample
{
    public class PushHandler : UAPushNotificationDelegate
    {
        public override void ReceivedBackgroundNotification(NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
        {
            Console.WriteLine("The application received a background notification");

            completionHandler(UIBackgroundFetchResult.NoData);
        }

        public override void ReceivedForegroundNotification(NSDictionary userInfo, Action completionHandler)
        {

            // Application received a foreground notification
            Console.WriteLine("The application received a foreground notification");

            // iOS 10 - let foreground presentations options handle it
            if (NSProcessInfo.ProcessInfo.IsOperatingSystemAtLeastVersion(new NSOperatingSystemVersion(10, 0, 0)))
            {
                completionHandler();
                return;
            }

            if (!userInfo.ContainsKey(new NSString("aps")))
            {
                return;
            }

            NSDictionary apsDict = (NSDictionary)userInfo.ValueForKey(new NSString("aps"));

            if (!apsDict.ContainsKey(new NSString("alert")))
            {
                return;
            }
            NSDictionary alert = (NSDictionary)apsDict.ValueForKey(new NSString("alert"));

            NSString title = (NSString)alert.ValueForKey(new NSString("title"));
            NSString body = (NSString)alert.ValueForKey(new NSString("body"));

            UIAlertController alertController = UIAlertController.Create(title: title,
                                                                         message: body,
                                                                         preferredStyle: UIAlertControllerStyle.Alert);

            UIAlertAction okAction = UIAlertAction.Create(title: "OK", style: UIAlertActionStyle.Default, handler: (UIAlertAction action) =>
            {
            });

            alertController.AddAction(okAction);

            UIViewController topController = UIApplication.SharedApplication.KeyWindow.RootViewController;

            alertController.PopoverPresentationController.SourceView = topController.View;

            topController.PresentViewController(alertController, true, null);

            completionHandler();
        }

        public override void ReceivedNotificationResponse(UNNotificationResponse notificationResponse, Action completionHandler)
        {
            Console.WriteLine("The user selected the following action identifier::{0}", notificationResponse.ActionIdentifier);

            UNNotificationContent notificationContent = notificationResponse.Notification.Request.Content;

            String message = String.Format("Action Identifier:{0}", notificationResponse.ActionIdentifier);
            String alertBody = notificationContent.Body;

            if (alertBody.Length > 0)
            {
                message += String.Format("\nAlert Body:\n{0}", alertBody);
            }

            if (notificationResponse is UNTextInputNotificationResponse)
            {
                String responseText = ((UNTextInputNotificationResponse) notificationResponse).UserText;

                if (responseText != null)
                {
                    message += String.Format("\nResponse:\n{0}", responseText);
                }
            }

 

            UIAlertController alertController = UIAlertController.Create(title: notificationContent.Title,
                                                                         message: alertBody,
                                                                         preferredStyle: UIAlertControllerStyle.Alert);

            UIAlertAction okAction = UIAlertAction.Create(title: "OK", style: UIAlertActionStyle.Default, handler: null);
            alertController.AddAction(okAction);

            UIViewController topController = UIApplication.SharedApplication.KeyWindow.RootViewController;
            if (alertController.PopoverPresentationController != null)
            {
                alertController.PopoverPresentationController.SourceView = topController.View;
            }

            topController.PresentViewController(alertController, true, null);

            completionHandler();
        }

        public override UNNotificationPresentationOptions ExtendPresentationOptions(UNNotificationPresentationOptions options, UNNotification notification)
        {
            return options | UNNotificationPresentationOptions.Alert | UNNotificationPresentationOptions.Sound;
        }
    }
}

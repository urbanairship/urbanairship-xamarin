using System;
using UrbanAirship;
using UserNotifications;
using UIKit;
using Foundation;
using System.IO.Compression;
using CoreSpotlight;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sample
{
	public class PushHandler : UAPushNotificationDelegate
	{
		public override void ReceivedBackgroundNotification(UANotificationContent notificationContent, Action<UIBackgroundFetchResult> completionHandler) { 
			Console.WriteLine("The application received a background notification");

			completionHandler(UIBackgroundFetchResult.NoData);
		}

		public override void ReceivedForegroundNotification(UANotificationContent notificationContent, Action completionHandler)
		{

			// Application received a foreground notification
			Console.WriteLine("The application received a foreground notification");

			// iOS 10 - let foreground presentations options handle it
			if (NSProcessInfo.ProcessInfo.IsOperatingSystemAtLeastVersion(new NSOperatingSystemVersion(10, 0, 0)))
			{
				completionHandler();
				return;
			}

			UIAlertController alertController = UIAlertController.Create(title: notificationContent.AlertTitle,
			                                                             message: notificationContent.AlertBody,
			                                                             preferredStyle: UIAlertControllerStyle.Alert);

			UIAlertAction okAction = UIAlertAction.Create(title: "OK", style: UIAlertActionStyle.Default, handler: (UIAlertAction action) =>
			{
				NSString messageID = UAInboxUtils.InboxMessageIDFromNotification(notificationContent.NotificationInfo);	

				if (messageID != null) {
					UAActionRunner.RunAction("open_mc_action", messageID, UASituation.ManualInvocation);
				}
			});

			alertController.AddAction(okAction);

			UIViewController topController = UIApplication.SharedApplication.KeyWindow.RootViewController;

			alertController.PopoverPresentationController.SourceView = topController.View;

			topController.PresentViewController(alertController, true, null);

			completionHandler();
		}

		public override void ReceivedNotificationResponse(UANotificationResponse notificationResponse, Action completionHandler)
		{
			Console.WriteLine("The user selected the following action identifier::{0}", notificationResponse.ActionIdentifier);

			UANotificationContent notificationContent = notificationResponse.NotificationContent;

			String message = String.Format("Action Identifier:{0}", notificationResponse.ActionIdentifier);
			String alertBody = notificationContent.AlertBody;

			if (alertBody.Length > 0) 
			{
				message += String.Format("\nAlert Body:\n{0}", alertBody); 
			}

			String responseText = notificationResponse.ResponseText;

			if (responseText != null) {
				message += String.Format("\nResponse:\n{0}", responseText);
			}

			UIAlertController alertController = UIAlertController.Create(title: notificationContent.AlertTitle,
																		 message: alertBody,
																		 preferredStyle: UIAlertControllerStyle.Alert);

			UIAlertAction okAction = UIAlertAction.Create(title: "OK", style: UIAlertActionStyle.Default, handler: null);
			alertController.AddAction(okAction);

			UIViewController topController = UIApplication.SharedApplication.KeyWindow.RootViewController;
            if (alertController.PopoverPresentationController != null) {
                alertController.PopoverPresentationController.SourceView = topController.View;
            }

			topController.PresentViewController(alertController, true, null);

			completionHandler();
		}

		public override UNNotificationPresentationOptions PresentationOptions(UNNotification notification)
		{
			return UNNotificationPresentationOptions.Alert | UNNotificationPresentationOptions.Sound;
		}
	}
}

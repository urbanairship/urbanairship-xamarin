using System;
using UrbanAirship;
using UserNotifications;
using UIKit;
using Foundation;
using System.IO.Compression;
using CoreSpotlight;
using Mono.Security.Interface;
using System.Linq;

namespace Sample
{
	public class PushHandler 
	{
		void ReceivedBackgroundNotification(UANotificationContent notificationContent, Action<UIBackgroundFetchResult> completionHandler) { 
			Console.WriteLine("The application received a background notification");

			completionHandler(UIBackgroundFetchResult.NoData);
		}

		void ReceivedForegroundNotification(UANotificationContent notificationContent, Action completionHandler)
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

				// If we have a message ID run the display inbox action to fetch and display the message.
				//NSString *messageId = [UAInboxUtils inboxMessageIDFromNotification: notificationContent.notificationInfo];
				//	if (messageId)
				//	{
				//	[UAActionRunner runActionWithName: kUADisplayInboxActionDefaultRegistryName
				//								value: messageId
				//							situation: UASituationManualInvocation];
				//}
				// TODO get message ID (expose UAInboxUtil method)
				//String messageID = UAInboxUtil

			});

			alertController.AddAction(okAction);

			UIViewController topController = UIApplication.SharedApplication.KeyWindow.RootViewController;

			alertController.PopoverPresentationController.SourceView = topController.View;

			topController.PresentViewController(alertController, true, null);

			completionHandler();
		}

		void ReceivedNotificationResponse(UANotificationResponse notificationResponse, Action completionHandler)
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
			alertController.PopoverPresentationController.SourceView = topController.View;

			topController.PresentViewController(alertController, true, null);

			completionHandler();
		}

		UNNotificationPresentationOptions PresentationOptions(UNNotification notification)
		{
			return UNNotificationPresentationOptions.Alert | UNNotificationPresentationOptions.Sound;
		}
	}
}

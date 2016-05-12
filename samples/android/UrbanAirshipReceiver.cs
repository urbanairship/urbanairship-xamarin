/*
 Copyright 2016 Urban Airship and Contributors
*/

using System;
using Android.Content;
using Android.App;
using Android.Util;
using UrbanAirship.Push;
using UrbanAirship;
using Android.Support.V4.Content;

namespace Sample
{
	[BroadcastReceiver(Exported = false)]
	[IntentFilter (new string[]{"com.urbanairship.push.CHANNEL_UPDATED", "com.urbanairship.push.OPENED", "com.urbanairship.push.DISMISSED", "com.urbanairship.push.RECEIVED"}, 
		Categories = new string[]{"@PACKAGE_NAME@"})]
	public class UrbanAirshipReceiver : AirshipReceiver
	{

		public const string ACTION_CHANNEL_UPDATED = "channel_updated";

		private const string TAG = "UrbanAirshipReceiver";

		protected override void OnChannelRegistrationSucceeded(Context context, String channelId)
		{
			Log.Info (TAG, "Channel registration updated. Channel Id:" + channelId);

			Intent intent = new Intent (ACTION_CHANNEL_UPDATED);
			LocalBroadcastManager.GetInstance (context).SendBroadcast (intent);
		}

		protected override void OnChannelRegistrationFailed(Context context)
		{
			Log.Info (TAG, "Channel registration failed.");
		}

		protected override void OnPushReceived(Context context, PushMessage message, bool notificationPosted)
		{
			Log.Info (TAG, "Received push message. Alert: " + message.Alert + ". Notification posted: " + notificationPosted);
		}

		protected override void OnNotificationPosted(Context context, AirshipReceiver.NotificationInfo notificationInfo)
		{
			Log.Info (TAG, "Notification posted. Alert: " + notificationInfo.Message.Alert + ". Notification ID: " + notificationInfo.NotificationId);
		}

		protected override bool OnNotificationOpened(Context context, AirshipReceiver.NotificationInfo notificationInfo)
		{
			Log.Info (TAG, "Notification opened. Alert: " + notificationInfo.Message.Alert + ". Notification ID: " + notificationInfo.NotificationId);

			// Return false here to allow Urban Airship to auto launch the launcher
			// activity for foreground notification action buttons
			return false;
		}

		protected override bool OnNotificationOpened(Context context, AirshipReceiver.NotificationInfo notificationInfo, AirshipReceiver.ActionButtonInfo actionButtonInfo)
		{
			Log.Info (TAG, "User clicked notification button. Button ID: " + actionButtonInfo.ButtonId + " Alert: " + notificationInfo.Message.Alert);

			// Return false here to allow Urban Airship to auto launch the launcher
			// activity for foreground notification action buttons
			return false;
		}

		protected override void OnNotificationDismissed(Context context, AirshipReceiver.NotificationInfo notificationInfo)
		{
			Log.Info (TAG, "Notification dismissed. Alert: " + notificationInfo.Message.Alert + ". Notification ID: " + notificationInfo.NotificationId);
		}
	}
}


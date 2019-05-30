/*
 Copyright 2017 Urban Airship and Contributors
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
	public class UrbanAirshipListener : Java.Lang.Object, IRegistrationListener, IPushListener, INotificationListener
    {
		public const string ACTION_CHANNEL_UPDATED = "channel_updated";

		private const string TAG = "UrbanAirshipReceiver";

        public void OnChannelCreated(String channelId)
		{
			Log.Info (TAG, "Channel created:" + channelId);

			Intent intent = new Intent (ACTION_CHANNEL_UPDATED);
			LocalBroadcastManager.GetInstance(Application.Context).SendBroadcast (intent);
		}

		public void OnChannelUpdated(String channelId)
		{
			Log.Info(TAG, "Channel updated:" + channelId);

			Intent intent = new Intent(ACTION_CHANNEL_UPDATED);
			LocalBroadcastManager.GetInstance(Application.Context).SendBroadcast(intent);
		}

		public void OnPushTokenUpdated(String token)
		{
			Log.Info (TAG, "Push token updated:" + token);
		}

        public void OnPushReceived(PushMessage message, bool notificationPosted)
		{
			Log.Info (TAG, "Received push message. Alert: " + message.Alert + ". Notification posted: " + notificationPosted);
		}

        public void OnNotificationPosted(NotificationInfo notificationInfo)
		{
			Log.Info (TAG, "Notification posted. Alert: " + notificationInfo.Message.Alert + ". Notification ID: " + notificationInfo.NotificationId);
		}

        public bool OnNotificationOpened(NotificationInfo notificationInfo)
		{
			Log.Info (TAG, "Notification opened. Alert: " + notificationInfo.Message.Alert + ". Notification ID: " + notificationInfo.NotificationId);

			// Return false here to allow Urban Airship to auto launch the launcher
			// activity for foreground notification action buttons
			return false;
		}

        public bool OnNotificationForegroundAction(NotificationInfo notificationInfo, NotificationActionButtonInfo actionButtonInfo)
		{
			Log.Info (TAG, "User clicked notification button in the foreground. Button ID: " + actionButtonInfo.ButtonId + " Alert: " + notificationInfo.Message.Alert);

			// Return false here to allow Urban Airship to auto launch the launcher
			// activity for foreground notification action buttons
			return false;
		}

        public void OnNotificationBackgroundAction(NotificationInfo notificationInfo, NotificationActionButtonInfo actionButtonInfo)
        {
            Log.Info(TAG, "User clicked notification button in the background. Button ID: " + actionButtonInfo.ButtonId + " Alert: " + notificationInfo.Message.Alert);
        }

        public void OnNotificationDismissed(NotificationInfo notificationInfo)
		{
			Log.Info (TAG, "Notification dismissed. Alert: " + notificationInfo.Message.Alert + ". Notification ID: " + notificationInfo.NotificationId);
		}
	}
}


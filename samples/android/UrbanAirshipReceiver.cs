/*
 Copyright 2016 Urban Airship and Contributors
*/

using System;
using Android.Content;
using Android.App;
using Android.Util;
using UrbanAirship.Push;
using Android.Support.V4.Content;

namespace Sample
{
	[BroadcastReceiver(Exported = false)]
	[IntentFilter (new string[]{"com.urbanairship.push.CHANNEL_UPDATED", "com.urbanairship.push.OPENED", "com.urbanairship.push.DISMISSED", "com.urbanairship.push.RECEIVED"}, 
		Categories = new string[]{"@PACKAGE_NAME@"})]
	public class UrbanAirshipReceiver : BaseIntentReceiver
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

		protected override void OnPushReceived(Context context, PushMessage message, int notificationId)
		{
			Log.Info (TAG, "Received push notification. Alert: " + message.Alert + ". Notification ID: " + notificationId);
		}

		protected override void OnBackgroundPushReceived(Context context, PushMessage message)
		{
			Log.Info (TAG, "Received background push message: " + message);
		}

		protected override bool OnNotificationOpened(Context context, PushMessage message, int notificationId)
		{
			Log.Info (TAG, "User clicked notification. Alert: " + message.Alert);
			return false;
		}

		protected override bool OnNotificationActionOpened(Context context, PushMessage message, int notificationId, String buttonId, bool isForeground)
		{
			Log.Info (TAG, "User clicked notification button. Button ID: " + buttonId + " Alert: " + message.Alert);
			return false;
		}

		protected override void OnNotificationDismissed(Context context, PushMessage message, int notificationId)
		{
			Log.Info (TAG, "Notification dismissed. Alert: " + message.Alert + ". Notification ID: " + notificationId);
		}
	}
}


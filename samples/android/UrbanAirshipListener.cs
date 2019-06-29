/*
 Copyright Airship and Contributors
*/

using System;
using Android.Content;
using Android.OS;
using Android.Util;

using UrbanAirship;
using UrbanAirship.Push;
using UrbanAirship.MessageCenter;

namespace Sample
{
    public class UrbanAirshipListener : Java.Lang.Object, IRegistrationListener, IPushListener, INotificationListener, MessageCenterClass.IOnShowMessageCenterListener
    {
        private const string TAG = "UrbanAirshipReceiver";

        public void OnChannelCreated(String channelId)
        {
            Log.Info(TAG, "Channel created:" + channelId);
        }

        public void OnChannelUpdated(String channelId)
        {
            Log.Info(TAG, "Channel updated:" + channelId);
        }

        public void OnPushTokenUpdated(String token)
        {
            Log.Info(TAG, "Push token updated:" + token);
        }

        public void OnPushReceived(PushMessage message, bool notificationPosted)
        {
            Log.Info(TAG, "Received push message. Alert: " + message.Alert + ". Notification posted: " + notificationPosted);
        }

        public void OnNotificationPosted(NotificationInfo notificationInfo)
        {
            Log.Info(TAG, "Notification posted. Alert: " + notificationInfo.Message.Alert + ". Notification ID: " + notificationInfo.NotificationId);
        }

        public bool OnNotificationOpened(NotificationInfo notificationInfo)
        {
            Log.Info(TAG, "Notification opened. Alert: " + notificationInfo.Message.Alert + ". Notification ID: " + notificationInfo.NotificationId);

            // Return false here to allow Airship to auto launch the launcher
            // activity for foreground notification action buttons
            return false;
        }

        public bool OnNotificationForegroundAction(NotificationInfo notificationInfo, NotificationActionButtonInfo actionButtonInfo)
        {
            Log.Info(TAG, "User clicked notification button in the foreground. Button ID: " + actionButtonInfo.ButtonId + " Alert: " + notificationInfo.Message.Alert);

            // Return false here to allow Airship to auto launch the launcher
            // activity for foreground notification action buttons
            return false;
        }

        public void OnNotificationBackgroundAction(NotificationInfo notificationInfo, NotificationActionButtonInfo actionButtonInfo)
        {
            Log.Info(TAG, "User clicked notification button in the background. Button ID: " + actionButtonInfo.ButtonId + " Alert: " + notificationInfo.Message.Alert);
        }

        public void OnNotificationDismissed(NotificationInfo notificationInfo)
        {
            Log.Info(TAG, "Notification dismissed. Alert: " + notificationInfo.Message.Alert + ". Notification ID: " + notificationInfo.NotificationId);
        }

        public bool OnShowMessageCenter(String messageId)
        {
            using (var h = new Handler(Looper.MainLooper))
                h.Post(() =>
                {
                    Log.Debug(TAG, "Navigate to messagecenter - message =" + messageId);

                    Context context = UAirship.ApplicationContext;

                    Intent intent = new Intent()
                        .SetPackage(context.PackageName)
                        .SetAction(MessageCenterClass.MessageDataScheme)
                        .SetClass(context, typeof(MainActivity));

                    if (messageId != null)
                    {
                        intent.SetData(Android.Net.Uri.FromParts(MessageCenterClass.MessageDataScheme, messageId, null));
                    }

                    context.StartActivity(intent);
                });

            return true;
        }
    }
}


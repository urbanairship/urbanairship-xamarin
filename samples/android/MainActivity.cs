/*
 Copyright 2016 Urban Airship and Contributors
*/

using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using UrbanAirship.Google;
using UrbanAirship;
using UrbanAirship.Push;

using Android.Support.V4.Content;

namespace Sample
{
	[Activity (MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private TextView channelID;
		private BroadcastReceiver channelIdUpdateReceiver;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			channelIdUpdateReceiver = new ChannelIdBroadcastReceiver ((Intent) => {
				UpdateChannelIdField ();
			});



			channelID = FindViewById<TextView> (Resource.Id.channel_id);
			channelID.Click += (sender, e) => {
				if (!string.IsNullOrEmpty (channelID.Text)) {
					// Using deprecated ClipboardManager to support Gingerbread (API 10)
					var clipboard = GetSystemService (Context.ClipboardService).JavaCast<ClipboardManager> ();
					clipboard.Text = channelID.Text;
					Toast.MakeText (this, "Channel ID copied to clipboard", ToastLength.Short).Show ();
				}
			};
		}

		protected override void OnResume ()
		{
			base.OnResume ();

			// Handle any Google Play services errors
			if (PlayServicesUtils.IsGooglePlayStoreAvailable (this)) {
				PlayServicesUtils.HandleAnyPlayServicesError (this);
			}

			// Use local broadcast manager to receive registration events to update the channel
			IntentFilter channelIdUpdateFilter;
			channelIdUpdateFilter = new IntentFilter ();
			channelIdUpdateFilter.AddAction (UrbanAirshipReceiver.ACTION_CHANNEL_UPDATED);
			LocalBroadcastManager.GetInstance (this).RegisterReceiver (channelIdUpdateReceiver, channelIdUpdateFilter);

			// Update the channel field
			UpdateChannelIdField ();
		}

		protected override void OnPause ()
		{
			base.OnPause ();
			LocalBroadcastManager.GetInstance (this).UnregisterReceiver (channelIdUpdateReceiver);
		}

		void UpdateChannelIdField ()
		{
			channelID.Text = UAirship.Shared ().PushManager.ChannelId ?? "";
		}

		internal class ChannelIdBroadcastReceiver : BroadcastReceiver
		{
			Action<Intent> callback;

			public ChannelIdBroadcastReceiver (Action<Intent> callback)
			{
				this.callback = callback;
			}

			public override void OnReceive (Context context, Intent intent)
			{
				if (callback != null) {
					callback.Invoke (intent);
				}
			}
		}
	}
}



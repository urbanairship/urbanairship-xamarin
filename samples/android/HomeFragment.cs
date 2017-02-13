/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;

using Android.Content;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Android.OS;

using UrbanAirship;
using UrbanAirship.Actions;
using UrbanAirship.Google;
using UrbanAirship.Push;

using Android.Support.V4.Content;


namespace Sample
{
	
	public class HomeFragment : Fragment
	{
		private TextView channelId;
		private Button shareButton;
		private Button copyButton;

		private ChannelIdBroadcastReceiver channelIdUpdateReceiver; 

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate(Resource.Layout.fragment_home, container, false);

			channelIdUpdateReceiver = new ChannelIdBroadcastReceiver((Intent) => { RefreshChannelId(); });

			channelId = (TextView)view.FindViewById(Resource.Id.channel_id);
			shareButton = (Button)view.FindViewById(Resource.Id.share_button);
			copyButton = (Button)view.FindViewById(Resource.Id.copy_button);

			copyButton.Click += (sender, e) =>
			{
				if (!string.IsNullOrEmpty(channelId.Text))
				{
					ActionRunRequest.CreateRequest(ClipboardAction.DefaultRegistryName)
									.SetValue(UAirship.Shared().PushManager.ChannelId)
					                .Run((args, result) => 
					{
						Toast.MakeText(Context, GetString(Resource.String.toast_channel_clipboard), ToastLength.Short).Show();
					});
				}
			};

			shareButton.Click += (sender, e) =>
			{
				if (!string.IsNullOrEmpty(channelId.Text))
				{
					ActionRunRequest.CreateRequest(ShareAction.DefaultRegistryName)
									.SetValue(UAirship.Shared().PushManager.ChannelId)
									.Run();
				}
			};

			return view;
		}

		public override void OnResume()
		{
			base.OnResume();

			// Register a local broadcast manager to list for ACTION_UPDATE_CHANNEL
			LocalBroadcastManager localBroadcastManager = LocalBroadcastManager.GetInstance(Context);

			// Use local broadcast manager to receive registration events to update the channel
			IntentFilter channelUpdateFilter = new IntentFilter();
			channelUpdateFilter.AddAction(UrbanAirshipReceiver.ACTION_CHANNEL_UPDATED);
			localBroadcastManager.RegisterReceiver(channelIdUpdateReceiver, channelUpdateFilter);

			RefreshChannelId();
		}

		public override void OnPause()
		{
			base.OnPause();
			LocalBroadcastManager localBroadcastManager = LocalBroadcastManager.GetInstance(Context);
			localBroadcastManager.UnregisterReceiver(channelIdUpdateReceiver);
		}

		void RefreshChannelId()
		{
			string channelIdString = UAirship.Shared().PushManager.ChannelId;

			if (!(channelIdString == channelId.Text))
			{
				channelId.Text = channelIdString;
			}

			if (String.IsNullOrEmpty(channelIdString))
			{
				copyButton.Enabled = false;
				shareButton.Enabled = false;
			}
			else
			{
				copyButton.Enabled = true;
				shareButton.Enabled = true;
			}
		}

		internal class ChannelIdBroadcastReceiver : BroadcastReceiver
		{
			Action<Intent> callback;

			public ChannelIdBroadcastReceiver(Action<Intent> callback)
			{
				this.callback = callback;
			}

			public override void OnReceive(Context context, Intent intent)
			{
				if (callback != null)
				{
					callback.Invoke(intent);
				}
			}
		}
	}
}

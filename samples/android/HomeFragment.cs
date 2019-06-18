/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;

using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Android.OS;

using UrbanAirship;
using UrbanAirship.Actions;
using UrbanAirship.Push;

namespace Sample
{
	
	public class HomeFragment : Fragment, IRegistrationListener
    {
		private TextView channelId;
		private Button shareButton;
		private Button copyButton;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate(Resource.Layout.fragment_home, container, false);

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

            UAirship.Shared().PushManager.AddRegistrationListener(this);

            RefreshChannelId();
		}

        public override void OnPause()
        {
            base.OnPause();

            UAirship.Shared().PushManager.RemoveRegistrationListener(this);
        }

        void RefreshChannelId()
        {
            RefreshChannelId(UAirship.Shared().PushManager.ChannelId);
        }

		void RefreshChannelId(String channelIdString)
		{
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

        public void OnChannelCreated(string channelId)
        {
            using (var h = new Handler(Looper.MainLooper))
                h.Post(() =>
                {
                    RefreshChannelId(channelId);
                });
        }

        public void OnChannelUpdated(string channelId)
        {
            using (var h = new Handler(Looper.MainLooper))
                h.Post(() =>
                {
                    RefreshChannelId(channelId);
                });
        }

        public void OnPushTokenUpdated(string token)
        {
        }
	}
}

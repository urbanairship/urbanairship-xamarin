/*
 Copyright Airship and Contributors
*/

using System;

using Android.Views;
using Android.Widget;
using Android.OS;

using AndroidX.Fragment.App;

using UrbanAirship;
using UrbanAirship.Actions;
using UrbanAirship.Channel;

namespace Sample
{

    public class HomeFragment : Fragment, IAirshipChannelListener
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
                                    .SetValue(UAirship.Shared().Channel.Id)
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
                                    .SetValue(UAirship.Shared().Channel.Id)
                                    .Run();
                }
            };

            return view;
        }

        public override void OnResume()
        {
            base.OnResume();

            UAirship.Shared().Channel.AddChannelListener(this);

            RefreshChannelId();
        }

        public override void OnPause()
        {
            base.OnPause();

            UAirship.Shared().Channel.RemoveChannelListener(this);
        }

        void RefreshChannelId()
        {
            RefreshChannelId(UAirship.Shared().Channel.Id);
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
    }
}

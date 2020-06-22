/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;
using Plugin.Clipboard;

using Xamarin.Forms;

using UrbanAirship.NETStandard;

namespace SampleApp
{
    public partial class HomeViewController : ContentPage
    {
        public HomeViewController()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            refreshView();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            if (!Airship.Instance.UserNotificationsEnabled)
            {
                Airship.Instance.UserNotificationsEnabled = true;
                //FIXME: Need to be improved
                do
                {
                } while (Airship.Instance.ChannelId == null);
                refreshView();

                return;
            }

            if (Airship.Instance.ChannelId != null)
            {
                CrossClipboard.Current.SetText(Airship.Instance.ChannelId);
                DisplayAlert(AppResources.alert_title, AppResources.alert_copied_channel_id, AppResources.ok);
            }
        }

        void MessageCenterBtnClicked(object sender, EventArgs e)
        {
            Airship.Instance.DisplayMessageCenter();
         
        }

        void refreshView()
        {
            if (Airship.Instance.UserNotificationsEnabled &&  Airship.Instance.ChannelId != null)
            {
                enablePushButton.Text = Airship.Instance.ChannelId;
            }
        }
    }
}
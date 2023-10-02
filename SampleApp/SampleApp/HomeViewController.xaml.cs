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
    public interface IBackgroundDependency
    {
        void OpenAirshipPreferenceCenter();
    }

    public partial class HomeViewController : ContentPage
    {
        public HomeViewController()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Airship.Instance.OnChannelCreation += OnChannelEvent;
            Airship.Instance.OnPushNotificationStatusUpdate += OnPushNotificationStatusEvent;
            Refresh();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Airship.Instance.OnChannelCreation -= OnChannelEvent;
            Airship.Instance.OnPushNotificationStatusUpdate -= OnPushNotificationStatusEvent;
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            if (!Airship.Instance.UserNotificationsEnabled)
            {
                Airship.Instance.UserNotificationsEnabled = true;
            }
            else if (Airship.Instance.ChannelId != null)
            {
                CrossClipboard.Current.SetText(Airship.Instance.ChannelId);
            }
        }

        void PreferenceCenterBtnClicked(object sender, EventArgs e)
        {
            DependencyService.Get<IBackgroundDependency>().OpenAirshipPreferenceCenter();
        }

        void MessageCenterBtnClicked(object sender, EventArgs e)
        {
            Airship.Instance.DisplayMessageCenter();
        }

        void Refresh()
        {
            if (!Airship.Instance.UserNotificationsEnabled)
            {
                enablePushButton.Text = AppResources.enable_push;
            }
            else if (Airship.Instance.ChannelId != null)
            {
                enablePushButton.Text = Airship.Instance.ChannelId;
            }
        }

        private void OnChannelEvent(object sender, ChannelEventArgs e) => Refresh();
        
        private void OnPushNotificationStatusEvent(object sender, PushNotificationStatusEventArgs e) => Refresh();
    }
}
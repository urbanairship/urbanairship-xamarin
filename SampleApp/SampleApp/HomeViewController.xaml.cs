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

        void DisplayMessageBtnClicked(object sender, EventArgs e)
        {
            Airship.Instance.DisplayMessage("-QmRithfSWagBusjmaRcEw");
        }

        void refreshView()
        {
            Airship.InboxHandler inboxHandler = new Airship.InboxHandler();
            Airship.Instance.OnMessageCenterUpdated += inboxHandler;
            Console.WriteLine("Listener set !");
            if (Airship.Instance.UserNotificationsEnabled &&  Airship.Instance.ChannelId != null)
            {
                enablePushButton.Text = Airship.Instance.ChannelId;
                displayMessageCenterButton.Text = "Display Message Center";
                displayMessageButton.Text = "Display Message Hello!";
            }
        }

        static void OnDeepLinkReceived(string s)
        {
            Console.WriteLine(s);
        }

        public static void OnMessageReceived()
        {
            Console.WriteLine("New message received !");
        }
    }
}
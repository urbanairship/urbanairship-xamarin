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
                MessagingCenter.Send(this, "ChannelUpdated");
                refreshView();

                return;
            }

            if (Airship.Instance.ChannelId != null)
            {
                CrossClipboard.Current.SetText(Airship.Instance.ChannelId);

                DisplayAlert("Alert", "Channel copied to clipboard!", "OK");
            }
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

/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Plugin.Clipboard;

using Xamarin.Forms;

using UrbanAirship.NETStandard;

namespace SampleApp
{
    public partial class PushSettingsViewController : ContentPage
    {
        public PushSettingsViewController()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            enabledPushSwitch.On = Airship.Instance.UserNotificationsEnabled;
            channelId.Detail = Airship.Instance.ChannelId != null ? Airship.Instance.ChannelId : AppResources.none;
            namedUser.Placeholder = Airship.Instance.NamedUser != null ? Airship.Instance.NamedUser : AppResources.channel_id_cell_placeholder;
        }

        void SwitchCell_OnChanged(object sender, EventArgs e)
        {
            Airship.Instance.UserNotificationsEnabled = enabledPushSwitch.On;
        }

        void CopyChannelID(object sender, EventArgs e)
        {
            if (Airship.Instance.ChannelId != null)
            {
                CrossClipboard.Current.SetText(Airship.Instance.ChannelId);
                DisplayAlert(AppResources.alert_title, AppResources.alert_copied_channel_id, AppResources.ok);
            }
        }

        void AddNamedUser(object sender, EventArgs e)
        {
            Airship.Instance.NamedUser = namedUser.Text;
            namedUser.Placeholder = namedUser.Text;
            DisplayAlert(AppResources.alert_title, AppResources.alert_named_user_added_successuflully, AppResources.ok);
        }
    }
}

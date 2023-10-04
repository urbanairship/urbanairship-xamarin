/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Plugin.Clipboard;

using Xamarin.Forms;

using UrbanAirship.NETStandard;
using SampleApp;
using System.ComponentModel;

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
            UpdateNamedUser();
            UpdateTagsCell();
        }

        void displayFeatures(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FeaturesViewController());
        }

        void enablePush_OnChanged(object sender, EventArgs e)
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
            if (namedUserLabel.Text == null)
            {
                Airship.Instance.ResetContact();
            }
            else
            {
                Airship.Instance.IdentifyContact(namedUserLabel.Text);
            }
            UpdateNamedUser();
            DisplayAlert(AppResources.alert_title, AppResources.alert_named_user_added_successuflully, AppResources.ok);
        }

        void AddTag(object sender, EventArgs e)
        {
            string tagToAdd = tagLabel.Text;
            Airship.Instance.EditDeviceTags()
                    .AddTags(new string[] { tagToAdd })
                    .Apply();
            UpdateTagsCell();
        }

        void UpdateTagsCell()
        {
            tagLabel.Text = "";
            IEnumerable<string> tags = Airship.Instance.Tags;

            string str = "";
            foreach (string tag in tags)
            {
                str = str + tag + "\n";
            }
            tagsList.Text = str;
        }

        void UpdateNamedUser()
        {
            namedUserLabel.Text = "";
            Airship.Instance.GetNamedUser(namedUser =>
            {
                Device.BeginInvokeOnMainThread(() => {
                    namedUserLabel.Placeholder = namedUser != null ? namedUser : AppResources.named_user_cell_placeholder;
                });
            });
        }
    }
}

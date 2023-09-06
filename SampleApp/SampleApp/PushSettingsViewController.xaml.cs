﻿/*
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

public class SettingsViewModel : INotifyPropertyChanged
{
    string namedUserValue;

    public event PropertyChangedEventHandler PropertyChanged;

    public void UpdateNamedUser()
    {
        Airship.Instance.GetNamedUser(namedUser =>
        {
            bool userNull = (namedUser == null);
            bool userEmpty = (namedUser.Length == 0);
            bool isEmpty = (userNull || userEmpty);
            this.namedUserValue = !isEmpty ? namedUser : AppResources.named_user_cell_placeholder;
            OnPropertyChanged("NamedUserValue");
        });
    }

    public string NamedUserValue
    {
        get
        {
            return namedUserValue;
        }
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

namespace SampleApp
{
    public partial class PushSettingsViewController : ContentPage
    {
        SettingsViewModel model = new SettingsViewModel();
        public PushSettingsViewController()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            enabledPushSwitch.On = Airship.Instance.UserNotificationsEnabled;
            channelId.Detail = Airship.Instance.ChannelId != null ? Airship.Instance.ChannelId : AppResources.none;
            UpdateNamedUserEntryCell();
            this.BindingContext = model;
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
            Airship.Instance.NamedUser = namedUserLabel.Text;
            UpdateNamedUserEntryCell();
            DisplayAlert(AppResources.alert_title, AppResources.alert_named_user_added_successuflully, AppResources.ok);
        }

        void UpdateNamedUserEntryCell()
        {
            namedUserLabel.Text = "";
            model.UpdateNamedUser();
        }
    }
}

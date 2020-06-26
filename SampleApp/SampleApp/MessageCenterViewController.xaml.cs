using System;
using System.Collections.Generic;

using Xamarin.Forms;

using UrbanAirship.NETStandard;
using UrbanAirship.NETStandard.MessageCenter;

namespace SampleApp
{
    public partial class MessageCenterViewController : ContentPage
    {
        public MessageCenterViewController()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            var messages = Airship.Instance.InboxMessages;
            listView.ItemsSource = messages;
        }

        void listView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var message = e.SelectedItem as Message;
            var messagePage = new MessagePage();
            messagePage.MessageId = message.MessageId;
            messagePage.LoadStarted += onLoadStarted;
            messagePage.Loaded += onLoaded;
            messagePage.Closed += onClosed;
            messagePage.LoadFailed += onLoadFailed;
            Navigation.PushAsync(messagePage);
        }

        private void onLoadStarted(object sender, MessageLoadStartedEventArgs e)
        {
            Console.WriteLine("onLoadStarted was reached.");
        }

        private void onLoaded(object sender, MessageLoadedEventArgs e)
        {
            Console.WriteLine("onLoaded was reached.");
        }

        private void onClosed(object sender, MessageClosedEventArgs e)
        {
            Console.WriteLine("onClosed was reached.");
        }

        private void onLoadFailed(object sender, MessageLoadFailedEventArgs e)
        {
            Console.WriteLine("onLoadFailed was reached.");
        }

    }
}

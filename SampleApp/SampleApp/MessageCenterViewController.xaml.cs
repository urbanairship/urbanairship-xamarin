using System;

using Xamarin.Forms;

using UrbanAirship.NETStandard;
using UrbanAirship.NETStandard.MessageCenter;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using System.Collections.Generic;
using System.Threading.Tasks;
using AirshipBindings.NETStandard.Abstractions;

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
            Airship.Instance.InboxMessages(messages =>
            {
                Console.WriteLine("Inbox Messages:");

                foreach (Message message in messages)
                {
                    Console.WriteLine("---");
                    Console.WriteLine(message.Title);
                    Console.WriteLine(message.Unread);
                    Console.WriteLine(message.SentDate);
                }
                Console.WriteLine("---");

                Device.BeginInvokeOnMainThread(() =>
                {
                    listView.ItemsSource = messages;
                });
            });
        }

        private async void listView_ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            var message = e.SelectedItem as Message;
            var messagePage = new MessagePage();
            messagePage.MessageId = message.MessageId;
            messagePage.LoadStarted += onLoadStarted;
            messagePage.Loaded += onLoaded;
            messagePage.Closed += onClosed;
            messagePage.LoadFailed += onLoadFailed;
            await Navigation.PushAsync(messagePage);
        }

        private void onLoadStarted(object sender, MessageLoadStartedEventArgs e)
        {
            Console.WriteLine("onLoadStarted was reached.");
        }

        private void onLoaded(object sender, MessageLoadedEventArgs e)
        {
            Console.WriteLine("onLoaded was reached.");
            
            Airship.Instance.MarkMessageRead(e.MessageId);
        }

        private void onClosed(object sender, MessageClosedEventArgs e)
        {
            Console.WriteLine("onClosed was reached.");
            Navigation.PopAsync();
        }

        private void onLoadFailed(object sender, MessageLoadFailedEventArgs e)
        {
            Console.WriteLine("onLoadFailed was reached.");
        }

    }
}

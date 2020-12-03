/*
 Copyright Airship and Contributors
*/

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using UrbanAirship.NETStandard;
using UrbanAirship.NETStandard.MessageCenter;
using System.Linq;

namespace SampleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TabbedPageView());
        }

        protected override void OnStart()
        {
            Airship.Instance.OnDeepLinkReceived += OnDeepLinkReceived;
            Airship.Instance.OnMessageCenterUpdated += OnMessageCenterUpdated;
            Airship.Instance.OnMessageCenterDisplay += OnMessageCenterDisplay;
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        static void OnDeepLinkReceived(object sender, DeepLinkEventArgs e)
        {
            Console.WriteLine("onDeepLinkReceived. Deep link = " + e.DeepLink);
        }

        static void OnMessageCenterUpdated(object sender, EventArgs e)
        {
            Console.WriteLine("onMessageCenterUpdated");
        }
        static void OnMessageCenterDisplay(object sender, MessageCenterEventArgs e)
        {
            TabbedPage originalRootPage = (TabbedPage)App.Current.MainPage.Navigation.NavigationStack.Last();

            originalRootPage.CurrentPage = originalRootPage.Children[1];

            if (e.MessageId != null)
            {
                var messagePage = new MessagePage();
                messagePage.MessageId = e.MessageId;
                originalRootPage.Navigation.PushAsync(messagePage);
            }
        }
    }
}

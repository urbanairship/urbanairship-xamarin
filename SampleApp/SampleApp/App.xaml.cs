/*
 Copyright Airship and Contributors
*/

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using UrbanAirship.NETStandard;

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
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        static void OnDeepLinkReceived(object sender, EventArgs e)
        {
            Console.WriteLine("onDeepLinkReceived. Deep link = " + e.ToString());
        }

        static void OnMessageCenterUpdated(object sender, EventArgs e)
        {
            Console.WriteLine("onMessageCenterUpdated");
        }
    }
}

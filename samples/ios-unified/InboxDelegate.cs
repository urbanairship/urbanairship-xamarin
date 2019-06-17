using UIKit;
using System.Linq;

using UrbanAirship;

namespace Sample
{
    public class InboxDelegate : UAInboxDelegate
    {

        private UIViewController rootViewController;

        public InboxDelegate(UIViewController rootViewController)
        {
            this.rootViewController = rootViewController;
        }

        MessageCenterViewController MessageCenterViewController()
        {
            UITabBarController tabBarController = (UITabBarController)this.rootViewController;
            return (MessageCenterViewController)tabBarController.ViewControllers.ElementAt(2);
        }

        public override void ShowMessage(string messageID)
        {
            ShowInbox();

            MessageCenterViewController().DisplayMessage(messageID);
        }

        public override void ShowInbox()
        {
            UITabBarController tabBarController = (UITabBarController)this.rootViewController;
            tabBarController.SelectedIndex = 2;
        }
    }
}


/*
 Copyright Airship and Contributors
*/

using UIKit;
using System.Linq;

using UrbanAirship;

namespace Sample
{
    public class MessageCenterDelegate : UAMessageCenterDisplayDelegate
    {

        private UIViewController rootViewController;

        public MessageCenterDelegate(UIViewController rootViewController)
        {
            this.rootViewController = rootViewController;
        }

        MessageCenterViewController MessageCenterViewController()
        {
            UITabBarController tabBarController = (UITabBarController)this.rootViewController;
            return (MessageCenterViewController)tabBarController.ViewControllers.ElementAt(2);
        }


        public override void DisplayMessageCenter (string messageID, bool animated)
        {
            DisplayMessageCenter(animated);

            MessageCenterViewController().DisplayMessage(messageID);
        }

        public override void DisplayMessageCenter (bool animated)
        {
            UITabBarController tabBarController = (UITabBarController)this.rootViewController;
            tabBarController.SelectedIndex = 2;
        }

        public override void DismissMessageCenterAnimated (bool animated)
        {
            throw new System.NotImplementedException();
        }
    }
}


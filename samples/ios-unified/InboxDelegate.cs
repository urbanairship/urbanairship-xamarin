using UIKit;
using System;
using UrbanAirship;
using System.Xml.Serialization;
using System.Linq;

namespace Sample
{
	public class InboxDelegate
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

		void ShowInboxMessage(UAInboxMessage message) {
			ShowInbox();

			//MessageCenterViewController().DisplayMessage(message);
		}

		void ShowInbox() 
		{
			UITabBarController tabBarController = (UITabBarController)this.rootViewController;
			tabBarController.SelectedIndex = 2;
		}
	}
}


using System;

using UIKit;
using UrbanAirship;

namespace Sample
{
	public partial class AddNamedUserTableViewController : UITableViewController
	{

		NamedUserTextFieldDelegate MyTextFieldDelegate;

		public AddNamedUserTableViewController() : base("AddNamedUserTableViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			MyTextFieldDelegate = new NamedUserTextFieldDelegate();
			MyTextFieldDelegate.MyAddNamedUserTableViewController = this;

			addNamedUserTextField.Delegate = MyTextFieldDelegate;
		}

		public override bool CanEditRow(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return false;
		}
	}

	class NamedUserTextFieldDelegate : UITextFieldDelegate
	{
		public AddNamedUserTableViewController MyAddNamedUserTableViewController;
		UITextField addNamedUserTextField { get; set; }

		bool TextFieldShouldReturn(UITextField textfield)
		{
			MyAddNamedUserTableViewController.View.EndEditing(true);

			// Trim leading and trailing whitespac
			var newTag = addNamedUserTextField.Text.Trim();

			if (newTag.Length > 0)
			{
				UAirship.Push.AddTag(newTag);
			}
			else
			{
				return false;
			}

			UAirship.Push.UpdateRegistration();

			var navigationController = (UINavigationController)MyAddNamedUserTableViewController.ParentViewController;
			navigationController.PopViewController(true);

			return true;
		}
	}
}

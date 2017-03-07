using System;

using UIKit;
using UrbanAirship;

namespace Sample
{
	public partial class AddNamedUserTableViewController : UITableViewController
	{

		NamedUserTextFieldDelegate MyTextFieldDelegate;

		public AddNamedUserTableViewController(IntPtr handle) : base (handle)
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

		public override bool ShouldReturn(UITextField textField)
		{
			MyAddNamedUserTableViewController.View.EndEditing(true);

			// Trim leading and trailing whitespac
			var newNamedUser = textField.Text.Trim();

			if (newNamedUser.Length > 0)
			{
				UAirship.NamedUser.Identifier = newNamedUser;
			}
			else {
				UAirship.NamedUser.Identifier = null;
			}

			UAirship.Push.UpdateRegistration();

			var navigationController = (UINavigationController)MyAddNamedUserTableViewController.ParentViewController;
			navigationController.PopViewController(true);

			return true;
		}
	}
}

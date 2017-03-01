using UIKit;
using UrbanAirship;

namespace Sample
{
	public partial class AddTagsTableViewController : UITableViewController
	{
		AddTagsTextFieldDelegate MyTextFieldDelegate;

		public AddTagsTableViewController() : base("AddTagsTableViewController", null)
		{
			
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			MyTextFieldDelegate = new AddTagsTextFieldDelegate();

			addCustomTagTextField.Delegate = MyTextFieldDelegate;
			MyTextFieldDelegate.AddTagsTableViewController = this;
		}

		public override bool CanEditRow(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return false;
		}
	}

	class AddTagsTextFieldDelegate : UITextFieldDelegate
	{
		public AddTagsTableViewController AddTagsTableViewController;
		UITextField addCustomTagTextField { get; set; }

		bool TextFieldShouldReturn(UITextField textfield)
		{
			AddTagsTableViewController.View.EndEditing(true);

			// Trim leading and trailing whitespace
			var newTag = this.addCustomTagTextField.Text.Trim();

			if (newTag.Length > 0)
			{
				UAirship.Push.AddTag(newTag);
			}
			else
			{
				return false;
			}

			UAirship.Push.UpdateRegistration();

			var navigationController = (UINavigationController)AddTagsTableViewController.ParentViewController;
			navigationController.PopViewController(true);

			return true;
		}
	}
}


using System;

using UIKit;
using ObjCRuntime;
using UrbanAirship;

namespace Sample
{
	public partial class TagsTableViewController : UITableViewController
	{
		public TagsTableViewController() : base("TagsTableViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			UIBarButtonItem addButton = new UIBarButtonItem(UIBarButtonSystemItem.Add, this, new Selector ("addTag:"));
			NavigationItem.RightBarButtonItem = addButton;
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);

			TableView.ReloadData();
		}

		public void AddTag() {
			PerformSegue("addTagsSegue", sender: this);
		}

		public override nint RowsInSection(UITableView tableView, nint section)
		{
			return 1;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell("tagCell", indexPath);

			if (cell == null) { 
				cell = new UITableViewCell(UITableViewCellStyle.Default, "tagCell");
			}

			cell.TextLabel.Text = UAirship.Push.Tags[indexPath.Row];

			return cell;
		}

		public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, Foundation.NSIndexPath indexPath)
		{
			if (editingStyle == UITableViewCellEditingStyle.Delete)
			{
				UAirship.Push.RemoveTag(tableView.CellAt(indexPath).TextLabel.Text);

				tableView.DeleteRows(new [] {indexPath}, UITableViewRowAnimation.Fade);

				UAirship.Push.UpdateRegistration();
			}
		}
	}
}


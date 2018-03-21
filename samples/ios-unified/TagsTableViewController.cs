using System;

using UIKit;
using ObjCRuntime;
using UrbanAirship;
using System.Linq;

namespace Sample
{
	public partial class TagsTableViewController : UITableViewController
	{
		public TagsTableViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			UIBarButtonItem addButton = new UIBarButtonItem(UIBarButtonSystemItem.Add, (sender, e) => {
				PerformSegue("addTagsSegue", sender: this);
			}); 

			NavigationItem.RightBarButtonItem = addButton;
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);

			TableView.ReloadData();
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection(UITableView tableView, nint section)
		{
			return UAirship.Push().Tags.Count();
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell("tagCell", indexPath);

			if (cell == null) { 
				cell = new UITableViewCell(UITableViewCellStyle.Default, "tagCell");
			}

			string[] tags = UAirship.Push().Tags;

			cell.TextLabel.Text = tags[indexPath.Row];

			return cell;
		}

		public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, Foundation.NSIndexPath indexPath)
		{
			if (editingStyle == UITableViewCellEditingStyle.Delete)
			{
				UAirship.Push().RemoveTag(tableView.CellAt(indexPath).TextLabel.Text);

				tableView.DeleteRows(new [] {indexPath}, UITableViewRowAnimation.Fade);

				UAirship.Push().UpdateRegistration();
			}
		}
	}
}


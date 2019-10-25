﻿using System;
using UIKit;

using UrbanAirship;

namespace Sample
{
    public partial class AddTagsTableViewController : UITableViewController
    {
        AddTagsTextFieldDelegate MyTextFieldDelegate;

        public AddTagsTableViewController(IntPtr handle) : base(handle)
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

        public override bool ShouldReturn(UITextField textField)
        {
            AddTagsTableViewController.View.EndEditing(true);

            // Trim leading and trailing whitespace
            var newTag = textField.Text.Trim();

            if (newTag.Length > 0)
            {
                UAirship.Channel().AddTag(newTag);
            }
            else
            {
                return false;
            }

            UAirship.Channel().UpdateRegistration();

            var navigationController = (UINavigationController)AddTagsTableViewController.ParentViewController;
            navigationController.PopViewController(true);

            return true;
        }
    }
}


/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;

using Android.Content;
using Android.Preferences;
using Android.Util;
using Android.Views;
using Android.Widget;

using UrbanAirship;

namespace Sample.Preference
{
	public class SetNamedUserPreference : DialogPreference
	{
		private EditText editTextView;
		private string currentNamedUser;

		public override Java.Lang.ICharSequence SummaryFormatted
		{
			get
			{
				return new Java.Lang.String(currentNamedUser);
			}
		}

		public SetNamedUserPreference(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			currentNamedUser = UAirship.Shared().NamedUser.Id;
		}

		protected override View OnCreateDialogView()
		{
			editTextView = new EditText(Context);
			editTextView.Text = currentNamedUser;

			return editTextView;
		}

		protected override View OnCreateView(ViewGroup parent)
		{
			View view = base.OnCreateView(parent);
			view.ContentDescription = "SET_NAMED_USER";
			return view;
		}

		protected override void OnDialogClosed(bool positiveResult)
		{
			if (positiveResult)
			{
				string namedUser = editTextView.Text;
				if (CallChangeListener(namedUser))
				{
					SetNamedUser(namedUser);
					NotifyChanged();
				}
			}
		}

		private void SetNamedUser(String namedUser)
		{
			currentNamedUser = String.IsNullOrEmpty(namedUser) ? null : namedUser;
			UAirship.Shared().NamedUser.Id = currentNamedUser;
		}

		protected override bool ShouldPersist()
		{
			return false;
		}
	}
}

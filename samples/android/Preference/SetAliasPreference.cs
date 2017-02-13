/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;

using Android.Content;
using Android.Preferences;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

using UrbanAirship;

// TODO alias stuff, getter setter blah;
namespace Sample.Preference
{
	public class SetAliasPreference : DialogPreference
	{
		private EditText editTextView;
		private string currentAlias;

		public override Java.Lang.ICharSequence SummaryFormatted
		{
			get
			{
				return new Java.Lang.String(currentAlias);
			}
		}

		public SetAliasPreference(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			currentAlias = UAirship.Shared().PushManager.Alias;
		}

		protected override View OnCreateDialogView()
		{
			editTextView = new EditText(Context);
			editTextView.Text = currentAlias;

			return editTextView;
		}

		protected override View OnCreateView(ViewGroup parent)
		{
			View view = base.OnCreateView(parent);
			view.ContentDescription = "SET_ALIAS";
			return view;
		}

		protected override void OnDialogClosed(bool positiveResult)
		{
			if (positiveResult)
			{
				string alias = editTextView.Text;
				if (CallChangeListener(alias))
				{
					SetAlias(alias);
					NotifyChanged();
				}
			}
		}

		private void SetAlias(string alias)
		{
			currentAlias = String.IsNullOrEmpty(alias) ? null : alias;
			UAirship.Shared().PushManager.Alias = currentAlias;
		}

		protected override bool ShouldPersist()
		{
			return false;
		}
	}
}
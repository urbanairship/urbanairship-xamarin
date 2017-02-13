using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using Android.Content;
using Android.Preferences;
using Android.Util;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;

using UrbanAirship;

namespace Sample.Preference
{
	public class AddTagsPreference : DialogPreference
	{
		private readonly List<string> tags = new List<string>();
		private readonly ISet<string> currentTags;
		private TagsAdapter tagsAdapter;

		public AddTagsPreference(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			currentTags = new HashSet<string>(UAirship.Shared().PushManager.Tags);
		}

		public override Java.Lang.ICharSequence SummaryFormatted
		{
			get
			{
				return new Java.Lang.String(string.Join(", ", currentTags));
			}
		}

		protected override View OnCreateDialogView()
		{
			tags.Clear();
			tags.AddRange(currentTags);

			View view = base.OnCreateDialogView();
			ListView listView = (ListView)view.FindViewById(Resource.Id.tags_list);
			tagsAdapter = new TagsAdapter(Context, Resource.Layout.tag_preference_item, this);
			listView.Adapter = tagsAdapter;

			EditText editText = (EditText)view.FindViewById(Resource.Id.new_tag_text);

			ImageButton button = (ImageButton)view.FindViewById(Resource.Id.new_tag_button);
			button.Click += (sender, e) =>
			{
				String newTag = editText.Text;
				editText.Text = null;
				InputMethodManager imm = (InputMethodManager)Context.GetSystemService(Context.InputMethodService);
				imm.HideSoftInputFromWindow(editText.WindowToken, 0);

				if (!String.IsNullOrEmpty(newTag))
				{
					if (tags.Contains(newTag))
					{
						Toast.MakeText(Context, Resource.String.duplicate_tag_warning, ToastLength.Short).Show();
					}
					else
					{
						tags.Add(newTag);
						tagsAdapter.NotifyDataSetChanged();
					}
				}
			};

			return view;
		}

		protected override View OnCreateView(ViewGroup parent)
		{
			View view = base.OnCreateView(parent);
			view.ContentDescription = "ADD_TAGS";
			return view;
		}

		protected override void OnDialogClosed(bool positiveResult)
		{
			if (positiveResult)
			{
				if (CallChangeListener(tags.ToArray()))
				{
					SetTags(tags);
					NotifyChanged();
				}
			}
		}

		protected override bool ShouldPersist()
		{
			return false;
		}

		private void SetTags(List<string> addTags)
		{
			currentTags.Clear();
			currentTags.UnionWith(addTags);

			UAirship.Shared().PushManager.Tags = currentTags;
		}

		private class TagsAdapter : ArrayAdapter<string>
		{
			private readonly int layout;
			private AddTagsPreference outer;

			public TagsAdapter(Context context, int layout, AddTagsPreference outer) : base(context, layout)
			{
				this.layout = layout;
				this.outer = outer;
			}

			private View CreateView(ViewGroup parent)
			{
				LayoutInflater layoutInflater = (LayoutInflater)Context.GetSystemService(Context.LayoutInflaterService);
				return layoutInflater.Inflate(layout, parent, false);
			}

			public override View GetView(int position, View convertView, ViewGroup parent)
			{
				View view = convertView == null ? CreateView(parent) : convertView;
				string tag = this.GetItem(position);

				TextView textView = (TextView)view.FindViewById(Resource.Id.tag_text);
				textView.Text = tag;

				ImageButton button = (ImageButton)view.FindViewById(Resource.Id.delete_tag_button);
				button.Click += (sender, e) =>
				{
					outer.tags.Remove(tag);
					this.NotifyDataSetChanged();
				};

				return view;
			}
		}
	}
}
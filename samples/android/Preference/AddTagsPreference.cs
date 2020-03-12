/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;

using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Util;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;

using AndroidX.Preference;

using UrbanAirship;

namespace Sample.Preference
{
    public class AddTagsPreference : DialogPreference
    {
        public List<string> tags = new List<string>();
        public ISet<string> currentTags;

        public AddTagsPreference(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            currentTags = new HashSet<string>(UAirship.Shared().Channel.Tags);
        }

        public override Java.Lang.ICharSequence SummaryFormatted
        {
            get
            {
                return new Java.Lang.String(string.Join(", ", currentTags));
            }
        }

        protected override Java.Lang.Object OnGetDefaultValue(TypedArray a, int index)
        {
            return a.GetString(index);
        }

        protected override bool ShouldPersist()
        {
          return false;
        }

        protected override void OnSetInitialValue(Java.Lang.Object defaultValue)
        {
            base.OnSetInitialValue(defaultValue);
        }

        public override int DialogLayoutResource
        {
            get
            {
                return Resource.Layout.dialog_add_tags;
            }
        }

        public void SetTags(List<string> addTags)
        {
            currentTags.Clear();
            currentTags.UnionWith(addTags);

            UAirship.Shared().Channel.EditTags().AddTags(currentTags).Apply();

            this.NotifyChanged();
        }

    }

    public class AddTagsPreferenceDialogFragmentCompat : PreferenceDialogFragmentCompat
    {
        private TagsAdapter tagsAdapter;
        private AddTagsPreference preference;

        public AddTagsPreferenceDialogFragmentCompat() : base() {}

        public AddTagsPreferenceDialogFragmentCompat(String key) : base()
        {
            Bundle bundle = new Bundle(1);
            bundle.PutString("key", key);
            this.Arguments = bundle;
        }

        protected override void OnBindDialogView(View view)
        {

            base.OnBindDialogView(view);

            preference = (AddTagsPreference)Preference;

            preference.tags.Clear();
            preference.tags.AddRange(preference.currentTags);

            ListView listView = (ListView)(view.FindViewById(Resource.Id.tags_list));

            if (listView == null)
            {
                throw new System.InvalidOperationException("Dialog view must contain" +
                        " a ListView with id 'tags_list'");
            }

            tagsAdapter = new TagsAdapter(Context, Resource.Layout.tag_preference_item, preference);
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
                    if (preference.tags.Contains(newTag))
                    {
                        Toast.MakeText(Context, Resource.String.duplicate_tag_warning, ToastLength.Short).Show();
                    }
                    else
                    {
                        preference.tags.Add(newTag);
                        tagsAdapter.NotifyDataSetChanged();
                    }
                }
            };
        }

        public override void OnDialogClosed(bool positiveResult)
        {
            if (positiveResult)
            {
                preference.SetTags(preference.tags);
            }
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
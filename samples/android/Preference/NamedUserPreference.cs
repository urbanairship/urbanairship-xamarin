/*
 Copyright Airship and Contributors
*/

using System;

using Android.Content;
using Android.Util;

using AndroidX.Preference;

using UrbanAirship;

namespace Sample.Preference
{
    public class NamedUserPreference : EditTextPreference
    {
        public NamedUserPreference(Context context, IAttributeSet attrs) : base(context, attrs) {}

        public override string Text
        {
            set
            {
                String namedUser = String.IsNullOrEmpty(value) ? null : value;
                UAirship.Shared().NamedUser.Id = namedUser;
                NotifyChanged();
            }
            get
            {
                return UAirship.Shared().NamedUser.Id;
            }
        }

        public override Java.Lang.ICharSequence SummaryFormatted
        {
            get
            {
                return new Java.Lang.String(UAirship.Shared().NamedUser.Id);
            }
        }
    }
}

using System;
using Android.Content;
using Android.Util;
using Android.OS;

namespace UrbanAirship.Preference
{
    public class ChannelIdPreference : UrbanAirship.Preference.ChannelIdPreferenceClass
    {
        public ChannelIdPreference(Context context, IAttributeSet attrs) : base(context, attrs) {}

        public ChannelIdPreference(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr) {}

        public ChannelIdPreference(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes) {}

        protected override void NotifyChanged()
        {
            // move call to the main (UI) thread.
            Handler handler = new Handler(Looper.MainLooper);
            handler.Post(new Java.Lang.Runnable(() =>
            {
                base.NotifyChanged();
            }));
        }
    }
}

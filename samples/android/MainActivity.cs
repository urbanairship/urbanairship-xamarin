/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.OS;

using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.Content;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;

using Google.Android.Material.Navigation;
using Google.Android.Material.Snackbar;

using UrbanAirship.Google;
using UrbanAirship;
using UrbanAirship.RichPush;
using UrbanAirship.MessageCenter;

namespace Sample
{
	[Register("sample.MainActivity")]
	[Activity (MainLauncher = true, 
	           Icon = "@drawable/urbanairship_logo",
	           Label = "@string/app_name",
	           LaunchMode = Android.Content.PM.LaunchMode.SingleTop,
	           Theme = "@style/AppTheme.NoActionBar")]
	[IntentFilter(new string[] { "android.intent.action.MAIN" }, Categories = new string[] { "android.intent.category.LAUNCHER" })]
	[IntentFilter(new string[] { "com.urbanairship.VIEW_RICH_PUSH_INBOX" }, Categories = new string[] { "android.intent.category.DEFAULT" })]
	[IntentFilter(new string[] { "com.urbanairship.VIEW_RICH_PUSH_INBOX" }, Categories = new string[] { "android.intent.category.DEFAULT" },
	              DataScheme= "message")]
	public class MainActivity : AppCompatActivity
	{
		private const string Tag = "MainActivity";

		private const string NavId = "NAV_ID";
		private const string TitleKey = "TITLE";
		private const string LastMessageSentDate = "LAST_MC_SENT_DATE";
		private const int MessageCenterIndicatorDurationMs = 10000;

		private DrawerLayout drawer;
		private int currentNavPosition = -1;

		private Snackbar messageCenterSnackbar;
		private long messageCenterLastSentDate;
		private NavigationView navigation;
		private InboxListener inboxListener;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView(Resource.Layout.activity_main);

			// Action bar
			Toolbar toolbar = (Toolbar)FindViewById(Resource.Id.toolbar);
			SetSupportActionBar(toolbar);

			// App drawer
			drawer = (DrawerLayout)FindViewById(Resource.Id.drawer_layout);
			ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
				this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_open
			);
			drawer.AddDrawerListener(toggle);
			toggle.SyncState();

			navigation = (NavigationView) FindViewById(Resource.Id.nav_view);
			navigation.NavigationItemSelected += (sender, e) =>
			{
				Navigate(e.MenuItem.ItemId);
			};

			inboxListener = new InboxListener(this);

			// message center stuff
			if (savedInstanceState != null)
			{
				Navigate(savedInstanceState.GetInt(NavId));
				Title = savedInstanceState.GetString(TitleKey);
			}
			else
			{
				navigation.SetCheckedItem(Resource.Id.nav_home);
				Navigate(Resource.Id.nav_home);
			}
		}

		protected override void OnNewIntent(Intent intent)
		{
			base.OnNewIntent(intent);
			Intent = intent;
		}

		protected override void OnSaveInstanceState(Bundle outState)
		{
			base.OnSaveInstanceState(outState);
			outState.PutInt(NavId, currentNavPosition);
			outState.PutString(TitleKey, Title);
			outState.PutLong(LastMessageSentDate, messageCenterLastSentDate);
		}

		protected override void OnResume ()
		{
			base.OnResume ();

			if (PlayServicesUtils.IsGooglePlayStoreAvailable(this))
			{
				PlayServicesUtils.HandleAnyPlayServicesError(this);
			}

			if (MessageCenterClass.MessageDataScheme == Intent.Action)
			{
				AndroidX.Fragment.App.Fragment fragment = Navigate(Resource.Id.nav_message_center);
				if (Intent.Data != null && Intent.Data.Scheme.ToLower() == MessageCenterClass.MessageDataScheme)
				{
					string messageId = Intent.Data.SchemeSpecificPart;
					if (fragment != null && fragment is MessageCenterFragment)
					{
						((MessageCenterFragment) fragment).SetMessageID(messageId);
					}
				}

				Intent.SetAction(null);
			}

			UAirship.Shared().Inbox.AddListener(inboxListener);
			ShowMessageCenterIndicator();
			UpdateUnreadCount();
		}

		protected override void OnPause ()
		{
			base.OnPause();
			UAirship.Shared().Inbox.RemoveListener(inboxListener);
		}

		public override void OnBackPressed()
		{
			DrawerLayout drawer = (DrawerLayout)FindViewById(Resource.Id.drawer_layout);
			if (drawer.IsDrawerOpen(GravityCompat.Start))
			{
				drawer.CloseDrawer(GravityCompat.Start);
			}
			else if (currentNavPosition != Resource.Id.nav_home)
			{
				Navigate(Resource.Id.nav_home);
			}
			else
			{
				base.OnBackPressed();
			}
		}

		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.menu_main, menu);
			return true;
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int id = item.ItemId;

			if (id == Resource.Id.action_settings)
			{
				this.StartActivity(new Intent(this, typeof(SettingsActivity)));
				return true;
			}

			return base.OnOptionsItemSelected(item);
		}

		private AndroidX.Fragment.App.Fragment Navigate(int id)
		{
			currentNavPosition = id;
			navigation.SetCheckedItem(id);

			AndroidX.Fragment.App.Fragment fragment = SupportFragmentManager.FindFragmentByTag("content_frag" + id);

			if (fragment != null)
			{
				return fragment;
			}

			switch (id)
			{
				case Resource.Id.nav_home:
					SetTitle(Resource.String.home_title);
					fragment = new HomeFragment();
					break;
				case Resource.Id.nav_message_center:
					SetTitle(Resource.String.message_center_title);
					fragment = new MessageCenterFragment();

					if (messageCenterSnackbar != null && messageCenterSnackbar.IsShownOrQueued)
					{
						messageCenterSnackbar.Dismiss();
					}
					break;
				case Resource.Id.nav_location:
					SetTitle(Resource.String.location_title);
					fragment = new LocationFragment();
					break;
				default:
					Log.Error(Tag, "Unexpected navigation item");			
					return null;
			}

			currentNavPosition = id;
			SupportFragmentManager.BeginTransaction()
						   .Replace(Resource.Id.content_frame, fragment, "content_frag" + id)
						   .Commit();

			drawer.CloseDrawer(GravityCompat.Start);

			return fragment;
		}


		private void UpdateUnreadCount()
		{
			int unreadCount = UAirship.Shared().Inbox.UnreadCount;
			AppCompatTextView view = (AppCompatTextView)navigation.Menu.FindItem(Resource.Id.nav_message_center).ActionView;

			if (unreadCount > 0)
			{
				view.Visibility = ViewStates.Visible;
				view.Text = unreadCount.ToString();
			}
			else
			{
				view.Visibility = ViewStates.Gone;
			}
		}

		private void ShowMessageCenterIndicator()
		{
			IList<RichPushMessage> unreadMessages = UAirship.Shared().Inbox.UnreadMessages;

			if (unreadMessages.Count == 0 || messageCenterLastSentDate >= unreadMessages[0].SentDateMS)
			{
				return;
			}

			messageCenterLastSentDate = unreadMessages[0].SentDateMS;

			if (messageCenterSnackbar != null && messageCenterSnackbar.IsShownOrQueued)
			{
				return;
			}

			if (currentNavPosition == Resource.Id.nav_message_center)
			{
				return;
			}

			String text = Resources.GetQuantityString(Resource.Plurals.mc_indicator_text, unreadMessages.Count, unreadMessages.Count);

			messageCenterSnackbar = Snackbar.Make(FindViewById(Resource.Id.coordinatorLayout), text, MessageCenterIndicatorDurationMs)
											.SetActionTextColor(ContextCompat.GetColor(this, Resource.Color.color_accent))
											.SetAction(Resource.String.view, (View v) =>
			{
				messageCenterSnackbar.Dismiss();
				UAirship.Shared().MessageCenter.ShowMessageCenter();
			});

			messageCenterSnackbar.Show();
		}

		internal class InboxListener : Java.Lang.Object, RichPushInbox.IListener
		{
			MainActivity activity;

			public InboxListener(MainActivity activity)
			{
				this.activity = activity;
			}
			public void OnInboxUpdated()
			{
				activity.ShowMessageCenterIndicator();
				activity.UpdateUnreadCount();
			}
		}
	}
}
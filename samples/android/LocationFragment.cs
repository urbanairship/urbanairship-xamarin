/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;

using Android.Content.PM;
using Android.Locations;
using Android.OS;
using Android.Support.V4.Content;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;


using UrbanAirship;
using UrbanAirship.Location;

namespace Sample
{
	public class LocationFragment : Fragment
	{
		private UrbanAirship.ICancelable pendingRequest;
		private RadioGroup priorityGroup;
		private View progress;
		const int PERMISSIONS_REQUEST_LOCATION = 100;

		private int Priority
		{
			get
			{
				switch (priorityGroup.CheckedRadioButtonId)
				{
					case Resource.Id.priority_high_accuracy:
						return LocationRequestOptions.PriorityHighAccuracy;
					case Resource.Id.priority_balanced:
						return LocationRequestOptions.PriorityBalancedPowerAccuracy;
					case Resource.Id.priority_low_power:
						return LocationRequestOptions.PriorityLowPower;
					case Resource.Id.priority_no_power:
						return LocationRequestOptions.PriorityNoPower;
				}
				return LocationRequestOptions.PriorityBalancedPowerAccuracy;
			}
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate(Resource.Layout.fragment_location, container, false);

			priorityGroup = (RadioGroup)view.FindViewById(Resource.Id.location_priority);
			progress = view.FindViewById(Resource.Id.request_progress);
			progress.Visibility = ViewStates.Invisible;

			Button button = (Button)view.FindViewById(Resource.Id.request_button);
			button.Click += (sender, e) =>
			{
				RequestLocation();
			};

			return view;
		}

		public override void OnPause()
		{
			base.OnPause();

			if (pendingRequest != null)
			{
				pendingRequest.Cancel();
				progress.Visibility = ViewStates.Invisible;
			}
		}

		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
		{
			switch (requestCode)
			{
				case PERMISSIONS_REQUEST_LOCATION:
					{
						if (grantResults[0] == Permission.Granted)
						{
							RequestLocation();
						}
						else
						{
							Toast.MakeText(Context, "Enable location permission and try again.", ToastLength.Short);
						}
					}
					break;
			}
		}

		private void RequestLocation()
		{
			if (Build.VERSION.SdkInt >= BuildVersionCodes.M && ContextCompat.CheckSelfPermission(Context, Android.Manifest.Permission.AccessFineLocation) != Permission.Granted)
			{
				RequestPermissions(new string[] { Android.Manifest.Permission.AccessFineLocation }, PERMISSIONS_REQUEST_LOCATION);
				return;
			}

			if (pendingRequest != null)
			{
				pendingRequest.Cancel();
			}

			progress.Visibility = ViewStates.Visible;

			LocationRequestOptions options = new LocationRequestOptions.Builder()
																	   .SetPriority(Priority)
																	   .Create();

			pendingRequest = UAirship.Shared().LocationManager.RequestSingleLocation(new LocManagerCallback(Context, progress), options);
		}

		internal class LocManagerCallback : Java.Lang.Object, ILocationCallback
		{
			View progress;
			Android.Content.Context context;

			public LocManagerCallback(Android.Content.Context context, View progress)
			{
				this.progress = progress;
				this.context = context;
			}

			public void OnResult(Location location)
			{
				progress.Visibility = ViewStates.Invisible;

				if (location != null)
				{
					Toast.MakeText(context, FormatLocation(location), ToastLength.Short).Show();
				}
				else
				{
					Toast.MakeText(context, "Failed to get location", ToastLength.Short).Show();
				}
			}

			private string FormatLocation(Location location)
			{
				return String.Format("provider: {0}, lat: {1}, lon: {2}, accuracy: {3}",
									 location.Provider, location.Latitude, location.Longitude, location.Accuracy);
			}
		}
	}
}
using Android.Locations;
using Android.OS;
using System;
using Android.Runtime;

namespace UrbanAirship.Location
{
	public partial class UALocationManager
	{

		/*
		 * Since we provide our own ILocationCallback the request methods that take
		 * in a location callback do not generate. These bindings are from before we created
		 * our own ILocationCallback.
		 **/
		// start
		static Delegate cb_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_;
		#pragma warning disable 0169
		static Delegate GetRequestSingleLocation_Lcom_urbanairship_location_LocationCallback_Handler ()
		{
			if (cb_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_ == null)
				cb_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestSingleLocation_Lcom_urbanairship_location_LocationCallback_);
			return cb_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_;
		}

		static IntPtr n_RequestSingleLocation_Lcom_urbanairship_location_LocationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UrbanAirship.Location.UALocationManager __this = global::Java.Lang.Object.GetObject<global::UrbanAirship.Location.UALocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UrbanAirship.Location.ILocationCallback p0 = (global::UrbanAirship.Location.ILocationCallback)global::Java.Lang.Object.GetObject<global::UrbanAirship.Location.ILocationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestSingleLocation (p0));
			return __ret;
		}
		#pragma warning restore 0169

		static IntPtr id_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.urbanairship.location']/class[@name='UALocationManager']/method[@name='requestSingleLocation' and count(parameter)=1 and parameter[1][@type='com.urbanairship.location.LocationCallback']]"
		[Register ("requestSingleLocation", "(Lcom/urbanairship/location/LocationCallback;)Lcom/urbanairship/Cancelable;", "GetRequestSingleLocation_Lcom_urbanairship_location_LocationCallback_Handler")]
		public virtual unsafe global::UrbanAirship.ICancelable RequestSingleLocation (global::UrbanAirship.Location.ILocationCallback p0)
		{
			if (id_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_ == IntPtr.Zero)
				id_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_ = JNIEnv.GetMethodID (class_ref, "requestSingleLocation", "(Lcom/urbanairship/location/LocationCallback;)Lcom/urbanairship/Cancelable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::UrbanAirship.ICancelable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::UrbanAirship.ICancelable> (JNIEnv.CallObjectMethod  (Handle, id_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::UrbanAirship.ICancelable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestSingleLocation", "(Lcom/urbanairship/location/LocationCallback;)Lcom/urbanairship/Cancelable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_Lcom_urbanairship_location_LocationRequestOptions_;
		#pragma warning disable 0169
		static Delegate GetRequestSingleLocation_Lcom_urbanairship_location_LocationCallback_Lcom_urbanairship_location_LocationRequestOptions_Handler ()
		{
			if (cb_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_Lcom_urbanairship_location_LocationRequestOptions_ == null)
				cb_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_Lcom_urbanairship_location_LocationRequestOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestSingleLocation_Lcom_urbanairship_location_LocationCallback_Lcom_urbanairship_location_LocationRequestOptions_);
			return cb_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_Lcom_urbanairship_location_LocationRequestOptions_;
		}

		static IntPtr n_RequestSingleLocation_Lcom_urbanairship_location_LocationCallback_Lcom_urbanairship_location_LocationRequestOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::UrbanAirship.Location.UALocationManager __this = global::Java.Lang.Object.GetObject<global::UrbanAirship.Location.UALocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UrbanAirship.Location.ILocationCallback p0 = (global::UrbanAirship.Location.ILocationCallback)global::Java.Lang.Object.GetObject<global::UrbanAirship.Location.ILocationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::UrbanAirship.Location.LocationRequestOptions p1 = global::Java.Lang.Object.GetObject<global::UrbanAirship.Location.LocationRequestOptions> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestSingleLocation (p0, p1));
			return __ret;
		}
		#pragma warning restore 0169

		static IntPtr id_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_Lcom_urbanairship_location_LocationRequestOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.urbanairship.location']/class[@name='UALocationManager']/method[@name='requestSingleLocation' and count(parameter)=2 and parameter[1][@type='com.urbanairship.location.LocationCallback'] and parameter[2][@type='com.urbanairship.location.LocationRequestOptions']]"
		[Register ("requestSingleLocation", "(Lcom/urbanairship/location/LocationCallback;Lcom/urbanairship/location/LocationRequestOptions;)Lcom/urbanairship/Cancelable;", "GetRequestSingleLocation_Lcom_urbanairship_location_LocationCallback_Lcom_urbanairship_location_LocationRequestOptions_Handler")]
		public virtual unsafe global::UrbanAirship.ICancelable RequestSingleLocation (global::UrbanAirship.Location.ILocationCallback p0, global::UrbanAirship.Location.LocationRequestOptions p1)
		{
			if (id_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_Lcom_urbanairship_location_LocationRequestOptions_ == IntPtr.Zero)
				id_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_Lcom_urbanairship_location_LocationRequestOptions_ = JNIEnv.GetMethodID (class_ref, "requestSingleLocation", "(Lcom/urbanairship/location/LocationCallback;Lcom/urbanairship/location/LocationRequestOptions;)Lcom/urbanairship/Cancelable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::UrbanAirship.ICancelable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::UrbanAirship.ICancelable> (JNIEnv.CallObjectMethod  (Handle, id_requestSingleLocation_Lcom_urbanairship_location_LocationCallback_Lcom_urbanairship_location_LocationRequestOptions_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::UrbanAirship.ICancelable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestSingleLocation", "(Lcom/urbanairship/location/LocationCallback;Lcom/urbanairship/location/LocationRequestOptions;)Lcom/urbanairship/Cancelable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// End

		public virtual ICancelable RequestSingleLocation (Action<Android.Locations.Location> callback)
		{
			return RequestSingleLocation (new LocationCallback (callback));
		}

		public virtual ICancelable RequestSingleLocation (Action<Android.Locations.Location> callback, LocationRequestOptions requestOptions)
		{
			return RequestSingleLocation (new LocationCallback (callback), requestOptions);
		}
			
		internal class LocationCallback : Java.Lang.Object, ILocationCallback
		{
			Action<Android.Locations.Location> callback;

			public LocationCallback (Action<Android.Locations.Location> callback)
			{
				this.callback = callback;
			}
				
			public void OnResult (Android.Locations.Location location)
			{

				if (callback != null) {
					callback.Invoke ((Android.Locations.Location)location);
				}
			}
		}
	}
}
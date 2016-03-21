using System;
using Android.Runtime;
using Android.Locations;

namespace UrbanAirship.Location
{
	[Register ("com/urbanairship/location/LocationCallback", "", "UrbanAirship.ILocationCallbackInvoker")]
	public partial interface ILocationCallback : IJavaObject
	{
		[Register ("onResult", "(Landroid/location/Location;)V", "GetOnResult_Landroid_location_Location_Handler:UrbanAirship.Location.ILocationCallbackInvoker, AirshipBindings")]
		void OnResult (Android.Locations.Location location);

	}

	[global::Android.Runtime.Register ("com/urbanairship/location/LocationCallback", DoNotGenerateAcw = true)]
	internal class ILocationCallbackInvoker : global::Java.Lang.Object, ILocationCallback
	{

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/urbanairship/location/LocationCallback");
		IntPtr class_ref;

		public static ILocationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocationCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
					JNIEnv.GetClassNameFromInstance (handle), "com.urbanairship.location.LocationCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof(ILocationCallbackInvoker); }
		}

		static Delegate cb_onResult_Landroid_location_Location_;
		#pragma warning disable 0169
		static Delegate GetOnResult_Landroid_location_Location_Handler ()
		{
			if (cb_onResult_Landroid_location_Location_ == null)
				cb_onResult_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>)n_OnResult_Landroid_location_Location_);
			return cb_onResult_Landroid_location_Location_;
		}

		static void n_OnResult_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::UrbanAirship.Location.ILocationCallback __this = global::Java.Lang.Object.GetObject<global::UrbanAirship.Location.ILocationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Locations.Location obj = global::Java.Lang.Object.GetObject<Android.Locations.Location> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (obj);
		}
		#pragma warning restore 0169

		IntPtr id_onResult_Landroid_location_Location_;

		public void OnResult (Android.Locations.Location obj)
		{
			if (id_onResult_Landroid_location_Location_ == IntPtr.Zero)
				id_onResult_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Landroid/location/Location;)V");
			IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
			JNIEnv.CallVoidMethod (Handle, id_onResult_Landroid_location_Location_, new JValue (native_obj));
			JNIEnv.DeleteLocalRef (native_obj);
		}

	}

	public partial class ResponseEventArgs : global::System.EventArgs
	{

		public ResponseEventArgs (global::Java.Lang.Object obj)
		{
			this.obj = obj;
		}

		global::Java.Lang.Object obj;

		public global::Java.Lang.Object Obj {
			get { return obj; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/urbanairship/location/LocationCallbackImplementor")]
	internal sealed class ILocationCallbackImplementor : global::Java.Lang.Object, ILocationCallback
	{

		object sender;

		public ILocationCallbackImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/urbanairship/location/LocationCallbackImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<ResponseEventArgs> Handler;
		#pragma warning restore 0649

		public void OnResult (Android.Locations.Location obj)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ResponseEventArgs (obj));
		}

		internal static bool __IsEmpty (ILocationCallbackImplementor value)
		{
			return value.Handler == null;
		}
	}
}


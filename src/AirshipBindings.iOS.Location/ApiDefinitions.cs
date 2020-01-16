/*
 Copyright Airship and Contributors
*/
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace UrbanAirship {
    // @protocol UALocationDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UALocationDelegate
    {

        // - (void)locationUpdatesStarted;
        [Export("locationUpdatesStarted")]
        void LocationUpdatesStarted ();

        // - (void)locationUpdatesStopped;
        [Export("locationUpdatesStopped")]
        void LocationUpdatesStopped ();

        // - (void)receivedLocationUpdates:(nonnull NSArray *)locations;
        [Export("receivedLocationUpdates:")]
        void ReceivedLocationUpdates (NSObject[] locations);
    }

    interface IUALocationDelegate { }

    // @interface UALocation : UAComponent <UALocationProviderDelegate>
    [BaseType(typeof(UAComponent))]
    interface UALocation : IUALocationProviderDelegate
    {
        // @property (getter=isAutoRequestAuthorizationEnabled, assign, readwrite, nonatomic) BOOL autoRequestAuthorizationEnabled;
        [Export("autoRequestAuthorizationEnabled")]
        bool AutoRequestAuthorizationEnabled { [Bind("isAutoRequestAuthorizationEnabled")] get; set; }

        // @property (getter=isLocationUpdatesEnabled, assign, readwrite, nonatomic) BOOL locationUpdatesEnabled;
        [Export("locationUpdatesEnabled")]
        bool LocationUpdatesEnabled { [Bind("isLocationUpdatesEnabled")] get; set; }

        // @property (getter=isBackgroundLocationUpdatesAllowed, assign, readwrite, nonatomic) BOOL backgroundLocationUpdatesAllowed;
        [Export("backgroundLocationUpdatesAllowed")]
        bool BackgroundLocationUpdatesAllowed { [Bind("isBackgroundLocationUpdatesAllowed")] get; set; }

        // @property (readwrite, nonatomic, nullable) id<UALocationDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IUALocationDelegate Delegate { get; set; }

        // @property (readonly, nonatomic, nullable) CLLocation *lastLocation;
        [NullAllowed, Export("lastLocation")]
        CLLocation LastLocation { get; }

        // + (null_unspecified UALocation *)sharedLocation;
        [Static]
        [Export("sharedLocation")]
        UALocation SharedLocation ();

        // - (BOOL)isLocationOptedIn;
        [Export("isLocationOptedIn")]
        bool IsLocationOptedIn ();

        // - (BOOL)isLocationDeniedOrRestricted;
        [Export("isLocationDeniedOrRestricted")]
        bool IsLocationDeniedOrRestricted ();

        // - (UALocationProviderPermissionStatus)locationPermissionStatus;
        [Export("locationPermissionStatus")]
        UALocationProviderPermissionStatus LocationPermissionStatus ();
    }

}

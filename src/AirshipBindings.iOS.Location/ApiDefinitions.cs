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

    // @interface UALocation : NSObject <UAComponent, UALocationProvider>
    [BaseType(typeof(NSObject))]
    interface UALocation : IUAComponent
    {
        // @property (class, nonatomic, readonly) UALocation *_Nonnull shared;
        [Static]
        [Export("shared")]
        UALocation Shared { get; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite, getter=isAutoRequestAuthorizationEnabled) BOOL autoRequestAuthorizationEnabled;
        [Export("autoRequestAuthorizationEnabled")]
        bool AutoRequestAuthorizationEnabled { [Bind("isAutoRequestAuthorizationEnabled")] get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite, getter=isLocationUpdatesEnabled) BOOL locationUpdatesEnabled;
        [Export("locationUpdatesEnabled")]
        bool LocationUpdatesEnabled { [Bind("isLocationUpdatesEnabled")] get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite, getter=isBackgroundLocationUpdatesAllowed) BOOL backgroundLocationUpdatesAllowed;
        [Export("backgroundLocationUpdatesAllowed")]
        bool BackgroundLocationUpdatesAllowed { [Bind("isBackgroundLocationUpdatesAllowed")] get; set; }

        // @property (nonatomic, weak, readwrite, nullable) id<UALocationDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IUALocationDelegate Delegate { get; set; }

        // @property (nonatomic, readonly, nullable) CLLocation *lastLocation;
        [NullAllowed, Export("lastLocation")]
        CLLocation LastLocation { get; }

        // - (BOOL)isLocationOptedIn;
        [Export("isLocationOptedIn")]
        bool IsLocationOptedIn ();

        // - (BOOL)isLocationDeniedOrRestricted;
        [Export("isLocationDeniedOrRestricted")]
        bool IsLocationDeniedOrRestricted ();

        // - (BOOL)isLocationAccuracyReduced;
        [Export("isLocationAccuracyReduced")]
        bool IsLocationAccuracyReduced ();
    }
}

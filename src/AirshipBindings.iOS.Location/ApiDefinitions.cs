/*
 Copyright Airship and Contributors
*/
using CoreLocation;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using System;
using UIKit;
using UserNotifications;
using WebKit;

namespace UrbanAirship {

    [Static]
    partial interface Constants
    {
        // extern NSString * const UAAnalyticsValueNone
        [Field("UAAnalyticsValueNone", "__Internal")]
        NSString UAAnalyticsValueNone { get; }

        // extern UALocationEventUpdateType * const UALocationEventAnalyticsType
        [Field("UALocationEventAnalyticsType", "__Internal")]
        NSString UALocationEventAnalyticsType { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventDesiredAccuracyKey
        [Field("UALocationEventDesiredAccuracyKey", "__Internal")]
        NSString UALocationEventDesiredAccuracyKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventDistanceFilterKey
        [Field("UALocationEventDistanceFilterKey", "__Internal")]
        NSString UALocationEventDistanceFilterKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventForegroundKey
        [Field("UALocationEventForegroundKey", "__Internal")]
        NSString UALocationEventForegroundKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventHorizontalAccuracyKey
        [Field("UALocationEventHorizontalAccuracyKey", "__Internal")]
        NSString UALocationEventHorizontalAccuracyKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventLatitudeKey
        [Field("UALocationEventLatitudeKey", "__Internal")]
        NSString UALocationEventLatitudeKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventLongitudeKey
        [Field("UALocationEventLongitudeKey", "__Internal")]
        NSString UALocationEventLongitudeKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventProviderKey
        [Field("UALocationEventProviderKey", "__Internal")]
        NSString UALocationEventProviderKey { get; }

        // extern UALocationEventUpdateType * const UALocationEventUpdateTypeChange
        [Field("UALocationEventUpdateTypeChange", "__Internal")]
        NSString UALocationEventUpdateTypeChange { get; }

        // extern UALocationEventUpdateType * const UALocationEventUpdateTypeContinuous
        [Field("UALocationEventUpdateTypeContinuous", "__Internal")]
        NSString UALocationEventUpdateTypeContinuous { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventUpdateTypeKey
        [Field("UALocationEventUpdateTypeKey", "__Internal")]
        NSString UALocationEventUpdateTypeKey { get; }

        // extern UALocationEventUpdateType * const UALocationEventUpdateTypeNone
        [Field("UALocationEventUpdateTypeNone", "__Internal")]
        NSString UALocationEventUpdateTypeNone { get; }

        // extern UALocationEventUpdateType * const UALocationEventUpdateTypeSingle
        [Field("UALocationEventUpdateTypeSingle", "__Internal")]
        NSString UALocationEventUpdateTypeSingle { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventVerticalAccuracyKey
        [Field("UALocationEventVerticalAccuracyKey", "__Internal")]
        NSString UALocationEventVerticalAccuracyKey { get; }

        // extern UALocationServiceProviderType *const UALocationServiceProviderGps
        [Field("UALocationServiceProviderGps", "__Internal")]
        NSString UALocationServiceProviderGps { get; }

        // extern UALocationServiceProviderType *const UALocationServiceProviderNetwork
        [Field("UALocationServiceProviderNetwork", "__Internal")]
        NSString UALocationServiceProviderNetwork { get; }

        // extern UALocationServiceProviderType *const UALocationServiceProviderUnknown
        [Field("UALocationServiceProviderUnknown", "__Internal")]
        NSString UALocationServiceProviderUnknown { get; }
    }

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

    // @interface UALocation : UAComponent <UALocationProvider>
    [BaseType(typeof(UAComponent))]
    interface UALocation
    {
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

        // + (null_unspecified instancetype)shared;
        [Static]
        [New]
        [Export("shared")]
        UALocation Shared ();

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

    // @interface UALocationInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface UALocationInfo
    {
        // @property (nonatomic, readonly) double latitude;
        [Export("latitude")]
        double Latitude { get; }

        // @property (nonatomic, readonly) double longitude;
        [Export("longitude")]
        double Longitude { get; }

        // @property (nonatomic, readonly) double horizontalAccuracy;
        [Export("horizontalAccuracy")]
        double HorizontalAccuracy { get; }

        // @property (nonatomic, readonly) double verticalAccuracy;
        [Export("verticalAccuracy")]
        double VerticalAccuracy { get; }

        // + (nonnull instancetype)infoWithLatitude:(double)latitude longitude:(double)longitude horizontalAccuracy:(double)horizontalAccuracy verticalAccuracy:(double)verticalAccuracy;
        [Static]
        [Export("infoWithLatitude:longitude:horizontalAccuracy:verticalAccuracy:")]
        UALocationInfo Info (double latitude, double longitude, double horizontalAccuracy, double verticalAccuracy);
    }

    // @interface UALocationEvent : UAEvent
    [BaseType(typeof(UAEvent))]
    interface UALocationEvent
    {
        // + (nonnull UALocationEvent *) locationEventWithInfo:(nonnull UALocationInfo *)info providerType:(nullable UALocationServiceProviderType *)providerType desiredAccuracy:(nullable NSNumber *)desiredAccuracy distanceFilter:(nullable NSNumber *)distanceFilter;
        [Static]
        [Export("locationEventWithInfo:providerType:desiredAccuracy:distanceFilter:")]
        UALocationEvent LocationEvent (UALocationInfo info, [NullAllowed] string providerType, [NullAllowed] NSNumber desiredAccuracy, [NullAllowed] NSNumber distanceFilter);

        // + (nonnull UALocationEvent *) singleLocationEventWithInfo:(nonnull UALocationInfo *)info providerType: (nullable UALocationServiceProviderType *)providerType desiredAccuracy:(nullable NSNumber *)desiredAccuracy distanceFilter:(nullable NSNumber *)distanceFilter;
        [Static]
        [Export("singleLocationEventWithInfo:providerType:desiredAccuracy:distanceFilter:")]
        UALocationEvent SingleLocationEvent (UALocationInfo info, [NullAllowed] string providerType, [NullAllowed] NSNumber desiredAccuracy, [NullAllowed] NSNumber distanceFilter);

        // + (nonnull UALocationEvent *) significantChangeLocationEventWithInfo:(nonnull UALocationInfo *)info providerType: (nullable UALocationServiceProviderType *) providerType;
        [Static]
        [Export("significantChangeLocationEventWithInfo:providerType:")]
        UALocationEvent SignificantChangeLocationEvent (UALocationInfo info, [NullAllowed] string providerType);

        // + (nonnull UALocationEvent *) standardLocationEventWithInfo:(nonnull UALocationInfo *)info providerType: (nullable UALocationServiceProviderType *)providerType desiredAccuracy:(nullable NSNumber *)desiredAccuracy distanceFilter:(nullable NSNumber *)distanceFilter;
        [Static]
        [Export("standardLocationEventWithInfo:providerType:desiredAccuracy:distanceFilter:")]
        UALocationEvent StandardLocationEvent (UALocationInfo info, [NullAllowed] string providerType, [NullAllowed] NSNumber desiredAccuracy, [NullAllowed] NSNumber distanceFilter);
    }
}

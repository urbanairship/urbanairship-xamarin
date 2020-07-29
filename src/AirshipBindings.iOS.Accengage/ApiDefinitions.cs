/*
 Copyright Airship and Contributors
*/
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
    }

    // @interface ACCDeviceInformationSet : NSObject <NSCoding> /*! * @brief Set a string parameter to the data * * @param string The string parameter * @param key The key of your string parameter */ - (void)setString:(NSString *)string forKey:(NSString *)key; /*! * @brief Set a number parameter to the data * * @param number The number parameter * @param key The key of your number parameter */ - (void)setNumber:(NSNumber *)number forKey:(NSString *)key; /*! * @brief Set a date parameter to the data * * @param date The date parameter * @param key The key of your date parameter */ - (void)setDate:(NSDate *)date forKey:(NSString *)key; @end
    [BaseType(typeof(NSObject))]
    interface ACCDeviceInformationSet : INSCoding
    {
        // - (void)setString:(nonnull NSString *)string forKey:(nonnull NSString *)key;
        [Export("setString:forKey:")]
        void SetString (string @string, string key);

        // - (void)setNumber:(nonnull NSNumber *)number forKey:(nonnull NSString *)key;
        [Export("setNumber:forKey:")]
        void SetNumber (NSNumber number, string key);

        // - (void)setDate:(nonnull NSDate *)date forKey:(nonnull NSString *)key;
        [Export("setDate:forKey:")]
        void SetDate (NSDate date, string key);
    }

    // @interface ACCUserProfile : NSObject ///----------------------------------------------------------------------------- /// @name Update device information ///----------------------------------------------------------------------------- /*! * @brief Update device information * * @param deviceInformation A @c ACCDeviceInformationSet object containing all information to update * * @see ACCDeviceInformationSet */ - (void)updateDeviceInformation:(ACCDeviceInformationSet *)deviceInformation withCompletionHandler:(nullable void(^)(NSError *__nullable error))completionHandler; @end
    [BaseType(typeof(NSObject))]
    interface ACCUserProfile
    {
        // - (void)updateDeviceInformation: (nonnull ACCDeviceInformationSet *)deviceInformation withCompletionHandler: (nullable void (^)(NSError *_Nullable))completionHandler;
        [Export("updateDeviceInformation:withCompletionHandler:")]
        void UpdateDeviceInformation (ACCDeviceInformationSet deviceInformation, [NullAllowed] Action completionHandler);
    }

    // @interface Accengage : NSObject /*! * @brief Returns the shared @c ACCUserProfile instance. * * @return The shared @c ACCUserProfile instance. */ + (ACCUserProfile *)profile; @end
    [BaseType(typeof(NSObject))]
    interface Accengage
    {
        // + (nonnull ACCUserProfile *)profile;
        [Static]
        [Export("profile")]
        ACCUserProfile Profile ();
    }
}

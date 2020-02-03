/*
 Copyright Airship and Contributors
*/
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
        // extern NSString *const UARateAppItunesIDKey
        [Field("UARateAppItunesIDKey", "__Internal")]
        NSString UARateAppItunesIDKey { get; }

        // extern NSString *const UARateAppLinkPromptBodyKey
        [Field("UARateAppLinkPromptBodyKey", "__Internal")]
        NSString UARateAppLinkPromptBodyKey { get; }

        // extern NSString *const UARateAppLinkPromptTitleKey
        [Field("UARateAppLinkPromptTitleKey", "__Internal")]
        NSString UARateAppLinkPromptTitleKey { get; }

        // extern NSString *const UARateAppShowLinkPromptKey
        [Field("UARateAppShowLinkPromptKey", "__Internal")]
        NSString UARateAppShowLinkPromptKey { get; }

    }

    // @interface UAExtendedActionsResources : NSObject
    [BaseType(typeof(NSObject))]
    interface UAExtendedActionsResources
    {
        // + (nonnull NSBundle *)bundle;
        [Static]
        [Export("bundle")]
        NSBundle Bundle ();
    }

    // @interface UARateAppAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UARateAppAction
    {
        // - (NSArray *)rateAppLinkPromptTimestamps;
        [Export("rateAppLinkPromptTimestamps")]
        NSObject[] RateAppLinkPromptTimestamps ();

        // - (NSArray *)rateAppPromptTimestamps;
        [Export("rateAppPromptTimestamps")]
        NSObject[] RateAppPromptTimestamps ();
    }


}

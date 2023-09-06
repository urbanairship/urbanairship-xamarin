/*
 Copyright Airship and Contributors
*/

using Foundation;

namespace UrbanAirship {

    [Static]
    partial interface Constants
    {
        // extern NSString *const UARateAppActionDefaultRegistryAlias
        [Field("UARateAppActionDefaultRegistryAlias", "__Internal")]
        NSString UARateAppActionDefaultRegistryAlias { get; }

        // extern NSString *const UARateAppActionDefaultRegistryName
        [Field("UARateAppActionDefaultRegistryName", "__Internal")]
        NSString UARateAppActionDefaultRegistryName { get; }

        // extern NSString *const UARateAppItunesIDKey
        [Field("UARateAppItunesIDKey", "__Internal")]
        NSString UARateAppItunesIDKey { get; }

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

    // @interface UARateAppAction : NSObject <UAAction>
    [BaseType(typeof(NSObject))]
    interface UARateAppAction : IUAAction
    {
    }
}

/*
 Copyright Airship and Contributors
*/

using Foundation;
using ObjCRuntime;
using System;
using WebKit;

namespace UrbanAirship {

    [Static]
    partial interface Constants
    {
    }

    // @protocol UAComponent <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAComponent
    {
        // - (BOOL)deepLink:(nonnull NSURL *)deepLink;
        [Export("deepLink:")]
        bool DeepLink (NSUrl deepLink);
    }

    interface IUAComponent { }

    // @interface UADisposable : NSObject
    [BaseType(typeof(NSObject))]
    interface UADisposable
    {
        // - (nonnull instancetype)init:(nonnull void (^)(void))disposalBlock;
        [Export("init:")]
        IntPtr Constructor (Action disposalBlock);

        // - (void)dispose;
        [Export("dispose")]
        [New]
        void Dispose ();
    }

    // @protocol UAEvent <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAEvent
    {
        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid ();
    }

    interface IUAEvent { }
}

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

    // @interface UAMediaAttachmentContent : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMediaAttachmentContent
    {
        // @property (nonatomic, readonly) NSString *body;
        [Export("body")]
        string Body { get; }

        // @property (nonatomic, readonly) NSString *title;
        [Export("title")]
        string Title { get; }

        // @property (nonatomic, readonly) NSString *subtitle;
        [Export("subtitle")]
        string Subtitle { get; }

    }

    // @interface UAMediaAttachmentURL : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMediaAttachmentURL
    {
        // @property (nonatomic, readonly) NSString *urlID;
        [Export("urlID")]
        string UrlID { get; }

        // @property (nonatomic, readonly) NSURL *url;
        [Export("url")]
        NSUrl Url { get; }

    }

    // @interface UAMediaAttachmentPayload : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMediaAttachmentPayload
    {
        // @property (nonatomic, readonly) NSMutableArray *urls;
        [Export("urls")]
        NSMutableArray Urls { get; }

        // @property (nonatomic, readonly) NSDictionary *options;
        [Export("options")]
        NSDictionary Options { get; }

        // @property (nonatomic, readonly) UAMediaAttachmentContent *content;
        [Export("content")]
        UAMediaAttachmentContent Content { get; }

        // @property (nonatomic, readonly) NSString *thumbnailID;
        [Export("thumbnailID")]
        string ThumbnailID { get; }

        // + (instancetype)payloadWithJSONObject:(id)object;
        [Static]
        [Export("payloadWithJSONObject:")]
        UAMediaAttachmentPayload Payload (NSObject @object);
    }

    // @interface UANotificationServiceExtension : UNNotificationServiceExtension
    [BaseType(typeof(UNNotificationServiceExtension))]
    interface UANotificationServiceExtension
    {

        // - (NSString *)uniformTypeIdentifierForData:(NSData *)data;
        [Export("uniformTypeIdentifierForData:")]
        string UniformTypeIdentifier (NSData data);
    }


}

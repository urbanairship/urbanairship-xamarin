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


    }

    // @interface UAMediaAttachmentContent : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMediaAttachmentContent
    {
        // @property (readonly, nonatomic) NSString *body;
        [Export("body")]
        string Body { get; }

        // @property (readonly, nonatomic) NSString *title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, nonatomic) NSString *subtitle;
        [Export("subtitle")]
        string Subtitle { get; }

    }

    // @interface UAMediaAttachmentURL : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMediaAttachmentURL
    {
        // @property (readonly, nonatomic) NSString *urlID;
        [Export("urlID")]
        string UrlID { get; }

        // @property (readonly, nonatomic) NSURL *url;
        [Export("url")]
        NSUrl Url { get; }

    }

    // @interface UAMediaAttachmentPayload : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMediaAttachmentPayload
    {
        // @property (readonly, nonatomic) NSMutableArray *urls;
        [Export("urls")]
        NSMutableArray Urls { get; }

        // @property (readonly, nonatomic) NSDictionary *options;
        [Export("options")]
        NSDictionary Options { get; }

        // @property (readonly, nonatomic) UAMediaAttachmentContent *content;
        [Export("content")]
        UAMediaAttachmentContent Content { get; }

        // @property (readonly, nonatomic) NSString *thumbnailID;
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

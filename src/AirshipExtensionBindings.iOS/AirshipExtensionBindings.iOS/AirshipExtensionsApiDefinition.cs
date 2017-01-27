/*
 Copyright 2017 Urban Airship and Contributors
*/

using Foundation;
using UserNotifications;

namespace AirshipAppExtensions
{
	// @interface UAMediaAttachmentExtension : UNNotificationServiceExtension
	[BaseType(typeof(UNNotificationServiceExtension))]
	interface UAMediaAttachmentExtension
	{
		// -(NSString *)uniformTypeIdentifierForData:(NSData *)data;
		[Export("uniformTypeIdentifierForData:")]
		string UniformTypeIdentifier(NSData data);
	}

	// @interface UAMediaAttachmentContent : NSObject
	[BaseType(typeof(NSObject))]
	interface UAMediaAttachmentContent
	{
		// @property (readonly, nonatomic) NSString * body;
		[Export("body")]
		string Body { get; }

		// @property (readonly, nonatomic) NSString * title;
		[Export("title")]
		string Title { get; }

		// @property (readonly, nonatomic) NSString * subtitle;
		[Export("subtitle")]
		string Subtitle { get; }
	}

	// @interface UAMediaAttachmentPayload : NSObject
	[BaseType(typeof(NSObject))]
	interface UAMediaAttachmentPayload
	{
		// +(instancetype)payloadWithJSONObject:(id)object;
		[Static]
		[Export("payloadWithJSONObject:")]
		UAMediaAttachmentPayload Payload(NSObject @object);

		// @property (readonly, nonatomic) NSMutableArray * urls;
		[Export("urls")]
		NSMutableArray Urls { get; }

		// @property (readonly, nonatomic) NSDictionary * options;
		[Export("options")]
		NSDictionary Options { get; }

		// @property (readonly, nonatomic) UAMediaAttachmentContent * content;
		[Export("content")]
		UAMediaAttachmentContent Content { get; }
	}

}

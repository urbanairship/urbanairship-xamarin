/* Copyright Airship and Contributors */

#import <UserNotifications/UserNotifications.h>

/**
 * A notification service extension for downloading and attaching media.
 */
__TVOS_PROHIBITED __WATCHOS_PROHIBITED
@interface UANotificationServiceExtension : UNNotificationServiceExtension

/**
 * Method for inferring a Uniform Type Identifier for a media attachment if the file lacks an extension.
 *
 * @param data A memory-mapped NSData instance representing a downloaded attachment file
 * @return The inferred identifier, or nil if unsuccessful.
 */
- (NSString *)uniformTypeIdentifierForData:(NSData *)data;


@end

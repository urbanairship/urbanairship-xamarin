### FCM Migration

FCM migration is optional, but recommended as Google deprecated GCM and is planning on dropping
GCM client APIs in April of 2019. For more info, please read the [GCM F.A.Q](https://developers.google.com/cloud-messaging/faq).

Airship supports the FCM client library starting in SDK 9.1.0. It is available in a new package
`urbanairship.android.fcm`. The FCM package is not compatible with the deprecated package `UrbanAirship`.

Migration Steps:

- [Add Firebase to your app](https://firebase.google.com/docs/android/setup#add_firebase_to_your_app).
- [Import your GCM project as a Firebase project](https://developers.google.com/cloud-messaging/android/android-migrate-fcm#import-your-gcm-project-as-a-firebase-project).
- In your Android app, replace the `UrbanAirship` package with the new `urbanairship.android.core` and `urbanairship.android.fcm` packages.

See also the [Android SDK FCM Migration Guide](https://github.com/urbanairship/android-library/blob/main/documentation/migration/migration-guide-fcm.md).

More information on Xamarin SDK can be found in our [Xamarin Platform Guide](https://docs.urbanairship.com/platform/xamarin/).
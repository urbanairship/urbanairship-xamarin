# Airship Xamarin Changelog

## Version 14.2.0 - May 21, 2021
Minor release updating to latest Airship SDKs and adding support for live chat.

### Changes
- Updated iOS Airship SDK to 14.4.1
- Updated Android Airship SDK to 14.4.3
- Added urbanairship.ios.chat and urbanairship.android.chat packages

## Version 14.1.1 - February 12, 2021
Minor release to latest Airship SDKs and to fix missing methods in the Android FCM bindings.

### Changes
- Updated iOS Airship SDK to 14.2.3
- Updated Android Airship SDK to 14.1.3
- Fixed Android binding issues

## Version 14.1.0 - January 14, 2021
Minor release to support iOS SDK 14.2.1 and Android SDK 14.1.1.

### Changes
- Added frequency limits support to IAA
- Added support for advanced IAA segmentation
- Added a new search event template
- Added wishlist options to retail event template
- Added tel: sms: and mailto: to default allow list settings
- IAA messages no longer redisplay if interrupted due to app termination

## Version 14.0.0 - Sept 28, 2020
Major release to support iOS SDK 14.1.2 & Android SDK 14.0.1.

### Changes
Starting with SDK 14, all landing page and external urls are tested against a URL allow list. The easiest way to go back to 13.x behavior is to add the wildcard symbol `*` to the array under the URLAllowListScopeOpenURL key in your AirshipConfig.plist for iOS, and `urlAllowListScopeOpenUrl = *` to the airshipconfig.properties on Android. Config for `whitelist` has been removed and replaced with:
-  iOS: `URLAllowList`, Android: `urlAllowList`
-  iOS: `URLAllowListScopeOpenURL`, Android: `urlAllowListScopeOpenUrl`
-  iOS: `URLAllowListScopeJavaScriptInterface`, Android: `urlAllowListScopeJavaScriptInterface`

## Version 13.1.0 - July 28, 2020
Minor release adding Date and NamedUser attributes as well as
MessageCenter and Deep Link event support to the .NETStandard libraries,
and providing a new Xamarin Forms based sample app.

- Updated Android SDK to 13.3.2
- Updated iOS SDK to 13.5.2
- Added Message Center and Deep Link events to the .NETStandard library
- Added Date and Named user attributes support to the .NETStandard library
- New sample app written using Xamarin Forms.

## Version 13.0.0 - April 3, 2020
Major release to support Android SDK 12.2.3 and cross-platform attributes. Android platform
now requires compatibility with Jetpack/AndroidX.

### Changes
- Updated Android SDK to 12.2.3
- Migrated Android bindings projects to use AndroidX
- Added string and number attribute support to Android, iOS and .NETStandard/PCL
- Added sample content extension to ios-unified sample project

## Version 12.0.1 - March 23, 2020
Patch addressing a regression in iOS SDK 13.1.0 causing channel tag loss
when upgrading from iOS SDK versions prior to 13.0.1. Apps upgrading from xamarin plugin
11.1.0 or below should avoid plugin version 12.0.0 in favor of version 12.0.1.

### Changes
- Updated iOS SDK to 13.1.1

## Version 12.0.0 - February 10, 2020
Major release to support iOS SDK 13.1.0.

### Changes
- Updated iOS SDK to 13.1.0
- Created new package layout for the new iOS SDK modules:
  - New packages
    - UrbanAirship.iOS.Automation
    - UrbanAirship.iOS.Core
    - UrbanAirship.iOS.ExtendedActions
    - UrbanAirship.iOS.MessageCenter
    - UrbanAirship.iOS.NotificationContentExtension
  - Renamed packages
    - UrbanAirship.iOS.locationkit -> UrbanAirship.iOS.location
    - UrbanAirship.iOS.AppExtensions -> UrbanAirship.iOS.NotificationServicEextension
  - Removed undefined constants from iOS bindings.
  - Changes handling of CustomEvent generics in .NETStandard and PCL libraries.
  - Fixed nupkg installations failing to link with missing symbol errors.
  - Fixed .NETStandard and PCL app crashes when adding a custom event (Airship.Instance.AddCustomEvent())

## Version 11.1.0 - December 9, 2019
Patch release to fix a bug affecting loss of tags on iOS during app migration to iOS SDK 12.0.0.
This patch release fixes the bug by combining previous tags with tags that have been set since the update
to iOS SDK 12.0.0. Applications using iOS SDK 12.0.0 should update.

### Changes
- Update iOS SDK to 12.1.2

## Version 11.0.0 - October 28, 2019
- Update iOS SDK to 12.0.0

## Version 10.1.1 – August 13, 2019
- Update Android SDK to 10.1.1
- Patch release to fix direct open reporting for notifications when an activity is resumed from the background

## Version 10.1.0  - July 11, 2019
- Update iOS SDK to 11.1.0
- Fixed problem with installation of new iOS LocationKit package.

## Version 10.0.0 - July 1, 2019
- Update Android SDK to 10.0.2
- Update iOS SDK to 11.0.0
- Android GCM support has been removed. Please use FCM instead.
- Android preference support has been moved to the urbanairship.android.preference package.
- iOS location support has been moved to the urbanairship.ios.locationkit package.
- Location support has been removed from the PCL and .NETStandard libraries.

## Version 9.4.1 - April 19, 2019
- Update package references to better support Xamarin 9.x
- Update Android package dependencies to target API level 28
- Update Android package to 9.7.1.1. SDK remains at 9.7.1
- Update iOS SDK to 10.2.2

## Version 9.4.0 - March 14, 2019
Fixed a security issue within Urban Airship SDK, that could allow trusted URL redirects in certain
edge cases. Affected package versions include the deprecated urbanairship package 5.0.0 - 5.0.2, the
urbanairship.android packages 9.2.0 - 9.5.6, as well as the urbanairship.netstandard and
urbanairship.portable packages 9.0.0 - 9.3.3. Apps using any of these should update as soon as possible.
For more details, please email security@urbanairship.com.

- Update Android SDK to 9.7.2
- iOS SDK remains at 10.0.3

## Version 9.3.3 - November 20, 2018
- Update Android SDK to 9.5.6
- iOS SDK remains at 10.0.3

## Version 9.3.2 - November 14, 2018
- Update Android SDK to 9.5.5
- iOS SDK remains at 10.0.3

## Version 9.3.1 – November 9, 2018
- Update iOS SDK to 10.0.3
- Update Android SDK to 9.5.4

## Version 9.3.0 - October 4, 2018
- Update iOS SDK to 10.0.1
- Android SDK version is still 9.5.2

## Version 9.2.0 - September 24, 2018
- Update iOS SDK to 9.4.0
- Update Android SDK to 9.5.2

## Version 9.1.0 - July 23, 2018
- Update iOS SDK to 9.3.2
- Updated Android SDK to 9.4.0

## Version 9.0.0 - May 22, 2018
- Updated iOS SDK to 9.1.0
- Updated Android SDK to 9.2.0.
- Split urbanairship package into iOS and Android packages. Also moved Android push providers into their own packages. `UrbanAirship` has been split into:
   - `UrbanAirship.iOS` (iOS)
   - `UrbanAirship.iOS.appextensions` (iOS Notification Service Extension)
   - `UrbanAirship.Android.Core` (Android core functionality)
   - `UrbanAirship.Android.ADM`  (Android ADM Push Provider)
   - `UrbanAirship.Android.FCM`  (Android FCM Push Provider)
   - `UrbanAirship.Android.GCM`  (Android GCM Push Provider)
- Starting with Version 9 of the Xamarin SDK, the version of the native bindings will track the native SDK version contained in that binding. The cross-platform libraries will be independently versioned.

## Version 5.0.2 - April 20, 2018
- Added a .NET 2.0 standard library package.

## Version 5.0.1 - April 10, 2018
- Updated iOS SDK to 9.0.5, and Android SDK to 9.0.6.
- Fix for undefined symbol errors in iOS bindings when using the mtouch linker.

## Version 5.0.0 - March 27, 2018
- Updated iOS and Android SDKs to 9.0.4

Note: Aside from SDK interface changes between 8.x and 9.x, iOS bindings have also
changed in that they no longer implicitly convert methods into properties.
Notably, accessors such as `UAirship.Push` and `UAirship.NamedUser` are now methods,
e.g. `UAirship.Push()` and `UAirship.NamedUser()`. This more closely reflects
the structure of the iOS SDK and will help to make bindings more stable moving forward.

## Version 4.6.4 - January 12, 2018
- Enable use of UAMessageCenterMessageViewController class.
- Enable use of initWithNibName:bundle: method in UAMessageCenterMessageViewController and UADefaultMessageCenterMessageViewController classes.

## Version 4.6.3 - December 12, 2017
- Enable use of IUAInAppMessageControllerDelegate protocol.

## Version 4.6.2 - December 5, 2017
- Enable use of IUAInboxDelegate protocol.

## Version 4.6.1 - October 2, 2017
- Deep link action had a run-time exception caused by ActionBlock having an incorrect binding.
- Sample Push Handler was not validating a pointer, causing an NPE

## Version 4.6.0 - August 15, 2017
- Update Android Urban Airship SDK to 8.8.2.
- Update iOS Urban Airship SDK to 8.5.2.

## Version 4.5.1 - June 28, 2017
- Fix iOS Sample for Xamarin component submission.

## Version 4.5.0 - June 27, 2017
- Update Android Urban Airship SDK to 8.6.0 (Android O support)

## Version 4.4.3 - May 23, 2017
- Update Android Urban Airship SDK to 8.4.2.
- Update iOS Urban Airship SDK to 8.3.3.

## Version 4.4.2 - May 10, 2017
- Update Android Urban Airship SDK to 8.4.1.

## Version 4.4.1 - May 9, 2017
- Update iOS Urban Airship SDK to 8.3.1.

## Version 4.4.0 - May 4, 2017
- Update Android Urban Airship SDK to 8.4.0.
- Update iOS Urban Airship SDK to 8.3.0.

## Version 4.3.0 - April 5, 2017
- Update Android Urban Airship SDK to 8.3.2.
- Add delegate methods to Android bindings.

## Version 4.2.2 - March 27, 2017
- Fixed dYSM generation build warnings.

## Version 4.2.1 - March 22, 2017
- Update Android Urban Airship SDK to 8.3.1.

## Version 4.2.0 - March 17, 2017
- Update Android Urban Airship SDK to 8.3.0.
- Update iOS bindings with proper memory assignment.

## Version 4.1.1 - March 10, 2017
- Fixed error on install when trying to use the Urban Airship portable library inside another PCL.

## Version 4.1.0 - February 23, 2017
- Added an Urban Airship portable class library for use in Xamarin Forms apps.

## Version 4.0.1 - January 26, 2017
- Updated iOS Urban Airship SDK to 8.1.6

## Version 4.0.0 - December 16, 2016
- Updated iOS SDK to 8.1.4
- Updated Android SDK to 8.2.2
- iOS Media Extension is available as a Nuget package

## Version 3.1.1 - October 20, 2016
- Removed the Urban Airship app extension due to deployment issues with older iOS devices. The extension will be restored in a later version of the component.

## Version 3.1.0 - October 13, 2016
- Component is compatible with Urban Airship app extension bindings
- Fixed build errors when linker is disabled

## Version 3.0.0 - October 4, 2016
- Updated iOS Urban Airship SDK to 8.0.2

## Version 2.2.2 - July 22, 2016
- Fixed missing Android bindings for UrbanAirship.Push.Notifications package.

## Version 2.2.1 - July 6, 2016
- Fixed native linking errors for missing UAWalletAction on iOS

## Version 2.2.0 - June 2, 2016
- Updated iOS Urban Airship SDK to 7.2.0
- Updated Android Urban Airship SDK to 7.1.5

## Version 2.1.0 - May 13, 2016
- Updated iOS Urban Airship SDK to 7.1.2
- Updated Android Urban Airship SDK to 7.1.3
- Added NuGet package and shell component support

## Version 2.0.5 - April 22, 2016
 - Added iOS bindings for region events

## Version 2.0.4 - April 6, 2016
 - Fixed missing AndroidManifest entries for the  MessageCenterActivity and MessageActivity.

## Version 2.0.3 - March 21, 2016
 - Fixed Android LocationCallback bindings

## Version 2.0.2 - March 1, 2016
 - Fixed Android linker issues

## Version 2.0.1 - Feb 17, 2016
 - Fixed Android not registering the GcmPushReceiver

## Version 2.0.0 - Feb 11, 2016
 - Updated iOS Urban Airship SDK to 7.0.2
 - Updated Android Urban Airship SDK to 7.0.1
 - Added Default Message Center support

## Version 1.0.0 - Nov 23, 2015
  - Initial release. Binds SDK 6.4.0

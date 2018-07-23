# Urban Airship Xamarin Library

This library provides official bindings to the Urban Airship SDK, as well as sample applications for both iOS and Android.

> Note: The library has moved to https://github.com/urbanairship/urbanairship-xamarin

### Release Notes

Version 9.1 - July 23, 2018
===========================
- Update iOS SDK to 9.3.2
- Updated Android SDK to 9.4.0

Version 9 - May 22, 2018
=============================
- Updated iOS SDK to 9.1.0
- Updated Android SDK to 9.2.0.

Note: Android SDK version 9.1.0 introduced support for FCM apis, modular packages, and in-app message design updates. More Android-specific details are available in the [changelog](https://github.com/urbanairship/android-library/blob/9.1.0/CHANGELOG.md). For FCM migration, please follow the [FCM Migration Guide](documentation/migration-guide-fcm.md).

Changes
-------
- Split urbanairship package into iOS and Android packages. Also moved Android push providers into their own packages. `urbanairship` has been split into:

   - `urbanairship.ios` (iOS)
   - `urbanairship.ios.appextensions` (iOS Notification Service Extension)
   - `urbanairship.android.core` (Android core functionality)
   - `urbanairship.android.adm`  (Android ADM Push Provider)
   - `urbanairship.android.fcm`  (Android FCM Push Provider)
   - `urbanairship.android.gcm`  (Android GCM Push Provider)
- Starting with Version 9 of the Xamarin SDK, the version of the native bindings will track the native SDK version contained in that binding. The cross-platform libraries will be independently versioned.

Package | Version
--- | ---
urbanairship.android.* | 9.2.0
urbanairship.ios.* | 9.1.0  
urbanairship.netstandard | 9.0.0
urbanairship.portable | 9.0.0

Version 5.0.2 - April 20, 2018
==============================
- Added a .NET 2.0 standard library package.

Version 5.0.1 - April 10, 2018
===============================
- Updated iOS SDK to 9.0.5, and Android SDK to 9.0.6.
- Fix for undefined symbol errors in iOS bindings when using the mtouch linker.

Version 5.0.0 - March 27, 2018
==============================
- Updated iOS and Android SDKs to 9.0.4

Note: Aside from SDK interface changes between 8.x and 9.x, iOS bindings have also
changed in that they no longer implicitly convert methods into properties.
Notably, accessors such as `UAirship.Push` and `UAirship.NamedUser` are now methods,
e.g. `UAirship.Push()` and `UAirship.NamedUser()`. This more closely refelcts
the structure of the iOS SDK and will help to make bindings more stable moving forward.  

Version 4.6.4 - January 12, 2018
=============================
- Enable use of UAMessageCenterMessageViewController class.
- Enable use of initWithNibName:bundle: method in UAMessageCenterMessageViewController and UADefaultMessageCenterMessageViewController classes.

Version 4.6.3 - December 12, 2017
=============================
- Enable use of IUAInAppMessageControllerDelegate protocol.

Version 4.6.2 - December 5, 2017
=============================
- Enable use of IUAInboxDelegate protocol.

Version 4.6.1 - October 2, 2017
=============================
- Deep link action had a run-time exception caused by ActionBlock having an incorrect binding.
- Sample Push Handler was not validating a pointer, causing an NPE

Version 4.6.0 - August 15, 2017
=============================
- Update Android Urban Airship SDK to 8.8.2.
- Update iOS Urban Airship SDK to 8.5.2.

Version 4.5.1 - June 28, 2017
=============================
- Fix iOS Sample for Xamarin component submission.

Version 4.5.0 - June 27, 2017
=============================
- Update Android Urban Airship SDK to 8.6.0 (Android O support)

Version 4.4.3 - May 23, 2017
============================
- Update Android Urban Airship SDK to 8.4.2.
- Update iOS Urban Airship SDK to 8.3.3.

Version 4.4.2 - May 10, 2017
============================
- Update Android Urban Airship SDK to 8.4.1.

Version 4.4.1 - May 9, 2017
===========================
- Update iOS Urban Airship SDK to 8.3.1.

Version 4.4.0 - May 4, 2017
===========================
- Update Android Urban Airship SDK to 8.4.0.
- Update iOS Urban Airship SDK to 8.3.0.

Version 4.3.0 - April 5, 2017
=============================
- Update Android Urban Airship SDK to 8.3.2.
- Add delegate methods to Android bindings.

Version 4.2.2 - March 27, 2017
==============================
- Fixed dYSM generation build warnings.

Version 4.2.1 - March 22, 2017
==============================
- Update Android Urban Airship SDK to 8.3.1.

Version 4.2.0 - March 17, 2017
==============================
- Update Android Urban Airship SDK to 8.3.0.
- Update iOS bindings with proper memory assignment.

Version 4.1.1 - March 10, 2017
==============================
- Fixed error on install when trying to use the Urban Airship portable library inside another PCL.

Version 4.1.0 - February 23, 2017
=================================
- Added an Urban Airship portable class library for use in Xamarin Forms apps.

Version 4.0.1 - January 26, 2017
================================
- Updated iOS Urban Airship SDK to 8.1.6

Version 4.0.0 - December 16, 2016
=================================
- Updated iOS SDK to 8.1.4
- Updated Android SDK to 8.2.2
- iOS Media Extension is available as a Nuget package

Version 3.1.1 - October 20, 2016
================================
- Removed the Urban Airship app extension due to deployment issues with older iOS devices. The extension will be restored in a later version of the component.

Version 3.1.0 - October 13, 2016
================================
- Component is compatible with Urban Airship app extension bindings
- Fixed build errors when linker is disabled

Version 3.0.0 - October 4, 2016
===============================
- Updated iOS Urban Airship SDK to 8.0.2

Version 2.2.2 - July 22, 2016
=============================
- Fixed missing Android bindings for UrbanAirship.Push.Notifications package.

Version 2.2.1 - July 6, 2016
============================
- Fixed native linking errors for missing UAWalletAction on iOS

Version 2.2 - June 2, 2016
==========================
- Updated iOS Urban Airship SDK to 7.2.0
- Updated Android Urban Airship SDK to 7.1.5

Version 2.1 - May 13, 2016
==========================
- Updated iOS Urban Airship SDK to 7.1.2
- Updated Android Urban Airship SDK to 7.1.3
- Added NuGet package and shell component support

Version 2.0.5 - April 22, 2016
==============================
 - Added iOS bindings for region events

Version 2.0.4 - April 6, 2016
==============================
 - Fixed missing AndroidManifest entries for the  MessageCenterActivity and MessageActivity.

Version 2.0.3 - March 21, 2016
==============================
 - Fixed Android LocationCallback bindings

Version 2.0.2 - March 1, 2016
=============================
 - Fixed Android linker issues

Version 2.0.1 - Feb 17, 2016
============================
 - Fixed Android not registering the GcmPushReceiver

Version 2.0 - Feb 11, 2016
==========================
 - Updated iOS Urban Airship SDK to 7.0.2
 - Updated Android Urban Airship SDK to 7.0.1
 - Added Default Message Center support

Version 1.0 - Nov 23, 2015
==========================
  - Initial release. Binds SDK 6.4.0

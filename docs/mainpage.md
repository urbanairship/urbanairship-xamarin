# Airship .NET

The Airship .NET SDK exposes a common subset of functionality between
the iOS and Android SDKs. This library is built against .NET 6.0, and can be used
within shared codebases (e.g., a MAUI app).

## Compatibility

The Airship .NET SDK targets the following platforms:
- `net6.0`
- `net6.0-android`
- `net6.0-ios`

The Airship .NET SDK is compatible with:
- Android 5.0 (API 21) or higher.
- iOS 13 or higher, using the latest supported release of Xcode.

## Resources
- [Getting started guide](https://docs.airship.com/platform/mobile/setup/sdk/xamarin/)
- [Mobile platform documentation](https://docs.airship.com/platform/mobile/)

## Setup

Use NuGet to install the `airship.net` package.

### Optional Feature Packages

* `airship.net.messagecenter` - Provides a cross-platform control that can be used to display Message Center messages.

Detailed instructions can be found in the [Getting started guide](https://docs.airship.com/platform/mobile/setup/sdk/xamarin/).

A cross-platform sample app is provided in the `MauiSample` directory on
[Github](https://github.com/urbanairship/urbanairship-xamarin/tree/main/MauiSample).

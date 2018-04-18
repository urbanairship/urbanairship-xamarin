# AirshipBindings .NET Standard Library and Portable Class Library

The AirshipBindings .NET standard library and portable client library expose a common subset
of functionality between the iOS and Android SDKs. These libraries can be used within
shared codebases (e.g., a Xamarin Forms app).

The .NET standard library is built against .NET 2.0. If in doubt, apps may continue to use the PCL,
but new shared codebases with the freedom to choose are encouraged to use the new library.

## Requirements
 - Xamarin.iOS and Xamarin.Android
 - NetStandard 2.0 requires a minimum of Xamarin.iOS 10.14 and Xamarin.Android 8.0, respectively

## Resources:
 - [Getting started guide](http://docs.urbanairship.com/platform/xamarin.html)

## Setup
Use NuGet to install the either the urbanairship.netstandard or the urbanairship.portable package.
Detailed instructions can be found in the [Getting started guide](http://docs.urbanairship.com/platform/xamarin.html#installation).

Both Android and iOS example apps are provided in the `samples/` directory on
[Github](https://github.com/urbanairship/xamarin-component).

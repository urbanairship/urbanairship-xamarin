# Airship Xamarin Library

This library provides official bindings to the Airship SDK, as well as sample applications for both iOS and Android.

### Resources

 - [Xamarin Platform Doc](http://docs.urbanairship.com/platform/xamarin.html)
 - [Getting Started](GettingStarted.md)
 - [CHANGELOG](CHANGELOG.md)


### Building

Before running the `build.sh` script or trying to build either iOS projects, you must
run `carthage update` in the root repo directory. This will fetch and build the version
of iOS Airship SDK defined in the `Cartfile`. Carthage can be installed with
`brew update && brew install carthage`.

# Airship Xamarin Cross-Platform Sample App

This cross-platform sample application allows you to experiment with the Airship SDK. It is written using our NETStandard library.

## Resources

- [Xamarin Platform Doc](http://docs.urbanairship.com/platform/xamarin.html)
- [Getting Started](../GettingStarted.md)

### Building

To build the sample apps, run `./gradlew :SampleApp:build` in the root of the repository.
The build requires Carthage, which can be installed with `brew update && brew install carthage`.
Out-of-date packages can get stuck in the nuget cache. If you see this, run `nuget locals global-packages -clear`.

### Running

Once you have built the sample app and its dependencies as above, start VisualStudio and open `SampleApp/SampleApp.sln` to run the iOS or Android flavors of the sample app.
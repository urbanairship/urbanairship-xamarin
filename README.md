# Urban Airship Xamarin Component

This component provides official bindings to the Urban Airship SDK, as well as sample applications for both iOS and Android.

### Contributing Code

We accept pull requests! If you would like to submit a pull request, please fill out and submit a
Code Contribution Agreement (http://docs.urbanairship.com/contribution-agreement.html).

### Resources

 - [Xamarin Platform Doc](http://docs.urbanairship.com/platform/xamarin.html)
 - [Getting Started](component/GettingStarted.md)
 - [CHANGELOG](CHANGELOG.md)


### Building

Before running the `build.sh` script or trying to build either iOS projects, you must
run `carthage update` in the root repo directory. This will fetch and build the version
of iOS Urban Airship SDK defined in the `Cartfile`. Carthage can be installed with
`brew update && brew install carthage`.

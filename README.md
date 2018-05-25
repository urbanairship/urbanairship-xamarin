# Urban Airship Xamarin Library

This library provides official bindings to the Urban Airship SDK, as well as sample applications for both iOS and Android.

### Contributing Code

We accept pull requests! If you would like to submit a pull request, please fill out and submit our
[Contributor License Agreement](https://docs.google.com/forms/d/e/1FAIpQLScErfiz-fXSPpVZ9r8Di2Tr2xDFxt5MgzUel0__9vqUgvko7Q/viewform).

One of our engineers will verify receipt of the agreement before approving your pull request.

### Resources

 - [Xamarin Platform Doc](http://docs.urbanairship.com/platform/xamarin.html)
 - [Getting Started](GettingStarted.md)
 - [CHANGELOG](CHANGELOG.md)


### Building

Before running the `build.sh` script or trying to build either iOS projects, you must
run `carthage update` in the root repo directory. This will fetch and build the version
of iOS Urban Airship SDK defined in the `Cartfile`. Carthage can be installed with
`brew update && brew install carthage`.

# Airship .NET Development

## Environment Setup

### Requirements

* Visual Studio for Mac ([stable](https://visualstudio.microsoft.com/vs/mac/) or [preview](https://visualstudio.microsoft.com/vs/mac/preview/))
* A supported Xcode version (at the time of writing, VS 2022 supported Xcode 14.2)
* OpenJDK 11
  * Using [Homebrew](https://brew.sh/): `brew install openjdk@11`
  * Or [SDKMAN!](https://sdkman.io/): `sdk install java 11.0.18-zulu`
* Android SDK: API 31+ platform, emulator, build tools, command line tools, etc.
* .NET6 SDK (install via VS)
* .NET Workloads (install via VS): maui, android, ios
* Doxygen & Graphviz (`brew install doxygen graphviz`)
* Carthage (`brew install carthage`)

### Etc.

[dotnet-maui-check](https://github.com/Redth/dotnet-maui-check) is a tool that can help verify your environment, but it's not been updated in a while and may raise warnings incorrectly. If you do want to give it a shot, you can skip problematic checks with: `maui-check -s xcode -s androidemulator`.

Also, if you need to maintain multiple versions for native or other framework development, [XcodesApp](https://github.com/RobotsAndPencils/XcodesApp) is a handy tool that helps with that.

## Development

### Initial Setup

1. Follow the getting started guide to add the Airship configs and `google-services.json` files in the following locations:
    * `MauiSample/Platforms/Android/Assets/airshipconfig.properties`
    * `MauiSample/Platforms/Android/Assets/google-services.json`
    * `MauiSample/Platforms/iOS/AirshipConfig.plist`
1. Run `./gradlew build` to trigger generation of bindings and sync up versions set in the `airship.properties` file with the rest of the project.

### Airship Bindings and .NET SDK

1. Open `Airship.Net.sln` in VS for Mac.
1. Right click on the top-level `Airship.Net` solution item and select `Restore NuGet Packages`.

### Sample App

1. Run `./gradlew MauiSample:restore` to pack all Airship dependencies, create a local NuGet feed, and run a restore on the Sample app.
2. Open `MauiSample.sln` in VS for Mac.

### Combined Workflow

The sample app is also included in the main `Airship.Net` solution in order to aid development. `MauiSample.csproj` includes a `UseProjectReferences` property that can be used to switch between project references and NuGet packages (local or remote) for Airship bindings and .NET libraries. The default is `false` (to use NuGets) in order to allow the sample to be opened in isolation via `MauiSample.sln`.

While working on native bindings or at the .NET layer, `UseProjectReferences` can be set to `true` in order to allow all code in the project to be edited and built together. Once work is completed, `UseProjectReferences` should be set back to `false`, and the sample app should be tested using packed NuGets from the local feed.

### Updating

To update native bindings and .NET lib versions, edit the `airship.properties` file.

Bindings will be generated against the versions supplied for `iosVersion` and `androidVersion`. Cross-platform .NET packages will be versioned according to the `crossPlatformVersion`.

Note that `crossPlatformVersion` should be bumped according to the native SDK version with the most significant change. e.g., If bumping from iOS 2.0.0 -> 2.1.0 and Android 2.0.0 -> 2.0.1, and the cross platform version was previously 1.0.0, it should be bumped to 1.1.0.

Revision numbers can be used to make minor updates to previously released NuGet packages, in cases where no updates to the native SDK versions are needed. If any revision properties are set to a value greater than zero, the revision number will be added to the NuGet package version as a 4th segment (`MAJOR.MINOR.PATCH.REVISION`). A revision number of zero will be ignored, resulting in a 3-segment package version (`MAJOR.MINOR.PATCH`).

### Documentation

Doxygen is used to generate documentation from the .NET sources, via the `./gradlew docs:build` task. HTML documentation is output to the `docs/build/html` directory and archived to a versioned `.tar.gz` file in the `docs/build` dir.

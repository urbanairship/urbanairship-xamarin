#!/bin/bash -ex
ROOT_DIR=$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )

TOOLS_DIR=$ROOT_DIR/.tools
BUILD_DIR=$ROOT_DIR/build

COMPONENT_DIR=$ROOT_DIR/component
NUSPEC=$ROOT_DIR/UrbanAirship.nuspec
APP_EXTENSIONS_NUSPEC=$ROOT_DIR/AirshipAppExtensions.nuspec
PCL_NUSPEC=$ROOT_DIR/UrbanAirship.Portable.nuspec

ANDROID_BINDINGS=$ROOT_DIR/src/AirshipBindings.Android/AirshipBindings.Android.sln
IOS_BINDINGS=$ROOT_DIR/src/AirshipBindings.iOS/AirshipBindings.iOS.sln
IOS_APP_EXTENSION_BINDINGS=$ROOT_DIR/src/AirshipExtensionBindings.iOS/AirshipExtensionBindings.iOS.sln
AIRSHIP_PCL=$ROOT_DIR/src/AirshipBindings.Portable/AirshipBindings.Portable.sln

NUGET_EXE=$TOOLS_DIR/nuget.exe
XAMARIN_COMPONENT_EXE=$TOOLS_DIR/xamarin-component.exe
MDTOOL="/Applications/Xamarin Studio.app/Contents/MacOS/mdtool"

DOCS_DIR=$ROOT_DIR/docs

# Make sure the tools folder exist.
if [ ! -d "$TOOLS_DIR" ]; then
  mkdir "$TOOLS_DIR"
fi

# Download NuGet if it does not exist.
if [ ! -f "$NUGET_EXE" ]; then
    echo "Downloading NuGet..."
    curl -Lsfo "$NUGET_EXE" https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
    if [ $? -ne 0 ]; then
        echo "An error occured while downloading nuget.exe."
        exit 1
    fi
fi

# Download xamarin-component if it does not exist
if [ ! -f "$XAMARIN_COMPONENT_EXE" ]; then
    echo "Downloading xamarin-component..."
    curl -LSf https://components.xamarin.com/submit/xpkg | tar -xf- -C $TOOLS_DIR
    if [ $? -ne 0 ]; then
        echo "An error occured while downloading xamarin-component"
        exit 1
    fi
fi

# Clean
rm -rf $BUILD_DIR
mkdir $BUILD_DIR
rm -f $COMPONENT_DIR/*.xam
rm -rf $DOCS_DIR/build
mkdir $DOCS_DIR/build

# Build Android
echo "Building Android bindings"
mono $NUGET_EXE restore $ANDROID_BINDINGS
"$MDTOOL" build -c:Release $ANDROID_BINDINGS

# AirshipKit from Carthage
echo "Updating Carthage"
carthage update

# Build iOS
echo "Building iOS bindings"
mono $NUGET_EXE restore $IOS_BINDINGS
"$MDTOOL" build -c:Release $IOS_BINDINGS
"$MDTOOL" build -c:Release $IOS_APP_EXTENSION_BINDINGS

# Build PCL
echo "Building PCL"
mono $NUGET_EXE restore $AIRSHIP_PCL
"$MDTOOL" build -c:Release $AIRSHIP_PCL

# Build NuGet packages
echo "Building NuGet package"
mono $NUGET_EXE pack $NUSPEC -OutputDirectory $BUILD_DIR
mono $NUGET_EXE pack $APP_EXTENSIONS_NUSPEC -OutputDirectory $BUILD_DIR
mono $NUGET_EXE pack $PCL_NUSPEC -OutputDirectory $BUILD_DIR

# Build Xamarin component
echo "Building Xamarin component"
mono $XAMARIN_COMPONENT_EXE package $COMPONENT_DIR -OutputDirectory $BUILD_DIR
mv $COMPONENT_DIR/*.xam $BUILD_DIR

# Generate PCL documentation.
echo "Generating PCL documentation"
cd $DOCS_DIR
doxygen Doxyfile
cp theme/{doxy-boot.js,header.html,footer.html} build/html
cd $ROOT_DIR

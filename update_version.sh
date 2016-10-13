#!/bin/bash -ex
ROOT_DIR=$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )
VERSION=$1

# Nuspec
sed -i '' "s/<version>.*<\/version>/<version>$VERSION<\/version>/g" $ROOT_DIR/UrbanAirship.nuspec
sed -i '' "s/<version>.*<\/version>/<version>$VERSION<\/version>/g" $ROOT_DIR/AirshipAppExtensions.nuspec

# Xamarin component yaml
sed -i '' "s/version: \".*\"/version: \"$VERSION\"/g" $ROOT_DIR/component/component.yaml
sed -i '' "s/urbanairship, Version=[0-9]+\.[0-9]+\.[0-9]+/urbanairship, Version=$VERSION/g" $ROOT_DIR/component/component.yaml

# SharedAssemblyInfo.cs
sed -i '' "s/AssemblyVersion \(.*\)]/AssemblyVersion \(\"$VERSION\"\)]/g" $ROOT_DIR/src/SharedAssemblyInfo.cs

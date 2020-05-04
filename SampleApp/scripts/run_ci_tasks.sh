#!/bin/bash

# run_ci_tasks.sh [OPTIONS]
# where OPTIONS are:
#  -a to build Android
#  -i to build iOS
#  -c to clean before building
#  -b [Debug|Release]
#  Defaults to -a -i -b Release.

set -euxo pipefail

SCRIPT_NAME=`basename "$0"`
SCRIPT_PATH=`dirname "$0"`;cd ${SCRIPT_PATH};SCRIPT_PATH="$(pwd)"
IOS_SAMPLE_PATH="${SCRIPT_PATH}/../SampleApp.iOS";cd ${IOS_SAMPLE_PATH};IOS_SAMPLE_PATH="$(pwd)"
ANDROID_SAMPLE_PATH="${SCRIPT_PATH}/../SampleApp.Android";cd ${ANDROID_SAMPLE_PATH};ANDROID_SAMPLE_PATH="$(pwd)"
REPO_ROOT_PATH="${SCRIPT_PATH}/../..";cd ${REPO_ROOT_PATH};REPO_ROOT_PATH="$(pwd)"

# default build options
ANDROID=false
IOS=false
CLEAN=false
PLUGIN=false
BUILD_CONFIG="Release"

# Parse arguments
OPTS=`getopt haicpb: $*`

if [ $? != 0 ] ; then echo "Failed parsing options." >&2 ; exit 1 ; fi
eval set -- "$OPTS"

if [ "$1" == "--" ]; then
  # set the default options
  eval set -- "-a" "-i" "-b" "Release" $@
fi

while true; do
  case "${1:-}" in
    -h  ) echo -ne "\n${SCRIPT_NAME} [OPTIONS]\nwhere OPTIONS are:\n  -a to build Android\n  -i to build iOS\n  -c to clean before building.\n  -b [Debug|Release]\n  Defaults to -a -i -b Release. \n"; exit 0;;
    -a  ) ANDROID=true;;
    -i  ) IOS=true;;
    -c  ) CLEAN=true;;
    -p  ) PLUGIN=true;;
    -b  ) BUILD_CONFIG="${2:-}";shift;;
    --  ) ;;
    *   ) break ;;
  esac
  shift
done

# Prepare for CI Tasks
if [ "$ANDROID" = "true" ]; then
  # Make sure google-services.json exists
  GOOGLE_SERVICES_FILE_PATH="${ANDROID_SAMPLE_PATH}/Assets/google-services.json"
  if [[ ! -f ${GOOGLE_SERVICES_FILE_PATH} ]]; then
    echo "ERROR: You must provide ${GOOGLE_SERVICES_FILE_PATH}."
    exit 1
  fi
fi

TARGETS=""
if [ "$PLUGIN" = "true" ]; then
  TARGETS="build pkg"
fi
if [ "$ANDROID" = "true" ]; then
  # build android samples and our android and iOS components
  TARGETS="$TARGETS :SampleApp:SampleApp.Android:build"
fi
if [ "$IOS" = "true" ]; then
  # build ios sample and our android and iOS components
  TARGETS="$TARGETS :SampleApp:SampleApp.iOS:build"
fi

# Execute CI Tasks
if [[ "$TARGETS" != "" ]]; then
  cd "${REPO_ROOT_PATH}"
  if [ "$CLEAN" = "true" ]; then
    TARGETS="clean ${TARGETS}"
  fi
  ./gradlew ${TARGETS} -Pbuild_configuration=${BUILD_CONFIG}
fi

echo "CI TASKS SUCCEEDED" 

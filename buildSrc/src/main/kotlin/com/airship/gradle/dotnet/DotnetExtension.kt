package com.airship.gradle.dotnet

import java.io.File

open class DotnetExtension(
  projectDir: File
) {
  var dotnetExe: String = "dotnet"

  var solution: File? = null
  var csproj: File? = null

  var configuration: String = "Release"

  var workingDir: File = projectDir

  var verbosity: String = "normal"

  internal val target: File?
    get() = solution ?: csproj
}

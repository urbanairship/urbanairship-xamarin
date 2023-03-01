package com.airship.gradle.dotnet

import org.gradle.api.Plugin
import org.gradle.api.Project
import org.gradle.kotlin.dsl.create

class DotnetPlugin : Plugin<Project> {
  override fun apply(target: Project) = target.run {
    val ext = extensions.create<DotnetExtension>("dotnet", projectDir)


  }

}

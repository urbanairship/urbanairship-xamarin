package com.airship.gradle.dotnet.tasks

import org.gradle.api.provider.Property
import org.gradle.api.tasks.Input
import org.gradle.api.tasks.InputFile
import org.gradle.api.tasks.Optional
import org.gradle.api.tasks.OutputDirectory
import java.io.File

abstract class DotnetBuild : BaseDotnetBuildTask("build") {
  @get:OutputDirectory
  @get:Optional
  abstract val outputDir: Property<File>

  override val arguments: List<String>
    get() = super.arguments.toMutableList().apply {
      if (outputDir.isPresent) {
        addAll(listOf("--output", outputDir.get().absolutePath))
      }
    }
}

abstract class DotnetPack : BaseDotnetBuildTask("pack") {
  @get:OutputDirectory
  abstract val outputDir: Property<File>

  init {
    outputDir.convention(project.buildDir)
  }

  override val arguments: List<String>
    get() = super.arguments.toMutableList().apply {
      if (outputDir.isPresent) {
        addAll(listOf("--output", outputDir.get().absolutePath))
      }
    }
}

abstract class DotnetClean : BaseDotnetBuildTask("clean")

abstract class BaseDotnetBuildTask(command: String) : BaseDotnetTask(command) {
  @get:InputFile
  abstract val solution: Property<File>

  @get:Input
  abstract val configuration: Property<String>

  @get:Input
  abstract val verbosity: Property<String>

  init {
    verbosity.convention(ext.verbosity)
    configuration.convention(ext.configuration)

    ext.target?.let { solution.convention(it) }
  }

  override val arguments: List<String>
    get() = listOf(
      solution.get().absolutePath,
      "--verbosity", verbosity.get(),
      "--configuration", configuration.get(),
    )
}

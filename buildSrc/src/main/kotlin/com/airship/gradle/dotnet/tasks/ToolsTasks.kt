package com.airship.gradle.dotnet.tasks

import org.gradle.api.provider.Property
import org.gradle.api.tasks.Input


abstract class ToolRestore : BaseDotnetToolTask("restore") {
  @get:Input
  abstract val ignoreFailedSources: Property<Boolean>

  init {
    ignoreFailedSources.convention(false)
  }

  override val arguments: List<String>
    get() =  super.arguments + listOfNotNull(
        "--ignore-failed-sources".takeIf { ignoreFailedSources.get() }
    )
}

abstract class BaseDotnetToolTask(
  private var subcommand: String,
) : BaseDotnetTask("tool") {

  override val arguments: List<String>
    get() = listOf(subcommand)
}

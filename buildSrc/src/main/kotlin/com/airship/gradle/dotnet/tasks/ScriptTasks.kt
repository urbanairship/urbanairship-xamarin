package com.airship.gradle.dotnet.tasks

import org.gradle.api.provider.ListProperty
import org.gradle.api.provider.Property
import org.gradle.api.tasks.Input
import org.gradle.api.tasks.InputFile
import java.io.File

abstract class DotnetScript : BaseDotnetTask("script") {
  @get:InputFile
  abstract val script: Property<File>

  @get:Input
  abstract val scriptArgs: ListProperty<String>

  @get:Input
  abstract val noCache: Property<Boolean>

  init {
    scriptArgs.convention(emptyList())
    noCache.convention(false)
  }

  override val arguments: List<String>
    get() = listOfNotNull(
      "--no-cache".takeIf { noCache.get() },
      script.get().absolutePath,
    ) + scriptArgs.get()
}

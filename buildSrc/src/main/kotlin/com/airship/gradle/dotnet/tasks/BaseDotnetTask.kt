package com.airship.gradle.dotnet.tasks

import com.airship.gradle.dotnet.DotnetExtension
import org.gradle.api.logging.LogLevel
import org.gradle.api.tasks.AbstractExecTask
import org.gradle.api.tasks.Internal
import org.gradle.api.tasks.TaskAction
import org.gradle.kotlin.dsl.getByType

abstract class BaseDotnetTask(
  private val command: String
) : AbstractExecTask<BaseDotnetTask>(BaseDotnetTask::class.java) {

  init {
    logging.captureStandardOutput(LogLevel.LIFECYCLE)
    logging.captureStandardError(LogLevel.ERROR)
  }

  @TaskAction
  override fun exec() {
    executable = ext.dotnetExe
    args(command)
    args(arguments)

    logger.lifecycle("$ " + commandLine.joinToString(" ") + "\n[cwd = $workingDir]")

    super.exec()
  }

  @get:Internal
  protected abstract val arguments: List<String>

  @get:Internal
  protected val ext: DotnetExtension
    get() = project.extensions.getByType<DotnetExtension>()
}

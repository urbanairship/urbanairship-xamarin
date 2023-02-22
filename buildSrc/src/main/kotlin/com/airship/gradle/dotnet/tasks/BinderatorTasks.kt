package com.airship.gradle.dotnet.tasks

import com.airship.gradle.dotnet.ensureCreated
import com.beust.klaxon.JsonArray
import com.beust.klaxon.JsonObject
import com.beust.klaxon.Parser
import groovy.json.JsonException
import org.gradle.api.DefaultTask
import org.gradle.api.provider.Property
import org.gradle.api.tasks.Input
import org.gradle.api.tasks.InputDirectory
import org.gradle.api.tasks.InputFile
import org.gradle.api.tasks.OutputDirectory
import org.gradle.api.tasks.TaskAction
import java.io.File

abstract class AndroidBinderator : BaseDotnetTask("xamarin-android-binderator") {
  @get:InputFile
  abstract val configFile: Property<File>
  @get:Input
  abstract val basePath: Property<File>

  init {
    basePath.convention(project.projectDir)

    inputs.dir("source")
    outputs.dirs("generated", "externals")
  }

  override val arguments: List<String>
    get() = listOf("--config=${configFile.get().absolutePath}", "--basepath=${basePath.get().absolutePath}")
}

abstract class AndroidBinderatorSources : DefaultTask() {
  @get:InputFile
  abstract val configFile: Property<File>
  @get:InputDirectory
  abstract val bindingDir: Property<File>
  @get:InputDirectory
  abstract val templateDir: Property<File>
  @get:OutputDirectory
  abstract val sourceDir: Property<File>

  init {
    bindingDir.convention(project.file("generated"))
    sourceDir.convention(project.file("source"))
  }

  @TaskAction
  fun ensureSourceFiles() {
    val sources = sourceDir.get()
    val templates = templateDir.get()

    parseArtifacts(configFile.get())
      .filterNot { it.boolean("dependencyOnly") == true }
      .forEach { artifact ->
        val groupId = requireNotNull(artifact.string("groupId"))
        val artifactId = requireNotNull(artifact.string("artifactId"))

        val groupDir = sources.resolve(groupId).ensureCreated()
        val artifactDir = groupDir.resolve(artifactId).ensureCreated()

        artifactDir.resolve("Additions").ensureCreated()

        artifactDir.resolve("Transforms").ensureCreated()
          .let { transformsDir ->
            val metadataFile = transformsDir.resolve("Metadata.xml")
            if (!metadataFile.exists()) {
              project.copy {
                from(templates.resolve("artifact/Transforms/Metadata.xml"))
                to(metadataFile)
              }
              logger.lifecycle("Copied file: ${metadataFile.toRelativeString(project.rootDir)}")
            }

            val enumFieldsFile = transformsDir.resolve("EnumFields.xml")
            if (!enumFieldsFile.exists()) {
              project.copy {
                from(templates.resolve("artifact/Transforms/EnumFields.xml"))
                to(enumFieldsFile)
              }
              logger.lifecycle("Copied file: ${enumFieldsFile.toRelativeString(project.rootDir)}")

            }

            val enumMethodsFile = transformsDir.resolve("EnumMethods.xml")
            if (!enumMethodsFile.exists()) {
              project.copy {
                from(templates.resolve("artifact/Transforms/EnumMethods.xml"))
                to(enumMethodsFile)
              }
              logger.lifecycle("Copied file: ${enumMethodsFile.toRelativeString(project.rootDir)}")
            }
          }
      }
  }

  @Suppress("UNCHECKED_CAST")
  private fun parseArtifacts(config: File): JsonArray<JsonObject> {
    val json = config.inputStream().use {
      Parser.default().parse(it) as JsonArray<JsonObject>
    }
    return json[0].array("artifacts") ?: throw JsonException(
      "Failed to parse artifacts from config: ${config.toRelativeString(project.rootDir)}"
    )
  }
}

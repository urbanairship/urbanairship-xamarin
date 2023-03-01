import com.airship.gradle.dotnet.DotnetExtension
import com.airship.gradle.dotnet.tasks.AndroidBinderatorSources
import com.airship.gradle.dotnet.tasks.AndroidBinderator
import com.airship.gradle.dotnet.tasks.DotnetBuild
import com.airship.gradle.dotnet.tasks.DotnetPack
import com.airship.gradle.dotnet.tasks.DotnetScript
import com.airship.gradle.dotnet.tasks.ToolRestore

plugins {
  id("airship-dotnet")
}

configure<DotnetExtension> {
  solution = file("generated/airship-android.sln")
}

val binderatorConfigFile = file("config.json")
val binderatorGeneratedDir = file("generated")
val binderatorSourceDir = file("source")
val binderatorTemplateDir = file("source/templates")
val binderatorUpdateScript = file("scripts/update-config.csx")

tasks {
  val restoreTools = register<ToolRestore>("restoreTools") {
    ignoreFailedSources.set(true)
  }

  val syncVersion = register<DotnetScript>("syncVersion") {
    dependsOn(restoreTools)

    val androidVersion: String by rootProject

    script.set(binderatorUpdateScript)
    scriptArgs.addAll("--", binderatorConfigFile.name, "update", "-v${androidVersion}")
    noCache.set(true)

    inputs.property("androidVersion", androidVersion)
    outputs.file(binderatorConfigFile)
  }

  val ensureSources = register<AndroidBinderatorSources>("ensureSources") {
    configFile.set(binderatorConfigFile)
    bindingDir.set(binderatorGeneratedDir)
    sourceDir.set(binderatorSourceDir)
    templateDir.set(binderatorTemplateDir)
  }

  val binderate = register<AndroidBinderator>("binderate") {
    dependsOn(syncVersion, restoreTools)
    finalizedBy(ensureSources)

    configFile.set(binderatorConfigFile)
  }

  val build = register<DotnetBuild>("build") {
    dependsOn(binderate, ensureSources)
  }

  register<DotnetPack>("pack") {
    dependsOn(build)

    inputs.dir(binderatorGeneratedDir)
    outputDir.set(rootProject.buildDir)
  }

  register<DotnetScript>("checkMavenVersions") {
    dependsOn(restoreTools)

    script.set(file(binderatorUpdateScript))
    scriptArgs.addAll("--", binderatorConfigFile.name, "check")
    noCache.set(true)
  }

  register<DotnetScript>("checkPublishedNugets") {
    dependsOn(restoreTools)

    script.set(file(binderatorUpdateScript))
    scriptArgs.addAll("--", binderatorConfigFile.name, "published")
    noCache.set(true)
  }

  register<Delete>("clean") {
    delete(file("build").listFiles())
    delete(file("externals").listFiles())
    delete(file(binderatorGeneratedDir).listFiles())
  }
}

plugins {
  `kotlin-dsl`
  `java-gradle-plugin`
}

group = "build"

dependencies {
  implementation(kotlin("gradle-plugin"))
  implementation("com.beust:klaxon:5.5")

}

gradlePlugin {
  plugins {
    register("airship-dotnet") {
      id = "airship-dotnet"
      implementationClass = "com.airship.gradle.dotnet.DotnetPlugin"
    }
  }
}

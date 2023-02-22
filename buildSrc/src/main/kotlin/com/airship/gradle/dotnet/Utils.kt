package com.airship.gradle.dotnet

import java.io.File

fun File.ensureCreated(): File {
  if (!exists()) mkdirs()
  return this
}

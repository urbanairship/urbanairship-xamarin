// Tools needed by cake addins
#tool nuget:?package=vswhere&version=3.0.2
#tool nuget:?package=dotnet-script&version=1.4.0

// Cake Addins
#addin nuget:?package=Cake.FileHelpers&version=5.0.0
#addin nuget:?package=Newtonsoft.Json&version=13.0.1

// Binderator
#addin nuget:?package=xamarin.androidbinderator&version=2.3.4

using System;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

var TARGET = Argument("t", Argument("target", "default"));
var CONFIGURATION = Argument("c", Argument("configuration", "Release"));

var PACKAGE_OUTPUT_PATH = new DirectoryPath("../build");

string nuget_version_template = "xx.yy.zz-suffix";
string nuget_version_suffix = "";

// HELPERS

void RunProcess(FilePath fileName, string processArguments)
{
	Information($"RunProcess: {fileName}, {processArguments}");
	var exitCode = StartProcess(fileName, processArguments);
	if (exitCode != 0)
		throw new Exception ($"Process {fileName} exited with code {exitCode}.");
}

// TASKS

Task("default")
	.IsDependentOn("binderate")
	.Does(() => {});

Task("binderate")
	.IsDependentOn("binderate-config-verify")
  .Does(() =>
{
  Information($"Generating Android bindings (configuration: {CONFIGURATION})...");

	FilePath binderator = Context.Tools.Resolve("xamarin-android-binderator");
	var config = MakeAbsolute(new FilePath("./config.json")).FullPath;
	var basePath = MakeAbsolute(new DirectoryPath ("./")).FullPath;

  // Run the binderator tool
	RunProcess(binderator, $"--config=\"{config}\" --basepath=\"{basePath}\"");

  // Format the csproj files to fix any weirdness from templating
  var targetsFiles = GetFiles("generated/**/*.csproj");
  foreach (var targets in targetsFiles) {
      XDocument
        .Load(targets.FullPath)
        .Save(targets.FullPath);
  }

  Information("Android bindings generated successfully!");
});

Task("binderate-config-verify")
	.IsDependentOn("binderate-fix")
	.Does(() =>
{
  using (StreamReader reader = System.IO.File.OpenText(@"./config.json"))
  {
    JsonTextReader jtr = new JsonTextReader(reader);
    JArray ja = (JArray)JToken.ReadFrom(jtr);

    foreach(JObject jo in ja[0]["artifacts"])
    {
      bool? dependency_only = (bool?) jo["dependencyOnly"];
      if ( dependency_only == true) continue;

      string version = (string) jo["version"];
      string nuget_version = (string) jo["nugetVersion"];
      Information($"groupId               = {jo["groupId"]}");
      Information($"artifactId            = {jo["artifactId"]}");
      Information($"version               = {version}");
      Information($"nuget_version         = {nuget_version}");
      Information($"nugetId               = {jo["nugetId"]}");

      string[] version_parsed = nuget_version.Split(new string[] {"."}, StringSplitOptions.None);
      string nuget_version_new = nuget_version_template;
      string version_parsed_xx = version_parsed[0];
      string version_parsed_yy = version_parsed[1];
      string version_parsed_zz = version_parsed[2];

      if ( version_parsed_xx.Length == 1 )
      {
        version_parsed_xx = string.Concat("0", version_parsed_xx);
      }
      Information($"version_parsed_xx     = {version_parsed_xx}");

      nuget_version_new = nuget_version_new.Replace("xx", version_parsed_xx);
      nuget_version_new = nuget_version_new.Replace("yy", version_parsed_yy);
      nuget_version_new = nuget_version_new.Replace("zz", version_parsed_zz);
      if (version_parsed.Length == 4)
      {
        nuget_version_new = nuget_version_new.Replace("ww", version_parsed[3]);
      }
      else
      {
        nuget_version_new = nuget_version_new.Replace(".ww", "");
      }

      nuget_version_new = nuget_version_new.Replace("-suffix", nuget_version_suffix);

      Information($"nuget_version_new     = {nuget_version_new}");
      Information($"nuget_version         = {nuget_version}");

      Information("---");

      if( ! nuget_version_new.Contains($"{nuget_version}") )
      {
        Error("check config.json for nuget id");
        Error  ($"		groupId       = {jo["groupId"]}");
        Error  ($"		artifactId    = {jo["artifactId"]}");
        Error  ($"		version       = {version}");
        Error  ($"		nuget_version = {nuget_version}");
        Error  ($"		nugetId       = {jo["nugetId"]}");

        Warning($"	expected : ");
        Warning($"		nuget_version = {nuget_version_new}");
        Warning("---");
        throw new Exception("check config.json for nuget id");
      }
    }
  }
});

Task("binderate-fix")
  .Does (() =>
{
  JArray binderator_json_array = null;

  using (StreamReader reader = System.IO.File.OpenText(@"./config.json"))
  {
      JsonTextReader jtr = new JsonTextReader(reader);
      binderator_json_array = (JArray)JToken.ReadFrom(jtr);
  }

  //Warning("config.json fixing missing folder structure ...");
  foreach(JObject jo in binderator_json_array[0]["artifacts"])
  {
    string groupId = (string) jo["groupId"];
    string artifactId = (string) jo["artifactId"];

    bool? dependency_only = (bool?) jo["dependencyOnly"];
    if ( dependency_only == true)
      continue;
//
//    Information($"Verifying files for:");
//    Information($"    group: {groupId}");
//    Information($"    artifact: {artifactId}");

    string dir_group = $"source/{groupId}";
    if (!DirectoryExists(dir_group)) {
        Warning($"Creating {dir_group}");
        CreateDirectory(dir_group);
    }

    string dir_artifact = $"{dir_group}/{artifactId}";
    if (!DirectoryExists(dir_artifact)) {
        Warning($"Creating artifact folder: {dir_artifact}");
        CreateDirectory(dir_artifact);
        CreateDirectory($"{dir_artifact}/Transforms/");
        CreateDirectory($"{dir_artifact}/Additions/");
    } else {
      continue;
    }

    if (!FileExists($"{dir_artifact}/Transforms/Metadata.xml")) {
      Warning($"Creating file: {dir_artifact}/Transforms/Metadata.xml");
      CopyFile(
        $"./source/templates/artifact/Transforms/Metadata.xml",
        $"{dir_artifact}/Transforms/Metadata.xml"
      );
    }
    if (!FileExists($"{dir_artifact}/Transforms/EnumFields.xml")) {
      Warning($"Creating file: {dir_artifact}/EnumFields.xml");
      CopyFile(
        $"./source/templates/artifact/Transforms/EnumFields.xml",
        $"{dir_artifact}/Transforms/EnumFields.xml"
      );
    }
    if (!FileExists($"{dir_artifact}/Transforms/EnumMethods.xml")) {
      Warning($"Creating file: {dir_artifact}/EnumMethods.xml");
      CopyFile(
        $"./source/templates/artifact/Transforms/EnumMethods.xml",
        $"{dir_artifact}/Transforms/EnumMethods.xml"
      );
    }
  }
});

Task("build")
  .IsDependentOn("binderate")
  .Does (() =>
{
  var settings = new DotNetMSBuildSettings()
    .SetConfiguration(CONFIGURATION)
    .WithProperty("DesignTimeBuild", "false")
    .WithTarget("Build");

  var solution = "./generated/airship-android.sln";
  DotNetRestore(solution, new DotNetRestoreSettings { MSBuildSettings = settings });
  DotNetMSBuild(solution, settings);
});

Task("pack")
  .Does (() =>
{
  var settings = new DotNetMSBuildSettings()
    .SetConfiguration(CONFIGURATION)
    .SetMaxCpuCount(0)
    .WithProperty("NoBuild", "true")
    .WithProperty("PackageOutputPath", new [] { MakeAbsolute(PACKAGE_OUTPUT_PATH).FullPath })
    .WithTarget("Pack");

    var solution = "./generated/airship-android.sln";
    DotNetRestore(solution, new DotNetRestoreSettings { MSBuildSettings = settings });
    DotNetMSBuild(solution, settings);
  });

Task("check-maven-versions")
  .Does(() =>
{
  FilePath dotnet = Context.Tools.Resolve("dotnet");
  RunProcess(dotnet, "script scripts/update-config.csx -- config.json check");
});

Task("check-published-nugets")
  .Does(() =>
{
  FilePath dotnet = Context.Tools.Resolve("dotnet");
  RunProcess(dotnet, "script scripts/update-config.csx -- config.json published");
});

Task("update-sdk-version")
  .Does(() =>
{
  var version = Argument<string>("sdk", "");

  FilePath dotnet = Context.Tools.Resolve("dotnet");
  var command = "script --no-cache scripts/update-config.csx -- config.json update";
  if (version != "")
  {
    command += $" -v{version}";
  }
  RunProcess(dotnet, command);
});

Task("sort-config")
  .Does(() =>
{
  FilePath dotnet = Context.Tools.Resolve("dotnet");
  RunProcess(dotnet, "script scripts/update-config.csx -- config.json sort");
});

Task("clean")
  .Does (() =>
{
  if (DirectoryExists("./externals"))
    DeleteDirectory("./externals", new DeleteDirectorySettings { Recursive = true, Force = true });

  if (DirectoryExists("./generated"))
    DeleteDirectory("./generated", new DeleteDirectorySettings { Recursive = true, Force = true });

  if (DirectoryExists("./output"))
    DeleteDirectory("./output", new DeleteDirectorySettings { Recursive = true, Force = true });

	CleanDirectories("./**/packages");
	CleanDirectories("./**/bin");
	CleanDirectories("./**/obj");
});

RunTarget(TARGET);

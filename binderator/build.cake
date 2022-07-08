
#tool dotnet:?package=Xamarin.AndroidBinderator.Tool&version=0.5.4

#tool nuget:?package=Cake.CoreCLR
/*
     dotnet cake spell-check.cake
    dotnet cake spell-check.cake -t=spell-check
 */
#addin nuget:?package=WeCantSpell.Hunspell&version=3.0.1
#addin nuget:?package=Newtonsoft.Json&version=12.0.3
#addin nuget:?package=Cake.FileHelpers&version=3.2.1
#addin nuget:?package=Mono.Cecil&version=0.11.4

#addin nuget:?package=HolisticWare.Xamarin.Tools.ComponentGovernance&version=0.0.1.1
#addin nuget:?package=HolisticWare.Core.Net.HTTP&version=0.0.1
#addin nuget:?package=HolisticWare.Core.IO&version=0.0.1

var TARGET = Argument("t", Argument("target", "ci"));

void RunProcess(FilePath fileName, string processArguments)
{
	var exitCode = StartProcess(fileName, processArguments);
	if (exitCode != 0)
		throw new Exception ($"Process {fileName} exited with code {exitCode}.");
}

Task("binderate")
	.Does(() =>
{
	var configFile = MakeAbsolute(new FilePath("./config.json")).FullPath;
    var basePath = MakeAbsolute(new DirectoryPath ("./")).FullPath;
	var toolPath = Context.Tools.Resolve("xamarin-android-binderator");


    // Run the dotnet tool for binderator
    RunProcess(toolPath,
        $"--config=\"{configFile}\" --basepath=\"{basePath}\"");
});


Task("libs")
	.IsDependentOn("binderate")
	.Does(() =>
{
	var settings = new MSBuildSettings()
		.SetConfiguration("Release")
		.EnableBinaryLogger("./output/libs.binlog")
		.WithRestore()
		.WithProperty("DesignTimeBuild", "false")
		.WithTarget("Build");

	MSBuild("./generated/Airship.Android.sln", settings);
});

Task("nuget")
	.IsDependentOn("libs")
	.Does(() =>
{
	var settings = new MSBuildSettings()
		.SetConfiguration("Release")
		.EnableBinaryLogger("./output/nuget.binlog")
		.WithProperty("NoBuild", "true")
		.WithProperty("PackageOutputPath", MakeAbsolute((DirectoryPath)"./output/").FullPath)
		.WithTarget("Pack");

	MSBuild("./generated/Airship.Android.sln", settings);
});

Task("clean")
	.Does(() =>
{
	CleanDirectories("./generated/*/bin");
	CleanDirectories("./generated/*/obj");

	CleanDirectories("./externals/");
	CleanDirectories("./generated/");
	CleanDirectories("./native/.gradle");
	CleanDirectories("./native/**/build");
});

Task("ci")
	.IsDependentOn("libs")
	.IsDependentOn("nuget");

RunTarget(TARGET);

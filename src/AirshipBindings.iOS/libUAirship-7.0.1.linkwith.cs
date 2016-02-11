using ObjCRuntime;

[assembly: LinkWith ("libUAirship-7.0.1.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, SmartLink = true, ForceLoad = true, Frameworks = "SystemConfiguration CoreTelephony CoreData CoreLocation PassKit Security QuartzCore", LinkerFlags = "-ObjC -lsqlite3 -lz")]

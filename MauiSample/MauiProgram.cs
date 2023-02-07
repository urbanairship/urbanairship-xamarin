using CommunityToolkit.Maui;
using Microsoft.Maui.Controls.Compatibility.Hosting;

using AirshipDotNet.MessageCenter.Controls;
using AirshipDotNet.MessageCenter.Handlers;

namespace MauiSample;

public static class MauiProgram
{
    [Obsolete]
    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCompatibility()
            .UseMauiCommunityToolkit()
			.ConfigureMauiHandlers((handlers) =>
			{
				handlers.AddHandler(typeof(MessageView), typeof(MessageViewHandler));
			})
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("RobotoMono-Regular.ttf", "RobotoMonoRegular");
            });

		return builder.Build();
	}
}

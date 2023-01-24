using CommunityToolkit.Maui;
using Microsoft.Maui.Controls.Compatibility.Hosting;

using AirshipDotNet.MessageCenter;
using AirshipDotNet;

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
			//.ConfigureMauiHandlers((handlers) =>
			//{
			//	handlers.AddCompatibilityRenderer(typeof(MessagePage), typeof(MessagePageRenderer));
			//})
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("RobotoMono-Regular.ttf", "RobotoMonoRegular");
            });

		return builder.Build();
	}
}

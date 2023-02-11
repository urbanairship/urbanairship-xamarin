using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

using AirshipDotNet.MessageCenter.Controls;
using AirshipDotNet.MessageCenter.Handlers;

namespace AirshipDotNet.MessageCenter
{
	public static class MauiAppBuilderExtensions
	{
		public static MauiAppBuilder UseAirshipMessageCenter(this MauiAppBuilder builder)
		{
			builder.ConfigureMauiHandlers((h) => {
				h.AddHandler(typeof(MessageView), typeof(MessageViewHandler));
			});

			return builder;
		}
  }
}


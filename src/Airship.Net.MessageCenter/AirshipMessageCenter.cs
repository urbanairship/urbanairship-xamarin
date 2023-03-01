using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

using AirshipDotNet.MessageCenter.Controls;
using AirshipDotNet.MessageCenter.Handlers;

namespace AirshipDotNet.MessageCenter
{
  /// <summary>
  /// Helper extensions to allow easy integration of Airship's built-in UIs.
  /// </summary>
	public static class MauiAppBuilderExtensions
	{
    /// <summary>
    /// <c>MauiAppBuilder</c> extension that configures Airship Message Center handlers.
    /// </summary>
		public static MauiAppBuilder UseAirshipMessageCenter(this MauiAppBuilder builder)
		{
			builder.ConfigureMauiHandlers((h) => {
				h.AddHandler(typeof(MessageView), typeof(MessageViewHandler));
			});

			return builder;
		}
  }
}


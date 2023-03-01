/*
 Copyright Airship and Contributors
*/

using System;

using UrbanAirship.Actions;

namespace UrbanAirship.Webkit
{
	public partial class AirshipWebViewClient
	{
		public virtual void SetActionCompletionCallback(Action<ActionArguments, ActionResult> callback)
		{
			SetActionCompletionCallback(new ActionCompletionCallback(callback));
		}
	}
}

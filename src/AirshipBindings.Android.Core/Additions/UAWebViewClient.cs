/*
 Copyright Airship and Contributors
*/

using System;
using UrbanAirship.Actions;

namespace UrbanAirship.Widget
{
	public partial class UAWebViewClient
	{
		public virtual void SetActionCompletionCallback(Action<ActionArguments, ActionResult> callback)
		{
			SetActionCompletionCallback(new ActionCompletionCallback(callback));
		}
	}
}

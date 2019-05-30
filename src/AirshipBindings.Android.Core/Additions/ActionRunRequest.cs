/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using Android.OS;

namespace UrbanAirship.Actions
{
	public partial class ActionRunRequest
	{
		public virtual void Run (Action<ActionArguments, ActionResult> callback)
		{
			Run (new ActionCompletionCallback (callback));
		}

		public virtual void Run (Action<ActionArguments, ActionResult> callback, Looper looper)
		{
			Run (looper, new ActionCompletionCallback (callback));
		}
	}
}
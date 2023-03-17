using System;

namespace UrbanAirship.Actions
{
	public class ActionCompletionCallback : Java.Lang.Object, IActionCompletionCallback
	{
		Action<ActionArguments, ActionResult> callback;

		public ActionCompletionCallback(Action<ActionArguments, ActionResult> callback)
		{
			this.callback = callback;
		}

		public void OnFinish(ActionArguments arguments, ActionResult result)
		{
			if (callback != null)
			{
				callback.Invoke(arguments, result);
			}
		}
	}
}

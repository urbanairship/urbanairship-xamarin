using System;

namespace UrbanAirship.Actions
{
	public partial class ActionRegistry
	{		
		public partial class Entry
		{
			public void SetPredicate(Func<ActionArguments, Boolean> predicate)
			{
				Predicate = new FuncPredicate(predicate);
			}
		}

		internal class FuncPredicate : Java.Lang.Object, IPredicate
		{
			Func<ActionArguments, Boolean> predicate;

			public FuncPredicate(Func<ActionArguments, Boolean> predicate)
			{
				this.predicate = predicate;
			}

			public Boolean Apply(ActionArguments arguments)
			{
				Boolean result = false;
				if (predicate != null)
				{
					result = predicate.Invoke((ActionArguments)arguments);
				}
				return result;
			}
		}
	}
}

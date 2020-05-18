/*
 Copyright Airship and Contributors
*/

using System;

using Android.Widget;

namespace UrbanAirship.MessageCenter
{
	public partial class MessageListFragment
	{
		public void GetAbsListViewAsync(Action<AbsListView> absListView)
		{
			GetAbsListViewAsync(new OnListViewReadyCallback(absListView));
		}

		internal class OnListViewReadyCallback : Java.Lang.Object
		{
			Action<AbsListView> onListViewReady;

			public OnListViewReadyCallback(Action<AbsListView> onListViewReady)
			{
				this.onListViewReady = onListViewReady;
			}

			public void OnListViewReady(AbsListView absListView)
			{
				if (absListView != null)
				{
					onListViewReady.Invoke(absListView);
				}
			}
		}
	}
}

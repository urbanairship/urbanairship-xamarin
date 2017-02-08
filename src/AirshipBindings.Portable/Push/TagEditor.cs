using System;
using System.Collections.Generic;


namespace UrbanAirship.Portable.Push
{
	public class TagEditor
	{
		private Action<List<string>, List<string>> onApply;
		private List<string> toAdd = new List<string>();
		private List<string> toRemove = new List<string>();

		internal TagEditor(Action<List<string>, List<string>> onApply)
		{
			this.onApply = onApply;
		}

		/// <summary>
		/// Add a tag to the device.
		/// </summary>
		/// <returns>The tag editor.</returns>
		/// <param name="tag">The tag to add.</param>
		public TagEditor AddTag(string tag)
		{
			toAdd.Add(tag);
			return this;
		}

		/// <summary>
		/// Add tags to the device.
		/// </summary>
		/// <returns>The tag editor.</returns>
		/// <param name="tags">Tags to add.</param>
		public TagEditor AddTags(ICollection<string> tags)
		{
			toAdd.AddRange(tags);
			return this;
		}

		/// <summary>
		/// Remove a tag from the device
		/// </summary>
		/// <returns>The tag editor.</returns>
		/// <param name="tag">Tag to remove.</param>
		public TagEditor RemoveTag(string tag)
		{
			toRemove.Add(tag);
			return this;
		}

		/// <summary>
		/// Remove tags from the device.
		/// </summary>
		/// <returns>The tag editor.</returns>
		/// <param name="tags">Tags to remove.</param>
		public TagEditor RemoveTags(ICollection<string> tags)
		{
			toRemove.AddRange(tags);
			return this;
		}

		/// <summary>
		/// Clear all tags from the tag editor.
		/// </summary>
		/// <returns>The tag editor.</returns>
		public TagEditor Clear()
		{
			toAdd.Clear();
			toRemove.Clear();
			return this;
		}

		/// <summary>
		/// Apply the tag changes.
		/// </summary>
		public void Apply()
		{
			if (onApply != null)
			{
				onApply(toAdd, toRemove);
			}
		}
	}
}

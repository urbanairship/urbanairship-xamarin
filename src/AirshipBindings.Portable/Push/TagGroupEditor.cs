/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using System.Collections.Generic;

namespace UrbanAirship.Portable.Push
{
	public class TagGroupEditor
	{
		public static readonly string ADD = "add";
		public static readonly string REMOVE = "remove";
		public static readonly string SET = "set";

		private Action<Dictionary<string, Dictionary<string, List<string>>>> onApply;

		private Dictionary<string, List<string>> addTags = new Dictionary<string, List<string>>();
		private Dictionary<string, List<string>> removeTags = new Dictionary<string, List<string>>();
		private Dictionary<string, List<string>> setTags = new Dictionary<string, List<string>>();

		internal TagGroupEditor(Action<Dictionary<string, Dictionary<string, List<string>>>> onApply)
		{
			this.onApply = onApply;
		}

		/// <summary>
		/// Add a tag to a given tag group.
		/// </summary>
		/// <returns>The tag group editor.</returns>
		/// <param name="tag">Tag to add.</param>
		/// <param name="group">Group to add the tag to.</param>
		public TagGroupEditor AddTag(string tag, string group)
		{
			appendMapValues(group, new List<string>() { tag }, addTags);
			return this;
		}

		/// <summary>
		/// Add tags to a given tag group.
		/// </summary>
		/// <returns>The tag group editor.</returns>
		/// <param name="tag">Tags to add.</param>
		/// <param name="group">Group to add tags to.</param>
		public TagGroupEditor AddTags(ICollection<string> tags, string group)
		{
			appendMapValues(group, tags, addTags);
			return this;
		}

		/// <summary>
		/// Remove tag from a given tag group.
		/// </summary>
		/// <returns>The tag group editor.</returns>
		/// <param name="tag">Tag to remove.</param>
		/// <param name="group">Group to remove the tag from.</param>
		public TagGroupEditor RemoveTag(string tag, string group)
		{
			appendMapValues(group, new List<string>() { tag }, removeTags);
			return this;
		}

		/// <summary>
		/// Remove tags from a given tag group.
		/// </summary>
		/// <returns>The tag group editor.</returns>
		/// <param name="tag">Tags to remove.</param>
		/// <param name="group">Group to remove the tags from.</param>
		public TagGroupEditor RemoveTags(ICollection<string> tags, string group)
		{
			appendMapValues(group, tags, removeTags);
			return this;
		}

		/// <summary>
		/// Set a tag to the given tag group.
		/// </summary>
		/// <returns>The tag group editor.</returns>
		/// <param name="tag">Tag to set.</param>
		/// <param name="group">Group to set the tag to.</param>
		public TagGroupEditor SetTag(string tag, string group)
		{
			appendMapValues(group, new List<string>() { tag }, setTags);
			return this;
		}

		/// <summary>
		/// Set tags to the given tag group.
		/// </summary>
		/// <returns>The tags group editor.</returns>
		/// <param name="tags">Tags to set.</param>
		/// <param name="group">Group to set the tags to.</param>
		public TagGroupEditor SetTags(ICollection<string> tags, string group)
		{
			appendMapValues(group, tags, setTags);
			return this;
		}

		/// <summary>
		/// Apply the tag group changes.
		/// </summary>
		public void Apply()
		{
			if (onApply != null)
			{
				Dictionary<string, Dictionary<string, List<string>>> tagOps = new Dictionary<string, Dictionary<string, List<string>>>();
				tagOps.Add(ADD, addTags);
				tagOps.Add(REMOVE, removeTags);
				tagOps.Add(SET, setTags);
				onApply(tagOps);
			}
		}

		private static void appendMapValues(string key, ICollection<string> values, Dictionary<string, List<string>> map)
		{
			if (!map.ContainsKey(key))
			{
				List<string> vals = new List<string>();
				vals.AddRange(values);
				map.Add(key, vals);
			}
			else
			{
				List<string> newList = map[key];
				newList.AddRange(values);
				map[key] = newList;
			}
		}
	}
}

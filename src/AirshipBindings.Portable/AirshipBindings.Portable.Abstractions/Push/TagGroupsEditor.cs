/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using System.Collections.Generic;


namespace UrbanAirship.Portable.Push
{
	/// <summary>
	/// Interface used for modifying channel and named user tag groups.
	/// </summary>
	public class TagGroupsEditor
	{
		private List<TagOperation> operations = new List<TagOperation>();
		private Action<List<TagOperation>> onApply;

		public TagGroupsEditor(Action<List<TagOperation>> onApply)
		{
			this.onApply = onApply;
		}

		/// <summary>
		/// Add a tag to a given tag group.
		/// </summary>
		/// <returns>The tag groups editor.</returns>
		/// <param name="tag">Tag to add.</param>
		/// <param name="group">Group to add the tag to.</param>
		public TagGroupsEditor AddTag(string tag, string group)
		{
			AddTags(new string[] { tag }, group);
			return this;
		}

		/// <summary>
		/// Add tags to a given tag group.
		/// </summary>
		/// <returns>The tag groups editor.</returns>
		/// <param name="tags">Tags to add.</param>
		/// <param name="group">Group to add tags to.</param>
		public TagGroupsEditor AddTags(ICollection<string> tags, string group)
		{
			operations.Add(new TagOperation(OperationType.ADD, tags, group));
			return this;

		}

		/// <summary>
		/// Remove tag from a given tag group.
		/// </summary>
		/// <returns>The tag groups editor.</returns>
		/// <param name="tag">Tag to remove.</param>
		/// <param name="group">Group to remove the tag from.</param>
		public TagGroupsEditor RemoveTag(string tag, string group)
		{
			RemoveTags(new string[] { tag }, group);
			return this;
		}

		/// <summary>
		/// Remove tags from a given tag group.
		/// </summary>
		/// <returns>The tag groups editor.</returns>
		/// <param name="tags">Tags to remove.</param>
		/// <param name="group">Group to remove the tags from.</param>
		public TagGroupsEditor RemoveTags(ICollection<string> tags, string group)
		{
			operations.Add(new TagOperation(OperationType.REMOVE, tags, group));
			return this;
		}

		/// <summary>
		/// Set a tag to the given tag group.
		/// </summary>
		/// <returns>The tag groups editor.</returns>
		/// <param name="tag">Tag to set.</param>
		/// <param name="group">Group to set the tag to.</param>
		public TagGroupsEditor SetTag(string tag, string group)
		{
			SetTags(new string[] { tag }, group);
			return this;
		}

		/// <summary>
		/// Set tags to the given tag group.
		/// </summary>
		/// <returns>The tag groups editor.</returns>
		/// <param name="tags">Tags to set.</param>
		/// <param name="group">Group to set the tags to.</param>
		public TagGroupsEditor SetTags(ICollection<string> tags, string group)
		{
			operations.Add(new TagOperation(OperationType.SET, tags, group));
			return this;
		}

		/// <summary>
		/// Apply the tag group changes.
		/// </summary>
		public void Apply()
		{
			if (onApply != null)
			{
				onApply(operations);
			}
		}

		public class TagOperation
		{
			public OperationType operationType;
			public ICollection<string> tags;
			public string group;

			internal TagOperation(OperationType operation, ICollection<string> tags, string group)
			{
				this.operationType = operation;
				this.tags = tags;
				this.group = group;
			}
		}

		public enum OperationType { ADD, REMOVE, SET }
	}
}
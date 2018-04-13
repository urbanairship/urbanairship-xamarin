/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace UrbanAirship.NETStandard.Push
{
    /// <summary>
    /// Class used for modifying channel tags.
    /// </summary>
    public partial class TagEditor
    {
        private bool clear = false;

        private Action<bool, string[], string[]> onApply;
        private HashSet<string> toAdd = new HashSet<string>();
        private HashSet<string> toRemove = new HashSet<string>();

        //@cond IGNORE
        public TagEditor(Action<bool, string[], string[]> onApply)
        {
            this.onApply = onApply;
        }
        //@endcond

        /// <summary>
        /// Add a tag to the device.
        /// </summary>
        /// <returns>The tag editor.</returns>
        /// <param name="tag">The tag to add.</param>
        public TagEditor AddTag(string tag)
        {
            AddTags(new string[] { tag });
            return this;
        }

        /// <summary>
        /// Add tags to the device.
        /// </summary>
        /// <returns>The tag editor.</returns>
        /// <param name="tags">Tags to add.</param>
        public TagEditor AddTags(ICollection<string> tags)
        {
            toRemove.ExceptWith(tags);
            toAdd.UnionWith(tags);
            return this;
        }

        /// <summary>
        /// Remove a tag from the device
        /// </summary>
        /// <returns>The tag editor.</returns>
        /// <param name="tag">Tag to remove.</param>
        public TagEditor RemoveTag(string tag)
        {
            RemoveTags(new string[] { tag });
            return this;
        }

        /// <summary>
        /// Remove tags from the device.
        /// </summary>
        /// <returns>The tag editor.</returns>
        /// <param name="tags">Tags to remove.</param>
        public TagEditor RemoveTags(ICollection<string> tags)
        {
            toAdd.ExceptWith(tags);
            toRemove.UnionWith(tags);
            return this;
        }

        /// <summary>
        /// Clear tags before executing add/remove operations.
        /// </summary>
        /// <returns>The tag editor.</returns>
        public TagEditor Clear()
        {
            clear = true;
            return this;
        }

        /// <summary>
        /// Apply the tag changes.
        /// </summary>
        public void Apply()
        {
            if (onApply != null)
            {
                onApply(clear, toAdd.ToArray(), toRemove.ToArray());
            }
        }
    }
}

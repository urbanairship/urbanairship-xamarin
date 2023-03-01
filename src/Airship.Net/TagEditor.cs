/* Copyright Airship and Contributors */

namespace AirshipDotNet.Channel
{
    /// <summary>
    /// Editor for Channel and Named User tags.
    /// </summary>
    public partial class TagEditor
    {
        private bool clear = false;

        private readonly Action<bool, string[], string[]> onApply;
        private readonly HashSet<string> toAdd = new();
        private readonly HashSet<string> toRemove = new();

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
            return AddTags(new string[] { tag });
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
            return RemoveTags(new string[] { tag });
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
            onApply?.Invoke(clear, toAdd.ToArray(), toRemove.ToArray());
        }
    }
}

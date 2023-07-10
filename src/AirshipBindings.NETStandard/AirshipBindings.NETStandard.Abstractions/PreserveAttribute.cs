using System;

namespace AirshipBindings.NETStandard.Abstractions
{
    /// Adds `Preserve` attribute support to control the linker.
    [AttributeUsage(AttributeTargets.All)]
    public sealed class PreserveAttribute : Attribute
    {
        public bool AllMembers;
        public bool Conditional;
    }
}

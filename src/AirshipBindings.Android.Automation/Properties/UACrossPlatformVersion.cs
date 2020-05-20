using System;
using System.Runtime;

namespace UrbanAirship.Attributes
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [System.Runtime.InteropServices.ComVisible(true)]
    public unsafe sealed class UACrossPlatformVersionAttribute : Attribute
    {
        private String m_version;

        public UACrossPlatformVersionAttribute(String version)
        {
            m_version = version;
        }

        public String Version
        {
            get { return m_version; }
        }
    }
}

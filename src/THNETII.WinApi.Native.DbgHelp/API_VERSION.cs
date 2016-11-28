using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp
{
    /// <summary>
    /// Contains the library version.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class API_VERSION
    {
        /// <summary>The major version number.</summary>
        public ushort MajorVersion;
        /// <summary>The minor version number.</summary>
        public ushort MinorVersion;
        /// <summary>The revision number.</summary>
        public ushort Revision;
        /// <summary>This member is reserved for use by the operating system.</summary>
        public ushort Reserved;
    }
}

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp
{
    /// <summary>
    /// Contains the library version.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms679275.aspx">API_VERSION structure</a></para>
    /// </remarks>
    /// <seealso cref="ImagehlpApiVersion"/>
    /// <seealso cref="ImagehlpApiVersionEx"/>
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

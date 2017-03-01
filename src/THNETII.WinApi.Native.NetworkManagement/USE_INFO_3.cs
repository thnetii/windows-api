using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USE_INFO_3"/> structure contains information about a connection between a local computer and a shared resource, including connection type, connection status, user name, domain name, and specific flags that describe connection behavior.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371383.aspx">USE_INFO_3 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUseEnum"/>
    /// <seealso cref="NetUseGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USE_INFO_3
    {
        /// <summary>
        /// <see cref="USE_INFO_2"/> structure that contains 
        /// </summary>
        public USE_INFO_2 ui3_ui2;
        /// <summary>
        /// A set of bit flags that describe connection behavior and credential handling.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public USE_INFO_3_FLAGS ui3_status;
    }
}

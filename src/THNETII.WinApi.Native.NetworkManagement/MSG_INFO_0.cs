using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="MSG_INFO_0"/> structure specifies a message alias.
    /// </summary>
    /// <remarks>
	/// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370288.aspx">MSG_INFO_0 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetMessageNameEnum"/>
    /// <seealso cref="NetMessageNameGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class MSG_INFO_0
    {
        /// <summary>
        /// A Unicode string that specifies the alias to which the message is to be sent.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string msgi0_name;
    }
}

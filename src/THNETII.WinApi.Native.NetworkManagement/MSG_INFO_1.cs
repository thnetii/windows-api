using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="MSG_INFO_1"/> structure specifies a message alias. This structure exists only for compatibility. Message forwarding is not supported.
    /// </summary>
    /// <remarks>
	/// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370289.aspx">MSG_INFO_1 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetMessageNameEnum"/>
    /// <seealso cref="NetMessageNameGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class MSG_INFO_1
    {
        /// <summary>
        /// A Unicode string that specifies the alias to which the message is to be sent.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string msgi1_name;
        /// <summary>This member must be zero.</summary>
        public int msgi1_forward_flag;
        /// <summary>This member must be <c>null</c>.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string msgi1_forward;
    }
}

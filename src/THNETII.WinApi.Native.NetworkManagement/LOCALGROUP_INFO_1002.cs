using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="LOCALGROUP_INFO_1002"/> structure contains a comment describing a local group.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370276.aspx">LOCALGROUP_INFO_1002 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetLocalGroupSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class LOCALGROUP_INFO_1002
    {
        /// <summary>
        /// A Unicode string that contains a remark associated with the local group. This member can be a null string. The comment can have as many as <see cref="MAXCOMMENTSZ"/> characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lgrpi1002_comment;
    }
}

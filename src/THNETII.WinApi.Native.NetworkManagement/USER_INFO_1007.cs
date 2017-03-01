using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1007"/> structure contains a comment associated with a user network account. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370967.aspx">USER_INFO_1007 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1007
    {
        /// <summary>
        /// A string that contains a comment to associate with the user account specified in the <var>username</var> parameter to the <see cref="NetUserSetInfo"/> function. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1007_comment;
    }
}

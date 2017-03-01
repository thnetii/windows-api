using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1010"/> structure contains a set of bit flags defining the operator privileges assigned to a user network account. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// For more information about controlling access to securable objects, see <a href="https://msdn.microsoft.com/en-us/library/aa374860.aspx">Access Control</a>, <a href="https://msdn.microsoft.com/en-us/library/aa379306.aspx">Privileges</a>, and <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">Securable Objects</a>.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370971.aspx">USER_INFO_1010 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1010
    {
        /// <summary>
        /// Specifies a value that contains a set of bit flags that specify the user's operator privileges. The user is specified in the <var>username</var> parameter to the <see cref="NetUserSetInfo"/> function. 
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public ACCOUNT_OPERATOR_FLAGS usri1010_auth_flags;
    }
}

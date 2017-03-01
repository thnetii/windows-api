using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1051"/> structure contains the relative ID (RID) associated with the user account. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371004.aspx">USER_INFO_1051 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1051
    {
        /// <summary>
        /// Specifies the RID of the Primary Global Group for the user specified in the <var>username</var> parameter to the <see cref="NetUserSetInfo"/> function. This member must be the RID of a global group that represents the enrolled user. For more information about RIDs, see <a href="https://msdn.microsoft.com/en-us/library/aa379597.aspx">SID Components</a>.
        /// </summary>
        public int usri1051_primary_group_id;
    }
}

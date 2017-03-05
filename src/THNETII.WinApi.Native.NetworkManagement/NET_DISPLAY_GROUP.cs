using System.Runtime.InteropServices;
using Microsoft.Win32.WinApi.SecurityIdentity.Authorization;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.SE_GROUP_ATTRIBUTES;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="NET_DISPLAY_GROUP"/> structure contains information that an account manager can access to determine information about group accounts.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370682.aspx">NET_DISPLAY_GROUP structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserAdd"/>
    /// <seealso cref="NetUserSetInfo"/>
    /// <seealso cref="NetQueryDisplayInformation"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    [StructLayout(LayoutKind.Sequential)]
    public class NET_DISPLAY_GROUP
    {
        /// <summary>
        /// A Unicode string that specifies the name of the group.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] public string grpi3_name;
        /// <summary>
        /// A Unicode string that contains a comment associated with the group. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] public string grpi3_comment;
        /// <summary>
        /// The relative identifier (RID) of the group. The relative identifier is determined by the accounts database when the group is created. It uniquely identifies the group to the account manager within the domain. The <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions ignore this member. For more information about RIDs, see <a href="https://msdn.microsoft.com/en-us/library/aa379597.aspx">SID Components</a>.
        /// </summary>
        public int grpi3_group_id;
        /// <summary>
        /// These attributes are hard-coded to <see cref="SE_GROUP_MANDATORY"/>, <see cref="SE_GROUP_ENABLED"/>, and <see cref="SE_GROUP_ENABLED_BY_DEFAULT"/>. For more information, see <see cref="TOKEN_GROUPS"/>. 
        /// </summary>
        [MarshalAs(UnmanagedType.I4)] public SE_GROUP_ATTRIBUTES grpi3_attributes;
        /// <summary>
        /// The index of the last entry returned by the <see cref="NetQueryDisplayInformation"/> function. Pass this value as the <em>Index</em> parameter to <see cref="NetQueryDisplayInformation"/> to return the next logical entry. Note that you should not use the value of this member for any purpose except to retrieve more data with additional calls to <see cref="NetQueryDisplayInformation"/>.
        /// </summary>
        public int grpi3_next_index;
    }
}

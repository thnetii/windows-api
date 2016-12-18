using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="LOCALGROUP_MEMBERS_INFO_0"/> structure contains the security identifier (SID) associated with a local group member. The member can be a user account or a global group account.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370278.aspx">LOCALGROUP_MEMBERS_INFO_0 structure</a></para>
    /// </remarks>
    /// <seealso cref="LOCALGROUP_MEMBERS_INFO_1"/>
    /// <seealso cref="LOCALGROUP_MEMBERS_INFO_2"/>
    /// <seealso cref="LOCALGROUP_MEMBERS_INFO_3"/>
    /// <seealso cref="NetLocalGroupAddMembers"/>
    /// <seealso cref="NetLocalGroupDelMembers"/>
    /// <seealso cref="NetLocalGroupGetMembers"/>
    /// <seealso cref="NetLocalGroupSetMembers"/>
    [StructLayout(LayoutKind.Sequential)]
    public class LOCALGROUP_MEMBERS_INFO_0
    {
        /// <summary>
        /// Pointer to the binary representation of a <see cref="SecurityIdentifier"/> structure that contains the <a href="https://msdn.microsoft.com/en-us/library/aa379571.aspx">security identifier (SID)</a> of the local group member.
        /// </summary>
        public IntPtr lgrmi0_sid;
        /// <summary>
        /// Marshal to managed memory: The <see cref="SecurityIdentifier"/> instance that contains the <a href="https://msdn.microsoft.com/en-us/library/aa379571.aspx">security identifier (SID)</a> of the local group member.
        /// </summary>
        /// <returns></returns>
        public SecurityIdentifier GetMarshaledSid() => lgrmi0_sid == IntPtr.Zero ? null : new SecurityIdentifier(lgrmi0_sid);
    }
}

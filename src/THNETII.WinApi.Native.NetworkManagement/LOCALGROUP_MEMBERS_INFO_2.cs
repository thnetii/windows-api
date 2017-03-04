using Microsoft.Win32.WinApi.SecurityIdentity.Authorization;
using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="LOCALGROUP_MEMBERS_INFO_2"/> structure contains the security identifier (SID) and account information associated with the member of a local group member.
    /// </summary>
    /// <remarks>
    /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370280.aspx">LOCALGROUP_MEMBERS_INFO_2 structure</a></para>
    /// </remarks>
    /// <seealso cref="LOCALGROUP_MEMBERS_INFO_0"/>
    /// <seealso cref="LOCALGROUP_MEMBERS_INFO_1"/>
    /// <seealso cref="LOCALGROUP_MEMBERS_INFO_3"/>
    /// <seealso cref="NetLocalGroupGetMembers"/>
    [StructLayout(LayoutKind.Sequential)]
    public class LOCALGROUP_MEMBERS_INFO_2
    {
        /// <summary>
        /// Pointer to the binary representation of a <see cref="SecurityIdentifier"/> structure that contains the <a href="https://msdn.microsoft.com/en-us/library/aa379571.aspx">security identifier (SID)</a> of the local group member. The account can be a user account or a global group account.
        /// </summary>
        public SecurityIdentifierAnySafeHandle lgrmi2_sid;
        /// <summary>
        /// Marshal to managed memory: The <see cref="SecurityIdentifier"/> instance that contains the <a href="https://msdn.microsoft.com/en-us/library/aa379571.aspx">security identifier (SID)</a> of the local group member.
        /// </summary>
        /// <returns></returns>
        public SecurityIdentifier GetMarshaledSid() => SecurityIdentifierSafeHandle.ReadValue(lgrmi2_sid);
        /// <summary>
        /// The account type associated with the security identifier specified in the <see cref="lgrmi2_sid"/> member.
        /// </summary>
        public SID_NAME_USE lgrmi2_sidusage;
        /// <summary>
        /// A string containing the account name of the local group member identified by the <see cref="lgrmi2_sid"/> member. The <see cref="lgrmi2_domainandname"/> member includes the domain name and has the form: <c>&lt;DomainName&gt;\&lt;AccountName&gt;</c>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lgrmi2_domainandname;
    }
}

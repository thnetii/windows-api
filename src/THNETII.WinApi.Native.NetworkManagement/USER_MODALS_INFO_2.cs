using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_MODALS_INFO_2"/> structure contains the Security Account Manager (SAM) domain name and identifier.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371354.aspx">USER_MODALS_INFO_2 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserModalsGet"/>
    /// <seealso cref="NetUserModalsSet"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_MODALS_INFO_2
    {
        /// <summary>
        /// Specifies the name of the Security Account Manager (SAM) domain. For a domain controller, this is the name of the domain that the controller is a member of. For workstations, this is the name of the computer.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usrmod2_domain_name;
        /// <summary>
        /// Pointer to a <see cref="SecurityIdentifier"/> structure that contains the security identifier (SID) of the domain named by the <see cref="usrmod2_domain_name"/> member.
        /// </summary>
        public IntPtr usrmod2_domain_id;
        /// <summary>
        /// Gets the <see cref="SecurityIdentifier"/> of the domain named by the <see cref="usrmod2_domain_name"/> member.
        /// </summary>
        /// <returns>A <see cref="SecurityIdentifier"/> instance representing the security identifier (SID) of the domain named by the <see cref="usrmod2_domain_name"/> member, or <c>null</c> if <see cref="usrmod2_domain_id"/> is <see cref="IntPtr.Zero"/>.</returns>
        /// <seealso cref="usrmod2_domain_id"/>
        public SecurityIdentifier GetDomainSid() => usrmod2_domain_id == IntPtr.Zero ? null : new SecurityIdentifier(usrmod2_domain_id);
    }
}

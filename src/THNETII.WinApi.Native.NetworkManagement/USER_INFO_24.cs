using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_24"/> structure contains user account information on an account which is connected to an Internet identity. This information includes the Internet provider name for the user, the user's Internet name, and the user's security identifier (SID).
    /// </summary>
    /// <remarks>
    /// <para>A user's account for logging onto Windows can be connected to an Internet identity. The user account can be a local account on a computer or a domain account for computers joined to a domain. The <see cref="USER_INFO_24"/> structure is used to provide information on an account which is connected to an Internet identity.</para>
    /// <para>On Windows 8 and Windows Server 2012, the Internet identity for a connected account can often be used instead of the computer account.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/hh994455.aspx">USER_INFO_24 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserGetInfo"/>
    /// <seealso cref="SecurityIdentifier"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_24
    {
        /// <summary>
        /// <para>A boolean value that indicates whether an account is connected to an Internet identity. </para>
        /// <para>This member is true if the account is connected to an Internet identity. The other members in this structure can be used. </para>
        /// <para>If this member is false, then the account is not connected to an Internet identity and other members in this structure should be ignored.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool usri24_internet_identity;
        /// <summary>
        /// A set of flags. This member must be zero.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public USER_FLAGS usri24_flags;
        /// <summary>
        /// A string that specifies the Internet provider name. 
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri24_internet_provider_name;
        /// <summary>
        /// A string that specifies the user's Internet name. 
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri24_internet_principal_name;
        /// <summary>
        /// A pointer to a <see cref="SecurityIdentifier"/> structure that contains the local account SID of the user.
        /// </summary>
        public IntPtr usri24_user_sid;
        /// <summary>
        /// Gets the local account SID of the user.
        /// </summary>
        /// <returns>A <see cref="SecurityIdentifier"/> instance for the user, or <c>null</c> if <see cref="usri24_user_sid"/> is <see cref="IntPtr.Zero"/>.</returns>
        public SecurityIdentifier GetUserId() => usri24_user_sid == IntPtr.Zero ? null : new SecurityIdentifier(usri24_user_sid);
    }
}

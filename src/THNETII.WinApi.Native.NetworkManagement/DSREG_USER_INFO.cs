using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Contains information about a user account that is used to join a device to Microsoft Azure Active Directory.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/mt481425.aspx">DSREG_USER_INFO structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public class DSREG_USER_INFO
    {
        /// <summary>The email address of the user.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszUserEmail;
        /// <summary>The identifier of the Microsoft Passport key that is provisioned for the user.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszUserKeyId;
        /// <summary>The name of the Microsoft Passport key that is provisioned for the user.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszUserKeyName;
    }

    public class DSREG_USER_INFO_ExternalSafeHandle : ExternalSafeHandle, ISafeHandleReadStructure<DSREG_USER_INFO> { }
}
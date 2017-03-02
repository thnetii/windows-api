using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Contains information about how a device is joined to Microsoft Azure Active Directory.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/mt481423.aspx">DSREG_JOIN_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="DSREG_JOIN_TYPE"/>
    /// <seealso cref="DSREG_USER_INFO"/>
    [StructLayout(LayoutKind.Sequential)]
    public class DSREG_JOIN_INFO
    {
        /// <summary>An enumeration value that specifies the type of the join. </summary>
        public DSREG_JOIN_TYPE joinType;
        /// <summary>Representations of the certification for the join.</summary>
        public IntPtr pJoinCertificate;
        /// <summary>The identifier of the device.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszDeviceID;
        /// <summary>A string that represents Azure Active Directory (Azure AD).</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszIdpDomain;
        /// <summary>The identifier of the joined Azure AD tenant.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszTenantId;
        /// <summary>The email address for the joined account.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszJoinUserEmail;
        /// <summary>The display name for the joined account.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszTenantDisplayName;
        /// <summary>The URL to use to enroll in the Mobile Device Management (MDM) service.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszMdmEnrollmentUrl;
        /// <summary>The URL that provides information about the terms of use for the MDM service.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszMdmTermsOfUseUrl;
        /// <summary>The URL that provides information about compliance for the MDM service.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszMdmComplianceUrl;
        /// <summary>The URL for synchronizing user settings.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszUserSettingSyncUrl;
        /// <summary>Information about the user account that was used to join a device to Azure AD.</summary>
        public DSREG_USER_INFO_ExternalSafeHandle pUserInfo;
    }
}

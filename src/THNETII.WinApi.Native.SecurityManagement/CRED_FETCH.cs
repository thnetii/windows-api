namespace Microsoft.Win32.WinApi.SecurityIdentity.SecurityManagement
{
    /// <summary>
    /// Defines values that determine how to fetch the credential of a Group Managed Service Account (gMSA).
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/hh448524.aspx">CRED_FETCH enumeration</a></para>
    /// </remarks>
    public enum CRED_FETCH
    {
        /// <summary>
        /// Signifies that the operating system should first attempt to retrieve the password from the local cache. If it is time to fetch the password, then the operating system should contact a domain controller for the password. If that fails, then return any cached passwords with the status value of success.
        /// </summary>
        CredFetchDefault = 0,
        /// <summary>
        /// Returns the local DPAPI credential to the caller. <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_support_provider_gly">Security support providers</a></em> (SSPs) generally would not require the use of this enumeration.
        /// </summary>
        CredFetchDPAPI = 1,
        /// <summary>
        /// Forces the operating system to attempt to read the password from the domain controller. During the password rollover time, the password may have changed at the domain controller and other member hosts, but the gMSA member host recognizes the password as still valid. This can happen due to clock skew issues between different domain controllers. When this value is specified, the operating system determines if there could be a possible password change due to clock skew, and if so, retrieves the password. Otherwise, the cached credential is returned. If there is no cached credential, then the operating system attempts to get one from the domain controller.
        /// </summary>
        CredFetchForced = 2
    }
}

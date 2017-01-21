namespace Microsoft.Win32.WinApi.SecurityIdentity.SecurityManagement
{
    /// <summary>
    /// Indicates the state of a managed service account. A managed service account can be either a group managed service account (gMSA) or a standalone managed service account (sMSA). A sMSA is limited to being deployed to a single computer.
    /// </summary>
    /// <remarks>
    /// <para>Service accounts can be group managed and are called group managed service accounts (gMSA). Standalone managed service accounts (sMSA) are limited to being deployed to a single computer.</para>
    /// <para><strong>Windows Server 2008 R2 and Windows 7:</strong> The managed service account (MSA) is limited to being deployed to a single computer.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/dd894396.aspx">MSA_INFO_STATE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="MSA_INFO_0"/>
    public enum MSA_INFO_STATE
    {
        /// <summary>The account does not exist.</summary>
        MsaInfoNotExist = 1,
        /// <summary>
        /// The account exists, but it is not a group managed service account (gMSA) or a Windows Server 2008 R2 or Windows 7 managed service account.
        /// <para><strong>Windows Server 2008 R2 and Windows 7:</strong> The account is not a managed service account.</para>
        /// </summary>
        MsaInfoNotService,
        /// <summary>
        /// If the managed service account is a gMSA, the credentials cannot be fetched from the active directory or the Kerberos encryption types did not match.
        /// <para><strong>Windows Server 2008 R2 and Windows 7:</strong> The account is not a managed service account.</para>
        /// </summary>
        MsaInfoCannotInstall,
        /// <summary>
        /// The sMSA can be installed. This constant will never be returned for a gMSA. 
        /// <para><strong>Windows Server 2008 R2 and Windows 7:</strong> The account is not a managed service account.</para>
        /// </summary>
        MsaInfoCanInstall,
        /// <summary>
        /// The gMSA managed service account is installed.
        /// <para><strong>Windows Server 2008 R2 and Windows 7:</strong> The account is not a managed service account.</para>
        /// </summary>
        MsaInfoInstalled
    }
}

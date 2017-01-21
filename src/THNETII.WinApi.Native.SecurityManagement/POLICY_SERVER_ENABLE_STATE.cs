namespace Microsoft.Win32.WinApi.SecurityIdentity.SecurityManagement
{
    /// <summary>
    /// The <see cref="POLICY_SERVER_ENABLE_STATE"/> enumeration represents the state of the LSA server—that is, whether it is enabled or disabled. Some operations may only be performed on an enabled LSA server.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms722414.aspx">POLICY_SERVER_ENABLE_STATE enumeration</a></para>
    /// </remarks>
    public enum POLICY_SERVER_ENABLE_STATE
    {
        /// <summary>The LSA server is enabled.</summary>
        PolicyServerEnabled = 2,
        /// <summary>The LSA server is disabled.</summary>
        PolicyServerDisabled
    }
}

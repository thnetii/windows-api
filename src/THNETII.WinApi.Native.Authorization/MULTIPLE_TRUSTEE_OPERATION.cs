namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="MULTIPLE_TRUSTEE_OPERATION"/> enumeration contains values that indicate whether a <see cref="TRUSTEE"/> structure is an impersonation trustee.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379284.aspx">MULTIPLE_TRUSTEE_OPERATION enumeration</a></para>
    /// </remarks>
    /// <seealso cref="TRUSTEE"/>
    public enum MULTIPLE_TRUSTEE_OPERATION
    {
        /// <summary>The trustee is not an impersonation trustee.</summary>
        NO_MULTIPLE_TRUSTEE,
        /// <summary>The trustee is an impersonation trustee. The <see cref="TRUSTEE.pMultipleTrustee"/> member of the <see cref="TRUSTEE"/> structure points to a trustee for a server that can impersonate the client trustee.</summary>
        TRUSTEE_IS_IMPERSONATE
    }
}

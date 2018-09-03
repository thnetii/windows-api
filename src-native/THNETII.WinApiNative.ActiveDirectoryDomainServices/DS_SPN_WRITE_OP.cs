namespace THNETII.WinApiNative.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_SPN_WRITE_OP"/> enumeration identifies the type of write operation that should be performed by the <see cref="DsWriteAccountSpn"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-ds_spn_write_op">DS_SPN_WRITE_OP Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DsWriteAccountSpn"/>
    public enum DS_SPN_WRITE_OP
    {
        /// <summary>
        /// Adds the specified service principal names (SPNs) to the object identified by the <em>pszAccount</em> parameter in <see cref="DsWriteAccountSpn"/>.
        /// </summary>
        DS_SPN_ADD_SPN_OP = 0,          // add SPNs
        /// <summary>
        /// Removes all service principal names (SPNs) currently registered on the account identified by the <em>pszAccount</em> parameter in <see cref="DsWriteAccountSpn"/> and replaces them with the SPNs specified by the <em>rpszSpn</em> parameter in <see cref="DsWriteAccountSpn"/>.
        /// </summary>
        DS_SPN_REPLACE_SPN_OP = 1,      // set all SPNs
        /// <summary>
        /// Deletes the specified service principal names (SPNs) from the object identified by the <em>pszAccount</em> parameter in <see cref="DsWriteAccountSpn"/>.
        /// </summary>
        DS_SPN_DELETE_SPN_OP = 2        // Delete SPNs
    }
}

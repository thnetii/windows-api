namespace THNETII.WinApiNative.ActiveDirectoryDomainServices
{
    /// <summary>
    /// Specifies tasks that Knowledge Consistency Checker (KCC) can execute.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-ds_kcc_taskid">DS_KCC_TASKID Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DsReplicaConsistencyCheck"/>
    public enum DS_KCC_TASKID
    {
        /// <summary>
        /// Dynamically adjusts the data replication topology of a network.
        /// </summary>
        DS_KCC_TASKID_UPDATE_TOPOLOGY = 0
    }
}

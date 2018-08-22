namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPSYNCALL_ERROR"/> enumeration is used with the <see cref="DS_REPSYNCALL_ERRINFO"/> structure to indicate where in the replication process an error occurred.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-ds_repsyncall_error">DS_REPSYNCALL_ERROR Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPSYNCALL_ERRINFO"/>
    /// <seealso cref="DsReplicaSyncAll"/>
    public enum DS_REPSYNCALL_ERROR
    {
        /// <summary>
        /// The server referred to by the <see cref="DS_REPSYNCALL_ERRINFO.pszSvrId"/> member of the <see cref="DS_REPSYNCALL_ERRINFO"/> structure cannot be contacted.
        /// </summary>
        DS_REPSYNCALL_WIN32_ERROR_CONTACTING_SERVER = 0,
        /// <summary>
        /// An error occurred during replication of the server identified by the <see cref="DS_REPSYNCALL_ERRINFO.pszSvrId"/> member of the <see cref="DS_REPSYNCALL_ERRINFO"/> structure.
        /// </summary>
        DS_REPSYNCALL_WIN32_ERROR_REPLICATING = 1,
        /// <summary>
        /// The server identified by the <see cref="DS_REPSYNCALL_ERRINFO.pszSvrId"/> member of the <see cref="DS_REPSYNCALL_ERRINFO"/> structure cannot be contacted.
        /// </summary>
        DS_REPSYNCALL_SERVER_UNREACHABLE = 2
    }
}

namespace THNETII.WinApi.Native.MinWinBase
{
    /// <summary>
    /// Defines values that are used with the <see cref="FindFirstFileEx"/> function to specify the type of filtering to perform.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ne-minwinbase-findex_search_ops">FINDEX_SEARCH_OPS Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="FindFirstFileEx"/>
    public enum FINDEX_SEARCH_OPS
    {
        /// <summary>
        /// The search for a file that matches a specified file name.<br/>
        /// The <em>lpSearchFilter</em> parameter of <see cref="FindFirstFileEx"/> must be <see langword="null"/> when this search operation is used.
        /// </summary>
        FindExSearchNameMatch,
        /// <summary>
        /// This is an advisory flag. If the file system supports directory filtering, the function searches for a file that matches the specified name and is also a directory. If the file system does not support directory filtering, this flag is silently ignored.<br/>
        /// The <em>lpSearchFilter</em> parameter of <see cref="FindFirstFileEx"/> must be <see langword="null"/> when this search value is used.
        /// <para>
        /// If directory filtering is desired, this flag can be used on all file systems, but because it is an advisory flag and only affects file systems that support it, the application must examine the file attribute data stored in the <em>lpFindFileData</em> parameter of the <see cref="FindFirstFileEx"/> function to determine whether the function has returned a handle to a directory.
        /// </para>
        /// </summary>
        FindExSearchLimitToDirectories,
        /// <summary>
        /// This filtering type is not available.<br/>
        /// For more information, see <a href="http://go.microsoft.com/fwlink/p/?linkid=94247">Device Interface Classes</a>.
        /// </summary>
        FindExSearchLimitToDevices,
        /// <summary/>
        FindExSearchMaxSearchOp
    }
}

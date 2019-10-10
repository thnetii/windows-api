namespace THNETII.WinApi.Native.MinWinBase
{
    /// <summary>
    /// Defines values that are used with the <see cref="GetFileAttributesEx"/> and <see cref="GetFileAttributesTransacted"/> functions to specify the information level of the returned data.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ne-minwinbase-get_fileex_info_levels">GET_FILEEX_INFO_LEVELS Enumeration</a></para>
    /// </remarks>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/FileIO/file-management-enumerations">File Management Enumerations</seealso>
    /// <seealso cref="GetFileAttributesEx"/>
    /// <seealso cref="GetFileAttributesTransacted"/>
    /// <seealso cref="WIN32_FILE_ATTRIBUTE_DATA"/>
    public enum GET_FILEEX_INFO_LEVELS
    {
        /// <summary>
        /// The <see cref="GetFileAttributesEx"/> or <see cref="GetFileAttributesTransacted"/> function retrieves a standard set of attribute information. The data is returned in a <see cref="WIN32_FILE_ATTRIBUTE_DATA"/> structure.
        /// </summary>
        GetFileExInfoStandard,
        /// <summary>
        /// One greater than the maximum value. Valid values for this enumeration will be less than this value.
        /// </summary>
        GetFileExMaxInfoLevel
    }
}

namespace THNETII.WinApi.Native.MinWinBase
{
    /// <summary>
    /// Defines values that are used with the <see cref="FindFirstFileEx"/> function to specify the information level of the returned data.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ne-minwinbase-findex_info_levels">FINDEX_INFO_LEVELS Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="FindFirstFileEx"/>
    /// <seealso cref="WIN32_FIND_DATAW"/>
    public enum FINDEX_INFO_LEVELS
    {
        /// <summary>
        /// The <see cref="FindFirstFileEx"/> function retrieves a standard set of attribute information. The data is returned in a <see cref="WIN32_FIND_DATAW"/> structure.
        /// </summary>
        FindExInfoStandard,
        /// <summary>
        /// The <see cref="FindFirstFileEx"/> function does not query the short file name, improving overall enumeration speed. The data is returned in a <see cref="WIN32_FIND_DATAW"/> structure, and the <see cref="WIN32_FIND_DATAW.cAlternateFileName"/> member is always an empty string.
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported until Windows Server 2008 R2 and Windows 7.</para>
        /// </summary>
        FindExInfoBasic,
        /// <summary>
        /// This value is used for validation. Supported values are less than this value.
        /// </summary>
        FindExInfoMaxInfoLevel
    }
}

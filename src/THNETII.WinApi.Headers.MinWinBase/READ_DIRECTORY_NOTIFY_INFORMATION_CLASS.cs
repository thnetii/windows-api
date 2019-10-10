namespace THNETII.WinApi.Native.MinWinBase
{
    /// <summary>
    /// Indicates the possible types of information that an application that calls the <see cref="ReadDirectoryChangesExW"/> function can request.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ne-minwinbase-read_directory_notify_information_class">READ_DIRECTORY_NOTIFY_INFORMATION_CLASS Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="FILE_NOTIFY_EXTENDED_INFORMATION"/>
    /// <seealso cref="FILE_NOTIFY_INFORMATION"/>
    /// <seealso cref="ReadDirectoryChangesExW"/>
    public enum READ_DIRECTORY_NOTIFY_INFORMATION_CLASS
    {
        /// <summary>
        /// The <see cref="ReadDirectoryChangesExW"/> function should provide information that describes the changes within the specified directory, and return this information in the output buffer in the form of <see cref="FILE_NOTIFY_INFORMATION"/> structures.
        /// </summary>
        ReadDirectoryNotifyInformation = 1,
        /// <summary>
        /// The <see cref="ReadDirectoryChangesExW"/> function should provide extended information that describes the changes within the specified directory, and return this information in the output buffer in the form of <see cref="FILE_NOTIFY_EXTENDED_INFORMATION"/> structures.
        /// </summary>
        ReadDirectoryNotifyExtendedInformation // 2
    }
}

namespace THNETII.WinApi.Native.WinNT
{
    public enum FILE_ACTION_TYPE : int
    {
        /// <summary>
        /// The file was added to the directory. 
        /// </summary>
        FILE_ACTION_ADDED = WinNTConstants.FILE_ACTION_ADDED,
        /// <summary>
        /// The file was removed from the directory. 
        /// </summary>
        FILE_ACTION_REMOVED = WinNTConstants.FILE_ACTION_REMOVED,
        /// <summary>
        /// The file was modified. This can be a change in the time stamp or attributes. 
        /// </summary>
        FILE_ACTION_MODIFIED = WinNTConstants.FILE_ACTION_MODIFIED,
        /// <summary>
        /// The file was renamed and this is the old name. 
        /// </summary>
        FILE_ACTION_RENAMED_OLD_NAME = WinNTConstants.FILE_ACTION_RENAMED_OLD_NAME,
        /// <summary>
        /// The file was renamed and this is the new name. 
        /// </summary>
        FILE_ACTION_RENAMED_NEW_NAME = WinNTConstants.FILE_ACTION_RENAMED_NEW_NAME,
    }
}

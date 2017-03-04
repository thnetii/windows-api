namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// parmnum manifests for SetInfo calls (only comment is settable)
    /// </summary>
    public enum GROUP_NAME_PARMNUM : int
    {
        GROUP_ALL_PARMNUM = 0,
        /// <summary><var>grpi*_name</var></summary>
        GROUP_NAME_PARMNUM = 1,
        /// <summary><var>grpi*_comment</var></summary>
        GROUP_COMMENT_PARMNUM = 2,
        /// <summary><var>grpi*_attributes</var></summary>
        GROUP_ATTRIBUTES_PARMNUM = 3,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
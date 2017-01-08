using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="NET_DISPLAY_USER"/> structure contains information that an account manager can access to determine information about computers and their attributes.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370684.aspx">NET_DISPLAY_USER structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserAdd"/>
    /// <seealso cref="NetUserSetInfo"/>
    /// <seealso cref="NetQueryDisplayInformation"/>
    [StructLayout(LayoutKind.Sequential)]
    public class NET_DISPLAY_USER
    {
        /// <summary>A Unicode string that specifies the name of the computer to access.</summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1_name;
        /// <summary>
        /// A Unicode string that contains a comment associated with the computer. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1_comment;
        /// <summary>
        /// A set of flags that contains values that determine several features. Note that setting user account control flags may require certain <a href="https://msdn.microsoft.com/en-us/library/aa379306.aspx">privileges</a> and <a href="https://msdn.microsoft.com/en-us/library/ms675747.aspx">control access rights</a>. For more information, see the Remarks section of the <see cref="NetUserSetInfo"/> function.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        USER_FLAGS usri1_flags;
        /// <summary>
        /// A Unicode string that contains the full name of the user. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1_full_name;
        /// <summary>
        /// The relative identifier (RID) of the computer. The relative identifier is determined by the accounts database when the computer is defined. For more information about RIDS, see <a href="https://msdn.microsoft.com/en-us/library/aa379597.aspx">SID Components</a>.
        /// </summary>
        public int usri1_user_id;
        /// <summary>
        /// The index of the last entry returned by the <see cref="NetQueryDisplayInformation"/> function. Pass this value as the <em>Index</em> parameter to <see cref="NetQueryDisplayInformation"/> to return the next logical entry. Note that you should not use the value of this member for any purpose except to retrieve more data with additional calls to <see cref="NetQueryDisplayInformation"/>.
        /// </summary>
        public int usri1_next_index;
    }
}

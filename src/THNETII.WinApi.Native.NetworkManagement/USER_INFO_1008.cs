using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1008"/> structure contains a set of bit flags defining several user network account parameters. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371009.aspx">USER_INFO_1008 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1008
    {
        /// <summary>
        /// <para>The features to associate with the user account specified in the <var>username</var> parameter to the <see cref="NetUserSetInfo"/> function. </para>
        /// <para>Note that setting user account control flags may require certain <a href="https://msdn.microsoft.com/en-us/library/aa379306.aspx">privileges</a> and <a href="https://msdn.microsoft.com/en-us/library/ms675747.aspx">control access rights</a>. For more information, see the Remarks section of the <see cref="NetUserSetInfo"/> function.</para>
        /// <para>Only one account type value can be set. You cannot change the account type using the <see cref="NetUserSetInfo"/> function.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public USER_FLAGS usri1008_flags;
    }
}

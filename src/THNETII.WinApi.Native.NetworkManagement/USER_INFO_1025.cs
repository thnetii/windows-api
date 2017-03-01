using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1025"/> structure contains the code page code for a network user's language of choice. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371003.aspx">USER_INFO_1025 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1025
    {
        /// <summary>
        /// <para>Specifies a value that indicates the code page code for the user's language of choice. The user is specified in the username parameter to the <see cref="NetUserSetInfo"/> function. </para>
        /// <para>This value is ignored.</para>
        /// </summary>
        public int usri1025_code_page;
    }
}

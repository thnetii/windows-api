using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1024"/> structure contains the country/region code for a network user's language of choice. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370997.aspx">USER_INFO_1024 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1024
    {
        /// <summary>
        /// <para>Specifies a value that indicates the country/region code for the user's language of choice. The user is specified in the username parameter to the <see cref="NetUserSetInfo"/> function. </para>
        /// <para>This value is ignored.</para>
        /// </summary>
        public int usri1024_country_code;
    }
}

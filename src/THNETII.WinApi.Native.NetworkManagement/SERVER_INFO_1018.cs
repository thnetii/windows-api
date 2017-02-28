using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1018"/> structure contains information about how much the announce rate can vary for the specified server.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370902.aspx">SERVER_INFO_1018 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    /// <seealso cref="SERVER_INFO_102"/>
    /// <seealso cref="SERVER_INFO_1017"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1018
    {
        /// <summary>
        /// Specifies the delta value for the announce rate, in milliseconds. This value specifies how much the announce rate can vary from the period of time specified in the <strong>svX_announce</strong> member. 
        /// <para>The delta value allows randomly varied announce rates. For example, if the <strong>svX_announce</strong> member has the value <c>10</c> and the <strong>svX_anndelta</strong> member has the value <c>1</c>, the announce rate can vary from <c>9.999</c> seconds to <c>10.001</c> seconds. For more information, see <see cref="SERVER_INFO_102"/> and <see cref="SERVER_INFO_1017"/>.</para>
        /// </summary>
        public int sv1018_anndelta;
    }
}

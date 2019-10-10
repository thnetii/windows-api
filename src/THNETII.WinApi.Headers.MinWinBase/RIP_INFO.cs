using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinUser;

namespace THNETII.WinApi.Native.MinWinBase
{
    using static WinUserConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 351
    /// <summary>
    /// Contains the error that caused the RIP debug event.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-rip_info">RIP_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="DEBUG_EVENT"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct RIP_INFO
    {
        /// <summary>
        /// The error that caused the RIP debug event. For more information, see <a href="https://docs.microsoft.com/windows/desktop/Debug/error-handling">Error Handling</a>.
        /// </summary>
        public int dwError;
        /// <summary>
        /// Any additional information about the type of error that caused the RIP debug event.
        /// This member can be one of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="SLE_ERROR"/></term><description>Indicates that invalid data was passed to the function that failed. This caused the application to fail.</description></item>
        /// <item><term><see cref="SLE_MINORERROR"/></term><description> Indicates that invalid data was passed to the function, but the error probably will not cause the application to fail.</description></item>
        /// <item><term><see cref="SLE_WARNING"/></term><description>Indicates that potentially invalid data was passed to the function, but the function completed processing.</description></item>
        /// <item><term><c>0</c> (zero)</term><description>Indicates that only <see cref="dwError"/> was set.</description></item>
        /// </list>
        /// </summary>
        public int dwType;
    }
}

using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementErrorCode;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Declares the Network Management Functions.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370675.aspx">Network Management Functions</a></para>
    /// </remarks>
    public static class NetworkManagementFunctions
    {
        #region NetApiBufferAllocate function
        /// <summary>
        /// The <see cref="NetApiBufferAllocate"/> function allocates memory from the heap. Use this function only when compatibility with the <see cref="NetApiBufferFree"/> function is required. Otherwise, use one of the other memory management functions.
        /// </summary>
        /// <param name="ByteCount">Number of bytes to be allocated.</param>
        /// <param name="Buffer">Receives a pointer to the allocated buffer.</param>
        /// <returns>
        /// If the function succeeds, the return value is <see cref="NERR_Success"/>.<br/>
        /// If the function fails, the return value is a system error code from the <see cref="NetworkManagementErrorCode"/> enumeration.
        /// </returns>
        /// <remarks>
        /// <para>No special group membership is required to successfully execute the ApiBuffer functions.</para>
        /// <para>For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370676.aspx">Network Management Function Buffers</a> and <a href="https://msdn.microsoft.com/en-us/library/aa370677.aspx">Network Management Function Buffer Lengths</a>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370302.aspx">NetApiBufferAllocate function</a></para>
        /// </remarks>
        /// <seealso cref="NetApiBufferFree"/>
        /// <seealso cref="NetApiBufferReallocate"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern NetworkManagementErrorCode NetApiBufferAllocate(
            [In] int ByteCount,
            out IntPtr Buffer
            );
        #endregion
    }
}

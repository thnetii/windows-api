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
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern NetworkManagementErrorCode NetApiBufferAllocate(
            [In] int ByteCount,
            out IntPtr Buffer
            );
        #endregion
        #region NetApiBufferFree function
        /// <summary>
        /// The <see cref="NetApiBufferFree"/> function frees the memory that the <see cref="NetApiBufferAllocate"/> function allocates. Applications should also call <see cref="NetApiBufferFree"/> to free the memory that other network management functions use internally to return information.
        /// </summary>
        /// <param name="Buffer">A pointer to a buffer returned previously by another network management function or memory allocated by calling the <see cref="NetApiBufferAllocate"/> function.</param>
        /// <returns>
        /// If the function succeeds, the return value is <see cref="NERR_Success"/>.<br/>
        /// If the function fails, the return value is a system error code from the <see cref="NetworkManagementErrorCode"/> enumeration.
        /// </returns>
        /// <remarks>
        /// <para>
        /// The NetApiBufferFree function is used to free memory used by network management functions. This function is used in two cases:
        /// <list type="bullet">
        /// <item>To free memory explicitly allocated by calls in an application to the <see cref="NetApiBufferAllocate"/> function when the memory is no longer needed.</item>
        /// <item>To free memory allocated internally by calls in an application to remotable network management functions that return information to the caller. The RPC run-time library internally allocates the buffer containing the return information. </item>
        /// </list>
        /// </para>
        /// <para>Many network management functions retrieve information and return this information as a buffer that may contain a complex structure, an array of structures, or an array of nested structures. These functions use the RPC run-time library to internally allocate the buffer containing the return information, whether the call is to a local computer or a remote server. For example, the <see cref="NetServerEnum"/> function retrieves a lists of servers and returns this information as an array of structures pointed to by the <em>bufptr</em> parameter. When the function is successful, memory is allocated internally by the <see cref="NetServerEnum"/> function to store the array of structures returned in the <em>bufptr</em> parameter to the application. When this array of structures is no longer needed, the <see cref="NetApiBufferFree"/> function should be called by the application with the <paramref name="Buffer"/> parameter set to the <em>bufptr</em> parameter returned by <see cref="NetServerEnum"/> to free this internal memory used. In these cases, the <see cref="NetApiBufferFree"/> function frees all of the internal memory allocated for the buffer including memory for nested structures, pointers to strings, and other data.</para>
        /// <para>No special group membership is required to successfully execute the <see cref="NetApiBufferFree"/> function or any of the other <a href="https://msdn.microsoft.com/en-us/library/aa370245.aspx">ApiBuffer functions</a>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370304.aspx">NetApiBufferFree function</a></para>
        /// </remarks>
        /// <seealso cref="NetApiBufferAllocate"/>
        /// <seealso cref="NetApiBufferReallocate"/>
        /// <seealso cref="NetApiBufferSize"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern NetworkManagementErrorCode NetApiBufferFree(
            [In] IntPtr Buffer
            );
        #endregion
        #region NetApiBufferReallocate function
        /// <summary>
        /// The <see cref="NetApiBufferReallocate"/> function changes the size of a buffer allocated by a previous call to the <see cref="NetApiBufferAllocate"/> function.
        /// </summary>
        /// <param name="OldBuffer">Pointer to the buffer returned by a call to the <see cref="NetApiBufferAllocate"/> function.</param>
        /// <param name="NewByteCount">Specifies the new size of the buffer, in bytes.</param>
        /// <param name="NewBuffer">Receives the pointer to the reallocated buffer.</param>
        /// <returns>
        /// If the function succeeds, the return value is <see cref="NERR_Success"/>.<br/>
        /// If the function fails, the return value is a system error code from the <see cref="NetworkManagementErrorCode"/> enumeration.
        /// </returns>
        /// <remarks>
        /// <para>No special group membership is required to successfully execute the ApiBuffer functions.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370306.aspx">NetApiBufferReallocate function</a></para>
        /// </remarks>
        /// <seealso cref="NetApiBufferAllocate"/>
        /// <seealso cref="NetApiBufferFree"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern NetworkManagementErrorCode NetApiBufferReallocate(
            [In] IntPtr OldBuffer,
            [In] int NewByteCount,
            out IntPtr NewBuffer
            );
        #endregion
    }
}

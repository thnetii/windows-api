using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
    /// <summary>
    /// Defines the memory management functions.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa366781.aspx">Memory Management Functions</a></para>
    /// </remarks>
    public static class MemoryManagementFunctions
    {
        #region AddSecureMemoryCacheCallback function
        /// <summary>
        /// Registers a callback function to be called when a secured memory range is freed or its protections are changed.
        /// </summary>
        /// <param name="pfnCallBack">A reference to the application-defined <see cref="SecureMemoryCacheCallback"/> function to register.</param>
        /// <returns>
        /// If the function succeeds, it returns <c>true</c>.<br/>
        /// If the function fails, it returns <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>An application that performs I/O directly to a high-performance device typically caches a virtual-to-physical memory mapping for the buffer it uses for the I/O. The device's driver typically secures this memory address range by calling the <see cref="MmSecureVirtualMemory"/> routine, which prevents the memory range from being freed or its protections changed until the driver unsecures the memory.</para>
        /// <para>An application can use <see cref="AddSecureMemoryCacheCallback"/> to register a callback function that will be called when the memory is freed or its protections are changed, so the application can invalidate its cached memory mapping. For more information, see <see cref="SecureMemoryCacheCallback"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows Vista with SP1 [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/bb870879.aspx">AddSecureMemoryCacheCallback function</a></para>
        /// </remarks>
        /// <seealso cref="RemoveSecureMemoryCacheCallback"/>
        /// <seealso cref="SecureMemoryCacheCallback"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddSecureMemoryCacheCallback(
            [In] SecureMemoryCacheCallback pfnCallBack
            );
        #endregion
        #region SecureMemoryCacheCallback callback function
        /// <summary>
        /// An application-defined function previously registered with the <see cref="AddSecureMemoryCacheCallback"/> function that is called when a secured memory range is freed or its protections are changed.
        /// </summary>
        /// <param name="Addr">The starting address of the memory range.</param>
        /// <param name="Range">The size of the memory range, in bytes.</param>
        /// <returns>
        /// <para>The return value indicates the success or failure of this function.</para>
        /// <para>If the caller has secured the specified memory range, this function should unsecure the memory and return <c>true</c>.</para>
        /// <para>If the caller has not secured the specified memory range, this function should return <c>false</c>.</para>
        /// </returns>
        /// <remarks>
        /// <para>After the callback function is registered, it is called after any attempt to free the specified memory range or change its protections. If the application has secured any part of the specified memory range, the callback function must invalidate all of the application's cached memory mappings for the secured memory range, unsecure the secured parts of the memory range, and return <c>true</c>. Otherwise it must return <c>false</c>.</para>
        /// <para>The application secures and unsecures a memory range by sending requests to a device driver, which uses the <see cref="MmSecureVirtualMemory"/> and <see cref="MmUnsecureVirtualMemory"/> functions to actually secure and unsecure the range. Operations on other types of secured or locked memory do not trigger this callback.</para>
        /// <para>Examples of function calls that trigger the callback function include calls to the <see cref="VirtualFree"/>, <see cref="VirtualFreeEx"/>, <see cref="VirtualProtect"/>, <see cref="VirtualProtectEx"/>, and <see cref="UnmapViewOfFile"/> functions.</para>
        /// <para>The callback function can also be triggered by a heap operation. In this case, the function must not perform any further operations on the heap that triggered the callback. This includes calling <a href="https://msdn.microsoft.com/en-us/library/aa366711.aspx">heap functions</a> on a private heap or the process's default heap, or calling standard library functions such as <strong>malloc</strong> and <strong>free</strong>, which implicitly use the process's default heap.</para>
        /// <para>To unregister the callback function, use the <see cref="RemoveSecureMemoryCacheCallback"/> function.</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/bb870882.aspx">SecureMemoryCacheCallback callback function</a></para>
        /// </remarks>
        /// <seealso cref="AddSecureMemoryCacheCallback"/>
        /// <seealso cref="RemoveSecureMemoryCacheCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool SecureMemoryCacheCallback(
            [In] IntPtr Addr,
            [In, MarshalAs(UnmanagedType.SysUInt)] ulong Range
            );
        #endregion
    }
}

using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.GMEM_FLAGS;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;

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
        #region GlobalAlloc function
        /// <summary>
        /// Allocates the specified number of bytes from the heap.
        /// <para><note>The global functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/en-us/library/aa366711.aspx">heap functions</a> unless documentation states that a global function should be used. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa366596.aspx">Global and Local Functions</a>.</note></para>
        /// </summary>
        /// <param name="uFlags">The memory allocation attributes. If zero is specified, the default is <see cref="GMEM_FIXED"/>. This parameter can be one or more of the values defined in the <see cref="GMEM_FLAGS"/> enumeration type., except for the incompatible combinations that are specifically noted.</param>
        /// <param name="dwBytes">The number of bytes to allocate. If this parameter is zero and the <paramref name="uFlags"/> parameter specifies <see cref="GMEM_MOVEABLE"/>, the function returns a handle to a memory object that is marked as discarded.</param>
        /// <returns>
        /// If the function succeeds, the return value is a handle to the newly allocated memory object.<br/>
        /// If the function fails, the return value is <c>null</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>Windows memory management does not provide a separate local heap and global heap. Therefore, the <see cref="GlobalAlloc"/> and <see cref="LocalAlloc"/> functions are essentially the same. </para>
        /// <para>The movable-memory flags <see cref="GHND"/> and <see cref="GMEM_MOVEABLE"/> add unnecessary overhead and require locking to be used safely. They should be avoided unless documentation specifically states that they should be used.</para>
        /// <para>New applications should use the <a href="https://msdn.microsoft.com/en-us/library/aa366711.aspx">heap functions</a> to allocate and manage memory unless the documentation specifically states that a global function should be used. For example, the global functions are still used with Dynamic Data Exchange (DDE), the clipboard functions, and OLE data objects. </para>
        /// <para>If the <see cref="GlobalAlloc"/> function succeeds, it allocates at least the amount of memory requested. If the actual amount allocated is greater than the amount requested, the process can use the entire amount. To determine the actual number of bytes allocated, use the <see cref="GlobalSize"/> function.</para>
        /// <para>Memory allocated with this function is guaranteed to be aligned on an 8-byte boundary. To execute dynamically generated code, use the <see cref="VirtualAlloc"/> function to allocate memory and the <see cref="VirtualProtect"/> function to grant <see cref="PAGE_EXECUTE"/> access.</para>
        /// <para>To free the memory, use the <see cref="SafeHandle.Dispose()"/> method on the returned handle.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa366574.aspx">GlobalAlloc function</a></para>
        /// </remarks>
        /// <seealso cref="GlobalDiscard"/>
        /// <seealso cref="GlobalFree"/>
        /// <seealso cref="GlobalLock"/>
        /// <seealso cref="GlobalSize"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern HGlobalNativeSafeHandle GlobalAlloc(
            [In, MarshalAs(UnmanagedType.U4)] GMEM_FLAGS uFlags,
            [In, MarshalAs(UnmanagedType.SysUInt)] ulong dwBytes
            );
        #endregion
        #region GlobalDiscard macro
        /// <summary>
        /// Discards the specified global memory block. The lock count of the memory object must be zero.
        /// <para><note>The global functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/en-us/library/aa366711.aspx">heap functions</a> unless documentation states that a global function should be used. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa366596.aspx">Global and Local Functions</a>.</note></para>
        /// </summary>
        /// <param name="hMem">A handle to the global memory object. This handle is returned by either the <see cref="GlobalAlloc"/> or <see cref="GlobalReAlloc"/> function.</param>
        /// <returns>
        /// If the function succeeds, the return value is a handle to the memory object.<br/>
        /// If the function fails, the return value is <see cref="IntPtr.Zero"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// Although <see cref="GlobalDiscard"/> discards the object's memory block, the handle to the object remains valid. The process can subsequently pass the handle to the <see cref="GlobalReAlloc"/> function to allocate another global memory block identified by the same handle.
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa366590.aspx">GlobalReAlloc function</a></para>
        /// </remarks>
        /// <seealso cref="GlobalAlloc"/>
        /// <seealso cref="GlobalReAlloc"/>
        public static IntPtr GlobalDiscard(IntPtr hMem) => GlobalReAlloc(hMem, 0, GMEM_MOVEABLE);
        #endregion
        #region GlobalFlags function
        /// <summary>
        /// Retrieves information about the specified global memory object.
        /// <para><note>This function is provided only for compatibility with 16-bit versions of Windows. New applications should use the <a href="https://msdn.microsoft.com/en-us/library/aa366711.aspx">heap functions</a>. For more information, see Remarks.</note></para>
        /// </summary>
        /// <param name="hMem">A handle to the global memory object. This handle is returned by either the <see cref="GlobalAlloc"/> or <see cref="GlobalReAlloc"/> function.</param>
        /// <returns>
        /// If the function succeeds, the return value specifies the allocation values and the lock count for the memory object.<br/>
        /// If the function fails, the return value is <see cref="GMEM_INVALID_HANDLE"/>, indicating that the global handle is not valid. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>To retrieve the lock count from the return value, use the <see cref="GlobalMemoryFlagsExtensions.GetLockCount(GMEM_FLAGS)"/> method. The lock count of memory objects allocated with <see cref="GMEM_FIXED"/> is always zero.</para>
        /// <para>The high-order byte of the low-order word of the return value indicates the allocation values of the memory object. It can be zero or <see cref="GMEM_DISCARDED"/>.</para>
        /// <para>The global functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/en-us/library/aa366711.aspx">heap functions</a> unless documentation states that a global function should be used. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa366596.aspx">Global and Local Functions</a>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa366577.aspx">GlobalFlags function</a></para>
        /// </remarks>
        /// <seealso cref="GlobalAlloc"/>
        /// <seealso cref="GlobalDiscard"/>
        /// <seealso cref="GlobalReAlloc"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern GMEM_FLAGS GlobalFlags(
            [In] HGlobalNativeSafeHandle hMem
            );
        #endregion
        #region GlobalFree function
        /// <summary>
        /// Frees the specified global memory object and invalidates its handle.
        /// <para><note>The global functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/en-us/library/aa366711.aspx">heap functions</a> unless documentation states that a global function should be used. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa366596.aspx">Global and Local Functions</a>.</note></para>
        /// </summary>
        /// <param name="hMem">A handle to the global memory object. This handle is returned by either the <see cref="GlobalAlloc"/> or <see cref="GlobalReAlloc"/> function. It is not safe to free memory allocated with <see cref="LocalAlloc"/>.</param>
        /// <returns>
        /// If the function succeeds, the return value is <see cref="IntPtr.Zero"/>.<br/>
        /// If the function fails, the return value is equal to a handle to the global memory object. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>If the process examines or modifies the memory after it has been freed, heap corruption may occur or an access violation exception may be generated.</para>
        /// <para>The <see cref="GlobalFree"/> function will free a locked memory object. A locked memory object has a lock count greater than zero. The <see cref="GlobalLock"/> function locks a global memory object and increments the lock count by one. The <see cref="GlobalUnlock"/> function unlocks it and decrements the lock count by one. To get the lock count of a global memory object, use the <see cref="GlobalFlags"/> function.</para>
        /// <para>If an application is running under a debug version of the system, <see cref="GlobalFree"/> will issue a message that tells you that a locked object is being freed. If you are debugging the application, <see cref="GlobalFree"/> will enter a breakpoint just before freeing a locked object. This allows you to verify the intended behavior, then continue execution.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa366579.aspx">GlobalFree function</a></para>
        /// </remarks>
        /// <seealso cref="GlobalAlloc"/>
        /// <seealso cref="GlobalFlags"/>
        /// <seealso cref="GlobalLock"/>
        /// <seealso cref="GlobalReAlloc"/>
        /// <seealso cref="GlobalUnlock"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern IntPtr GlobalFree(
            [In] IntPtr hMem
            );
        #endregion
        #region GlobalHandle function
        /// <summary>
        /// Retrieves the handle associated with the specified pointer to a global memory block.
        /// <para><note>The global functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/en-us/library/aa366711.aspx">heap functions</a> unless documentation states that a global function should be used. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa366596.aspx">Global and Local Functions</a>.</note></para>
        /// </summary>
        /// <param name="pMem">A pointer to the first byte of the global memory block. This pointer is returned by the <see cref="GlobalLock"/> function.</param>
        /// <returns>
        /// If the function succeeds, the return value is a handle to the specified global memory object.<br/>
        /// If the function fails, the return value is <see cref="IntPtr.Zero"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// When the <see cref="GlobalAlloc"/> function allocates a memory object with <see cref="GMEM_MOVEABLE"/>, it returns a handle to the object. The <see cref="GlobalLock"/> function converts this handle into a pointer to the memory block, and <see cref="GlobalHandle"/> converts the pointer back into a handle.
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa366582.aspx">GlobalHandle function</a></para>
        /// </remarks>
        /// <seealso cref="GlobalAlloc"/>
        /// <seealso cref="GlobalLock"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern IntPtr GlobalHandle(
            [In] IntPtr pMem
            );
        #endregion
        #region GlobalLock function
        /// <summary>
        /// Locks a global memory object and returns a pointer to the first byte of the object's memory block.
        /// <para><note>The global functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/en-us/library/aa366711.aspx">heap functions</a> unless documentation states that a global function should be used. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa366596.aspx">Global and Local Functions</a>.</note></para>
        /// </summary>
        /// <param name="hMem">A handle to the global memory object. This handle is returned by either the <see cref="GlobalAlloc"/> or <see cref="GlobalReAlloc"/> function.</param>
        /// <returns>
        /// If the function succeeds, the return value is a pointer to the first byte of the memory block.<br/>
        /// If the function fails, the return value is <see cref="IntPtr.Zero"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The internal data structures for each memory object include a lock count that is initially zero. For movable memory objects, <see cref="GlobalLock"/> increments the count by one, and the <see cref="GlobalUnlock"/> function decrements the count by one. Each successful call that a process makes to <see cref="GlobalLock"/> for an object must be matched by a corresponding call to <see cref="GlobalUnlock"/>. Locked memory will not be moved or discarded, unless the memory object is reallocated by using the <see cref="GlobalReAlloc"/> function. The memory block of a locked memory object remains locked until its lock count is decremented to zero, at which time it can be moved or discarded.</para>
        /// <para>Memory objects allocated with <see cref="GMEM_FIXED"/> always have a lock count of zero. For these objects, the value of the returned pointer is equal to the value of the specified handle.</para>
        /// <para>If the specified memory block has been discarded or if the memory block has a zero-byte size, this function returns <see cref="IntPtr.Zero"/>.</para>
        /// <para>Discarded objects always have a lock count of zero.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa366584.aspx">GlobalLock function</a></para>
        /// </remarks>
        /// <seealso cref="GlobalAlloc"/>
        /// <seealso cref="GlobalReAlloc"/>
        /// <seealso cref="GlobalUnlock"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern HGlobalNativeLockedSafeHandle GlobalLock(
            [In] HGlobalNativeSafeHandle hMem
            );
        #endregion
        #region GlobalReAlloc function
        /// <summary>
        /// Changes the size or attributes of a specified global memory object. The size can increase or decrease.
        /// <para><note>The global functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/en-us/library/aa366711.aspx">heap functions</a> unless documentation states that a global function should be used. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa366596.aspx">Global and Local Functions</a>.</note></para>
        /// </summary>
        /// <param name="hMem">A handle to the global memory object to be reallocated. This handle is returned by either the <see cref="GlobalAlloc"/> or <see cref="GlobalReAlloc"/> function.</param>
        /// <param name="dwBytes">The new size of the memory block, in bytes. If <paramref name="uFlags"/> specifies <see cref="GMEM_MODIFY"/>, this parameter is ignored.</param>
        /// <param name="uFlags">
        /// <para>The reallocation options. If <see cref="GMEM_MODIFY"/> is specified, the function modifies the attributes of the memory object only (the <paramref name="dwBytes"/> parameter is ignored.) Otherwise, the function reallocates the memory object.</para>
        /// <para><see cref="GMEM_MOVEABLE"/>: If the memory is a locked <see cref="GMEM_MOVEABLE"/> memory block or a <see cref="GMEM_FIXED"/> memory block and this flag is not specified, the memory can only be reallocated in place.</para>
        /// <para><see cref="GMEM_ZEROINIT"/>: If <see cref="GMEM_MODIFY"/> is not specified, this flag causes the additional memory contents to be initialized to zero if the memory object is growing in size.</para>
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is a handle to the reallocated memory object.<br/>
        /// If the function fails, the return value is <see cref="IntPtr.Zero"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>If <see cref="GlobalReAlloc"/> reallocates a movable object, the return value is a handle to the memory object. To convert the handle to a pointer, use the <see cref="GlobalLock"/> function.</para>
        /// <para>If <see cref="GlobalReAlloc"/> reallocates a fixed object, the value of the handle returned is the address of the first byte of the memory block.</para>
        /// <para>If <see cref="GlobalReAlloc"/> fails, the original memory is not freed, and the original handle and pointer are still valid.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa366590.aspx">GlobalReAlloc function</a></para>
        /// </remarks>
        /// <seealso cref="GlobalAlloc"/>
        /// <seealso cref="GlobalDiscard"/>
        /// <seealso cref="GlobalLock"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern IntPtr GlobalReAlloc(
            [In] IntPtr hMem,
            [In, MarshalAs(UnmanagedType.SysUInt)] ulong dwBytes,
            [In, MarshalAs(UnmanagedType.U4)] GMEM_FLAGS uFlags
            );
        #endregion
        #region GlobalSize function
        /// <summary>
        /// Retrieves the current size of the specified global memory object, in bytes.
        /// <para><note>The global functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/en-us/library/aa366711.aspx">heap functions</a> unless documentation states that a global function should be used. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa366596.aspx">Global and Local Functions</a>.</note></para>
        /// </summary>
        /// <param name="hMem">A handle to the global memory object. This handle is returned by either the <see cref="GlobalAlloc"/> or <see cref="GlobalReAlloc"/> function.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is the size of the specified global memory object, in bytes.</para>
        /// <para>If the specified handle is not valid or if the object has been discarded, the return value is zero. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The size of a memory block may be larger than the size requested when the memory was allocated.</para>
        /// <para>To verify that the specified object's memory block has not been discarded, use the <see cref="GlobalFlags"/> function before calling <see cref="GlobalSize"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa366593.aspx">GlobalSize function</a></para>
        /// </remarks>
        /// <seealso cref="GlobalAlloc"/>
        /// <seealso cref="GlobalFlags"/>
        /// <seealso cref="GlobalReAlloc"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern ulong GlobalSize(
            [In] HGlobalNativeSafeHandle hMem
            );
        #endregion
        #region GlobalUnlock function
        /// <summary>
        /// Decrements the lock count associated with a memory object that was allocated with <see cref="GMEM_MOVEABLE"/>. This function has no effect on memory objects allocated with <see cref="GMEM_FIXED"/>.
        /// <para><note>The global functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/en-us/library/aa366711.aspx">heap functions</a> unless documentation states that a global function should be used. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa366596.aspx">Global and Local Functions</a>.</note></para>
        /// </summary>
        /// <param name="hMem">A handle to the global memory object. This handle is returned by either the <see cref="GlobalAlloc"/> or <see cref="GlobalReAlloc"/> function.</param>
        /// <returns>
        /// <para>If the memory object is still locked after decrementing the lock count, the return value is <c>true</c>. If the memory object is unlocked after decrementing the lock count, the function returns <c>false</c> and <see cref="Marshal.GetLastWin32Error"/> returns <see cref="NO_ERROR"/>.</para>
        /// <para>If the function fails, the return value is <c>false</c> and <see cref="Marshal.GetLastWin32Error"/> returns a value other than <see cref="NO_ERROR"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The internal data structures for each memory object include a lock count that is initially zero. For movable memory objects, the <see cref="GlobalLock"/> function increments the count by one, and <see cref="GlobalUnlock"/> decrements the count by one. For each call that a process makes to <see cref="GlobalLock"/> for an object, it must eventually call <see cref="GlobalUnlock"/>. Locked memory will not be moved or discarded, unless the memory object is reallocated by using the <see cref="GlobalReAlloc"/> function. The memory block of a locked memory object remains locked until its lock count is decremented to zero, at which time it can be moved or discarded.</para>
        /// <para>Memory objects allocated with <see cref="GMEM_FIXED"/> always have a lock count of zero. If the specified memory block is fixed memory, this function returns <c>true</c>.</para>
        /// <para>If the memory object is already unlocked, <see cref="GlobalUnlock"/> returns <c>false</c> and <see cref="Marshal.GetLastWin32Error"/> reports <see cref="ERROR_NOT_LOCKED"/>.</para>
        /// <para>A process should not rely on the return value to determine the number of times it must subsequently call <see cref="GlobalUnlock"/> for a memory object.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa366595.aspx">GlobalUnlock function</a></para>
        /// </remarks>
        /// <seealso cref="GlobalAlloc"/>
        /// <seealso cref="GlobalLock"/>
        /// <seealso cref="GlobalReAlloc"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalUnlock(
            [In] IntPtr hMem
            );
        #endregion
    }
}

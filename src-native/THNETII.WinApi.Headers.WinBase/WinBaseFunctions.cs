using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

using THNETII.InteropServices.Bitwise;
using THNETII.InteropServices.Memory;

using THNETII.WinApi.Native.MinWinBase;
using THNETII.WinApi.Native.MinWinDef;
using THNETII.WinApi.Native.WinError;

#if NETSTANDARD1_6
using AccessViolationException = System.Exception;
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.WinBase
{
    using static LMEM_FLAGS;
    using static NativeLibraryNames;
    using static WinErrorConstants;

    public static partial class WinBaseFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 82
        #region DefineHandleTable macro
        // #define DefineHandleTable(w)            ((w),TRUE)
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 83
        #region LimitEmsPages macro
        [SuppressMessage("Style", "IDE0060: Remove unused parameter")]
        [SuppressMessage("Usage", "CA1801: Review unused parameters")]
        public static void LimitEmsPages(int dw) { }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 84
        #region SetSwapAreaSize macro
        // #define SetSwapAreaSize(w)              (w)
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 85
        #region LockSegment macro
        // #define LockSegment(w)                  GlobalFix((HANDLE)(w))
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 86
        #region UnlockSegment macro
        // #define UnlockSegment(w)                GlobalUnfix((HANDLE)(w))
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 94
        #region GetCurrentTime macro
        // TODO: #define GetCurrentTime()                GetTickCount()
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 116
        #region CaptureStackBackTrace function
        /// <summary>
        /// Captures a stack back trace by walking up the stack and recording the information for each frame.
        /// </summary>
        /// <param name="FramesToSkip">The number of frames to skip from the start of the back trace.</param>
        /// <param name="FramesToCapture">
        /// The number of frames to be captured. You can capture up to the <see cref="ushort.MaxValue"/> of the <see cref="ushort"/> type frames.
        /// <para><strong>Windows Server 2003 and Windows XP:</strong> The sum of the <paramref name="FramesToSkip"/> and <paramref name="FramesToCapture"/> parameters must be less than <c>63</c>.</para>
        /// </param>
        /// <param name="BackTrace">Receives a pointer to an array of stack frame pointers from the current stack trace.</param>
        /// <param name="BackTraceHash">
        /// A value that can be used to organize hash tables. The value is optional and can be ignored or discarded.
        /// <para>This value is calculated based on the values of the pointers returned in the <paramref name="BackTrace"/> array. Two identical stack traces will generate identical hash values.</para>
        /// </param>
        /// <returns>The number of captured frames.</returns>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/library/Bb204633.aspx">CaptureStackBackTrace function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        public static unsafe ushort CaptureStackBackTrace(
            int FramesToSkip,
            int FramesToCapture,
            out IntPtr* BackTrace,
            out int BackTraceHash
            ) => WinNT.WinNTFunctions.RtlCaptureStackBackTrace(FramesToSkip, FramesToCapture, out BackTrace, out BackTraceHash);
        /// <inheritdoc cref="CaptureStackBackTrace(int, int, out IntPtr*, out int)"/>
        public static unsafe ReadOnlySpan<IntPtr> CaptureStackBackTrace(
            int FramesToSkip,
            int FramesToCapture,
            out int BackTraceHash
            )
        {
            var length = CaptureStackBackTrace(FramesToSkip, FramesToCapture, out IntPtr* BackTrace, out BackTraceHash);
            return new ReadOnlySpan<IntPtr>(BackTrace, length);
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 1082
        #region LocalAlloc function
        /// <summary>
        /// <para>Allocates the specified number of bytes from the heap.</para>
        /// <note>The local functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/cfb683fa-4f46-48b5-9a28-f4625a9cb8cd">heap functions</a> unless documentation states that a local function should be used. For more information, see <a href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</a>.</note>
        /// </summary>
        /// <param name="uFlags">
        /// The memory allocation attributes. The default is the <see cref="LMEM_FIXED"/> value. This parameter can be one or more of the following values, except for the incompatible combinations that are specifically noted.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="LHND"/></term><description>Combines <see cref="LMEM_MOVEABLE"/> and <see cref="LMEM_ZEROINIT"/>. </description></item>
        /// <item><term><see cref="LMEM_FIXED"/></term><description>Allocates fixed memory. The return value is a pointer to the memory object. </description></item>
        /// <item><term><see cref="LMEM_MOVEABLE"/></term><description><para>Allocates movable memory. Memory blocks are never moved in physical memory, but they can be moved within the default heap.<br/>The return value is a handle to the memory object. To translate the handle to a pointer, use the <see cref="LocalLock"/> function.</para>This value cannot be combined with <see cref="LMEM_FIXED"/>.<para></para></description></item>
        /// <item><term><see cref="LMEM_ZEROINIT"/></term><description>Initializes memory contents to zero. </description></item>
        /// <item><term><see cref="LPTR"/></term><description>Combines <see cref="LMEM_FIXED"/> and <see cref="LMEM_ZEROINIT"/>. </description></item>
        /// <item><term><see cref="NONZEROLHND"/></term><description>Same as <see cref="LMEM_MOVEABLE"/>. </description></item>
        /// <item><term><see cref="NONZEROLPTR"/></term><description>Same as <see cref="LMEM_FIXED"/>. </description></item>
        /// </list>
        /// The following values are obsolete, but are provided for compatibility with 16-bit Windows. They are ignored.
        /// <list type="bullet">
        /// <item><term><see cref="LMEM_DISCARDABLE"/></term></item>
        /// <item><term><see cref="LMEM_NOCOMPACT"/></term></item>
        /// <item><term><see cref="LMEM_NODISCARD"/></term></item>
        /// </list>
        /// </param>
        /// <param name="uBytes">The number of bytes to allocate. If this parameter is <c>0</c> (zero) and the <paramref name="uFlags"/> parameter specifies <see cref="LMEM_MOVEABLE"/>, the function returns a handle to a memory object that is marked as discarded.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is a handle to the newly allocated memory object.</para>
        /// <para>If the function fails, the return value is an <see cref="HLOCAL"/> value representing a null-pointer. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>Windows memory management does not provide a separate local heap and global heap. Therefore, the <see cref="LocalAlloc"/> and <see cref="GlobalAlloc"/> functions are essentially the same.</para>
        /// <para>The movable-memory flags <see cref="LHND"/>, <see cref="LMEM_MOVEABLE"/>, and <see cref="NONZEROLHND"/> add unnecessary overhead and require locking to be used safely. They should be avoided unless documentation specifically states that they should be used.</para>
        /// <para>New applications should use the <a href="https://msdn.microsoft.com/cfb683fa-4f46-48b5-9a28-f4625a9cb8cd">heap functions</a> unless the documentation specifically states that a local function should be used. For example, some Windows functions allocate memory that must be freed with <see cref="LocalFree"/>.</para>
        /// <para>If the heap does not contain sufficient free space to satisfy the request, <see cref="LocalAlloc"/> returns a null-pointer. Because a null-pointer is used to indicate an error, virtual address zero is never allocated. It is, therefore, easy to detect the use of a null pointer.</para>
        /// <para>If the <see cref="LocalAlloc"/> function succeeds, it allocates at least the amount requested. If the amount allocated is greater than the amount requested, the process can use the entire amount. To determine the actual number of bytes allocated, use the <see cref="LocalSize"/> function.</para>
        /// <para>To free the memory, use the <see cref="LocalFree"/> function. It is not safe to free memory allocated with <see cref="LocalAlloc"/> using <see cref="GlobalFree"/> or <see cref="Marshal.FreeHGlobal"/>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winbase/nf-winbase-localalloc">LocalAlloc function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="LocalFree"/>
        /// <seealso cref="LocalLock"/>
        /// <seealso cref="LocalReAlloc"/>
        /// <seealso cref="LocalSize"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern HLOCAL LocalAlloc(
            [MarshalAs(UnmanagedType.I4)] LMEM_FLAGS uFlags,
            [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uBytes
            );
        #endregion
        #region LocalReAlloc function
        /// <summary>
        /// <para>Changes the size or the attributes of a specified local memory object. The size can increase or decrease.</para>
        /// <note>The local functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/cfb683fa-4f46-48b5-9a28-f4625a9cb8cd">heap functions</a> unless documentation states that a local function should be used. For more information, see <a href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</a>.</note>
        /// </summary>
        /// <param name="hMem">A handle to the local memory object to be reallocated. This handle is returned by either the <see cref="LocalAlloc"/> or <see cref="LocalReAlloc"/> function.</param>
        /// <param name="uBytes">The new size of the memory block, in bytes. If <paramref name="uFlags"/> specifies <see cref="LMEM_MODIFY"/>, this parameter is ignored.</param>
        /// <param name="uFlags">
        /// <para>The reallocation options. If <see cref="LMEM_MODIFY"/> is specified, the function modifies the attributes of the memory object only (the <paramref name="uBytes"/> parameter is ignored.) Otherwise, the function reallocates the memory object.</para>
        /// <para>
        /// You can optionally combine <see cref="LMEM_MODIFY"/> with the following value.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="LMEM_MOVEABLE"/></term><description>Allocates fixed or movable memory.<br/>If the memory is a locked <see cref="LMEM_MOVEABLE"/> memory block or a <see cref="LMEM_FIXED"/> memory block and this flag is not specified, the memory can only be reallocated in place.</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// If this parameter does not specify <see cref="LMEM_MODIFY"/>, you can use the following value.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="LMEM_ZEROINIT"/></term><description>Causes the additional memory contents to be initialized to zero if the memory object is growing in size.</description></item>
        /// </list>
        /// </para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is a handle to the reallocated memory object.</para>
        /// <para>If the function fails, the return value is an <see cref="HLOCAL"/> value representing a null-pointer. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>If <see cref="LocalReAlloc"/> fails, the original memory is not freed, and the original handle and pointer are still valid.</para>
        /// <para>If <see cref="LocalReAlloc"/> reallocates a fixed object, the value of the handle returned is the address of the first byte of the memory block. To access the memory, a process can simply cast the <see cref="HLOCAL.Pointer"/> property of the return value to a pointer.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winbase/nf-winbase-localrealloc">LocalReAlloc function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="LocalAlloc"/>
        /// <seealso cref="LocalFree"/>
        /// <seealso cref="LocalLock"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern HLOCAL LocalReAlloc(
            HLOCAL hMem,
            [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uBytes,
            [MarshalAs(UnmanagedType.I4)] LMEM_FLAGS uFlags
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 1110
        #region LocalLock function
        /// <summary>
        /// <para>Locks a local memory object and returns a pointer to the first byte of the object's memory block.</para>
        /// <note>The local functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/cfb683fa-4f46-48b5-9a28-f4625a9cb8cd">heap functions</a> unless documentation states that a local function should be used. For more information, see <a href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</a>.</note>
        /// </summary>
        /// <param name="hMem">A handle to the local memory object. This handle is returned by either the <see cref="LocalAlloc"/> or <see cref="LocalReAlloc"/> function.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is a pointer to the first byte of the memory block.</para>
        /// <para>If the function fails, the return value is <see cref="IntPtr.Zero"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The internal data structures for each memory object include a lock count that is initially zero. For movable memory objects, <see cref="LocalLock"/> increments the count by one, and the <see cref="LocalUnlock"/> function decrements the count by one. Each successful call that a process makes to <see cref="LocalLock"/> for an object must be matched by a corresponding call to <see cref="LocalUnlock"/>. Locked memory will not be moved or discarded unless the memory object is reallocated by using the <see cref="LocalReAlloc"/> function. The memory block of a locked memory object remains locked in memory until its lock count is decremented to zero, at which time it can be moved or discarded.</para>
        /// <para>Memory objects allocated with <see cref="LMEM_FIXED"/> always have a lock count of zero. For these objects, the value of the returned pointer is equal to the value of the specified handle.</para>
        /// <para>If the specified memory block has been discarded or if the memory block has a zero-byte size, this function returns <see cref="IntPtr.Zero"/>.</para>
        /// <para>Discarded objects always have a lock count of zero.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winbase/nf-winbase-locallock">LocalLock function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="LocalAlloc"/>
        /// <seealso cref="LocalFlags"/>
        /// <seealso cref="LocalReAlloc"/>
        /// <seealso cref="LocalUnlock"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern IntPtr LocalLock(
            HLOCAL hMem
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 1124
        #region LocalHandle function
        /// <summary>
        /// Retrieves the handle associated with the specified pointer to a local memory object.
        /// <note>The local functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/cfb683fa-4f46-48b5-9a28-f4625a9cb8cd">heap functions</a> unless documentation states that a local function should be used. For more information, see <a href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</a>.</note>
        /// </summary>
        /// <param name="pMem">A pointer to the first byte of the local memory object. This pointer is returned by the <see cref="LocalLock"/> function.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is a handle to the specified local memory object.</para>
        /// <para>If the function fails, the return value is an <see cref="HLOCAL"/> representing <see langword="null"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// When the <see cref="LocalAlloc"/> function allocates a local memory object with <see cref="LMEM_MOVEABLE"/>, it returns a handle to the object. The <see cref="LocalLock"/> function converts this handle into a pointer to the object's memory block, and <see cref="LocalHandle"/> converts the pointer back into a handle.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winbase/nf-winbase-localhandle">LocalHandle function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</seealso>
        /// <seealso cref="LocalAlloc"/>
        /// <seealso cref="LocalLock"/>
        /// <seealso href="https://msdn.microsoft.com/5a2a7a62-0bda-4a0d-93d2-25b4898871fd">Memory Management Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern HLOCAL LocalHandle(IntPtr pMem);
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 1138
        #region LocalUnlock function
        /// <summary>
        /// Decrements the lock count associated with a memory object that was allocated with <see cref="LMEM_MOVEABLE"/>. This function has no effect on memory objects allocated with <see cref="LMEM_FIXED"/>.
        /// <note>The local functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/cfb683fa-4f46-48b5-9a28-f4625a9cb8cd">heap functions</a> unless documentation states that a local function should be used. For more information, see <a href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</a>.</note>
        /// </summary>
        /// <param name="hMem">A handle to the local memory object. This handle is returned by either the <see cref="LocalAlloc"/> or <see cref="LocalReAlloc"/> function.</param>
        /// <returns>
        /// <para>If the memory object is still locked after decrementing the lock count, the return value is nonzero. If the memory object is unlocked after decrementing the lock count, the function returns <c>0</c> (zero) and <see cref="Marshal.GetLastWin32Error"/> returns <see cref="NO_ERROR"/>.</para>
        /// <para>If the function fails, the return value is <c>0</c> (zero) and <see cref="Marshal.GetLastWin32Error"/> returns a value other than <see cref="NO_ERROR"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The internal data structures for each memory object include a lock count that is initially zero. For movable memory objects, the <see cref="LocalLock"/> function increments the count by one, and <see cref="LocalUnlock"/> decrements the count by one. For each call that a process makes to <see cref="LocalLock"/> for an object, it must eventually call <see cref="LocalUnlock"/>. Locked memory will not be moved or discarded unless the memory object is reallocated by using the <see cref="LocalReAlloc"/> function. The memory block of a locked memory object remains locked until its lock count is decremented to zero, at which time it can be moved or discarded.</para>
        /// <para>If the memory object is already unlocked, <see cref="LocalUnlock"/> returns <c>0</c> (zero) and <see cref="Marshal.GetLastWin32Error"/> reports <see cref="ERROR_NOT_LOCKED"/>. Memory objects allocated with <see cref="LMEM_FIXED"/> always have a lock count of zero and cause the <see cref="ERROR_NOT_LOCKED"/> error.</para>
        /// <para>A process should not rely on the return value to determine the number of times it must subsequently call LocalUnlock for the memory block.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winbase/nf-winbase-localunlock">LocalUnlock function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</seealso>
        /// <seealso cref="LocalAlloc"/>
        /// <seealso cref="LocalFlags"/>
        /// <seealso cref="LocalLock"/>
        /// <seealso cref="LocalReAlloc"/>
        /// <seealso href="https://msdn.microsoft.com/5a2a7a62-0bda-4a0d-93d2-25b4898871fd">Memory Management Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int LocalUnlock(HLOCAL hMem);
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 1151
        #region LocalSize function
        /// <summary>
        /// Retrieves the current size of the specified local memory object, in bytes.
        /// <note>The local functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/cfb683fa-4f46-48b5-9a28-f4625a9cb8cd">heap functions</a> unless documentation states that a local function should be used. For more information, see <a href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</a>.</note>
        /// </summary>
        /// <param name="hMem">A handle to the local memory object. This handle is returned by the <see cref="LocalAlloc"/>, <see cref="LocalReAlloc"/>, or <see cref="LocalHandle"/> function.</param>
        /// <returns>If the function succeeds, the return value is the size of the specified local memory object, in bytes. If the specified handle is not valid or if the object has been discarded, the return value is zero. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</returns>
        /// <remarks>
        /// <para>The size of a memory block may be larger than the size requested when the memory was allocated.</para>
        /// <para>To verify that the specified object's memory block has not been discarded, call the <see cref="LocalFlags"/> function before calling <see cref="LocalSize"/>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winbase/nf-winbase-localsize">LocalSize function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</seealso>
        /// <seealso cref="LocalAlloc"/>
        /// <seealso cref="LocalFlags"/>
        /// <seealso cref="LocalHandle"/>
        /// <seealso cref="LocalReAlloc"/>
        /// <seealso href="https://msdn.microsoft.com/5a2a7a62-0bda-4a0d-93d2-25b4898871fd">Memory Management Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern UIntPtr LocalSize(HLOCAL hMem);
        #endregion
        #region LocalFlags function
        /// <summary>
        /// Retrieves information about the specified local memory object.
        /// <note>This function is provided only for compatibility with 16-bit versions of Windows. New applications should use the <a href="https://msdn.microsoft.com/cfb683fa-4f46-48b5-9a28-f4625a9cb8cd">heap functions</a>. For more information, see Remarks.</note>
        /// </summary>
        /// <param name="hMem">A handle to the local memory object. This handle is returned by either the <see cref="LocalAlloc"/> or <see cref="LocalReAlloc"/> function.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value specifies the allocation values and the lock count for the memory object.</para>
        /// <para>If the function fails, the return value is <see cref="LMEM_INVALID_HANDLE"/>, indicating that the local handle is not valid. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// The local functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/cfb683fa-4f46-48b5-9a28-f4625a9cb8cd">heap functions</a> unless documentation states that a local function should be used. For more information, see <a href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</a>.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winbase/nf-winbase-localsize">LocalSize function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</seealso>
        /// <seealso cref="GlobalFlags"/>
        /// <seealso cref="LocalAlloc"/>
        /// <seealso cref="LocalDiscard"/>
        /// <seealso cref="LocalLock"/>
        /// <seealso cref="LocalReAlloc"/>
        /// <seealso cref="LocalUnlock"/>
        /// <seealso href="https://msdn.microsoft.com/5a2a7a62-0bda-4a0d-93d2-25b4898871fd">Memory Management Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern LMEM_STATUS LocalFlags(HLOCAL hMem);
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 1171
        #region LocalFree function
        /// <summary>
        /// Frees the specified local memory object and invalidates its handle.
        /// <note>The local functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/cfb683fa-4f46-48b5-9a28-f4625a9cb8cd">heap functions</a> unless documentation states that a local function should be used. For more information, see <a href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</a>.</note>
        /// </summary>
        /// <param name="hMem">A handle to the local memory object. This handle is returned by either the <see cref="LocalAlloc"/> or <see cref="LocalReAlloc"/> function. It is not safe to free memory allocated with <see cref="GlobalAlloc"/> or <see cref="Marshal.AllocHGlobal(int)"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is an <see cref="HLOCAL"/> representing <see langword="null"/>.</para>
        /// <para>If the function fails, the return value is equal to a handle to the local memory object. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>If the process tries to examine or modify the memory after it has been freed, heap corruption may occur or an access violation exception (<see cref="AccessViolationException"/>) may be generated.</para>
        /// <para>If the <paramref name="hMem"/> parameter points to <see langword="null"/>, <see cref="LocalFree"/> ignores the parameter and returns an <see cref="HLOCAL"/> to <see langword="null"/>.</para>
        /// <para>The <see cref="LocalFree"/> function will free a locked memory object. A locked memory object has a lock count greater than zero. The <see cref="LocalLock"/> function locks a local memory object and increments the lock count by one. The <see cref="LocalUnlock"/> function unlocks it and decrements the lock count by one. To get the lock count of a local memory object, use the <see cref="LocalFlags"/> function.</para>
        /// <para>If an application is running under a debug version of the system, <see cref="LocalFree"/> will issue a message that tells you that a locked object is being freed. If you are debugging the application, <see cref="LocalFree"/> will enter a breakpoint just before freeing a locked object. This allows you to verify the intended behavior, then continue execution.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winbase/nf-winbase-localfree">LocalFree function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</seealso>
        /// <seealso cref="GlobalFree"/>
        /// <seealso cref="LocalAlloc"/>
        /// <seealso cref="LocalFlags"/>
        /// <seealso cref="LocalLock"/>
        /// <seealso cref="LocalReAlloc"/>
        /// <seealso cref="LocalUnlock"/>
        /// <seealso href="https://msdn.microsoft.com/5a2a7a62-0bda-4a0d-93d2-25b4898871fd">Memory Management Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern HLOCAL LocalFree(HLOCAL hMem);
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 1350
        #region FatalExit function
        /// <summary>
        /// Transfers execution control to the debugger. The behavior of the debugger thereafter is specific to the type of debugger used.
        /// </summary>
        /// <param name="ExitCode">The error code associated with the exit.</param>
        /// <remarks>
        /// An application should only use <see cref="FatalExit"/> for debugging purposes. It should not call the function in a retail version of the application because doing so will terminate the application.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winbase/nf-winbase-fatalexit">FatalExit function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="M:THNETII.WinApi.Native.ErrHandlingApi.ErrHandlingApiFunctions.FatalAppExit(System.Int32,System.String)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern void FatalExit(
            int ExitCode
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 2382
        #region FormatMessageA function
        // string lpSource
        /// <inheritdoc cref="FormatMessage" />
        public static unsafe int FormatMessageA(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            string lpSource,
            int dwMessageId,
            int dwLanguageId,
            StringBuilder lpBuffer,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_STRING |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_SYSTEM |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_HMODULE
                );
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessageA(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    lpBuffer,
                    lpBuffer?.Capacity ?? 0,
                    pArguments
                    );
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern unsafe int FormatMessageA(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] string lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [Out] StringBuilder lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        /// <inheritdoc cref="FormatMessageA" />
        public static unsafe int FormatMessageA(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            string lpSource,
            int dwMessageId,
            int dwLanguageId,
            out string lpBuffer,
            int nSize = 0,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);

            HLOCAL lpBufferPointer;
            int result;
            fixed (IntPtr* pArguments = Arguments)
                result = FormatMessageA(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    out lpBufferPointer,
                    nSize,
                    pArguments
                    );
            int lastError = Marshal.GetLastWin32Error();
            lpBuffer = Marshal.PtrToStringAnsi(lpBufferPointer.Pointer, result);
            if (lpBufferPointer.Pointer != IntPtr.Zero)
            {
                try
                {
                    if (LocalFree(lpBufferPointer).Pointer != IntPtr.Zero)
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                finally
                {
                    SetLastError(lastError);
                }
            }
            return result;
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern unsafe int FormatMessageA(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] string lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            out HLOCAL lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        /// <inheritdoc cref="FormatMessageA" />
        public static unsafe int FormatMessageA(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            byte* lpSource,
            int dwMessageId,
            int dwLanguageId,
            Span<byte> lpBuffer,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER);
            fixed (byte* lpBufferPtr = lpBuffer)
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessageA(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    lpBufferPtr,
                    lpBuffer.Length,
                    pArguments
                    );
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern unsafe int FormatMessageA(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] byte* lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [In] byte* lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        /// <inheritdoc cref="FormatMessageA" />
        public static unsafe int FormatMessageA(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            byte* lpSource,
            int dwMessageId,
            int dwLanguageId,
            out HLOCAL lpBuffer,
            int nSize = 0,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessageA(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    out lpBuffer,
                    nSize,
                    pArguments
                    );
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern unsafe int FormatMessageA(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] byte* lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            out HLOCAL lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        // IntPtr lpSource
        /// <inheritdoc cref="FormatMessage" />
        public static unsafe int FormatMessageA(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            StringBuilder lpBuffer,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER);
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessageA(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    lpBuffer,
                    lpBuffer?.Capacity ?? 0,
                    pArguments
                    );
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern unsafe int FormatMessageA(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [Out] StringBuilder lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        /// <inheritdoc cref="FormatMessageA" />
        public static unsafe int FormatMessageA(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            out string lpBuffer,
            int nSize = 0,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);

            HLOCAL lpBufferPointer;
            int result;
            fixed (IntPtr* pArguments = Arguments)
                result = FormatMessageA(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    out lpBufferPointer,
                    nSize,
                    pArguments
                    );
            int lastError = Marshal.GetLastWin32Error();
            lpBuffer = Marshal.PtrToStringAnsi(lpBufferPointer.Pointer, result);
            if (lpBufferPointer.Pointer != IntPtr.Zero)
            {
                try
                {
                    if (LocalFree(lpBufferPointer).Pointer != IntPtr.Zero)
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                finally
                {
                    SetLastError(lastError);
                }
            }
            return result;
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern unsafe int FormatMessageA(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            out HLOCAL lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        /// <inheritdoc cref="FormatMessageA" />
        public static unsafe int FormatMessageA(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            Span<byte> lpBuffer,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER);
            fixed (byte* lpBufferPtr = lpBuffer)
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessageA(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    lpBufferPtr,
                    lpBuffer.Length,
                    pArguments
                    );
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern unsafe int FormatMessageA(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [In] byte* lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        /// <inheritdoc cref="FormatMessageA" />
        public static unsafe int FormatMessageA(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            out HLOCAL lpBuffer,
            int nSize = 0,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessageA(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    out lpBuffer,
                    nSize,
                    pArguments
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 2398
        #region FormatMessageW function
        // string lpSource
        /// <inheritdoc cref="FormatMessage" />
        public static unsafe int FormatMessageW(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            string lpSource,
            int dwMessageId,
            int dwLanguageId,
            StringBuilder lpBuffer,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER);
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessageW(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    lpBuffer,
                    lpBuffer?.Capacity ?? 0,
                    pArguments
                    );
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern unsafe int FormatMessageW(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] string lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [Out] StringBuilder lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        /// <inheritdoc cref="FormatMessageW" />
        public static unsafe int FormatMessageW(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            string lpSource,
            int dwMessageId,
            int dwLanguageId,
            out string lpBuffer,
            int nSize = 0,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);

            HLOCAL lpBufferPointer;
            int result;
            fixed (IntPtr* pArguments = Arguments)
                result = FormatMessageW(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    out lpBufferPointer,
                    nSize,
                    pArguments
                    );
            int lastError = Marshal.GetLastWin32Error();
            lpBuffer = Marshal.PtrToStringUni(lpBufferPointer.Pointer, result);
            if (lpBufferPointer.Pointer != IntPtr.Zero)
            {
                try
                {
                    if (LocalFree(lpBufferPointer).Pointer != IntPtr.Zero)
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                finally
                {
                    SetLastError(lastError);
                }
            }
            return result;
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern unsafe int FormatMessageW(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] string lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            out HLOCAL lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        /// <inheritdoc cref="FormatMessageW" />
        public static unsafe int FormatMessageW(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            char* lpSource,
            int dwMessageId,
            int dwLanguageId,
            Span<char> lpBuffer,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER);
            fixed (char* lpBufferPtr = lpBuffer)
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessageW(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    lpBufferPtr,
                    lpBuffer.Length,
                    pArguments
                    );
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern unsafe int FormatMessageW(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] char* lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [In] char* lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        /// <inheritdoc cref="FormatMessageW" />
        public static unsafe int FormatMessageW(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            char* lpSource,
            int dwMessageId,
            int dwLanguageId,
            out HLOCAL lpBuffer,
            int nSize = 0,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessageW(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    out lpBuffer,
                    nSize,
                    pArguments
                    );
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern unsafe int FormatMessageW(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] char* lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            out HLOCAL lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        // IntPtr lpSource
        /// <inheritdoc cref="FormatMessage" />
        public static unsafe int FormatMessageW(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            StringBuilder lpBuffer,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER);
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessageW(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    lpBuffer,
                    lpBuffer?.Capacity ?? 0,
                    pArguments
                    );
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern unsafe int FormatMessageW(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [Out] StringBuilder lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        /// <inheritdoc cref="FormatMessageW" />
        public static unsafe int FormatMessageW(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            out string lpBuffer,
            int nSize = 0,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);

            HLOCAL lpBufferPointer;
            int result;
            fixed (IntPtr* pArguments = Arguments)
                result = FormatMessageW(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    out lpBufferPointer,
                    nSize,
                    pArguments
                    );
            int lastError = Marshal.GetLastWin32Error();
            lpBuffer = Marshal.PtrToStringUni(lpBufferPointer.Pointer, result);
            if (lpBufferPointer.Pointer != IntPtr.Zero)
            {
                try
                {
                    if (LocalFree(lpBufferPointer).Pointer != IntPtr.Zero)
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                finally
                {
                    SetLastError(lastError);
                }
            }
            return result;
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern unsafe int FormatMessageW(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            out HLOCAL lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        /// <inheritdoc cref="FormatMessageW" />
        public static unsafe int FormatMessageW(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            Span<char> lpBuffer,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER);
            fixed (char* lpBufferPtr = lpBuffer)
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessageW(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    lpBufferPtr,
                    lpBuffer.Length,
                    pArguments
                    );
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern unsafe int FormatMessageW(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [In] char* lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            );

        /// <inheritdoc cref="FormatMessageW" />
        public static unsafe int FormatMessageW(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            out HLOCAL lpBuffer,
            int nSize = 0,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessageW(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    out lpBuffer,
                    nSize,
                    pArguments
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 2413
        #region FormatMessage function
        // string lpSource
        public static unsafe int FormatMessage(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            string lpSource,
            int dwMessageId,
            int dwLanguageId,
            StringBuilder lpBuffer,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER);
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessage(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    lpBuffer,
                    lpBuffer?.Capacity ?? 0,
                    pArguments
                    );
        }

#if !NETSTANDARD1_3 && !NETSTANDARD1_6
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern unsafe
#else
        private static unsafe
#endif
        int FormatMessage(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] string lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [Out] StringBuilder lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            )
#if !NETSTANDARD1_3 && !NETSTANDARD1_6
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => FormatMessageA(dwFlags, lpSource, dwMessageId,
                    dwLanguageId, lpBuffer, nSize, Arguments),
                2 => FormatMessageW(dwFlags, lpSource, dwMessageId,
                    dwLanguageId, lpBuffer, nSize, Arguments),
                _ => throw new PlatformNotSupportedException()
            };
#endif

        /// <inheritdoc cref="FormatMessage" />
        public static unsafe int FormatMessage(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            string lpSource,
            int dwMessageId,
            int dwLanguageId,
            out string lpBuffer,
            int nSize = 0,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);

            HLOCAL lpBufferPointer;
            int result;
            fixed (IntPtr* pArguments = Arguments)
                result = FormatMessage(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    out lpBufferPointer,
                    nSize,
                    pArguments
                    );
            int lastError = Marshal.GetLastWin32Error();
            lpBuffer = lpBufferPointer.Pointer.MarshalAsAutoString(result);
            if (lpBufferPointer.Pointer != IntPtr.Zero)
            {
                try
                {
                    if (LocalFree(lpBufferPointer).Pointer != IntPtr.Zero)
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                finally
                {
                    SetLastError(lastError);
                }
            }
            return result;
        }

#if !NETSTANDARD1_3 && !NETSTANDARD1_6
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern unsafe
#else
        private static unsafe
#endif
        int FormatMessage(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] string lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            out HLOCAL lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            )
#if !NETSTANDARD1_3 && !NETSTANDARD1_6
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => FormatMessageA(dwFlags, lpSource, dwMessageId,
                    dwLanguageId, out lpBuffer, nSize, Arguments),
                2 => FormatMessageW(dwFlags, lpSource, dwMessageId,
                    dwLanguageId, out lpBuffer, nSize, Arguments),
                _ => throw new PlatformNotSupportedException()
            };
#endif

        /// <inheritdoc cref="FormatMessage" />
        public static unsafe int FormatMessage(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            byte* lpSource,
            int dwMessageId,
            int dwLanguageId,
            Span<byte> lpBuffer,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER);
            fixed (byte* lpBufferPtr = lpBuffer)
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessage(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    lpBufferPtr,
                    lpBuffer.Length / Marshal.SystemDefaultCharSize,
                    pArguments
                    );
        }

#if !NETSTANDARD1_3 && !NETSTANDARD1_6
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern unsafe
#else
        private static unsafe
#endif
        int FormatMessage(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] byte* lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [In] byte* lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            )
#if !NETSTANDARD1_3 && !NETSTANDARD1_6
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => FormatMessageA(dwFlags, lpSource, dwMessageId,
                    dwLanguageId, lpBuffer, nSize, Arguments),
                2 => FormatMessageW(dwFlags, (char*)lpSource, dwMessageId,
                    dwLanguageId, (char*)lpBuffer, nSize, Arguments),
                _ => throw new PlatformNotSupportedException()
            };
#endif

        /// <inheritdoc cref="FormatMessage" />
        public static unsafe int FormatMessage(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            byte* lpSource,
            int dwMessageId,
            int dwLanguageId,
            out HLOCAL lpBuffer,
            int nSize = 0,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessage(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    out lpBuffer,
                    nSize,
                    pArguments
                    );
        }

#if !NETSTANDARD1_3 && !NETSTANDARD1_6
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern unsafe
#else
        private static unsafe
#endif
        int FormatMessage(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] byte* lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            out HLOCAL lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            )
#if !NETSTANDARD1_3 && !NETSTANDARD1_6
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => FormatMessageA(dwFlags, lpSource, dwMessageId,
                    dwLanguageId, out lpBuffer, nSize, Arguments),
                2 => FormatMessageW(dwFlags, (char*)lpSource, dwMessageId,
                    dwLanguageId, out lpBuffer, nSize, Arguments),
                _ => throw new PlatformNotSupportedException()
            };
#endif

        // IntPtr lpSource
        /// <inheritdoc cref="FormatMessage" />
        public static unsafe int FormatMessage(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            StringBuilder lpBuffer,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER);
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessage(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    lpBuffer,
                    lpBuffer?.Capacity ?? 0,
                    pArguments
                    );
        }

#if !NETSTANDARD1_3 && !NETSTANDARD1_6
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern unsafe
#else
        private static unsafe
#endif
        int FormatMessage(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [Out] StringBuilder lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            )
#if !NETSTANDARD1_3 && !NETSTANDARD1_6
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => FormatMessageA(dwFlags, lpSource, dwMessageId,
                    dwLanguageId, lpBuffer, nSize, Arguments),
                2 => FormatMessageW(dwFlags, lpSource, dwMessageId,
                    dwLanguageId, lpBuffer, nSize, Arguments),
                _ => throw new PlatformNotSupportedException()
            };
#endif

        /// <inheritdoc cref="FormatMessage" />
        public static unsafe int FormatMessage(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            out string lpBuffer,
            int nSize = 0,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);

            HLOCAL lpBufferPointer;
            int result;
            fixed (IntPtr* pArguments = Arguments)
                result = FormatMessage(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    out lpBufferPointer,
                    nSize,
                    pArguments
                    );
            int lastError = Marshal.GetLastWin32Error();
            lpBuffer = lpBufferPointer.Pointer.MarshalAsAutoString(result);
            if (lpBufferPointer.Pointer != IntPtr.Zero)
            {
                try
                {
                    if (LocalFree(lpBufferPointer).Pointer != IntPtr.Zero)
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                finally
                {
                    SetLastError(lastError);
                }
            }
            return result;
        }

#if !NETSTANDARD1_3 && !NETSTANDARD1_6
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern unsafe
#else
        private static unsafe
#endif
        int FormatMessage(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            out HLOCAL lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            )
#if !NETSTANDARD1_3 && !NETSTANDARD1_6
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => FormatMessageA(dwFlags, lpSource, dwMessageId,
                    dwLanguageId, out lpBuffer, nSize, Arguments),
                2 => FormatMessageW(dwFlags, lpSource, dwMessageId,
                    dwLanguageId, out lpBuffer, nSize, Arguments),
                _ => throw new PlatformNotSupportedException()
            };
#endif

        /// <inheritdoc cref="FormatMessage" />
        public static unsafe int FormatMessage(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            Span<byte> lpBuffer,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER);
            fixed (byte* lpBufferPtr = lpBuffer)
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessage(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    lpBufferPtr,
                    lpBuffer.Length / Marshal.SystemDefaultCharSize,
                    pArguments
                    );
        }

#if !NETSTANDARD1_3 && !NETSTANDARD1_6
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern unsafe
#else
        private static unsafe
#endif
        int FormatMessage(
            [In, MarshalAs(UnmanagedType.I4)]
            FORMAT_MESSAGE_FLAGS dwFlags,
            [In, Optional] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [In] byte* lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr* Arguments
            )
#if !NETSTANDARD1_3 && !NETSTANDARD1_6
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => FormatMessageA(dwFlags, lpSource, dwMessageId,
                    dwLanguageId, lpBuffer, nSize, Arguments),
                2 => FormatMessageW(dwFlags, lpSource, dwMessageId,
                    dwLanguageId, (char*)lpBuffer, nSize, Arguments),
                _ => throw new PlatformNotSupportedException()
            };
#endif

        /// <inheritdoc cref="FormatMessage" />
        public static unsafe int FormatMessage(
            FORMAT_MESSAGE_FLAGS dwFlags,
            int dwWidth,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            out HLOCAL lpBuffer,
            int nSize = 0,
            ReadOnlySpan<IntPtr> Arguments = default
            )
        {
            dwFlags |=
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ALLOCATE_BUFFER |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            fixed (IntPtr* pArguments = Arguments)
                return FormatMessage(
                    dwFlags,
                    lpSource,
                    dwMessageId,
                    dwLanguageId,
                    out lpBuffer,
                    nSize,
                    pArguments
                    );
        }
#endregion
    }
}

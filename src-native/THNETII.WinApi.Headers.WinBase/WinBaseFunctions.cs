using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

using THNETII.InteropServices.Memory;

using THNETII.WinApi.Native.MinWinBase;
using THNETII.WinApi.Native.MinWinDef;
using THNETII.WinApi.Native.WinError;

#if NETSTANDARD1_3 || NETSTANDARD1_6
using AccessViolationException = System.Exception;
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.WinBase
{
    using static FORMAT_MESSAGE_FLAGS;
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_FROM_STRING |
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FROM_SYSTEM |
                FORMAT_MESSAGE_FROM_HMODULE
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FROM_STRING |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_FROM_SYSTEM |
                FORMAT_MESSAGE_FROM_HMODULE
                );

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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FROM_STRING |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FROM_SYSTEM |
                FORMAT_MESSAGE_FROM_HMODULE
                );
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FROM_STRING |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_FROM_SYSTEM |
                FORMAT_MESSAGE_FROM_HMODULE
                );
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_ALLOCATE_BUFFER);
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_ALLOCATE_BUFFER);
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FROM_STRING |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FROM_HMODULE |
                FORMAT_MESSAGE_FROM_SYSTEM
                );
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FROM_STRING |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_FROM_HMODULE |
                FORMAT_MESSAGE_FROM_SYSTEM
                );
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FROM_STRING |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FROM_HMODULE |
                FORMAT_MESSAGE_FROM_SYSTEM
                );
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FROM_STRING |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_FROM_HMODULE |
                FORMAT_MESSAGE_FROM_SYSTEM
                );
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_ALLOCATE_BUFFER);
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_ALLOCATE_BUFFER);
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
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
#pragma warning disable CS1572 // XML comment has a param tag, but there is no parameter by that name
#pragma warning disable CS1734 // XML comment has a paramref tag, but there is no parameter by that name
        /// <summary>
        /// Formats a message string. The function requires a message definition as input. The message definition can come from a buffer passed into the function. It can come from a message table resource in an already-loaded module. Or the caller can ask the function to search the system's message table resource(s) for the message definition. The function finds the message definition in a message table resource based on a message identifier and a language identifier. The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
        /// </summary>
        /// <param name="dwFlags">
        /// The formatting options, and how to interpret the <paramref name="lpSource"/> parameter.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="FORMAT_MESSAGE_ALLOCATE_BUFFER"/></term>
        /// <description>
        /// <para>Automatically set or cleared by the function as appropriate by the specific overload.</para>
        /// <para>The function allocates a buffer large enough to hold the formatted message, and places the allocated buffer at the address specified by <paramref name="lpBuffer"/>. The <paramref name="nSize"/> parameter specifies the minimum number of characters to allocate for an output message buffer. The caller should use the <see cref="LocalFree"/> function to free the buffer when it is no longer needed.</para>
        /// <para>If the length of the formatted message exceeds 128K bytes, then <see cref="FormatMessage"/> will fail and a subsequent call to <see cref="Marshal.GetLastWin32Error"/> will return <see cref="ERROR_MORE_DATA"/>.</para>
        /// <para>In previous versions of Windows, this value was not available for use when compiling Windows Store apps. As of Windows 10 this value can be used.</para>
        /// <para><strong>Windows Server 2003 and Windows XP</strong>: If the length of the formatted message exceeds 128K bytes, then <see cref="FormatMessage"/> will not automatically fail with an error of <see cref="ERROR_MORE_DATA"/>.</para>
        /// </description></item>
        /// <item><term><see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/></term><description>
        /// <para>Automatically applied by the function, as variadic argument invocation is not supported.</para>
        /// </description></item>
        /// <item><term><see cref="FORMAT_MESSAGE_FROM_HMODULE"/></term><description>
        /// <para>Automatically cleared by overloads that accept a <see cref="string"/>, <see cref="char"/> pointer or <see cref="byte"/> pointer value for the <paramref name="lpSource"/> parameter.</para>
        /// <para>The <paramref name="lpSource"/> parameter is a module handle containing the message-table resource(s) to search. If this <paramref name="lpSource"/> handle is <see cref="IntPtr.Zero"/>, the current process's application image file will be searched. This flag cannot be used with <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</para>
        /// <para>If the module has no message table resource, the function fails with <see cref="ERROR_RESOURCE_TYPE_NOT_FOUND"/>.</para>
        /// </description></item>
        /// <item><term><see cref="FORMAT_MESSAGE_FROM_STRING"/></term><description>
        /// <para>Automatically set by overloads that accept a <see cref="string"/>, <see cref="char"/> pointer or <see cref="byte"/> pointer value for the <paramref name="lpSource"/> parameter.</para>
        /// <para>The <paramref name="lpSource"/> parameter is a <see cref="string"/> value or a pointer to a null-terminated string that contains a message definition. The message definition may contain insert sequences, just as the message text in a message table resource may. This flag cannot be used with <see cref="FORMAT_MESSAGE_FROM_HMODULE"/> or <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/>.</para>
        /// </description></item>
        /// <item><term><see cref="FORMAT_MESSAGE_FROM_SYSTEM"/></term><description>
        /// <para>Automatically cleared by overloads that accept a <see cref="string"/>, <see cref="char"/> pointer or <see cref="byte"/> pointer value for the <paramref name="lpSource"/> parameter.</para>
        /// <para>The function should search the system message-table resource(s) for the requested message. If this flag is specified with <see cref="FORMAT_MESSAGE_FROM_HMODULE"/>, the function searches the system message table if the message is not found in the module specified by <paramref name="lpSource"/>. This flag cannot be used with <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</para>
        /// <para>If this flag is specified, an application can pass the result of the <see cref="Marshal.GetLastWin32Error"/> function to retrieve the message text for a system-defined error.</para>
        /// </description></item>
        /// <item><term><see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/></term><description>
        /// <para>Insert sequences in the message definition are to be ignored and passed through to the output buffer unchanged. This flag is useful for fetching a message for later formatting. If this flag is set, the <paramref name="Arguments"/> parameter is ignored.</para>
        /// </description></item>
        /// </list>
        /// </param>
        /// <param name="dwWidth">
        /// Can be used to specify the maximum width of a formatted output line.
        /// Valid values range from and including <c>0</c> (zero) up to but excluding <c>256</c>
        /// (the range of the <see cref="byte"/> type). The Value is truncated to fit into this range.
        /// <para>If the value is a non-zero value other than <see cref="WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK"/>, it specifies the maximum number of characters in an output line. The function ignores regular line breaks in the message definition text. The function never splits a string delimited by white space across a line break. The function stores hard-coded line breaks in the message definition text into the output buffer. Hard-coded line breaks are coded with the <c>%n</c> escape sequence.</para>
        /// <para>
        /// The following values have special meaning.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><c>0</c> (zero)</term><description>There are no output line width restrictions. The function stores line breaks that are in the message definition text into the output buffer.</description></item>
        /// <item><term><see cref="WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK"/><br/>(<c>0x000000FF</c>)</term><description>The function ignores regular line breaks in the message definition text. The function stores hard-coded line breaks in the message definition text into the output buffer. The function generates no new line breaks.</description></item>
        /// </list>
        /// </para>
        /// </param>
        /// <param name="lpSource">
        /// The location of the message definition. The type of this parameter depends upon the settings in the <paramref name="dwFlags"/> parameter.
        /// <list type="table">
        /// <listheader><term><paramref name="dwFlags"/> Setting</term><description>Meaning</description></listheader>
        /// <item><term><see cref="FORMAT_MESSAGE_FROM_HMODULE"/></term><description>A handle to the module that contains the message table to search.</description></item>
        /// <item><term><see cref="FORMAT_MESSAGE_FROM_STRING"/></term><description>Pointer or reference to a string that consists of unformatted message text. It will be scanned for inserts and formatted accordingly.</description></item>
        /// </list>
        /// If neither of these flags is set in <paramref name="dwFlags"/>, then <paramref name="lpSource"/> is ignored.
        /// </param>
        /// <param name="dwMessageId">The message identifier for the requested message. This parameter is ignored if <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</param>
        /// <param name="dwLanguageId">
        /// <para>The <a href="https://docs.microsoft.com/windows/desktop/Intl/language-identifiers">language identifier</a> for the requested message. This parameter is ignored if <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</para>
        /// <para>
        /// If you pass a specific <c>LANGID</c> in this parameter, <see cref="FormatMessage"/> will return a message for that <c>LANGID</c> only. If the function cannot find a message for that <c>LANGID</c>, it sets Last-Error to <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>. If you pass in zero, <see cref="FormatMessage"/> looks for a message for <c>LANGID</c>s in the following order:
        /// <list type="number">
        /// <item>Language neutral</item>
        /// <item>Thread <c>LANGID</c>, based on the thread's locale value</item>
        /// <item>User default <c>LANGID</c>, based on the user's default locale value</item>
        /// <item>System default <c>LANGID</c>, based on the system default locale value</item>
        /// <item>US English</item>
        /// </list>
        /// </para>
        /// <para>If <see cref="FormatMessage"/> does not locate a message for any of the preceding <c>LANGID</c>s, it returns any language message string that is present. If that fails, it returns <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>.</para>
        /// </param>
        /// <param name="lpBuffer">
        /// <para>A buffer that receives the null-terminated string that specifies the formatted message. If <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_ALLOCATE_BUFFER"/>, the function allocates a buffer using the <see cref="LocalAlloc"/> function, and places the pointer to the buffer at the address specified in <paramref name="lpBuffer"/>.</para>
        /// <para>This buffer cannot be larger than 64K bytes.</para>
        /// </param>
        /// <param name="nSize">
        /// <para>If the <see cref="FORMAT_MESSAGE_ALLOCATE_BUFFER"/> flag is not set, this parameter specifies the size of the output buffer, in characters. If <see cref="FORMAT_MESSAGE_ALLOCATE_BUFFER"/> is set, this parameter specifies the minimum number of characters to allocate for an output buffer.</para>
        /// <para>The output buffer cannot be larger than 64K bytes.</para>
        /// </param>
        /// <param name="Arguments">
        /// <para>An array of values that are used as insert values in the formatted message. A <c>%1</c> in the format string indicates the first value in the Arguments array; a <c>%2</c> indicates the second argument; and so on.</para>
        /// <para>The interpretation of each value depends on the formatting information associated with the insert in the message definition. The default is to treat each value as a pointer to a null-terminated string.</para>
        /// <para>The function automatically applies the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is the number of characters or bytes stored in the output buffer, excluding the terminating null character.</para>
        /// <para>If the function fails, the return value is zero. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// Within the message text, several escape sequences are supported for dynamically formatting the message. These escape sequences and their meanings are shown in the following tables. All escape sequences start with the percent character (<c>%</c>).
        /// <list type="table">
        /// <listheader><term>Escape sequence</term><description>Meaning</description></listheader>
        /// <item><term><c>%0</c></term><description>Terminates a message text line without a trailing new line character. This escape sequence can be used to build up long lines or to terminate the message itself without a trailing new line character. It is useful for prompt messages.</description></item>
        /// <item><term><c>%<var>n</var>!<var>format string</var>!</c></term><description>
        /// <para>Identifies an insert. The value of <var>n</var> can be in the range from <c>1</c> through <c>99</c>. The <var>format string</var> (which must be surrounded by exclamation marks) is optional and defaults to <c>!s!</c> if not specified. For more information, see <a href="https://msdn.microsoft.com/library/56e442dc.aspx">Format Specification Fields</a>.</para>
        /// <para>The format string can include a width and precision specifier for strings and a width specifier for integers. Use an asterisk (<c>*</c>) to specify the width and precision. For example, <c>%1!.*s!</c> or <c>%1!*u!</c>.</para>
        /// <para>If you do not use the width and precision specifiers, the insert numbers correspond directly to the input arguments. For example, if the source string is <c>"%1 %2 %1"</c> and the input arguments are <c>"Bill"</c> and <c>"Bob"</c>, the formatted output string is <c>"Bill Bob Bill"</c>.</para>
        /// <para>However, if you use a width and precision specifier, the insert numbers do not correspond directly to the input arguments. For example, the insert numbers for the previous example could change to <c>"%1!*.*s! %4 %5!*s!"</c>.</para>
        /// <para>For an arguments array, the next insert number is <c>n+2</c> if the previous format string contained one asterisk and is <c>n+3</c> if two asterisks were specified.</para>
        /// <para>If you want to repeat <c>"Bill"</c>, as in the previous example, the arguments must include <c>"Bill"</c> twice. For example, if the source string is <c>"%1!*.*s! %4 %5!*s!"</c>, the arguments could be, <c>4</c>, <c>2</c>, <c>Bill</c>, <c>Bob</c>, <c>6</c>, <c>Bill</c> (if using the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag). The formatted string would then be <c>"  Bi Bob   Bill"</c>.</para>
        /// <para>Repeating insert numbers when the source string contains width and precision specifiers may not yield the intended results. If you replaced <c>%5</c> with <c>%1</c>, the function would try to print a string at address <c>6</c> (likely resulting in an access violation).</para>
        /// <para>Floating-point format specifiers — <c>e</c>, <c>E</c>, <c>f</c>, and <c>g</c> — are not supported. The workaround is to use the <see cref="StringCchPrintf"/> function to format the floating-point number into a temporary buffer, then use that buffer as the insert string.</para>
        /// <para>Inserts that use the <c>I64</c> prefix are treated as two 32-bit arguments. They must be used before subsequent arguments are used. Note that it may be easier for you to use <see cref="StringCchPrintf"/> instead of this prefix.</para>
        /// </description></item>
        /// </list>
        /// Any other nondigit character following a percent character is formatted in the output message without the percent character. Following are some examples.
        /// <list type="table">
        /// <listheader><term>Format string</term><description>Resulting output</description></listheader>
        /// <item><term><c>%%</c></term><description>A single percent sign.</description></item>
        /// <item><term><c>%<em>space</em></c></term><description>A single space. This format string can be used to ensure the appropriate number of trailing spaces in a message text line.</description></item>
        /// <item><term><c>%.</c></term><description>A single period. This format string can be used to include a single period at the beginning of a line without terminating the message text definition.</description></item>
        /// <item><term><c>%!</c></term><description>A single exclamation point. This format string can be used to include an exclamation point immediately after an insert without its being mistaken for the beginning of a format string.</description></item>
        /// <item><term><c>%n</c></term><description>A hard line break when the format string occurs at the end of a line. This format string is useful when <see cref="FormatMessage"/> is supplying regular line breaks so the message fits in a certain width.</description></item>
        /// <item><term><c>%r</c></term><description>A hard carriage return without a trailing newline character.</description></item>
        /// <item><term><c>%t</c></term><description>A single tab.</description></item>
        /// </list>
        /// </para>
        /// <para><note type="security">
        /// If this function is called without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>, the <paramref name="Arguments"/> parameter must contain enough parameters to satisfy all insertion sequences in the message string, and they must be of the correct type. Therefore, do not use untrusted or unknown message strings with inserts enabled because they can contain more insertion sequences than <paramref name="Arguments"/> provides, or those that may be of the wrong type. In particular, it is unsafe to take an arbitrary system error code returned from an API and use <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/> without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>.
        /// </note></para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps| UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps| UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winbase/nf-winbase-formatmessagew">FormatMessageW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Debug/error-handling-functions">Error Handling Functions</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/WES/message-compiler--mc-exe-">Message Compiler</seealso>
        /// <seealso>Message Tables</seealso>
#pragma warning restore CS1572 // XML comment has a param tag, but there is no parameter by that name
#pragma warning restore CS1734 // XML comment has a paramref tag, but there is no parameter by that name
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FROM_STRING |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FROM_HMODULE |
                FORMAT_MESSAGE_FROM_SYSTEM
                );
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FROM_STRING |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_FROM_HMODULE |
                FORMAT_MESSAGE_FROM_SYSTEM
                );

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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_FROM_STRING |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FROM_HMODULE |
                FORMAT_MESSAGE_FROM_SYSTEM
                );
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_FROM_STRING |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(
                FORMAT_MESSAGE_FROM_HMODULE |
                FORMAT_MESSAGE_FROM_SYSTEM
                );
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_ALLOCATE_BUFFER);
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                (FORMAT_MESSAGE_FLAGS)(dwWidth & WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags &= ~(FORMAT_MESSAGE_ALLOCATE_BUFFER);
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
            dwFlags &= (FORMAT_MESSAGE_FLAGS)~(WinBaseConstants.FORMAT_MESSAGE_MAX_WIDTH_MASK);
            dwFlags |=
                FORMAT_MESSAGE_ARGUMENT_ARRAY |
                FORMAT_MESSAGE_ALLOCATE_BUFFER |
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

using System;
using System.Security.AccessControl;

using THNETII.WinApi.Native.MinWinDef;
using THNETII.WinApi.Native.WinBase;
using THNETII.WinApi.Native.WinNT;

#if NETSTANDARD1_6
using EntryPointNotFoundException = System.Exception;
#endif


namespace THNETII.WinApi.Native.MinWinBase
{
    using static LMEM_FLAGS;
    using static WinBaseFunctions;
    using static WinNTFunctions;

    public static class MinWinBaseExtensions
    {
        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 33
        #region MoveMemory macro
        /// <inheritdoc cref="RtlMoveMemory"/>
        public static void MoveMemory(IntPtr Destination, IntPtr Source, UIntPtr Length) =>
            RtlMoveMemory(Destination, Source, Length);
        #endregion
        #region CopyMemory macro
        /// <inheritdoc cref="RtlCopyMemory"/>
        public static void CopyMemory(IntPtr Destination, IntPtr Source, UIntPtr Length) =>
            RtlCopyMemory(Destination, Source, Length);
        #endregion
        #region FillMemory macro
        /// <inheritdoc cref="RtlFillMemory"/>
        public static void FillMemory(IntPtr Destination, UIntPtr Length, int Fill) =>
            RtlFillMemory(Destination, Length, Fill);
        #endregion
        #region ZeroMemory macro
        /// <inheritdoc cref="RtlZeroMemory"/>
        public static void ZeroMemory(IntPtr Destination, UIntPtr Length) =>
            RtlZeroMemory(Destination, Length);
        #endregion

        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 431
        #region LocalDiscard macro
        /// <summary>
        /// Discards the specified local memory object. The lock count of the memory object must be zero.
        /// <para>
        /// <note>The local functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://docs.microsoft.com/windows/desktop/Memory/heap-functions">heap functions</a> unless documentation states that a local function should be used. For more information, see <a href="https://docs.microsoft.com/windows/desktop/Memory/global-and-local-functions">Global and Local Functions</a>.</note>
        /// </para>
        /// </summary>
        /// <param name="h">A handle to the local memory object. This handle is returned by either the <see cref="LocalAlloc"/> or <see cref="LocalReAlloc"/> function.</param>
        /// <remarks>
        /// Although <see cref="LocalDiscard"/> discards the object's memory block, the handle to the object remains valid. A process can subsequently pass the handle to the <see cref="LocalReAlloc"/> function to allocate another local memory object identified by the same handle.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/nf-minwinbase-localdiscard">LocalDiscard function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Memory/global-and-local-functions">Global and Local Functions</seealso>
        /// <seealso cref="LocalAlloc"/>
        /// <seealso cref="LocalReAlloc"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Memory/memory-management-functions">Memory Management Functions</seealso>
        public static void LocalDiscard(HLOCAL h) =>
            LocalReAlloc(h, UIntPtr.Zero, LMEM_MOVEABLE);
        #endregion

        public static RawSecurityDescriptor MarshalSecurityDescriptor(
            this in SECURITY_ATTRIBUTES attr) =>
            SECURITY_DESCRIPTOR.MarshalToManagedSecurityDescriptor(attr.lpSecurityDescriptor);
    }
}

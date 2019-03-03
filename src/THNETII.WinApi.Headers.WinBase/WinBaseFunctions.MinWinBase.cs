using System;
using System.Runtime.InteropServices;
using THNETII.WinApi.Native.MinWinDef;
using static THNETII.WinApi.Native.MinWinBase.LMEM_FLAGS;
#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.WinBase
{

    public static partial class WinBaseFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 431
        #region LocalDiscard macro
        /// <summary>
        /// Discards the specified local memory object. The lock count of the memory object must be zero.
        /// <note>The local functions have greater overhead and provide fewer features than other memory management functions. New applications should use the <a href="https://msdn.microsoft.com/cfb683fa-4f46-48b5-9a28-f4625a9cb8cd">heap functions</a> unless documentation states that a local function should be used. For more information, see <a href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</a>.</note>
        /// </summary>
        /// <param name="hlocMem">A handle to the local memory object. This handle is returned by either the <see cref="LocalAlloc"/> or <see cref="LocalReAlloc"/> function.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is a handle to the local memory object.</para>
        /// <para>If the function fails, the return value is an <see cref="HLOCAL"/> value representing a null-pointer. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// Although <see cref="LocalDiscard"/> discards the object's memory block, the handle to the object remains valid. A process can subsequently pass the handle to the <see cref="LocalReAlloc"/> function to allocate another local memory object identified by the same handle.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/05842fa7-0438-4237-962f-055dc338368c">LocalDiscard macro</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://msdn.microsoft.com/97707ce7-4c65-4d0e-ba69-47fdaee73a9b">Global and Local Functions</seealso>
        /// <seealso cref="LocalAlloc"/>
        /// <seealso cref="LocalReAlloc"/>
        /// <seealso href="https://msdn.microsoft.com/5a2a7a62-0bda-4a0d-93d2-25b4898871fd">Memory Management Functions</seealso>
        public static HLOCAL LocalDiscard(
            [In] HLOCAL hlocMem
            ) => LocalReAlloc(hlocMem, UIntPtr.Zero, LMEM_MOVEABLE);
        #endregion
    }
}

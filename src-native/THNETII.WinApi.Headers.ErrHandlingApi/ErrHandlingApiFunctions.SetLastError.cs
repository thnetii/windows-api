using System;
using System.Runtime.InteropServices;

#if NETSTANDARD1_3 || NETSTANDARD1_6
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.ErrHandlingApi
{
    partial class ErrHandlingApiFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\errhandlingapi.h, line 96
        #region SetLastError function
        /// <summary>
        /// Sets the last-error code for the calling thread.
        /// </summary>
        /// <param name="dwErrCode">The last-error code for the thread.</param>
        /// <remarks>
        /// <para>The last-error code is kept in thread local storage so that multiple threads do not overwrite each other's values.</para>
        /// <para>Most functions call <see cref="SetLastError"/> or <see cref="M:THNETII.WinApi.Native.WinUser.WinUserFunctions.SetLastErrorEx(System.Int32,THNETII.WinApi.Native.WinUser.SLE_TYPE)"/> only when they fail. However, some system functions call <see cref="SetLastError"/> or <see cref="M:THNETII.WinApi.Native.WinUser.WinUserFunctions.SetLastErrorEx(System.Int32,THNETII.WinApi.Native.WinUser.SLE_TYPE)"/> under conditions of success; those cases are noted in each function's documentation.</para>
        /// <para>Applications can optionally retrieve the value set by this function by using the <see cref="Marshal.GetLastWin32Error"/> function immediately after a function fails.</para>
        /// <para>Error codes are 32-bit values (bit 31 is the most significant bit). Bit 29 is reserved for application-defined error codes; no system error code has this bit set. If you are defining an error code for your application, set this bit to indicate that the error code has been defined by your application and to ensure that your error code does not conflict with any system-defined error codes.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/library/ms680627.aspx">SetLastError function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="Marshal.GetLastWin32Error"/>
        /// <seealso cref="M:THNETII.WinApi.Native.WinUser.WinUserFunctions.SetLastErrorEx(System.Int32,THNETII.WinApi.Native.WinUser.SLE_TYPE)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern void SetLastError(
            [In] int dwErrCode
            );
        #endregion
    }
}

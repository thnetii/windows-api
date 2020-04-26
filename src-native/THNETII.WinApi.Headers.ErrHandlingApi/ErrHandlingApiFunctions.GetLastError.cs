using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinBase;

#if NETSTANDARD1_3 || NETSTANDARD1_6
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.ErrHandlingApi
{
    using static WinBaseFunctions;

    partial class ErrHandlingApiFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\errhandlingapi.h, line 82
        #region GetLastError function
        /// <summary>
        /// Retrieves the calling thread's last-error code value. The last-error code is maintained on a per-thread basis. Multiple threads do not overwrite each other's last-error code.
        /// </summary>
        /// <returns>
        /// <para>The return value is the calling thread's last-error code.</para>
        /// <para>The Return Value section of the documentation for each function that sets the last-error code notes the conditions under which the function sets the last-error code. Most functions that set the thread's last-error code set it when they fail. However, some functions also set the last-error code when they succeed. If the function is not documented to set the last-error code, the value returned by this function is simply the most recent last-error code to have been set; some functions set the last-error code to <c>0</c> (zero) on success and others do not.</para>
        /// </returns>
        /// <remarks>
        /// <para>Functions executed by the calling thread set this value by calling the <see cref="SetLastError"/> function. You should call the <see cref="GetLastError"/> function immediately when a function's return value indicates that such a call will return useful data. That is because some functions call <see cref="SetLastError"/> with a zero when they succeed, wiping out the error code set by the most recently failed function.</para>
        /// <para>To obtain an error string for system error codes, use the <see cref="FormatMessage"/> function. For a complete list of error codes provided by the operating system, see <a href="https://msdn.microsoft.com/en-us/library/ms681381.aspx">System Error Codes</a>.</para>
        /// <para>The error codes returned by a function are not part of the Windows API specification and can vary by operating system or device driver. For this reason, we cannot provide the complete list of error codes that can be returned by each function. There are also many functions whose documentation does not include even a partial list of error codes that can be returned.</para>
        /// <para>Error codes are 32-bit values (bit 31 is the most significant bit). Bit 29 is reserved for application-defined error codes; no system error code has this bit set. If you are defining an error code for your application, set this bit to one. That indicates that the error code has been defined by an application, and ensures that your error code does not conflict with any error codes defined by the system.</para>
        /// <para>To convert a system error into an <see cref="T:THNETII.WindowsProtocols.WindowsErrorCodes.HRESULT"/> value, use the <see cref="M:THNETII.WindowsProtocols.WindowsErrorCodes.HRESULT.FromWin32(System.Int32)"/> function.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported phone:</strong></term><description>Windows Phone 8</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/library/ms679360.aspx">GetLastError function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="FormatMessage"/>
        /// <seealso cref="M:THNETII.WindowsProtocols.WindowsErrorCodes.HRESULT.FromWin32(System.Int32)"/>
        /// <seealso cref="SetLastError"/>
        /// <seealso cref="M:THNETII.WinApi.Native.WinUser.WinUserFunctions.SetLastErrorEx(System.Int32,THNETII.WinApi.Native.WinUser.SLE_TYPE)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetLastError) + ". Instead the static System.Runtime.InteropServices.Marshal.GetLastWin32Error() method should be used.")]
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetLastError();
        #endregion
    }
}

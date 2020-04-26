using System;
using System.Runtime.InteropServices;

#if NETSTANDARD1_3 || NETSTANDARD1_6
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.ErrHandlingApi
{
    partial class ErrHandlingApiFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\errhandlingapi.h, line 222
        #region FatalAppExit function
        /// <summary>
        /// Displays a message box and terminates the application when the message box is closed. If the system is running with a debug version of Kernel32.dll, the message box gives the user the opportunity to terminate the application or to cancel the message box and return to the application that called <see cref="FatalAppExit"/>.
        /// </summary>
        /// <param name="uAction">This parameter must be <c>0</c> (zero).</param>
        /// <param name="lpMessageText">The string that is displayed in the message box.</param>
        /// <remarks>
        /// An application calls <see cref="FatalAppExit"/> only when it is not capable of terminating any other way. 
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/library/ms679336.aspx">FatalAppExit function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="FatalExit"/>
        public static void FatalAppExit(
            int uAction,
            string lpMessageText
            ) => FatalAppExitW(uAction, lpMessageText);
        /// <inheritdoc cref="FatalAppExit"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(FatalAppExitA))]
        public static extern void FatalAppExitA(
            [In] int uAction,
            [In, MarshalAs(UnmanagedType.LPStr)] string lpMessageText
            );
        /// <inheritdoc cref="FatalAppExit"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(FatalAppExitW))]
        public static extern void FatalAppExitW(
            [In] int uAction,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpMessageText
            );
        #endregion
    }
}

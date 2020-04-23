using System;
using System.Runtime.InteropServices;

#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.WinUser
{
    using static MB_ICON;

    public static class WinUserFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinUser.h, line 4546
        #region FlashWindow function
        /// <summary>
        /// <para>Flashes the specified window one time. It does not change the active state of the window.</para>
        /// <para>To flash the window a specified number of times, use the <see cref="FlashWindowEx"/> function.</para>
        /// </summary>
        /// <param name="hWnd">A handle to the window to be flashed. The window can be either open or minimized.</param>
        /// <param name="bInvert">
        /// <para>If this parameter is <see langword="true"/>, the window is flashed from one state to the other. If it is <see langword="false"/>, the window is returned to its original state (either active or inactive).</para>
        /// <para>When an application is minimized and this parameter is <see langword="true"/>, the taskbar window button flashes active/inactive. If it is <see langword="false"/>, the taskbar window button flashes inactive, meaning that it does not change colors. It flashes, as if it were being redrawn, but it does not provide the visual invert clue to the user.</para>
        /// </param>
        /// <returns>
        /// The return value specifies the window's state before the call to the FlashWindow function. If the window caption was drawn as active before the call, the return value is <see langword="true"/>. Otherwise, the return value is <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// <para>Flashing a window means changing the appearance of its caption bar as if the window were changing from inactive to active status, or vice versa. (An inactive caption bar changes to an active caption bar; an active caption bar changes to an inactive caption bar.)</para>
        /// <para>Typically, a window is flashed to inform the user that the window requires attention but that it does not currently have the keyboard focus.</para>
        /// <para>The <see cref="FlashWindow"/> function flashes the window only once; for repeated flashing, the application should create a system timer.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winuser/nf-winuser-flashwindow">FlashWindow function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(NativeLibraryNames.User32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern bool FlashWindow(
            IntPtr hWnd,
            [MarshalAs(UnmanagedType.Bool)] bool bInvert
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinUser.h, line 4562
        #region FlashWindowEx function
        /// <summary>
        /// Flashes the specified window. It does not change the active state of the window.
        /// </summary>
        /// <param name="pfwi">A <see cref="FLASHWINFO"/> structure.</param>
        /// <returns>The return value specifies the window's state before the call to the <see cref="FlashWindowEx"/> function. If the window caption was drawn as active before the call, the return value is <see langword="true"/>. Otherwise, the return value is <see langword="false"/>.</returns>
        /// <remarks>
        /// Typically, you flash a window to inform the user that the window requires attention but does not currently have the keyboard focus. When a window flashes, it appears to change from inactive to active status. An inactive caption bar changes to an active caption bar; an active caption bar changes to an inactive caption bar.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winuser/nf-winuser-flashwindowex">FlashWindowEx function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="FLASHWINFO"/>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(NativeLibraryNames.User32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern bool FlashWindowEx(
            in FLASHWINFO pfwi
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinUser.h, line 9061
        #region MessageBeep function
        /// <summary>
        /// Plays a waveform sound. The waveform sound for each sound type is identified by an entry in the registry.
        /// </summary>
        /// <param name="uType">
        /// <para>The sound to be played. The sounds are set by the user through the Sound control panel application, and then stored in the registry.</para>
        /// <para>
        /// This parameter can be one of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><c>(<see cref="MB_ICON"/>)0xFFFFFFFF</c></term><description>A simple beep. If the sound card is not available, the sound is generated using the speaker. </description></item>
        /// <item><term><see cref="MB_ICONASTERISK"/></term><description>See <see cref="MB_ICONINFORMATION"/>.</description></item>
        /// <item><term><see cref="MB_ICONEXCLAMATION"/></term><description>See <see cref="MB_ICONWARNING"/>.</description></item>
        /// <item><term><see cref="MB_ICONERROR"/></term><description>The sound specified as the Windows Critical Stop sound. </description></item>
        /// <item><term><see cref="MB_ICONHAND"/></term><description>See <see cref="MB_ICONERROR"/>. </description></item>
        /// <item><term><see cref="MB_ICONINFORMATION"/></term><description>The sound specified as the Windows Asterisk sound. </description></item>
        /// <item><term><see cref="MB_ICONQUESTION"/></term><description>The sound specified as the Windows Question sound. </description></item>
        /// <item><term><see cref="MB_ICONSTOP"/></term><description>See <see cref="MB_ICONERROR"/>. </description></item>
        /// <item><term><see cref="MB_ICONWARNING"/></term><description>The sound specified as the Windows Exclamation sound. </description></item>
        /// <item><term><c>(<see cref="MB_ICON"/>)0</c></term><description>The sound specified as the Windows Default Beep sound. </description></item>
        /// </list>
        /// </para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>After queuing the sound, the <see cref="MessageBeep"/> function returns control to the calling function and plays the sound asynchronously.</para>
        /// <para>If it cannot play the specified alert sound, <see cref="MessageBeep"/> attempts to play the system default sound. If it cannot play the system default sound, the function produces a standard beep sound through the computer speaker.</para>
        /// <para>The user can disable the warning beep by using the Sound control panel application.</para>
        /// <para><strong>Note:</strong> To send a beep to a remote client, use the <see cref="M:THNETII.WinApi.Native.UtilApiset.UtilApisetFunctions.Beep(System.Int32,System.Int32)"/> function. The <see cref="M:THNETII.WinApi.Native.UtilApiset.UtilApisetFunctions.Beep(System.Int32,System.Int32)"/> function is redirected to the client, whereas <see cref="MessageBeep"/> is not.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/WinUser/nf-winuser-messagebeep">MessageBeep function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="M:THNETII.WinApi.Native.UtilApiset.UtilApisetFunctions.Beep(System.Int32,System.Int32)"/>
        /// <seealso cref="FlashWindow"/>
        [DllImport(NativeLibraryNames.User32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MessageBeep(
            [MarshalAs(UnmanagedType.I4)] MB_ICON uType
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinUser.h, line 13152
        #region SetLastErrorEx function
        /// <summary>
        /// <para>Sets the last-error code.</para>
        /// <para>Currently, this function is identical to the <see cref="M:THNETII.WinApi.Native.ErrHandlingApi.ErrHandlingApiFunctions.SetLastError(System.Int32)"/> function. The second parameter is ignored.</para>
        /// </summary>
        /// <param name="dwErrCode">The last-error code for the thread.</param>
        /// <param name="dwType">This parameter is ignored.</param>
        /// <remarks>
        /// <para>The last-error code is kept in thread local storage so that multiple threads do not overwrite each other's values.</para>
        /// <para>Most functions call <see cref="M:THNETII.WinApi.Native.ErrHandlingApi.ErrHandlingApiFunctions.SetLastError(System.Int32)"/> or <see cref="SetLastErrorEx"/> only when they fail. However, some system functions call <see cref="M:THNETII.WinApi.Native.ErrHandlingApi.ErrHandlingApiFunctions.SetLastError(System.Int32)"/> or <see cref="SetLastErrorEx"/> under conditions of success; those cases are noted in each function's documentation.</para>
        /// <para>Applications can optionally retrieve the value set by this function by using the <see cref="Marshal.GetLastWin32Error"/> function immediately after a function fails.</para>
        /// <para>Error codes are 32-bit values (bit 31 is the most significant bit). Bit 29 is reserved for application-defined error codes; no system error code has this bit set. If you are defining an error code for your application, set this bit to indicate that the error code has been defined by your application and to ensure that your error code does not conflict with any system-defined error codes.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winuser/nf-winuser-setlasterrorex">SetLastErrorEx function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="Marshal.GetLastWin32Error"/>
        [DllImport(NativeLibraryNames.User32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern void SetLastErrorEx(
            [In] int dwErrCode,
            [In] SLE_TYPE dwType
            );
        #endregion
    }
}

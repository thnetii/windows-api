using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10791
    /// <summary>
    /// The <see cref="TOKEN_LINKED_TOKEN"/> structure contains a handle to a token. This token is linked to the token being queried by the <see cref="GetTokenInformation"/> function or set by the <see cref="SetTokenInformation"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_linked_token">TOKEN_LINKED_TOKEN structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_LINKED_TOKEN
    {
        /// <summary>
        /// A handle to the linked token.
        /// <para>When you have finished using the handle, close it by calling the <see cref="CloseHandle"/> function.</para>
        /// </summary>
        /// <seealso cref="GetSafeLinkedTokenHandle"/>
        public IntPtr LinkedToken;

        /// <summary>
        /// Gets a <see cref="SafeAccessTokenHandle"/> instance created from the value of <see cref="LinkedToken"/>.
        /// </summary>
        /// <returns>A new <see cref="SafeAccessTokenHandle"/> instance. The returned instance refers to an invalid handle if <see cref="LinkedToken"/> is <see cref="IntPtr.Zero"/>.</returns>
        /// <exception cref="PlatformNotSupportedException" />
        [SuppressMessage("Usage", "PC001: API not supported on all platforms")]
        public SafeAccessTokenHandle GetSafeLinkedTokenHandle() => new SafeAccessTokenHandle(LinkedToken);
    }
}

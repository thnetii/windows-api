using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using THNETII.WinApi.Native.HandleApi;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10791
    /// <summary>
    /// The <see cref="TOKEN_LINKED_TOKEN"/> structure contains a handle to a token. This token is linked to the token being queried by the <see cref="GetTokenInformation"/> function or set by the <see cref="SetTokenInformation"/> function.
    /// <para><see cref="IDisposable"/>: Instances of this structure should be used within a <c>using</c>-block.</para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_linked_token">TOKEN_LINKED_TOKEN structure</a></para>
    /// </remarks>
    /// <seealso cref="AdjustTokenGroups"/>
    /// <seealso cref="CreateRestrictedToken"/>
    /// <seealso cref="SID_AND_ATTRIBUTES"/>
    /// <seealso cref="TOKEN_CONTROL"/>
    /// <seealso cref="TOKEN_DEFAULT_DACL"/>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    /// <seealso cref="TOKEN_OWNER"/>
    /// <seealso cref="TOKEN_PRIMARY_GROUP"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    /// <seealso cref="TOKEN_SOURCE"/>
    /// <seealso cref="TOKEN_STATISTICS"/>
    /// <seealso cref="TOKEN_TYPE"/>
    /// <seealso cref="TOKEN_USER"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_LINKED_TOKEN : IDisposable
    {
        /// <summary>
        /// A handle to the linked token.
        /// <para>When you have finished using the handle, close it by calling the <see cref="CloseHandle"/> function. Calling the <see cref="Dispose"/> on the containing <see cref="TOKEN_LINKED_TOKEN"/> structure, or using the containing <see cref="TOKEN_LINKED_TOKEN"/> structure within a <c>using</c>-block will safely dispose the Access Token Handle after use.</para>
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

        public void Dispose()
        {
            IntPtr handle = Interlocked.Exchange(ref LinkedToken, IntPtr.Zero);
            if (handle == IntPtr.Zero)
                return;
            var closeSuccessful = HandleApiFunctions.CloseHandle(handle);
            Debug.Assert(closeSuccessful, new Win32Exception(Marshal.GetLastWin32Error()).ToString());
        }
    }
}

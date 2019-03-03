using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10791
    /// <summary>
    /// The <see cref="TOKEN_LINKED_TOKEN"/> structure contains a handle to a token. This token is linked to the token being queried by the <see cref="GetTokenInformation"/> function or set by the <see cref="SetTokenInformation"/> function.
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
        /// </summary>
        public IntPtr LinkedToken;

        public void Dispose()
        {
            IntPtr handle = Interlocked.Exchange(ref LinkedToken, IntPtr.Zero);
            if (handle == IntPtr.Zero)
                return;

        }
    }
}

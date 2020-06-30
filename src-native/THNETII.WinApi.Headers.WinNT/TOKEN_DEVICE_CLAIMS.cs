using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10770
    /// <summary>
    /// The <see cref="TOKEN_DEVICE_CLAIMS"/> structure defines the device claims for the token.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_device_claims">TOKEN_DEVICE_CLAIMS structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_DEVICE_CLAIMS
    {
        /// <summary>
        /// The device claims for the token.
        /// </summary>
        public IntPtr DeviceClaims;
    }
}

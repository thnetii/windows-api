using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinSmcrd
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 270
    /// <summary>
    /// The <see cref="SCARD_IO_REQUEST"/> structure begins a protocol control information structure. Any protocol-specific information then immediately follows this structure. The entire length of the structure must be aligned with the underlying hardware architecture word size. For example, in Win32 the length of any PCI information must be a multiple of four bytes so that it aligns on a 32-bit boundary.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/secauthn/scard-io-request">SCARD_IO_REQUEST structure</a></para>
    /// </remarks>
    /// <seealso cref="SCardTransmit"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SCARD_IO_REQUEST
    {
        /// <summary>
        /// Protocol in use.
        /// </summary>
        public int dwProtocol;   // Protocol identifier
        /// <summary>
        /// Length, in bytes, of the <see cref="SCARD_IO_REQUEST"/> structure plus any following PCI-specific information.
        /// </summary>
        public int cbPciLength;  // Protocol Control Information Length
        public Span<byte> PciTrailer => SpanAfterStruct.GetSpan<SCARD_IO_REQUEST, byte>(ref this, cbPciLength - SizeOf<SCARD_IO_REQUEST>.Bytes);
    }
}

using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1123
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_NegotiatedTlsExtensions
    {
        /// <summary>
        /// Number of negotiated TLS extensions.
        /// </summary>
        public int ExtensionsCount;
        /// <summary>
        /// Pointer to array of 2-byte TLS extension IDs (allocated by IANA).
        /// </summary>
        public ushort* ExtensionsPointer;
        /// <summary>
        /// Span of 2-byte TLS extension IDs (allocated by IANA).
        /// </summary>
        public Span<ushort> Extensions =>
            new Span<ushort>(ExtensionsPointer, ExtensionsCount);
    }
}

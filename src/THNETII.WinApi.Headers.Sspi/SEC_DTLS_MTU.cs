using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 442
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SEC_DTLS_MTU
    {
        /// <summary>Path MTU for the connection</summary>
        public ushort PathMTU;
    }
}

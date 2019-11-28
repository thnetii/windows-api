using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 432
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SEC_PRESHAREDKEY
    {
        /// <summary>Size in bytes of the PSK</summary>
        public ushort KeySize;
        #region public Span<byte> Key;
        internal byte* KeyPtr;
        /// <summary>PSK</summary>
        public Span<byte> Key => new Span<byte>(KeyPtr, KeySize);
        #endregion
    }
}

using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 437
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SEC_PRESHAREDKEY_IDENTITY
    {
        /// <summary>Size in bytes of the PSK Identity</summary>
        public ushort KeyIdentitySize;
        #region public Span<byte> KeyIdentity;
        internal byte* KeyIdentityPtr;
        /// <summary>PSK Identity</summary>
        public Span<byte> KeyIdentity => new Span<byte>(KeyIdentityPtr, KeyIdentitySize);
        #endregion
    }
}

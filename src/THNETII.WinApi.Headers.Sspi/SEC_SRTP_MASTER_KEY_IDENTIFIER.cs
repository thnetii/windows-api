using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 419
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SEC_SRTP_MASTER_KEY_IDENTIFIER
    {
        /// <summary>
        /// Size in bytes of the SRTP master key identifier
        /// </summary>
        public byte MasterKeyIdentifierSize;
        #region public Span<byte> MasterKeyIdentifier;
        internal byte* MasterKeyIdentifierPtr;
        /// <summary>
        /// SRTP master key identifier
        /// </summary>
        public Span<byte> MasterKeyIdentifier =>
            new Span<byte>(MasterKeyIdentifierPtr, MasterKeyIdentifierSize);
        #endregion
    }
}

using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 425
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SEC_TOKEN_BINDING
    {
        /// <summary>Supported major version of the Token Binding protocol</summary>
        public byte MajorVersion;
        /// <summary>Supported minor version of the Token Binding protocol</summary>
        public byte MinorVersion;
        /// <summary>Size in bytes of the Token Binding key parameter IDs array</summary>
        public ushort KeyParametersSize;
        #region public Span<byte> KeyParameters;
        internal byte* KeyParametersPtr;
        /// <summary>Token Binding key parameter IDs, most preferred first</summary>
        public Span<byte> KeyParameters => new Span<byte>(KeyParametersPtr, KeyParametersSize);
        #endregion
    }
}

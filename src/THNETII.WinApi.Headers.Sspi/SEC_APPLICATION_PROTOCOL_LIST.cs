using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 406
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SEC_APPLICATION_PROTOCOL_LIST
    {
        /// <summary>
        /// Protocol negotiation extension type to use with this list of protocols
        /// </summary>
        public SEC_APPLICATION_PROTOCOL_NEGOTIATION_EXT ProtoNegoExt;
        /// <summary>
        /// Size in bytes of the protocol ID list
        /// </summary>
        public ushort ProtocolListSize;
        #region public Span<char> ProtocolList;
        internal byte* ProtocolListPtr;
        /// <summary>
        /// 8-bit length-prefixed application protocol IDs, most preferred first
        /// </summary>
        public Span<byte> ProtocolList => new Span<byte>(ProtocolListPtr, ProtocolListSize);
        #endregion
    }
}

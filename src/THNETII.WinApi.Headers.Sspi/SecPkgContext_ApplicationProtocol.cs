using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    using static SspiConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1123
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_ApplicationProtocol
    {
        /// <summary>Application  protocol negotiation status</summary>
        public SEC_APPLICATION_PROTOCOL_NEGOTIATION_STATUS ProtoNegoStatus;
        /// <summary>Protocol negotiation extension type corresponding to this protocol ID</summary>
        public SEC_APPLICATION_PROTOCOL_NEGOTIATION_EXT ProtoNegoExt;
        /// <summary>Size in bytes of the application protocol ID</summary>
        public byte ProtocolIdSize;
        internal fixed byte ProtocolIdField[MAX_PROTOCOL_ID_SIZE];
        /// <summary>Byte string representing the negotiated application protocol ID</summary>
        public Span<byte> ProtocolId
        {
            get
            {
                fixed (void* pProtocolId = ProtocolIdField)
                    return new Span<byte>(pProtocolId, ProtocolIdSize);
            }
        }
    }
}

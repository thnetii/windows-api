using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 411
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SEC_APPLICATION_PROTOCOLS
    {
        /// <summary>
        /// Size in bytes of the protocol ID lists array
        /// </summary>
        public int ProtocolListsSize;
        #region public Span<SEC_APPLICATION_PROTOCOL_LIST> ProtocolLists;
        internal SEC_APPLICATION_PROTOCOL_LIST* ProtocolListsPtr;
        /// <summary>
        /// Array of protocol ID lists
        /// </summary>
        public Span<SEC_APPLICATION_PROTOCOL_LIST> ProtocolLists =>
            new Span<SEC_APPLICATION_PROTOCOL_LIST>(ProtocolListsPtr, ProtocolListsSize);
        #endregion
    }
}

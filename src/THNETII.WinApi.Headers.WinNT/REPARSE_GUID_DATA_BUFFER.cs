using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13060
    /// <summary>
    /// The reparse GUID structure is used by all 3rd party layered drivers to
    /// store data in a reparse point. For non-Microsoft tags, The GUID field
    /// cannot be GUID_NULL.
    /// The constraints on reparse tags are defined below.
    /// Microsoft tags can also be used with this format of the reparse point buffer.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct REPARSE_GUID_DATA_BUFFER
    {
        public REPARSE_TAG ReparseTag;
        public short ReparseDataLength;
        public short Reserved;
        public Guid ReparseGuid;
        internal byte DataBufferField;
        public Span<byte> DataBuffer => SpanOverRef.GetSpan(ref DataBufferField, Math.Min((ushort)ReparseDataLength, (ushort)MAXIMUM_REPARSE_DATA_BUFFER_SIZE));
    }
}

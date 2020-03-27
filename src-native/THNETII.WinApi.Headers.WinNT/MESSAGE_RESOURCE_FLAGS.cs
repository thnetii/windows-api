using System;
using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum MESSAGE_RESOURCE_FLAGS : short
    {
        MESSAGE_RESOURCE_UNICODE = WinNTConstants.MESSAGE_RESOURCE_UNICODE,
    }
}

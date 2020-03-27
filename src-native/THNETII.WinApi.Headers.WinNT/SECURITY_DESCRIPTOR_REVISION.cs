using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32", Justification = @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10206")]
    public enum SECURITY_DESCRIPTOR_REVISION : byte
    {
        SECURITY_DESCRIPTOR_REVISION = WinNTConstants.SECURITY_DESCRIPTOR_REVISION,
        SECURITY_DESCRIPTOR_REVISION1 = WinNTConstants.SECURITY_DESCRIPTOR_REVISION1,
    }
}

using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11167
    [SuppressMessage("Design", "CA1028:" + "Enum Storage should be Int32", Justification = @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11167")]
    public enum SECURITY_CONTEXT_TRACKING_MODE : byte
    {
        SECURITY_DYNAMIC_TRACKING = 1,
        SECURITY_STATIC_TRACKING = 0
    }
}

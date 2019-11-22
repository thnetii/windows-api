using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 940
    [StructLayout(LayoutKind.Sequential)]
    public struct SecPkgContext_LogoffTime
    {
        public TimeStamp tsLogoffTime;
    }
}

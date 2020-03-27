using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11768
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_JOBSET_INFORMATION
    {
        public int MemberLevel;
    }
}

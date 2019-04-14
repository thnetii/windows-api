using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12557
    [StructLayout(LayoutKind.Sequential)]
    public struct XSTATE_FEATURE
    {
        internal const int SizeOf = sizeof(int) * 2;

        public int Offset;
        public int Size;
    }
}

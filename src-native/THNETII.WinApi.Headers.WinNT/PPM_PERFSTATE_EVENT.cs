using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15835
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_PERFSTATE_EVENT
    {
        public int State;
        public int Status;
        public int Latency;
        public int Speed;
        public int Processor;
    }
}

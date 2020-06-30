using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18131
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY
    {
        public int BeginAddress;
        public int EndAddress;
        public int ExceptionHandler;
        public int HandlerData;
        public int PrologEndAddress;
    }
}

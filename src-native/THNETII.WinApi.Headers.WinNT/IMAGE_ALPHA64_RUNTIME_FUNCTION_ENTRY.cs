using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18123
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY
    {
        public long BeginAddress;
        public long EndAddress;
        public long ExceptionHandler;
        public long HandlerData;
        public long PrologEndAddress;
    }
}

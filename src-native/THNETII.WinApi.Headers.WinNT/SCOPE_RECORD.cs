using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SCOPE_RECORD
    {
        public int BeginAddress;
        public int EndAddress;
        public int HandlerAddress;
        public int JumpTarget;
    }
}

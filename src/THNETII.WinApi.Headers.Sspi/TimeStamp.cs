using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct TimeStamp
    {
        internal SECURITY_INTEGER value;
        public uint LowPart
        {
            get => value.LowPart;
            set => this.value.LowPart = value;
        }
        public int HighPart
        {
            get => value.HighPart;
            set => this.value.HighPart = value;
        }
        public long QuadPart
        {
            get => value.QuadPart;
            set => this.value.QuadPart = value;
        }
    }
}

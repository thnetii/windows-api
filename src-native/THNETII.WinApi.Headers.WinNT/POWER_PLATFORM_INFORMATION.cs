using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15559
    [StructLayout(LayoutKind.Sequential)]
    public struct POWER_PLATFORM_INFORMATION
    {
        private byte AoAcField;
        public bool AoAc
        {
            get => AoAcField != 0;
            set => AoAcField = (byte)(value ? 1 : 0);
        }
    }
}

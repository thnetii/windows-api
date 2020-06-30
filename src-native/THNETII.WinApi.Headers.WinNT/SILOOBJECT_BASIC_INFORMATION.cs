using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12193
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SILOOBJECT_BASIC_INFORMATION
    {
        public int SiloId;
        public int SiloParentId;
        public int NumberOfProcesses;
        private byte IsInServerSiloField;
        public bool IsInServerSilo
        {
            get => IsInServerSiloField != 0;
            set => IsInServerSiloField = (byte)(value ? 1 : 0);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed byte Reserved[3];
    }
}

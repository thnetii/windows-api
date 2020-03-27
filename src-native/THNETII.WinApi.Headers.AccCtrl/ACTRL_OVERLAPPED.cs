using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 656
    [StructLayout(LayoutKind.Sequential)]
    public struct ACTRL_OVERLAPPED
    {
        [StructLayout(LayoutKind.Explicit)]
        private struct DUMMYUNIONNAME
        {
            [FieldOffset(0)]
            public IntPtr Provider;
            [FieldOffset(0)]
            public int Reserved1;
        }

        private DUMMYUNIONNAME u;

        public IntPtr Provider
        {
            readonly get => u.Provider;
            set => u.Provider = value;
        }

        public int Reserved1
        {
            readonly get => u.Reserved1;
            set => u.Reserved1 = value;
        }

        public int Reserved2;
        public IntPtr hEvent;
    }
}

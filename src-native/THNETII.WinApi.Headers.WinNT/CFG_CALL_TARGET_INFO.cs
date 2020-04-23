using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12663
    [StructLayout(LayoutKind.Sequential)]
    public struct CFG_CALL_TARGET_INFO
    {
        public UIntPtr Offset;
        internal IntPtr FlagsField;
        public CFG_CALL_TARGET_FLAGS Flags
        {
            get => (CFG_CALL_TARGET_FLAGS)FlagsField.ToInt32();
            set => FlagsField = (IntPtr)(int)value;
        }
    }
}

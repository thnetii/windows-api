using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17541
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe struct IMAGE_IMPORT_BY_NAME
    {
        public short Hint;
        internal fixed byte NameField[1];
        public string Name
        {
            get
            {
                fixed (byte* ptr = NameField)
                {
                    return Marshal.PtrToStringAnsi(new IntPtr(ptr));
                }
            }
        }
    }
}

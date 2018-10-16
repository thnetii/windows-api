using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Format of data for (F)XSAVE/(F)XRSTOR instruction
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public struct XSAVE_FORMAT
    {
        public ushort ControlWord;
        public ushort StatusWord;
        public byte TagWord;
        internal byte Reserved1;
        public ushort ErrorOpcode;
        public uint ErrorOffset;
        public ushort ErrorSelector;
        internal ushort Reserved2;
        public uint DataOffset;
        public ushort DataSelector;
        internal ushort Reserved3;
        public uint MxCsr;
        public uint MxCsr_Mask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public M128A[] FloatRegisters;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public M128A[] XmmRegisters;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 224)]
        internal byte[] Reserved4;
    }

    /// <summary>
    /// Format of data for (F)XSAVE/(F)XRSTOR instruction
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public struct XSAVE_FORMAT_WIN64
    {
        public ushort ControlWord;
        public ushort StatusWord;
        public byte TagWord;
        internal byte Reserved1;
        public ushort ErrorOpcode;
        public uint ErrorOffset;
        public ushort ErrorSelector;
        internal ushort Reserved2;
        public uint DataOffset;
        public ushort DataSelector;
        internal ushort Reserved3;
        public uint MxCsr;
        public uint MxCsr_Mask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public M128A[] FloatRegisters;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public M128A[] XmmRegisters;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)]
        internal byte[] Reserved4;
    }
}

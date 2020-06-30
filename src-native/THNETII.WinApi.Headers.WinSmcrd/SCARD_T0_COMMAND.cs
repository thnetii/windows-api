using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinSmcrd
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 281
    [StructLayout(LayoutKind.Sequential)]
    public struct SCARD_T0_COMMAND
    {
        /// <summary>The instruction class</summary>
        public byte bCla;
        /// <summary>The instruction code within the instruction class</summary>
        public byte bIns;
        /// <summary>First parameter to the instruction</summary>
        public byte bP1;
        /// <summary>Second parameter to the instruction</summary>
        public byte bP2;
        /// <summary>Size of I/O Transfer</summary>
        public byte bP3;
    }
}

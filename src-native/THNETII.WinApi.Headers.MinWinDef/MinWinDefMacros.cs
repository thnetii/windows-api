using System;
using System.Collections.Generic;
using System.Text;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.MinWinDef
{
    public static class MinWinDefMacros
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\minwindef.h, line 202
        private static readonly Bitfield32 lowByte = Bitfield32.FromMask(0xff);
        private static readonly Bitfield32 highByte = Bitfield32.FromMask(0xff, 8);
        private static readonly Bitfield32 lowWord = Bitfield32.FromMask(0xffff);
        private static readonly Bitfield32 highWord = Bitfield32.FromMask(0xffff, 16);

        public static ushort MAKEWORD(byte a, byte b)
        {
            uint v = 0;
            lowByte.Write(ref v, a);
            highByte.Write(ref v, b);
            return (ushort)v;
        }
        public static uint MAKELONG(ushort a, ushort b)
        {
            uint v = 0;
            lowWord.Write(ref v, a);
            highWord.Write(ref v, b);
            return v;
        }
        public static ushort LOWORD(uint l) => (ushort)lowWord.Read(l);
        public static ushort HIWORD(uint l) => (ushort)highWord.Read(l);
        public static byte LOBYTE(ushort w) => (byte)lowByte.Read(w);
        public static byte HIBYTE(ushort w) => (byte)highByte.Read(w);
    }
}

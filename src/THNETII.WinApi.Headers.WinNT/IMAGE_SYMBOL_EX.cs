using System;
using System.Runtime.InteropServices;
using System.Text;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16782
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe struct IMAGE_SYMBOL_EX
    {
        public IMAGE_SYMBOL_EX_N N;
        public int Value;
        public int SectionNumber;
        public short Type;
        public byte StorageClass;
        public byte NumberOfAuxSymbols;
    }

    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public unsafe struct IMAGE_SYMBOL_EX_N
    {
        [FieldOffset(0)]
        internal fixed byte ShortNameField[8];
        public string ShortName
        {
            get
            {
                fixed (byte* ptr = ShortNameField)
                {
                    Span<byte> span = new Span<byte>(ptr, 8);
                    int len = span.IndexOf((byte)0);
                    return Encoding.UTF8.GetString(ptr, len < 0 ? 8 : len);
                }
            }
            set
            {
                string s = value ?? string.Empty;
                fixed (char* ch = s)
                fixed (byte* ptr = ShortNameField)
                {
                    int len = Encoding.UTF8.GetBytes(ch, s.Length, ptr, 8);
                    if (len < 8)
                        ptr[len] = 0;
                }
            }
        }
        [FieldOffset(0)]
        public IMAGE_SYMBOL_EX_N_NAME Name;
        [FieldOffset(0)]
        public fixed int LongName[2];
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct IMAGE_SYMBOL_EX_N_NAME
    {
        /// <summary>if <c>0</c> (zero), use <see cref="IMAGE_SYMBOL_EX_N.LongName"/></summary>
        public int Short;
        /// <summary>offset into string table</summary>
        public int Long;
    }
}

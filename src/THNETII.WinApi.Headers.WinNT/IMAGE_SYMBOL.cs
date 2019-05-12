using System.Runtime.InteropServices;
using System.Text;

using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16759
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe struct IMAGE_SYMBOL
    {
        public IMAGE_SYMBOL_N N;
        public int Value;
        public short SectionNumber;
        public IMAGE_SYM_TYPE Type;
        public byte StorageClass;
        public byte NumberOfAuxSymbols;
    }

    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public unsafe struct IMAGE_SYMBOL_N
    {
        [FieldOffset(0)]
        internal fixed byte ShortNameField[8];
        public string ShortName
        {
            get
            {
                fixed (byte* ptr = ShortNameField)
                    return FixedStringBuffer.ToString(ptr, 8, Encoding.UTF8);
            }
            set
            {
                fixed (byte* ptr = ShortNameField)
                    FixedStringBuffer.ToBytes(value, ptr, 8, Encoding.UTF8);
            }
        }
        [FieldOffset(0)]
        public IMAGE_SYMBOL_N_NAME Name;
        [FieldOffset(0)]
        public fixed int LongName[2];
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct IMAGE_SYMBOL_N_NAME
    {
        /// <summary>if <c>0</c> (zero), use <see cref="IMAGE_SYMBOL_N.LongName"/></summary>
        public int Short;
        /// <summary>offset into string table</summary>
        public int Long;
    }
}

using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16473
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe struct IMAGE_ROM_OPTIONAL_HEADER
    {
        public short Magic;
        public byte MajorLinkerVersion;
        public byte MinorLinkerVersion;
        public Version LinkerVersion
        {
            get => new Version(MajorLinkerVersion, MinorLinkerVersion);
            set
            {
                MajorLinkerVersion = (byte)(value?.Major ?? 0);
                MinorLinkerVersion = (byte)(value?.Minor ?? 0);
            }
        }
        public int SizeOfCode;
        public int SizeOfInitializedData;
        public int SizeOfUninitializedData;
        public int AddressOfEntryPoint;
        public int BaseOfCode;
        public int BaseOfData;
        public int BaseOfBss;
        public int GprMask;
        public fixed int CprMask[4];
        public int GpValue;
    }
}

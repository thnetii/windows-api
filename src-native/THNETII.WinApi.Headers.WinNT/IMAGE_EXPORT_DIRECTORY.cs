using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17523
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_EXPORT_DIRECTORY
    {
        public int Characteristics;
        public int TimeDateStamp;
        public short MajorVersion;
        public short MinorVersion;
        public Version Version
        {
            get => new Version(MajorVersion, MinorVersion);
            set
            {
                MajorVersion = (short)(value?.Major ?? 0);
                MinorVersion = (short)(value?.Minor ?? 0);
            }
        }
        public int Name;
        public int Base;
        public int NumberOfFunctions;
        public int NumberOfNames;
        public int AddressOfFunctions;     // RVA from base of image
        public int AddressOfNames;         // RVA from base of image
        public int AddressOfNameOrdinals;  // RVA from base of image
    }
}

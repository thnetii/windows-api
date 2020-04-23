using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16628
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct ANON_OBJECT_HEADER
    {
        /// <summary>Must be <see cref="IMAGE_FILE_MACHINE_UNKNOWN"/></summary>
        public short Sig1;
        /// <summary>Must be <c>0xffff</c></summary>
        public short Sig2;
        /// <summary>&gt;= 1 (implies the <see cref="ClassID"/> field is present)</summary>
        public short Version;
        public short Machine;
        public int TimeDateStamp;
        /// <summary>Used to invoke <see cref="CoCreateInstance"/></summary>
        public Guid ClassID;
        /// <summary>Size of data that follows the header</summary>
        public int SizeOfData;
    }
}

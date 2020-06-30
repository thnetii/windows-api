using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16258
    /// <summary>
    /// OS/2 .EXE header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct IMAGE_OS2_HEADER
    {
        /// <summary>Magic number</summary>
        public short ne_magic;
        /// <summary>Version number</summary>
        public byte ne_ver;
        /// <summary>Revision number</summary>
        public byte ne_rev;
        /// <summary>Offset of Entry Table</summary>
        public short ne_enttab;
        /// <summary>Number of bytes in Entry Table</summary>
        public short ne_cbenttab;
        /// <summary>Checksum of whole file</summary>
        public int ne_crc;
        /// <summary>Flag word</summary>
        public short ne_flags;
        /// <summary>Automatic data segment number</summary>
        public short ne_autodata;
        /// <summary>Initial heap allocation</summary>
        public short ne_heap;
        /// <summary>Initial stack allocation</summary>
        public short ne_stack;
        /// <summary>Initial CS:IP setting</summary>
        public int ne_csip;
        /// <summary>Initial SS:SP setting</summary>
        public int ne_sssp;
        /// <summary>Count of file segments</summary>
        public short ne_cseg;
        /// <summary>Entries in Module Reference Table</summary>
        public short ne_cmod;
        /// <summary>Size of non-resident name table</summary>
        public short ne_cbnrestab;
        /// <summary>Offset of Segment Table</summary>
        public short ne_segtab;
        /// <summary>Offset of Resource Table</summary>
        public short ne_rsrctab;
        /// <summary>Offset of resident name table</summary>
        public short ne_restab;
        /// <summary>Offset of Module Reference Table</summary>
        public short ne_modtab;
        /// <summary>Offset of Imported Names Table</summary>
        public short ne_imptab;
        /// <summary>Offset of Non-resident Names Table</summary>
        public int ne_nrestab;
        /// <summary>Count of movable entries</summary>
        public short ne_cmovent;
        /// <summary>Segment alignment shift count</summary>
        public short ne_align;
        /// <summary>Count of resource segments</summary>
        public short ne_cres;
        /// <summary>Target Operating system</summary>
        public byte ne_exetyp;
        /// <summary>Other .EXE flags</summary>
        public byte ne_flagsothers;
        /// <summary>offset to return thunks</summary>
        public short ne_pretthunks;
        /// <summary>offset to segment ref. bytes</summary>
        public short ne_psegrefbytes;
        /// <summary>Minimum code swap area size</summary>
        public short ne_swaparea;
        /// <summary>Expected Windows version number</summary>
        public short ne_expver;
    }
}

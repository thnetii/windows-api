using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16291
    /// <summary>
    /// Windows VXD header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe struct IMAGE_VXD_HEADER
    {
        /// <summary>Magic number</summary>
        public short e32_magic;
        /// <summary>The byte ordering for the VXD</summary>
        public byte e32_border;
        /// <summary>The word ordering for the VXD</summary>
        public byte e32_worder;
        /// <summary>The EXE format level for now = 0</summary>
        public int e32_level;
        /// <summary>The CPU type</summary>
        public short e32_cpu;
        /// <summary>The OS type</summary>
        public short e32_os;
        /// <summary>Module version</summary>
        public int e32_ver;
        /// <summary>Module flags</summary>
        public int e32_mflags;
        /// <summary>Module # pages</summary>
        public int e32_mpages;
        /// <summary>Object # for instruction pointer</summary>
        public int e32_startobj;
        /// <summary>Extended instruction pointer</summary>
        public int e32_eip;
        /// <summary>Object # for stack pointer</summary>
        public int e32_stackobj;
        /// <summary>Extended stack pointer</summary>
        public int e32_esp;
        /// <summary>VXD page size</summary>
        public int e32_pagesize;
        /// <summary>Last page size in VXD</summary>
        public int e32_lastpagesize;
        /// <summary>Fixup section size</summary>
        public int e32_fixupsize;
        /// <summary>Fixup section checksum</summary>
        public int e32_fixupsum;
        /// <summary>Loader section size</summary>
        public int e32_ldrsize;
        /// <summary>Loader section checksum</summary>
        public int e32_ldrsum;
        /// <summary>Object table offset</summary>
        public int e32_objtab;
        /// <summary>Number of objects in module</summary>
        public int e32_objcnt;
        /// <summary>Object page map offset</summary>
        public int e32_objmap;
        /// <summary>Object iterated data map offset</summary>
        public int e32_itermap;
        /// <summary>Offset of Resource Table</summary>
        public int e32_rsrctab;
        /// <summary>Number of resource entries</summary>
        public int e32_rsrccnt;
        /// <summary>Offset of resident name table</summary>
        public int e32_restab;
        /// <summary>Offset of Entry Table</summary>
        public int e32_enttab;
        /// <summary>Offset of Module Directive Table</summary>
        public int e32_dirtab;
        /// <summary>Number of module directives</summary>
        public int e32_dircnt;
        /// <summary>Offset of Fixup Page Table</summary>
        public int e32_fpagetab;
        /// <summary>Offset of Fixup Record Table</summary>
        public int e32_frectab;
        /// <summary>Offset of Import Module Name Table</summary>
        public int e32_impmod;
        /// <summary>Number of entries in Import Module Name Table</summary>
        public int e32_impmodcnt;
        /// <summary>Offset of Import Procedure Name Table</summary>
        public int e32_impproc;
        /// <summary>Offset of Per-Page Checksum Table</summary>
        public int e32_pagesum;
        /// <summary>Offset of Enumerated Data Pages</summary>
        public int e32_datapage;
        /// <summary>Number of preload pages</summary>
        public int e32_preload;
        /// <summary>Offset of Non-resident Names Table</summary>
        public int e32_nrestab;
        /// <summary>Size of Non-resident Name Table</summary>
        public int e32_cbnrestab;
        /// <summary>Non-resident Name Table Checksum</summary>
        public int e32_nressum;
        /// <summary>Object # for automatic data object</summary>
        public int e32_autodata;
        /// <summary>Offset of the debugging information</summary>
        public int e32_debuginfo;
        /// <summary>The length of the debugging info. in bytes</summary>
        public int e32_debuglen;
        /// <summary>Number of instance pages in preload section of VXD file</summary>
        public int e32_instpreload;
        /// <summary>Number of instance pages in demand load section of VXD file</summary>
        public int e32_instdemand;
        /// <summary>Size of heap - for 16-bit apps</summary>
        public int e32_heapsize;
        /// <summary>Reserved words</summary>
        public fixed byte e32_res3[12];
        public int e32_winresoff;
        public int e32_winreslen;
        /// <summary>Device ID for VxD</summary>
        public short e32_devid;
        /// <summary>DDK version for VxD</summary>
        public short e32_ddkver;
    }
}

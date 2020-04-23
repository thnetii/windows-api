using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16236
    /// <summary>
    /// DOS .EXE header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe struct IMAGE_DOS_HEADER
    {
        /// <summary>Magic number</summary>
        public short e_magic;
        /// <summary>Bytes on last page of file</summary>
        public short e_cblp;
        /// <summary>Pages in file</summary>
        public short e_cp;
        /// <summary>Relocations</summary>
        public short e_crlc;
        /// <summary>Size of header in paragraphs</summary>
        public short e_cparhdr;
        /// <summary>Minimum extra paragraphs needed</summary>
        public short e_minalloc;
        /// <summary>Maximum extra paragraphs needed</summary>
        public short e_maxalloc;
        /// <summary>Initial (relative) SS value</summary>
        public short e_ss;
        /// <summary>Initial SP value</summary>
        public short e_sp;
        /// <summary>Checksum</summary>
        public short e_csum;
        /// <summary>Initial IP value</summary>
        public short e_ip;
        /// <summary>Initial (relative) CS value</summary>
        public short e_cs;
        /// <summary>File address of relocation table</summary>
        public short e_lfarlc;
        /// <summary>Overlay number</summary>
        public short e_ovno;
        /// <summary>Reserved words</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed short e_res[4];
        /// <summary>OEM identifier (for <see cref="e_oeminfo"/>)</summary>
        public short e_oemid;
        /// <summary>OEM information; <see cref="e_oemid"/> specific</summary>
        public short e_oeminfo;
        /// <summary>Reserved words</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed short e_res2[10];
        /// <summary>File address of new exe header</summary>
        public long e_lfanew;
    }
}

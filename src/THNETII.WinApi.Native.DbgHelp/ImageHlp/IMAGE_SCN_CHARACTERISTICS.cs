using System;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Section characteristics.
    /// </summary>
    [Flags]
    public enum IMAGE_SCN_CHARACTERISTICS : int
    {
        /// <summary>Reserved.</summary>
        IMAGE_SCN_TYPE_REG = 0x00000000,
        /// <summary>Reserved.</summary>
        IMAGE_SCN_TYPE_DSECT = 0x00000001,
        /// <summary>Reserved.</summary>
        IMAGE_SCN_TYPE_NOLOAD = 0x00000002,
        /// <summary>Reserved.</summary>
        IMAGE_SCN_TYPE_GROUP = 0x00000004,
        /// <summary>Reserved.</summary>
        IMAGE_SCN_TYPE_NO_PAD = 0x00000008,
        /// <summary>Reserved.</summary>
        IMAGE_SCN_TYPE_COPY = 0x00000010,

        /// <summary>Section contains code.</summary>
        IMAGE_SCN_CNT_CODE = 0x00000020,
        /// <summary>Section contains initialized data.</summary>
        IMAGE_SCN_CNT_INITIALIZED_DATA = 0x00000040,
        /// <summary>Section contains uninitialized data.</summary>
        IMAGE_SCN_CNT_UNINITIALIZED_DATA = 0x00000080,

        /// <summary>Reserved.</summary>
        IMAGE_SCN_LNK_OTHER = 0x00000100,
        /// <summary>Section contains comments or some other type of information.</summary>
        IMAGE_SCN_LNK_INFO = 0x00000200,
        /// <summary>Reserved.</summary>
        IMAGE_SCN_TYPE_OVER = 0x00000400,
        /// <summary>Section contents will not become part of image.</summary>
        IMAGE_SCN_LNK_REMOVE = 0x00000800,
        /// <summary>Section contents comdat.</summary>
        IMAGE_SCN_LNK_COMDAT = 0x00001000,
        //                                           0x00002000  // Reserved.
        [Obsolete]
        IMAGE_SCN_MEM_PROTECTED = 0x00004000,
                              /// <summary>Reset speculative exceptions handling bits in the TLB entries for this section.</summary>
        IMAGE_SCN_NO_DEFER_SPEC_EXC = 0x00004000,
        /// <summary>Section content can be accessed relative to GP</summary>
        IMAGE_SCN_GPREL = 0x00008000,
        /// <summary></summary>
        IMAGE_SCN_MEM_FARDATA = 0x00008000,
        [Obsolete]
        IMAGE_SCN_MEM_SYSHEAP = 0x00010000,
        /// <summary></summary>
        IMAGE_SCN_MEM_PURGEABLE = 0x00020000,
        /// <summary></summary>
        IMAGE_SCN_MEM_16BIT = 0x00020000,
        /// <summary></summary>
        IMAGE_SCN_MEM_LOCKED = 0x00040000,
        /// <summary></summary>
        IMAGE_SCN_MEM_PRELOAD = 0x00080000,

        /// <summary></summary>
        IMAGE_SCN_ALIGN_1BYTES = 0x00100000,
        /// <summary></summary>
        IMAGE_SCN_ALIGN_2BYTES = 0x00200000,
        /// <summary></summary>
        IMAGE_SCN_ALIGN_4BYTES = 0x00300000,
        /// <summary></summary>
        IMAGE_SCN_ALIGN_8BYTES = 0x00400000,
        /// <summary>Default alignment if no others are specified.</summary>
        IMAGE_SCN_ALIGN_16BYTES = 0x00500000,
        /// <summary></summary>
        IMAGE_SCN_ALIGN_32BYTES = 0x00600000,
        /// <summary></summary>
        IMAGE_SCN_ALIGN_64BYTES = 0x00700000,
        /// <summary></summary>
        IMAGE_SCN_ALIGN_128BYTES = 0x00800000,
        /// <summary></summary>
        IMAGE_SCN_ALIGN_256BYTES = 0x00900000,
        /// <summary></summary>
        IMAGE_SCN_ALIGN_512BYTES = 0x00A00000,
        /// <summary></summary>
        IMAGE_SCN_ALIGN_1024BYTES = 0x00B00000,
        /// <summary></summary>
        IMAGE_SCN_ALIGN_2048BYTES = 0x00C00000,
        /// <summary></summary>
        IMAGE_SCN_ALIGN_4096BYTES = 0x00D00000,
        /// <summary></summary>
        IMAGE_SCN_ALIGN_8192BYTES = 0x00E00000,
        // Unused                                    0x00F00000
        /// <summary></summary>
        IMAGE_SCN_ALIGN_MASK = 0x00F00000,

        /// <summary>Section contains extended relocations.</summary>
        IMAGE_SCN_LNK_NRELOC_OVFL = 0x01000000,
        /// <summary>Section can be discarded.</summary>
        IMAGE_SCN_MEM_DISCARDABLE = 0x02000000,
        /// <summary>Section is not cachable.</summary>
        IMAGE_SCN_MEM_NOT_CACHED = 0x04000000,
        /// <summary>Section is not pageable.</summary>
        IMAGE_SCN_MEM_NOT_PAGED = 0x08000000,
        /// <summary>Section is shareable.</summary>
        IMAGE_SCN_MEM_SHARED = 0x10000000,
        /// <summary>Section is executable.</summary>
        IMAGE_SCN_MEM_EXECUTE = 0x20000000,
        /// <summary>Section is readable.</summary>
        IMAGE_SCN_MEM_READ = 0x40000000,
        /// <summary>Section is writeable.</summary>
        IMAGE_SCN_MEM_WRITE = unchecked((int)0x80000000),
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
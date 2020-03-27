using System;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16694
    /// <summary>
    /// Section characteristics.
    /// </summary>
    [Flags]
    public enum IMAGE_SCN_CHARACTERISTICS : int
    {
        /// <summary>Reserved.</summary>
        IMAGE_SCN_TYPE_REG = WinNTConstants.IMAGE_SCN_TYPE_REG,
        /// <summary>Reserved.</summary>
        IMAGE_SCN_TYPE_DSECT = WinNTConstants.IMAGE_SCN_TYPE_DSECT,
        /// <summary>Reserved.</summary>
        IMAGE_SCN_TYPE_NOLOAD = WinNTConstants.IMAGE_SCN_TYPE_NOLOAD,
        /// <summary>Reserved.</summary>
        IMAGE_SCN_TYPE_GROUP = WinNTConstants.IMAGE_SCN_TYPE_GROUP,
        /// <summary>
        /// The section should not be padded to the next boundary.
        /// <para>This flag is obsolete and is replaced by <see cref="IMAGE_SCN_ALIGN_1BYTES"/>.</para>
        /// </summary>
        [Obsolete("This flag is obsolete and is replaced by IMAGE_SCN_ALIGN_1BYTES.")]
        IMAGE_SCN_TYPE_NO_PAD = WinNTConstants.IMAGE_SCN_TYPE_NO_PAD,
        /// <summary>Reserved.</summary>
        IMAGE_SCN_TYPE_COPY = WinNTConstants.IMAGE_SCN_TYPE_COPY,

        /// <summary>The section contains executable code. </summary>
        IMAGE_SCN_CNT_CODE = WinNTConstants.IMAGE_SCN_CNT_CODE,
        /// <summary>The section contains initialized data. </summary>
        IMAGE_SCN_CNT_INITIALIZED_DATA = WinNTConstants.IMAGE_SCN_CNT_INITIALIZED_DATA,
        /// <summary>The section contains uninitialized data. </summary>
        IMAGE_SCN_CNT_UNINITIALIZED_DATA = WinNTConstants.IMAGE_SCN_CNT_UNINITIALIZED_DATA,

        /// <summary>Reserved. </summary>
        IMAGE_SCN_LNK_OTHER = WinNTConstants.IMAGE_SCN_LNK_OTHER,
        /// <summary>The section contains comments or other information. This is valid only for object files. </summary>
        IMAGE_SCN_LNK_INFO = WinNTConstants.IMAGE_SCN_LNK_INFO,
        /// <summary>Reserved. </summary>
        IMAGE_SCN_TYPE_OVER = WinNTConstants.IMAGE_SCN_TYPE_OVER,
        /// <summary>The section will not become part of the image. This is valid only for object files. </summary>
        IMAGE_SCN_LNK_REMOVE = WinNTConstants.IMAGE_SCN_LNK_REMOVE,
        /// <summary>The section contains COMDAT data. This is valid only for object files. </summary>
        IMAGE_SCN_LNK_COMDAT = WinNTConstants.IMAGE_SCN_LNK_COMDAT,

        [Obsolete("Obsolete")]
        IMAGE_SCN_MEM_PROTECTED = WinNTConstants.IMAGE_SCN_MEM_PROTECTED,
        /// <summary>Reset speculative exceptions handling bits in the TLB entries for this section. </summary>
        IMAGE_SCN_NO_DEFER_SPEC_EXC = WinNTConstants.IMAGE_SCN_NO_DEFER_SPEC_EXC,
        /// <summary>The section contains data referenced through the global pointer. </summary>
        IMAGE_SCN_GPREL = WinNTConstants.IMAGE_SCN_GPREL,
        IMAGE_SCN_MEM_FARDATA = WinNTConstants.IMAGE_SCN_MEM_FARDATA,
        [Obsolete("Obsolete")]
        IMAGE_SCN_MEM_SYSHEAP = WinNTConstants.IMAGE_SCN_MEM_SYSHEAP,
        /// <summary>Reserved. </summary>
        IMAGE_SCN_MEM_PURGEABLE = WinNTConstants.IMAGE_SCN_MEM_PURGEABLE,
        IMAGE_SCN_MEM_16BIT = WinNTConstants.IMAGE_SCN_MEM_16BIT,
        /// <summary>Reserved. </summary>
        IMAGE_SCN_MEM_LOCKED = WinNTConstants.IMAGE_SCN_MEM_LOCKED,
        /// <summary>Reserved. </summary>
        IMAGE_SCN_MEM_PRELOAD = WinNTConstants.IMAGE_SCN_MEM_PRELOAD,

        /// <summary>Align data on a 1-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_1BYTES = WinNTConstants.IMAGE_SCN_ALIGN_1BYTES,
        /// <summary>Align data on a 2-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_2BYTES = WinNTConstants.IMAGE_SCN_ALIGN_2BYTES,
        /// <summary>Align data on a 4-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_4BYTES = WinNTConstants.IMAGE_SCN_ALIGN_4BYTES,
        /// <summary>Align data on a 8-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_8BYTES = WinNTConstants.IMAGE_SCN_ALIGN_8BYTES,
        /// <summary>Align data on a 16-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_16BYTES = WinNTConstants.IMAGE_SCN_ALIGN_16BYTES,
        /// <summary>Align data on a 32-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_32BYTES = WinNTConstants.IMAGE_SCN_ALIGN_32BYTES,
        /// <summary>Align data on a 64-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_64BYTES = WinNTConstants.IMAGE_SCN_ALIGN_64BYTES,
        /// <summary>Align data on a 128-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_128BYTES = WinNTConstants.IMAGE_SCN_ALIGN_128BYTES,
        /// <summary>Align data on a 256-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_256BYTES = WinNTConstants.IMAGE_SCN_ALIGN_256BYTES,
        /// <summary>Align data on a 512-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_512BYTES = WinNTConstants.IMAGE_SCN_ALIGN_512BYTES,
        /// <summary>Align data on a 1024-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_1024BYTES = WinNTConstants.IMAGE_SCN_ALIGN_1024BYTES,
        /// <summary>Align data on a 2048-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_2048BYTES = WinNTConstants.IMAGE_SCN_ALIGN_2048BYTES,
        /// <summary>Align data on a 4096-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_4096BYTES = WinNTConstants.IMAGE_SCN_ALIGN_4096BYTES,
        /// <summary>Align data on a 8192-byte boundary. This is valid only for object files. </summary>
        IMAGE_SCN_ALIGN_8192BYTES = WinNTConstants.IMAGE_SCN_ALIGN_8192BYTES,

        IMAGE_SCN_ALIGN_MASK = WinNTConstants.IMAGE_SCN_ALIGN_MASK,

        /// <summary>
        /// The section contains extended relocations. The count of relocations for the section exceeds the 16 bits that is reserved for it in the section header. If the <see cref="IMAGE_SECTION_HEADER.NumberOfRelocations"/> field in the section header is <c>0xffff</c>, the actual relocation count is stored in the <see cref="IMAGE_RELOCATION.VirtualAddress"/> field of the first relocation. It is an error if <see cref="IMAGE_SCN_LNK_NRELOC_OVFL"/> is set and there are fewer than <c>0xffff</c> relocations in the section.
        /// </summary>
        IMAGE_SCN_LNK_NRELOC_OVFL = WinNTConstants.IMAGE_SCN_LNK_NRELOC_OVFL,
        /// <summary>The section can be discarded as needed. </summary>
        IMAGE_SCN_MEM_DISCARDABLE = WinNTConstants.IMAGE_SCN_MEM_DISCARDABLE,
        /// <summary>The section cannot be cached. </summary>
        IMAGE_SCN_MEM_NOT_CACHED = WinNTConstants.IMAGE_SCN_MEM_NOT_CACHED,
        /// <summary>The section cannot be paged. </summary>
        IMAGE_SCN_MEM_NOT_PAGED = WinNTConstants.IMAGE_SCN_MEM_NOT_PAGED,
        /// <summary>The section can be shared in memory. </summary>
        IMAGE_SCN_MEM_SHARED = WinNTConstants.IMAGE_SCN_MEM_SHARED,
        /// <summary>The section can be executed as code. </summary>
        IMAGE_SCN_MEM_EXECUTE = WinNTConstants.IMAGE_SCN_MEM_EXECUTE,
        /// <summary>The section can be read. </summary>
        IMAGE_SCN_MEM_READ = WinNTConstants.IMAGE_SCN_MEM_READ,
        /// <summary>The section can be written to. </summary>
        IMAGE_SCN_MEM_WRITE = WinNTConstants.IMAGE_SCN_MEM_WRITE,

        //
        // TLS Characteristic Flags
        //
        IMAGE_SCN_SCALE_INDEX = WinNTConstants.IMAGE_SCN_SCALE_INDEX,
    }
}

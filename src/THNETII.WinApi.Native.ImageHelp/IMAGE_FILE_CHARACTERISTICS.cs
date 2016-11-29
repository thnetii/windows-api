using System;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHelp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [Flags]
    public enum IMAGE_FILE_CHARACTERISTICS : ushort
    {
        /// <summary>Relocation information was stripped from the file. The file must be loaded at its preferred base address. If the base address is not available, the loader reports an error.</summary>
        IMAGE_FILE_RELOCS_STRIPPED = 0x0001,
        /// <summary>File is executable  (i.e. no unresolved external references).</summary>
        IMAGE_FILE_EXECUTABLE_IMAGE = 0x0002,
        /// <summary>Line nunbers stripped from file.</summary>
        IMAGE_FILE_LINE_NUMS_STRIPPED = 0x0004,
        /// <summary>Local symbols stripped from file.</summary>
        IMAGE_FILE_LOCAL_SYMS_STRIPPED = 0x0008,
        /// <summary>Aggressively trim working set</summary>
        IMAGE_FILE_AGGRESIVE_WS_TRIM = 0x0010,
        /// <summary>App can handle >2gb addresses</summary>
        IMAGE_FILE_LARGE_ADDRESS_AWARE = 0x0020,
        /// <summary>Bytes of machine word are reversed.</summary>
        IMAGE_FILE_BYTES_REVERSED_LO = 0x0080,
        /// <summary>32 bit word machine.</summary>
        IMAGE_FILE_32BIT_MACHINE = 0x0100,
        /// <summary>Debugging info stripped from file in .DBG file</summary>
        IMAGE_FILE_DEBUG_STRIPPED = 0x0200,
        /// <summary>If Image is on removable media, copy and run from the swap file.</summary>
        IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP = 0x0400,
        /// <summary>If Image is on Net, copy and run from the swap file.</summary>
        IMAGE_FILE_NET_RUN_FROM_SWAP = 0x0800,
        /// <summary>System File.</summary>
        IMAGE_FILE_SYSTEM = 0x1000,
        /// <summary>File is a DLL.</summary>
        IMAGE_FILE_DLL = 0x2000,
        /// <summary>File should only be run on a UP machine</summary>
        IMAGE_FILE_UP_SYSTEM_ONLY = 0x4000,
        /// <summary>Bytes of machine word are reversed.</summary>
        IMAGE_FILE_BYTES_REVERSED_HI = 0x8000,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

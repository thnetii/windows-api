using System;
using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_FILE_CHARACTERISTICS : short
    {
        /// <summary>
        /// Relocation information was stripped from the file. The file must be loaded at its preferred base address. If the base address is not available, the loader reports an error. 
        /// </summary>
        IMAGE_FILE_RELOCS_STRIPPED = WinNTConstants.IMAGE_FILE_RELOCS_STRIPPED,
        /// <summary>The file is executable (there are no unresolved external references).</summary>
        IMAGE_FILE_EXECUTABLE_IMAGE = WinNTConstants.IMAGE_FILE_EXECUTABLE_IMAGE,
        /// <summary>COFF line numbers were stripped from the file.</summary>
        IMAGE_FILE_LINE_NUMS_STRIPPED = WinNTConstants.IMAGE_FILE_LINE_NUMS_STRIPPED,
        /// <summary>COFF symbol table entries were stripped from file.</summary>
        IMAGE_FILE_LOCAL_SYMS_STRIPPED = WinNTConstants.IMAGE_FILE_LOCAL_SYMS_STRIPPED,
        /// <summary>Aggressively trim the working set. This value is obsolete.</summary>
        [Obsolete("This value is obsolete.")]
        IMAGE_FILE_AGGRESIVE_WS_TRIM = WinNTConstants.IMAGE_FILE_AGGRESIVE_WS_TRIM,
        /// <summary>The application can handle addresses larger than 2 GB.</summary>
        IMAGE_FILE_LARGE_ADDRESS_AWARE = WinNTConstants.IMAGE_FILE_LARGE_ADDRESS_AWARE,
        /// <summary>The bytes of the word are reversed. This flag is obsolete.</summary>
        [Obsolete("This flag is obsolete.")]
        IMAGE_FILE_BYTES_REVERSED_LO = WinNTConstants.IMAGE_FILE_BYTES_REVERSED_LO,
        /// <summary>The computer supports 32-bit words.</summary>
        IMAGE_FILE_32BIT_MACHINE = WinNTConstants.IMAGE_FILE_32BIT_MACHINE,
        /// <summary>Debugging information was removed and stored separately in another file.</summary>
        IMAGE_FILE_DEBUG_STRIPPED = WinNTConstants.IMAGE_FILE_DEBUG_STRIPPED,
        /// <summary>If the image is on removable media, copy it to and run it from the swap file.</summary>
        IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP = WinNTConstants.IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP,
        /// <summary>If the image is on the network, copy it to and run it from the swap file.</summary>
        IMAGE_FILE_NET_RUN_FROM_SWAP = WinNTConstants.IMAGE_FILE_NET_RUN_FROM_SWAP,
        /// <summary>The image is a system file.</summary>
        IMAGE_FILE_SYSTEM = WinNTConstants.IMAGE_FILE_SYSTEM,
        /// <summary>The image is a DLL file. While it is an executable file, it cannot be run directly.</summary>
        IMAGE_FILE_DLL = WinNTConstants.IMAGE_FILE_DLL,
        /// <summary>The file should be run only on a uniprocessor computer.</summary>
        IMAGE_FILE_UP_SYSTEM_ONLY = WinNTConstants.IMAGE_FILE_UP_SYSTEM_ONLY,
        /// <summary>The bytes of the word are reversed. This flag is obsolete.</summary>
        [Obsolete("This flag is obsolete.")]
        IMAGE_FILE_BYTES_REVERSED_HI = WinNTConstants.IMAGE_FILE_BYTES_REVERSED_HI,
    }
}

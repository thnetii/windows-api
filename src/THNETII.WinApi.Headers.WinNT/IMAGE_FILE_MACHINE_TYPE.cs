using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_FILE_MACHINE_TYPE : short
    {
        IMAGE_FILE_MACHINE_UNKNOWN = WinNTConstants.IMAGE_FILE_MACHINE_UNKNOWN,
        /// <summary>Useful for indicating we want to interact with the host and not a WoW guest.</summary>
        IMAGE_FILE_MACHINE_TARGET_HOST = WinNTConstants.IMAGE_FILE_MACHINE_TARGET_HOST,
        /// <summary>Intel 386.</summary>
        IMAGE_FILE_MACHINE_I386 = WinNTConstants.IMAGE_FILE_MACHINE_I386,
        /// <summary>MIPS little-endian, 0x160 big-endian</summary>
        IMAGE_FILE_MACHINE_R3000 = WinNTConstants.IMAGE_FILE_MACHINE_R3000,
        /// <summary>MIPS little-endian</summary>
        IMAGE_FILE_MACHINE_R4000 = WinNTConstants.IMAGE_FILE_MACHINE_R4000,
        /// <summary>MIPS little-endian</summary>
        IMAGE_FILE_MACHINE_R10000 = WinNTConstants.IMAGE_FILE_MACHINE_R10000,
        /// <summary>MIPS little-endian WCE v2</summary>
        IMAGE_FILE_MACHINE_WCEMIPSV2 = WinNTConstants.IMAGE_FILE_MACHINE_WCEMIPSV2,
        /// <summary>Alpha_AXP</summary>
        IMAGE_FILE_MACHINE_ALPHA = WinNTConstants.IMAGE_FILE_MACHINE_ALPHA,
        /// <summary>SH3 little-endian</summary>
        IMAGE_FILE_MACHINE_SH3 = WinNTConstants.IMAGE_FILE_MACHINE_SH3,
        IMAGE_FILE_MACHINE_SH3DSP = WinNTConstants.IMAGE_FILE_MACHINE_SH3DSP,
        /// <summary>SH3E little-endian</summary>
        IMAGE_FILE_MACHINE_SH3E = WinNTConstants.IMAGE_FILE_MACHINE_SH3E,
        /// <summary>SH4 little-endian</summary>
        IMAGE_FILE_MACHINE_SH4 = WinNTConstants.IMAGE_FILE_MACHINE_SH4,
        /// <summary>SH5</summary>
        IMAGE_FILE_MACHINE_SH5 = WinNTConstants.IMAGE_FILE_MACHINE_SH5,
        /// <summary>ARM Little-Endian</summary>
        IMAGE_FILE_MACHINE_ARM = WinNTConstants.IMAGE_FILE_MACHINE_ARM,
        /// <summary>ARM Thumb/Thumb-2 Little-Endian</summary>
        IMAGE_FILE_MACHINE_THUMB = WinNTConstants.IMAGE_FILE_MACHINE_THUMB,
        /// <summary>ARM Thumb-2 Little-Endian</summary>
        IMAGE_FILE_MACHINE_ARMNT = WinNTConstants.IMAGE_FILE_MACHINE_ARMNT,
        IMAGE_FILE_MACHINE_AM33 = WinNTConstants.IMAGE_FILE_MACHINE_AM33,
        /// <summary>IBM PowerPC Little-Endian</summary>
        IMAGE_FILE_MACHINE_POWERPC = WinNTConstants.IMAGE_FILE_MACHINE_POWERPC,
        IMAGE_FILE_MACHINE_POWERPCFP = WinNTConstants.IMAGE_FILE_MACHINE_POWERPCFP,
        /// <summary>Intel 64</summary>
        IMAGE_FILE_MACHINE_IA64 = WinNTConstants.IMAGE_FILE_MACHINE_IA64,
        /// <summary>MIPS</summary>
        IMAGE_FILE_MACHINE_MIPS16 = WinNTConstants.IMAGE_FILE_MACHINE_MIPS16,
        /// <summary>ALPHA64</summary>
        IMAGE_FILE_MACHINE_ALPHA64 = WinNTConstants.IMAGE_FILE_MACHINE_ALPHA64,
        /// <summary>MIPS</summary>
        IMAGE_FILE_MACHINE_MIPSFPU = WinNTConstants.IMAGE_FILE_MACHINE_MIPSFPU,
        /// <summary>MIPS</summary>
        IMAGE_FILE_MACHINE_MIPSFPU16 = WinNTConstants.IMAGE_FILE_MACHINE_MIPSFPU16,
        IMAGE_FILE_MACHINE_AXP64 = WinNTConstants.IMAGE_FILE_MACHINE_AXP64,
        /// <summary>Infineon</summary>
        IMAGE_FILE_MACHINE_TRICORE = WinNTConstants.IMAGE_FILE_MACHINE_TRICORE,
        IMAGE_FILE_MACHINE_CEF = WinNTConstants.IMAGE_FILE_MACHINE_CEF,
        /// <summary>EFI Byte Code</summary>
        IMAGE_FILE_MACHINE_EBC = WinNTConstants.IMAGE_FILE_MACHINE_EBC,
        /// <summary>AMD64 (K8)</summary>
        IMAGE_FILE_MACHINE_AMD64 = WinNTConstants.IMAGE_FILE_MACHINE_AMD64,
        /// <summary>M32R little-endian</summary>
        IMAGE_FILE_MACHINE_M32R = WinNTConstants.IMAGE_FILE_MACHINE_M32R,
        /// <summary>ARM64 Little-Endian</summary>
        IMAGE_FILE_MACHINE_ARM64 = WinNTConstants.IMAGE_FILE_MACHINE_ARM64,
        IMAGE_FILE_MACHINE_CEE = WinNTConstants.IMAGE_FILE_MACHINE_CEE,
    }
}

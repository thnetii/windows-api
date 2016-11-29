namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum IMAGE_FILE_MACHINE : ushort
    {
        /// <summary></summary>
        IMAGE_FILE_MACHINE_UNKNOWN = 0,
        /// <summary>Useful for indicating we want to interact with the host and not a WoW guest.</summary>
        IMAGE_FILE_MACHINE_TARGET_HOST = 0x0001,
        /// <summary>Intel 386.</summary>
        IMAGE_FILE_MACHINE_I386 = 0x014c,
        /// <summary>MIPS little-endian, 0x160 big-endian</summary>
        IMAGE_FILE_MACHINE_R3000 = 0x0162,
        /// <summary>MIPS little-endian</summary>
        IMAGE_FILE_MACHINE_R4000 = 0x0166,
        /// <summary>MIPS little-endian</summary>
        IMAGE_FILE_MACHINE_R10000 = 0x0168,
        /// <summary>MIPS little-endian WCE v2</summary>
        IMAGE_FILE_MACHINE_WCEMIPSV2 = 0x0169,
        /// <summary>Alpha_AXP</summary>
        IMAGE_FILE_MACHINE_ALPHA = 0x0184,
        /// <summary>SH3 little-endian</summary>
        IMAGE_FILE_MACHINE_SH3 = 0x01a2,
        /// <summary></summary>
        IMAGE_FILE_MACHINE_SH3DSP = 0x01a3,
        /// <summary>SH3E little-endian</summary>
        IMAGE_FILE_MACHINE_SH3E = 0x01a4,
        /// <summary>SH4 little-endian</summary>
        IMAGE_FILE_MACHINE_SH4 = 0x01a6,
        /// <summary>SH5</summary>
        IMAGE_FILE_MACHINE_SH5 = 0x01a8,
        /// <summary>ARM Little-Endian</summary>
        IMAGE_FILE_MACHINE_ARM = 0x01c0,
        /// <summary>ARM Thumb/Thumb-2 Little-Endian</summary>
        IMAGE_FILE_MACHINE_THUMB = 0x01c2,
        /// <summary>ARM Thumb-2 Little-Endian</summary>
        IMAGE_FILE_MACHINE_ARMNT = 0x01c4,
        /// <summary></summary>
        IMAGE_FILE_MACHINE_AM33 = 0x01d3,
        /// <summary>IBM PowerPC Little-Endian</summary>
        IMAGE_FILE_MACHINE_POWERPC = 0x01F0,
        /// <summary></summary>
        IMAGE_FILE_MACHINE_POWERPCFP = 0x01f1,
        /// <summary>Intel 64</summary>
        IMAGE_FILE_MACHINE_IA64 = 0x0200,
        /// <summary>MIPS</summary>
        IMAGE_FILE_MACHINE_MIPS16 = 0x0266,
        /// <summary>ALPHA64</summary>
        IMAGE_FILE_MACHINE_ALPHA64 = 0x0284,
        /// <summary>MIPS</summary>
        IMAGE_FILE_MACHINE_MIPSFPU = 0x0366,
        /// <summary>MIPS</summary>
        IMAGE_FILE_MACHINE_MIPSFPU16 = 0x0466,
        /// <summary></summary>
        IMAGE_FILE_MACHINE_AXP64 = IMAGE_FILE_MACHINE_ALPHA64,
        /// <summary>Infineon</summary>
        IMAGE_FILE_MACHINE_TRICORE = 0x0520,
        /// <summary></summary>
        IMAGE_FILE_MACHINE_CEF = 0x0CEF,
        /// <summary>EFI Byte Code</summary>
        IMAGE_FILE_MACHINE_EBC = 0x0EBC,
        /// <summary>AMD64 (K8)</summary>
        IMAGE_FILE_MACHINE_AMD64 = 0x8664,
        /// <summary>M32R little-endian</summary>
        IMAGE_FILE_MACHINE_M32R = 0x9041,
        /// <summary>ARM64 Little-Endian</summary>
        IMAGE_FILE_MACHINE_ARM64 = 0xAA64,
        /// <summary></summary>
        IMAGE_FILE_MACHINE_CEE = 0xC0EE,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
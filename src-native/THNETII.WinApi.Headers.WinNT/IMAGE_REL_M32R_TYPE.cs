using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// The following relocation type indicators are defined for the Mitsubishi M32R processors.
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_M32R_TYPE : short
    {
        /// <summary>The relocation is ignored. </summary>
        IMAGE_REL_M32R_ABSOLUTE = WinNTConstants.IMAGE_REL_M32R_ABSOLUTE,
        /// <summary>The target's 32-bit VA. </summary>
        IMAGE_REL_M32R_ADDR32 = WinNTConstants.IMAGE_REL_M32R_ADDR32,
        /// <summary>The target's 32-bit RVA. </summary>
        IMAGE_REL_M32R_ADDR32NB = WinNTConstants.IMAGE_REL_M32R_ADDR32NB,
        /// <summary>The target's 24-bit VA. </summary>
        IMAGE_REL_M32R_ADDR24 = WinNTConstants.IMAGE_REL_M32R_ADDR24,
        /// <summary>The target's 16-bit offset from the GP register. </summary>
        IMAGE_REL_M32R_GPREL16 = WinNTConstants.IMAGE_REL_M32R_GPREL16,
        /// <summary>The target's 24-bit offset from the program counter (PC), shifted left by 2 bits and sign-extended </summary>
        IMAGE_REL_M32R_PCREL24 = WinNTConstants.IMAGE_REL_M32R_PCREL24,
        /// <summary>The target's 16-bit offset from the PC, shifted left by 2 bits and sign-extended </summary>
        IMAGE_REL_M32R_PCREL16 = WinNTConstants.IMAGE_REL_M32R_PCREL16,
        /// <summary>The target's 8-bit offset from the PC, shifted left by 2 bits and sign-extended </summary>
        IMAGE_REL_M32R_PCREL8 = WinNTConstants.IMAGE_REL_M32R_PCREL8,
        /// <summary>The 16 MSBs of the target VA. </summary>
        IMAGE_REL_M32R_REFHALF = WinNTConstants.IMAGE_REL_M32R_REFHALF,
        /// <summary>The 16 MSBs of the target VA, adjusted for LSB sign extension. This is used for the first instruction in a two-instruction sequence that loads a full 32-bit address. This relocation must be immediately followed by a PAIR relocation whose SymbolTableIndex contains a signed 16-bit displacement that is added to the upper 16 bits that are taken from the location that is being relocated. </summary>
        IMAGE_REL_M32R_REFHI = WinNTConstants.IMAGE_REL_M32R_REFHI,
        /// <summary>The 16 LSBs of the target VA. </summary>
        IMAGE_REL_M32R_REFLO = WinNTConstants.IMAGE_REL_M32R_REFLO,
        /// <summary>The relocation must follow the REFHI relocation. Its SymbolTableIndex contains a displacement and not an index into the symbol table. </summary>
        IMAGE_REL_M32R_PAIR = WinNTConstants.IMAGE_REL_M32R_PAIR,
        /// <summary>The 16-bit section index of the section that contains the target. This is used to support debugging information. </summary>
        IMAGE_REL_M32R_SECTION = WinNTConstants.IMAGE_REL_M32R_SECTION,
        /// <summary>The 32-bit offset of the target from the beginning of its section. This is used to support debugging information and static thread local storage. </summary>
        IMAGE_REL_M32R_SECREL32 = WinNTConstants.IMAGE_REL_M32R_SECREL32,
        /// <summary>The CLR token. </summary>
        IMAGE_REL_M32R_TOKEN = WinNTConstants.IMAGE_REL_M32R_TOKEN,
    }
}

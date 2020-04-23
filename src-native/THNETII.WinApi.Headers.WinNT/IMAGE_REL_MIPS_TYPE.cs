using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// The following relocation type indicators are defined for MIPS processors.
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_MIPS_TYPE : short
    {
        /// <summary>The relocation is ignored. </summary>
        IMAGE_REL_MIPS_ABSOLUTE = WinNTConstants.IMAGE_REL_MIPS_ABSOLUTE,
        /// <summary>The high 16 bits of the target's 32-bit VA. </summary>
        IMAGE_REL_MIPS_REFHALF = WinNTConstants.IMAGE_REL_MIPS_REFHALF,
        /// <summary>The target's 32-bit VA. </summary>
        IMAGE_REL_MIPS_REFWORD = WinNTConstants.IMAGE_REL_MIPS_REFWORD,
        /// <summary>The low 26 bits of the target's VA. This supports the MIPS J and JAL instructions. </summary>
        IMAGE_REL_MIPS_JMPADDR = WinNTConstants.IMAGE_REL_MIPS_JMPADDR,
        /// <summary>The high 16 bits of the target's 32-bit VA. This is used for the first instruction in a two-instruction sequence that loads a full address. This relocation must be immediately followed by a PAIR relocation whose SymbolTableIndex contains a signed 16-bit displacement that is added to the upper 16 bits that are taken from the location that is being relocated. </summary>
        IMAGE_REL_MIPS_REFHI = WinNTConstants.IMAGE_REL_MIPS_REFHI,
        /// <summary>The low 16 bits of the target's VA. </summary>
        IMAGE_REL_MIPS_REFLO = WinNTConstants.IMAGE_REL_MIPS_REFLO,
        /// <summary>A 16-bit signed displacement of the target relative to the GP register. </summary>
        IMAGE_REL_MIPS_GPREL = WinNTConstants.IMAGE_REL_MIPS_GPREL,
        /// <summary>The same as <see cref="IMAGE_REL_MIPS_GPREL"/>. </summary>
        IMAGE_REL_MIPS_LITERAL = WinNTConstants.IMAGE_REL_MIPS_LITERAL,
        /// <summary>The 16-bit section index of the section contains the target. This is used to support debugging information. </summary>
        IMAGE_REL_MIPS_SECTION = WinNTConstants.IMAGE_REL_MIPS_SECTION,
        /// <summary>The 32-bit offset of the target from the beginning of its section. This is used to support debugging information and static thread local storage. </summary>
        IMAGE_REL_MIPS_SECREL = WinNTConstants.IMAGE_REL_MIPS_SECREL,
        /// <summary>The low 16 bits of the 32-bit offset of the target from the beginning of its section. </summary>
        IMAGE_REL_MIPS_SECRELLO = WinNTConstants.IMAGE_REL_MIPS_SECRELLO,
        /// <summary>The high 16 bits of the 32-bit offset of the target from the beginning of its section. An IMAGE_REL_MIPS_PAIR relocation must immediately follow this one. The SymbolTableIndex of the PAIR relocation contains a signed 16-bit displacement that is added to the upper 16 bits that are taken from the location that is being relocated. </summary>
        IMAGE_REL_MIPS_SECRELHI = WinNTConstants.IMAGE_REL_MIPS_SECRELHI,
        IMAGE_REL_MIPS_TOKEN = WinNTConstants.IMAGE_REL_MIPS_TOKEN,
        /// <summary>The low 26 bits of the target's VA. This supports the MIPS16 JAL instruction. </summary>
        IMAGE_REL_MIPS_JMPADDR16 = WinNTConstants.IMAGE_REL_MIPS_JMPADDR16,
        /// <summary>The target's 32-bit RVA. </summary>
        IMAGE_REL_MIPS_REFWORDNB = WinNTConstants.IMAGE_REL_MIPS_REFWORDNB,
        /// <summary>The relocation is valid only when it immediately follows a REFHI or SECRELHI relocation. Its SymbolTableIndex contains a displacement and not an index into the symbol table. </summary>
        IMAGE_REL_MIPS_PAIR = WinNTConstants.IMAGE_REL_MIPS_PAIR,
    }
}

using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// The following relocation type indicators are defined for PowerPC processors.
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_PPC_TYPE : short
    {
        /// <summary>The relocation is ignored. </summary>
        IMAGE_REL_PPC_ABSOLUTE = WinNTConstants.IMAGE_REL_PPC_ABSOLUTE,
        /// <summary>The 64-bit VA of the target. </summary>
        IMAGE_REL_PPC_ADDR64 = WinNTConstants.IMAGE_REL_PPC_ADDR64,
        /// <summary>The 32-bit VA of the target. </summary>
        IMAGE_REL_PPC_ADDR32 = WinNTConstants.IMAGE_REL_PPC_ADDR32,
        /// <summary>The low 24 bits of the VA of the target. This is valid only when the target symbol is absolute and can be sign-extended to its original value. </summary>
        IMAGE_REL_PPC_ADDR24 = WinNTConstants.IMAGE_REL_PPC_ADDR24,
        /// <summary>The low 16 bits of the target's VA. </summary>
        IMAGE_REL_PPC_ADDR16 = WinNTConstants.IMAGE_REL_PPC_ADDR16,
        /// <summary>The low 14 bits of the target's VA. This is valid only when the target symbol is absolute and can be sign-extended to its original value. </summary>
        IMAGE_REL_PPC_ADDR14 = WinNTConstants.IMAGE_REL_PPC_ADDR14,
        /// <summary>A 24-bit PC-relative offset to the symbol's location. </summary>
        IMAGE_REL_PPC_REL24 = WinNTConstants.IMAGE_REL_PPC_REL24,
        /// <summary>A 14-bit PC-relative offset to the symbol's location. </summary>
        IMAGE_REL_PPC_REL14 = WinNTConstants.IMAGE_REL_PPC_REL14,
        IMAGE_REL_PPC_TOCREL16 = WinNTConstants.IMAGE_REL_PPC_TOCREL16,
        IMAGE_REL_PPC_TOCREL14 = WinNTConstants.IMAGE_REL_PPC_TOCREL14,

        /// <summary>The 32-bit RVA of the target. </summary>
        IMAGE_REL_PPC_ADDR32NB = WinNTConstants.IMAGE_REL_PPC_ADDR32NB,
        /// <summary>The 32-bit offset of the target from the beginning of its section. This is used to support debugging information and static thread local storage. </summary>
        IMAGE_REL_PPC_SECREL = WinNTConstants.IMAGE_REL_PPC_SECREL,
        /// <summary>The 16-bit section index of the section that contains the target. This is used to support debugging information. </summary>
        IMAGE_REL_PPC_SECTION = WinNTConstants.IMAGE_REL_PPC_SECTION,
        IMAGE_REL_PPC_IFGLUE = WinNTConstants.IMAGE_REL_PPC_IFGLUE,
        IMAGE_REL_PPC_IMGLUE = WinNTConstants.IMAGE_REL_PPC_IMGLUE,
        /// <summary>The 16-bit offset of the target from the beginning of its section. This is used to support debugging information and static thread local storage. </summary>
        IMAGE_REL_PPC_SECREL16 = WinNTConstants.IMAGE_REL_PPC_SECREL16,
        /// <summary>The high 16 bits of the target's 32-bit VA. This is used for the first instruction in a two-instruction sequence that loads a full address. This relocation must be immediately followed by a PAIR relocation whose SymbolTableIndex contains a signed 16-bit displacement that is added to the upper 16 bits that was taken from the location that is being relocated. </summary>
        IMAGE_REL_PPC_REFHI = WinNTConstants.IMAGE_REL_PPC_REFHI,
        /// <summary>The low 16 bits of the target's VA. </summary>
        IMAGE_REL_PPC_REFLO = WinNTConstants.IMAGE_REL_PPC_REFLO,
        /// <summary>A relocation that is valid only when it immediately follows a REFHI or SECRELHI relocation. Its SymbolTableIndex contains a displacement and not an index into the symbol table. </summary>
        IMAGE_REL_PPC_PAIR = WinNTConstants.IMAGE_REL_PPC_PAIR,
        /// <summary>The low 16 bits of the 32-bit offset of the target from the beginning of its section. </summary>
        IMAGE_REL_PPC_SECRELLO = WinNTConstants.IMAGE_REL_PPC_SECRELLO,
        IMAGE_REL_PPC_SECRELHI = WinNTConstants.IMAGE_REL_PPC_SECRELHI,
        /// <summary>The 16-bit signed displacement of the target relative to the GP register. </summary>
        IMAGE_REL_PPC_GPREL = WinNTConstants.IMAGE_REL_PPC_GPREL,
        /// <summary>The CLR token. </summary>
        IMAGE_REL_PPC_TOKEN = WinNTConstants.IMAGE_REL_PPC_TOKEN,

        IMAGE_REL_PPC_TYPEMASK = WinNTConstants.IMAGE_REL_PPC_TYPEMASK,

        // Flag bits in IMAGE_RELOCATION.TYPE

        IMAGE_REL_PPC_NEG = WinNTConstants.IMAGE_REL_PPC_NEG,
        IMAGE_REL_PPC_BRTAKEN = WinNTConstants.IMAGE_REL_PPC_BRTAKEN,
        IMAGE_REL_PPC_BRNTAKEN = WinNTConstants.IMAGE_REL_PPC_BRNTAKEN,
        IMAGE_REL_PPC_TOCDEFN = WinNTConstants.IMAGE_REL_PPC_TOCDEFN,
    }
}

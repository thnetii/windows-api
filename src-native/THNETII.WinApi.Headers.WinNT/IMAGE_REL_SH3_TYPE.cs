using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// The following relocation type indicators are defined for SH3 and SH4 processors. SH5-specific relocations are noted as SHM (SH Media).
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_SH3_TYPE : short
    {
        /// <summary>The relocation is ignored. </summary>
        IMAGE_REL_SH3_ABSOLUTE = WinNTConstants.IMAGE_REL_SH3_ABSOLUTE,
        /// <summary>A reference to the 16-bit location that contains the VA of the target symbol. </summary>
        IMAGE_REL_SH3_DIRECT16 = WinNTConstants.IMAGE_REL_SH3_DIRECT16,
        /// <summary>The 32-bit VA of the target symbol. </summary>
        IMAGE_REL_SH3_DIRECT32 = WinNTConstants.IMAGE_REL_SH3_DIRECT32,
        /// <summary>A reference to the 8-bit location that contains the VA of the target symbol. </summary>
        IMAGE_REL_SH3_DIRECT8 = WinNTConstants.IMAGE_REL_SH3_DIRECT8,
        /// <summary>A reference to the 8-bit instruction that contains the effective 16-bit VA of the target symbol. </summary>
        IMAGE_REL_SH3_DIRECT8_WORD = WinNTConstants.IMAGE_REL_SH3_DIRECT8_WORD,
        /// <summary>A reference to the 8-bit instruction that contains the effective 32-bit VA of the target symbol. </summary>
        IMAGE_REL_SH3_DIRECT8_LONG = WinNTConstants.IMAGE_REL_SH3_DIRECT8_LONG,
        /// <summary>A reference to the 8-bit location whose low 4 bits contain the VA of the target symbol. </summary>
        IMAGE_REL_SH3_DIRECT4 = WinNTConstants.IMAGE_REL_SH3_DIRECT4,
        /// <summary>A reference to the 8-bit instruction whose low 4 bits contain the effective 16-bit VA of the target symbol. </summary>
        IMAGE_REL_SH3_DIRECT4_WORD = WinNTConstants.IMAGE_REL_SH3_DIRECT4_WORD,
        /// <summary>A reference to the 8-bit instruction whose low 4 bits contain the effective 32-bit VA of the target symbol. </summary>
        IMAGE_REL_SH3_DIRECT4_LONG = WinNTConstants.IMAGE_REL_SH3_DIRECT4_LONG,
        /// <summary>A reference to the 8-bit instruction that contains the effective 16-bit relative offset of the target symbol. </summary>
        IMAGE_REL_SH3_PCREL8_WORD = WinNTConstants.IMAGE_REL_SH3_PCREL8_WORD,
        /// <summary>A reference to the 8-bit instruction that contains the effective 32-bit relative offset of the target symbol. </summary>
        IMAGE_REL_SH3_PCREL8_LONG = WinNTConstants.IMAGE_REL_SH3_PCREL8_LONG,
        /// <summary>A reference to the 16-bit instruction whose low 12 bits contain the effective 16-bit relative offset of the target symbol. </summary>
        IMAGE_REL_SH3_PCREL12_WORD = WinNTConstants.IMAGE_REL_SH3_PCREL12_WORD,
        /// <summary>A reference to a 32-bit location that is the VA of the section that contains the target symbol. </summary>
        IMAGE_REL_SH3_STARTOF_SECTION = WinNTConstants.IMAGE_REL_SH3_STARTOF_SECTION,
        /// <summary>A reference to the 32-bit location that is the size of the section that contains the target symbol. </summary>
        IMAGE_REL_SH3_SIZEOF_SECTION = WinNTConstants.IMAGE_REL_SH3_SIZEOF_SECTION,
        /// <summary>The 16-bit section index of the section that contains the target. This is used to support debugging information. </summary>
        IMAGE_REL_SH3_SECTION = WinNTConstants.IMAGE_REL_SH3_SECTION,
        /// <summary>The 32-bit offset of the target from the beginning of its section. This is used to support debugging information and static thread local storage. </summary>
        IMAGE_REL_SH3_SECREL = WinNTConstants.IMAGE_REL_SH3_SECREL,
        /// <summary>The 32-bit RVA of the target symbol. </summary>
        IMAGE_REL_SH3_DIRECT32_NB = WinNTConstants.IMAGE_REL_SH3_DIRECT32_NB,
        /// <summary>GP relative. </summary>
        IMAGE_REL_SH3_GPREL4_LONG = WinNTConstants.IMAGE_REL_SH3_GPREL4_LONG,
        /// <summary>CLR token. </summary>
        IMAGE_REL_SH3_TOKEN = WinNTConstants.IMAGE_REL_SH3_TOKEN,
        /// <summary>The offset from the current instruction in longwords. If the NOMODE bit is not set, insert the inverse of the low bit at bit 32 to select PTA or PTB. </summary>
        IMAGE_REL_SHM_PCRELPT = WinNTConstants.IMAGE_REL_SHM_PCRELPT,
        /// <summary>The low 16 bits of the 32-bit address. </summary>
        IMAGE_REL_SHM_REFLO = WinNTConstants.IMAGE_REL_SHM_REFLO,
        /// <summary>The high 16 bits of the 32-bit address. </summary>
        IMAGE_REL_SHM_REFHALF = WinNTConstants.IMAGE_REL_SHM_REFHALF,
        /// <summary>The low 16 bits of the relative address. </summary>
        IMAGE_REL_SHM_RELLO = WinNTConstants.IMAGE_REL_SHM_RELLO,
        /// <summary>The high 16 bits of the relative address. </summary>
        IMAGE_REL_SHM_RELHALF = WinNTConstants.IMAGE_REL_SHM_RELHALF,
        /// <summary>The relocation is valid only when it immediately follows a REFHALF, RELHALF, or RELLO relocation. The SymbolTableIndex field of the relocation contains a displacement and not an index into the symbol table. </summary>
        IMAGE_REL_SHM_PAIR = WinNTConstants.IMAGE_REL_SHM_PAIR,

        /// <summary>The relocation ignores section mode. </summary>
        IMAGE_REL_SH_NOMODE = WinNTConstants.IMAGE_REL_SH_NOMODE,
    }
}

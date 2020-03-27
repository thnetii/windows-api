using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// The following relocation type indicators are defined for ARM64 processors.
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_ARM64_TYPE : short
    {
        /// <summary>The relocation is ignored. </summary>
        IMAGE_REL_ARM64_ABSOLUTE = WinNTConstants.IMAGE_REL_ARM64_ABSOLUTE,
        /// <summary>The 32-bit VA of the target. </summary>
        IMAGE_REL_ARM64_ADDR32 = WinNTConstants.IMAGE_REL_ARM64_ADDR32,
        /// <summary>The 32-bit RVA of the target. </summary>
        IMAGE_REL_ARM64_ADDR32NB = WinNTConstants.IMAGE_REL_ARM64_ADDR32NB,
        /// <summary>The 26-bit relative displacement to the target, for B and BL instructions. </summary>
        IMAGE_REL_ARM64_BRANCH26 = WinNTConstants.IMAGE_REL_ARM64_BRANCH26,
        /// <summary>The page base of the target, for ADRP instruction. </summary>
        IMAGE_REL_ARM64_PAGEBASE_REL21 = WinNTConstants.IMAGE_REL_ARM64_PAGEBASE_REL21,
        /// <summary>The 12-bit relative displacement to the target, for instruction ADR </summary>
        IMAGE_REL_ARM64_REL21 = WinNTConstants.IMAGE_REL_ARM64_REL21,
        /// <summary>The 12-bit page offset of the target, for instructions ADD/ADDS (immediate) with zero shift. </summary>
        IMAGE_REL_ARM64_PAGEOFFSET_12A = WinNTConstants.IMAGE_REL_ARM64_PAGEOFFSET_12A,
        /// <summary>The 12-bit page offset of the target, for instruction LDR (indexed, unsigned immediate). </summary>
        IMAGE_REL_ARM64_PAGEOFFSET_12L = WinNTConstants.IMAGE_REL_ARM64_PAGEOFFSET_12L,
        /// <summary>The 32-bit offset of the target from the beginning of its section. This is used to support debugging information and static thread local storage. </summary>
        IMAGE_REL_ARM64_SECREL = WinNTConstants.IMAGE_REL_ARM64_SECREL,
        /// <summary>Bit 0:11 of section offset of the target, for instructions ADD/ADDS (immediate) with zero shift. </summary>
        IMAGE_REL_ARM64_SECREL_LOW12A = WinNTConstants.IMAGE_REL_ARM64_SECREL_LOW12A,
        /// <summary>Bit 12:23 of section offset of the target, for instructions ADD/ADDS (immediate) with zero shift. </summary>
        IMAGE_REL_ARM64_SECREL_HIGH12A = WinNTConstants.IMAGE_REL_ARM64_SECREL_HIGH12A,
        /// <summary>Bit 0:11 of section offset of the target, for instruction LDR (indexed, unsigned immediate). </summary>
        IMAGE_REL_ARM64_SECREL_LOW12L = WinNTConstants.IMAGE_REL_ARM64_SECREL_LOW12L,
        /// <summary>CLR token. </summary>
        IMAGE_REL_ARM64_TOKEN = WinNTConstants.IMAGE_REL_ARM64_TOKEN,
        /// <summary>The 16-bit section index of the section that contains the target. This is used to support debugging information. </summary>
        IMAGE_REL_ARM64_SECTION = WinNTConstants.IMAGE_REL_ARM64_SECTION,
        /// <summary>The 64-bit VA of the relocation target. </summary>
        IMAGE_REL_ARM64_ADDR64 = WinNTConstants.IMAGE_REL_ARM64_ADDR64,
        /// <summary>The 19-bit offset to the relocation target, for conditional B instruction. </summary>
        IMAGE_REL_ARM64_BRANCH19 = WinNTConstants.IMAGE_REL_ARM64_BRANCH19,
    }
}

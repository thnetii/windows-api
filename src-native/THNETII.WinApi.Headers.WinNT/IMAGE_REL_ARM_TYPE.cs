using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// The following relocation type indicators are defined for ARM processors.
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_ARM_TYPE : short
    {
        /// <summary>The relocation is ignored. </summary>
        IMAGE_REL_ARM_ABSOLUTE = WinNTConstants.IMAGE_REL_ARM_ABSOLUTE,
        /// <summary>The 32-bit VA of the target. </summary>
        IMAGE_REL_ARM_ADDR32 = WinNTConstants.IMAGE_REL_ARM_ADDR32,
        /// <summary>The 32-bit RVA of the target. </summary>
        IMAGE_REL_ARM_ADDR32NB = WinNTConstants.IMAGE_REL_ARM_ADDR32NB,
        /// <summary>The 24-bit relative displacement to the target. </summary>
        IMAGE_REL_ARM_BRANCH24 = WinNTConstants.IMAGE_REL_ARM_BRANCH24,
        /// <summary>The reference to a subroutine call. The reference consists of two 16-bit instructions with 11-bit offsets. </summary>
        IMAGE_REL_ARM_BRANCH11 = WinNTConstants.IMAGE_REL_ARM_BRANCH11,
        IMAGE_REL_ARM_TOKEN = WinNTConstants.IMAGE_REL_ARM_TOKEN,
        IMAGE_REL_ARM_GPREL12 = WinNTConstants.IMAGE_REL_ARM_GPREL12,
        IMAGE_REL_ARM_GPREL7 = WinNTConstants.IMAGE_REL_ARM_GPREL7,
        IMAGE_REL_ARM_BLX24 = WinNTConstants.IMAGE_REL_ARM_BLX24,
        IMAGE_REL_ARM_BLX11 = WinNTConstants.IMAGE_REL_ARM_BLX11,
        /// <summary>The 16-bit section index of the section that contains the target. This is used to support debugging information. </summary>
        IMAGE_REL_ARM_SECTION = WinNTConstants.IMAGE_REL_ARM_SECTION,
        /// <summary>The 32-bit offset of the target from the beginning of its section. This is used to support debugging information and static thread local storage. </summary>
        IMAGE_REL_ARM_SECREL = WinNTConstants.IMAGE_REL_ARM_SECREL,
        IMAGE_REL_ARM_MOV32A = WinNTConstants.IMAGE_REL_ARM_MOV32A,
        /// <summary>The 32-bit VA of the target. This relocation is applied using a MOVW instruction for the low 16 bits followed by a MOVT for the high 16 bits. </summary>
        IMAGE_REL_ARM_MOV32 = WinNTConstants.IMAGE_REL_ARM_MOV32,
        IMAGE_REL_ARM_MOV32T = WinNTConstants.IMAGE_REL_ARM_MOV32T,
        /// <summary>The 32-bit VA of the target. This relocation is applied using a MOVW instruction for the low 16 bits followed by a MOVT for the high 16 bits. </summary>
        IMAGE_REL_THUMB_MOV32 = WinNTConstants.IMAGE_REL_THUMB_MOV32,
        IMAGE_REL_ARM_BRANCH20T = WinNTConstants.IMAGE_REL_ARM_BRANCH20T,
        /// <summary>The instruction is fixed up with the 21-bit relative displacement to the 2-byte aligned target. The least significant bit of the displacement is always zero and is not stored. This relocation corresponds to a Thumb-2 32-bit conditional B instruction. </summary>
        IMAGE_REL_THUMB_BRANCH20 = WinNTConstants.IMAGE_REL_THUMB_BRANCH20,
        IMAGE_REL_ARM_BRANCH24T = WinNTConstants.IMAGE_REL_ARM_BRANCH24T,
        /// <summary>The instruction is fixed up with the 25-bit relative displacement to the 2-byte aligned target. The least significant bit of the displacement is zero and is not stored.This relocation corresponds to a Thumb-2 B instruction. </summary>
        IMAGE_REL_THUMB_BRANCH24 = WinNTConstants.IMAGE_REL_THUMB_BRANCH24,
        /// <summary>Thumb: BLX immediate</summary>
        IMAGE_REL_ARM_BLX23T = WinNTConstants.IMAGE_REL_ARM_BLX23T,
        /// <summary>
        /// <para>The instruction is fixed up with the 25-bit relative displacement to the 4-byte aligned target. The low 2 bits of the displacement are zero and are not stored.</para>
        /// <para>This relocation corresponds to a Thumb-2 BLX instruction.</para>
        /// </summary>
        IMAGE_REL_THUMB_BLX23 = WinNTConstants.IMAGE_REL_THUMB_BLX23,
    }
}

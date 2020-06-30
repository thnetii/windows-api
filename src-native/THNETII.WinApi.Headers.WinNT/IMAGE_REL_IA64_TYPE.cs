using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// The following relocation type indicators are defined for the Intel Itanium processor family and compatible processors. Note that relocations on instructions use the bundle's offset and slot number for the relocation offset.
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_IA64_TYPE : short
    {
        /// <summary>The relocation is ignored. </summary>
        IMAGE_REL_IA64_ABSOLUTE = WinNTConstants.IMAGE_REL_IA64_ABSOLUTE,
        /// <summary>The instruction relocation can be followed by an ADDEND relocation whose value is added to the target address before it is inserted into the specified slot in the IMM14 bundle. The relocation target must be absolute or the image must be fixed. </summary>
        IMAGE_REL_IA64_IMM14 = WinNTConstants.IMAGE_REL_IA64_IMM14,
        /// <summary>The instruction relocation can be followed by an ADDEND relocation whose value is added to the target address before it is inserted into the specified slot in the IMM22 bundle. The relocation target must be absolute or the image must be fixed. </summary>
        IMAGE_REL_IA64_IMM22 = WinNTConstants.IMAGE_REL_IA64_IMM22,
        /// <summary>The slot number of this relocation must be one (1). The relocation can be followed by an ADDEND relocation whose value is added to the target address before it is stored in all three slots of the IMM64 bundle. </summary>
        IMAGE_REL_IA64_IMM64 = WinNTConstants.IMAGE_REL_IA64_IMM64,
        /// <summary>The target's 32-bit VA. This is supported only for /LARGEADDRESSAWARE:NO images. </summary>
        IMAGE_REL_IA64_DIR32 = WinNTConstants.IMAGE_REL_IA64_DIR32,
        /// <summary>The target's 64-bit VA. </summary>
        IMAGE_REL_IA64_DIR64 = WinNTConstants.IMAGE_REL_IA64_DIR64,
        /// <summary>The instruction is fixed up with the 25-bit relative displacement to the 16-bit aligned target. The low 4 bits of the displacement are zero and are not stored. </summary>
        IMAGE_REL_IA64_PCREL21B = WinNTConstants.IMAGE_REL_IA64_PCREL21B,
        /// <summary>The instruction is fixed up with the 25-bit relative displacement to the 16-bit aligned target. The low 4 bits of the displacement, which are zero, are not stored. </summary>
        IMAGE_REL_IA64_PCREL21M = WinNTConstants.IMAGE_REL_IA64_PCREL21M,
        /// <summary>The LSBs of this relocation's offset must contain the slot number whereas the rest is the bundle address. The bundle is fixed up with the 25-bit relative displacement to the 16-bit aligned target. The low 4 bits of the displacement are zero and are not stored. </summary>
        IMAGE_REL_IA64_PCREL21F = WinNTConstants.IMAGE_REL_IA64_PCREL21F,
        /// <summary>The instruction relocation can be followed by an ADDEND relocation whose value is added to the target address and then a 22-bit GP-relative offset that is calculated and applied to the GPREL22 bundle. </summary>
        IMAGE_REL_IA64_GPREL22 = WinNTConstants.IMAGE_REL_IA64_GPREL22,
        /// <summary>The instruction is fixed up with the 22-bit GP-relative offset to the target symbol's literal table entry. The linker creates this literal table entry based on this relocation and the ADDEND relocation that might follow. </summary>
        IMAGE_REL_IA64_LTOFF22 = WinNTConstants.IMAGE_REL_IA64_LTOFF22,
        /// <summary>The 16-bit section index of the section contains the target. This is used to support debugging information. </summary>
        IMAGE_REL_IA64_SECTION = WinNTConstants.IMAGE_REL_IA64_SECTION,
        /// <summary>The instruction is fixed up with the 22-bit offset of the target from the beginning of its section. This relocation can be followed immediately by an ADDEND relocation, whose Value field contains the 32-bit unsigned offset of the target from the beginning of the section. </summary>
        IMAGE_REL_IA64_SECREL22 = WinNTConstants.IMAGE_REL_IA64_SECREL22,
        /// <summary>The slot number for this relocation must be one (1). The instruction is fixed up with the 64-bit offset of the target from the beginning of its section. This relocation can be followed immediately by an ADDEND relocation whose Value field contains the 32-bit unsigned offset of the target from the beginning of the section. </summary>
        IMAGE_REL_IA64_SECREL64I = WinNTConstants.IMAGE_REL_IA64_SECREL64I,
        /// <summary>The address of data to be fixed up with the 32-bit offset of the target from the beginning of its section. </summary>
        IMAGE_REL_IA64_SECREL32 = WinNTConstants.IMAGE_REL_IA64_SECREL32,
        //
        /// <summary>The target's 32-bit RVA. </summary>
        IMAGE_REL_IA64_DIR32NB = WinNTConstants.IMAGE_REL_IA64_DIR32NB,
        /// <summary>This is applied to a signed 14-bit immediate that contains the difference between two relocatable targets. This is a declarative field for the linker that indicates that the compiler has already emitted this value. </summary>
        IMAGE_REL_IA64_SREL14 = WinNTConstants.IMAGE_REL_IA64_SREL14,
        /// <summary>This is applied to a signed 22-bit immediate that contains the difference between two relocatable targets. This is a declarative field for the linker that indicates that the compiler has already emitted this value. </summary>
        IMAGE_REL_IA64_SREL22 = WinNTConstants.IMAGE_REL_IA64_SREL22,
        /// <summary>This is applied to a signed 32-bit immediate that contains the difference between two relocatable values. This is a declarative field for the linker that indicates that the compiler has already emitted this value. </summary>
        IMAGE_REL_IA64_SREL32 = WinNTConstants.IMAGE_REL_IA64_SREL32,
        /// <summary>This is applied to an unsigned 32-bit immediate that contains the difference between two relocatable values. This is a declarative field for the linker that indicates that the compiler has already emitted this value. </summary>
        IMAGE_REL_IA64_UREL32 = WinNTConstants.IMAGE_REL_IA64_UREL32,
        /// <summary>A 60-bit PC-relative fixup that always stays as a BRL instruction of an MLX bundle. </summary>
        IMAGE_REL_IA64_PCREL60X = WinNTConstants.IMAGE_REL_IA64_PCREL60X,
        /// <summary>A 60-bit PC-relative fixup. If the target displacement fits in a signed 25-bit field, convert the entire bundle to an MBB bundle with NOP.B in slot 1 and a 25-bit BR instruction (with the 4 lowest bits all zero and dropped) in slot 2. </summary>
        IMAGE_REL_IA64_PCREL60B = WinNTConstants.IMAGE_REL_IA64_PCREL60B,
        /// <summary>A 60-bit PC-relative fixup. If the target displacement fits in a signed 25-bit field, convert the entire bundle to an MFB bundle with NOP.F in slot 1 and a 25-bit (4 lowest bits all zero and dropped) BR instruction in slot 2. </summary>
        IMAGE_REL_IA64_PCREL60F = WinNTConstants.IMAGE_REL_IA64_PCREL60F,
        /// <summary>A 60-bit PC-relative fixup. If the target displacement fits in a signed 25-bit field, convert the entire bundle to an MIB bundle with NOP.I in slot 1 and a 25-bit (4 lowest bits all zero and dropped) BR instruction in slot 2. </summary>
        IMAGE_REL_IA64_PCREL60I = WinNTConstants.IMAGE_REL_IA64_PCREL60I,
        /// <summary>A 60-bit PC-relative fixup. If the target displacement fits in a signed 25-bit field, convert the entire bundle to an MMB bundle with NOP.M in slot 1 and a 25-bit (4 lowest bits all zero and dropped) BR instruction in slot 2. </summary>
        IMAGE_REL_IA64_PCREL60M = WinNTConstants.IMAGE_REL_IA64_PCREL60M,
        /// <summary>A 64-bit GP-relative fixup. </summary>
        IMAGE_REL_IA64_IMMGPREL64 = WinNTConstants.IMAGE_REL_IA64_IMMGPREL64,
        /// <summary>A CLR token. </summary>
        IMAGE_REL_IA64_TOKEN = WinNTConstants.IMAGE_REL_IA64_TOKEN,
        /// <summary>A 32-bit GP-relative fixup. </summary>
        IMAGE_REL_IA64_GPREL32 = WinNTConstants.IMAGE_REL_IA64_GPREL32,
        /// <summary>The relocation is valid only when it immediately follows one of the following relocations: IMM14, IMM22, IMM64, GPREL22, LTOFF22, LTOFF64, SECREL22, SECREL64I, or SECREL32. Its value contains the addend to apply to instructions within a bundle, not for data. </summary>
        IMAGE_REL_IA64_ADDEND = WinNTConstants.IMAGE_REL_IA64_ADDEND,
    }
}

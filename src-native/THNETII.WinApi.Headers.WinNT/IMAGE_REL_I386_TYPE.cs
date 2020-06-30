using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// The following relocation type indicators are defined for Intel 386 and compatible processors.
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_I386_TYPE : short
    {
        /// <summary>The relocation is ignored. </summary>
        IMAGE_REL_I386_ABSOLUTE = WinNTConstants.IMAGE_REL_I386_ABSOLUTE,
        /// <summary>Not supported. </summary>
        IMAGE_REL_I386_DIR16 = WinNTConstants.IMAGE_REL_I386_DIR16,
        /// <summary>Not supported. </summary>
        IMAGE_REL_I386_REL16 = WinNTConstants.IMAGE_REL_I386_REL16,
        /// <summary>The target's 32-bit VA. </summary>
        IMAGE_REL_I386_DIR32 = WinNTConstants.IMAGE_REL_I386_DIR32,
        /// <summary>The target's 32-bit RVA. </summary>
        IMAGE_REL_I386_DIR32NB = WinNTConstants.IMAGE_REL_I386_DIR32NB,
        /// <summary>Not supported. </summary>
        IMAGE_REL_I386_SEG12 = WinNTConstants.IMAGE_REL_I386_SEG12,
        /// <summary>The 16-bit section index of the section that contains the target. This is used to support debugging information. </summary>
        IMAGE_REL_I386_SECTION = WinNTConstants.IMAGE_REL_I386_SECTION,
        /// <summary>The 32-bit offset of the target from the beginning of its section. This is used to support debugging information and static thread local storage. </summary>
        IMAGE_REL_I386_SECREL = WinNTConstants.IMAGE_REL_I386_SECREL,
        /// <summary>The CLR token. </summary>
        IMAGE_REL_I386_TOKEN = WinNTConstants.IMAGE_REL_I386_TOKEN,
        /// <summary>A 7-bit offset from the base of the section that contains the target. </summary>
        IMAGE_REL_I386_SECREL7 = WinNTConstants.IMAGE_REL_I386_SECREL7,
        /// <summary>The 32-bit relative displacement to the target. This supports the x86 relative branch and call instructions. </summary>
        IMAGE_REL_I386_REL32 = WinNTConstants.IMAGE_REL_I386_REL32,
    }
}

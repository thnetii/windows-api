using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// The following relocation type indicators are defined for x64 and compatible processors.
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_AMD64_TYPE : short
    {
        /// <summary>The relocation is ignored. </summary>
        IMAGE_REL_AMD64_ABSOLUTE = WinNTConstants.IMAGE_REL_AMD64_ABSOLUTE,
        /// <summary>The 64-bit VA of the relocation target. </summary>
        IMAGE_REL_AMD64_ADDR64 = WinNTConstants.IMAGE_REL_AMD64_ADDR64,
        /// <summary>The 32-bit VA of the relocation target. </summary>
        IMAGE_REL_AMD64_ADDR32 = WinNTConstants.IMAGE_REL_AMD64_ADDR32,
        /// <summary>The 32-bit address without an image base (RVA). </summary>
        IMAGE_REL_AMD64_ADDR32NB = WinNTConstants.IMAGE_REL_AMD64_ADDR32NB,
        /// <summary>The 32-bit relative address from the byte following the relocation. </summary>
        IMAGE_REL_AMD64_REL32 = WinNTConstants.IMAGE_REL_AMD64_REL32,
        /// <summary>The 32-bit address relative to byte distance 1 from the relocation. </summary>
        IMAGE_REL_AMD64_REL32_1 = WinNTConstants.IMAGE_REL_AMD64_REL32_1,
        /// <summary>The 32-bit address relative to byte distance 2 from the relocation. </summary>
        IMAGE_REL_AMD64_REL32_2 = WinNTConstants.IMAGE_REL_AMD64_REL32_2,
        /// <summary>The 32-bit address relative to byte distance 3 from the relocation. </summary>
        IMAGE_REL_AMD64_REL32_3 = WinNTConstants.IMAGE_REL_AMD64_REL32_3,
        /// <summary>The 32-bit address relative to byte distance 4 from the relocation. </summary>
        IMAGE_REL_AMD64_REL32_4 = WinNTConstants.IMAGE_REL_AMD64_REL32_4,
        /// <summary>The 32-bit address relative to byte distance 5 from the relocation. </summary>
        IMAGE_REL_AMD64_REL32_5 = WinNTConstants.IMAGE_REL_AMD64_REL32_5,
        /// <summary>The 16-bit section index of the section that contains the target. This is used to support debugging information. </summary>
        IMAGE_REL_AMD64_SECTION = WinNTConstants.IMAGE_REL_AMD64_SECTION,
        /// <summary>The 32-bit offset of the target from the beginning of its section. This is used to support debugging information and static thread local storage. </summary>
        IMAGE_REL_AMD64_SECREL = WinNTConstants.IMAGE_REL_AMD64_SECREL,
        /// <summary>A 7-bit unsigned offset from the base of the section that contains the target. </summary>
        IMAGE_REL_AMD64_SECREL7 = WinNTConstants.IMAGE_REL_AMD64_SECREL7,
        /// <summary>CLR tokens. </summary>
        IMAGE_REL_AMD64_TOKEN = WinNTConstants.IMAGE_REL_AMD64_TOKEN,
        /// <summary>A 32-bit signed span-dependent value emitted into the object. </summary>
        IMAGE_REL_AMD64_SREL32 = WinNTConstants.IMAGE_REL_AMD64_SREL32,
        /// <summary>A pair that must immediately follow every span-dependent value. </summary>
        IMAGE_REL_AMD64_PAIR = WinNTConstants.IMAGE_REL_AMD64_PAIR,
        /// <summary>A 32-bit signed span-dependent value that is applied at link time. </summary>
        IMAGE_REL_AMD64_SSPAN32 = WinNTConstants.IMAGE_REL_AMD64_SSPAN32,
    }
}

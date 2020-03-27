using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// CEF relocation types.
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_CEF_TYPE : short
    {
        /// <summary>Reference is absolute, no relocation is necessary</summary>
        IMAGE_REL_CEF_ABSOLUTE = WinNTConstants.IMAGE_REL_CEF_ABSOLUTE,
        /// <summary>32-bit address (VA).</summary>
        IMAGE_REL_CEF_ADDR32 = WinNTConstants.IMAGE_REL_CEF_ADDR32,
        /// <summary>64-bit address (VA).</summary>
        IMAGE_REL_CEF_ADDR64 = WinNTConstants.IMAGE_REL_CEF_ADDR64,
        /// <summary>32-bit address w/o image base (RVA).</summary>
        IMAGE_REL_CEF_ADDR32NB = WinNTConstants.IMAGE_REL_CEF_ADDR32NB,
        /// <summary>Section index</summary>
        IMAGE_REL_CEF_SECTION = WinNTConstants.IMAGE_REL_CEF_SECTION,
        /// <summary>32 bit offset from base of section containing target</summary>
        IMAGE_REL_CEF_SECREL = WinNTConstants.IMAGE_REL_CEF_SECREL,
        /// <summary>32 bit metadata token</summary>
        IMAGE_REL_CEF_TOKEN = WinNTConstants.IMAGE_REL_CEF_TOKEN,
    }
}

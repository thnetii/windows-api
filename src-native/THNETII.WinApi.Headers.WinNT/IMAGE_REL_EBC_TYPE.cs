using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_EBC_TYPE : short
    {
        /// <summary>No relocation required</summary>
        IMAGE_REL_EBC_ABSOLUTE = WinNTConstants.IMAGE_REL_EBC_ABSOLUTE,
        /// <summary>32 bit address w/o image base</summary>
        IMAGE_REL_EBC_ADDR32NB = WinNTConstants.IMAGE_REL_EBC_ADDR32NB,
        /// <summary>32-bit relative address from byte following reloc</summary>
        IMAGE_REL_EBC_REL32 = WinNTConstants.IMAGE_REL_EBC_REL32,
        /// <summary>Section table index</summary>
        IMAGE_REL_EBC_SECTION = WinNTConstants.IMAGE_REL_EBC_SECTION,
        /// <summary>Offset within section</summary>
        IMAGE_REL_EBC_SECREL = WinNTConstants.IMAGE_REL_EBC_SECREL,
    }
}

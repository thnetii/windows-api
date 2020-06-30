using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_AM_TYPE : short
    {
        IMAGE_REL_AM_ABSOLUTE = WinNTConstants.IMAGE_REL_AM_ABSOLUTE,
        IMAGE_REL_AM_ADDR32 = WinNTConstants.IMAGE_REL_AM_ADDR32,
        IMAGE_REL_AM_ADDR32NB = WinNTConstants.IMAGE_REL_AM_ADDR32NB,
        IMAGE_REL_AM_CALL32 = WinNTConstants.IMAGE_REL_AM_CALL32,
        IMAGE_REL_AM_FUNCINFO = WinNTConstants.IMAGE_REL_AM_FUNCINFO,
        IMAGE_REL_AM_REL32_1 = WinNTConstants.IMAGE_REL_AM_REL32_1,
        IMAGE_REL_AM_REL32_2 = WinNTConstants.IMAGE_REL_AM_REL32_2,
        IMAGE_REL_AM_SECREL = WinNTConstants.IMAGE_REL_AM_SECREL,
        IMAGE_REL_AM_SECTION = WinNTConstants.IMAGE_REL_AM_SECTION,
        IMAGE_REL_AM_TOKEN = WinNTConstants.IMAGE_REL_AM_TOKEN,
    }
}

using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_I386_TYPE : short
    {
        IMAGE_REL_I386_ABSOLUTE = WinNTConstants.IMAGE_REL_I386_ABSOLUTE,
        IMAGE_REL_I386_DIR16 = WinNTConstants.IMAGE_REL_I386_DIR16,
        IMAGE_REL_I386_REL16 = WinNTConstants.IMAGE_REL_I386_REL16,
        IMAGE_REL_I386_DIR32 = WinNTConstants.IMAGE_REL_I386_DIR32,
        IMAGE_REL_I386_DIR32NB = WinNTConstants.IMAGE_REL_I386_DIR32NB,
        IMAGE_REL_I386_SEG12 = WinNTConstants.IMAGE_REL_I386_SEG12,
        IMAGE_REL_I386_SECTION = WinNTConstants.IMAGE_REL_I386_SECTION,
        IMAGE_REL_I386_SECREL = WinNTConstants.IMAGE_REL_I386_SECREL,
        IMAGE_REL_I386_TOKEN = WinNTConstants.IMAGE_REL_I386_TOKEN,
        IMAGE_REL_I386_SECREL7 = WinNTConstants.IMAGE_REL_I386_SECREL7,
        IMAGE_REL_I386_REL32 = WinNTConstants.IMAGE_REL_I386_REL32,
    }
}

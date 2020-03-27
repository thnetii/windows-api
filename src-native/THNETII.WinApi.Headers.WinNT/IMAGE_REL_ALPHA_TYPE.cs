using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Alpha Relocation types.
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_REL_ALPHA_TYPE : short
    {
        IMAGE_REL_ALPHA_ABSOLUTE = WinNTConstants.IMAGE_REL_ALPHA_ABSOLUTE,
        IMAGE_REL_ALPHA_REFLONG = WinNTConstants.IMAGE_REL_ALPHA_REFLONG,
        IMAGE_REL_ALPHA_REFQUAD = WinNTConstants.IMAGE_REL_ALPHA_REFQUAD,
        IMAGE_REL_ALPHA_GPREL32 = WinNTConstants.IMAGE_REL_ALPHA_GPREL32,
        IMAGE_REL_ALPHA_LITERAL = WinNTConstants.IMAGE_REL_ALPHA_LITERAL,
        IMAGE_REL_ALPHA_LITUSE = WinNTConstants.IMAGE_REL_ALPHA_LITUSE,
        IMAGE_REL_ALPHA_GPDISP = WinNTConstants.IMAGE_REL_ALPHA_GPDISP,
        IMAGE_REL_ALPHA_BRADDR = WinNTConstants.IMAGE_REL_ALPHA_BRADDR,
        IMAGE_REL_ALPHA_HINT = WinNTConstants.IMAGE_REL_ALPHA_HINT,
        IMAGE_REL_ALPHA_INLINE_REFLONG = WinNTConstants.IMAGE_REL_ALPHA_INLINE_REFLONG,
        IMAGE_REL_ALPHA_REFHI = WinNTConstants.IMAGE_REL_ALPHA_REFHI,
        IMAGE_REL_ALPHA_REFLO = WinNTConstants.IMAGE_REL_ALPHA_REFLO,
        IMAGE_REL_ALPHA_PAIR = WinNTConstants.IMAGE_REL_ALPHA_PAIR,
        IMAGE_REL_ALPHA_MATCH = WinNTConstants.IMAGE_REL_ALPHA_MATCH,
        IMAGE_REL_ALPHA_SECTION = WinNTConstants.IMAGE_REL_ALPHA_SECTION,
        IMAGE_REL_ALPHA_SECREL = WinNTConstants.IMAGE_REL_ALPHA_SECREL,
        IMAGE_REL_ALPHA_REFLONGNB = WinNTConstants.IMAGE_REL_ALPHA_REFLONGNB,
        /// <summary>Low 16-bit section relative reference</summary>
        IMAGE_REL_ALPHA_SECRELLO = WinNTConstants.IMAGE_REL_ALPHA_SECRELLO,
        /// <summary>High 16-bit section relative reference</summary>
        IMAGE_REL_ALPHA_SECRELHI = WinNTConstants.IMAGE_REL_ALPHA_SECRELHI,
        /// <summary>High 16 bits of 48 bit reference</summary>
        IMAGE_REL_ALPHA_REFQ3 = WinNTConstants.IMAGE_REL_ALPHA_REFQ3,
        /// <summary>Middle 16 bits of 48 bit reference</summary>
        IMAGE_REL_ALPHA_REFQ2 = WinNTConstants.IMAGE_REL_ALPHA_REFQ2,
        /// <summary>Low 16 bits of 48 bit reference</summary>
        IMAGE_REL_ALPHA_REFQ1 = WinNTConstants.IMAGE_REL_ALPHA_REFQ1,
        /// <summary>Low 16-bit GP relative reference</summary>
        IMAGE_REL_ALPHA_GPRELLO = WinNTConstants.IMAGE_REL_ALPHA_GPRELLO,
        /// <summary>High 16-bit GP relative reference</summary>
        IMAGE_REL_ALPHA_GPRELHI = WinNTConstants.IMAGE_REL_ALPHA_GPRELHI,
    }
}

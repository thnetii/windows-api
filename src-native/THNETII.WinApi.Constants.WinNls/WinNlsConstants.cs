namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h
    ////////////////////////////////////////////////////////////////////////////
    //
    //  Constants
    //
    //  Define all constants for the NLS component here.
    //
    ////////////////////////////////////////////////////////////////////////////

    public static class WinNlsConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 98
        //
        //  String Length Maximums.
        //
        public const int MAX_LEADBYTES = 12;    // 5 ranges, 2 bytes ea., 0 term.
        public const int MAX_DEFAULTCHAR = 2;   // single or double byte

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 104
        //
        //  Surrogate pairs
        //
        //  Conversion examples:
        //
        //  A) The first character in the Surrogate range (D800, DC00) as UTF-32:
        //
        //  1.  D800: binary 1101100000000000  (lower ten bits: 0000000000)
        //  2.  DC00: binary 1101110000000000  (lower ten bits: 0000000000)
        //  3.  Concatenate 0000000000+0000000000 = 0x0000
        //  4.  Add 0x10000
        //
        //  Result: U+10000. This is correct, since the first character in the Supplementary character
        //  range immediately follows the last code point in the 16-bit UTF-16 range (U+FFFF)
        //
        //  B) A UTF-32 code point such as U+2040A (this a CJK character in CJK Extension B), and wish
        //  to convert it in UTF-16:
        //
        //  1.  Subtract 0x10000 - Result: 0x1040A
        //  2.  Split into two ten-bit pieces: 0001000001 0000001010
        //  3.  Add 1101100000000000 (0xD800) to the high 10 bits piece (0001000001) - Result: 1101100001000001 (0xD841)
        //  4.  Add 1101110000000000 (0xDC00) to the low 10 bits piece (0000001010) - Result: 1101110000001010 (0xDC0A)
        //
        //  RESULT: The surrogate pair: U+D841, U+DC0A
        //
        //  Special Unicode code point values, for use with UTF-16 surrogate pairs.
        //
        public const short HIGH_SURROGATE_START = unchecked((short)0xd800);
        public const short HIGH_SURROGATE_END = unchecked((short)0xdbff);
        public const short LOW_SURROGATE_START = unchecked((short)0xdc00);
        public const short LOW_SURROGATE_END = unchecked((short)0xdfff);

    }
}

using Xunit;

namespace THNETII.WinApi.Native.WinNls.Test
{
    using static WinNlsFunctions;

    public static class IsValidCodePage
    {
        [TheoryWindowsOS]
        [InlineData(437)]   //  IBM437          OEM United States
        [InlineData(850)]   //  ibm850          OEM Multilingual Latin 1; Western European (DOS)
        [InlineData(1250)]  //  windows-1250    ANSI Central European; Central European (Windows)
        [InlineData(1252)]  //  windows-1252    ANSI Latin 1; Western European (Windows)
        [InlineData(20127)] //  us-ascii        US-ASCII (7-bit)
        [InlineData(28591)] //  iso-8859-1      ISO 8859-1 Latin 1; Western European (ISO)
        [InlineData(28605)] //  iso-8859-15     ISO 8859-15 Latin 9
        [InlineData(65001)] //  utf-8           Unicode (UTF-8)
        public static void ReturnsTrueForCodePage(int codepage) =>
            Assert.True(IsValidCodePage(codepage));

        [TheoryWindowsOS]
        [InlineData(0)]     //  Non existant
        [InlineData(ushort.MaxValue + 100)] // Max Code Page is ushort.MaxValue
        public static void ReturnsFalseForInvalidCodePage(int codepage) =>
            Assert.False(IsValidCodePage(codepage));
    }
}

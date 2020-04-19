using System.Text;

using Xunit;

namespace THNETII.WinApi.Native.WinNls.Test
{
    using static WinNlsFunctions;

    public static class GetOEMCP
    {
        [FactWindowsOS]
        public static void ReturnsNonZeroCodePage()
        {
            int codepage = GetOEMCP();

            Assert.InRange(codepage, 1, ushort.MaxValue);
        }

        [FactWindowsOS]
        public static void ReturnedCodePageIsValid()
        {
            int codepage = GetOEMCP();
            Assert.True(IsValidCodePage(codepage));
        }

        [FactWindowsOS]
        public static void CanCreateEncodingFromReturnedCodePage()
        {
            int codepage = GetOEMCP();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var encoding = Encoding.GetEncoding(codepage);

            Assert.NotNull(encoding);
        }
    }
}

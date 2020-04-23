using System.Text;

using Xunit;

namespace THNETII.WinApi.Native.WinNls.Test
{
    using static WinNlsFunctions;

    public static class GetACP
    {
        [FactWindowsOS]
        public static void ReturnsNonZeroCodePage()
        {
            int codepage = GetACP();

            Assert.InRange(codepage, 1, ushort.MaxValue);
        }

        [FactWindowsOS]
        public static void ReturnedCodePageIsValid()
        {
            int codepage = GetACP();
            Assert.True(IsValidCodePage(codepage));
        }

        [FactWindowsOS]
        public static void CanCreateEncodingFromReturnedCodePage()
        {
            int codepage = GetACP();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var encoding = Encoding.GetEncoding(codepage);

            Assert.NotNull(encoding);
        }
    }
}

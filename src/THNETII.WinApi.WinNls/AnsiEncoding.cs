using System;
using System.Text;

using THNETII.WinApi.Native.WinNls;

namespace THNETII.WinApi.WinNls
{
    public static class AnsiEncoding
    {
        private static Encoding? acpEncoding;
        private static Encoding? oemEncoding;

        public static Encoding ActiveCodePage
        {
            get
            {
                if (acpEncoding is Encoding enc)
                    return enc;
                int cp;
                try
                {
                    cp = WinNlsFunctions.GetACP();
                }
                catch (Exception e)
                {
                    throw new PlatformNotSupportedException(
                        message: default, inner: e);
                }

                return acpEncoding = Encoding.GetEncoding(cp);
            }
        }

        public static Encoding OEMCodePage
        {
            get
            {
                if (oemEncoding is Encoding enc)
                    return enc;
                int cp;
                try
                {
                    cp = WinNlsFunctions.GetOEMCP();
                }
                catch (Exception e)
                {
                    throw new PlatformNotSupportedException(
                        message: default, inner: e);
                }

                return oemEncoding = Encoding.GetEncoding(cp);
            }
        }
    }
}

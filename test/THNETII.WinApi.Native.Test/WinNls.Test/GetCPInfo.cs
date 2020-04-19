using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

using Xunit;

namespace THNETII.WinApi.Native.WinNls.Test
{
    using static WinNlsConstants;
    using static WinNlsFunctions;

    public static class GetCPInfo
    {
        [TheoryWindowsOS]
        [InlineData(CP_ACP)]
        [InlineData(CP_MACCP)]
        [InlineData(CP_OEMCP)]
        [InlineData(CP_THREAD_ACP)]
        [InlineData(437)]   //  IBM437          OEM United States
        [InlineData(850)]   //  ibm850          OEM Multilingual Latin 1; Western European (DOS)
        [InlineData(1250)]  //  windows-1250    ANSI Central European; Central European (Windows)
        [InlineData(1252)]  //  windows-1252    ANSI Latin 1; Western European (Windows)
        [InlineData(20127)] //  us-ascii        US-ASCII (7-bit)
        [InlineData(28591)] //  iso-8859-1      ISO 8859-1 Latin 1; Western European (ISO)
        [InlineData(28605)] //  iso-8859-15     ISO 8859-15 Latin 9
        [InlineData(65001)] //  utf-8           Unicode (UTF-8)
        [Obsolete("Deprecated Win API")]
        public static void ReturnsTrueForCodePage(int codepage)
        {
            bool success = GetCPInfo(codepage, out var cpinfo);

            if (!success)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            Assert.True(success);

            _ = cpinfo.MaxCharSize;
            foreach (ref readonly byte leadByte in cpinfo.LeadByte)
                _ = leadByte;
            foreach (ref readonly byte defaultByte in cpinfo.DefaultChar)
                _ = defaultByte;
        }
    }
}

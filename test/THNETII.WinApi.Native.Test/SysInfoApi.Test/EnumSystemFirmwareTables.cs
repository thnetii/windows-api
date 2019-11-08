using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using Xunit;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class EnumSystemFirmwareTables
    {
        [FactWindowsOS(Skip = "Encoding the Provider signature for EnumSystemFirmwareTables cannot be determined.")]
        public static void Can_call_extern_function()
        {
            int sig = default;
            int requiredBytes = EnumSystemFirmwareTables(sig, default);
            if (requiredBytes == 0)
                throw new Win32Exception(Marshal.GetLastWin32Error());
            Assert.NotEqual(0, requiredBytes);
            Span<byte> buffer = new byte[requiredBytes];
            int bytesWritten = EnumSystemFirmwareTables(sig, buffer);
            Assert.Equal(requiredBytes, bytesWritten);
        }
    }
}

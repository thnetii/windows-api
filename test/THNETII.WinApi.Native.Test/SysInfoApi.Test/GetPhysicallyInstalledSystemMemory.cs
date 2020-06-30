using System.ComponentModel;
using System.Runtime.InteropServices;

using Xunit;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetPhysicallyInstalledSystemMemory
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
            bool successful = GetPhysicallyInstalledSystemMemory(out var memkb);
            if (!successful)
                throw new Win32Exception(Marshal.GetLastWin32Error());
            Assert.NotEqual(0UL, memkb);
        }
    }
}

using System.Runtime.InteropServices;
using System.Text;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.MinWinDef;

using Xunit;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static MinWinDefConstants;
    using static SysInfoApiFunctions;

    public static class GetWindowsDirectory
    {
        [FactWindowsOS]
        public static void Can_call_lpstr_extern_function()
        {
            var buffer = Pointer.Create<LPSTR>(Marshal.AllocCoTaskMem(1 * MAX_PATH));
            try
            {
                var length = GetWindowsDirectoryA(buffer, MAX_PATH);
                if (length == 0)
                    throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
                var path = AnsiStringPointer.MarshalToString(buffer, length);
                Assert.NotNull(path);
            }
            finally
            {
                Marshal.FreeCoTaskMem(buffer.Pointer);
            }
        }

        [FactWindowsOS]
        public static void Can_call_lpwstr_extern_function()
        {
            var buffer = Pointer.Create<LPWSTR>(Marshal.AllocCoTaskMem(2 * MAX_PATH));
            try
            {
                var length = GetWindowsDirectoryW(buffer, MAX_PATH);
                if (length == 0)
                    throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
                var path = UnicodeStringPointer.MarshalToString(buffer, length);
                Assert.NotNull(path);
            }
            finally
            {
                Marshal.FreeCoTaskMem(buffer.Pointer);
            }
        }

        [FactWindowsOS]
        public static void Can_call_lptstr_extern_function()
        {
            var buffer = Pointer.Create<LPTSTR>(Marshal.AllocCoTaskMem(Marshal.SystemDefaultCharSize * MAX_PATH));
            try
            {
                var length = GetWindowsDirectory(buffer, MAX_PATH);
                if (length == 0)
                    throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
                var path = AutoStringPointer.MarshalToString(buffer, length);
                Assert.NotNull(path);
            }
            finally
            {
                Marshal.FreeCoTaskMem(buffer.Pointer);
            }
        }

        [FactWindowsOS]
        public static void Can_call_ansi_marshaling_extern_function()
        {
            var pathBuilder = new StringBuilder(capacity: MAX_PATH);
            var length = GetWindowsDirectoryA(pathBuilder);
            if (length == 0)
                throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
            var path = pathBuilder.ToString(0, length);
            Assert.NotNull(path);
        }

        [FactWindowsOS]
        public static void Can_call_unicode_marshaling_extern_function()
        {
            var pathBuilder = new StringBuilder(capacity: MAX_PATH);
            var length = GetWindowsDirectoryW(pathBuilder);
            if (length == 0)
                throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
            var path = pathBuilder.ToString(0, length);
            Assert.NotNull(path);
        }

        [FactWindowsOS]
        public static void Can_call_auto_marshaling_extern_function()
        {
            var pathBuilder = new StringBuilder(capacity: MAX_PATH);
            var length = GetWindowsDirectory(pathBuilder);
            if (length == 0)
                throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
            var path = pathBuilder.ToString(0, length);
            Assert.NotNull(path);
        }
    }
}

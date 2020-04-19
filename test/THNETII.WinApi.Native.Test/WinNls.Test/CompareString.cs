using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

using Xunit;

namespace THNETII.WinApi.Native.WinNls.Test
{
    using static WinNlsFunctions;

    public static class CompareString
    {
        [FactWindowsOS]
        [Obsolete("Deprecated Win API")]
        public static void CanCallExternFunctionStringAnsi()
        {
            string str1 = nameof(CompareString);
            string str2 = nameof(CompareString);

            var result = CompareStringA(default, default, str1, str2);
            if (result == default)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            Assert.Equal(CSTR_RESULT.CSTR_EQUAL, result);
        }

        [FactWindowsOS]
        [Obsolete("Deprecated Win API")]
        public static void CanCallExternFunctionLpStr()
        {
            var str1 = Pointer.Create<LPSTR>(Marshal.StringToCoTaskMemAnsi(nameof(CompareString)));
            var str2 = Pointer.Create<LPSTR>(Marshal.StringToCoTaskMemAnsi(nameof(CompareString)));

            try
            {
                var result = CompareStringA(default, default, str1, -1, str2, -1);
                if (result == default)
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                Assert.Equal(CSTR_RESULT.CSTR_EQUAL, result);
            }
            finally
            {
                Marshal.FreeCoTaskMem(str1.Pointer);
                Marshal.FreeCoTaskMem(str2.Pointer);
            }
        }

        [FactWindowsOS]
        public static void CanCallExternFunctionStringUnicode()
        {
            string str1 = nameof(CompareString);
            string str2 = nameof(CompareString);

            var result = CompareStringW(default, default, str1, str2);
            if (result == default)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            Assert.Equal(CSTR_RESULT.CSTR_EQUAL, result);
        }

        [FactWindowsOS]
        public static void CanCallExternFunctionLpWStr()
        {
            var str1 = Pointer.Create<LPWSTR>(Marshal.StringToCoTaskMemUni(nameof(CompareString)));
            var str2 = Pointer.Create<LPWSTR>(Marshal.StringToCoTaskMemUni(nameof(CompareString)));

            try
            {
                var result = CompareStringW(default, default, str1, -1, str2, -1);
                if (result == default)
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                Assert.Equal(CSTR_RESULT.CSTR_EQUAL, result);
            }
            finally
            {
                Marshal.FreeCoTaskMem(str1.Pointer);
                Marshal.FreeCoTaskMem(str2.Pointer);
            }
        }

        [FactWindowsOS]
        [Obsolete("Deprecated Win API")]
        public static void CanCallExternFunctionStringAuto()
        {
            string str1 = nameof(CompareString);
            string str2 = nameof(CompareString);

            var result = CompareString(default, default, str1, str2);
            if (result == default)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            Assert.Equal(CSTR_RESULT.CSTR_EQUAL, result);
        }

        [FactWindowsOS]
        [Obsolete("Deprecated Win API")]
        public static void CanCallExternFunctionLpTStr()
        {
            var str1 = Pointer.Create<LPTSTR>(Marshal.StringToCoTaskMemAuto(nameof(CompareString)));
            var str2 = Pointer.Create<LPTSTR>(Marshal.StringToCoTaskMemAuto(nameof(CompareString)));

            try
            {
                var result = CompareString(default, default, str1, -1, str2, -1);
                if (result == default)
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                Assert.Equal(CSTR_RESULT.CSTR_EQUAL, result);
            }
            finally
            {
                Marshal.FreeCoTaskMem(str1.Pointer);
                Marshal.FreeCoTaskMem(str2.Pointer);
            }
        }
    }
}

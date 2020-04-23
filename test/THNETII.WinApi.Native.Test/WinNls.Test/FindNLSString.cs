using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

using Xunit;

namespace THNETII.WinApi.Native.WinNls.Test
{
    using static WinNlsFunctions;

    public static class FindNLSString
    {
        private static readonly string TestSource = typeof(FindNLSString).FullName;
        private static readonly string TestValue = nameof(Test);

        [FactWindowsOS]
        [Obsolete("Deprecated Win API")]
        public static void CanCallExternFunctionString()
        {
            string source = new string(TestSource);
            string value = new string(TestValue);

            int idx = FindNLSString(default, default, source, value, out int len);
            if (idx < 0)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            Assert.InRange(idx, 0, source.Length);
            Assert.Equal(value.Length, len);
        }

        [FactWindowsOS]
        [Obsolete("Deprecated Win API")]
        public static void CanCallExternFunctionSpan()
        {
            ReadOnlySpan<char> source = new string(TestSource).AsSpan();
            ReadOnlySpan<char> value = new string(TestValue).AsSpan();

            int idx = FindNLSString(default, default, source, value, out int len);
            if (idx < 0)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            Assert.InRange(idx, 0, source.Length);
            Assert.Equal(value.Length, len);
        }

        [FactWindowsOS]
        [Obsolete("Deprecated Win API")]
        public static void CanCallExternFunctionLpWStr()
        {
            var source = Pointer.Create<LPCWSTR>(Marshal.StringToCoTaskMemUni(TestSource));
            var value = Pointer.Create<LPCWSTR>(Marshal.StringToCoTaskMemUni(TestValue));

            try
            {
                int idx = FindNLSString(default, default, source, -1, value, -1, out int len);
                if (idx < 0)
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                Assert.InRange(idx, 0, int.MaxValue);
                var expect = value.GetReadOnlySpan<LPCWSTR, char>(len).ToArray();
                var found = source.GetReadOnlySpan<LPCWSTR, char>(idx + len).Slice(idx).ToArray();
                Assert.Equal(expect, found);
            }
            finally
            {
                Marshal.FreeCoTaskMem(source.Pointer);
                Marshal.FreeCoTaskMem(value.Pointer);
            }
        }
    }
}

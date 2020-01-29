using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

using Xunit;

namespace THNETII.WinApi.Native.WindowsDataTypes.Test
{
    public static class MultiStringTest
    {
        private const string emptyMultiString = "\0";

        private static (string[] array, string multiString) GetTestMultiString()
        {
            var array = Enumerable.Range(0, 10)
                .Select(i =>
                {
                    var iStr = i.ToString(CultureInfo.InvariantCulture);
                    return string.Join("-", Enumerable.Repeat(iStr, 10));
                }).ToArray();
            return (array, string.Join("\0", array) + "\0");
        }

        [Fact]
        public static void Empty_known_length_LPMSTR_zero_foreach_iterations()
        {
            var ptr = Marshal.StringToCoTaskMemAnsi(emptyMultiString);
            try
            {
                var multiStrPtr = Pointer.Create<LPMSTR>(ptr);

                int iterations = 0;
                foreach (var (strPtr, strLen) in multiStrPtr.AsEnumerable(emptyMultiString.Length))
                {
                    _ = strPtr;
                    _ = strLen;
                    iterations++;
                }

                Assert.Equal(0, iterations);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Empty_known_length_LPCMSTR_zero_foreach_iterations()
        {
            var ptr = Marshal.StringToCoTaskMemAnsi(emptyMultiString);
            try
            {
                var multiStrPtr = Pointer.Create<LPCMSTR>(ptr);

                int iterations = 0;
                foreach (var (strPtr, strLen) in multiStrPtr.AsEnumerable(emptyMultiString.Length))
                {
                    _ = strPtr;
                    _ = strLen;
                    iterations++;
                }

                Assert.Equal(0, iterations);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Empty_known_length_LPMWSTR_zero_foreach_iterations()
        {
            var ptr = Marshal.StringToCoTaskMemUni(emptyMultiString);
            try
            {
                var multiStrPtr = Pointer.Create<LPMWSTR>(ptr);

                int iterations = 0;
                foreach (var (strPtr, strLen) in multiStrPtr.AsEnumerable(emptyMultiString.Length))
                {
                    _ = strPtr;
                    _ = strLen;
                    iterations++;
                }

                Assert.Equal(0, iterations);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Empty_known_length_LPCMWSTR_zero_foreach_iterations()
        {
            var ptr = Marshal.StringToCoTaskMemUni(emptyMultiString);
            try
            {
                var multiStrPtr = Pointer.Create<LPCMWSTR>(ptr);

                int iterations = 0;
                foreach (var (strPtr, strLen) in multiStrPtr.AsEnumerable(emptyMultiString.Length))
                {
                    _ = strPtr;
                    _ = strLen;
                    iterations++;
                }

                Assert.Equal(0, iterations);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Empty_known_length_LPMTSTR_zero_foreach_iterations()
        {
            var ptr = Marshal.StringToCoTaskMemAuto(emptyMultiString);
            try
            {
                var multiStrPtr = Pointer.Create<LPMTSTR>(ptr);

                int iterations = 0;
                foreach (var (strPtr, strLen) in multiStrPtr.AsEnumerable(emptyMultiString.Length))
                {
                    _ = strPtr;
                    _ = strLen;
                    iterations++;
                }

                Assert.Equal(0, iterations);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Empty_known_length_LPCMTSTR_zero_foreach_iterations()
        {
            var ptr = Marshal.StringToCoTaskMemAuto(emptyMultiString);
            try
            {
                var multiStrPtr = Pointer.Create<LPCMTSTR>(ptr);

                int iterations = 0;
                foreach (var (strPtr, strLen) in multiStrPtr.AsEnumerable(emptyMultiString.Length))
                {
                    _ = strPtr;
                    _ = strLen;
                    iterations++;
                }

                Assert.Equal(0, iterations);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Empty_unknown_length_LPMSTR_zero_foreach_iterations()
        {
            var ptr = Marshal.StringToCoTaskMemAnsi(emptyMultiString);
            try
            {
                var multiStrPtr = Pointer.Create<LPMSTR>(ptr);

                int iterations = 0;
                foreach (var (strPtr, strLen) in multiStrPtr.AsEnumerable())
                {
                    _ = strPtr;
                    _ = strLen;
                    iterations++;
                }

                Assert.Equal(0, iterations);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Empty_unknown_length_LPCMSTR_zero_foreach_iterations()
        {
            var ptr = Marshal.StringToCoTaskMemAnsi(emptyMultiString);
            try
            {
                var multiStrPtr = Pointer.Create<LPCMSTR>(ptr);

                int iterations = 0;
                foreach (var (strPtr, strLen) in multiStrPtr.AsEnumerable())
                {
                    _ = strPtr;
                    _ = strLen;
                    iterations++;
                }

                Assert.Equal(0, iterations);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Empty_unknown_length_LPMWSTR_zero_foreach_iterations()
        {
            var ptr = Marshal.StringToCoTaskMemUni(emptyMultiString);
            try
            {
                var multiStrPtr = Pointer.Create<LPMWSTR>(ptr);

                int iterations = 0;
                foreach (var (strPtr, strLen) in multiStrPtr.AsEnumerable())
                {
                    _ = strPtr;
                    _ = strLen;
                    iterations++;
                }

                Assert.Equal(0, iterations);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Empty_unknown_length_LPCMWSTR_zero_foreach_iterations()
        {
            var ptr = Marshal.StringToCoTaskMemUni(emptyMultiString);
            try
            {
                var multiStrPtr = Pointer.Create<LPCMWSTR>(ptr);

                int iterations = 0;
                foreach (var (strPtr, strLen) in multiStrPtr.AsEnumerable())
                {
                    _ = strPtr;
                    _ = strLen;
                    iterations++;
                }

                Assert.Equal(0, iterations);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Empty_unknown_length_LPMTSTR_zero_foreach_iterations()
        {
            var ptr = Marshal.StringToCoTaskMemAuto(emptyMultiString);
            try
            {
                var multiStrPtr = Pointer.Create<LPMTSTR>(ptr);

                int iterations = 0;
                foreach (var (strPtr, strLen) in multiStrPtr.AsEnumerable())
                {
                    _ = strPtr;
                    _ = strLen;
                    iterations++;
                }

                Assert.Equal(0, iterations);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Empty_unknown_length_LPCMTSTR_zero_foreach_iterations()
        {
            var ptr = Marshal.StringToCoTaskMemAuto(emptyMultiString);
            try
            {
                var multiStrPtr = Pointer.Create<LPCMTSTR>(ptr);

                int iterations = 0;
                foreach (var (strPtr, strLen) in multiStrPtr.AsEnumerable())
                {
                    _ = strPtr;
                    _ = strLen;
                    iterations++;
                }

                Assert.Equal(0, iterations);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Known_length_LPMSTR_foreach_yields_correct_strings()
        {
            var (array, str) = GetTestMultiString();
            var ptr = Marshal.StringToCoTaskMemAnsi(str);
            try
            {
                var multiStrPtr = Pointer.Create<LPMSTR>(ptr);

                int iteration = 0;
                foreach (var (strPtr, length) in multiStrPtr.AsEnumerable(str.Length))
                {
                    Assert.Equal(array[iteration], strPtr.MarshalToString(length));
                    iteration++;
                }
                Assert.Equal(array.Length, iteration);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Known_length_LPCMSTR_foreach_yields_correct_strings()
        {
            var (array, str) = GetTestMultiString();
            var ptr = Marshal.StringToCoTaskMemAnsi(str);
            try
            {
                var multiStrPtr = Pointer.Create<LPCMSTR>(ptr);

                int iteration = 0;
                foreach (var (strPtr, length) in multiStrPtr.AsEnumerable(str.Length))
                {
                    Assert.Equal(array[iteration], strPtr.MarshalToString(length));
                    iteration++;
                }
                Assert.Equal(array.Length, iteration);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Known_length_LPMWSTR_foreach_yields_correct_strings()
        {
            var (array, str) = GetTestMultiString();
            var ptr = Marshal.StringToCoTaskMemUni(str);
            try
            {
                var multiStrPtr = Pointer.Create<LPMWSTR>(ptr);

                int iteration = 0;
                foreach (var (strPtr, length) in multiStrPtr.AsEnumerable(str.Length))
                {
                    Assert.Equal(array[iteration], strPtr.MarshalToString(length));
                    iteration++;
                }
                Assert.Equal(array.Length, iteration);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Known_length_LPCMWSTR_foreach_yields_correct_strings()
        {
            var (array, str) = GetTestMultiString();
            var ptr = Marshal.StringToCoTaskMemUni(str);
            try
            {
                var multiStrPtr = Pointer.Create<LPCMWSTR>(ptr);

                int iteration = 0;
                foreach (var (strPtr, length) in multiStrPtr.AsEnumerable(str.Length))
                {
                    Assert.Equal(array[iteration], strPtr.MarshalToString(length));
                    iteration++;
                }
                Assert.Equal(array.Length, iteration);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Known_length_LPMTSTR_foreach_yields_correct_strings()
        {
            var (array, str) = GetTestMultiString();
            var ptr = Marshal.StringToCoTaskMemAuto(str);
            try
            {
                var multiStrPtr = Pointer.Create<LPMTSTR>(ptr);

                int iteration = 0;
                foreach (var (strPtr, length) in multiStrPtr.AsEnumerable(str.Length))
                {
                    Assert.Equal(array[iteration], strPtr.MarshalToString(length));
                    iteration++;
                }
                Assert.Equal(array.Length, iteration);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Known_length_LPCMTSTR_foreach_yields_correct_strings()
        {
            var (array, str) = GetTestMultiString();
            var ptr = Marshal.StringToCoTaskMemAuto(str);
            try
            {
                var multiStrPtr = Pointer.Create<LPCMTSTR>(ptr);

                int iteration = 0;
                foreach (var (strPtr, length) in multiStrPtr.AsEnumerable(str.Length))
                {
                    Assert.Equal(array[iteration], strPtr.MarshalToString(length));
                    iteration++;
                }
                Assert.Equal(array.Length, iteration);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Unknown_length_LPMSTR_foreach_yields_correct_strings()
        {
            var (array, str) = GetTestMultiString();
            var ptr = Marshal.StringToCoTaskMemAnsi(str);
            try
            {
                var multiStrPtr = Pointer.Create<LPMSTR>(ptr);

                int iteration = 0;
                foreach (var (strPtr, length) in multiStrPtr.AsEnumerable())
                {
                    Assert.Equal(array[iteration], strPtr.MarshalToString(length));
                    iteration++;
                }
                Assert.Equal(array.Length, iteration);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Unknown_length_LPCMSTR_foreach_yields_correct_strings()
        {
            var (array, str) = GetTestMultiString();
            var ptr = Marshal.StringToCoTaskMemAnsi(str);
            try
            {
                var multiStrPtr = Pointer.Create<LPCMSTR>(ptr);

                int iteration = 0;
                foreach (var (strPtr, length) in multiStrPtr.AsEnumerable())
                {
                    Assert.Equal(array[iteration], strPtr.MarshalToString(length));
                    iteration++;
                }
                Assert.Equal(array.Length, iteration);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Unknown_length_LPMWSTR_foreach_yields_correct_strings()
        {
            var (array, str) = GetTestMultiString();
            var ptr = Marshal.StringToCoTaskMemUni(str);
            try
            {
                var multiStrPtr = Pointer.Create<LPMWSTR>(ptr);

                int iteration = 0;
                foreach (var (strPtr, length) in multiStrPtr.AsEnumerable())
                {
                    Assert.Equal(array[iteration], strPtr.MarshalToString(length));
                    iteration++;
                }
                Assert.Equal(array.Length, iteration);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Unknown_length_LPCMWSTR_foreach_yields_correct_strings()
        {
            var (array, str) = GetTestMultiString();
            var ptr = Marshal.StringToCoTaskMemUni(str);
            try
            {
                var multiStrPtr = Pointer.Create<LPCMWSTR>(ptr);

                int iteration = 0;
                foreach (var (strPtr, length) in multiStrPtr.AsEnumerable())
                {
                    Assert.Equal(array[iteration], strPtr.MarshalToString(length));
                    iteration++;
                }
                Assert.Equal(array.Length, iteration);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Unknown_length_LPMTSTR_foreach_yields_correct_strings()
        {
            var (array, str) = GetTestMultiString();
            var ptr = Marshal.StringToCoTaskMemAuto(str);
            try
            {
                var multiStrPtr = Pointer.Create<LPMTSTR>(ptr);

                int iteration = 0;
                foreach (var (strPtr, length) in multiStrPtr.AsEnumerable())
                {
                    Assert.Equal(array[iteration], strPtr.MarshalToString(length));
                    iteration++;
                }
                Assert.Equal(array.Length, iteration);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Fact]
        public static void Unknown_length_LPCMTSTR_foreach_yields_correct_strings()
        {
            var (array, str) = GetTestMultiString();
            var ptr = Marshal.StringToCoTaskMemAuto(str);
            try
            {
                var multiStrPtr = Pointer.Create<LPCMTSTR>(ptr);

                int iteration = 0;
                foreach (var (strPtr, length) in multiStrPtr.AsEnumerable())
                {
                    Assert.Equal(array[iteration], strPtr.MarshalToString(length));
                    iteration++;
                }
                Assert.Equal(array.Length, iteration);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }
    }
}

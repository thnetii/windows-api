using System;
using System.Text;
using Xunit;

namespace THNETII.WinApiNative.ErrorHandling.Test
{
    using System.ComponentModel;
    using System.Globalization;
    using System.Runtime.InteropServices;
    using THNETII.WindowsProtocols.WindowsErrorCodes;
    using static FORMAT_MESSAGE_FLAGS;

    public static class FormatMessageFunctionTest
    {
        [SkippableTheory(typeof(DllNotFoundException), typeof(EntryPointNotFoundException))]
        [InlineData("%%", "%")]
        [InlineData("% ", " ")]
        [InlineData("%.", ".")]
        [InlineData("%!", "!")]
        [InlineData("%n", "\r\n")]
        [InlineData("%r", "\r")]
        [InlineData("%t", "\t")]
        public static void FormatMessageBuilderEscapeSequence(string format, string expect)
        {
            var builder = new StringBuilder(32);
            var nChar = ErrorHandlingFunctions.FormatMessage(
                FORMAT_MESSAGE_FROM_STRING, format,
                dwMessageId: default, dwLanguageId: default,
                builder, nSize: builder.Capacity,
                Arguments: default
                );
            if (nChar < 1)
            {
                Win32ErrorCode error = Marshal.GetLastWin32Error();
                throw new Win32Exception(error.Value);
            }

            string actual = builder.ToString();
            Assert.Contains(expect, actual, StringComparison.Ordinal);
        }

        [SkippableFact(typeof(DllNotFoundException), typeof(EntryPointNotFoundException))]
        public static void FormatMessageBuilderInsertString()
        {
            const string testString = nameof(FormatMessageBuilderInsertString);
            var builder = new StringBuilder(testString.Length + 32);
            (IntPtr argumentString, IntPtr argumentsArray) = (default, default);
            try
            {
                argumentsArray = Marshal.AllocCoTaskMem(IntPtr.Size * 1);
                argumentString = Marshal.StringToCoTaskMemUni(testString);
                Marshal.WriteIntPtr(argumentsArray, argumentString);
                var nChar = ErrorHandlingFunctions.FormatMessage(
                    FORMAT_MESSAGE_FROM_STRING | FORMAT_MESSAGE_ARGUMENT_ARRAY,
                    "%1", default, default,
                    builder, builder.Capacity,
                    argumentsArray
                    );
                if (nChar < 1)
                {
                    Win32ErrorCode error = Marshal.GetLastWin32Error();
                    throw new Win32Exception(error.Value);
                }

                string actual = builder.ToString();
                Assert.Contains(testString, actual, StringComparison.Ordinal);
            }
            finally
            {
                Marshal.FreeCoTaskMem(argumentString);
                Marshal.FreeCoTaskMem(argumentsArray);
            }
        }

        [SkippableFact(typeof(DllNotFoundException), typeof(EntryPointNotFoundException))]
        public static void FormatMessageBuilderInsertInt32()
        {
            int testValue = nameof(FormatMessageBuilderInsertString).Length;
            var builder = new StringBuilder(32);
            IntPtr argumentsArray = default;
            try
            {
                argumentsArray = Marshal.AllocCoTaskMem(sizeof(int) * 1);
                Marshal.WriteInt32(argumentsArray, testValue);
                CultureInfo culture = CultureInfo.InvariantCulture;
                var nChar = ErrorHandlingFunctions.FormatMessage(
                    FORMAT_MESSAGE_FROM_STRING | FORMAT_MESSAGE_ARGUMENT_ARRAY,
                    "%1!d!", default, culture.LCID,
                    builder, builder.Capacity,
                    argumentsArray
                    );
                if (nChar < 1)
                {
                    Win32ErrorCode error = Marshal.GetLastWin32Error();
                    throw new Win32Exception(error.Value);
                }


                string actual = builder.ToString();
                Assert.Contains(testValue.ToString(culture), actual, StringComparison.InvariantCulture);
            }
            finally
            {
                Marshal.FreeCoTaskMem(argumentsArray);
            }
        }
    }
}

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.MinWinDef;
using THNETII.WinApi.Native.WinError;

using Xunit;

namespace THNETII.WinApi.Native.WinBase.Test
{
    using static WinBaseFunctions;
    using static WinErrorConstants;

    public static class FormatMessageW
    {
        [FactWindowsOS]
        public static void Call_FormatString_StringBuilder()
        {
            const string formatString = "%1!*.*s! %4 %5!*s!";
            Span<IntPtr> arguments = stackalloc IntPtr[]
            {
                (IntPtr)4,
                (IntPtr)2,
                Marshal.StringToCoTaskMemUni("Bill"),
                Marshal.StringToCoTaskMemUni("Bob"),
                (IntPtr)6,
                IntPtr.Zero
            };
            arguments[5] = arguments[2];

            try
            {
                int messageLength;
                StringBuilder messageBuilder = new StringBuilder();
                do
                {
                    messageLength = FormatMessageW(
                        dwFlags: FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_STRING,
                        dwWidth: default,
                        lpSource: formatString,
                        dwMessageId: 0,
                        dwLanguageId: default,
                        lpBuffer: messageBuilder,
                        Arguments: arguments
                        );
                } while (messageLength == 0 && Marshal.GetLastWin32Error() switch
                {
                    ERROR_INSUFFICIENT_BUFFER =>
                        (messageBuilder.Capacity += 32) > 0,
                    int e => throw new Win32Exception(e)
                });

                string message = messageBuilder.ToString(0, messageLength);
                Assert.NotEmpty(message);
                Assert.DoesNotContain("\0", message, StringComparison.Ordinal);

                Assert.Equal("  Bi Bob   Bill", message);
            }
            finally
            {
                Marshal.FreeCoTaskMem(arguments[2]);
                Marshal.FreeCoTaskMem(arguments[3]);
            }
        }

        [FactWindowsOS]
        public static void Call_FormatString_StringOut()
        {
            const string formatString = "%1!*.*s! %4 %5!*s!";
            Span<IntPtr> arguments = stackalloc IntPtr[]
            {
                (IntPtr)4,
                (IntPtr)2,
                Marshal.StringToCoTaskMemUni("Bill"),
                Marshal.StringToCoTaskMemUni("Bob"),
                (IntPtr)6,
                IntPtr.Zero
            };
            arguments[5] = arguments[2];

            try
            {
                int messageLength = FormatMessageW(
                    dwFlags: FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_STRING,
                    dwWidth: default,
                    lpSource: formatString,
                    dwMessageId: 0,
                    dwLanguageId: default,
                    lpBuffer: out string message,
                    nSize: default,
                    arguments
                    );

                if (messageLength == 0)
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                Assert.NotEmpty(message);
                Assert.DoesNotContain("\0", message, StringComparison.Ordinal);

                Assert.Equal("  Bi Bob   Bill", message);
            }
            finally
            {
                Marshal.FreeCoTaskMem(arguments[2]);
                Marshal.FreeCoTaskMem(arguments[3]);
            }
        }

        [FactWindowsOS]
        public static unsafe void Call_FormatString_Span()
        {
            IntPtr formatString = Marshal.StringToCoTaskMemUni("%1!*.*s! %4 %5!*s!");
            Span<IntPtr> arguments = stackalloc IntPtr[]
            {
                (IntPtr)4,
                (IntPtr)2,
                Marshal.StringToCoTaskMemUni("Bill"),
                Marshal.StringToCoTaskMemUni("Bob"),
                (IntPtr)6,
                IntPtr.Zero
            };
            arguments[5] = arguments[2];

            try
            {
                string message = null;
                for (int bufferLength = 16; message is null; bufferLength += 16)
                {
                    Span<char> messageBuffer = stackalloc char[bufferLength];
                    int messageLength = FormatMessageW(
                        dwFlags: FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_STRING,
                        dwWidth: default,
                        lpSource: (char*)formatString.ToPointer(),
                        dwMessageId: default,
                        dwLanguageId: default,
                        messageBuffer,
                        arguments
                        );

                    switch (messageLength)
                    {
                        case 0:
                            _ = Marshal.GetLastWin32Error() switch
                            {
                                ERROR_INSUFFICIENT_BUFFER => 0,
                                int e => throw new Win32Exception(e),
                            };
                            break;
                        default:
                            unsafe
                            {
                                fixed (char* messagePointer = messageBuffer)
                                    message = Marshal.PtrToStringUni(
                                        (IntPtr)messagePointer, messageLength);
                            }
                            break;
                    }
                }

                Assert.NotEmpty(message);
                Assert.DoesNotContain("\0", message, StringComparison.Ordinal);

                Assert.Equal("  Bi Bob   Bill", message);
            }
            finally
            {
                Marshal.FreeCoTaskMem(formatString);
                Marshal.FreeCoTaskMem(arguments[2]);
                Marshal.FreeCoTaskMem(arguments[3]);
            }
        }

        [FactWindowsOS]
        public static unsafe void Call_FormatString_SpanOut()
        {
            IntPtr formatString = Marshal.StringToCoTaskMemUni("%1!*.*s! %4 %5!*s!");
            Span<IntPtr> arguments = stackalloc IntPtr[]
            {
                (IntPtr)4,
                (IntPtr)2,
                Marshal.StringToCoTaskMemUni("Bill"),
                Marshal.StringToCoTaskMemUni("Bob"),
                (IntPtr)6,
                IntPtr.Zero
            };
            arguments[5] = arguments[2];

            try
            {
                int messageLength = FormatMessageW(
                    dwFlags: FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_STRING,
                    dwWidth: default,
                    lpSource: (char*)formatString.ToPointer(),
                    dwMessageId: 0,
                    dwLanguageId: default,
                    lpBuffer: out HLOCAL messageBuffer,
                    nSize: default,
                    arguments
                    );

                string message = messageBuffer.Pointer.MarshalAsUnicodeString(messageLength);
                if (LocalFree(messageBuffer).Pointer != IntPtr.Zero)
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                Assert.NotEmpty(message);
                Assert.DoesNotContain("\0", message, StringComparison.Ordinal);

                Assert.Equal("  Bi Bob   Bill", message);
            }
            finally
            {
                Marshal.FreeCoTaskMem(formatString);
                Marshal.FreeCoTaskMem(arguments[2]);
                Marshal.FreeCoTaskMem(arguments[3]);
            }
        }

        [TheoryWindowsOS]
        [InlineData(ERROR_SUCCESS)]
        [InlineData(ERROR_OUTOFMEMORY)]
        [InlineData(ERROR_INVALID_PARAMETER)]
        public static void Call_Win32Error_StringBuilder(int errorcode)
        {
            StringBuilder messageBuilder = new StringBuilder();

            int messageLength;
            do
            {
                messageLength = FormatMessageW(
                    dwFlags: FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_SYSTEM |
                        FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_IGNORE_INSERTS,
                    dwWidth: default,
                    lpSource: IntPtr.Zero,
                    dwMessageId: errorcode,
                    dwLanguageId: default,
                    lpBuffer: messageBuilder
                    );
            } while (messageLength == 0 && Marshal.GetLastWin32Error() switch
            {
                ERROR_INSUFFICIENT_BUFFER =>
                    (messageBuilder.Capacity += 32) > 0,
                int e => throw new Win32Exception(e)
            });

            string message = messageBuilder.ToString(0, messageLength);

            Assert.NotEmpty(message);
            Assert.DoesNotContain("\0", message, StringComparison.Ordinal);
        }

        [TheoryWindowsOS]
        [InlineData(ERROR_SUCCESS)]
        [InlineData(ERROR_OUTOFMEMORY)]
        [InlineData(ERROR_INVALID_PARAMETER)]
        public static void Call_Win32Error_StringOut(int errorcode)
        {
            int messageLength = FormatMessageW(
                dwFlags: FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_SYSTEM |
                    FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_IGNORE_INSERTS,
                dwWidth: default,
                lpSource: IntPtr.Zero,
                dwMessageId: errorcode,
                dwLanguageId: default,
                out string message
                );

            if (messageLength == 0)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            Assert.NotEmpty(message);
            Assert.DoesNotContain("\0", message, StringComparison.Ordinal);
        }

        [TheoryWindowsOS]
        [InlineData(ERROR_SUCCESS)]
        [InlineData(ERROR_OUTOFMEMORY)]
        [InlineData(ERROR_INVALID_PARAMETER)]
        public static void Call_Win32Error_Span(int errorcode)
        {
            string message = null;
            for (int bufferLength = 16; message is null; bufferLength += 16)
            {
                Span<char> messageBuffer = stackalloc char[bufferLength];
                int messageLength = FormatMessageW(
                    dwFlags: FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_SYSTEM |
                        FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_IGNORE_INSERTS,
                    dwWidth: default,
                    lpSource: IntPtr.Zero,
                    dwMessageId: errorcode,
                    dwLanguageId: default,
                    messageBuffer
                    );

                switch (messageLength)
                {
                    case 0:
                        _ = Marshal.GetLastWin32Error() switch
                        {
                            ERROR_INSUFFICIENT_BUFFER => 0,
                            int e => throw new Win32Exception(e),
                        };
                        break;
                    default:
                        unsafe
                        {
                            fixed (char* messagePointer = messageBuffer)
                                message = Marshal.PtrToStringUni(
                                    (IntPtr)messagePointer, messageLength);
                        }
                        break;
                }
            }

            Assert.NotEmpty(message);
            Assert.DoesNotContain("\0", message, StringComparison.Ordinal);
        }

        [TheoryWindowsOS]
        [InlineData(ERROR_SUCCESS)]
        [InlineData(ERROR_OUTOFMEMORY)]
        [InlineData(ERROR_INVALID_PARAMETER)]
        public static void Call_Win32Error_SpanOut(int errorcode)
        {
            int messageLength = FormatMessageW(
                dwFlags: FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_SYSTEM |
                    FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_IGNORE_INSERTS,
                dwWidth: default,
                lpSource: IntPtr.Zero,
                dwMessageId: errorcode,
                dwLanguageId: default,
                out HLOCAL messagePointer
                );

            if (messageLength == 0)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            string message = messagePointer.Pointer
                .MarshalAsUnicodeString(messageLength);
            if (LocalFree(messagePointer).Pointer != IntPtr.Zero)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            Assert.NotEmpty(message);
            Assert.DoesNotContain("\0", message, StringComparison.Ordinal);
        }
    }
}

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

    public static class FormatMessage
    {
        [FactWindowsOS]
        public static void Call_FormatString_StringBuilder()
        {
            const string formatString = "%1!*.*s! %4 %5!*s!";
            Span<IntPtr> arguments = stackalloc IntPtr[]
            {
                (IntPtr)4,
                (IntPtr)2,
                Marshal.StringToCoTaskMemAuto("Bill"),
                Marshal.StringToCoTaskMemAuto("Bob"),
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
                    messageLength = FormatMessage(
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
                Marshal.StringToCoTaskMemAuto("Bill"),
                Marshal.StringToCoTaskMemAuto("Bob"),
                (IntPtr)6,
                IntPtr.Zero
            };
            arguments[5] = arguments[2];

            try
            {
                int messageLength = FormatMessage(
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
            IntPtr formatString = Marshal.StringToCoTaskMemAuto("%1!*.*s! %4 %5!*s!");
            Span<IntPtr> arguments = stackalloc IntPtr[]
            {
                (IntPtr)4,
                (IntPtr)2,
                Marshal.StringToCoTaskMemAuto("Bill"),
                Marshal.StringToCoTaskMemAuto("Bob"),
                (IntPtr)6,
                IntPtr.Zero
            };
            arguments[5] = arguments[2];

            try
            {
                string message = null;
                for (int bufferLength = 16; message is null; bufferLength += 16)
                {
                    Span<byte> messageBuffer = stackalloc byte[bufferLength * Marshal.SystemDefaultCharSize];
                    int messageLength = FormatMessage(
                        dwFlags: FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_STRING,
                        dwWidth: default,
                        lpSource: (byte*)formatString.ToPointer(),
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
                                fixed (byte* messagePointer = messageBuffer)
                                    message = Marshal.PtrToStringAuto(
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
            IntPtr formatString = Marshal.StringToCoTaskMemAuto("%1!*.*s! %4 %5!*s!");
            Span<IntPtr> arguments = stackalloc IntPtr[]
            {
                (IntPtr)4,
                (IntPtr)2,
                Marshal.StringToCoTaskMemAuto("Bill"),
                Marshal.StringToCoTaskMemAuto("Bob"),
                (IntPtr)6,
                IntPtr.Zero
            };
            arguments[5] = arguments[2];

            try
            {
                int messageLength = FormatMessage(
                    dwFlags: FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_FROM_STRING,
                    dwWidth: default,
                    lpSource: (byte*)formatString.ToPointer(),
                    dwMessageId: 0,
                    dwLanguageId: default,
                    lpBuffer: out HLOCAL messageBuffer,
                    nSize: default,
                    arguments
                    );

                string message = messageBuffer.Pointer.MarshalAsAutoString(messageLength);
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
                messageLength = FormatMessage(
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
            int messageLength = FormatMessage(
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
                Span<byte> messageBuffer = stackalloc byte[bufferLength * Marshal.SystemDefaultCharSize];
                int messageLength = FormatMessage(
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
                            fixed (byte* messagePointer = messageBuffer)
                                message = Marshal.PtrToStringAuto(
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
            int messageLength = FormatMessage(
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
                .MarshalAsAutoString(messageLength);
            if (LocalFree(messagePointer).Pointer != IntPtr.Zero)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            Assert.NotEmpty(message);
            Assert.DoesNotContain("\0", message, StringComparison.Ordinal);
        }
    }
}

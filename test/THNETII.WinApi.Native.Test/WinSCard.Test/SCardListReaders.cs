using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.SCardErr;

using Xunit;

namespace THNETII.WinApi.Native.WinSCard.Test
{
    using static SCardErrConstants;
    using static WinSCardFunctions;

    public static class SCardListReaders
    {
        [SkippableFactWindowsOS]
        public static void Can_call_ansi_extern_function_with_null_context_and_group()
        {
            int error;
            int readersLength = 16;
            LPMSTR readersBuffer = default;
            try
            {
                do
                {
                    readersBuffer = Pointer.Create<LPMSTR>(
                        Marshal.ReAllocCoTaskMem(readersBuffer.Pointer, 1 * readersLength)
                        );
                    error = SCardListReadersA(default, null, readersBuffer,
                        ref readersLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
                Skip.If(error == SCARD_E_NO_READERS_AVAILABLE, new Win32Exception(error).Message);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                foreach (var (readerPointer, readerLength) in readersBuffer.AsEnumerable(readersLength))
                {
                    string readerName = readerPointer.MarshalToString(readerLength);
                    _ = readerName;
                }
            }
            finally
            {
                Marshal.FreeCoTaskMem(readersBuffer.Pointer);
            }
        }

        [SkippableFactWindowsOS]
        public static void Can_call_unicode_extern_function_with_null_context_and_group()
        {
            int error;
            int readersLength = 16;
            LPMWSTR readersBuffer = default;
            try
            {
                do
                {
                    readersBuffer = Pointer.Create<LPMWSTR>(
                        Marshal.ReAllocCoTaskMem(readersBuffer.Pointer, 2 * readersLength)
                        );
                    error = SCardListReadersW(default, null, readersBuffer,
                        ref readersLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
                Skip.If(error == SCARD_E_NO_READERS_AVAILABLE, new Win32Exception(error).Message);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                foreach (var (readerPointer, readerLength) in readersBuffer.AsEnumerable(readersLength))
                {
                    string readerName = readerPointer.MarshalToString(readerLength);
                    _ = readerName;
                }
            }
            finally
            {
                Marshal.FreeCoTaskMem(readersBuffer.Pointer);
            }
        }

        [SkippableFactWindowsOS]
        public static void Can_call_auto_extern_function_with_null_context_and_group()
        {
            int error;
            int readersLength = 16;
            LPMTSTR readersBuffer = default;
            try
            {
                do
                {
                    readersBuffer = Pointer.Create<LPMTSTR>(
                        Marshal.ReAllocCoTaskMem(readersBuffer.Pointer,
                            Marshal.SystemDefaultCharSize * readersLength)
                        );
                    error = SCardListReaders(default, null, readersBuffer,
                        ref readersLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
                Skip.If(error == SCARD_E_NO_READERS_AVAILABLE, new Win32Exception(error).Message);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                foreach (var (readerPointer, readerLength) in readersBuffer.AsEnumerable(readersLength))
                {
                    string readerName = readerPointer.MarshalToString(readerLength);
                    _ = readerName;
                }
            }
            finally
            {
                Marshal.FreeCoTaskMem(readersBuffer.Pointer);
            }
        }
    }
}

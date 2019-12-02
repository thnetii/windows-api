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
            LPSTR readersBuffer = default;
            try
            {
                do
                {
                    readersBuffer = Pointer.Create<LPSTR>(
                        Marshal.ReAllocCoTaskMem(readersBuffer.Pointer, 1 * readersLength)
                        );
                    error = SCardListReadersA(default, null, readersBuffer,
                        ref readersLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
                Skip.If(error == SCARD_E_NO_READERS_AVAILABLE, new Win32Exception(error).Message);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                var readersString = readersBuffer.MarshalToString(readersLength);
                string[] readersArray = readersString.Split('\0', StringSplitOptions.RemoveEmptyEntries);
                foreach (string readerName in readersArray)
                    _ = readerName;
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
            LPWSTR readersBuffer = default;
            try
            {
                do
                {
                    readersBuffer = Pointer.Create<LPWSTR>(
                        Marshal.ReAllocCoTaskMem(readersBuffer.Pointer, 2 * readersLength)
                        );
                    error = SCardListReadersW(default, null, readersBuffer,
                        ref readersLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
                Skip.If(error == SCARD_E_NO_READERS_AVAILABLE, new Win32Exception(error).Message);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                var readersString = readersBuffer.MarshalToString(readersLength);
                string[] readersArray = readersString.Split('\0', StringSplitOptions.RemoveEmptyEntries);
                foreach (string readerName in readersArray)
                    _ = readerName;
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
            LPTSTR readersBuffer = default;
            try
            {
                do
                {
                    readersBuffer = Pointer.Create<LPTSTR>(
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

                var readersString = readersBuffer.MarshalToString(readersLength);
                string[] readersArray = readersString.Split('\0', StringSplitOptions.RemoveEmptyEntries);
                foreach (string readerName in readersArray)
                    _ = readerName;
            }
            finally
            {
                Marshal.FreeCoTaskMem(readersBuffer.Pointer);
            }
        }
    }
}

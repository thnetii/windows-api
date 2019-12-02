using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.SCardErr;

using Xunit;

namespace THNETII.WinApi.Native.WinSCard.Test
{
    using static SCardErrConstants;
    using static WinSCardConstants;
    using static WinSCardFunctions;

    public static class SCardListReaderGroups
    {
        [SkippableFactWindowsOS]
        public static void Can_call_ansi_extern_function_with_null_context()
        {
            int error;
            int groupLength = 16;
            LPSTR groupBuffer = default;
            try
            {
                do
                {
                    groupBuffer = Pointer.Create<LPSTR>(
                        Marshal.ReAllocCoTaskMem(groupBuffer.Pointer, 1 * groupLength)
                        );
                    error = SCardListReaderGroupsA(default, groupBuffer,
                        ref groupLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                var groupString = groupBuffer.MarshalToString(groupLength);
                string[] groupArray = groupString.Split('\0', StringSplitOptions.RemoveEmptyEntries);
                foreach (string groupName in groupArray)
                    _ = groupName;
            }
            finally
            {
                Marshal.FreeCoTaskMem(groupBuffer.Pointer);
            }
        }

        [SkippableFactWindowsOS]
        public static void Can_call_unicode_extern_function_with_null_context()
        {
            int error;
            int groupLength = 16;
            LPWSTR groupBuffer = default;
            try
            {
                do
                {
                    groupBuffer = Pointer.Create<LPWSTR>(
                        Marshal.ReAllocCoTaskMem(groupBuffer.Pointer, 2 * groupLength)
                        );
                    error = SCardListReaderGroupsW(default, groupBuffer,
                        ref groupLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                var groupString = groupBuffer.MarshalToString(groupLength);
                string[] groupArray = groupString.Split('\0', StringSplitOptions.RemoveEmptyEntries);
                foreach (string groupName in groupArray)
                    _ = groupName;
            }
            finally
            {
                Marshal.FreeCoTaskMem(groupBuffer.Pointer);
            }
        }

        [SkippableFactWindowsOS]
        public static void Can_call_auto_extern_function_with_null_context()
        {
            int error;
            int groupLength = 16;
            LPTSTR groupBuffer = default;
            try
            {
                do
                {
                    groupBuffer = Pointer.Create<LPTSTR>(
                        Marshal.ReAllocCoTaskMem(groupBuffer.Pointer,
                            Marshal.SystemDefaultCharSize * groupLength)
                        );
                    error = SCardListReaderGroups(default, groupBuffer,
                        ref groupLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                var groupString = groupBuffer.MarshalToString(groupLength);
                string[] groupArray = groupString.Split('\0', StringSplitOptions.RemoveEmptyEntries);
                foreach (string groupName in groupArray)
                    _ = groupName;
            }
            finally
            {
                Marshal.FreeCoTaskMem(groupBuffer.Pointer);
            }
        }
    }
}

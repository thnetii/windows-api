using Microsoft.Win32.WinApi.WinError;
using System;
using System.Globalization;
using System.Text;
using Xunit;

using static Microsoft.Win32.WinApi.Diagnostics.ErrorHandling.ErrorHandlingFunctions;
using static Microsoft.Win32.WinApi.Diagnostics.ErrorHandling.ErrorHandlingFunctions.FORMAT_MESSAGE_FLAG;

namespace THNETII.WinApi.Native.Test.ErrorHandling
{
    public class ErrorHandlingTest
    {
        [Fact]
        public void FormatMessageWithAllWin32ErrorsTest()
        {
            var lpMessageBuffer = new StringBuilder(2048);

            foreach (Win32ErrorCode dwMessageId in Enum.GetValues(typeof(Win32ErrorCode)))
            {
                retryFormatMessageCall:
                var dwMessageLength = FormatMessage(
                    dwFlags: FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS,
                    dwMessageId: (int)dwMessageId,
                    dwLanguageId: 0,
                    lpBuffer: lpMessageBuffer,
                    nSize: lpMessageBuffer.Capacity
                    );
                Assert.NotEqual(0, dwMessageLength);
                if (dwMessageLength > lpMessageBuffer.Capacity)
                {
                    lpMessageBuffer.EnsureCapacity(dwMessageLength);
                    goto retryFormatMessageCall;
                }
            }
        }
    }
}

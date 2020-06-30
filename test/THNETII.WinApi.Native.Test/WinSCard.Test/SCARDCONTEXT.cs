using System.ComponentModel;

using THNETII.WinApi.Native.SCardErr;

using Xunit;

namespace THNETII.WinApi.Native.WinSCard.Test
{
    using static SCardErrConstants;
    using static WinSCardFunctions;

    public static class SCARDCONTEXT
    {
        [SkippableFactWindowsOS]
        public static void Can_estabilsh_and_release_context()
        {
            int error = SCardEstablishContext(default, default, default,
                out var context);
            Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
            if (error != SCARD_S_SUCCESS)
                throw new Win32Exception(error);
            try
            {
                error = SCardIsValidContext(context);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);
            }
            finally
            {
                error = SCardReleaseContext(context);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);
            }
        }
    }
}

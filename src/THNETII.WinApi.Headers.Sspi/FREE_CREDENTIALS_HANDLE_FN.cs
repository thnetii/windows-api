using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int FREE_CREDENTIALS_HANDLE_FN(
        [In] in CredHandle phCredential
        );
}

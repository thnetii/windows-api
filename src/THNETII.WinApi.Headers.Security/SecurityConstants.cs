using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.Security
{
    public static class SecurityConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\security.h, line 30
        //
        // These are name that can be used to refer to the builtin packages
        //

        public static readonly LPCSTR NTLMSP_NAME_A =
            Pointer.Create<LPCSTR>(Marshal.StringToCoTaskMemAnsi(NTLMSP_NAME));
        public const string NTLMSP_NAME = "NTLM";        // ntifs

        public static readonly LPCSTR MICROSOFT_KERBEROS_NAME_A =
            Pointer.Create<LPCSTR>(Marshal.StringToCoTaskMemAnsi(MICROSOFT_KERBEROS_NAME));
        public const string MICROSOFT_KERBEROS_NAME_W = "Kerberos";
        public const string MICROSOFT_KERBEROS_NAME = MICROSOFT_KERBEROS_NAME_W;

        public const string NEGOSSP_NAME_W = "Negotiate";
        public static readonly LPCSTR NEGOSSP_NAME_A =
            Pointer.Create<LPCSTR>(Marshal.StringToCoTaskMemAnsi(NEGOSSP_NAME));

        public const string NEGOSSP_NAME = NEGOSSP_NAME_W;

    }
}

using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.Sspi
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int ACQUIRE_CREDENTIALS_HANDLE_FN_W(
        [In, Optional] LPCWSTR pszPrincipal, [In] LPCWSTR pszPackage,
        [In, MarshalAs(UnmanagedType.U4)] SECPKG_CRED_USE fCredentialUse,
        [In, Optional] in LUID pvLogonId, [In, Optional] IntPtr pAuthData,
        [In, Optional] SEC_GET_KEY_FN pGetKeyFn,
        [In, Optional] IntPtr pvGetKeyArgument,
        out CredHandle phCredential, [Optional] out TimeStamp ptsExpiry
        );

    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int ACQUIRE_CREDENTIALS_HANDLE_FN_A(
        [In, Optional] LPCSTR pszPrincipal, [In] LPCSTR pszPackage,
        [In, MarshalAs(UnmanagedType.U4)] SECPKG_CRED_USE fCredentialUse,
        [In, Optional] in LUID pvLogonId, [In, Optional] IntPtr pAuthData,
        [In, Optional] SEC_GET_KEY_FN pGetKeyFn,
        [In, Optional] IntPtr pvGetKeyArgument,
        out CredHandle phCredential, [Optional] out TimeStamp ptsExpiry
        );

    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int ACQUIRE_CREDENTIALS_HANDLE_FN(
        [In, Optional] LPCTSTR pszPrincipal, [In] LPCTSTR pszPackage,
        [In, MarshalAs(UnmanagedType.U4)] SECPKG_CRED_USE fCredentialUse,
        [In, Optional] in LUID pvLogonId, [In, Optional] IntPtr pAuthData,
        [In, Optional] SEC_GET_KEY_FN pGetKeyFn,
        [In, Optional] IntPtr pvGetKeyArgument,
        out CredHandle phCredential, [Optional] out TimeStamp ptsExpiry
        );
}

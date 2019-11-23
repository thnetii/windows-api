using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    public delegate int ADD_CREDENTIALS_FN_W(
        [In] in CredHandle hCredentials,
        [In, Optional] LPCWSTR pszPrincipal,
        [In] LPCWSTR pszPackage,
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_CRED_USE fCredentialUse,
        [In, Optional] IntPtr pAuthData,
        [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
        SEC_GET_KEY_FN pGetKeyFn,
        [In, Optional] IntPtr pvGetKeyArgument,
        [Optional] out TimeStamp ptsExpiry
        );

    public delegate int ADD_CREDENTIALS_FN_A(
        [In] in CredHandle hCredentials,
        [In, Optional] LPCSTR pszPrincipal,
        [In] LPCWSTR pszPackage,
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_CRED_USE fCredentialUse,
        [In, Optional] IntPtr pAuthData,
        [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
        SEC_GET_KEY_FN pGetKeyFn,
        [In, Optional] IntPtr pvGetKeyArgument,
        [Optional] out TimeStamp ptsExpiry
        );

    public delegate int ADD_CREDENTIALS_FN(
        [In] in CredHandle hCredentials,
        [In, Optional] LPCTSTR pszPrincipal,
        [In] LPCWSTR pszPackage,
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_CRED_USE fCredentialUse,
        [In, Optional] IntPtr pAuthData,
        [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
        SEC_GET_KEY_FN pGetKeyFn,
        [In, Optional] IntPtr pvGetKeyArgument,
        [Optional] out TimeStamp ptsExpiry
        );
}

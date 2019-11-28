using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int CHANGE_PASSWORD_FN_W(
        [In] LPCWSTR pszPackageName,
        [In] LPCWSTR pszDomainName,
        [In] LPCWSTR pszAccountName,
        [In] LPCWSTR pszOldPassword,
        [In] LPCWSTR pszNewPassword,
        [In, MarshalAs(UnmanagedType.U1)] bool bImpersonating,
        [In] int dwReserved,
        ref SecBufferDesc pOutput
        );

    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int CHANGE_PASSWORD_FN_A(
        [In] LPCSTR pszPackageName,
        [In] LPCSTR pszDomainName,
        [In] LPCSTR pszAccountName,
        [In] LPCSTR pszOldPassword,
        [In] LPCSTR pszNewPassword,
        [In, MarshalAs(UnmanagedType.U1)] bool bImpersonating,
        [In] int dwReserved,
        ref SecBufferDesc pOutput
        );

    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int CHANGE_PASSWORD_FN(
        [In] LPCTSTR pszPackageName,
        [In] LPCTSTR pszDomainName,
        [In] LPCTSTR pszAccountName,
        [In] LPCTSTR pszOldPassword,
        [In] LPCTSTR pszNewPassword,
        [In, MarshalAs(UnmanagedType.U1)] bool bImpersonating,
        [In] int dwReserved,
        ref SecBufferDesc pOutput
        );
}

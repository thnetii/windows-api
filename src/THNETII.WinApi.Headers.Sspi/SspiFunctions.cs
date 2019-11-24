using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

using THNETII.WinApi.Native.WinNT;
using THNETII.WinApi.Native.WinError;

#if NETSTANDARD1_6
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.Sspi
{
    using static NativeLibraryNames;
    using static WinErrorConstants;

    using static ISC_REQ_FLAGS;
    using static ISC_RET_FLAGS;
    using static SECBUFFER_TYPE;
    using static SECPKG_ATTR_TYPE;

    public static class SspiFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 139
        #region SecInvalidateHandle macro
        public static void SecInvalidateHandle(ref SecHandle x)
        {
            x.dwLower = new UIntPtr(unchecked((uint)-1));
            x.dwUpper = new UIntPtr(unchecked((uint)-1));
        }
        #endregion
        #region SecIsValidHandle macro
        public static bool SecIsValidHandle(in SecHandle x)
        {
            return x.dwLower != new UIntPtr(unchecked((uint)-1)) &&
                x.dwUpper != new UIntPtr(unchecked((uint)-1));
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1167
        #region AcquireCredentialsHandleW function
        /// <inheritdoc cref="AcquireCredentialsHandle(LPCTSTR, LPCTSTR, SECPKG_CRED_USE, in LUID, IntPtr, SEC_GET_KEY_FN, IntPtr, out CredHandle, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int AcquireCredentialsHandleW(
            [In, Optional] LPCWSTR pszPrincipal,         // Name of principal
            [In] LPCWSTR pszPackage,                     // Name of package
            [In, MarshalAs(UnmanagedType.U4)]
            SECPKG_CRED_USE fCredentialUse,             // Flags indicating use
            [In, Optional] in LUID pvLogonId,           // Pointer to logon ID
            [In, Optional] IntPtr pAuthData,            // Package specific data
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
            SEC_GET_KEY_FN pGetKeyFn,                // Pointer to GetKey() func
            [In, Optional] IntPtr pvGetKeyArgument,  // Value to pass to GetKey()
            out CredHandle phCredential,             // (out) Cred Handle
            [Optional] out TimeStamp ptsExpiry       // (out) Lifetime (optional)
            );

        /// <inheritdoc cref="AcquireCredentialsHandleW(LPCWSTR, LPCWSTR, SECPKG_CRED_USE, in LUID, IntPtr, SEC_GET_KEY_FN, IntPtr, out CredHandle, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int AcquireCredentialsHandleW(
            [In, Optional] string pszPrincipal,         // Name of principal
            [In] string pszPackage,                     // Name of package
            [In, MarshalAs(UnmanagedType.U4)]
            SECPKG_CRED_USE fCredentialUse,             // Flags indicating use
            [In, Optional] in LUID pvLogonId,           // Pointer to logon ID
            [In, Optional] IntPtr pAuthData,            // Package specific data
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
            SEC_GET_KEY_FN pGetKeyFn,                // Pointer to GetKey() func
            [In, Optional] IntPtr pvGetKeyArgument,  // Value to pass to GetKey()
            out CredHandle phCredential,             // (out) Cred Handle
            [Optional] out TimeStamp ptsExpiry       // (out) Lifetime (optional)
            );

        /// <inheritdoc cref="AcquireCredentialsHandleW(LPCWSTR, LPCWSTR, SECPKG_CRED_USE, in LUID, IntPtr, SEC_GET_KEY_FN, IntPtr, out CredHandle, out TimeStamp)"/>
        public static unsafe int AcquireCredentialsHandleW(
            ReadOnlySpan<char> pszPrincipal,         // Name of principal
            ReadOnlySpan<char> pszPackage,           // Name of package
            SECPKG_CRED_USE fCredentialUse,          // Flags indicating use
            in LUID pvLogonId,                       // Pointer to logon ID
            IntPtr pAuthData,                        // Package specific data
            SEC_GET_KEY_FN pGetKeyFn,                // Pointer to GetKey() func
            IntPtr pvGetKeyArgument,                 // Value to pass to GetKey()
            out CredHandle phCredential,             // (out) Cred Handle
            out TimeStamp ptsExpiry                  // (out) Lifetime (optional)
            )
        {
            fixed (char* pszPrincipalPtr = pszPrincipal)
            fixed (char* pszPackagePtr = pszPackage)
                return AcquireCredentialsHandleW(
                    Pointer.Create<LPCWSTR>(pszPrincipalPtr),
                    Pointer.Create<LPCWSTR>(pszPackagePtr),
                    fCredentialUse, pvLogonId, pAuthData,
                    pGetKeyFn, pvGetKeyArgument,
                    out phCredential, out ptsExpiry
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1205
        #region AcquireCredentialsHandleA function
        /// <inheritdoc cref="AcquireCredentialsHandle(LPCTSTR, LPCTSTR, SECPKG_CRED_USE, in LUID, IntPtr, SEC_GET_KEY_FN, IntPtr, out CredHandle, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int AcquireCredentialsHandleA(
            [In, Optional] LPCSTR pszPrincipal,         // Name of principal
            [In] LPCSTR pszPackage,                     // Name of package
            [In, MarshalAs(UnmanagedType.U4)]
            SECPKG_CRED_USE fCredentialUse,             // Flags indicating use
            [In, Optional] in LUID pvLogonId,           // Pointer to logon ID
            [In, Optional] IntPtr pAuthData,            // Package specific data
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
            SEC_GET_KEY_FN pGetKeyFn,                // Pointer to GetKey() func
            [In, Optional] IntPtr pvGetKeyArgument,  // Value to pass to GetKey()
            out CredHandle phCredential,             // (out) Cred Handle
            [Optional] out TimeStamp ptsExpiry       // (out) Lifetime (optional)
            );

        /// <inheritdoc cref="AcquireCredentialsHandleA(LPCSTR, LPCSTR, SECPKG_CRED_USE, in LUID, IntPtr, SEC_GET_KEY_FN, IntPtr, out CredHandle, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int AcquireCredentialsHandleA(
            [In, Optional] string pszPrincipal,         // Name of principal
            [In] string pszPackage,                     // Name of package
            [In, MarshalAs(UnmanagedType.U4)]
            SECPKG_CRED_USE fCredentialUse,             // Flags indicating use
            [In, Optional] in LUID pvLogonId,           // Pointer to logon ID
            [In, Optional] IntPtr pAuthData,            // Package specific data
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
            SEC_GET_KEY_FN pGetKeyFn,                // Pointer to GetKey() func
            [In, Optional] IntPtr pvGetKeyArgument,  // Value to pass to GetKey()
            out CredHandle phCredential,             // (out) Cred Handle
            [Optional] out TimeStamp ptsExpiry       // (out) Lifetime (optional)
            );

        /// <inheritdoc cref="AcquireCredentialsHandleA(LPCSTR, LPCSTR, SECPKG_CRED_USE, in LUID, IntPtr, SEC_GET_KEY_FN, IntPtr, out CredHandle, out TimeStamp)"/>
        public static unsafe int AcquireCredentialsHandleA(
            ReadOnlySpan<byte> pszPrincipal,         // Name of principal
            ReadOnlySpan<byte> pszPackage,           // Name of package
            SECPKG_CRED_USE fCredentialUse,          // Flags indicating use
            in LUID pvLogonId,                       // Pointer to logon ID
            IntPtr pAuthData,                        // Package specific data
            SEC_GET_KEY_FN pGetKeyFn,                // Pointer to GetKey() func
            IntPtr pvGetKeyArgument,                 // Value to pass to GetKey()
            out CredHandle phCredential,             // (out) Cred Handle
            out TimeStamp ptsExpiry                  // (out) Lifetime (optional)
            )
        {
            fixed (byte* pszPrincipalPtr = pszPrincipal)
            fixed (byte* pszPackagePtr = pszPackage)
                return AcquireCredentialsHandleA(
                    Pointer.Create<LPCSTR>(pszPrincipalPtr),
                    Pointer.Create<LPCSTR>(pszPackagePtr),
                    fCredentialUse, pvLogonId, pAuthData,
                    pGetKeyFn, pvGetKeyArgument,
                    out phCredential, out ptsExpiry
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1230
        #region AcquireCredentialsHandle function
        /// <summary>
        /// The <see cref="AcquireCredentialsHandle"/> (General) function acquires a handle to preexisting credentials of a security principal. This handle is required by the <see cref="InitializeSecurityContext"/> (General) and <see cref="AcceptSecurityContext"/> (General) functions. These can be either preexisting credentials, which are established through a system logon that is not described here, or the caller can provide alternative credentials.
        /// <para><note>This is not a "log on to the network" and does not imply gathering of credentials.</note></para>
        /// </summary>
        /// <param name="pszPrincipal">
        /// <para>A pointer to a null-terminated string that specifies the name of the principal whose credentials the handle will reference.</para>
        /// <para>When using the Digest SSP, this parameter is optional.</para>
        /// <para>When using the Schannel SSP, this parameter is not used and should be set to <see langword="null"/>.</para>
        /// <para><note>If the process that requests the handle does not have access to the credentials, the function returns an error. A null string indicates that the process requires a handle to the credentials of the user under whose <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">security context</a> it is executing.</note></para>
        /// </param>
        /// <param name="pszPackage">
        /// <para>A pointer to a null-terminated string that specifies the name of the <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">security package</a> with which these credentials will be used. This is a <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">security package</a> name returned in the <see cref="SecPkgInfoW.Name"/> member of a <see cref="SecPkgInfoW"/> structure returned by the <see cref="EnumerateSecurityPackages"/> function. After a context is established, <see cref="QueryContextAttributes"/> (General) can be called with <em>ulAttribute</em> set to <see cref="SECPKG_ATTR_PACKAGE_INFO"/> to return information on the <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">security package</a> in use.</para>
        /// <para>When using the Digest SSP, set this parameter to <see cref="WDIGEST_SP_NAME"/>.</para>
        /// <para>When using the Schannel SSP, set this parameter to <see cref="UNISP_NAME"/>.</para>
        /// </param>
        /// <param name="fCredentialUse">A flag that indicates how these credentials will be used.</param>
        /// <param name="pvLogonId">
        /// <para>A pointer to a <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/l-gly">locally unique identifier</a> (<see cref="LUID"/>) that identifies the user. This parameter is provided for file-system processes such as network redirectors. This parameter can be <see langword="null"/>.</para>
        /// <para>When using the Schannel SSP, this parameter is not used and should be set to <see langword="default"/>.</para>
        /// </param>
        /// <param name="pAuthData">
        /// <para>A pointer to package-specific data. This parameter can be <see cref="IntPtr.Zero"/>, which indicates that the default credentials for that <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">security package</a> must be used. To use supplied credentials, pass a <see cref="SEC_WINNT_AUTH_IDENTITY"/> structure that includes those credentials in this parameter. The RPC run time passes whatever was provided in <see cref="RpcBindingSetAuthInfo"/>.</para>
        /// <para>When using the Digest SSP, this parameter is a pointer to a <see cref="SEC_WINNT_AUTH_IDENTITY"/> structure that contains authentication information to use to locate the credentials.</para>
        /// <para>When using the Schannel SSP, specify an <see cref="SCHANNEL_CRED"/> structure that indicates the protocol to use and the settings for various customizable channel features.</para>
        /// <para>When using the NTLM or Negotiate packages, the maximum character lengths for user name, password, and domain are 256, 256, and 15, respectively.</para>
        /// </param>
        /// <param name="pGetKeyFn">This parameter is not used and should be set to <see langword="null"/>.</param>
        /// <param name="pvGetKeyArgument">This parameter is not used and should be set to <see cref="IntPtr.Zero"/>.</param>
        /// <param name="phCredential">A <see cref="CredHandle"/> structure to receive the credential handle.</param>
        /// <param name="ptsExpiry">
        /// <para>A <see cref="TimeStamp"/> structure that receives the time at which the returned credentials expire. The value returned in this <see cref="TimeStamp"/> structure depends on the <em><a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a></em>. The <em><a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">security package</a></em> must return this value in local time.</para>
        /// <para>This parameter is set to a constant maximum time. There is no expiration time for Digest <em><a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">security context</a></em>s or credentials or when using the Digest SSP.</para>
        /// <para>When using the Schannel SSP, this parameter is optional. When the credential to be used for authentication is a certificate, this parameter receives the expiration time for that certificate. If no certificate was supplied, then a maximum time value is returned.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SEC_E_OK"/>.</para>
        /// <para>
        /// If the function fails, it returns one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><see cref="SEC_E_INSUFFICIENT_MEMORY"/></term><description>There is not enough memory available to complete the requested action.</description></item>
        /// <item><term><see cref="SEC_E_INTERNAL_ERROR"/></term><description>An error occurred that did not map to an SSPI error code.</description></item>
        /// <item><term><see cref="SEC_E_NO_CREDENTIALS"/></term><description>No credentials are available in the <em><a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a></em>.</description></item>
        /// <item><term><see cref="SEC_E_NOT_OWNER"/></term><description>The caller of the function does not have the necessary credentials.</description></item>
        /// <item><term><see cref="SEC_E_SECPKG_NOT_FOUND"/></term><description>The requested <em><a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">security package</a></em> does not exist.</description></item>
        /// <item><term><see cref="SEC_E_UNKNOWN_CREDENTIALS"/></term><description>The credentials supplied to the package were not recognized.</description></item>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="AcquireCredentialsHandle"/> (General) function returns a handle to the credentials of a principal, such as a user or client, as used by a specific <em><a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a></em>. This can be the handle to preexisting credentials, or the function can create a new set of credentials and return it. This handle can be used in subsequent calls to the <see cref="AcceptSecurityContext"/> (General) and <see cref="InitializeSecurityContext"/> (General) functions.</para>
        /// <para>In general, <see cref="AcquireCredentialsHandle"/> (General) does not allow a process to obtain a handle to the credentials of other users logged on to the same computer. However, a caller with <see cref="SE_TCB_NAME"/> <em><a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">privilege</a></em> has the option of specifying the <em><a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/l-gly">logon identifier</a></em> (<see cref="LUID"/>) of any existing logon session token to get a handle to that session's credentials. Typically, this is used by kernel-mode modules that must act on behalf of a logged-on user.</para>
        /// <para>A package might call the function in <paramref name="pGetKeyFn"/> provided by the RPC run-time transport. If the transport does not support the notion of callback to retrieve credentials, this parameter must be <see langword="null"/>.</para>
        /// <para>When you have finished using the returned credentials, free the memory used by the credentials by calling the <see cref="FreeCredentialsHandle"/> function.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/secauthn/acquirecredentialshandle--general">AcquireCredentialsHandle (General) function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/en-us/windows/win32/secauthn/authentication-functions#sspi-functions">SSPI Functions</seealso>
        /// <seealso cref="AcceptSecurityContext"/>
        /// <seealso cref="InitializeSecurityContext"/>
        /// <seealso cref="FreeCredentialsHandle"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int AcquireCredentialsHandle(
            [In, Optional] LPCTSTR pszPrincipal,         // Name of principal
            [In] LPCTSTR pszPackage,                     // Name of package
            [In, MarshalAs(UnmanagedType.U4)]
            SECPKG_CRED_USE fCredentialUse,             // Flags indicating use
            [In, Optional] in LUID pvLogonId,           // Pointer to logon ID
            [In, Optional] IntPtr pAuthData,            // Package specific data
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
            SEC_GET_KEY_FN pGetKeyFn,                // Pointer to GetKey() func
            [In, Optional] IntPtr pvGetKeyArgument,  // Value to pass to GetKey()
            out CredHandle phCredential,             // (out) Cred Handle
            [Optional] out TimeStamp ptsExpiry       // (out) Lifetime (optional)
            );

#if !NETSTANDARD1_6
        /// <inheritdoc cref="AcquireCredentialsHandle(LPCTSTR, LPCTSTR, SECPKG_CRED_USE, in LUID, IntPtr, SEC_GET_KEY_FN, IntPtr, out CredHandle, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int AcquireCredentialsHandle(
            [In, Optional] string pszPrincipal,         // Name of principal
            [In] string pszPackage,                     // Name of package
            [In, MarshalAs(UnmanagedType.U4)]
            SECPKG_CRED_USE fCredentialUse,             // Flags indicating use
            [In, Optional] in LUID pvLogonId,           // Pointer to logon ID
            [In, Optional] IntPtr pAuthData,            // Package specific data
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
            SEC_GET_KEY_FN pGetKeyFn,                // Pointer to GetKey() func
            [In, Optional] IntPtr pvGetKeyArgument,  // Value to pass to GetKey()
            out CredHandle phCredential,             // (out) Cred Handle
            [Optional] out TimeStamp ptsExpiry       // (out) Lifetime (optional)
            );
#endif // !NETSTANDARD1_6
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1240
        #region FreeCredentialsHandle function
        /// <summary>
        /// <para>The <see cref="FreeCredentialsHandle"/> function notifies the security system that the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">credentials</a> are no longer needed. An application calls this function to free the credential handle acquired in the call to the <see cref="AcquireCredentialsHandle"/> (General) function after calling the <see cref="DeleteSecurityContext"/> function to free any context handles associated with the credential. When all references to this credential set have been removed, the credentials themselves can be removed.</para>
        /// <para>Failure to free credentials handles will result in memory leaks.</para>
        /// </summary>
        /// <param name="phCredential">
        /// A handle obtained by using the <see cref="AcquireCredentialsHandle"/> (General) function.
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SEC_E_OK"/>.</para>
        /// <para>
        /// If the function fails, it returns the following error code.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><see cref="SEC_E_INVALID_HANDLE"/></term><description>The handle passed to the function is not valid.</description></item>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/nf-sspi-freecredentialshandle">FreeCredentialsHandle function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="AcquireCredentialsHandle"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-functions">SSPI Functions</seealso>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int FreeCredentialsHandle(
            [In] in CredHandle phCredential            // Handle to free
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1250
        #region AddCredentialsW function
        /// <inheritdoc cref="AddCredentials(in CredHandle, LPCTSTR, LPCTSTR, SECPKG_CRED_USE, IntPtr, SEC_GET_KEY_FN, IntPtr, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int AddCredentialsW(
            [In] in CredHandle hCredentials,
            [In, Optional] LPCWSTR pszPrincipal,    // Name of principal
            [In] LPCWSTR pszPackage,                // Name of package
            [In, MarshalAs(UnmanagedType.U4)]
            SECPKG_CRED_USE fCredentialUse,         // Flags indicating use
            [In, Optional] IntPtr pAuthData,        // Package specific data
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
            SEC_GET_KEY_FN pGetKeyFn,               // Pointer to GetKey() func
            [In, Optional] IntPtr pvGetKeyArgument, // Value to pass to GetKey()
            [Optional] out TimeStamp ptsExpiry      // (out) Lifetime (optional)
            );

        /// <inheritdoc cref="AddCredentialsW(in CredHandle, LPCWSTR, LPCWSTR, SECPKG_CRED_USE, IntPtr, SEC_GET_KEY_FN, IntPtr, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int AddCredentialsW(
            [In] in CredHandle hCredentials,
            [In, Optional] string pszPrincipal,    // Name of principal
            [In] string pszPackage,                // Name of package
            [In, MarshalAs(UnmanagedType.U4)]
            SECPKG_CRED_USE fCredentialUse,         // Flags indicating use
            [In, Optional] IntPtr pAuthData,        // Package specific data
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
            SEC_GET_KEY_FN pGetKeyFn,               // Pointer to GetKey() func
            [In, Optional] IntPtr pvGetKeyArgument, // Value to pass to GetKey()
            [Optional] out TimeStamp ptsExpiry      // (out) Lifetime (optional)
            );

        /// <inheritdoc cref="AddCredentialsW(in CredHandle, LPCWSTR, LPCWSTR, SECPKG_CRED_USE, IntPtr, SEC_GET_KEY_FN, IntPtr, out TimeStamp)"/>
        public static unsafe int AddCredentialsW(
            in CredHandle hCredentials,
            ReadOnlySpan<char> pszPrincipal, // Name of principal
            ReadOnlySpan<char> pszPackage,   // Name of package
            SECPKG_CRED_USE fCredentialUse,  // Flags indicating use
            IntPtr pAuthData,                // Package specific data
            SEC_GET_KEY_FN pGetKeyFn,        // Pointer to GetKey() func
            IntPtr pvGetKeyArgument,         // Value to pass to GetKey()
            out TimeStamp ptsExpiry          // (out) Lifetime (optional)
            )
        {
            fixed (char* pszPrincipalPtr = pszPrincipal)
            fixed (char* pszPackagePtr = pszPackage)
                return AddCredentialsW(
                    hCredentials,
                    Pointer.Create<LPCWSTR>(pszPrincipalPtr),
                    Pointer.Create<LPCWSTR>(pszPackagePtr),
                    fCredentialUse, pAuthData, pGetKeyFn, pvGetKeyArgument,
                    out ptsExpiry
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1284
        #region AddCredentialsA function
        /// <inheritdoc cref="AddCredentials(in CredHandle, LPCTSTR, LPCTSTR, SECPKG_CRED_USE, IntPtr, SEC_GET_KEY_FN, IntPtr, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int AddCredentialsA(
            [In] in CredHandle hCredentials,
            [In, Optional] LPCSTR pszPrincipal,    // Name of principal
            [In] LPCSTR pszPackage,                // Name of package
            [In, MarshalAs(UnmanagedType.U4)]
            SECPKG_CRED_USE fCredentialUse,         // Flags indicating use
            [In, Optional] IntPtr pAuthData,        // Package specific data
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
            SEC_GET_KEY_FN pGetKeyFn,               // Pointer to GetKey() func
            [In, Optional] IntPtr pvGetKeyArgument, // Value to pass to GetKey()
            [Optional] out TimeStamp ptsExpiry      // (out) Lifetime (optional)
            );

        /// <inheritdoc cref="AddCredentialsA(in CredHandle, LPCSTR, LPCSTR, SECPKG_CRED_USE, IntPtr, SEC_GET_KEY_FN, IntPtr, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int AddCredentialsA(
            [In] in CredHandle hCredentials,
            [In, Optional] string pszPrincipal,    // Name of principal
            [In] string pszPackage,                // Name of package
            [In, MarshalAs(UnmanagedType.U4)]
            SECPKG_CRED_USE fCredentialUse,         // Flags indicating use
            [In, Optional] IntPtr pAuthData,        // Package specific data
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
            SEC_GET_KEY_FN pGetKeyFn,               // Pointer to GetKey() func
            [In, Optional] IntPtr pvGetKeyArgument, // Value to pass to GetKey()
            [Optional] out TimeStamp ptsExpiry      // (out) Lifetime (optional)
            );

        /// <inheritdoc cref="AddCredentialsA(in CredHandle, LPCSTR, LPCSTR, SECPKG_CRED_USE, IntPtr, SEC_GET_KEY_FN, IntPtr, out TimeStamp)"/>
        public static unsafe int AddCredentialsA(
            in CredHandle hCredentials,
            ReadOnlySpan<byte> pszPrincipal, // Name of principal
            ReadOnlySpan<byte> pszPackage,   // Name of package
            SECPKG_CRED_USE fCredentialUse,  // Flags indicating use
            IntPtr pAuthData,                // Package specific data
            SEC_GET_KEY_FN pGetKeyFn,        // Pointer to GetKey() func
            IntPtr pvGetKeyArgument,         // Value to pass to GetKey()
            out TimeStamp ptsExpiry          // (out) Lifetime (optional)
            )
        {
            fixed (byte* pszPrincipalPtr = pszPrincipal)
            fixed (byte* pszPackagePtr = pszPackage)
                return AddCredentialsA(
                    hCredentials,
                    Pointer.Create<LPCSTR>(pszPrincipalPtr),
                    Pointer.Create<LPCSTR>(pszPackagePtr),
                    fCredentialUse, pAuthData, pGetKeyFn, pvGetKeyArgument,
                    out ptsExpiry
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1307
        #region AddCredentials function
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int AddCredentials(
            [In] in CredHandle hCredentials,
            [In, Optional] LPCTSTR pszPrincipal,    // Name of principal
            [In] LPCTSTR pszPackage,                // Name of package
            [In, MarshalAs(UnmanagedType.U4)]
            SECPKG_CRED_USE fCredentialUse,         // Flags indicating use
            [In, Optional] IntPtr pAuthData,        // Package specific data
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
            SEC_GET_KEY_FN pGetKeyFn,               // Pointer to GetKey() func
            [In, Optional] IntPtr pvGetKeyArgument, // Value to pass to GetKey()
            [Optional] out TimeStamp ptsExpiry      // (out) Lifetime (optional)
            );

#if !NETSTANDARD1_6
        /// <inheritdoc cref="AddCredentials(in CredHandle, LPCTSTR, LPCTSTR, SECPKG_CRED_USE, IntPtr, SEC_GET_KEY_FN, IntPtr, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int AddCredentials(
            [In] in CredHandle hCredentials,
            [In, Optional] string pszPrincipal,    // Name of principal
            [In] string pszPackage,                // Name of package
            [In, MarshalAs(UnmanagedType.U4)]
            SECPKG_CRED_USE fCredentialUse,         // Flags indicating use
            [In, Optional] IntPtr pAuthData,        // Package specific data
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)]
            SEC_GET_KEY_FN pGetKeyFn,               // Pointer to GetKey() func
            [In, Optional] IntPtr pvGetKeyArgument, // Value to pass to GetKey()
            [Optional] out TimeStamp ptsExpiry      // (out) Lifetime (optional)
            );
#endif // !NETSTANDARD1_6
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1500
        #region ChangeAccountPasswordW function
        /// <inheritdoc cref="ChangeAccountPassword(LPCTSTR, LPCTSTR, LPCTSTR, LPCTSTR, LPCTSTR, bool, int, ref SecBufferDesc)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int ChangeAccountPasswordW(
            [In] LPCWSTR pszPackageName,
            [In] LPCWSTR pszDomainName,
            [In] LPCWSTR pszAccountName,
            [In] LPCWSTR pszOldPassword,
            [In] LPCWSTR pszNewPassword,
            [In, MarshalAs(UnmanagedType.U1)] bool bImpersonating,
            [In] int dwReserved,
            ref SecBufferDesc pOutput
            );

        /// <inheritdoc cref="ChangeAccountPasswordW(LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, bool, int, ref SecBufferDesc)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int ChangeAccountPasswordW(
            [In] string pszPackageName,
            [In] string pszDomainName,
            [In] string pszAccountName,
            [In] string pszOldPassword,
            [In] string pszNewPassword,
            [In, MarshalAs(UnmanagedType.U1)] bool bImpersonating,
            [In] int dwReserved,
            ref SecBufferDesc pOutput
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1526
        #region ChangeAccountPasswordA function
        /// <inheritdoc cref="ChangeAccountPassword(LPCTSTR, LPCTSTR, LPCTSTR, LPCTSTR, LPCTSTR, bool, int, ref SecBufferDesc)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int ChangeAccountPasswordA(
            [In] LPCSTR pszPackageName,
            [In] LPCSTR pszDomainName,
            [In] LPCSTR pszAccountName,
            [In] LPCSTR pszOldPassword,
            [In] LPCSTR pszNewPassword,
            [In, MarshalAs(UnmanagedType.U1)] bool bImpersonating,
            [In] int dwReserved,
            ref SecBufferDesc pOutput
            );

        /// <inheritdoc cref="ChangeAccountPasswordA(LPCSTR, LPCSTR, LPCSTR, LPCSTR, LPCSTR, bool, int, ref SecBufferDesc)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int ChangeAccountPasswordA(
            [In] string pszPackageName,
            [In] string pszDomainName,
            [In] string pszAccountName,
            [In] string pszOldPassword,
            [In] string pszNewPassword,
            [In, MarshalAs(UnmanagedType.U1)] bool bImpersonating,
            [In] int dwReserved,
            ref SecBufferDesc pOutput
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1550
        #region ChangeAccountPassword function
        /// <summary>
        /// <para>The <see cref="ChangeAccountPassword"/> function changes the password for a Windows domain account by using the specified <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/sspi">Security Support Provider</a>.</para>
        /// <para>This function is supported only by the <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/microsoft-kerberos">Microsoft Kerberos</a>, <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/microsoft-negotiate">Microsoft Negotiate</a>, and <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/microsoft-ntlm">Microsoft NTLM</a> providers.</para>
        /// </summary>
        /// <param name="pszPackageName">The name of the provider to use. The value of this parameter must be either <c>"Kerberos"</c>, <c>"Negotiate"</c>, or <c>"NTLM"</c>.</param>
        /// <param name="pszDomainName">The domain of the account for which to change the password.</param>
        /// <param name="pszAccountName">The user name of the account for which to change the password.</param>
        /// <param name="pszOldPassword">The old password to be changed.</param>
        /// <param name="pszNewPassword">The new password for the specified account.</param>
        /// <param name="bImpersonating"><see langword="true"/> if the calling process is running as the client; otherwise, <see langword="false"/>.</param>
        /// <param name="dwReserved">Reserved. Must be set to zero.</param>
        /// <param name="pOutput">On input, a reference to a <see cref="SecBufferDesc"/> structure. The <see cref="SecBufferDesc"/> structure must contain a single buffer of type <see cref="SECBUFFER_CHANGE_PASS_RESPONSE"/>. On output, the <see cref="SecBufferDesc.Buffers"/> member of that structure points to a <see cref="DOMAIN_PASSWORD_INFORMATION"/> structure.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SEC_E_OK"/>.</para>
        /// <para>If the function fails, it returns an error code.</para>
        /// </returns>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/nf-sspi-changeaccountpasswordw">ChangeAccountPasswordW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int ChangeAccountPassword(
            [In] LPCTSTR pszPackageName,
            [In] LPCTSTR pszDomainName,
            [In] LPCTSTR pszAccountName,
            [In] LPCTSTR pszOldPassword,
            [In] LPCTSTR pszNewPassword,
            [In, MarshalAs(UnmanagedType.U1)] bool bImpersonating,
            [In] int dwReserved,
            ref SecBufferDesc pOutput
            );

#if !NETSTANDARD1_6
        /// <inheritdoc cref="ChangeAccountPassword(LPCTSTR, LPCTSTR, LPCTSTR, LPCTSTR, LPCTSTR, bool, int, ref SecBufferDesc)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int ChangeAccountPassword(
            [In] string pszPackageName,
            [In] string pszDomainName,
            [In] string pszAccountName,
            [In] string pszOldPassword,
            [In] string pszNewPassword,
            [In, MarshalAs(UnmanagedType.U1)] bool bImpersonating,
            [In] int dwReserved,
            ref SecBufferDesc pOutput
            );
#endif // !NETSTANDARD1_6
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1561
        #region InitializeSecurityContextW function
        /// <inheritdoc cref="InitializeSecurityContext(in CredHandle, in CtxtHandle, LPCTSTR, ISC_REQ_FLAGS, int, SECURITY_DREP_TYPE, in SecBufferDesc, int, ref CtxtHandle, ref SecBufferDesc, out ISC_RET_FLAGS, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int InitializeSecurityContextW(
            [Optional] in CredHandle phCredential,  // Cred to base context
            [Optional] in CtxtHandle phContext,     // Existing context (OPT)
            [In, Optional] LPCWSTR pszTargetName,   // Name of target
            [In, MarshalAs(UnmanagedType.U4)]
            ISC_REQ_FLAGS fContextReq,              // Context Requirements
            [In] int Reserved1,                     // Reserved, MBZ
            [In, MarshalAs(UnmanagedType.U4)]
            SECURITY_DREP_TYPE TargetDataRep,       // Data rep of target
            [Optional] in SecBufferDesc pInput,     // Input Buffers
            [In] int Reserved2,                     // Reserved, MBZ
            [Optional] ref CtxtHandle phNewContext, // (out) New Context handle
            [Optional] ref SecBufferDesc pOutput,   // (inout) Output Buffers
            [MarshalAs(UnmanagedType.U4)]
            out ISC_RET_FLAGS pfContextAttr,        // (out) Context attrs
            [Optional] out TimeStamp ptsExpiry      // (out) Life span (OPT)
            );

        /// <inheritdoc cref="InitializeSecurityContextW(in CredHandle, in CtxtHandle, LPCWSTR, ISC_REQ_FLAGS, int, SECURITY_DREP_TYPE, in SecBufferDesc, int, ref CtxtHandle, ref SecBufferDesc, out ISC_RET_FLAGS, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int InitializeSecurityContextW(
            [Optional] in CredHandle phCredential,  // Cred to base context
            [Optional] in CtxtHandle phContext,     // Existing context (OPT)
            [In, Optional] string pszTargetName,    // Name of target
            [In, MarshalAs(UnmanagedType.U4)]
            ISC_REQ_FLAGS fContextReq,              // Context Requirements
            [In] int Reserved1,                     // Reserved, MBZ
            [In, MarshalAs(UnmanagedType.U4)]
            SECURITY_DREP_TYPE TargetDataRep,       // Data rep of target
            [Optional] in SecBufferDesc pInput,     // Input Buffers
            [In] int Reserved2,                     // Reserved, MBZ
            [Optional] ref CtxtHandle phNewContext, // (out) New Context handle
            [Optional] ref SecBufferDesc pOutput,   // (inout) Output Buffers
            [MarshalAs(UnmanagedType.U4)]
            out ISC_RET_FLAGS pfContextAttr,        // (out) Context attrs
            [Optional] out TimeStamp ptsExpiry      // (out) Life span (OPT)
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1609
        #region InitializeSecurityContextA function
        /// <inheritdoc cref="InitializeSecurityContext(in CredHandle, in CtxtHandle, LPCTSTR, ISC_REQ_FLAGS, int, SECURITY_DREP_TYPE, in SecBufferDesc, int, ref CtxtHandle, ref SecBufferDesc, out ISC_RET_FLAGS, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int InitializeSecurityContextA(
            [Optional] in CredHandle phCredential,  // Cred to base context
            [Optional] in CtxtHandle phContext,     // Existing context (OPT)
            [In, Optional] LPCSTR pszTargetName,   // Name of target
            [In, MarshalAs(UnmanagedType.U4)]
            ISC_REQ_FLAGS fContextReq,              // Context Requirements
            [In] int Reserved1,                     // Reserved, MBZ
            [In, MarshalAs(UnmanagedType.U4)]
            SECURITY_DREP_TYPE TargetDataRep,       // Data rep of target
            [Optional] in SecBufferDesc pInput,     // Input Buffers
            [In] int Reserved2,                     // Reserved, MBZ
            [Optional] ref CtxtHandle phNewContext, // (out) New Context handle
            [Optional] ref SecBufferDesc pOutput,   // (inout) Output Buffers
            [MarshalAs(UnmanagedType.U4)]
            out ISC_RET_FLAGS pfContextAttr,        // (out) Context attrs
            [Optional] out TimeStamp ptsExpiry      // (out) Life span (OPT)
            );

        /// <inheritdoc cref="InitializeSecurityContextA(in CredHandle, in CtxtHandle, LPCSTR, ISC_REQ_FLAGS, int, SECURITY_DREP_TYPE, in SecBufferDesc, int, ref CtxtHandle, ref SecBufferDesc, out ISC_RET_FLAGS, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int InitializeSecurityContextA(
            [Optional] in CredHandle phCredential,  // Cred to base context
            [Optional] in CtxtHandle phContext,     // Existing context (OPT)
            [In, Optional] string pszTargetName,    // Name of target
            [In, MarshalAs(UnmanagedType.U4)]
            ISC_REQ_FLAGS fContextReq,              // Context Requirements
            [In] int Reserved1,                     // Reserved, MBZ
            [In, MarshalAs(UnmanagedType.U4)]
            SECURITY_DREP_TYPE TargetDataRep,       // Data rep of target
            [Optional] in SecBufferDesc pInput,     // Input Buffers
            [In] int Reserved2,                     // Reserved, MBZ
            [Optional] ref CtxtHandle phNewContext, // (out) New Context handle
            [Optional] ref SecBufferDesc pOutput,   // (inout) Output Buffers
            [MarshalAs(UnmanagedType.U4)]
            out ISC_RET_FLAGS pfContextAttr,        // (out) Context attrs
            [Optional] out TimeStamp ptsExpiry      // (out) Life span (OPT)
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1640
        #region InitializeSecurityContextW function
        /// <summary>
        /// <para>The <see cref="InitializeSecurityContext"/> (General) function initiates the client side, outbound <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a> from a credential handle. The function is used to build a security context between the client application and a remote peer. <see cref="InitializeSecurityContext"/> (General) returns a token that the client must pass to the remote peer, which the peer in turn submits to the local security implementation through the <see cref="AcceptSecurityContext"/> (General) call. The token generated should be considered opaque by all callers.</para>
        /// <para>Typically, the <see cref="InitializeSecurityContext"/> (General) function is called in a loop until a sufficient security context is established.</para>
        /// </summary>
        /// <param name="phCredential">A handle to the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">credentials</a> returned by <see cref="AcquireCredentialsHandle"/> (General). This handle is used to build the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a>. The <see cref="InitializeSecurityContext"/> (General) function requires at least OUTBOUND credentials.</param>
        /// <param name="phContext">
        /// <para>A <see cref="CtxtHandle"/> structure. On the first call to <see cref="InitializeSecurityContext"/> (General), this pointer is <see langword="null"/>. On the second call, this parameter is the handle to the partially formed context returned in the <paramref name="phNewContext"/> parameter by the first call.</para>
        /// <para>This parameter is optional with the Microsoft Digest SSP and can be set to <see langword="null"/>.</para>
        /// <para>When using the Schannel SSP, on the first call to <see cref="InitializeSecurityContext"/> (General), specify <see langword="null"/>. On future calls, specify the token received in the <paramref name="phNewContext"/> parameter after the first call to this function.</para>
        /// </param>
        /// <param name="pszTargetName"/>
        /// <param name="fContextReq">
        /// <para>Bit flags that indicate requests for the context. Not all packages can support all requirements.</para>
        /// <para>The requested attributes may not be supported by the client. For more information, see the <paramref name="pfContextAttr"/> parameter.</para>
        /// <para>For further descriptions of the various attributes, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/context-requirements">Context Requirements</a>.</para>
        /// </param>
        /// <param name="Reserved1">This parameter is reserved and must be set to zero.</param>
        /// <param name="TargetDataRep">
        /// <para>The data representation, such as byte ordering, on the target. This parameter can be either <see cref="SECURITY_NATIVE_DREP"/> or <see cref="SECURITY_NETWORK_DREP"/>.</para>
        /// <para>This parameter is not used with Digest or Schannel. Set it to zero.</para>
        /// </param>
        /// <param name="pInput">A <see cref="SecBufferDesc"/> structure that contains pointers to the buffers supplied as input to the package. Unless the client context was initiated by the server, the value of this parameter must be <see langword="null"/> on the first call to the function. On subsequent calls to the function or when the client context was initiated by the server, the value of this parameter is a pointer to a buffer allocated with enough memory to hold the token returned by the remote computer.</param>
        /// <param name="Reserved2">This parameter is reserved and must be set to zero.</param>
        /// <param name="phNewContext">
        /// <para>A reference to a <see cref="CtxtHandle"/> structure. On the first call to <see cref="InitializeSecurityContext"/> (General), this variable receives the new context handle. On the second call, <paramref name="phNewContext"/> can be the same as the handle specified in the <paramref name="phContext"/> parameter.</para>
        /// <para>When using the Schannel SSP, on calls after the first call, pass the handle returned here as the <paramref name="phContext"/> parameter and specify <see langword="null"/> for <paramref name="phNewContext"/>.</para>
        /// </param>
        /// <param name="pOutput">
        /// <para>A reference to a <see cref="SecBufferDesc"/> structure that contains pointers to the <see cref="SecBuffer"/> structure that receives the output data. If a buffer was typed as <see cref="SEC_READWRITE"/> in the input, it will be there on output. The system will allocate a buffer for the security token if requested (through <see cref="ISC_REQ_ALLOCATE_MEMORY"/>) and fill in the address in the buffer descriptor for the security token.</para>
        /// <para>When using the Microsoft Digest SSP, this parameter receives the challenge response that must be sent to the server.</para>
        /// <para>When using the Schannel SSP, if the <see cref="ISC_REQ_ALLOCATE_MEMORY"/> flag is specified, the Schannel SSP will allocate memory for the buffer and put the appropriate information in the <see cref="SecBufferDesc"/>. In addition, the caller must pass in a buffer of type <see cref="SECBUFFER_ALERT"/>. On output, if an alert is generated, this buffer contains information about that alert, and the function fails.</para>
        /// </param>
        /// <param name="pfContextAttr">
        /// <para>A variable to receive a set of bit flags that indicate the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">attributes</a> of the established <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">context</a>. For a description of the various attributes, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/context-requirements">Context Requirements</a>.</para>
        /// <para>Do not check for security-related attributes until the final function call returns successfully. Attribute flags that are not related to security, such as the <see cref="ASC_RET_ALLOCATED_MEMORY"/> flag, can be checked before the final return.</para>
        /// <para><note>Particular context attributes can change during negotiation with a remote peer.</note></para>
        /// </param>
        /// <param name="ptsExpiry">
        /// <para>A <see cref="TimeStamp"/> structure that receives the expiration time of the context. It is recommended that the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a> always return this value in local time. This parameter is optional and should be ignored for short-lived clients.</para>
        /// <para>There is no expiration time for Microsoft Digest SSP security contexts or <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">credentials</a>.</para>
        /// </param>
        /// <returns>
        /// <para>
        /// If the function succeeds, the function returns one of the following success codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><see cref="SEC_I_COMPLETE_AND_CONTINUE"/></term><description> The client must call <see cref="CompleteAuthToken"/> and then pass the output to the server. The client then waits for a returned token and passes it, in another call, to <see cref="InitializeSecurityContext"/> (General).</description></item>
        /// <item><term><see cref="SEC_I_COMPLETE_NEEDED"/></term><description> The client must finish building the message and then call the <see cref="CompleteAuthToken"/> function. </description></item>
        /// <item><term><see cref="SEC_I_CONTINUE_NEEDED"/></term><description> The client must send the output token to the server and wait for a return token. The returned token is then passed in another call to <see cref="InitializeSecurityContext"/> (General). The output token can be empty.</description></item>
        /// <item><term><see cref="SEC_I_INCOMPLETE_CREDENTIALS"/></term><description> Use with Schannel. The server has requested client authentication, and the supplied credentials either do not include a certificate or the certificate was not issued by a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">certification authority</a> that is trusted by the server. For more information, see Remarks.</description></item>
        /// <item><term><see cref="SEC_E_INCOMPLETE_MESSAGE"/></term><description> Use with Schannel. Data for the whole message was not read from the wire.<br/>When this value is returned, the <paramref name="pInput"/> buffer contains a <see cref="SecBuffer"/> structure with a <see cref="SecBuffer.BufferType"/> member of <see cref="SECBUFFER_MISSING"/>.The <see cref="SecBuffer.cbBuffer"/> member of <see cref="SecBuffer"/> contains a value that indicates the number of additional bytes that the function must read from the client before this function succeeds. While this number is not always accurate, using it can help improve performance by avoiding multiple calls to this function.</description></item>
        /// <item><term><see cref="SEC_E_OK"/></term><description> The <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a> was successfully initialized. There is no need for another <see cref="InitializeSecurityContext"/> (General) call. If the function returns an output token, that is, if the <see cref="SECBUFFER_TOKEN"/> in <paramref name="pOutput"/> is of nonzero length, that token must be sent to the server.</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// If the function fails, the function returns one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><see cref="SEC_E_INSUFFICIENT_MEMORY"/></term><description>There is not enough memory available to complete the requested action. </description></item>
        /// <item><term><see cref="SEC_E_INTERNAL_ERROR"/></term><description>An error occurred that did not map to an SSPI error code. </description></item>
        /// <item><term><see cref="SEC_E_INVALID_HANDLE"/></term><description>The handle passed to the function is not valid. </description></item>
        /// <item><term><see cref="SEC_E_INVALID_TOKEN"/></term><description>The error is due to a malformed input token, such as a token corrupted in transit, a token of incorrect size, or a token passed into the wrong security package. Passing a token to the wrong package can happen if the client and server did not negotiate the proper security package. </description></item>
        /// <item><term><see cref="SEC_E_LOGON_DENIED"/></term><description>The logon failed. </description></item>
        /// <item><term><see cref="SEC_E_NO_AUTHENTICATING_AUTHORITY"/></term><description> No authority could be contacted for authentication. The domain name of the authenticating party could be wrong, the domain could be unreachable, or there might have been a trust relationship failure. </description></item>
        /// <item><term><see cref="SEC_E_NO_CREDENTIALS"/></term><description>No credentials are available in the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a>. </description></item>
        /// <item><term><see cref="SEC_E_TARGET_UNKNOWN"/></term><description>The target was not recognized. </description></item>
        /// <item><term><see cref="SEC_E_UNSUPPORTED_FUNCTION"/></term><description>A context attribute flag that is not valid (<see cref="ISC_REQ_DELEGATE"/> or <see cref="ISC_REQ_PROMPT_FOR_CREDS"/>) was specified in the <paramref name="fContextReq"/> parameter. </description></item>
        /// <item><term><see cref="SEC_E_WRONG_PRINCIPAL"/></term><description> The principal that received the authentication request is not the same as the one passed into the <paramref name="pszTargetName"/> parameter. This indicates a failure in mutual authentication. </description></item>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The caller is responsible for determining whether the final context attributes are sufficient. If, for example, confidentiality was requested, but could not be established, some applications may choose to shut down the connection immediately.</para>
        /// <para>If attributes of the security context are not sufficient, the client must free the partially created context by calling the <see cref="DeleteSecurityContext"/> function.</para>
        /// <para>The <see cref="InitializeSecurityContext"/> (General) function is used by a client to initialize an outbound context.</para>
        /// <para>
        /// For a two-leg security context, the calling sequence is as follows:
        /// <list type="number">
        /// <item>The client calls the function with <paramref name="phContext"/> set to <see langword="null"/> and fills in the buffer descriptor with the input message.</item>
        /// <item>The security package examines the parameters and constructs an opaque token, placing it in the TOKEN element in the buffer array. If the <paramref name="fContextReq"/> parameter includes the <see cref="ISC_REQ_ALLOCATE_MEMORY"/> flag, the security package allocates the memory and returns the pointer in the TOKEN element.</item>
        /// <item>The client sends the token returned in the <paramref name="pOutput"/> buffer to the target server. The server then passes the token as an input argument in a call to the <see cref="AcceptSecurityContext"/> (General) function.</item>
        /// <item><see cref="AcceptSecurityContext"/> (General) may return a token, which the server sends to the client for a second call to <see cref="InitializeSecurityContext"/> (General) if the first call returned <see cref="SEC_I_CONTINUE_NEEDED"/>.</item>
        /// </list>
        /// </para>
        /// <para>
        /// For multiple-leg security contexts, such as mutual authentication, the calling sequence is as follows:
        /// <list type="number">
        /// <item>The client calls the function as described earlier, but the package returns the <see cref="SEC_I_CONTINUE_NEEDED"/> success code.</item>
        /// <item>The client sends the output token to the server and waits for the server's reply.</item>
        /// <item>Upon receipt of the server's response, the client calls <see cref="InitializeSecurityContext"/> (General) again, with <paramref name="phContext"/> set to the handle that was returned from the last call. The token received from the server is supplied in the <paramref name="pInput"/> parameter.</item>
        /// </list>
        /// </para>
        /// <para>If the server has successfully responded, the security package returns <see cref="SEC_E_OK"/> and a secure session is established. </para>
        /// <para>If the function returns one of the error responses, the server's response is not accepted, and the session is not established.</para>
        /// <para>If the function returns <see cref="SEC_I_CONTINUE_NEEDED"/>, <see cref="SEC_I_COMPLETE_NEEDED"/>, or <see cref="SEC_I_COMPLETE_AND_CONTINUE"/>, steps 2 and 3 are repeated.</para>
        /// <para>To initialize a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a>, more than one call to this function may be required, depending on the underlying authentication mechanism as well as the choices specified in the <paramref name="fContextReq"/> parameter.</para>
        /// <para>The <paramref name="fContextReq"/> and <paramref name="pfContextAttr"/> parameters are bitmasks that represent various context attributes. For a description of the various attributes, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/context-requirements">Context Requirements</a>. The <paramref name="pfContextAttr"/> parameter is valid on any successful return, but only on the final successful return should you examine the flags that pertain to security aspects of the context. Intermediate returns can set, for example, the <see cref="ISC_RET_ALLOCATED_MEMORY"/> flag.</para>
        /// <para>If the <see cref="ISC_REQ_USE_SUPPLIED_CREDS"/> flag is set, the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a> must look for a <see cref="SECBUFFER_PKG_PARAMS"/> buffer type in the <paramref name="pInput"/> input buffer. This is not a generic solution, but it allows for a strong pairing of security package and application when appropriate.</para>
        /// <para>If <see cref="ISC_REQ_ALLOCATE_MEMORY"/> was specified, the caller must free the memory by calling the <see cref="FreeContextBuffer"/> function.</para>
        /// <para>For example, the input token could be the challenge from a LAN Manager. In this case, the output token would be the NTLM-encrypted response to the challenge.</para>
        /// <para>The action the client takes depends on the return code from this function. If the return code is <see cref="SEC_E_OK"/>, there will be no second <see cref="InitializeSecurityContext"/> (General) call, and no response from the server is expected. If the return code is <see cref="SEC_I_CONTINUE_NEEDED"/>, the client expects a token in response from the server and passes it in a second call to <see cref="InitializeSecurityContext"/> (General). The <see cref="SEC_I_COMPLETE_NEEDED"/> return code indicates that the client must finish building the message and call the <see cref="CompleteAuthToken"/> function. The <see cref="SEC_I_COMPLETE_AND_CONTINUE"/> code incorporates both of these actions.</para>
        /// <para>If <see cref="InitializeSecurityContext"/> (General) returns success on the first (or only) call, then the caller must eventually call the <see cref="DeleteSecurityContext"/> function on the returned handle, even if the call fails on a later leg of the authentication exchange.</para>
        /// <para>The client may call <see cref="InitializeSecurityContext"/> (General) again after it has completed successfully. This indicates to the security package that a reauthentication is wanted.</para>
        /// <para>Kernel mode callers have the following differences: the target name is a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/u-gly">Unicode</a> string that must be allocated in virtual memory by using <see cref="VirtualAlloc"/>; it must not be allocated from the pool. Buffers passed and supplied in <paramref name="pInput"/> and <paramref name="pOutput"/> must be in virtual memory, not in the pool.</para>
        /// <para>When using the Schannel SSP, if the function returns <see cref="SEC_I_INCOMPLETE_CREDENTIALS"/>, check that you specified a valid and trusted certificate in your credentials. The certificate is specified when calling the <see cref="AcquireCredentialsHandle"/> (General) function. The certificate must be a client authentication certificate issued by a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">certification authority</a> (CA) trusted by the server. To obtain a list of the CAs trusted by the server, call the <see cref="QueryContextAttributes"/> (General) function and specify the <see cref="SECPKG_ATTR_ISSUER_LIST_EX"/> attribute.</para>
        /// <para>When using the Schannel SSP, after a client application receives an authentication certificate from a CA that is trusted by the server, the application creates a new credential by calling the <see cref="AcquireCredentialsHandle"/> (General) function and then calling <see cref="InitializeSecurityContext"/> (General) again, specifying the new credential in the <paramref name="phCredential"/> parameter.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/nf-sspi-initializesecuritycontextw">InitializeSecurityContextW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="AcceptSecurityContext"/>
        /// <seealso cref="AcquireCredentialsHandle"/>
        /// <seealso cref="CompleteAuthToken"/>
        /// <seealso cref="DeleteSecurityContext"/>
        /// <seealso cref="FreeContextBuffer"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-functions">SSPI Functions</seealso>
        /// <seealso cref="SecBuffer"/>
        /// <seealso cref="SecBufferDesc"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int InitializeSecurityContext(
            [Optional] in CredHandle phCredential,  // Cred to base context
            [Optional] in CtxtHandle phContext,     // Existing context (OPT)
            [In, Optional] LPCTSTR pszTargetName,   // Name of target
            [In, MarshalAs(UnmanagedType.U4)]
            ISC_REQ_FLAGS fContextReq,              // Context Requirements
            [In] int Reserved1,                     // Reserved, MBZ
            [In, MarshalAs(UnmanagedType.U4)]
            SECURITY_DREP_TYPE TargetDataRep,       // Data rep of target
            [Optional] in SecBufferDesc pInput,     // Input Buffers
            [In] int Reserved2,                     // Reserved, MBZ
            [Optional] ref CtxtHandle phNewContext, // (out) New Context handle
            [Optional] ref SecBufferDesc pOutput,   // (inout) Output Buffers
            [MarshalAs(UnmanagedType.U4)]
            out ISC_RET_FLAGS pfContextAttr,        // (out) Context attrs
            [Optional] out TimeStamp ptsExpiry      // (out) Life span (OPT)
            );

#if !NETSTANDARD1_6
        /// <inheritdoc cref="InitializeSecurityContext(in CredHandle, in CtxtHandle, LPCTSTR, ISC_REQ_FLAGS, int, SECURITY_DREP_TYPE, in SecBufferDesc, int, ref CtxtHandle, ref SecBufferDesc, out ISC_RET_FLAGS, out TimeStamp)"/>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int InitializeSecurityContext(
            [Optional] in CredHandle phCredential,  // Cred to base context
            [Optional] in CtxtHandle phContext,     // Existing context (OPT)
            [In, Optional] string pszTargetName,    // Name of target
            [In, MarshalAs(UnmanagedType.U4)]
            ISC_REQ_FLAGS fContextReq,              // Context Requirements
            [In] int Reserved1,                     // Reserved, MBZ
            [In, MarshalAs(UnmanagedType.U4)]
            SECURITY_DREP_TYPE TargetDataRep,       // Data rep of target
            [Optional] in SecBufferDesc pInput,     // Input Buffers
            [In] int Reserved2,                     // Reserved, MBZ
            [Optional] ref CtxtHandle phNewContext, // (out) New Context handle
            [Optional] ref SecBufferDesc pOutput,   // (inout) Output Buffers
            [MarshalAs(UnmanagedType.U4)]
            out ISC_RET_FLAGS pfContextAttr,        // (out) Context attrs
            [Optional] out TimeStamp ptsExpiry      // (out) Life span (OPT)
            );
#endif // !NETSTANDARD1_6
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1650
        #region AcceptSecurityContext function
        /// <summary>
        /// The <see cref="AcceptSecurityContext"/> (CredSSP) function lets the server component of a transport application establish a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a> between the server and a remote client. The remote client calls the <see cref="InitializeSecurityContext"/> (CredSSP) function to start the process of establishing a security context. The server can require one or more reply tokens from the remote client to complete establishing the security context.
        /// </summary>
        /// <param name="phCredential">A handle to the server credentials. To retrieve this handle, the server calls the <see cref="AcquireCredentialsHandle"/> (CredSSP) function with either the <see cref="SECPKG_CRED_INBOUND"/> or <see cref="SECPKG_CRED_BOTH"/> flag set.</param>
        /// <param name="phContext">A <see cref="CtxtHandle"/> structure. On the first call to <see cref="AcceptSecurityContext"/> (CredSSP), this handle is <see langword="default"/>. On subsequent calls, <paramref name="phContext"/> specifies the partially formed context returned in the <paramref name="phCredential"/> parameter by the first call.</param>
        /// <param name="pInput">
        /// <para>A <see cref="SecBufferDesc"/> structure generated by a client call to <see cref="InitializeSecurityContext"/> (CredSSP). The structure contains the input buffer descriptor.</para>
        /// <para>The first buffer must be of type <see cref="SECBUFFER_TOKEN"/> and contain the security token received from the client. The second buffer should be of type <see cref="SECBUFFER_EMPTY"/>.</para>
        /// </param>
        /// <param name="fContextReq">
        /// <para>Bit flags that specify the attributes required by the server to establish the context. Bit flags can be combined by using bitwise-OR operations.</para>
        /// <para>The requested attributes may not be supported by the client. For more information, see the <paramref name="pfContextAttr"/> parameter.</para>
        /// </param>
        /// <param name="TargetDataRep">The data representation, such as byte ordering, on the target. This parameter can be either <see cref="SECURITY_NATIVE_DREP"/> or <see cref="SECURITY_NETWORK_DREP"/>.</param>
        /// <param name="phNewContext">A reference to a <see cref="CtxtHandle"/> structure. On the first call to <see cref="AcceptSecurityContext"/> (CredSSP), this handle receives the new context handle. On subsequent calls, <paramref name="phNewContext"/> can be the same as the handle specified in the <paramref name="phContext"/> parameter.</param>
        /// <param name="pOutput">
        /// <para>Reference to a <see cref="SecBufferDesc"/> structure that contains the output buffer descriptor. This buffer is sent to the client for input into additional calls to <see cref="InitializeSecurityContext"/> (CredSSP). An output buffer may be generated even if the function returns <see cref="SEC_E_OK"/>. Any buffer generated must be sent back to the client application.</para>
        /// <para>On output, this buffer receives a token for the security context. The token must be sent to the client. The function can also return a buffer of type <see cref="SECBUFFER_EXTRA"/>.</para>
        /// </param>
        /// <param name="pfContextAttr">
        /// <para>Receives a set of bit flags that indicate the attributes of the established context. For a description of the various attributes, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/context-requirements">Context Requirements</a>.</para>
        /// <para>Do not check for security-related attributes until the final function call returns successfully. Attribute flags not related to security, such as the <see cref="ASC_RET_ALLOCATED_MEMORY"/> flag, can be checked before the final return.</para>
        /// </param>
        /// <param name="ptsExpiry">
        /// <para>A <see cref="TimeStamp"/> structure that receives the expiration time of the context. We recommend that the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a> always return this value in local time.</para>
        /// <para><note>Until the last call of the authentication process, the expiration time for the context can be incorrect because more information will be provided during later stages of the negotiation. Therefore, <paramref name="ptsExpiry"/> must be ignored until the last call to the function.</note></para>
        /// </param>
        /// <returns>
        /// This function returns one of the following values.
        /// <list type="table">
        /// <listheader><term>Return code / value</term><description>Description</description></listheader>
        /// <item><term><see cref="SEC_E_INCOMPLETE_MESSAGE"/><br/><c>0x80090318</c></term><description>The function succeeded. The data in the input buffer is incomplete. The application must read additional data from the client and call <see cref="AcceptSecurityContext"/> (CredSSP) again.</description></item>
        /// <item><term><see cref="SEC_E_INSUFFICIENT_MEMORY"/><br/><c>0x80090300</c></term><description>The function failed. There is not enough memory available to complete the requested action.</description></item>
        /// <item><term><see cref="SEC_E_INTERNAL_ERROR"/><br/><c>0x80090304</c></term><description>The function failed. An error occurred that did not map to an SSPI error code.</description></item>
        /// <item><term><see cref="SEC_E_INVALID_HANDLE"/><br/><c>0x80100003</c></term><description>The function failed. The handle passed to the function is not valid.</description></item>
        /// <item><term><see cref="SEC_E_INVALID_TOKEN"/><br/><c>0x80090308</c></term><description>The function failed. The token passed to the function is not valid.</description></item>
        /// <item><term><see cref="SEC_E_LOGON_DENIED"/><br/><c>0x8009030C</c></term><description>The logon failed.</description></item>
        /// <item><term><see cref="SEC_E_NO_AUTHENTICATING_AUTHORITY"/><br/><c>0x80090311</c></term><description>The function failed. No authority could be contacted for authentication. This could be due to the following conditions: <list type="bullet"><item>The domain name of the authenticating party is incorrect.</item><item>The domain is unavailable.</item><item>The trust relationship has failed.</item></list></description></item>
        /// <item><term><see cref="SEC_E_NO_CREDENTIALS"/><br/><c>0x8009030E</c></term><description>The function failed. The <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">credentials</a> handle specified in the <paramref name="phCredential"/> parameter is not valid.</description></item>
        /// <item><term><see cref="SEC_E_OK"/><br/><c>0x00000000</c></term><description>The function succeeded. The security context received from the client was accepted. If the function generated an output token, the token must be sent to the client process.</description></item>
        /// <item><term><see cref="SEC_E_UNSUPPORTED_FUNCTION"/><br/><c>0x80090302</c></term><description>The function failed. The <paramref name="fContextReq"/> parameter specified a context attribute flag (<see cref="ASC_REQ_DELEGATE"/> or <see cref="ASC_REQ_PROMPT_FOR_CREDS"/>) that was not valid.</description></item>
        /// <item><term><see cref="SEC_I_COMPLETE_AND_CONTINUE"/><br/><c>0x00090314</c></term><description>The function succeeded. The server must call <see cref="CompleteAuthToken"/> and pass the output token to the client. The server must then wait for a return token from the client before making another call to <see cref="AcceptSecurityContext"/> (CredSSP). </description></item>
        /// <item><term><see cref="SEC_I_COMPLETE_NEEDED"/><br/><c>0x00090313</c></term><description>The function succeeded. The server must finish building the message from the client before calling <see cref="CompleteAuthToken"/>. </description></item>
        /// <item><term><see cref="SEC_I_CONTINUE_NEEDED"/><br/><c>0x00090312</c></term><description>The function succeeded. The server must send the output token to the client and wait for a returned token. The returned token should be passed in <em>pInput</em> for another call to <see cref="AcceptSecurityContext"/> (CredSSP). </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="AcceptSecurityContext"/> (CredSSP) function is the server counterpart to the <see cref="InitializeSecurityContext"/> (CredSSP) function.</para>
        /// <para>When the server receives a request from a client, it uses the <paramref name="fContextReq"/> parameter to specify what it requires of the session. In this fashion, a server can require that clients be capable of using a confidential or <a href="https://docs.microsoft.com/windows/desktop/SecGloss/i-gly">integrity</a>-checked session; it can reject clients that cannot meet that demand. Alternatively, a server can require nothing; whatever the client requires or can provide is returned in the <paramref name="pfContextAttr"/> parameter.</para>
        /// <para>The <paramref name="fContextReq"/> and <paramref name="pfContextAttr"/> parameters are bitmasks that represent various context attributes. For a description of the various attributes, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/context-requirements">Context Requirements</a>.</para>
        /// <para><note>While the <paramref name="pfContextAttr"/> parameter is valid on any successful return, you should examine the flags pertaining to security aspects of the context only on the final successful return. Intermediate returns can set, for example, the <see cref="ISC_RET_ALLOCATED_MEMORY"/> flag.</note></para>
        /// <para>The caller is responsible for determining whether the final context attributes are sufficient. For example, if confidentiality (encryption) was requested but could not be established, some applications may choose to shut down the connection immediately. If the security context cannot be established, the server must free the partially created context by calling the <see cref="DeleteSecurityContext"/> function. For information about when to call the <see cref="DeleteSecurityContext"/> function, see <see cref="DeleteSecurityContext"/>.</para>
        /// <para>After the security context has been established, the server application can use the <see cref="QuerySecurityContextToken"/> function to retrieve a handle to the user account to which the client certificate was mapped. Also, the server can use the <see cref="ImpersonateSecurityContext"/> function to impersonate the user.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/nf-sspi-acceptsecuritycontext">AcceptSecurityContext function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="DeleteSecurityContext"/>
        /// <seealso cref="InitializeSecurityContext"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-functions">SSPI Functions</seealso>
        [DllImport(Secur32, CallingConvention = CallingConvention.Winapi)]
        public static extern int AcceptSecurityContext(
            [Optional] in CredHandle phCredential,  // Cred to base context
            [Optional] in CtxtHandle phContext,     // Existing context (OPT)
            [Optional] in SecBufferDesc pInput,     // Input buffer
            [In, MarshalAs(UnmanagedType.U4)]
            ASC_REQ_FLAGS fContextReq,              // Context Requirements
            [In, MarshalAs(UnmanagedType.U4)]
            SECURITY_DREP_TYPE TargetDataRep,       // Target Data Rep
            [Optional] ref CtxtHandle phNewContext, // (out) New context handle
            [Optional] ref SecBufferDesc pOutput,   // (inout) Output buffers
            [MarshalAs(UnmanagedType.U4)]
            out ASC_RET_FLAGS pfContextAttr,        // (out) Context attributes
            [Optional] out TimeStamp ptsExpiry      // (out) Life span (OPT)
            );
        #endregion
    }
}

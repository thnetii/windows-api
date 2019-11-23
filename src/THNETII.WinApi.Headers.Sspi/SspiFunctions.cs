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
    }
}

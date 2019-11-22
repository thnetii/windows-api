using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 607
    /// <summary>
    /// The <see cref="SecPkgCredentials_NamesW"/> structure holds the name of the user associated with a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">context</a>. The <see cref="QueryCredentialsAttributes"/> function uses this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcredentials_namesw">SecPkgCredentials_NamesW structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryCredentialsAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgCredentials_NamesW
    {
        #region public char* sUserName;
        internal char* sUserName;
        /// <summary>
        /// Gets a span to a string containing the name of the user represented by the credential. If the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a> sets the <see cref="SECPKG_FLAG_ACCEPT_WIN32_NAME"/> flag to indicate that it can process Windows names, this name can be used in other Windows calls.
        /// </summary>
        public Span<char> GetUserName() =>
            new IntPtr(sUserName).ToZeroTerminatedUnicodeSpan();
        #endregion
    }

    /// <summary>
    /// The <see cref="SecPkgCredentials_NamesA"/> structure holds the name of the user associated with a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">context</a>. The <see cref="QueryCredentialsAttributes"/> function uses this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcredentials_namesa">SecPkgCredentials_NamesA structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryCredentialsAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgCredentials_NamesA
    {
        #region public char* sUserName;
        internal char* sUserName;
        /// <summary>
        /// Gets a span to an ANSI-byte string containing the name of the user represented by the credential. If the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a> sets the <see cref="SECPKG_FLAG_ACCEPT_WIN32_NAME"/> flag to indicate that it can process Windows names, this name can be used in other Windows calls.
        /// </summary>
        public Span<char> GetUserName() =>
            new IntPtr(sUserName).ToZeroTerminatedUnicodeSpan();
        #endregion
    }
}

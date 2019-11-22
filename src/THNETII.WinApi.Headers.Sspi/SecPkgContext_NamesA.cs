﻿using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    using static SECPKG_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 825
    /// <summary>
    /// The <see cref="SecPkgContext_NamesA"/> structure indicates the name of the user associated with a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a>. The <see cref="QueryContextAttributes"/> (General) function uses this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_namesa">SecPkgContext_NamesA structure</a></para>
    /// </remarks>
    /// <seealso cref="SECPKG_ATTR_LCT_STATUS"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_NamesA
    {
        /// <summary>
        /// Pointer to a null-terminated ANSI-string containing the name of the user represented by the context. If the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a> has set the <see cref="SECPKG_FLAG_ACCEPT_WIN32_NAME"/> flag, this name can be used in other Windows calls.
        /// </summary>
        public byte* sUserName;
    }
}

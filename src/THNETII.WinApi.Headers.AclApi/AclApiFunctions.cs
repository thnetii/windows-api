using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

using THNETII.WinApi.Native.AccCtrl;
using THNETII.WinApi.Native.WinError;
using THNETII.WinApi.Native.WinNT;

#if NETSTANDARD1_6
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.AclApi
{
    using static ACCESS_MODE;
    using static NativeLibraryNames;
    using static WinErrorConstants;

    /// <summary>
    /// Win32 Access Control APIs
    /// </summary>
    public static class AclApiFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AclAPI.h, line 53
        #region SetEntriesInAclA function
        /// <inheritdoc cref="SetEntriesInAcl"/>
        public static unsafe int SetEntriesInAclA(
            ReadOnlySpan<EXPLICIT_ACCESS_A> pListOfExplicitEntries,
            [Optional] IntPtr OldAcl,
            out IntPtr NewAcl
            )
        {
            fixed (EXPLICIT_ACCESS_A* ptrListOfExplicitEntries = pListOfExplicitEntries)
                return SetEntriesInAclA(
                    pListOfExplicitEntries.Length,
                    ptrListOfExplicitEntries,
                    OldAcl,
                    out NewAcl);
        }

        [DllImport(Advapi32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        private static extern unsafe int SetEntriesInAclA(
            [In] int cCountOfExplicitEntries,
            [In] EXPLICIT_ACCESS_A* pListOfExplicitEntries,
            [In, Optional] IntPtr OldAcl,
            out IntPtr NewAcl
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AclAPI.h, line 62
        #region SetEntriesInAclW function
        /// <inheritdoc cref="SetEntriesInAcl"/>
        public static unsafe int SetEntriesInAclW(
            ReadOnlySpan<EXPLICIT_ACCESS_W> pListOfExplicitEntries,
            [Optional] IntPtr OldAcl,
            out IntPtr NewAcl
            )
        {
            fixed (EXPLICIT_ACCESS_W* ptrListOfExplicitEntries = pListOfExplicitEntries)
                return SetEntriesInAclW(
                    pListOfExplicitEntries.Length,
                    ptrListOfExplicitEntries,
                    OldAcl,
                    out NewAcl);
        }

        [DllImport(Advapi32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        private static extern unsafe int SetEntriesInAclW(
            [In] int cCountOfExplicitEntries,
            [In] EXPLICIT_ACCESS_W* pListOfExplicitEntries,
            [In, Optional] IntPtr OldAcl,
            out IntPtr NewAcl
            );
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AclAPI.h, line 53
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AclAPI.h, line 71
        #region SetEntriesInAcl function
        /// <summary>
        /// The <see cref="SetEntriesInAcl"/> function creates a new <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">access control list</a> (ACL) by merging new access control or audit control information into an existing <see cref="ACL"/> structure.
        /// </summary>
        /// <param name="pListOfExplicitEntries">A span of <see cref="EXPLICIT_ACCESS"/> structures that describe the access control information to merge into the existing ACL.</param>
        /// <param name="OldAcl">A pointer to the existing ACL. This parameter can be <see cref="IntPtr.Zero"/>, in which case, the function creates a new ACL based on the <see cref="EXPLICIT_ACCESS"/> entries.</param>
        /// <param name="NewAcl">A variable that receives a pointer to the new ACL. If the function succeeds, you must call the <see cref="LocalFree"/> function to free the returned buffer.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="ERROR_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns a nonzero error code.</para>
        /// </returns>
        /// <remarks>
        /// <para>Each entry in the array of <see cref="EXPLICIT_ACCESS"/> structures specifies access control or audit control information for a specified trustee. A trustee can be a user, group, or other <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security identifier</a> (SID) value, such as a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/l-gly">logon identifier</a> or logon type (for instance, a Windows service or batch job). You can use a name or a SID to identify a trustee.</para>
        /// <para>You can use the <see cref="SetEntriesInAcl"/> function to modify the list of <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">access control entries</a> (ACEs) in a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/d-gly">discretionary access control list</a> (DACL) or a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">system access control list</a> (SACL). Note that <see cref="SetEntriesInAcl"/> does not prevent you from mixing access control and audit control information in the same <see cref="ACL"/>; however, the resulting ACL will contain meaningless entries.</para>
        /// <para>
        /// For a DACL, the <see cref="EXPLICIT_ACCESS.grfAccessMode"/> member of the <see cref="EXPLICIT_ACCESS"/> structure specifies whether to allow, deny, or revoke access rights for the trustee. This member can specify one of the following values:
        /// <list type="bullet">
        /// <item><see cref="GRANT_ACCESS"/></item>
        /// <item><see cref="SET_ACCESS"/></item>
        /// <item><see cref="DENY_ACCESS"/></item>
        /// <item><see cref="REVOKE_ACCESS"/></item>
        /// </list>
        /// For information about these values, see <see cref="ACCESS_MODE"/>.
        /// </para>
        /// <para>The <see cref="SetEntriesInAcl"/> function places any new access-denied ACEs at the beginning of the list of ACEs for the new <see cref="ACL"/>. This function places any new access-allowed ACEs just before any existing access-allowed ACEs.</para>
        /// <para>
        /// For a SACL, the <see cref="EXPLICIT_ACCESS.grfAccessMode"/> member of the <see cref="EXPLICIT_ACCESS"/> structure can specify the following values:
        /// <list type="bullet">
        /// <item><see cref="REVOKE_ACCESS"/></item>
        /// <item><see cref="SET_AUDIT_FAILURE"/></item>
        /// <item><see cref="SET_AUDIT_SUCCESS"/></item>
        /// </list>
        /// <see cref="SET_AUDIT_FAILURE"/> and <see cref="SET_AUDIT_SUCCESS"/> can be combined. For information about these values, see <see cref="ACCESS_MODE"/>.
        /// </para>
        /// <para>The <see cref="SetEntriesInAcl"/> function places any new system-audit ACEs at the beginning of the list of ACEs for the new ACL.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/aclapi/nf-aclapi-setentriesinaclw">SetEntriesInAclW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="ACL"/>
        /// <seealso cref="GenericAce"/>
        /// <seealso cref="GenericAcl"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthZ/access-control">Access Control</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthZ/authorization-functions">Basic Access Control Functions</seealso>
        /// <seealso cref="EXPLICIT_ACCESS"/>
        /// <seealso cref="LocalFree"/>
        public static unsafe int SetEntriesInAcl(
            ReadOnlySpan<EXPLICIT_ACCESS> pListOfExplicitEntries,
            [Optional] IntPtr OldAcl,
            out IntPtr NewAcl
            )
        {
            fixed (EXPLICIT_ACCESS* ptrListOfExplicitEntries = pListOfExplicitEntries)
                return SetEntriesInAcl(
                    pListOfExplicitEntries.Length,
                    ptrListOfExplicitEntries,
                    OldAcl,
                    out NewAcl);
        }

#if !NETSTANDARD1_6
        [DllImport(Advapi32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static extern
#else
        private static
#endif // !NETSTANDARD1_6
        unsafe int SetEntriesInAcl(
            [In] int cCountOfExplicitEntries,
            [In] EXPLICIT_ACCESS* pListOfExplicitEntries,
            [In, Optional] IntPtr OldAcl,
            out IntPtr NewAcl
            )
#if !NETSTANDARD1_6
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SetEntriesInAclA(cCountOfExplicitEntries,
                    (EXPLICIT_ACCESS_A*)pListOfExplicitEntries,
                    OldAcl, out NewAcl),
                2 => SetEntriesInAclW(cCountOfExplicitEntries,
                    (EXPLICIT_ACCESS_W*)pListOfExplicitEntries,
                    OldAcl, out NewAcl),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_6
        #endregion
    }
}

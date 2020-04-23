using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1220
    // The combination of dwNLSVersion, and guidCustomVersion
    // identify specific sort behavior, persist those to ensure identical
    // behavior in the future.

    /// <summary>
    /// Contains version information about an NLS capability.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="dwNLSVersion"/> and <see cref="dwDefinedVersion"/> members are completely independent. Although each member is defined for a single int, actually each is composed of a major version and a minor version. See <a href="https://docs.microsoft.com/windows/desktop/Intl/handling-sorting-in-your-applications">Handling Sorting in Your Applications</a> for more information.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/ns-winnls-nlsversioninfoex">NLSVERSIONINFOEX structure</a></para>
    /// </remarks>
    /// <seealso cref="GetNLSVersionEx"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/handling-sorting-in-your-applications">Handling Sorting in Your Applications</seealso>
    /// <seealso cref="IsNLSDefinedString"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-structures">National Language Support Structures</seealso>
    [StructLayout(LayoutKind.Sequential)]
    public struct NLSVERSIONINFOEX
    {
        public static readonly int SizeOf = SizeOf<NLSVERSIONINFOEX>.Bytes;

        /// <summary>
        /// Size, in bytes, of the structure. Use the value of <see cref="SizeOf"/> on initialization.
        /// </summary>
        public int dwNLSVersionInfoSize;     // sizeof(NLSVERSIONINFOEX) == 32 bytes
        /// <summary>
        /// NLS version. This value is used to track changes and additions to the set of code points that have the indicated capability for a particular locale. The value is locale-specific, and increments when the capability changes. For example, using the <see cref="COMPARE_STRING"/> capability defined by the <see cref="SYSNLS_FUNCTION"/> enumeration, the version changes if sorting weights are assigned to code points that previously had no weights defined for the locale.
        /// </summary>
        public int dwNLSVersion;
        /// <summary>
        /// Defined version. This value is used to track changes in the repertoire of Unicode code points. The value increments when the Unicode repertoire is extended, for example, if more characters are defined.
        /// <para><strong>Starting with Windows 8:</strong> Deprecated. Use <see cref="dwNLSVersion"/> instead.</para>
        /// </summary>
        [Obsolete("Starting with Windows 8: Deprecated, use dwNLSVersion instead")]
        public int dwDefinedVersion;         // Deprecated, use dwNLSVersion instead
        /// <summary>
        /// Identifier of the sort order used for the input locale for the represented version. For example, for a custom locale <c>en-Mine</c> that uses <c>0409</c> for a sort order identifier, this member contains <c>0409</c>. If this member specifies a "real" sort, <see cref="guidCustomVersion"/> is set to an empty GUID.
        /// <para><strong>Starting with Windows 8:</strong> Deprecated. Use <see cref="guidCustomVersion"/> instead.</para>
        /// </summary>
        [Obsolete("Starting with Windows 8: Deprecated, use guidCustomVerison instead")]
        public int dwEffectiveId;            // Deprecated, use guidCustomVerison instead
        /// <summary>
        /// Unique GUID for the behavior of a custom sort used by the locale for the represented version.
        /// </summary>
        public Guid guidCustomVersion;        // Explicit sort version
    }
}

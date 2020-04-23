using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1186
    //
    //  NLS version structure.
    //

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1206
    // 
    // Windows 7 and below had different sizes
    //

    // This is to be deprecated, please use the NLSVERSIONINFOEX
    // structure below in the future.  The difference is that
    // guidCustomversion is required to uniquely identify a sort

    /// <summary>
    /// Deprecated. Contains version information about an NLS capability.
    /// <para>Starting with Windows 8, your app should use <see cref="NLSVERSIONINFOEX"/> instead of <see cref="NLSVERSIONINFO"/>.</para>
    /// </summary>
    /// <remarks>
    /// <para>See Remarks for <see cref="NLSVERSIONINFOEX"/>.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/ns-winnls-nlsversioninfo~r1">NLSVERSIONINFO structure</a></para>
    /// </remarks>
    /// <seealso cref="GetNLSVersion"/>
    /// <seealso cref="GetNLSVersionEx"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/handling-sorting-in-your-applications">Handling Sorting in Your Applications</seealso>
    /// <seealso cref="IsNLSDefinedString"/>
    /// <seealso cref="NLSVERSIONINFOEX"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-structures">National Language Support Structures</seealso>
    [Obsolete("Starting with Windows 8, your app should use NLSVERSIONINFOEX instead of NLSVERSIONINFO.")]
    [StructLayout(LayoutKind.Sequential)]
    public struct NLSVERSIONINFO
    {
        public static readonly int SizeOf = SizeOf<NLSVERSIONINFO>.Bytes;

        /// <summary>
        /// Size, in bytes, of the structure. Use the value of <see cref="SizeOf"/> on initialization.
        /// </summary>
        public int dwNLSVersionInfoSize;     // 12 bytes
        /// <summary>
        /// NLS version. This value is used to track changes and additions to the set of code points that have the indicated capability for a particular locale. The value is locale-specific, and increments when the capability changes. For example, using the <see cref="COMPARE_STRING"/> capability defined by the <see cref="SYSNLS_FUNCTION"/> enumeration, the version changes if sorting weights are assigned to code points that previously had no weights defined for the locale.
        /// </summary>
        public int dwNLSVersion;
        /// <summary>
        /// Defined version. This value is used to track changes in the repertoire of Unicode code points. The value increments when the Unicode repertoire is extended, for example, if more characters are defined.
        /// </summary>
        [Obsolete("Deprecated, use dwNLSVersion instead")]
        public int dwDefinedVersion;         // Deprecated, use dwNLSVersion instead
    }
}

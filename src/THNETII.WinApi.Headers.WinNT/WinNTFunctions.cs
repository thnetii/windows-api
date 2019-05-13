using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Principal;

#if NETSTANDARD1_6
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    public static class WinNTFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2097
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        //  DEPRECATED: The LCID/LANGID/SORTID concept is deprecated, please use
        //  Locale Names instead, eg: "en-US" instead of an LCID like 0x0409.
        //  See the documentation for GetLocaleInfoEx.
        //
        //  A language ID is a 16 bit value which is the combination of a
        //  primary language ID and a secondary language ID.  The bits are
        //  allocated as follows:
        //
        //       +-----------------------+-------------------------+
        //       |     Sublanguage ID    |   Primary Language ID   |
        //       +-----------------------+-------------------------+
        //        15                   10 9                       0   bit
        //
        //  WARNING:  This pattern is broken and not followed for all languages.
        //            Serbian, Bosnian & Croatian are a few examples.
        //
        //  WARNING:  There are > 6000 human languages.  The PRIMARYLANGID construct
        //            cannot support all languages your application may encounter.
        //            Please use Language Names, such as "en".
        //
        //  WARNING:  There are > 200 country-regions.  The SUBLANGID construct cannot
        //            represent all valid dialects of languages such as English.
        //            Please use Locale Names, such as "en-US".
        //
        //  WARNING:  Some languages may have more than one PRIMARYLANGID.  Please
        //            use Locale Names, such as "en-FJ".
        //
        //  WARNING:  Some languages do not have assigned LANGIDs.  Please use
        //            Locale Names, such as "tlh-Piqd".
        //
        //  It is recommended that applications test for locale names rather than
        //  attempting to construct/deconstruct LANGID/PRIMARYLANGID/SUBLANGID
        //
        //  Language ID creation/extraction macros:
        //
        //    MAKELANGID    - construct language id from a primary language id and
        //                    a sublanguage id.
        //    PRIMARYLANGID - extract primary language id from a language id.
        //    SUBLANGID     - extract sublanguage id from a language id.
        //
        //  Note that the LANG, SUBLANG construction is not always consistent.
        //  The named locale APIs (eg GetLocaleInfoEx) are recommended.
        //
        //  DEPRECATED: Language IDs do not exist for all locales
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        public static int MAKELANGID(int p, int s) => (((ushort)s) << 10) | (ushort)p;
        public static int PRIMARYLANGID(int lgid) => (short)lgid & 0x3ff;
        public static int SUBLANGID(int lgid) => (short)lgid >> 10;

        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        //  DEPRECATED: The LCID/LANGID/SORTID concept is deprecated, please use
        //  Locale Names instead, eg: en-US instead of an LCID like 0x0409.
        //  See the documentation for GetLocaleInfoEx.
        //
        //  A locale ID is a 32 bit value which is the combination of a
        //  language ID, a sort ID, and a reserved area.  The bits are
        //  allocated as follows:
        //
        //       +-------------+---------+-------------------------+
        //       |   Reserved  | Sort ID |      Language ID        |
        //       +-------------+---------+-------------------------+
        //        31         20 19     16 15                      0   bit
        //
        //  WARNING: This pattern isn't always followed (es-ES_tradnl vs es-ES for example)
        //
        //  WARNING: Some locales do not have assigned LCIDs.  Please use
        //           Locale Names, such as "tlh-Piqd".
        //
        //  It is recommended that applications test for locale names rather than
        //  attempting to rely on LCID or LANGID behavior.
        //
        //  DEPRECATED: Locale ID creation/extraction macros:
        //
        //    MAKELCID            - construct the locale id from a language id and a sort id.
        //    MAKESORTLCID        - construct the locale id from a language id, sort id, and sort version.
        //    LANGIDFROMLCID      - extract the language id from a locale id.
        //    SORTIDFROMLCID      - extract the sort id from a locale id.
        //    SORTVERSIONFROMLCID - extract the sort version from a locale id.
        //
        //  Note that the LANG, SUBLANG construction is not always consistent.
        //  The named locale APIs (eg GetLocaleInfoEx) are recommended.
        //
        //  DEPRECATED: LCIDs do not exist for all locales.
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2192
        public static int MAKELCID(int lgid, int srtid) => ((ushort)srtid << 16) | (ushort)lgid;
        public static int MAKESORTLCID(int lgid, int srtid, int ver) => (MAKELCID(lgid, srtid)) | ((ushort)ver << 20);
        public static int LANGIDFROMLCID(int lcid) => (ushort)lcid;
        public static int SORTIDFROMLCID(int lcid) => (ushort)((lcid >> 16) & 0xf);
        public static int SORTVERSIONFROMLCID(int lcid) => (ushort)((lcid >> 20) & 0xf);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8752
        public static bool IS_UNWINDING(int Flag) => (Flag & EXCEPTION_UNWIND) != 0;
        public static bool IS_DISPATCHING(int Flag) => (Flag & EXCEPTION_UNWIND) == 0;
        public static bool IS_TARGET_UNWIND(int Flag) => (Flag & EXCEPTION_TARGET_UNWIND) != 0;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9423
        public static int MANDATORY_LEVEL_TO_MANDATORY_RID(int IL) => IL * 0x1000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10566
        public static bool VALID_IMPERSONATION_LEVEL(TokenImpersonationLevel L) =>
            (L >= SECURITY_MIN_IMPERSONATION_LEVEL) && (L <= SECURITY_MAX_IMPERSONATION_LEVEL);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13493
        #region IsVirtualDiskFileShared macro
        /// <summary>
        /// Determines if the provided virtual disk handle state, from <see cref="SHARED_VIRTUAL_DISK_SUPPORT"/>,
        /// indicates that the target virtual disk file is opened in shared mode.
        /// </summary>
        public static bool IsVirtualDiskFileShared(SharedVirtualDiskHandleState HandleState) =>
            ((HandleState) & SharedVirtualDiskHandleState.SharedVirtualDiskHandleStateFileShared) != 0;

        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18578
        #region RtlCaptureStackBackTrace function
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern unsafe ushort RtlCaptureStackBackTrace(
            [In] int FramesToSkip,
            [In] int FramesToCapture,
            out IntPtr* BackTrace,
            [Optional] out int BackTraceHash
            );
        /// <inheritdoc cref="RtlCaptureStackBackTrace(int, int, out IntPtr*, out int)"/>
        public static unsafe ReadOnlySpan<IntPtr> RtlCaptureStackBackTrace(
            int FramesToSkip,
            int FramesToCapture,
            out int BackTraceHash
            )
        {
            var length = RtlCaptureStackBackTrace(FramesToSkip, FramesToCapture, out IntPtr* BackTrace, out BackTraceHash);
            return new ReadOnlySpan<IntPtr>(BackTrace, length);
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18600
        #region RtlCaptureContext function
        /// <summary>
        /// Retrieves a context record in the context of the caller.
        /// </summary>
        /// <param name="ContextRecord">Receives a <see cref="CONTEXT"/> structure on return.</param>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlcapturecontext">RtlCaptureContext function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CONTEXT"/>
        /// <seealso cref="RtlRestoreContext"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.StdCall)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP", Justification = "Documentation")]
        public static extern void RtlCaptureContext(out CONTEXT ContextRecord);
        #endregion
    }
}

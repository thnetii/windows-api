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
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18618
        #region RtlUnwind function
        /// <summary>
        /// Initiates an unwind of procedure call frames.
        /// </summary>
        /// <param name="TargetFrame">A pointer to the call frame that is the target of the unwind. If this parameter is <see cref="IntPtr.Zero"/>, the function performs an exit unwind.</param>
        /// <param name="TargetIp">The continuation address of the unwind. This parameter is ignored if <paramref name="TargetFrame"/> is <see cref="IntPtr.Zero"/>.</param>
        /// <param name="ExceptionRecord">An <see cref="EXCEPTION_RECORD"/> structure.</param>
        /// <param name="ReturnValue">A value to be placed in the integer function return register before continuing execution.</param>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlunwind">RtlUnwind function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="EXCEPTION_RECORD"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.StdCall)]
        public static extern void RtlUnwind(
            [In, Optional] IntPtr TargetFrame,
            [In, Optional] IntPtr TargetIp,
            [In, Optional] in EXCEPTION_RECORD ExceptionRecord,
            [In] IntPtr ReturnValue
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18640
        #region RtlAddFunctionTable function
        /// <summary>
        /// Adds a dynamic function table to the dynamic function table list.
        /// </summary>
        /// <param name="FunctionTable">An array of function entries. For more information on runtime function entries, see the calling convention documentation for the processor.</param>
        /// <param name="EntryCount">The number of entries in the <paramref name="FunctionTable"/> array.</param>
        /// <param name="BaseAddress">The base address to use when computing full virtual addresses from relative virtual addresses of function table entries.</param>
        /// <returns>If the function succeeds, the return value is <see langword="true"/>. Otherwise, the return value is <see langword="false"/>.</returns>
        /// <remarks>
        /// <para>Function tables are used on 64-bit Windows to determine how to unwind or walk the stack. These tables are usually generated by the compiler and stored as part of the image. However, applications must provide the function table for dynamically generated code. For more information about function tables, see the architecture guide for your system.</para>
        /// <para>This function is useful for code that is generated from a template or generated only once during the life of the process. For more dynamically generated code, use the <see cref="RtlInstallFunctionTableCallback"/> function.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtladdfunctiontable">RtlAddFunctionTable function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="RtlDeleteFunctionTable(IMAGE_IA64_RUNTIME_FUNCTION_ENTRY*)"/>
        /// <seealso cref="RtlInstallFunctionTableCallback"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        internal static unsafe extern byte RtlAddFunctionTable(
            [In] IMAGE_IA64_RUNTIME_FUNCTION_ENTRY* FunctionTable,
            [In] int EntryCount,
            [In] long BaseAddress
            );
        /// <inheritdoc cref="RtlAddFunctionTable(IMAGE_IA64_RUNTIME_FUNCTION_ENTRY*, int, long)"/>
        public static unsafe bool RtlAddFunctionTable(
            Span<IMAGE_IA64_RUNTIME_FUNCTION_ENTRY> FunctionTable,
            long BaseAddress
            )
        {
            if (FunctionTable.IsEmpty)
                return RtlAddFunctionTable(null, 0, BaseAddress) != 0;
            fixed (IMAGE_IA64_RUNTIME_FUNCTION_ENTRY* ptr = &FunctionTable[0])
            {
                return RtlAddFunctionTable(ptr, FunctionTable.Length, BaseAddress) != 0;
            }
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18647
        #region RtlDeleteFunctionTable function
        /// <summary>
        /// Removes a dynamic function table from the dynamic function table list.
        /// </summary>
        /// <param name="FunctionTable">A pointer to an array of function entries that were previously passed to <see cref="RtlAddFunctionTable(IMAGE_IA64_RUNTIME_FUNCTION_ENTRY*, int, long)"/> or an identifier previously passed to <see cref="RtlInstallFunctionTableCallback"/>.</param>
        /// <returns>If the function succeeds, the return value is <see langword="true"/>. Otherwise, the return value is <see langword="false"/>.</returns>
        /// <remarks>
        /// <para>Function tables are used on 64-bit Windows to determine how to unwind or walk the stack. These tables are usually generated by the compiler and stored as part of the image. However, applications must provide the function table for dynamically generated code. For more information about function tables, see the architecture guide for your system.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtldeletefunctiontable">RtlDeleteFunctionTable function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="RtlAddFunctionTable(IMAGE_IA64_RUNTIME_FUNCTION_ENTRY*, int, long)"/>
        /// <seealso cref="RtlInstallFunctionTableCallback"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        internal static unsafe extern byte RtlDeleteFunctionTable(
            [In] IMAGE_IA64_RUNTIME_FUNCTION_ENTRY* FunctionTable
            );
        /// <inheritdoc cref="RtlDeleteFunctionTable(IMAGE_IA64_RUNTIME_FUNCTION_ENTRY*)"/>
        public static unsafe bool RtlDeleteFunctionTable(
            Span<IMAGE_IA64_RUNTIME_FUNCTION_ENTRY> FunctionTable
            )
        {
            if (FunctionTable.IsEmpty)
                return RtlDeleteFunctionTable((IMAGE_IA64_RUNTIME_FUNCTION_ENTRY*)null) != 0;
            fixed (IMAGE_IA64_RUNTIME_FUNCTION_ENTRY* pFunctionTable = FunctionTable)
            {
                return RtlDeleteFunctionTable(pFunctionTable) != 0;
            }
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18655
        #region RtlInstallFunctionTableCallback function
        /// <summary>
        /// Adds a dynamic function table to the dynamic function table list.
        /// </summary>
        /// <param name="TableIdentifier">The identifier for the dynamic function table callback. The two low-order bits must be set. For example, <c><paramref name="BaseAddress"/>|0x3</c>.</param>
        /// <param name="BaseAddress">The base address of the region of memory managed by the callback function.</param>
        /// <param name="Length">The size of the region of memory managed by the callback function, in bytes.</param>
        /// <param name="Callback">The callback function that is called to retrieve the function table entries for the functions in the specified region of memory.</param>
        /// <param name="Context">A pointer to the user-defined data to be passed to the callback function.</param>
        /// <param name="OutOfProcessCallbackDll">
        /// <para>An optional string that specifies the path of a DLL that provides function table entries that are outside the process.</para>
        /// <para>When a debugger unwinds to a function in the range of addresses managed by the callback function, it loads this DLL and calls the <see cref="OUT_OF_PROCESS_FUNCTION_TABLE_CALLBACK_EXPORT_NAME"/> function, whose type is <see cref="OUT_OF_PROCESS_FUNCTION_TABLE_CALLBACK"/>.</para>
        /// </param>
        /// <returns>If the function succeeds, the return value is <see langword="true"/>. Otherwise, the return value is <see langword="false"/>.</returns>
        /// <remarks>
        /// <para>Function tables are used on 64-bit Windows to determine how to unwind or walk the stack. These tables are usually generated by the compiler and stored as part of the image. However, applications must provide the function table for dynamically generated code. For more information about function tables, see the architecture guide for your system.</para>
        /// <para>This function is useful for very dynamic code. The application specifies the memory range for the generated code, but does not need to generate a table until it is needed by an unwind request. At that time, the system calls the callback function with the <paramref name="Context"/> and the control address. The callback function must return the runtime function entry for the specified address. Be sure to avoid creating a deadlock between the callback function and the code generator.</para>
        /// <para>For code that is generated from a template or generated only once during the life of the process, use the <see cref="RtlAddFunctionTable(IMAGE_IA64_RUNTIME_FUNCTION_ENTRY*, int, long)"/> function.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlinstallfunctiontablecallback">RtlInstallFunctionTableCallback function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="RtlAddFunctionTable(IMAGE_IA64_RUNTIME_FUNCTION_ENTRY*, int, long)"/>
        /// <seealso cref="RtlDeleteFunctionTable(IMAGE_IA64_RUNTIME_FUNCTION_ENTRY*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static extern unsafe bool RtlInstallFunctionTableCallback(
            [In] long TableIdentifier,
            [In] long BaseAddress,
            [In] int Length,
            [In, MarshalAs(UnmanagedType.FunctionPtr)] GET_RUNTIME_FUNCTION_CALLBACK Callback,
            [In] void* Context = null,
            [In, MarshalAs(UnmanagedType.LPWStr)] string OutOfProcessCallbackDll = null
            );
        #endregion
    }
}

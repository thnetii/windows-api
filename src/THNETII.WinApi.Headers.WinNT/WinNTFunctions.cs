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
        #region MAKELANGID macro
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
        #endregion
        #region PRIMARYLANGID macro
        public static int PRIMARYLANGID(int lgid) => (short)lgid & 0x3ff;
        #endregion
        #region SUBLANGID macro
        public static int SUBLANGID(int lgid) => (short)lgid >> 10;
        #endregion

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2192
        #region MAKELCID macro
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
        public static int MAKELCID(int lgid, int srtid) => ((ushort)srtid << 16) | (ushort)lgid;
        #endregion
        #region MAKESORTLCID macro
        public static int MAKESORTLCID(int lgid, int srtid, int ver) => (MAKELCID(lgid, srtid)) | ((ushort)ver << 20);
        #endregion
        #region LANGIDFROMLCID macro
        public static int LANGIDFROMLCID(int lcid) => (ushort)lcid;
        #endregion
        #region SORTIDFROMLCID macro
        public static int SORTIDFROMLCID(int lcid) => (ushort)((lcid >> 16) & 0xf);
        #endregion
        #region SORTVERSIONFROMLCID macro
        public static int SORTVERSIONFROMLCID(int lcid) => (ushort)((lcid >> 20) & 0xf);
        #endregion

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8752
        #region IS_UNWINDING macro
        public static bool IS_UNWINDING(int Flag) => (Flag & EXCEPTION_UNWIND) != 0;
        #endregion
        #region IS_DISPATCHING macro
        public static bool IS_DISPATCHING(int Flag) => (Flag & EXCEPTION_UNWIND) == 0;
        #endregion
        #region IS_TARGET_UNWIND macro
        public static bool IS_TARGET_UNWIND(int Flag) => (Flag & EXCEPTION_TARGET_UNWIND) != 0;
        #endregion

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8752
        #region RtlUnwind2 function
        /// <summary>
        /// Initiates an unwind of procedure call frames.
        /// </summary>
        /// <param name="TargetFrame">A pointer to the call frame that is the target of the unwind. If this parameter is all zero, the function performs an exit unwind.</param>
        /// <param name="TargetIp">The continuation address of the unwind. This parameter is ignored if <paramref name="TargetFrame"/> is all zero.</param>
        /// <param name="ExceptionRecord">An <see cref="EXCEPTION_RECORD"/> structure.</param>
        /// <param name="ReturnValue">A value to be placed in the integer function return register before continuing execution.</param>
        /// <param name="ContextRecord">A reference to a <see cref="CONTEXT_AMD64"/> structure that stores context during the unwind operation.</param>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlunwind2">RtlUnwind2 function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CONTEXT"/>
        /// <seealso cref="EXCEPTION_RECORD"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static extern void RtlUnwind2(
            [In, Optional] FRAME_POINTERS TargetFrame,
            [In, Optional] IntPtr TargetIp,
            [In, Optional] in EXCEPTION_RECORD ExceptionRecord,
            [In] IntPtr ReturnValue,
            [In] ref CONTEXT_AMD64 ContextRecord
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9423
        #region MANDATORY_LEVEL_TO_MANDATORY_RID macro
        public static int MANDATORY_LEVEL_TO_MANDATORY_RID(int IL) => IL * 0x1000;
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10566
        #region VALID_IMPERSONATION_LEVEL macro
        public static bool VALID_IMPERSONATION_LEVEL(TokenImpersonationLevel L) =>
            (L >= SECURITY_MIN_IMPERSONATION_LEVEL) && (L <= SECURITY_MAX_IMPERSONATION_LEVEL);
        #endregion
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
        /// <seealso cref="RtlRestoreContext(in CONTEXT_AMD64, EXCEPTION_RECORD*)"/>
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
        /// <para>This function is useful for code that is generated from a template or generated only once during the life of the process. For more dynamically generated code, use the <see cref="RtlInstallFunctionTableCallback(IntPtr, IntPtr, int, GET_RUNTIME_FUNCTION_AMD64_CALLBACK, void*, string)"/> function.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtladdfunctiontable">RtlAddFunctionTable function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="RtlDeleteFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*)"/>
        /// <seealso cref="RtlInstallFunctionTableCallback(IntPtr, IntPtr, int, GET_RUNTIME_FUNCTION_AMD64_CALLBACK, void*, string)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        internal static unsafe extern byte RtlAddFunctionTable(
            [In] IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY* FunctionTable,
            [In] int EntryCount,
            [In] IntPtr BaseAddress
            );
        /// <inheritdoc cref="RtlAddFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, IntPtr)"/>
        public static unsafe bool RtlAddFunctionTable(
            Span<IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY> FunctionTable,
            IntPtr BaseAddress
            )
        {
            fixed (IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY* ptr = FunctionTable)
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
        /// <param name="FunctionTable">A pointer to an array of function entries that were previously passed to <see cref="RtlAddFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, IntPtr)"/> or an identifier previously passed to <see cref="RtlInstallFunctionTableCallback(IntPtr, IntPtr, int, GET_RUNTIME_FUNCTION_AMD64_CALLBACK, void*, string)"/>.</param>
        /// <returns>If the function succeeds, the return value is <see langword="true"/>. Otherwise, the return value is <see langword="false"/>.</returns>
        /// <remarks>
        /// <para>Function tables are used on 64-bit Windows to determine how to unwind or walk the stack. These tables are usually generated by the compiler and stored as part of the image. However, applications must provide the function table for dynamically generated code. For more information about function tables, see the architecture guide for your system.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtldeletefunctiontable">RtlDeleteFunctionTable function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="RtlAddFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, IntPtr)"/>
        /// <seealso cref="RtlInstallFunctionTableCallback(IntPtr, IntPtr, int, GET_RUNTIME_FUNCTION_AMD64_CALLBACK, void*, string)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        internal static unsafe extern byte RtlDeleteFunctionTable(
            [In] IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY* FunctionTable
            );
        /// <inheritdoc cref="RtlDeleteFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*)"/>
        public static unsafe bool RtlDeleteFunctionTable(
            Span<IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY> FunctionTable
            )
        {
            fixed (IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY* pFunctionTable = FunctionTable)
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
        /// <para>When a debugger unwinds to a function in the range of addresses managed by the callback function, it loads this DLL and calls the <see cref="OUT_OF_PROCESS_FUNCTION_TABLE_CALLBACK_EXPORT_NAME"/> function, whose type is <see cref="OUT_OF_PROCESS_FUNCTION_TABLE_AMD64_CALLBACK"/>.</para>
        /// </param>
        /// <returns>If the function succeeds, the return value is <see langword="true"/>. Otherwise, the return value is <see langword="false"/>.</returns>
        /// <remarks>
        /// <para>Function tables are used on 64-bit Windows to determine how to unwind or walk the stack. These tables are usually generated by the compiler and stored as part of the image. However, applications must provide the function table for dynamically generated code. For more information about function tables, see the architecture guide for your system.</para>
        /// <para>This function is useful for very dynamic code. The application specifies the memory range for the generated code, but does not need to generate a table until it is needed by an unwind request. At that time, the system calls the callback function with the <paramref name="Context"/> and the control address. The callback function must return the runtime function entry for the specified address. Be sure to avoid creating a deadlock between the callback function and the code generator.</para>
        /// <para>For code that is generated from a template or generated only once during the life of the process, use the <see cref="RtlAddFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, IntPtr)"/> function.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlinstallfunctiontablecallback">RtlInstallFunctionTableCallback function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="RtlAddFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, IntPtr)"/>
        /// <seealso cref="RtlDeleteFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static extern unsafe bool RtlInstallFunctionTableCallback(
            [In] IntPtr TableIdentifier,
            [In] IntPtr BaseAddress,
            [In] int Length,
            [In, MarshalAs(UnmanagedType.FunctionPtr)] GET_RUNTIME_FUNCTION_AMD64_CALLBACK Callback,
            [In] void* Context = null,
            [In, MarshalAs(UnmanagedType.LPWStr)] string OutOfProcessCallbackDll = null
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18670
        #region RtlAddGrowableFunctionTable function
        /// <summary>
        /// Informs the system of a dynamic function table representing a region of memory containing code.
        /// </summary>
        /// <param name="DynamicTable">A pointer variable that receives an opaque reference to the newly-added table on success.</param>
        /// <param name="FunctionTable">A pointer to a partially-filled array of <see cref="IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY"/> entries which provides unwind information for the region of code. The entries in this array must remain sorted in ascending order of the <see cref="IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY.BeginAddress"/> members.</param>
        /// <param name="EntryCount">The number of entries currently populated in the function table. This value may be zero.</param>
        /// <param name="MaximumEntryCount">The capacity of the function table.</param>
        /// <param name="RangeBase">The beginning of the memory range described by the function table.</param>
        /// <param name="RangeEnd">The end of the memory range described by the function table.</param>
        /// <returns>
        /// <para>This function returns zero on success. (More detail).</para>
        /// <para>See <a href="http://msdn.microsoft.com/en-us/library/cc704588(PROT.10).aspx">NTSTATUS Values</a> for a list of <see cref="NTSTATUS"/> values.</para>
        /// </returns>
        /// <remarks>
        /// <para>The function table can grow as code is added to the memory region. The entries in the table must be sorted. This table is used for dispatching exceptions through runtime-generated code and for collecting stack backtraces.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 8 [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2012 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtladdgrowablefunctiontable">RtlAddGrowableFunctionTable function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(NativeLibraryNames.Ntdll, CallingConvention = CallingConvention.StdCall)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP", Justification = "Documentation")]
        internal static unsafe extern NTSTATUS RtlAddGrowableFunctionTable(
            out IntPtr DynamicTable,
            [In] IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY* FunctionTable,
            [In] int EntryCount,
            [In] int MaximumEntryCount,
            [In] IntPtr RangeBase,
            [In] IntPtr RangeEnd
            );
        /// <inheritdoc cref="RtlAddGrowableFunctionTable(out IntPtr, IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, int, IntPtr, IntPtr)"/>
        public static unsafe NTSTATUS RtlAddGrowableFunctionTable(
            out IntPtr DynamicTable,
            Span<IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY> FunctionTable,
            int EntryCount,
            IntPtr RangeBase,
            IntPtr RangeEnd
            )
        {
            fixed (IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY* pFunctionTable = FunctionTable)
            {
                return RtlAddGrowableFunctionTable(
                    out DynamicTable,
                    pFunctionTable,
                    EntryCount,
                    FunctionTable.Length,
                    RangeBase,
                    RangeEnd
                    );
            }
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18683
        #region RtlGrowFunctionTable function
        /// <summary>
        /// Reports that a dynamic function table has increased in size.
        /// </summary>
        /// <param name="DynamicTable">An opaque reference returned by <see cref="RtlAddGrowableFunctionTable(out IntPtr, IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, int, IntPtr, IntPtr)"/>.</param>
        /// <param name="NewEntryCount">The new number of entries in the <see cref="IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY"/> array. This must be greater than the previously reported size of the array.</param>
        /// <remarks>
        /// <para><see cref="RtlGrowFunctionTable"/> should be called after populating the corresponding entries in the <see cref="IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY"/> array specified in <see cref="RtlAddGrowableFunctionTable(out IntPtr, IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, int, IntPtr, IntPtr)"/>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 8 [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2012 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlgrowfunctiontable">RtlGrowFunctionTable function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(NativeLibraryNames.Ntdll, CallingConvention = CallingConvention.StdCall)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP", Justification = "Documentation")]
        public static extern void RtlGrowFunctionTable(
            [In, Out] IntPtr DynamicTable,
            [In] int NewEntryCount
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18692
        #region RtlDeleteGrowableFunctionTable function
        /// <summary>
        /// Informs the system that a previously reported dynamic function table is no longer in use.
        /// </summary>
        /// <param name="DynamicTable">An opaque reference returned by <see cref="RtlAddGrowableFunctionTable(out IntPtr, IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, int, IntPtr, IntPtr)"/>.</param>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 8 [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2012 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtldeletegrowablefunctiontable">RtlDeleteGrowableFunctionTable function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(NativeLibraryNames.Ntdll, CallingConvention = CallingConvention.StdCall)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP", Justification = "Documentation")]
        public static extern void RtlDeleteGrowableFunctionTable(
            [In] IntPtr DynamicTable
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18707
        #region RtlLookupFunctionEntry functions
        /// <summary>
        /// Searches the active function tables for an entry that corresponds to the specified PC value.
        /// </summary>
        /// <param name="ControlPc">The virtual address of an instruction bundle within the function.</param>
        /// <param name="ImageBase">The base address of module to which the function belongs.</param>
        /// <param name="HistoryTable">The global pointer value of the module.</param>
        /// <returns>
        /// If there is no entry in the function table for the specified PC, the function returns <see langword="null"/>. Otherwise, the function returns the address of the function table entry that corresponds to the specified PC.
        /// </returns>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtllookupfunctionentry">RtlLookupFunctionEntry function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="RtlUnwindEx(IntPtr, IntPtr, in EXCEPTION_RECORD, IntPtr, ref CONTEXT_AMD64, ref UNWIND_HISTORY_TABLE_AMD64)"/>
        /// <seealso cref="RtlVirtualUnwind(UNW_FLAGS, IntPtr, IntPtr, IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, ref CONTEXT_AMD64, out IntPtr, out IntPtr, KNONVOLATILE_CONTEXT_POINTERS_AMD64*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.StdCall)]
        public static unsafe extern IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY* RtlLookupFunctionEntry(
            [In] IntPtr ControlPc,
            out IntPtr ImageBase,
            [Optional] UNWIND_HISTORY_TABLE_AMD64* HistoryTable
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18723
        #region RtlRestoreContext function
        /// <summary>
        /// Restores the context of the caller to the specified context record.
        /// </summary>
        /// <param name="ContextRecord">A <see cref="CONTEXT_AMD64"/> structure.</param>
        /// <param name="ExceptionRecord">
        /// <para>A pointer to an <see cref="EXCEPTION_RECORD"/> structure. This parameter is optional and should typically be <see langword="null"/>.</para>
        /// <para>An exception record is used primarily with long jump and C++ catch-throw support. If the <see cref="EXCEPTION_RECORD.ExceptionCode"/> member is <see cref="STATUS_LONGJUMP"/>, the <see cref="EXCEPTION_RECORD.ExceptionInformation"/> member contains a pointer to a jump buffer. <see cref="RtlRestoreContext(in CONTEXT_AMD64, EXCEPTION_RECORD*)"/> will copy the non-volatile state from the jump buffer in to the context record before the context record is restored.</para>
        /// <para>If the <see cref="EXCEPTION_RECORD.ExceptionCode"/> member is <see cref="STATUS_UNWIND_CONSOLIDATE"/>, the <see cref="EXCEPTION_RECORD.ExceptionInformation"/> member contains a pointer to a callback function, such as a catch handler. <see cref="RtlRestoreContext(in CONTEXT_AMD64, EXCEPTION_RECORD*)"/> consolidates the call frames between its frame and the frame specified in the context record before calling the callback function. This hides frames from any exception handling that might occur in the callback function. The difference between this and a typical unwind is that the data on the stack is still present, so frame data such as a throw object is still available. The callback function returns a new program counter to update in the context record, which is then used in a normal restore context.</para>
        /// </param>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlrestorecontext">RtlRestoreContext function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CONTEXT"/>
        /// <seealso cref="RtlCaptureContext"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static extern unsafe void RtlRestoreContext(
            [In] in CONTEXT_AMD64 ContextRecord,
            [In] EXCEPTION_RECORD* ExceptionRecord = null
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18738
        #region RtlUnwindEx function
        /// <summary>
        /// Initiates an unwind of procedure call frames.
        /// </summary>
        /// <param name="TargetFrame">A pointer to the call frame that is the target of the unwind. If this parameter is <see cref="IntPtr.Zero"/>, the function performs an exit unwind.</param>
        /// <param name="TargetIp">The continuation address of the unwind. This parameter is ignored if <paramref name="TargetFrame"/> is <see cref="IntPtr.Zero"/>.</param>
        /// <param name="ExceptionRecord">A read-only reference to an <see cref="EXCEPTION_RECORD"/> structure.</param>
        /// <param name="ReturnValue">A value to be placed in the integer function return register before continuing execution.</param>
        /// <param name="ContextRecord">A reference to a <see cref="CONTEXT_AMD64"/> structure that stores context during the unwind operation.</param>
        /// <param name="HistoryTable">A reference to the unwind history table. This structure is processor specific.</param>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlunwindex">RtlUnwindEx function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CONTEXT_AMD64"/>
        /// <seealso cref="EXCEPTION_RECORD"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static extern void RtlUnwindEx(
            [In, Optional] IntPtr TargetFrame,
            [In, Optional] IntPtr TargetIp,
            [In, Optional] in EXCEPTION_RECORD ExceptionRecord,
            [In] IntPtr ReturnValue,
            [In] ref CONTEXT_AMD64 ContextRecord,
            [In, Optional] ref UNWIND_HISTORY_TABLE_AMD64 HistoryTable
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18757
        #region RtlVirtualUnwind function
        /// <summary>
        /// Retrieves the invocation context of the function that precedes the specified function context.
        /// <para>
        /// <note>This function is not implemented on all processor platforms and the implementation is different on each platform that supports it. The following prototype lists all the potential parameters and their application. Read further for processor-specific function prototypes.</note>
        /// </para>
        /// </summary>
        /// <param name="HandlerType">
        /// <para>The handler type.</para>
        /// <para>This parameter is only present on x64.</para>
        /// </param>
        /// <param name="ImageBase">The base address of the module to which the function belongs.</param>
        /// <param name="ControlPc">The virtual address where control left the specified function.</param>
        /// <param name="FunctionEntry">The address of the function table entry for the specified function. To obtain the function table entry, call the <see cref="RtlLookupFunctionEntry(IntPtr, out IntPtr, UNWIND_HISTORY_TABLE_AMD64*)"/> function.</param>
        /// <param name="ContextRecord">A reference to a <see cref="CONTEXT_AMD64"/> structure that represents the context of the previous frame.</param>
        /// <param name="HandlerData">
        /// <para>The location of the PC. If this parameter is 0, the PC is in the prologue, epilogue, or a null frame region of the function. If this parameter is 1, the PC is in the body of the function.</para>
        /// <para>This parameter is not present on x64.</para>
        /// </param>
        /// <param name="EstablisherFrame">A pointer that receives the establisher frame pointer value.</param>
        /// <param name="ContextPointers">An optional pointer to a context pointers structure.</param>
        /// <returns>This function returns an <see cref="EXCEPTION_ROUTINE"/> callback function.</returns>
        /// <remarks>
        /// <para>
        /// The complete list of epilogue markers for x64 is as follows:
        /// <list type="bullet">
        /// <item>ret</item>
        /// <item>ret <em>n</em></item>
        /// <item>rep ret</item>
        /// <item>jmp <em>imm8</em> | <em>imm32</em> where the target is outside the function being unwound</item>
        /// <item>jmp qword ptr <em>imm32</em></item>
        /// <item>rex.w jmp <em>reg</em></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlvirtualunwind">RtlVirtualUnwind function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CONTEXT_AMD64"/>
        /// <seealso cref="EXCEPTION_RECORD"/>
        /// <seealso cref="RtlLookupFunctionEntry(IntPtr, out IntPtr, UNWIND_HISTORY_TABLE_AMD64*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        [return: MarshalAs(UnmanagedType.FunctionPtr)]
        public static unsafe extern EXCEPTION_ROUTINE RtlVirtualUnwind(
            [In, MarshalAs(UnmanagedType.I4)] UNW_FLAGS HandlerType,
            [In] IntPtr ImageBase,
            [In] IntPtr ControlPc,
            [In] IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY* FunctionEntry,
            ref CONTEXT_AMD64 ContextRecord,
            out IntPtr HandlerData,
            out IntPtr EstablisherFrame,
            [Optional] KNONVOLATILE_CONTEXT_POINTERS_AMD64* ContextPointers
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18786
        #region RtlAddFunctionTable function
        /// <inheritdoc cref="RtlAddFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, IntPtr)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        internal static unsafe extern byte RtlAddFunctionTable(
            [In] IMAGE_ARM_RUNTIME_FUNCTION_ENTRY* FunctionTable,
            [In] int EntryCount,
            [In] IntPtr BaseAddress
            );
        /// <inheritdoc cref="RtlAddFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, IntPtr)"/>
        public static unsafe bool RtlAddFunctionTable(
            Span<IMAGE_ARM_RUNTIME_FUNCTION_ENTRY> FunctionTable,
            IntPtr BaseAddress
            )
        {
            fixed (IMAGE_ARM_RUNTIME_FUNCTION_ENTRY* ptr = FunctionTable)
            {
                return RtlAddFunctionTable(ptr, FunctionTable.Length, BaseAddress) != 0;
            }
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18796
        #region RtlDeleteFunctionTable function
        /// <inheritdoc cref="RtlDeleteFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        internal static unsafe extern byte RtlDeleteFunctionTable(
            [In] IMAGE_ARM_RUNTIME_FUNCTION_ENTRY* FunctionTable
            );
        /// <inheritdoc cref="RtlDeleteFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*)"/>
        public static unsafe bool RtlDeleteFunctionTable(
            Span<IMAGE_ARM_RUNTIME_FUNCTION_ENTRY> FunctionTable
            )
        {
            fixed (IMAGE_ARM_RUNTIME_FUNCTION_ENTRY* pFunctionTable = FunctionTable)
            {
                return RtlDeleteFunctionTable(pFunctionTable) != 0;
            }
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18801
        #region RtlInstallFunctionTableCallback function
        /// <inheritdoc cref="RtlInstallFunctionTableCallback(IntPtr, IntPtr, int, GET_RUNTIME_FUNCTION_AMD64_CALLBACK, void*, string)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static extern unsafe bool RtlInstallFunctionTableCallback(
            [In] IntPtr TableIdentifier,
            [In] IntPtr BaseAddress,
            [In] int Length,
            [In, MarshalAs(UnmanagedType.FunctionPtr)] GET_RUNTIME_FUNCTION_ARM_CALLBACK Callback,
            [In] void* Context = null,
            [In, MarshalAs(UnmanagedType.LPWStr)] string OutOfProcessCallbackDll = null
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18816
        #region RtlAddGrowableFunctionTable function
        /// <inheritdoc cref="RtlAddGrowableFunctionTable(out IntPtr, IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, int, IntPtr, IntPtr)"/>
        [DllImport(NativeLibraryNames.Ntdll, CallingConvention = CallingConvention.StdCall)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP", Justification = "Documentation")]
        internal static unsafe extern NTSTATUS RtlAddGrowableFunctionTable(
            out IntPtr DynamicTable,
            [In] IMAGE_ARM_RUNTIME_FUNCTION_ENTRY* FunctionTable,
            [In] int EntryCount,
            [In] int MaximumEntryCount,
            [In] IntPtr RangeBase,
            [In] IntPtr RangeEnd
            );
        /// <inheritdoc cref="RtlAddGrowableFunctionTable(out IntPtr, IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, int, IntPtr, IntPtr)"/>
        public static unsafe NTSTATUS RtlAddGrowableFunctionTable(
            out IntPtr DynamicTable,
            Span<IMAGE_ARM_RUNTIME_FUNCTION_ENTRY> FunctionTable,
            int EntryCount,
            IntPtr RangeBase,
            IntPtr RangeEnd
            )
        {
            fixed (IMAGE_ARM_RUNTIME_FUNCTION_ENTRY* pFunctionTable = FunctionTable)
            {
                return RtlAddGrowableFunctionTable(
                    out DynamicTable,
                    pFunctionTable,
                    EntryCount,
                    FunctionTable.Length,
                    RangeBase,
                    RangeEnd
                    );
            }
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18829
        #region RtlGrowFunctionTable function
        // See above
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18838
        #region RtlDeleteGrowableFunctionTable function
        // See above
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18853
        #region RtlLookupFunctionEntry functions
        /// <inheritdoc cref="RtlLookupFunctionEntry(IntPtr, out IntPtr, UNWIND_HISTORY_TABLE_AMD64*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.StdCall)]
        public static unsafe extern IMAGE_ARM_RUNTIME_FUNCTION_ENTRY* RtlLookupFunctionEntry(
            [In] IntPtr ControlPc,
            out IntPtr ImageBase,
            [Optional] UNWIND_HISTORY_TABLE_ARM* HistoryTable
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18869
        #region RtlRestoreContext function
        /// <inheritdoc cref="RtlRestoreContext(in CONTEXT_AMD64, EXCEPTION_RECORD*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static extern unsafe void RtlRestoreContext(
            [In] in CONTEXT_ARM ContextRecord,
            [In] EXCEPTION_RECORD* ExceptionRecord = null
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18884
        #region RtlUnwindEx function
        /// <inheritdoc cref="RtlUnwindEx(IntPtr, IntPtr, in EXCEPTION_RECORD, IntPtr, ref CONTEXT_AMD64, ref UNWIND_HISTORY_TABLE_AMD64)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static extern void RtlUnwindEx(
            [In, Optional] IntPtr TargetFrame,
            [In, Optional] IntPtr TargetIp,
            [In, Optional] in EXCEPTION_RECORD ExceptionRecord,
            [In] IntPtr ReturnValue,
            [In] ref CONTEXT_ARM ContextRecord,
            [In, Optional] ref UNWIND_HISTORY_TABLE_ARM HistoryTable
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18903
        #region RtlVirtualUnwind function
        /// <inheritdoc cref="RtlVirtualUnwind(UNW_FLAGS, IntPtr, IntPtr, IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, ref CONTEXT_AMD64, out IntPtr, out IntPtr, KNONVOLATILE_CONTEXT_POINTERS_AMD64*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        [return: MarshalAs(UnmanagedType.FunctionPtr)]
        public static unsafe extern EXCEPTION_ROUTINE RtlVirtualUnwind(
            [In, MarshalAs(UnmanagedType.I4)] UNW_FLAGS HandlerType,
            [In] IntPtr ImageBase,
            [In] IntPtr ControlPc,
            [In] IMAGE_ARM_RUNTIME_FUNCTION_ENTRY* FunctionEntry,
            ref CONTEXT_ARM ContextRecord,
            out IntPtr HandlerData,
            out IntPtr EstablisherFrame,
            [Optional] KNONVOLATILE_CONTEXT_POINTERS_ARM* ContextPointers
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18929
        #region RtlAddFunctionTable function
        /// <inheritdoc cref="RtlAddFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, IntPtr)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        internal static unsafe extern byte RtlAddFunctionTable(
            [In] IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* FunctionTable,
            [In] int EntryCount,
            [In] IntPtr BaseAddress
            );
        /// <inheritdoc cref="RtlAddFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, IntPtr)"/>
        public static unsafe bool RtlAddFunctionTable(
            Span<IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY> FunctionTable,
            IntPtr BaseAddress
            )
        {
            fixed (IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* ptr = FunctionTable)
            {
                return RtlAddFunctionTable(ptr, FunctionTable.Length, BaseAddress) != 0;
            }
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18939
        #region RtlDeleteFunctionTable function
        /// <inheritdoc cref="RtlDeleteFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        internal static unsafe extern byte RtlDeleteFunctionTable(
            [In] IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* FunctionTable
            );
        /// <inheritdoc cref="RtlDeleteFunctionTable(IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*)"/>
        public static unsafe bool RtlDeleteFunctionTable(
            Span<IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY> FunctionTable
            )
        {
            fixed (IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* pFunctionTable = FunctionTable)
            {
                return RtlDeleteFunctionTable(pFunctionTable) != 0;
            }
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18947
        #region RtlInstallFunctionTableCallback function
        /// <inheritdoc cref="RtlInstallFunctionTableCallback(IntPtr, IntPtr, int, GET_RUNTIME_FUNCTION_AMD64_CALLBACK, void*, string)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static extern unsafe bool RtlInstallFunctionTableCallback(
            [In] IntPtr TableIdentifier,
            [In] IntPtr BaseAddress,
            [In] int Length,
            [In, MarshalAs(UnmanagedType.FunctionPtr)] GET_RUNTIME_FUNCTION_ARM64_CALLBACK Callback,
            [In] void* Context = null,
            [In, MarshalAs(UnmanagedType.LPWStr)] string OutOfProcessCallbackDll = null
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18962
        #region RtlAddGrowableFunctionTable function
        /// <inheritdoc cref="RtlAddGrowableFunctionTable(out IntPtr, IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, int, IntPtr, IntPtr)"/>
        [DllImport(NativeLibraryNames.Ntdll, CallingConvention = CallingConvention.StdCall)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP", Justification = "Documentation")]
        internal static unsafe extern NTSTATUS RtlAddGrowableFunctionTable(
            out IntPtr DynamicTable,
            [In] IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* FunctionTable,
            [In] int EntryCount,
            [In] int MaximumEntryCount,
            [In] IntPtr RangeBase,
            [In] IntPtr RangeEnd
            );
        /// <inheritdoc cref="RtlAddGrowableFunctionTable(out IntPtr, IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, int, int, IntPtr, IntPtr)"/>
        public static unsafe NTSTATUS RtlAddGrowableFunctionTable(
            out IntPtr DynamicTable,
            Span<IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY> FunctionTable,
            int EntryCount,
            IntPtr RangeBase,
            IntPtr RangeEnd
            )
        {
            fixed (IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* pFunctionTable = FunctionTable)
            {
                return RtlAddGrowableFunctionTable(
                    out DynamicTable,
                    pFunctionTable,
                    EntryCount,
                    FunctionTable.Length,
                    RangeBase,
                    RangeEnd
                    );
            }
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18975
        #region RtlGrowFunctionTable function
        // See above
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18984
        #region RtlDeleteGrowableFunctionTable function
        // See above
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18999
        #region RtlLookupFunctionEntry function
        /// <inheritdoc cref="RtlLookupFunctionEntry(IntPtr, out IntPtr, UNWIND_HISTORY_TABLE_AMD64*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.StdCall)]
        public static unsafe extern IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* RtlLookupFunctionEntry(
            [In] IntPtr ControlPc,
            out IntPtr ImageBase,
            [Optional] UNWIND_HISTORY_TABLE_ARM64* HistoryTable
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19015
        #region RtlRestoreContext function
        /// <inheritdoc cref="RtlRestoreContext(in CONTEXT_AMD64, EXCEPTION_RECORD*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Cdecl)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static extern unsafe void RtlRestoreContext(
            [In] in ARM64_NT_CONTEXT ContextRecord,
            [In] EXCEPTION_RECORD* ExceptionRecord = null
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19030
        #region RtlUnwindEx function
        /// <inheritdoc cref="RtlUnwindEx(IntPtr, IntPtr, in EXCEPTION_RECORD, IntPtr, ref CONTEXT_AMD64, ref UNWIND_HISTORY_TABLE_AMD64)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static extern void RtlUnwindEx(
            [In, Optional] IntPtr TargetFrame,
            [In, Optional] IntPtr TargetIp,
            [In, Optional] in EXCEPTION_RECORD ExceptionRecord,
            [In] IntPtr ReturnValue,
            [In] ref ARM64_NT_CONTEXT ContextRecord,
            [In, Optional] ref UNWIND_HISTORY_TABLE_ARM64 HistoryTable
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19049
        #region RtlVirtualUnwind function
        /// <inheritdoc cref="RtlVirtualUnwind(UNW_FLAGS, IntPtr, IntPtr, IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY*, ref CONTEXT_AMD64, out IntPtr, out IntPtr, KNONVOLATILE_CONTEXT_POINTERS_AMD64*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        [return: MarshalAs(UnmanagedType.FunctionPtr)]
        public static unsafe extern EXCEPTION_ROUTINE RtlVirtualUnwind(
            [In, MarshalAs(UnmanagedType.I4)] UNW_FLAGS HandlerType,
            [In] IntPtr ImageBase,
            [In] IntPtr ControlPc,
            [In] IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* FunctionEntry,
            ref ARM64_NT_CONTEXT ContextRecord,
            out IntPtr HandlerData,
            out IntPtr EstablisherFrame,
            [Optional] KNONVOLATILE_CONTEXT_POINTERS_ARM64* ContextPointers
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19074
        #region RtlUnwindEx function
        // See above
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19093
        #region RtlLookupFunctionEntryCHPE function
        /// <inheritdoc cref="RtlLookupFunctionEntry(IntPtr, out IntPtr, UNWIND_HISTORY_TABLE_AMD64*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.StdCall)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static unsafe extern IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* RtlLookupFunctionEntryCHPE(
            [In] IntPtr ControlPc,
            out IntPtr ImageBase,
            [Optional] UNWIND_HISTORY_TABLE_ARM64* HistoryTable
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19112
        #region RtlPcToFileHeader function
        /// <summary>
        /// Retrieves the base address of the image that contains the specified PC value.
        /// </summary>
        /// <param name="PcValue">The PC value. The function searches all modules mapped into the address space of the calling process for a module that contains this value.</param>
        /// <param name="BaseOfImage">The base address of the image containing the PC value. This value must be added to any relative addresses in the headers to locate the image.</param>
        /// <returns>
        /// <para>If the PC value is found, the function returns the base address of the image that contains the PC value.</para>
        /// <para>If no image contains the PC value, the function returns <see cref="IntPtr.Zero"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlpctofileheader">RtlPcToFileHeader function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="RtlLookupFunctionEntry(IntPtr, out IntPtr, UNWIND_HISTORY_TABLE_AMD64*)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr RtlPcToFileHeader(
            [In] IntPtr PcValue,
            out IntPtr BaseOfImage
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19130
        #region RtlCompareMemory function
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP")]
        public static extern UIntPtr RtlCompareMemory(
            [In] IntPtr Source1,
            [In] IntPtr Source2,
            [In] UIntPtr Length
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19248
        #region RtlInitializeSListHead function
        /// <summary>
        /// Initializes the head of a singly linked list.
        /// </summary>
        /// <param name="ListHead">Receives an initialized <see cref="SLIST_HEADER"/> structure on return that represents the head of a singly linked list. This structure is for system use only.</param>
        /// <remarks>
        /// <para>Calls to the <see cref="InitializeSListHead"/> function are forwarded to the <see cref="RtlInitializeSListHead"/> function. Applications should call <see cref="InitializeSListHead"/> instead of calling this function directly.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlinitializeslisthead">RtlInitializeSListHead function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://msdn.microsoft.com/35463ace-33ab-4eb9-9901-2504a92456e2">Interlocked Singly Linked Lists</seealso>
        [DllImport(NativeLibraryNames.Ntdll, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP", Justification = "Documentation")]
        public static extern void RtlInitializeSListHead(
            out SLIST_HEADER ListHead
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19255
        #region RtlFirstEntrySList function
        /// <summary>
        /// Retrieves the first entry in a singly linked list. Access to the list is synchronized on a multiprocessor system.
        /// </summary>
        /// <param name="ListHead">
        /// <para>A read-only reference to an <see cref="SLIST_HEADER"/> structure that represents the head of a singly linked list. This structure is for system use only.</para>
        /// <para>The list must be previously initialized with the <see cref="InitializeSListHead"/> function.</para>
        /// </param>
        /// <returns>The return value is a reference to the first entry in the list. If the list is empty, the return value is <see langword="null"/>.</returns>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlfirstentryslist">RtlFirstEntrySList function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://msdn.microsoft.com/35463ace-33ab-4eb9-9901-2504a92456e2">Interlocked Singly Linked Lists</seealso>
        [DllImport(NativeLibraryNames.Ntdll, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP", Justification = "Documentation")]
        public static extern ref SLIST_ENTRY RtlFirstEntrySList(
            in SLIST_HEADER ListHead
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19263
        #region RtlInterlockedPopEntrySList function
        /// <summary>
        /// Removes an item from the front of a singly linked list. Access to the list is synchronized on a multiprocessor system.
        /// </summary>
        /// <param name="ListHead">A reference to an <see cref="SLIST_HEADER"/> structure that represents the head of a singly linked list. This structure is for system use only.</param>
        /// <returns>The return value is a reference to the first entry in the list. If the list is empty, the return value is <see langword="null"/>.</returns>
        /// <remarks>
        /// <para>Calls to the <see cref="InterlockedPopEntrySList"/> function are forwarded to the <see cref="RtlInterlockedPopEntrySList"/> function. Applications should call <see cref="InterlockedPopEntrySList"/> instead of calling this function directly.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlinterlockedpopentryslist">RtlInterlockedPopEntrySList function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://msdn.microsoft.com/35463ace-33ab-4eb9-9901-2504a92456e2">Interlocked Singly Linked Lists</seealso>
        [DllImport(NativeLibraryNames.Ntdll, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP", Justification = "Documentation")]
        public static extern ref SLIST_ENTRY RtlInterlockedPopEntrySList(
            ref SLIST_HEADER ListHead
            );
        #endregion
        #region RtlInterlockedPushEntrySList function
        /// <summary>
        /// Inserts an item at the front of a singly linked list. Access to the list is synchronized on a multiprocessor system.
        /// </summary>
        /// <param name="ListHead">A reference to an <see cref="SLIST_HEADER"/> structure that represents the head of a singly linked list. This structure is for system use only.</param>
        /// <param name="ListEntry">A reference to an <see cref="SLIST_ENTRY"/> structure that represents an item in a singly linked list.</param>
        /// <returns>The return value is a reference to the previous first entry in the list. If the list was previously empty, the return value is <see langword="null"/>.</returns>
        /// <remarks>
        /// <para>Calls to the <see cref="InterlockedPushEntrySList"/> function are forwarded to the <see cref="RtlInterlockedPushEntrySList"/> function. Applications should call <see cref="InterlockedPushEntrySList"/> instead of calling this function directly.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlinterlockedpushentryslist">RtlInterlockedPushEntrySList function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://msdn.microsoft.com/35463ace-33ab-4eb9-9901-2504a92456e2">Interlocked Singly Linked Lists</seealso>
        [DllImport(NativeLibraryNames.Ntdll, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP", Justification = "Documentation")]
        public static extern ref SLIST_ENTRY RtlInterlockedPushEntrySList(
            ref SLIST_HEADER ListHead,
            ref SLIST_ENTRY ListEntry
            );
        #endregion
        #region RtlInterlockedPushListSListEx function
        [DllImport(NativeLibraryNames.Ntdll, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP", Justification = "Documentation")]
        public static extern ref SLIST_ENTRY RtlInterlockedPushListSListEx(
            ref SLIST_HEADER ListHead,
            ref SLIST_ENTRY ListEntry,
            ref SLIST_ENTRY ListEnd,
            [In] int count
            );
        #endregion
        #region RtlInterlockedFlushSList function
        /// <summary>
        /// Removes all items from a singly linked list. Access to the list is synchronized on a multiprocessor system.
        /// </summary>
        /// <param name="ListHead">A reference to an <see cref="SLIST_HEADER"/> structure that represents the head of a singly linked list. This structure is for system use only.</param>
        /// <returns>The return value is a reference to the previous first entry in the list. If the list was previously empty, the return value is <see langword="null"/>.</returns>
        /// <remarks>
        /// <para>Calls to the <see cref="InterlockedFlushSList"/> function are forwarded to the <see cref="RtlInterlockedFlushSList"/> function. Applications should call <see cref="InterlockedFlushSList"/> instead of calling this function directly.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/nf-winnt-rtlinterlockedflushslist">RtlInterlockedFlushSList function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://msdn.microsoft.com/35463ace-33ab-4eb9-9901-2504a92456e2">Interlocked Singly Linked Lists</seealso>
        [DllImport(NativeLibraryNames.Ntdll, CallingConvention = CallingConvention.Winapi)]
        [SuppressMessage("Usage", "PC003: Native API not available in UWP", Justification = "Documentation")]
        public static extern ref SLIST_ENTRY RtlInterlockedFlushSList(
            ref SLIST_HEADER ListHead
            );
        #endregion

    }
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.SCardErr;
using THNETII.WinApi.Native.WinError;
using THNETII.WinApi.Native.WinSmcrd;

#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.WinSCard
{
    using static NativeLibraryNames;
    using static SCardErrConstants;
    using static WinSCardConstants;
    using static WinSmcrdConstants;

    public static class WinSCardFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 80
        //
        ////////////////////////////////////////////////////////////////////////////////
        //
        //  Service Manager Access Services
        //
        //      The following services are used to manage user and terminal contexts for
        //      Smart Cards.
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 111
        #region SCardEstablishContext function
        /// <summary>
        /// The <see cref="SCardEstablishContext"/> function establishes the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a> (the scope) within which database operations are performed.
        /// </summary>
        /// <param name="dwScope">Scope of the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>.</param>
        /// <param name="pvReserved1">Reserved for future use and must be <see cref="IntPtr.Zero"/>. This parameter will allow a suitably privileged management application to act on behalf of another user.</param>
        /// <param name="pvReserved2">Reserved for future use and must be <see cref="IntPtr.Zero"/>.</param>
        /// <param name="phContext">A handle to the established <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. This handle can now be supplied to other functions attempting to do work within this context.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The context handle returned by <see cref="SCardEstablishContext"/> can be used by database query and management functions. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-query-functions">Smart Card Database Query Functions</a> and <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-management-functions">Smart Card Database Management Functions</a>.</para>
        /// <para>To release an established resource manager context, use <see cref="SCardReleaseContext"/>.</para>
        /// <para>If the client attempts a smart card operation in a remote session, such as a client session running on a terminal server, and the operating system in use does not support smart card redirection, this function returns <see cref="WinErrorConstants.ERROR_BROKEN_PIPE"/>.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winscard/nf-winscard-scardestablishcontext">SCardEstablishContext function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardReleaseContext"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardEstablishContext(
            [In, MarshalAs(UnmanagedType.I4)] SCARD_SCOPE_TYPE dwScope,
            [In] IntPtr pvReserved1,
            [In] IntPtr pvReserved2,
            out SCARDCONTEXT phContext
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 118
        #region SCardReleaseContext function
        /// <summary>
        /// The <see cref="SCardReleaseContext"/> function closes an established <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>, freeing any resources allocated under that context, including <see cref="SCARDHANDLE"/> objects and memory allocated using the <see cref="SCARD_AUTOALLOCATE"/> length designator.
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a> is set by a previous call to <see cref="SCardEstablishContext"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winscard/nf-winscard-scardreleasecontext">SCardReleaseContext function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardReleaseContext(
            [In] SCARDCONTEXT hContext
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 122
        #region SCardIsValidContext function
        /// <summary>
        /// The <see cref="SCardIsValidContext"/> function determines whether a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> context handle is valid.
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context can be set by a previous call to <see cref="SCardEstablishContext"/>.</param>
        /// <returns>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><see cref="SCARD_S_SUCCESS"/></term><description>The <paramref name="hContext"/> parameter is valid. </description></item>
        /// <item><term><see cref="WinErrorConstants.ERROR_INVALID_HANDLE"/></term><description>The <paramref name="hContext"/> parameter is not valid. </description></item>
        /// <item><term>Other value</term><description>An error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>. </description></item>
        /// </list>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see </para>
        /// </returns>
        /// <remarks>
        /// Call this function to determine whether a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> context handle is still valid. After a smart card context handle has been set by <see cref="SCardEstablishContext"/>, it may become not valid if the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager</a> service has been shut down.
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winscard/nf-winscard-scardisvalidcontext">SCardIsValidContext function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardIsValidContext(
            [In] SCARDCONTEXT hContext
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 127
        //
        ////////////////////////////////////////////////////////////////////////////////
        //
        //  Smart Card Database Management Services
        //
        //      The following services provide for managing the Smart Card Database.
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 145
        //
        // Database Reader routines
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 149
        #region SCardListReaderGroupsA function
        /// <inheritdoc cref="SCardListReaderGroups(SCARDCONTEXT, LPMTSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardListReaderGroupsA(
            [In] SCARDCONTEXT hContext,
            [In, Optional] LPMSTR mszGroups,
            ref int pcchGroups
            );

        /// <inheritdoc cref="SCardListReaderGroupsA(SCARDCONTEXT, LPMSTR, ref int)"/>
        public static unsafe int SCardListReaderGroupsA(
            SCARDCONTEXT hContext,
            out LPMSTR mszGroups,
            out int pcchGroups
            )
        {
            pcchGroups = SCARD_AUTOALLOCATE;
            fixed (void* pmszGroups = &mszGroups)
                return SCardListReaderGroupsA(
                    hContext,
                    Pointer.Create<LPMSTR>(pmszGroups),
                    ref pcchGroups
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 154
        #region SCardListReaderGroupsW function
        /// <inheritdoc cref="SCardListReaderGroups(SCARDCONTEXT, LPMTSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardListReaderGroupsW(
            [In] SCARDCONTEXT hContext,
            [In, Optional] LPMWSTR mszGroups,
            ref int pcchGroups
            );

        /// <inheritdoc cref="SCardListReaderGroupsW(SCARDCONTEXT, LPMWSTR, ref int)"/>
        public static unsafe int SCardListReaderGroupsW(
            SCARDCONTEXT hContext,
            out LPMWSTR mszGroups,
            out int pcchGroups
            )
        {
            pcchGroups = SCARD_AUTOALLOCATE;
            fixed (void* pmszGroups = &mszGroups)
                return SCardListReaderGroupsW(
                    hContext,
                    Pointer.Create<LPMWSTR>(pmszGroups),
                    ref pcchGroups
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 160
        #region SCardListReaderGroups function
        /// <summary>
        /// The <see cref="SCardListReaderGroups"/> function provides the list of <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader groups</a> that have previously been introduced to the system.
        /// </summary>
        /// <param name="hContext">
        /// <para>Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a> for the query. The resource manager context can be set by a previous call to <see cref="SCardEstablishContext"/>.</para>
        /// <para>If this parameter is set to <see langword="default"/>, the search for reader groups is not limited to any context.</para>
        /// </param>
        /// <param name="mszGroups">Multi-string that lists the reader groups defined to the system and available to the current user on the current <a href="https://docs.microsoft.com/windows/desktop/SecGloss/t-gly">terminal</a>. If this value is <see langword="default"/>, <see cref="SCardListReaderGroups"/> ignores the buffer length supplied in <paramref name="pcchGroups"/>, writes the length of the buffer that would have been returned if this parameter had not been <see langword="default"/> to <paramref name="pcchGroups"/>, and returns a success code.</param>
        /// <param name="pcchGroups">Length of the <paramref name="mszGroups"/> buffer in characters, and receives the actual length of the multi-string structure, including all trailing null characters. If the buffer length is specified as <see cref="SCARD_AUTOALLOCATE"/>, then <paramref name="mszGroups"/> is converted to a pointer to a byte pointer, and receives the address of a block of memory containing the multi-string structure. This block of memory must be deallocated with <see cref="SCardFreeMemory"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>A group is returned only if it contains at least one reader. This includes the group <c>SCard$DefaultReaders</c>. The group <c>SCard$AllReaders</c> cannot be returned, since it only exists implicitly.</para>
        /// <para>The <see cref="SCardListReaderGroups"/> function is a database query function. For more information on other database query functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-query-functions">Smart Card Database Query Functions</a>.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winscard/nf-winscard-scardlistreadergroupsw">SCardListReaderGroupsW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardFreeMemory"/>
        /// <seealso cref="SCardGetProviderId"/>
        /// <seealso cref="SCardListCards"/>
        /// <seealso cref="SCardListInterfaces"/>
        /// <seealso cref="SCardListReaders"/>
#if NETSTANDARD1_3
        public static
#else
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#endif // !NETSTANDARD1_3
            int SCardListReaderGroups(
            [In] SCARDCONTEXT hContext,
            [In, Optional] LPMTSTR mszGroups,
            ref int pcchGroups
            )
#if NETSTANDARD1_3
        => Marshal.SystemDefaultCharSize switch
        {
            1 => SCardListReaderGroupsA(hContext, Pointer.Create<LPMSTR>(mszGroups.Pointer), ref pcchGroups),
            2 => SCardListReaderGroupsW(hContext, Pointer.Create<LPMWSTR>(mszGroups.Pointer), ref pcchGroups),
            _ => throw new PlatformNotSupportedException()
        };
#else
        ;
#endif // !NETSTANDARD1_3

        /// <inheritdoc cref="SCardListReaderGroups(SCARDCONTEXT, LPMTSTR, ref int)"/>
        public static unsafe int SCardListReaderGroups(
            SCARDCONTEXT hContext,
            out LPMTSTR mszGroups,
            out int pcchGroups
            )
        {
            pcchGroups = SCARD_AUTOALLOCATE;
            fixed (void* pmszGroups = &mszGroups)
                return SCardListReaderGroups(
                    hContext,
                    Pointer.Create<LPMTSTR>(pmszGroups),
                    ref pcchGroups
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 165
        #region SCardListReadersA function
        /// <inheritdoc cref="SCardListReaders(SCARDCONTEXT, LPCMTSTR, LPMTSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardListReadersA(
            [In] SCARDCONTEXT hContext,
            [In, Optional] LPCMSTR mszGroups,
            LPMSTR mszReaders,
            ref int pcchReaders
            );

        /// <inheritdoc cref="SCardListReadersA(SCARDCONTEXT, LPCMSTR, LPMSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardListReadersA(
            [In] SCARDCONTEXT hContext,
            [In, Optional] string mszGroups,
            LPMSTR mszReaders,
            ref int pcchReaders
            );

        /// <inheritdoc cref="SCardListReadersA(SCARDCONTEXT, LPCMSTR, LPMSTR, ref int)"/>
        public static unsafe int SCardListReadersA(
            SCARDCONTEXT hContext,
            LPCMSTR mszGroups,
            out LPMSTR mszReaders,
            out int pcchReaders
            )
        {
            pcchReaders = SCARD_AUTOALLOCATE;
            fixed (void* pmszReaders = &mszReaders)
                return SCardListReadersA(
                    hContext,
                    mszGroups,
                    Pointer.Create<LPMSTR>(pmszReaders),
                    ref pcchReaders
                    );
        }

        /// <inheritdoc cref="SCardListReadersA(SCARDCONTEXT, LPCMSTR, LPMSTR, ref int)"/>
        public static unsafe int SCardListReadersA(
            SCARDCONTEXT hContext,
            string mszGroups,
            out LPMSTR mszReaders,
            out int pcchReaders
            )
        {
            pcchReaders = SCARD_AUTOALLOCATE;
            fixed (void* pmszReaders = &mszReaders)
                return SCardListReadersA(
                    hContext,
                    mszGroups,
                    Pointer.Create<LPMSTR>(pmszReaders),
                    ref pcchReaders
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 175
        #region SCardListReadersW function
        /// <inheritdoc cref="SCardListReaders(SCARDCONTEXT, LPCMTSTR, LPMTSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardListReadersW(
            [In] SCARDCONTEXT hContext,
            [In, Optional] LPCMWSTR mszGroups,
            LPMWSTR mszReaders,
            ref int pcchReaders
            );

        /// <inheritdoc cref="SCardListReadersW(SCARDCONTEXT, LPCMWSTR, LPMWSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardListReadersW(
            [In] SCARDCONTEXT hContext,
            [In, Optional] string mszGroups,
            LPMWSTR mszReaders,
            ref int pcchReaders
            );

        /// <inheritdoc cref="SCardListReadersW(SCARDCONTEXT, LPCMWSTR, LPMWSTR, ref int)"/>
        public static unsafe int SCardListReadersW(
            SCARDCONTEXT hContext,
            LPCMWSTR mszGroups,
            out LPMWSTR mszReaders,
            out int pcchReaders
            )
        {
            pcchReaders = SCARD_AUTOALLOCATE;
            fixed (void* pmszReaders = &mszReaders)
                return SCardListReadersW(
                    hContext,
                    mszGroups,
                    Pointer.Create<LPMWSTR>(pmszReaders),
                    ref pcchReaders
                    );
        }

        /// <inheritdoc cref="SCardListReadersW(SCARDCONTEXT, LPCMWSTR, LPMWSTR, ref int)"/>
        public static unsafe int SCardListReadersW(
            SCARDCONTEXT hContext,
            string mszGroups,
            out LPMWSTR mszReaders,
            out int pcchReaders
            )
        {
            pcchReaders = SCARD_AUTOALLOCATE;
            fixed (void* pmszReaders = &mszReaders)
                return SCardListReadersW(
                    hContext,
                    mszGroups,
                    Pointer.Create<LPMWSTR>(pmszReaders),
                    ref pcchReaders
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 183
        #region SCardListReaders function
        /// <summary>
        /// <para>The <see cref="SCardListReaders"/> function provides the list of <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">readers</a> within a set of named <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader groups</a>, eliminating duplicates.</para>
        /// <para>The caller supplies a list of reader groups, and receives the list of readers within the named groups. Unrecognized group names are ignored. This function only returns readers within the named groups that are currently attached to the system and available for use.</para>
        /// </summary>
        /// <param name="hContext">
        /// <para>Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a> for the query. The resource manager context can be set by a previous call to <see cref="SCardEstablishContext"/>.</para>
        /// <para>If this parameter is set to <see langword="default"/>, the search for readers is not limited to any context.</para>
        /// </param>
        /// <param name="mszGroups">Names of the reader groups defined to the system, as a multi-string. Use a <see langword="default"/> value to list all readers in the system (that is, the <c>SCard$AllReaders</c> group).</param>
        /// <param name="mszReaders">Multi-string that lists the card readers within the supplied reader groups. If this value is <see langword="default"/>, <see cref="SCardListReaders"/> ignores the buffer length supplied in <paramref name="pcchReaders"/>, writes the length of the buffer that would have been returned if this parameter had not been <see langword="default"/> to <paramref name="pcchReaders"/>, and returns a success code.</param>
        /// <param name="pcchReaders">Length of the <paramref name="mszReaders"/> buffer in characters. This parameter receives the actual length of the multi-string structure, including all trailing null characters. If the buffer length is specified as <see cref="SCARD_AUTOALLOCATE"/>, then <paramref name="mszReaders"/> is converted to a pointer to a byte pointer, and receives the address of a block of memory containing the multi-string structure. This block of memory must be deallocated with <see cref="SCardFreeMemory"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// The <see cref="SCardListReaders"/> function is a database query function. For more information on other database query functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-query-functions">Smart Card Database Query Functions</a>.
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winscard/nf-winscard-scardlistreadersw">SCardListReadersW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardFreeMemory"/>
        /// <seealso cref="SCardGetProviderId"/>
        /// <seealso cref="SCardListCards"/>
        /// <seealso cref="SCardListInterfaces"/>
        /// <seealso cref="SCardListReaderGroups"/>
#if !NETSTANDARD1_3

        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif
        int SCardListReaders(
            [In] SCARDCONTEXT hContext,
            [In, Optional] LPCMTSTR mszGroups,
            LPMTSTR mszReaders,
            ref int pcchReaders
            )
#if !NETSTANDARD1_3
            ;
#else
        => Marshal.SystemDefaultCharSize switch
        {
            1 => SCardListReadersA(hContext, Pointer.Create<LPCMSTR>(mszGroups.Pointer), Pointer.Create<LPMSTR>(mszReaders.Pointer), ref pcchReaders),
            2 => SCardListReadersW(hContext, Pointer.Create<LPCMWSTR>(mszGroups.Pointer), Pointer.Create<LPMWSTR>(mszReaders.Pointer), ref pcchReaders),
            _ => throw new PlatformNotSupportedException()
        };
#endif

        /// <inheritdoc cref="SCardListReaders(SCARDCONTEXT, LPCMTSTR, LPMTSTR, ref int)"/>
#if !NETSTANDARD1_3

        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif
        int SCardListReaders(
            [In] SCARDCONTEXT hContext,
            [In, Optional] string mszGroups,
            LPMTSTR mszReaders,
            ref int pcchReaders
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardListReadersA(hContext, mszGroups, Pointer.Create<LPMSTR>(mszReaders.Pointer), ref pcchReaders),
                2 => SCardListReadersW(hContext, mszGroups, Pointer.Create<LPMWSTR>(mszReaders.Pointer), ref pcchReaders),
                _ => throw new PlatformNotSupportedException()
            };
#endif

        /// <inheritdoc cref="SCardListReaders(SCARDCONTEXT, LPCMTSTR, LPMTSTR, ref int)"/>
        public static unsafe int SCardListReaders(
            SCARDCONTEXT hContext,
            LPCMTSTR mszGroups,
            out LPMTSTR mszReaders,
            out int pcchReaders
            )
        {
            pcchReaders = SCARD_AUTOALLOCATE;
            fixed (void* pmszReaders = &mszReaders)
                return SCardListReaders(
                    hContext,
                    mszGroups,
                    Pointer.Create<LPMTSTR>(pmszReaders),
                    ref pcchReaders
                    );
        }

        /// <inheritdoc cref="SCardListReaders(SCARDCONTEXT, LPCMTSTR, LPMTSTR, ref int)"/>
        public static unsafe int SCardListReaders(
            SCARDCONTEXT hContext,
            string mszGroups,
            out LPMTSTR mszReaders,
            out int pcchReaders
            )
        {
            pcchReaders = SCARD_AUTOALLOCATE;
            fixed (void* pmszReaders = &mszReaders)
                return SCardListReaders(
                    hContext,
                    mszGroups,
                    Pointer.Create<LPMTSTR>(pmszReaders),
                    ref pcchReaders
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 189
        #region SCardListCardsA function
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe int SCardListCardsA(
            [In] SCARDCONTEXT hContext,
            [In, Optional] byte* pbAtr,
            [In, Optional] Guid* rgquidInterfaces,
            [In] int cguidInterfaceCount,
            LPMSTR mszCards,
            ref int pcchCards
            );

        /// <inheritdocc cref="SCardListCards(SCARDCONTEXT, ReadOnlySpan{byte}, ReadOnlySpan{Guid}, LPMTSTR, ref int)"/>
        public static unsafe int SCardListCardsA(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            LPMSTR mszCards,
            ref int pcchCards
            )
        {
            if (pbAtr.Length > 0 && pbAtr.Length < SCARD_ATR_LENGTH)
            {
                Span<byte> pbExtAtr = stackalloc byte[SCARD_ATR_LENGTH];
                pbAtr.CopyTo(pbExtAtr);
                pbExtAtr.Slice(pbAtr.Length).Fill(0);
                return SCardListCardsA(hContext, pbExtAtr, rgquidInterfaces,
                    mszCards, ref pcchCards);
            }

            fixed (byte* pbAtrPtr = pbAtr)
            fixed (Guid* prgquidInterfaces = rgquidInterfaces)
                return SCardListCardsA(
                    hContext,
                    pbAtrPtr,
                    prgquidInterfaces,
                    rgquidInterfaces.Length,
                    mszCards,
                    ref pcchCards
                    );
        }

        /// <inheritdocc cref="SCardListCardsA(SCARDCONTEXT, ReadOnlySpan{byte}, ReadOnlySpan{Guid}, LPMSTR, ref int)"/>
        public static unsafe int SCardListCardsA(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            out LPMSTR mszCards,
            out int pcchCards
            )
        {
            pcchCards = SCARD_AUTOALLOCATE;
            fixed (void* pmszCards = &mszCards)
                return SCardListCardsA(
                    hContext,
                    pbAtr,
                    rgquidInterfaces,
                    Pointer.Create<LPMSTR>(pmszCards),
                    ref pcchCards
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 200
        #region SCardListCardsW function
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe int SCardListCardsW(
            [In] SCARDCONTEXT hContext,
            [In, Optional] byte* pbAtr,
            [In, Optional] Guid* rgquidInterfaces,
            [In] int cguidInterfaceCount,
            LPMWSTR mszCards,
            ref int pcchCards
            );

        /// <inheritdocc cref="SCardListCards(SCARDCONTEXT, ReadOnlySpan{byte}, ReadOnlySpan{Guid}, LPMTSTR, ref int)"/>
        public static unsafe int SCardListCardsW(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            LPMWSTR mszCards,
            ref int pcchCards
            )
        {
            if (pbAtr.Length > 0 && pbAtr.Length < SCARD_ATR_LENGTH)
            {
                Span<byte> pbExtAtr = stackalloc byte[SCARD_ATR_LENGTH];
                pbAtr.CopyTo(pbExtAtr);
                pbExtAtr.Slice(pbAtr.Length).Fill(0);
                return SCardListCardsW(hContext, pbExtAtr, rgquidInterfaces,
                    mszCards, ref pcchCards);
            }

            fixed (byte* pbAtrPtr = pbAtr)
            fixed (Guid* prgquidInterfaces = rgquidInterfaces)
                return SCardListCardsW(
                    hContext,
                    pbAtrPtr,
                    prgquidInterfaces,
                    rgquidInterfaces.Length,
                    mszCards,
                    ref pcchCards
                    );
        }

        /// <inheritdocc cref="SCardListCardsW(SCARDCONTEXT, ReadOnlySpan{byte}, ReadOnlySpan{Guid}, LPMWSTR, ref int)"/>
        public static unsafe int SCardListCardsW(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            out LPMWSTR mszCards,
            out int pcchCards
            )
        {
            pcchCards = SCARD_AUTOALLOCATE;
            fixed (void* pmszCards = &mszCards)
                return SCardListCardsW(
                    hContext,
                    pbAtr,
                    rgquidInterfaces,
                    Pointer.Create<LPMWSTR>(pmszCards),
                    ref pcchCards
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 211
        #region SCardListCards function
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static extern unsafe
#else
        private static unsafe
#endif
        int SCardListCards(
            [In] SCARDCONTEXT hContext,
            [In, Optional] byte* pbAtr,
            [In, Optional] Guid* rgquidInterfaces,
            [In] int cguidInterfaceCount,
            LPMTSTR mszCards,
            ref int pcchCards
            )
#if !NETSTANDARD1_3
        ;
#else
        => Marshal.SystemDefaultCharSize switch
        {
            1 => SCardListCardsA(hContext, pbAtr, rgquidInterfaces, cguidInterfaceCount, Pointer.Create<LPMSTR>(mszCards.Pointer), ref pcchCards),
            2 => SCardListCardsW(hContext, pbAtr, rgquidInterfaces, cguidInterfaceCount, Pointer.Create<LPMWSTR>(mszCards.Pointer), ref pcchCards),
            _ => throw new PlatformNotSupportedException()
        };
#endif

        /// <summary>
        /// The <see cref="SCardListCards"/> function searches the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card database</a> and provides a list of named cards previously introduced to the system by the user.
        /// <para>The caller specifies an <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">ATR string</a>, a set of interface identifiers (<see cref="Guid"/>s), or both. If both an ATR string and an identifier array are supplied, the cards returned will match the ATR string supplied and support the interfaces specified.</para>
        /// </summary>
        /// <param name="hContext">
        /// <para>Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a> for the query. The resource manager context can be set by a previous call to <see cref="SCardEstablishContext"/>.</para>
        /// <para>If this parameter is set to <see langword="default"/>, the search for cards is not limited to any context.</para>
        /// </param>
        /// <param name="pbAtr">An ATR string to compare to known cards, or <see langword="default"/> (an empty span) if no ATR matching is to be performed.</param>
        /// <param name="rgquidInterfaces">A span of identifiers (<see cref="Guid"/>s), or <see langword="default"/> (an empty span) if no interface matching is to be performed. When identifiers are supplied, a card name will be returned only if all the specified identifiers are supported by the card.</param>
        /// <param name="mszCards">Multi-string that lists the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart cards</a> found. If this value is <see langword="default"/>, <see cref="SCardListCards"/> ignores the buffer length supplied in <paramref name="pcchCards"/>, returning the length of the buffer that would have been returned if this parameter had not been <see langword="default"/> to <paramref name="pcchCards"/> and a success code.</param>
        /// <param name="pcchCards">Length of the <paramref name="mszCards"/> buffer in characters. Receives the actual length of the multi-string structure, including all trailing null characters. If the buffer length is specified as <see cref="SCARD_AUTOALLOCATE"/>, then <paramref name="mszCards"/> is converted to a pointer to a byte pointer, and receives the address of a block of memory containing the multi-string structure. This block of memory must be deallocated with <see cref="SCardFreeMemory"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>This function is not redirected, but calling the function when inside a Remote Desktop session will not result in an error. It only means that the result will be from the remote computer instead of the local computer.</para>
        /// <para>To return all smart cards introduced to the subsystem, set <paramref name="pbAtr"/> and <paramref name="rgquidInterfaces"/> to empty spans or <see langword="default"/>.</para>
        /// <para>The <see cref="SCardListCards"/> function is a database query function. For more information on other database query functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-query-functions">Smart Card Database Query Functions</a>.</para>
        /// <para>Calling this function should be done outside of a transaction. If an application begins a transaction with the <see cref="SCardBeginTransaction"/> function and then calls this function, it resets the <em>hCard</em> parameter (of type <see cref="SCARDHANDLE"/>) of the <see cref="SCardBeginTransaction"/> function.</para>
        /// <para><strong>Windows Server 2008 R2 and Windows 7:</strong> Calling this function within a transaction could result in your computer becoming unresponsive.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> Not applicable.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winscard/nf-winscard-scardlistcardsw">SCardListCardsW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardFreeMemory"/>
        /// <seealso cref="SCardGetProviderId"/>
        /// <seealso cref="SCardListInterfaces"/>
        /// <seealso cref="SCardListReaderGroups"/>
        /// <seealso cref="SCardListReaders"/>
        public static unsafe int SCardListCards(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            LPMTSTR mszCards,
            ref int pcchCards
            )
        {
            if (pbAtr.Length > 0 && pbAtr.Length < SCARD_ATR_LENGTH)
            {
                Span<byte> pbExtAtr = stackalloc byte[SCARD_ATR_LENGTH];
                pbAtr.CopyTo(pbExtAtr);
                pbExtAtr.Slice(pbAtr.Length).Fill(0);
                return SCardListCards(hContext, pbExtAtr, rgquidInterfaces,
                    mszCards, ref pcchCards);
            }

            fixed (byte* pbAtrPtr = pbAtr)
            fixed (Guid* prgquidInterfaces = rgquidInterfaces)
                return SCardListCards(
                    hContext,
                    pbAtrPtr,
                    prgquidInterfaces,
                    rgquidInterfaces.Length,
                    mszCards,
                    ref pcchCards
                    );
        }

        /// <inheritdocc cref="SCardListCards(SCARDCONTEXT, ReadOnlySpan{byte}, ReadOnlySpan{Guid}, LPMTSTR, ref int)"/>
        public static unsafe int SCardListCards(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            out LPMTSTR mszCards,
            out int pcchCards
            )
        {
            pcchCards = SCARD_AUTOALLOCATE;
            fixed (void* pmszCards = &mszCards)
                return SCardListCards(
                    hContext,
                    pbAtr,
                    rgquidInterfaces,
                    Pointer.Create<LPMTSTR>(pmszCards),
                    ref pcchCards
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 216
        #region SCardListCardTypes function
        /// <inheritdoc cref="SCardListCards(SCARDCONTEXT, ReadOnlySpan{byte}, ReadOnlySpan{Guid}, LPMTSTR, ref int)" />
        public static int SCardListCardTypes(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            LPMTSTR mszCards,
            ref int pcchCards
            )
        {
#if NETSTANDARD1_3
            switch (Marshal.SystemDefaultCharSize)
            {
                case 1:
                    return SCardListCardsA(
                        hContext,
                        pbAtr,
                        rgquidInterfaces,
                        Pointer.Create<LPMSTR>(mszCards.Pointer),
                        ref pcchCards
                        );
                case 2:
                    return SCardListCardsW(
                        hContext,
                        pbAtr,
                        rgquidInterfaces,
                        Pointer.Create<LPMWSTR>(mszCards.Pointer),
                        ref pcchCards
                        );
                default:
                    throw new PlatformNotSupportedException();
            }
#else // !NETSTANDARD1_3
            return SCardListCards(
                hContext,
                pbAtr,
                rgquidInterfaces,
                mszCards,
                ref pcchCards
                );
#endif
        }

        /// <inheritdoc cref="SCardListCards(SCARDCONTEXT, ReadOnlySpan{byte}, ReadOnlySpan{Guid}, out LPMTSTR, out int)" />
        public static int SCardListCardTypes(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            out LPMTSTR mszCards,
            out int pcchCards
            )
        {
#if NETSTANDARD1_3
            int error;
            switch (Marshal.SystemDefaultCharSize)
            {
                case 1:
                    error = SCardListCardsA(
                        hContext,
                        pbAtr,
                        rgquidInterfaces,
                        out var lpstrCards,
                        out pcchCards
                        );
                    mszCards = Pointer.Create<LPMTSTR>(lpstrCards.Pointer);
                    return error;
                case 2:
                    error = SCardListCardsW(
                        hContext,
                        pbAtr,
                        rgquidInterfaces,
                        out var lpwstrCards,
                        out pcchCards
                        );
                    mszCards = Pointer.Create<LPMTSTR>(lpwstrCards.Pointer);
                    return error;
                default:
                    throw new PlatformNotSupportedException();
            }
#else // !NETSTANDARD1_3
            return SCardListCards(
                hContext,
                pbAtr,
                rgquidInterfaces,
                out mszCards,
                out pcchCards
                );
#endif
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 232
        #region SCardListInterfacesA function
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        private static unsafe extern int SCardListInterfacesA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szCard,
            Guid* pguidInterfaces,
            ref int pcguidInterfaces
            );

        /// <inheritdoc cref="SCardListInterfaces(SCARDCONTEXT, LPCTSTR, Span{Guid}, out int)"/>
        public static unsafe int SCardListInterfacesA(
            SCARDCONTEXT hContext,
            LPCSTR szCard,
            Span<Guid> pguidInterfaces,
            out int pcguidInterfaces
            )
        {
            pcguidInterfaces = pguidInterfaces.Length;
            fixed (Guid* ppguidInterfaces = pguidInterfaces)
                return SCardListInterfacesA(
                    hContext,
                    szCard,
                    ppguidInterfaces,
                    ref pcguidInterfaces
                    );
        }

        /// <inheritdoc cref="SCardListInterfacesA(SCARDCONTEXT, LPCSTR, Span{Guid}, out int)"/>
        public static unsafe int SCardListInterfacesA(
            SCARDCONTEXT hContext,
            LPCSTR szCard,
            out Span<Guid> pguidInterfaces
            )
        {
            int pcguidInterfaces = SCARD_AUTOALLOCATE;
            Guid* pguidAllocated;
            int error = SCardListInterfacesA(
                hContext,
                szCard,
                (Guid*)&pguidAllocated,
                ref pcguidInterfaces
                );
            pguidInterfaces = new Span<Guid>(pguidAllocated, pcguidInterfaces);
            return error;
        }

        /// <inheritdoc cref="SCardListInterfacesA(SCARDCONTEXT, LPCSTR, Span{Guid}, out int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        private static unsafe extern int SCardListInterfacesA(
            [In] SCARDCONTEXT hContext,
            [In] string szCard,
            Guid* pguidInterfaces,
            ref int pcguidInterfaces
            );

        /// <inheritdoc cref="SCardListInterfacesA(SCARDCONTEXT, LPCSTR, Span{Guid}, out int)"/>
        public static unsafe int SCardListInterfacesA(
            SCARDCONTEXT hContext,
            string szCard,
            Span<Guid> pguidInterfaces,
            out int pcguidInterfaces
            )
        {
            pcguidInterfaces = pguidInterfaces.Length;
            fixed (Guid* ppguidInterfaces = pguidInterfaces)
                return SCardListInterfacesA(
                    hContext,
                    szCard,
                    ppguidInterfaces,
                    ref pcguidInterfaces
                    );
        }

        /// <inheritdoc cref="SCardListInterfacesA(SCARDCONTEXT, LPCSTR, Span{Guid}, out int)"/>
        public static unsafe int SCardListInterfacesA(
            SCARDCONTEXT hContext,
            string szCard,
            out Span<Guid> pguidInterfaces
            )
        {
            int pcguidInterfaces = SCARD_AUTOALLOCATE;
            Guid* pguidAllocated;
            int error = SCardListInterfacesA(
                hContext,
                szCard,
                (Guid*)&pguidAllocated,
                ref pcguidInterfaces
                );
            pguidInterfaces = new Span<Guid>(pguidAllocated, pcguidInterfaces);
            return error;
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 238
        #region SCardListInterfacesW function
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        private static unsafe extern int SCardListInterfacesW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szCard,
            Guid* pguidInterfaces,
            ref int pcguidInterfaces
            );

        /// <inheritdoc cref="SCardListInterfaces(SCARDCONTEXT, LPCTSTR, Span{Guid}, out int)"/>
        public static unsafe int SCardListInterfacesW(
            SCARDCONTEXT hContext,
            LPCWSTR szCard,
            Span<Guid> pguidInterfaces,
            out int pcguidInterfaces
            )
        {
            pcguidInterfaces = pguidInterfaces.Length;
            fixed (Guid* ppguidInterfaces = pguidInterfaces)
                return SCardListInterfacesW(
                    hContext,
                    szCard,
                    ppguidInterfaces,
                    ref pcguidInterfaces
                    );
        }

        /// <inheritdoc cref="SCardListInterfacesW(SCARDCONTEXT, LPCWSTR, Span{Guid}, out int)"/>
        public static unsafe int SCardListInterfacesW(
            SCARDCONTEXT hContext,
            LPCWSTR szCard,
            out Span<Guid> pguidInterfaces
            )
        {
            int pcguidInterfaces = SCARD_AUTOALLOCATE;
            Guid* pguidAllocated;
            int error = SCardListInterfacesW(
                hContext,
                szCard,
                (Guid*)&pguidAllocated,
                ref pcguidInterfaces
                );
            pguidInterfaces = new Span<Guid>(pguidAllocated, pcguidInterfaces);
            return error;
        }

        /// <inheritdoc cref="SCardListInterfacesW(SCARDCONTEXT, LPCWSTR, Span{Guid}, out int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        private static unsafe extern int SCardListInterfacesW(
            [In] SCARDCONTEXT hContext,
            [In] string szCard,
            Guid* pguidInterfaces,
            ref int pcguidInterfaces
            );

        /// <inheritdoc cref="SCardListInterfacesW(SCARDCONTEXT, LPCWSTR, Span{Guid}, out int)"/>
        public static unsafe int SCardListInterfacesW(
            SCARDCONTEXT hContext,
            string szCard,
            Span<Guid> pguidInterfaces,
            out int pcguidInterfaces
            )
        {
            pcguidInterfaces = pguidInterfaces.Length;
            fixed (Guid* ppguidInterfaces = pguidInterfaces)
                return SCardListInterfacesW(
                    hContext,
                    szCard,
                    ppguidInterfaces,
                    ref pcguidInterfaces
                    );
        }

        /// <inheritdoc cref="SCardListInterfacesW(SCARDCONTEXT, LPCWSTR, Span{Guid}, out int)"/>
        public static unsafe int SCardListInterfacesW(
            SCARDCONTEXT hContext,
            string szCard,
            out Span<Guid> pguidInterfaces
            )
        {
            int pcguidInterfaces = SCARD_AUTOALLOCATE;
            Guid* pguidAllocated;
            int error = SCardListInterfacesW(
                hContext,
                szCard,
                (Guid*)&pguidAllocated,
                ref pcguidInterfaces
                );
            pguidInterfaces = new Span<Guid>(pguidAllocated, pcguidInterfaces);
            return error;
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 244
        #region SCardListInterfaces function
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static unsafe extern
#else
        private static unsafe
#endif
        int SCardListInterfaces(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szCard,
            Guid* pguidInterfaces,
            ref int pcguidInterfaces
            )
#if !NETSTANDARD1_3
        ;
#else
        => Marshal.SystemDefaultCharSize switch
        {
            1 => SCardListInterfacesA(hContext, Pointer.Create<LPCSTR>(szCard.Pointer), pguidInterfaces, ref pcguidInterfaces),
            2 => SCardListInterfacesW(hContext, Pointer.Create<LPCWSTR>(szCard.Pointer), pguidInterfaces, ref pcguidInterfaces),
            _ => throw new PlatformNotSupportedException()
        };
#endif

        /// <summary>
        /// The <see cref="SCardListInterfaces"/> function provides a list of interfaces supplied by a given card.
        /// <para>The caller supplies the name of a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> previously introduced to the subsystem, and receives the list of interfaces supported by the card.</para>
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a> for the query. The resource manager context can be set by a previous call to <see cref="SCardEstablishContext"/>. This parameter cannot be <see langword="default"/>.</param>
        /// <param name="szCard">Name of the smart card already introduced to the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card subsystem</a>.</param>
        /// <param name="pguidInterfaces">Span of interface identifiers (<see cref="Guid"/>s) that indicate the interfaces supported by the smart card. If this value is <see langword="default"/> (an empty span), <see cref="SCardListInterfaces"/> ignores the array length supplied in <paramref name="pcguidInterfaces"/>, returning the size of the array that would have been returned if this parameter had not been an empty span to <paramref name="pcguidInterfaces"/> and a success code.</param>
        /// <param name="pcguidInterfaces">Size of the <paramref name="pguidInterfaces"/> span, receives the actual length of the returned span. If the span length is specified as <see cref="SCARD_AUTOALLOCATE"/>, then <paramref name="pguidInterfaces"/> is converted to a pointer to a <see cref="Guid"/> pointer, and receives the address of a block of memory containing an array. This block of memory must be deallocated with <see cref="SCardFreeMemory"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>This function is not redirected, but calling the function when attempting a Remote Desktop session will not result in an error. It only means that the result will be from the remote computer instead of the local computer.</para>
        /// <para>The <see cref="SCardListInterfaces"/> function is a database query function. For more information on other database query functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-query-functions">Smart Card Database Query Functions</a>.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winscard/nf-winscard-scardlistinterfacesw">SCardListInterfacesW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardFreeMemory"/>
        /// <seealso cref="SCardGetProviderId"/>
        /// <seealso cref="SCardListCards"/>
        /// <seealso cref="SCardListReaderGroups"/>
        /// <seealso cref="SCardListReaders"/>
        public static unsafe int SCardListInterfaces(
            SCARDCONTEXT hContext,
            LPCTSTR szCard,
            Span<Guid> pguidInterfaces,
            out int pcguidInterfaces
            )
        {
            pcguidInterfaces = pguidInterfaces.Length;
            fixed (Guid* ppguidInterfaces = pguidInterfaces)
                return SCardListInterfaces(
                    hContext,
                    szCard,
                    ppguidInterfaces,
                    ref pcguidInterfaces
                    );
        }

        /// <inheritdoc cref="SCardListInterfaces(SCARDCONTEXT, LPCTSTR, Span{Guid}, out int)"/>
        public static unsafe int SCardListInterfaces(
            SCARDCONTEXT hContext,
            LPCTSTR szCard,
            out Span<Guid> pguidInterfaces
            )
        {
            int pcguidInterfaces = SCARD_AUTOALLOCATE;
            Guid* pguidAllocated;
            int error = SCardListInterfaces(
                hContext,
                szCard,
                (Guid*)&pguidAllocated,
                ref pcguidInterfaces
                );
            pguidInterfaces = new Span<Guid>(pguidAllocated, pcguidInterfaces);
            return error;
        }

        /// <inheritdoc cref="SCardListInterfaces(SCARDCONTEXT, LPCTSTR, Span{Guid}, out int)"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static unsafe extern
#else
        private static unsafe
#endif // !NETSTANDARD1_3
        int SCardListInterfaces(
            [In] SCARDCONTEXT hContext,
            [In] string szCard,
            Guid* pguidInterfaces,
            ref int pcguidInterfaces
            )
#if !NETSTANDARD1_3
        ;
#else
        => Marshal.SystemDefaultCharSize switch
        {
            1 => SCardListInterfacesA(hContext, szCard, pguidInterfaces, ref pcguidInterfaces),
            2 => SCardListInterfacesW(hContext, szCard, pguidInterfaces, ref pcguidInterfaces),
            _ => throw new PlatformNotSupportedException()
        };
#endif

        /// <inheritdoc cref="SCardListInterfaces(SCARDCONTEXT, LPCTSTR, Span{Guid}, out int)"/>
        public static unsafe int SCardListInterfaces(
            SCARDCONTEXT hContext,
            string szCard,
            Span<Guid> pguidInterfaces,
            out int pcguidInterfaces
            )
        {
            pcguidInterfaces = pguidInterfaces.Length;
            fixed (Guid* ppguidInterfaces = pguidInterfaces)
                return SCardListInterfaces(
                    hContext,
                    szCard,
                    ppguidInterfaces,
                    ref pcguidInterfaces
                    );
        }

        /// <inheritdoc cref="SCardListInterfaces(SCARDCONTEXT, LPCTSTR, Span{Guid}, out int)"/>
        public static unsafe int SCardListInterfaces(
            SCARDCONTEXT hContext,
            string szCard,
            out Span<Guid> pguidInterfaces
            )
        {
            int pcguidInterfaces = SCARD_AUTOALLOCATE;
            Guid* pguidAllocated;
            int error = SCardListInterfaces(
                hContext,
                szCard,
                (Guid*)&pguidAllocated,
                ref pcguidInterfaces
                );
            pguidInterfaces = new Span<Guid>(pguidAllocated, pcguidInterfaces);
            return error;
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 250
        #region SCardGetProviderIdA function
        /// <inheritdoc cref="SCardGetProviderId(SCARDCONTEXT, LPCTSTR, out Guid)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardGetProviderIdA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szCard,
            out Guid pguidProviderId
            );

        /// <inheritdoc cref="SCardGetProviderIdA(SCARDCONTEXT, LPCSTR, out Guid)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardGetProviderIdA(
            [In] SCARDCONTEXT hContext,
            [In] string szCard,
            out Guid pguidProviderId
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 255
        #region SCardGetProviderIdW function
        /// <inheritdoc cref="SCardGetProviderId(SCARDCONTEXT, LPCTSTR, out Guid)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardGetProviderIdW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szCard,
            out Guid pguidProviderId
            );

        /// <inheritdoc cref="SCardGetProviderIdW(SCARDCONTEXT, LPCWSTR, out Guid)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardGetProviderIdW(
            [In] SCARDCONTEXT hContext,
            [In] string szCard,
            out Guid pguidProviderId
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 260
        #region SCardGetProviderId function
        /// <summary>
        /// The <see cref="SCardGetProviderId"/> function returns the identifier (<see cref="Guid"/>) of the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/p-gly">primary service provider</a> for a given card.
        /// <para>The caller supplies the name of a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> (previously introduced to the system) and receives the registered identifier of the primary service provider <see cref="Guid"/>, if one exists.</para>
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a> for the query. The resource manager context can be set by a previous call to <see cref="SCardEstablishContext"/>. This parameter cannot be <see langword="default"/>.</param>
        /// <param name="szCard">Name of the card defined to the system.</param>
        /// <param name="pguidProviderId">Identifier (<see cref="Guid"/>) of the primary service provider. This provider may be activated using COM, and will supply access to other services in the card.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>This function is not redirected, but calling the function when attempting a Remote Desktop session will not result in an error. It only means that the result will be from the remote computer instead of the local computer.</para>
        /// <para>The <see cref="SCardGetProviderId"/> function is a database query function. For more information on other database query functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-query-functions">Smart Card Database Query Functions</a>.</para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winscard/nf-winscard-scardgetprovideridw">SCardGetProviderIdW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardListCards"/>
        /// <seealso cref="SCardListInterfaces"/>
        /// <seealso cref="SCardListReaderGroups"/>
        /// <seealso cref="SCardListReaders"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardGetProviderId(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szCard,
            out Guid pguidProviderId
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardGetProviderIdA(hContext, Pointer.Create<LPCSTR>(szCard.Pointer), out pguidProviderId),
                2 => SCardGetProviderIdW(hContext, Pointer.Create<LPCWSTR>(szCard.Pointer), out pguidProviderId),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3

        /// <inheritdoc cref="SCardGetProviderId(SCARDCONTEXT, LPCTSTR, out Guid)"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardGetProviderId(
            [In] SCARDCONTEXT hContext,
            [In] string szCard,
            out Guid pguidProviderId
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardGetProviderIdA(hContext, szCard, out pguidProviderId),
                2 => SCardGetProviderIdW(hContext, szCard, out pguidProviderId),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 270
        #region SCardGetCardTypeProviderNameA function
        /// <inheritdoc cref="SCardGetCardTypeProviderName"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardGetCardTypeProviderNameA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szCardName,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROVIDER_TYPE dwProviderId,
            LPSTR szProvider,
            ref int pcchProvider
            );

        /// <inheritdoc cref="SCardGetCardTypeProviderNameA"/>
        public static unsafe int SCardGetCardTypeProviderNameA(
            SCARDCONTEXT hContext,
            LPCSTR szCardName,
            SCARD_PROVIDER_TYPE dwProviderId,
            out LPSTR szProvider,
            out int pcchProvider
            )
        {
            pcchProvider = SCARD_AUTOALLOCATE;
            fixed (void* pszProvider = &szProvider)
                return SCardGetCardTypeProviderNameA(
                    hContext,
                    szCardName,
                    dwProviderId,
                    Pointer.Create<LPSTR>(pszProvider),
                    ref pcchProvider
                    );
        }

        /// <inheritdoc cref="SCardGetCardTypeProviderNameA"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, EntryPoint = nameof(SCardGetCardTypeProviderNameA))]
        private static extern int SCardGetCardTypeProviderNameAImpl(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROVIDER_TYPE dwProviderId,
            [Out] StringBuilder szProvider,
            ref int pcchProvider
            );

        /// <inheritdoc cref="SCardGetCardTypeProviderNameA"/>
        public static int SCardGetCardTypeProviderNameA(
            SCARDCONTEXT hContext,
            string szCardName,
            SCARD_PROVIDER_TYPE dwProviderId,
            StringBuilder szProvider,
            out int pcchProvider
            )
        {
            pcchProvider = szProvider?.Capacity ?? 0;
            return SCardGetCardTypeProviderNameAImpl(
                hContext,
                szCardName,
                dwProviderId,
                szProvider,
                ref pcchProvider
                );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 280
        #region SCardGetCardTypeProviderNameW function
        /// <inheritdoc cref="SCardGetCardTypeProviderName"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardGetCardTypeProviderNameW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szCardName,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROVIDER_TYPE dwProviderId,
            LPWSTR szProvider,
            ref int pcchProvider
            );

        /// <inheritdoc cref="SCardGetCardTypeProviderNameW"/>
        public static unsafe int SCardGetCardTypeProviderNameW(
            SCARDCONTEXT hContext,
            LPCWSTR szCardName,
            SCARD_PROVIDER_TYPE dwProviderId,
            out LPWSTR szProvider,
            out int pcchProvider
            )
        {
            pcchProvider = SCARD_AUTOALLOCATE;
            fixed (void* pszProvider = &szProvider)
                return SCardGetCardTypeProviderNameW(
                    hContext,
                    szCardName,
                    dwProviderId,
                    Pointer.Create<LPWSTR>(pszProvider),
                    ref pcchProvider
                    );
        }

        /// <inheritdoc cref="SCardGetCardTypeProviderNameW"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = nameof(SCardGetCardTypeProviderNameW))]
        private static extern int SCardGetCardTypeProviderNameWImpl(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROVIDER_TYPE dwProviderId,
            [Out] StringBuilder szProvider,
            ref int pcchProvider
            );

        /// <inheritdoc cref="SCardGetCardTypeProviderNameW"/>
        public static int SCardGetCardTypeProviderNameW(
            SCARDCONTEXT hContext,
            string szCardName,
            SCARD_PROVIDER_TYPE dwProviderId,
            StringBuilder szProvider,
            out int pcchProvider
            )
        {
            pcchProvider = szProvider?.Capacity ?? 0;
            return SCardGetCardTypeProviderNameWImpl(
                hContext,
                szCardName,
                dwProviderId,
                szProvider,
                ref pcchProvider
                );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 290
        #region SCardGetCardTypeProviderName function
        /// <summary>
        /// The <see cref="SCardGetCardTypeProviderName"/> function returns the name of the module (dynamic link library) that contains the provider for a given card name and <a href="https://docs.microsoft.com/windows/desktop/SecGloss/p-gly">provider type</a>.
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context can be set by a previous call to <see cref="SCardEstablishContext"/>. This value can be <see langword="default"/> if the call to <see cref="SCardGetCardTypeProviderName"/> is not directed to a specific <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">context</a>.</param>
        /// <param name="szCardName">Name of the card type with which this provider name is associated.</param>
        /// <param name="dwProviderId">Identifier for the provider associated with this card type.</param>
        /// <param name="szProvider">String variable to receive the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/p-gly">provider name</a> upon successful completion of this function.</param>
        /// <param name="pcchProvider">
        /// <para>On input, <paramref name="pcchProvider"/> supplies the length of the <paramref name="szProvider"/> buffer in characters. If this value is <see cref="SCARD_AUTOALLOCATE"/>, then <paramref name="szProvider"/> is converted to a pointer to a byte pointer and receives the address of a block of memory containing the string. This block of memory must be deallocated by calling <see cref="SCardFreeMemory"/>.</para>
        /// <para>On output, this value represents the actual number of characters, including the null terminator, in the szProvider variable.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>This function is not redirected, but calling the function when inside a Remote Desktop session will not result in an error. It only means that the result will be from the remote computer instead of the local computer.</para>
        /// <para>Upon successful completion of this function, the value in szProvider can be used as the third parameter in a call to <see cref="CryptAcquireContext"/>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardgetcardtypeprovidernamew">SCardGetCardTypeProviderNameW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardFreeMemory"/>
        /// <seealso cref="SCardSetCardTypeProviderName(SCARDCONTEXT, string, SCARD_PROVIDER_TYPE, string)"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardGetCardTypeProviderName(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szCardName,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROVIDER_TYPE dwProviderId,
            LPTSTR szProvider,
            ref int pcchProvider
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardGetCardTypeProviderNameA(
                    hContext,
                    Pointer.Create<LPCSTR>(szCardName.Pointer),
                    dwProviderId,
                    Pointer.Create<LPSTR>(szProvider.Pointer),
                    ref pcchProvider),
                2 => SCardGetCardTypeProviderNameW(
                    hContext,
                    Pointer.Create<LPCWSTR>(szCardName.Pointer),
                    dwProviderId,
                    Pointer.Create<LPWSTR>(szProvider.Pointer),
                    ref pcchProvider),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3

        /// <inheritdoc cref="SCardGetCardTypeProviderName"/>
        public static unsafe int SCardGetCardTypeProviderName(
            SCARDCONTEXT hContext,
            LPCTSTR szCardName,
            SCARD_PROVIDER_TYPE dwProviderId,
            out LPTSTR szProvider,
            out int pcchProvider
            )
        {
            pcchProvider = SCARD_AUTOALLOCATE;
            fixed (void* pszProvider = &szProvider)
                return SCardGetCardTypeProviderName(
                    hContext,
                    szCardName,
                    dwProviderId,
                    Pointer.Create<LPTSTR>(pszProvider),
                    ref pcchProvider
                    );
        }

        /// <inheritdoc cref="SCardGetCardTypeProviderName"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, EntryPoint = nameof(SCardGetCardTypeProviderName))]
        private static extern
#else
        private static
#endif // !NETSTANDARD1_3
        int SCardGetCardTypeProviderNameImpl(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROVIDER_TYPE dwProviderId,
            [Out] StringBuilder szProvider,
            ref int pcchProvider
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardGetCardTypeProviderNameAImpl(
                    hContext,
                    szCardName,
                    dwProviderId,
                    szProvider,
                    ref pcchProvider),
                2 => SCardGetCardTypeProviderNameWImpl(
                    hContext,
                    szCardName,
                    dwProviderId,
                    szProvider,
                    ref pcchProvider),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3

        /// <inheritdoc cref="SCardGetCardTypeProviderName"/>
        public static int SCardGetCardTypeProviderName(
            SCARDCONTEXT hContext,
            string szCardName,
            SCARD_PROVIDER_TYPE dwProviderId,
            StringBuilder szProvider,
            out int pcchProvider
            )
        {
            pcchProvider = szProvider?.Capacity ?? 0;
            return SCardGetCardTypeProviderNameImpl(
                hContext,
                szCardName,
                dwProviderId,
                szProvider,
                ref pcchProvider
                );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 300
        //
        // Database Writer routines
        //
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 304
        #region SCardIntroduceReaderGroupA function
        /// <inheritdoc cref="SCardIntroduceReaderGroup" />
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardIntroduceReaderGroupA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szGroupName
            );

        /// <inheritdoc cref="SCardIntroduceReaderGroupA" />
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardIntroduceReaderGroupA(
            [In] SCARDCONTEXT hContext,
            [In] string szGroupName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 308
        #region SCardIntroduceReaderGroupW function
        /// <inheritdoc cref="SCardIntroduceReaderGroup" />
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardIntroduceReaderGroupW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szGroupName
            );

        /// <inheritdoc cref="SCardIntroduceReaderGroupW" />
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardIntroduceReaderGroupW(
            [In] SCARDCONTEXT hContext,
            [In] string szGroupName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 312
        #region SCardIntroduceReaderGroup function
        /// <summary>
        /// The <see cref="SCardIntroduceReaderGroup"/> function introduces a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader group</a> to the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> subsystem. However, the reader group is not created until the group is specified when adding a reader to the smart card database.
        /// </summary>
        /// <param name="hContext">Supplies the handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to the <see cref="SCardEstablishContext"/> function. If this parameter is <see langword="default"/>, the scope of the resource manager is <see cref="SCARD_SCOPE_TYPE.SCARD_SCOPE_SYSTEM"/>.</param>
        /// <param name="szGroupName">Supplies the display name to be assigned to the new reader group.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="SCardIntroduceReaderGroup"/> function is provided for PC/SC specification compatibility. Reader groups are not stored until a reader is added to the group.</para>
        /// <para>The <see cref="SCardIntroduceReaderGroup"/> function is a database management function. For a description of other database management functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-management-functions">Smart Card Database Management Functions</a>.</para>
        /// <para>To remove a reader group, use <see cref="SCardForgetReaderGroup"/>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardintroducereadergroupw">SCardIntroduceReaderGroup function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardAddReaderToGroup"/>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardForgetReaderGroup"/>
        /// <seealso cref="SCardIntroduceCardType(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        /// <seealso cref="SCardIntroduceReader"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardIntroduceReaderGroup(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szGroupName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardIntroduceReaderGroupA(
                    hContext,
                    Pointer.Create<LPCSTR>(szGroupName.Pointer)
                    ),
                2 => SCardIntroduceReaderGroupW(
                    hContext,
                    Pointer.Create<LPCWSTR>(szGroupName.Pointer)
                    ),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3

        /// <inheritdoc cref="SCardIntroduceReaderGroup" />
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardIntroduceReaderGroup(
            [In] SCARDCONTEXT hContext,
            [In] string szGroupName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardIntroduceReaderGroupA(hContext, szGroupName),
                2 => SCardIntroduceReaderGroupW(hContext, szGroupName),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 318
        #region SCardForgetReaderGroupA function
        /// <inheritdoc cref="SCardForgetReaderGroup"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardForgetReaderGroupA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szGroupName
            );

        /// <inheritdoc cref="SCardForgetReaderGroupA"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardForgetReaderGroupA(
            [In] SCARDCONTEXT hContext,
            [In] string szGroupName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 322
        #region SCardForgetReaderGroupW function
        /// <inheritdoc cref="SCardForgetReaderGroup"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardForgetReaderGroupW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szGroupName
            );

        /// <inheritdoc cref="SCardForgetReaderGroupW"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardForgetReaderGroupW(
            [In] SCARDCONTEXT hContext,
            [In] string szGroupName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 326
        #region SCardForgetReaderGroup function
        /// <summary>
        /// The <see cref="SCardForgetReaderGroup"/> function removes a previously introduced <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader group</a> from the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card subsystem</a>. Although this function automatically clears all readers from the group, it does not affect the existence of the individual <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">readers</a> in the database.
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to <see cref="SCardEstablishContext"/>. This parameter cannot be <see langword="default"/>.</param>
        /// <param name="szGroupName">Display name of the reader group to be removed. System-defined reader groups cannot be removed from the database.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// The <see cref="SCardForgetReaderGroup"/> function is a database management function. For more information on other database management functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-management-functions">Smart Card Database Management Functions</a>.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardforgetreadergroupw">SCardForgetReaderGroupW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardForgetCardType(SCARDCONTEXT, string)"/>
        /// <seealso cref="SCardForgetReader"/>
        /// <seealso cref="SCardIntroduceReaderGroup"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
            int SCardForgetReaderGroup(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szGroupName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardForgetReaderGroupA(hContext, Pointer.Create<LPCSTR>(szGroupName.Pointer)),
                2 => SCardForgetReaderGroupW(hContext, Pointer.Create<LPCWSTR>(szGroupName.Pointer)),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3

        /// <inheritdoc cref="SCardForgetReaderGroup"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
            int SCardForgetReaderGroup(
            [In] SCARDCONTEXT hContext,
            [In] string szGroupName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardForgetReaderGroupA(hContext, szGroupName),
                2 => SCardForgetReaderGroupW(hContext, szGroupName),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 332
        #region SCardIntroduceReaderA function
        /// <inheritdoc cref="SCardIntroduceReader"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardIntroduceReaderA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szReaderName,
            [In] LPCSTR szDeviceName
            );

        /// <inheritdoc cref="SCardIntroduceReaderA"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardIntroduceReaderA(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName,
            [In] string szDeviceName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 337
        #region SCardIntroduceReaderW function
        /// <inheritdoc cref="SCardIntroduceReader"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardIntroduceReaderW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szReaderName,
            [In] LPCWSTR szDeviceName
            );

        /// <inheritdoc cref="SCardIntroduceReaderW"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardIntroduceReaderW(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName,
            [In] string szDeviceName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 342
        #region SCardIntroduceReader function
        /// <summary>
        /// The <see cref="SCardIntroduceReader"/> function introduces a new name for an existing <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a>.
        /// <para><note>Smart card readers are automatically introduced to the system; a smart card reader vendor's setup program can also introduce a smart card reader to the system.</note></para>
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to <see cref="SCardEstablishContext"/>. This parameter cannot be <see langword="default"/>.</param>
        /// <param name="szReaderName">Display name to be assigned to the reader.</param>
        /// <param name="szDeviceName">System name of the smart card reader, for example, <c>"MyReader 01"</c>.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>All readers installed on the system are automatically introduced by their system name. Typically, <see cref="SCardIntroduceReader"/> is called only to change the name of an existing reader.</para>
        /// <para>The <see cref="SCardIntroduceReader"/> function is a database management function. For more information on other database management functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-management-functions">Smart Card Database Management Functions</a>.</para>
        /// <para>To remove a reader, use <see cref="SCardForgetReader"/>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardintroducereaderw">SCardIntroduceReaderW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardForgetReader"/>
        /// <seealso cref="SCardIntroduceCardType(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        /// <seealso cref="SCardIntroduceReaderGroup"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardIntroduceReader(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szReaderName,
            [In] LPCTSTR szDeviceName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardIntroduceReaderA(
                    hContext,
                    Pointer.Create<LPCSTR>(szReaderName.Pointer),
                    Pointer.Create<LPCSTR>(szDeviceName.Pointer)
                    ),
                2 => SCardIntroduceReaderW(
                    hContext,
                    Pointer.Create<LPCWSTR>(szReaderName.Pointer),
                    Pointer.Create<LPCWSTR>(szDeviceName.Pointer)
                    ),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3

        /// <inheritdoc cref="SCardIntroduceReader"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardIntroduceReader(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName,
            [In] string szDeviceName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardIntroduceReaderA(hContext, szReaderName, szDeviceName),
                2 => SCardIntroduceReaderW(hContext, szReaderName, szDeviceName),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 348
        #region SCardForgetReaderA function
        /// <inheritdoc cref="SCardForgetReader(SCARDCONTEXT, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardForgetReaderA(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName
            );
        /// <inheritdoc cref="SCardForgetReaderA(SCARDCONTEXT, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardForgetReaderA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szReaderName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 352
        #region SCardForgetReaderW function
        /// <inheritdoc cref="SCardForgetReader(SCARDCONTEXT, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardForgetReaderW(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName
            );
        /// <inheritdoc cref="SCardForgetReaderW(SCARDCONTEXT, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardForgetReaderW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szReaderName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 356
        #region SCardForgetReader function
        /// <summary>
        /// The <see cref="SCardForgetReader"/> function removes a previously introduced <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a> from control by the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card subsystem</a>. It is removed from the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card database</a>, including from any <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader group</a> that it may have been added to.
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to <see cref="SCardEstablishContext"/>. This parameter cannot be set to <see langword="default"/>.</param>
        /// <param name="szReaderName"></param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>If the specified reader is the last member of a reader group, the reader group is automatically removed as well.</para>
        /// <para>The <see cref="SCardForgetReader"/> function is a database management function. For more information on other database management functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-management-functions">Smart Card Database Management Functions</a>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardforgetreaderw">SCardForgetReaderW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardForgetCardType(SCARDCONTEXT, string)"/>
        /// <seealso cref="SCardForgetReaderGroup"/>
        /// <seealso cref="SCardIntroduceReader"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardForgetReader(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardForgetReaderA(hContext, szReaderName),
                2 => SCardForgetReaderW(hContext, szReaderName),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        /// <inheritdoc cref="SCardForgetReader(SCARDCONTEXT, string)"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardForgetReader(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szReaderName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardForgetReaderA(hContext, Pointer.Create<LPCSTR>(szReaderName.Pointer)),
                2 => SCardForgetReaderW(hContext, Pointer.Create<LPCWSTR>(szReaderName.Pointer)),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 362
        #region SCardAddReaderToGroupA function
        /// <inheritdoc cref="SCardAddReaderToGroup(SCARDCONTEXT, string, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardAddReaderToGroupA(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName,
            [In] string szGroupName
            );
        /// <inheritdoc cref="SCardAddReaderToGroupA(SCARDCONTEXT, string, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardAddReaderToGroupA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szReaderName,
            [In] LPCSTR szGroupName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 367
        #region SCardAddReaderToGroupW function
        /// <inheritdoc cref="SCardAddReaderToGroup(SCARDCONTEXT, string, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardAddReaderToGroupW(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName,
            [In] string szGroupName
            );
        /// <inheritdoc cref="SCardAddReaderToGroupW(SCARDCONTEXT, string, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardAddReaderToGroupW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szReaderName,
            [In] LPCWSTR szGroupName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 372
        #region SCardAddReaderToGroup function
        /// <summary>
        /// The <see cref="SCardAddReaderToGroup"/> function adds a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a> to a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader group</a>.
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to <see cref="SCardEstablishContext"/>. This parameter cannot be set to <see langword="default"/>.</param>
        /// <param name="szReaderName">Display name of the reader that you are adding.</param>
        /// <param name="szGroupName">
        /// Display name of the group to which you are adding the reader.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="SCARD_ALL_READERS"/><br/><c>SCard$AllReaders\0</c></term><description>Group used when no group name is provided when listing readers. Returns a list of all readers, regardless of what group or groups the readers are in.</description></item>
        /// <item><term><see cref="SCARD_DEFAULT_READERS"/><br/><c>SCard$DefaultReaders\0</c></term><description>Default group to which all readers are added when introduced into the system.</description></item>
        /// <item><term><see cref="SCARD_LOCAL_READERS"/><br/><c>SCard$LocalReaders\0</c></term><description>Unused legacy value. This is an internally managed group that cannot be modified by using any reader group APIs. It is intended to be used for enumeration only.</description></item>
        /// <item><term><see cref="SCARD_SYSTEM_READERS"/><br/><c>SCard$SystemReaders\0</c></term><description>Unused legacy value. This is an internally managed group that cannot be modified by using any reader group APIs. It is intended to be used for enumeration only.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see cref="SCardAddReaderToGroup"/> automatically creates the reader group specified if it does not already exist.</para>
        /// <para>The <see cref="SCardAddReaderToGroup"/> function is a database management function. For more information on other database management functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-management-functions">Smart Card Database Management Functions</a>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardaddreadertogroupw">SCardAddReaderToGroupW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardIntroduceReader"/>
        /// <seealso cref="SCardIntroduceReaderGroup"/>
        /// <seealso cref="SCardRemoveReaderFromGroup"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardAddReaderToGroup(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName,
            [In] string szGroupName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardAddReaderToGroupA(hContext, szReaderName, szGroupName),
                2 => SCardAddReaderToGroupW(hContext, szReaderName, szGroupName),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        /// <inheritdoc cref="SCardAddReaderToGroup(SCARDCONTEXT, string, string)"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardAddReaderToGroup(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szReaderName,
            [In] LPCTSTR szGroupName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardAddReaderToGroupA(
                    hContext,
                    Pointer.Create<LPCSTR>(szReaderName.Pointer),
                    Pointer.Create<LPCSTR>(szGroupName.Pointer)
                    ),
                2 => SCardAddReaderToGroupW(
                    hContext,
                    Pointer.Create<LPCWSTR>(szReaderName.Pointer),
                    Pointer.Create<LPCWSTR>(szGroupName.Pointer)
                    ),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 378
        #region SCardRemoveReaderFromGroupA function
        /// <inheritdoc cref="SCardRemoveReaderFromGroup(SCARDCONTEXT, string, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardRemoveReaderFromGroupA(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName,
            [In] string szGroupName
            );
        /// <inheritdoc cref="SCardRemoveReaderFromGroupA(SCARDCONTEXT, string, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardRemoveReaderFromGroupA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szReaderName,
            [In] LPCSTR szGroupName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 383
        #region SCardRemoveReaderFromGroupW function
        /// <inheritdoc cref="SCardRemoveReaderFromGroup(SCARDCONTEXT, string, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardRemoveReaderFromGroupW(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName,
            [In] string szGroupName
            );
        /// <inheritdoc cref="SCardRemoveReaderFromGroupW(SCARDCONTEXT, string, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardRemoveReaderFromGroupW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szReaderName,
            [In] LPCWSTR szGroupName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 388
        #region SCardRemoveReaderFromGroup function
        /// <summary>
        /// The <see cref="SCardRemoveReaderFromGroup"/> function removes a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a> from an existing <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader group</a>. This function has no effect on the reader.
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to <see cref="SCardEstablishContext"/>. This parameter cannot be set to <see langword="default"/>.</param>
        /// <param name="szReaderName">Display name of the reader to be removed.</param>
        /// <param name="szGroupName">
        /// Display name of the group from which the reader should be removed.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="SCARD_ALL_READERS"/><br/><c>SCard$AllReaders\0</c></term><description>Group used when no group name is provided when listing readers. Returns a list of all readers, regardless of what group or groups the readers are in.</description></item>
        /// <item><term><see cref="SCARD_DEFAULT_READERS"/><br/><c>SCard$DefaultReaders\0</c></term><description>Default group to which all readers are added when introduced into the system.</description></item>
        /// <item><term><see cref="SCARD_LOCAL_READERS"/><br/><c>SCard$LocalReaders\0</c></term><description>Unused legacy value. This is an internally managed group that cannot be modified by using any reader group APIs. It is intended to be used for enumeration only.</description></item>
        /// <item><term><see cref="SCARD_SYSTEM_READERS"/><br/><c>SCard$SystemReaders\0</c></term><description>Unused legacy value. This is an internally managed group that cannot be modified by using any reader group APIs. It is intended to be used for enumeration only.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>When the last reader is removed from a group, the group is automatically forgotten.</para>
        /// <para>The <see cref="SCardRemoveReaderFromGroup"/> function is a database management function. For information about other database management functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-management-functions">Smart Card Database Management Functions</a>.</para>
        /// <para>To add a reader to a reader group, use <see cref="SCardAddReaderToGroup"/>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardremovereaderfromgroupw">SCardRemoveReaderFromGroupW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardAddReaderToGroup"/>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardForgetCardType(SCARDCONTEXT, string)"/>
        /// <seealso cref="SCardForgetReader"/>
        /// <seealso cref="SCardForgetReaderGroup"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardRemoveReaderFromGroup(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName,
            [In] string szGroupName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardRemoveReaderFromGroupA(
                    hContext, szReaderName, szGroupName),
                2 => SCardRemoveReaderFromGroupW(
                    hContext, szReaderName, szGroupName),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        /// <inheritdoc cref="SCardRemoveReaderFromGroup(SCARDCONTEXT, string, string)"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardRemoveReaderFromGroup(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szReaderName,
            [In] LPCTSTR szGroupName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardRemoveReaderFromGroupA(
                    hContext,
                    Pointer.Create<LPCSTR>(szReaderName.Pointer),
                    Pointer.Create<LPCSTR>(szGroupName.Pointer)
                    ),
                2 => SCardRemoveReaderFromGroupW(
                    hContext,
                    Pointer.Create<LPCWSTR>(szReaderName.Pointer),
                    Pointer.Create<LPCWSTR>(szGroupName.Pointer)
                    ),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 394
        #region SCardIntroduceCardTypeA function
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        private static extern unsafe int SCardIntroduceCardTypeA(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] Guid* rgguidInterfaces,
            [In] int dwInterfaceCount,
            byte* pbAtr,
            byte* pbAtrMask,
            [In] int cbAtrLen
            );
        /// <inheritdoc cref="SCardIntroduceCardType(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        public static unsafe int SCardIntroduceCardTypeA(
            SCARDCONTEXT hContext,
            string szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] ReadOnlySpan<Guid> rgguidInterfaces,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<byte> pbAtrMask
            )
        {
            fixed (Guid* ptrguidInterfaces = rgguidInterfaces)
            fixed (byte* ptrAtr = pbAtr)
            fixed (byte* ptrAtrMask = pbAtrMask)
                return SCardIntroduceCardTypeA(
                    hContext,
                    szCardName,
                    pguidPrimaryProvider,
                    ptrguidInterfaces,
                    rgguidInterfaces.Length,
                    ptrAtr,
                    ptrAtrMask,
                    pbAtr.Length
                    );
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        private static extern unsafe int SCardIntroduceCardTypeA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] Guid* rgguidInterfaces,
            [In] int dwInterfaceCount,
            byte* pbAtr,
            byte* pbAtrMask,
            [In] int cbAtrLen
            );
        /// <inheritdoc cref="SCardIntroduceCardTypeA(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        public static unsafe int SCardIntroduceCardTypeA(
            SCARDCONTEXT hContext,
            LPCSTR szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] ReadOnlySpan<Guid> rgguidInterfaces,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<byte> pbAtrMask
            )
        {
            fixed (Guid* ptrguidInterfaces = rgguidInterfaces)
            fixed (byte* ptrAtr = pbAtr)
            fixed (byte* ptrAtrMask = pbAtrMask)
                return SCardIntroduceCardTypeA(
                    hContext,
                    szCardName,
                    pguidPrimaryProvider,
                    ptrguidInterfaces,
                    rgguidInterfaces.Length,
                    ptrAtr,
                    ptrAtrMask,
                    pbAtr.Length
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 404
        #region SCardIntroduceCardTypeW function
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        private static extern unsafe int SCardIntroduceCardTypeW(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] Guid* rgguidInterfaces,
            [In] int dwInterfaceCount,
            byte* pbAtr,
            byte* pbAtrMask,
            [In] int cbAtrLen
            );
        /// <inheritdoc cref="SCardIntroduceCardType(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        public static unsafe int SCardIntroduceCardTypeW(
            SCARDCONTEXT hContext,
            string szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] ReadOnlySpan<Guid> rgguidInterfaces,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<byte> pbAtrMask
            )
        {
            fixed (Guid* ptrguidInterfaces = rgguidInterfaces)
            fixed (byte* ptrAtr = pbAtr)
            fixed (byte* ptrAtrMask = pbAtrMask)
                return SCardIntroduceCardTypeW(
                    hContext,
                    szCardName,
                    pguidPrimaryProvider,
                    ptrguidInterfaces,
                    rgguidInterfaces.Length,
                    ptrAtr,
                    ptrAtrMask,
                    pbAtr.Length
                    );
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        private static extern unsafe int SCardIntroduceCardTypeW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] Guid* rgguidInterfaces,
            [In] int dwInterfaceCount,
            byte* pbAtr,
            byte* pbAtrMask,
            [In] int cbAtrLen
            );
        /// <inheritdoc cref="SCardIntroduceCardTypeW(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        public static unsafe int SCardIntroduceCardTypeW(
            SCARDCONTEXT hContext,
            LPCWSTR szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] ReadOnlySpan<Guid> rgguidInterfaces,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<byte> pbAtrMask
            )
        {
            fixed (Guid* ptrguidInterfaces = rgguidInterfaces)
            fixed (byte* ptrAtr = pbAtr)
            fixed (byte* ptrAtrMask = pbAtrMask)
                return SCardIntroduceCardTypeW(
                    hContext,
                    szCardName,
                    pguidPrimaryProvider,
                    ptrguidInterfaces,
                    rgguidInterfaces.Length,
                    ptrAtr,
                    ptrAtrMask,
                    pbAtr.Length
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 414
        #region SCardIntroduceCardType function
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static extern unsafe
#else
        private static unsafe
#endif // !NETSTANDARD1_3
        int SCardIntroduceCardType(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] Guid* rgguidInterfaces,
            [In] int dwInterfaceCount,
            byte* pbAtr,
            byte* pbAtrMask,
            [In] int cbAtrLen
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardIntroduceCardTypeA(
                    hContext, szCardName, pguidPrimaryProvider,
                    rgguidInterfaces, dwInterfaceCount, pbAtr, pbAtrMask,
                    cbAtrLen),
                2 => SCardIntroduceCardTypeW(
                    hContext, szCardName, pguidPrimaryProvider,
                    rgguidInterfaces, dwInterfaceCount, pbAtr, pbAtrMask,
                    cbAtrLen),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        /// <summary>
        /// The <see cref="SCardIntroduceCardType(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/> function introduces a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> to the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card subsystem</a> (for the active user) by adding it to the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card database</a>.
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to <see cref="SCardEstablishContext"/>. This parameter cannot be set to <see langword="default"/>.</param>
        /// <param name="szCardName">Name by which the user can recognize the card.</param>
        /// <param name="pguidPrimaryProvider">The identifier (GUID) for the smart card's <a href="https://docs.microsoft.com/windows/desktop/SecGloss/p-gly">primary service provider</a>.</param>
        /// <param name="rgguidInterfaces">Array of identifiers (GUIDs) that identify the interfaces supported by the smart card.</param>
        /// <param name="pbAtr"><a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly"></a> that can be used for matching purposes when querying the smart card database (for more information, see <see cref="SCardListCards"/>). The length of this string is determined by normal ATR parsing.</param>
        /// <param name="pbAtrMask">Optional bitmask to use when comparing the ATRs of smart cards to the ATR supplied in <paramref name="pbAtr"/>. If this value is non-empty, it must be a string of bytes the same length as the ATR string supplied in <paramref name="pbAtr"/>. When a given ATR string <em>A</em> is compared to the ATR supplied in <paramref name="pbAtr"/>, it matches if and only if <c><em>A</em> &amp; <em>M</em> = <paramref name="pbAtr"/></c>, where <em>M</em> is the supplied mask, and <c>&amp;</c> represents bitwise AND.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>This function is not redirected, but calling the function when inside a Remote Desktop session will not result in an error. It only means that the result will be from the remote computer instead of the local computer.</para>
        /// <para>The <see cref="SCardIntroduceCardType(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/> function is a database management function. For more information on other database management functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-management-functions">Smart Card Database Management Functions</a>.</para>
        /// <para>To remove a smart card, use <see cref="SCardForgetCardType(SCARDCONTEXT, string)"/>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardintroducecardtypew">SCardIntroduceCardTypeW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardForgetCardType(SCARDCONTEXT, string)"/>
        /// <seealso cref="SCardIntroduceReader"/>
        /// <seealso cref="SCardIntroduceReaderGroup"/>
        /// <seealso cref="SCardListCards"/>
        public static unsafe int SCardIntroduceCardType(
            SCARDCONTEXT hContext,
            string szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] ReadOnlySpan<Guid> rgguidInterfaces,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<byte> pbAtrMask
            )
        {
            fixed (Guid* ptrguidInterfaces = rgguidInterfaces)
            fixed (byte* ptrAtr = pbAtr)
            fixed (byte* ptrAtrMask = pbAtrMask)
                return SCardIntroduceCardType(
                    hContext,
                    szCardName,
                    pguidPrimaryProvider,
                    ptrguidInterfaces,
                    rgguidInterfaces.Length,
                    ptrAtr,
                    ptrAtrMask,
                    pbAtr.Length
                    );
        }
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static extern unsafe
#else
        private static unsafe
#endif // !NETSTANDARD1_3
        int SCardIntroduceCardType(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] Guid* rgguidInterfaces,
            [In] int dwInterfaceCount,
            byte* pbAtr,
            byte* pbAtrMask,
            [In] int cbAtrLen
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardIntroduceCardTypeA(hContext,
                    Pointer.Create<LPCSTR>(szCardName.Pointer),
                    pguidPrimaryProvider, rgguidInterfaces, dwInterfaceCount,
                    pbAtr, pbAtrMask, cbAtrLen),
                2 => SCardIntroduceCardTypeW(hContext,
                    Pointer.Create<LPCWSTR>(szCardName.Pointer),
                    pguidPrimaryProvider, rgguidInterfaces, dwInterfaceCount,
                    pbAtr, pbAtrMask, cbAtrLen),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        /// <inheritdoc cref="SCardIntroduceCardType(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        public static unsafe int SCardIntroduceCardType(
            SCARDCONTEXT hContext,
            LPCTSTR szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] ReadOnlySpan<Guid> rgguidInterfaces,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<byte> pbAtrMask
            )
        {
            fixed (Guid* ptrguidInterfaces = rgguidInterfaces)
            fixed (byte* ptrAtr = pbAtr)
            fixed (byte* ptrAtrMask = pbAtrMask)
                return SCardIntroduceCardType(
                    hContext,
                    szCardName,
                    pguidPrimaryProvider,
                    ptrguidInterfaces,
                    rgguidInterfaces.Length,
                    ptrAtr,
                    ptrAtrMask,
                    pbAtr.Length
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 419
        #region PCSCardIntroduceCardType function
        /// <inheritdoc cref="SCardIntroduceCardTypeA(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        public static int PCSCardIntroduceCardTypeA(
            SCARDCONTEXT hContext,
            string szCardName,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<byte> pbAtrMask,
            in Guid pguidPrimaryProvider = default,
            ReadOnlySpan<Guid> rgguidInterfaces = default
            ) => SCardIntroduceCardTypeA(
                hContext,
                szCardName,
                pguidPrimaryProvider,
                rgguidInterfaces,
                pbAtr,
                pbAtrMask
                );
        /// <inheritdoc cref="SCardIntroduceCardTypeA(SCARDCONTEXT, LPCSTR, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        public static int PCSCardIntroduceCardTypeA(
            SCARDCONTEXT hContext,
            LPCSTR szCardName,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<byte> pbAtrMask,
            in Guid pguidPrimaryProvider = default,
            ReadOnlySpan<Guid> rgguidInterfaces = default
            ) => SCardIntroduceCardTypeA(
                hContext,
                szCardName,
                pguidPrimaryProvider,
                rgguidInterfaces,
                pbAtr,
                pbAtrMask
                );
        /// <inheritdoc cref="SCardIntroduceCardTypeW(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        public static int PCSCardIntroduceCardTypeW(
            SCARDCONTEXT hContext,
            string szCardName,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<byte> pbAtrMask,
            in Guid pguidPrimaryProvider = default,
            ReadOnlySpan<Guid> rgguidInterfaces = default
            ) => SCardIntroduceCardTypeW(
                hContext,
                szCardName,
                pguidPrimaryProvider,
                rgguidInterfaces,
                pbAtr,
                pbAtrMask
                );
        /// <inheritdoc cref="SCardIntroduceCardTypeW(SCARDCONTEXT, LPCWSTR, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        public static int PCSCardIntroduceCardTypeW(
            SCARDCONTEXT hContext,
            LPCWSTR szCardName,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<byte> pbAtrMask,
            in Guid pguidPrimaryProvider = default,
            ReadOnlySpan<Guid> rgguidInterfaces = default
            ) => SCardIntroduceCardTypeW(
                hContext,
                szCardName,
                pguidPrimaryProvider,
                rgguidInterfaces,
                pbAtr,
                pbAtrMask
                );
        /// <inheritdoc cref="SCardIntroduceCardType(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        public static int PCSCardIntroduceCardType(
            SCARDCONTEXT hContext,
            string szCardName,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<byte> pbAtrMask,
            in Guid pguidPrimaryProvider = default,
            ReadOnlySpan<Guid> rgguidInterfaces = default
            ) => SCardIntroduceCardType(
                hContext,
                szCardName,
                pguidPrimaryProvider,
                rgguidInterfaces,
                pbAtr,
                pbAtrMask
                );
        /// <inheritdoc cref="SCardIntroduceCardType(SCARDCONTEXT, LPCTSTR, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
        public static int PCSCardIntroduceCardType(
            SCARDCONTEXT hContext,
            LPCTSTR szCardName,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<byte> pbAtrMask,
            in Guid pguidPrimaryProvider = default,
            ReadOnlySpan<Guid> rgguidInterfaces = default
            ) => SCardIntroduceCardType(
                hContext,
                szCardName,
                pguidPrimaryProvider,
                rgguidInterfaces,
                pbAtr,
                pbAtrMask
                );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 438
        #region SCardSetCardTypeProviderNameA function
        /// <inheritdoc cref="SCardSetCardTypeProviderName(SCARDCONTEXT, string, SCARD_PROVIDER_TYPE, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardSetCardTypeProviderNameA(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName,
            [In, MarshalAs(UnmanagedType.U4)] SCARD_PROVIDER_TYPE dwProviderId,
            [In] string szProvider
            );
        /// <inheritdoc cref="SCardSetCardTypeProviderNameA(SCARDCONTEXT, string, SCARD_PROVIDER_TYPE, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardSetCardTypeProviderNameA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szCardName,
            [In, MarshalAs(UnmanagedType.U4)] SCARD_PROVIDER_TYPE dwProviderId,
            [In] LPCSTR szProvider
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 444
        #region SCardSetCardTypeProviderNameW function
        /// <inheritdoc cref="SCardSetCardTypeProviderName(SCARDCONTEXT, string, SCARD_PROVIDER_TYPE, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardSetCardTypeProviderNameW(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName,
            [In, MarshalAs(UnmanagedType.U4)] SCARD_PROVIDER_TYPE dwProviderId,
            [In] string szProvider
            );
        /// <inheritdoc cref="SCardSetCardTypeProviderNameW(SCARDCONTEXT, string, SCARD_PROVIDER_TYPE, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardSetCardTypeProviderNameW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szCardName,
            [In, MarshalAs(UnmanagedType.U4)] SCARD_PROVIDER_TYPE dwProviderId,
            [In] LPCWSTR szProvider
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 450
        #region SCardSetCardTypeProviderName function
        /// <summary>
        /// The <see cref="SCardSetCardTypeProviderName(SCARDCONTEXT, string, SCARD_PROVIDER_TYPE, string)"/> function specifies the name of the module (dynamic link library) containing the provider for a given card name and <a href="https://docs.microsoft.com/windows/desktop/SecGloss/p-gly">provider type</a>.
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context can be set by a previous call to <see cref="SCardEstablishContext"/>. This value can be <see langword="default"/> if the call to <see cref="SCardSetCardTypeProviderName(SCARDCONTEXT, string, SCARD_PROVIDER_TYPE, string)"/> is not directed to a specific <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">context</a>.</param>
        /// <param name="szCardName">Name of the card type with which this <a href="https://docs.microsoft.com/windows/desktop/SecGloss/p-gly">provider name</a> is associated.</param>
        /// <param name="dwProviderId">Identifier for the provider associated with this card type.</param>
        /// <param name="szProvider">A string that contains the provider name that is representing the CSP.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>This function is not redirected, but calling the function when inside a Remote Desktop session will not result in an error. It only means that the result will be from the remote computer instead of the local computer.</para>
        /// <para>This function sets the provider name, while <see cref="SCardGetCardTypeProviderName"/> can be used to retrieve the provider name.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardsetcardtypeprovidernamew">SCardSetCardTypeProviderNameW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardGetCardTypeProviderName"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardSetCardTypeProviderName(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName,
            [In, MarshalAs(UnmanagedType.U4)] SCARD_PROVIDER_TYPE dwProviderId,
            [In] string szProvider
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardSetCardTypeProviderNameA(hContext, szCardName,
                    dwProviderId, szProvider),
                2 => SCardSetCardTypeProviderNameW(hContext, szCardName,
                    dwProviderId, szProvider),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        /// <inheritdoc cref="SCardSetCardTypeProviderName(SCARDCONTEXT, string, SCARD_PROVIDER_TYPE, string)"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardSetCardTypeProviderName(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szCardName,
            [In, MarshalAs(UnmanagedType.U4)] SCARD_PROVIDER_TYPE dwProviderId,
            [In] LPCTSTR szProvider
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardSetCardTypeProviderNameA(hContext,
                    Pointer.Create<LPCSTR>(szCardName.Pointer), dwProviderId,
                    Pointer.Create<LPCSTR>(szProvider.Pointer)),
                2 => SCardSetCardTypeProviderNameW(hContext,
                    Pointer.Create<LPCWSTR>(szCardName.Pointer), dwProviderId,
                    Pointer.Create<LPCWSTR>(szProvider.Pointer)),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 455
        //
        // NOTE:    This routine is an extention to the PC/SC specifications.
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 459
        #region SCardForgetCardTypeA function
        /// <inheritdoc cref="SCardForgetCardType(SCARDCONTEXT, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardForgetCardTypeA(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName
            );
        /// <inheritdoc cref="SCardForgetCardTypeA(SCARDCONTEXT, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardForgetCardTypeA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szCardName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 463
        #region SCardForgetCardTypeW function
        /// <inheritdoc cref="SCardForgetCardType(SCARDCONTEXT, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardForgetCardTypeW(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName
            );
        /// <inheritdoc cref="SCardForgetCardTypeW(SCARDCONTEXT, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardForgetCardTypeW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szCardName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 467
        #region SCardForgetCardType function
        /// <summary>
        /// The <see cref="SCardForgetCardType(SCARDCONTEXT, string)"/> function removes an introduced <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> from the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card subsystem</a>.
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to <see cref="SCardEstablishContext"/>. This parameter cannot be set to <see langword="default"/>.</param>
        /// <param name="szCardName">Display name of the card to be removed from the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card database</a>.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>This function is not redirected, but calling the function <see cref="SCardForgetCardType(SCARDCONTEXT, string)"/> when inside a Remote Desktop session will not result in an error. It only means that the result will be from the remote computer instead of the local computer.</para>
        /// <para>The <see cref="SCardForgetCardType(SCARDCONTEXT, string)"/> function is a database management function. For more information about other database management functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-management-functions">Smart Card Database Management Functions</a>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardforgetcardtypew">SCardForgetCardTypeW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardForgetReader"/>
        /// <seealso cref="SCardForgetReaderGroup"/>
        /// <seealso cref="SCardIntroduceCardType(SCARDCONTEXT, string, in Guid, ReadOnlySpan{Guid}, ReadOnlySpan{byte}, ReadOnlySpan{byte})"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardForgetCardType(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardForgetCardTypeA(hContext, szCardName),
                2 => SCardForgetCardTypeW(hContext, szCardName),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3

        /// <inheritdoc cref="SCardForgetCardType(SCARDCONTEXT, string)"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardForgetCardType(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szCardName
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardForgetCardTypeA(hContext, Pointer.Create<LPCSTR>(szCardName.Pointer)),
                2 => SCardForgetCardTypeW(hContext, Pointer.Create<LPCWSTR>(szCardName.Pointer)),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 474
        //
        ////////////////////////////////////////////////////////////////////////////////
        //
        //  Service Manager Support Routines
        //
        //      The following services are supplied to simplify the use of the Service
        //      Manager API.
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 483
        #region SCardFreeMemory function
        /// <summary>
        /// The <see cref="SCardFreeMemory"/> function releases memory that has been returned from the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager</a> using the <see cref="SCARD_AUTOALLOCATE"/> length designator.
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a> returned from <see cref="SCardEstablishContext"/>, or <see langword="default"/> if the creating function also specified <see langword="default"/> for its <em>hContext</em> parameter. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-database-query-functions">Smart Card Database Query Functions</a>.</param>
        /// <param name="pvMem">Memory block to be released.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardfreememory">SCardFreeMemory function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardGetProviderId"/>
        /// <seealso cref="SCardListCards"/>
        /// <seealso cref="SCardListInterfaces"/>
        /// <seealso cref="SCardListReaderGroups"/>
        /// <seealso cref="SCardListReaders"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardFreeMemory(
            [In] SCARDCONTEXT hContext,
            [In] IntPtr pvMem
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 488
        #region SCardAccessStartedEvent function
        /// <summary>
        /// The <see cref="SCardAccessStartedEvent"/> function returns an event handle when an event signals that the smart card resource manager is started. The event-object handle can be specified in a call to one of the wait functions.
        /// </summary>
        /// <returns>
        /// <para>The function returns an event <see cref="SCARDWAITHANDLE"/> if it succeeds or a pointer with the value of <see cref="IntPtr.Zero"/> if it fails.</para>
        /// <para>If the function fails, the <see cref="Marshal.GetLastWin32Error"/> function provides information on the cause of the failure.</para>
        /// </returns>
        /// <remarks>
        /// <para>The event-object handle returned can be specified in a call to one of the wait functions.</para>
        /// <para>Do not close the handle returned by this function. When you have finished using the handle, decrement the reference count by calling the <see cref="SCardReleaseStartedEvent"/> function.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardaccessstartedevent">SCardAccessStartedEvent function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern SCARDWAITHANDLE SCardAccessStartedEvent();
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 488
        #region SCardReleaseStartedEvent function
        /// <summary>
        /// The <see cref="SCardReleaseStartedEvent"/> function decrements the reference count for a handle acquired by a previous call to the <see cref="SCardAccessStartedEvent"/> function.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardreleasestartedevent">SCardReleaseStartedEvent function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern void SCardReleaseStartedEvent();
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 496
        //
        ////////////////////////////////////////////////////////////////////////////////
        //
        //  Reader Services
        //
        //      The following services supply means for tracking cards within readers.
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 600
        #region SCardLocateCardsA function
        /// <inheritdoc cref="SCardLocateCards"/>
        public static unsafe int SCardLocateCardsA(
            SCARDCONTEXT hContext,
            string mszCards,
            Span<SCARD_READERSTATEA> rgReaderStates
            )
        {
            fixed (SCARD_READERSTATEA* ptrReaderStates = rgReaderStates)
                return SCardLocateCardsA(
                    hContext,
                    mszCards,
                    ptrReaderStates,
                    rgReaderStates.Length
                    );
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        private static extern unsafe int SCardLocateCardsA(
            [In] SCARDCONTEXT hContext,
            [In] string mszCards,
            SCARD_READERSTATEA* rgReaderStates,
            [In] int cReaders
            );
        /// <inheritdoc cref="SCardLocateCardsA(SCARDCONTEXT, string, Span{SCARD_READERSTATEA})"/>
        public static unsafe int SCardLocateCardsA(
            SCARDCONTEXT hContext,
            LPCMSTR mszCards,
            Span<SCARD_READERSTATEA> rgReaderStates
            )
        {
            fixed (SCARD_READERSTATEA* ptrReaderStates = rgReaderStates)
                return SCardLocateCardsA(
                    hContext,
                    mszCards,
                    ptrReaderStates,
                    rgReaderStates.Length
                    );
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        private static extern unsafe int SCardLocateCardsA(
            [In] SCARDCONTEXT hContext,
            [In] LPCMSTR mszCards,
            SCARD_READERSTATEA* rgReaderStates,
            [In] int cReaders
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 606
        #region SCardLocateCardsW function
        /// <inheritdoc cref="SCardLocateCards(SCARDCONTEXT, string, Span{SCARD_READERSTATE})"/>
        public static unsafe int SCardLocateCardsW(
            SCARDCONTEXT hContext,
            string mszCards,
            Span<SCARD_READERSTATEW> rgReaderStates
            )
        {
            fixed (SCARD_READERSTATEW* ptrReaderStates = rgReaderStates)
                return SCardLocateCardsW(
                    hContext,
                    mszCards,
                    ptrReaderStates,
                    rgReaderStates.Length
                    );
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        private static extern unsafe int SCardLocateCardsW(
            [In] SCARDCONTEXT hContext,
            [In] string mszCards,
            SCARD_READERSTATEW* rgReaderStates,
            [In] int cReaders
            );
        /// <inheritdoc cref="SCardLocateCardsW(SCARDCONTEXT, string, Span{SCARD_READERSTATEW})"/>
        public static unsafe int SCardLocateCardsW(
            SCARDCONTEXT hContext,
            LPCMWSTR mszCards,
            Span<SCARD_READERSTATEW> rgReaderStates
            )
        {
            fixed (SCARD_READERSTATEW* ptrReaderStates = rgReaderStates)
                return SCardLocateCardsW(
                    hContext,
                    mszCards,
                    ptrReaderStates,
                    rgReaderStates.Length
                    );
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        private static extern unsafe int SCardLocateCardsW(
            [In] SCARDCONTEXT hContext,
            [In] LPCMWSTR mszCards,
            SCARD_READERSTATEW* rgReaderStates,
            [In] int cReaders
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 612
        #region SCardLocateCards function
        /// <summary>
        /// The <see cref="SCardLocateCards(SCARDCONTEXT, string, Span{SCARD_READERSTATE})"/> function searches the readers listed in the <paramref name="rgReaderStates"/> parameter for a card with an <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">ATR string</a> that matches one of the card names specified in <paramref name="mszCards"/>, returning immediately with the result.
        /// </summary>
        /// <param name="hContext">A handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to <see cref="SCardEstablishContext"/>.</param>
        /// <param name="mszCards">A multiple string that contains the names of the cards to search for.</param>
        /// <param name="rgReaderStates">An array of <see cref="SCARD_READERSTATE"/> structures that, on input, specify the readers to search and that, on output, receives the result.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>This service is especially useful when used in conjunction with <see cref="SCardGetStatusChange(SCARDCONTEXT, TimeSpan, Span{SCARD_READERSTATE})"/>. If no matching cards are found by means of <see cref="SCardLocateCards(SCARDCONTEXT, string, Span{SCARD_READERSTATE})"/>, the calling application may use <see cref="SCardGetStatusChange(SCARDCONTEXT, TimeSpan, Span{SCARD_READERSTATE})"/> to wait for card availability changes.</para>
        /// <para>The <see cref="SCardLocateCards(SCARDCONTEXT, string, Span{SCARD_READERSTATE})"/> function is a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> tracking function. For more information on other tracking functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-tracking-functions">Smart Card Tracking Functions</a>.</para>
        /// <para>Calling this function should be done outside of a transaction. If an application begins a transaction with the <see cref="SCardBeginTransaction"/> function and then calls this function, it resets the <em>hCard</em> parameter (of type <see cref="SCARDHANDLE"/>) of the <see cref="SCardBeginTransaction"/> function.</para>
        /// <para><strong>Windows Server 2008 R2 and Windows 7:</strong> Calling this function within a transaction could result in your computer becoming unresponsive.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> Not applicable.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardlocatecardsw">SCardLocateCardsW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCARD_READERSTATE"/>
        /// <seealso cref="SCardCancel"/>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardGetStatusChange(SCARDCONTEXT, TimeSpan, Span{SCARD_READERSTATE})"/>
        public static unsafe int SCardLocateCards(
            SCARDCONTEXT hContext,
            string mszCards,
            Span<SCARD_READERSTATE> rgReaderStates
            )
        {
            fixed (SCARD_READERSTATE* ptrReaderStates = rgReaderStates)
                return SCardLocateCards(
                    hContext,
                    mszCards,
                    ptrReaderStates,
                    rgReaderStates.Length
                    );
        }
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static extern unsafe
#else
        private static unsafe
#endif // !NETSTANDARD1_3
        int SCardLocateCards(
            [In] SCARDCONTEXT hContext,
            [In] string mszCards,
            SCARD_READERSTATE* rgReaderStates,
            [In] int cReaders
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardLocateCardsA(hContext, mszCards,
                    (SCARD_READERSTATEA*)rgReaderStates, cReaders),
                2 => SCardLocateCardsW(hContext, mszCards,
                    (SCARD_READERSTATEW*)rgReaderStates, cReaders),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        /// <inheritdoc cref="SCardLocateCards(SCARDCONTEXT, string, Span{SCARD_READERSTATE})"/>
        public static unsafe int SCardLocateCards(
            SCARDCONTEXT hContext,
            LPCMTSTR mszCards,
            Span<SCARD_READERSTATE> rgReaderStates
            )
        {
            fixed (SCARD_READERSTATE* ptrReaderStates = rgReaderStates)
                return SCardLocateCards(
                    hContext,
                    mszCards,
                    ptrReaderStates,
                    rgReaderStates.Length
                    );
        }
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static extern unsafe
#else
        private static unsafe
#endif // !NETSTANDARD1_3
        int SCardLocateCards(
            [In] SCARDCONTEXT hContext,
            [In] LPCMTSTR mszCards,
            SCARD_READERSTATE* rgReaderStates,
            [In] int cReaders
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardLocateCardsA(hContext,
                    Pointer.Create<LPCMSTR>(mszCards.Pointer),
                    (SCARD_READERSTATEA*)rgReaderStates, cReaders),
                2 => SCardLocateCardsW(hContext,
                    Pointer.Create<LPCMWSTR>(mszCards.Pointer),
                    (SCARD_READERSTATEW*)rgReaderStates, cReaders),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 626
        #region SCardLocateCardsByATRA function
        /// <inheritdoc cref="SCardLocateCardsByATR(SCARDCONTEXT, ReadOnlySpan{SCARD_ATRMASK}, Span{SCARD_READERSTATE})"/>
        public static unsafe int SCardLocateCardsByATRA(
            SCARDCONTEXT hContext,
            ReadOnlySpan<SCARD_ATRMASK> rgAtrMasks,
            Span<SCARD_READERSTATEA> rgReaderStates
            )
        {
            fixed (SCARD_ATRMASK* ptrAtrMasks = rgAtrMasks)
            fixed (SCARD_READERSTATEA* ptrReaderStates = rgReaderStates)
                return SCardLocateCardsByATRA(
                    hContext,
                    ptrAtrMasks,
                    rgAtrMasks.Length,
                    ptrReaderStates,
                    rgReaderStates.Length
                    );
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        private static extern unsafe int SCardLocateCardsByATRA(
            [In] SCARDCONTEXT hContext,
            [In] SCARD_ATRMASK* rgAtrMasks,
            [In] int cAtrs,
            [In, Out] SCARD_READERSTATEA* rgReaderStates,
            [In] int cReaders
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 633
        #region SCardLocateCardsByATRW function
        /// <inheritdoc cref="SCardLocateCardsByATR(SCARDCONTEXT, ReadOnlySpan{SCARD_ATRMASK}, Span{SCARD_READERSTATE})"/>
        public static unsafe int SCardLocateCardsByATRW(
            SCARDCONTEXT hContext,
            ReadOnlySpan<SCARD_ATRMASK> rgAtrMasks,
            Span<SCARD_READERSTATEW> rgReaderStates
            )
        {
            fixed (SCARD_ATRMASK* ptrAtrMasks = rgAtrMasks)
            fixed (SCARD_READERSTATEW* ptrReaderStates = rgReaderStates)
                return SCardLocateCardsByATRW(
                    hContext,
                    ptrAtrMasks,
                    rgAtrMasks.Length,
                    ptrReaderStates,
                    rgReaderStates.Length
                    );
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        private static extern unsafe int SCardLocateCardsByATRW(
            [In] SCARDCONTEXT hContext,
            [In] SCARD_ATRMASK* rgAtrMasks,
            [In] int cAtrs,
            [In, Out] SCARD_READERSTATEW* rgReaderStates,
            [In] int cReaders
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 640
        #region SCardLocateCardsByATR function
        /// <summary>
        /// The <see cref="SCardLocateCardsByATR(SCARDCONTEXT, ReadOnlySpan{SCARD_ATRMASK}, Span{SCARD_READERSTATE})"/> function searches the readers listed in the <paramref name="rgReaderStates"/> parameter for a card with a name that matches one of the card names contained in one of the <see cref="SCARD_ATRMASK"/> structures specified by the <paramref name="rgAtrMasks"/> parameter.
        /// </summary>
        /// <param name="hContext">A handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to <see cref="SCardEstablishContext"/>.</param>
        /// <param name="rgAtrMasks">Array of <see cref="SCARD_ATRMASK"/> structures that contain the names of the cards for which to search.</param>
        /// <param name="rgReaderStates">Array of <see cref="SCARD_READERSTATE"/> structures that specify the readers to search, and receive the result.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>This service is especially useful when used in conjunction with <see cref="SCardGetStatusChange(SCARDCONTEXT, TimeSpan, Span{SCARD_READERSTATE})"/>. If no matching cards are found by means of <see cref="SCardLocateCards(SCARDCONTEXT, string, Span{SCARD_READERSTATE})"/>, the calling application may use <see cref="SCardGetStatusChange(SCARDCONTEXT, TimeSpan, Span{SCARD_READERSTATE})"/> to wait for card availability changes.</para>
        /// <para>The <see cref="SCardLocateCardsByATR(SCARDCONTEXT, ReadOnlySpan{SCARD_ATRMASK}, Span{SCARD_READERSTATE})"/> function is a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> tracking function. For information about other tracking functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-tracking-functions">Smart Card Tracking Functions</a>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardlocatecardsbyatrw">SCardLocateCardsByATRW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        public static unsafe int SCardLocateCardsByATR(
            SCARDCONTEXT hContext,
            ReadOnlySpan<SCARD_ATRMASK> rgAtrMasks,
            Span<SCARD_READERSTATE> rgReaderStates
            )
        {
            fixed (SCARD_ATRMASK* ptrAtrMasks = rgAtrMasks)
            fixed (SCARD_READERSTATE* ptrReaderStates = rgReaderStates)
                return SCardLocateCardsByATR(
                    hContext,
                    ptrAtrMasks,
                    rgAtrMasks.Length,
                    ptrReaderStates,
                    rgReaderStates.Length
                    );
        }
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static extern unsafe
#else
        private static unsafe
#endif // !NETSTANDARD1_3
        int SCardLocateCardsByATR(
            [In] SCARDCONTEXT hContext,
            [In] SCARD_ATRMASK* rgAtrMasks,
            [In] int cAtrs,
            [In, Out] SCARD_READERSTATE* rgReaderStates,
            [In] int cReaders
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardLocateCardsByATRA(hContext, rgAtrMasks, cAtrs,
                    (SCARD_READERSTATEA*)rgReaderStates, cReaders),
                2 => SCardLocateCardsByATRW(hContext, rgAtrMasks, cAtrs,
                    (SCARD_READERSTATEW*)rgReaderStates, cReaders),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 647
        #region SCardGetStatusChangeA function
        /// <inheritdoc cref="SCardGetStatusChange(SCARDCONTEXT, TimeSpan, Span{SCARD_READERSTATE})"/>
        public static unsafe int SCardGetStatusChangeA(
            SCARDCONTEXT hContext,
            TimeSpan dwTimeout,
            Span<SCARD_READERSTATEA> rgReaderStates
            )
        {
            fixed (SCARD_READERSTATEA* ptrReaderStates = rgReaderStates)
                return SCardGetStatusChangeA(
                    hContext,
                    (int)dwTimeout.TotalMilliseconds,
                    ptrReaderStates,
                    rgReaderStates.Length
                    );
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        private static extern unsafe int SCardGetStatusChangeA(
            [In] SCARDCONTEXT hContext,
            [In] int dwTimeout,
            [In, Out] SCARD_READERSTATEA* rgReaderStates,
            [In] int cReaders
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 653
        #region SCardGetStatusChangeW function
        /// <inheritdoc cref="SCardGetStatusChange(SCARDCONTEXT, TimeSpan, Span{SCARD_READERSTATE})"/>
        public static unsafe int SCardGetStatusChangeW(
            SCARDCONTEXT hContext,
            TimeSpan dwTimeout,
            Span<SCARD_READERSTATEW> rgReaderStates
            )
        {
            fixed (SCARD_READERSTATEW* ptrReaderStates = rgReaderStates)
                return SCardGetStatusChangeW(
                    hContext,
                    (int)dwTimeout.TotalMilliseconds,
                    ptrReaderStates,
                    rgReaderStates.Length
                    );
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        private static extern unsafe int SCardGetStatusChangeW(
            [In] SCARDCONTEXT hContext,
            [In] int dwTimeout,
            [In, Out] SCARD_READERSTATEW* rgReaderStates,
            [In] int cReaders
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 659
        #region SCardGetStatusChange function
        /// <summary>
        /// The <see cref="SCardGetStatusChange(SCARDCONTEXT, TimeSpan, Span{SCARD_READERSTATE})"/> function blocks execution until the current availability of the cards in a specific set of readers changes.
        /// <para>The caller supplies a list of <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">readers</a> to be monitored by an <see cref="SCARD_READERSTATE"/> array and the maximum amount of time (in milliseconds) that it is willing to wait for an action to occur on one of the listed readers. Note that <see cref="SCardGetStatusChange(SCARDCONTEXT, TimeSpan, Span{SCARD_READERSTATE})"/> uses the user-supplied value in the <see cref="SCARD_READERSTATE.dwCurrentState"/> members of the <paramref name="rgReaderStates"/> <see cref="SCARD_READERSTATE"/> array as the definition of the current <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">state</a> of the readers. The function returns when there is a change in availability, having filled in the <see cref="SCARD_READERSTATE.dwEventState"/> members of <paramref name="rgReaderStates"/> appropriately.</para>
        /// </summary>
        /// <param name="hContext">A handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to <see cref="SCardEstablishContext"/>.</param>
        /// <param name="dwTimeout">The maximum amount of time to wait for an action. A value of <see cref="TimeSpan.Zero"/> causes the function to return immediately. A value of <see cref="System.Threading.Timeout.InfiniteTimeSpan"/> causes this function never to time out.</param>
        /// <param name="rgReaderStates">
        /// <para>An array of <see cref="SCARD_READERSTATE"/> structures that specify the readers to watch, and that receives the result.</para>
        /// <para>To be notified of the arrival of a new smart card reader, set the <see cref="SCARD_READERSTATE.szReader"/> member of a <see cref="SCARD_READERSTATE"/> structure to <c>"\\?PnP?\Notification"</c>, and set all of the other members of that structure to zero.</para>
        /// <para>
        /// <note type="important">
        /// Each member of each structure in this array must be initialized to zero and then set to specific values as necessary. If this is not done, the function will fail in situations that involve remote card readers.
        /// </note>
        /// </para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="SCardGetStatusChange(SCARDCONTEXT, TimeSpan, Span{SCARD_READERSTATE})"/> function is a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> tracking function. For more information about other tracking functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-tracking-functions">Smart Card Tracking Functions</a>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardgetstatuschangew">SCardGetStatusChangeW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCARD_READERSTATE"/>
        /// <seealso cref="SCardCancel"/>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardLocateCards(SCARDCONTEXT, string, Span{SCARD_READERSTATE})"/>
        public static unsafe int SCardGetStatusChange(
            SCARDCONTEXT hContext,
            TimeSpan dwTimeout,
            Span<SCARD_READERSTATE> rgReaderStates
            )
        {
            fixed (SCARD_READERSTATE* ptrReaderStates = rgReaderStates)
                return SCardGetStatusChange(
                    hContext,
                    (int)dwTimeout.TotalMilliseconds,
                    ptrReaderStates,
                    rgReaderStates.Length
                    );
        }
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static extern unsafe
#else
        private static unsafe
#endif // !NETSTANDARD1_3
        int SCardGetStatusChange(
            [In] SCARDCONTEXT hContext,
            [In] int dwTimeout,
            [In, Out] SCARD_READERSTATE* rgReaderStates,
            [In] int cReaders
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardGetStatusChangeA(hContext, dwTimeout,
                    (SCARD_READERSTATEA*)rgReaderStates, cReaders),
                2 => SCardGetStatusChangeW(hContext, dwTimeout,
                    (SCARD_READERSTATEW*)rgReaderStates, cReaders),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 665
        #region SCardCancel function
        /// <summary>
        /// <para>The <see cref="SCardCancel"/> function terminates all outstanding actions within a specific <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>.</para>
        /// <para>The only requests that you can cancel are those that require waiting for external action by the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> or user. Any such outstanding action requests will terminate with a status indication that the action was canceled. This is especially useful to force outstanding <see cref="SCardGetStatusChange(SCARDCONTEXT, TimeSpan, Span{SCARD_READERSTATE})"/> calls to terminate.</para>
        /// </summary>
        /// <param name="hContext">A handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to <see cref="SCardEstablishContext"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="SCardCancel"/> function is a smart card tracking function. For a description of other tracking functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-tracking-functions">Smart Card Tracking Functions</a>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardcancel">SCardCancel function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardGetStatusChange(SCARDCONTEXT, TimeSpan, Span{SCARD_READERSTATE})"/>
        /// <seealso cref="SCardLocateCards(SCARDCONTEXT, string, Span{SCARD_READERSTATE})"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardCancel(
            [In] SCARDCONTEXT hContext
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 670
        //
        ////////////////////////////////////////////////////////////////////////////////
        //
        //  Card/Reader Communication Services
        //
        //      The following services provide means for communication with the card.
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 691
        #region SCardConnectA function
        /// <inheritdoc cref="SCardConnect(SCARDCONTEXT, string, SCARD_SHARE_MODE, SCARD_PROTOCOL_FLAGS, out SCARDHANDLE, out SCARD_PROTOCOL_FLAGS)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardConnectA(
            [In] SCARDCONTEXT hContext,
            [In] string szReader,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_SHARE_MODE dwShareMode,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROTOCOL_FLAGS dwPreferredProtocols,
            out SCARDHANDLE phCard,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_PROTOCOL_FLAGS pdwActiveProtocol
            );
        /// <inheritdoc cref="SCardConnectA(SCARDCONTEXT, string, SCARD_SHARE_MODE, SCARD_PROTOCOL_FLAGS, out SCARDHANDLE, out SCARD_PROTOCOL_FLAGS)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardConnectA(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szReader,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_SHARE_MODE dwShareMode,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROTOCOL_FLAGS dwPreferredProtocols,
            out SCARDHANDLE phCard,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_PROTOCOL_FLAGS pdwActiveProtocol
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 699
        #region SCardConnectW function
        /// <inheritdoc cref="SCardConnect(SCARDCONTEXT, string, SCARD_SHARE_MODE, SCARD_PROTOCOL_FLAGS, out SCARDHANDLE, out SCARD_PROTOCOL_FLAGS)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardConnectW(
            [In] SCARDCONTEXT hContext,
            [In] string szReader,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_SHARE_MODE dwShareMode,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROTOCOL_FLAGS dwPreferredProtocols,
            out SCARDHANDLE phCard,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_PROTOCOL_FLAGS pdwActiveProtocol
            );
        /// <inheritdoc cref="SCardConnectW(SCARDCONTEXT, string, SCARD_SHARE_MODE, SCARD_PROTOCOL_FLAGS, out SCARDHANDLE, out SCARD_PROTOCOL_FLAGS)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardConnectW(
            [In] SCARDCONTEXT hContext,
            [In] LPCWSTR szReader,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_SHARE_MODE dwShareMode,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROTOCOL_FLAGS dwPreferredProtocols,
            out SCARDHANDLE phCard,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_PROTOCOL_FLAGS pdwActiveProtocol
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 699
        #region SCardConnect function
        /// <summary>
        /// The <see cref="SCardConnect"/> function establishes a connection (using a specific <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>) between the calling application and a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> contained by a specific reader. If no card exists in the specified reader, an error is returned.
        /// </summary>
        /// <param name="hContext">A handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context is set by a previous call to <see cref="SCardEstablishContext"/>.</param>
        /// <param name="szReader">The name of the reader that contains the target card.</param>
        /// <param name="dwShareMode">A flag that indicates whether other applications may form connections to the card.</param>
        /// <param name="dwPreferredProtocols">A bitmask of acceptable protocols for the connection. Possible values may be combined with the <strong>OR</strong> operation.</param>
        /// <param name="phCard">A handle that identifies the connection to the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> in the designated reader.</param>
        /// <param name="pdwActiveProtocol">A flag that indicates the established active protocol.</param>
        /// <returns>
        /// This function returns different values depending on whether it succeeds or fails.
        /// <list type="table">
        /// <listheader><term>Outcome</term><description>Description</description></listheader>
        /// <item><term>Success</term><description><see cref="SCARD_S_SUCCESS"/></description></item>
        /// <item><term>Failure</term><description>An error code. An error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</description></item>
        /// <item><term><see cref="SCARD_E_NOT_READY"/></term><description>The reader was unable to connect to the card.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// The <see cref="SCardConnect"/> function is a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> and <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a> access function. For more information about other access functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-and-reader-access-functions">Smart Card and Reader Access Functions</a>.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardconnectw">SCardConnectW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardControl"/>
        /// <seealso cref="SCardDisconnect"/>
        /// <seealso cref="SCardEstablishContext"/>
        /// <seealso cref="SCardReconnect"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardConnect(
            [In] SCARDCONTEXT hContext,
            [In] string szReader,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_SHARE_MODE dwShareMode,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROTOCOL_FLAGS dwPreferredProtocols,
            out SCARDHANDLE phCard,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_PROTOCOL_FLAGS pdwActiveProtocol
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardConnectA(hContext, szReader, dwShareMode,
                    dwPreferredProtocols, out phCard, out pdwActiveProtocol),
                2 => SCardConnectW(hContext, szReader, dwShareMode,
                    dwPreferredProtocols, out phCard, out pdwActiveProtocol),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        /// <inheritdoc cref="SCardConnect(SCARDCONTEXT, string, SCARD_SHARE_MODE, SCARD_PROTOCOL_FLAGS, out SCARDHANDLE, out SCARD_PROTOCOL_FLAGS)"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static
#endif // !NETSTANDARD1_3
        int SCardConnect(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szReader,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_SHARE_MODE dwShareMode,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROTOCOL_FLAGS dwPreferredProtocols,
            out SCARDHANDLE phCard,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_PROTOCOL_FLAGS pdwActiveProtocol
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardConnectA(hContext,
                    Pointer.Create<LPCSTR>(szReader.Pointer), dwShareMode,
                    dwPreferredProtocols, out phCard, out pdwActiveProtocol),
                2 => SCardConnectW(hContext,
                    Pointer.Create<LPCWSTR>(szReader.Pointer), dwShareMode,
                    dwPreferredProtocols, out phCard, out pdwActiveProtocol),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 713
        #region SCardReconnect function
        /// <summary>
        /// The <see cref="SCardReconnect"/> function reestablishes an existing connection between the calling application and a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a>. This function moves a card handle from direct access to general access, or acknowledges and clears an error condition that is preventing further access to the card.
        /// </summary>
        /// <param name="hCard">Reference value obtained from a previous call to <see cref="SCardConnect"/>.</param>
        /// <param name="dwShareMode">Flag that indicates whether other applications may form connections to this card.</param>
        /// <param name="dwPreferredProtocols">
        /// <para>Bitmask of acceptable protocols for this connection. Possible values may be combined with the <strong>OR</strong> operation.</para>
        /// <para>The value of this parameter should include the current protocol. Attempting to reconnect with a protocol other than the current protocol will result in an error.</para>
        /// </param>
        /// <param name="dwInitialization">Type of initialization that should be performed on the card.</param>
        /// <param name="pdwActiveProtocol">Flag that indicates the established active protocol.</param>
        /// <returns>
        /// This function returns different values depending on whether it succeeds or fails.
        /// <list type="table">
        /// <listheader><term>Outcome</term><description>Description</description></listheader>
        /// <item><term>Success</term><description><see cref="SCARD_S_SUCCESS"/></description></item>
        /// <item><term>Failure</term><description>An error code. An error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <see cref="SCardReconnect"/> is a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> and <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a> access function. For information about other access functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-and-reader-access-functions">Smart Card and Reader Access Functions</a>.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardreconnect">SCardReconnect function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardConnect"/>
        /// <seealso cref="SCardDisconnect"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardReconnect(
            [In] SCARDHANDLE hCard,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_SHARE_MODE dwShareMode,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROTOCOL_FLAGS dwPreferredProtocols,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_DISPOSITION dwInitialization,
            [Optional] out SCARD_PROTOCOL_FLAGS pdwActiveProtocol
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 721
        #region SCardDisconnect function
        /// <summary>
        /// The <see cref="SCardDisconnect"/> function terminates a connection previously opened between the calling application and a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> in the target <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a>.
        /// </summary>
        /// <param name="hCard">Reference value obtained from a previous call to <see cref="SCardConnect"/>.</param>
        /// <param name="dwDisposition">Action to take on the card in the connected reader on close.</param>
        /// <returns>
        /// This function returns different values depending on whether it succeeds or fails.
        /// <list type="table">
        /// <listheader><term>Outcome</term><description>Description</description></listheader>
        /// <item><term>Success</term><description><see cref="SCARD_S_SUCCESS"/></description></item>
        /// <item><term>Failure</term><description>An error code. An error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <para>If an application (which previously called <see cref="SCardConnect"/>) exits without calling <see cref="SCardDisconnect"/>, the card is automatically reset.</para>
        /// <para>The <see cref="SCardDisconnect"/> function is a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> and <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a> access function. For more information on other access functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-and-reader-access-functions">Smart Card and Reader Access Functions</a>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scarddisconnect">SCardDisconnect function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardConnect"/>
        /// <seealso cref="SCardReconnect"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardDisconnect(
            [In] SCARDHANDLE hCard,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_DISPOSITION dwDisposition
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 726
        #region SCardBeginTransaction function
        /// <summary>
        /// <para>The <see cref="SCardBeginTransaction"/> function starts a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/t-gly">transaction</a>.</para>
        /// <para>The function waits for the completion of all other transactions before it begins. After the transaction starts, all other applications are blocked from accessing the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> while the transaction is in progress.</para>
        /// </summary>
        /// <param name="hCard">A reference value obtained from a previous call to <see cref="SCardConnect"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, it returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// <para>If another process or thread has reset the card, <see cref="SCARD_W_RESET_CARD"/> is returned as expected.</para>
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This function returns <see cref="SCARD_S_SUCCESS"/> even if another process or thread has reset the card. To determine whether the card has been reset, call the <see cref="SCardStatus"/> function immediately after calling this function.</para>
        /// </returns>
        /// <remarks>
        /// <para>If a transaction is held on the card for more than five seconds with no operations happening on that card, then the card is reset. Calling any of the <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-and-reader-access-functions">Smart Card and Reader Access Functions</a> or <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/direct-card-access-functions">Direct Card Access Functions</a> on the card that is transacted results in the timer being reset to continue allowing the transaction to be used.</para>
        /// <para>The <see cref="SCardBeginTransaction"/> function is a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> and <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a> access function. For more information about other access functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-and-reader-access-functions">Smart Card and Reader Access Functions</a>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardbegintransaction">SCardBeginTransaction function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardConnect"/>
        /// <seealso cref="SCardEndTransaction"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardBeginTransaction(
            [In] SCARDHANDLE hCard
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 730
        #region SCardEndTransaction function
        /// <summary>
        /// The <see cref="SCardEndTransaction"/> function completes a previously declared <a href="https://docs.microsoft.com/windows/desktop/SecGloss/t-gly">transaction</a>, allowing other applications to resume interactions with the card.
        /// </summary>
        /// <param name="hCard">Reference value obtained from a previous call to <see cref="SCardConnect"/>. This value would also have been used in an earlier call to <see cref="SCardBeginTransaction"/>.</param>
        /// <param name="dwDisposition">Action to take on the card in the connected reader on close.</param>
        /// <returns>
        /// <para>If the function succeeds, the function returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>
        /// If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>. Possible error codes follow.
        /// <list type="table">
        /// <listheader><term>Return code/value</term><description>Description</description></listheader>
        /// <item><term><see cref="SCARD_W_RESET_CARD"/><br/><c>0x80100068</c></term><description><para>The transaction was released. Any future communication with the card requires a call to the <see cref="SCardReconnect"/> function.</para><para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> The transaction was not released. The application must immediately call the <see cref="SCardDisconnect"/>, <see cref="SCardReconnect"/>, or <see cref="SCardReleaseContext"/> function to avoid an existing transaction blocking other threads and processes from communicating with the smart card.</para></description></item>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="SCardEndTransaction"/> function is a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> and <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a> access function. For more information on other access functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-and-reader-access-functions">Smart Card and Reader Access Functions</a>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardendtransaction">SCardEndTransaction function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardBeginTransaction"/>
        /// <seealso cref="SCardConnect"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardEndTransaction(
            [In] SCARDHANDLE hCard,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_DISPOSITION dwDisposition
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 735
        #region SCardCancelTransaction function
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardCancelTransaction(
            [In] SCARDHANDLE hCard
            );
        //
        // NOTE:    This call corresponds to the PC/SC SCARDCOMM::Cancel routine,
        //          terminating a blocked SCardBeginTransaction service.
        //
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 744
        #region SCardState function
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [Obsolete("SCardState is an obsolete routine. PC/SC has replaced it with SCardStatus.")]
        public static unsafe int SCardState(
            SCARDHANDLE hCard,
            out SCARD_READER_STATE pdwState,
            out SCARD_PROTOCOL_FLAGS pdwProtocol,
            Span<byte> pbAtr,
            out int pcbAtrLen
            )
        {
            pcbAtrLen = pbAtr.Length;
            fixed (byte* ptrAtr = pbAtr)
                return SCardState(
                    hCard,
                    out pdwState,
                    out pdwProtocol,
                    ptrAtr,
                    ref pcbAtrLen
                    );
        }
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [Obsolete("SCardState is an obsolete routine. PC/SC has replaced it with SCardStatus.")]
        public static unsafe int SCardState(
            SCARDHANDLE hCard,
            out SCARD_READER_STATE pdwState,
            out SCARD_PROTOCOL_FLAGS pdwProtocol,
            out Span<byte> pbAtr
            )
        {
            int cbAtrLen = SCARD_AUTOALLOCATE;
            void* ptrAtr;
            byte* pptrAtr = (byte*)(&ptrAtr);
            int resultCode = SCardState(
                    hCard,
                    out pdwState,
                    out pdwProtocol,
                    pptrAtr,
                    ref cbAtrLen
                    );
            pbAtr = new Span<byte>(ptrAtr, cbAtrLen);
            return resultCode;
        }
        [Obsolete("SCardState is an obsolete routine. PC/SC has replaced it with SCardStatus.")]
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe int SCardState(
            [In] SCARDHANDLE hCard,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_READER_STATE pdwState,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_PROTOCOL_FLAGS pdwProtocol,
            byte* pbAtr,
            ref int pcbAtrLen
            );
        //
        // NOTE:    SCardState is an obsolete routine.  PC/SC has replaced it with
        //          SCardStatus.
        //
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 756
        #region SCardStatusA function
        /// <inheritdoc cref="SCardStatus"/>
        public static unsafe int SCardStatusA(
            SCARDHANDLE hCard,
            [Optional] LPMSTR mszReaderNames,
            [Optional] ref int pcchReaderLen,
            [Optional] out SCARD_READER_STATE pdwState,
            [Optional] out SCARD_PROTOCOL_FLAGS pdwProtocol,
            [Optional] Span<byte> pbAtr,
            [Optional] out int pcbAtrLen
            )
        {
            pcbAtrLen = pbAtr.Length;
            fixed (byte* ptrAtr = pbAtr)
                return SCardStatusA(
                    hCard,
                    mszReaderNames,
                    ref pcchReaderLen,
                    out pdwState,
                    out pdwProtocol,
                    ptrAtr,
                    ref pcbAtrLen
                    );
        }
        /// <inheritdoc cref="SCardStatusA"/>
        public static unsafe int SCardStatusA(
            SCARDHANDLE hCard,
            [Optional] out LPMSTR mszReaderNames,
            [Optional] out int pcchReaderLen,
            [Optional] out SCARD_READER_STATE pdwState,
            [Optional] out SCARD_PROTOCOL_FLAGS pdwProtocol,
            [Optional] out Span<byte> pbAtr
            )
        {
            pcchReaderLen = SCARD_AUTOALLOCATE;
            void* ptrAtr;
            int pcbAtrLen = SCARD_AUTOALLOCATE;
            int scard_status;
            fixed (void* pmszReaderName = &mszReaderNames)
                scard_status = SCardStatusA(
                    hCard,
                    Pointer.Create<LPMSTR>(pmszReaderName),
                    ref pcchReaderLen,
                    out pdwState,
                    out pdwProtocol,
                    (byte*)&ptrAtr,
                    ref pcbAtrLen
                    );
            pbAtr = new Span<byte>(ptrAtr, pcbAtrLen);
            return scard_status;
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        private static extern unsafe int SCardStatusA(
            [In] SCARDHANDLE hCard,
            [Optional] LPMSTR mszReaderNames,
            [Optional] ref int pcchReaderLen,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_READER_STATE pdwState,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_PROTOCOL_FLAGS pdwProtocol,
            [Optional] byte* pbAtr,
            [Optional] ref int pcbAtrLen
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 769
        #region SCardStatusW function
        /// <inheritdoc cref="SCardStatus"/>
        public static unsafe int SCardStatusW(
            SCARDHANDLE hCard,
            [Optional] LPMWSTR mszReaderNames,
            [Optional] ref int pcchReaderLen,
            [Optional] out SCARD_READER_STATE pdwState,
            [Optional] out SCARD_PROTOCOL_FLAGS pdwProtocol,
            [Optional] Span<byte> pbAtr,
            [Optional] out int pcbAtrLen
            )
        {
            pcbAtrLen = pbAtr.Length;
            fixed (byte* ptrAtr = pbAtr)
                return SCardStatusW(
                    hCard,
                    mszReaderNames,
                    ref pcchReaderLen,
                    out pdwState,
                    out pdwProtocol,
                    ptrAtr,
                    ref pcbAtrLen
                    );
        }
        /// <inheritdoc cref="SCardStatusW"/>
        public static unsafe int SCardStatusW(
            SCARDHANDLE hCard,
            [Optional] out LPMWSTR mszReaderNames,
            [Optional] out int pcchReaderLen,
            [Optional] out SCARD_READER_STATE pdwState,
            [Optional] out SCARD_PROTOCOL_FLAGS pdwProtocol,
            [Optional] out Span<byte> pbAtr
            )
        {
            pcchReaderLen = SCARD_AUTOALLOCATE;
            void* ptrAtr;
            int pcbAtrLen = SCARD_AUTOALLOCATE;
            int scard_status;
            fixed (void* pmszReaderName = &mszReaderNames)
                scard_status = SCardStatusW(
                    hCard,
                    Pointer.Create<LPMWSTR>(pmszReaderName),
                    ref pcchReaderLen,
                    out pdwState,
                    out pdwProtocol,
                    (byte*)&ptrAtr,
                    ref pcbAtrLen
                    );
            pbAtr = new Span<byte>(ptrAtr, pcbAtrLen);
            return scard_status;
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        private static extern unsafe int SCardStatusW(
            [In] SCARDHANDLE hCard,
            [Optional] LPMWSTR mszReaderNames,
            [Optional] ref int pcchReaderLen,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_READER_STATE pdwState,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_PROTOCOL_FLAGS pdwProtocol,
            [Optional] byte* pbAtr,
            [Optional] ref int pcbAtrLen
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 782
        #region SCardStatus function
        /// <summary>
        /// The <see cref="SCardStatus"/> function provides the current status of a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> in a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a>. You can call it any time after a successful call to <see cref="SCardConnect"/> and before a successful call to <see cref="SCardDisconnect"/>. It does not affect the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">state</a> of the reader or <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader driver</a>.
        /// </summary>
        /// <param name="hCard">Reference value returned from <see cref="SCardConnect"/>.</param>
        /// <param name="mszReaderNames">List of display names (multiple string) by which the currently connected reader is known.</param>
        /// <param name="pcchReaderLen">
        /// <para>On input, supplies the length of the <paramref name="mszReaderNames"/> buffer.</para>
        /// <para>On output, receives the actual length (in characters) of the reader name list, including the trailing terminating character. If this buffer length is specified as <see cref="SCARD_AUTOALLOCATE"/>, then <paramref name="mszReaderNames"/> is converted to a pointer to a byte pointer, and it receives the address of a block of memory that contains the multiple-string structure.</para>
        /// </param>
        /// <param name="pdwState">Current <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">state</a> of the smart card in the reader. Upon success, it receives one of the state indicators.</param>
        /// <param name="pdwProtocol">Current protocol, if any. The returned value is meaningful only if the returned value of <paramref name="pdwState"/> is <see cref="SCARD_READER_STATE.SCARD_SPECIFIC"/>.</param>
        /// <param name="pbAtr">A buffer that receives the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">ATR string</a> from the currently inserted card, if available.</param>
        /// <param name="pcbAtrLen">On output, receives the number of bytes in the ATR string (32 bytes maximum).</param>
        /// <returns>
        /// <para>If the function successfully provides the current status of a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> in a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a>, the return value is <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="SCardStatus"/> function is a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> and <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a> access function. For information about other access functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-and-reader-access-functions">Smart Card and Reader Access Functions</a>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardstatusw">SCardStatusW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardConnect"/>
        /// <seealso cref="SCardDisconnect"/>
        public static unsafe int SCardStatus(
            SCARDHANDLE hCard,
            [Optional] LPMTSTR mszReaderNames,
            [Optional] ref int pcchReaderLen,
            [Optional] out SCARD_READER_STATE pdwState,
            [Optional] out SCARD_PROTOCOL_FLAGS pdwProtocol,
            [Optional] Span<byte> pbAtr,
            [Optional] out int pcbAtrLen
            )
        {
            pcbAtrLen = pbAtr.Length;
            fixed (byte* ptrAtr = pbAtr)
                return SCardStatus(
                    hCard,
                    mszReaderNames,
                    ref pcchReaderLen,
                    out pdwState,
                    out pdwProtocol,
                    ptrAtr,
                    ref pcbAtrLen
                    );
        }
        /// <inheritdoc cref="SCardStatus"/>
        public static unsafe int SCardStatus(
            SCARDHANDLE hCard,
            [Optional] out LPMTSTR mszReaderNames,
            [Optional] out int pcchReaderLen,
            [Optional] out SCARD_READER_STATE pdwState,
            [Optional] out SCARD_PROTOCOL_FLAGS pdwProtocol,
            [Optional] out Span<byte> pbAtr
            )
        {
            pcchReaderLen = SCARD_AUTOALLOCATE;
            void* ptrAtr;
            int pcbAtrLen = SCARD_AUTOALLOCATE;
            int scard_status;
            fixed (void* pmszReaderName = &mszReaderNames)
                scard_status = SCardStatus(
                    hCard,
                    Pointer.Create<LPMTSTR>(pmszReaderName),
                    ref pcchReaderLen,
                    out pdwState,
                    out pdwProtocol,
                    (byte*)&ptrAtr,
                    ref pcbAtrLen
                    );
            pbAtr = new Span<byte>(ptrAtr, pcbAtrLen);
            return scard_status;
        }
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static extern unsafe
#else
        private static unsafe
#endif // !NETSTANDARD1_3
        int SCardStatus(
            [In] SCARDHANDLE hCard,
            [Optional] LPMTSTR mszReaderNames,
            [Optional] ref int pcchReaderLen,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_READER_STATE pdwState,
            [MarshalAs(UnmanagedType.U4)]
            out SCARD_PROTOCOL_FLAGS pdwProtocol,
            [Optional] byte* pbAtr,
            [Optional] ref int pcbAtrLen
            )
#if !NETSTANDARD1_3
            ;
#else
            => Marshal.SystemDefaultCharSize switch
            {
                1 => SCardStatusA(hCard,
                    Pointer.Create<LPMSTR>(mszReaderNames.Pointer),
                    ref pcchReaderLen, out pdwState, out pdwProtocol,
                    pbAtr, ref pcbAtrLen),
                2 => SCardStatusW(hCard,
                    Pointer.Create<LPMWSTR>(mszReaderNames.Pointer),
                    ref pcchReaderLen, out pdwState, out pdwProtocol,
                    pbAtr, ref pcbAtrLen),
                _ => throw new PlatformNotSupportedException()
            };
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 788
        #region SCardTransmit function
        /// <summary>
        /// The <see cref="SCardTransmit"/> function sends a service request to the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> and expects to receive data back from the card.
        /// </summary>
        /// <param name="hCard">A reference value returned from teh <see cref="SCardConnect"/> function.</param>
        /// <param name="pioSendPci">
        /// <para>The protocol header structure for the instruction. This buffer is in the format of an <see cref="SCARD_IO_REQUEST"/> structure, followed by the specific protocol control information (PCI).</para>
        /// <para>For the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/t-gly">T=0</a>, <a href="https://docs.microsoft.com/windows/desktop/SecGloss/t-gly">T=1</a>, and Raw protocols, the PCI structure is constant. The <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card subsystem</a> supplies a global T=0, T=1, or Raw PCI structure, which you can reference by using the symbols <see cref="SCARD_PCI_T0"/>, <see cref="SCARD_PCI_T1"/>, and <see cref="SCARD_PCI_RAW"/> respectively.</para>
        /// </param>
        /// <param name="pbSendBuffer">The actual data to be written to the card.</param>
        /// <param name="pioRecvPci">The protocol header structure for the instruction, followed by a buffer in which to receive any returned protocol control information (PCI) specific to the protocol in use. This parameter can be optional if no PCI is returned.</param>
        /// <param name="pbRecvBuffer">
        /// <para>The data returned from the card.</para>
        /// <para>For T=0, the data is immediately followed by the SW1 and SW2 status bytes. If no data is returned from the card, then this buffer will only contain the SW1 and SW2 status bytes.</para>
        /// </param>
        /// <param name="pcbRecvLength">Receives the actual number of bytes received from the smart card.</param>
        /// <returns>
        /// <para>If the function successfully sends a service request to the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a>, the return value is <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="SCardTransmit"/> function is a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> and <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a> access function. For information about other access functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/smart-card-and-reader-access-functions">Smart Card and Reader Access Functions</a>.</para>
        /// <para>For the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/t-gly">T=0 protocol</a>, the data received back are the SW1 and SW2 status codes, possibly preceded by response data.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardtransmit">SCardTransmit function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCARD_IO_REQUEST"/>
        /// <seealso cref="SCardConnect"/>
        public static unsafe int SCardTransmit(
            SCARDHANDLE hCard,
            in SCARD_IO_REQUEST pioSendPci,
            ReadOnlySpan<byte> pbSendBuffer,
            [Optional] ref SCARD_IO_REQUEST pioRecvPci,
            Span<byte> pbRecvBuffer,
            out int pcbRecvLength
            )
        {
            pcbRecvLength = pbRecvBuffer.Length;
            fixed (byte* ptrSendBuffer = pbSendBuffer)
            fixed (byte* ptrRecvBuffer = pbRecvBuffer)
                return SCardTransmit(
                    hCard,
                    pioSendPci,
                    ptrSendBuffer,
                    pbSendBuffer.Length,
                    ref pioRecvPci,
                    ptrRecvBuffer,
                    ref pcbRecvLength
                    );
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe int SCardTransmit(
            [In] SCARDHANDLE hCard,
            in SCARD_IO_REQUEST pioSendPci,
            byte* pbSendBuffer,
            [In] int cbSendLength,
            [Optional] ref SCARD_IO_REQUEST pioRecvPci,
            byte* pbRecvBuffer,
            ref int pcbRecvLength
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 798
        #region SCardGetTransmitCount function
        /// <summary>
        /// The <see cref="SCardGetTransmitCount"/> function retrieves the number of transmit operations that have completed since the specified card reader was inserted.
        /// </summary>
        /// <param name="hCard">A handle to a smart card obtained from a previous call to <see cref="SCardConnect"/>.</param>
        /// <param name="pcTransmitCount">The number of transmit operations that have completed since the specified card reader was inserted.</param>
        /// <returns>
        /// <para>If the function succeeds, it returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows Vista [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2008 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardgettransmitcount">SCardGetTransmitCount function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardGetTransmitCount(
            [In] SCARDHANDLE hCard,
            out int pcTransmitCount
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 805
        //
        ////////////////////////////////////////////////////////////////////////////////
        //
        //  Reader Control Routines
        //
        //      The following services provide for direct, low-level manipulation of the
        //      reader by the calling application allowing it control over the
        //      attributes of the communications with the card.
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 815
        #region SCardControl function
        /// <summary>
        /// The <see cref="SCardControl"/> function gives you direct control of the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a>. You can call it any time after a successful call to <see cref="SCardConnect"/> and before a successful call to <see cref="SCardDisconnect"/>. The effect on the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">state</a> of the reader depends on the control code.
        /// </summary>
        /// <param name="hCard">Reference value returned from <see cref="SCardConnect"/>.</param>
        /// <param name="dwControlCode">Control code for the operation. This value identifies the specific operation to be performed.</param>
        /// <param name="lpInBuffer">A buffer that contains the data required to perform the operation. This parameter can be an empty span if the <paramref name="dwControlCode"/> parameter specifies an operation that does not require input data.</param>
        /// <param name="lpOutBuffer">A buffer that receives the operation's output data. This parameter can be an empty span if the <paramref name="dwControlCode"/> parameter specifies an operation that does not produce output data.</param>
        /// <param name="lpBytesReturned">Receives the size, in bytes, of the data stored into the buffer pointed to by <paramref name="lpOutBuffer"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, it returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// The <see cref="SCardControl"/> function is a direct card access function. For more information on other direct access functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/direct-card-access-functions">Direct Card Access Functions</a>.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardcontrol">SCardControl function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardConnect"/>
        /// <seealso cref="SCardDisconnect"/>
        public static unsafe int SCardControl(
            SCARDHANDLE hCard,
            int dwControlCode,
            ReadOnlySpan<byte> lpInBuffer,
            Span<byte> lpOutBuffer,
            out int lpBytesReturned
            )
        {
            fixed (byte* ptrInBuffer = lpInBuffer)
            fixed (byte* ptrOutBuffer = lpOutBuffer)
                return SCardControl(
                    hCard,
                    dwControlCode,
                    ptrInBuffer,
                    lpInBuffer.Length,
                    ptrOutBuffer,
                    lpOutBuffer.Length,
                    out lpBytesReturned
                    );
        }

        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe int SCardControl(
            [In] SCARDHANDLE hCard,
            [In] int dwControlCode,
            [In] byte* lpInBuffer,
            [In] int cbInBufferSize,
            [Out] byte* lpOutBuffer,
            [In] int cbOutBufferSize,
            out int lpBytesReturned
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 825
        #region SCardGetAttrib function
        /// <summary>
        /// The <see cref="SCardGetAttrib"/> function retrieves the current reader attributes for the given handle. It does not affect the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">state</a> of the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a>, driver, or <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">card</a>.
        /// </summary>
        /// <param name="hCard">Reference value returned from <see cref="SCardConnect"/>.</param>
        /// <param name="dwAttrId">Identifier for the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">attribute</a> to get. Note that vendors may not support all attributes.</param>
        /// <param name="pbAttr">A buffer that receives the attribute whose ID is supplied in <paramref name="dwAttrId"/>. If this value is an empty span, <see cref="SCardGetAttrib"/> writes the length of the buffer that would have been returned if this parameter had not been an empty span to <paramref name="pcbAttrLen"/>, and returns a success code.</param>
        /// <param name="pcbAttrLen">Receives the actual length of the received attribute.</param>
        /// <returns>
        /// This function returns different values depending on whether it succeeds or fails.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term>Success</term><description><see cref=" SCARD_S_SUCCESS"/>.</description></item>
        /// <item><term>Attribute value not supported.</term><description><see cref="WinErrorConstants.ERROR_NOT_SUPPORTED"/>.</description></item>
        /// <item><term>Other Failure</term><description>An error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// The <see cref="SCardGetAttrib"/> function is a direct card access function. For more information on other direct access functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/direct-card-access-functions">Direct Card Access Functions</a>.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardgetattrib">SCardGetAttrib function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardConnect"/>
        /// <seealso cref="SCardFreeMemory"/>
        /// <seealso cref="SCardSetAttrib"/>
        public static unsafe int SCardGetAttrib(
            SCARDHANDLE hCard,
            SCARD_ATTR_VALUE dwAttrId,
            [Optional] Span<byte> pbAttr,
            out int pcbAttrLen
            )
        {
            pcbAttrLen = pbAttr.Length;
            fixed (byte* ptrAttr = pbAttr)
                return SCardGetAttrib(
                    hCard,
                    dwAttrId,
                    ptrAttr,
                    ref pcbAttrLen
                    );
        }
        /// <inheritdoc cref="SCardGetAttrib"/>
        public static unsafe int SCardGetAttrib(
            SCARDHANDLE hCard,
            SCARD_ATTR_VALUE dwAttrId,
            out ReadOnlySpan<byte> pbAttr
            )
        {
            int scard_status;
            int pcbAttrLen = SCARD_AUTOALLOCATE;
            void* ptrAttr;
            scard_status = SCardGetAttrib(
                hCard,
                dwAttrId,
                (byte*)&ptrAttr,
                ref pcbAttrLen
                );
            pbAttr = new ReadOnlySpan<byte>(ptrAttr, pcbAttrLen);
            return scard_status;
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe int SCardGetAttrib(
            [In] SCARDHANDLE hCard,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_ATTR_VALUE dwAttrId,
            [Out, Optional] byte* pbAttr,
            ref int pcbAttrLen
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 831
        #region SCardGetReaderCapabilities macro
        //
        // NOTE:    The routine SCardGetAttrib's name differs from the PC/SC definition.
        //          It should be:
        //
        //              extern WINSCARDAPI LONG WINAPI
        //              SCardGetReaderCapabilities(
        //                  _In_    SCARDHANDLE hCard,
        //                  _In_    DWORD dwTag,
        //                  _Out_   LPBYTE pbAttr,
        //                  _Inout_ LPDWORD pcbAttrLen);
        //
        //          Here's a work-around MACRO:
        /// <inheritdoc cref="SCardGetAttrib"/>
        public static int SCardGetReaderCapabilities(
            SCARDHANDLE hCard,
            SCARD_ATTR_VALUE dwAttrId,
            Span<byte> pbAttr,
            out int pcbAttrLen
            ) => SCardGetAttrib(hCard, dwAttrId, pbAttr, out pcbAttrLen);
        /// <inheritdoc cref="SCardGetAttrib"/>
        public static int SCardGetReaderCapabilities(
            SCARDHANDLE hCard,
            SCARD_ATTR_VALUE dwAttrId,
            out ReadOnlySpan<byte> pbAttr
            ) => SCardGetAttrib(hCard, dwAttrId, out pbAttr);
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 845
        #region SCardSetAttrib function
        /// <summary>
        /// The <see cref="SCardSetAttrib"/> function sets the given <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a> attribute for the given handle. It does not affect the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">state</a> of the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a>, <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader driver</a>, or <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a>. Not all attributes are supported by all readers (nor can they be set at all times) as many of the attributes are under direct control of the transport protocol.
        /// </summary>
        /// <param name="hCard">Reference value returned from <see cref="SCardConnect"/>.</param>
        /// <param name="dwAttrId">Identifier for the attribute to set. The values are write-only. Note that vendors may not support all attributes.</param>
        /// <param name="pbAttr">A buffer that supplies the attribute whose ID is supplied in <paramref name="dwAttrId"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, it returns <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// The <see cref="SCardSetAttrib"/> function is a direct card access function. For more information on other direct access functions, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/direct-card-access-functions">Direct Card Access Functions</a>.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardsetattrib">SCardSetAttrib function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SCardConnect"/>
        /// <seealso cref="SCardGetAttrib"/>
        public static unsafe int SCardSetAttrib(
            SCARDHANDLE hCard,
            SCARD_ATTR_VALUE dwAttrId,
            ReadOnlySpan<byte> pbAttr
            )
        {
            fixed (byte* ptrAttr = pbAttr)
                return SCardSetAttrib(
                    hCard,
                    dwAttrId,
                    ptrAttr,
                    pbAttr.Length
                    );
        }
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe int SCardSetAttrib(
            [In] SCARDHANDLE hCard,
            [In, MarshalAs(UnmanagedType.U4)] SCARD_ATTR_VALUE dwAttrId,
            [In] byte* pbAttr,
            [In] int cbAttrLen
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 851
        #region SCardSetReaderCapabilities macro
        //
        // NOTE:    The routine SCardSetAttrib's name differs from the PC/SC definition.
        //          It should be:
        //
        //              extern WINSCARDAPI LONG WINAPI
        //              SCardSetReaderCapabilities(
        //                  _In_    SCARDHANDLE hCard,
        //                  _In_    DWORD dwTag,
        //                  _In_    LPCBYTE pbAttr,
        //                  _In_    DWORD cbAttrLen);
        //
        //          Here's a work-around MACRO:
        /// <inheritdoc cref="SCardSetAttrib"/>
        public static int SCardSetReaderCapabilities(
            SCARDHANDLE hCard,
            SCARD_ATTR_VALUE dwAttrId,
            ReadOnlySpan<byte> pbAttr
            ) => SCardSetAttrib(hCard, dwAttrId, pbAttr);
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 866
        //
        ////////////////////////////////////////////////////////////////////////////////
        //
        //  Smart Card Dialog definitions
        //
        //      The following section contains structures and  exported function
        //      declarations for the Smart Card Common Dialog dialog.
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 1141
        //
        // SCardUIDlgSelectCard replaces GetOpenCardName
        //
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 1145
        #region SCardUIDlgSelectCardA function
        /// <inheritdoc cref="SCardUIDlgSelectCard"/>
        [DllImport(SCardDlg, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardUIDlgSelectCardA(
            ref OPENCARDNAME_EXA Arg1
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 1148
        #region SCardUIDlgSelectCardW function
        /// <inheritdoc cref="SCardUIDlgSelectCard"/>
        [DllImport(SCardDlg, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardUIDlgSelectCardW(
            ref OPENCARDNAME_EXW Arg1
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 1151
        #region SCardUIDlgSelectCardW function
        /// <summary>
        /// The <see cref="SCardUIDlgSelectCard"/> function displays the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> <strong>Select Card</strong> dialog box.
        /// </summary>
        /// <param name="pDlgStruc">Reference to the <see cref="OPENCARDNAME_EX"/> structure for the <strong>Select Card</strong> dialog box.</param>
        /// <returns>
        /// <para>If the function successfully displays the <strong>Select Card</strong> dialog box, the return value is  <see cref="SCARD_S_SUCCESS"/>.</para>
        /// <para>If the function fails, it returns an error code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// The <see cref="SCardUIDlgSelectCard"/> function provides a method for connecting to a specific <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a>. When called, this function performs a search for appropriate smart cards matching the <see cref="OPENCARD_SEARCH_CRITERIA"/> member specified by the <paramref name="pDlgStruc"/> parameter. Depending on the <see cref="OPENCARDNAME_EX.dwFlags"/> member of <paramref name="pDlgStruc"/>, this function takes the following actions.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Action</description></listheader>
        /// <item><term><see cref="SC_DLG_FLAGS.SC_DLG_FORCE_UI"/></term><description>Connects to the card selected by the user from the smart card Select Card dialog box.</description></item>
        /// <item><term><see cref="SC_DLG_FLAGS.SC_DLG_MINIMAL_UI"/></term><description>Selects the smart card if only one smart card meets the criteria, or returns information about the user's selection if more than one smart card meets the criteria.</description></item>
        /// <item><term><see cref="SC_DLG_FLAGS.SC_DLG_NO_UI"/></term><description>Selects the first available card.</description></item>
        /// </list>
        /// </para>
        /// <para>This function replaces <see cref="GetOpenCardName"/>. The <see cref="GetOpenCardName"/> function is maintained for backward compatibility with version 1.0 of the Microsoft Smart Card Base Components.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scarduidlgselectcardw">SCardUIDlgSelectCardW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="OPENCARDNAME_EX"/>
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern
#else
        public static unsafe
#endif // !NETSTANDARD1_3
        int SCardUIDlgSelectCard(
            ref OPENCARDNAME_EX pDlgStruc
            )
#if !NETSTANDARD1_3
            ;
#else
        {
            fixed (void* ptrDlgStruc = &pDlgStruc)
                return Marshal.SystemDefaultCharSize switch
                {
                    1 => SCardUIDlgSelectCardA(
                        ref Unsafe.AsRef<OPENCARDNAME_EXA>(ptrDlgStruc)
                        ),
                    2 => SCardUIDlgSelectCardW(
                        ref Unsafe.AsRef<OPENCARDNAME_EXW>(ptrDlgStruc)
                        ),
                    _ => throw new PlatformNotSupportedException()
                };
        }
#endif // !NETSTANDARD1_3
        #endregion
    }
}

using System;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.SCardErr;
using THNETII.WinApi.Native.WinError;
using THNETII.WinApi.Native.WinSmcrd;

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
        /// <inheritdoc cref="SCardListReaderGroups(SCARDCONTEXT, LPTSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardListReaderGroupsA(
            [In] SCARDCONTEXT hContext,
            [In, Optional] LPSTR mszGroups,
            ref int pcchGroups
            );

        /// <inheritdoc cref="SCardListReaderGroupsA(SCARDCONTEXT, LPSTR, ref int)"/>
        public static unsafe int SCardListReaderGroupsA(
            SCARDCONTEXT hContext,
            out LPSTR mszGroups,
            out int pcchGroups
            )
        {
            pcchGroups = SCARD_AUTOALLOCATE;
            fixed (void* pmszGroups = &mszGroups)
                return SCardListReaderGroupsA(
                    hContext,
                    Pointer.Create<LPSTR>(pmszGroups),
                    ref pcchGroups
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 154
        #region SCardListReaderGroupsW function
        /// <inheritdoc cref="SCardListReaderGroups(SCARDCONTEXT, LPTSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardListReaderGroupsW(
            [In] SCARDCONTEXT hContext,
            [In, Optional] LPWSTR mszGroups,
            ref int pcchGroups
            );

        /// <inheritdoc cref="SCardListReaderGroupsW(SCARDCONTEXT, LPWSTR, ref int)"/>
        public static unsafe int SCardListReaderGroupsW(
            SCARDCONTEXT hContext,
            out LPWSTR mszGroups,
            out int pcchGroups
            )
        {
            pcchGroups = SCARD_AUTOALLOCATE;
            fixed (void* pmszGroups = &mszGroups)
                return SCardListReaderGroupsW(
                    hContext,
                    Pointer.Create<LPWSTR>(pmszGroups),
                    ref pcchGroups
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 160
        #region SCardListReaderGroups function
#if !NETSTANDARD1_3
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
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardListReaderGroups(
            [In] SCARDCONTEXT hContext,
            [In, Optional] LPTSTR mszGroups,
            ref int pcchGroups
            );

        /// <inheritdoc cref="SCardListReaderGroups(SCARDCONTEXT, LPTSTR, ref int)"/>
        public static unsafe int SCardListReaderGroups(
            SCARDCONTEXT hContext,
            out LPTSTR mszGroups,
            out int pcchGroups
            )
        {
            pcchGroups = SCARD_AUTOALLOCATE;
            fixed (void* pmszGroups = &mszGroups)
                return SCardListReaderGroups(
                    hContext,
                    Pointer.Create<LPTSTR>(pmszGroups),
                    ref pcchGroups
                    );
        }
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 165
        #region SCardListReadersA function
        /// <inheritdoc cref="SCardListReaders(SCARDCONTEXT, LPCTSTR, LPTSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardListReadersA(
            [In] SCARDCONTEXT hContext,
            [In, Optional] LPCSTR mszGroups,
            LPSTR mszReaders,
            ref int pcchReaders
            );

        /// <inheritdoc cref="SCardListReadersA(SCARDCONTEXT, LPCSTR, LPSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SCardListReadersA(
            [In] SCARDCONTEXT hContext,
            [In, Optional] string mszGroups,
            LPSTR mszReaders,
            ref int pcchReaders
            );

        /// <inheritdoc cref="SCardListReadersA(SCARDCONTEXT, LPCSTR, LPSTR, ref int)"/>
        public static unsafe int SCardListReadersA(
            SCARDCONTEXT hContext,
            LPCSTR mszGroups,
            out LPSTR mszReaders,
            out int pcchReaders
            )
        {
            pcchReaders = SCARD_AUTOALLOCATE;
            fixed (void* pmszReaders = &mszReaders)
                return SCardListReadersA(
                    hContext,
                    mszGroups,
                    Pointer.Create<LPSTR>(pmszReaders),
                    ref pcchReaders
                    );
        }

        /// <inheritdoc cref="SCardListReadersA(SCARDCONTEXT, LPCSTR, LPSTR, ref int)"/>
        public static unsafe int SCardListReadersA(
            SCARDCONTEXT hContext,
            string mszGroups,
            out LPSTR mszReaders,
            out int pcchReaders
            )
        {
            pcchReaders = SCARD_AUTOALLOCATE;
            fixed (void* pmszReaders = &mszReaders)
                return SCardListReadersA(
                    hContext,
                    mszGroups,
                    Pointer.Create<LPSTR>(pmszReaders),
                    ref pcchReaders
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 175
        #region SCardListReadersW function
        /// <inheritdoc cref="SCardListReaders(SCARDCONTEXT, LPCTSTR, LPTSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardListReadersW(
            [In] SCARDCONTEXT hContext,
            [In, Optional] LPCWSTR mszGroups,
            LPWSTR mszReaders,
            ref int pcchReaders
            );

        /// <inheritdoc cref="SCardListReadersW(SCARDCONTEXT, LPCWSTR, LPWSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        public static extern int SCardListReadersW(
            [In] SCARDCONTEXT hContext,
            [In, Optional] string mszGroups,
            LPWSTR mszReaders,
            ref int pcchReaders
            );

        /// <inheritdoc cref="SCardListReadersW(SCARDCONTEXT, LPCWSTR, LPWSTR, ref int)"/>
        public static unsafe int SCardListReadersW(
            SCARDCONTEXT hContext,
            LPCWSTR mszGroups,
            out LPWSTR mszReaders,
            out int pcchReaders
            )
        {
            pcchReaders = SCARD_AUTOALLOCATE;
            fixed (void* pmszReaders = &mszReaders)
                return SCardListReadersW(
                    hContext,
                    mszGroups,
                    Pointer.Create<LPWSTR>(pmszReaders),
                    ref pcchReaders
                    );
        }

        /// <inheritdoc cref="SCardListReadersW(SCARDCONTEXT, LPCWSTR, LPWSTR, ref int)"/>
        public static unsafe int SCardListReadersW(
            SCARDCONTEXT hContext,
            string mszGroups,
            out LPWSTR mszReaders,
            out int pcchReaders
            )
        {
            pcchReaders = SCARD_AUTOALLOCATE;
            fixed (void* pmszReaders = &mszReaders)
                return SCardListReadersW(
                    hContext,
                    mszGroups,
                    Pointer.Create<LPWSTR>(pmszReaders),
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
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardListReaders(
            [In] SCARDCONTEXT hContext,
            [In, Optional] LPCTSTR mszGroups,
            LPTSTR mszReaders,
            ref int pcchReaders
            );

#if !NETSTANDARD1_3
        /// <inheritdoc cref="SCardListReaders(SCARDCONTEXT, LPCTSTR, LPTSTR, ref int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardListReaders(
            [In] SCARDCONTEXT hContext,
            [In, Optional] string mszGroups,
            LPTSTR mszReaders,
            ref int pcchReaders
            );
#endif // !NETSTANDARD1_3

        /// <inheritdoc cref="SCardListReaders(SCARDCONTEXT, LPCTSTR, LPTSTR, ref int)"/>
        public static unsafe int SCardListReaders(
            SCARDCONTEXT hContext,
            LPCTSTR mszGroups,
            out LPTSTR mszReaders,
            out int pcchReaders
            )
        {
            pcchReaders = SCARD_AUTOALLOCATE;
            fixed (void* pmszReaders = &mszReaders)
                return SCardListReaders(
                    hContext,
                    mszGroups,
                    Pointer.Create<LPTSTR>(pmszReaders),
                    ref pcchReaders
                    );
        }

#if !NETSTANDARD1_3
        /// <inheritdoc cref="SCardListReaders(SCARDCONTEXT, LPCTSTR, LPTSTR, ref int)"/>
        public static unsafe int SCardListReaders(
            SCARDCONTEXT hContext,
            string mszGroups,
            out LPTSTR mszReaders,
            out int pcchReaders
            )
        {
            pcchReaders = SCARD_AUTOALLOCATE;
            fixed (void* pmszReaders = &mszReaders)
                return SCardListReaders(
                    hContext,
                    mszGroups,
                    Pointer.Create<LPTSTR>(pmszReaders),
                    ref pcchReaders
                    );
        }
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 189
        #region SCardListCardsA function
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe int SCardListCardsA(
            [In] SCARDCONTEXT hContext,
            [In, Optional] byte* pbAtr,
            [In, Optional] Guid* rgquidInterfaces,
            [In] int cguidInterfaceCount,
            LPSTR mszCards,
            ref int pcchCards
            );

        /// <inheritdocc cref="SCardListCards(SCARDCONTEXT, ReadOnlySpan{byte}, ReadOnlySpan{Guid}, LPTSTR, ref int)"/>
        public static unsafe int SCardListCardsA(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            LPSTR mszCards,
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

        /// <inheritdocc cref="SCardListCardsA(SCARDCONTEXT, ReadOnlySpan{byte}, ReadOnlySpan{Guid}, LPSTR, ref int)"/>
        public static unsafe int SCardListCardsA(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            out LPSTR mszCards,
            out int pcchCards
            )
        {
            pcchCards = SCARD_AUTOALLOCATE;
            fixed (void* pmszCards = &mszCards)
                return SCardListCardsA(
                    hContext,
                    pbAtr,
                    rgquidInterfaces,
                    Pointer.Create<LPSTR>(pmszCards),
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
            LPWSTR mszCards,
            ref int pcchCards
            );

        /// <inheritdocc cref="SCardListCards(SCARDCONTEXT, ReadOnlySpan{byte}, ReadOnlySpan{Guid}, LPTSTR, ref int)"/>
        public static unsafe int SCardListCardsW(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            LPWSTR mszCards,
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

        /// <inheritdocc cref="SCardListCardsW(SCARDCONTEXT, ReadOnlySpan{byte}, ReadOnlySpan{Guid}, LPWSTR, ref int)"/>
        public static unsafe int SCardListCardsW(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            out LPWSTR mszCards,
            out int pcchCards
            )
        {
            pcchCards = SCARD_AUTOALLOCATE;
            fixed (void* pmszCards = &mszCards)
                return SCardListCardsW(
                    hContext,
                    pbAtr,
                    rgquidInterfaces,
                    Pointer.Create<LPWSTR>(pmszCards),
                    ref pcchCards
                    );
        }
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 211
        #region SCardListCards function
#if !NETSTANDARD1_3
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static extern unsafe int SCardListCards(
            [In] SCARDCONTEXT hContext,
            [In, Optional] byte* pbAtr,
            [In, Optional] Guid* rgquidInterfaces,
            [In] int cguidInterfaceCount,
            LPTSTR mszCards,
            ref int pcchCards
            );

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
            LPTSTR mszCards,
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

        /// <inheritdocc cref="SCardListCards(SCARDCONTEXT, ReadOnlySpan{byte}, ReadOnlySpan{Guid}, LPTSTR, ref int)"/>
        public static unsafe int SCardListCards(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            out LPTSTR mszCards,
            out int pcchCards
            )
        {
            pcchCards = SCARD_AUTOALLOCATE;
            fixed (void* pmszCards = &mszCards)
                return SCardListCards(
                    hContext,
                    pbAtr,
                    rgquidInterfaces,
                    Pointer.Create<LPTSTR>(pmszCards),
                    ref pcchCards
                    );
        }
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 216
        #region SCardListCardTypes function
        /// <inheritdoc cref="SCardListCards" />
        public static int SCardListCardTypes(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            LPTSTR mszCards,
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
                        Pointer.Create<LPSTR>(mszCards.Pointer),
                        ref pcchCards
                        );
                case 2:
                    return SCardListCardsW(
                        hContext,
                        pbAtr,
                        rgquidInterfaces,
                        Pointer.Create<LPWSTR>(mszCards.Pointer),
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

        /// <inheritdoc cref="SCardListCards" />
        public static int SCardListCardTypes(
            SCARDCONTEXT hContext,
            ReadOnlySpan<byte> pbAtr,
            ReadOnlySpan<Guid> rgquidInterfaces,
            out LPTSTR mszCards,
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
                    mszCards = Pointer.Create<LPTSTR>(lpstrCards.Pointer);
                    return error;
                case 2:
                    error = SCardListCardsW(
                        hContext,
                        pbAtr,
                        rgquidInterfaces,
                        out var lpwstrCards,
                        out pcchCards
                        );
                    mszCards = Pointer.Create<LPTSTR>(lpwstrCards.Pointer);
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
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        private static unsafe extern int SCardListInterfaces(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szCard,
            Guid* pguidInterfaces,
            ref int pcguidInterfaces
            );

        /// <summary>
        /// The <see cref="SCardListInterfaces"/> function provides a list of interfaces supplied by a given card.
        /// <para>The caller supplies the name of a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> previously introduced to the subsystem, and receives the list of interfaces supported by the card.</para>
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a> for the query. The resource manager context can be set by a previous call to <see cref="SCardEstablishContext"/>. This parameter cannot be <see langword="default"/>.</param>
        /// <param name="szCard">Name of the smart card already introduced to the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card subsystem</a>.</param>
        /// <param name="pguidInterfaces">Span of interface identifiers (<see cref="GUID"/>s) that indicate the interfaces supported by the smart card. If this value is <see langword="default"/> (an empty span), <see cref="SCardListInterfaces"/> ignores the array length supplied in <paramref name="pcguidInterfaces"/>, returning the size of the array that would have been returned if this parameter had not been an empty span to <paramref name="pcguidInterfaces"/> and a success code.</param>
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

#if !NETSTANDARD1_3
        /// <inheritdoc cref="SCardListInterfaces(SCARDCONTEXT, LPCTSTR, Span{Guid}, out int)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        private static unsafe extern int SCardListInterfaces(
            [In] SCARDCONTEXT hContext,
            [In] string szCard,
            Guid* pguidInterfaces,
            ref int pcguidInterfaces
            );

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
#endif // !NETSTANDARD1_3
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
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi)]
        public static extern int SCardGetProviderId(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szCard,
            out Guid pguidProviderId
            );

#if !NETSTANDARD1_3
        /// <inheritdoc cref="SCardGetProviderId(SCARDCONTEXT, LPCTSTR, out Guid)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardGetProviderId(
            [In] SCARDCONTEXT hContext,
            [In] string szCard,
            out Guid pguidProviderId
            );
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
#if !NETSTANDARD1_3
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
        /// <seealso cref="SCardSetCardTypeProviderName"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardGetCardTypeProviderName(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szCardName,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROVIDER_TYPE dwProviderId,
            LPTSTR szProvider,
            ref int pcchProvider
            );

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
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, EntryPoint = nameof(SCardGetCardTypeProviderName))]
        private static extern int SCardGetCardTypeProviderNameImpl(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName,
            [In, MarshalAs(UnmanagedType.U4)]
            SCARD_PROVIDER_TYPE dwProviderId,
            [Out] StringBuilder szProvider,
            ref int pcchProvider
            );

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
#endif // !NETSTANDARD1_3
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
            [In] LPCSTR szGroupName
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
#if !NETSTANDARD1_3
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
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardIntroduceReaderGroup(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szGroupName
            );

        /// <inheritdoc cref="SCardIntroduceReaderGroup" />
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardIntroduceReaderGroup(
            [In] SCARDCONTEXT hContext,
            [In] string szGroupName
            );
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
#if !NETSTANDARD1_3
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
        /// <seealso cref="SCardForgetCardType"/>
        /// <seealso cref="SCardForgetReader"/>
        /// <seealso cref="SCardIntroduceReaderGroup"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardForgetReaderGroup(
            [In] SCARDCONTEXT hContext,
            [In] LPCSTR szGroupName
            );

        /// <inheritdoc cref="SCardForgetReaderGroup"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardForgetReaderGroup(
            [In] SCARDCONTEXT hContext,
            [In] string szGroupName
            );
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
#if !NETSTANDARD1_3
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
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardIntroduceReader(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szReaderName,
            [In] LPCTSTR szDeviceName
            );

        /// <inheritdoc cref="SCardIntroduceReader"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardIntroduceReader(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName,
            [In] string szDeviceName
            );
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
#if !NETSTANDARD1_3
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
        /// <seealso cref="SCardForgetCardType"/>
        /// <seealso cref="SCardForgetReaderGroup"/>
        /// <seealso cref="SCardIntroduceReader"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardForgetReader(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName
            );
        /// <inheritdoc cref="SCardForgetReader(SCARDCONTEXT, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardForgetReader(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szReaderName
            );
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
#if !NETSTANDARD1_3
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
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardAddReaderToGroup(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName,
            [In] string szGroupName
            );
        /// <inheritdoc cref="SCardAddReaderToGroup(SCARDCONTEXT, string, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardAddReaderToGroup(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szReaderName,
            [In] LPCTSTR szGroupName
            );
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
#if !NETSTANDARD1_3
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
        /// <seealso cref="SCardForgetCardType"/>
        /// <seealso cref="SCardForgetReader"/>
        /// <seealso cref="SCardForgetReaderGroup"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardRemoveReaderFromGroup(
            [In] SCARDCONTEXT hContext,
            [In] string szReaderName,
            [In] string szGroupName
            );
        /// <inheritdoc cref="SCardRemoveReaderFromGroup(SCARDCONTEXT, string, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardRemoveReaderFromGroup(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szReaderName,
            [In] LPCTSTR szGroupName
            );
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
        private static extern unsafe int SCardIntroduceCardType(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] Guid* rgguidInterfaces,
            [In] int dwInterfaceCount,
            byte* pbAtr,
            byte* pbAtrMask,
            [In] int cbAtrLen
            );
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
        /// <para>To remove a smart card, use <see cref="SCardForgetCardType"/>.</para>
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
        /// <seealso cref="SCardForgetCardType"/>
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
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static extern unsafe int SCardIntroduceCardType(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szCardName,
            [Optional] in Guid pguidPrimaryProvider,
            [Optional] Guid* rgguidInterfaces,
            [In] int dwInterfaceCount,
            byte* pbAtr,
            byte* pbAtrMask,
            [In] int cbAtrLen
            );
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
#endif // !NETSTANDARD1_3
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
#if !NETSTANDARD1_3
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
#endif // !NETSTANDARD1_3
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
#if !NETSTANDARD1_3
        /// <summary>
        /// The <see cref="SCardSetCardTypeProviderName"/> function specifies the name of the module (dynamic link library) containing the provider for a given card name and <a href="https://docs.microsoft.com/windows/desktop/SecGloss/p-gly">provider type</a>.
        /// </summary>
        /// <param name="hContext">Handle that identifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a>. The resource manager context can be set by a previous call to <see cref="SCardEstablishContext"/>. This value can be <see langword="default"/> if the call to <see cref="SCardSetCardTypeProviderName"/> is not directed to a specific <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">context</a>.</param>
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
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardSetCardTypeProviderName(
            [In] SCARDCONTEXT hContext,
            [In] string szCardName,
            [In, MarshalAs(UnmanagedType.U4)] SCARD_PROVIDER_TYPE dwProviderId,
            [In] string szProvider
            );
        /// <inheritdoc cref="SCardSetCardTypeProviderName(SCARDCONTEXT, string, SCARD_PROVIDER_TYPE, string)"/>
        [DllImport(WinSCard, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern int SCardSetCardTypeProviderName(
            [In] SCARDCONTEXT hContext,
            [In] LPCTSTR szCardName,
            [In, MarshalAs(UnmanagedType.U4)] SCARD_PROVIDER_TYPE dwProviderId,
            [In] LPCTSTR szProvider
            );
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 455
        //
        // NOTE:    This routine is an extention to the PC/SC specifications.
        //

    }
}

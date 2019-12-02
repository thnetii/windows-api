using System;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.SCardErr;
using THNETII.WinApi.Native.WinError;

namespace THNETII.WinApi.Native.WinSCard
{
    using static NativeLibraryNames;
    using static SCardErrConstants;
    using static WinSCardConstants;

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
    }
}

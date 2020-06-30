using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.WinSmcrd;

namespace THNETII.WinApi.Native.WinSCard
{
    using static WinSCardFunctions;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 895
    //
    // OPENCARD_SEARCH_CRITERIA: In order to specify a user-extended search,
    // lpfnCheck must not be NULL.  Moreover, the connection to be made to the
    // card before performing the callback must be indicated by either providing
    // lpfnConnect and lpfnDisconnect OR by setting dwShareMode.
    // If both the connection callbacks and dwShareMode are non-NULL, the callbacks
    // will be used.
    //

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 904
    /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct OPENCARD_SEARCH_CRITERIAA
    {
        public static readonly int SizeOf = SizeOf<OPENCARD_SEARCH_CRITERIAA>.Bytes;

        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.dwStructSize"/>
        public int dwStructSize;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.lpstrGroupNames"/>
        public LPMSTR lpstrGroupNames;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.nMaxGroupNames"/>
        public int nMaxGroupNames;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.rgguidInterfaces"/>
        public Guid* rgguidInterfaces;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.cguidInterfaces"/>
        public int cguidInterfaces;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.GuidInterfaces"/>
        public Span<Guid> GuidInterfaces => new Span<Guid>(rgguidInterfaces, rgguidInterfaces is null ? 0 : cguidInterfaces);
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.lpstrCardNames"/>
        public LPMSTR lpstrCardNames;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.nMaxCardNames"/>
        public int nMaxCardNames;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.lpfnCheck"/>
        public LPOCNCHKPROC lpfnCheck;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.lpfnConnect"/>
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public LPOCNCONNPROCA lpfnConnect;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.lpfnDisconnect"/>
        public LPOCNDSCPROC lpfnDisconnect;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.pvUserData"/>
        public IntPtr pvUserData;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.dwShareMode"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_SHARE_MODE dwShareMode;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.dwPreferredProtocols"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwPreferredProtocols;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 920
    /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct OPENCARD_SEARCH_CRITERIAW
    {
        public static readonly int SizeOf = SizeOf<OPENCARD_SEARCH_CRITERIAW>.Bytes;

        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.dwStructSize"/>
        public int dwStructSize;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.lpstrGroupNames"/>
        public LPMWSTR lpstrGroupNames;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.nMaxGroupNames"/>
        public int nMaxGroupNames;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.rgguidInterfaces"/>
        public Guid* rgguidInterfaces;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.cguidInterfaces"/>
        public int cguidInterfaces;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.GuidInterfaces"/>
        public Span<Guid> GuidInterfaces => new Span<Guid>(rgguidInterfaces, rgguidInterfaces is null ? 0 : cguidInterfaces);
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.lpstrCardNames"/>
        public LPMWSTR lpstrCardNames;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.nMaxCardNames"/>
        public int nMaxCardNames;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.lpfnCheck"/>
        public LPOCNCHKPROC lpfnCheck;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.lpfnConnect"/>
        public LPOCNCONNPROCA lpfnConnect;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.lpfnDisconnect"/>
        public LPOCNDSCPROC lpfnDisconnect;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.pvUserData"/>
        public IntPtr pvUserData;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.dwShareMode"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_SHARE_MODE dwShareMode;
        /// <inheritdoc cref="OPENCARD_SEARCH_CRITERIA.dwPreferredProtocols"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwPreferredProtocols;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 936
    /// <summary>
    /// The <see cref="OPENCARD_SEARCH_CRITERIA"/> structure is used by the <see cref="SCardUIDlgSelectCard"/> function in order to recognize cards that meet the requirements set forth by the caller. You can, however, call <see cref="SCardUIDlgSelectCard"/> without using this structure.
    /// </summary>
    /// <remarks>
    /// <para><note>
    /// When you use <see cref="lpfnConnect"/>, <see cref="lpfnCheck"/>, and <see cref="lpfnDisconnect"/>, all three callback procedures should be present. Using these callbacks allows further verification that the calling application has found the appropriate card. This is the best way to ensure the appropriate card is selected. However, when using a value that is not <see langword="null"/> for <see cref="lpfnCheck"/>, either both <see cref="lpfnConnect"/> and <see cref="lpfnDisconnect"/> must not be <see langword="null"/> (and <see cref="pvUserData"/> should also be provided), or <see cref="dwShareMode"/> and <see cref="dwPreferredProtocols"/> must both be set.
    /// </note></para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/ns-winscard-opencard_search_criteriaw">OPENCARD_SEARCH_CRITERIAW structure</a></para>
    /// </remarks>
    /// <seealso cref="OPENCARDNAME_EX"/>
    /// <seealso cref="SCardUIDlgSelectCard"/>
#if !NETSTANDARD1_3
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif // !NETSTANDARD1_3
    public unsafe struct OPENCARD_SEARCH_CRITERIA
    {
        public static readonly int SizeOf = SizeOf<OPENCARD_SEARCH_CRITERIA>.Bytes;

        /// <summary>
        /// The length, in bytes, of the structure. Must not be <c>0</c> (zero).
        /// <para>Use the static <see cref="SizeOf"/> value.</para>
        /// </summary>
        public int dwStructSize;
        /// <summary>
        /// A pointer to a buffer containing null-terminated group name strings. The last string in the buffer must be terminated by two null characters. Each string is the name of a group of cards that is to be included in the search. If <see cref="lpstrGroupNames"/> is <see cref="IntPtr.Zero"/>, the default group (<c><a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">Scard$DefaultReaders</a></c>) is searched.
        /// </summary>
        public LPMTSTR lpstrGroupNames;     // OPTIONAL reader groups to include in
                                            //          search.  NULL defaults to
                                            //          SCard$DefaultReaders
        /// <summary>
        /// The maximum number of bytes (ANSI version) or characters (Unicode version) in the <see cref="lpstrGroupNames"/> string.
        /// </summary>
        public int nMaxGroupNames;
        /// <summary>
        /// Reserved for future use. An array of GUIDs that identifies the interfaces required. Set this member to <see langword="null"/>.
        /// </summary>
        public Guid* rgguidInterfaces;      // OPTIONAL requested interfaces
                                            //          supported by card's SSP
        /// <summary>
        /// Reserved for future use. The number of interfaces in the <see cref="rgguidInterfaces"/> array. Set this member to <c>0</c> (zero).
        /// </summary>
        public int cguidInterfaces;
        /// <summary>
        /// Reserved for future use. The span of GUIDs that identifies the interfaces required.
        /// </summary>
        public Span<Guid> GuidInterfaces => new Span<Guid>(rgguidInterfaces, rgguidInterfaces is null ? 0 : cguidInterfaces);
        /// <summary>
        /// A pointer to a buffer that contains null-terminated card name strings. The last string in the buffer must be terminated by two null characters. Each string is the name of a card that is to be located.
        /// </summary>
        public LPMTSTR lpstrCardNames;      // OPTIONAL requested card names; all cards w/
                                            //          matching ATRs will be accepted
        /// <summary>
        /// The maximum number of bytes (ANSI version) or characters (Unicode version) in the <see cref="lpstrGroupNames"/> string.
        /// </summary>
        public int nMaxCardNames;
        /// <summary>
        /// A pointer to the caller's card verify routine. If no special card verification is required, this pointer is <see langword="null"/>. If the card is rejected by the verify routine, <see langword="false"/> is returned, and the card will be disconnected. If the card is accepted by the verify routine, <see langword="true"/> is returned.
        /// </summary>
        public LPOCNCHKPROC lpfnCheck;      // OPTIONAL if NULL no user check will be performed.
        /// <summary>
        /// A pointer to the caller's card connect routine. If the caller needs to perform additional processing to connect to the card, this field is set to the user's connect function. If the connect function is successful, the card is left connected and initialized, and the card handle is returned.
        /// </summary>
        public LPOCNCONNPROCA lpfnConnect;  // OPTIONAL if lpfnConnect is provided,
                                            //          lpfnDisconnect must also be set.
        /// <summary>
        /// A pointer to the caller's card disconnect routine.
        /// </summary>
        public LPOCNDSCPROC lpfnDisconnect;
        /// <summary>
        /// Pointer to user data. This pointer is passed back to the caller on the Connect, Check, and Disconnect routines.
        /// </summary>
        public IntPtr pvUserData;           // OPTIONAL parameter to callbacks
        /// <summary>
        /// If <see cref="lpfnConnect"/> is not <see langword="null"/>, the <see cref="dwShareMode"/> and <see cref="dwPreferredProtocols"/> members are ignored. If <see cref="lpfnConnect"/> is <see langword="null"/> and <see cref="dwShareMode"/> is nonzero, an internal call is made to <see cref="SCardConnect"/> that uses <see cref="dwShareMode"/> and <see cref="dwPreferredProtocols"/> as the parameter.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_SHARE_MODE dwShareMode;// OPTIONAL must be set if lpfnCheck is not null
        /// <summary>
        /// Used for internal connection as described in <see cref="dwShareMode"/>.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwPreferredProtocols;    // OPTIONAL
    }
}

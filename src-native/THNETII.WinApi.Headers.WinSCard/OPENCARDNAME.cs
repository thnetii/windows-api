using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.SCardErr;
using THNETII.WinApi.Native.WinSmcrd;

namespace THNETII.WinApi.Native.WinSCard
{
    using static SCardErrConstants;
    using static WinSCardFunctions;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 1158
    //
    // "Smart Card Common Dialog" definitions for backwards compatibility
    //  with the Smart Card Base Services SDK version 1.0
    //

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 1163
    /// <inheritdoc cref="OPENCARDNAME"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Obsolete("\"Smart Card Common Dialog\" definitions for backwards compatibility with the Smart Card Base Services SDK version 1.0")]
    public unsafe struct OPENCARDNAMEA
    {
        public static readonly int SizeOf = SizeOf<OPENCARDNAMEA>.Bytes;

        /// <inheritdoc cref="OPENCARDNAME.dwStructSize"/>
        public int dwStructSize;
        /// <inheritdoc cref="OPENCARDNAME.hwndOwner"/>
        public IntPtr hwndOwner;
        /// <inheritdoc cref="OPENCARDNAME.hSCardContext"/>
        public SCARDCONTEXT hSCardContext;
        /// <inheritdoc cref="OPENCARDNAME.lpstrGroupNames"/>
        public LPMSTR lpstrGroupNames;
        /// <inheritdoc cref="OPENCARDNAME.nMaxGroupNames"/>
        public int nMaxGroupNames;
        /// <inheritdoc cref="OPENCARDNAME.lpstrCardNames"/>
        public LPMSTR lpstrCardNames;
        /// <inheritdoc cref="OPENCARDNAME.nMaxCardNames"/>
        public int nMaxCardNames;
        /// <inheritdoc cref="OPENCARDNAME.rgguidInterfaces"/>
        public Guid* rgguidInterfaces;
        /// <inheritdoc cref="OPENCARDNAME.cguidInterfaces"/>
        public int cguidInterfaces;
        /// <inheritdoc cref="OPENCARDNAME.lpstrRdr"/>
        public LPSTR lpstrRdr;
        /// <inheritdoc cref="OPENCARDNAME.nMaxRdr"/>
        public int nMaxRdr;
        /// <inheritdoc cref="OPENCARDNAME.lpstrCard"/>
        public LPSTR lpstrCard;
        /// <inheritdoc cref="OPENCARDNAME.nMaxCard"/>
        public int nMaxCard;
        /// <inheritdoc cref="OPENCARDNAME.lpstrTitle"/>
        public LPCSTR lpstrTitle;
        /// <inheritdoc cref="OPENCARDNAME.dwFlags"/>
        [MarshalAs(UnmanagedType.U4)]
        public SC_DLG_FLAGS dwFlags;
        /// <inheritdoc cref="OPENCARDNAME.pvUserData"/>
        public IntPtr pvUserData;
        /// <inheritdoc cref="OPENCARDNAME.dwShareMode"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_SHARE_MODE dwShareMode;
        /// <inheritdoc cref="OPENCARDNAME.dwPreferredProtocols"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwPreferredProtocols;
        /// <inheritdoc cref="OPENCARDNAME.dwActiveProtocol"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwActiveProtocol;
        /// <inheritdoc cref="OPENCARDNAME.lpfnConnect"/>
        public LPOCNCONNPROCW lpfnConnect;
        /// <inheritdoc cref="OPENCARDNAME.lpfnCheck"/>
        public LPOCNCHKPROC lpfnCheck;
        /// <inheritdoc cref="OPENCARDNAME.lpfnDisconnect"/>
        public LPOCNDSCPROC lpfnDisconnect;
        /// <inheritdoc cref="OPENCARDNAME.hCardHandle"/>
        public SCARDHANDLE hCardHandle;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 1188
    /// <inheritdoc cref="OPENCARDNAME"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [Obsolete("\"Smart Card Common Dialog\" definitions for backwards compatibility with the Smart Card Base Services SDK version 1.0")]
    public unsafe struct OPENCARDNAMEW
    {
        public static readonly int SizeOf = SizeOf<OPENCARDNAMEW>.Bytes;

        /// <inheritdoc cref="OPENCARDNAME.dwStructSize"/>
        public int dwStructSize;
        /// <inheritdoc cref="OPENCARDNAME.hwndOwner"/>
        public IntPtr hwndOwner;
        /// <inheritdoc cref="OPENCARDNAME.hSCardContext"/>
        public SCARDCONTEXT hSCardContext;
        /// <inheritdoc cref="OPENCARDNAME.lpstrGroupNames"/>
        public LPMWSTR lpstrGroupNames;
        /// <inheritdoc cref="OPENCARDNAME.nMaxGroupNames"/>
        public int nMaxGroupNames;
        /// <inheritdoc cref="OPENCARDNAME.lpstrCardNames"/>
        public LPMWSTR lpstrCardNames;
        /// <inheritdoc cref="OPENCARDNAME.nMaxCardNames"/>
        public int nMaxCardNames;
        /// <inheritdoc cref="OPENCARDNAME.rgguidInterfaces"/>
        public Guid* rgguidInterfaces;
        /// <inheritdoc cref="OPENCARDNAME.cguidInterfaces"/>
        public int cguidInterfaces;
        /// <inheritdoc cref="OPENCARDNAME.lpstrRdr"/>
        public LPWSTR lpstrRdr;
        /// <inheritdoc cref="OPENCARDNAME.nMaxRdr"/>
        public int nMaxRdr;
        /// <inheritdoc cref="OPENCARDNAME.lpstrCard"/>
        public LPWSTR lpstrCard;
        /// <inheritdoc cref="OPENCARDNAME.nMaxCard"/>
        public int nMaxCard;
        /// <inheritdoc cref="OPENCARDNAME.lpstrTitle"/>
        public LPCWSTR lpstrTitle;
        /// <inheritdoc cref="OPENCARDNAME.dwFlags"/>
        [MarshalAs(UnmanagedType.U4)]
        public SC_DLG_FLAGS dwFlags;
        /// <inheritdoc cref="OPENCARDNAME.pvUserData"/>
        public IntPtr pvUserData;
        /// <inheritdoc cref="OPENCARDNAME.dwShareMode"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_SHARE_MODE dwShareMode;
        /// <inheritdoc cref="OPENCARDNAME.dwPreferredProtocols"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwPreferredProtocols;
        /// <inheritdoc cref="OPENCARDNAME.dwActiveProtocol"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwActiveProtocol;
        /// <inheritdoc cref="OPENCARDNAME.lpfnConnect"/>
        public LPOCNCONNPROCW lpfnConnect;
        /// <inheritdoc cref="OPENCARDNAME.lpfnCheck"/>
        public LPOCNCHKPROC lpfnCheck;
        /// <inheritdoc cref="OPENCARDNAME.lpfnDisconnect"/>
        public LPOCNDSCPROC lpfnDisconnect;
        /// <inheritdoc cref="OPENCARDNAME.hCardHandle"/>
        public SCARDHANDLE hCardHandle;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 1213
    /// <summary>
    /// The <see cref="OPENCARDNAME"/> structure contains the information that the <see cref="GetOpenCardName"/> function uses to initialize a smart card <strong>Select Card</strong> dialog box. Calling <see cref="SCardUIDlgSelectCard"/> with <see cref="OPENCARDNAME_EX"/> is recommended over calling <see cref="GetOpenCardName"/> with <see cref="OPENCARDNAME"/>. <see cref="OPENCARDNAME"/> is provided for backward compatibility.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/ns-winscard-opencardnamew">OPENCARDNAMEW structure</a></para>
    /// </remarks>
    /// <seealso cref="GetOpenCardName"/>
    /// <seealso cref="SCardConnect"/>
    /// <seealso cref="SCardEstablishContext"/>
    /// <seealso cref="SCardReleaseContext"/>
    /// <seealso cref="SCardUIDlgSelectCard"/>
#if !NETSTANDARD1_3
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif // !NETSTANDARD1_3
    [Obsolete("\"Smart Card Common Dialog\" definitions for backwards compatibility with the Smart Card Base Services SDK version 1.0")]
    public unsafe struct OPENCARDNAME
    {
        public static readonly int SizeOf = SizeOf<OPENCARDNAME>.Bytes;

        /// <summary>
        /// The length, in bytes, of the structure. Must not be <c>0</c> (zero).
        /// <para>Use the static <see cref="SizeOf"/> value.</para>
        /// </summary>
        public int dwStructSize;
        /// <summary>
        /// The window that owns the dialog box. This member can be any valid window handle, or it can be <see cref="IntPtr.Zero"/> for desktop default.
        /// </summary>
        public IntPtr hwndOwner;
        /// <summary>
        /// The context used for communication with the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager</a>. Call <see cref="SCardEstablishContext"/> to set the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a> and <see cref="SCardReleaseContext"/> to release it. This member must not be <see cref="IntPtr.Zero"/>.
        /// </summary>
        public SCARDCONTEXT hSCardContext;
        /// <summary>
        /// A pointer to a buffer that contains null-terminated group name strings. The last string in the buffer must be terminated by two null characters. Each string is the name of a group of cards that is to be included in the search. If <see cref="lpstrGroupNames"/> is <see cref="IntPtr.Zero"/>, the default group (<c><a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">Scard$DefaultReaders</a></c>) is searched.
        /// </summary>
        public LPMTSTR lpstrGroupNames;
        /// <summary>
        /// The maximum number of bytes (ANSI version) or characters (Unicode version) in the <see cref="lpstrGroupNames"/> string.
        /// </summary>
        public int nMaxGroupNames;
        /// <summary>
        /// A pointer to a buffer that contains null-terminated card name strings. The last string in the buffer must be terminated by two null characters. Each string is the name of a card that is to be located.
        /// </summary>
        public LPMTSTR lpstrCardNames;
        /// <summary>
        /// The maximum number of bytes (ANSI version) or characters (Unicode version) in the <see cref="lpstrCardNames"/> string.
        /// </summary>
        public int nMaxCardNames;
        /// <summary>
        /// Reserved for future use. Set to <see langword="null"/>. An array of GUIDs that identify the interfaces required.
        /// </summary>
        public Guid* rgguidInterfaces;
        /// <summary>
        /// Reserved for futures use. Set to <c>0</c> (zero). The number of interfaces in the <see cref="rgguidInterfaces"/> array.
        /// </summary>
        public int cguidInterfaces;
        /// <summary>
        /// If the card is located, the <see cref="lpstrRdr"/> buffer contains the name of the reader that contains the located card. The buffer should be at least 256 characters long.
        /// </summary>
        public LPTSTR lpstrRdr;
        /// <summary>
        /// The size, in bytes (ANSI version) or characters (Unicode version), of the buffer pointed to by <see cref="lpstrRdr"/>. If the buffer is too small to contain the reader information, <see cref="GetOpenCardName"/> returns <see cref="SCARD_E_NO_MEMORY"/> and the required size of the buffer pointed to by <see cref="lpstrRdr"/>.
        /// </summary>
        public int nMaxRdr;
        /// <summary>
        /// If the card is located, the <see cref="lpstrCard"/> buffer contains the name of the located card. The buffer should be at least 256 characters long.
        /// </summary>
        public LPTSTR lpstrCard;
        /// <summary>
        /// The size, in bytes (ANSI version) or characters (Unicode version), of the buffer pointed to by <see cref="lpstrCard"/>. If the buffer is too small to contain the card information, <see cref="GetOpenCardName"/> returns <see cref="SCARD_E_NO_MEMORY"/> and the required size of the buffer in <see cref="nMaxCard"/>.
        /// </summary>
        public int nMaxCard;
        /// <summary>
        /// A pointer to a string to be placed in the title bar of the dialog box. If this member is <see langword="null"/>, the system uses the default title <c>"Select Card:"</c>.
        /// </summary>
        public LPCTSTR lpstrTitle;
        /// <summary>
        /// A set of bit flags you can use to initialize the dialog box. When the dialog box returns, it sets these flags to indicate the input of the user.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SC_DLG_FLAGS dwFlags;
        /// <summary>
        /// A void pointer to user data. This pointer is passed back to the caller on the Connect, Check, and Disconnect routines.
        /// </summary>
        public IntPtr pvUserData;
        /// <summary>
        /// <para>If <see cref="lpfnConnect"/> is not <see langword="null"/>, the <see cref="dwShareMode"/> and <see cref="dwPreferredProtocols"/> members are ignored.</para>
        /// <para>If <see cref="lpfnConnect"/> is <see langword="null"/> and <see cref="dwShareMode"/> is nonzero, then an internal call is made to <see cref="SCardConnect"/> that uses <see cref="dwShareMode"/> and <see cref="dwPreferredProtocols"/> as the <em>dwShareMode</em> and <em>dwPreferredProtocols</em> parameters. If the connect succeeds, <see cref="hCardHandle"/> is set to the handle returned by <em>hSCardConnect</em>.</para>
        /// <para>If <see cref="lpfnConnect"/> is <see langword="null"/> and <see cref="dwShareMode"/> is zero, the dialog box returns <see cref="hCardHandle"/> as <see cref="IntPtr.Zero"/>.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_SHARE_MODE dwShareMode;
        /// <summary>
        /// Used for internal connection as described in <see cref="dwShareMode"/>.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwPreferredProtocols;
        /// <summary>
        /// Returns the actual protocol in use when the dialog box makes a connection to a card.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwActiveProtocol;
        /// <summary>
        /// A pointer to the card connect routine of the caller. If the caller needs to perform additional processing to connect to the card, this function pointer is set to the connect function for the user. If the connect function is successful, the card is left connected and initialized, and the card handle is returned.
        /// </summary>
        public LPOCNCONNPROCW lpfnConnect;
        /// <summary>
        /// <para>A pointer to the card verify routine of the caller. If no special card verification is required, this pointer is <see cref="IntPtr.Zero"/>.</para>
        /// <para>If the card is rejected by the verify routine, <see langword="false"/> is returned and the card is disconnected, as indicated by <see cref="lpfnDisconnect"/>.</para>
        /// <para>If the card is accepted by the verify routine, <see langword="true"/> is returned. When the user accepts the card, all other cards currently connected will be disconnected, as indicated by <see cref="lpfnDisconnect"/>, and this card will be returned as the located card. The located card will remain connected.</para>
        /// </summary>
        public LPOCNCHKPROC lpfnCheck;
        /// <summary>
        /// A pointer to the card disconnect routine of the caller.
        /// <note>When using <see cref="lpfnConnect"/>, <see cref="lpfnCheck"/>, and <see cref="lpfnDisconnect"/>, all three callback procedures should be present. Using these callbacks allows further verification that the calling application has found the appropriate card. This is the best way to ensure the appropriate card is selected.</note>
        /// </summary>
        public LPOCNDSCPROC lpfnDisconnect;
        /// <summary>
        /// A handle of the connected card (either through an internal dialog box connect or an <see cref="lpfnConnect"/> callback).
        /// </summary>
        public SCARDHANDLE hCardHandle;
    }
}

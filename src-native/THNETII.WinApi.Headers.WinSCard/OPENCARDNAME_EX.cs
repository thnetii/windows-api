using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.SCardErr;
using THNETII.WinApi.Native.WinSmcrd;

namespace THNETII.WinApi.Native.WinSCard
{
    using static SCardErrConstants;
    using static WinSCardFunctions;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 947
    //
    // OPENCARDNAME_EX: used by SCardUIDlgSelectCard; replaces obsolete OPENCARDNAME
    //

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 951
    /// <inheritdoc cref="OPENCARDNAME_EX"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct OPENCARDNAME_EXA
    {
        public static readonly int SizeOf = SizeOf<OPENCARDNAME_EXA>.Bytes;

        /// <inheritdoc cref="OPENCARDNAME_EX.dwStructSize"/>
        public int dwStructSize;
        /// <inheritdoc cref="OPENCARDNAME_EX.hSCardContext"/>
        public SCARDCONTEXT hSCardContext;  // REQUIRED
        /// <inheritdoc cref="OPENCARDNAME_EX.hwndOwner"/>
        public IntPtr hwndOwner;            // OPTIONAL
        /// <inheritdoc cref="OPENCARDNAME_EX.dwFlags"/>
        [MarshalAs(UnmanagedType.U4)]
        public SC_DLG_FLAGS dwFlags;        // OPTIONAL -- default is SC_DLG_MINIMAL_UI
        /// <inheritdoc cref="OPENCARDNAME_EX.lpstrTitle"/>
        public LPCSTR lpstrTitle;          // OPTIONAL
        /// <inheritdoc cref="OPENCARDNAME_EX.lpstrSearchDesc"/>
        public LPCSTR lpstrSearchDesc;     // OPTIONAL (eg. "Please insert your <brandname> smart card.")
        /// <inheritdoc cref="OPENCARDNAME_EX.hIcon"/>
        public IntPtr hIcon;                // OPTIONAL 32x32 icon for your brand insignia
        /// <inheritdoc cref="OPENCARDNAME_EX.pOpenCardSearchCriteria"/>
        public OPENCARD_SEARCH_CRITERIAA* pOpenCardSearchCriteria; // OPTIONAL
        /// <inheritdoc cref="OPENCARDNAME_EX.lpfnConnect"/>
        public LPOCNCONNPROCA lpfnConnect;   // OPTIONAL - performed on successful selection
        /// <inheritdoc cref="OPENCARDNAME_EX.pvUserData"/>
        public IntPtr pvUserData;           // OPTIONAL parameter to lpfnConnect
        /// <inheritdoc cref="OPENCARDNAME_EX.dwShareMode"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_SHARE_MODE dwShareMode;// OPTIONAL - if lpfnConnect is NULL, dwShareMode and
        /// <inheritdoc cref="OPENCARDNAME_EX.dwPreferredProtocols"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwPreferredProtocols;   // OPTIONAL dwPreferredProtocols will be used to
                                                            //          connect to the selected card
        /// <inheritdoc cref="OPENCARDNAME_EX.lpstrRdr"/>
        public LPSTR lpstrRdr;              // REQUIRED [IN|OUT] Name of selected reader
        /// <inheritdoc cref="OPENCARDNAME_EX.nMaxRdr"/>
        public int nMaxRdr;                 // REQUIRED [IN|OUT]
        /// <inheritdoc cref="OPENCARDNAME_EX.lpstrCard"/>
        public LPSTR lpstrCard;             // REQUIRED [IN|OUT] Name of selected card
        /// <inheritdoc cref="OPENCARDNAME_EX.nMaxCard"/>
        public int nMaxCard;                // REQUIRED [IN|OUT]
        /// <inheritdoc cref="OPENCARDNAME_EX.dwActiveProtocol"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwActiveProtocol;   // [OUT] set only if dwShareMode not NULL
        /// <inheritdoc cref="OPENCARDNAME_EX.hCardHandle"/>
        public SCARDHANDLE hCardHandle;     // [OUT] set if a card connection was indicated
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 972
    /// <inheritdoc cref="OPENCARDNAME_EX"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct OPENCARDNAME_EXW
    {
        public static readonly int SizeOf = SizeOf<OPENCARDNAME_EXW>.Bytes;

        /// <inheritdoc cref="OPENCARDNAME_EX.dwStructSize"/>
        public int dwStructSize;
        /// <inheritdoc cref="OPENCARDNAME_EX.hSCardContext"/>
        public SCARDCONTEXT hSCardContext;  // REQUIRED
        /// <inheritdoc cref="OPENCARDNAME_EX.hwndOwner"/>
        public IntPtr hwndOwner;            // OPTIONAL
        /// <inheritdoc cref="OPENCARDNAME_EX.dwFlags"/>
        [MarshalAs(UnmanagedType.U4)]
        public SC_DLG_FLAGS dwFlags;        // OPTIONAL -- default is SC_DLG_MINIMAL_UI
        /// <inheritdoc cref="OPENCARDNAME_EX.lpstrTitle"/>
        public LPCWSTR lpstrTitle;          // OPTIONAL
        /// <inheritdoc cref="OPENCARDNAME_EX.lpstrSearchDesc"/>
        public LPCWSTR lpstrSearchDesc;     // OPTIONAL (eg. "Please insert your <brandname> smart card.")
        /// <inheritdoc cref="OPENCARDNAME_EX.hIcon"/>
        public IntPtr hIcon;                // OPTIONAL 32x32 icon for your brand insignia
        /// <inheritdoc cref="OPENCARDNAME_EX.pOpenCardSearchCriteria"/>
        public OPENCARD_SEARCH_CRITERIAW* pOpenCardSearchCriteria; // OPTIONAL
        /// <inheritdoc cref="OPENCARDNAME_EX.lpfnConnect"/>
        public LPOCNCONNPROCW lpfnConnect;   // OPTIONAL - performed on successful selection
        /// <inheritdoc cref="OPENCARDNAME_EX.pvUserData"/>
        public IntPtr pvUserData;           // OPTIONAL parameter to lpfnConnect
        /// <inheritdoc cref="OPENCARDNAME_EX.dwShareMode"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_SHARE_MODE dwShareMode;// OPTIONAL - if lpfnConnect is NULL, dwShareMode and
        /// <inheritdoc cref="OPENCARDNAME_EX.dwPreferredProtocols"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwPreferredProtocols;   // OPTIONAL dwPreferredProtocols will be used to
                                                            //          connect to the selected card
        /// <inheritdoc cref="OPENCARDNAME_EX.lpstrRdr"/>
        public LPWSTR lpstrRdr;              // REQUIRED [IN|OUT] Name of selected reader
        /// <inheritdoc cref="OPENCARDNAME_EX.nMaxRdr"/>
        public int nMaxRdr;                 // REQUIRED [IN|OUT]
        /// <inheritdoc cref="OPENCARDNAME_EX.lpstrCard"/>
        public LPWSTR lpstrCard;             // REQUIRED [IN|OUT] Name of selected card
        /// <inheritdoc cref="OPENCARDNAME_EX.nMaxCard"/>
        public int nMaxCard;                // REQUIRED [IN|OUT]
        /// <inheritdoc cref="OPENCARDNAME_EX.dwActiveProtocol"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwActiveProtocol;   // [OUT] set only if dwShareMode not NULL
        /// <inheritdoc cref="OPENCARDNAME_EX.hCardHandle"/>
        public SCARDHANDLE hCardHandle;     // [OUT] set if a card connection was indicated
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 993
    /// <summary>
    /// The <see cref="OPENCARDNAME_EX"/> structure contains the information that the <see cref="SCardUIDlgSelectCard"/> function uses to initialize a smart card <strong>Select Card</strong> dialog box.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/ns-winscard-opencardname_exw">OPENCARDNAME_EXW structure</a></para>
    /// </remarks>
    /// <seealso cref="SCardConnect"/>
    /// <seealso cref="SCardEstablishContext"/>
    /// <seealso cref="SCardReleaseContext"/>
    /// <seealso cref="SCardUIDlgSelectCard"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthN/authentication-return-values">Smart Card Return Values</seealso>
#if !NETSTANDARD1_3
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif // !NETSTANDARD1_3
    public unsafe struct OPENCARDNAME_EX
    {
        public static readonly int SizeOf = SizeOf<OPENCARDNAME_EX>.Bytes;

        /// <summary>
        /// The length, in bytes, of the structure. Must not be <c>0</c> (zero).
        /// <para>Use the static <see cref="SizeOf"/> value.</para>
        /// </summary>
        public int dwStructSize;
        /// <summary>
        /// The context used for communication with the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager</a>. Call <see cref="SCardEstablishContext"/> to set the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager context</a> and <see cref="SCardReleaseContext"/> to release it. The value of this member must not be <see cref="IntPtr.Zero"/>.
        /// </summary>
        public SCARDCONTEXT hSCardContext;  // REQUIRED
        /// <summary>
        /// The window that owns the dialog box. This member can be any valid window handle, or it can be <see cref="IntPtr.Zero"/> for the desktop default.
        /// </summary>
        public IntPtr hwndOwner;            // OPTIONAL
        /// <summary>
        /// A set of bit flags that you can use to initialize the dialog box. When the dialog box returns, it sets these flags to indicate the user's input.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SC_DLG_FLAGS dwFlags;        // OPTIONAL -- default is SC_DLG_MINIMAL_UI
        /// <summary>
        /// A pointer to a string to be placed in the title bar of the dialog box. If this member is set to <see langword="default"/>, the system uses the default title <c>"Select Card:"</c>.
        /// </summary>
        public LPCTSTR lpstrTitle;          // OPTIONAL
        /// <summary>
        /// A pointer to a string to be displayed to the user as a prompt to insert the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a>. If this member is set to <see langword="default"/>, the system uses the default text <c>"Please insert a smart card"</c>.
        /// </summary>
        public LPCTSTR lpstrSearchDesc;     // OPTIONAL (eg. "Please insert your <brandname> smart card.")
        /// <summary>
        /// A handle to an icon (32 x 32 pixels). You can specify a vendor-specific icon to display in the dialog box. If this value is <see cref="IntPtr.Zero"/>, a generic, smart card reader–loaded icon is displayed.
        /// </summary>
        public IntPtr hIcon;                // OPTIONAL 32x32 icon for your brand insignia
        /// <summary>
        /// A pointer to the <see cref="OPENCARD_SEARCH_CRITERIA"/> structure to be used, or <see langword="null"/>, if one is not used.
        /// </summary>
        public OPENCARD_SEARCH_CRITERIA* pOpenCardSearchCriteria; // OPTIONAL
        /// <summary>
        /// A pointer to the caller's card connect routine. If the caller needs to perform additional processing to connect to the card, this function pointer is set to the user's connect function. If the connect function is successful, the card is left connected and initialized, and the card handle is returned.
        /// </summary>
        public LPOCNCONNPROC lpfnConnect;   // OPTIONAL - performed on successful selection
        /// <summary>
        /// A void pointer to user data. This pointer is passed back to the caller on the Connect routine.
        /// </summary>
        public IntPtr pvUserData;           // OPTIONAL parameter to lpfnConnect
        /// <summary>
        /// If <see cref="lpfnConnect"/> is not <see langword="null"/>, the <see cref="dwShareMode"/> and <see cref="dwPreferredProtocols"/> members are ignored. If <see cref="lpfnConnect"/> is <see langword="null"/> and <see cref="dwShareMode"/> is nonzero, an internal call is made to <see cref="SCardConnect"/> that uses <see cref="dwShareMode"/> and <see cref="dwPreferredProtocols"/> as the <em>dwShareMode</em> and <em>dwPreferredProtocols</em> parameters. If the connect succeeds, <see cref="hCardHandle"/> is set to the handle returned by <see cref="SCardConnect"/>. If <see cref="lpfnConnect"/> is <see langword="null"/> and <see cref="dwShareMode"/> is zero, <see cref="hCardHandle"/> is set to <see langword="null"/>.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_SHARE_MODE dwShareMode;// OPTIONAL - if lpfnConnect is NULL, dwShareMode and
        /// <summary>
        /// Used for internal connection as described in <see cref="dwShareMode"/>.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwPreferredProtocols;   // OPTIONAL dwPreferredProtocols will be used to
                                                            //          connect to the selected card
        /// <summary>
        /// If the card is located, the <see cref="lpstrRdr"/> buffer contains the name of the reader that contains the located card. The buffer should be at least 256 characters long.
        /// </summary>
        public LPTSTR lpstrRdr;              // REQUIRED [IN|OUT] Name of selected reader
        /// <summary>
        /// Size, in bytes (ANSI version) or characters (<a href="https://docs.microsoft.com/windows/desktop/SecGloss/u-gly">Unicode</a> version), of the buffer pointed to by <see cref="lpstrRdr"/>. If the buffer is too small to contain the reader information, <see cref="SCardUIDlgSelectCard"/> returns <see cref="SCARD_E_NO_MEMORY"/> and the required size of the buffer pointed to by <see cref="lpstrRdr"/>.
        /// </summary>
        public int nMaxRdr;                 // REQUIRED [IN|OUT]
        /// <summary>
        /// If the card is located, the <see cref="lpstrCard"/> buffer contains the name of the located card. The buffer should be at least 256 characters long.
        /// </summary>
        public LPTSTR lpstrCard;             // REQUIRED [IN|OUT] Name of selected card
        /// <summary>
        /// Size, in bytes (ANSI version) or characters (<a href="https://docs.microsoft.com/windows/desktop/SecGloss/u-gly">Unicode</a> version), of the buffer pointed to by <see cref="lpstrCard"/>. If the buffer is too small to contain the card information, <see cref="SCardUIDlgSelectCard"/> returns <see cref="SCARD_E_NO_MEMORY"/> and the required size of the buffer in <see cref="nMaxCard"/>.
        /// </summary>
        public int nMaxCard;                // REQUIRED [IN|OUT]
        /// <summary>
        /// The actual protocol in use when the dialog box makes a connection to a card.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwActiveProtocol;   // [OUT] set only if dwShareMode not NULL
        /// <summary>
        /// A handle of the connected card (either through an internal dialog box connect or an <see cref="lpfnConnect"/> callback).
        /// </summary>
        public SCARDHANDLE hCardHandle;     // [OUT] set if a card connection was indicated
    }
}

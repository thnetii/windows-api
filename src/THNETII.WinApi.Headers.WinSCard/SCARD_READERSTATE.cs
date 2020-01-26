using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinSCard
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 504
    /// <inheritdoc cref="SCARD_READERSTATE"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct SCARD_READERSTATEA
    {
        /// <inheritdoc cref="SCARD_READERSTATE.szReader"/>
        public LPCSTR szReader;       // reader name
        /// <inheritdoc cref="SCARD_READERSTATE.pvUserData"/>
        public IntPtr pvUserData;     // user defined data
        /// <inheritdoc cref="SCARD_READERSTATE.dwCurrentState"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_STATE_FLAGS dwCurrentState; // current state of reader at time of call
        /// <inheritdoc cref="SCARD_READERSTATE.dwEventState"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_STATE_FLAGS dwEventState;   // state of reader after state change
        /// <inheritdoc cref="SCARD_READERSTATE.cbAtr"/>
        public int cbAtr;          // Number of bytes in the returned ATR.
        #region public fixed byte[36];
        internal fixed byte rgbAtrField[36];
        /// <inheritdoc cref="SCARD_READERSTATE.rgbAtr"/>
        public Span<byte> rgbAtr
        {
            get
            {
                fixed (byte* ptrAtrField = rgbAtrField)
                    return new Span<byte>(ptrAtrField, (int)Math.Min((uint)cbAtr, 36U));
            }
        }
        #endregion
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 512
    /// <inheritdoc cref="SCARD_READERSTATE"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct SCARD_READERSTATEW
    {
        /// <inheritdoc cref="SCARD_READERSTATE.szReader"/>
        public LPCWSTR szReader;       // reader name
        /// <inheritdoc cref="SCARD_READERSTATE.pvUserData"/>
        public IntPtr pvUserData;     // user defined data
        /// <inheritdoc cref="SCARD_READERSTATE.dwCurrentState"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_STATE_FLAGS dwCurrentState; // current state of reader at time of call
        /// <inheritdoc cref="SCARD_READERSTATE.dwEventState"/>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_STATE_FLAGS dwEventState;   // state of reader after state change
        /// <inheritdoc cref="SCARD_READERSTATE.cbAtr"/>
        public int cbAtr;          // Number of bytes in the returned ATR.
        #region public fixed byte[36];
        internal fixed byte rgbAtrField[36];
        /// <inheritdoc cref="SCARD_READERSTATE.rgbAtr"/>
        public Span<byte> rgbAtr
        {
            get
            {
                fixed (byte* ptrAtrField = rgbAtrField)
                    return new Span<byte>(ptrAtrField, (int)Math.Min((uint)cbAtr, 36U));
            }
        }
        #endregion
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 520
    /// <summary>
    /// The <see cref="SCARD_READERSTATE"/> structure is used by functions for tracking <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart cards</a> within <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">readers</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/ns-winscard-scard_readerstatew">SCARD_READERSTATEW structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public unsafe struct SCARD_READERSTATE
    {
        /// <summary>
        /// A pointer to the name of the reader being monitored.
        /// <para>Set the value of this member to <c>"\\?PnP?\Notification"</c> and the values of all other members to zero to be notified of the arrival of a new smart card reader.</para>
        /// </summary>
        public LPCTSTR szReader;       // reader name
        /// <summary>
        /// Not used by the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card subsystem</a>. This member is used by the application.
        /// </summary>
        public IntPtr pvUserData;     // user defined data
        /// <summary>
        /// Current <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">state</a> of the reader, as seen by the application. This field can take on any of the <see cref="SCARD_STATE_FLAGS"/> values, in combination, as a bitmask.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_STATE_FLAGS dwCurrentState; // current state of reader at time of call
        /// <summary>
        /// Current <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">state</a> of the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">reader</a>, as known by the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> <a href="https://docs.microsoft.com/windows/desktop/SecGloss/r-gly">resource manager</a>. This field can take on any of the <see cref="SCARD_STATE_FLAGS"/> values, in combination, as a bitmask.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_STATE_FLAGS dwEventState;   // state of reader after state change
        /// <summary>
        /// Number of bytes in the returned ATR.
        /// </summary>
        public int cbAtr;          // Number of bytes in the returned ATR.
        #region public fixed byte[36];
        internal fixed byte rgbAtrField[36];    // Atr of inserted card, (extra alignment bytes)
        /// <summary>
        /// ATR of the inserted card, with extra alignment bytes.
        /// </summary>
        public Span<byte> rgbAtr
        {
            get
            {
                fixed (byte* ptrAtrField = rgbAtrField)
                    return new Span<byte>(ptrAtrField, (int)Math.Min((uint)cbAtr, 36U));
            }
        }
        #endregion
    }
}

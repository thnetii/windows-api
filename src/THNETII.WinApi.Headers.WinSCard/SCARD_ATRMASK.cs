using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinSCard
{
    using static WinSCardFunctions;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 619
    /// <summary>
    /// The <see cref="SCARD_ATRMASK"/> structure is used by the <see cref="SCardLocateCardsByATR(SCARDCONTEXT, ReadOnlySpan{SCARD_ATRMASK}, Span{SCARD_READERSTATE})"/> function to locate cards.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winscard/ns-winscard-scard_atrmask">SCARD_ATRMASK structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SCARD_ATRMASK
    {
        /// <summary>
        /// The number of bytes in the ATR and the mask.
        /// </summary>
        public int cbAtr;          // Number of bytes in the ATR and the mask.
        #region public fixed byte rgbAtr[36];
        internal fixed byte rgbAtrField[36];     // Atr of card (extra alignment bytes)
        /// <summary>
        /// An array of <see cref="byte"/> values for the ATR of the card with extra alignment bytes.
        /// </summary>
        public Span<byte> rgbAtr
        {
            get
            {
                fixed (byte* ptrAtr = rgbAtrField)
                    return new Span<byte>(
                        ptrAtr,
                        (int)Math.Min((uint)cbAtr, 36U)
                        );
            }
        }
        #endregion
        #region public fixed byte rgbMask[36];
        internal fixed byte rgbMaskField[36];    // Mask for the Atr (extra alignment bytes)
        /// <summary>
        /// An array of <see cref="byte"/> values for the mask for the ATR with extra alignment bytes.
        /// </summary>
        public Span<byte> rgbMask
        {
            get
            {
                fixed (byte* ptrMask = rgbMaskField)
                    return new Span<byte>(
                        ptrMask,
                        (int)Math.Min((uint)cbAtr, 36U)
                        );
            }
        }
        #endregion
    }
}

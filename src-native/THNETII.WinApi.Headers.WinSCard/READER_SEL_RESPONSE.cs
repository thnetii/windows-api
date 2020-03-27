using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinSCard
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 1114
    /// <summary>
    /// Reader selection response from reader selection provider
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct READER_SEL_RESPONSE
    {
        /// <summary>
        /// Byte offset of matched reader name UNICODE string from the beginning of
        /// <see cref="READER_SEL_RESPONSE"/> structure
        /// </summary>
        public int cbReaderNameOffset;
        /// <summary>
        /// Number of characters in matched reader name UNICODE string including the
        /// terminating NULL character
        /// </summary>
        public int cchReaderNameLength;
        /// <summary>
        /// Byte offset of matched card name UNICODE string from the beginning of
        /// <see cref="READER_SEL_RESPONSE"/> structure
        /// </summary>
        public int cbCardNameOffset;
        /// <summary>
        /// Number of characters in matched card name UNICODE string including the
        /// terminating NULL character
        /// </summary>
        public int cchCardNameLength;

        /// <summary>
        /// Gets the span of characters storing the reader name as indicated by
        /// <see cref="cbReaderNameOffset"/> and <see cref="cchReaderNameLength"/>.
        /// </summary>
        public unsafe Span<char> GetReaderName()
        {
            fixed (READER_SEL_RESPONSE* pThis = &this)
                return new Span<char>(
                    ((byte*)pThis) + cbReaderNameOffset,
                    cchReaderNameLength
                    );
        }

        /// <summary>
        /// Gets the span of characters storing the card name as indicated by
        /// <see cref="cbCardNameOffset"/> and <see cref="cchCardNameLength"/>.
        /// </summary>
        public unsafe Span<char> GetCardName()
        {
            fixed (READER_SEL_RESPONSE* pThis = &this)
                return new Span<char>(
                    ((byte*)pThis) + cbCardNameOffset,
                    cchCardNameLength
                    );
        }
    }
}

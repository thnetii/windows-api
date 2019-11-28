using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.Sspi
{
    using static SspiConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 315

    //
    // SecBuffer
    //
    //  Generic memory descriptors for buffers passed in to the security
    //  API
    //

    /// <summary>
    /// The <see cref="SecBuffer"/> structure describes a buffer allocated by a transport application to pass to a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secbuffer">SecBuffer structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecBuffer
    {
        private static readonly Bitfield32 secbufferattrmask = Bitfield32.FromMask(SECBUFFER_ATTRMASK);
        private static readonly Bitfield32 secbuffertypemask = Bitfield32.FromMask(secbufferattrmask.InverseMask);

        /// <summary>
        /// Specifies the size, in bytes, of the buffer pointed to by the <see cref="Buffer"/> member.
        /// </summary>
        public int cbBuffer;             // Size of the buffer, in bytes
        #region public SECBUFFER_TYPE BufferType;
        internal int BufferTypeField;           // Type of the buffer (below)
        /// <summary>
        /// The type of the buffer.
        /// </summary>
        public SECBUFFER_TYPE BufferType
        {
            get => (SECBUFFER_TYPE)secbuffertypemask.ReadMasked(BufferTypeField);
            set => secbuffertypemask.WriteMasked(ref BufferTypeField, (int)value);
        }
        #endregion
        #region public SECBUFFER_ATTR Attributes;
        /// <summary>
        /// The attributes of the buffer.
        /// </summary>
        public SECBUFFER_ATTR Attributes
        {
            get => (SECBUFFER_ATTR)secbufferattrmask.ReadMasked(BufferTypeField);
            set => secbufferattrmask.WriteMasked(ref BufferTypeField, (int)value);
        }
        #endregion
        #region public Span<byte> Buffer;
        internal byte* pvBuffer;
        public Span<byte> Buffer => new Span<byte>(pvBuffer, cbBuffer);
        #endregion
    }
}

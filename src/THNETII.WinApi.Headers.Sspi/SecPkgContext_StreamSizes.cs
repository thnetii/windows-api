using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 795
    /// <summary>
    /// The <see cref="SecPkgContext_StreamSizes"/> structure indicates the sizes of the various parts of a stream for use with the message support functions. The <see cref="QueryContextAttributes"/> (General) function uses this structure.
    /// </summary>
    /// <remarks>
    /// Applications calling <see cref="EncryptMessage"/> (General) should check the values of the <see cref="cbHeader"/>, <see cref="cbTrailer"/>, and <see cref="cbMaximumMessage"/> members to determine the size of the encrypted packet.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_streamsizes">SecPkgContext_StreamSizes structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_StreamSizes
    {
        /// <summary>Specifies the size, in bytes, of the header portion. If zero, no header is used.</summary>
        public int cbHeader;
        /// <summary>Specifies the maximum size, in bytes, of the trailer portion. If zero, no trailer is used.</summary>
        public int cbTrailer;
        /// <summary>Specifies the size, in bytes, of the largest message that can be encapsulated.</summary>
        public int cbMaximumMessage;
        /// <summary>Specifies the number of buffers to pass.</summary>
        public int cBuffers;
        /// <summary>Specifies the preferred integral size of the messages. For example, eight indicates that messages should be of size zero mod eight for optimal performance. Messages other than this block size can be padded.</summary>
        public int cbBlockSize;
    }
}

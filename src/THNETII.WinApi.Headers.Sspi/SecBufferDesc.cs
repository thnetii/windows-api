using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    using static SspiConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 332
    /// <summary>
    /// The <see cref="SecBufferDesc"/> structure describes an array of <see cref="SecBuffer"/> structures to pass from a transport application to a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secbufferdesc">SecBufferDesc structure</a></para>
    /// </remarks>
    /// <seealso cref="SecBuffer"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecBufferDesc
    {
        /// <summary>
        /// Specifies the version number of this structure. This member must be <see cref="SECBUFFER_VERSION"/>.
        /// </summary>
        public int ulVersion;            // Version number
        /// <summary>
        /// Indicates the number of <see cref="SecBuffer"/> structures in the <see cref="Buffers"/> span.
        /// </summary>
        public int cBuffers;             // Number of buffers
        #region public Span<SecBuffer> pBuffers;
        internal SecBuffer* pBuffers;                // Pointer to array of buffers
        /// <summary>
        /// Span to an array of <see cref="SecBuffer"/> structures.
        /// </summary>
        public Span<SecBuffer> Buffers => new Span<SecBuffer>(pBuffers, cBuffers);
        #endregion
    }
}

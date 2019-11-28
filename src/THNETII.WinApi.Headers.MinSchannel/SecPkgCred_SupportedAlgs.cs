using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinCrypt;

namespace THNETII.WinApi.Native.MinSchannel
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minschannel.h, line 78
    /// <summary>
    /// The <see cref="SecPkgCred_SupportedAlgs"/> structure contains identifiers for algorithms permitted with a specified Schannel credential. This structure is used by the <see cref="QueryCredentialsAttributes"/> function.
    /// </summary>
    /// <remarks>
    /// For information about setting the algorithms, see <see cref="AcquireCredentialsHandle"/>.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgCred_SupportedAlgs
    {
        /// <summary>
        /// Number of elements in the <see cref="palgSupportedAlgs"/> array.
        /// </summary>
        public int cSupportedAlgs;
        /// <summary>
        /// Pointer to algorithm identifiers (<see cref="ALG_ID"/>) allowed with a credential.
        /// </summary>
        public ALG_ID* palgSupportedAlgs;
        /// <summary>
        /// A span of algorithm identifiers (<see cref="ALG_ID"/>) pointed to by <see cref="palgSupportedAlgs"/>.
        /// </summary>
        public Span<ALG_ID> SupportedAlgs => new Span<ALG_ID>(palgSupportedAlgs, cSupportedAlgs);
    }
}

using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.MinSchannel
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minschannel.h, line 85
    /// <summary>
    /// The <see cref="SecPkgCred_CipherStrengths"/> structure holds the minimum and maximum strength permitted for the cipher used by the specified Schannel credential. This structure is used by the <see cref="QueryCredentialsAttributes"/> function.
    /// </summary>
    /// <remarks>
    /// For information about setting the cipher strength, see <see cref="AcquireCredentialsHandle"/>.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct SecPkgCred_CipherStrengths
    {
        /// <summary>
        /// Minimum cipher strength allowed.
        /// </summary>
        public int dwMinimumCipherStrength;
        /// <summary>
        /// Maximum cipher strength allowed.
        /// </summary>
        public int dwMaximumCipherStrength;
    }
}

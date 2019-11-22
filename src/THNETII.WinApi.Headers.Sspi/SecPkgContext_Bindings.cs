using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1108
    /// <summary>
    /// Specifies a structure that contains channel binding information for a security <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">context</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_bindings">SecPkgContext_Bindings structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryContextAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_Bindings
    {
        /// <summary>
        /// The size, in bytes, of the structure specified by the <see cref="Bindings"/> member
        /// </summary>
        public int BindingsLength;
        /// <summary>
        /// A pointer to a <see cref="SEC_CHANNEL_BINDINGS"/> structure that specifies channel binding information.
        /// </summary>
        public SEC_CHANNEL_BINDINGS* Bindings;
    }
}

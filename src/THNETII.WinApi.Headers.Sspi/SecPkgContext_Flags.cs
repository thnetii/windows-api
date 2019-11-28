using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 982
    /// <summary>
    /// The <see cref="SecPkgContext_Flags"/> structure contains information about the flags in the current security context. This structure is returned by <see cref="QueryContextAttributes"/> (General).
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_flags">SecPkgContext_Flags structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct SecPkgContext_Flags
    {
        /// <summary>
        /// Flag values for the current security context. These values correspond to the flags negotiated by the <see cref="InitializeSecurityContext"/> (General) and <see cref="AcceptSecurityContext"/> (General) functions.
        /// </summary>
        public int Flags;
    }
}

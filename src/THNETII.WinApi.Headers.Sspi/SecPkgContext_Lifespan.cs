using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 840
    /// <summary>
    /// The <see cref="SecPkgContext_Lifespan"/> structure indicates the life span of a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a>. The <see cref="QueryContextAttributes"/> (General) function uses this structure.
    /// </summary>
    /// <remarks>
    /// It is recommended that the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a> always return these values in local time.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_lifespan">SecPkgContext_Lifespan structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryContextAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SecPkgContext_Lifespan
    {
        /// <summary>
        /// Time at which the context was established.
        /// </summary>
        public SECURITY_INTEGER tsStart;
        /// <summary>
        /// Time at which the context will expire.
        /// </summary>
        public SECURITY_INTEGER tsExpiry;
    }
}

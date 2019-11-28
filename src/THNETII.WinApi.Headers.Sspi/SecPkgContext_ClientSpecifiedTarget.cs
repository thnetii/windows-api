using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1103
    /// <summary>
    /// The <see cref="SecPkgContext_ClientSpecifiedTarget"/> structure specifies the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">service principal name</a> (SPN) of the initial target when calling the <see cref="QueryContextAttributes"/> (Digest) function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_clientspecifiedtarget">SecPkgContext_ClientSpecifiedTarget structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryContextAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_ClientSpecifiedTarget
    {
        /// <summary>
        /// The SPN of the initial target.
        /// </summary>
        public LPWSTR sTargetName;
    }
}

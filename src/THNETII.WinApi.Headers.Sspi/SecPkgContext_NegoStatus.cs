using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 782
    /// <summary>
    /// Specifies the error status of the last attempt to create a client context.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_negostatus">SecPkgContext_NegoStatus structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_NegoStatus
    {
        /// <summary>
        /// The error status of the last attempt to create a client context.
        /// </summary>
        public int LastStatus;
    }
}

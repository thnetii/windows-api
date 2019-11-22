using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 906
    /// <summary>
    /// <para>The <see cref="SecPkgContext_ProtoInfoA"/> structure holds information about the protocol in use.</para>
    /// <para>This attribute is supported only by the Schannel <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security support provider</a> (SSP).</para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_protoinfoa">SecPkgContext_ProtoInfoA structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryContextAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    [Obsolete("The SecPkgContext_ProtoInfo structure is available for use in older operating systems. It may be altered or unavailable in subsequent versions. Instead, use the SecPkgContext_ConnectionInfo structure.")]
    public struct SecPkgContext_ProtoInfoA
    {
        public LPSTR sProtocolName;
        public int majorVersion;
        public int minorVersion;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 915
    /// <summary>
    /// <para>The <see cref="SecPkgContext_ProtoInfoW"/> structure holds information about the protocol in use.</para>
    /// <para>This attribute is supported only by the Schannel <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security support provider</a> (SSP).</para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_protoinfow">SecPkgContext_ProtoInfoW structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryContextAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    [Obsolete("The SecPkgContext_ProtoInfo structure is available for use in older operating systems. It may be altered or unavailable in subsequent versions. Instead, use the SecPkgContext_ConnectionInfo structure.")]
    public struct SecPkgContext_ProtoInfoW
    {
        public LPWSTR sProtocolName;
        public int majorVersion;
        public int minorVersion;
    }
}

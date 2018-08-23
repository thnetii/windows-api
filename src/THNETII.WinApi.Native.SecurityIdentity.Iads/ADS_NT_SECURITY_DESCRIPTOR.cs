using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_NT_SECURITY_DESCRIPTOR"/> structure defines the data type of the security descriptor for Windows.
    /// </summary>
    /// <remarks>
    /// The <see cref="ADS_NT_SECURITY_DESCRIPTOR"/> structure is normally used as a member of the <see cref="ADSVALUE"/> structure definition.
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0003">__MIDL___MIDL_itf_ads_0000_0000_0003 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_NT_SECURITY_DESCRIPTOR
    {
        /// <summary>
        /// The length data, in bytes.
        /// </summary>
        public int dwLength;

        /// <summary>
        /// Pointer to the security descriptor
        /// </summary>
        public IntPtr lpValue;

        /// <summary>
        /// Gets a span over the bytes containing the security descriptor.
        /// </summary>
        public unsafe Span<byte> RawBytes =>
            new Span<byte>(lpValue.ToPointer(), dwLength);

        /// <summary>
        /// Copies the bytes pointed to by the current instance into a new
        /// managed Security Descriptor object.
        /// <para>This operation is only supported on Windows Operating Systems.</para>
        /// </summary>
        /// <returns>A <see cref="RawSecurityDescriptor"/> instance initialized with a copy of the data pointed to by the current instance.</returns>
        public RawSecurityDescriptor GetSecurityDescriptor()
            => new RawSecurityDescriptor(RawBytes.ToArray(), 0);
    }
}

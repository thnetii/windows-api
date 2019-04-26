using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// The <see cref="SECURITY_CAPABILITIES"/> structure defines the security capabilities of the app container.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-security_capabilities">SECURITY_CAPABILITIES structure</a></para>
    /// </remarks>
    /// <seealso href="https://msdn.microsoft.com/CD27774F-0B70-4D97-96C9-B247536CC88E">Capability SID Constants</seealso>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SECURITY_CAPABILITIES
    {
        public SID* AppContainerSid;
        public SID_AND_ATTRIBUTES* PCapabilities;
        public Span<SID_AND_ATTRIBUTES> Capabilities => new Span<SID_AND_ATTRIBUTES>(PCapabilities, CapabilityCount);
        /// <summary>
        /// The number of the capabilities.
        /// </summary>
        public int CapabilityCount;
        /// <summary>
        /// This member is reserved. Do not use it.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved;

        public unsafe SecurityIdentifier MarshalAppContainerSidToManagedSid() =>
            SID.MarshalToManagedSid(new IntPtr(AppContainerSid));
    }
}

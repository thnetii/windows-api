using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

using static THNETII.WinApi.Native.WinNT.CLAIM_SECURITY_ATTRIBUTES_VERSION;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// The <see cref="CLAIM_SECURITY_ATTRIBUTES_INFORMATION"/> structure defines the security attributes for the claim.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-claim_security_attributes_information">CLAIM_SECURITY_ATTRIBUTES_INFORMATION structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct CLAIM_SECURITY_ATTRIBUTES_INFORMATION
    {
        /// <summary>
        /// The version of the security attribute. This must be <see cref="CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1"/>.
        /// </summary>
        public CLAIM_SECURITY_ATTRIBUTES_VERSION Version;
        /// <summary>
        /// This member is currently reserved and must be zero when setting an attribute and is ignored when getting an attribute.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public short Reserved;
        /// <summary>
        /// The number of values.
        /// </summary>
        public int AttributeCount;
        /// <summary>
        /// A pointer to the actual attributes.
        /// </summary>
        internal IntPtr pAttribute;
        /// <summary>
        /// A span that grants access to <see cref="AttributeCount"/> members of the
        /// <see cref="CLAIM_SECURITY_ATTRIBUTE_V1"/> structure.
        /// </summary>
        public Span<CLAIM_SECURITY_ATTRIBUTE_V1> AttributeV1
        {
            get
            {
                if (Version != CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1)
                    throw new InvalidOperationException($"Cannot access property {nameof(AttributeV1)} if {nameof(Version)} is {Version}");
                return pAttribute.AsRefStructSpan<CLAIM_SECURITY_ATTRIBUTE_V1>(AttributeCount);
            }
        }
    }
}

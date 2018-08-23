using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_HOLD"/> structure is an ADSI representation of the <strong>Hold</strong> attribute syntax.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0010">__MIDL___MIDL_itf_ads_0000_0000_0010 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_HOLD
    {
        /// <summary>
        /// A pointer to a null-terminated Unicode string that contains the name of an object put on hold.
        /// </summary>
        public IntPtr pwzObjectName;

        /// <summary>
        /// Gets the span over the string that contains the name of an object put on hold.
        /// </summary>
        public Span<char> ObjectName => pwzObjectName.AsZeroTerminatedUnicodeSpan();

        /// <summary>
        /// Number of charges that a server places against the user on hold while it verifies the user account balance.
        /// </summary>
        public int Amount;
    }
}

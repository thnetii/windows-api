using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApiNative.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_TYPEDNAME "/> structure is an ADSI representation of the <strong>Typed Name</strong> attribute syntax.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0009">__MIDL___MIDL_itf_ads_0000_0000_0009 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_TYPEDNAME
    {
        /// <summary>
        /// A pointer to a null-terminated Unicode string that contains an object name.
        /// </summary>
        public IntPtr pwzObjectName;

        /// <summary>
        /// Gets the span over the string that contains an object name.
        /// </summary>
        public Span<char> ObjectName => pwzObjectName.AsZeroTerminatedUnicodeSpan();

        /// <summary>
        /// The priority associated with the object.
        /// </summary>
        public int Level;

        /// <summary>
        /// The frequency of reference of the object.
        /// </summary>
        public int Interval;
    }
}

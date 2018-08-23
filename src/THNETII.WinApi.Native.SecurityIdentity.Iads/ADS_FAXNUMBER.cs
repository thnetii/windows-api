using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_FAXNUMBER"/> structure is an ADSI representation of the <strong>Facsimile Telephone</strong> attribute syntax.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0013">__MIDL___MIDL_itf_ads_0000_0000_0013 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_FAXNUMBER
    {
        /// <summary>
        /// Pointer to a null-terminated Unicode string value that contains the telephone number of the facsimile (fax) machine.
        /// </summary>
        public IntPtr pwzTelephoneNumber;

        /// <summary>
        /// Gets a span over the string value that contains the telephone number of the facsimile (fax) machine.
        /// </summary>
        public Span<char> TelephoneNumber => pwzTelephoneNumber.AsZeroTerminatedUnicodeSpan();

        /// <summary>
        /// The number of data bits.
        /// </summary>
        public int NumberOfBits;

        /// <summary>
        /// Pointer to optional parameters for the fax machine.
        /// </summary>
        public IntPtr pParamaters;

        /// <summary>
        /// Gets a span over the optional parameters for the fax machine.
        /// </summary>
        public unsafe Span<byte> Parameters =>
            new Span<byte>(pParamaters.ToPointer(), NumberOfBits);
    }
}

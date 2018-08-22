using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_BACKLINK"/> structure is an ADSI representation of the <strong>Back Link</strong> attribute syntax.
    /// </summary>
    /// <remarks>
    /// A <strong>Back Link</strong> attribute contains one or more servers that hold an external reference to the attached object.
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0008">__MIDL___MIDL_itf_ads_0000_0000_0008 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_BACKLINK
    {
        /// <summary>
        /// Identifier of the remote server that requires an external reference to the object specified by <see cref="pszObjectName"/>. See below.
        /// </summary>
        public int RemoteID;

        /// <summary>
        /// Pointer to a null-terminated Unicode string that specifies the name of an object to which the <strong>Back Link</strong> attribute is attached.
        /// </summary>
        public IntPtr pszObjectName;

        /// <summary>
        /// Marshals the string pointed to by <see cref="pszObjectName"/>.
        /// </summary>
        /// <returns>A managed <see cref="string"/> instance containing a copy of the data pointed to by <see cref="pszObjectName"/>.</returns>
        public string GetObjectName() => pszObjectName.MarshalAsUnicodeString();
    }
}

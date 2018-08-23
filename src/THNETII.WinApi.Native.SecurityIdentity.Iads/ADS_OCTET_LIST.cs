using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_OCTET_LIST"/> structure is an ADSI representation of an ordered sequence of single-byte strings.
    /// </summary>
    /// <remarks>
    /// <para>For more information, see Novell NetWare Directory Services Schema Specification, version 1.1.</para>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-_ads_octet_list">_ADS_OCTET_LIST structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_OCTET_LIST
    {
        /// <summary>
        /// Pointer to the next <see cref="ADS_OCTET_LIST"/> entry in the list.
        /// </summary>
        public IntPtr pNext;

        /// <summary>
        /// Typed reference to the next <see cref="ADS_OCTET_LIST"/> entry in the list.
        /// </summary>
        public ref ADS_OCTET_LIST Next =>
            ref pNext.AsRefStruct<ADS_OCTET_LIST>();

        /// <summary>
        /// Contains the length, in bytes, of the list.
        /// </summary>
        public int Length;

        /// <summary>
        /// Pointer to an array of bytes that contains the list. The Length member of this structure contains the number of bytes in this array.
        /// </summary>
        public IntPtr pData;

        /// <summary>
        /// Gets a span providing access to the bytes contained at the memory location pointed to by <see cref="pData"/>.
        /// </summary>
        public unsafe Span<byte> Data => new Span<byte>(pData.ToPointer(), Length);
    }
}

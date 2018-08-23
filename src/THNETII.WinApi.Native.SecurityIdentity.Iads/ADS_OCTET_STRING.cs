﻿using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_OCTET_STRING"/> structure is an ADSI representation of the <strong>Octet String</strong> attribute syntax used in Active Directory.
    /// </summary>
    /// <remarks>
    /// Memory for the byte array must be allocated separately.
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0002">__MIDL___MIDL_itf_ads_0000_0000_0002 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_OCTET_STRING
    {
        /// <summary>
        /// The size, in bytes, of the character array.
        /// </summary>
        public int dwLength;

        /// <summary>
        /// Pointer to an array of single byte characters not interpreted by the underlying directory.
        /// </summary>
        public IntPtr lpValue;

        /// <summary>
        /// Returns the byte array as a span over the memory pointed to by <see cref="lpValue"/>.
        /// </summary>
        /// <returns>A span granting read/write access to the bytes pointed to by the current instance.</returns>
        public unsafe Span<byte> AsSpan() => new Span<byte>(lpValue.ToPointer(), dwLength);
    }
}

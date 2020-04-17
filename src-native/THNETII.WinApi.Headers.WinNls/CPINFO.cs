using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNls
{
    using static WinNlsConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1072
    //
    //  CP Info.
    //
    // Deprecated.  Applications should use Unicode (WCHAR / UTF-16 or UTF-8)
    //
    // WARNING: These structures fail for some encodings, including UTF-8, which
    //          do not fit into the assumptions of these APIs.
    //
    /// <summary>
    /// Contains information about a code page. This structure is used by the <see cref="GetCPInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Lead bytes are unique to DBCS code pages that allow for more than 256 characters. A lead byte is the first byte of a 2-byte character in a DBCS. On each DBCS code page, the lead bytes occupy a specific range of byte values. This range is different for different code pages.</para>
    /// <para>The lead byte information is not very helpful for most code pages, and is not even provided for many multi-byte encodings, for example, UTF-8 and GB18030. Your applications are discouraged from using this information to predict what the <see cref="MultiByteToWideChar"/> or <see cref="WideCharToMultiByte"/> function will do. The function might end up using a default character or performing other default behavior if the bytes following the lead byte are not as expected.</para>
    /// <para><see cref="CPINFOEX"/>, used by the <see cref="GetCPInfoEx"/> function, provides an extended version of this structure.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/ns-winnls-cpinfo">CPINFO structure</a></para>
    /// </remarks>
    /// <seealso cref="CPINFOEX"/>
    /// <seealso cref="GetCPInfo"/>
    /// <seealso cref="MultiByteToWideChar"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-structures">National Language Support Structures</seealso>
    /// <seealso cref="WideCharToMultiByte"/>
    [Obsolete("Use Unicode. The information in this structure cannot represent all encodings accurately and may be unreliable on many machines.")]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CPINFO
    {
        /// <summary>
        /// Maximum length, in bytes, of a character in the code page. The length can be 1 for a <a href="https://docs.microsoft.com/windows/desktop/Intl/single-byte-character-sets">single-byte character set</a> (SBCS), 2 for a <a href="https://docs.microsoft.com/windows/desktop/Intl/double-byte-character-sets">double-byte character set</a> (DBCS), or a value larger than 2 for other character set types. The function cannot use the size to distinguish an SBCS or a DBCS from other character sets because of other factors, for example, the use of ISCII or ISO-2022-xx code pages.
        /// </summary>
        public int MaxCharSize;                    // max length (in bytes) of a char
        #region public fixed byte DefaultChar[MAX_DEFAULTCHAR];
        internal fixed byte DefaultCharPtr[MAX_DEFAULTCHAR];   // default character
        /// <summary>
        /// Default character used when translating character strings to the specific code page. This character is used by the <see cref="WideCharToMultiByte"/> function if an explicit default character is not specified. The default is usually the <c>'?'</c> character for the code page.
        /// </summary>
        public Span<byte> DefaultChar
        {
            get
            {
                fixed (void* ptr = DefaultCharPtr)
                    return new Span<byte>(ptr, MAX_DEFAULTCHAR);
            }
        }
        #endregion
        #region public fixed byte LeadByte[MAX_LEADBYTES];
        internal fixed byte LeadBytePtr[MAX_LEADBYTES];        // lead byte ranges
        /// <summary>
        /// A fixed-length array of lead byte ranges, for which the number of lead byte ranges is variable. If the code page has no lead bytes, every element of the array is set to <c>0</c> (zero). If the code page has lead bytes, the array specifies a starting value and an ending value for each range. Ranges are inclusive, and the maximum number of ranges for any code page is five. The array uses two bytes to describe each range, with two null bytes as a terminator after the last range.
        /// <para><note>Some code pages use lead bytes and a combination of other encoding mechanisms. This member is usually only populated for a subset of the code pages that use lead bytes in some form. For more information, see the Remarks section.</note></para>
        /// </summary>
        public Span<byte> LeadByte
        {
            get
            {
                fixed (void* ptr = LeadBytePtr)
                    return new Span<byte>(ptr, MAX_LEADBYTES);
            }
        }
        #endregion
    }
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Memory;
using THNETII.WinApi.Helpers;
using THNETII.WinApi.Native.MinWinDef;

namespace THNETII.WinApi.Native.WinNls
{
    using static MinWinDefConstants;
    using static WinNlsConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1088
    [Obsolete("Use Unicode. The information in this structure cannot represent all encodings accurately and may be unreliable on many machines.")]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct CPINFOEXA
    {
        /// <inheritdoc cref="CPINFOEX.MaxCharSize"/>
        public int MaxCharSize;                    // max length (in bytes) of a char
        #region public fixed byte DefaultChar[MAX_DEFAULTCHAR];
        internal fixed byte DefaultCharPtr[MAX_DEFAULTCHAR];   // default character
        /// <inheritdoc cref="CPINFOEX.DefaultChar"/>
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
        /// <inheritdoc cref="CPINFOEX.LeadByte"/>
        public Span<byte> LeadByte
        {
            get
            {
                fixed (void* ptr = LeadBytePtr)
                    return new Span<byte>(ptr, MAX_LEADBYTES);
            }
        }
        #endregion
        /// <inheritdoc cref="CPINFOEX.UnicodeDefaultChar"/>
        public char UnicodeDefaultChar;             // default character (Unicode)
        /// <inheritdoc cref="CPINFOEX.CodePage"/>
        public int CodePage;                       // code page id
        #region public fixed byte CodePageName[MAX_PATH];
        internal fixed byte CodePageNamePtr[MAX_PATH];
        public Span<byte> CodePageNameSpan
        {
            get
            {
                fixed (byte* ptr = CodePageNamePtr)
                    return new Span<byte>(ptr, MAX_PATH);
            }
        }

        /// <inheritdoc cref="CPINFOEX.CodePageName"/>
        public string CodePageName // code page name (Unicode)
        {
            get
            {
                fixed (byte* ptr = CodePageNamePtr)
                    return FixedStringBuffer.ToStringZeroTerminatedAnsi(ptr, MAX_PATH);
            }
            set
            {
                fixed (byte* ptr = CodePageNamePtr)
                    FixedStringBuffer.MarshalAnsiBytes(value, ptr, MAX_PATH);
            }
        }
        #endregion
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1097
    [Obsolete("Use Unicode. The information in this structure cannot represent all encodings accurately and may be unreliable on many machines.")]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CPINFOEXW
    {
        /// <inheritdoc cref="CPINFOEX.MaxCharSize"/>
        public int MaxCharSize;                    // max length (in bytes) of a char
        #region public fixed byte DefaultChar[MAX_DEFAULTCHAR];
        internal fixed byte DefaultCharPtr[MAX_DEFAULTCHAR];   // default character
        /// <inheritdoc cref="CPINFOEX.DefaultChar"/>
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
        /// <inheritdoc cref="CPINFOEX.LeadByte"/>
        public Span<byte> LeadByte
        {
            get
            {
                fixed (void* ptr = LeadBytePtr)
                    return new Span<byte>(ptr, MAX_LEADBYTES);
            }
        }
        #endregion
        /// <inheritdoc cref="CPINFOEX.UnicodeDefaultChar"/>
        public char UnicodeDefaultChar;             // default character (Unicode)
        /// <inheritdoc cref="CPINFOEX.CodePage"/>
        public int CodePage;                       // code page id
        #region public fixed byte CodePageName[MAX_PATH];
        internal fixed char CodePageNamePtr[MAX_PATH];
        public Span<char> CodePageNameSpan
        {
            get
            {
                fixed (char* ptr = CodePageNamePtr)
                    return new Span<char>(ptr, MAX_PATH);
            }
        }

        /// <inheritdoc cref="CPINFOEX.CodePageName"/>
        public string CodePageName // code page name (Unicode)
        {
            get
            {
                fixed (char* ptr = CodePageNamePtr)
                    return FixedStringBuffer.ToStringZeroTerminatedUnicode(ptr, MAX_PATH);
            }
            set
            {
                fixed (char* ptr = CodePageNamePtr)
                    FixedStringBuffer.MarshalUnicodeChars(value, ptr, MAX_PATH);
            }
        }
        #endregion
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1106
    /// <summary>
    /// Contains information about a code page. This structure is used by the <see cref="GetCPInfoEx"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Lead bytes are unique to DBCS code pages that allow for more than 256 characters. A lead byte is the first byte of a 2-byte character in a DBCS. On each DBCS code page, the lead bytes occupy a specific range of byte values. This range is different for different code pages.</para>
    /// <para>The lead byte information is not very helpful for most code pages, and is not even provided for many multi-byte encodings, for example, UTF-8 and GB18030. Your applications are discouraged from using this information to predict what the <see cref="MultiByteToWideChar"/> or <see cref="WideCharToMultiByte"/> function will do. The function might end up using a default character or performing other default behavior if the bytes following the lead byte are not as expected.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/ns-winnls-cpinfoexw">CPINFOEXW structure</a></para>
    /// </remarks>
    /// <seealso cref="GetCPInfoEx"/>
    /// <seealso cref="MultiByteToWideChar"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-structures">National Language Support Structures</seealso>
    /// <seealso cref="WideCharToMultiByte"/>
    [Obsolete("Use Unicode. The information in this structure cannot represent all encodings accurately and may be unreliable on many machines.")]
#if NETSTANDARD1_3
    [StructLayout(LayoutKind.Sequential)]
#else
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#endif
    public unsafe struct CPINFOEX
    {
        /// <inheritdoc cref="CPINFO.MaxCharSize"/>
        public int MaxCharSize;                    // max length (in bytes) of a char
        #region public fixed byte DefaultChar[MAX_DEFAULTCHAR];
        internal fixed byte DefaultCharPtr[MAX_DEFAULTCHAR];   // default character
        /// <inheritdoc cref="CPINFO.DefaultChar"/>
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
        /// <inheritdoc cref="CPINFO.LeadByte"/>
        public Span<byte> LeadByte
        {
            get
            {
                fixed (void* ptr = LeadBytePtr)
                    return new Span<byte>(ptr, MAX_LEADBYTES);
            }
        }
        #endregion
        /// <summary>
        /// Unicode default character used in translations from the specific code page. The default is usually the <c>?</c> character or the katakana middle dot character. The Unicode default character is used by the <see cref="MultiByteToWideChar"/> function.
        /// </summary>
        public char UnicodeDefaultChar;             // default character (Unicode)
        /// <summary>
        /// Code page value. This value reflects the code page passed to the <see cref="GetCPInfoEx"/> function. See <a href="https://docs.microsoft.com/windows/desktop/Intl/code-page-identifiers">Code Page Identifiers</a> for a list of ANSI and other code pages.
        /// </summary>
        public int CodePage;                       // code page id
        #region public fixed byte CodePageName[MAX_PATH];
        private fixed char CodePageNamePtr[MAX_PATH];
        /// <summary>
        /// Full name of the code page. Note that this name is localized and is not guaranteed for uniqueness or consistency between operating system versions or computers.
        /// </summary>
        public string CodePageName // code page name (Unicode)
        {
            get
            {
                fixed (void* thisPtr = &this)
                {
                    switch (Marshal.SystemDefaultCharSize)
                    {
                        case 1:
                            CPINFOEXA* pcpinfoexa = (CPINFOEXA*)thisPtr;
                            return pcpinfoexa->CodePageName;
                        case 2:
                            CPINFOEXW* pcpinfoexw = (CPINFOEXW*)thisPtr;
                            return pcpinfoexw->CodePageName;
                        default: throw new PlatformNotSupportedException();
                    }
                }
            }
            set
            {
                fixed (void* thisPtr = &this)
                {
                    switch (Marshal.SystemDefaultCharSize)
                    {
                        case 1:
                            CPINFOEXA* pcpinfoexa = (CPINFOEXA*)thisPtr;
                            pcpinfoexa->CodePageName = value;
                            break;
                        case 2:
                            CPINFOEXW* pcpinfoexw = (CPINFOEXW*)thisPtr;
                            pcpinfoexw->CodePageName = value;
                            break;
                        default: throw new PlatformNotSupportedException();
                    }
                }
            }
        }
        #endregion
    }
}

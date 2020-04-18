using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNls
{
    using static WinNlsConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1422
    //
    // Information about a MUI file, used as input/output in GetFileMUIInfo
    // All offsets are relative to start of the structure. Offsets with value 0 mean empty field.
    //

    /// <summary>
    /// Contains information about a file, related to its use with MUI. Most of this data is stored in the resource configuration data for the particular file. When this structure is retrieved by <see cref="GetFileMUIInfo"/>, not all fields are necessarily filled in. The fields used depend on the flags that the application has passed to that function.
    /// <para><note>Your MUI applications can use the MUI macros to access this structure.</note></para>
    /// </summary>
    /// <remarks>
    /// <para>All offsets are from the base of the structure. An offset of 0 indicates that the data is not available.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/ns-winnls-filemuiinfo">FILEMUIINFO structure</a></para>
    /// </remarks>
    /// <seealso cref="GetFileMUIInfo"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/multilingual-user-interface">Multilingual User Interface</seealso>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/multilingual-user-interface-macros">Multilingual User Interface Macros</seealso>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/multilingual-user-interface-structures">Multilingual User Interface Structures</seealso>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FILEMUIINFO
    {
        public static readonly int SizeOf = SizeOf<FILEMUIINFO>.Bytes;

        /// <summary>
        /// Size of the structure, including the buffer, which can be extended past the 8 bytes declared. The minimum value allowed is <see cref="SizeOf"/>.
        /// </summary>
        public int dwSize;                 // Size of the structure including buffer size [in]
        /// <summary>
        /// Version of the structure. The current version is <see cref="MUI_FILEINFO_VERSION"/>.
        /// </summary>
        public int dwVersion;              // Version of the structure [in]
        /// <summary>
        /// The file type.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public MUI_FILETYPE dwFileType;             // Type of the file [out]
        #region public fixed byte pChecksum[16];
        /// <summary>
        /// Pointer to a 128-bit checksum for the file, if it is either an LN file or a language-specific resource file.
        /// </summary>
        internal fixed byte pChecksumField[16];          // Checksum of the file [out]
        /// <summary>
        /// A 128-bit checksum for the file, if it is either an LN file or a language-specific resource file.
        /// </summary>
        public Span<byte> pChecksum
        {
            get
            {
                fixed (byte* ptr = pServiceChecksumField)
                    return new Span<byte>(ptr, 16);
            }
        }
        #endregion
        #region public fixed byte pServiceChecksum[16];
        /// <summary>
        /// Pointer to a 128-bit checksum for the file, used for servicing.
        /// </summary>
        internal fixed byte pServiceChecksumField[16];   // Checksum of the file [out]
        /// <summary>
        /// A 128-bit checksum for the file, used for servicing.
        /// </summary>
        public Span<byte> pServiceChecksum
        {
            get
            {
                fixed (byte* ptr = pServiceChecksumField)
                    return new Span<byte>(ptr, 16);
            }
        }
        #endregion
        /// <summary>
        /// Offset, in bytes, from the beginning of the structure to the language name string for a language-specific resource file, or to the ultimate fallback language name string for an LN file.
        /// </summary>
        public int dwLanguageNameOffset;   // Language name of the file [out]
        /// <summary>
        /// Size of the array for which the offset is indicated by dwTypeIDMainOffset. The size also corresponds to the number of strings in the multi-string array indicated by <see cref="dwTypeNameMainOffset"/>.
        /// </summary>
        public int dwTypeIDMainSize;       // Number of TypeIDs in main module [out]
        /// <summary>
        /// Offset, in bytes, from the beginning of the structure to an <see cref="int"/> array enumerating the resource types contained in the LN file.
        /// </summary>
        public int dwTypeIDMainOffset;     // Array of TypeIDs (DWORD) in main module [out]
        /// <summary>
        /// Offset, in bytes, from the beginning of the structure to a series of null-terminated strings in a multi-string array enumerating the resource names contained in the LN file.
        /// </summary>
        public int dwTypeNameMainOffset;   // Multistring array of TypeNames in main module [out]
        /// <summary>
        /// Size of the array with the offset indicated by <see cref="dwTypeIDMUIOffset"/>. The size also corresponds to the number of strings in the series of strings indicated by <see cref="dwTypeNameMUIOffset"/>.
        /// </summary>
        public int dwTypeIDMUISize;        // Number of TypeIDs in MUI module [out]
        /// <summary>
        /// Offset, in bytes, from the beginning of the structure to an <see cref="int"/> array enumerating the resource types contained in the LN file.
        /// </summary>
        public int dwTypeIDMUIOffset;      // Array of TypeIDs (DWORD) in MUI module [out]
        /// <summary>
        /// Offset, in bytes, from the beginning of the structure to a multi-string array enumerating the resource names contained in the LN file.
        /// </summary>
        public int dwTypeNameMUIOffset;    // Multistring array of TypeNames in MUI module [out]
        #region public fixed byte abBuffer[8];
        internal fixed byte abBufferField[8];             // Buffer for extra data [in] (Size 4 is for padding)
        /// <summary>
        /// Remainder of the allocated memory for this structure. See the Remarks section for correct use of this array.
        /// </summary>
        public Span<byte> abBuffer
        {
            get
            {
                fixed (byte* ptr = abBufferField)
                    return new Span<byte>(ptr, 8);
            }
        }
        #endregion
    }

    /// <summary>
    /// A pointer to a MUI File info structure.
    /// </summary>
    /// <seealso cref="FILEMUIINFO"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct PFILEMUIINFO : IPointer<FILEMUIINFO>
    {
        private readonly IntPtr pointer;

        IntPtr IPointer.Pointer => pointer;

        internal ref FILEMUIINFO Value => ref pointer.AsRefStruct<FILEMUIINFO>();

        /// <inheritdoc cref="FILEMUIINFO.dwSize" />
        public ref int Size => ref Value.dwSize;
        /// <inheritdoc cref="FILEMUIINFO.dwVersion" />
        public ref int Version => ref Value.dwVersion;
        /// <inheritdoc cref="FILEMUIINFO.dwFileType" />
        public ref MUI_FILETYPE FileType => ref Value.dwFileType;
        /// <inheritdoc cref="FILEMUIINFO.pChecksum" />
        public Span<byte> Checksum => Value.pChecksum;
        /// <inheritdoc cref="FILEMUIINFO.pServiceChecksum" />
        public Span<byte> ServiceChecksum => Value.pServiceChecksum;

        /// <summary>
        /// A pointer to the language name string for a language-specific resource file, or to the ultimate fallback language name string for an LN file.
        /// </summary>
        public LPCWSTR LanguageName
        {
            get
            {
                ref FILEMUIINFO value = ref Value;
                int offset = value.dwLanguageNameOffset;
                if (offset == 0)
                    return default;
                return Pointer.Create<LPCWSTR>(pointer + offset);
            }
        }

        /// <summary>
        /// A span of resource type IDs contained in the LN file.
        /// </summary>
        public Span<int> TypeIDMain
        {
            get
            {
                ref FILEMUIINFO value = ref Value;
                int offset = value.dwTypeIDMainOffset;
                int length = value.dwTypeIDMainSize;
                if (offset == 0)
                    return Span<int>.Empty;
                return (pointer + offset).AsRefStructSpan<int>(length);
            }
        }

        /// <summary>
        /// A null-terminated multi-string pointer containing the resource names contained in the LN file.
        /// </summary>
        public LPCMWSTR TypeNameMain
        {
            get
            {
                ref FILEMUIINFO value = ref Value;
                int offset = value.dwTypeNameMainOffset;
                if (offset == 0)
                    return default;
                return Pointer.Create<LPCMWSTR>(pointer + offset);
            }
        }

        /// <summary>
        /// A span of the resource type IDs contained in the LN file.
        /// </summary>
        public Span<int> TypeIDMUI
        {
            get
            {
                ref FILEMUIINFO value = ref Value;
                int offset = value.dwTypeIDMUIOffset;
                int length = value.dwTypeIDMUISize;
                if (offset == 0)
                    return Span<int>.Empty;
                return (pointer + offset).AsRefStructSpan<int>(length);
            }
        }

        /// <summary>
        /// A null-terminated multi-string pointer containing the resource names contained in the LN file.
        /// </summary>
        public LPCMWSTR TypeNameMUI
        {
            get
            {
                ref FILEMUIINFO value = ref Value;
                int offset = value.dwTypeNameMUIOffset;
                if (offset == 0)
                    return default;
                return Pointer.Create<LPCMWSTR>(pointer + offset);
            }
        }

        /// <inheritdoc cref="FILEMUIINFO.abBuffer" />
        public Span<byte> Buffer => Value.abBuffer;
    }
}

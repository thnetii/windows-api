using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19604
    /// <inheritdoc cref="OSVERSIONINFOW"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct OSVERSIONINFOA
    {
        public static readonly int SizeOf = SizeOf<OSVERSIONINFOA>.Bytes;

        /// <summary>
        /// The size of this data structure, in bytes. Set this member to <see cref="SizeOf"/>.
        /// </summary>
        public int dwOSVersionInfoSize;
        /// <inheritdoc cref="OSVERSIONINFOW.dwMajorVersion"/>
        public int dwMajorVersion;
        /// <inheritdoc cref="OSVERSIONINFOW.dwMinorVersion"/>
        public int dwMinorVersion;
        /// <inheritdoc cref="OSVERSIONINFOW.dwBuildNumber"/>
        public int dwBuildNumber;
        /// <inheritdoc cref="OSVERSIONINFOW.dwPlatformId"/>
        internal int dwPlatformId;
        /// <inheritdoc cref="OSVERSIONINFOW.PlatformId"/>
        public VER_PLATFORM_ID PlatformId
        {
            get => (VER_PLATFORM_ID)dwPlatformId;
            set => dwPlatformId = (int)value;
        }
        #region internal fixed char szCSDVersion[128]
        internal fixed byte szCSDVersionField[128];
        /// <inheritdoc cref="OSVERSIONINFOW.szCSDVersion"/>
        public Span<byte> szCSDVersion
        {
            get
            {
                fixed (byte* ptr = szCSDVersionField)
                    return new Span<byte>(ptr, 128);
            }
        }
        /// <inheritdoc cref="OSVERSIONINFOW.CSDVersion"/>
        public string CSDVersion
        {
            get
            {
                fixed (byte* ptr = szCSDVersionField)
                    return FixedStringBuffer.MarshalAnsiString(ptr, 128);
            }
            set
            {
                fixed (byte* ptr = szCSDVersionField)
                    FixedStringBuffer.MarshalAnsiBytes(value, ptr, 128);
            }
        }
        #endregion
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19613
    /// <summary>
    /// Contains operating system version information. The information includes major and minor version numbers, a build number, a platform identifier, and descriptive text about the operating system. This structure is used with the <see cref="GetVersionEx"/> function.
    /// <para>To obtain additional version information, use the <see cref="OSVERSIONINFOEXW"/> structure with <see cref="GetVersionEx"/> instead.</para>
    /// </summary>
    /// <remarks>
    /// <para>Relying on version information is not the best way to test for a feature. Instead, refer to the documentation for the feature of interest. For more information on common techniques for feature detection, see <a href="https://docs.microsoft.com/windows/desktop/SysInfo/operating-system-version">Operating System Version</a>.</para>
    /// <para>If you must require a particular operating system, be sure to use it as a minimum supported version, rather than design the test for the one operating system. This way, your detection code will continue to work on future versions of Windows.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-osversioninfow">OSVERSIONINFOW structure</a></para>
    /// </remarks>
    /// <seealso cref="OSVERSIONINFOEX"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/version-helper-apis">Version Helper APIs</seealso>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct OSVERSIONINFOW
    {
        public static readonly int SizeOf = SizeOf<OSVERSIONINFOW>.Bytes;

        /// <summary>
        /// The size of this data structure, in bytes. Set this member to <see cref="SizeOf"/>.
        /// </summary>
        public int dwOSVersionInfoSize;
        /// <summary>
        /// The major version number of the operating system. For more information, see Remarks.
        /// </summary>
        public int dwMajorVersion;
        /// <summary>
        /// The minor version number of the operating system. For more information, see Remarks.
        /// </summary>
        public int dwMinorVersion;
        /// <summary>
        /// The build number of the operating system.
        /// </summary>
        public int dwBuildNumber;
        internal int dwPlatformId;
        /// <summary>
        /// The operating system platform. This member can be the following value.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="VER_PLATFORM_ID.VER_PLATFORM_WIN32_NT"/><br/><c>2</c></term><description>The operating system is Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003, Windows XP, or Windows 2000.</description></item>
        /// </list>
        /// </summary>
        public VER_PLATFORM_ID PlatformId
        {
            get => (VER_PLATFORM_ID)dwPlatformId;
            set => dwPlatformId = (int)value;
        }
        #region internal fixed char szCSDVersion[128]
        internal fixed char szCSDVersionField[128];
        /// <inheritdoc cref="CSDVersion"/>
        public Span<char> szCSDVersion
        {
            get
            {
                fixed (char* ptr = szCSDVersionField)
                    return new Span<char>(ptr, 128);
            }
        }

        /// <summary>
        /// A <see cref="string"/>, such as <c>"Service Pack 3"</c>, that includes the latest Service Pack installed on the system. If no Service Pack has been installed, the string is empty.
        /// </summary>
        public string CSDVersion
        {
            get
            {
                fixed (char* ptr = szCSDVersionField)
                    return FixedStringBuffer.MarshalUnicodeString(ptr, 128);
            }
            set
            {
                fixed (char* ptr = szCSDVersionField)
                    FixedStringBuffer.MarshalUnicodeChars(value, ptr, 128);
            }
        }
        #endregion
    }
}

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    using static VER_SUITE_FLAGS;
    using static VER_NT_TYPE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19631
    /// <inheritdoc cref="OSVERSIONINFOEXW"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct OSVERSIONINFOEXA
    {
        public static readonly int SizeOf = SizeOf<OSVERSIONINFOEXA>.Bytes;

        /// <summary>
        /// The size of this data structure, in bytes. Set this member to <see cref="SizeOf"/>.
        /// </summary>
        public int dwOSVersionInfoSize;
        /// <inheritdoc cref="OSVERSIONINFOEXW.dwMajorVersion"/>
        public int dwMajorVersion;
        /// <inheritdoc cref="OSVERSIONINFOEXW.dwMinorVersion"/>
        public int dwMinorVersion;
        /// <inheritdoc cref="OSVERSIONINFOEXW.dwBuildNumber"/>
        public int dwBuildNumber;
        /// <inheritdoc cref="OSVERSIONINFOEXW.dwPlatformId"/>
        internal int dwPlatformId;
        /// <inheritdoc cref="OSVERSIONINFOEXW.PlatformId"/>
        public VER_PLATFORM_ID PlatformId
        {
            get => (VER_PLATFORM_ID)dwPlatformId;
            set => dwPlatformId = (int)value;
        }
        #region internal fixed char szCSDVersion[128]
        internal fixed byte szCSDVersionField[128];
        /// <inheritdoc cref="OSVERSIONINFOEXW.szCSDVersion"/>
        public Span<byte> szCSDVersion
        {
            get
            {
                fixed (byte* ptr = szCSDVersionField)
                    return new Span<byte>(ptr, 128);
            }
        }
        /// <inheritdoc cref="OSVERSIONINFOEXW.CSDVersion"/>
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
        /// <inheritdoc cref="OSVERSIONINFOEXW.wServicePackMajor"/>
        public short wServicePackMajor;
        /// <inheritdoc cref="OSVERSIONINFOEXW.wServicePackMinor"/>
        public short wServicePackMinor;
        #region public VER_SUITE_FLAGS wSuiteMask;
        /// <inheritdoc cref="OSVERSIONINFOEXW.wServicePackMinor"/>
        internal short wSuiteMask;
        /// <inheritdoc cref="OSVERSIONINFOEXW.wServicePackMinor"/>
        public VER_SUITE_FLAGS SuiteMask
        {
            get => (VER_SUITE_FLAGS)wSuiteMask;
            set => wSuiteMask = (short)value;
        }
        #endregion
        #region public VER_NT_TYPE wProductType;
        /// <inheritdoc cref="OSVERSIONINFOEXW.wProductType"/>
        internal byte wProductType;
        /// <inheritdoc cref="OSVERSIONINFOEXW.ProductType"/>
        public VER_NT_TYPE ProductType
        {
            get => (VER_NT_TYPE)wProductType;
            set => wProductType = (byte)value;
        }
        #endregion
        /// <inheritdoc cref="OSVERSIONINFOEXW.wReserved"/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public byte wReserved;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19644
    /// <summary>
    /// Contains operating system version information. The information includes major and minor version numbers, a build number, a platform identifier, and information about product suites and the latest Service Pack installed on the system. This structure is used with the <see cref="GetVersionEx"/> and <see cref="VerifyVersionInfo"/> functions.
    /// </summary>
    /// <remarks>
    /// <para>Relying on version information is not the best way to test for a feature. Instead, refer to the documentation for the feature of interest. For more information on common techniques for feature detection, see <a href="https://docs.microsoft.com/windows/desktop/SysInfo/operating-system-version">Operating System Version</a>.</para>
    /// <para>If you must require a particular operating system, be sure to use it as a minimum supported version, rather than design the test for the one operating system. This way, your detection code will continue to work on future versions of Windows.</para>
    /// <para>You should not rely upon only the <see cref="VER_SUITE_SMALLBUSINESS"/> flag to determine whether Small Business Server has been installed on the system, as both this flag and the <see cref="VER_SUITE_SMALLBUSINESS_RESTRICTED"/> flag are set when this product suite is installed. If you upgrade this installation to Windows Server, Standard Edition, the <see cref="VER_SUITE_SMALLBUSINESS_RESTRICTED"/> flag will be cleared — however, the <see cref="VER_SUITE_SMALLBUSINESS"/> flag will remain set. In this case, this indicates that Small Business Server was once installed on this system. If this installation is further upgraded to Windows Server, Enterprise Edition, the <see cref="VER_SUITE_SMALLBUSINESS"/> flag will remain set.</para>
    /// <para>If compatibility mode is in effect, the <see cref="OSVERSIONINFOEXW"/> structure contains information about the operating system that is selected for <a href="http://go.microsoft.com/fwlink/p/?linkid=115300">application compatibility</a>.</para>
    /// <para>To determine whether a Win32-based application is running on WOW64, call the <see cref="IsWow64Process"/> function. To determine whether the system is running a 64-bit version of Windows, call the <see cref="GetNativeSystemInfo"/> function.</para>
    /// <para>
    /// The <see cref="GetSystemMetrics"/> function provides the following additional information about the current operating system.
    /// <list type="table">
    /// <listheader><term>Product</term><description>Setting</description></listheader>
    /// <item><term>Windows Server 2003 R2</term><description><strong>SM_SERVERR2</strong></description></item>
    /// <item><term>Windows XP Media Center Edition</term><description><strong>SM_MEDIACENTER</strong></description></item>
    /// <item><term>Windows XP Starter Edition</term><description><strong>SM_STARTER</strong></description></item>
    /// <item><term>Windows XP Tablet PC Edition</term><description><strong>SM_TABLETPC</strong></description></item>
    /// </list>
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-osversioninfoexw">OSVERSIONINFOEXW structure</a></para>
    /// </remarks>
    /// <seealso cref="IsWow64Process"/>
    /// <seealso cref="OSVERSIONINFOW"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/version-helper-apis">Version Helper APIs</seealso>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct OSVERSIONINFOEXW
    {
        public static readonly int SizeOf = SizeOf<OSVERSIONINFOEXW>.Bytes;

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
        /// <summary>
        /// The major version number of the latest Service Pack installed on the system. For example, for Service Pack 3, the major version number is 3. If no Service Pack has been installed, the value is zero.
        /// </summary>
        public short wServicePackMajor;
        /// <summary>
        /// The minor version number of the latest Service Pack installed on the system. For example, for Service Pack 3, the minor version number is 0.
        /// </summary>
        public short wServicePackMinor;
        #region public VER_SUITE_FLAGS wSuiteMask;
        internal short wSuiteMask;
        /// <summary>
        /// A bit mask that identifies the product suites available on the system.
        /// </summary>
        public VER_SUITE_FLAGS SuiteMask
        {
            get => (VER_SUITE_FLAGS)wSuiteMask;
            set => wSuiteMask = (short)value;
        }
        #endregion
        #region public VER_NT_TYPE wProductType;
        internal byte wProductType;
        /// <summary>
        /// Any additional information about the system.
        /// </summary>
        public VER_NT_TYPE ProductType
        {
            get => (VER_NT_TYPE)wProductType;
            set => wProductType = (byte)value;
        }
        #endregion
        /// <summary>Reserved for future use.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public byte wReserved;
    }
}

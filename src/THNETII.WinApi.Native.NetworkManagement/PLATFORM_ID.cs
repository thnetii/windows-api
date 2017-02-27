namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The platform ID indicates the levels to use for platform-specific
    /// information.
    /// </summary>
    public enum PLATFORM_ID : int
    {
        /// <summary>The MS-DOS platform.</summary>
        PLATFORM_ID_DOS = 300,
        /// <summary>The OS/2 platform.</summary>
        PLATFORM_ID_OS2 = 400,
        /// <summary>The Windows NT platform.</summary>
        PLATFORM_ID_NT = 500,
        /// <summary>The OSF platform.</summary>
        PLATFORM_ID_OSF = 600,
        /// <summary>The VMS platform.</summary>
        PLATFORM_ID_VMS = 700,
    }
}
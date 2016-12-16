namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Specifies the possible ways that a device can be joined to Microsoft Azure Active Directory.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/mt481424.aspx">DSREG_JOIN_TYPE enumeration</a></para>
    /// </remarks>
    public enum DSREG_JOIN_TYPE
    {
        /// <summary>The type of join is not known.</summary>
        DSREG_UNKNOWN_JOIN = 0,
        /// <summary>The device is joined to Azure Active Directory (Azure AD).</summary>
        DSREG_DEVICE_JOIN = 1,
        /// <summary>An Azure AD work account is added on the device.</summary>
        DSREG_WORKPLACE_JOIN = 2
    }
}

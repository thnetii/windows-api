using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// One of these values indicates the parameter within an information
    /// structure that is invalid when <see cref="ERROR_INVALID_PARAMETER"/> is returned by
    /// <see cref="NetWkstaUserSetInfo"/>.
    /// </summary>
    public enum WKSTA_USER_INFO_PARMNUM : int
    {
        /// <summary><var>wkui*_oth_domains</var></summary>
        WKSTA_OTH_DOMAINS_PARMNUM = 101
    }
}
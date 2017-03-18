using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// One of these values indicates the parameter within an information
    /// structure that is invalid when <see cref="ERROR_INVALID_PARAMETER"/> is returned by
    /// <see cref="NetUseAdd"/>.
    /// </summary>
    public enum USE_INFO_PARMNUM : int
    {
        /// <summary><var>ui*_local</var></summary>
        USE_LOCAL_PARMNUM = 1,
        /// <summary><var>ui*_remote</var></summary>
        USE_REMOTE_PARMNUM = 2,
        /// <summary><var>ui*_password</var></summary>
        USE_PASSWORD_PARMNUM = 3,
        /// <summary><var>ui*_asgtype</var></summary>
        USE_ASGTYPE_PARMNUM = 4,
        /// <summary><var>ui*_username</var></summary>
        USE_USERNAME_PARMNUM = 5,
        /// <summary><var>ui*_domainname</var></summary>
        USE_DOMAINNAME_PARMNUM = 6,
    }
}

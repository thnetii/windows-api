using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Values for <var>ParmError</var> for <see cref="NetUserSetInfo"/>.
    /// </summary>
    public enum USER_INFO_PARMNUM : int
    {
        USER_NAME_PARMNUM = 1,
        USER_PASSWORD_PARMNUM = 3,
        USER_PASSWORD_AGE_PARMNUM = 4,
        USER_PRIV_PARMNUM = 5,
        USER_HOME_DIR_PARMNUM = 6,
        USER_COMMENT_PARMNUM = 7,
        USER_FLAGS_PARMNUM = 8,
        USER_SCRIPT_PATH_PARMNUM = 9,
        USER_AUTH_FLAGS_PARMNUM = 10,
        USER_FULL_NAME_PARMNUM = 11,
        USER_USR_COMMENT_PARMNUM = 12,
        USER_PARMS_PARMNUM = 13,
        USER_WORKSTATIONS_PARMNUM = 14,
        USER_LAST_LOGON_PARMNUM = 15,
        USER_LAST_LOGOFF_PARMNUM = 16,
        USER_ACCT_EXPIRES_PARMNUM = 17,
        USER_MAX_STORAGE_PARMNUM = 18,
        USER_UNITS_PER_WEEK_PARMNUM = 19,
        USER_LOGON_HOURS_PARMNUM = 20,
        USER_PAD_PW_COUNT_PARMNUM = 21,
        USER_NUM_LOGONS_PARMNUM = 22,
        USER_LOGON_SERVER_PARMNUM = 23,
        USER_COUNTRY_CODE_PARMNUM = 24,
        USER_CODE_PAGE_PARMNUM = 25,
        USER_PRIMARY_GROUP_PARMNUM = 51,
        USER_PROFILE = 52, // ?? Delete when convenient
        USER_PROFILE_PARMNUM = 52,
        USER_HOME_DIR_DRIVE_PARMNUM = 53,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
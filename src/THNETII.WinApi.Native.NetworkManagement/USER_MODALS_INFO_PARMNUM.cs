namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// parmnum manifests for user modals
    /// </summary>
    public enum USER_MODALS_INFO_PARMNUM : int
    {
        /// <summary><var>usrmod*_min_passwd_len</var></summary>
        MODALS_MIN_PASSWD_LEN_PARMNUM = 1,
        /// <summary><var>usrmod*_max_passwd_age</var></summary>
        MODALS_MAX_PASSWD_AGE_PARMNUM = 2,
        /// <summary><var>usrmod*_min_passwd_age</var></summary>
        MODALS_MIN_PASSWD_AGE_PARMNUM = 3,
        /// <summary><var>usrmod*_force_logoff</var></summary>
        MODALS_FORCE_LOGOFF_PARMNUM = 4,
        /// <summary><var>usrmod*_passwd_hist_len</var></summary>
        MODALS_PASSWD_HIST_LEN_PARMNUM = 5,
        /// <summary><var>usrmod*_role</var></summary>
        MODALS_ROLE_PARMNUM = 6,
        /// <summary><var>usrmod*_primary</var></summary>
        MODALS_PRIMARY_PARMNUM = 7,
        /// <summary><var>usrmod*_domain_name</var></summary>
        MODALS_DOMAIN_NAME_PARMNUM = 8,
        /// <summary><var>usrmod*_domain_id</var></summary>
        MODALS_DOMAIN_ID_PARMNUM = 9,
        /// <summary><var>usrmod*_lockout_duration</var></summary>
        MODALS_LOCKOUT_DURATION_PARMNUM = 10,
        /// <summary><var>usrmod*_lockout_observation_window</var></summary>
        MODALS_LOCKOUT_OBSERVATION_WINDOW_PARMNUM = 11,
        /// <summary><var>usrmod*_lockout_threshold</var></summary>
        MODALS_LOCKOUT_THRESHOLD_PARMNUM = 12,
    }
}
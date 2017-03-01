using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static class LanManAccessConstants
    {
        /// <summary>
        /// For SetInfo call (parmnum 0) when password change not required
        /// </summary>
        public const string NULL_USERSETINFO_PASSWD = "              ";

        public const int TIMEQ_FOREVER = -1;
        public const uint USER_MAXSTORAGE_UNLIMITED = unchecked((uint)-1);
        public const int USER_NO_LOGOFF = -1;
        public const int UNITS_PER_DAY = 24;
        public const int UNITS_PER_WEEK = UNITS_PER_DAY * 7;

        //
        // user modals related defaults
        //

        public const int MAX_PASSWD_LEN = PWLEN;
        public const int DEF_MIN_PWLEN = 6;
        public const int DEF_PWUNIQUENESS = 5;
        public const int DEF_MAX_PWHIST = 8;

        /// <summary>forever</summary>
        public const int DEF_MAX_PWAGE = TIMEQ_FOREVER;
        /// <summary>0 days</summary>
        public const int DEF_MIN_PWAGE = 0;
        /// <summary>never</summary>
        public const int DEF_FORCE_LOGOFF = unchecked((int)0xffffffff);
        /// <summary>no limit</summary>
        public const int DEF_MAX_BADPW = 0;
        /// <summary>01 day</summary>
        public const int ONE_DAY = 01 * 24 * 3600;
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

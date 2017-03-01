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
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

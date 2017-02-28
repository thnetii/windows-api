namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    public static class LanManServerConstants
    {
        /// <summary>
        /// Mask to be applied to <strong>svX_version_major</strong> in order to obtain
        /// the major version number.
        /// </summary>
        public const int MAJOR_VERSION_MASK = 0x0F;

        /// <summary>
        /// Special value for <strong>svX_disc</strong> that specifies infinite disconnect
        /// time.
        /// </summary>
        public const int SV_NODISC = (-1);  /* No autodisconnect timeout enforced */

        /// <summary>The server is not visible.</summary>
        public const bool SV_HIDDEN = true;
        /// <summary>The server is visible.</summary>
        public const bool SV_VISIBLE = false;

        /// <summary>
        /// Equate for use with <see cref="SERVER_INFO_102.sv102_licenses"/>.
        /// </summary>
        public const int SV_USERS_PER_LICENSE = 5;

        

    }
}

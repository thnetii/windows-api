namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Contains constants used throughout the LAN Manager API.
    /// <para>
    /// <note>
    /// Lengths of strings are given as the maximum lengths of the
    /// string in characters(not bytes).
    /// </note>
    /// <para>
    /// Definitions of the form <c>LM20_*</c> define those values in effect for
    /// LanMan 2.0.
    /// </para>
    /// </para>
    /// </summary>
    public static class LanManConstants
    {
        //
        // String Lengths for various LanMan names
        //

        /// <summary>Computer name length</summary>
        public const int CNLEN = 15;
        /// <summary>LM 2.0 Computer name length</summary>
        public const int LM20_CNLEN = 15;
        /// <summary>Maximum domain name length</summary>
        public const int DNLEN = CNLEN;
        /// <summary>LM 2.0 Maximum domain name length</summary>
        public const int LM20_DNLEN = LM20_CNLEN;

        /// <summary>UNC computer name length</summary>
        public const int UNCLEN = (CNLEN + 2);
        /// <summary>LM 2.0 UNC computer name length</summary>
        public const int LM20_UNCLEN = (LM20_CNLEN + 2);

        /// <summary>Net name length (share name)</summary>
        public const int NNLEN = 80;
        /// <summary>LM 2.0 Net name length</summary>
        public const int LM20_NNLEN = 12;

        /// <summary>Max remote name length</summary>
        public const int RMLEN = (UNCLEN + 1 + NNLEN);
        /// <summary>LM 2.0 Max remote name length</summary>
        public const int LM20_RMLEN = (LM20_UNCLEN + 1 + LM20_NNLEN);

        /// <summary>Service name length</summary>
        public const int SNLEN = 80;
        /// <summary>LM 2.0 Service name length</summary>
        public const int LM20_SNLEN = 15;
        /// <summary>Service text length</summary>
        public const int STXTLEN = 256;
        /// <summary>LM 2.0 Service text length</summary>
        public const int LM20_STXTLEN = 63;

        /// <summary>Max. path (not including drive name)</summary>
        public const int PATHLEN = 256;
        /// <summary>LM 2.0 Max. path</summary>
        public const int LM20_PATHLEN = 256;

        /// <summary>Device name length</summary>
        public const int DEVLEN = 80;
        /// <summary>LM 2.0 Device name length</summary>
        public const int LM20_DEVLEN = 8;

        /// <summary>Event name length</summary>
        public const int EVLEN = 16;

        //
        // User, Group and Password lengths
        // 

        /// <summary>Maximum user name length</summary>
        public const int UNLEN = 256;
        /// <summary>LM 2.0 Maximum user name length</summary>
        public const int LM20_UNLEN = 20;

        /// <summary>Group name</summary>
        public const int GNLEN = UNLEN;
        /// <summary>LM 2.0 Group name</summary>
        public const int LM20_GNLEN = LM20_UNLEN;

        /// <summary>Maximum password length</summary>
        public const int PWLEN = 256;
        /// <summary>LM 2.0 Maximum password length</summary>
        public const int LM20_PWLEN = 14;

        /// <summary>Share password length (bytes)</summary>
        public const int SHPWLEN = 8;


        /// <summary>Length of client type string</summary>
        public const int CLTYPE_LEN = 12;


        /// <summary>Multipurpose comment length</summary>
        public const int MAXCOMMENTSZ = 256;
        /// <summary>LM 2.0 Multipurpose comment length</summary>
        public const int LM20_MAXCOMMENTSZ = 48;

        /// <summary>Queue name maximum length</summary>
        public const int QNLEN = NNLEN;
        /// <summary>LM 2.0 Queue name maximum length</summary>
        public const int LM20_QNLEN = LM20_NNLEN;

        //
        // The ALERTSZ and MAXDEVENTRIES defines have not yet been NT'ized.
        // Whoever ports these components should change these values appropriately.
        //

        /// <summary>size of alert string in server</summary>
        public const int ALERTSZ = 128;
        /// <summary>Max number of device entries</summary>
        public const int MAXDEVENTRIES = (sizeof(int) * 8);

        //
        // We use int bitmap to represent
        //

        /// <summary>NetBIOS net name (bytes)</summary>
        public const int NETBIOS_NAME_LEN = 16;

        /// <summary>
        /// Value to be used with APIs which have a "preferred maximum length"
        /// parameter.  This value indicates that the API should just allocate
        /// "as much as it takes."
        /// </summary>
        public const int MAX_PREFERRED_LENGTH = -1;


        //
        //        Constants used with encryption
        //

        public const int CRYPT_KEY_LEN = 7;
        public const int CRYPT_TXT_LEN = 8;
        public const int ENCRYPTED_PWLEN = 16;
        public const int SESSION_PWLEN = 24;
        public const int SESSION_CRYPT_KLEN = 21;

        /// <summary>
        /// Value to be used with SetInfo calls to allow setting of all
        /// settable parameters (parmnum zero option)
        /// </summary>
        public const int PARMNUM_ALL = 0;

        public const int PARM_ERROR_UNKNOWN = (-1);
        public const int PARM_ERROR_NONE = 0;
        public const int PARMNUM_BASE_INFOLEVEL = 1000;

        //
        //        Message File Names
        //

        public const string MESSAGE_FILENAME = ("NETMSG");
        public const string OS2MSG_FILENAME = ("BASE");
        public const string HELP_MSG_FILENAME = ("NETH");

        // INTERNAL_ONLY

        // The backup message file named here is a duplicate of net.msg. It
        // is not shipped with the product, but is used at buildtime to
        // msgbind certain messages to netapi.dll and some of the services.
        // This allows for OEMs to modify the message text in net.msg and
        // have those changes show up.        Only in case there is an error in
        // retrieving the messages from net.msg do we then get the bound
        // messages out of bak.msg (really out of the message segment).

        public const string BACKUP_MSG_FILENAME = ("BAK.MSG");

        //END_INTERNAL

        //
        //      Names of standard Microsoft-defined alert events.
        //

        public const string ALERT_PRINT_EVENT = "PRINTING";
        public const string ALERT_MESSAGE_EVENT = "MESSAGE";
        public const string ALERT_ERRORLOG_EVENT = "ERRORLOG";
        public const string ALERT_ADMIN_EVENT = "ADMIN";
        public const string ALERT_USER_EVENT = "USER";

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

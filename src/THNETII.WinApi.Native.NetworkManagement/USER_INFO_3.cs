using System;
using System.Collections;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.ACCOUNT_OPERATOR_FLAGS;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManAccessConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.USER_FLAGS;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.USER_PRIVILEGE_LEVEL;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_3"/> structure contains information about a user account, including the account name, password data, privilege level, the path to the user's home directory, relative identifiers (RIDs), and other user-related network statistics.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="USER_INFO_3"/> structure can be used with the <see cref="NetUserAdd"/>, <see cref="NetUserEnum"/> , <see cref="NetUserSetInfo"/>, and <see cref="NetUserGetInfo"/> functions.</para>
    /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
    /// <para>Note that the <see cref="USER_INFO_4"/> structure supersedes the <see cref="USER_INFO_3"/> structure on Windows XP and later. It is recommended that applications use the <see cref="USER_INFO_4"/> structure instead of the <see cref="USER_INFO_3"/> structure with the <see cref="NetUserAdd"/>, <see cref="NetUserSetInfo"/>, and <see cref="NetUserGetInfo"/> functions on Windows XP and later.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371338.aspx">USER_INFO_3 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserAdd"/>
    /// <seealso cref="NetUserEnum"/>
    /// <seealso cref="NetUserSetInfo"/>
    /// <seealso cref="NetUserGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_3
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 00, 00, 00, DateTimeKind.Utc);

        /// <summary>
        /// A string that specifies the name of the user account. For the <see cref="NetUserSetInfo"/> function, this member is ignored. For more information, see the type's Remarks section.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri3_name;
        /// <summary>
        /// A string that specifies the password of the user indicated by the <see cref="usri3_name"/> member. The length cannot exceed <see cref="PWLEN"/> bytes. The <see cref="NetUserEnum"/> and <see cref="NetUserGetInfo"/> functions return <c>null</c> to maintain password security. 
        /// <para>By convention, the length of passwords is limited to <see cref="LM20_PWLEN"/> characters.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri3_password;
        /// <summary>
        /// The number of seconds that have elapsed since the <see cref="usri3_password"/> member was last changed. The <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions ignore this member.
        /// </summary>
        public int usri3_password_age;
        /// <summary>
        /// The level of privilege assigned to the <see cref="usri3_name"/> member. When you call the <see cref="NetUserAdd"/> function, this member must be <see cref="USER_PRIV_USER"/>. When you call the <see cref="NetUserSetInfo"/> function, this member must be the value returned by the <see cref="NetUserGetInfo"/> function or the <see cref="NetUserEnum"/> function. For more information about user and group account rights, see <a href="https://msdn.microsoft.com/en-us/library/aa379306.aspx">Privileges</a>. 
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public USER_PRIVILEGE_LEVEL usri3_priv;
        /// <summary>
        /// A string specifying the path of the home directory for the user specified in the <see cref="usri3_name"/> member. The string can be <c>null</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri3_home_dir;
        /// <summary>
        /// A string that contains a comment to associate with the user account. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri3_comment;
        /// <summary>
        /// <para>Note that setting user account control flags may require certain privileges and control access rights. For more information, see the Remarks section of the <see cref="NetUserSetInfo"/> function.</para>
        /// <para>Only one account type value can be set. You cannot change the account type using the <see cref="NetUserSetInfo"/> function.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public USER_FLAGS usri3_flags;
        /// <summary>
        /// A string specifying the path for the user's logon script file. The script file can be a .CMD file, an .EXE file, or a .BAT file. The string can also be <c>null</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri3_script_path;
        /// <summary>
        /// <para>The user's operator privileges. </para>
        /// <para>Calls to the <see cref="NetUserGetInfo"/> and <see cref="NetUserEnum"/> functions return a value based on the user's local group membership. If the user is a member of Print Operators, <see cref="AF_OP_PRINT"/> is set. If the user is a member of Server Operators, <see cref="AF_OP_SERVER"/> is set. If the user is a member of the Account Operators, <see cref="AF_OP_ACCOUNTS"/> is set. <see cref="AF_OP_COMM"/> is never set. For more information about user and group account rights, see <a href="https://msdn.microsoft.com/en-us/library/aa379306.aspx">Privileges</a>.</para>
        /// <para>
        /// The following restrictions apply:
        /// <list type="bullet">
        /// <item>When you call the <see cref="NetUserAdd"/> function, this member must be zero.</item>
        /// <item>When you call the <see cref="NetUserSetInfo"/> function, this member must be the value returned from a call to <see cref="NetUserGetInfo"/> or to <see cref="NetUserEnum"/>.</item>
        /// </list>
        /// </para>
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public ACCOUNT_OPERATOR_FLAGS usri3_auth_flags;
        /// <summary>
        /// A string that contains the full name of the user. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri3_full_name;
        /// <summary>
        /// A string that contains a user comment. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri3_usr_comment;
        /// <summary>
        /// A string that is reserved for use by applications. This string can be a <c>null</c> string, or it can have any number of characters. Microsoft products use this member to store user configuration information. Do not modify this information.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri3_parms;
        /// <summary>
        /// A string that contains the names of workstations from which the user can log on. As many as eight workstations can be specified; the names must be separated by commas. A <c>null</c> string indicates that there is no restriction. To disable logons from all workstations to this account, set the <see cref="UF_ACCOUNTDISABLE"/> value in the <see cref="usri3_flags"/> member.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri3_workstations;
        /// <summary>
        /// <para>The date and time when the last logon occurred. This value is stored as the number of seconds that have elapsed since 00:00:00, January 1, 1970, GMT. This member is ignored by the <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions. </para>
        /// <para>This member is maintained separately on each backup domain controller (BDC) in the domain. To obtain an accurate value, you must query each BDC in the domain. The last logon occurred at the time indicated by the largest retrieved value.</para>
        /// </summary>
        public int usri3_last_logon;
        /// <summary>
        /// The date and time when the last logon occurred, expressed as a <see cref="DateTime"/> value using the local time of the system.
        /// </summary>
        /// <seealso cref="usri3_last_logon"/>
        public DateTime LastLogon => epoch.AddSeconds((uint)usri3_last_logon).ToLocalTime();
        /// <summary>
        /// <para>This member is currently not used.</para>
        /// <para>Indicates when the last logoff occurred. This value is stored as the number of seconds that have elapsed since 00:00:00, January 1, 1970, GMT. A value of zero indicates that the last logoff time is unknown.</para>
        /// <para>This member is maintained separately on each backup domain controller (BDC) in the domain. To obtain an accurate value, you must query each BDC in the domain. The last logoff occurred at the time indicated by the largest retrieved value.</para>
        /// </summary>
        public int usri3_last_logoff;
        /// <summary>
        /// Indicates when the last logoff occurred, expressed as a <see cref="DateTime"/> value using the local time of the system.
        /// </summary>
        /// <seealso cref="usri3_last_logoff"/>
        public DateTime LastLogoff => (usri3_last_logoff == 0 ? default(DateTime) : epoch.AddSeconds((uint)usri3_last_logoff).ToLocalTime());
        /// <summary>
        /// The date and time when the account expires. This value is stored as the number of seconds elapsed since 00:00:00, January 1, 1970, GMT. A value of <see cref="TIMEQ_FOREVER"/> indicates that the account never expires.
        /// </summary>
        public int usri3_acct_expires;
        /// <summary>
        /// The date and time when the account expires, expressed as a <see cref="DateTime"/> value using the local time of the system.
        /// <para>A value of <see cref="DateTime.MaxValue"/> indicates that the account never expires.</para>
        /// </summary>
        public DateTime AccountExpires
        {
            get { return usri3_acct_expires == TIMEQ_FOREVER ? DateTime.MaxValue : epoch.AddSeconds((uint)usri3_acct_expires).ToLocalTime(); }
            set
            {
                if (value == default(DateTime))
                    usri3_acct_expires = 0;
                else if (value == DateTime.MaxValue)
                    usri3_acct_expires = TIMEQ_FOREVER;
                else
                    usri3_acct_expires = (int)((uint)(value - epoch).TotalSeconds);
            }
        }
        /// <summary>
        /// The maximum amount of disk space the user can use. Specify <see cref="USER_MAXSTORAGE_UNLIMITED"/> to use all available disk space.
        /// </summary>
        public uint usri3_max_storage;
        /// <summary>
        /// <para>The number of equal-length time units into which the week is divided. This value is required to compute the length of the bit string in the <see cref="usri3_logon_hours"/> member. </para>
        /// <para>This value must be <see cref="UNITS_PER_WEEK"/> for LAN Manager 2.0. This element is ignored by the <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions.</para>
        /// </summary>
        public int usri3_units_per_week;
        /// <summary>
        /// <para>A pointer to a 21-byte (168 bits) bit string that specifies the times during which the user can log on. Each bit represents a unique hour in the week, in Greenwich Mean Time (GMT). </para>
        /// <para>The first bit (bit 0, word 0) is Sunday, 0:00 to 0:59; the second bit (bit 1, word 0) is Sunday, 1:00 to 1:59; and so on. Note that bit 0 in word 0 represents Sunday from 0:00 to 0:59 only if you are in the GMT time zone. In all other cases you must adjust the bits according to your time zone offset (for example, GMT minus 8 hours for Pacific Standard Time).</para>
        /// <para>Specify a <c>null</c> pointer in this member when calling the <see cref="NetUserAdd"/> function to indicate no time restriction. Specify a <c>null</c> pointer when calling the <see cref="NetUserSetInfo"/> function to indicate that no change is to be made to the times during which the user can log on.</para>
        /// </summary>
        public ByteArrayAnySafeHandle usri3_logon_hours;
        /// <summary>
        /// Gets the marshaled bit array containing the logon hours during which the user can log on.
        /// </summary>
        /// <returns>A bit array containing exactly <see cref="usri3_units_per_week"/> bits, or zero bits if <see cref="usri3_logon_hours"/> is <c>null</c>.</returns>
        /// <seealso cref="usri3_logon_hours"/>
        /// <seealso cref="usri3_units_per_week"/>
        public BitArray GetLogonHoursBitArray() => new BitArray(ByteArraySafeHandle.ReadValue(usri3_logon_hours, usri3_units_per_week / 8) ?? new byte[0]);
        /// <summary>
        /// <para>The number of times the user tried to log on to the account using an incorrect password. A value of <c>-1</c> indicates that the value is unknown. Calls to the <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions ignore this member. </para>
        /// <para>This member is replicated from the primary domain controller (PDC); it is also maintained on each backup domain controller (BDC) in the domain. To obtain an accurate value, you must query each BDC in the domain. The number of times the user tried to log on using an incorrect password is the largest value retrieved.</para>
        /// </summary>
        public int usri3_bad_pw_count;
        /// <summary>
        /// <para>The number of times the user logged on successfully to this account. A value of <c>-1</c> indicates that the value is unknown. Calls to the <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions ignore this member. </para>
        /// <para>This member is maintained separately on each backup domain controller (BDC) in the domain. To obtain an accurate value, you must query each BDC in the domain. The number of times the user logged on successfully is the sum of the retrieved values.</para>
        /// </summary>
        public int usri3_num_logons;
        /// <summary>
        /// A string that contains the name of the server to which logon requests are sent. Server names should be preceded by two backslashes (\\). To indicate that the logon request can be handled by any logon server, specify an asterisk (\\*) for the server name. A <c>null</c> string indicates that requests should be sent to the domain controller. 
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri3_logon_server;
        /// <summary>The country/region code for the user's language of choice.</summary>
        public int usri3_country_code;
        /// <summary>The code page for the user's language of choice.</summary>
        public int usri3_code_page;
        /// <summary>
        /// The relative ID (RID) of the user. The RID is determined by the Security Account Manager (SAM) when the user is created. It uniquely defines the user account to SAM within the domain. The <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions ignore this member. For more information about RIDs, see <a href="https://msdn.microsoft.com/en-us/library/aa379597.aspx">SID Components</a>.
        /// </summary>
        public int usri3_user_id;
        /// <summary>
        /// The RID of the Primary Global Group for the user. When you call the <see cref="NetUserAdd"/> function, this member must be <var>DOMAIN_GROUP_RID_USERS</var>. When you call <see cref="NetUserSetInfo"/>, this member must be the RID of a global group in which the user is enrolled. For more information, see <strong><a href="https://msdn.microsoft.com/en-us/library/aa379649.aspx">Well-Known SIDs</a></strong>.
        /// </summary>
        public int usri3_primary_group_id;
        /// <summary>
        /// A string that specifies a path to the user's profile. This value can be a <c>null</c> string, a local absolute path, or a UNC path.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri3_profile;
        /// <summary>
        /// A string that specifies the drive letter assigned to the user's home directory for logon purposes.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri3_home_dir_drive;
        /// <summary>
        /// <para>The password expiration information. </para>
        /// <para>The <see cref="NetUserGetInfo"/> and <see cref="NetUserEnum"/> functions return <c>false</c> if the password has not expired (and <c>true</c> if it has).</para>
        /// <para>When you call <see cref="NetUserAdd"/> or <see cref="NetUserSetInfo"/>, specify a <c>true</c> value in this member to inform users that they must change their password at the next logon. To turn off this message, call <see cref="NetUserSetInfo"/> and specify <c>false</c> in this member. Note that you cannot specify <c>false</c> to negate the expiration of a password that has already expired.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool usri3_password_expired;
    }
}

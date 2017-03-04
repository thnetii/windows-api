using System;
using System.Collections;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_11"/> structure contains information about a user account, including the account name, privilege level, the path to the user's home directory, and other user-related network statistics.
    /// </summary>
    /// <remarks>
    /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371106.aspx">USER_INFO_11 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserAdd"/>
    /// <seealso cref="NetUserDel"/>
    /// <seealso cref="NetUserEnum"/>
    /// <seealso cref="NetUserGetInfo"/>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_11
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 00, 00, 00, DateTimeKind.Utc);

        /// <summary>
        /// A string that specifies the name of the user account. Calls to the <see cref="NetUserSetInfo"/> function ignore this member. For more information, see the type's Remarks section.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri11_name;
        /// <summary>
        /// A string that contains a comment to associate with the user account. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri11_comment;
        /// <summary>
        /// A string that contains a user comment. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri11_usr_comment;
        /// <summary>
        /// A string that contains the full name of the user. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri11_full_name;
        /// <summary>
        /// The level of privilege assigned to the <see cref="usri11_name"/> member. When you call the <see cref="NetUserAdd"/> function, this member must be <see cref="USER_PRIV_USER"/>. When you call the <see cref="NetUserSetInfo"/> function, this member must be the value returned by the <see cref="NetUserGetInfo"/> function or the <see cref="NetUserEnum"/> function. For more information about user and group account rights, see <a href="https://msdn.microsoft.com/en-us/library/aa379306.aspx">Privileges</a>. 
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public USER_PRIVILEGE_LEVEL usri11_priv;
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
        public ACCOUNT_OPERATOR_FLAGS usri11_auth_flags;
        /// <summary>
        /// The number of seconds that have elapsed since the password was last changed. The <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions ignore this member.
        /// </summary>
        public int usri11_password_age;
        /// <summary>
        /// The time that has elapsed since the password was last changed.
        /// </summary>
        public TimeSpan PasswordAge => TimeSpan.FromSeconds(usri11_password_age);
        /// <summary>
        /// A string specifying the path of the home directory for the user specified in the <see cref="usri11_name"/> member. The string can be <c>null</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri11_home_dir;
        /// <summary>
        /// A string that is reserved for use by applications. This string can be a <c>null</c> string, or it can have any number of characters. Microsoft products use this member to store user configuration information. Do not modify this information.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri11_parms;
        /// <summary>
        /// <para>The date and time when the last logon occurred. This value is stored as the number of seconds that have elapsed since 00:00:00, January 1, 1970, GMT. This member is ignored by the <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions. </para>
        /// <para>This member is maintained separately on each backup domain controller (BDC) in the domain. To obtain an accurate value, you must query each BDC in the domain. The last logon occurred at the time indicated by the largest retrieved value.</para>
        /// </summary>
        public int usri11_last_logon;
        /// <summary>
        /// The date and time when the last logon occurred, expressed as a <see cref="DateTime"/> value using the local time of the system.
        /// </summary>
        /// <seealso cref="usri11_last_logon"/>
        public DateTime LastLogon => epoch.AddSeconds((uint)usri11_last_logon).ToLocalTime();
        /// <summary>
        /// <para>This member is currently not used.</para>
        /// <para>Indicates when the last logoff occurred. This value is stored as the number of seconds that have elapsed since 00:00:00, January 1, 1970, GMT. A value of zero indicates that the last logoff time is unknown.</para>
        /// <para>This member is maintained separately on each backup domain controller (BDC) in the domain. To obtain an accurate value, you must query each BDC in the domain. The last logoff occurred at the time indicated by the largest retrieved value.</para>
        /// </summary>
        public int usri11_last_logoff;
        /// <summary>
        /// Indicates when the last logoff occurred, expressed as a <see cref="DateTime"/> value using the local time of the system.
        /// </summary>
        /// <seealso cref="usri11_last_logoff"/>
        public DateTime LastLogoff => (usri11_last_logoff == 0 ? default(DateTime) : epoch.AddSeconds((uint)usri11_last_logoff).ToLocalTime());
        /// <summary>
        /// <para>The number of times the user tried to log on to the account using an incorrect password. A value of <c>-1</c> indicates that the value is unknown. Calls to the <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions ignore this member. </para>
        /// <para>This member is replicated from the primary domain controller (PDC); it is also maintained on each backup domain controller (BDC) in the domain. To obtain an accurate value, you must query each BDC in the domain. The number of times the user tried to log on using an incorrect password is the largest value retrieved.</para>
        /// </summary>
        public int usri11_bad_pw_count;
        /// <summary>
        /// <para>The number of times the user logged on successfully to this account. A value of <c>-1</c> indicates that the value is unknown. Calls to the <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions ignore this member. </para>
        /// <para>This member is maintained separately on each backup domain controller (BDC) in the domain. To obtain an accurate value, you must query each BDC in the domain. The number of times the user logged on successfully is the sum of the retrieved values.</para>
        /// </summary>
        public int usri11_num_logons;
        /// <summary>
        /// A string that contains the name of the server to which logon requests are sent. Server names should be preceded by two backslashes (\\). To indicate that the logon request can be handled by any logon server, specify an asterisk (\\*) for the server name. A <c>null</c> string indicates that requests should be sent to the domain controller. 
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri11_logon_server;
        /// <summary>The country/region code for the user's language of choice.</summary>
        public int usri11_country_code;
        /// <summary>
        /// A string that contains the names of workstations from which the user can log on. As many as eight workstations can be specified; the names must be separated by commas. A <c>null</c> string indicates that there is no restriction. To disable logons from all workstations to this account, set the <see cref="UF_ACCOUNTDISABLE"/> value in the <see cref="usri11_flags"/> member.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri11_workstations;
        /// <summary>
        /// The maximum amount of disk space the user can use. Specify <see cref="USER_MAXSTORAGE_UNLIMITED"/> to use all available disk space.
        /// </summary>
        public uint usri11_max_storage;
        /// <summary>
        /// <para>The number of equal-length time units into which the week is divided. This value is required to compute the length of the bit string in the <see cref="usri11_logon_hours"/> member. </para>
        /// <para>This value must be <see cref="UNITS_PER_WEEK"/> for LAN Manager 2.0. This element is ignored by the <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions.</para>
        /// </summary>
        public int usri11_units_per_week;
        /// <summary>
        /// <para>A pointer to a 21-byte (168 bits) bit string that specifies the times during which the user can log on. Each bit represents a unique hour in the week, in Greenwich Mean Time (GMT). </para>
        /// <para>The first bit (bit 0, word 0) is Sunday, 0:00 to 0:59; the second bit (bit 1, word 0) is Sunday, 1:00 to 1:59; and so on. Note that bit 0 in word 0 represents Sunday from 0:00 to 0:59 only if you are in the GMT time zone. In all other cases you must adjust the bits according to your time zone offset (for example, GMT minus 8 hours for Pacific Standard Time).</para>
        /// <para>Specify a <c>null</c> pointer in this member when calling the <see cref="NetUserAdd"/> function to indicate no time restriction. Specify a <c>null</c> pointer when calling the <see cref="NetUserSetInfo"/> function to indicate that no change is to be made to the times during which the user can log on.</para>
        /// </summary>
        public ByteArrayAnySafeHandle usri11_logon_hours;
        /// <summary>
        /// Gets the marshaled bit array containing the logon hours during which the user can log on.
        /// </summary>
        /// <returns>A bit array containing exactly <see cref="usri11_units_per_week"/> bits, or zero bits if <see cref="usri11_logon_hours"/> is <c>null</c>.</returns>
        /// <seealso cref="usri11_logon_hours"/>
        /// <seealso cref="usri11_units_per_week"/>
        public BitArray GetLogonHoursBitArray() => new BitArray(ByteArraySafeHandle.ReadValue(usri11_logon_hours, usri11_units_per_week / 8) ?? new byte[0]);
        /// <summary>The code page for the user's language of choice.</summary>
        public int usri11_code_page;
    }
}

using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="NET_VALIDATE_PERSISTED_FIELDS"/> structure contains information about a user's password properties. Input to and output from the <see cref="NetValidatePasswordPolicy"/> function contain persistent password-related data. When the function outputs this structure, it identifies the persistent data that has changed in this call.
    /// </summary>
    /// <remarks>
    /// <para>Note that it is the application's responsibility to save all changed persistent data as well as any user object information. The next time the application calls <see cref="NetValidatePasswordPolicy"/> on the same instance of the user object, the application must provide the required fields from the persistent information.</para>
    /// <para>The <see cref="NET_VALIDATE_AUTHENTICATION_INPUT_ARG"/>, <see cref="NET_VALIDATE_PASSWORD_CHANGE_INPUT_ARG"/>, <see cref="NET_VALIDATE_PASSWORD_RESET_INPUT_ARG"/>, and <see cref="NET_VALIDATE_OUTPUT_ARG"/> structures contain a <see cref="NET_VALIDATE_PERSISTED_FIELDS"/> structure.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370690.aspx">NET_VALIDATE_PERSISTED_FIELDS structure</a></para>
    /// </remarks>
    /// <seealso cref="NetValidatePasswordPolicy"/>
    [StructLayout(LayoutKind.Sequential)]
    public class NET_VALIDATE_PERSISTED_FIELDS
    {
        /// <summary>
        /// A set of bit flags identifying the persistent password-related data that has changed. This member is valid only when this structure is output from the <see cref="NetValidatePasswordPolicy"/> function. This member is ignored when this structure is input to the function. For more information, see the following Remarks section.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public NET_VALIDATE_FIELDS PresentFields;
        /// <summary>
        /// The date and time (in GMT) when the password for the account was set or last changed.
        /// </summary>
        public long PasswordLastSet;
        /// <summary>
        /// The date and time (in GMT) when the password for the account was set or last changed.
        /// </summary>
        public DateTime PasswordLastSetDateTime
        {
            get { return DateTime.FromFileTimeUtc(PasswordLastSet); }
            set { PasswordLastSet = value.ToFileTimeUtc(); }
        }
        /// <summary>
        /// The date and time (in GMT) when the user tried to log on to the account using an incorrect password.
        /// </summary>
        public long BadPasswordTime;
        /// <summary>
        /// The date and time (in GMT) when the user tried to log on to the account using an incorrect password.
        /// </summary>
        public DateTime BadPasswordDateTime
        {
            get { return DateTime.FromFileTimeUtc(BadPasswordTime); }
            set { BadPasswordTime = value.ToFileTimeUtc(); }
        }
        /// <summary>
        /// The date and time (in GMT) when the account was last locked out. If the account has not been locked out, this member is zero. A lockout occurs when the number of bad password logins exceeds the number allowed.
        /// </summary>
        public long LockoutTime;
        /// <summary>
        /// The date and time (in GMT) when the account was last locked out. If the account has not been locked out, the <see cref="LockoutTime"/> member is zero. A lockout occurs when the number of bad password logins exceeds the number allowed.
        /// </summary>
        public DateTime LockoutDateTime
        {
            get { return DateTime.FromFileTimeUtc(LockoutTime); }
            set { LockoutTime = value.ToFileTimeUtc(); }
        }
        /// <summary>The number of times the user tried to log on to the account using an incorrect password.</summary>
        public int BadPasswordCount;
        /// <summary>The number of previous passwords saved in the history list for the account. The user cannot reuse a password in the history list.</summary>
        public int PasswordHistoryLength;
        /// <summary>
        /// A Safe Handle for a <see cref="NET_VALIDATE_PASSWORD_HASH"/> structure that contains the password hashes in the history list.
        /// </summary>
        public SafeHandle<NET_VALIDATE_PASSWORD_HASH> PasswordHistory;
    }
}

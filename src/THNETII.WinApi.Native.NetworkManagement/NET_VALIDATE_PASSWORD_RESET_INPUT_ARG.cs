using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// A client application passes the <see cref="NET_VALIDATE_PASSWORD_RESET_INPUT_ARG"/> structure to the <see cref="NetValidatePasswordPolicy"/> function when the application requests a password reset validation.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370689.aspx">NET_VALIDATE_PASSWORD_RESET_INPUT_ARG structure</a></para>
    /// </remarks>
    /// <seealso cref="NetValidatePasswordPolicy"/>
    [StructLayout(LayoutKind.Sequential)]
    public class NET_VALIDATE_PASSWORD_RESET_INPUT_ARG
    {
        /// <summary>
        /// Specifies a <see cref="NET_VALIDATE_PERSISTED_FIELDS"/> structure that contains persistent password-related information about the account being logged on.
        /// </summary>
        public NET_VALIDATE_PERSISTED_FIELDS InputPersistedFields;
        /// <summary>
        /// A Unicode string specifying the new password, in plaintext format.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string ClearPassword;
        /// <summary>
        /// A Unicode string specifying the name of the user account.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string UserAccountName;
        /// <summary>
        /// Specifies a <see cref="NET_VALIDATE_PASSWORD_HASH"/> structure that contains a hash of the new password.
        /// </summary>
        public NET_VALIDATE_PASSWORD_HASH HashedPassword;
        /// <summary>
        /// <see cref="bool"/> value that indicates whether the user must change his or her password at the next logon. If this parameter is <c>true</c>, the user must change the password at the next logon.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public bool PasswordMustChangeAtNextLogon;
        /// <summary>
        /// <see cref="bool"/> value that can reset the "lockout state" of the user account. If this member is <c>true</c>, the account will no longer be locked out. Note that an application cannot directly lock out an account. An account can be locked out only as a result of exceeding the maximum number of invalid password authentications allowed for the account.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public bool ClearLockout;
    }
}

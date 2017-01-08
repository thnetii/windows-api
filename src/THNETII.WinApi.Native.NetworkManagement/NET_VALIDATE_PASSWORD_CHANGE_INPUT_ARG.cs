using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// A client application passes the <see cref="NET_VALIDATE_PASSWORD_CHANGE_INPUT_ARG"/> structure to the <see cref="NetValidatePasswordPolicy"/> function when the application requests a password change validation.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370687.aspx">NET_VALIDATE_PASSWORD_CHANGE_INPUT_ARG structure</a></para>
    /// </remarks>
    /// <seealso cref="NetValidatePasswordPolicy"/>
    [StructLayout(LayoutKind.Sequential)]
    public class NET_VALIDATE_PASSWORD_CHANGE_INPUT_ARG
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
        /// <see cref="bool"/> value that indicates the result of the application's attempt to validate the old password supplied by the user. If this parameter is <c>false</c>, the password was not validated.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public bool PasswordMatched;
    }
}

using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// A client application passes the <see cref="NET_VALIDATE_AUTHENTICATION_INPUT_ARG"/> structure to the <see cref="NetValidatePasswordPolicy"/> function when the application requests an authentication validation.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370685.aspx">NET_VALIDATE_AUTHENTICATION_INPUT_ARG structure</a></para>
    /// </remarks>
    /// <seealso cref="NetValidatePasswordPolicy"/>
    [StructLayout(LayoutKind.Sequential)]
    public class NET_VALIDATE_AUTHENTICATION_INPUT_ARG
    {
        /// <summary>
        /// Specifies a <see cref="NET_VALIDATE_PERSISTED_FIELDS"/> structure that contains persistent password-related information about the account being logged on.
        /// </summary>
        public NET_VALIDATE_PERSISTED_FIELDS InputPersistedFields;
        /// <summary>
        /// <see cref="bool"/> value that indicates the result of the client application's authentication of the password supplied by the user. If this parameter is <c>false</c>, the password has not been authenticated.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public bool PasswordMatched;
    }
}

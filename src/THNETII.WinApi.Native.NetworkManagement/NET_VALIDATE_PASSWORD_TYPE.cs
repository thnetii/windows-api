namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum NET_VALIDATE_PASSWORD_TYPE
    {
        /// <summary>The application is requesting password validation during authentication.</summary>
        NetValidateAuthentication = 1,
        /// <summary>The application is requesting password validation during a password change operation.</summary>
        NetValidatePasswordChange,
        /// <summary>The application is requesting password validation during a password reset operation.</summary>
        NetValidatePasswordReset,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

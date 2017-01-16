namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Privilege Set Control flags
    /// </summary>
    public enum PRIVILEGE_SET_CONTROL : int
    {
        /// <summary>
        /// All of the specified privileges must be held by the <em><a href="https://msdn.microsoft.com/en-us/library/ms721603.aspx#_security_process_gly">process</a></em> requesting access.
        /// </summary>
        PRIVILEGE_SET_ALL_NECESSARY = (1)
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
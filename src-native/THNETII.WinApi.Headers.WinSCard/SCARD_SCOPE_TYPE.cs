namespace THNETII.WinApi.Native.WinSCard
{
    public enum SCARD_SCOPE_TYPE
    {
        /// <summary>
        /// The context is a user context, and any
        /// database operations are performed within the
        /// domain of the user.
        /// </summary>
        SCARD_SCOPE_USER = WinSCardConstants.SCARD_SCOPE_USER,
        /// <summary>
        /// The context is that of the current terminal,
        /// and any database operations are performed
        /// within the domain of that terminal.  (The
        /// calling application must have appropriate
        /// access permissions for any database actions.)
        /// </summary>
        SCARD_SCOPE_TERMINAL = WinSCardConstants.SCARD_SCOPE_TERMINAL,
        /// <summary>
        /// The context is the system context, and any
        /// database operations are performed within the
        /// domain of the system.  (The calling
        /// application must have appropriate access
        /// permissions for any database actions.)
        /// </summary>
        SCARD_SCOPE_SYSTEM = WinSCardConstants.SCARD_SCOPE_SYSTEM,
    }
}

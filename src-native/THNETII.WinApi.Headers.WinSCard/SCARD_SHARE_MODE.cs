namespace THNETII.WinApi.Native.WinSCard
{
    public enum SCARD_SHARE_MODE
    {
        /// <summary>
        /// This application is not willing to share this
        /// card with other applications.
        /// </summary>
        SCARD_SHARE_EXCLUSIVE = WinSCardConstants.SCARD_SHARE_EXCLUSIVE,
        /// <summary>
        /// This application is willing to share this
        /// card with other applications.
        /// </summary>
        SCARD_SHARE_SHARED = WinSCardConstants.SCARD_SHARE_SHARED,
        /// <summary>
        /// This application demands direct control of
        /// the reader, so it is not available to other
        /// applications.
        /// </summary>
        SCARD_SHARE_DIRECT = WinSCardConstants.SCARD_SHARE_DIRECT,
    }
}

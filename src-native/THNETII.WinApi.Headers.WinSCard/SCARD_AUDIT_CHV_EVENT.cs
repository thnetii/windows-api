namespace THNETII.WinApi.Native.WinSCard
{
    public enum SCARD_AUDIT_CHV_EVENT
    {
        /// <summary>
        /// A smart card holder verification (CHV)
        /// attempt failed.
        /// </summary>
        SCARD_AUDIT_CHV_FAILURE = WinSCardConstants.SCARD_AUDIT_CHV_FAILURE,

        /// <summary>
        /// A smart card holder verification (CHV)
        /// attempt succeeded.
        /// </summary>
        SCARD_AUDIT_CHV_SUCCESS = WinSCardConstants.SCARD_AUDIT_CHV_SUCCESS,
    }
}

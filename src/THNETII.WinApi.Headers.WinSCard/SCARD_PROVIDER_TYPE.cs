namespace THNETII.WinApi.Native.WinSCard
{
    public enum SCARD_PROVIDER_TYPE
    {
        /// <summary>
        /// Primary Provider Id
        /// </summary>
        SCARD_PROVIDER_PRIMARY = WinSCardConstants.SCARD_PROVIDER_PRIMARY,
        /// <summary>
        /// Crypto Service Provider Id
        /// </summary>
        SCARD_PROVIDER_CSP = WinSCardConstants.SCARD_PROVIDER_CSP,
        /// <summary>
        /// Key Storage Provider Id
        /// </summary>
        SCARD_PROVIDER_KSP = WinSCardConstants.SCARD_PROVIDER_KSP,
        /// <summary>
        /// Id of the card module name
        /// </summary>
        SCARD_PROVIDER_CARD_MODULE = unchecked((int)0x80000001),
    }
}

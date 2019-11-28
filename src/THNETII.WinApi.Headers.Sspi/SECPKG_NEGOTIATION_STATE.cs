namespace THNETII.WinApi.Native.Sspi
{
    public enum SECPKG_NEGOTIATION_STATE
    {
        /// <summary>Negotiation has been completed. </summary>
        SECPKG_NEGOTIATION_COMPLETE = SspiConstants.SECPKG_NEGOTIATION_COMPLETE,
        /// <summary>Negotiations not yet completed. </summary>
        SECPKG_NEGOTIATION_OPTIMISTIC = SspiConstants.SECPKG_NEGOTIATION_OPTIMISTIC,
        /// <summary>Negotiations in progress.</summary>
        SECPKG_NEGOTIATION_IN_PROGRESS = SspiConstants.SECPKG_NEGOTIATION_IN_PROGRESS,
        SECPKG_NEGOTIATION_DIRECT = SspiConstants.SECPKG_NEGOTIATION_DIRECT,
        SECPKG_NEGOTIATION_TRY_MULTICRED = SspiConstants.SECPKG_NEGOTIATION_TRY_MULTICRED,
    }
}

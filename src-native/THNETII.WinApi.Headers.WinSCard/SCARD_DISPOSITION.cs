namespace THNETII.WinApi.Native.WinSCard
{
    public enum SCARD_DISPOSITION
    {
        /// <summary>
        /// Don't do anything special on close
        /// </summary>
        SCARD_LEAVE_CARD = WinSCardConstants.SCARD_LEAVE_CARD,
        /// <summary>
        /// Reset the card on close
        /// </summary>
        SCARD_RESET_CARD = WinSCardConstants.SCARD_RESET_CARD,
        /// <summary>
        /// Power down the card on close
        /// </summary>
        SCARD_UNPOWER_CARD = WinSCardConstants.SCARD_UNPOWER_CARD,
        /// <summary>
        /// Eject the card on close
        /// </summary>
        SCARD_EJECT_CARD = WinSCardConstants.SCARD_EJECT_CARD,
    }
}

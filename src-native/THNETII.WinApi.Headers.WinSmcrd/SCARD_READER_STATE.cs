namespace THNETII.WinApi.Native.WinSmcrd
{
    public enum SCARD_READER_STATE
    {
        /// <summary>
        /// This value implies the driver is unaware
        /// of the current state of the reader.
        /// </summary>
        SCARD_UNKNOWN = WinSmcrdConstants.SCARD_UNKNOWN,
        /// <summary>
        /// This value implies there is no card in
        /// the reader.
        /// </summary>
        SCARD_ABSENT = WinSmcrdConstants.SCARD_ABSENT,
        /// <summary>
        /// This value implies there is a card is
        /// present in the reader, but that it has
        /// not been moved into position for use.
        /// </summary>
        SCARD_PRESENT = WinSmcrdConstants.SCARD_PRESENT,
        /// <summary>
        /// This value implies there is a card in the
        /// reader in position for use.  The card is
        /// not powered.
        /// </summary>
        SCARD_SWALLOWED = WinSmcrdConstants.SCARD_SWALLOWED,
        /// <summary>
        /// This value implies there is power is
        /// being provided to the card, but the
        /// Reader Driver is unaware of the mode of
        /// the card.
        /// </summary>
        SCARD_POWERED = WinSmcrdConstants.SCARD_POWERED,
        /// <summary>
        /// This value implies the card has been
        /// reset and is awaiting PTS negotiation.
        /// </summary>
        SCARD_NEGOTIABLE = WinSmcrdConstants.SCARD_NEGOTIABLE,
        /// <summary>
        /// This value implies the card has been
        /// reset and specific communication
        /// protocols have been established.
        /// </summary>
        SCARD_SPECIFIC = WinSmcrdConstants.SCARD_SPECIFIC,
    }
}

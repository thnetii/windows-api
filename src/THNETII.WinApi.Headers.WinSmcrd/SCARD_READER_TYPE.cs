namespace THNETII.WinApi.Native.WinSmcrd
{
    /// <summary>
    /// Type of reader
    /// </summary>
    public enum SCARD_READER_TYPE
    {
        /// <summary> Serial reader </summary>
        SCARD_READER_TYPE_SERIAL = WinSmcrdConstants.SCARD_READER_TYPE_SERIAL,
        /// <summary>Parallel reader </summary>
        SCARD_READER_TYPE_PARALELL = WinSmcrdConstants.SCARD_READER_TYPE_PARALELL,
        /// <summary>Keyboard-attached reader </summary>
        SCARD_READER_TYPE_KEYBOARD = WinSmcrdConstants.SCARD_READER_TYPE_KEYBOARD,
        /// <summary>SCSI reader </summary>
        SCARD_READER_TYPE_SCSI = WinSmcrdConstants.SCARD_READER_TYPE_SCSI,
        /// <summary>IDE reader </summary>
        SCARD_READER_TYPE_IDE = WinSmcrdConstants.SCARD_READER_TYPE_IDE,
        /// <summary>USB reader </summary>
        SCARD_READER_TYPE_USB = WinSmcrdConstants.SCARD_READER_TYPE_USB,
        /// <summary>PCMCIA reader </summary>
        SCARD_READER_TYPE_PCMCIA = WinSmcrdConstants.SCARD_READER_TYPE_PCMCIA,
        /// <summary>Reader that uses a TPM chip for key material storage and cryptographic operations </summary>
        SCARD_READER_TYPE_TPM = WinSmcrdConstants.SCARD_READER_TYPE_TPM,
        SCARD_READER_TYPE_NFC = WinSmcrdConstants.SCARD_READER_TYPE_NFC,
        SCARD_READER_TYPE_UICC = WinSmcrdConstants.SCARD_READER_TYPE_UICC,
        SCARD_READER_TYPE_NGC = WinSmcrdConstants.SCARD_READER_TYPE_NGC,
        SCARD_READER_TYPE_EMBEDDEDSE = WinSmcrdConstants.SCARD_READER_TYPE_EMBEDDEDSE,
        /// <summary>Reader that uses a proprietary vendor bus </summary>
        SCARD_READER_TYPE_VENDOR = WinSmcrdConstants.SCARD_READER_TYPE_VENDOR,
    }
}

namespace THNETII.WinApi.Native.WinCrypt
{
    public enum ALG_CLASS
    {
        ALG_CLASS_ANY = WinCryptConstants.ALG_CLASS_ANY,
        ALG_CLASS_SIGNATURE = WinCryptConstants.ALG_CLASS_SIGNATURE,
        ALG_CLASS_MSG_ENCRYPT = WinCryptConstants.ALG_CLASS_MSG_ENCRYPT,
        ALG_CLASS_DATA_ENCRYPT = WinCryptConstants.ALG_CLASS_DATA_ENCRYPT,
        ALG_CLASS_HASH = WinCryptConstants.ALG_CLASS_HASH,
        ALG_CLASS_KEY_EXCHANGE = WinCryptConstants.ALG_CLASS_KEY_EXCHANGE,
        ALG_CLASS_ALL = WinCryptConstants.ALG_CLASS_ALL,
    }
}

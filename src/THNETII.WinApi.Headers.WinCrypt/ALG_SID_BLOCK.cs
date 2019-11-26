namespace THNETII.WinApi.Native.WinCrypt
{
    /// <summary>
    /// Block cipher sub ids
    /// </summary>
    public enum ALG_SID_BLOCK
    {
        // DES sub_ids
        ALG_SID_DES = WinCryptConstants.ALG_SID_DES,
        ALG_SID_3DES = WinCryptConstants.ALG_SID_3DES,
        ALG_SID_DESX = WinCryptConstants.ALG_SID_DESX,
        ALG_SID_IDEA = WinCryptConstants.ALG_SID_IDEA,
        ALG_SID_CAST = WinCryptConstants.ALG_SID_CAST,
        ALG_SID_SAFERSK64 = WinCryptConstants.ALG_SID_SAFERSK64,
        ALG_SID_SAFERSK128 = WinCryptConstants.ALG_SID_SAFERSK128,
        ALG_SID_3DES_112 = WinCryptConstants.ALG_SID_3DES_112,
        ALG_SID_CYLINK_MEK = WinCryptConstants.ALG_SID_CYLINK_MEK,
        ALG_SID_RC5 = WinCryptConstants.ALG_SID_RC5,
        ALG_SID_AES_128 = WinCryptConstants.ALG_SID_AES_128,
        ALG_SID_AES_192 = WinCryptConstants.ALG_SID_AES_192,
        ALG_SID_AES_256 = WinCryptConstants.ALG_SID_AES_256,
        ALG_SID_AES = WinCryptConstants.ALG_SID_AES,

        // Fortezza sub-ids
        ALG_SID_SKIPJACK = WinCryptConstants.ALG_SID_SKIPJACK,
        ALG_SID_TEK = WinCryptConstants.ALG_SID_TEK,

        // RC2 sub-ids
        ALG_SID_RC2 = WinCryptConstants.ALG_SID_RC2,
    }
}

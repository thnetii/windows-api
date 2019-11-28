namespace THNETII.WinApi.Native.WinCrypt
{
    /// <summary>
    /// Secure channel sub ids
    /// </summary>
    public enum ALG_SID_SCHANNEL
    {
        ALG_SID_SSL3_MASTER = WinCryptConstants.ALG_SID_SSL3_MASTER,
        ALG_SID_SCHANNEL_MASTER_HASH = WinCryptConstants.ALG_SID_SCHANNEL_MASTER_HASH,
        ALG_SID_SCHANNEL_MAC_KEY = WinCryptConstants.ALG_SID_SCHANNEL_MAC_KEY,
        ALG_SID_PCT1_MASTER = WinCryptConstants.ALG_SID_PCT1_MASTER,
        ALG_SID_SSL2_MASTER = WinCryptConstants.ALG_SID_SSL2_MASTER,
        ALG_SID_TLS1_MASTER = WinCryptConstants.ALG_SID_TLS1_MASTER,
        ALG_SID_SCHANNEL_ENC_KEY = WinCryptConstants.ALG_SID_SCHANNEL_ENC_KEY,
    }
}

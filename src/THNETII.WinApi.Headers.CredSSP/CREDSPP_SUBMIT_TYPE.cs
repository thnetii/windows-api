namespace THNETII.WinApi.Native.CredSSP
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\credssp.h, line 54
    /// <summary>
    /// The <see cref="CREDSPP_SUBMIT_TYPE"/> enumeration specifies the type of credentials specified by a <see cref="CREDSSP_CRED"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/credssp/ne-credssp-credspp_submit_type">CREDSPP_SUBMIT_TYPE Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="CREDSSP_CRED"/>
    public enum CREDSPP_SUBMIT_TYPE
    {
        /// <summary>The credentials are a user name and password.</summary>
        CredsspPasswordCreds = 2,
        /// <summary>The credentials are Schannel credentials.</summary>
        CredsspSchannelCreds = 4,
        /// <summary>The credentials are in a certificate.</summary>
        CredsspCertificateCreds = 13,
        /// <summary>The credentials contain both certificate and Schannel credentials.</summary>
        CredsspSubmitBufferBoth = 50,
        /// <summary/>
        CredsspSubmitBufferBothOld = 51,
        /// <summary/>
        CredsspCredEx = 100,
    }
}

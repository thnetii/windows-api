using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.CredSSP
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\credssp.h, line 63
    /// <summary>
    /// The <see cref="CREDSSP_CRED"/> structure specifies authentication data for both Schannel and Negotiate <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security packages</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/credssp/ns-credssp-credssp_cred">CREDSSP_CRED structure</a></para>
    /// </remarks>
    /// <seealso cref="AcquireCredentialsHandle"/>
    /// <seealso cref="CREDSPP_SUBMIT_TYPE"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CREDSSP_CRED
    {
        /// <summary>
        /// The <see cref="CREDSPP_SUBMIT_TYPE"/> enumeration value that specifies the type of credentials contained in this structure.
        /// </summary>
        public CREDSPP_SUBMIT_TYPE Type;
        /// <summary>
        /// A pointer to a set of Schannel credentials.
        /// </summary>
        public IntPtr pSchannelCred;
        /// <summary>
        /// A pointer to a set of Negotiate credentials.
        /// </summary>
        public IntPtr pSpnegoCred;
    }
}

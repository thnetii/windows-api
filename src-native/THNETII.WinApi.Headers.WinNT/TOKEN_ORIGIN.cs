using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10876
    /// <summary>
    /// The <see cref="TOKEN_ORIGIN"/> structure contains information about the origin of the logon session. This structure is used by the <see cref="GetTokenInformation"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_origin">TOKEN_ORIGIN structure</a></para>
    /// </remarks>
    /// <seealso cref="GetTokenInformation"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_ORIGIN
    {
        /// <summary>
        /// <a href="https://msdn.microsoft.com/65dd9a04-fc7c-4179-95ff-dac7dad4668f">Locally unique identifier</a> (LUID) for the <a href="https://msdn.microsoft.com/65dd9a04-fc7c-4179-95ff-dac7dad4668f">logon session</a>. If the token passed to <see cref="GetTokenInformation"/> resulted from a logon using explicit credentials, such as passing name, domain, and password to the <see cref="LogonUser"/> function, then this member will contain the ID of the logon session that created it. If the token resulted from network authentication, such as a call to <see cref="AcceptSecurityContext"/>, or a call to <see cref="LogonUser"/> with <em>dwLogonType</em> set to <see cref="LOGON32_LOGON_NETWORK"/> or <see cref="LOGON32_LOGON_NETWORK_CLEARTEXT"/>, then this member will be zero.
        /// </summary>
        public LUID OriginatingLogonSession;
    }
}

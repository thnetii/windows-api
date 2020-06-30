using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10814
    /// <summary>
    /// The <see cref="TOKEN_MANDATORY_POLICY"/> structure specifies the mandatory integrity policy for a token.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_mandatory_policy">TOKEN_MANDATORY_POLICY structure</a></para>
    /// </remarks>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_MANDATORY_POLICY
    {
        /// <summary>
        /// The mandatory integrity access policy for the associated token.
        /// </summary>
        public TOKEN_MANDATORY_POLICY_FLAGS Policy;
    }
}

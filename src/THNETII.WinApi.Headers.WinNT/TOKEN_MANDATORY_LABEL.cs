using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10799
    /// <summary>
    /// The <see cref="TOKEN_MANDATORY_LABEL"/> structure specifies the mandatory integrity level for a token.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_mandatory_label">TOKEN_MANDATORY_LABEL structure</a></para>
    /// </remarks>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_MANDATORY_LABEL
    {
        /// <summary>
        /// A <see cref="SID_AND_ATTRIBUTES"/> structure that specifies the mandatory integrity level of the token.
        /// </summary>
        public SID_AND_ATTRIBUTES Label;
    }
}

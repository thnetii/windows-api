using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10842
    /// <summary>
    /// The <see cref="TOKEN_AUDIT_POLICY"/> structure specifies the per user audit policy for a token.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_audit_policy">TOKEN_AUDIT_POLICY structure</a></para>
    /// </remarks>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct TOKEN_AUDIT_POLICY
    {
        /// <summary>
        /// Specifies the per user audit policy for the token.
        /// </summary>
        public fixed byte PerUserPolicy[((POLICY_AUDIT_SUBCATEGORY_COUNT) >> 1) + 1];
    }
}

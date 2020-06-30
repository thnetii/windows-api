using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10869
    /// <summary>
    /// The <see cref="TOKEN_CONTROL"/> structure contains information that identifies an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access token</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_control">TOKEN_CONTROL structure</a></para>
    /// </remarks>
    /// <seealso cref="LUID"/>
    /// <seealso cref="TOKEN_CONTROL"/>
    /// <seealso cref="TOKEN_DEFAULT_DACL"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    /// <seealso cref="TOKEN_OWNER"/>
    /// <seealso cref="TOKEN_PRIMARY_GROUP"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    /// <seealso cref="TOKEN_SOURCE"/>
    /// <seealso cref="TOKEN_STATISTICS"/>
    /// <seealso cref="TOKEN_TYPE"/>
    /// <seealso cref="TOKEN_USER"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_CONTROL
    {
        /// <summary>
        /// Specifies a <a href="https://msdn.microsoft.com/65dd9a04-fc7c-4179-95ff-dac7dad4668f">locally unique identifier</a> (LUID) identifying this instance of the token object.
        /// </summary>
        public LUID TokenId;
        /// <summary>
        /// Specifies a <a href="https://msdn.microsoft.com/65dd9a04-fc7c-4179-95ff-dac7dad4668f">locally unique identifier</a> (LUID) assigned to the <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">session</a> this token represents. There can be many tokens representing a single <a href="https://msdn.microsoft.com/65dd9a04-fc7c-4179-95ff-dac7dad4668f">logon session</a>.
        /// </summary>
        public LUID AuthenticationId;
        /// <summary>
        /// Specifies a <a href="https://msdn.microsoft.com/65dd9a04-fc7c-4179-95ff-dac7dad4668f">locally unique identifier</a> (LUID) that changes each time the token is modified. An application can use this value as a test of whether a <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security context</a> has changed since it was last used.
        /// </summary>
        public LUID ModifiedId;
        /// <summary>
        /// Specifies a <see cref="TOKEN_SOURCE"/> structure identifying the agency that issued the token. This information is used in audit trails.
        /// </summary>
        public TOKEN_SOURCE TokenSource;
    }
}

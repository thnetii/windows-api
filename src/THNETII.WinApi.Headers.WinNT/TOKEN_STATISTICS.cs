using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Principal;

using static THNETII.WinApi.Native.WinNT.TOKEN_TYPE;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10854
    /// <summary>
    /// The <see cref="TOKEN_STATISTICS"/> structure contains information about an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access token</a>. An application can retrieve this information by calling the <see cref="GetTokenInformation"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-token_statistics">TOKEN_STATISTICS structure</a></para>
    /// </remarks>
    /// <seealso cref="GetTokenInformation"/>
    /// <seealso cref="LUID"/>
    /// <seealso cref="TokenImpersonationLevel"/>
    /// <seealso cref="TOKEN_CONTROL"/>
    /// <seealso cref="TOKEN_DEFAULT_DACL"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    /// <seealso cref="TOKEN_OWNER"/>
    /// <seealso cref="TOKEN_PRIMARY_GROUP"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    /// <seealso cref="TOKEN_SOURCE"/>
    /// <seealso cref="TOKEN_TYPE"/>
    /// <seealso cref="TOKEN_USER"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_STATISTICS
    {
        /// <summary>
        /// Specifies a locally unique identifier (LUID) that identifies this instance of the token object.
        /// </summary>
        public LUID TokenId;
        /// <summary>
        /// Specifies an LUID assigned to the <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">session</a> this token represents. There can be many tokens representing a single <a href="https://msdn.microsoft.com/65dd9a04-fc7c-4179-95ff-dac7dad4668f">logon session</a>.
        /// </summary>
        public LUID AuthenticationId;
        /// <summary>
        /// Specifies the time at which this token expires. Expiration times for access tokens are not currently supported.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ulong ExpirationTime;
        /// <summary>
        /// Specifies a <see cref="TOKEN_TYPE"/> enumeration type indicating whether the token is a <a href="https://msdn.microsoft.com/2fe6cfd3-8a2e-4dbe-9fb8-332633daa97a">primary</a> or <a href="https://msdn.microsoft.com/af511aed-88f5-4b12-ad44-317925297f70">impersonation token</a>.
        /// </summary>
        public TOKEN_TYPE TokenType;
        /// <summary>
        /// Specifies a <see cref="TokenImpersonationLevel"/> enumeration type indicating the impersonation level of the token. This member is valid only if the <see cref="TokenType"/> is <see cref="TokenImpersonation"/>.
        /// </summary>
        public TokenImpersonationLevel ImpersonationLevel;
        /// <summary>
        /// Specifies the amount, in bytes, of memory allocated for storing default protection and a primary group identifier.
        /// </summary>
        public int DynamicCharged;
        /// <summary>
        /// Specifies the portion of memory allocated for storing default protection and a primary group identifier not already in use. This value is returned as a count of free bytes.
        /// </summary>
        public int DynamicAvailable;
        /// <summary>
        /// Specifies the number of supplemental group <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifiers</a> (SIDs) included in the token.
        /// </summary>
        public int GroupCount;
        /// <summary>
        /// Specifies the number of privileges included in the token.
        /// </summary>
        public int PrivilegeCount;
        /// <summary>
        /// Specifies an LUID that changes each time the token is modified. An application can use this value as a test of whether a <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security context</a> has changed since it was last used.
        /// </summary>
        public LUID ModifiedId;
    }
}

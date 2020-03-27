using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10761
    /// <summary>
    /// The <see cref="TOKEN_PRIMARY_GROUP"/> structure specifies a group <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifier</a> (SID) for an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access token</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_primary_group">TOKEN_PRIMARY_GROUP structure</a></para>
    /// </remarks>
    /// <seealso cref="GetTokenInformation"/>
    /// <seealso cref="SID"/>
    /// <seealso cref="SetTokenInformation"/>
    /// <seealso cref="TOKEN_CONTROL"/>
    /// <seealso cref="TOKEN_DEFAULT_DACL"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    /// <seealso cref="TOKEN_OWNER"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    /// <seealso cref="TOKEN_SOURCE"/>
    /// <seealso cref="TOKEN_STATISTICS"/>
    /// <seealso cref="TOKEN_TYPE"/>
    /// <seealso cref="TOKEN_USER"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct TOKEN_PRIMARY_GROUP
    {
        /// <summary>
        /// A pointer to a <see cref="SID"/> structure representing a group that will become the primary group of any objects created by a process using this access token. The SID must be one of the group SIDs already in the token.
        /// <para>Use the <see cref="MarshalPrimaryGroupToManaged"/> method to marshal the SID to a managed <see cref="SecurityIdentifier"/> instance.</para>
        /// </summary>
        public IntPtr PrimaryGroup;

        public SecurityIdentifier MarshalPrimaryGroupToManaged() =>
            SID.MarshalToManagedSid(PrimaryGroup);
    }
}

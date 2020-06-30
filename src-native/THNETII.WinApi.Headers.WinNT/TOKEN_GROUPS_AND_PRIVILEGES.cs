using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10778
    /// <summary>
    /// The <see cref="TOKEN_GROUPS_AND_PRIVILEGES"/> structure contains information about the group <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifiers</a> (SIDs) in an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access token</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_groups_and_privileges">TOKEN_GROUPS_AND_PRIVILEGES structure</a></para>
    /// </remarks>
    /// <seealso cref="AdjustTokenGroups"/>
    /// <seealso cref="CreateRestrictedToken"/>
    /// <seealso cref="SID_AND_ATTRIBUTES"/>
    /// <seealso cref="TOKEN_CONTROL"/>
    /// <seealso cref="TOKEN_DEFAULT_DACL"/>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    /// <seealso cref="TOKEN_OWNER"/>
    /// <seealso cref="TOKEN_PRIMARY_GROUP"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    /// <seealso cref="TOKEN_SOURCE"/>
    /// <seealso cref="TOKEN_STATISTICS"/>
    /// <seealso cref="TOKEN_TYPE"/>
    /// <seealso cref="TOKEN_USER"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_GROUPS_AND_PRIVILEGES
    {
        /// <summary>
        /// Number of SIDs in the access token.
        /// </summary>
        public int SidCount;
        /// <summary>
        /// Length, in bytes, required to hold all of the user SIDs and the account SID for the group.
        /// </summary>
        public int SidLength;
        /// <summary>
        /// A pointer to an array of <see cref="SID_AND_ATTRIBUTES"/> structures that contain a set of SIDs and corresponding attributes.
        /// <para>Use the <see cref="Sids"/> property to access the SIDs.</para>
        /// </summary>
        public IntPtr SidsPtr;
        /// <summary>
        /// A span of <see cref="SID_AND_ATTRIBUTES"/> structures that contain a set of SIDs and corresponding attributes.
        /// <para>The possible values for the <see cref="SID_AND_ATTRIBUTES.Attributes"/> members of the <see cref="SID_AND_ATTRIBUTES"/> structures are defined by the <see cref="SE_GROUP_ATTRIBUTES"/> enumeration.</para>
        /// </summary>
        public Span<SID_AND_ATTRIBUTES> Sids => SidsPtr.AsRefStructSpan<SID_AND_ATTRIBUTES>(SidCount);
        /// <summary>
        /// Number of restricted SIDs.
        /// </summary>
        public int RestrictedSidCount;
        /// <summary>
        /// Length, in bytes, required to hold all of the restricted SIDs.
        /// </summary>
        public int RestrictedSidLength;
        /// <summary>
        /// A pointer to an array of <see cref="SID_AND_ATTRIBUTES"/> structures that contain a set of restricted SIDs and corresponding attributes.
        /// <para>Use the <see cref="RestrictedSids"/> property to access the SIDs.</para>
        /// </summary>
        public IntPtr RestrictedSidsPtr;
        /// <summary>
        /// A span of <see cref="SID_AND_ATTRIBUTES"/> structures that contain a set of restricted SIDs and corresponding attributes.
        /// <para>The possible values for the <see cref="SID_AND_ATTRIBUTES.Attributes"/> members of the <see cref="SID_AND_ATTRIBUTES"/> structures are defined by the <see cref="SE_GROUP_ATTRIBUTES"/> enumeration.</para>
        /// </summary>
        public Span<SID_AND_ATTRIBUTES> RestrictedSids => RestrictedSidsPtr.AsRefStructSpan<SID_AND_ATTRIBUTES>(RestrictedSidCount);
        /// <summary>
        /// Number of privileges.
        /// </summary>
        public int PrivilegeCount;
        /// <summary>
        /// Length, in bytes, needed to hold the privilege array.
        /// </summary>
        public int PrivilegeLength;
        /// <summary>
        /// A pointer to an array of <see cref="LUID_AND_ATTRIBUTES"/> structures containing the priviliges of the token.
        /// <para>Use the <see cref="Privileges"/> property to access the privileges.</para>
        /// </summary>
        public IntPtr PrivilegesPtr;
        /// <summary>
        /// A span of <see cref="LUID_AND_ATTRIBUTES"/> structures containing the priviliges of the token.
        /// </summary>
        public Span<LUID_AND_ATTRIBUTES> Privileges => PrivilegesPtr.AsRefStructSpan<LUID_AND_ATTRIBUTES>(PrivilegeCount);
        /// <summary>
        /// <a href="https://msdn.microsoft.com/65dd9a04-fc7c-4179-95ff-dac7dad4668f">Locally unique identifier</a> (LUID) of the authenticator of the token.
        /// </summary>
        public LUID AuthenticationId;
    }
}

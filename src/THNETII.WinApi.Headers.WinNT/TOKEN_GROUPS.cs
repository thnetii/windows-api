using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10714
    /// <summary>
    /// The <see cref="TOKEN_GROUPS"/> structure contains information about the group <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifiers</a> (SIDs) in an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access token</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_groups">TOKEN_GROUPS structure</a></para>
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
    public struct TOKEN_GROUPS
    {
        /// <summary>
        /// Specifies the number of groups in the access token.
        /// </summary>
        public int GroupCount;
        internal SID_AND_ATTRIBUTES GroupsField;
        public unsafe Span<SID_AND_ATTRIBUTES> Groups => SpanOverRef.GetSpan(ref GroupsField, GroupCount);
    }
}

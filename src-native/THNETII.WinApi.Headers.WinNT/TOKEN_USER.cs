using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10714
    /// <summary>
    /// The <see cref="TOKEN_USER"/> structure identifies the user associated with an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access token</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-token_user">TOKEN_USER structure</a></para>
    /// </remarks>
    /// <seealso cref="GetTokenInformation"/>
    /// <seealso cref="SID_AND_ATTRIBUTES"/>
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
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_USER
    {
        /// <summary>
        /// Specifies a <see cref="SID_AND_ATTRIBUTES"/> structure representing the user associated with the access token. There are currently no attributes defined for user <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifiers</a> (SIDs).
        /// </summary>
        public SID_AND_ATTRIBUTES User;
    }
}

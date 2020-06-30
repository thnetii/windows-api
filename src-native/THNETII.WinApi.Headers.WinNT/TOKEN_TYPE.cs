namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10638
    /// <summary>
    /// The <see cref="TOKEN_TYPE"/> enumeration contains values that differentiate between a <a href="https://msdn.microsoft.com/2fe6cfd3-8a2e-4dbe-9fb8-332633daa97a">primary token</a> and an <a href="https://msdn.microsoft.com/af511aed-88f5-4b12-ad44-317925297f70">impersonation token</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ne-winnt-token_type">TOKEN_TYPE enumeration</a></para>
    /// </remarks>
    /// <seealso href="https://msdn.microsoft.com/d9ce4ec5-5c09-4b33-93a1-39638a925986">Access Control Overview</seealso>
    /// <seealso href="https://msdn.microsoft.com/e2f22838-102e-432c-9c82-06a3e0741374">Authorization Enumerations</seealso>
    /// <seealso cref="GetTokenInformation"/>
    /// <seealso cref="TOKEN_CONTROL"/>
    /// <seealso cref="TOKEN_DEFAULT_DACL"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    /// <seealso cref="TOKEN_OWNER"/>
    /// <seealso cref="TOKEN_PRIMARY_GROUP"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    /// <seealso cref="TOKEN_SOURCE"/>
    /// <seealso cref="TOKEN_STATISTICS"/>
    /// <seealso cref="TOKEN_USER"/>
    public enum TOKEN_TYPE
    {
        /// <summary>Indicates a primary token.</summary>
        TokenPrimary = 1,
        /// <summary>Indicates an impersonation token.</summary>
        TokenImpersonation
    }
}

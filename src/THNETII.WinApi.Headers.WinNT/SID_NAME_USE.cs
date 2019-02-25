namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9042
    /// <summary>
    /// The <see cref="SID_NAME_USE"/> enumeration contains values that specify the type of a <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifier</a> (SID).
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ne-winnt-_sid_name_use">SID_NAME_USE enumeration</a></para>
    /// </remarks>
    /// <seealso href="https://msdn.microsoft.com/d9ce4ec5-5c09-4b33-93a1-39638a925986">Access Control Overview</seealso>
    /// <seealso href="https://msdn.microsoft.com/e2f22838-102e-432c-9c82-06a3e0741374">Authorization Enumerations</seealso>
    /// <seealso cref="LookupAccountName"/>
    /// <seealso cref="LookupAccountSid"/>
    public enum SID_NAME_USE
    {
        /// <summary>A user SID.</summary>
        SidTypeUser = 1,
        /// <summary>A group SID.</summary>
        SidTypeGroup,
        /// <summary>A domain SID.</summary>
        SidTypeDomain,
        /// <summary>An alias SID.</summary>
        SidTypeAlias,
        /// <summary>A SID for a well-known group.</summary>
        SidTypeWellKnownGroup,
        /// <summary>A SID for a deleted account.</summary>
        SidTypeDeletedAccount,
        /// <summary>A SID that is not valid.</summary>
        SidTypeInvalid,
        /// <summary>A SID of unknown type.</summary>
        SidTypeUnknown,
        /// <summary>A SID for a computer.</summary>
        SidTypeComputer,
        /// <summary>A mandatory integrity label SID.</summary>
        SidTypeLabel,
        /// <summary/>
        SidTypeLogonSession
    }
}

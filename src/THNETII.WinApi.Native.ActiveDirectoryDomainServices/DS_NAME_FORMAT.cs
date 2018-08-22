using System;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_NAME_FLAGS"/> enumeration is used to define how the name syntax will be cracked. These flags are used by the <see cref="DsCrackNames"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-ds_name_format">DS_NAME_FORMAT Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DsCrackNames"/>
    public enum DS_NAME_FORMAT
    {
        /// <summary>
        /// Indicates the name is using an unknown name type. This format can impact performance because it forces the server to attempt to match all possible formats. Only use this value if the input format is unknown.
        /// </summary>
        DS_UNKNOWN_NAME = 0,

        /// <summary>
        /// Indicates that the fully qualified distinguished name is used. For example:
        /// <code>CN=someone,OU=Users,DC=Engineering,DC=Fabrikam,DC=Com</code>
        /// </summary>
        DS_FQDN_1779_NAME = 1,

        /// <summary>
        /// <para>Indicates a Windows NT 4.0 account name. For example: <code>Engineering\someone</code></para>
        /// <para>The domain-only version includes two trailing backslashes (\).</para>
        /// </summary>
        DS_NT4_ACCOUNT_NAME = 2,

        /// <summary>
        /// Indicates a user-friendly display name, for example, Jeff Smith. The display name is not necessarily the same as relative distinguished name (RDN).
        /// </summary>
        DS_DISPLAY_NAME = 3,

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        [Obsolete("Old name format deprecated, remapped to " + nameof(DS_USER_PRINCIPAL_NAME))]
        DS_DOMAIN_SIMPLE_NAME = DS_USER_PRINCIPAL_NAME,

        [Obsolete("Old name format deprecated, remapped to " + nameof(DS_USER_PRINCIPAL_NAME))]
        DS_ENTERPRISE_SIMPLE_NAME = DS_USER_PRINCIPAL_NAME,
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// Indicates a GUID string that the IIDFromString function returns. For example: 
        /// <code>{4fa050f0-f561-11cf-bdd9-00aa003a77b6}</code>
        /// </summary>
        DS_UNIQUE_ID_NAME = 6,

        /// <summary>
        /// Indicates a complete canonical name. For example: <code>engineering.fabrikam.com/software/someone</code>
        /// <para>The domain-only version includes a trailing forward slash (/).</para>
        /// </summary>
        DS_CANONICAL_NAME = 7,

        /// <summary>
        /// Indicates that it is using the user principal name (UPN). For example:
        /// <code>someone@engineering.fabrikam.com</code>
        /// </summary>
        DS_USER_PRINCIPAL_NAME = 8,

        /// <summary>
        /// This element is the same as <see cref="DS_CANONICAL_NAME"/> except that the rightmost forward slash (/) is replaced with a newline character (\n), even in a domain-only case. For example:
        /// <code>
        /// engineering.fabrikam.com/software
        /// someone
        /// </code>
        /// </summary>
        DS_CANONICAL_NAME_EX = 9,

        /// <summary>
        /// Indicates it is using a generalized service principal name. For example:
        /// <code>www/www.fabrikam.com@fabrikam.com</code>
        /// </summary>
        DS_SERVICE_PRINCIPAL_NAME = 10,

        /// <summary>
        /// Indicates a Security Identifier (SID) for the object. This can be either the current SID or a SID from the object SID history. The SID string can use either the standard string representation of a SID, or one of the string constants defined in Sddl.h. For more information about converting a binary SID into a SID string, see <a href="https://msdn.microsoft.com/a531532f-afba-46a1-8576-90d4ff881b94">SID Strings</a>. The following is an example of a SID string:
        /// <code>S-1-5-21-397955417-626881126-188441444-501</code>
        /// </summary>
        DS_SID_OR_SID_HISTORY_NAME = 11,

        /// <summary>
        /// Pseudo-name format so <see cref="GetUserNameEx"/> can return the DNS domain name to
        /// a caller.
        /// <para>This level is not supported by the DS APIs.</para>
        /// </summary>
        DS_DNS_DOMAIN_NAME = 12
    }
}

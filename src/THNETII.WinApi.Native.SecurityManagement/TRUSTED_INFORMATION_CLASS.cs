using System;

namespace Microsoft.Win32.WinApi.SecurityIdentity.SecurityManagement
{
    /// <summary>
    /// <para>The <see cref="TRUSTED_INFORMATION_CLASS"/> enumeration type defines values that indicate the type of information to set or query for a trusted domain.</para>
    /// <para>Each value has an associated structure that the <see cref="LsaQueryTrustedDomainInfo"/> and <see cref="LsaSetTrustedDomainInformation"/> functions use to store the information.</para>
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms722481.aspx">TRUSTED_INFORMATION_CLASS enumeration</a></para>
    /// </remarks>
    /// <seealso cref="LsaQueryTrustedDomainInfo"/>
    /// <seealso cref="LsaSetTrustedDomainInformation"/>
    /// <seealso cref="TRUSTED_DOMAIN_AUTH_INFORMATION"/>
    /// <seealso cref="TRUSTED_DOMAIN_FULL_INFORMATION"/>
    /// <seealso cref="TRUSTED_DOMAIN_INFORMATION_EX"/>
    /// <seealso cref="TRUSTED_DOMAIN_NAME_INFO"/>
    /// <seealso cref="TRUSTED_PASSWORD_INFO"/>
    /// <seealso cref="TRUSTED_POSIX_OFFSET_INFO"/>
    /// <seealso cref="LSA_TRUST_INFORMATION"/>
    public enum TRUSTED_INFORMATION_CLASS
    {
        /// <summary>Query or set the name of a trusted domain. Use the <see cref="TRUSTED_DOMAIN_NAME_INFO"/> structure.</summary>
        TrustedDomainNameInformation = 1,
        /// <summary>This value is obsolete.</summary>
        [Obsolete]
        TrustedControllersInformation,
        /// <summary>Query or set the value used to generate Posix user and group identifiers. Use the <see cref="TRUSTED_POSIX_OFFSET_INFO"/> structure.</summary>
        TrustedPosixOffsetInformation,
        /// <summary>This value has been superseded by the <see cref="TrustedDomainAuthInformation"/> value. </summary>
        [Obsolete("This value has been superseded by the TrustedDomainAuthInformation value.")]
        TrustedPasswordInformation,
        /// <summary>This value is obsolete.</summary>
        [Obsolete]
        TrustedDomainInformationBasic,
        /// <summary>Query extended information for a trusted domain. Use the <see cref="TRUSTED_DOMAIN_INFORMATION_EX"/> structure.</summary>
        TrustedDomainInformationEx,
        /// <summary>Query authentication information for a trusted domain. Use the <see cref="TRUSTED_DOMAIN_AUTH_INFORMATION"/> structure.</summary>
        TrustedDomainAuthInformation,
        /// <summary>Query complete information for a trusted domain. This information includes the Posix offset information, authentication information, and the extended information returned for the <see cref="TrustedDomainInformationEx"/> value. Use the <see cref="TRUSTED_DOMAIN_FULL_INFORMATION"/> structure.</summary>
        TrustedDomainFullInformation
    }
}

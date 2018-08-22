namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_SPN_NAME_TYPE"/> enumeration is used by the <see cref="DsGetSPN"/> function to identify the format for composing SPNs.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-ds_spn_name_type">DS_SPN_NAME_TYPE Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DsGetSPN"/>
    public enum DS_SPN_NAME_TYPE
    {
        /// <summary>
        /// The SPN format for the distinguished name service of the host-based service, which provides services identified with its host computer. This SPN uses the following format:
        /// <code>jeffsmith.fabrikam.com</code>
        /// </summary>
        DS_SPN_DNS_HOST = 0,

        /// <summary>
        /// The SPN format for the distinguished name of the host-based service, which provides services identified with its host computer. This SPN uses the following format:
        /// <code>cn=jeffsmith,ou=computers,dc=fabrikam,dc=com</code>
        /// </summary>
        DS_SPN_DN_HOST = 1,

        /// <summary>
        /// The SPN format for the NetBIOS service of the host-based service, which provides services identified with its host computer. This SPN uses the following format:
        /// <code>jeffsmith-nec</code>
        /// </summary>
        DS_SPN_NB_HOST = 2,

        /// <summary>
        /// The SPN format for a replicable service that provides services to the specified domain. This SPN uses the following format:
        /// <code>fabrikam.com</code>
        /// </summary>
        DS_SPN_DOMAIN = 3,

        /// <summary>
        /// The SPN format for a replicable service that provides services to the specified NetBIOS domain. This SPN uses the following format:
        /// <code>fabrikam</code>
        /// </summary>
        DS_SPN_NB_DOMAIN = 4,

        /// <summary>
        /// The SPN format for a specified service. This SPN uses the following formats, depending on which service is used:
        /// <code>cn=anRpcService,cn=RPC Services,cn=system,dc=fabrikam,dc=com</code>
        /// <code>cn=aWsService,cn=Winsock Services,cn=system,dc=fabrikam,dc=com</code>
        /// <code>cn=aService,dc=itg,dc=fabrikam,dc=com</code>
        /// <code>www.fabrikam.com, ftp.fabrikam.com, ldap.fabrikam.com</code>
        /// <code>products.fabrikam.com</code>
        /// </summary>
        DS_SPN_SERVICE = 5
    }
}

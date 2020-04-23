namespace THNETII.WinApi.Native.SysInfoApi
{
    using static SysInfoApiFunctions;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line 296
    /// <summary>
    /// Specifies a type of computer name.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/ne-sysinfoapi-computer_name_format">COMPUTER_NAME_FORMAT Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="GetComputerNameEx"/>
    /// <seealso cref="SetComputerNameEx"/>
    public enum COMPUTER_NAME_FORMAT
    {
        /// <summary>
        /// The NetBIOS name of the local computer or the cluster associated with the local computer. This name is limited to <c><see cref="F:THNETII.WinApi.Native.WinBase.WinBaseConstants.MAX_COMPUTERNAME_LENGTH"/> + 1</c> characters and may be a truncated version of the DNS host name. For example, if the DNS host name is "corporate-mail-server", the NetBIOS name would be "corporate-mail-".
        /// </summary>
        ComputerNameNetBIOS,
        /// <summary>
        /// The DNS name of the local computer or the cluster associated with the local computer.
        /// </summary>
        ComputerNameDnsHostname,
        /// <summary>
        /// The name of the DNS domain assigned to the local computer or the cluster associated with the local computer.
        /// </summary>
        ComputerNameDnsDomain,
        /// <summary>
        /// The fully qualified DNS name that uniquely identifies the local computer or the cluster associated with the local computer.<br/>
        /// This name is a combination of the DNS host name and the DNS domain name, using the form <em>HostName.DomainName</em>. For example, if the DNS host name is "corporate-mail-server" and the DNS domain name is "microsoft.com", the fully qualified DNS name is "corporate-mail-server.microsoft.com".
        /// </summary>
        ComputerNameDnsFullyQualified,
        /// <summary>
        /// The NetBIOS name of the local computer. On a cluster, this is the NetBIOS name of the local node on the cluster.
        /// </summary>
        ComputerNamePhysicalNetBIOS,
        /// <summary>
        /// The DNS host name of the local computer. On a cluster, this is the DNS host name of the local node on the cluster.
        /// </summary>
        ComputerNamePhysicalDnsHostname,
        /// <summary>
        /// The name of the DNS domain assigned to the local computer. On a cluster, this is the DNS domain of the local node on the cluster.
        /// </summary>
        ComputerNamePhysicalDnsDomain,
        /// <summary>
        /// The fully qualified DNS name that uniquely identifies the computer. On a cluster, this is the fully qualified DNS name of the local node on the cluster. The fully qualified DNS name is a combination of the DNS host name and the DNS domain name, using the form <em>HostName.DomainName</em>.
        /// </summary>
        ComputerNamePhysicalDnsFullyQualified,
        ComputerNameMax
    }
}

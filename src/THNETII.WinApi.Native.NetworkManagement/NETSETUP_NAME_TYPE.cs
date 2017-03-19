namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Types of name that can be validated
    /// </summary>
    public enum NETSETUP_NAME_TYPE
    {
        /// <summary>The nametype is unknown.</summary>
        NetSetupUnknown = 0,
        /// <summary>Verify that the NetBIOS computer name is valid and that it is not in use.</summary>
        NetSetupMachine,
        /// <summary>Verify that the workgroup name is valid.</summary>
        NetSetupWorkgroup,
        /// <summary>Verify that the domain name exists and that it is a domain.</summary>
        NetSetupDomain,
        /// <summary>Verify that the domain name is not in use.</summary>
        NetSetupNonExistentDomain,
        /// <summary>Verify that the DNS computer name is valid.</summary>
        NetSetupDnsMachine
    }
}
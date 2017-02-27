using System;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Flags to determine the behavior of <see cref="NetProvisionComputerAccount"/> and
    /// <see cref="NetCreateProvisioningPackage"/>.
    /// </summary>
    [Flags]
    public enum NETSETUP_PROVISION_FLAGS : int
    {

        /// <summary>
        /// The caller requires account creation by privilege, this option will cause a retry
        /// on failure using down level account creation APIs.
        /// </summary>
        NETSETUP_PROVISION_DOWNLEVEL_PRIV_SUPPORT = 0x00000001,

        /// <summary>
        /// If the named account already exists an attempt will be made to reuse. Requires
        /// sufficient credentials i.e. Domain Administrator or the object owner.
        /// </summary>
        NETSETUP_PROVISION_REUSE_ACCOUNT = 0x00000002,

        /// <summary>
        /// Use the default machine account password which is the machine name in lowercase.
        /// </summary>
        NETSETUP_PROVISION_USE_DEFAULT_PASSWORD = 0x00000004,

        /// <summary>
        /// Do not try to find the account on any DC in the domain. This is faster but
        /// should only be used when the caller is certain that an account by the same
        /// name hasn't recently been created. Only valid when specifying the target DC.
        /// When the pre-requisites are met, this option allows for must faster provisioning
        /// useful for scenarios such as batch processing.
        /// </summary>
        NETSETUP_PROVISION_SKIP_ACCOUNT_SEARCH = 0x00000008,

        /// <summary>
        /// Include root Certificate Authority certificates in provisioning package.
        /// </summary>
        NETSETUP_PROVISION_ROOT_CA_CERTS = 0x00000010,

        /// <summary>
        /// Configure site as persistent (if not specified then configure as dynamic).
        /// </summary>
        NETSETUP_PROVISION_PERSISTENTSITE = 0x00000020,

        //
        // The following are reserved for internal use.
        //

        /// <summary>
        /// The operation is online.
        /// This is an internal option not available through the API.
        /// </summary>
        NETSETUP_PROVISION_ONLINE_CALLER = 0x40000000,

        /// <summary>
        /// Validate the machine password only. This is an internal option not available
        /// through the API.
        /// </summary>
        NETSETUP_PROVISION_CHECK_PWD_ONLY = unchecked((int)0x80000000),

    }
}
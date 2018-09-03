using System;

namespace THNETII.WinApiNative.ActiveDirectoryDomainServices
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Contains definitions for public NTDS APIs other than directory interfaces like LDAP.
    /// </summary>
    /// <remarks>File: C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\NtDsAPI.h</remarks>
    public static class _NTDSAPI_H_
    {
        #region L100-L109
        /// <summary>
        /// When booted to DS mode, this event is signalled when the DS has completed
        /// its initial sync attempts.  The period of time between system startup and
        /// this event's state being set is indeterminate from the local service's
        /// standpoint.  In the meantime the contents of the DS should be considered
        /// incomplete / out-dated, and the machine will not be advertised as a domain
        /// controller to off-machine clients.  Other local services that rely on
        /// information published in the DS should avoid accessing (or at least
        /// relying on) the contents of the DS until this event is set.
        /// </summary>
        public const string DS_SYNCED_EVENT_NAME = "NTDSInitialSyncsCompleted"; 
        #endregion
        #region L781-L821
        // ***********************
        // Well Known Object Guids
        // ***********************
        public const string GUID_USERS_CONTAINER_STRING = "a9d1ca15768811d1aded00c04fd8d5cd";
        public const string GUID_COMPUTRS_CONTAINER_STRING = "aa312825768811d1aded00c04fd8d5cd";
        public const string GUID_SYSTEMS_CONTAINER_STRING = "ab1d30f3768811d1aded00c04fd8d5cd";
        public const string GUID_DOMAIN_CONTROLLERS_CONTAINER_STRING = "a361b2ffffd211d1aa4b00c04fd7d83a";
        public const string GUID_INFRASTRUCTURE_CONTAINER_STRING = "2fbac1870ade11d297c400c04fd8d5cd";
        public const string GUID_DELETED_OBJECTS_CONTAINER_STRING = "18e2ea80684f11d2b9aa00c04f79f805";
        public const string GUID_LOSTANDFOUND_CONTAINER_STRING = "ab8153b7768811d1aded00c04fd8d5cd";
        public const string GUID_FOREIGNSECURITYPRINCIPALS_CONTAINER_STRING = "22b70c67d56e4efb91e9300fca3dc1aa";
        public const string GUID_PROGRAM_DATA_CONTAINER_STRING = "09460c08ae1e4a4ea0f64aee7daa1e5a";
        public const string GUID_MICROSOFT_PROGRAM_DATA_CONTAINER_STRING = "f4be92a4c777485e878e9421d53087db";
        public const string GUID_NTDS_QUOTAS_CONTAINER_STRING = "6227f0af1fc2410d8e3bb10615bb5b0f";


        public static readonly Guid GUID_USERS_CONTAINER = new Guid(GUID_USERS_CONTAINER_STRING);
        public static readonly Guid GUID_COMPUTRS_CONTAINER = new Guid(GUID_COMPUTRS_CONTAINER_STRING);
        public static readonly Guid GUID_SYSTEMS_CONTAINER = new Guid(GUID_SYSTEMS_CONTAINER_STRING);
        public static readonly Guid GUID_DOMAIN_CONTROLLERS_CONTAINER = new Guid(GUID_DOMAIN_CONTROLLERS_CONTAINER_STRING);
        public static readonly Guid GUID_INFRASTRUCTURE_CONTAINER = new Guid(GUID_INFRASTRUCTURE_CONTAINER_STRING);
        public static readonly Guid GUID_DELETED_OBJECTS_CONTAINER = new Guid(GUID_DELETED_OBJECTS_CONTAINER_STRING);
        public static readonly Guid GUID_LOSTANDFOUND_CONTAINER = new Guid(GUID_LOSTANDFOUND_CONTAINER_STRING);
        public static readonly Guid GUID_FOREIGNSECURITYPRINCIPALS_CONTAINER = new Guid(GUID_FOREIGNSECURITYPRINCIPALS_CONTAINER_STRING);
        public static readonly Guid GUID_PROGRAM_DATA_CONTAINER = new Guid(GUID_PROGRAM_DATA_CONTAINER_STRING);
        public static readonly Guid GUID_MICROSOFT_PROGRAM_DATA_CONTAINER = new Guid(GUID_MICROSOFT_PROGRAM_DATA_CONTAINER_STRING);
        public static readonly Guid GUID_NTDS_QUOTAS_CONTAINER = new Guid(GUID_NTDS_QUOTAS_CONTAINER_STRING); 
        #endregion
        #region L3198-L3224
        // -------------------------------------------------------------------------
        // strings used by ADAM for constructing keywords values for SCP publication
        // -------------------------------------------------------------------------

        /// <summary>Site name, e.g. "site:Default-First-Site-Name"</summary>
        public const string ADAM_SCP_SITE_NAME_STRING = "site:";

        /// <summary>Partition DN, e.g. "partition:O=MSFT,L=WA,C=US"</summary>
        public const string ADAM_SCP_PARTITION_STRING = "partition:";

        /// <summary>Instance name, e.g. "instance:instance1"</summary>
        public const string ADAM_SCP_INSTANCE_NAME_STRING = "instance:";

        /// <summary>FSMO, e.g. "fsmo:naming"</summary>
        public const string ADAM_SCP_FSMO_STRING = "fsmo:";

        /// <summary>FSMO values, e.g. "fsmo:naming"</summary>
        public const string ADAM_SCP_FSMO_NAMING_STRING = "naming";

        public const string ADAM_SCP_FSMO_SCHEMA_STRING = "schema";
        #endregion
        #region L3252-3259
        /// <summary>GUID of the Recycle Bin optional feature</summary>
        public const string GUID_RECYCLE_BIN_OPTIONAL_FEATURE_STRING = "d8dc6d76d0ac5e44f3b9a7f9b6744f2a";
        /// <summary>GUID of the Recycle Bin optional feature</summary>
        public static readonly Guid GUID_RECYCLE_BIN_OPTIONAL_FEATURE = new Guid(GUID_RECYCLE_BIN_OPTIONAL_FEATURE_STRING);

        public const string GUID_PRIVILEGED_ACCESS_MANAGEMENT_OPTIONAL_FEATURE_STRING = "73e843ece8cc4046b4ab07ffe4ab5bcd";
        public static readonly Guid GUID_PRIVILEGED_ACCESS_MANAGEMENT_OPTIONAL_FEATURE = new Guid(GUID_PRIVILEGED_ACCESS_MANAGEMENT_OPTIONAL_FEATURE_STRING); 
        #endregion
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

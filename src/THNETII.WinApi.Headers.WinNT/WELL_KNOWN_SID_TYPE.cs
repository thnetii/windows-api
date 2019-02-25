using System.Security.Principal;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9472
    //
    // Well known SID definitions for lookup.
    //
    /// <summary>
    /// The <see cref="WELL_KNOWN_SID_TYPE"/> enumeration is a list of commonly used <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifiers</a> (SIDs). Programs can pass these values to the <see cref="CreateWellKnownSid"/> function to create a SID from this list.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ne-winnt-_well_known_sid_type">WELL_KNOWN_SID_TYPE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="WellKnownSidType"/>
    /// <seealso href="https://msdn.microsoft.com/3d813e46-f06e-4147-874c-30b5fc6f50d9">Allowing Anonymous Access</seealso>
    /// <seealso cref="CreateWellKnownSid"/>
    /// <seealso cref="IsWellKnownSid"/>
    /// <seealso href="https://msdn.microsoft.com/eb2f95c4-9465-409b-b76c-9ccae1d05eda">Well-known SIDs</seealso>
    public enum WELL_KNOWN_SID_TYPE
    {
        /// <summary>Indicates a null SID.</summary>
        WinNullSid = 0,
        /// <summary>Indicates a SID that matches everyone.</summary>
        WinWorldSid = 1,
        /// <summary>Indicates a local SID.</summary>
        WinLocalSid = 2,
        /// <summary>Indicates a SID that matches the owner or creator of an object.</summary>
        WinCreatorOwnerSid = 3,
        /// <summary>Indicates a SID that matches the creator group of an object.</summary>
        WinCreatorGroupSid = 4,
        /// <summary>Indicates a creator owner server SID.</summary>
        WinCreatorOwnerServerSid = 5,
        /// <summary>Indicates a creator group server SID.</summary>
        WinCreatorGroupServerSid = 6,
        /// <summary>Indicates a SID for the Windows NT authority account.</summary>
        WinNtAuthoritySid = 7,
        /// <summary>Indicates a SID for a dial-up account.</summary>
        WinDialupSid = 8,
        /// <summary>Indicates a SID for a network account. This SID is added to the process of a token when it logs on across a network. The corresponding logon type is <see cref="LOGON32_LOGON_NETWORK"/>.</summary>
        WinNetworkSid = 9,
        /// <summary>Indicates a SID for a batch process. This SID is added to the process of a token when it logs on as a batch job. The corresponding logon type is <see cref="LOGON32_LOGON_BATCH"/>.</summary>
        WinBatchSid = 10,
        /// <summary>Indicates a SID for an interactive account. This SID is added to the process of a token when it logs on interactively. The corresponding logon type is <see cref="LOGON32_LOGON_INTERACTIVE"/>.</summary>
        WinInteractiveSid = 11,
        /// <summary>Indicates a SID for a service. This SID is added to the process of a token when it logs on as a service. The corresponding logon type is <see cref="LOGON32_LOGON_SERVICE"/>.</summary>
        WinServiceSid = 12,
        /// <summary>Indicates a SID for the anonymous account.</summary>
        WinAnonymousSid = 13,
        /// <summary>Indicates a proxy SID.</summary>
        WinProxySid = 14,
        /// <summary>Indicates a SID for an enterprise controller.</summary>
        WinEnterpriseControllersSid = 15,
        /// <summary>Indicates a SID for self.</summary>
        WinSelfSid = 16,
        /// <summary>Indicates a SID that matches any authenticated user.</summary>
        WinAuthenticatedUserSid = 17,
        /// <summary>Indicates a SID for restricted code.</summary>
        WinRestrictedCodeSid = 18,
        /// <summary>Indicates a SID that matches a terminal server account.</summary>
        WinTerminalServerSid = 19,
        /// <summary>Indicates a SID that matches remote logons.</summary>
        WinRemoteLogonIdSid = 20,
        /// <summary>Indicates a SID that matches logon IDs.</summary>
        WinLogonIdsSid = 21,
        /// <summary>Indicates a SID that matches the local system.</summary>
        WinLocalSystemSid = 22,
        /// <summary>Indicates a SID that matches a local service.</summary>
        WinLocalServiceSid = 23,
        /// <summary>Indicates a SID that matches a network service.</summary>
        WinNetworkServiceSid = 24,
        /// <summary>Indicates a SID that matches the domain account.</summary>
        WinBuiltinDomainSid = 25,
        /// <summary>Indicates a SID that matches the administrator group.</summary>
        WinBuiltinAdministratorsSid = 26,
        /// <summary>Indicates a SID that matches built-in user accounts.</summary>
        WinBuiltinUsersSid = 27,
        /// <summary>Indicates a SID that matches the guest account.</summary>
        WinBuiltinGuestsSid = 28,
        /// <summary>Indicates a SID that matches the power users group.</summary>
        WinBuiltinPowerUsersSid = 29,
        /// <summary>Indicates a SID that matches the account operators account.</summary>
        WinBuiltinAccountOperatorsSid = 30,
        /// <summary>Indicates a SID that matches the system operators group.</summary>
        WinBuiltinSystemOperatorsSid = 31,
        /// <summary>Indicates a SID that matches the print operators group.</summary>
        WinBuiltinPrintOperatorsSid = 32,
        /// <summary>Indicates a SID that matches the backup operators group.</summary>
        WinBuiltinBackupOperatorsSid = 33,
        /// <summary>Indicates a SID that matches the replicator account.</summary>
        WinBuiltinReplicatorSid = 34,
        /// <summary>Indicates a SID that matches pre-Windows 2000 compatible accounts.</summary>
        WinBuiltinPreWindows2000CompatibleAccessSid = 35,
        /// <summary>Indicates a SID that matches remote desktop users.</summary>
        WinBuiltinRemoteDesktopUsersSid = 36,
        /// <summary>Indicates a SID that matches the network operators group.</summary>
        WinBuiltinNetworkConfigurationOperatorsSid = 37,
        /// <summary>Indicates a SID that matches the account administrator's account.</summary>
        WinAccountAdministratorSid = 38,
        /// <summary>Indicates a SID that matches the account guest group.</summary>
        WinAccountGuestSid = 39,
        /// <summary>Indicates a SID that matches account Kerberos target group.</summary>
        WinAccountKrbtgtSid = 40,
        /// <summary>Indicates a SID that matches the account domain administrator group.</summary>
        WinAccountDomainAdminsSid = 41,
        /// <summary>Indicates a SID that matches the account domain users group.</summary>
        WinAccountDomainUsersSid = 42,
        /// <summary>Indicates a SID that matches the account domain guests group.</summary>
        WinAccountDomainGuestsSid = 43,
        /// <summary>Indicates a SID that matches the account computer group.</summary>
        WinAccountComputersSid = 44,
        /// <summary>Indicates a SID that matches the account controller group.</summary>
        WinAccountControllersSid = 45,
        /// <summary>Indicates a SID that matches the certificate administrators group.</summary>
        WinAccountCertAdminsSid = 46,
        /// <summary>Indicates a SID that matches the schema administrators group.</summary>
        WinAccountSchemaAdminsSid = 47,
        /// <summary>Indicates a SID that matches the enterprise administrators group.</summary>
        WinAccountEnterpriseAdminsSid = 48,
        /// <summary>Indicates a SID that matches the policy administrators group.</summary>
        WinAccountPolicyAdminsSid = 49,
        /// <summary>Indicates a SID that matches the RAS and IAS server account.</summary>
        WinAccountRasAndIasServersSid = 50,
        /// <summary>Indicates a SID present when the Microsoft NTLM authentication package authenticated the client.</summary>
        WinNTLMAuthenticationSid = 51,
        /// <summary>Indicates a SID present when the Microsoft Digest authentication package authenticated the client.</summary>
        WinDigestAuthenticationSid = 52,
        /// <summary>Indicates a SID present when the Secure Channel (SSL/TLS) authentication package authenticated the client.</summary>
        WinSChannelAuthenticationSid = 53,
        /// <summary>Indicates a SID present when the user authenticated from within the forest or across a trust that does not have the selective authentication option enabled. If this SID is present, then <see cref="WinOtherOrganizationSid"/> cannot be present.</summary>
        WinThisOrganizationSid = 54,
        /// <summary>Indicates a SID present when the user authenticated across a forest with the selective authentication option enabled. If this SID is present, then <see cref="WinThisOrganizationSid"/> cannot be present.</summary>
        WinOtherOrganizationSid = 55,
        /// <summary>Indicates a SID that allows a user to create incoming forest trusts. It is added to the token of users who are a member of the Incoming Forest Trust Builders built-in group in the root domain of the forest.</summary>
        WinBuiltinIncomingForestTrustBuildersSid = 56,
        /// <summary>Indicates a SID that matches the performance monitor user group.</summary>
        WinBuiltinPerfMonitoringUsersSid = 57,
        /// <summary>Indicates a SID that matches the performance log user group.</summary>
        WinBuiltinPerfLoggingUsersSid = 58,
        /// <summary>Indicates a SID that matches the Windows Authorization Access group.</summary>
        WinBuiltinAuthorizationAccessSid = 59,
        /// <summary>Indicates a SID is present in a server that can issue terminal server licenses.</summary>
        WinBuiltinTerminalServerLicenseServersSid = 60,
        /// <summary>Indicates a SID that matches the distributed COM user group.</summary>
        WinBuiltinDCOMUsersSid = 61,
        /// <summary>Indicates a SID that matches the Internet built-in user group.</summary>
        WinBuiltinIUsersSid = 62,
        /// <summary>Indicates a SID that matches the Internet user group.</summary>
        WinIUserSid = 63,
        /// <summary>Indicates a SID that allows a user to use cryptographic operations. It is added to the token of users who are a member of the CryptoOperators built-in group.</summary>
        WinBuiltinCryptoOperatorsSid = 64,
        /// <summary>Indicates a SID that matches an untrusted label.</summary>
        WinUntrustedLabelSid = 65,
        /// <summary>Indicates a SID that matches an low level of trust label.</summary>
        WinLowLabelSid = 66,
        /// <summary>Indicates a SID that matches an medium level of trust label.</summary>
        WinMediumLabelSid = 67,
        /// <summary>Indicates a SID that matches a high level of trust label.</summary>
        WinHighLabelSid = 68,
        /// <summary>Indicates a SID that matches a system label.</summary>
        WinSystemLabelSid = 69,
        /// <summary>Indicates a SID that matches a write restricted code group.</summary>
        WinWriteRestrictedCodeSid = 70,
        /// <summary>Indicates a SID that matches a creator and owner rights group.</summary>
        WinCreatorOwnerRightsSid = 71,
        /// <summary>Indicates a SID that matches a cacheable principals group.</summary>
        WinCacheablePrincipalsGroupSid = 72,
        /// <summary>Indicates a SID that matches a non-cacheable principals group.</summary>
        WinNonCacheablePrincipalsGroupSid = 73,
        /// <summary>Indicates a SID that matches an enterprise wide read-only controllers group.</summary>
        WinEnterpriseReadonlyControllersSid = 74,
        /// <summary>Indicates a SID that matches an account read-only controllers group.</summary>
        WinAccountReadonlyControllersSid = 75,
        /// <summary>Indicates a SID that matches an event log readers group.</summary>
        WinBuiltinEventLogReadersGroup = 76,
        /// <summary>Indicates a SID that matches a read-only enterprise domain controller.</summary>
        WinNewEnterpriseReadonlyControllersSid = 77,
        /// <summary>Indicates a SID that matches the built-in DCOM certification services access group.</summary>
        WinBuiltinCertSvcDComAccessGroup = 78,
        /// <summary>
        /// Indicates a SID that matches the medium plus integrity label.
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinMediumPlusLabelSid = 79,
        /// <summary>
        /// Indicates a SID that matches a local logon group. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinLocalLogonSid = 80,
        /// <summary>
        /// Indicates a SID that matches a console logon group. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinConsoleLogonSid = 81,
        /// <summary>
        /// Indicates a SID that matches a certificate for the given organization. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinThisOrganizationCertificateSid = 82,
        /// <summary>
        /// Indicates a SID that matches the application package authority. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinApplicationPackageAuthoritySid = 83,
        /// <summary>
        /// Indicates a SID that applies to all app containers. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinBuiltinAnyPackageSid = 84,
        /// <summary>
        /// Indicates a SID of Internet client capability for app containers. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinCapabilityInternetClientSid = 85,
        /// <summary>
        /// Indicates a SID of Internet client and server capability for app containers. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinCapabilityInternetClientServerSid = 86,
        /// <summary>
        /// Indicates a SID of private network client and server capability for app containers. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinCapabilityPrivateNetworkClientServerSid = 87,
        /// <summary>
        /// Indicates a SID for pictures library capability for app containers.
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinCapabilityPicturesLibrarySid = 88,
        /// <summary>
        /// Indicates a SID for videos library capability for app containers. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinCapabilityVideosLibrarySid = 89,
        /// <summary>
        /// Indicates a SID for music library capability for app containers. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinCapabilityMusicLibrarySid = 90,
        /// <summary>
        /// Indicates a SID for documents library capability for app containers. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinCapabilityDocumentsLibrarySid = 91,
        /// <summary>
        /// Indicates a SID for shared user certificates capability for app containers. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinCapabilitySharedUserCertificatesSid = 92,
        /// <summary>
        /// Indicates a SID for Windows credentials capability for app containers. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinCapabilityEnterpriseAuthenticationSid = 93,
        /// <summary>
        /// Indicates a SID for removable storage capability for app containers. 
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not available.</para>
        /// </summary>
        WinCapabilityRemovableStorageSid = 94,
        /// <summary />
        WinBuiltinRDSRemoteAccessServersSid = 95,
        /// <summary />
        WinBuiltinRDSEndpointServersSid = 96,
        /// <summary />
        WinBuiltinRDSManagementServersSid = 97,
        /// <summary />
        WinUserModeDriversSid = 98,
        /// <summary />
        WinBuiltinHyperVAdminsSid = 99,
        /// <summary />
        WinAccountCloneableControllersSid = 100,
        /// <summary />
        WinBuiltinAccessControlAssistanceOperatorsSid = 101,
        /// <summary />
        WinBuiltinRemoteManagementUsersSid = 102,
        /// <summary />
        WinAuthenticationAuthorityAssertedSid = 103,
        /// <summary />
        WinAuthenticationServiceAssertedSid = 104,
        /// <summary />
        WinLocalAccountSid = 105,
        /// <summary />
        WinLocalAccountAndAdministratorSid = 106,
        /// <summary />
        WinAccountProtectedUsersSid = 107,
        /// <summary />
        WinCapabilityAppointmentsSid = 108,
        /// <summary />
        WinCapabilityContactsSid = 109,
        /// <summary />
        WinAccountDefaultSystemManagedSid = 110,
        /// <summary />
        WinBuiltinDefaultSystemManagedGroupSid = 111,
        /// <summary />
        WinBuiltinStorageReplicaAdminsSid = 112,
        /// <summary />
        WinAccountKeyAdminsSid = 113,
        /// <summary />
        WinAccountEnterpriseKeyAdminsSid = 114,
        /// <summary />
        WinAuthenticationKeyTrustSid = 115,
        /// <summary />
        WinAuthenticationKeyPropertyMFASid = 116,
        /// <summary />
        WinAuthenticationKeyPropertyAttestationSid = 117,
        /// <summary />
        WinAuthenticationFreshKeyAuthSid = 118,
        /// <summary />
        WinBuiltinDeviceOwnersSid = 119,
    }
}

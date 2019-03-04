using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10820
    /// <summary>
    /// The <see cref="TOKEN_ACCESS_INFORMATION"/> structure specifies all the information in a token that is necessary to perform an access check.
    /// <para><note>This structure doesn't contain token claim information. Applications that support conditional expression <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access control entries</a> (ACEs) should not use this structure for verifying access. For information about access validation support for conditional expressions, see the <see cref="AuthzAccessCheck"/> and <see cref="AccessCheckAndAuditAlarm"/> functions.</note></para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_mandatory_policy">TOKEN_MANDATORY_POLICY structure</a></para>
    /// </remarks>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct TOKEN_ACCESS_INFORMATION
    {
        /// <summary>
        /// A pointer to a <see cref="SID_AND_ATTRIBUTES_HASH"/> structure that specifies a hash of the token's <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifier</a> (SID).
        /// </summary>
        public SID_AND_ATTRIBUTES_HASH* SidHash;
        /// <summary>
        /// A pointer to a <see cref="SID_AND_ATTRIBUTES_HASH"/> structure that specifies a hash of the token's restricted <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifier</a> (SID).
        /// </summary>
        public SID_AND_ATTRIBUTES_HASH* RestrictedSidHash;
        /// <summary>
        /// A pointer to a <see cref="TOKEN_PRIVILEGES"/> structure that specifies information about the token's privileges.
        /// </summary>
        public TOKEN_PRIVILEGES* Privileges;
        /// <summary>
        /// A <see cref="LUID"/> structure that specifies the token's identity.
        /// </summary>
        public LUID AuthenticationId;
        /// <summary>
        /// A value of the <see cref="TOKEN_TYPE"/> enumeration that specifies the token's type.
        /// </summary>
        public TOKEN_TYPE TokenType;
        /// <summary>
        /// A value of the <see cref="TokenImpersonationLevel"/> enumeration that specifies the token's impersonation level.
        /// </summary>
        public TokenImpersonationLevel ImpersonationLevel;
        /// <summary>
        /// A <see cref="TOKEN_MANDATORY_POLICY"/> structure that specifies the token's mandatory integrity policy.
        /// </summary>
        public TOKEN_MANDATORY_POLICY MandatoryPolicy;
        /// <summary>
        /// Reserved. Must be set to zero.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Flags;
        /// <summary>
        /// The app container number for the token or zero if this is not an app container token.
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008 and Windows Vista</strong>: This member is not available.</para>
        /// </summary>
        public int AppContainerNumber;
        /// <summary>
        /// The app container SID or <see cref="IntPtr.Zero"/> if this is not an app container token.
        /// <para>Use the <see cref="MarshalPackageSidToManaged"/> method, to marshal the SID to a managed <see cref="SecurityIdentifier"/> instance.</para>
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008 and Windows Vista</strong>: This member is not available.</para>
        /// </summary>
        public IntPtr PackageSid;
        /// <summary>
        /// Pointer to a <see cref="SID_AND_ATTRIBUTES_HASH"/> structure that specifies a hash of the token's capability SIDs.
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008 and Windows Vista</strong>: This member is not available.</para>
        /// </summary>
        public SID_AND_ATTRIBUTES_HASH* CapabilitiesHash;
        /// <summary>
        /// The protected process trust level of the token.
        /// <para>Use the <see cref="MarshalTrustLevelSidToManaged"/> method, to marshal the SID to a managed <see cref="SecurityIdentifier"/> instance.</para>
        /// </summary>
        public IntPtr TrustLevelSid;
        /// <summary>
        /// Reserved. Must be set to <c>null</c>.
        /// <para><strong>Prior to Windows 10</strong>: This member is not available.</para>
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void* SecurityAttributes;

        public SecurityIdentifier MarshalPackageSidToManaged() =>
            SID.MarshalToManagedSid(PackageSid);
        public SecurityIdentifier MarshalTrustLevelSidToManaged() =>
            SID.MarshalToManagedSid(TrustLevelSid);
    }
}

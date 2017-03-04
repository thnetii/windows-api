using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="NETSETUP_PROVISIONING_PARAMS"/> structure contains information that is used when creating a provisioning package using the <see cref="NetCreateProvisionPackage"/> function.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="NETSETUP_PROVISIONING_PARAMS"/> structure provides flags for the <see cref="NetCreateProvisioningPackage"/> function which is supported on Windows 8 and Windows Server 2012 and later for offline join operations.</para>
    /// <para>
    /// In addition to domain joins, the provisioning package can provide certificates and policies to the machine. The provisioning package can be used in four ways:
    /// <list type="bullet">
    /// <item>Domain join</item>
    /// <item>Domain join and installation of certificates</item>
    /// <item>Domain join and installation of policies</item>
    /// <item>Domain join and installation of certificates and policies</item>
    /// </list>
    /// </para>
    /// <para>When certificates need to be added to the package, this structure provides the <see cref="aCertTemplateNames"/> member as an array of zero-terminated certificate template names. The <see cref="aCertTemplateNames"/> member requires the <see cref="cCertTemplateNames"/> member to provide an explicit count of the number of items in the array.</para>
    /// <para>
    /// There are two different ways to add policies. You can use one or both methods:
    /// <list type="table">
    /// <term>Policy name</term> <description>An array of zero-terminated policy names is provided in the <see cref="aMachinePolicyNames"/> member. During runtime, the policy name is mapped to the policy name in AD and the GUID that represents the policy in the enterprise space is retrieved. The <see cref="aMachinePolicyNames"/> member requires the <see cref="cMachinePolicyNames"/> member to provide an explicit count of the number of items in the array.</description>
    /// <term>Policy path</term> <description>A pointer to an array of zero-terminated character strings provided in the <see cref="aMachinePolicyPaths"/> member which specify the path to a file in the Registry Policy File format. For more information on the Registry Policy File Format, see <a href="https://msdn.microsoft.com/en-us/library/aa374407.aspx">Registry Policy File Format</a>. The policy path is a full or relative path to the policy file.</description>
    /// </list>
    /// </para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/hh706772.aspx">NETSETUP_PROVISIONING_PARAMS structure</a></para>
    /// </remarks>
    /// <seealso cref="NetCreateProvisionPackage"/>
    /// <seealso cref="NetJoinDomain"/>
    /// <seealso cref="NetProvisionComputerAccount"/>
    /// <seealso cref="NetRenameMachineInDomain"/>
    /// <seealso cref="NetRequestOfflineDomainJoin"/>
    /// <seealso cref="NetRequestProvisioningPackageInstall"/>
    /// <seealso cref="NetUnjoinDomain"/>
    [StructLayout(LayoutKind.Sequential)]
    public class NETSETUP_PROVISIONING_PARAMS
    {
        // For dwVersion field of NETSETUP_PROVISIONING_PARAMS
        /// <summary>The version for this package is Windows Server 2012 and Windows 8.</summary>
        public const int NETSETUP_PROVISIONING_PARAMS_WIN8_VERSION = 0x00000001;
        /// <summary>The version for this package is Windows Server 2016 and Windows 10.</summary>
        public const int NETSETUP_PROVISIONING_PARAMS_CURRENT_VERSION = 0x00000002;

        // Version 1 fields
        /// <summary>
        /// The version of Windows in the provisioning package. Set to <see cref="NETSETUP_PROVISIONING_PARAMS_CURRENT_VERSION"/> by default.
        /// </summary>
        public int dwVersion = NETSETUP_PROVISIONING_PARAMS_CURRENT_VERSION;
        /// <summary>
        /// A string that specifies the name of the domain where the computer account is created. 
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDomain;
        /// <summary>
        /// A string that specifies the short name of the machine from which the computer account attribute sAMAccountName is derived by appending a '$'. This parameter must contain a valid DNS or NetBIOS machine name.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpMachineName;
        /// <summary>
        /// <para>A string that contains the RFC 1779 format name of the organizational unit (OU) where the computer account will be created. If you specify this parameter, the string must contain a full path, for example, OU=testOU,DC=domain,DC=Domain,DC=com. Otherwise, this parameter must be <c>null</c>.</para>
        /// <para>If this parameter is <c>null</c>, the well known computer object container will be used as published in the domain.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpMachineAccountOU;
        /// <summary>
        /// An optional string that contains the name of the domain controller to target.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDcName;
        /// <summary>
        /// A set of bit flags that define provisioning options.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public NETSETUP_PROVISION_FLAGS dwProvisionOptions;
        /// <summary>
        /// A pointer to an array of zero-terminated certificate template names. 
        /// </summary>
        public WideStringZeroTerminatedArrayAnySafeHandle aCertTemplateNames;
        /// <summary>
        /// When <see cref="aCertTemplateNames"/> is not <c>null</c>, this member provides an explicit count of the number of items in the array.
        /// </summary>
        public int cCertTemplateNames;
        /// <summary>
        /// Gets the array of certificate template names.
        /// </summary>
        /// <returns>A managed string array instance containing exactly <see cref="cCertTemplateNames"/> elements, or <c>null</c> if <see cref="aCertTemplateNames"/> is <c>null</c>.</returns>
        /// <seealso cref="aCertTemplateNames"/>
        public string[] GetCertTemplateNames() => WideStringZeroTerminatedArraySafeHandle.ReadValue(aCertTemplateNames, cCertTemplateNames);
        /// <summary>
        /// A pointer to an array of zero-terminated machine policy names.
        /// </summary>
        public WideStringZeroTerminatedArrayAnySafeHandle aMachinePolicyNames;
        /// <summary>
        /// When <see cref="aMachinePolicyNames"/> is not <c>null</c>, this member provides an explicit count of the number of items in the array.
        /// </summary>
        public int cMachinePolicyNames;
        /// <summary>
        /// Gets the arry of machine policy names.
        /// </summary>
        /// <returns>A managed string array instance containing exactly <see cref="cMachinePolicyNames"/> elements, or <c>null</c> if <see cref="aMachinePolicyNames"/> is <c>null</c>.</returns>
        /// <seealso cref="aMachinePolicyNames"/>
        public string[] GetMachinePolicyNames() => WideStringZeroTerminatedArraySafeHandle.ReadValue(aMachinePolicyNames, cMachinePolicyNames);
        /// <summary>
        /// A pointer to an array of character strings. Each array element is a zero-terminated character string which specifies the full or partial path to a file in the Registry Policy File format. For more information on the Registry Policy File Format, see <a href="https://msdn.microsoft.com/en-us/library/aa374407.aspx">Registry Policy File Format</a>.
        /// <para>These paths could be UNC paths on a remote server.</para>
        /// </summary>
        public WideStringZeroTerminatedArrayAnySafeHandle aMachinePolicyPaths;
        /// <summary>
        /// When <see cref="aMachinePolicyPaths"/> is not <c>null</c>, this member provides an explicit count of the number of items in the array.
        /// </summary>
        public int cMachinePolicyPaths;
        /// <summary>
        /// Gets the array of machine policy paths.
        /// </summary>
        /// <returns>A managed string array instance containing exactly <see cref="cMachinePolicyPaths"/> elements, or <c>null</c> if <see cref="aMachinePolicyPaths"/> is <c>null</c>.</returns>
        /// <seealso cref="aMachinePolicyPaths"/>
        public string[] GetMachinePolicyPaths() => WideStringZeroTerminatedArraySafeHandle.ReadValue(aMachinePolicyPaths, cMachinePolicyPaths);

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        // Version 2 fields
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpNetbiosName;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpSiteName;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpPrimaryDNSDomain;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}

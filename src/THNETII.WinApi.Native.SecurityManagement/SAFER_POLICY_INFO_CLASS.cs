namespace Microsoft.Win32.WinApi.SecurityIdentity.SecurityManagement
{
    /// <summary>
    /// The <see cref="SAFER_POLICY_INFO_CLASS"/> enumeration type defines the ways in which a policy may be queried.
    /// </summary>
    /// <remarks>
    /// The <see cref="SAFER_POLICY_INFO_CLASS"/> enumeration type is used by the <see cref="SaferGetPolicyInformation"/> function. 
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms722437.aspx">SAFER_POLICY_INFO_CLASS enumeration</a></para>
    /// </remarks>
    public enum SAFER_POLICY_INFO_CLASS
    {
        /// <summary>Queries for the list of all levels defined in a policy.</summary>
        SaferPolicyLevelList = 1,
        /// <summary>Queries for the policy value to determine whether DLL checking is enabled.</summary>
        SaferPolicyEnableTransparentEnforcement = 2,
        /// <summary>Queries for the default policy level.</summary>
        SaferPolicyDefaultLevel = 3,
        /// <summary>Queries to determine whether user scope rules should be consulted during policy evaluation.</summary>
        SaferPolicyEvaluateUserScope = 4,
        /// <summary>Queries to determine whether the policy is to skip members of the local administrators group.</summary>
        SaferPolicyScopeFlags = 5
    }
}

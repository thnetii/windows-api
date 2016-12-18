namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="ACL_INFORMATION_CLASS"/> enumeration contains values that specify the type of information being assigned to or retrieved from an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_list_gly"></a></em>access control list (ACL).
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa374935.aspx">ACL_INFORMATION_CLASS enumeration</a></para>
    /// </remarks>
    /// <seealso cref="System.Security.AccessControl.GenericAcl"/>
    /// <seealso cref="ACL_REVISION_INFORMATION"/>
    /// <seealso cref="ACL_SIZE_INFORMATION"/>
    /// <seealso cref="GetAclInformation"/>
    /// <seealso cref="SetAclInformation"/>
    public enum ACL_INFORMATION_CLASS
    {
        /// <summary>Indicates ACL revision information.</summary>
        AclRevisionInformation = 1,
        /// <summary>Indicates ACL size information.</summary>
        AclSizeInformation
    }
}

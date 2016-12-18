using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="ACL_REVISION_INFORMATION"/> structure contains revision information about an <see cref="GenericAcl"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa374942.aspx">ACL_REVISION_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="GenericAcl"/>
    /// <seealso cref="ACL_INFORMATION_CLASS"/>
    /// <seealso cref="ACL_SIZE_INFORMATION"/>
    /// <seealso cref="GetAclInformation"/>
    /// <seealso cref="SetAclInformation"/>
    [StructLayout(LayoutKind.Sequential)]
    public class ACL_REVISION_INFORMATION
    {
        /// <summary>Specifies a revision number. The current revision number is <see cref="GenericAcl.AclRevision"/>.</summary>
        public int AclRevision;
    }
}

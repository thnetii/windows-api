using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="ACL_SIZE_INFORMATION"/> structure contains information about the size of an <see cref="GenericAcl"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa374945.aspx">ACL_SIZE_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="GenericAcl"/>
    /// <seealso cref="ACL_INFORMATION_CLASS"/>
    /// <seealso cref="ACL_REVISION_INFORMATION"/>
    /// <seealso cref="GetAclInformation"/>
    /// <seealso cref="SetAclInformation"/>
    [StructLayout(LayoutKind.Sequential)]
    public class ACL_SIZE_INFORMATION
    {
        /// <summary>The number of <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_entry_gly">access control entries</a></em> (ACEs) in the <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_list_gly">access control list</a></em> (ACL).</summary>
        public int AceCount;
        /// <summary>The number of bytes in the ACL actually used to store the ACEs and <see cref="GenericAcl"/> structure. This may be less than the total number of bytes allocated to the ACL.</summary>
        public int AclBytesInUse;
        /// <summary>The number of unused bytes in the ACL.</summary>
        public int AclBytesFree;
    }
}

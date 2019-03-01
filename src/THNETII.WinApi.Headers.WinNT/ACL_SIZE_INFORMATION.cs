using System.Runtime.InteropServices;
using System.Security.AccessControl;
using static THNETII.WinApi.Native.WinNT.ACL_INFORMATION_CLASS;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10069
    /// <summary>
    /// The <see cref="ACL_SIZE_INFORMATION"/> structure contains revision information about an <see cref="GenericAcl"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This record is returned if the user is requesting <see cref="AclSizeInformation"/>
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/window/desktop/api/Winnt/ns-winnt-_acl_size_information">ACL_SIZE_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="GenericAcl"/>
    /// <seealso cref="ACL_INFORMATION_CLASS"/>
    /// <seealso cref="ACL_REVISION_INFORMATION"/>
    /// <seealso cref="GetAclInformation"/>
    /// <seealso cref="SetAclInformation"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct ACL_SIZE_INFORMATION
    {
        /// <summary>
        /// The number of <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access control entries</a> (ACEs) in the <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access control list</a> (ACL).
        /// </summary>
        public int AceCount;
        /// <summary>
        /// The number of bytes in the ACL actually used to store the ACEs and <see cref="GenericAcl"/> structure. This may be less than the total number of bytes allocated to the ACL.
        /// </summary>
        public int AclBytesInUse;
        /// <summary>
        /// The number of unused bytes in the ACL.
        /// </summary>
        public int AclBytesFree;
    }
}

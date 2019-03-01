using System.Runtime.InteropServices;
using System.Security.AccessControl;

using static THNETII.WinApi.Native.WinNT.ACL_INFORMATION_CLASS;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10064
    /// <summary>
    /// The <see cref="ACL_REVISION_INFORMATION"/> structure contains revision information about an <see cref="GenericAcl"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This record is returned/sent if the user is requesting/setting the
    /// <see cref="AclRevisionInformation"/>
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-_acl_revision_information">ACL_REVISION_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="GenericAcl"/>
    /// <seealso cref="ACL_INFORMATION_CLASS"/>
    /// <seealso cref="ACL_SIZE_INFORMATION"/>
    /// <seealso cref="GetAclInformation"/>
    /// <seealso cref="SetAclInformation"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct ACL_REVISION_INFORMATION
    {
        /// <summary>Specifies a revision number. The current revision number is <see cref="GenericAcl.AclRevision"/></summary>
        public int AclRevision;
    }
}

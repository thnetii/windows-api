using System.Security.AccessControl;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10054
    /// <summary>
    /// The <see cref="ACL_INFORMATION_CLASS"/> enumeration contains values that specify the type of information being assigned to or retrieved from an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access control list</a> (ACL).
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ne-winnt-acl_information_class">ACL_INFORMATION_CLASS enumeration</a></para>
    /// </remarks>
    /// <seealso cref="RawAcl"/>
    /// <seealso cref="ACL_REVISION_INFORMATION"/>
    /// <seealso cref="ACL_SIZE_INFORMATION"/>
    /// <seealso href="https://msdn.microsoft.com/d9ce4ec5-5c09-4b33-93a1-39638a925986">Access Control Overview</seealso>
    /// <seealso href="https://msdn.microsoft.com/e2f22838-102e-432c-9c82-06a3e0741374">Authorization Enumerations</seealso>
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

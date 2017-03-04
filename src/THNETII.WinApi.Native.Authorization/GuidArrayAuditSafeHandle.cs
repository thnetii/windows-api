using System;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public class GuidArrayAuditSafeHandle : AuditSafeHandle, ISafeHandleReadableAsSimpleStructureArray<Guid> { }
}
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;

namespace THNETII.WinApi.Native.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    public static class SECURITY_DESCRIPTOR
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct STRUCT_SECURITY_DESCRIPTOR
        {
            public readonly byte Revision;
            [EditorBrowsable(EditorBrowsableState.Never)]
            internal readonly byte Sbz1;
            public readonly short Control;
            public readonly IntPtr Owner;
            public readonly IntPtr Group;
            public readonly IntPtr Sacl;
            public readonly IntPtr Dacl;
        }

        [SuppressMessage("Usage", "PC001: API not supported on all platforms")]
        public static RawSecurityDescriptor MarshalToManagedSecurityDescriptor(IntPtr ptrSecDesc)
        {
            if (ptrSecDesc == IntPtr.Zero)
                return null;
            ControlFlags controlFlags;
            SecurityIdentifier owner, group;
            RawAcl sacl, dacl;
            unsafe
            {
                STRUCT_SECURITY_DESCRIPTOR* pSecDesc = (STRUCT_SECURITY_DESCRIPTOR*)ptrSecDesc.ToPointer();
                controlFlags = (ControlFlags)pSecDesc->Control;
                owner = SID.MarshalToManagedSid(pSecDesc->Owner);
                group = SID.MarshalToManagedSid(pSecDesc->Group);
                sacl = ACL.MarshalToManagedAcl(pSecDesc->Sacl);
                dacl = ACL.MarshalToManagedAcl(pSecDesc->Dacl);
            }
            return new RawSecurityDescriptor(controlFlags, owner, group, sacl, dacl);
        }
    }
}

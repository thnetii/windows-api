using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10458
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SE_ACCESS_REQUEST
    {
        public int Size;
        public SE_SECURITY_DESCRIPTOR* SeSecurityDescriptor;
        public ACCESS_MASK DesiredAccess;
        public ACCESS_MASK PreviouslyGrantedAccess;
        public SID* PrincipalSelfSid;      // Need to watch how this field affects the cache.
        public GENERIC_MAPPING* GenericMapping;
        public int ObjectTypeListCount;
        public OBJECT_TYPE_LIST* PObjectTypeList;
        public unsafe Span<OBJECT_TYPE_LIST> ObjectTypeList => new Span<OBJECT_TYPE_LIST>(PObjectTypeList, ObjectTypeListCount);
    }
}

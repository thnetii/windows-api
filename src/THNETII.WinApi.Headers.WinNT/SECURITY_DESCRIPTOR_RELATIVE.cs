using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10195
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_DESCRIPTOR_RELATIVE
    {
        public SECURITY_DESCRIPTOR_REVISION Revision;
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal byte Sbz1;
        public SECURITY_DESCRIPTOR_CONTROL Control;
        public int OwnerOffset;
        public unsafe ref SID Owner
        {
            get
            {
                fixed (SECURITY_DESCRIPTOR_RELATIVE* pThis = &this)
                {
                    var pOwner = new IntPtr(pThis) + OwnerOffset;
                    return ref Unsafe.AsRef<SID>(pOwner.ToPointer());
                }
            }
        }
        public int GroupOffset;
        public unsafe ref SID Group
        {
            get
            {
                fixed (SECURITY_DESCRIPTOR_RELATIVE* pThis = &this)
                {
                    var pOwner = new IntPtr(pThis) + GroupOffset;
                    return ref Unsafe.AsRef<SID>(pOwner.ToPointer());
                }
            }
        }
        public int SaclOffset;
        public unsafe ref ACL Sacl
        {
            get
            {
                fixed (SECURITY_DESCRIPTOR_RELATIVE* pThis = &this)
                {
                    var pOwner = new IntPtr(pThis) + SaclOffset;
                    return ref Unsafe.AsRef<ACL>(pOwner.ToPointer());
                }
            }
        }
        public int DaclOffset;
        public unsafe ref ACL Dacl
        {
            get
            {
                fixed (SECURITY_DESCRIPTOR_RELATIVE* pThis = &this)
                {
                    var pOwner = new IntPtr(pThis) + DaclOffset;
                    return ref Unsafe.AsRef<ACL>(pOwner.ToPointer());
                }
            }
        }
    }
}

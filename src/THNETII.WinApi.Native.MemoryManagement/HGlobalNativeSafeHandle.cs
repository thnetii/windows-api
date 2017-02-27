using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
    public class HGlobalNativeSafeHandle : SafeHandle
    {
        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            throw new NotImplementedException();
        }

        protected HGlobalNativeSafeHandle() : this(IntPtr.Zero, ownsHandle: false) { }

        protected HGlobalNativeSafeHandle(IntPtr invalidHandleValue, bool ownsHandle = false) : base(invalidHandleValue, ownsHandle) { }
    }
}

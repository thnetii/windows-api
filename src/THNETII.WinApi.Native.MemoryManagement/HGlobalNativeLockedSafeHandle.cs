using Microsoft.Win32.WinApi.WinError;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.MemoryManagementFunctions;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
    public class HGlobalNativeLockedSafeHandle : HGlobalNativeSafeHandle
    {
        private class HGlobalNativeUnmanagedSafeHandle : HGlobalNativeSafeHandle
        {
            public HGlobalNativeUnmanagedSafeHandle(IntPtr handle) : base(IntPtr.Zero, ownsHandle: false)
            {
                this.handle = handle;
            }
        }

        private HGlobalNativeSafeHandle globalHandle;

        /// <inheritdoc />
        public override GMEM_FLAGS Flags => Handle.Flags;

        /// <inheritdoc />
        public override bool IsDiscarded => Handle.IsDiscarded;

        /// <inheritdoc />
        public override int LockCount => Handle.LockCount;

        /// <inheritdoc />
        public override ulong Size => Handle.Size;

        public HGlobalNativeSafeHandle Handle
        {
            get
            {
                if (IsClosed)
                    throw new ObjectDisposedException(nameof(handle));
                if (IsInvalid)
                    throw new InvalidOperationException();
                return globalHandle ?? CacheGlobalHandle();
            }
        }

        private HGlobalNativeSafeHandle CacheGlobalHandle()
        {
            var globalHandle = GlobalHandle(handle);
            if (globalHandle == IntPtr.Zero)
                throw new Win32Exception(Marshal.GetLastWin32Error());
            this.globalHandle = new HGlobalNativeUnmanagedSafeHandle(globalHandle);
            return this.globalHandle;
        }

        protected override bool ReleaseHandle()
        {
            if (IsInvalid)
                return false;
            var globalHandle = GlobalHandle(handle);
            if (globalHandle == IntPtr.Zero)
                throw new Win32Exception(Marshal.GetLastWin32Error());
            var unlockReturnValue = GlobalUnlock(globalHandle);
            if (unlockReturnValue)
                return true;
            var winApiError = (Win32ErrorCode)Marshal.GetLastWin32Error();
            if (winApiError == NO_ERROR)
                return true;
            throw new Win32Exception((int)winApiError);
        }
    }
}

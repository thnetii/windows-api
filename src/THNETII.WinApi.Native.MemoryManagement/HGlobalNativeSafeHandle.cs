using Microsoft.Win32.WinApi.WinError;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.MemoryManagementFunctions;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
    public class HGlobalNativeSafeHandle : SafeHandle
    {
        /// <inheritdoc />
        public override bool IsInvalid => handle == IntPtr.Zero;

        public virtual GMEM_FLAGS Flags => GetFlags() & ~(GMEM_FLAGS.GMEM_LOCKCOUNT);

        public virtual int LockCount => GetFlags().GetLockCount();

        public virtual bool IsDiscarded => Flags.HasFlag(GMEM_FLAGS.GMEM_DISCARDED);

        private GMEM_FLAGS GetFlags()
        {
            if (IsClosed)
                throw new ObjectDisposedException(nameof(handle));
            else if (IsInvalid)
                throw new InvalidOperationException();
            var flags = GlobalFlags(this);
            if (flags.HasFlag(GMEM_FLAGS.GMEM_INVALID_HANDLE))
                throw new Win32Exception(Marshal.GetLastWin32Error());
            return flags;
        }

        /// <summary>
        /// Retrieves the current size of the global memory object, in bytes.
        /// </summary>
        public virtual ulong Size
        {
            get
            {
                if (IsClosed)
                    throw new ObjectDisposedException(nameof(handle));
                else if (IsInvalid)
                    throw new InvalidOperationException();
                var size = GlobalSize(this);
                if (size == 0)
                {
                    var winApiError = (Win32ErrorCode)Marshal.GetLastWin32Error();
                    if (winApiError != NO_ERROR)
                        throw new Win32Exception((int)winApiError);
                }
                return size;
            }
        }

        protected override bool ReleaseHandle()
        {
            if (IsInvalid)
                return false;
            handle = GlobalFree(handle);
            if (IsInvalid)
                throw new Win32Exception(Marshal.GetLastWin32Error());
            return true;
        }

        protected HGlobalNativeSafeHandle() : this(IntPtr.Zero, ownsHandle: true) { }

        protected HGlobalNativeSafeHandle(IntPtr invalidHandleValue, bool ownsHandle = true) : base(invalidHandleValue, ownsHandle) { }
    }
}

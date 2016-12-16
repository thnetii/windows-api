using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Provides a managed handle object for a Network Management API Buffer.
    /// </summary>
    public class NetApiBufferHandle : SafeHandle
    {
        /// <inheritdoc />
        public override bool IsInvalid { get; } = false;

        /// <summary>
        /// Gets the size, in bytes, of natively allocated memory by the <see cref="NetApiBufferHandle"/>.
        /// </summary>
        public int BufferSize
        {
            get
            {
                if (IsClosed)
                    throw new ObjectDisposedException(nameof(handle));
                else if (IsInvalid)
                    throw new InvalidOperationException();
                var netApiStatus = NetApiBufferSize(handle, out int ByteCount);
                if (netApiStatus == NetworkManagementErrorCode.NERR_Success)
                    return ByteCount;
                throw new Win32Exception((int)netApiStatus);
            }
        }

        /// <inheritdoc />
        protected override bool ReleaseHandle()
        {
            if (IsInvalid)
                return false;
            var netApiStatus = NetApiBufferFree(handle);
            if (netApiStatus == NetworkManagementErrorCode.NERR_Success)
                return true;
            throw new Win32Exception((int)netApiStatus);
        }

        /// <inheritdoc />
        protected NetApiBufferHandle() : this(ownsHandle: true) { }

        /// <inheritdoc />
        protected NetApiBufferHandle(bool ownsHandle) : base(IntPtr.Zero, ownsHandle) { }

        /// <summary>
        /// Allocates native memory from the heap for use by the Network Management API.
        /// </summary>
        /// <param name="ByteCount">Number of bytes to be allocated.</param>
        public NetApiBufferHandle(int ByteCount) : this()
        {
            IsInvalid = true;
            var netApiStatus = NetApiBufferAllocate(ByteCount, out handle);
            if (netApiStatus != NetworkManagementErrorCode.NERR_Success)
            {
                IsInvalid = true;

                throw new Win32Exception((int)netApiStatus);
            }
        }
    }
}

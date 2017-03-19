using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;

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
        /// <exception cref="ObjectDisposedException">The memory that the handle control has been freed.</exception>
        /// <exception cref="InvalidOperationException">The handle represented by this instance is invalid.</exception>
        /// <exception cref="Win32Exception">An error occurred during the native call to the system.</exception>
        public int ByteSize
        {
            get
            {
                if (IsClosed)
                    throw new ObjectDisposedException(nameof(handle));
                else if (IsInvalid)
                    throw new InvalidOperationException();
                int ByteCount;
                var netApiStatus = NetApiBufferSize(handle, out ByteCount);
                if (netApiStatus == NERR_Success)
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
            if (netApiStatus == NERR_Success)
                return true;
            throw new Win32Exception((int)netApiStatus);
        }

        protected NetApiBufferHandle() : this(ownsHandle: true) { }

        protected NetApiBufferHandle(bool ownsHandle) : base(IntPtr.Zero, ownsHandle) { }

        /// <summary>
        /// Allocates native memory from the heap for use by the Network Management API.
        /// </summary>
        /// <param name="ByteCount">Number of bytes to be allocated.</param>
        /// <exception cref="Win32Exception">An error occurred during the native call to the system.</exception>
        public NetApiBufferHandle(int ByteCount) : this()
        {
            var netApiStatus = NetApiBufferAllocate(ByteCount, out handle);
            if (netApiStatus != NERR_Success)
            {
                IsInvalid = true;

                throw new Win32Exception((int)netApiStatus);
            }
        }
    }

    public class GroupInfoNetApiBufferHandle : NetApiBufferHandle
    {
    }

    public class GroupInfoArrayNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class GroupUsersInfoNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class GroupUsersInfoArrayNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class LocalGroupInfoNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class LocalGroupInfoArrayNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class LocalGroupMembersInfoNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class LocalGroupMembersInfoArrayNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class MsgInfoNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class MsgInfoNetArrayApiBufferHandle : NetApiBufferHandle
    {

    }

    public class NetDisplayNetApiBufferHandle : NetApiBufferHandle
    {
    }

    public class NetDisplayArrayNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class TimeOfDayInfoNetApiBufferHandle : NetApiBufferHandle, ISafeHandleReadableAsSimpleStructure<TIME_OF_DAY_INFO> { }

    public class ByteArrayNetApiBufferHandle : NetApiAlertBufferHandle, ISafeHandleReadableAsByteArray { }

    public class AtEnumArrayNetApiNetApiBufferHandle : NetApiAlertBufferHandle, ISafeHandleReadableAsSimpleStructureArray<AT_ENUM> { }

    public class AtIntoNetApiNetApiBufferHandle : NetApiAlertBufferHandle, ISafeHandleReadableAsSimpleStructure<AT_INFO> { }

    public class WideStringZeroTerminatedArrayNetApiBufferHandle : NetApiAlertBufferHandle, ISafeHandleReadableAsWideStringZeroTerminatedArray { }

    public class ServerInfoNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class ServerInfoArrayNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class ServerTransportInfoArrayNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class UseInfoNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class UseInfoArrayNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class UserInfoNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class UserInfoArrayNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class GroupUserInfoNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class GroupUserInfoArrayNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class LocalGroupUsersArrayInfoNetApiBufferHandle : NetApiBufferHandle
    {

    }

    public class UserModalsInfoNetApiBufferHandle : NetApiBufferHandle
    {

    }
}

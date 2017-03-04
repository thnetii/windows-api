using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    public class NetAadJoinInformationBuffer : SafeHandle, ISafeHandleReadableAsSimpleStructure<DSREG_JOIN_INFO>
    {
        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            if (IsInvalid)
                return false;
            NetFreeAadJoinInformation(handle);
            return true;
        }

        protected NetAadJoinInformationBuffer() : this(ownsHandle: true) { }
        protected NetAadJoinInformationBuffer(bool ownsHandle) : this(IntPtr.Zero, ownsHandle) { }
        protected NetAadJoinInformationBuffer(IntPtr invalidHandleValue, bool ownsHandle = true) : base(invalidHandleValue, ownsHandle) { }
    }
}
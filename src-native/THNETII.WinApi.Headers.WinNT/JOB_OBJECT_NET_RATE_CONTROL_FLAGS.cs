using System;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11872
    /// <summary>
    /// Specifies types of scheduling policies for network rate control.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ne-winnt-job_object_net_rate_control_flags">JOB_OBJECT_NET_RATE_CONTROL_FLAGS Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="JOBOBJECT_NET_RATE_CONTROL_INFORMATION"/>
    [Flags]
    public enum JOB_OBJECT_NET_RATE_CONTROL_FLAGS
    {
        /// <summary>
        /// Turns on the control of the network traffic. You must
        /// set this value if you also set either
        /// <see cref="JOB_OBJECT_NET_RATE_CONTROL_MAX_BANDWIDTH"/>
        /// or <see cref="JOB_OBJECT_NET_RATE_CONTROL_DSCP_TAG"/>.
        /// </summary>
        JOB_OBJECT_NET_RATE_CONTROL_ENABLE = 0x1,
        /// <summary/>
        JOB_OBJECT_NET_RATE_CONTROL_MAX_BANDWIDTH = 0x2,
        /// <summary>
        /// Sets the DSCP field in the packet header to the value of
        /// the <see cref="JOBOBJECT_NET_RATE_CONTROL_INFORMATION.DscpTag"/> member of the
        /// <see cref="JOBOBJECT_NET_RATE_CONTROL_INFORMATION"/>
        /// structure. For information about DSCP, see
        /// <a href="https://msdn.microsoft.com/0b4afa74-0198-482d-af72-9ddf135a8e2f">Differentiated Services</a>.
        /// </summary>
        JOB_OBJECT_NET_RATE_CONTROL_DSCP_TAG = 0x4,
        /// <summary>
        /// The combination of all of the valid flags for the
        /// <see cref="JOB_OBJECT_NET_RATE_CONTROL_FLAGS"/> enumeration.
        /// </summary>
        JOB_OBJECT_NET_RATE_CONTROL_VALID_FLAGS = 0x7
    }
}

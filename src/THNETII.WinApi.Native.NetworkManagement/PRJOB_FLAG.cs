using System;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Bitmap masks for <see cref="PRINT_OTHER_INFO.alrtpr_status"/> field of <see cref="PRINT_OTHER_INFO"/>.
    /// </summary>
    [Flags]
    public enum PRJOB_FLAG : int
    {
        // 2-7 bits also used in device status

        /// <summary>You can obtain the overall status of the job by checking <see cref="PRJOB_QSTATUS"/> (bits 0 and 1). </summary>
        PRJOB_QSTATUS = 0x3,        // Bits 0,1
        /// <summary>If the print job is in the <see cref="PRJOB_QS_PRINTING"/> state, you can check bits 2 through 8 for the device's status (<see cref="PRJOB_DEVSTATUS"/>). Bit 15 is also meaningful.</summary>
        PRJOB_DEVSTATUS = 0x1fc,    // 2-8 bits
        /// <summary>The job has completed printing.</summary>
        PRJOB_COMPLETE = 0x4,       // Bit 2
        /// <summary>The destination printer requires an operator's intervention.</summary>
        PRJOB_INTERV = 0x8,         // Bit 3
        /// <summary>There is an error at the destination printer.</summary>
        PRJOB_ERROR = 0x10,         // Bit 4
        /// <summary>The destination printer is offline.</summary>
        PRJOB_DESTOFFLINE = 0x20,   // Bit 5
        /// <summary>The destination printer is paused.</summary>
        PRJOB_DESTPAUSED = 0x40,    // Bit 6
        /// <summary>A printing alert should be raised.</summary>
        PRJOB_NOTIFY = 0x80,        // BIT 7
        /// <summary>The destination printer is out of paper.</summary>
        PRJOB_DESTNOPAPER = 0x100,  // BIT 8
        /// <summary>The printing job is being deleted.</summary>
        PRJOB_DELETED = 0x8000,     // BIT 15

        //
        //      Values of PRJOB_QSTATUS bits in prjob_status field of PRINTJOB.
        //

        /// <summary>The print job is in the queue waiting to be scheduled.</summary>
        PRJOB_QS_QUEUED = 0,
        /// <summary>The print job is in the queue, but it has been paused. (When a job is paused, it cannot be scheduled.)</summary>
        PRJOB_QS_PAUSED = 1,
        /// <summary>The print job is in the process of being spooled.</summary>
        PRJOB_QS_SPOOLING = 2,
        /// <summary>The job is currently printing.</summary>
        PRJOB_QS_PRINTING = 3,

    }
}
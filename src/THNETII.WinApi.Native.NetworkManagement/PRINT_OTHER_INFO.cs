using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="PRINT_OTHER_INFO"/> structure contains information about a print job. The <see cref="NetAlertRaise"/> and <see cref="NetAlertRaiseEx"/> functions use the <see cref="PRINT_OTHER_INFO"/> structure to specify information when a job has finished printing, or when a printer needs intervention.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Additional variable-length data follows the <see cref="PRINT_OTHER_INFO"/> structure in the alert message buffer. The information is in the form of contiguous null-terminated character strings, as follows.
    /// <list type="table">
    /// <listheader><term>String</term><description>Meaning</description></listheader>
    /// <term>computername</term><description>The computer that submitted the print job.</description>
    /// <term>username</term><description>The user who submitted the print job.</description>
    /// <term>queuename</term><description>The print queue to which the job was submitted.</description>
    /// <term>destination</term><description>The printer destination (device) to which the print job was routed.</description>
    /// <term>status</term><description>The status of the print job.</description>
    /// </list>
    /// </para>
    /// <para>The calling application must allocate and free the memory for all structures and variable-length data in an alert message buffer.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370695.aspx">PRINT_OTHER_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="ADMIN_OTHER_INFO"/>
    /// <seealso cref="ERRLOG_OTHER_INFO"/>
    /// <seealso cref="STD_ALERT"/>
    /// <seealso cref="USER_OTHER_INFO"/>
    /// <seealso cref="NetAlertRaise"/>
    /// <seealso cref="NetAlertRaiseEx"/>
    [StructLayout(LayoutKind.Sequential)]
    public class PRINT_OTHER_INFO
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 00, 00, 00, DateTimeKind.Utc);

        /// <summary>
        /// The identification number of the print job.
        /// </summary>
        public uint alrtpr_jobid;
        /// <summary>
        /// A bitmask describing the status of the print job. 
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public PRJOB_FLAG alrtpr_status;
        /// <summary>
        /// The time at which the print job was submitted. This value is stored as the number of seconds that have elapsed since 00:00:00, January 1, 1970, GMT.
        /// </summary>
        public uint alrtpr_submitted;
        /// <summary>
        /// The time at which the print job was submitted, expressed as a <see cref="DateTime"/> value using the local time of the system.
        /// </summary>
        public DateTime SubmittedTime
        {
            get { return epoch.AddSeconds(alrtpr_submitted).ToLocalTime(); }
            set { alrtpr_submitted = value == default(DateTime) ? 0 : (uint)((value - epoch).TotalSeconds); }
        }
        /// <summary>
        /// The size, in bytes, of the print job.
        /// </summary>
        public uint alrtpr_size;
    }
}

using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_OTHER_INFO"/> structure contains user error code information. The <see cref="NetAlertRaise"/> and <see cref="NetAlertRaiseEx"/> functions use the <see cref="USER_OTHER_INFO"/> structure to specify information about an event or condition of interest to a user.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Additional variable-length data follows the <see cref="USER_OTHER_INFO"/> structure in the alert message buffer. The information is in the form of contiguous null-terminated character strings, as follows.
    /// <list type="table">
    /// <listheader><term>String</term> <description>Meaning</description></listheader>
    /// <term><var>username</var></term><description>The user who created the session.</description>
    /// <term><var>computername</var></term><description>The computer that created the session.</description>
    /// </list>
    /// </para>
    /// <para>The calling application must allocate and free the memory for all structures and variable-length data in an alert message buffer.</para>
    /// <para>See <see cref="NetAlertRaiseEx"/> for a code sample that demonstrates how to raise a user alert.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371357.aspx">USER_OTHER_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="ADMIN_OTHER_INFO"/>
    /// <seealso cref="ERRLOG_OTHER_INFO"/>
    /// <seealso cref="PRINT_OTHER_INFO"/>
    /// <seealso cref="STD_ALERT"/>
    /// <seealso cref="NetAlertRaise"/>
    /// <seealso cref="NetAlertRaiseEx"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_OTHER_INFO
    {
        /// <summary>
        /// Specifies the error code for the new message in the message log.
        /// </summary>
        public int alrtus_errcode;
        /// <summary>
        /// Specifies the number (0-9) of consecutive Unicode strings in the message log.
        /// </summary>
        public int alrtus_numstrings;
    }
}

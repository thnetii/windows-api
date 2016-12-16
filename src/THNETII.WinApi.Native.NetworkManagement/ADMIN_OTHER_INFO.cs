using System.Runtime.InteropServices;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="ADMIN_OTHER_INFO"/> structure contains error message information. The <see cref="NetAlertRaise"/> and <see cref="NetAlertRaiseEx"/> functions use the <see cref="ADMIN_OTHER_INFO"/> structure to specify information when raising an administrator's interrupting message.
    /// </summary>
    /// <remarks>
    /// <para>Variable-length data follows the <see cref="ADMIN_OTHER_INFO"/> structure in the alert message buffer if you specify one or more strings in the <see cref="alrtad_numstrings"/> member. The calling application must allocate and free the memory for all structures and variable-length data in an alert message buffer.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370241.aspx">ADMIN_OTHER_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="ERRLOG_OTHER_INFO"/>
    /// <seealso cref="PRINT_OTHER_INFO"/>
    /// <seealso cref="STD_ALERT"/>
    /// <seealso cref="USER_OTHER_INFO"/>
    /// <seealso cref="NetAlertRaise"/>
    /// <seealso cref="NetAlertRaiseEx"/>
    [StructLayout(LayoutKind.Sequential)]
    public class ADMIN_OTHER_INFO
    {
        /// <summary>
        /// The size, in bytes, that a single instance of the <see cref="ADMIN_OTHER_INFO"/> type occupies in native memory.
        /// </summary>
        public static readonly int SizeOf = Marshal.SizeOf<ADMIN_OTHER_INFO>();

        /// <summary>Specifies the error code for the new message written to the message log.</summary>
        public int alrtad_errcode;
        /// <summary>Specifies the number (0-9) of consecutive Unicode strings written to the message log.</summary>
        public int alrtad_numstrings;
    }
}

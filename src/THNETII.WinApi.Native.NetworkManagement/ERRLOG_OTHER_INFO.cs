using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="ERRLOG_OTHER_INFO"/> structure contains error log information. The <see cref="NetAlertRaise"/> and <see cref="NetAlertRaiseEx"/> functions use the <see cref="ERRLOG_OTHER_INFO"/> structure to specify information when adding a new entry to the error log.
    /// </summary>
    /// <remarks>
    /// The calling application must allocate and free the memory for all structures and variable-length data in an alert message buffer.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370259.aspx">ERRLOG_OTHER_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="ADMIN_OTHER_INFO"/>
    /// <seealso cref="PRINT_OTHER_INFO"/>
    /// <seealso cref="STD_ALERT"/>
    /// <seealso cref="USER_OTHER_INFO"/>
    /// <seealso cref="NetAlertRaise"/>
    /// <seealso cref="NetAlertRaiseEx"/>
    [StructLayout(LayoutKind.Sequential)]
    public class ERRLOG_OTHER_INFO
    {
        /// <summary>
        /// The size, in bytes, that a single instance of the <see cref="ERRLOG_OTHER_INFO"/> type occupies in native memory.
        /// </summary>
        public static readonly int SizeOf = Marshal.SizeOf<ERRLOG_OTHER_INFO>();

        /// <summary>Specifies the error code that was written to the error log.</summary>
        public int alrter_errcode;
        /// <summary>Specifies the offset for the new entry in the error log.</summary>
        public int alrter_offset;
    }
}

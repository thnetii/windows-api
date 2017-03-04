using System.Collections;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManAccessConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1020"/> structure contains the times during which a user can log on to the network. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370994.aspx">USER_INFO_1020 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1020
    {
        /// <summary>
        /// <para>The number of equal-length time units into which the week is divided. This value is required to compute the length of the bit string in the <see cref="usri1020_logon_hours"/> member. </para>
        /// <para>This value must be <see cref="UNITS_PER_WEEK"/> for LAN Manager 2.0. This element is ignored by the <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions.</para>
        /// </summary>
        public int usri1020_units_per_week;
        /// <summary>
        /// <para>A pointer to a 21-byte (168 bits) bit string that specifies the times during which the user can log on. Each bit represents a unique hour in the week, in Greenwich Mean Time (GMT). </para>
        /// <para>The first bit (bit 0, word 0) is Sunday, 0:00 to 0:59; the second bit (bit 1, word 0) is Sunday, 1:00 to 1:59; and so on. Note that bit 0 in word 0 represents Sunday from 0:00 to 0:59 only if you are in the GMT time zone. In all other cases you must adjust the bits according to your time zone offset (for example, GMT minus 8 hours for Pacific Standard Time).</para>
        /// <para>Specify a <c>null</c> pointer in this member when calling the <see cref="NetUserAdd"/> function to indicate no time restriction. Specify a <c>null</c> pointer when calling the <see cref="NetUserSetInfo"/> function to indicate that no change is to be made to the times during which the user can log on.</para>
        /// </summary>
        public ByteArrayAnySafeHandle usri1020_logon_hours;
        /// <summary>
        /// Gets the marshaled bit array containing the logon hours during which the user can log on.
        /// </summary>
        /// <returns>A bit array containing exactly <see cref="usri1020_units_per_week"/> bits, or zero bits if <see cref="usri1020_logon_hours"/> is <c>null</c>.</returns>
        /// <seealso cref="usri1020_logon_hours"/>
        /// <seealso cref="usri1020_units_per_week"/>
        public BitArray GetLogonHoursBitArray() => new BitArray(ByteArraySafeHandle.ReadValue(usri1020_logon_hours, usri1020_units_per_week / 8) ?? new byte[0]);
    }
}

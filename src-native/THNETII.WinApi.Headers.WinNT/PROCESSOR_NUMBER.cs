using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    //
    // Structure to represent a system wide processor number. It contains a
    // group number and relative processor number within the group.
    //

    /// <summary>
    /// Represents a logical processor in a processor group.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-_processor_number">_PROCESSOR_NUMBER structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESSOR_NUMBER
    {
        /// <summary>
        /// The processor group to which the logical processor is assigned.
        /// </summary>
        public short Group;
        /// <summary>
        /// The number of the logical processor relative to the group.
        /// </summary>
        public byte Number;
        /// <summary>
        /// This parameter is reserved.
        /// </summary>
        internal byte Reserved;
    }
}

using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19593
    /// <summary>
    /// Contains information about message strings with identifiers in the range indicated by the <see cref="LowId"/> and <see cref="HighId"/> members.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-message_resource_block">MESSAGE_RESOURCE_BLOCK structure</a></para>
    /// </remarks>
    /// <seealso cref="MESSAGE_RESOURCE_DATA"/>
    /// <seealso cref="MESSAGE_RESOURCE_ENTRY"/>
    /// <seealso href="https://msdn.microsoft.com/en-us/library/ms632583(v=VS.85).aspx">Resources</seealso>
    [StructLayout(LayoutKind.Sequential)]
    public struct MESSAGE_RESOURCE_BLOCK
    {
        /// <summary>
        /// The lowest message identifier contained within this structure.
        /// </summary>
        public int LowId;
        /// <summary>
        /// The highest message identifier contained within this structure.
        /// </summary>
        public int HighId;
        /// <summary>
        /// The offset, in bytes, from the beginning of the <see cref="MESSAGE_RESOURCE_DATA"/> structure to the <see cref="MESSAGE_RESOURCE_ENTRY"/> structures in this <see cref="MESSAGE_RESOURCE_BLOCK"/>. The <see cref="MESSAGE_RESOURCE_ENTRY"/> structures contain the message strings.
        /// </summary>
        public int OffsetToEntries;
    }
}

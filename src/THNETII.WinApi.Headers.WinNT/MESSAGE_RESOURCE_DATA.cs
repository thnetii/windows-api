using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19599
    /// <summary>
    /// Contains information about formatted text for display as an error message or in a message box in a message table resource.
    /// </summary>
    /// <remarks>
    /// <para>A <see cref="MESSAGE_RESOURCE_DATA"/> structure can contain one or more <see cref="MESSAGE_RESOURCE_BLOCK"/> structures, which can each contain one or more <see cref="MESSAGE_RESOURCE_ENTRY"/> structures.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-message_resource_data">MESSAGE_RESOURCE_DATA structure</a></para>
    /// </remarks>
    /// <seealso cref="MESSAGE_RESOURCE_BLOCK"/>
    /// <seealso cref="MESSAGE_RESOURCE_ENTRY"/>
    /// <seealso href="https://msdn.microsoft.com/en-us/library/ms632583(v=VS.85).aspx">Resources</seealso>
    [StructLayout(LayoutKind.Sequential)]
    public struct MESSAGE_RESOURCE_DATA
    {
        /// <summary>
        /// The number of <see cref="MESSAGE_RESOURCE_BLOCK"/> structures.
        /// </summary>
        public int NumberOfBlocks;
        /// <summary>
        /// An span of structures. The span is the size indicated by the <see cref="NumberOfBlocks"/> member.
        /// </summary>
        internal MESSAGE_RESOURCE_BLOCK BlocksField;
        public Span<MESSAGE_RESOURCE_BLOCK> Blocks => SpanOverRef.GetSpan(ref BlocksField, NumberOfBlocks);
    }
}

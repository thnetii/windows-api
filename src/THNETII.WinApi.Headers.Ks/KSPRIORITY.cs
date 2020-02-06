using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Ks
{
    using static KSPRIORITY_CLASS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\ks.h, line 101
    /// <summary>
    /// The <see cref="KSPRIORITY"/> structure is used to specify priority and is used with the <see cref="KSPROPERTY_CONNECTION_PRIORITY"/> property.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="PrioritySubClass"/> member allows a client to set exclusive use of resources consumed by a pin and also to prioritize the use of those resources by the client's pins within that exclusive class. The initial priority of a pin is set by the connection request typically performed through <see cref="KsCreatePin"/>, and is usually <see cref="KSPRIORITY_NORMAL"/>, with a subclass priority of <c>1</c>. A pin uses these priorities as parameters when allocating shared resources from any component managing resources. Resource allocation occurs when formats are set on pins.</para>
    /// <para>If the removal of resources by a higher priority client causes the filter pin to fail, the client must be notified through the <see cref="KSEVENT_CONNECTION_PRIORITY"/> event (assuming that the client had registered for event notification of this type).</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/ks/ns-ks-kspriority">KSPRIORITY structure</a></para>
    /// </remarks>
    /// <seealso cref="KSPROPERTY_CONNECTION_PRIORITY"/>
    /// <seealso cref="KsCreatePin"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct KSPRIORITY
    {
        /// <summary>
        /// Specifies a number ranging from 1 to 0xFFFFFFFF, where 1 is least priority and 0xFFFFFFFF is the highest priority. Zero is reserved for future use. When setting a class value, 0xFFFFFFFF is used to indicate exclusive access to the resources consumed by the pin.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public KSPRIORITY_CLASS PriorityClass;
        /// <summary>
        /// Specifies a number ranging from 1 to 0xFFFFFFFF, where 1 is the least priority within the class and 0xFFFFFFFF is the most priority. Zero is reserved for future use.
        /// </summary>
        public int PrioritySubClass;
    }
}

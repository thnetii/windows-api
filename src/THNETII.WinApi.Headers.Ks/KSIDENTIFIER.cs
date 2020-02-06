using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.NTStatus;

namespace THNETII.WinApi.Native.Ks
{
    using static NTStatusConstants;
    using static KsConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\ks.h, line 106
    /// <summary>
    /// The <see cref="KSIDENTIFIER"/> structure specifies a <see cref="Guid"/> that uniquely identifies a related set of <see cref="Guid"/>s, and an index value to refer to a specific member within that set.
    /// </summary>
    /// <remarks>
    /// <para>The <strong>KSEVENT</strong>, <strong>KSMETHOD</strong>, and <strong>KSPROPERTY</strong> structures are aliases for the <see cref="KSIDENTIFIER"/> structure. As such, their definitions are identical.</para>
    /// <para>The use of an ID within the set allows one to perform a single large compare for a set identifier, then smaller quick compares (for example, by using a switch statement for identifiers within a set). For example, a <em>property set</em> is referred to by a unique GUID identifier, and properties within that set are referred to by the short ID.</para>
    /// <para><em>Method</em>, <em>Event</em>, <em>Interface</em>, and <em>medium sets</em> can be thought of as "classes" of sets.</para>
    /// <para>The size of the output buffer passed determines what data is returned from a <see cref="KSPROPERTY_TYPE_BASICSUPPORT"/> request. If the output buffer is the size of a <see cref="int"/>, only the access flags are returned. If the output buffer is the size of the <see cref="KSPROPERTY_DESCRIPTION"/> structure, the structure is filled with the access flags, the inclusive size of the entire values information, the property value type information, and the number of member lists that correspond to the structure.</para>
    /// <para>For a <see cref="KSPROPERTY_TYPE_RELATIONS"/> request, data returned also depends on the size of the output buffer. If the output buffer size is zero, the size required to return the related properties is returned in <see cref="KSPROPERTY_TYPE_RELATIONS.BytesReturned"/> with a warning status of <see cref="STATUS_BUFFER_OVERFLOW"/>. If the buffer is the size of a <see cref="KSMULTIPLE_ITEM"/> structure, both the byte size and count of relations is returned. Otherwise, the buffer is expected to be long enough to return the <see cref="KSMULTIPLE_ITEM"/> structure and all related property identifiers, which is returned as a list of <see cref="KSIDENTIFIER"/> structures.</para>
    /// <para><see cref="KSPROPERTY_TYPE_SERIALIZESET"/> and <see cref="KSPROPERTY_TYPE_UNSERIALIZESET"/> requests allow interaction with multiple properties with a single call from the client. If the kernel streaming handler is being used to process property requests, these are broken up into multiple calls by the <see cref="KsPropertyHandler"/> function. When using this handler, the property set definition controls which properties are to be serialized.</para>
    /// <para>For serialization requests, the <see cref="KSPROPERTY_ITEM.SerializedSize"/> member of the relevant <see cref="KSPROPERTY_ITEM"/> structure is checked for a nonzero value that indicates the size, in bytes, of the property. If the value of the <see cref="KSPROPERTY_ITEM.SerializedSize"/> member is <c>1</c>, it is unknown and must be queried (all unknown properties begin with a <see cref="KSMULTIPLE_ITEM"/> structure that can be queried separately). To query for the total size a serialization would take, the client passes a zero length buffer in the call to <see cref="DeviceIoControl"/>. <see cref="KSMULTIPLE_ITEM.BytesReturned"/> then returns the size, in bytes, that the buffer must be to serialize the set, and a warning status of <see cref="STATUS_BUFFER_OVERFLOW"/>. A buffer allocated that size can then be filled with the serialized data.</para>
    /// <para>The format of the serialization buffer is a <see cref="KSPROPERTY_SERIALHDR"/>, followed by serialized properties. Each property that follows contains a header (<see cref="KSPROPERTY_SERIAL"/>), followed by the property data, with the start of each property on <see cref="FILE_LONG_ALIGNMENT"/>. Note that the serial header structure is defined to be on <see cref="FILE_LONG_ALIGNMENT"/>.</para>
    /// <para><see cref="KSPROPERTY_TYPE_SERIALIZERAW"/> and <see cref="KSPROPERTY_TYPE_UNSERIALIZERAW"/> are supported if a property item handler exists. The <see cref="KsPropertyHandler"/> function invokes the handler provided by the minidriver. The buffer size required for serialization can also be queried by passing a zero-length buffer to a serialize raw request. Because handlers are attached to property items rather than the property set, a specific item within the property set must be specified in the <em>Property</em> parameter. This handler may deal with multiple properties within the set.</para>
    /// <para>Microsoft provides several system-defined property set GUIDs. Minidrivers specify one of these GUIDs in the <see cref="Set"/> member. Kernel streaming property sets typically begin with either a <strong>KSPROPSETID</strong> or a <strong>PROPSETID</strong> prefix. Kernel streaming property sets are defined in <em>ks.h</em>, <em>ksmedia.h</em>, <em>bdamedia.h</em>, and possibly other header files.</para>
    /// <para>For more information about kernel streaming properties, see <a href="https://docs.microsoft.com/windows-hardware/drivers/stream/ks-properties--events--and-methods">KS Properties, Events, and Methods</a>.</para>
    /// <para>A client can use the <see cref="IOCTL_KS_METHOD"/> request along with the <see cref="KSIDENTIFIER"/> structure to execute methods on a kernel streaming object that the minidriver handles. For more information, see <a href="https://docs.microsoft.com/windows-hardware/drivers/stream/ks-methods">KS Methods</a>.</para>
    /// <para>The <see cref="KSPIN_MEDIUM"/> structure identifies a medium, with a unique medium GUID and instance identifier, which is generated in a bus-specific manner. There is a reserved identifier value <see cref="KSMEDIUM_TYPE_ANYINSTANCE"/> that is used when bus instances are not of concern. For example, the <see cref="KSMEDIUMSETID_Standard"/> refers to the system bus, of which there should only be one. So this instance identifier is always used just as a convenience.</para>
    /// <para>A pin may support multiple mediums and interfaces on those mediums. The way in which a pin is described implies that the list of interfaces is supported on all mediums enumerated for a pin. If there is a case in which this is not true, another pin may be used to describe each subset of interfaces for the specific mediums.</para>
    /// <para>The medium is also cached by kernel streaming to speed up the search for a possible connection.</para>
    /// <para>An example of use of this structure can be found in a tuner sample, in which <see cref="KSPIN_MEDIUM"/> represents unique connections between tuners, crossbars, and other tuner components.</para>
    /// <para>The <see cref="Flags"/> member can contain different values based on the type of signal degradation that the client employs. See <a href="https://docs.microsoft.com/windows-hardware/drivers/stream/quality-management">Quality Management</a> for more details on different strategies for solving QM problems by reducing signal quality.</para>
    /// <para>Because <see cref="Flags"/> contains in integer value, multiple Skip requests may be needed to remedy the QM issue.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/ks/ns-ks-ksidentifier">KSIDENTIFIER structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit)]
    public struct KSIDENTIFIER
    {
        [FieldOffset(0)]
        internal KSIDENTIFIER_CONTENT Content;

        public Guid Set
        {
            get => Content.Set;
            set => Content.Set = value;
        }

        public int Id
        {
            get => Content.Id;
            set => Content.Id = value;
        }

        public int Flags
        {
            get => Content.Flags;
            set => Content.Flags = value;
        }

        [FieldOffset(0)]
        public long Alignment;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct KSIDENTIFIER_CONTENT
    {
        public Guid Set;
        public int Id;
        public int Flags;
    }
}

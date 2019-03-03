using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;
using THNETII.InteropServices.Runtime;
using static THNETII.WinApi.Native.WinNT.WinNTConstants;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9071
    /// <summary>
    /// The <see cref="SID_AND_ATTRIBUTES_HASH"/> structure specifies a hash values for the specified array of <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifiers</a> (SIDs).
    /// </summary>
    /// <remarks>
    /// <para>
    /// A group is represented by a SID. SIDs have attributes that indicate whether they are currently
    /// enabled, disabled, or mandatory. SIDs also indicate how these attributes are used. A
    /// <see cref="SID_AND_ATTRIBUTES"/> structure can represent a SID whose attributes change frequently. For
    /// example, <see cref="SID_AND_ATTRIBUTES"/> is used to represent groups in the <see cref="TOKEN_GROUPS"/>
    /// structure.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-_sid_and_attributes_hash">SID_AND_ATTRIBUTES_HASH structure</a></para>
    /// </remarks>
    /// <seealso cref="TOKEN_ACCESS_INFORMATION"/>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SID_AND_ATTRIBUTES_HASH
    {
        /// <summary>
        /// The number of SIDs pointed to by the <see cref="SidAttr"/> parameter.
        /// </summary>
        public int SidCount;
        #region public PSID_AND_ATTRIBUTES SidAttr;
        internal IntPtr SidAttrPtr;
        /// <summary>
        /// A span of <see cref="SID_AND_ATTRIBUTES"/> structures that represent SIDs and their attributes.
        /// </summary>
        public Span<SID_AND_ATTRIBUTES> SidAttr => SidAttrPtr.AsRefStructSpan<SID_AND_ATTRIBUTES>(SidCount);
        #endregion
        #region public UIntPtr Hash[SID_HASH_SIZE];
        internal HASH HashField;
        internal struct HASH
        {
            public const int Length = SID_HASH_SIZE;
            public ref UIntPtr this[int index] => ref Span[index];
            public Span<UIntPtr> Span => MemoryMarshal.Cast<HASH, UIntPtr>(SpanOverRef.GetSpan(ref this));
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
            internal UIntPtr Hash0;
            internal UIntPtr Hash1;
            internal UIntPtr Hash2;
            internal UIntPtr Hash3;
            internal UIntPtr Hash4;
            internal UIntPtr Hash5;
            internal UIntPtr Hash6;
            internal UIntPtr Hash7;
            internal UIntPtr Hash8;
            internal UIntPtr Hash9;
            internal UIntPtr Hash10;
            internal UIntPtr Hash11;
            internal UIntPtr Hash12;
            internal UIntPtr Hash13;
            internal UIntPtr Hash14;
            internal UIntPtr Hash15;
            internal UIntPtr Hash16;
            internal UIntPtr Hash17;
            internal UIntPtr Hash18;
            internal UIntPtr Hash19;
            internal UIntPtr Hash20;
            internal UIntPtr Hash21;
            internal UIntPtr Hash22;
            internal UIntPtr Hash23;
            internal UIntPtr Hash24;
            internal UIntPtr Hash25;
            internal UIntPtr Hash26;
            internal UIntPtr Hash27;
            internal UIntPtr Hash28;
            internal UIntPtr Hash29;
            internal UIntPtr Hash30;
            internal UIntPtr Hash31;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
        }
        /// <summary>
        /// A span of hash values. These values correspond to the <see cref="SID_AND_ATTRIBUTES"/> structures pointed to by the <see cref="SidAttr"/> parameter.
        /// </summary>
        public Span<UIntPtr> Hash => HashField.Span;
        #endregion
    }
}

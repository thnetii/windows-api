using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 7630
    /// <summary>
    /// Describes an entry in the descriptor table. This structure is valid only on x86-based systems.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="GetThreadSelectorEntry"/> function fills this structure with information from an entry in the descriptor table. You can use this information to convert a segment-relative address to a linear virtual address.</para>
    /// <para>The base address of a segment is the address of offset 0 in the segment.</para>
    /// <para>The limit of a segment is the address of the last byte that can be addressed in the segment.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-_ldt_entry">LDT_ENTRY structure</a></para>
    /// </remarks>
    /// <seealso href="https://msdn.microsoft.com/bf1294cd-1836-49d3-9cc4-4532429a301f">Debugging Structures</seealso>
    /// <seealso cref="GetThreadSelectorEntry"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct LDT_ENTRY
    {
        private static readonly Bitfield32 bits_low = Bitfield32.LowBits(count: 16);
        private static readonly Bitfield32 bits_mid = Bitfield32.SelectBits(offset: 16, count: 8);
        private static readonly Bitfield32 bits_hi = Bitfield32.RemainingBits(offset: 24);

        private static readonly Bitfield32 bits_limHi = Bitfield32.SelectBits(offset: 16, count: 4);

        /// <summary>
        /// The low-order part of the address of the last byte in the segment.
        /// </summary>
        public ushort LimitLow;
        /// <summary>
        /// The low-order part of the base address of the segment.
        /// </summary>
        public ushort BaseLow;
        /// <summary>
        /// The high-order portion of the descriptor. This member may be interpreted as bytes or collections of bits, depending on the level of detail required.
        /// </summary>
        public LDT_ENTRY_HIGHWORD HighWord;

        /// <summary>
        /// The middle bits (16-23) of the base address of the segment.
        /// </summary>
        public byte BaseMid
        {
            get => HighWord.BaseMid;
            set => HighWord.BaseMid = value;
        }

        /// <summary>
        /// The high bits (24-31) of the base address of the segment.
        /// </summary>
        public byte BaseHi
        {
            get => HighWord.BaseHi;
            set => HighWord.BaseHi = value;
        }

        /// <summary>
        /// The high-order part of the address of the last byte in the segment.
        /// </summary>
        public ushort LimitHi
        {
            get => HighWord.LimitHi;
            set => HighWord.LimitHi = (byte)value;
        }

        /// <summary>
        /// The entire 32-bit base address of the segment.
        /// </summary>
        public uint BaseAddress
        {
            get
            {
                uint addr = 0U;
                bits_low.Write(ref addr, BaseLow);
                bits_mid.Write(ref addr, BaseMid);
                bits_hi.Write(ref addr, BaseHi);
                return addr;
            }
            set
            {
                BaseLow = (ushort)bits_low.Read(value);
                BaseMid = (byte)bits_mid.Read(value);
                BaseHi = (byte)bits_hi.Read(value);
            }
        }

        /// <summary>
        /// The entire 24-bit address of the last byte in the segment.
        /// </summary>
        public uint LimitAddress
        {
            get
            {
                uint addr = 0U;
                bits_low.Write(ref addr, LimitLow);
                bits_limHi.Write(ref addr, LimitHi);
                return addr;
            }
            set
            {
                LimitLow = (ushort)bits_low.Read(value);
                LimitHi = (ushort)bits_limHi.Read(value);
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LDT_ENTRY_HIGHWORD
    {
        private static readonly Bitfield32 bits_BaseMid = Bitfield32.LowBits(count: 8);
        private static readonly Bitfield32 bits_Type = Bitfield32.SelectBits(offset: 8, count: 5);
        private static readonly Bitfield32 bits_Dpl = Bitfield32.SelectBits(offset: 13, count: 2);
        private static readonly Bitfield32 bits_Pres = Bitfield32.SelectBits(offset: 15, count: 1);
        private static readonly Bitfield32 bits_limitHi = Bitfield32.SelectBits(offset: 16, count: 4);
        private static readonly Bitfield32 bits_Sys = Bitfield32.SelectBits(offset: 20, count: 1);
        private static readonly Bitfield32 bits_Reserved0 = Bitfield32.SelectBits(offset: 21, count: 1);
        private static readonly Bitfield32 bits_DefaultBig = Bitfield32.SelectBits(offset: 22, count: 1);
        private static readonly Bitfield32 bits_Granularity = Bitfield32.SelectBits(offset: 23, count: 1);
        private static readonly Bitfield32 bits_BaseHi = Bitfield32.RemainingBits(offset: 24);
        private static readonly Bitfield32 bits_Flags1 = Bitfield32.SelectBits(offset: 8, count: 8);
        private static readonly Bitfield32 bits_Flags2 = Bitfield32.SelectBits(offset: 16, count: 8);

        private uint value;

        /// <summary>
        /// Middle bits (16-23) of the base address of the segment.
        /// </summary>
        public byte BaseMid
        {
            get => (byte)bits_BaseMid.Read(value);
            set => bits_BaseMid.Write(ref this.value, value);
        }

        /// <summary>
        /// Values of the <see cref="Type"/>, <see cref="Dpl"/>, and <see cref="Pres"/> members.
        /// </summary>
        public byte Flags1
        {
            get => (byte)bits_Flags1.Read(value);
            set => bits_Flags1.Write(ref this.value, value);
        }

        /// <summary>
        /// Values of the <see cref="LimitHi"/>, <see cref="Sys"/>, <see cref="Default_Big"/>, and <see cref="Granularity"/> members
        /// </summary>
        public byte Flags2
        {
            get => (byte)bits_Flags2.Read(value);
            set => bits_Flags2.Write(ref this.value, value);
        }

        /// <summary>
        /// High bits (24-31) of the base address of the segment.
        /// </summary>
        public byte BaseHi
        {
            get => (byte)bits_BaseHi.Read(value);
            set => bits_BaseHi.Write(ref this.value, value);
        }

        /// <summary>
        /// The type of segment.
        /// </summary>
        public int Type
        {
            get => (int)bits_Type.Read(value);
            set => bits_Type.Write(ref this.value, (uint)value);
        }

        /// <summary>
        /// The privilege level of the descriptor.
        /// </summary>
        /// <value>An integer value in the range 0 (most privileged) through 3 (least privileged).</value>
        public int Dpl
        {
            get => (int)bits_Dpl.Read(value);
            set => bits_Dpl.Write(ref this.value, (uint)value);
        }

        /// <summary>
        /// The present flag.
        /// </summary>
        /// <value><see langword="true"/> if the segment is present in physical memory; otherwise, <see langword="false"/>.</value>
        public bool Pres
        {
            get => bits_Pres.ReadBool(value);
            set => bits_Pres.WriteBool(ref this.value, value);
        }

        /// <summary>
        /// The high bits (16-19) of the address of the last byte in the segment.
        /// </summary>
        public byte LimitHi
        {
            get => (byte)bits_limitHi.Read(value);
            set => bits_limitHi.Write(ref this.value, value);
        }

        /// <summary>
        /// The space that is available to system programmers. This member might be used for marking segments in some system-specific way.
        /// </summary>
        public bool Sys
        {
            get => bits_Sys.ReadBool(value);
            set => bits_Sys.WriteBool(ref this.value, value);
        }

        internal int Reserved_0
        {
            get => (int)bits_Reserved0.Read(value);
            set => bits_Reserved0.Write(ref this.value, (uint)value);
        }

        /// <summary>
        /// The size of segment.
        /// </summary>
        /// <value>
        /// <para>If the segment is a data segment: <see langword="true"/> if the segment is larger than 64 kilobytes; <see langword="false"/> if the segment is smaller than or equal to 64K.</para>
        /// <para>If the segment is a code segment: <see langword="true"/> if the code runs with the default (native) instruction set; <see langword="false"/> if the code segment is an 80286 code segment and runs with 16-bit offsets and the 80286-compatible instruction set.</para>
        /// </value>
        public bool DefaultBig
        {
            get => bits_DefaultBig.ReadBool(value);
            set => bits_DefaultBig.WriteBool(ref this.value, value);
        }

        /// <summary>
        /// The granularity.
        /// </summary>
        /// <value><c>0</c> (zero) if the segment is byte granular. <c>1</c> if the segment is page granular.</value>
        public int Granularity
        {
            get => (int)bits_Granularity.Read(value);
            set => bits_Granularity.Write(ref this.value, (uint)value);
        }
    }
}

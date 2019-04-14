using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;
    using static MEM_EXTENDED_PARAMETER_TYPE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12731
    /// <summary>
    /// Represents an extended parameter for a function that manages virtual memory.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-mem_extended_parameter">MEM_EXTENDED_PARAMETER structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct MEM_EXTENDED_PARAMETER
    {
        private static readonly Bitfield64 TypeBitfield = Bitfield64.DefineLowerBits(MEM_EXTENDED_PARAMETER_TYPE_BITS);
        private ulong TypeField;
        /// <summary>
        /// <para>A <see cref="MEM_EXTENDED_PARAMETER_TYPE"/> value that indicates the type of the parameter.</para>
        /// <para>If <see cref="Type"/> is set to <see cref="MemExtendedParameterAddressRequirements"/>, then <see cref="Pointer"/> must be a pointer to a caller-allocated <see cref="MEM_ADDRESS_REQUIREMENTS"/> structure that specifies the lowest and highest base address and alignment.</para>
        /// <para>If Type is set to <see cref="MemExtendedParameterNumaNode"/>, then <see cref="ULong"/> must be set to the desired node number.</para>
        /// </summary>
        public MEM_EXTENDED_PARAMETER_TYPE Type
        {
            get => (MEM_EXTENDED_PARAMETER_TYPE)TypeBitfield.Read(TypeField);
            set => TypeBitfield.Write(ref TypeField, (ulong)value);
        }
        private static readonly Bitfield64 ReservedBitfield = Bitfield64.DefineFromMask(TypeBitfield.InverseMask);
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ulong Reserved
        {
            get => ReservedBitfield.Read(TypeField);
            set => ReservedBitfield.Write(ref TypeField, value);
        }
        [StructLayout(LayoutKind.Explicit)]
        private struct DUMMYUNIONNAME
        {
            [FieldOffset(0)]
            public ulong ULong64;
            [FieldOffset(0)]
            public IntPtr Pointer;
            [FieldOffset(0)]
            public UIntPtr Size;
            [FieldOffset(0)]
            public IntPtr Handle;
            [FieldOffset(0)]
            public uint ULong;
        }
        private DUMMYUNIONNAME u;
        public ulong ULong64
        {
            get => u.ULong64;
            set => u.ULong64 = value;
        }
        /// <summary>
        /// If <see cref="Type"/> is set to <see cref="MemExtendedParameterAddressRequirements"/>, then <see cref="Pointer"/> must be a pointer to a caller-allocated <see cref="MEM_ADDRESS_REQUIREMENTS"/> structure that specifies the lowest and highest base address and alignment.
        /// </summary>
        public IntPtr Pointer
        {
            get => u.Pointer;
            set => u.Pointer = value;
        }
        public ulong Size
        {
            get => u.Size.ToUInt64();
            set => u.Size = (UIntPtr)value;
        }
        public IntPtr Handle
        {
            get => u.Handle;
            set => u.Handle = value;
        }
        /// <summary>
        /// If <see cref="Type"/> is set to <see cref="MemExtendedParameterNumaNode"/>, then <see cref="ULong"/> must be set to the desired node number.
        /// </summary>
        public uint ULong
        {
            get => u.ULong;
            set => u.ULong = value;
        }
    }
}

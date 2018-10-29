using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 869
    /// <summary>
    /// <para>An <see cref="LUID"/> is a 64-bit value guaranteed to be unique only on the system on which it was generated. The uniqueness of a <a href="https://msdn.microsoft.com/65dd9a04-fc7c-4179-95ff-dac7dad4668f">locally unique identifier</a> (LUID) is guaranteed only until the system is restarted.</para>
    /// <para>Applications must use functions and structures to manipulate <see cref="LUID"/> values.</para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-_luid">LUID structure</a></para>
    /// </remarks>
    /// <seealso cref="AllocateLocallyUniqueId"/>
    /// <seealso cref="LUID_AND_ATTRIBUTES"/>
    /// <seealso cref="LookupPrivilegeName"/>
    /// <seealso cref="LookupPrivilegeValue"/>
    /// <seealso cref="PRIVILEGE_SET"/>
    /// <seealso cref="PrivilegeCheck"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct LUID : IEquatable<LUID>, IEquatable<long>
    {
        private static readonly Bitfield64 LowBits = Bitfield64.DefineFromMask(uint.MaxValue);
        private static readonly Bitfield64 HighBits = Bitfield64.DefineFromMask(uint.MaxValue, sizeof(uint) * 8);

        /// <summary>Low-order bits.</summary>
        internal uint LowPart;
        /// <summary>High-order bits.</summary>
        internal int HighPart;

        public long Value => AsInt64();

        public LUID(long value)
        {
            LowPart = (uint)LowBits.Read(value);
            HighPart = (int)HighBits.Read(value);
        }

        public long AsInt64()
        {
            long v = default;
            LowBits.Write(ref v, LowPart);
            HighBits.Write(ref v, HighPart);
            return v;
        }

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates")]
        public static implicit operator LUID(long value) => new LUID(value);

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(AsInt64))]
        public static explicit operator long(LUID luid) => luid.Value;

        public bool Equals(LUID luid) => Value == luid.Value;

        public bool Equals(long value) => Value == value;

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case LUID luid: return Equals(luid);
                case long value: return Equals(value);
                default: return false;
            }
        }

        public override int GetHashCode() => Value.GetHashCode();

        public static bool operator ==(LUID a, LUID b) => a.Equals(b);
        public static bool operator !=(LUID a, LUID b) => !a.Equals(b);

        public static bool operator ==(LUID luid, long value) => luid.Equals(value);
        public static bool operator !=(LUID luid, long value) => !luid.Equals(value);

        public static bool operator ==(long value, LUID luid) => luid.Equals(value);
        public static bool operator !=(long value, LUID luid) => !luid.Equals(value);
    }
}

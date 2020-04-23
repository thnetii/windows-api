using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    using static WinNlsConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1042
    /// <summary>
    /// Language Group ID
    /// </summary>
    [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
    [StructLayout(LayoutKind.Sequential)]
    public struct LGRPID : IEquatable<LGRPID>, IEquatable<int>
    {
        public LGRPID(int value) : this() => Value = value;

        public int Value { get; }

        public override bool Equals(object obj) => obj switch
        {
            int value => Equals(value),
            LGRPID other => Equals(other),
            null => false,
            _ => false
        };

        public bool Equals(LGRPID other) => Value.Equals(other.Value);

        public bool Equals(int other) => Value.Equals(other);

        public override int GetHashCode() => Value.GetHashCode();

        public static bool operator ==(LGRPID left, LGRPID right) =>
            left.Equals(right);

        public static bool operator !=(LGRPID left, LGRPID right) =>
            !(left == right);

        public static bool operator ==(LGRPID left, int right) =>
            left.Equals(right);

        public static bool operator !=(LGRPID left, int right) =>
            !(left == right);

        public static bool operator ==(int left, LGRPID right) =>
            left.Equals(right.Value);

        public static bool operator !=(int left, LGRPID right) =>
            !(left == right);

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(LGRPID))]
        public static explicit operator LGRPID(int value) =>
            new LGRPID(value);


        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(Value))]
        public static implicit operator int(LGRPID lgrpid) => lgrpid.Value;
    }
}

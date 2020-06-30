using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16065
    /// <summary>
    /// Processor Perf State Policy.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESSOR_PERFSTATE_POLICY
    {
        public int Revision;
        public byte MaxThrottle;
        public byte MinThrottle;
        public byte BusyAdjThreshold;
        #region public byte Flags;
        private static readonly Bitfield8 NoDomainAccountingBitfield = Bitfield8.Bit(0);
        private static readonly Bitfield8 IncreasePolicyBitfield = Bitfield8.SelectBits(1, 2);
        private static readonly Bitfield8 DecreasePolicyBitfield = Bitfield8.SelectBits(3, 2);
        private static readonly Bitfield8 ReservedBitfield = Bitfield8.RemainingBits(5);
        public bool NoDomainAccounting
        {
            get => NoDomainAccountingBitfield.ReadBool(Flags);
            set => NoDomainAccountingBitfield.WriteBool(ref Flags, value);
        }
        public byte IncreasePolicy
        {
            get => IncreasePolicyBitfield.Read(Flags);
            set => IncreasePolicyBitfield.Write(ref Flags, value);
        }
        public byte DecreasePolicy
        {
            get => DecreasePolicyBitfield.Read(Flags);
            set => DecreasePolicyBitfield.Write(ref Flags, value);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public byte Reserved
        {
            get => ReservedBitfield.Read(Flags);
            set => ReservedBitfield.Write(ref Flags, value);
        }
        public byte Flags;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public byte Spare
        {
            get => Flags;
            set => Flags = value;
        }
        #endregion

        public int TimeCheck;
        public int IncreaseTime;
        public int DecreaseTime;
        public int IncreasePercent;
        public int DecreasePercent;
    }
}

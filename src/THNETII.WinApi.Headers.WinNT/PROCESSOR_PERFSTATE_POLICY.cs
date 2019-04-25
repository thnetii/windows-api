using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;

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
        private static readonly Bitfield32 NoDomainAccountingBitfield = Bitfield32.DefineFromMask(1 << 0);
        private static readonly Bitfield32 IncreasePolicyBitfield = Bitfield32.DefineMiddleBits(1, 2);
        private static readonly Bitfield32 DecreasePolicyBitfield = Bitfield32.DefineMiddleBits(3, 2);
        private static readonly Bitfield32 ReservedBitfield = Bitfield32.DefineRemainingBits(5);
        public bool NoDomainAccounting
        {
            get => NoDomainAccountingBitfield.Read((uint)Flags) != 0;
            set
            {
                uint tmp = Flags;
                Flags = (byte)NoDomainAccountingBitfield.Write(ref tmp, value ? ~0U : 0U);
            }
        }
        public byte IncreasePolicy
        {
            get => (byte)IncreasePolicyBitfield.Read((uint)Flags);
            set
            {
                uint tmp = Flags;
                Flags = (byte)IncreasePolicyBitfield.Write(ref tmp, value);
            }
        }
        public byte DecreasePolicy
        {
            get => (byte)DecreasePolicyBitfield.Read((uint)Flags);
            set
            {
                uint tmp = Flags;
                Flags = (byte)DecreasePolicyBitfield.Write(ref tmp, value);
            }
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public byte Reserved
        {
            get => (byte)ReservedBitfield.Read((uint)Flags);
            set
            {
                uint tmp = Flags;
                Flags = (byte)ReservedBitfield.Write(ref tmp, value);
            }
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

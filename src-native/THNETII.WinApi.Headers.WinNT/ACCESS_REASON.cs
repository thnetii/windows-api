using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

using static THNETII.WinApi.Native.WinNT.WinNTConstants;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10420
    [StructLayout(LayoutKind.Sequential)]
    public struct ACCESS_REASON
    {
        private static readonly Bitfield32 TypeBitfield = Bitfield32.FromMask(ACCESS_REASON_TYPE_MASK);
        private static readonly Bitfield32 DataBitfield = Bitfield32.FromMask(ACCESS_REASON_DATA_MASK);
        private static readonly Bitfield32 StagingBitfield = Bitfield32.FromMask(ACCESS_REASON_STAGING_MASK);
        private static readonly Bitfield32 ExDataBitfield = Bitfield32.FromMask(ACCESS_REASON_EXDATA_MASK);

        internal int field;

        public ACCESS_REASON(int value) => field = value;

        public ACCESS_REASON_TYPE Type
        {
            get => (ACCESS_REASON_TYPE)TypeBitfield.ReadMasked(field);
            set => TypeBitfield.WriteMasked(ref field, (int)value);
        }

        public int Data
        {
            get => (short)DataBitfield.ReadMasked(field);
            set => DataBitfield.WriteMasked(ref field, value);
        }

        public bool Staging
        {
            get => StagingBitfield.ReadBool(field);
            set => StagingBitfield.WriteBool(ref field, value);
        }

        public int ExtendedData
        {
            get => ExDataBitfield.ReadMasked(field);
            set => ExDataBitfield.WriteMasked(ref field, value);
        }
    }
}

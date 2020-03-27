using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11659
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_PAYLOAD_RESTRICTION_POLICY
    {
        private static readonly Bitfield32 bfEnableExportAddressFilter = Bitfield32.LowBits(1);
        private static readonly Bitfield32 bfAuditExportAddressFilter = Bitfield32.SelectBits(1, 1);

        private static readonly Bitfield32 bfEnableExportAddressFilterPlus = Bitfield32.SelectBits(2, 1);
        private static readonly Bitfield32 bfAuditExportAddressFilterPlus = Bitfield32.SelectBits(3, 1);

        private static readonly Bitfield32 bfEnableImportAddressFilter = Bitfield32.SelectBits(4, 1);
        private static readonly Bitfield32 bfAuditImportAddressFilter = Bitfield32.SelectBits(5, 1);

        private static readonly Bitfield32 bfEnableRopStackPivot = Bitfield32.SelectBits(6, 1);
        private static readonly Bitfield32 bfAuditRopStackPivot = Bitfield32.SelectBits(7, 1);

        private static readonly Bitfield32 bfEnableRopCallerCheck = Bitfield32.SelectBits(8, 1);
        private static readonly Bitfield32 bfAuditRopCallerCheck = Bitfield32.SelectBits(9, 1);

        private static readonly Bitfield32 bfEnableRopSimExec = Bitfield32.SelectBits(10, 1);
        private static readonly Bitfield32 bfAuditRopSimExec = Bitfield32.SelectBits(11, 1);

        private static readonly Bitfield32 bfReservedFlags = Bitfield32.FromMask(Bitmask.HigherBitsUInt32(20));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        public bool EnableExportAddressFilter
        {
            get => bfEnableExportAddressFilter.ReadBool(dwFlags);
            set => bfEnableExportAddressFilter.WriteBool(ref dwFlags, value);
        }

        public bool AuditExportAddressFilter
        {
            get => bfAuditExportAddressFilter.ReadBool(dwFlags);
            set => bfAuditExportAddressFilter.WriteBool(ref dwFlags, value);
        }

        public bool EnableExportAddressFilterPlus
        {
            get => bfEnableExportAddressFilterPlus.ReadBool(dwFlags);
            set => bfEnableExportAddressFilterPlus.WriteBool(ref dwFlags, value);
        }

        public bool AuditExportAddressFilterPlus
        {
            get => bfAuditExportAddressFilterPlus.ReadBool(dwFlags);
            set => bfAuditExportAddressFilterPlus.WriteBool(ref dwFlags, value);
        }

        public bool EnableImportAddressFilter
        {
            get => bfEnableImportAddressFilter.ReadBool(dwFlags);
            set => bfEnableImportAddressFilter.WriteBool(ref dwFlags, value);
        }

        public bool AuditImportAddressFilter
        {
            get => bfAuditImportAddressFilter.ReadBool(dwFlags);
            set => bfAuditImportAddressFilter.WriteBool(ref dwFlags, value);
        }

        public bool EnableRopStackPivot
        {
            get => bfEnableRopStackPivot.ReadBool(dwFlags);
            set => bfEnableRopStackPivot.WriteBool(ref dwFlags, value);
        }

        public bool AuditRopStackPivot
        {
            get => bfAuditRopStackPivot.ReadBool(dwFlags);
            set => bfAuditRopStackPivot.WriteBool(ref dwFlags, value);
        }

        public bool EnableRopCallerCheck
        {
            get => bfEnableRopCallerCheck.ReadBool(dwFlags);
            set => bfEnableRopCallerCheck.WriteBool(ref dwFlags, value);
        }

        public bool AuditRopCallerCheck
        {
            get => bfAuditRopCallerCheck.ReadBool(dwFlags);
            set => bfAuditRopCallerCheck.WriteBool(ref dwFlags, value);
        }

        public bool EnableRopSimExec
        {
            get => bfEnableRopSimExec.ReadBool(dwFlags);
            set => bfEnableRopSimExec.WriteBool(ref dwFlags, value);
        }

        public bool AuditRopSimExec
        {
            get => bfAuditRopSimExec.ReadBool(dwFlags);
            set => bfAuditRopSimExec.WriteBool(ref dwFlags, value);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.ReadMasked(dwFlags);
            set => bfReservedFlags.WriteMasked(ref dwFlags, (uint)value);
        }
    }
}

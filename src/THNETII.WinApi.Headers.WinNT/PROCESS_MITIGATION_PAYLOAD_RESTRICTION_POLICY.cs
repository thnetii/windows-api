using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;

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
            get => bfEnableExportAddressFilter.ReadMasked(dwFlags) != 0;
            set => bfEnableExportAddressFilter.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool AuditExportAddressFilter
        {
            get => bfAuditExportAddressFilter.ReadMasked(dwFlags) != 0;
            set => bfAuditExportAddressFilter.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool EnableExportAddressFilterPlus
        {
            get => bfEnableExportAddressFilterPlus.ReadMasked(dwFlags) != 0;
            set => bfEnableExportAddressFilterPlus.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool AuditExportAddressFilterPlus
        {
            get => bfAuditExportAddressFilterPlus.ReadMasked(dwFlags) != 0;
            set => bfAuditExportAddressFilterPlus.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool EnableImportAddressFilter
        {
            get => bfEnableImportAddressFilter.ReadMasked(dwFlags) != 0;
            set => bfEnableImportAddressFilter.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool AuditImportAddressFilter
        {
            get => bfAuditImportAddressFilter.ReadMasked(dwFlags) != 0;
            set => bfAuditImportAddressFilter.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool EnableRopStackPivot
        {
            get => bfEnableRopStackPivot.ReadMasked(dwFlags) != 0;
            set => bfEnableRopStackPivot.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool AuditRopStackPivot
        {
            get => bfAuditRopStackPivot.ReadMasked(dwFlags) != 0;
            set => bfAuditRopStackPivot.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool EnableRopCallerCheck
        {
            get => bfEnableRopCallerCheck.ReadMasked(dwFlags) != 0;
            set => bfEnableRopCallerCheck.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool AuditRopCallerCheck
        {
            get => bfAuditRopCallerCheck.ReadMasked(dwFlags) != 0;
            set => bfAuditRopCallerCheck.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool EnableRopSimExec
        {
            get => bfEnableRopSimExec.ReadMasked(dwFlags) != 0;
            set => bfEnableRopSimExec.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool AuditRopSimExec
        {
            get => bfAuditRopSimExec.ReadMasked(dwFlags) != 0;
            set => bfAuditRopSimExec.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.ReadMasked(dwFlags);
            set => bfReservedFlags.WriteMasked(ref dwFlags, (uint)value);
        }
    }
}

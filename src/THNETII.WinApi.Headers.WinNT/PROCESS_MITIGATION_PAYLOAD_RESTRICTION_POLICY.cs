using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11659
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_PAYLOAD_RESTRICTION_POLICY
    {
        private static readonly Bitfield32 bfEnableExportAddressFilter = Bitfield32.DefineLowerBits(1);
        private static readonly Bitfield32 bfAuditExportAddressFilter = Bitfield32.DefineMiddleBits(1, 1);

        private static readonly Bitfield32 bfEnableExportAddressFilterPlus = Bitfield32.DefineMiddleBits(2, 1);
        private static readonly Bitfield32 bfAuditExportAddressFilterPlus = Bitfield32.DefineMiddleBits(3, 1);

        private static readonly Bitfield32 bfEnableImportAddressFilter = Bitfield32.DefineMiddleBits(4, 1);
        private static readonly Bitfield32 bfAuditImportAddressFilter = Bitfield32.DefineMiddleBits(5, 1);

        private static readonly Bitfield32 bfEnableRopStackPivot = Bitfield32.DefineMiddleBits(6, 1);
        private static readonly Bitfield32 bfAuditRopStackPivot = Bitfield32.DefineMiddleBits(7, 1);

        private static readonly Bitfield32 bfEnableRopCallerCheck = Bitfield32.DefineMiddleBits(8, 1);
        private static readonly Bitfield32 bfAuditRopCallerCheck = Bitfield32.DefineMiddleBits(9, 1);

        private static readonly Bitfield32 bfEnableRopSimExec = Bitfield32.DefineMiddleBits(10, 1);
        private static readonly Bitfield32 bfAuditRopSimExec = Bitfield32.DefineMiddleBits(11, 1);

        private static readonly Bitfield32 bfReservedFlags = Bitfield32.DefineFromMask(Bitmask.HigherBitsUInt32(20));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        public bool EnableExportAddressFilter
        {
            get => bfEnableExportAddressFilter.Read(dwFlags) != 0;
            set => bfEnableExportAddressFilter.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditExportAddressFilter
        {
            get => bfAuditExportAddressFilter.Read(dwFlags) != 0;
            set => bfAuditExportAddressFilter.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool EnableExportAddressFilterPlus
        {
            get => bfEnableExportAddressFilterPlus.Read(dwFlags) != 0;
            set => bfEnableExportAddressFilterPlus.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditExportAddressFilterPlus
        {
            get => bfAuditExportAddressFilterPlus.Read(dwFlags) != 0;
            set => bfAuditExportAddressFilterPlus.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool EnableImportAddressFilter
        {
            get => bfEnableImportAddressFilter.Read(dwFlags) != 0;
            set => bfEnableImportAddressFilter.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditImportAddressFilter
        {
            get => bfAuditImportAddressFilter.Read(dwFlags) != 0;
            set => bfAuditImportAddressFilter.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool EnableRopStackPivot
        {
            get => bfEnableRopStackPivot.Read(dwFlags) != 0;
            set => bfEnableRopStackPivot.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditRopStackPivot
        {
            get => bfAuditRopStackPivot.Read(dwFlags) != 0;
            set => bfAuditRopStackPivot.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool EnableRopCallerCheck
        {
            get => bfEnableRopCallerCheck.Read(dwFlags) != 0;
            set => bfEnableRopCallerCheck.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditRopCallerCheck
        {
            get => bfAuditRopCallerCheck.Read(dwFlags) != 0;
            set => bfAuditRopCallerCheck.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool EnableRopSimExec
        {
            get => bfEnableRopSimExec.Read(dwFlags) != 0;
            set => bfEnableRopSimExec.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditRopSimExec
        {
            get => bfAuditRopSimExec.Read(dwFlags) != 0;
            set => bfAuditRopSimExec.Write(ref dwFlags, value ? 1U : 0U);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.Read(dwFlags);
            set => bfReservedFlags.Write(ref dwFlags, (uint)value);
        }
    }
}

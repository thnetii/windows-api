using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11598
    /// <summary>
    /// Contains process mitigation policy settings for Control Flow Guard (CFG). The
    /// <see cref="GetProcessMitigationPolicy"/> and <see cref="SetProcessMitigationPolicy"/> functions use this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-process_mitigation_control_flow_guard_policy">PROCESS_MITIGATION_CONTROL_FLOW_GUARD_POLICY structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_CONTROL_FLOW_GUARD_POLICY
    {
        private static readonly Bitfield32 bfEnableControlFlowGuard = Bitfield32.DefineLowerBits(1);
        private static readonly Bitfield32 bfEnableExportSuppression = Bitfield32.DefineMiddleBits(1, 1);
        private static readonly Bitfield32 bfStrictMode = Bitfield32.DefineMiddleBits(2, 1);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.DefineFromMask(Bitmask.HigherBitsUInt32(29));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        /// <summary>
        /// CFG is enabled for the process if this flag is set. This field cannot be changed via
        /// <see cref="SetProcessMitigationPolicy"/>.
        /// </summary>
        public bool EnableControlFlowGuard
        {
            get => bfEnableControlFlowGuard.Read(dwFlags) != 0;
            set => bfEnableControlFlowGuard.Write(ref dwFlags, value ? 1U : 0U);
        }

        /// <summary>
        /// If <see langword="true"/>, exported functions will be treated as invalid indirect call targets by default. Exported
        /// functions only become valid indirect call targets if they are dynamically resolved via
        /// <see cref="GetProcAddress"/>. This field cannot be changed via <see cref="SetProcessMitigationPolicy"/>.
        /// </summary>
        public bool EnableExportSuppression
        {
            get => bfEnableExportSuppression.Read(dwFlags) != 0;
            set => bfEnableExportSuppression.Write(ref dwFlags, value ? 1U : 0U);
        }

        /// <summary>
        /// If <see langword="true"/>, all DLLs that are loaded must enable CFG. If a DLL does not enable CFG then the
        /// image will fail to load. This policy can be enabled after a process has started by calling
        /// <see cref="SetProcessMitigationPolicy"/>. It cannot be disabled once enabled.
        /// </summary>
        public bool AllowRemoteDowngrade
        {
            get => bfStrictMode.Read(dwFlags) != 0;
            set => bfStrictMode.Write(ref dwFlags, value ? 1U : 0U);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.Read(dwFlags);
            set => bfReservedFlags.Write(ref dwFlags, (uint)value);
        }
    }
}

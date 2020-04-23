using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11553
    /// <summary>
    /// Used to impose new behavior on handle references that are not valid.
    /// </summary>
    /// <remarks>
    /// <para>
    /// As a general rule, strict handle checking cannot be turned off once it is turned on. Therefore,
    /// when calling the <see cref="SetProcessMitigationPolicy"/> function with this policy, the values of the
    /// <see cref="RaiseExceptionOnInvalidHandleReference"/> and <see cref="HandleExceptionsPermanentlyEnabled"/>
    /// substructure members must be the same. It is not possible to enable invalid handle
    /// exceptions only temporarily.
    /// </para>
    /// <para>
    /// The exception to the general rule about strict handle checking always being a permanent
    /// state is that debugging tools such as Application Verifier can cause the operating system to
    /// enable invalid handle exceptions temporarily. Under those cases, it is possible for the
    /// <see cref="GetProcessMitigationPolicy"/> function to return with
    /// <see cref="RaiseExceptionOnInvalidHandleReference "/> set to <see langword="true"/>, but
    /// <see cref="HandleExceptionsPermanentlyEnabled"/> set to <see langword="false"/>.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-process_mitigation_strict_handle_check_policy">PROCESS_MITIGATION_STRICT_HANDLE_CHECK_POLICY structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_STRICT_HANDLE_CHECK_POLICY
    {
        private static readonly Bitfield32 bfRaiseExceptionOnInvalidHandleReference = Bitfield32.LowBits(1);
        private static readonly Bitfield32 bfHandleExceptionsPermanentlyEnabled = Bitfield32.SelectBits(1, 1);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.FromMask(Bitmask.HigherBitsUInt32(30));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        public bool RaiseExceptionOnInvalidHandleReference
        {
            get => bfRaiseExceptionOnInvalidHandleReference.ReadBool(dwFlags);
            set => bfRaiseExceptionOnInvalidHandleReference.WriteBool(ref dwFlags, value);
        }

        public bool HandleExceptionsPermanentlyEnabled
        {
            get => bfHandleExceptionsPermanentlyEnabled.ReadBool(dwFlags);
            set => bfHandleExceptionsPermanentlyEnabled.WriteBool(ref dwFlags, value);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.ReadMasked(dwFlags);
            set => bfReservedFlags.WriteMasked(ref dwFlags, (uint)value);
        }
    }
}

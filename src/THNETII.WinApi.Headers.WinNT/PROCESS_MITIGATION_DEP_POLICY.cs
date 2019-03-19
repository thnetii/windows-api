﻿using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11541
    /// <summary>
    /// Contains process mitigation policy settings for data execution prevention (DEP).
    /// The <see cref="GetProcessMitigationPolicy"/> and <see cref="SetProcessMitigationPolicy"/> functions use this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-process_mitigation_dep_policy">PROCESS_MITIGATION_DEP_POLICY structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_DEP_POLICY
    {
        private static readonly Bitfield32 bfEnable = Bitfield32.DefineLowerBits(1);
        private static readonly Bitfield32 bfDisableAtlThunkEmulation = Bitfield32.DefineMiddleBits(1, 1);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.DefineFromMask(Bitmask.HigherBitsUInt32(30));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        public bool Enable
        {
            get => bfEnable.Read(dwFlags) != 0;
            set => bfEnable.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool DisableAtlThunkEmulation
        {
            get => bfDisableAtlThunkEmulation.Read(dwFlags) != 0;
            set => bfDisableAtlThunkEmulation.Write(ref dwFlags, value ? 1U : 0U);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.Read(dwFlags);
            set => bfReservedFlags.Write(ref dwFlags, (uint)value);
        }

        private byte bPermanent;

        /// <summary>
        /// DEP is permanently enabled and cannot be disabled if this field is set to <see langword="true"/>.
        /// </summary>
        public bool Permanent
        {
            get => bPermanent != 0;
            set => bPermanent = value ? (byte)1 : (byte)0;
        }
    }
}
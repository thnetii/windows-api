using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;
using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15998
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESSOR_IDLESTATE_POLICY
    {
        public short Revision;
        #region public DUMMYUNIONNAME Flags;
        private static readonly Bitfield32 AllowScalingBitfield = Bitfield32.DefineFromMask(1 << 0);
        private static readonly Bitfield32 DisabledBitfield = Bitfield32.DefineFromMask(1 << 1);
        private static readonly Bitfield32 ReservedBitfield = Bitfield32.DefineFromMask(~0U << 2, 2);
        public short Flags;
        public bool AllowScaling
        {
            get => AllowScalingBitfield.Read(Flags) != 0;
            set
            {
                uint tmp = (uint)Flags;
                Flags = (short)AllowScalingBitfield.Write(ref tmp, value ? ~0U : 0U);
            }
        }
        public bool Disabled
        {
            get => DisabledBitfield.Read(Flags) != 0;
            set
            {
                uint tmp = (uint)Flags;
                Flags = (short)DisabledBitfield.Write(ref tmp, value ? ~0U : 0U);
            }
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public short Reserved
        {
            get => (short)ReservedBitfield.Read(Flags);
            set
            {
                int tmp = Flags;
                Flags = (short)ReservedBitfield.Write(ref tmp, value);
            }
        }
        #endregion

        public int PolicyCount;
        #region public PROCESSOR_IDLESTATE_INFO[] Policy = new PROCESSOR_IDLESTATE_INFO[PolicyCount];
        internal PROCESSOR_IDLESTATE_INFO PolicyField;
        public Span<PROCESSOR_IDLESTATE_INFO> Policy => SpanOverRef.GetSpan(ref PolicyField, PolicyCount); 
        #endregion
    }
}

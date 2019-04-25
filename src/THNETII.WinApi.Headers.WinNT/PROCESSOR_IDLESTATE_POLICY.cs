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
        private static readonly Bitfield16 AllowScalingBitfield = Bitfield16.Bit(0);
        private static readonly Bitfield16 DisabledBitfield = Bitfield16.Bit(1);
        private static readonly Bitfield16 ReservedBitfield = Bitfield16.RemainingBits(2);
        public short Flags;
        public bool AllowScaling
        {
            get => AllowScalingBitfield.ReadMasked(Flags) != 0;
            set => AllowScalingBitfield.WriteMasked(ref Flags, (short)(value ? ~0 : 0));
        }
        public bool Disabled
        {
            get => DisabledBitfield.ReadMasked(Flags) != 0;
            set => DisabledBitfield.WriteMasked(ref Flags, (short)(value ? ~0 : 0));
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public short Reserved
        {
            get => ReservedBitfield.Read(Flags);
            set=> ReservedBitfield.Write(ref Flags, value);
        }
        #endregion

        public int PolicyCount;
        #region public PROCESSOR_IDLESTATE_INFO[] Policy = new PROCESSOR_IDLESTATE_INFO[PolicyCount];
        internal PROCESSOR_IDLESTATE_INFO PolicyField;
        public Span<PROCESSOR_IDLESTATE_INFO> Policy => SpanOverRef.GetSpan(ref PolicyField, PolicyCount); 
        #endregion
    }
}

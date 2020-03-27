using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    [StructLayout(LayoutKind.Sequential)]
    public struct HEAP_TAG
    {
        private static readonly Bitfield32 HEAP_TAG_BASE_BITFIELD = Bitfield32.FromMask(HEAP_MAXIMUM_TAG);
        private static readonly Bitfield32 HEAP_PSEUDO_TAG_BITFIELD = Bitfield32.FromMask(HEAP_PSEUDO_TAG_FLAG);
        private static readonly Bitfield32 HEAP_TAG_FLAGS_BITFIELD = Bitfield32.FromMask(~(HEAP_MAXIMUM_TAG | HEAP_PSEUDO_TAG_FLAG), HEAP_TAG_SHIFT);

        internal int value;

        public int TagBase
        {
            get => HEAP_TAG_BASE_BITFIELD.Read(value);
            set => HEAP_TAG_BASE_BITFIELD.Write(ref this.value, value);
        }

        public bool IsPseudoTag
        {
            get => HEAP_PSEUDO_TAG_BITFIELD.ReadBool(value);
            set => HEAP_PSEUDO_TAG_BITFIELD.WriteBool(ref this.value, value);
        }

        public HEAP_TAG_FLAGS Flags
        {
            get => (HEAP_TAG_FLAGS)HEAP_TAG_FLAGS_BITFIELD.Read(value);
            set => HEAP_TAG_FLAGS_BITFIELD.Write(ref this.value, (int)value);
        }

        public HEAP_TAG(int TagBase, HEAP_TAG_FLAGS Tag) =>
            value = WinNTFunctions.HEAP_MAKE_TAG_FLAGS(TagBase, (int)Tag);
    }
}

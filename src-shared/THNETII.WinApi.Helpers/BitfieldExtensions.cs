using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi
{
    public static class BitfieldExtensions
    {
        public static bool ReadBool(this Bitfield8 bitfield, byte storage) =>
            bitfield.ReadMasked( storage) != 0;
        public static bool ReadBool(this Bitfield8 bitfield, sbyte storage) =>
            bitfield.ReadMasked( storage) != 0;
        public static bool ReadBool(this Bitfield16 bitfield, short storage) =>
            bitfield.ReadMasked( storage) != 0;
        public static bool ReadBool(this Bitfield16 bitfield, ushort storage) =>
            bitfield.ReadMasked( storage) != 0;
        public static bool ReadBool(this Bitfield32 bitfield, int storage) =>
            bitfield.ReadMasked (storage) != 0;
        public static bool ReadBool(this Bitfield32 bitfield, uint storage) =>
            bitfield.ReadMasked( storage) != 0;
        public static bool ReadBool(this Bitfield64 bitfield, long storage) =>
            bitfield.ReadMasked( storage) != 0;
        public static bool ReadBool(this Bitfield64 bitfield, ulong storage) =>
            bitfield.ReadMasked (storage) != 0;

        public static void WriteBool(this Bitfield8 bitfield, ref byte storage, bool value) =>
            bitfield.WriteMasked(ref storage, (byte)(value ? ~0U : 0U));
        public static void WriteBool(this Bitfield8 bitfield, ref sbyte storage, bool value) =>
            bitfield.WriteMasked(ref storage, (sbyte)(value ? ~0 : 0));
        public static void WriteBool(this Bitfield16 bitfield, ref short storage, bool value) =>
            bitfield.WriteMasked(ref storage, (short)(value ? ~0 : 0));
        public static void WriteBool(this Bitfield16 bitfield, ref ushort storage, bool value) =>
            bitfield.WriteMasked(ref storage, (ushort)(value ? ~0U : 0U));
        public static void WriteBool(this Bitfield32 bitfield, ref int storage, bool value) =>
            bitfield.WriteMasked(ref storage, value ? ~0 : 0);
        public static void WriteBool(this Bitfield32 bitfield, ref uint storage, bool value) =>
            bitfield.WriteMasked(ref storage, value ? ~0U : 0U);
        public static void WriteBool(this Bitfield64 bitfield, ref long storage, bool value) =>
            bitfield.WriteMasked(ref storage, value ? ~0L : 0L);
        public static void WriteBool(this Bitfield64 bitfield, ref ulong storage, bool value) =>
            bitfield.WriteMasked(ref storage, value ? ~0UL : 0UL);
    }
}

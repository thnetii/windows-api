using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Helpers
{
    /// <summary>
    /// Provides helper methods for Bitfield operations in native WinApi libraries.
    /// </summary>
    public static class BitfieldExtensions
    {
        /// <summary>
        /// Extracts the bits specified by the bitfield from the specified storage value
        /// and returns wheter any of the extracted bits are set.
        /// </summary>
        /// <param name="bitfield">The bitfield that specifies which bits to extract. Must not be <see langword="null"/>.</param>
        /// <param name="storage">The value to extract the bits from.</param>
        /// <returns>
        /// <see langword="true"/> if any of the extracted bits are set, i.e. if the result from <see cref="IBitfield{T}.ReadMasked(T)"/> is non-zero;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        /// <seealso cref="IBitfield{T}.ReadMasked(T)"/>
        public static bool ReadBool(this Bitfield8 bitfield, byte storage) =>
            bitfield.ReadMasked( storage) != 0;
        /// <inheritdoc cref="ReadBool(Bitfield8, byte)"/>
        public static bool ReadBool(this Bitfield8 bitfield, sbyte storage) =>
            bitfield.ReadMasked( storage) != 0;
        /// <inheritdoc cref="ReadBool(Bitfield8, byte)"/>
        public static bool ReadBool(this Bitfield16 bitfield, short storage) =>
            bitfield.ReadMasked( storage) != 0;
        /// <inheritdoc cref="ReadBool(Bitfield8, byte)"/>
        public static bool ReadBool(this Bitfield16 bitfield, ushort storage) =>
            bitfield.ReadMasked( storage) != 0;
        /// <inheritdoc cref="ReadBool(Bitfield8, byte)"/>
        public static bool ReadBool(this Bitfield32 bitfield, int storage) =>
            bitfield.ReadMasked (storage) != 0;
        /// <inheritdoc cref="ReadBool(Bitfield8, byte)"/>
        public static bool ReadBool(this Bitfield32 bitfield, uint storage) =>
            bitfield.ReadMasked( storage) != 0;
        /// <inheritdoc cref="ReadBool(Bitfield8, byte)"/>
        public static bool ReadBool(this Bitfield64 bitfield, long storage) =>
            bitfield.ReadMasked( storage) != 0;
        /// <inheritdoc cref="ReadBool(Bitfield8, byte)"/>
        public static bool ReadBool(this Bitfield64 bitfield, ulong storage) =>
            bitfield.ReadMasked (storage) != 0;

        /// <summary>
        /// Sets or clears all bits defined by the specified bitfield definition in the storage field,
        /// depending on the specified boolean value.
        /// </summary>
        /// <param name="bitfield">The bitfield that specifies which bits to set or clear. Must not be <see langword="null"/>.</param>
        /// <param name="storage">A reference to the value in which the bits will be cleared or set.</param>
        /// <param name="value"><see langword="true"/> to set all relevant bits in <paramref name="storage"/>; <see langword="false"/> to clear them.</param>
        /// <remarks>
        /// This extension method writes a boolean value to the targeted bits as defined by <paramref name="bitfield"/>.
        /// If <paramref name="value"/> is <see langword="true"/>, the targeted bits will be set to a non-zero value.
        /// If <paramref name="value"/> is <see langword="false"/>, the targeted bits will be set to zero.
        /// </remarks>
        /// <seealso cref="IBitfield{T}.WriteMasked(ref T, T)"/>
        public static void WriteBool(this Bitfield8 bitfield, ref byte storage, bool value) =>
            bitfield.WriteMasked(ref storage, (byte)(value ? ~0U : 0U));
        /// <inheritdoc cref="WriteBool(Bitfield8, ref byte, bool)"/>
        public static void WriteBool(this Bitfield8 bitfield, ref sbyte storage, bool value) =>
            bitfield.WriteMasked(ref storage, (sbyte)(value ? ~0 : 0));
        /// <inheritdoc cref="WriteBool(Bitfield8, ref byte, bool)"/>
        public static void WriteBool(this Bitfield16 bitfield, ref short storage, bool value) =>
            bitfield.WriteMasked(ref storage, (short)(value ? ~0 : 0));
        /// <inheritdoc cref="WriteBool(Bitfield8, ref byte, bool)"/>
        public static void WriteBool(this Bitfield16 bitfield, ref ushort storage, bool value) =>
            bitfield.WriteMasked(ref storage, (ushort)(value ? ~0U : 0U));
        /// <inheritdoc cref="WriteBool(Bitfield8, ref byte, bool)"/>
        public static void WriteBool(this Bitfield32 bitfield, ref int storage, bool value) =>
            bitfield.WriteMasked(ref storage, value ? ~0 : 0);
        /// <inheritdoc cref="WriteBool(Bitfield8, ref byte, bool)"/>
        public static void WriteBool(this Bitfield32 bitfield, ref uint storage, bool value) =>
            bitfield.WriteMasked(ref storage, value ? ~0U : 0U);
        /// <inheritdoc cref="WriteBool(Bitfield8, ref byte, bool)"/>
        public static void WriteBool(this Bitfield64 bitfield, ref long storage, bool value) =>
            bitfield.WriteMasked(ref storage, value ? ~0L : 0L);
        /// <inheritdoc cref="WriteBool(Bitfield8, ref byte, bool)"/>
        public static void WriteBool(this Bitfield64 bitfield, ref ulong storage, bool value) =>
            bitfield.WriteMasked(ref storage, value ? ~0UL : 0UL);
    }
}

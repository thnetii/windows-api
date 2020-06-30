using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18076
    /// <summary>
    /// <para>This structure contains detailed information about runtime exception processing.</para>
    /// <para><see cref="IMAGE_CE_RUNTIME_FUNCTION_ENTRY"/> is used only by ARM and Renesas microprocessor families. It does not apply to MIPS microprocessors.</para>
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="IMAGE_CE_RUNTIME_FUNCTION_ENTRY"/> data structure is also called as <strong>PDATA</strong>. A table containing these records is stored in a section called <strong>.pdata</strong>. The <strong>.pdata</strong> section aids in debugging and exception processing.</para>
    /// <para>If the <see cref="ExceptionFlag"/> is <see langword="true"/>, or if the <see cref="FuncLen"/> is set to <c>0</c> (zero), an additional <strong>PDATA_EH</strong> structure exists that precedes the function in the <strong>.text</strong> section.</para>
    /// <para>The data record containing this information appears in the <strong>.text</strong> section, immediately preceding the function, if and only if the <see cref="ExceptionFlag"/> is <see langword="true"/>.</para>
    /// <para>This record is used when the function has an associated exception handler or handler data.</para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_CE_RUNTIME_FUNCTION_ENTRY
    {
        /// <summary>
        /// Address of the first instruction in the function.
        /// </summary>
        /// <value>It is the function's entry address.</value>
        public int FuncStart;
        internal int Attrs;
        private static readonly Bitfield32 PrologLenBitfield = Bitfield32.SelectBits(0, 8);
        private static readonly Bitfield32 FuncLenBitfield = Bitfield32.SelectBits(8, 22);
        private static readonly Bitfield32 ThirtyTwoBitBitfield = Bitfield32.Bit(30);
        private static readonly Bitfield32 ExceptionFlagBitfield = Bitfield32.Bit(31);
        /// <summary>
        /// Length of the prolog in instructions, based on the instruction size indicated in the <see cref="ThirtyTwoBit"/> flag.
        /// </summary>
        /// <value>A prolog with 10 ARM instructions would have a <see cref="PrologLen"/> of <c>10</c>, indicating 40 bytes. A prolog with 10 THUMB instructions would also have a <see cref="PrologLen"/> of <c>10</c>, meaning 20 bytes.</value>
        public int PrologLen
        {
            get => PrologLenBitfield.Read(Attrs);
            set => PrologLenBitfield.Write(ref Attrs, value);
        }
        /// <summary>
        /// Total function length in instructions
        /// </summary>
        /// <value>A function with 200 ARM instructions would have a <see cref="FuncLen"/> of <c>200</c> (meaning 800 bytes).</value>
        /// <seealso cref="PrologLen"/>
        public int FuncLen
        {
            get => FuncLenBitfield.Read(Attrs);
            set => FuncLenBitfield.Write(ref Attrs, value);
        }
        /// <summary>
        /// Size of instructions in a function.
        /// This value is <see langword="true"/> for 32-bit instructions and <see langword="false"/> for 16-bit instructions.
        /// The <see cref="FuncLen"/> and <see cref="PrologLen"/> properties use this value to computer the size of a function and prolog.
        /// </summary>
        public bool ThirtyTwoBit
        {
            get => ThirtyTwoBitBitfield.ReadBool(Attrs);
            set => ThirtyTwoBitBitfield.WriteBool(ref Attrs, value);
        }
        /// <summary>
        /// Associated exception handler or handler data.
        /// </summary>
        /// <value>When its value is <see langword="true"/>, the <strong>PDATA_EH</strong> is present in the <strong>.text</strong> section. When the <see cref="ExceptionFlag"/> is <see langword="false"/>, no <strong>PDATA_EH</strong> is present.</value>
        public bool ExceptionFlag
        {
            get => ExceptionFlagBitfield.ReadBool(Attrs);
            set => ExceptionFlagBitfield.WriteBool(ref Attrs, value);
        }
    }
}

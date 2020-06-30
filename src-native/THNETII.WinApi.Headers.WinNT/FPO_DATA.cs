using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18299
    /// <summary>
    /// Represents the stack frame layout for a function on an x86 computer when frame pointer omission (FPO) optimization is used. The structure is used to locate the base of the call frame.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-fpo_data">FPO_DATA structure</a></para>
    /// </remarks>
    /// <seealso cref="FunctionTableAccessProc64"/>
    /// <seealso cref="STACKFRAME64"/>
    /// <seealso cref="SymFunctionTableAccess64"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct FPO_DATA
    {
        /// <summary>
        /// The offset of the first byte of the function code.
        /// </summary>
        public int ulOffStart;              // offset 1st byte of function code
        /// <summary>
        /// The number of bytes in the function.
        /// </summary>
        public int cbProcSize;              // # bytes in function
        /// <summary>
        /// The number of local variables.
        /// </summary>
        public int cdwLocals;               // # bytes in locals/4
        /// <summary>
        /// The size of the parameters, in <see cref="int"/>s.
        /// </summary>
        public short cdwParams;             // # bytes in params/4
        internal short attrs;
        private static readonly Bitfield16 cbPrologBitfield = Bitfield16.SelectBits(0, 8);
        private static readonly Bitfield16 cbRegsBitfield = Bitfield16.SelectBits(8, 3);
        private static readonly Bitfield16 fHasSEHBitfield = Bitfield16.SelectBits(11, 1);
        private static readonly Bitfield16 fUseBPBitfield = Bitfield16.SelectBits(12, 1);
        private static readonly Bitfield16 reservedBitfield = Bitfield16.SelectBits(13, 1);
        private static readonly Bitfield16 cbFrameBitfield = Bitfield16.SelectBits(14, 2);
        /// <summary>
        /// The number of bytes in the function prolog code.
        /// </summary>
        public short Prolog                 // # bytes in prolog
        {
            get => cbPrologBitfield.Read(attrs);
            set => cbPrologBitfield.Write(ref attrs, value);
        }
        /// <summary>
        /// The number of registers saved.
        /// </summary>
        public short Regs                   // # regs saved
        {
            get => cbRegsBitfield.Read(attrs);
            set => cbRegsBitfield.Write(ref attrs, value);
        }
        /// <summary>
        /// Indicates whether the function uses structured exception handling.
        /// </summary>
        public bool HasSEH                  // TRUE if SEH in func
        {
            get => fHasSEHBitfield.ReadBool(attrs);
            set => fHasSEHBitfield.WriteBool(ref attrs, value);
        }
        /// <summary>
        /// Indicates whether the EBP register has been allocated.
        /// </summary>
        public bool UseBP                   // TRUE if EBP has been allocated
        {
            get => fUseBPBitfield.ReadBool(attrs);
            set => fUseBPBitfield.WriteBool(ref attrs, value);
        }
        /// <summary>Reserved for future use.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public short Reserved               // reserved for future use
        {
            get => reservedBitfield.Read(attrs);
            set => reservedBitfield.Write(ref attrs, value);
        }
        /// <summary>
        /// Indicates the frame type.
        /// </summary>
        public FPO_FRAME_TYPE Frame         // frame type
        {
            get => (FPO_FRAME_TYPE)cbFrameBitfield.Read(attrs);
            set => cbFrameBitfield.Write(ref attrs, (short)value);
        }
    }
}

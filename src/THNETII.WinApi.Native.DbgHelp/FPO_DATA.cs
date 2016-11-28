using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitfields;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp
{
    /// <summary>
    /// Represents the stack frame layout for a function on an x86 computer when frame pointer omission (FPO) optimization is used. The structure is used to locate the base of the call frame.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms679352.aspx">FPO_DATA structure</a></para>
    /// </remarks>
    /// <seealso cref="FunctionTableAccessProc64"/>
    /// <seealso cref="STACKFRAME64"/>
    /// <seealso cref="SymFunctionTableAccess64"/>
    [StructLayout(LayoutKind.Sequential)]
    public class FPO_DATA
    {
        private static readonly Int16OffsetBitfield cbPrologBitfield = new Int16OffsetBitfield(0, 8);
        private static readonly Int16OffsetBitfield cbRegsBitfield = new Int16OffsetBitfield(8, 3);
        private static readonly Int16OffsetBitfield fHasSEHBitfield = new Int16OffsetBitfield(11, 1);
        private static readonly Int16OffsetBitfield fUseBPBitfield = new Int16OffsetBitfield(12, 1);
        private static readonly Int16OffsetBitfield reservedBitfield = new Int16OffsetBitfield(13, 1);
        private static readonly Int16OffsetBitfield cbFrameBitfield = new Int16OffsetBitfield(14, 2);

        /// <summary>The offset of the first byte of the function code.</summary>
        public int ulOffStart;
        /// <summary>The number of bytes in the function.</summary>
        public int cbProcSize;
        /// <summary>The number of local variables.</summary>
        public int cdwLocals;
        /// <summary>The size of the parameters, in DWORDs (i.e. 4-Byte values).</summary>
        public short cdwParams;
        private short wBitfieldStorage;

        /// <summary>The number of bytes in the function prolog code.</summary>
        public short cbProlog
        {
            get { return cbPrologBitfield.Get(wBitfieldStorage); }
            set { wBitfieldStorage = cbPrologBitfield.Set(value, wBitfieldStorage); }
        }

        /// <summary>The number of registers saved.</summary>
        public short cbRegs
        {
            get { return cbRegsBitfield.Get(wBitfieldStorage); }
            set { wBitfieldStorage = cbRegsBitfield.Set(value, wBitfieldStorage); }
        }

        /// <summary>A variable that indicates whether the function uses structured exception handling.</summary>
        public bool fHasSEH
        {
            get { return fHasSEHBitfield.Get(wBitfieldStorage) == 0 ? false : true; }
            set { wBitfieldStorage = fHasSEHBitfield.Set((short)(value ? 1 : 0), wBitfieldStorage); }
        }

        /// <summary>A variable that indicates whether the EBP register has been allocated.</summary>
        public bool fUseBP
        {
            get { return fUseBPBitfield.Get(wBitfieldStorage) == 0 ? false : true; }
            set { wBitfieldStorage = fUseBPBitfield.Set((short)(value ? 1 : 0), wBitfieldStorage); }
        }

        /// <summary>Reserved for future use.</summary>
        public short reserved
        {
            get { return reservedBitfield.Get(wBitfieldStorage); }
            set { wBitfieldStorage = reservedBitfield.Set(value, wBitfieldStorage); }
        }

        /// <summary>A variable that indicates the frame type.</summary>
        public FRAME_TYPE cbFrame
        {
            get { return (FRAME_TYPE)cbFrameBitfield.Get(wBitfieldStorage); }
            set { wBitfieldStorage = cbFrameBitfield.Set((short)value, wBitfieldStorage); }
        }
    }
}

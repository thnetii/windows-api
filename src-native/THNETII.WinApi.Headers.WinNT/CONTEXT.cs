using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static CONTEXT_FLAGS;
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 7525
    /// <summary>
    /// Context Frame
    /// </summary>
    /// <remarks>
    /// <para>
    /// This frame has a several purposes:
    /// <list type="number">
    /// <item><term>it is used as an argument to <see cref="NtContinue"/></term></item>
    /// <item><term>it is used to constuct a call frame for APC delivery</term></item>
    /// <item><term>it is used in the user level thread creation routines.</term></item>
    /// </list>
    /// </para>
    /// <para>The layout of the record conforms to a standard call frame.</para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe struct CONTEXT
    {
        /// <summary>
        /// The flags values within this flag control the contents of
        /// a <see cref="CONTEXT"/> record.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the context record is used as an input parameter, then
        /// for each portion of the context record controlled by a flag
        /// whose value is set, it is assumed that that portion of the
        /// context record contains valid context. If the context record
        /// is being used to modify a threads context, then only that
        /// portion of the threads context will be modified.
        /// </para>
        /// <para>
        /// If the context record is used as a ref parameter to capture
        /// the context of a thread, then only those portions of the thread's
        /// context corresponding to set flags will be returned.
        /// </para>
        /// <para>
        /// The context record is never used as an out parameter.
        /// </para>
        /// </remarks>
        [MarshalAs(UnmanagedType.I4)]
        public CONTEXT_FLAGS ContextFlags;

        /// <summary>Only valid if <see cref="CONTEXT_DEBUG_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks><note><see cref="CONTEXT_DEBUG_REGISTERS"/> is <strong>not</strong> included in <see cref="CONTEXT_FULL"/>.</note></remarks>
        public int Dr0;
        /// <summary>Only valid if <see cref="CONTEXT_DEBUG_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks><note><see cref="CONTEXT_DEBUG_REGISTERS"/> is <strong>not</strong> included in <see cref="CONTEXT_FULL"/>.</note></remarks>
        public int Dr1;
        /// <summary>Only valid if <see cref="CONTEXT_DEBUG_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks><note><see cref="CONTEXT_DEBUG_REGISTERS"/> is <strong>not</strong> included in <see cref="CONTEXT_FULL"/>.</note></remarks>
        public int Dr2;
        /// <summary>Only valid if <see cref="CONTEXT_DEBUG_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks><note><see cref="CONTEXT_DEBUG_REGISTERS"/> is <strong>not</strong> included in <see cref="CONTEXT_FULL"/>.</note></remarks>
        public int Dr3;
        /// <summary>Only valid if <see cref="CONTEXT_DEBUG_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks><note><see cref="CONTEXT_DEBUG_REGISTERS"/> is <strong>not</strong> included in <see cref="CONTEXT_FULL"/>.</note></remarks>
        public int Dr6;
        /// <summary>Only valid if <see cref="CONTEXT_DEBUG_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks><note><see cref="CONTEXT_DEBUG_REGISTERS"/> is <strong>not</strong> included in <see cref="CONTEXT_FULL"/>.</note></remarks>
        public int Dr7;

        /// <summary>
        /// This section is specified/returned if the
        /// <see cref="ContextFlags"/> field contains the flag <see cref="CONTEXT_FLOATING_POINT"/>.
        /// </summary>
        public FLOATING_SAVE_AREA FloatSave;

        /// <summary>Only valid if <see cref="CONTEXT_SEGMENTS"/> is set in <see cref="ContextFlags"/>.</summary>
        public int SegGs;
        /// <summary>Only valid if <see cref="CONTEXT_SEGMENTS"/> is set in <see cref="ContextFlags"/>.</summary>
        public int SegFs;
        /// <summary>Only valid if <see cref="CONTEXT_SEGMENTS"/> is set in <see cref="ContextFlags"/>.</summary>
        public int SegEs;
        /// <summary>Only valid if <see cref="CONTEXT_SEGMENTS"/> is set in <see cref="ContextFlags"/>.</summary>
        public int SegDs;

        /// <summary>Only valid if <see cref="CONTEXT_INTEGER"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Edi;
        /// <summary>Only valid if <see cref="CONTEXT_INTEGER"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Esi;
        /// <summary>Only valid if <see cref="CONTEXT_INTEGER"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Ebx;
        /// <summary>Only valid if <see cref="CONTEXT_INTEGER"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Edx;
        /// <summary>Only valid if <see cref="CONTEXT_INTEGER"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Ecx;
        /// <summary>Only valid if <see cref="CONTEXT_INTEGER"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Eax;

        /// <summary>Only valid if <see cref="CONTEXT_CONTROL"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Ebp;
        /// <summary>Only valid if <see cref="CONTEXT_CONTROL"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Eip;
        /// <summary>Only valid if <see cref="CONTEXT_CONTROL"/> is set in <see cref="ContextFlags"/>.</summary>
        public int SegCs;              // MUST BE SANITIZED
        /// <summary>Only valid if <see cref="CONTEXT_CONTROL"/> is set in <see cref="ContextFlags"/>.</summary>
        public int EFlags;             // MUST BE SANITIZED
        /// <summary>Only valid if <see cref="CONTEXT_CONTROL"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Esp;
        /// <summary>Only valid if <see cref="CONTEXT_CONTROL"/> is set in <see cref="ContextFlags"/>.</summary>
        public int SegSs;

        /// <summary>
        /// This section is specified/returned if the <see cref="ContextFlags"/> word
        /// contains the flag <see cref="CONTEXT_EXTENDED_REGISTERS"/>.
        /// The format and contexts are processor specific
        /// </summary>
        public fixed byte ExtendedRegisters[MAXIMUM_SUPPORTED_EXTENSION];
    }

    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public unsafe struct CONTEXT_AMD64
    {
        //
        // Register parameter home addresses.
        //
        // N.B. These fields are for convience - they could be used to extend the
        //      context record in the future.
        //

        public long P1Home;
        public long P2Home;
        public long P3Home;
        public long P4Home;
        public long P5Home;
        public long P6Home;

        //
        // Control flags.
        //

        public CONTEXT_FLAGS ContextFlags;
        public int MxCsr;

        //
        // Segment Registers and processor flags.
        //

        public short SegCs;
        public short SegDs;
        public short SegEs;
        public short SegFs;
        public short SegGs;
        public short SegSs;
        public int EFlags;

        //
        // Debug registers
        //

        public long Dr0;
        public long Dr1;
        public long Dr2;
        public long Dr3;
        public long Dr6;
        public long Dr7;

        //
        // Integer registers.
        //

        public long Rax;
        public long Rcx;
        public long Rdx;
        public long Rbx;
        public long Rsp;
        public long Rbp;
        public long Rsi;
        public long Rdi;
        public long R8;
        public long R9;
        public long R10;
        public long R11;
        public long R12;
        public long R13;
        public long R14;
        public long R15;

        //
        // Program counter.
        //

        public long Rip;

        //
        // Floating point state.
        //

        public CONTEXT_AMD64_FLOATING_POINT_STATE FloatingPointState;

        //
        // Vector registers.
        //

        #region public fixed M128A VectorRegister[26];
        public fixed byte VectorRegisterField[26 * M128A.SizeOf];
        public Span<M128A> VectorRegister
        {
            get
            {
                fixed (void* ptr = VectorRegisterField)
                {
                    return new Span<M128A>(ptr, 26);
                }
            }
        }
        #endregion
        public long VectorControl;

        //
        // Special debug control registers.
        //

        public long DebugControl;
        public long LastBranchToRip;
        public long LastBranchFromRip;
        public long LastExceptionToRip;
        public long LastExceptionFromRip;
    }

    [StructLayout(LayoutKind.Explicit, Pack = 16)]
    public struct CONTEXT_AMD64_FLOATING_POINT_STATE
    {
        [FieldOffset(0)]
        public XSAVE_FORMAT FltSave;
        [FieldOffset(0)]
        public CONTEXT_AMD64_XMM_STATE XmmSave;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public unsafe struct CONTEXT_AMD64_XMM_STATE
    {
        #region public fixed M128A Header[2];
        internal fixed byte HeaderField[2 * M128A.SizeOf];
        public Span<M128A> Header
        {
            get
            {
                fixed (void* pHeader = HeaderField)
                {
                    return new Span<M128A>(pHeader, 2);
                }
            }
        }
        #endregion
        #region public fixed M128A Legacy[8];
        internal fixed byte LegacyField[8 * M128A.SizeOf];
        public Span<M128A> Legacy
        {
            get
            {
                fixed (void* pLegacy = LegacyField)
                {
                    return new Span<M128A>(pLegacy, 8);
                }
            }
        }
        #endregion
        public M128A Xmm0;
        public M128A Xmm1;
        public M128A Xmm2;
        public M128A Xmm3;
        public M128A Xmm4;
        public M128A Xmm5;
        public M128A Xmm6;
        public M128A Xmm7;
        public M128A Xmm8;
        public M128A Xmm9;
        public M128A Xmm10;
        public M128A Xmm11;
        public M128A Xmm12;
        public M128A Xmm13;
        public M128A Xmm14;
        public M128A Xmm15;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public unsafe struct CONTEXT_ARM
    {
        /// <summary>
        /// Control flags.
        /// </summary>
        public CONTEXT_FLAGS ContextFlags;

        //
        // Integer registers
        //

        public int R0;
        public int R1;
        public int R2;
        public int R3;
        public int R4;
        public int R5;
        public int R6;
        public int R7;
        public int R8;
        public int R9;
        public int R10;
        public int R11;
        public int R12;

        //
        // Control Registers
        //

        public int Sp;
        public int Lr;
        public int Pc;
        public int Cpsr;

        //
        // Floating Point/NEON Registers
        //

        public int Fpscr;
        public int Padding;
        public Span<NEON128> Q
        {
            get
            {
                fixed (void* ptr = D)
                    return new Span<NEON128>(ptr, 16);
            }
        }
        public fixed ulong D[32];
        public Span<int> S
        {
            get
            {
                fixed (void* ptr = D)
                    return new Span<int>(ptr, 32);
            }
        }

        //
        // Debug registers
        //

        public fixed int Bvr[ARM_MAX_BREAKPOINTS];
        public fixed int Bcr[ARM_MAX_BREAKPOINTS];
        public fixed int Wvr[ARM_MAX_WATCHPOINTS];
        public fixed int Wcr[ARM_MAX_WATCHPOINTS];

        public fixed int Padding2[2];
    }

    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public unsafe struct ARM64_NT_CONTEXT
    {
        /// <summary>
        /// Control flags.
        /// </summary>
        public CONTEXT_FLAGS ContextFlags;

        //
        // Integer registers
        //
        /// <summary>NZVF + DAIF + CurrentEL + SPSel</summary>
        public int Cpsr;
        public long X0;
        public long X1;
        public long X2;
        public long X3;
        public long X4;
        public long X5;
        public long X6;
        public long X7;
        public long X8;
        public long X9;
        public long X10;
        public long X11;
        public long X12;
        public long X13;
        public long X14;
        public long X15;
        public long X16;
        public long X17;
        public long X18;
        public long X19;
        public long X20;
        public long X21;
        public long X22;
        public long X23;
        public long X24;
        public long X25;
        public long X26;
        public long X27;
        public long X28;
        public long Fp;
        public long Lr;
        public Span<long> X
        {
            get
            {
                fixed (long* ptr = &X0)
                {
                    return new Span<long>(ptr, 31);
                }
            }
        }
        public long Sp;
        public long Pc;

        //
        // Floating Point/NEON Registers
        //

        #region public fixed ARM64_NT_NEON128 V[32];
        internal fixed byte VField[32 * (128 / 8)];
        public Span<ARM64_NT_NEON128> V
        {
            get
            {
                fixed (void* ptr = VField)
                {
                    return new Span<ARM64_NT_NEON128>(ptr, 32);
                }
            }
        }
        #endregion
        public int Fpcr;
        public int Fpsr;

        //
        // Debug registers
        //

        public fixed int Bcr[ARM64_MAX_BREAKPOINTS];
        public fixed long Bvr[ARM64_MAX_BREAKPOINTS];
        public fixed int Wcr[ARM64_MAX_WATCHPOINTS];
        public fixed long Wvr[ARM64_MAX_WATCHPOINTS];
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe struct WOW64_CONTEXT
    {
        /// <summary>
        /// The flags values within this flag control the contents of
        /// a <see cref="WOW64_CONTEXT"/> record.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the context record is used as an input parameter, then
        /// for each portion of the context record controlled by a flag
        /// whose value is set, it is assumed that that portion of the
        /// context record contains valid context. If the context record
        /// is being used to modify a threads context, then only that
        /// portion of the threads context will be modified.
        /// </para>
        /// <para>
        /// If the context record is used as a ref parameter to capture
        /// the context of a thread, then only those portions of the thread's
        /// context corresponding to set flags will be returned.
        /// </para>
        /// <para>
        /// The context record is never used as an out parameter.
        /// </para>
        /// </remarks>
        [MarshalAs(UnmanagedType.I4)]
        public CONTEXT_FLAGS ContextFlags;

        /// <summary>Only valid if <see cref="WOW64_CONTEXT_DEBUG_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks><note><see cref="WOW64_CONTEXT_DEBUG_REGISTERS"/> is <strong>not</strong> included in <see cref="WOW64_CONTEXT_FULL"/>.</note></remarks>
        public int Dr0;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_DEBUG_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks><note><see cref="WOW64_CONTEXT_DEBUG_REGISTERS"/> is <strong>not</strong> included in <see cref="WOW64_CONTEXT_FULL"/>.</note></remarks>
        public int Dr1;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_DEBUG_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks><note><see cref="WOW64_CONTEXT_DEBUG_REGISTERS"/> is <strong>not</strong> included in <see cref="WOW64_CONTEXT_FULL"/>.</note></remarks>
        public int Dr2;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_DEBUG_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks><note><see cref="WOW64_CONTEXT_DEBUG_REGISTERS"/> is <strong>not</strong> included in <see cref="WOW64_CONTEXT_FULL"/>.</note></remarks>
        public int Dr3;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_DEBUG_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks><note><see cref="WOW64_CONTEXT_DEBUG_REGISTERS"/> is <strong>not</strong> included in <see cref="WOW64_CONTEXT_FULL"/>.</note></remarks>
        public int Dr6;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_DEBUG_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks><note><see cref="WOW64_CONTEXT_DEBUG_REGISTERS"/> is <strong>not</strong> included in <see cref="WOW64_CONTEXT_FULL"/>.</note></remarks>
        public int Dr7;

        /// <summary>
        /// This section is specified/returned if the
        /// <see cref="ContextFlags"/> field contains the flag <see cref="WOW64_CONTEXT_FLOATING_POINT"/>.
        /// </summary>
        public WOW64_FLOATING_SAVE_AREA FloatSave;

        /// <summary>Only valid if <see cref="WOW64_CONTEXT_SEGMENTS"/> is set in <see cref="ContextFlags"/>.</summary>
        public int SegGs;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_SEGMENTS"/> is set in <see cref="ContextFlags"/>.</summary>
        public int SegFs;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_SEGMENTS"/> is set in <see cref="ContextFlags"/>.</summary>
        public int SegEs;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_SEGMENTS"/> is set in <see cref="ContextFlags"/>.</summary>
        public int SegDs;

        /// <summary>Only valid if <see cref="WOW64_CONTEXT_INTEGER"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Edi;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_INTEGER"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Esi;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_INTEGER"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Ebx;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_INTEGER"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Edx;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_INTEGER"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Ecx;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_INTEGER"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Eax;

        /// <summary>Only valid if <see cref="WOW64_CONTEXT_CONTROL"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Ebp;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_CONTROL"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Eip;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_CONTROL"/> is set in <see cref="ContextFlags"/>.</summary>
        public int SegCs;              // MUST BE SANITIZED
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_CONTROL"/> is set in <see cref="ContextFlags"/>.</summary>
        public int EFlags;             // MUST BE SANITIZED
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_CONTROL"/> is set in <see cref="ContextFlags"/>.</summary>
        public int Esp;
        /// <summary>Only valid if <see cref="WOW64_CONTEXT_CONTROL"/> is set in <see cref="ContextFlags"/>.</summary>
        public int SegSs;

        /// <summary>
        /// This section is specified/returned if the <see cref="ContextFlags"/> word
        /// contains the flag <see cref="WOW64_CONTEXT_EXTENDED_REGISTERS"/>.
        /// The format and contexts are processor specific
        /// </summary>
        public fixed byte ExtendedRegisters[WOW64_MAXIMUM_SUPPORTED_EXTENSION];
    }
}

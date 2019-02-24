using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;
using THNETII.InteropServices.Runtime;
using static THNETII.WinApi.Native.WinNT.CONTEXT_FLAGS;

namespace THNETII.WinApi.Native.WinNT
{
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
    public struct CONTEXT
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

        #region public byte ExtendedRegisters[MAXIMUM_SUPPORTED_EXTENSION];
        internal ExtendedRegistersField fieldExtendedRegisters;
        [StructLayout(LayoutKind.Explicit, Size = WinNTConstants.MAXIMUM_SUPPORTED_EXTENSION * sizeof(byte))]
        internal struct ExtendedRegistersField
        {
            public const int Length = WinNTConstants.MAXIMUM_SUPPORTED_EXTENSION * sizeof(byte);
            public ref byte this[int index] => ref Span[index];
            public Span<byte> Span => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref this));
        }
        /// <summary>Only valid if <see cref="CONTEXT_EXTENDED_REGISTERS"/> is set in <see cref="ContextFlags"/>.</summary>
        /// <remarks>The format and contexts are processor specific</remarks>
        public Span<byte> ExtendedRegisters => fieldExtendedRegisters.Span;
        #endregion
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PCONTEXT : IIntPtr<CONTEXT>
    {
        public PCONTEXT(IntPtr ptr) : this() => Pointer = ptr;
        public IntPtr Pointer { get; }
    }
}

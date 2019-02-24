using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Scope table structure definition.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SCOPE_TABLE_HEADER
    {
        public int Count;
        public SCOPE_RECORD ScopeRecord;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PSCOPE_TABLE : IIntPtr
    {
        public PSCOPE_TABLE(IntPtr ptr) => Pointer = ptr;
        public PSCOPE_TABLE(IntPtr<SCOPE_TABLE_HEADER> ptr) => Pointer = ptr.Pointer;
        public PSCOPE_TABLE(IIntPtr<SCOPE_TABLE_HEADER> ptr) => Pointer = (ptr?.Pointer).GetValueOrDefault();
        public IntPtr Pointer { get; }
        public ref int Count => ref Pointer.AsRefStruct<SCOPE_TABLE_HEADER>().Count;
        public Span<SCOPE_RECORD> ScopeRecord
        {
            get
            {
                var ptr = Pointer;
                if (ptr == IntPtr.Zero)
                    return Span<SCOPE_RECORD>.Empty;
                var count = ptr.AsRefStruct<SCOPE_TABLE_HEADER>().Count;
                var pScopeRecord = ptr + Marshal.OffsetOf<SCOPE_TABLE_HEADER>(nameof(SCOPE_TABLE_HEADER.ScopeRecord)).ToInt32();
                try { return pScopeRecord.AsRefStructSpan<SCOPE_RECORD>(count); }
                catch (ArgumentException argExcept) { throw new InvalidOperationException(argExcept.Message, argExcept); }
            }
        }
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct SCOPE_RECORD
    {
        public int BeginAddress;
        public int EndAddress;
        public int HandlerAddress;
        public int JumpTarget;
    }
}

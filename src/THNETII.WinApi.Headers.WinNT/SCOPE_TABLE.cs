using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Scope table structure definition.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SCOPE_TABLE
    {
        public int Count;
        internal SCOPE_RECORD ScopeRecordField;
        public unsafe Span<SCOPE_RECORD> ScopeRecord => new Span<SCOPE_RECORD>(Unsafe.AsPointer(ref ScopeRecordField), Count);
    }
}

using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

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
        public Span<SCOPE_RECORD> ScopeRecord => SpanOverRef.GetSpan(ref ScopeRecordField, Count);
    }
}

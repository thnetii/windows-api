using System;
using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>V-table constants</summary>
    [Flags]
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum COR_VTABLE_FLAGS : byte
    {
        /// <inheritdoc cref="ReplacesCorHdrNumericDefines.COR_VTABLE_32BIT"/>
        COR_VTABLE_32BIT = ReplacesCorHdrNumericDefines.COR_VTABLE_32BIT,
        /// <inheritdoc cref="ReplacesCorHdrNumericDefines.COR_VTABLE_64BIT"/>
        COR_VTABLE_64BIT = ReplacesCorHdrNumericDefines.COR_VTABLE_64BIT,
        /// <inheritdoc cref="ReplacesCorHdrNumericDefines.COR_VTABLE_FROM_UNMANAGED"/>
        COR_VTABLE_FROM_UNMANAGED = ReplacesCorHdrNumericDefines.COR_VTABLE_FROM_UNMANAGED,
        /// <inheritdoc cref="ReplacesCorHdrNumericDefines.COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN"/>
        COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN = ReplacesCorHdrNumericDefines.COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN,
        /// <inheritdoc cref="ReplacesCorHdrNumericDefines.COR_VTABLE_CALL_MOST_DERIVED"/>
        COR_VTABLE_CALL_MOST_DERIVED = ReplacesCorHdrNumericDefines.COR_VTABLE_CALL_MOST_DERIVED,
    }
}

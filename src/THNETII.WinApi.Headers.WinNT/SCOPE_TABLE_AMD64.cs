using System.Runtime.InteropServices;

namespace THNETII.WinApi.WinNT
{
    using System;
    using THNETII.InteropServices.NativeMemory;
    using static WinNTConstants;

    [StructLayout(LayoutKind.Sequential)]
    public struct SCOPE_TABLE_AMD64
    {
        public int Count;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = ANYSIZE_ARRAY)]
        public SCOPE_RECORD_AMD64[] ScopeRecord;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SCOPE_RECORD_AMD64
    {
        public int BeginAddress;
        public int EndAddress;
        public int HandlerAddress;
        public int JumpTarget;
    }

    public class SCOPE_TABLE_AMD64_MARSHAL
#if !NETSTANDARD1_3
        : ICustomMarshaler
#endif // !NETSTANDARD1_3
    {
        private static readonly int offsetScopeRecord =
            Marshal.OffsetOf<SCOPE_TABLE_AMD64>(nameof(SCOPE_TABLE_AMD64.ScopeRecord)).ToInt32();
        private static readonly int offsetScopeRecordPlusOne =
            offsetScopeRecord + SizeOf<SCOPE_RECORD_AMD64>.Bytes * 1;

        public void CleanUpManagedData(object ManagedObj)
        {
            if (ManagedObj is IDisposable disposable)
                disposable.Dispose();
        }

        public void CleanUpNativeData(IntPtr pNativeData) =>
            Marshal.FreeCoTaskMem(pNativeData);

#if NETSTANDARD1_3
        internal int GetNativeDataSize()
#else // !NETSTANDARD1_3
        int ICustomMarshaler.GetNativeDataSize()
#endif // !NETSTANDARD1_3
        { return -1; }

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            if (!(ManagedObj is SCOPE_TABLE_AMD64 scopeTable))
                return IntPtr.Zero;

            int cbScopeTable = SizeOf<SCOPE_TABLE_AMD64>.Bytes;
            int additionalRecords = ((scopeTable.ScopeRecord?.Length ?? 0) > ANYSIZE_ARRAY)
                ? scopeTable.ScopeRecord.Length - ANYSIZE_ARRAY
                : 0;
            cbScopeTable += additionalRecords * SizeOf<SCOPE_RECORD_AMD64>.Bytes;

            var pScopeTable = Marshal.AllocCoTaskMem(cbScopeTable);
            Marshal.StructureToPtr(scopeTable, pScopeTable, fDeleteOld: false);
            IntPtr pRecord = pScopeTable + offsetScopeRecordPlusOne;
            for (int i = 1; i < scopeTable.ScopeRecord.Length; i++, pRecord += SizeOf<SCOPE_RECORD_AMD64>.Bytes)
                Marshal.StructureToPtr(scopeTable.ScopeRecord[i], pRecord, fDeleteOld: false);
            return pScopeTable;
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
                return default(SCOPE_TABLE_AMD64);

            var scopeTable = Marshal.PtrToStructure<SCOPE_TABLE_AMD64>(pNativeData);
            if (scopeTable.Count < 2)
                return scopeTable;
            var records = new SCOPE_RECORD_AMD64[scopeTable.Count];
            IntPtr pRecord = pNativeData + offsetScopeRecord;
            for (int i = 0; i < scopeTable.Count; i++, pRecord += SizeOf<SCOPE_RECORD_AMD64>.Bytes)
                records[i] = Marshal.PtrToStructure<SCOPE_RECORD_AMD64>(pRecord);
            scopeTable.ScopeRecord = records;
            return scopeTable;
        }

        public static SCOPE_TABLE_AMD64_MARSHAL GetInstance() =>
            new SCOPE_TABLE_AMD64_MARSHAL();

        public static SCOPE_TABLE_AMD64_MARSHAL GetInstance(string cookie) =>
            new SCOPE_TABLE_AMD64_MARSHAL();
    }
}

using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 3975
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UNWIND_HISTORY_TABLE_AMD64
    {
        public int Count;
        public byte LocalHint;
        public byte GlobalHint;
        public byte Search;
        public byte Once;
        public long LowAddress;
        public long HighAddress;
        #region public fixed UNWIND_HISTORY_TABLE_ENTRY_AMD64 Entry[UNWIND_HISTORY_TABLE_SIZE];
        internal fixed byte EntryField[UNWIND_HISTORY_TABLE_SIZE * UNWIND_HISTORY_TABLE_ENTRY_AMD64.SizeOf];
        public Span<UNWIND_HISTORY_TABLE_ENTRY_AMD64> Entry
        {
            get
            {
                fixed (void* ptr = EntryField)
                {
                    return new Span<UNWIND_HISTORY_TABLE_ENTRY_AMD64>(ptr, UNWIND_HISTORY_TABLE_SIZE);
                }
            }
        }
        #endregion
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 4968
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UNWIND_HISTORY_TABLE_ARM
    {
        public int Count;
        public byte LocalHint;
        public byte GlobalHint;
        public byte Search;
        public byte Once;
        public int LowAddress;
        public int HighAddress;
        #region public fixed UNWIND_HISTORY_TABLE_ENTRY_ARM Entry[UNWIND_HISTORY_TABLE_SIZE];
        internal fixed byte EntryField[UNWIND_HISTORY_TABLE_SIZE * UNWIND_HISTORY_TABLE_ENTRY_ARM.SizeOf];
        public Span<UNWIND_HISTORY_TABLE_ENTRY_ARM> Entry
        {
            get
            {
                fixed (void* ptr = EntryField)
                {
                    return new Span<UNWIND_HISTORY_TABLE_ENTRY_ARM>(ptr, UNWIND_HISTORY_TABLE_SIZE);
                }
            }
        }
        #endregion
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 6154
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UNWIND_HISTORY_TABLE_ARM64
    {
        public int Count;
        public byte LocalHint;
        public byte GlobalHint;
        public byte Search;
        public byte Once;
        public long LowAddress;
        public long HighAddress;
        #region public fixed UNWIND_HISTORY_TABLE_ENTRY_ARM64 Entry[UNWIND_HISTORY_TABLE_SIZE];
        internal fixed byte EntryField[UNWIND_HISTORY_TABLE_SIZE * UNWIND_HISTORY_TABLE_ENTRY_ARM64.SizeOf];
        public Span<UNWIND_HISTORY_TABLE_ENTRY_ARM64> Entry
        {
            get
            {
                fixed (void* ptr = EntryField)
                {
                    return new Span<UNWIND_HISTORY_TABLE_ENTRY_ARM64>(ptr, UNWIND_HISTORY_TABLE_SIZE);
                }
            }
        }
        #endregion
    }
}

namespace THNETII.WinApi.Native.MinWinBase
{
    public static class MinWinBaseConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 414
        /* Local Memory Flags */
        public const int LMEM_FIXED = 0x0000;
        public const int LMEM_MOVEABLE = 0x0002;
        public const int LMEM_NOCOMPACT = 0x0010;
        public const int LMEM_NODISCARD = 0x0020;
        public const int LMEM_ZEROINIT = 0x0040;
        public const int LMEM_MODIFY = 0x0080;
        public const int LMEM_DISCARDABLE = 0x0F00;
        public const int LMEM_VALID_FLAGS = 0x0F72;
        public const int LMEM_INVALID_HANDLE = 0x8000;

        public const int LHND = LMEM_MOVEABLE | LMEM_ZEROINIT;
        public const int LPTR = LMEM_FIXED | LMEM_ZEROINIT;

        public const int NONZEROLHND = LMEM_MOVEABLE;
        public const int NONZEROLPTR = LMEM_FIXED;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 433
        /* Flags returned by LocalFlags (in addition to LMEM_DISCARDABLE) */
        public const int LMEM_DISCARDED = 0x4000;
        public const int LMEM_LOCKCOUNT = 0x00FF;
    }
}

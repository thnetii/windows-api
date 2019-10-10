using static THNETII.WinApi.Native.NTStatus.NTStatusConstants;

namespace THNETII.WinApi.Native.MinWinBase
{
    public static class MinWinBaseConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 154
        public const int FIND_FIRST_EX_CASE_SENSITIVE = 0x00000001;
        public const int FIND_FIRST_EX_LARGE_FETCH = 0x00000002;
        public const int FIND_FIRST_EX_ON_DISK_ENTRIES_ONLY = 0x00000004;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 387
        /* compatibility macros */
        public const int STILL_ACTIVE = STATUS_PENDING;
        public const int EXCEPTION_ACCESS_VIOLATION = STATUS_ACCESS_VIOLATION;
        public const int EXCEPTION_DATATYPE_MISALIGNMENT = STATUS_DATATYPE_MISALIGNMENT;
        public const int EXCEPTION_BREAKPOINT = STATUS_BREAKPOINT;
        public const int EXCEPTION_SINGLE_STEP = STATUS_SINGLE_STEP;
        public const int EXCEPTION_ARRAY_BOUNDS_EXCEEDED = STATUS_ARRAY_BOUNDS_EXCEEDED;
        public const int EXCEPTION_FLT_DENORMAL_OPERAND = STATUS_FLOAT_DENORMAL_OPERAND;
        public const int EXCEPTION_FLT_DIVIDE_BY_ZERO = STATUS_FLOAT_DIVIDE_BY_ZERO;
        public const int EXCEPTION_FLT_INEXACT_RESULT = STATUS_FLOAT_INEXACT_RESULT;
        public const int EXCEPTION_FLT_INVALID_OPERATION = STATUS_FLOAT_INVALID_OPERATION;
        public const int EXCEPTION_FLT_OVERFLOW = STATUS_FLOAT_OVERFLOW;
        public const int EXCEPTION_FLT_STACK_CHECK = STATUS_FLOAT_STACK_CHECK;
        public const int EXCEPTION_FLT_UNDERFLOW = STATUS_FLOAT_UNDERFLOW;
        public const int EXCEPTION_INT_DIVIDE_BY_ZERO = STATUS_INTEGER_DIVIDE_BY_ZERO;
        public const int EXCEPTION_INT_OVERFLOW = STATUS_INTEGER_OVERFLOW;
        public const int EXCEPTION_PRIV_INSTRUCTION = STATUS_PRIVILEGED_INSTRUCTION;
        public const int EXCEPTION_IN_PAGE_ERROR = STATUS_IN_PAGE_ERROR;
        public const int EXCEPTION_ILLEGAL_INSTRUCTION = STATUS_ILLEGAL_INSTRUCTION;
        public const int EXCEPTION_NONCONTINUABLE_EXCEPTION = STATUS_NONCONTINUABLE_EXCEPTION;
        public const int EXCEPTION_STACK_OVERFLOW = STATUS_STACK_OVERFLOW;
        public const int EXCEPTION_INVALID_DISPOSITION = STATUS_INVALID_DISPOSITION;
        public const int EXCEPTION_GUARD_PAGE = STATUS_GUARD_PAGE_VIOLATION;
        public const int EXCEPTION_INVALID_HANDLE = STATUS_INVALID_HANDLE;
        public const int EXCEPTION_POSSIBLE_DEADLOCK = STATUS_POSSIBLE_DEADLOCK;
        public const int CONTROL_C_EXIT = STATUS_CONTROL_C_EXIT;

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

using System;

namespace THNETII.WinApi.Native.MinWinBase
{
    [Flags]
    public enum FIND_FIRST_EX_MODE : int
    {
        FIND_FIRST_EX_CASE_SENSITIVE = MinWinBaseConstants.FIND_FIRST_EX_CASE_SENSITIVE,
        FIND_FIRST_EX_LARGE_FETCH = MinWinBaseConstants.FIND_FIRST_EX_LARGE_FETCH,
        FIND_FIRST_EX_ON_DISK_ENTRIES_ONLY = MinWinBaseConstants.FIND_FIRST_EX_ON_DISK_ENTRIES_ONLY,

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using THNETII.WinApi.Native.MinWinBase;
using THNETII.WinApi.Native.MinWinDef;
using THNETII.WinApi.Native.WinBase;
using THNETII.WinApi.Native.WinNT;
using THNETII.WinApi.Native.WinUser;

namespace THNETII.WinApi.Native.Metadata
{
    public static class WinApiStructures
    {
        public static readonly IEnumerable<Type> Types = new[]
        {
            // MinWinBase
            typeof(LMEM_STATUS),
            // MinWinDef
            typeof(HLOCAL),
            // WinBase
            typeof(FORMAT_MESSAGE_OPTIONS),
            // WinNT
            typeof(ACCESS_MASK),
            typeof(CONTEXT),
            typeof(EXCEPTION_RECORD), typeof(PEXCEPTION_RECORD),
            typeof(FLOATING_SAVE_AREA),
            typeof(GENERIC_MAPPING),
            typeof(GROUP_AFFINITY),
            typeof(LDT_ENTRY), typeof(LDT_ENTRY_HIGHWORD),
            typeof(LIST_ENTRY), typeof(PLIST_ENTRY),
            typeof(LUID),
            typeof(LUID_AND_ATTRIBUTES),
            typeof(M128A),
            typeof(OBJECTID),
            typeof(PROCESSOR_NUMBER),
            typeof(SCOPE_TABLE), typeof(SCOPE_RECORD),
            typeof(SINGLE_LIST_ENTRY), typeof(PSINGLE_LIST_ENTRY),
            typeof(XSAVE_AREA), typeof(PXSAVE_AREA),
            typeof(XSAVE_AREA_HEADER),
            typeof(XSAVE_FORMAT), typeof(XSAVE_FORMAT_WIN64),
            typeof(XSTATE_CONTEXT), typeof(XSTATE_CONTEXT_X86),
            // WinUser
            typeof(FLASHWINFO),
            // Error Codes
            typeof(HRESULT),
            typeof(NTSTATUS),
            typeof(Win32ErrorCode),
        };

        public static readonly IEnumerable<object[]> TypesMemberData =
            Types.Select(t => new object[] { t });
    }
}

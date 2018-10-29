using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using THNETII.WinApi.Native.MinWinBase;
using THNETII.WinApi.Native.MinWinDef;
using THNETII.WinApi.Native.WinBase;
using THNETII.WinApi.Native.WinNT;
using THNETII.WinApi.Native.WinUser;
using Xunit;

namespace THNETII.WinApi.Native.SizeOf.Test
{
    public static class SizeOfTest
    {
        private static readonly Type[] type = new[]
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

        public static IEnumerable<object[]> GetWinApiTypesData() => type.Select(t => (new object[] { t }));

        private static readonly MethodInfo MarshalSizeOfGeneric = typeof(Marshal)
            .GetMethod(nameof(Marshal.SizeOf), genericParameterCount: 1, BindingFlags.Static | BindingFlags.Public, Type.DefaultBinder, Type.EmptyTypes, modifiers: null);

        private static Func<int> GetMarshalSizeOfForType(Type type) =>
            (Func<int>)MarshalSizeOfGeneric.MakeGenericMethod(type).CreateDelegate(typeof(Func<int>));

        private static readonly MethodInfo UnsafeSizeOfGeneric = typeof(Unsafe)
            .GetMethod(nameof(Unsafe.SizeOf), genericParameterCount: 1, BindingFlags.Static | BindingFlags.Public, Type.DefaultBinder, Type.EmptyTypes, modifiers: null);

        private static Func<int> GetUnsafeSizeOfForType(Type type) =>
            (Func<int>)UnsafeSizeOfGeneric.MakeGenericMethod(type).CreateDelegate(typeof(Func<int>));

        [Theory, MemberData(nameof(GetWinApiTypesData))]
        public static void WinApiTypeMarshalSizeOf(Type type)
        {
            Assert.NotEqual(0, GetMarshalSizeOfForType(type).Invoke());
        }

        [Theory, MemberData(nameof(GetWinApiTypesData))]
        public static void MarshalSizeOfsEqualsThnetiiSizeOf(Type type)
        {
            var expected = GetMarshalSizeOfForType(type).Invoke();
            Assert.Equal(expected, InteropServices.NativeMemory.SizeOf.GetSizeOf(type).Bytes);
        }

        [Theory, MemberData(nameof(GetWinApiTypesData))]
        public static void MarshalSizeOfsEqualsUnsafeSizeOf(Type type)
        {
            var expected = GetMarshalSizeOfForType(type).Invoke();
            Assert.Equal(expected, GetUnsafeSizeOfForType(type).Invoke());
        }
    }
}

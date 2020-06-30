using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.Metadata;

using Xunit;

namespace THNETII.WinApi.Native.Test
{
    public static class SizeOfTest
    {
        private static readonly MethodInfo MarshalSizeOfGeneric = typeof(Marshal)
            .GetMethod(nameof(Marshal.SizeOf), genericParameterCount: 1, BindingFlags.Static | BindingFlags.Public, Type.DefaultBinder, Type.EmptyTypes, modifiers: null);

        private static Func<int> GetMarshalSizeOfForType(Type type) =>
            (Func<int>)MarshalSizeOfGeneric.MakeGenericMethod(type).CreateDelegate(typeof(Func<int>));

        private static readonly MethodInfo UnsafeSizeOfGeneric = typeof(Unsafe)
            .GetMethod(nameof(Unsafe.SizeOf), genericParameterCount: 1, BindingFlags.Static | BindingFlags.Public, Type.DefaultBinder, Type.EmptyTypes, modifiers: null);

        private static Func<int> GetUnsafeSizeOfForType(Type type) =>
            (Func<int>)UnsafeSizeOfGeneric.MakeGenericMethod(type).CreateDelegate(typeof(Func<int>));

        [Theory, MemberData(nameof(WinApiStructures.TypesMemberData), MemberType = typeof(WinApiStructures))]
        public static void WinApiTypeMarshalSizeOf(Type type)
        {
            Assert.NotEqual(0, GetMarshalSizeOfForType(type).Invoke());
        }

        [Theory, MemberData(nameof(WinApiStructures.TypesMemberData), MemberType = typeof(WinApiStructures))]
        public static void MarshalSizeOfsEqualsThnetiiSizeOf(Type type)
        {
            var expected = GetMarshalSizeOfForType(type).Invoke();
            Assert.Equal(expected, InteropServices.Memory.SizeOf.GetSizeOf(type).Bytes);
        }

        [Theory, MemberData(nameof(WinApiStructures.TypesMemberData), MemberType = typeof(WinApiStructures))]
        public static void MarshalSizeOfsEqualsUnsafeSizeOf(Type type)
        {
            var expected = GetMarshalSizeOfForType(type).Invoke();
            Assert.Equal(expected, GetUnsafeSizeOfForType(type).Invoke());
        }
    }
}

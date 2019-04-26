using System;
using System.Reflection;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.Metadata;

using Xunit;

namespace THNETII.WinApi.Native.Test
{
    public class RefStructTest
    {
        private static void AsRefStructImpl<T>() where T : struct
        {
            var size = SizeOf<T>.Default;
            var ptr = Marshal.AllocCoTaskMem(size.Bytes);
            Assert.NotEqual(IntPtr.Zero, ptr);
            try
            {
                Span<T> span = ptr.AsRefStructSpan<T>(count: 1);
                Span<T> copy = new T[1];
                span.CopyTo(copy);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        [Theory, MemberData(nameof(WinApiStructures.TypesMemberData), MemberType = typeof(WinApiStructures))]
        public void AsRefStruct(Type type)
        {
            var mi = typeof(RefStructTest).GetMethod(nameof(AsRefStructImpl), BindingFlags.NonPublic | BindingFlags.Static);
            Assert.True(mi.ContainsGenericParameters);
            mi.MakeGenericMethod(type).Invoke(null, null);
        }
    }
}

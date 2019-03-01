using System;
using THNETII.InteropServices.NativeMemory;
using Xunit;

namespace THNETII.WinApi.Native.Test
{
    public static class IntPtrOfGuidTest
    {
        [Fact]
        public static unsafe void CreateIntPtrOfNewGuid()
        {
            var guid = Guid.NewGuid();
            var ptrGuid = new IntPtr<Guid>(new IntPtr(&guid));
            Assert.Equal(guid, ptrGuid.Pointer.AsRefStruct<Guid>());
        }
    }
}

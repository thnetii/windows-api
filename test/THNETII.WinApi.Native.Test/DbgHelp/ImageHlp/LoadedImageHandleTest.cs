using Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp;
using Xunit;

namespace THNETII.WinApi.Native.Test.DbgHelp.ImageHlp
{
    public class LoadedImageHandleTest
    {
        private class MockupLoadedImageHandle : LoadedImageHandle
        {
            public MockupLoadedImageHandle() : base() { }
        }

        [Fact]
        public void LoadedImageHandleIsInvalidByDefault()
        {
            var handle = new MockupLoadedImageHandle();

            Assert.NotNull(handle);
            Assert.True(handle.IsInvalid);
        }
    }
}

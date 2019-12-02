using System.Runtime.InteropServices;

using Xunit;

namespace THNETII.WinApi.Native
{
    public class SkippableFactWindowsOSAttribute : SkippableFactAttribute
    {
        public SkippableFactWindowsOSAttribute()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                Skip = "Test case is only supported on Windows platforms";
        }
    }
}

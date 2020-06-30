using System.Runtime.InteropServices;

using Xunit;

namespace THNETII.WinApi.Native
{
    public class TheoryWindowsOSAttribute : TheoryAttribute
    {
        public TheoryWindowsOSAttribute() : base()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                Skip = "Test case is only supported on Windows platforms";
        }
    }
}

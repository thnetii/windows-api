using System.Runtime.InteropServices;

using Xunit;

namespace THNETII.WinApi.Native
{
    public class FactWindowsOSAttribute : FactAttribute
    {
        public FactWindowsOSAttribute() : base()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                Skip = "Test case is only supported on Windows platforms";
        }
    }
}

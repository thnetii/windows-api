using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetIntegratedDisplaySize
    {
        [FactWindowsOS(Skip = "Some information relates to pre-released product which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.")]
        public static void Can_call_extern_function()
        {
            HRESULT hr = GetIntegratedDisplaySize(out double inches);
            if (!hr.IsSuccess)
                throw Marshal.GetExceptionForHR(hr.Value);

            _ = inches;
        }
    }
}

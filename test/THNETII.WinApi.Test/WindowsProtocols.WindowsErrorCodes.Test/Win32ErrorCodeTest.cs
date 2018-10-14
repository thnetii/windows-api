using System.Collections.Generic;
using System.Linq;
using THNETII.WindowsProtocols.WindowsErrorCodes.Constants;

namespace THNETII.WindowsProtocols.WindowsErrorCodes.Test
{
    public static class Win32ErrorCodeTest
    {
        public static IEnumerable<object[]> GetHResultConstants()
        {
            return typeof(HResultConstants).GetFields()
                .Where(fi => fi.IsStatic && fi.IsLiteral)
                .Select(fi => new object[] { fi.Name, fi.GetValue(null) });
        }
    }
}

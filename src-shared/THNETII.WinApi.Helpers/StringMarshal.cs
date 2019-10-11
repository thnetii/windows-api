using System.Runtime.InteropServices;

namespace THNETII.WinApi.Helpers
{
    public static class StringMarshal
    {
        public const CharSet CharSetAuto =
#if NETSTANDARD1_3
            CharSet.Unicode
#else
            CharSet.Auto
#endif
            ;
        public const UnmanagedType LPTSTR =
#if NETSTANDARD1_3
            UnmanagedType.LPWStr
#else
            UnmanagedType.LPTStr
#endif
            ;

    }
}

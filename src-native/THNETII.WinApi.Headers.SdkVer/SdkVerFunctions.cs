namespace THNETII.WinApi.Native.SdkVer
{
    using static SdkVerConstants;

    public static class SdkVerFunctions
    {
        //
        // macros to extract various version fields from the NTDDI version
        //
        public static int OSVER(int Version) => ((Version) & OSVERSION_MASK);
        public static int SPVER(int Version) => (((Version) & SPVERSION_MASK) >> 8);
        public static int SUBVER(int Version) => (((Version) & SUBVERSION_MASK));
    }
}

namespace THNETII.WinApi.Native.WinBase
{
    using static WinNT.WinNTConstants;

    public static class WinBaseConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 1474
        public const int UMS_VERSION = RTL_UMS_VERSION;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 1823
        public const int SEM_FAILCRITICALERRORS = 0x0001;
        public const int SEM_NOGPFAULTERRORBOX = 0x0002;
        public const int SEM_NOALIGNMENTFAULTEXCEPT = 0x0004;
        public const int SEM_NOOPENFILEERRORBOX = 0x8000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 1992
        public const int HANDLE_FLAG_INHERIT = 0x00000001;
        public const int HANDLE_FLAG_PROTECT_FROM_CLOSE = 0x00000002;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 2380
        /// <summary>
        /// <see cref="FORMAT_MESSAGE_ALLOCATE_BUFFER"/> requires use of <see cref="HeapFree"/>
        /// </summary>
        public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 2450
        public const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200;
        public const int FORMAT_MESSAGE_FROM_STRING = 0x00000400;
        public const int FORMAT_MESSAGE_FROM_HMODULE = 0x00000800;
        public const int FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000;
        public const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000;
        public const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 0x000000FF;
    }
}

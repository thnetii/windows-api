namespace THNETII.WinApi.Native.FileApi
{
    public static class FileApiConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\fileapi.h, line 28
        //
        // Constants
        //
        public const int CREATE_NEW = 1;
        public const int CREATE_ALWAYS = 2;
        public const int OPEN_EXISTING = 3;
        public const int OPEN_ALWAYS = 4;
        public const int TRUNCATE_EXISTING = 5;

        public const int INVALID_FILE_SIZE = unchecked((int)0xFFFFFFFF);
        public const int INVALID_SET_FILE_POINTER = -1;
        public const int INVALID_FILE_ATTRIBUTES = -1;
    }
}

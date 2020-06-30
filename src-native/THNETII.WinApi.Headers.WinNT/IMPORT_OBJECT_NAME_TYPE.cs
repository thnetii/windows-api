namespace THNETII.WinApi.Native.WinNT
{
    public enum IMPORT_OBJECT_NAME_TYPE
    {
        /// <summary>
        /// Import by ordinal
        /// </summary>
        IMPORT_OBJECT_ORDINAL = 0,
        /// <summary>
        /// Import name == public symbol name.
        /// </summary>
        IMPORT_OBJECT_NAME = 1,
        /// <summary>
        /// Import name == public symbol name skipping leading ?, @, or optionally _.
        /// </summary>
        IMPORT_OBJECT_NAME_NO_PREFIX = 2,
        /// <summary>
        /// Import name == public symbol name skipping leading ?, @, or optionally _
        /// and truncating at first @.
        /// </summary>
        IMPORT_OBJECT_NAME_UNDECORATE = 3,
        /// <summary>
        /// Import name == a name is explicitly provided after the DLL name.
        /// </summary>
        IMPORT_OBJECT_NAME_EXPORTAS = 4,
    }
}

using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Type (fundamental) values.
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_SYM_TYPE : short
    {
        IMAGE_SYM_TYPE_NULL = WinNTConstants.IMAGE_SYM_TYPE_NULL,
        IMAGE_SYM_TYPE_VOID = WinNTConstants.IMAGE_SYM_TYPE_VOID,
        IMAGE_SYM_TYPE_CHAR = WinNTConstants.IMAGE_SYM_TYPE_CHAR,
        IMAGE_SYM_TYPE_SHORT = WinNTConstants.IMAGE_SYM_TYPE_SHORT,
        IMAGE_SYM_TYPE_INT = WinNTConstants.IMAGE_SYM_TYPE_INT,
        IMAGE_SYM_TYPE_LONG = WinNTConstants.IMAGE_SYM_TYPE_LONG,
        IMAGE_SYM_TYPE_FLOAT = WinNTConstants.IMAGE_SYM_TYPE_FLOAT,
        IMAGE_SYM_TYPE_DOUBLE = WinNTConstants.IMAGE_SYM_TYPE_DOUBLE,
        IMAGE_SYM_TYPE_STRUCT = WinNTConstants.IMAGE_SYM_TYPE_STRUCT,
        IMAGE_SYM_TYPE_UNION = WinNTConstants.IMAGE_SYM_TYPE_UNION,
        IMAGE_SYM_TYPE_ENUM = WinNTConstants.IMAGE_SYM_TYPE_ENUM,
        IMAGE_SYM_TYPE_MOE = WinNTConstants.IMAGE_SYM_TYPE_MOE,
        IMAGE_SYM_TYPE_BYTE = WinNTConstants.IMAGE_SYM_TYPE_BYTE,
        IMAGE_SYM_TYPE_WORD = WinNTConstants.IMAGE_SYM_TYPE_WORD,
        IMAGE_SYM_TYPE_UINT = WinNTConstants.IMAGE_SYM_TYPE_UINT,
        IMAGE_SYM_TYPE_DWORD = WinNTConstants.IMAGE_SYM_TYPE_DWORD,
        IMAGE_SYM_TYPE_PCODE = WinNTConstants.IMAGE_SYM_TYPE_PCODE,
    }
}

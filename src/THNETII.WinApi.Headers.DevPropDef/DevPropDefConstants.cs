namespace THNETII.WinApi.Native.DevPropDef
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h
    /// <summary>
    /// Defines constants for the Plug and Play Device Property API.
    /// </summary>
    public static class DevPropDefConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 35
        //
        // Property type modifiers.  Used to modify base DEVPROP_TYPE_ values, as
        // appropriate.  Not valid as standalone DEVPROPTYPE values.
        //
        public const int DEVPROP_TYPEMOD_ARRAY = 0x00001000;  // array of fixed-sized data elements
        public const int DEVPROP_TYPEMOD_LIST = 0x00002000;  // list of variable-sized data elements

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 42
        //
        // Property data types.
        //
        public const int DEVPROP_TYPE_EMPTY = 0x00000000; // nothing, no property data
        public const int DEVPROP_TYPE_NULL = 0x00000001; // null property data
        public const int DEVPROP_TYPE_SBYTE = 0x00000002; // 8-bit signed int (SBYTE)
        public const int DEVPROP_TYPE_BYTE = 0x00000003; // 8-bit unsigned int (BYTE)
        public const int DEVPROP_TYPE_INT16 = 0x00000004; // 16-bit signed int (SHORT)
        public const int DEVPROP_TYPE_UINT16 = 0x00000005; // 16-bit unsigned int (USHORT)
        public const int DEVPROP_TYPE_INT32 = 0x00000006; // 32-bit signed int (LONG)
        public const int DEVPROP_TYPE_UINT32 = 0x00000007; // 32-bit unsigned int (ULONG)
        public const int DEVPROP_TYPE_INT64 = 0x00000008; // 64-bit signed int (LONG64)
        public const int DEVPROP_TYPE_UINT64 = 0x00000009; // 64-bit unsigned int (ULONG64)
        public const int DEVPROP_TYPE_FLOAT = 0x0000000A; // 32-bit floating-point (FLOAT)
        public const int DEVPROP_TYPE_DOUBLE = 0x0000000B; // 64-bit floating-point (DOUBLE)
        public const int DEVPROP_TYPE_DECIMAL = 0x0000000C; // 128-bit data (DECIMAL)
        public const int DEVPROP_TYPE_GUID = 0x0000000D; // 128-bit unique identifier (GUID)
        public const int DEVPROP_TYPE_CURRENCY = 0x0000000E; // 64 bit signed int currency value (CURRENCY)
        public const int DEVPROP_TYPE_DATE = 0x0000000F; // date (DATE)
        public const int DEVPROP_TYPE_FILETIME = 0x00000010; // file time (FILETIME)
        public const int DEVPROP_TYPE_BOOLEAN = 0x00000011; // 8-bit boolean (DEVPROP_BOOLEAN)
        public const int DEVPROP_TYPE_STRING = 0x00000012; // null-terminated string
        public const int DEVPROP_TYPE_STRING_LIST = (DEVPROP_TYPE_STRING | DEVPROP_TYPEMOD_LIST); // multi-sz string list
        public const int DEVPROP_TYPE_SECURITY_DESCRIPTOR = 0x00000013; // self-relative binary SECURITY_DESCRIPTOR
        public const int DEVPROP_TYPE_SECURITY_DESCRIPTOR_STRING = 0x00000014; // security descriptor string (SDDL format)
        public const int DEVPROP_TYPE_DEVPROPKEY = 0x00000015; // device property key (DEVPROPKEY)
        public const int DEVPROP_TYPE_DEVPROPTYPE = 0x00000016; // device property type (DEVPROPTYPE)
        public const int DEVPROP_TYPE_BINARY = (DEVPROP_TYPE_BYTE | DEVPROP_TYPEMOD_ARRAY); // custom binary data
        public const int DEVPROP_TYPE_ERROR = 0x00000017; // 32-bit Win32 system error code
        public const int DEVPROP_TYPE_NTSTATUS = 0x00000018; // 32-bit NTSTATUS code
        public const int DEVPROP_TYPE_STRING_INDIRECT = 0x00000019; // string resource (@[path\]<dllname>,-<strId>)

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 74
        //
        // Max base DEVPROP_TYPE_ and DEVPROP_TYPEMOD_ values.
        //
        public const int MAX_DEVPROP_TYPE = 0x00000019; // max valid DEVPROP_TYPE_ value
        public const int MAX_DEVPROP_TYPEMOD = 0x00002000; // max valid DEVPROP_TYPEMOD_ value

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 80
        //
        // Bitmasks for extracting DEVPROP_TYPE_ and DEVPROP_TYPEMOD_ values.
        //
        public const int DEVPROP_MASK_TYPE = 0x00000FFF; // range for base DEVPROP_TYPE_ values
        public const int DEVPROP_MASK_TYPEMOD = 0x0000F000; // mask for DEVPROP_TYPEMOD_ type modifiers

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 87
        //
        // Property type specific data types.
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 91
        public const byte DEVPROP_TRUE = unchecked((byte)-1);
        public const byte DEVPROP_FALSE = 0;
    }
}

using System;

namespace THNETII.WinApi.Native.DevPropDef
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 28
    /// <summary>
    /// Type definition for property data types.  Valid <see cref="DEVPROPTYPE"/> values are
    /// constructed from base <strong>DEVPROP_TYPE_</strong> values, which may be modified by a
    /// logical OR with <strong>DEVPROP_TYPEMOD_</strong> values, as appropriate.
    /// </summary>
    [Flags]
    public enum DEVPROPTYPE : uint
    {
        /// <summary>
        /// array of fixed-sized data elements
        /// <para>
        /// Property type modifiers.  Used to modify base <strong>DEVPROP_TYPE_</strong> values, as
        /// appropriate.  Not valid as standalone <see cref="DEVPROPTYPE"/> values.
        /// </para>
        /// </summary>
        DEVPROP_TYPEMOD_ARRAY = DevPropDefConstants.DEVPROP_TYPEMOD_ARRAY,
        /// <summary>
        /// list of variable-sized data elements
        /// <para>
        /// Property type modifiers.  Used to modify base <strong>DEVPROP_TYPE_</strong> values, as
        /// appropriate.  Not valid as standalone <see cref="DEVPROPTYPE"/> values.
        /// </para>
        /// </summary>
        DEVPROP_TYPEMOD_LIST = DevPropDefConstants.DEVPROP_TYPEMOD_LIST,

        //
        // Property data types.
        //
        /// <summary>
        /// nothing, no property data
        /// </summary>
        DEVPROP_TYPE_EMPTY = DevPropDefConstants.DEVPROP_TYPE_EMPTY,
        /// <summary>
        /// null property data
        /// </summary>
        DEVPROP_TYPE_NULL = DevPropDefConstants.DEVPROP_TYPE_NULL,
        /// <summary>
        /// 8-bit signed int (SBYTE)
        /// </summary>
        DEVPROP_TYPE_SBYTE = DevPropDefConstants.DEVPROP_TYPE_SBYTE,
        /// <summary>
        /// 8-bit unsigned int (BYTE)
        /// </summary>
        DEVPROP_TYPE_BYTE = DevPropDefConstants.DEVPROP_TYPE_BYTE,
        /// <summary>
        /// 16-bit signed int (SHORT)
        /// </summary>
        DEVPROP_TYPE_INT16 = DevPropDefConstants.DEVPROP_TYPE_INT16,
        /// <summary>
        /// 16-bit unsigned int (USHORT)
        /// </summary>
        DEVPROP_TYPE_UINT16 = DevPropDefConstants.DEVPROP_TYPE_UINT16,
        /// <summary>
        /// 32-bit signed int (LONG)
        /// </summary>
        DEVPROP_TYPE_INT32 = DevPropDefConstants.DEVPROP_TYPE_INT32,
        /// <summary>
        /// 32-bit unsigned int (ULONG)
        /// </summary>
        DEVPROP_TYPE_UINT32 = DevPropDefConstants.DEVPROP_TYPE_UINT32,
        /// <summary>
        /// 64-bit signed int (LONG64)
        /// </summary>
        DEVPROP_TYPE_INT64 = DevPropDefConstants.DEVPROP_TYPE_INT64,
        /// <summary>
        /// 64-bit unsigned int (ULONG64)
        /// </summary>
        DEVPROP_TYPE_UINT64 = DevPropDefConstants.DEVPROP_TYPE_UINT64,
        /// <summary>
        /// 32-bit floating-point (FLOAT)
        /// </summary>
        DEVPROP_TYPE_FLOAT = DevPropDefConstants.DEVPROP_TYPE_FLOAT,
        /// <summary>
        /// 64-bit floating-point (DOUBLE)
        /// </summary>
        DEVPROP_TYPE_DOUBLE = DevPropDefConstants.DEVPROP_TYPE_DOUBLE,
        /// <summary>
        /// 128-bit data (DECIMAL)
        /// </summary>
        DEVPROP_TYPE_DECIMAL = DevPropDefConstants.DEVPROP_TYPE_DECIMAL,
        /// <summary>
        /// 128-bit unique identifier (GUID)
        /// </summary>
        DEVPROP_TYPE_GUID = DevPropDefConstants.DEVPROP_TYPE_GUID,
        /// <summary>
        /// 64 bit signed int currency value (CURRENCY)
        /// </summary>
        DEVPROP_TYPE_CURRENCY = DevPropDefConstants.DEVPROP_TYPE_CURRENCY,
        /// <summary>
        /// date (DATE)
        /// </summary>
        DEVPROP_TYPE_DATE = DevPropDefConstants.DEVPROP_TYPE_DATE,
        /// <summary>
        /// file time (FILETIME)
        /// </summary>
        DEVPROP_TYPE_FILETIME = DevPropDefConstants.DEVPROP_TYPE_FILETIME,
        /// <summary>
        /// 8-bit boolean (DEVPROP_BOOLEAN)
        /// </summary>
        DEVPROP_TYPE_BOOLEAN = DevPropDefConstants.DEVPROP_TYPE_BOOLEAN,
        /// <summary>
        /// null-terminated string
        /// </summary>
        DEVPROP_TYPE_STRING = DevPropDefConstants.DEVPROP_TYPE_STRING,
        /// <summary>
        /// multi-sz string list
        /// </summary>
        DEVPROP_TYPE_STRING_LIST = DevPropDefConstants.DEVPROP_TYPE_STRING_LIST,
        /// <summary>
        /// self-relative binary SECURITY_DESCRIPTOR
        /// </summary>
        DEVPROP_TYPE_SECURITY_DESCRIPTOR = DevPropDefConstants.DEVPROP_TYPE_SECURITY_DESCRIPTOR,
        /// <summary>
        /// security descriptor string (SDDL format)
        /// </summary>
        DEVPROP_TYPE_SECURITY_DESCRIPTOR_STRING = DevPropDefConstants.DEVPROP_TYPE_SECURITY_DESCRIPTOR_STRING,
        /// <summary>
        /// device property key (DEVPROPKEY)
        /// </summary>
        DEVPROP_TYPE_DEVPROPKEY = DevPropDefConstants.DEVPROP_TYPE_DEVPROPKEY,
        /// <summary>
        /// device property type (DEVPROPTYPE)
        /// </summary>
        DEVPROP_TYPE_DEVPROPTYPE = DevPropDefConstants.DEVPROP_TYPE_DEVPROPTYPE,
        /// <summary>
        /// custom binary data
        /// </summary>
        DEVPROP_TYPE_BINARY = DevPropDefConstants.DEVPROP_TYPE_BINARY,
        /// <summary>
        /// 32-bit Win32 system error code
        /// </summary>
        DEVPROP_TYPE_ERROR = DevPropDefConstants.DEVPROP_TYPE_ERROR,
        /// <summary>
        /// 32-bit NTSTATUS code
        /// </summary>
        DEVPROP_TYPE_NTSTATUS = DevPropDefConstants.DEVPROP_TYPE_NTSTATUS,
        /// <summary>
        /// string resource (@[path\]&lt;dllname&gt;,-&lt;strId&gt;)
        /// </summary>
        DEVPROP_TYPE_STRING_INDIRECT = DevPropDefConstants.DEVPROP_TYPE_STRING_INDIRECT,

        //
        // Max base DEVPROP_TYPE_ and DEVPROP_TYPEMOD_ values.
        //
        /// <summary>
        /// max valid DEVPROP_TYPE_ value
        /// </summary>
        MAX_DEVPROP_TYPE = DevPropDefConstants.MAX_DEVPROP_TYPE,
        /// <summary>
        /// max valid DEVPROP_TYPEMOD_ value
        /// </summary>
        MAX_DEVPROP_TYPEMOD = DevPropDefConstants.MAX_DEVPROP_TYPEMOD,

        //
        // Bitmasks for extracting DEVPROP_TYPE_ and DEVPROP_TYPEMOD_ values.
        //
        /// <summary>
        /// range for base DEVPROP_TYPE_ values
        /// </summary>
        DEVPROP_MASK_TYPE = DevPropDefConstants.DEVPROP_MASK_TYPE,
        /// <summary>
        /// mask for DEVPROP_TYPEMOD_ type modifiers
        /// </summary>
        DEVPROP_MASK_TYPEMOD = DevPropDefConstants.DEVPROP_MASK_TYPEMOD,
    }
}

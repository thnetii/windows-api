using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHelp
{
    /// <summary>
    /// Represents the data directory.
    /// </summary>
    /// <remarks>
    /// The following is a list of the data directories. Offsets are relative to the beginning of the optional header.
    /// <list type="table">
    /// <listheader><term>Offset (PE/PE32+)</term> <description>Description</description></listheader>
    /// <item><term>96/112</term> <description>Export table address and size</description></item>
    /// <item><term>104/120</term> <description>Import table address and size</description></item>
    /// <item><term>112/128</term> <description>Resource table address and size</description></item>
    /// <item><term>120/136</term> <description>Exception table address and size</description></item>
    /// <item><term>128/144</term> <description>Certificate table address and size</description></item>
    /// <item><term>136/152</term> <description>Base relocation table address and size</description></item>
    /// <item><term>144/160</term> <description>Debugging information starting address and size</description></item>
    /// <item><term>152/168</term> <description>Architecture-specific data address and size</description></item>
    /// <item><term>160/176</term> <description>Global pointer register relative virtual address</description></item>
    /// <item><term>168/184</term> <description>Thread local storage (TLS) table address and size</description></item>
    /// <item><term>176/192</term> <description>Load configuration table address and size</description></item>
    /// <item><term>184/200</term> <description>Bound import table address and size</description></item>
    /// <item><term>192/208</term> <description>Import address table address and size</description></item>
    /// <item><term>200/216</term> <description>Delay import descriptor address and size</description></item>
    /// <item><term>208/224</term> <description>The CLR header address and size</description></item>
    /// <item><term>216/232</term> <description>Reserved</description></item>
    /// </list>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680305.aspx">IMAGE_DATA_DIRECTORY structure</a></para>
    /// </remarks>
    /// <seealso cref="IMAGE_OPTIONAL_HEADER32"/>
    /// <seealso cref="IMAGE_OPTIONAL_HEADER64"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_DATA_DIRECTORY
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const int IMAGE_NUMBEROF_DIRECTORY_ENTRIES = 16;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>Export Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_EXPORT = 0;
        /// <summary>Import Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_IMPORT = 1;
        /// <summary>Resource Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_RESOURCE = 2;
        /// <summary>Exception Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_EXCEPTION = 3;
        /// <summary>Security Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_SECURITY = 4;
        /// <summary>Base Relocation Table</summary>
        public const int IMAGE_DIRECTORY_ENTRY_BASERELOC = 5;
        /// <summary>Debug Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_DEBUG = 6;
        /// <summary>(X86 usage)</summary>
        public const int IMAGE_DIRECTORY_ENTRY_COPYRIGHT = 7;
        /// <summary>Architecture Specific Data</summary>
        public const int IMAGE_DIRECTORY_ENTRY_ARCHITECTURE = 7;
        /// <summary>RVA of GP</summary>
        public const int IMAGE_DIRECTORY_ENTRY_GLOBALPTR = 8;
        /// <summary>TLS Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_TLS = 9;
        /// <summary>Load Configuration Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_LOAD_CONFIG = 10;
        /// <summary>Bound Import Directory in headers</summary>
        public const int IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT = 11;
        /// <summary>Import Address Table</summary>
        public const int IMAGE_DIRECTORY_ENTRY_IAT = 12;
        /// <summary>Delay Load Import Descriptors</summary>
        public const int IMAGE_DIRECTORY_ENTRY_DELAY_IMPORT = 13;
        /// <summary>COM Runtime descriptor</summary>
        public const int IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR = 14;

        /// <summary>The relative virtual address of the table.</summary>
        public int VirtualAddress;
        /// <summary>The size of the table, in bytes.</summary>
        public int Size;
    }
}

using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16415
    /// <summary>
    /// Represents the data directory.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The following is a list of the data directories. Offsets are relative to the beginning of the optional header.
    /// <list type="table">
    /// <listheader><term>Offset (PE/PE32+)</term><description>Description</description></listheader>
    /// <item><term>96/112</term><description>Export table address and size</description></item>
    /// <item><term>104/120</term><description>Import table address and size</description></item>
    /// <item><term>112/128</term><description>Resource table address and size</description></item>
    /// <item><term>120/136</term><description>Exception table address and size</description></item>
    /// <item><term>128/144</term><description>Certificate table address and size</description></item>
    /// <item><term>136/152</term><description>Base relocation table address and size</description></item>
    /// <item><term>144/160</term><description>Debugging information starting address and size</description></item>
    /// <item><term>152/168</term><description>Architecture-specific data address and size</description></item>
    /// <item><term>160/176</term><description>Global pointer register relative virtual address</description></item>
    /// <item><term>168/184</term><description>Thread local storage (TLS) table address and size</description></item>
    /// <item><term>176/192</term><description>Load configuration table address and size</description></item>
    /// <item><term>184/200</term><description>Bound import table address and size</description></item>
    /// <item><term>192/208</term><description>Import address table address and size</description></item>
    /// <item><term>200/216</term><description>Delay import descriptor address and size</description></item>
    /// <item><term>208/224</term><description>The CLR header address and size</description></item>
    /// <item><term>216/232</term><description>Reserved</description></item>
    /// </list>
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-image_data_directory">IMAGE_DATA_DIRECTORY structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_DATA_DIRECTORY
    {
        internal const int SizeOf = sizeof(int) * 2;

        /// <summary>
        /// The relative virtual address of the table.
        /// </summary>
        public int VirtualAddress;
        /// <summary>
        /// The size of the table, in bytes.
        /// </summary>
        public int Size;
    }
}

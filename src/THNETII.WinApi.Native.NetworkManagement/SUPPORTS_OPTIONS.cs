using System;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Mask bits for use with <see cref="NetRemoteComputerSupports"/>
    /// </summary>
    [Flags]
    public enum SUPPORTS_OPTIONS : int
    {
        /// <summary>Requests Remote Administration Protocol support.</summary>
        SUPPORTS_REMOTE_ADMIN_PROTOCOL = 0x00000002,
        /// <summary>Requests RPC support.</summary>
        SUPPORTS_RPC = 0x00000004,
        /// <summary>Requests Security Account Manager (SAM) support.</summary>
        SUPPORTS_SAM_PROTOCOL = 0x00000008,
        /// <summary>Requests Unicode standard support.</summary>
        SUPPORTS_UNICODE = 0x00000010,
        /// <summary>Requests support for the first three values listed in this table.</summary>
        SUPPORTS_LOCAL = 0x00000020,
        SUPPORTS_ANY = unchecked((int)0xFFFFFFFF),
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
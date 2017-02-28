using System;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Equate for use with <see cref="SERVER_TRANSPORT_INFO_2.svti2_flags"/> in <see cref="NetServerTransportAddEx"/>.
    /// </summary>
    [Flags]
    public enum SVTI2_FLAGS : int
    {
        /// <summary>
        /// If this value is set for an endpoint, client requests arriving over the transport to open a named pipe are rerouted (remapped) to the following local pipe name:<br/>
        /// <strong>$$\ServerName\PipeName</strong>
        /// </summary>
        SVTI2_REMAP_PIPE_NAMES = 0x02,
        /// <summary>If this value is set for an endpoint and there is an attempt to create a second transport with the same network address but a different transport name and conflicting settings for the SCOPED flag, this transport creation will fail. Thus, every registered transport for a given network address must have the same scoped setting.</summary>
        SVTI2_SCOPED_NAME = 0x04,
    }
}
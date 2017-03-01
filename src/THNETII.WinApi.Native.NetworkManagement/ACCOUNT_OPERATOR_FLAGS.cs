using System;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Bit masks for field <see cref="USER_INFO_2.usri2_auth_flags"/> of <see cref="USER_INFO_2"/>.
    /// </summary>
    [Flags]
    public enum ACCOUNT_OPERATOR_FLAGS : int
    {
        /// <summary>The print operator privilege is enabled.</summary>
        AF_OP_PRINT = 0x1,
        /// <summary>The communications operator privilege is enabled.</summary>
        AF_OP_COMM = 0x2,
        /// <summary>The server operator privilege is enabled.</summary>
        AF_OP_SERVER = 0x4,
        /// <summary>The accounts operator privilege is enabled.</summary>
        AF_OP_ACCOUNTS = 0x8,
        AF_SETTABLE_BITS = (AF_OP_PRINT | AF_OP_COMM | AF_OP_SERVER | AF_OP_ACCOUNTS)
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
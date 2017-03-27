using Microsoft.Win32.WinApi.Networking.NetworkManagement;
using System;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.ACCOUNT_OPERATOR_FLAGS;

namespace THNETII.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// User operator priviliges.
    /// </summary>
    [Flags]
    public enum NetUserOperatorPrivilege : int
    {
        /// <summary>The print operator privilege is enabled.</summary>
        PrintOperator = AF_OP_PRINT,
        /// <summary>The communications operator privilege is enabled.</summary>
        CommunicationsOperator = AF_OP_COMM,
        /// <summary>The server operator privilege is enabled.</summary>
        ServerOperator = AF_OP_SERVER,
        /// <summary>The accounts operator privilege is enabled.</summary>
        AccountsOperator = AF_OP_ACCOUNTS,
        SettableBits = AF_SETTABLE_BITS
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    internal static class NetUserOperatorPrivilegeExtensions
    {
        public static NetUserOperatorPrivilege AsManaged(this ACCOUNT_OPERATOR_FLAGS value) => (NetUserOperatorPrivilege)value;
        public static ACCOUNT_OPERATOR_FLAGS AsNative(this NetUserOperatorPrivilege value) => (ACCOUNT_OPERATOR_FLAGS)value;
    }
}
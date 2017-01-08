using System;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [Flags]
    public enum NET_VALIDATE_FIELDS : int
    {
        /// <summary>
        /// The <see cref="NET_VALIDATE_PERSISTED_FIELDS.PasswordLastSet"/> member contains a new value.
        /// </summary>
        NET_VALIDATE_PASSWORD_LAST_SET = 0x00000001,
        /// <summary>
        /// The <see cref="NET_VALIDATE_PERSISTED_FIELDS.BadPasswordTime"/> member contains a new value.
        /// </summary>
        NET_VALIDATE_BAD_PASSWORD_TIME = 0x00000002,
        /// <summary>
        /// The <see cref="NET_VALIDATE_PERSISTED_FIELDS.LockoutTime"/> member contains a new value.
        /// </summary>
        NET_VALIDATE_LOCKOUT_TIME = 0x00000004,
        /// <summary>
        /// The <see cref="NET_VALIDATE_PERSISTED_FIELDS.BadPasswordCount"/> member contains a new value.
        /// </summary>
        NET_VALIDATE_BAD_PASSWORD_COUNT = 0x00000008,
        /// <summary>
        /// The <see cref="NET_VALIDATE_PERSISTED_FIELDS.PasswordHistoryLength"/> member contains a new value.
        /// </summary>
        NET_VALIDATE_PASSWORD_HISTORY_LENGTH = 0x00000010,
        /// <summary>
        /// The <see cref="NET_VALIDATE_PERSISTED_FIELDS.PasswordHistory"/> member contains a new value.
        /// </summary>
        NET_VALIDATE_PASSWORD_HISTORY = 0x00000020,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

using System;

namespace THNETII.WinApiNative.ActiveDirectoryDomainServices
{
    /// <summary>
    /// Replica Modify flags
    /// </summary>
    [Flags]
    public enum DS_REPMOD_FLAGS : uint
    {
        /// <summary>Perform this operation asynchronously.</summary>
        DS_REPMOD_ASYNCHRONOUS_OPERATION = unchecked((uint)0x00000001),

        /// <summary>The replica is writeable.</summary>
        DS_REPMOD_WRITEABLE = unchecked((uint)0x00000002),
    }
}

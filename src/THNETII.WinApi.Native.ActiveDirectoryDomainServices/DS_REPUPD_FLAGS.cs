using System;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// Update Refs flags
    /// </summary>
    [Flags]
    public enum DS_REPUPD_FLAGS : uint
    {
        /// <summary>Perform this operation asynchronously.</summary>
        DS_REPUPD_ASYNCHRONOUS_OPERATION = unchecked(0x00000001),

        /// <summary>The replica being deleted is writeable.</summary>
        DS_REPUPD_WRITEABLE = unchecked(0x00000002),

        /// <summary>Add a reference</summary>
        DS_REPUPD_ADD_REFERENCE = unchecked(0x00000004),

        /// <summary>Remove a reference</summary>
        DS_REPUPD_DELETE_REFERENCE = unchecked(0x00000008),

        /// <summary>Use GCSPN while notifying replica partner</summary>
        DS_REPUPD_REFERENCE_GCSPN = unchecked(0x00000010),
    }
}

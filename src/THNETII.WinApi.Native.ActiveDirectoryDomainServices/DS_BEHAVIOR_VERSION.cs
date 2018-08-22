using System;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Following constants define the Active Directory Behavior
    /// Version numbers.
    /// </summary>
    public enum DS_BEHAVIOR_VERSION
    {
        DS_BEHAVIOR_WIN2000 = 0,
        DS_BEHAVIOR_WIN2003_WITH_MIXED_DOMAINS = 1,
        DS_BEHAVIOR_WIN2003 = 2,
        DS_BEHAVIOR_WIN2008 = 3,
        DS_BEHAVIOR_WIN2008R2 = 4,
        DS_BEHAVIOR_WIN2012 = 5,
        DS_BEHAVIOR_WIN2012R2 = 6,
        DS_BEHAVIOR_WIN2016 = 7,

        // Deprecated constants
        [Obsolete("Deprecated constant, use " + nameof(DS_BEHAVIOR_WIN2008) + " instead.")]
        DS_BEHAVIOR_LONGHORN = DS_BEHAVIOR_WIN2008,
        [Obsolete("Deprecated constant, use " + nameof(DS_BEHAVIOR_WIN2008R2) + " instead.")]
        DS_BEHAVIOR_WIN7 = DS_BEHAVIOR_WIN2008R2,
        [Obsolete("Deprecated constant, use " + nameof(DS_BEHAVIOR_WIN2012) + " instead.")]
        DS_BEHAVIOR_WIN8 = DS_BEHAVIOR_WIN2012,
        [Obsolete("Deprecated constant, use " + nameof(DS_BEHAVIOR_WIN2012R2) + " instead.")]
        DS_BEHAVIOR_WINBLUE = DS_BEHAVIOR_WIN2012R2,
        [Obsolete("Deprecated constant, use " + nameof(DS_BEHAVIOR_WIN2016) + " instead.")]
        DS_BEHAVIOR_WINTHRESHOLD = DS_BEHAVIOR_WIN2016,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

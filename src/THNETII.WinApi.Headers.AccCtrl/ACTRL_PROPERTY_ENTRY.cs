using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 438
    /// <inheritdoc cref="ACTRL_PROPERTY_ENTRY" />
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct ACTRL_PROPERTY_ENTRYA
    {
        /// <inheritdoc cref="ACTRL_PROPERTY_ENTRY.lpProperty"/>
        public LPSTR lpProperty;
        /// <inheritdoc cref="ACTRL_PROPERTY_ENTRY.pAccessEntryList"/>
        public ACTRL_ACCESS_ENTRY_LISTA* pAccessEntryList;
        /// <inheritdoc cref="ACTRL_PROPERTY_ENTRY.fListFlags"/>
        [MarshalAs(UnmanagedType.U4)]
        public PROPERTY_ACCESS_FLAGS fListFlags;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 444
    /// <inheritdoc cref="ACTRL_PROPERTY_ENTRY" />
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct ACTRL_PROPERTY_ENTRYW
    {
        /// <inheritdoc cref="ACTRL_PROPERTY_ENTRY.lpProperty"/>
        public LPWSTR lpProperty;
        /// <inheritdoc cref="ACTRL_PROPERTY_ENTRY.pAccessEntryList"/>
        public ACTRL_ACCESS_ENTRY_LISTW* pAccessEntryList;
        /// <inheritdoc cref="ACTRL_PROPERTY_ENTRY.fListFlags"/>
        [MarshalAs(UnmanagedType.U4)]
        public PROPERTY_ACCESS_FLAGS fListFlags;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 450
    /// <summary>
    /// Contains a list of access-control entries for an object or a specified property on an object.
    /// </summary>
    /// <remarks>
    /// <para>To create an <see cref="ACTRL_PROPERTY_ENTRY"/> structure that grants everyone full access to an object, set the <see cref="pAccessEntryList"/> member to <see langword="null"/>.</para>
    /// <para>To create an <see cref="ACTRL_PROPERTY_ENTRY"/> structure that denies all access to an object, set the <see cref="pAccessEntryList"/> member to point to an <see cref="ACTRL_ACCESS_ENTRY_LIST"/> structure whose <see cref="ACTRL_ACCESS_ENTRY_LIST.cEntries"/> member is <c>0</c> and <see cref="ACTRL_ACCESS_ENTRY_LIST.pAccessList"/> member is <see langword="null"/>.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ns-accctrl-actrl_property_entryw">ACTRL_PROPERTY_ENTRYW structure</a></para>
    /// </remarks>
    /// <seealso cref="ACTRL_ACCESS_ENTRY_LIST"/>
#if !NETSTANDARD1_6
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif
    public unsafe struct ACTRL_PROPERTY_ENTRY
    {
        /// <summary>
        /// The string representation of the GUID of a property on an object.
        /// </summary>
        public LPTSTR lpProperty;
        /// <summary>
        /// A pointer to an <see cref="ACTRL_ACCESS_ENTRY_LIST"/> structure that contains a list of access-control entries.
        /// </summary>
        public ACTRL_ACCESS_ENTRY_LIST* pAccessEntryList;
        /// <summary>
        /// Flags that specify information about the <see cref="lpProperty"/> property.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public PROPERTY_ACCESS_FLAGS fListFlags;
    }
}

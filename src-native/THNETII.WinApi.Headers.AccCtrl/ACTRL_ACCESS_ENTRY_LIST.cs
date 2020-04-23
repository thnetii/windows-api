using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 412
    /// <inheritdoc cref="ACTRL_ACCESS_ENTRY_LIST" />
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct ACTRL_ACCESS_ENTRY_LISTA
    {
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY_LIST.cEntries"/>
        public int cEntries;
        internal ACTRL_ACCESS_ENTRYA* pAccessList;
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY_LIST.AccessList"/>
        public Span<ACTRL_ACCESS_ENTRYA> AccessList
        {
            get => new Span<ACTRL_ACCESS_ENTRYA>(pAccessList, cEntries);
            set
            {
                fixed (ACTRL_ACCESS_ENTRYA* pValue = value)
                {
                    pAccessList = pValue;
                    cEntries = value.Length;
                }
            }
        }
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 420
    /// <inheritdoc cref="ACTRL_ACCESS_ENTRY_LIST" />
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct ACTRL_ACCESS_ENTRY_LISTW
    {
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY_LIST.cEntries"/>
        public int cEntries;
        internal ACTRL_ACCESS_ENTRYW* pAccessList;
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY_LIST.AccessList"/>
        public Span<ACTRL_ACCESS_ENTRYW> AccessList
        {
            get => new Span<ACTRL_ACCESS_ENTRYW>(pAccessList, cEntries);
            set
            {
                fixed (ACTRL_ACCESS_ENTRYW* pValue = value)
                {
                    pAccessList = pValue;
                    cEntries = value.Length;
                }
            }
        }
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 428
    /// <summary>
    /// Contains a list of access entries.
    /// </summary>
    /// <remarks>
    /// <para>An empty list does not grant access to any trustee, and thus, denies all access to an object.</para>
    /// <para>To create a null access list, set the <see cref="ACTRL_PROPERTY_ENTRY.pAccessEntryList"/> member of the <see cref="ACTRL_PROPERTY_ENTRY"/> structure to <see langword="null"/>. A null access list grants everyone full access to the object.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ns-accctrl-actrl_access_entry_listw">ACTRL_ACCESS_ENTRY_LISTW structure</a></para>
    /// </remarks>
    /// <seealso cref="ACTRL_PROPERTY_ENTRY"/>
#if !NETSTANDARD1_6
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif
    public unsafe struct ACTRL_ACCESS_ENTRY_LIST
    {
        /// <summary>
        /// The number of entries in the <see cref="AccessList"/> span.
        /// </summary>
        public int cEntries;
        internal ACTRL_ACCESS_ENTRY* pAccessList;
        /// <summary>
        /// A span of <see cref="ACTRL_ACCESS_ENTRY"/> structures. Each structure specifies access-control information for a specified trustee.
        /// </summary>
        public Span<ACTRL_ACCESS_ENTRY> AccessList
        {
            get => new Span<ACTRL_ACCESS_ENTRY>(pAccessList, cEntries);
            set
            {
                fixed (ACTRL_ACCESS_ENTRY* pValue = value)
                {
                    pAccessList = pValue;
                    cEntries = value.Length;
                }
            }
        }
    }
}

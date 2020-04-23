using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 460
    /// <inheritdoc cref="ACTRL_ALIST" />
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct ACTRL_ALISTA
    {
        /// <inheritdoc cref="ACTRL_ALIST.cEntries"/>
        public int cEntries;
        internal ACTRL_PROPERTY_ENTRYA* pPropertyAccessList;
        /// <inheritdoc cref="ACTRL_ALIST.pPropertyAccessList"/>
        public Span<ACTRL_PROPERTY_ENTRYA> PropertyAccessList
        {
            get => new Span<ACTRL_PROPERTY_ENTRYA>(pPropertyAccessList, cEntries);
            set
            {
                fixed (ACTRL_PROPERTY_ENTRYA* pValue = value)
                {
                    pPropertyAccessList = pValue;
                    cEntries = value.Length;
                }
            }
        }
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 468
    /// <inheritdoc cref="ACTRL_ALIST" />
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct ACTRL_ALISTW
    {
        /// <inheritdoc cref="ACTRL_ALIST.cEntries"/>
        public int cEntries;
        internal ACTRL_PROPERTY_ENTRYW* pPropertyAccessList;
        /// <inheritdoc cref="ACTRL_ALIST.pPropertyAccessList"/>
        public Span<ACTRL_PROPERTY_ENTRYW> PropertyAccessList
        {
            get => new Span<ACTRL_PROPERTY_ENTRYW>(pPropertyAccessList, cEntries);
            set
            {
                fixed (ACTRL_PROPERTY_ENTRYW* pValue = value)
                {
                    pPropertyAccessList = pValue;
                    cEntries = value.Length;
                }
            }
        }
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 476
#if !NETSTANDARD1_6
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif
    public unsafe struct ACTRL_ALIST
    {
        public int cEntries;
        internal ACTRL_PROPERTY_ENTRY* pPropertyAccessList;
        public Span<ACTRL_PROPERTY_ENTRY> PropertyAccessList
        {
            get => new Span<ACTRL_PROPERTY_ENTRY>(pPropertyAccessList, cEntries);
            set
            {
                fixed (ACTRL_PROPERTY_ENTRY* pValue = value)
                {
                    pPropertyAccessList = pValue;
                    cEntries = value.Length;
                }
            }
        }
    }
}

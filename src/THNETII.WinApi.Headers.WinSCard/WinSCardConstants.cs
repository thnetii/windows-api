using System;
using System.Runtime.CompilerServices;

using THNETII.WinApi.Helpers;
using THNETII.WinApi.Native.WinSmcrd;

namespace THNETII.WinApi.Native.WinSCard
{
    using static NativeLibraryNames;

    public static class WinSCardConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 71
        #region SCARD_IO_REQUEST* SCARD_PCI_T0;
        internal static readonly Lazy<IntPtr> g_rgSCardT0Pci =
            DllImportHelper.CreateDllImportLazy(WinSCard, nameof(g_rgSCardT0Pci));
        public static unsafe ref readonly SCARD_IO_REQUEST SCARD_PCI_T0 =>
            ref Unsafe.AsRef<SCARD_IO_REQUEST>(g_rgSCardT0Pci.Value.ToPointer());
        #endregion
        #region SCARD_IO_REQUEST* SCARD_PCI_T1;
        internal static readonly Lazy<IntPtr> g_rgSCardT1Pci =
            DllImportHelper.CreateDllImportLazy(WinSCard, nameof(g_rgSCardT1Pci));
        public static unsafe ref readonly SCARD_IO_REQUEST SCARD_PCI_T1 =>
            ref Unsafe.AsRef<SCARD_IO_REQUEST>(g_rgSCardT1Pci.Value.ToPointer());
        #endregion
        #region SCARD_IO_REQUEST* SCARD_PCI_RAW;
        internal static readonly Lazy<IntPtr> g_rgSCardRawPci =
            DllImportHelper.CreateDllImportLazy(WinSCard, nameof(g_rgSCardRawPci));
        public static unsafe ref readonly SCARD_IO_REQUEST SCARD_PCI_RAW =>
            ref Unsafe.AsRef<SCARD_IO_REQUEST>(g_rgSCardRawPci.Value.ToPointer());
        #endregion

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 95
        public const int SCARD_AUTOALLOCATE = -1;
    }
}

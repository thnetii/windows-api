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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 97
        public const int SCARD_SCOPE_USER = 0;      // The context is a user context, and any
                                                    // database operations are performed within the
                                                    // domain of the user.
        public const int SCARD_SCOPE_TERMINAL = 1;  // The context is that of the current terminal,
                                                    // and any database operations are performed
                                                    // within the domain of that terminal.  (The
                                                    // calling application must have appropriate
                                                    // access permissions for any database actions.)
        public const int SCARD_SCOPE_SYSTEM = 2;    // The context is the system context, and any
                                                    // database operations are performed within the
                                                    // domain of the system.  (The calling
                                                    // application must have appropriate access
                                                    // permissions for any database actions.)

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 135
        /// <summary>
        ///  Group used when no group name is provided when listing readers. Returns a list of all readers, regardless of what group or groups the readers are in. 
        /// </summary>
        public const string SCARD_ALL_READERS = "SCard$AllReaders\0";
        /// <summary>
        /// Default group to which all readers are added when introduced into the system. 
        /// </summary>
        public const string SCARD_DEFAULT_READERS = "SCard$DefaultReaders\0";
        /// <summary>
        /// Unused legacy value. This is an internally managed group that cannot be modified by using any reader group APIs. It is intended to be used for enumeration only. 
        /// </summary>
        public const string SCARD_LOCAL_READERS = "SCard$LocalReaders\0";
        /// <summary>
        /// Unused legacy value. This is an internally managed group that cannot be modified by using any reader group APIs. It is intended to be used for enumeration only. 
        /// </summary>
        public const string SCARD_SYSTEM_READERS = "SCard$SystemReaders\0";

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 140
        public const int SCARD_PROVIDER_PRIMARY = 1;    // Primary Provider Id
        public const int SCARD_PROVIDER_CSP = 2;        // Crypto Service Provider Id
        public const int SCARD_PROVIDER_KSP = 3;        // Key Storage Provider Id

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 538
        public const int SCARD_STATE_UNAWARE = 0x00000000;  // The application is unaware of the
                                                            // current state, and would like to
                                                            // know.  The use of this value
                                                            // results in an immediate return
                                                            // from state transition monitoring
                                                            // services.  This is represented by
                                                            // all bits set to zero.
        public const int SCARD_STATE_IGNORE = 0x00000001;  // The application requested that
                                                           // this reader be ignored.  No other
                                                           // bits will be set.
        public const int SCARD_STATE_CHANGED = 0x00000002;  // This implies that there is a
                                                            // difference between the state
                                                            // believed by the application, and
                                                            // the state known by the Service
                                                            // Manager.  When this bit is set,
                                                            // the application may assume a
                                                            // significant state change has
                                                            // occurred on this reader.
        public const int SCARD_STATE_UNKNOWN = 0x00000004;  // This implies that the given
                                                            // reader name is not recognized by
                                                            // the Service Manager.  If this bit
                                                            // is set, then SCARD_STATE_CHANGED
                                                            // and SCARD_STATE_IGNORE will also
                                                            // be set.
        public const int SCARD_STATE_UNAVAILABLE = 0x00000008;  // This implies that the actual
                                                                // state of this reader is not
                                                                // available.  If this bit is set,
                                                                // then all the following bits are
                                                                // clear.
        public const int SCARD_STATE_EMPTY = 0x00000010;  // This implies that there is not
                                                          // card in the reader.  If this bit
                                                          // is set, all the following bits
                                                          // will be clear.
        public const int SCARD_STATE_PRESENT = 0x00000020;  // This implies that there is a card
                                                            // in the reader.
        public const int SCARD_STATE_ATRMATCH = 0x00000040;  // This implies that there is a card
                                                             // in the reader with an ATR
                                                             // matching one of the target cards.
                                                             // If this bit is set,
                                                             // SCARD_STATE_PRESENT will also be
                                                             // set.  This bit is only returned
                                                             // on the SCardLocateCard() service.
        public const int SCARD_STATE_EXCLUSIVE = 0x00000080;  // This implies that the card in the
                                                              // reader is allocated for exclusive
                                                              // use by another application.  If
                                                              // this bit is set,
                                                              // SCARD_STATE_PRESENT will also be
                                                              // set.
        public const int SCARD_STATE_INUSE = 0x00000100;  // This implies that the card in the
                                                          // reader is in use by one or more
                                                          // other applications, but may be
                                                          // connected to in shared mode.  If
                                                          // this bit is set,
                                                          // SCARD_STATE_PRESENT will also be
                                                          // set.
        public const int SCARD_STATE_MUTE = 0x00000200;  // This implies that the card in the
                                                         // reader is unresponsive or not
                                                         // supported by the reader or
                                                         // software.
        public const int SCARD_STATE_UNPOWERED = 0x00000400;  // This implies that the card in the
                                                              // reader has not been powered up.

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 678
        public const int SCARD_SHARE_EXCLUSIVE = 1; // This application is not willing to share this
                                                    // card with other applications.
        public const int SCARD_SHARE_SHARED = 2; // This application is willing to share this
                                                 // card with other applications.
        public const int SCARD_SHARE_DIRECT = 3; // This application demands direct control of
                                                 // the reader, so it is not available to other
                                                 // applications.

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 678
        public const int SCARD_LEAVE_CARD = 0; // Don't do anything special on close
        public const int SCARD_RESET_CARD = 1; // Reset the card on close
        public const int SCARD_UNPOWER_CARD = 2; // Power down the card on close
        public const int SCARD_EJECT_CARD = 3; // Eject the card on close

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 875
        // Defined constants
        // Flags
        public const int SC_DLG_MINIMAL_UI = 0x01;
        public const int SC_DLG_NO_UI = 0x02;
        public const int SC_DLG_FORCE_UI = 0x04;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 881
        public const int SCERR_NOCARDNAME = 0x4000;
        public const int SCERR_NOGUIDS = 0x8000;
    }
}

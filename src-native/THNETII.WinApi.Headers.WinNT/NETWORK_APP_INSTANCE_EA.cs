using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13543
    [StructLayout(LayoutKind.Sequential)]
    public struct NETWORK_APP_INSTANCE_EA
    {
        /// <summary>
        /// The caller places a GUID that should always be unique for a single instance of
        /// the application.
        /// </summary>
        public Guid AppInstanceID;

        /// <summary>
        /// Combination of <see cref="NETWORK_APP_INSTANCE_CSV_FLAGS"/> flags.
        /// </summary>
        public NETWORK_APP_INSTANCE_CSV_FLAGS CsvFlags;
    }
}

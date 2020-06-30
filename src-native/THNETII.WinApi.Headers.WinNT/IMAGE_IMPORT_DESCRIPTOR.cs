using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17643
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_IMPORT_DESCRIPTOR
    {
        internal int u;
        /// <summary>
        /// <c>0</c> (zero) for terminating null import descriptor
        /// </summary>
        public int Characteristics
        {
            get => u;
            set => u = value;
        }
        /// <summary>
        /// RVA to original unbound IAT (<see cref="IMAGE_THUNK_DATA"/>)
        /// </summary>
        public int OriginalFirstThunk
        {
            get => u;
            set => u = value;
        }
        /// <summary>
        /// <para><c>0</c> (zero) if not bound</para>
        /// <para><c>-1</c> if bound, and real date/time stamp in <see cref="IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT"/> (new BIND)</para>
        /// <para>Otherwise date/time stamp of DLL bound to (Old BIND)</para>
        /// </summary>
        public int TimeDateStamp;
        /// <summary>
        /// -1 if no forwarders
        /// </summary>
        public int ForwarderChain;
        public int Name;
        /// <summary>
        /// RVA to IAT (if bound this IAT has actual addresses)
        /// </summary>
        public int FirstThunk;
    }
}

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17670
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_DELAYLOAD_DESCRIPTOR
    {
        public int Attributes;
        private static readonly Bitfield32 RvaBasedBitfield = Bitfield32.Bit(0);
        private static readonly Bitfield32 ReservedAttributesBitfield = Bitfield32.RemainingBits(1);
        /// <summary>Delay load version 2</summary>
        public bool RvaBased
        {
            get => RvaBasedBitfield.ReadBool(Attributes);
            set => RvaBasedBitfield.WriteBool(ref Attributes, value);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int ReservedAttributes
        {
            get => ReservedAttributesBitfield.Read(Attributes);
            set => ReservedAttributesBitfield.Write(ref Attributes, value);
        }

        /// <summary>RVA to the name of the target library (NULL-terminate ASCII string)</summary>
        public int DllNameRVA;
        /// <summary>RVA to the HMODULE caching location (<see cref="IntPtr"/>)</summary>
        public int ModuleHandleRVA;
        /// <summary>RVA to the start of the IAT (<see cref="IMAGE_THUNK_DATA"/>)</summary>
        public int ImportAddressTableRVA;
        /// <summary>RVA to the start of the name table (<see cref="IMAGE_THUNK_DATA.AddressOfData"/>)</summary>
        public int ImportNameTableRVA;
        /// <summary>RVA to an optional bound IAT</summary>
        public int BoundImportAddressTableRVA;
        /// <summary>RVA to an optional unload info table</summary>
        public int UnloadInformationTableRVA;
        /// <summary>
        /// <c>0</c> (zero) if not bound;
        /// Otherwise, date/time of the target DLL
        /// </summary>
        public int TimeDateStamp;
    }
}

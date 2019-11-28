using System;

namespace THNETII.WinApi.Native.WinSmcrd
{
    using static WinSmcrdFunctions;

    public static class WinSmcrdConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 46
        public const int FILE_DEVICE_SMARTCARD = 0x00000031;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 54
        //
        // Smart card reader interface GUID
        //
        // {50DD5230-BA8A-11D1-BF5D-0000F805F530}   
        //
        public static readonly Guid GUID_DEVINTERFACE_SMARTCARD_READER =
            Guid.Parse("50DD5230-BA8A-11D1-BF5D-0000F805F530");

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 62
        //
        // Various constants
        //

        public const int SCARD_ATR_LENGTH = 33;     // ISO 7816-3 spec.

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 68
        //
        ///////////////////////////////////////////////////////////////////////////////
        //
        //  Protocol Flag definitions
        //

        public const int SCARD_PROTOCOL_UNDEFINED = 0x00000000;     // There is no active protocol.
        public const int SCARD_PROTOCOL_T0 = 0x00000001;            // T=0 is the active protocol.
        public const int SCARD_PROTOCOL_T1 = 0x00000002;            // T=1 is the active protocol.
        public const int SCARD_PROTOCOL_RAW = 0x00010000;           // Raw is the active protocol.
        //
        // This is the mask of ISO defined transmission protocols
        //
        public const int SCARD_PROTOCOL_Tx = (SCARD_PROTOCOL_T0 | SCARD_PROTOCOL_T1);
        //
        // Use the default transmission parameters / card clock freq.
        //
        public const int SCARD_PROTOCOL_DEFAULT = unchecked((int)0x80000000);
        //
        // Use optimal transmission parameters / card clock freq.
        // Since using the optimal parameters is the default case no bit is defined to be 1
        //
        public const int SCARD_PROTOCOL_OPTIMAL = 0x00000000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 93
        //
        // Ioctl parameters 1 for IOCTL_SMARTCARD_POWER
        //
        public const int SCARD_POWER_DOWN = 0;          // Power down the card.
        public const int SCARD_COLD_RESET = 1;          // Cycle power and reset the card.
        public const int SCARD_WARM_RESET = 2;          // Force a reset on the card.

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 129
        //
        ///////////////////////////////////////////////////////////////////////////////
        //
        // Tags for requesting card and reader attributes
        //

        public const int MAXIMUM_ATTR_STRING_LENGTH = 32;   // Nothing bigger than this from getAttr
        public const int MAXIMUM_SMARTCARD_READERS = 10;   // Limit the readers on the system

        public const int SCARD_CLASS_VENDOR_INFO = 1;   // Vendor information definitions
        public const int SCARD_CLASS_COMMUNICATIONS = 2;   // Communication definitions
        public const int SCARD_CLASS_PROTOCOL = 3;   // Protocol definitions
        public const int SCARD_CLASS_POWER_MGMT = 4;   // Power Management definitions
        public const int SCARD_CLASS_SECURITY = 5;   // Security Assurance definitions
        public const int SCARD_CLASS_MECHANICAL = 6;   // Mechanical characteristic definitions
        public const int SCARD_CLASS_VENDOR_DEFINED = 7;   // Vendor specific definitions
        public const int SCARD_CLASS_IFD_PROTOCOL = 8;   // Interface Device Protocol options
        public const int SCARD_CLASS_ICC_STATE = 9;   // ICC State specific definitions
        public const int SCARD_CLASS_PERF = 0x7ffe;   // performace counters
        public const int SCARD_CLASS_SYSTEM = 0x7fff;   // System-specific definitions

        public const int SCARD_ATTR_VENDOR_NAME = (SCARD_CLASS_VENDOR_INFO << 16) | 0x0100;
        public const int SCARD_ATTR_VENDOR_IFD_TYPE = (SCARD_CLASS_VENDOR_INFO << 16) | 0x0101;
        public const int SCARD_ATTR_VENDOR_IFD_VERSION = (SCARD_CLASS_VENDOR_INFO << 16) | 0x0102;
        public const int SCARD_ATTR_VENDOR_IFD_SERIAL_NO = (SCARD_CLASS_VENDOR_INFO << 16) | 0x0103;
        public const int SCARD_ATTR_CHANNEL_ID = (SCARD_CLASS_COMMUNICATIONS << 16) | 0x0110;
        public const int SCARD_ATTR_PROTOCOL_TYPES = (SCARD_CLASS_PROTOCOL << 16) | 0x0120;
        // public const int SCARD_ATTR_ASYNC_PROTOCOL_TYPES = (SCARD_CLASS_PROTOCOL << 16) | 0x0120;
        public const int SCARD_ATTR_DEFAULT_CLK = (SCARD_CLASS_PROTOCOL << 16) | 0x0121;
        public const int SCARD_ATTR_MAX_CLK = (SCARD_CLASS_PROTOCOL << 16) | 0x0122;
        public const int SCARD_ATTR_DEFAULT_DATA_RATE = (SCARD_CLASS_PROTOCOL << 16) | 0x0123;
        public const int SCARD_ATTR_MAX_DATA_RATE = (SCARD_CLASS_PROTOCOL << 16) | 0x0124;
        public const int SCARD_ATTR_MAX_IFSD = (SCARD_CLASS_PROTOCOL << 16) | 0x0125;
        // public const int SCARD_ATTR_SYNC_PROTOCOL_TYPES = (SCARD_CLASS_PROTOCOL << 16) | 0x0126;
        public const int SCARD_ATTR_POWER_MGMT_SUPPORT = (SCARD_CLASS_POWER_MGMT << 16) | 0x0131;
        public const int SCARD_ATTR_USER_TO_CARD_AUTH_DEVICE = (SCARD_CLASS_SECURITY << 16) | 0x0140;
        public const int SCARD_ATTR_USER_AUTH_INPUT_DEVICE = (SCARD_CLASS_SECURITY << 16) | 0x0142;
        public const int SCARD_ATTR_CHARACTERISTICS = (SCARD_CLASS_MECHANICAL << 16) | 0x0150;

        public const int SCARD_ATTR_CURRENT_PROTOCOL_TYPE = (SCARD_CLASS_IFD_PROTOCOL << 16) | 0x0201;
        public const int SCARD_ATTR_CURRENT_CLK = (SCARD_CLASS_IFD_PROTOCOL << 16) | 0x0202;
        public const int SCARD_ATTR_CURRENT_F = (SCARD_CLASS_IFD_PROTOCOL << 16) | 0x0203;
        public const int SCARD_ATTR_CURRENT_D = (SCARD_CLASS_IFD_PROTOCOL << 16) | 0x0204;
        public const int SCARD_ATTR_CURRENT_N = (SCARD_CLASS_IFD_PROTOCOL << 16) | 0x0205;
        public const int SCARD_ATTR_CURRENT_W = (SCARD_CLASS_IFD_PROTOCOL << 16) | 0x0206;
        public const int SCARD_ATTR_CURRENT_IFSC = (SCARD_CLASS_IFD_PROTOCOL << 16) | 0x0207;
        public const int SCARD_ATTR_CURRENT_IFSD = (SCARD_CLASS_IFD_PROTOCOL << 16) | 0x0208;
        public const int SCARD_ATTR_CURRENT_BWT = (SCARD_CLASS_IFD_PROTOCOL << 16) | 0x0209;
        public const int SCARD_ATTR_CURRENT_CWT = (SCARD_CLASS_IFD_PROTOCOL << 16) | 0x020a;
        public const int SCARD_ATTR_CURRENT_EBC_ENCODING = (SCARD_CLASS_IFD_PROTOCOL << 16) | 0x020b;
        public const int SCARD_ATTR_EXTENDED_BWT = (SCARD_CLASS_IFD_PROTOCOL << 16) | 0x020c;

        public const int SCARD_ATTR_ICC_PRESENCE = (SCARD_CLASS_ICC_STATE << 16) | 0x0300;
        public const int SCARD_ATTR_ICC_INTERFACE_STATUS = (SCARD_CLASS_ICC_STATE << 16) | 0x0301;
        public const int SCARD_ATTR_CURRENT_IO_STATE = (SCARD_CLASS_ICC_STATE << 16) | 0x0302;
        public const int SCARD_ATTR_ATR_STRING = (SCARD_CLASS_ICC_STATE << 16) | 0x0303;
        public const int SCARD_ATTR_ICC_TYPE_PER_ATR = (SCARD_CLASS_ICC_STATE << 16) | 0x0304;

        public const int SCARD_ATTR_ESC_RESET = (SCARD_CLASS_VENDOR_DEFINED << 16) | 0xA000;
        public const int SCARD_ATTR_ESC_CANCEL = (SCARD_CLASS_VENDOR_DEFINED << 16) | 0xA003;
        public const int SCARD_ATTR_ESC_AUTHREQUEST = (SCARD_CLASS_VENDOR_DEFINED << 16) | 0xA005;
        public const int SCARD_ATTR_MAXINPUT = (SCARD_CLASS_VENDOR_DEFINED << 16) | 0xA007;
        public const int SCARD_ATTR_VENDOR_SPECIFIC_INFO = (SCARD_CLASS_VENDOR_DEFINED << 16) | 0xA008;

        public const int SCARD_ATTR_DEVICE_UNIT = (SCARD_CLASS_SYSTEM << 16) | 0x0001;
        public const int SCARD_ATTR_DEVICE_IN_USE = (SCARD_CLASS_SYSTEM << 16) | 0x0002;
        public const int SCARD_ATTR_DEVICE_FRIENDLY_NAME_A = (SCARD_CLASS_SYSTEM << 16) | 0x0003;
        public const int SCARD_ATTR_DEVICE_SYSTEM_NAME_A = (SCARD_CLASS_SYSTEM << 16) | 0x0004;
        public const int SCARD_ATTR_DEVICE_FRIENDLY_NAME_W = (SCARD_CLASS_SYSTEM << 16) | 0x0005;
        public const int SCARD_ATTR_DEVICE_SYSTEM_NAME_W = (SCARD_CLASS_SYSTEM << 16) | 0x0006;
        public const int SCARD_ATTR_SUPRESS_T1_IFS_REQUEST = (SCARD_CLASS_SYSTEM << 16) | 0x0007;

        public const int SCARD_PERF_NUM_TRANSMISSIONS = (SCARD_CLASS_PERF << 16) | 0x0001;
        public const int SCARD_PERF_BYTES_TRANSMITTED = (SCARD_CLASS_PERF << 16) | 0x0002;
        public const int SCARD_PERF_TRANSMISSION_TIME = (SCARD_CLASS_PERF << 16) | 0x0003;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 216
        //
        // T=0 Protocol Defines
        //

        public const int SCARD_T0_HEADER_LENGTH = 7;
        public const int SCARD_T0_CMD_LENGTH = 5;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 224
        //
        // T=1 Protocol Defines
        //

        public const int SCARD_T1_PROLOGUE_LENGTH = 3;
        public const int SCARD_T1_EPILOGUE_LENGTH = 2;  // CRC
        public const int SCARD_T1_EPILOGUE_LENGTH_LRC = 1;
        public const int SCARD_T1_MAX_IFS = 254;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 234
        //
        ///////////////////////////////////////////////////////////////////////////////
        //
        //  Reader states
        //

        public const int SCARD_UNKNOWN = 0;   // This value implies the driver is unaware
                                              // of the current state of the reader.
        public const int SCARD_ABSENT = 1;   // This value implies there is no card in
                                             // the reader.
        public const int SCARD_PRESENT = 2;   // This value implies there is a card is
                                              // present in the reader, but that it has
                                              // not been moved into position for use.
        public const int SCARD_SWALLOWED = 3;   // This value implies there is a card in the
                                                // reader in position for use.  The card is
                                                // not powered.
        public const int SCARD_POWERED = 4;   // This value implies there is power is
                                              // being provided to the card, but the
                                              // Reader Driver is unaware of the mode of
                                              // the card.
        public const int SCARD_NEGOTIABLE = 5;   // This value implies the card has been
                                                 // reset and is awaiting PTS negotiation.
        public const int SCARD_SPECIFIC = 6;   // This value implies the card has been
                                               // reset and specific communication
                                               // protocols have been established.

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 318
        //
        ////////////////////////////////////////////////////////////////////////////////
        //
        //  Driver attribute flags
        //

        public const int SCARD_READER_SWALLOWS = 0x00000001;  // Reader has a card swallowing
                                                              // mechanism.
        public const int SCARD_READER_EJECTS = 0x00000002;  // Reader has a card ejection
                                                            // mechanism.
        public const int SCARD_READER_CONFISCATES = 0x00000004;  // Reader has a card capture
                                                                 // mechanism.
        public const int SCARD_READER_CONTACTLESS = 0x00000008;  // Reader supports contactless

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 332
        //
        ///////////////////////////////////////////////////////////////////////////////
        //
        // Type of reader
        //
        public const int SCARD_READER_TYPE_SERIAL = 0x01;
        public const int SCARD_READER_TYPE_PARALELL = 0x02;
        public const int SCARD_READER_TYPE_KEYBOARD = 0x04;
        public const int SCARD_READER_TYPE_SCSI = 0x08;
        public const int SCARD_READER_TYPE_IDE = 0x10;
        public const int SCARD_READER_TYPE_USB = 0x20;
        public const int SCARD_READER_TYPE_PCMCIA = 0x40;
        public const int SCARD_READER_TYPE_TPM = 0x80;
        public const int SCARD_READER_TYPE_NFC = 0x100;
        public const int SCARD_READER_TYPE_UICC = 0x200;
        public const int SCARD_READER_TYPE_NGC = 0x400;
        public const int SCARD_READER_TYPE_EMBEDDEDSE = 0x800;
        public const int SCARD_READER_TYPE_VENDOR = 0xF0;
    }
}

using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinSmcrd
{
    using static SCARD_ATTR_CLASS;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct SCARD_ATTR_VALUE
    {
        private static readonly Bitfield32 classBitfield = Bitfield32.HighBits(16);
        private static readonly Bitfield32 tagBitfield = Bitfield32.LowBits(16);

        private readonly int valueField;

        public SCARD_ATTR_VALUE(int value) : this() => valueField = value;
        public SCARD_ATTR_VALUE(SCARD_ATTR_CLASS @class, int tag) : this()
        {
            classBitfield.Write(ref valueField, (int)@class);
            tagBitfield.Write(ref valueField, tag);
        }

        public readonly int Value => valueField;
        public readonly SCARD_ATTR_CLASS Class =>
            (SCARD_ATTR_CLASS)classBitfield.Read(valueField);
        public readonly int Tag => tagBitfield.Read(valueField);

        /// <summary>
        /// Vendor name.
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_VENDOR_NAME = new SCARD_ATTR_VALUE(SCARD_CLASS_VENDOR_INFO, 0x0100);
        /// <summary>
        /// Vendor-supplied interface device type (model designation of reader). 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_VENDOR_IFD_TYPE = new SCARD_ATTR_VALUE(SCARD_CLASS_VENDOR_INFO, 0x0101);
        /// <summary>
        /// Vendor-supplied interface device version (<strong>DWORD</strong> in the form <c>0x<em>MM</em><em>mm</em><em>bbbb</em></c> where <c><em>MM</em></c> = major version, <c><em>mm</em></c> = minor version, and <c><em>bbbb</em></c> = build number). 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_VENDOR_IFD_VERSION = new SCARD_ATTR_VALUE(SCARD_CLASS_VENDOR_INFO, 0x0102);
        /// <summary>
        ///  Vendor-supplied interface device serial number. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_VENDOR_IFD_SERIAL_NO = new SCARD_ATTR_VALUE(SCARD_CLASS_VENDOR_INFO, 0x0103);
        /// <summary>
        /// <strong>DWORD</strong> encoded as <c>0x<em>DDDD</em><em>CCCC</em></c>, where <em>DDDD</em> = data channel type and <em>CCCC</em> = channel number:
        /// <list type="bullet">
        /// <listheader>The following encodings are defined for <em>DDDD</em>:</listheader>
        /// <item><c>0x01</c> serial I/O; <em>CCCC</em> is a port number.</item>
        /// <item><c>0x02</c> parallel I/O; <em>CCCC</em> is a port number.</item>
        /// <item><c>0x04</c> PS/2 keyboard port; <em>CCCC</em> is zero.</item>
        /// <item><c>0x08</c> SCSI; <em>CCCC</em> is SCSI ID number.</item>
        /// <item><c>0x10</c> IDE; <em>CCCC</em> is device number.</item>
        /// <item><c>0x20</c> USB; <em>CCCC</em> is device number.</item>
        /// <item><c>0xF<em>y</em></c> vendor-defined interface with <em>y</em> in the range zero through 15; <em>CCCC</em> is vendor defined.</item>
        /// </list>
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CHANNEL_ID = new SCARD_ATTR_VALUE(SCARD_CLASS_COMMUNICATIONS, 0x0110);
        /// <summary>
        /// <strong>DWORD</strong> encoded as <c>0x0<em>rrr</em><em>pppp</em></c> where <c><em>rrr</em></c> is RFU and should be <c>0x000</c>. <c><em>pppp</em></c> encodes the supported protocol types. A '1' in a given bit position indicates support for the associated ISO protocol, so if bits zero and one are set, both <a href="https://docs.microsoft.com/windows/desktop/SecGloss/t-gly">T=0</a> and <a href="https://docs.microsoft.com/windows/desktop/SecGloss/t-gly">T=1</a> protocols are supported.
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_PROTOCOL_TYPES = new SCARD_ATTR_VALUE(SCARD_CLASS_PROTOCOL, 0x0120);
        // public static readonly SCARD_ATTR_VALUE SCARD_ATTR_ASYNC_PROTOCOL_TYPES = new SCARD_ATTR_VALUE(SCARD_CLASS_PROTOCOL, 0x0120);
        /// <summary>
        /// Default clock rate, in kHz.
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_DEFAULT_CLK = new SCARD_ATTR_VALUE(SCARD_CLASS_PROTOCOL, 0x0121);
        /// <summary>
        /// Maximum clock rate, in kHz. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_MAX_CLK = new SCARD_ATTR_VALUE(SCARD_CLASS_PROTOCOL, 0x0122);
        /// <summary>
        /// Default data rate, in bps.
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_DEFAULT_DATA_RATE = new SCARD_ATTR_VALUE(SCARD_CLASS_PROTOCOL, 0x0123);
        /// <summary>
        /// Maximum data rate, in bps. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_MAX_DATA_RATE = new SCARD_ATTR_VALUE(SCARD_CLASS_PROTOCOL, 0x0124);
        /// <summary>
        /// Maximum bytes for information file size device. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_MAX_IFSD = new SCARD_ATTR_VALUE(SCARD_CLASS_PROTOCOL, 0x0125);
        // public static readonly SCARD_ATTR_VALUE SCARD_ATTR_SYNC_PROTOCOL_TYPES = new SCARD_ATTR_VALUE(SCARD_CLASS_PROTOCOL, 0x0126);
        /// <summary>
        /// Zero if device does not support power down while smart card is inserted. Nonzero otherwise. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_POWER_MGMT_SUPPORT = new SCARD_ATTR_VALUE(SCARD_CLASS_POWER_MGMT, 0x0131);
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_USER_TO_CARD_AUTH_DEVICE = new SCARD_ATTR_VALUE(SCARD_CLASS_SECURITY, 0x0140);
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_USER_AUTH_INPUT_DEVICE = new SCARD_ATTR_VALUE(SCARD_CLASS_SECURITY, 0x0142);
        /// <summary>
        /// <strong>DWORD</strong> indicating which mechanical characteristics are supported. If zero, no special characteristics are supported. Note that multiple bits can be set:
        /// <list type="table">
        /// <item><term><c>0x00000001</c></term><description>Card swallowing mechanism</description></item>
        /// <item><term><c>0x00000002</c></term><description>Card ejection mechanism</description></item>
        /// <item><term><c>0x00000004</c></term><description>Card capture mechanism</description></item>
        /// </list>
        /// All other values are reserved for future use(RFU).
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CHARACTERISTICS = new SCARD_ATTR_VALUE(SCARD_CLASS_MECHANICAL, 0x0150);

        /// <summary>
        /// <strong>DWORD</strong> encoded as <c>0x0<em>rrr</em><em>pppp</em></c> where <em>rrr</em> is RFU and should be <c>0x000</c>. <em>pppp</em> encodes the current protocol type. Whichever bit has been set indicates which ISO protocol is currently in use. (For example, if bit zero is set, <a href="https://docs.microsoft.com/windows/desktop/SecGloss/t-gly">T=0 protocol</a> is in effect.) 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CURRENT_PROTOCOL_TYPE = new SCARD_ATTR_VALUE(SCARD_CLASS_IFD_PROTOCOL, 0x0201);
        /// <summary>
        /// Current clock rate, in kHz. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CURRENT_CLK = new SCARD_ATTR_VALUE(SCARD_CLASS_IFD_PROTOCOL, 0x0202);
        /// <summary>
        ///  Clock conversion factor. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CURRENT_F = new SCARD_ATTR_VALUE(SCARD_CLASS_IFD_PROTOCOL, 0x0203);
        /// <summary>
        /// Bit rate conversion factor. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CURRENT_D = new SCARD_ATTR_VALUE(SCARD_CLASS_IFD_PROTOCOL, 0x0204);
        /// <summary>
        /// Current guard time. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CURRENT_N = new SCARD_ATTR_VALUE(SCARD_CLASS_IFD_PROTOCOL, 0x0205);
        /// <summary>
        ///  Current work waiting time. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CURRENT_W = new SCARD_ATTR_VALUE(SCARD_CLASS_IFD_PROTOCOL, 0x0206);
        /// <summary>
        /// Current byte size for information field size card. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CURRENT_IFSC = new SCARD_ATTR_VALUE(SCARD_CLASS_IFD_PROTOCOL, 0x0207);
        /// <summary>
        /// Current byte size for information field size device. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CURRENT_IFSD = new SCARD_ATTR_VALUE(SCARD_CLASS_IFD_PROTOCOL, 0x0208);
        /// <summary>
        /// Current block waiting time. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CURRENT_BWT = new SCARD_ATTR_VALUE(SCARD_CLASS_IFD_PROTOCOL, 0x0209);
        /// <summary>
        /// Current character waiting time. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CURRENT_CWT = new SCARD_ATTR_VALUE(SCARD_CLASS_IFD_PROTOCOL, 0x020a);
        /// <summary>
        /// Current error block control encoding.
        /// <list type="table">
        /// <item><term><c>0</c></term><description>longitudinal redundancy check(LRC)</description></item>
        /// <item><term><c>1</c></term><description>cyclical redundancy check(CRC)</description></item>
        /// </list>
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CURRENT_EBC_ENCODING = new SCARD_ATTR_VALUE(SCARD_CLASS_IFD_PROTOCOL, 0x020b);
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_EXTENDED_BWT = new SCARD_ATTR_VALUE(SCARD_CLASS_IFD_PROTOCOL, 0x020c);

        /// <summary>
        /// Single byte indicating smart card presence:
        /// <list type="table">
        /// <item><term><c>0</c></term><description>not present</description></item>
        /// <item><term><c>1</c></term><description>card present but not swallowed (applies only if reader supports smart card swallowing)</description></item>
        /// <item><term><c>2</c></term><description>card present (and swallowed if reader supports smart card swallowing)</description></item>
        /// <item><term><c>4</c></term><description>card confiscated.</description></item>
        /// </list>
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_ICC_PRESENCE = new SCARD_ATTR_VALUE(SCARD_CLASS_ICC_STATE, 0x0300);
        /// <summary>
        /// Single byte. Zero if <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">smart card</a> electrical contact is not active; nonzero if contact is active. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_ICC_INTERFACE_STATUS = new SCARD_ATTR_VALUE(SCARD_CLASS_ICC_STATE, 0x0301);
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_CURRENT_IO_STATE = new SCARD_ATTR_VALUE(SCARD_CLASS_ICC_STATE, 0x0302);
        /// <summary>
        ///  Answer to reset (ATR) string. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_ATR_STRING = new SCARD_ATTR_VALUE(SCARD_CLASS_ICC_STATE, 0x0303);
        /// <summary>
        /// Single byte indicating smart card type:
        /// <list type="table">
        /// <item><term><c>0</c></term><description>unknown type</description></item>
        /// <item><term><c>1</c></term><description>7816 Asynchronous</description></item>
        /// <item><term><c>2</c></term><description>7816 Synchronous</description></item>
        /// </list>
        /// Other values RFU.
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_ICC_TYPE_PER_ATR = new SCARD_ATTR_VALUE(SCARD_CLASS_ICC_STATE, 0x0304);

        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_ESC_RESET = new SCARD_ATTR_VALUE(SCARD_CLASS_VENDOR_DEFINED, 0xA000);
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_ESC_CANCEL = new SCARD_ATTR_VALUE(SCARD_CLASS_VENDOR_DEFINED, 0xA003);
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_ESC_AUTHREQUEST = new SCARD_ATTR_VALUE(SCARD_CLASS_VENDOR_DEFINED, 0xA005);
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_MAXINPUT = new SCARD_ATTR_VALUE(SCARD_CLASS_VENDOR_DEFINED, 0xA007);
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_VENDOR_SPECIFIC_INFO = new SCARD_ATTR_VALUE(SCARD_CLASS_VENDOR_DEFINED, 0xA008);

        /// <summary>
        /// Instance of this vendor's reader attached to the computer. The first instance will be device unit 0, the next will be unit 1 (if it is the same brand of reader) and so on. Two different brands of readers will both have zero for this value. 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_DEVICE_UNIT = new SCARD_ATTR_VALUE(SCARD_CLASS_SYSTEM, 0x0001);
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_DEVICE_IN_USE = new SCARD_ATTR_VALUE(SCARD_CLASS_SYSTEM, 0x0002);
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_DEVICE_FRIENDLY_NAME_A = new SCARD_ATTR_VALUE(SCARD_CLASS_SYSTEM, 0x0003);
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_DEVICE_SYSTEM_NAME_A = new SCARD_ATTR_VALUE(SCARD_CLASS_SYSTEM, 0x0004);
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_DEVICE_FRIENDLY_NAME_W = new SCARD_ATTR_VALUE(SCARD_CLASS_SYSTEM, 0x0005);
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_DEVICE_SYSTEM_NAME_W = new SCARD_ATTR_VALUE(SCARD_CLASS_SYSTEM, 0x0006);
        /// <summary>
        ///  Suppress sending of <a href="https://docs.microsoft.com/windows/desktop/SecGloss/t-gly">T=1</a> IFSD packet from the reader to the card. (Can be used if the currently inserted card does not support an IFSD request.) 
        /// </summary>
        public static readonly SCARD_ATTR_VALUE SCARD_ATTR_SUPRESS_T1_IFS_REQUEST = new SCARD_ATTR_VALUE(SCARD_CLASS_SYSTEM, 0x0007);

        public static readonly SCARD_ATTR_VALUE SCARD_PERF_NUM_TRANSMISSIONS = new SCARD_ATTR_VALUE(SCARD_CLASS_PERF, 0x0001);
        public static readonly SCARD_ATTR_VALUE SCARD_PERF_BYTES_TRANSMITTED = new SCARD_ATTR_VALUE(SCARD_CLASS_PERF, 0x0002);
        public static readonly SCARD_ATTR_VALUE SCARD_PERF_TRANSMISSION_TIME = new SCARD_ATTR_VALUE(SCARD_CLASS_PERF, 0x0003);

        /// <summary>
        /// Reader's display name.
        /// </summary>
        public static SCARD_ATTR_VALUE SCARD_ATTR_DEVICE_FRIENDLY_NAME =>
            Marshal.SystemDefaultCharSize switch
            {
                1 => SCARD_ATTR_DEVICE_FRIENDLY_NAME_A,
                2 => SCARD_ATTR_DEVICE_FRIENDLY_NAME_W,
                _ => throw new PlatformNotSupportedException()
            };
        /// <summary>
        /// Reader's system name.
        /// </summary>
        public static SCARD_ATTR_VALUE SCARD_ATTR_DEVICE_SYSTEM_NAME =>
            Marshal.SystemDefaultCharSize switch
            {
                1 => SCARD_ATTR_DEVICE_SYSTEM_NAME_A,
                2 => SCARD_ATTR_DEVICE_SYSTEM_NAME_W,
                _ => throw new PlatformNotSupportedException()
            };
    }
}

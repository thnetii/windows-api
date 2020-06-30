using System;
using System.Collections.Generic;
using System.Text;

namespace THNETII.WinApi.Native.WinIOCtl
{
    public static class WinIOCtlConstants
    {
        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 43
        public static readonly Guid GUID_DEVINTERFACE_DISK = new Guid(0x53f56307, unchecked((short)0xb6bf), 0x11d0, new byte[] { 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b });
        public static readonly Guid GUID_DEVINTERFACE_CDROM = new Guid(0x53f56308, unchecked((short)0xb6bf), 0x11d0, new byte[] { 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b });
        public static readonly Guid GUID_DEVINTERFACE_PARTITION = new Guid(0x53f5630a, unchecked((short)0xb6bf), 0x11d0, new byte[] { 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b });
        public static readonly Guid GUID_DEVINTERFACE_TAPE = new Guid(0x53f5630b, unchecked((short)0xb6bf), 0x11d0, new byte[] { 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b });
        public static readonly Guid GUID_DEVINTERFACE_WRITEONCEDISK = new Guid(0x53f5630c, unchecked((short)0xb6bf), 0x11d0, new byte[] { 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b });
        public static readonly Guid GUID_DEVINTERFACE_VOLUME = new Guid(0x53f5630d, unchecked((short)0xb6bf), 0x11d0, new byte[] { 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b });
        public static readonly Guid GUID_DEVINTERFACE_MEDIUMCHANGER = new Guid(0x53f56310, unchecked((short)0xb6bf), 0x11d0, new byte[] { 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b });
        public static readonly Guid GUID_DEVINTERFACE_FLOPPY = new Guid(0x53f56311, unchecked((short)0xb6bf), 0x11d0, new byte[] { 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b });
        public static readonly Guid GUID_DEVINTERFACE_CDCHANGER = new Guid(0x53f56312, unchecked((short)0xb6bf), 0x11d0, new byte[] { 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b });
        public static readonly Guid GUID_DEVINTERFACE_STORAGEPORT = new Guid(0x2accfe60, unchecked((short)0xc130), 0x11d2, new byte[] { 0xb0, 0x82, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b });
        public static readonly Guid GUID_DEVINTERFACE_VMLUN = new Guid(0x6f416619, unchecked((short)0x9f29), 0x42a5, new byte[] { 0xb2, 0x0b, 0x37, 0xe2, 0x19, 0xca, 0x02, 0xb0 });
        public static readonly Guid GUID_DEVINTERFACE_SES = new Guid(0x1790c9ec, 0x47d5, 0x4df3, new byte[] { 0xb5, 0xaf, 0x9a, 0xdf, 0x3c, 0xf2, 0x3e, 0x48 });

        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 56
        public static readonly Guid WDI_STORAGE_PREDICT_FAILURE_DPS_GUID =
            new Guid(unchecked((int)0xe9f2d03a), 0x747c, 0x41c2, new byte[] { 0xbb, 0x9a, 0x02, 0xc6, 0x2b, 0x6d, 0x5f, 0xcb });

        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 58
        //
        // Interfaces to discover devices that are
        // not reported  through conventional APIs
        //

        public static readonly Guid GUID_DEVINTERFACE_SERVICE_VOLUME = new Guid(0x6ead3d82, 0x25ec, 0x46bc, new byte[] { 0xb7, 0xfd, 0xc1, 0xf0, 0xdf, 0x8f, 0x50, 0x37 });
        public static readonly Guid GUID_DEVINTERFACE_HIDDEN_VOLUME = new Guid(0x7f108a28, unchecked((short)0x9833), 0x4b3b, new byte[] { 0xb7, 0x80, 0x2c, 0x6b, 0x5f, 0xa5, 0xc0, 0x62 });

        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 66
        //
        // Interface to register for RPMB commands
        //

        public static readonly Guid GUID_DEVINTERFACE_UNIFIED_ACCESS_RPMB = new Guid(0x27447c21, unchecked((short)0xbcc3), 0x4d07, new byte[] { 0xa0, 0x5b, 0xa3, 0x39, 0x5b, 0xb4, 0xee, 0xe7 });

        // {86E0D1E0-8089-11D0-9CE4-08003E301F73}
        public static readonly Guid GUID_DEVINTERFACE_COMPORT = new Guid(unchecked((int)0X86E0D1E0), unchecked((short)0X8089), 0X11D0, new byte[] { 0X9C, 0XE4, 0X08, 0X00, 0X3E, 0X30, 0X1F, 0X73 });
        // {4D36E978-E325-11CE-BFC1-08002BE10318}
        public static readonly Guid GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR = new Guid(0x4D36E978, unchecked((short)0xE325), 0x11CE, new byte[] { 0xBF, 0xC1, 0x08, 0x00, 0x2B, 0xE1, 0x03, 0x18 });

        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 77
        //
        // Obsolete device interface class GUID names.
        // (use of above GUID_DEVINTERFACE_* names is recommended).
        //

        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 86
        public static ref readonly Guid DiskClassGuid => ref GUID_DEVINTERFACE_DISK;
        public static ref readonly Guid CdRomClassGuid => ref GUID_DEVINTERFACE_CDROM;
        public static ref readonly Guid PartitionClassGuid => ref GUID_DEVINTERFACE_PARTITION;
        public static ref readonly Guid TapeClassGuid => ref GUID_DEVINTERFACE_TAPE;
        public static ref readonly Guid WriteOnceDiskClassGuid => ref GUID_DEVINTERFACE_WRITEONCEDISK;
        public static ref readonly Guid VolumeClassGuid => ref GUID_DEVINTERFACE_VOLUME;
        public static ref readonly Guid MediumChangerClassGuid => ref GUID_DEVINTERFACE_MEDIUMCHANGER;
        public static ref readonly Guid FloppyClassGuid => ref GUID_DEVINTERFACE_FLOPPY;
        public static ref readonly Guid CdChangerClassGuid => ref GUID_DEVINTERFACE_CDCHANGER;
        public static ref readonly Guid StoragePortClassGuid => ref GUID_DEVINTERFACE_STORAGEPORT;

        public static ref readonly Guid HiddenVolumeClassGuid => ref GUID_DEVINTERFACE_HIDDEN_VOLUME;

        public static ref readonly Guid GUID_CLASS_COMPORT => ref GUID_DEVINTERFACE_COMPORT;
        public static ref readonly Guid GUID_SERENUM_BUS_ENUMERATOR => ref GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR;

        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 148
        //
        // Define the various device type values.  Note that values used by Microsoft
        // Corporation are in the range 0-32767, and 32768-65535 are reserved for use
        // by customers.
        //

        public const int FILE_DEVICE_BEEP = 0x00000001;
        public const int FILE_DEVICE_CD_ROM = 0x00000002;
        public const int FILE_DEVICE_CD_ROM_FILE_SYSTEM = 0x00000003;
        public const int FILE_DEVICE_CONTROLLER = 0x00000004;
        public const int FILE_DEVICE_DATALINK = 0x00000005;
        public const int FILE_DEVICE_DFS = 0x00000006;
        public const int FILE_DEVICE_DISK = 0x00000007;
        public const int FILE_DEVICE_DISK_FILE_SYSTEM = 0x00000008;
        public const int FILE_DEVICE_FILE_SYSTEM = 0x00000009;
        public const int FILE_DEVICE_INPORT_PORT = 0x0000000a;
        public const int FILE_DEVICE_KEYBOARD = 0x0000000b;
        public const int FILE_DEVICE_MAILSLOT = 0x0000000c;
        public const int FILE_DEVICE_MIDI_IN = 0x0000000d;
        public const int FILE_DEVICE_MIDI_OUT = 0x0000000e;
        public const int FILE_DEVICE_MOUSE = 0x0000000f;
        public const int FILE_DEVICE_MULTI_UNC_PROVIDER = 0x00000010;
        public const int FILE_DEVICE_NAMED_PIPE = 0x00000011;
        public const int FILE_DEVICE_NETWORK = 0x00000012;
        public const int FILE_DEVICE_NETWORK_BROWSER = 0x00000013;
        public const int FILE_DEVICE_NETWORK_FILE_SYSTEM = 0x00000014;
        public const int FILE_DEVICE_NULL = 0x00000015;
        public const int FILE_DEVICE_PARALLEL_PORT = 0x00000016;
        public const int FILE_DEVICE_PHYSICAL_NETCARD = 0x00000017;
        public const int FILE_DEVICE_PRINTER = 0x00000018;
        public const int FILE_DEVICE_SCANNER = 0x00000019;
        public const int FILE_DEVICE_SERIAL_MOUSE_PORT = 0x0000001a;
        public const int FILE_DEVICE_SERIAL_PORT = 0x0000001b;
        public const int FILE_DEVICE_SCREEN = 0x0000001c;
        public const int FILE_DEVICE_SOUND = 0x0000001d;
        public const int FILE_DEVICE_STREAMS = 0x0000001e;
        public const int FILE_DEVICE_TAPE = 0x0000001f;
        public const int FILE_DEVICE_TAPE_FILE_SYSTEM = 0x00000020;
        public const int FILE_DEVICE_TRANSPORT = 0x00000021;
        public const int FILE_DEVICE_UNKNOWN = 0x00000022;
        public const int FILE_DEVICE_VIDEO = 0x00000023;
        public const int FILE_DEVICE_VIRTUAL_DISK = 0x00000024;
        public const int FILE_DEVICE_WAVE_IN = 0x00000025;
        public const int FILE_DEVICE_WAVE_OUT = 0x00000026;
        public const int FILE_DEVICE_8042_PORT = 0x00000027;
        public const int FILE_DEVICE_NETWORK_REDIRECTOR = 0x00000028;
        public const int FILE_DEVICE_BATTERY = 0x00000029;
        public const int FILE_DEVICE_BUS_EXTENDER = 0x0000002a;
        public const int FILE_DEVICE_MODEM = 0x0000002b;
        public const int FILE_DEVICE_VDM = 0x0000002c;
        public const int FILE_DEVICE_MASS_STORAGE = 0x0000002d;
        public const int FILE_DEVICE_SMB = 0x0000002e;
        public const int FILE_DEVICE_KS = 0x0000002f;
        public const int FILE_DEVICE_CHANGER = 0x00000030;
        public const int FILE_DEVICE_SMARTCARD = 0x00000031;
        public const int FILE_DEVICE_ACPI = 0x00000032;
        public const int FILE_DEVICE_DVD = 0x00000033;
        public const int FILE_DEVICE_FULLSCREEN_VIDEO = 0x00000034;
        public const int FILE_DEVICE_DFS_FILE_SYSTEM = 0x00000035;
        public const int FILE_DEVICE_DFS_VOLUME = 0x00000036;
        public const int FILE_DEVICE_SERENUM = 0x00000037;
        public const int FILE_DEVICE_TERMSRV = 0x00000038;
        public const int FILE_DEVICE_KSEC = 0x00000039;
        public const int FILE_DEVICE_FIPS = 0x0000003A;
        public const int FILE_DEVICE_INFINIBAND = 0x0000003B;
        public const int FILE_DEVICE_VMBUS = 0x0000003E;
        public const int FILE_DEVICE_CRYPT_PROVIDER = 0x0000003F;
        public const int FILE_DEVICE_WPD = 0x00000040;
        public const int FILE_DEVICE_BLUETOOTH = 0x00000041;
        public const int FILE_DEVICE_MT_COMPOSITE = 0x00000042;
        public const int FILE_DEVICE_MT_TRANSPORT = 0x00000043;
        public const int FILE_DEVICE_BIOMETRIC = 0x00000044;
        public const int FILE_DEVICE_PMI = 0x00000045;
        public const int FILE_DEVICE_EHSTOR = 0x00000046;
        public const int FILE_DEVICE_DEVAPI = 0x00000047;
        public const int FILE_DEVICE_GPIO = 0x00000048;
        public const int FILE_DEVICE_USBEX = 0x00000049;
        public const int FILE_DEVICE_CONSOLE = 0x00000050;
        public const int FILE_DEVICE_NFP = 0x00000051;
        public const int FILE_DEVICE_SYSENV = 0x00000052;
        public const int FILE_DEVICE_VIRTUAL_BLOCK = 0x00000053;
        public const int FILE_DEVICE_POINT_OF_SERVICE = 0x00000054;
        public const int FILE_DEVICE_STORAGE_REPLICATION = 0x00000055;
        public const int FILE_DEVICE_TRUST_ENV = 0x00000056;
        public const int FILE_DEVICE_UCM = 0x00000057;
        public const int FILE_DEVICE_UCMTCPCI = 0x00000058;
        public const int FILE_DEVICE_PERSISTENT_MEMORY = 0x00000059;
        public const int FILE_DEVICE_NVDIMM = 0x0000005a;
        public const int FILE_DEVICE_HOLOGRAPHIC = 0x0000005b;
        public const int FILE_DEVICE_SDFXHCI = 0x0000005c;

        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 261
        //
        // Define the method codes for how buffers are passed for I/O and FS controls
        //

        public const int METHOD_BUFFERED = 0;
        public const int METHOD_IN_DIRECT = 1;
        public const int METHOD_OUT_DIRECT = 2;
        public const int METHOD_NEITHER = 3;

        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 270
        //
        // Define some easier to comprehend aliases:
        //   METHOD_DIRECT_TO_HARDWARE (writes, aka METHOD_IN_DIRECT)
        //   METHOD_DIRECT_FROM_HARDWARE (reads, aka METHOD_OUT_DIRECT)
        //

        public const int METHOD_DIRECT_TO_HARDWARE = METHOD_IN_DIRECT;
        public const int METHOD_DIRECT_FROM_HARDWARE = METHOD_OUT_DIRECT;

        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 279
        //
        // Define the access check value for any access
        //
        //
        // The FILE_READ_ACCESS and FILE_WRITE_ACCESS constants are also defined in
        // ntioapi.h as FILE_READ_DATA and FILE_WRITE_DATA. The values for these
        // constants *MUST* always be in sync.
        //
        //
        // FILE_SPECIAL_ACCESS is checked by the NT I/O system the same as FILE_ANY_ACCESS.
        // The file systems, however, may add additional access checks for I/O and FS controls
        // that use this value.
        //


        public const int FILE_ANY_ACCESS = 0;
        public const int FILE_SPECIAL_ACCESS = FILE_ANY_ACCESS;
        public const int FILE_READ_ACCESS = 0x0001;    // file & pipe
        public const int FILE_WRITE_ACCESS = 0x0002;    // file & pipe

        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 320
        //
        // IoControlCode values for storage devices
        //

        public const int IOCTL_STORAGE_BASE = FILE_DEVICE_MASS_STORAGE;

        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 326
        //
        // The following device control codes are common for all class drivers.  They
        // should be used in place of the older IOCTL_DISK, IOCTL_CDROM and IOCTL_TAPE
        // common codes
        //

        public const int IOCTL_STORAGE_CHECK_VERIFY = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0200 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_CHECK_VERIFY2 = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0200 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_MEDIA_REMOVAL = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0201 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_EJECT_MEDIA = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0202 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_LOAD_MEDIA = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0203 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_LOAD_MEDIA2 = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0203 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_RESERVE = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0204 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_RELEASE = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0205 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_FIND_NEW_DEVICES = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0206 << 2) | METHOD_BUFFERED;

        public const int IOCTL_STORAGE_EJECTION_CONTROL = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0250 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_MCN_CONTROL = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0251 << 2) | METHOD_BUFFERED;

        public const int IOCTL_STORAGE_GET_MEDIA_TYPES = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0300 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_GET_MEDIA_TYPES_EX = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0301 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_GET_MEDIA_SERIAL_NUMBER = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0304 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_GET_HOTPLUG_INFO = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0305 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_SET_HOTPLUG_INFO = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0306 << 2) | METHOD_BUFFERED;

        public const int IOCTL_STORAGE_RESET_BUS = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0400 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_RESET_DEVICE = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0401 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_BREAK_RESERVATION = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0405 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_PERSISTENT_RESERVE_IN = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0406 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_PERSISTENT_RESERVE_OUT = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0407 << 2) | METHOD_BUFFERED;

        public const int IOCTL_STORAGE_GET_DEVICE_NUMBER = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0420 << 2) | METHOD_BUFFERED;

        //
        // This IOCTL includes the same information as IOCTL_STORAGE_GET_DEVICE_NUMBER, plus the device GUID.
        //
        public const int IOCTL_STORAGE_GET_DEVICE_NUMBER_EX = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0421 << 2) | METHOD_BUFFERED;


        public const int IOCTL_STORAGE_PREDICT_FAILURE = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0440 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_FAILURE_PREDICTION_CONFIG = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0441 << 2) | METHOD_BUFFERED;

        //
        // This IOCTL retrieves reliability counters for a device.
        //
        public const int IOCTL_STORAGE_GET_COUNTERS = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x442 << 2) | METHOD_BUFFERED;

        public const int IOCTL_STORAGE_READ_CAPACITY = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0450 << 2) | METHOD_BUFFERED;

        //
        // IOCTLs 0x0463 to 0x0468 reserved for dependent disk support.
        //


        //
        // IOCTLs 0x0470 to 0x047f reserved for device and stack telemetry interfaces
        //

        public const int IOCTL_STORAGE_GET_DEVICE_TELEMETRY = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0470 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_DEVICE_TELEMETRY_NOTIFY = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0471 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_DEVICE_TELEMETRY_QUERY_CAPS = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0472 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_GET_DEVICE_TELEMETRY_RAW = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0473 << 2) | METHOD_BUFFERED;


        public const int IOCTL_STORAGE_SET_TEMPERATURE_THRESHOLD = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0480 << 2) | METHOD_BUFFERED;

        public const int IOCTL_STORAGE_PROTOCOL_COMMAND = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x04F0 << 2) | METHOD_BUFFERED;

        public const int IOCTL_STORAGE_QUERY_PROPERTY = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0500 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_MANAGE_DATA_SET_ATTRIBUTES = (IOCTL_STORAGE_BASE << 16) | (FILE_WRITE_ACCESS << 14) | (0x0501 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_GET_LB_PROVISIONING_MAP_RESOURCES = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0502 << 2) | METHOD_BUFFERED;

        public const int IOCTL_STORAGE_SET_PROPERTY = (IOCTL_STORAGE_BASE << 16) | (FILE_WRITE_ACCESS << 14) | (0x0503 << 2) | METHOD_BUFFERED;

        //
        // IOCTLs 0x0503 to 0x0580 reserved for Enhanced Storage devices.
        //

        //
        // This IOCTL offloads the erasure process to the storage device. There is no guarantee as to the successful
        // deletion or recoverability of the data on the storage device after command completion. This IOCTL is limited
        // to data disks in regular Windows. In WinPE, this IOCTL is supported for both boot and data disks.
        //
        // Initial implementation requires no input and returns no output other than status. Callers should first
        // call FSCTL_LOCK_VOLUME before calling this ioctl to flush out cached data in upper layers. No waiting of
        // outstanding request completion is done before issuing the command to the device.
        //
        public const int IOCTL_STORAGE_REINITIALIZE_MEDIA = (IOCTL_STORAGE_BASE << 16) | (FILE_WRITE_ACCESS << 14) | (0x0590 << 2) | METHOD_BUFFERED;


        //
        // IOCTLs for bandwidth contracts on storage devices
        // (Move this to ntddsfio if we decide to use a new base)
        //

        public const int IOCTL_STORAGE_GET_BC_PROPERTIES = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS << 14) | (0x0600 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_ALLOCATE_BC_STREAM = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0601 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_FREE_BC_STREAM = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0602 << 2) | METHOD_BUFFERED;

        //
        // IOCTL to check for priority support
        //
        public const int IOCTL_STORAGE_CHECK_PRIORITY_HINT_SUPPORT = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0620 << 2) | METHOD_BUFFERED;

        //
        // IOCTL for data integrity check support
        //

        public const int IOCTL_STORAGE_START_DATA_INTEGRITY_CHECK = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0621 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_STOP_DATA_INTEGRITY_CHECK = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0622 << 2) | METHOD_BUFFERED;

        //
        // These ioctl codes are obsolete.  They are defined here to avoid resuing them
        // and to allow class drivers to respond to them more easily.
        //

        public const int OBSOLETE_IOCTL_STORAGE_RESET_BUS = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0400 << 2) | METHOD_BUFFERED;
        public const int OBSOLETE_IOCTL_STORAGE_RESET_DEVICE = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0401 << 2) | METHOD_BUFFERED;

        //
        // IOCTLs 0x0643 to 0x0655 reserved for VHD disk support.
        //


        //
        // IOCTLs for firmware upgrade on storage devices
        //

        public const int IOCTL_STORAGE_FIRMWARE_GET_INFO = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0700 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_FIRMWARE_DOWNLOAD = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0701 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_FIRMWARE_ACTIVATE = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0702 << 2) | METHOD_BUFFERED;


        //
        // IOCTL to support Idle Power Management, including Device Wake
        //
        public const int IOCTL_STORAGE_ENABLE_IDLE_POWER = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0720 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_GET_IDLE_POWERUP_REASON = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0721 << 2) | METHOD_BUFFERED;

        //
        // IOCTLs to allow class drivers to acquire and release active references on
        // a unit.  These should only be used if the class driver previously sent a
        // successful IOCTL_STORAGE_ENABLE_IDLE_POWER request to the port driver.
        //
        public const int IOCTL_STORAGE_POWER_ACTIVE = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0722 << 2) | METHOD_BUFFERED;
        public const int IOCTL_STORAGE_POWER_IDLE = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0723 << 2) | METHOD_BUFFERED;

        //
        // This IOCTL indicates that the physical device has triggered some sort of event.
        //
        public const int IOCTL_STORAGE_EVENT_NOTIFICATION = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0724 << 2) | METHOD_BUFFERED;

        //
        // IOCTL to specify a power cap for a storage device.
        //
        public const int IOCTL_STORAGE_DEVICE_POWER_CAP = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0725 << 2) | METHOD_BUFFERED;

        //
        // IOCTL to send commands to the RPMB for a storage device.
        //
        public const int IOCTL_STORAGE_RPMB_COMMAND = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0726 << 2) | METHOD_BUFFERED;

        //
        // IOCTL to manage attributes for storage devices
        //
        public const int IOCTL_STORAGE_ATTRIBUTE_MANAGEMENT = (IOCTL_STORAGE_BASE << 16) | (FILE_READ_ACCESS | FILE_WRITE_ACCESS << 14) | (0x0727 << 2) | METHOD_BUFFERED;

        //
        // IOCTL_STORAGE_DIAGNOSTIC IOCTL to query diagnostic data from the storage driver stack
        //
        public const int IOCTL_STORAGE_DIAGNOSTIC = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0728 << 2) | METHOD_BUFFERED;

        //
        // IOCTLs for storage device depopulation support.
        //

        //
        // IOCTL_STORAGE_GET_PHYSICAL_ELEMENT_STATUS IOCTL to query physical element status from device.
        //
        public const int IOCTL_STORAGE_GET_PHYSICAL_ELEMENT_STATUS = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0729 << 2) | METHOD_BUFFERED;

        //
        // IOCTL_STORAGE_REMOVE_ELEMENT_AND_TRUNCATE IOCTL to remove and truncate element from device.
        //
        public const int IOCTL_STORAGE_REMOVE_ELEMENT_AND_TRUNCATE = (IOCTL_STORAGE_BASE << 16) | (FILE_ANY_ACCESS << 14) | (0x0730 << 2) | METHOD_BUFFERED;


        //
        // Note: Function code values of less than 0x800 are reserved for Microsoft. Values of 0x800 and higher can be used by vendors.
        //       So do not use function code of 0x800 and higher to define new IOCTLs in this file.
        //
    }
}

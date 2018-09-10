#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace THNETII.WinApiNative.NTStatus
{
    /// <summary>
    /// Constant definitions for the NTSTATUS values.
    /// </summary>
    public static class NTStatusConstants
    {
        /// <summary>
        /// The success status codes 0 - 63 are reserved for wait completion status.
        /// FacilityCodes 0x5 - 0xF have been allocated by various drivers.
        /// </summary>
        public const int STATUS_WAIT_0 = 0x00000000; // winnt

        //
        //  Values are 32 bit values laid out as follows:
        //
        //   3 3 2 2 2 2 2 2 2 2 2 2 1 1 1 1 1 1 1 1 1 1
        //   1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0
        //  +---+-+-+-----------------------+-------------------------------+
        //  |Sev|C|R|     Facility          |               Code            |
        //  +---+-+-+-----------------------+-------------------------------+
        //
        //  where
        //
        //      Sev - is the severity code
        //
        //          00 - Success
        //          01 - Informational
        //          10 - Warning
        //          11 - Error
        //
        //      C - is the Customer code flag
        //
        //      R - is a reserved bit
        //
        //      Facility - is the facility code
        //
        //      Code - is the facility's status code
        //

        //
        // Define the facility codes
        //

        public const int FACILITY_DEBUGGER = 0x1;
        public const int FACILITY_RPC_RUNTIME = 0x2;
        public const int FACILITY_RPC_STUBS = 0x3;
        public const int FACILITY_IO_ERROR_CODE = 0x4;
        public const int FACILITY_CODCLASS_ERROR_CODE = 0x6;
        public const int FACILITY_NTWIN32 = 0x7;
        public const int FACILITY_NTCERT = 0x8;
        public const int FACILITY_NTSSPI = 0x9;
        public const int FACILITY_TERMINAL_SERVER = 0xA;
        public const int FACILTIY_MUI_ERROR_CODE = 0xB;
        public const int FACILITY_USB_ERROR_CODE = 0x10;
        public const int FACILITY_HID_ERROR_CODE = 0x11;
        public const int FACILITY_FIREWIRE_ERROR_CODE = 0x12;
        public const int FACILITY_CLUSTER_ERROR_CODE = 0x13;
        public const int FACILITY_ACPI_ERROR_CODE = 0x14;
        public const int FACILITY_SXS_ERROR_CODE = 0x15;
        public const int FACILITY_TRANSACTION = 0x19;
        public const int FACILITY_COMMONLOG = 0x1A;
        public const int FACILITY_VIDEO = 0x1B;
        public const int FACILITY_FILTER_MANAGER = 0x1C;
        public const int FACILITY_MONITOR = 0x1D;
        public const int FACILITY_GRAPHICS_KERNEL = 0x1E;
        public const int FACILITY_DRIVER_FRAMEWORK = 0x20;
        public const int FACILITY_FVE_ERROR_CODE = 0x21;
        public const int FACILITY_FWP_ERROR_CODE = 0x22;
        public const int FACILITY_NDIS_ERROR_CODE = 0x23;
        public const int FACILITY_TPM = 0x29;
        public const int FACILITY_RTPM = 0x2A;
        public const int FACILITY_HYPERVISOR = 0x35;
        public const int FACILITY_IPSEC = 0x36;
        public const int FACILITY_VIRTUALIZATION = 0x37;
        public const int FACILITY_VOLMGR = 0x38;
        public const int FACILITY_BCD_ERROR_CODE = 0x39;
        public const int FACILITY_WIN32K_NTUSER = 0x3E;
        public const int FACILITY_WIN32K_NTGDI = 0x3F;
        public const int FACILITY_RESUME_KEY_FILTER = 0x40;
        public const int FACILITY_RDBSS = 0x41;
        public const int FACILITY_BTH_ATT = 0x42;
        public const int FACILITY_SECUREBOOT = 0x43;
        public const int FACILITY_AUDIO_KERNEL = 0x44;
        public const int FACILITY_VSM = 0x45;
        public const int FACILITY_VOLSNAP = 0x50;
        public const int FACILITY_SDBUS = 0x51;
        public const int FACILITY_SHARED_VHDX = 0x5C;
        public const int FACILITY_SMB = 0x5D;
        public const int FACILITY_INTERIX = 0x99;
        public const int FACILITY_SPACES = 0xE7;
        public const int FACILITY_SECURITY_CORE = 0xE8;
        public const int FACILITY_SYSTEM_INTEGRITY = 0xE9;
        public const int FACILITY_LICENSING = 0xEA;
        public const int FACILITY_PLATFORM_MANIFEST = 0xEB;
        public const int FACILITY_APP_EXEC = 0xEC;
        public const int FACILITY_MAXIMUM_VALUE = 0xED;


        //
        // Define the severity codes
        //

        public const int STATUS_SEVERITY_SUCCESS = 0x0;
        public const int STATUS_SEVERITY_INFORMATIONAL = 0x1;
        public const int STATUS_SEVERITY_WARNING = 0x2;
        public const int STATUS_SEVERITY_ERROR = 0x3;

        /// <summary>
        /// STATUS_SUCCESS
        /// </summary>
        public const int STATUS_SUCCESS = 0x00000000; // ntsubauth

        /// <summary>
        /// STATUS_WAIT_1
        /// </summary>
        public const int STATUS_WAIT_1 = 0x00000001;

        /// <summary>
        /// STATUS_WAIT_2
        /// </summary>
        public const int STATUS_WAIT_2 = 0x00000002;

        /// <summary>
        /// STATUS_WAIT_3
        /// </summary>
        public const int STATUS_WAIT_3 = 0x00000003;

        /// <summary>
        /// STATUS_WAIT_63
        /// </summary>
        public const int STATUS_WAIT_63 = 0x0000003F;


        /// <summary>
        /// The success status codes 128 - 191 are reserved for wait completion
        /// status with an abandoned mutant object.
        /// </summary>
        public const int STATUS_ABANDONED = 0x00000080;

        /// <summary>
        /// STATUS_ABANDONED_WAIT_0
        /// </summary>
        public const int STATUS_ABANDONED_WAIT_0 = 0x00000080; // winnt

        /// <summary>
        /// STATUS_ABANDONED_WAIT_63
        /// </summary>
        public const int STATUS_ABANDONED_WAIT_63 = 0x000000BF;


        //
        // The success status codes 256, 257, 258, and 258 are reserved for
        // User APC, Kernel APC, Alerted, and Timeout.
        //

        /// <summary>
        /// STATUS_USER_APC
        /// </summary>
        public const int STATUS_USER_APC = 0x000000C0; // winnt

        /// <summary>
        /// The requested action was completed by an earlier operation.
        /// </summary>
        public const int STATUS_ALREADY_COMPLETE = 0x000000FF;

        /// <summary>
        /// STATUS_KERNEL_APC
        /// </summary>
        public const int STATUS_KERNEL_APC = 0x00000100;

        /// <summary>
        /// STATUS_ALERTED
        /// </summary>
        public const int STATUS_ALERTED = 0x00000101;

        /// <summary>
        /// STATUS_TIMEOUT
        /// </summary>
        public const int STATUS_TIMEOUT = 0x00000102; // winnt

        /// <summary>
        /// The operation that was requested is pending completion.
        /// </summary>
        public const int STATUS_PENDING = 0x00000103; // winnt

        /// <summary>
        /// A reparse should be performed by the Object Manager since the name of the file resulted in a symbolic link.
        /// </summary>
        public const int STATUS_REPARSE = 0x00000104;

        /// <summary>
        /// Returned by enumeration APIs to indicate more information is available to successive calls.
        /// </summary>
        public const int STATUS_MORE_ENTRIES = 0x00000105;

        /// <summary>
        /// Indicates not all privileges or groups referenced are assigned to the caller.
        /// This allows, for example, all privileges to be disabled without having to know exactly which privileges are assigned.
        /// </summary>
        public const int STATUS_NOT_ALL_ASSIGNED = 0x00000106;

        /// <summary>
        /// Some of the information to be translated has not been translated.
        /// </summary>
        public const int STATUS_SOME_NOT_MAPPED = 0x00000107;

        /// <summary>
        /// An open/create operation completed while an oplock break is underway.
        /// </summary>
        public const int STATUS_OPLOCK_BREAK_IN_PROGRESS = 0x00000108;

        /// <summary>
        /// A new volume has been mounted by a file system.
        /// </summary>
        public const int STATUS_VOLUME_MOUNTED = 0x00000109;

        /// <summary>
        /// This success level status indicates that the transaction state already exists for the registry sub-tree, but that a transaction commit was previously aborted. The commit has now been completed.
        /// </summary>
        public const int STATUS_RXACT_COMMITTED = 0x0000010A;

        /// <summary>
        /// This indicates that a notify change request has been completed due to closing the handle which made the notify change request.
        /// </summary>
        public const int STATUS_NOTIFY_CLEANUP = 0x0000010B;

        /// <summary>
        /// This indicates that a notify change request is being completed and that the information is not being returned in the caller's buffer.
        /// The caller now needs to enumerate the files to find the changes.
        /// </summary>
        public const int STATUS_NOTIFY_ENUM_DIR = 0x0000010C;

        /// <summary>
        /// {No Quotas}
        /// No system quota limits are specifically set for this account.
        /// </summary>
        public const int STATUS_NO_QUOTAS_FOR_ACCOUNT = 0x0000010D;

        /// <summary>
        /// {Connect Failure on Primary Transport}
        /// An attempt was made to connect to the remote server %hs on the primary transport, but the connection failed.
        /// The computer WAS able to connect on a secondary transport.
        /// </summary>
        public const int STATUS_PRIMARY_TRANSPORT_CONNECT_FAILED = 0x0000010E;

        /// <summary>
        /// Page fault was a transition fault.
        /// </summary>
        public const int STATUS_PAGE_FAULT_TRANSITION = 0x00000110;

        /// <summary>
        /// Page fault was a demand zero fault.
        /// </summary>
        public const int STATUS_PAGE_FAULT_DEMAND_ZERO = 0x00000111;

        /// <summary>
        /// Page fault was a demand zero fault.
        /// </summary>
        public const int STATUS_PAGE_FAULT_COPY_ON_WRITE = 0x00000112;

        /// <summary>
        /// Page fault was a demand zero fault.
        /// </summary>
        public const int STATUS_PAGE_FAULT_GUARD_PAGE = 0x00000113;

        /// <summary>
        /// Page fault was satisfied by reading from a secondary storage device.
        /// </summary>
        public const int STATUS_PAGE_FAULT_PAGING_FILE = 0x00000114;

        /// <summary>
        /// Cached page was locked during operation.
        /// </summary>
        public const int STATUS_CACHE_PAGE_LOCKED = 0x00000115;

        /// <summary>
        /// Crash dump exists in paging file.
        /// </summary>
        public const int STATUS_CRASH_DUMP = 0x00000116;

        /// <summary>
        /// Specified buffer contains all zeros.
        /// </summary>
        public const int STATUS_BUFFER_ALL_ZEROS = 0x00000117;

        /// <summary>
        /// A reparse should be performed by the Object Manager since the name of the file resulted in a symbolic link.
        /// </summary>
        public const int STATUS_REPARSE_OBJECT = 0x00000118;

        /// <summary>
        /// The device has succeeded a query-stop and its resource requirements have changed.
        /// </summary>
        public const int STATUS_RESOURCE_REQUIREMENTS_CHANGED = 0x00000119;

        /// <summary>
        /// The translator has translated these resources into the global space and no further translations should be performed.
        /// </summary>
        public const int STATUS_TRANSLATION_COMPLETE = 0x00000120;

        /// <summary>
        /// The directory service evaluated group memberships locally, as it was unable to contact a global catalog server.
        /// </summary>
        public const int STATUS_DS_MEMBERSHIP_EVALUATED_LOCALLY = 0x00000121;

        /// <summary>
        /// A process being terminated has no threads to terminate.
        /// </summary>
        public const int STATUS_NOTHING_TO_TERMINATE = 0x00000122;

        /// <summary>
        /// The specified process is not part of a job.
        /// </summary>
        public const int STATUS_PROCESS_NOT_IN_JOB = 0x00000123;

        /// <summary>
        /// The specified process is part of a job.
        /// </summary>
        public const int STATUS_PROCESS_IN_JOB = 0x00000124;

        /// <summary>
        /// {Volume Shadow Copy Service}
        /// The system is now ready for hibernation.
        /// </summary>
        public const int STATUS_VOLSNAP_HIBERNATE_READY = 0x00000125;

        /// <summary>
        /// A file system or file system filter driver has successfully completed an FsFilter operation.
        /// </summary>
        public const int STATUS_FSFILTER_OP_COMPLETED_SUCCESSFULLY = 0x00000126;

        /// <summary>
        /// The specified interrupt vector was already connected.
        /// </summary>
        public const int STATUS_INTERRUPT_VECTOR_ALREADY_CONNECTED = 0x00000127;

        /// <summary>
        /// The specified interrupt vector is still connected.
        /// </summary>
        public const int STATUS_INTERRUPT_STILL_CONNECTED = 0x00000128;

        /// <summary>
        /// The current process is a cloned process.
        /// </summary>
        public const int STATUS_PROCESS_CLONED = 0x00000129;

        /// <summary>
        /// The file was locked and all users of the file can only read.
        /// </summary>
        public const int STATUS_FILE_LOCKED_WITH_ONLY_READERS = 0x0000012A;

        /// <summary>
        /// The file was locked and at least one user of the file can write.
        /// </summary>
        public const int STATUS_FILE_LOCKED_WITH_WRITERS = 0x0000012B;

        /// <summary>
        /// The file image hash is valid.
        /// </summary>
        public const int STATUS_VALID_IMAGE_HASH = 0x0000012C;

        /// <summary>
        /// The file catalog hash is valid.
        /// </summary>
        public const int STATUS_VALID_CATALOG_HASH = 0x0000012D;

        /// <summary>
        /// The file hash is valid and uses strong code integrity.
        /// </summary>
        public const int STATUS_VALID_STRONG_CODE_HASH = 0x0000012E;

        /// <summary>
        /// At least a portion of IO range intersects with a ghosted file range.
        /// </summary>
        public const int STATUS_GHOSTED = 0x0000012F;

        /// <summary>
        /// A completed operation may have overwritten previous data.
        /// </summary>
        public const int STATUS_DATA_OVERWRITTEN = 0x00000130;

        /// <summary>
        /// The specified ResourceManager made no changes or updates to the resource under this transaction.
        /// </summary>
        public const int STATUS_RESOURCEMANAGER_READ_ONLY = 0x00000202;

        /// <summary>
        /// The specified ring buffer was empty before the packet was successfully inserted.
        /// </summary>
        public const int STATUS_RING_PREVIOUSLY_EMPTY = 0x00000210;

        /// <summary>
        /// The specified ring buffer was full before the packet was successfully removed.
        /// </summary>
        public const int STATUS_RING_PREVIOUSLY_FULL = 0x00000211;

        /// <summary>
        /// The specified ring buffer has dropped below its quota of outstanding transactions.
        /// </summary>
        public const int STATUS_RING_PREVIOUSLY_ABOVE_QUOTA = 0x00000212;

        /// <summary>
        /// The specified ring buffer has, with the removal of the current packet, now become empty.
        /// </summary>
        public const int STATUS_RING_NEWLY_EMPTY = 0x00000213;

        /// <summary>
        /// The specified ring buffer was either previously empty or previously full which implies that the caller should signal the opposite endpoint.
        /// </summary>
        public const int STATUS_RING_SIGNAL_OPPOSITE_ENDPOINT = 0x00000214;

        /// <summary>
        /// The oplock that was associated with this handle is now associated with a different handle.
        /// </summary>
        public const int STATUS_OPLOCK_SWITCHED_TO_NEW_HANDLE = 0x00000215;

        /// <summary>
        /// The handle with which this oplock was associated has been closed.  The oplock is now broken.
        /// </summary>
        public const int STATUS_OPLOCK_HANDLE_CLOSED = 0x00000216;

        /// <summary>
        /// An operation is blocked waiting for an oplock.
        /// </summary>
        public const int STATUS_WAIT_FOR_OPLOCK = 0x00000367;

        /// <summary>
        /// A reparse should be performed by the Object Manager from the global root to escape the container name space.
        /// </summary>
        public const int STATUS_REPARSE_GLOBAL = 0x00000368;

        /// <summary>
        /// Debugger handled exception
        /// </summary>
        public const int DBG_EXCEPTION_HANDLED = 0x00010001; // winnt

        /// <summary>
        /// Debugger continued
        /// </summary>
        public const int DBG_CONTINUE = 0x00010002; // winnt

        /// <summary>
        /// The IO was completed by a filter.
        /// </summary>
        public const int STATUS_FLT_IO_COMPLETE = 0x001C0001;

        /////////////////////////////////////////////////////////////////////////
        //
        // Standard Information values
        //
        /////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// {Object Exists}
        /// An attempt was made to create an object and the object name already existed.
        /// </summary>
        public const int STATUS_OBJECT_NAME_EXISTS = 0x40000000;

        /// <summary>
        /// {Thread Suspended}
        /// A thread termination occurred while the thread was suspended. The thread was resumed, and termination proceeded.
        /// </summary>
        public const int STATUS_THREAD_WAS_SUSPENDED = 0x40000001;

        /// <summary>
        /// {Working Set Range Error}
        /// An attempt was made to set the working set minimum or maximum to values which are outside of the allowable range.
        /// </summary>
        public const int STATUS_WORKING_SET_LIMIT_RANGE = 0x40000002;

        /// <summary>
        /// {Image Relocated}
        /// An image file could not be mapped at the address specified in the image file. Local fixups must be performed on this image.
        /// </summary>
        public const int STATUS_IMAGE_NOT_AT_BASE = 0x40000003;

        /// <summary>
        /// This informational level status indicates that a specified registry sub-tree transaction state did not yet exist and had to be created.
        /// </summary>
        public const int STATUS_RXACT_STATE_CREATED = 0x40000004;

        /// <summary>
        /// {Segment Load}
        /// A virtual DOS machine (VDM) is loading, unloading, or moving an MS-DOS or Win16 program segment image.
        /// An exception is raised so a debugger can load, unload or track symbols and breakpoints within these 16-bit segments.
        /// </summary>
        public const int STATUS_SEGMENT_NOTIFICATION = 0x40000005; // winnt

        /// <summary>
        /// {Local Session Key}
        /// A user session key was requested for a local RPC connection. The session key returned is a constant value and not unique to this connection.
        /// </summary>
        public const int STATUS_LOCAL_USER_SESSION_KEY = 0x40000006;

        /// <summary>
        /// {Invalid Current Directory}
        /// The process cannot switch to the startup current directory %hs.
        /// Select OK to set current directory to %hs, or select CANCEL to exit.
        /// </summary>
        public const int STATUS_BAD_CURRENT_DIRECTORY = 0x40000007;

        /// <summary>
        /// {Serial IOCTL Complete}
        /// A serial I/O operation was completed by another write to a serial port.
        /// (The IOCTL_SERIAL_XOFF_COUNTER reached zero.)
        /// </summary>
        public const int STATUS_SERIAL_MORE_WRITES = 0x40000008;

        /// <summary>
        /// {Registry Recovery}
        /// One of the files containing the system's Registry data had to be recovered by use of a log or alternate copy. The recovery was successful.
        /// </summary>
        public const int STATUS_REGISTRY_RECOVERED = 0x40000009;

        /// <summary>
        /// {Redundant Read}
        /// To satisfy a read request, the NT fault-tolerant file system successfully read the requested data from a redundant copy.
        /// This was done because the file system encountered a failure on a member of the fault-tolerant volume, but was unable to reassign the failing area of the device.
        /// </summary>
        public const int STATUS_FT_READ_RECOVERY_FROM_BACKUP = 0x4000000A;

        /// <summary>
        /// {Redundant Write}
        /// To satisfy a write request, the NT fault-tolerant file system successfully wrote a redundant copy of the information.
        /// This was done because the file system encountered a failure on a member of the fault-tolerant volume, but was not able to reassign the failing area of the device.
        /// </summary>
        public const int STATUS_FT_WRITE_RECOVERY = 0x4000000B;

        /// <summary>
        /// {Serial IOCTL Timeout}
        /// A serial I/O operation completed because the time-out period expired. (The IOCTL_SERIAL_XOFF_COUNTER had not reached zero.)
        /// </summary>
        public const int STATUS_SERIAL_COUNTER_TIMEOUT = 0x4000000C;

        /// <summary>
        /// {Password Too Complex}
        /// The Windows password is too complex to be converted to a LAN Manager password. The LAN Manager password returned is a NULL string.
        /// </summary>
        public const int STATUS_NULL_LM_PASSWORD = 0x4000000D;

        /// <summary>
        /// {Machine Type Mismatch}
        /// The image file %hs is valid, but is for a machine type other than the current machine. Select OK to continue, or CANCEL to fail the DLL load.
        /// </summary>
        public const int STATUS_IMAGE_MACHINE_TYPE_MISMATCH = 0x4000000E;

        /// <summary>
        /// {Partial Data Received}
        /// The network transport returned partial data to its client. The remaining data will be sent later.
        /// </summary>
        public const int STATUS_RECEIVE_PARTIAL = 0x4000000F;

        /// <summary>
        /// {Expedited Data Received}
        /// The network transport returned data to its client that was marked as expedited by the remote system.
        /// </summary>
        public const int STATUS_RECEIVE_EXPEDITED = 0x40000010;

        /// <summary>
        /// {Partial Expedited Data Received}
        /// The network transport returned partial data to its client and this data was marked as expedited by the remote system. The remaining data will be sent later.
        /// </summary>
        public const int STATUS_RECEIVE_PARTIAL_EXPEDITED = 0x40000011;

        /// <summary>
        /// {TDI Event Done}
        /// The TDI indication has completed successfully.
        /// </summary>
        public const int STATUS_EVENT_DONE = 0x40000012;

        /// <summary>
        /// {TDI Event Pending}
        /// The TDI indication has entered the pending state.
        /// </summary>
        public const int STATUS_EVENT_PENDING = 0x40000013;

        /// <summary>
        /// Checking file system on %wZ
        /// </summary>
        public const int STATUS_CHECKING_FILE_SYSTEM = 0x40000014;

        /// <summary>
        /// {Fatal Application Exit}
        /// %hs
        /// </summary>
        public const int STATUS_FATAL_APP_EXIT = 0x40000015; // winnt

        /// <summary>
        /// The specified registry key is referenced by a predefined handle.
        /// </summary>
        public const int STATUS_PREDEFINED_HANDLE = 0x40000016;

        /// <summary>
        /// {Page Unlocked}
        /// The page protection of a locked page was changed to 'No Access' and the page was unlocked from memory and from the process.
        /// </summary>
        public const int STATUS_WAS_UNLOCKED = 0x40000017;

        /// <summary>
        /// %hs
        /// </summary>
        public const int STATUS_SERVICE_NOTIFICATION = 0x40000018;

        /// <summary>
        /// {Page Locked}
        /// One of the pages to lock was already locked.
        /// </summary>
        public const int STATUS_WAS_LOCKED = 0x40000019;

        /// <summary>
        /// Application popup: %1 : %2
        /// </summary>
        public const int STATUS_LOG_HARD_ERROR = 0x4000001A;

        /// <summary>
        /// STATUS_ALREADY_WIN32
        /// </summary>
        public const int STATUS_ALREADY_WIN32 = 0x4000001B;

        /// <summary>
        /// Exception status code used by Win32 x86 emulation subsystem.
        /// </summary>
        public const int STATUS_WX86_UNSIMULATE = 0x4000001C;

        /// <summary>
        /// Exception status code used by Win32 x86 emulation subsystem.
        /// </summary>
        public const int STATUS_WX86_CONTINUE = 0x4000001D;

        /// <summary>
        /// Exception status code used by Win32 x86 emulation subsystem.
        /// </summary>
        public const int STATUS_WX86_SINGLE_STEP = 0x4000001E;

        /// <summary>
        /// Exception status code used by Win32 x86 emulation subsystem.
        /// </summary>
        public const int STATUS_WX86_BREAKPOINT = 0x4000001F;

        /// <summary>
        /// Exception status code used by Win32 x86 emulation subsystem.
        /// </summary>
        public const int STATUS_WX86_EXCEPTION_CONTINUE = 0x40000020;

        /// <summary>
        /// Exception status code used by Win32 x86 emulation subsystem.
        /// </summary>
        public const int STATUS_WX86_EXCEPTION_LASTCHANCE = 0x40000021;

        /// <summary>
        /// Exception status code used by Win32 x86 emulation subsystem.
        /// </summary>
        public const int STATUS_WX86_EXCEPTION_CHAIN = 0x40000022;

        /// <summary>
        /// {Machine Type Mismatch}
        /// The image file %hs is valid, but is for a machine type other than the current machine.
        /// </summary>
        public const int STATUS_IMAGE_MACHINE_TYPE_MISMATCH_EXE = 0x40000023;

        /// <summary>
        /// A yield execution was performed and no thread was available to run.
        /// </summary>
        public const int STATUS_NO_YIELD_PERFORMED = 0x40000024;

        /// <summary>
        /// The resumable flag to a timer API was ignored.
        /// </summary>
        public const int STATUS_TIMER_RESUME_IGNORED = 0x40000025;

        /// <summary>
        /// The arbiter has deferred arbitration of these resources to its parent
        /// </summary>
        public const int STATUS_ARBITRATION_UNHANDLED = 0x40000026;

        /// <summary>
        /// The device "%hs" has detected a CardBus card in its slot, but the firmware on this system is not configured to allow the CardBus controller to be run in CardBus mode.
        /// The operating system will currently accept only 16-bit (R2) pc-cards on this controller.
        /// </summary>
        public const int STATUS_CARDBUS_NOT_SUPPORTED = 0x40000027;

        /// <summary>
        /// Exception status code used by Win32 x86 emulation subsystem.
        /// </summary>
        public const int STATUS_WX86_CREATEWX86TIB = 0x40000028;

        /// <summary>
        /// The CPUs in this multiprocessor system are not all the same revision level. To use all processors the operating system restricts itself to the features of the least capable processor in the system. Should problems occur with this system, contact the CPU manufacturer to see if this mix of processors is supported.
        /// </summary>
        public const int STATUS_MP_PROCESSOR_MISMATCH = 0x40000029;

        /// <summary>
        /// The system was put into hibernation.
        /// </summary>
        public const int STATUS_HIBERNATED = 0x4000002A;

        /// <summary>
        /// The system was resumed from hibernation.
        /// </summary>
        public const int STATUS_RESUME_HIBERNATION = 0x4000002B;

        /// <summary>
        /// Windows has detected that the system firmware (BIOS) was updated [previous firmware date = %2, current firmware date %3].
        /// </summary>
        public const int STATUS_FIRMWARE_UPDATED = 0x4000002C;

        /// <summary>
        /// A device driver is leaking locked I/O pages causing system degradation. The system has automatically enabled tracking code in order to try and catch the culprit.
        /// </summary>
        public const int STATUS_DRIVERS_LEAKING_LOCKED_PAGES = 0x4000002D;

        /// <summary>
        /// The ALPC message being canceled has already been retrieved from the queue on the other side.
        /// </summary>
        public const int STATUS_MESSAGE_RETRIEVED = 0x4000002E;

        /// <summary>
        /// The system power state is transitioning from %2 to %3.
        /// </summary>
        public const int STATUS_SYSTEM_POWERSTATE_TRANSITION = 0x4000002F;

        /// <summary>
        /// The receive operation was successful. Check the ALPC completion list for the received message.
        /// </summary>
        public const int STATUS_ALPC_CHECK_COMPLETION_LIST = 0x40000030;

        /// <summary>
        /// The system power state is transitioning from %2 to %3 but could enter %4.
        /// </summary>
        public const int STATUS_SYSTEM_POWERSTATE_COMPLEX_TRANSITION = 0x40000031;

        /// <summary>
        /// Access to %1 is monitored by policy rule %2.
        /// </summary>
        public const int STATUS_ACCESS_AUDIT_BY_POLICY = 0x40000032;

        /// <summary>
        /// A valid hibernation file has been invalidated and should be abandoned.
        /// </summary>
        public const int STATUS_ABANDON_HIBERFILE = 0x40000033;

        /// <summary>
        /// Business rule scripts are disabled for the calling application.
        /// </summary>
        public const int STATUS_BIZRULES_NOT_ENABLED = 0x40000034;

        /// <summary>
        /// The specified copy of the requested data was successfully read.
        /// </summary>
        public const int STATUS_FT_READ_FROM_COPY = 0x40000035;

        /// <summary>
        /// {Image Relocated}
        /// An image file was mapped at a different address from the one specified in the image file but fixups will still be automatically performed on the image.
        /// </summary>
        public const int STATUS_IMAGE_AT_DIFFERENT_BASE = 0x40000036;

        /// <summary>
        /// Debugger will reply later.
        /// </summary>
        public const int DBG_REPLY_LATER = 0x40010001; // winnt

        /// <summary>
        /// Debugger cannot provide handle.
        /// </summary>
        public const int DBG_UNABLE_TO_PROVIDE_HANDLE = 0x40010002;

        /// <summary>
        /// Debugger terminated thread.
        /// </summary>
        public const int DBG_TERMINATE_THREAD = 0x40010003; // winnt

        /// <summary>
        /// Debugger terminated process.
        /// </summary>
        public const int DBG_TERMINATE_PROCESS = 0x40010004; // winnt

        /// <summary>
        /// Debugger got control C.
        /// </summary>
        public const int DBG_CONTROL_C = 0x40010005; // winnt

        /// <summary>
        /// Debugger printed exception on control C.
        /// </summary>
        public const int DBG_PRINTEXCEPTION_C = 0x40010006; // winnt

        /// <summary>
        /// Debugger received RIP exception.
        /// </summary>
        public const int DBG_RIPEXCEPTION = 0x40010007; // winnt

        /// <summary>
        /// Debugger received control break.
        /// </summary>
        public const int DBG_CONTROL_BREAK = 0x40010008; // winnt

        /// <summary>
        /// Debugger command communication exception.
        /// </summary>
        public const int DBG_COMMAND_EXCEPTION = 0x40010009; // winnt

        /// <summary>
        /// Debugger printed exception on control C.
        /// </summary>
        public const int DBG_PRINTEXCEPTION_WIDE_C = 0x4001000A; // winnt

        /// <summary>
        /// The attempt to commit the Transaction completed, but it is possible that some portion of the transaction tree did not commit successfully due to heuristics.  Therefore it is possible that some data modified in the transaction may not have committed, resulting in transactional inconsistency.  If possible, check the consistency of the associated data.
        /// </summary>
        public const int STATUS_HEURISTIC_DAMAGE_POSSIBLE = 0x40190001;



        /////////////////////////////////////////////////////////////////////////
        //
        // Standard Warning values
        //
        //
        // Note:  Do NOT use the value 0x80000000L, as this is a non-portable value
        //        for the NT_SUCCESS macro. Warning values start with a code of 1.
        //
        /////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// {EXCEPTION}
        /// Guard Page Exception
        /// A page of memory that marks the end of a data structure, such as a stack or an array, has been accessed.
        /// </summary>
        public const int STATUS_GUARD_PAGE_VIOLATION = unchecked((int)0x80000001); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Alignment Fault
        /// A datatype misalignment was detected in a load or store instruction.
        /// </summary>
        public const int STATUS_DATATYPE_MISALIGNMENT = unchecked((int)0x80000002); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Breakpoint
        /// A breakpoint has been reached.
        /// </summary>
        public const int STATUS_BREAKPOINT = unchecked((int)0x80000003); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Single Step
        /// A single step or trace operation has just been completed.
        /// </summary>
        public const int STATUS_SINGLE_STEP = unchecked((int)0x80000004); // winnt

        /// <summary>
        /// {Buffer Overflow}
        /// The data was too large to fit into the specified buffer.
        /// </summary>
        public const int STATUS_BUFFER_OVERFLOW = unchecked((int)0x80000005);

        /// <summary>
        /// {No More Files}
        /// No more files were found which match the file specification.
        /// </summary>
        public const int STATUS_NO_MORE_FILES = unchecked((int)0x80000006);

        /// <summary>
        /// {Kernel Debugger Awakened}
        /// the system debugger was awakened by an interrupt.
        /// </summary>
        public const int STATUS_WAKE_SYSTEM_DEBUGGER = unchecked((int)0x80000007);

        /// <summary>
        /// {Handles Closed}
        /// Handles to objects have been automatically closed as a result of the requested operation.
        /// </summary>
        public const int STATUS_HANDLES_CLOSED = unchecked((int)0x8000000A);

        /// <summary>
        /// {Non-Inheritable ACL}
        /// An access control list (ACL) contains no components that can be inherited.
        /// </summary>
        public const int STATUS_NO_INHERITANCE = unchecked((int)0x8000000B);

        /// <summary>
        /// {GUID Substitution}
        /// During the translation of a global identifier (GUID) to a Windows security ID (SID), no administratively-defined GUID prefix was found. A substitute prefix was used, which will not compromise system security. However, this may provide a more restrictive access than intended.
        /// </summary>
        public const int STATUS_GUID_SUBSTITUTION_MADE = unchecked((int)0x8000000C);

        /// <summary>
        /// {Partial Copy}
        /// Due to protection conflicts not all the requested bytes could be copied.
        /// </summary>
        public const int STATUS_PARTIAL_COPY = unchecked((int)0x8000000D);

        /// <summary>
        /// {Out of Paper}
        /// The printer is out of paper.
        /// </summary>
        public const int STATUS_DEVICE_PAPER_EMPTY = unchecked((int)0x8000000E);

        /// <summary>
        /// {Device Power Is Off}
        /// The printer power has been turned off.
        /// </summary>
        public const int STATUS_DEVICE_POWERED_OFF = unchecked((int)0x8000000F);

        /// <summary>
        /// {Device Offline}
        /// The printer has been taken offline.
        /// </summary>
        public const int STATUS_DEVICE_OFF_LINE = unchecked((int)0x80000010);

        /// <summary>
        /// {Device Busy}
        /// The device is currently busy.
        /// </summary>
        public const int STATUS_DEVICE_BUSY = unchecked((int)0x80000011);

        /// <summary>
        /// {No More EAs}
        /// No more extended attributes (EAs) were found for the file.
        /// </summary>
        public const int STATUS_NO_MORE_EAS = unchecked((int)0x80000012);

        /// <summary>
        /// {Illegal EA}
        /// The specified extended attribute (EA) name contains at least one illegal character.
        /// </summary>
        public const int STATUS_INVALID_EA_NAME = unchecked((int)0x80000013);

        /// <summary>
        /// {Inconsistent EA List}
        /// The extended attribute (EA) list is inconsistent.
        /// </summary>
        public const int STATUS_EA_LIST_INCONSISTENT = unchecked((int)0x80000014);

        /// <summary>
        /// {Invalid EA Flag}
        /// An invalid extended attribute (EA) flag was set.
        /// </summary>
        public const int STATUS_INVALID_EA_FLAG = unchecked((int)0x80000015);

        /// <summary>
        /// {Verifying Disk}
        /// The media has changed and a verify operation is in progress so no reads or writes may be performed to the device, except those used in the verify operation.
        /// </summary>
        public const int STATUS_VERIFY_REQUIRED = unchecked((int)0x80000016);

        /// <summary>
        /// {Too Much Information}
        /// The specified access control list (ACL) contained more information than was expected.
        /// </summary>
        public const int STATUS_EXTRANEOUS_INFORMATION = unchecked((int)0x80000017);

        /// <summary>
        /// This warning level status indicates that the transaction state already exists for the registry sub-tree, but that a transaction commit was previously aborted.
        /// The commit has NOT been completed, but has not been rolled back either (so it may still be committed if desired).
        /// </summary>
        public const int STATUS_RXACT_COMMIT_NECESSARY = unchecked((int)0x80000018);

        /// <summary>
        /// {No More Entries}
        /// No more entries are available from an enumeration operation.
        /// </summary>
        public const int STATUS_NO_MORE_ENTRIES = unchecked((int)0x8000001A);

        /// <summary>
        /// {Filemark Found}
        /// A filemark was detected.
        /// </summary>
        public const int STATUS_FILEMARK_DETECTED = unchecked((int)0x8000001B);

        /// <summary>
        /// {Media Changed}
        /// The media may have changed.
        /// </summary>
        public const int STATUS_MEDIA_CHANGED = unchecked((int)0x8000001C);

        /// <summary>
        /// {I/O Bus Reset}
        /// An I/O bus reset was detected.
        /// </summary>
        public const int STATUS_BUS_RESET = unchecked((int)0x8000001D);

        /// <summary>
        /// {End of Media}
        /// The end of the media was encountered.
        /// </summary>
        public const int STATUS_END_OF_MEDIA = unchecked((int)0x8000001E);

        /// <summary>
        /// Beginning of tape or partition has been detected.
        /// </summary>
        public const int STATUS_BEGINNING_OF_MEDIA = unchecked((int)0x8000001F);

        /// <summary>
        /// {Media Changed}
        /// The media may have changed.
        /// </summary>
        public const int STATUS_MEDIA_CHECK = unchecked((int)0x80000020);

        /// <summary>
        /// A tape access reached a setmark.
        /// </summary>
        public const int STATUS_SETMARK_DETECTED = unchecked((int)0x80000021);

        /// <summary>
        /// During a tape access, the end of the data written is reached.
        /// </summary>
        public const int STATUS_NO_DATA_DETECTED = unchecked((int)0x80000022);

        /// <summary>
        /// The redirector is in use and cannot be unloaded.
        /// </summary>
        public const int STATUS_REDIRECTOR_HAS_OPEN_HANDLES = unchecked((int)0x80000023);

        /// <summary>
        /// The server is in use and cannot be unloaded.
        /// </summary>
        public const int STATUS_SERVER_HAS_OPEN_HANDLES = unchecked((int)0x80000024);

        /// <summary>
        /// The specified connection has already been disconnected.
        /// </summary>
        public const int STATUS_ALREADY_DISCONNECTED = unchecked((int)0x80000025);

        /// <summary>
        /// A long jump has been executed.
        /// </summary>
        public const int STATUS_LONGJUMP = unchecked((int)0x80000026); // winnt

        /// <summary>
        /// A cleaner cartridge is present in the tape library.
        /// </summary>
        public const int STATUS_CLEANER_CARTRIDGE_INSTALLED = unchecked((int)0x80000027);

        /// <summary>
        /// The Plug and Play query operation was not successful.
        /// </summary>
        public const int STATUS_PLUGPLAY_QUERY_VETOED = unchecked((int)0x80000028);

        /// <summary>
        /// A frame consolidation has been executed.
        /// </summary>
        public const int STATUS_UNWIND_CONSOLIDATE = unchecked((int)0x80000029); // winnt

        /// <summary>
        /// {Registry Hive Recovered}
        /// Registry hive (file):
        /// %hs
        /// was corrupted and it has been recovered. Some data might have been lost.
        /// </summary>
        public const int STATUS_REGISTRY_HIVE_RECOVERED = unchecked((int)0x8000002A);

        /// <summary>
        /// The application is attempting to run executable code from the module %hs. This may be insecure. An alternative, %hs, is available. Should the application use the secure module %hs?
        /// </summary>
        public const int STATUS_DLL_MIGHT_BE_INSECURE = unchecked((int)0x8000002B);

        /// <summary>
        /// The application is loading executable code from the module %hs. This is secure, but may be incompatible with previous releases of the operating system. An alternative, %hs, is available. Should the application use the secure module %hs?
        /// </summary>
        public const int STATUS_DLL_MIGHT_BE_INCOMPATIBLE = unchecked((int)0x8000002C);

        /// <summary>
        /// The create operation stopped after reaching a symbolic link.
        /// </summary>
        public const int STATUS_STOPPED_ON_SYMLINK = unchecked((int)0x8000002D);

        /// <summary>
        /// An oplock of the requested level cannot be granted.  An oplock of a lower level may be available.
        /// </summary>
        public const int STATUS_CANNOT_GRANT_REQUESTED_OPLOCK = unchecked((int)0x8000002E);

        /// <summary>
        /// {No ACE Condition}
        /// The specified access control entry (ACE) does not contain a condition.
        /// </summary>
        public const int STATUS_NO_ACE_CONDITION = unchecked((int)0x8000002F);

        /// <summary>
        /// {Support Being Determined}
        /// Device's command support detection is in progress.
        /// </summary>
        public const int STATUS_DEVICE_SUPPORT_IN_PROGRESS = unchecked((int)0x80000030);

        /// <summary>
        /// The device needs to be power cycled.
        /// </summary>
        public const int STATUS_DEVICE_POWER_CYCLE_REQUIRED = unchecked((int)0x80000031);

        /// <summary>
        /// The action requested resulted in no work being done. Error-style clean-up has been performed.
        /// </summary>
        public const int STATUS_NO_WORK_DONE = unchecked((int)0x80000032);

        /// <summary>
        /// Debugger did not handle the exception.
        /// </summary>
        public const int DBG_EXCEPTION_NOT_HANDLED = unchecked((int)0x80010001); // winnt

        /// <summary>
        /// The cluster node is already up.
        /// </summary>
        public const int STATUS_CLUSTER_NODE_ALREADY_UP = unchecked((int)0x80130001);

        /// <summary>
        /// The cluster node is already down.
        /// </summary>
        public const int STATUS_CLUSTER_NODE_ALREADY_DOWN = unchecked((int)0x80130002);

        /// <summary>
        /// The cluster network is already online.
        /// </summary>
        public const int STATUS_CLUSTER_NETWORK_ALREADY_ONLINE = unchecked((int)0x80130003);

        /// <summary>
        /// The cluster network is already offline.
        /// </summary>
        public const int STATUS_CLUSTER_NETWORK_ALREADY_OFFLINE = unchecked((int)0x80130004);

        /// <summary>
        /// The cluster node is already a member of the cluster.
        /// </summary>
        public const int STATUS_CLUSTER_NODE_ALREADY_MEMBER = unchecked((int)0x80130005);

        /// <summary>
        /// {Buffer too small}
        /// The buffer is too small to contain the entry. No information has been written to the buffer.
        /// </summary>
        public const int STATUS_FLT_BUFFER_TOO_SMALL = unchecked((int)0x801C0001);

        /// <summary>
        /// Volume Metadata read or write is incomplete.
        /// </summary>
        public const int STATUS_FVE_PARTIAL_METADATA = unchecked((int)0x80210001);

        /// <summary>
        /// BitLocker encryption keys were ignored because the volume was in a transient state.
        /// </summary>
        public const int STATUS_FVE_TRANSIENT_STATE = unchecked((int)0x80210002);

        /*++

         MessageId's 0xcf00 - 0xcfff (inclusive) are for Cloud Files specific warning messages.

        --*/
        /// <summary>
        /// The cloud file property is possibly corrupt. The on-disk checksum does not match the computed checksum.
        /// </summary>
        public const int STATUS_CLOUD_FILE_PROPERTY_BLOB_CHECKSUM_MISMATCH = unchecked((int)0x8000CF00);

        /*++

         End of Cloud Files specific warning messages.

        --*/
        /////////////////////////////////////////////////////////////////////////
        //
        //  Standard Error values
        //
        /////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// {Operation Failed}
        /// The requested operation was unsuccessful.
        /// </summary>
        public const int STATUS_UNSUCCESSFUL = unchecked((int)0xC0000001);

        /// <summary>
        /// {Not Implemented}
        /// The requested operation is not implemented.
        /// </summary>
        public const int STATUS_NOT_IMPLEMENTED = unchecked((int)0xC0000002);

        /// <summary>
        /// {Invalid Parameter}
        /// The specified information class is not a valid information class for the specified object.
        /// </summary>
        public const int STATUS_INVALID_INFO_CLASS = unchecked((int)0xC0000003); // ntsubauth

        /// <summary>
        /// The specified information record length does not match the length required for the specified information class.
        /// </summary>
        public const int STATUS_INFO_LENGTH_MISMATCH = unchecked((int)0xC0000004);

        /// <summary>
        /// The instruction at 0x%p referenced memory at 0x%p. The memory could not be %s.
        /// </summary>
        public const int STATUS_ACCESS_VIOLATION = unchecked((int)0xC0000005); // winnt

        /// <summary>
        /// The instruction at 0x%p referenced memory at 0x%p. The required data was not placed into memory because of an I/O error status of 0x%x.
        /// </summary>
        public const int STATUS_IN_PAGE_ERROR = unchecked((int)0xC0000006); // winnt

        /// <summary>
        /// The pagefile quota for the process has been exhausted.
        /// </summary>
        public const int STATUS_PAGEFILE_QUOTA = unchecked((int)0xC0000007);

        /// <summary>
        /// An invalid HANDLE was specified.
        /// </summary>
        public const int STATUS_INVALID_HANDLE = unchecked((int)0xC0000008); // winnt

        /// <summary>
        /// An invalid initial stack was specified in a call to NtCreateThread.
        /// </summary>
        public const int STATUS_BAD_INITIAL_STACK = unchecked((int)0xC0000009);

        /// <summary>
        /// An invalid initial start address was specified in a call to NtCreateThread.
        /// </summary>
        public const int STATUS_BAD_INITIAL_PC = unchecked((int)0xC000000A);

        /// <summary>
        /// An invalid Client ID was specified.
        /// </summary>
        public const int STATUS_INVALID_CID = unchecked((int)0xC000000B);

        /// <summary>
        /// An attempt was made to cancel or set a timer that has an associated APC and the subject thread is not the thread that originally set the timer with an associated APC routine.
        /// </summary>
        public const int STATUS_TIMER_NOT_CANCELED = unchecked((int)0xC000000C);

        /// <summary>
        /// An invalid parameter was passed to a service or function.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER = unchecked((int)0xC000000D); // winnt

        /// <summary>
        /// A device which does not exist was specified.
        /// </summary>
        public const int STATUS_NO_SUCH_DEVICE = unchecked((int)0xC000000E);

        /// <summary>
        /// {File Not Found}
        /// The file %hs does not exist.
        /// </summary>
        public const int STATUS_NO_SUCH_FILE = unchecked((int)0xC000000F);

        /// <summary>
        /// The specified request is not a valid operation for the target device.
        /// </summary>
        public const int STATUS_INVALID_DEVICE_REQUEST = unchecked((int)0xC0000010);

        /// <summary>
        /// The end-of-file marker has been reached. There is no valid data in the file beyond this marker.
        /// </summary>
        public const int STATUS_END_OF_FILE = unchecked((int)0xC0000011);

        /// <summary>
        /// {Wrong Volume}
        /// The wrong volume is in the drive.
        /// Please insert volume %hs into drive %hs.
        /// </summary>
        public const int STATUS_WRONG_VOLUME = unchecked((int)0xC0000012);

        /// <summary>
        /// {No Disk}
        /// There is no disk in the drive.
        /// Please insert a disk into drive %hs.
        /// </summary>
        public const int STATUS_NO_MEDIA_IN_DEVICE = unchecked((int)0xC0000013);

        /// <summary>
        /// {Unknown Disk Format}
        /// The disk in drive %hs is not formatted properly.
        /// Please check the disk, and reformat if necessary.
        /// </summary>
        public const int STATUS_UNRECOGNIZED_MEDIA = unchecked((int)0xC0000014);

        /// <summary>
        /// {Sector Not Found}
        /// The specified sector does not exist.
        /// </summary>
        public const int STATUS_NONEXISTENT_SECTOR = unchecked((int)0xC0000015);

        /// <summary>
        /// {Still Busy}
        /// The specified I/O request packet (IRP) cannot be disposed of because the I/O operation is not complete.
        /// </summary>
        public const int STATUS_MORE_PROCESSING_REQUIRED = unchecked((int)0xC0000016);

        /// <summary>
        /// {Not Enough Quota}
        /// Not enough virtual memory or paging file quota is available to complete the specified operation.
        /// </summary>
        public const int STATUS_NO_MEMORY = unchecked((int)0xC0000017); // winnt

        /// <summary>
        /// {Conflicting Address Range}
        /// The specified address range conflicts with the address space.
        /// </summary>
        public const int STATUS_CONFLICTING_ADDRESSES = unchecked((int)0xC0000018);

        /// <summary>
        /// Address range to unmap is not a mapped view.
        /// </summary>
        public const int STATUS_NOT_MAPPED_VIEW = unchecked((int)0xC0000019);

        /// <summary>
        /// Virtual memory cannot be freed.
        /// </summary>
        public const int STATUS_UNABLE_TO_FREE_VM = unchecked((int)0xC000001A);

        /// <summary>
        /// Specified section cannot be deleted.
        /// </summary>
        public const int STATUS_UNABLE_TO_DELETE_SECTION = unchecked((int)0xC000001B);

        /// <summary>
        /// An invalid system service was specified in a system service call.
        /// </summary>
        public const int STATUS_INVALID_SYSTEM_SERVICE = unchecked((int)0xC000001C);

        /// <summary>
        /// {EXCEPTION}
        /// Illegal Instruction
        /// An attempt was made to execute an illegal instruction.
        /// </summary>
        public const int STATUS_ILLEGAL_INSTRUCTION = unchecked((int)0xC000001D); // winnt

        /// <summary>
        /// {Invalid Lock Sequence}
        /// An attempt was made to execute an invalid lock sequence.
        /// </summary>
        public const int STATUS_INVALID_LOCK_SEQUENCE = unchecked((int)0xC000001E);

        /// <summary>
        /// {Invalid Mapping}
        /// An attempt was made to create a view for a section which is bigger than the section.
        /// </summary>
        public const int STATUS_INVALID_VIEW_SIZE = unchecked((int)0xC000001F);

        /// <summary>
        /// {Bad File}
        /// The attributes of the specified mapping file for a section of memory cannot be read.
        /// </summary>
        public const int STATUS_INVALID_FILE_FOR_SECTION = unchecked((int)0xC0000020);

        /// <summary>
        /// {Already Committed}
        /// The specified address range is already committed.
        /// </summary>
        public const int STATUS_ALREADY_COMMITTED = unchecked((int)0xC0000021);

        /// <summary>
        /// {Access Denied}
        /// A process has requested access to an object, but has not been granted those access rights.
        /// </summary>
        public const int STATUS_ACCESS_DENIED = unchecked((int)0xC0000022);

        /// <summary>
        /// {Buffer Too Small}
        /// The buffer is too small to contain the entry. No information has been written to the buffer.
        /// </summary>
        public const int STATUS_BUFFER_TOO_SMALL = unchecked((int)0xC0000023);

        /// <summary>
        /// {Wrong Type}
        /// There is a mismatch between the type of object required by the requested operation and the type of object that is specified in the request.
        /// </summary>
        public const int STATUS_OBJECT_TYPE_MISMATCH = unchecked((int)0xC0000024);

        /// <summary>
        /// {EXCEPTION}
        /// Cannot Continue
        /// Windows cannot continue from this exception.
        /// </summary>
        public const int STATUS_NONCONTINUABLE_EXCEPTION = unchecked((int)0xC0000025); // winnt

        /// <summary>
        /// An invalid exception disposition was returned by an exception handler.
        /// </summary>
        public const int STATUS_INVALID_DISPOSITION = unchecked((int)0xC0000026); // winnt

        /// <summary>
        /// Unwind exception code.
        /// </summary>
        public const int STATUS_UNWIND = unchecked((int)0xC0000027);

        /// <summary>
        /// An invalid or unaligned stack was encountered during an unwind operation.
        /// </summary>
        public const int STATUS_BAD_STACK = unchecked((int)0xC0000028);

        /// <summary>
        /// An invalid unwind target was encountered during an unwind operation.
        /// </summary>
        public const int STATUS_INVALID_UNWIND_TARGET = unchecked((int)0xC0000029);

        /// <summary>
        /// An attempt was made to unlock a page of memory which was not locked.
        /// </summary>
        public const int STATUS_NOT_LOCKED = unchecked((int)0xC000002A);

        /// <summary>
        /// Device parity error on I/O operation.
        /// </summary>
        public const int STATUS_PARITY_ERROR = unchecked((int)0xC000002B);

        /// <summary>
        /// An attempt was made to decommit uncommitted virtual memory.
        /// </summary>
        public const int STATUS_UNABLE_TO_DECOMMIT_VM = unchecked((int)0xC000002C);

        /// <summary>
        /// An attempt was made to change the attributes on memory that has not been committed.
        /// </summary>
        public const int STATUS_NOT_COMMITTED = unchecked((int)0xC000002D);

        /// <summary>
        /// Invalid Object Attributes specified to NtCreatePort or invalid Port Attributes specified to NtConnectPort
        /// </summary>
        public const int STATUS_INVALID_PORT_ATTRIBUTES = unchecked((int)0xC000002E);

        /// <summary>
        /// Length of message passed to NtRequestPort or NtRequestWaitReplyPort was longer than the maximum message allowed by the port.
        /// </summary>
        public const int STATUS_PORT_MESSAGE_TOO_LONG = unchecked((int)0xC000002F);

        /// <summary>
        /// An invalid combination of parameters was specified.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_MIX = unchecked((int)0xC0000030);

        /// <summary>
        /// An attempt was made to lower a quota limit below the current usage.
        /// </summary>
        public const int STATUS_INVALID_QUOTA_LOWER = unchecked((int)0xC0000031);

        /// <summary>
        /// {Corrupt Disk}
        /// The file system structure on the disk is corrupt and unusable.
        /// Please run the Chkdsk utility on the volume %hs.
        /// </summary>
        public const int STATUS_DISK_CORRUPT_ERROR = unchecked((int)0xC0000032);

        /// <summary>
        /// Object Name invalid.
        /// </summary>
        public const int STATUS_OBJECT_NAME_INVALID = unchecked((int)0xC0000033);

        /// <summary>
        /// Object Name not found.
        /// </summary>
        public const int STATUS_OBJECT_NAME_NOT_FOUND = unchecked((int)0xC0000034);

        /// <summary>
        /// Object Name already exists.
        /// </summary>
        public const int STATUS_OBJECT_NAME_COLLISION = unchecked((int)0xC0000035);

        /// <summary>
        /// A port with the 'do not disturb' flag set attempted to send a message to a port in a suspended process.
        /// The process was not woken, and the message was not delivered.
        /// </summary>
        public const int STATUS_PORT_DO_NOT_DISTURB = unchecked((int)0xC0000036);

        /// <summary>
        /// Attempt to send a message to a disconnected communication port.
        /// </summary>
        public const int STATUS_PORT_DISCONNECTED = unchecked((int)0xC0000037);

        /// <summary>
        /// An attempt was made to attach to a device that was already attached to another device.
        /// </summary>
        public const int STATUS_DEVICE_ALREADY_ATTACHED = unchecked((int)0xC0000038);

        /// <summary>
        /// Object Path Component was not a directory object.
        /// </summary>
        public const int STATUS_OBJECT_PATH_INVALID = unchecked((int)0xC0000039);

        /// <summary>
        /// {Path Not Found}
        /// The path %hs does not exist.
        /// </summary>
        public const int STATUS_OBJECT_PATH_NOT_FOUND = unchecked((int)0xC000003A);

        /// <summary>
        /// Object Path Component was not a directory object.
        /// </summary>
        public const int STATUS_OBJECT_PATH_SYNTAX_BAD = unchecked((int)0xC000003B);

        /// <summary>
        /// {Data Overrun}
        /// A data overrun error occurred.
        /// </summary>
        public const int STATUS_DATA_OVERRUN = unchecked((int)0xC000003C);

        /// <summary>
        /// {Data Late}
        /// A data late error occurred.
        /// </summary>
        public const int STATUS_DATA_LATE_ERROR = unchecked((int)0xC000003D);

        /// <summary>
        /// {Data Error}
        /// An error in reading or writing data occurred.
        /// </summary>
        public const int STATUS_DATA_ERROR = unchecked((int)0xC000003E);

        /// <summary>
        /// {Bad CRC}
        /// A cyclic redundancy check (CRC) checksum error occurred.
        /// </summary>
        public const int STATUS_CRC_ERROR = unchecked((int)0xC000003F);

        /// <summary>
        /// {Section Too Large}
        /// The specified section is too big to map the file.
        /// </summary>
        public const int STATUS_SECTION_TOO_BIG = unchecked((int)0xC0000040);

        /// <summary>
        /// The NtConnectPort request is refused.
        /// </summary>
        public const int STATUS_PORT_CONNECTION_REFUSED = unchecked((int)0xC0000041);

        /// <summary>
        /// The type of port handle is invalid for the operation requested.
        /// </summary>
        public const int STATUS_INVALID_PORT_HANDLE = unchecked((int)0xC0000042);

        /// <summary>
        /// A file cannot be opened because the share access flags are incompatible.
        /// </summary>
        public const int STATUS_SHARING_VIOLATION = unchecked((int)0xC0000043);

        /// <summary>
        /// Insufficient quota exists to complete the operation
        /// </summary>
        public const int STATUS_QUOTA_EXCEEDED = unchecked((int)0xC0000044);

        /// <summary>
        /// The specified page protection was not valid.
        /// </summary>
        public const int STATUS_INVALID_PAGE_PROTECTION = unchecked((int)0xC0000045);

        /// <summary>
        /// An attempt to release a mutant object was made by a thread that was not the owner of the mutant object.
        /// </summary>
        public const int STATUS_MUTANT_NOT_OWNED = unchecked((int)0xC0000046);

        /// <summary>
        /// An attempt was made to release a semaphore such that its maximum count would have been exceeded.
        /// </summary>
        public const int STATUS_SEMAPHORE_LIMIT_EXCEEDED = unchecked((int)0xC0000047);

        /// <summary>
        /// An attempt to set a process's DebugPort or ExceptionPort was made, but a port already exists in the process or an attempt to set a file's CompletionPort made, but a port was already set in the file or an attempt to set an ALPC port's associated completion port was made, but it is already set.
        /// </summary>
        public const int STATUS_PORT_ALREADY_SET = unchecked((int)0xC0000048);

        /// <summary>
        /// An attempt was made to query image information on a section which does not map an image.
        /// </summary>
        public const int STATUS_SECTION_NOT_IMAGE = unchecked((int)0xC0000049);

        /// <summary>
        /// An attempt was made to suspend a thread whose suspend count was at its maximum.
        /// </summary>
        public const int STATUS_SUSPEND_COUNT_EXCEEDED = unchecked((int)0xC000004A);

        /// <summary>
        /// An attempt was made to access a thread that has begun termination.
        /// </summary>
        public const int STATUS_THREAD_IS_TERMINATING = unchecked((int)0xC000004B);

        /// <summary>
        /// An attempt was made to set the working set limit to an invalid value (minimum greater than maximum, etc).
        /// </summary>
        public const int STATUS_BAD_WORKING_SET_LIMIT = unchecked((int)0xC000004C);

        /// <summary>
        /// A section was created to map a file which is not compatible to an already existing section which maps the same file.
        /// </summary>
        public const int STATUS_INCOMPATIBLE_FILE_MAP = unchecked((int)0xC000004D);

        /// <summary>
        /// A view to a section specifies a protection which is incompatible with the initial view's protection.
        /// </summary>
        public const int STATUS_SECTION_PROTECTION = unchecked((int)0xC000004E);

        /// <summary>
        /// An operation involving EAs failed because the file system does not support EAs.
        /// </summary>
        public const int STATUS_EAS_NOT_SUPPORTED = unchecked((int)0xC000004F);

        /// <summary>
        /// An EA operation failed because EA set is too large.
        /// </summary>
        public const int STATUS_EA_TOO_LARGE = unchecked((int)0xC0000050);

        /// <summary>
        /// An EA operation failed because the name or EA index is invalid.
        /// </summary>
        public const int STATUS_NONEXISTENT_EA_ENTRY = unchecked((int)0xC0000051);

        /// <summary>
        /// The file for which EAs were requested has no EAs.
        /// </summary>
        public const int STATUS_NO_EAS_ON_FILE = unchecked((int)0xC0000052);

        /// <summary>
        /// The EA is corrupt and non-readable.
        /// </summary>
        public const int STATUS_EA_CORRUPT_ERROR = unchecked((int)0xC0000053);

        /// <summary>
        /// A requested read/write cannot be granted due to a conflicting file lock.
        /// </summary>
        public const int STATUS_FILE_LOCK_CONFLICT = unchecked((int)0xC0000054);

        /// <summary>
        /// A requested file lock cannot be granted due to other existing locks.
        /// </summary>
        public const int STATUS_LOCK_NOT_GRANTED = unchecked((int)0xC0000055);

        /// <summary>
        /// A non close operation has been requested of a file object with a delete pending.
        /// </summary>
        public const int STATUS_DELETE_PENDING = unchecked((int)0xC0000056);

        /// <summary>
        /// An attempt was made to set the control attribute on a file. This attribute is not supported in the target file system.
        /// </summary>
        public const int STATUS_CTL_FILE_NOT_SUPPORTED = unchecked((int)0xC0000057);

        /// <summary>
        /// Indicates a revision number encountered or specified is not one known by the service. It may be a more recent revision than the service is aware of.
        /// </summary>
        public const int STATUS_UNKNOWN_REVISION = unchecked((int)0xC0000058);

        /// <summary>
        /// Indicates two revision levels are incompatible.
        /// </summary>
        public const int STATUS_REVISION_MISMATCH = unchecked((int)0xC0000059);

        /// <summary>
        /// Indicates a particular Security ID may not be assigned as the owner of an object.
        /// </summary>
        public const int STATUS_INVALID_OWNER = unchecked((int)0xC000005A);

        /// <summary>
        /// Indicates a particular Security ID may not be assigned as the primary group of an object.
        /// </summary>
        public const int STATUS_INVALID_PRIMARY_GROUP = unchecked((int)0xC000005B);

        /// <summary>
        /// An attempt has been made to operate on an impersonation token by a thread that is not currently impersonating a client.
        /// </summary>
        public const int STATUS_NO_IMPERSONATION_TOKEN = unchecked((int)0xC000005C);

        /// <summary>
        /// A mandatory group may not be disabled.
        /// </summary>
        public const int STATUS_CANT_DISABLE_MANDATORY = unchecked((int)0xC000005D);

        /// <summary>
        /// We can't sign you in with this credential because your domain isn't available. Make sure your device is connected to your organization's network and try again. If you previously signed in on this device with another credential, you can sign in with that credential.
        /// </summary>
        public const int STATUS_NO_LOGON_SERVERS = unchecked((int)0xC000005E);

        /// <summary>
        /// A specified logon session does not exist. It may already have been terminated.
        /// </summary>
        public const int STATUS_NO_SUCH_LOGON_SESSION = unchecked((int)0xC000005F);

        /// <summary>
        /// A specified privilege does not exist.
        /// </summary>
        public const int STATUS_NO_SUCH_PRIVILEGE = unchecked((int)0xC0000060);

        /// <summary>
        /// A required privilege is not held by the client.
        /// </summary>
        public const int STATUS_PRIVILEGE_NOT_HELD = unchecked((int)0xC0000061);

        /// <summary>
        /// The name provided is not a properly formed account name.
        /// </summary>
        public const int STATUS_INVALID_ACCOUNT_NAME = unchecked((int)0xC0000062);

        /// <summary>
        /// The specified account already exists.
        /// </summary>
        public const int STATUS_USER_EXISTS = unchecked((int)0xC0000063);

        /// <summary>
        /// The specified account does not exist.
        /// </summary>
        public const int STATUS_NO_SUCH_USER = unchecked((int)0xC0000064); // ntsubauth

        /// <summary>
        /// The specified group already exists.
        /// </summary>
        public const int STATUS_GROUP_EXISTS = unchecked((int)0xC0000065);

        /// <summary>
        /// The specified group does not exist.
        /// </summary>
        public const int STATUS_NO_SUCH_GROUP = unchecked((int)0xC0000066);

        /// <summary>
        /// The specified user account is already in the specified group account. Also used to indicate a group cannot be deleted because it contains a member.
        /// </summary>
        public const int STATUS_MEMBER_IN_GROUP = unchecked((int)0xC0000067);

        /// <summary>
        /// The specified user account is not a member of the specified group account.
        /// </summary>
        public const int STATUS_MEMBER_NOT_IN_GROUP = unchecked((int)0xC0000068);

        /// <summary>
        /// Indicates the requested operation would disable, delete or could prevent logon for an administration account.
        /// This is not allowed to prevent creating a situation in which the system cannot be administrated.
        /// </summary>
        public const int STATUS_LAST_ADMIN = unchecked((int)0xC0000069);

        /// <summary>
        /// When trying to update a password, this return status indicates that the value provided as the current password is not correct.
        /// </summary>
        public const int STATUS_WRONG_PASSWORD = unchecked((int)0xC000006A); // ntsubauth

        /// <summary>
        /// When trying to update a password, this return status indicates that the value provided for the new password contains values that are not allowed in passwords.
        /// </summary>
        public const int STATUS_ILL_FORMED_PASSWORD = unchecked((int)0xC000006B);

        /// <summary>
        /// When trying to update a password, this status indicates that some password update rule has been violated. For example, the password may not meet length criteria.
        /// </summary>
        public const int STATUS_PASSWORD_RESTRICTION = unchecked((int)0xC000006C); // ntsubauth

        /// <summary>
        /// The attempted logon is invalid. This is either due to a bad username or authentication information.
        /// </summary>
        public const int STATUS_LOGON_FAILURE = unchecked((int)0xC000006D); // ntsubauth

        /// <summary>
        /// Indicates a referenced user name and authentication information are valid, but some user account restriction has prevented successful authentication (such as time-of-day restrictions).
        /// </summary>
        public const int STATUS_ACCOUNT_RESTRICTION = unchecked((int)0xC000006E); // ntsubauth

        /// <summary>
        /// The user account has time restrictions and may not be logged onto at this time.
        /// </summary>
        public const int STATUS_INVALID_LOGON_HOURS = unchecked((int)0xC000006F); // ntsubauth

        /// <summary>
        /// The user account is restricted such that it may not be used to log on from the source workstation.
        /// </summary>
        public const int STATUS_INVALID_WORKSTATION = unchecked((int)0xC0000070); // ntsubauth

        /// <summary>
        /// The user account's password has expired.
        /// </summary>
        public const int STATUS_PASSWORD_EXPIRED = unchecked((int)0xC0000071); // ntsubauth

        /// <summary>
        /// The referenced account is currently disabled and may not be logged on to.
        /// </summary>
        public const int STATUS_ACCOUNT_DISABLED = unchecked((int)0xC0000072); // ntsubauth

        /// <summary>
        /// None of the information to be translated has been translated.
        /// </summary>
        public const int STATUS_NONE_MAPPED = unchecked((int)0xC0000073);

        /// <summary>
        /// The number of LUIDs requested may not be allocated with a single allocation.
        /// </summary>
        public const int STATUS_TOO_MANY_LUIDS_REQUESTED = unchecked((int)0xC0000074);

        /// <summary>
        /// Indicates there are no more LUIDs to allocate.
        /// </summary>
        public const int STATUS_LUIDS_EXHAUSTED = unchecked((int)0xC0000075);

        /// <summary>
        /// Indicates the sub-authority value is invalid for the particular use.
        /// </summary>
        public const int STATUS_INVALID_SUB_AUTHORITY = unchecked((int)0xC0000076);

        /// <summary>
        /// Indicates the ACL structure is not valid.
        /// </summary>
        public const int STATUS_INVALID_ACL = unchecked((int)0xC0000077);

        /// <summary>
        /// Indicates the SID structure is not valid.
        /// </summary>
        public const int STATUS_INVALID_SID = unchecked((int)0xC0000078);

        /// <summary>
        /// Indicates the SECURITY_DESCRIPTOR structure is not valid.
        /// </summary>
        public const int STATUS_INVALID_SECURITY_DESCR = unchecked((int)0xC0000079);

        /// <summary>
        /// Indicates the specified procedure address cannot be found in the DLL.
        /// </summary>
        public const int STATUS_PROCEDURE_NOT_FOUND = unchecked((int)0xC000007A);

        /// <summary>
        /// {Bad Image}
        /// %hs is either not designed to run on Windows or it contains an error. Try installing the program again using the original installation media or contact your system administrator or the software vendor for support. Error status 0x%08lx.
        /// </summary>
        public const int STATUS_INVALID_IMAGE_FORMAT = unchecked((int)0xC000007B);

        /// <summary>
        /// An attempt was made to reference a token that doesn't exist.
        /// This is typically done by referencing the token associated with a thread when the thread is not impersonating a client.
        /// </summary>
        public const int STATUS_NO_TOKEN = unchecked((int)0xC000007C);

        /// <summary>
        /// Indicates that an attempt to build either an inherited ACL or ACE was not successful.
        /// This can be caused by a number of things. One of the more probable causes is the replacement of a CreatorId with an SID that didn't fit into the ACE or ACL.
        /// </summary>
        public const int STATUS_BAD_INHERITANCE_ACL = unchecked((int)0xC000007D);

        /// <summary>
        /// The range specified in NtUnlockFile was not locked.
        /// </summary>
        public const int STATUS_RANGE_NOT_LOCKED = unchecked((int)0xC000007E);

        /// <summary>
        /// An operation failed because the disk was full.
        /// If this is a thinly provisioned volume the physical storage backing this volume has been exhausted.
        /// </summary>
        public const int STATUS_DISK_FULL = unchecked((int)0xC000007F);

        /// <summary>
        /// The GUID allocation server is [already] disabled at the moment.
        /// </summary>
        public const int STATUS_SERVER_DISABLED = unchecked((int)0xC0000080);

        /// <summary>
        /// The GUID allocation server is [already] enabled at the moment.
        /// </summary>
        public const int STATUS_SERVER_NOT_DISABLED = unchecked((int)0xC0000081);

        /// <summary>
        /// Too many GUIDs were requested from the allocation server at once.
        /// </summary>
        public const int STATUS_TOO_MANY_GUIDS_REQUESTED = unchecked((int)0xC0000082);

        /// <summary>
        /// The GUIDs could not be allocated because the Authority Agent was exhausted.
        /// </summary>
        public const int STATUS_GUIDS_EXHAUSTED = unchecked((int)0xC0000083);

        /// <summary>
        /// The value provided was an invalid value for an identifier authority.
        /// </summary>
        public const int STATUS_INVALID_ID_AUTHORITY = unchecked((int)0xC0000084);

        /// <summary>
        /// There are no more authority agent values available for the given identifier authority value.
        /// </summary>
        public const int STATUS_AGENTS_EXHAUSTED = unchecked((int)0xC0000085);

        /// <summary>
        /// An invalid volume label has been specified.
        /// </summary>
        public const int STATUS_INVALID_VOLUME_LABEL = unchecked((int)0xC0000086);

        /// <summary>
        /// A mapped section could not be extended.
        /// </summary>
        public const int STATUS_SECTION_NOT_EXTENDED = unchecked((int)0xC0000087);

        /// <summary>
        /// Specified section to flush does not map a data file.
        /// </summary>
        public const int STATUS_NOT_MAPPED_DATA = unchecked((int)0xC0000088);

        /// <summary>
        /// Indicates the specified image file did not contain a resource section.
        /// </summary>
        public const int STATUS_RESOURCE_DATA_NOT_FOUND = unchecked((int)0xC0000089);

        /// <summary>
        /// Indicates the specified resource type cannot be found in the image file.
        /// </summary>
        public const int STATUS_RESOURCE_TYPE_NOT_FOUND = unchecked((int)0xC000008A);

        /// <summary>
        /// Indicates the specified resource name cannot be found in the image file.
        /// </summary>
        public const int STATUS_RESOURCE_NAME_NOT_FOUND = unchecked((int)0xC000008B);

        /// <summary>
        /// {EXCEPTION}
        /// Array bounds exceeded.
        /// </summary>
        public const int STATUS_ARRAY_BOUNDS_EXCEEDED = unchecked((int)0xC000008C); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Floating-point denormal operand.
        /// </summary>
        public const int STATUS_FLOAT_DENORMAL_OPERAND = unchecked((int)0xC000008D); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Floating-point division by zero.
        /// </summary>
        public const int STATUS_FLOAT_DIVIDE_BY_ZERO = unchecked((int)0xC000008E); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Floating-point inexact result.
        /// </summary>
        public const int STATUS_FLOAT_INEXACT_RESULT = unchecked((int)0xC000008F); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Floating-point invalid operation.
        /// </summary>
        public const int STATUS_FLOAT_INVALID_OPERATION = unchecked((int)0xC0000090); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Floating-point overflow.
        /// </summary>
        public const int STATUS_FLOAT_OVERFLOW = unchecked((int)0xC0000091); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Floating-point stack check.
        /// </summary>
        public const int STATUS_FLOAT_STACK_CHECK = unchecked((int)0xC0000092); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Floating-point underflow.
        /// </summary>
        public const int STATUS_FLOAT_UNDERFLOW = unchecked((int)0xC0000093); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Integer division by zero.
        /// </summary>
        public const int STATUS_INTEGER_DIVIDE_BY_ZERO = unchecked((int)0xC0000094); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Integer overflow.
        /// </summary>
        public const int STATUS_INTEGER_OVERFLOW = unchecked((int)0xC0000095); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Privileged instruction.
        /// </summary>
        public const int STATUS_PRIVILEGED_INSTRUCTION = unchecked((int)0xC0000096); // winnt

        /// <summary>
        /// An attempt was made to install more paging files than the system supports.
        /// </summary>
        public const int STATUS_TOO_MANY_PAGING_FILES = unchecked((int)0xC0000097);

        /// <summary>
        /// The volume for a file has been externally altered such that the opened file is no longer valid.
        /// </summary>
        public const int STATUS_FILE_INVALID = unchecked((int)0xC0000098);

        /// <summary>
        /// When a block of memory is allotted for future updates, such as the memory allocated to hold discretionary access control and primary group information, successive updates may exceed the amount of memory originally allotted.
        /// Since quota may already have been charged to several processes which have handles to the object, it is not reasonable to alter the size of the allocated memory.
        /// Instead, a request that requires more memory than has been allotted must fail and the STATUS_ALLOTED_SPACE_EXCEEDED error returned.
        /// </summary>
        public const int STATUS_ALLOTTED_SPACE_EXCEEDED = unchecked((int)0xC0000099);

        /// <summary>
        /// Insufficient system resources exist to complete the API.
        /// </summary>
        public const int STATUS_INSUFFICIENT_RESOURCES = unchecked((int)0xC000009A); // ntsubauth

        /// <summary>
        /// An attempt has been made to open a DFS exit path control file.
        /// </summary>
        public const int STATUS_DFS_EXIT_PATH_FOUND = unchecked((int)0xC000009B);

        /// <summary>
        /// STATUS_DEVICE_DATA_ERROR
        /// </summary>
        public const int STATUS_DEVICE_DATA_ERROR = unchecked((int)0xC000009C);

        /// <summary>
        /// STATUS_DEVICE_NOT_CONNECTED
        /// </summary>
        public const int STATUS_DEVICE_NOT_CONNECTED = unchecked((int)0xC000009D);

        /// <summary>
        /// STATUS_DEVICE_POWER_FAILURE
        /// </summary>
        public const int STATUS_DEVICE_POWER_FAILURE = unchecked((int)0xC000009E);

        /// <summary>
        /// Virtual memory cannot be freed as base address is not the base of the region and a region size of zero was specified.
        /// </summary>
        public const int STATUS_FREE_VM_NOT_AT_BASE = unchecked((int)0xC000009F);

        /// <summary>
        /// An attempt was made to free virtual memory which is not allocated.
        /// </summary>
        public const int STATUS_MEMORY_NOT_ALLOCATED = unchecked((int)0xC00000A0);

        /// <summary>
        /// The working set is not big enough to allow the requested pages to be locked.
        /// </summary>
        public const int STATUS_WORKING_SET_QUOTA = unchecked((int)0xC00000A1);

        /// <summary>
        /// {Write Protect Error}
        /// The disk cannot be written to because it is write protected. Please remove the write protection from the volume %hs in drive %hs.
        /// </summary>
        public const int STATUS_MEDIA_WRITE_PROTECTED = unchecked((int)0xC00000A2);

        /// <summary>
        /// {Drive Not Ready}
        /// The drive is not ready for use; its door may be open. Please check drive %hs and make sure that a disk is inserted and that the drive door is closed.
        /// </summary>
        public const int STATUS_DEVICE_NOT_READY = unchecked((int)0xC00000A3);

        /// <summary>
        /// The specified attributes are invalid, or incompatible with the attributes for the group as a whole.
        /// </summary>
        public const int STATUS_INVALID_GROUP_ATTRIBUTES = unchecked((int)0xC00000A4);

        /// <summary>
        /// A specified impersonation level is invalid.
        /// Also used to indicate a required impersonation level was not provided.
        /// </summary>
        public const int STATUS_BAD_IMPERSONATION_LEVEL = unchecked((int)0xC00000A5);

        /// <summary>
        /// An attempt was made to open an Anonymous level token.
        /// Anonymous tokens may not be opened.
        /// </summary>
        public const int STATUS_CANT_OPEN_ANONYMOUS = unchecked((int)0xC00000A6);

        /// <summary>
        /// The validation information class requested was invalid.
        /// </summary>
        public const int STATUS_BAD_VALIDATION_CLASS = unchecked((int)0xC00000A7);

        /// <summary>
        /// The type of a token object is inappropriate for its attempted use.
        /// </summary>
        public const int STATUS_BAD_TOKEN_TYPE = unchecked((int)0xC00000A8);

        /// <summary>
        /// The type of a token object is inappropriate for its attempted use.
        /// </summary>
        public const int STATUS_BAD_MASTER_BOOT_RECORD = unchecked((int)0xC00000A9);

        /// <summary>
        /// An attempt was made to execute an instruction at an unaligned address and the host system does not support unaligned instruction references.
        /// </summary>
        public const int STATUS_INSTRUCTION_MISALIGNMENT = unchecked((int)0xC00000AA);

        /// <summary>
        /// The maximum named pipe instance count has been reached.
        /// </summary>
        public const int STATUS_INSTANCE_NOT_AVAILABLE = unchecked((int)0xC00000AB);

        /// <summary>
        /// An instance of a named pipe cannot be found in the listening state.
        /// </summary>
        public const int STATUS_PIPE_NOT_AVAILABLE = unchecked((int)0xC00000AC);

        /// <summary>
        /// The named pipe is not in the connected or closing state.
        /// </summary>
        public const int STATUS_INVALID_PIPE_STATE = unchecked((int)0xC00000AD);

        /// <summary>
        /// The specified pipe is set to complete operations and there are current I/O operations queued so it cannot be changed to queue operations.
        /// </summary>
        public const int STATUS_PIPE_BUSY = unchecked((int)0xC00000AE);

        /// <summary>
        /// The specified handle is not open to the server end of the named pipe.
        /// </summary>
        public const int STATUS_ILLEGAL_FUNCTION = unchecked((int)0xC00000AF);

        /// <summary>
        /// The specified named pipe is in the disconnected state.
        /// </summary>
        public const int STATUS_PIPE_DISCONNECTED = unchecked((int)0xC00000B0);

        /// <summary>
        /// The specified named pipe is in the closing state.
        /// </summary>
        public const int STATUS_PIPE_CLOSING = unchecked((int)0xC00000B1);

        /// <summary>
        /// The specified named pipe is in the connected state.
        /// </summary>
        public const int STATUS_PIPE_CONNECTED = unchecked((int)0xC00000B2);

        /// <summary>
        /// The specified named pipe is in the listening state.
        /// </summary>
        public const int STATUS_PIPE_LISTENING = unchecked((int)0xC00000B3);

        /// <summary>
        /// The specified named pipe is not in message mode.
        /// </summary>
        public const int STATUS_INVALID_READ_MODE = unchecked((int)0xC00000B4);

        /// <summary>
        /// {Device Timeout}
        /// The specified I/O operation on %hs was not completed before the time-out period expired.
        /// </summary>
        public const int STATUS_IO_TIMEOUT = unchecked((int)0xC00000B5);

        /// <summary>
        /// The specified file has been closed by another process.
        /// </summary>
        public const int STATUS_FILE_FORCED_CLOSED = unchecked((int)0xC00000B6);

        /// <summary>
        /// Profiling not started.
        /// </summary>
        public const int STATUS_PROFILING_NOT_STARTED = unchecked((int)0xC00000B7);

        /// <summary>
        /// Profiling not stopped.
        /// </summary>
        public const int STATUS_PROFILING_NOT_STOPPED = unchecked((int)0xC00000B8);

        /// <summary>
        /// The passed ACL did not contain the minimum required information.
        /// </summary>
        public const int STATUS_COULD_NOT_INTERPRET = unchecked((int)0xC00000B9);

        /// <summary>
        /// The file that was specified as a target is a directory and the caller specified that it could be anything but a directory.
        /// </summary>
        public const int STATUS_FILE_IS_A_DIRECTORY = unchecked((int)0xC00000BA);

        //
        // Network specific errors.
        //
        //
        /// <summary>
        /// The request is not supported.
        /// </summary>
        public const int STATUS_NOT_SUPPORTED = unchecked((int)0xC00000BB);

        /// <summary>
        /// This remote computer is not listening.
        /// </summary>
        public const int STATUS_REMOTE_NOT_LISTENING = unchecked((int)0xC00000BC);

        /// <summary>
        /// A duplicate name exists on the network.
        /// </summary>
        public const int STATUS_DUPLICATE_NAME = unchecked((int)0xC00000BD);

        /// <summary>
        /// The network path cannot be located.
        /// </summary>
        public const int STATUS_BAD_NETWORK_PATH = unchecked((int)0xC00000BE);

        /// <summary>
        /// The network is busy.
        /// </summary>
        public const int STATUS_NETWORK_BUSY = unchecked((int)0xC00000BF);

        /// <summary>
        /// This device does not exist.
        /// </summary>
        public const int STATUS_DEVICE_DOES_NOT_EXIST = unchecked((int)0xC00000C0);

        /// <summary>
        /// The network BIOS command limit has been reached.
        /// </summary>
        public const int STATUS_TOO_MANY_COMMANDS = unchecked((int)0xC00000C1);

        /// <summary>
        /// An I/O adapter hardware error has occurred.
        /// </summary>
        public const int STATUS_ADAPTER_HARDWARE_ERROR = unchecked((int)0xC00000C2);

        /// <summary>
        /// The network responded incorrectly.
        /// </summary>
        public const int STATUS_INVALID_NETWORK_RESPONSE = unchecked((int)0xC00000C3);

        /// <summary>
        /// An unexpected network error occurred.
        /// </summary>
        public const int STATUS_UNEXPECTED_NETWORK_ERROR = unchecked((int)0xC00000C4);

        /// <summary>
        /// The remote adapter is not compatible.
        /// </summary>
        public const int STATUS_BAD_REMOTE_ADAPTER = unchecked((int)0xC00000C5);

        /// <summary>
        /// The printer queue is full.
        /// </summary>
        public const int STATUS_PRINT_QUEUE_FULL = unchecked((int)0xC00000C6);

        /// <summary>
        /// Space to store the file waiting to be printed is not available on the server.
        /// </summary>
        public const int STATUS_NO_SPOOL_SPACE = unchecked((int)0xC00000C7);

        /// <summary>
        /// The requested print file has been canceled.
        /// </summary>
        public const int STATUS_PRINT_CANCELLED = unchecked((int)0xC00000C8);

        /// <summary>
        /// The network name was deleted.
        /// </summary>
        public const int STATUS_NETWORK_NAME_DELETED = unchecked((int)0xC00000C9);

        /// <summary>
        /// Network access is denied.
        /// </summary>
        public const int STATUS_NETWORK_ACCESS_DENIED = unchecked((int)0xC00000CA);

        /// <summary>
        /// {Incorrect Network Resource Type}
        /// The specified device type (LPT, for example) conflicts with the actual device type on the remote resource.
        /// </summary>
        public const int STATUS_BAD_DEVICE_TYPE = unchecked((int)0xC00000CB);

        /// <summary>
        /// {Network Name Not Found}
        /// The specified share name cannot be found on the remote server.
        /// </summary>
        public const int STATUS_BAD_NETWORK_NAME = unchecked((int)0xC00000CC);

        /// <summary>
        /// The name limit for the local computer network adapter card was exceeded.
        /// </summary>
        public const int STATUS_TOO_MANY_NAMES = unchecked((int)0xC00000CD);

        /// <summary>
        /// The network BIOS session limit was exceeded.
        /// </summary>
        public const int STATUS_TOO_MANY_SESSIONS = unchecked((int)0xC00000CE);

        /// <summary>
        /// File sharing has been temporarily paused.
        /// </summary>
        public const int STATUS_SHARING_PAUSED = unchecked((int)0xC00000CF);

        /// <summary>
        /// No more connections can be made to this remote computer at this time because there are already as many connections as the computer can accept.
        /// </summary>
        public const int STATUS_REQUEST_NOT_ACCEPTED = unchecked((int)0xC00000D0);

        /// <summary>
        /// Print or disk redirection is temporarily paused.
        /// </summary>
        public const int STATUS_REDIRECTOR_PAUSED = unchecked((int)0xC00000D1);

        /// <summary>
        /// A network data fault occurred.
        /// </summary>
        public const int STATUS_NET_WRITE_FAULT = unchecked((int)0xC00000D2);

        /// <summary>
        /// The number of active profiling objects is at the maximum and no more may be started.
        /// </summary>
        public const int STATUS_PROFILING_AT_LIMIT = unchecked((int)0xC00000D3);

        /// <summary>
        /// {Incorrect Volume}
        /// The target file of a rename request is located on a different device than the source of the rename request.
        /// </summary>
        public const int STATUS_NOT_SAME_DEVICE = unchecked((int)0xC00000D4);

        /// <summary>
        /// The file specified has been renamed and thus cannot be modified.
        /// </summary>
        public const int STATUS_FILE_RENAMED = unchecked((int)0xC00000D5);

        /// <summary>
        /// {Network Request Timeout}
        /// The session with a remote server has been disconnected because the time-out interval for a request has expired.
        /// </summary>
        public const int STATUS_VIRTUAL_CIRCUIT_CLOSED = unchecked((int)0xC00000D6);

        /// <summary>
        /// Indicates an attempt was made to operate on the security of an object that does not have security associated with it.
        /// </summary>
        public const int STATUS_NO_SECURITY_ON_OBJECT = unchecked((int)0xC00000D7);

        /// <summary>
        /// Used to indicate that an operation cannot continue without blocking for I/O.
        /// </summary>
        public const int STATUS_CANT_WAIT = unchecked((int)0xC00000D8);

        /// <summary>
        /// Used to indicate that a read operation was done on an empty pipe.
        /// </summary>
        public const int STATUS_PIPE_EMPTY = unchecked((int)0xC00000D9);

        /// <summary>
        /// Configuration information could not be read from the domain controller, either because the machine is unavailable, or access has been denied.
        /// </summary>
        public const int STATUS_CANT_ACCESS_DOMAIN_INFO = unchecked((int)0xC00000DA);

        /// <summary>
        /// Indicates that a thread attempted to terminate itself by default (called NtTerminateThread with NULL) and it was the last thread in the current process.
        /// </summary>
        public const int STATUS_CANT_TERMINATE_SELF = unchecked((int)0xC00000DB);

        /// <summary>
        /// Indicates the Sam Server was in the wrong state to perform the desired operation.
        /// </summary>
        public const int STATUS_INVALID_SERVER_STATE = unchecked((int)0xC00000DC);

        /// <summary>
        /// Indicates the Domain was in the wrong state to perform the desired operation.
        /// </summary>
        public const int STATUS_INVALID_DOMAIN_STATE = unchecked((int)0xC00000DD);

        /// <summary>
        /// This operation is only allowed for the Primary Domain Controller of the domain.
        /// </summary>
        public const int STATUS_INVALID_DOMAIN_ROLE = unchecked((int)0xC00000DE);

        /// <summary>
        /// The specified Domain did not exist.
        /// </summary>
        public const int STATUS_NO_SUCH_DOMAIN = unchecked((int)0xC00000DF);

        /// <summary>
        /// The specified Domain already exists.
        /// </summary>
        public const int STATUS_DOMAIN_EXISTS = unchecked((int)0xC00000E0);

        /// <summary>
        /// An attempt was made to exceed the limit on the number of domains per server for this release.
        /// </summary>
        public const int STATUS_DOMAIN_LIMIT_EXCEEDED = unchecked((int)0xC00000E1);

        /// <summary>
        /// Error status returned when oplock request is denied.
        /// </summary>
        public const int STATUS_OPLOCK_NOT_GRANTED = unchecked((int)0xC00000E2);

        /// <summary>
        /// Error status returned when an invalid oplock acknowledgment is received by a file system.
        /// </summary>
        public const int STATUS_INVALID_OPLOCK_PROTOCOL = unchecked((int)0xC00000E3);

        /// <summary>
        /// This error indicates that the requested operation cannot be completed due to a catastrophic media failure or on-disk data structure corruption.
        /// </summary>
        public const int STATUS_INTERNAL_DB_CORRUPTION = unchecked((int)0xC00000E4);

        /// <summary>
        /// An internal error occurred.
        /// </summary>
        public const int STATUS_INTERNAL_ERROR = unchecked((int)0xC00000E5);

        /// <summary>
        /// Indicates generic access types were contained in an access mask which should already be mapped to non-generic access types.
        /// </summary>
        public const int STATUS_GENERIC_NOT_MAPPED = unchecked((int)0xC00000E6);

        /// <summary>
        /// Indicates a security descriptor is not in the necessary format (absolute or self-relative).
        /// </summary>
        public const int STATUS_BAD_DESCRIPTOR_FORMAT = unchecked((int)0xC00000E7);

        //
        // Status codes raised by the Cache Manager which must be considered as
        // "expected" by its callers.
        //
        /// <summary>
        /// An access to a user buffer failed at an "expected" point in time. This code is defined since the caller does not want to accept STATUS_ACCESS_VIOLATION in its filter.
        /// </summary>
        public const int STATUS_INVALID_USER_BUFFER = unchecked((int)0xC00000E8);

        /// <summary>
        /// If an I/O error is returned which is not defined in the standard FsRtl filter, it is converted to the following error which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.
        /// </summary>
        public const int STATUS_UNEXPECTED_IO_ERROR = unchecked((int)0xC00000E9);

        /// <summary>
        /// If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.
        /// </summary>
        public const int STATUS_UNEXPECTED_MM_CREATE_ERR = unchecked((int)0xC00000EA);

        /// <summary>
        /// If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.
        /// </summary>
        public const int STATUS_UNEXPECTED_MM_MAP_ERROR = unchecked((int)0xC00000EB);

        /// <summary>
        /// If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.
        /// </summary>
        public const int STATUS_UNEXPECTED_MM_EXTEND_ERR = unchecked((int)0xC00000EC);

        /// <summary>
        /// The requested action is restricted for use by logon processes only. The calling process has not registered as a logon process.
        /// </summary>
        public const int STATUS_NOT_LOGON_PROCESS = unchecked((int)0xC00000ED);

        /// <summary>
        /// An attempt has been made to start a new session manager or LSA logon session with an ID that is already in use.
        /// </summary>
        public const int STATUS_LOGON_SESSION_EXISTS = unchecked((int)0xC00000EE);

        /// <summary>
        /// An invalid parameter was passed to a service or function as the first argument.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_1 = unchecked((int)0xC00000EF);

        /// <summary>
        /// An invalid parameter was passed to a service or function as the second argument.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_2 = unchecked((int)0xC00000F0);

        /// <summary>
        /// An invalid parameter was passed to a service or function as the third argument.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_3 = unchecked((int)0xC00000F1);

        /// <summary>
        /// An invalid parameter was passed to a service or function as the fourth argument.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_4 = unchecked((int)0xC00000F2);

        /// <summary>
        /// An invalid parameter was passed to a service or function as the fifth argument.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_5 = unchecked((int)0xC00000F3);

        /// <summary>
        /// An invalid parameter was passed to a service or function as the sixth argument.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_6 = unchecked((int)0xC00000F4);

        /// <summary>
        /// An invalid parameter was passed to a service or function as the seventh argument.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_7 = unchecked((int)0xC00000F5);

        /// <summary>
        /// An invalid parameter was passed to a service or function as the eighth argument.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_8 = unchecked((int)0xC00000F6);

        /// <summary>
        /// An invalid parameter was passed to a service or function as the ninth argument.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_9 = unchecked((int)0xC00000F7);

        /// <summary>
        /// An invalid parameter was passed to a service or function as the tenth argument.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_10 = unchecked((int)0xC00000F8);

        /// <summary>
        /// An invalid parameter was passed to a service or function as the eleventh argument.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_11 = unchecked((int)0xC00000F9);

        /// <summary>
        /// An invalid parameter was passed to a service or function as the twelfth argument.
        /// </summary>
        public const int STATUS_INVALID_PARAMETER_12 = unchecked((int)0xC00000FA);

        /// <summary>
        /// An attempt was made to access a network file, but the network software was not yet started.
        /// </summary>
        public const int STATUS_REDIRECTOR_NOT_STARTED = unchecked((int)0xC00000FB);

        /// <summary>
        /// An attempt was made to start the redirector, but the redirector has already been started.
        /// </summary>
        public const int STATUS_REDIRECTOR_STARTED = unchecked((int)0xC00000FC);

        /// <summary>
        /// A new guard page for the stack cannot be created.
        /// </summary>
        public const int STATUS_STACK_OVERFLOW = unchecked((int)0xC00000FD); // winnt

        /// <summary>
        /// A specified authentication package is unknown.
        /// </summary>
        public const int STATUS_NO_SUCH_PACKAGE = unchecked((int)0xC00000FE);

        /// <summary>
        /// A malformed function table was encountered during an unwind operation.
        /// </summary>
        public const int STATUS_BAD_FUNCTION_TABLE = unchecked((int)0xC00000FF);

        /// <summary>
        /// Indicates the specified environment variable name was not found in the specified environment block.
        /// </summary>
        public const int STATUS_VARIABLE_NOT_FOUND = unchecked((int)0xC0000100);

        /// <summary>
        /// Indicates that the directory trying to be deleted is not empty.
        /// </summary>
        public const int STATUS_DIRECTORY_NOT_EMPTY = unchecked((int)0xC0000101);

        /// <summary>
        /// {Corrupt File}
        /// The file or directory %hs is corrupt and unreadable.
        /// Please run the Chkdsk utility.
        /// </summary>
        public const int STATUS_FILE_CORRUPT_ERROR = unchecked((int)0xC0000102);

        /// <summary>
        /// A requested opened file is not a directory.
        /// </summary>
        public const int STATUS_NOT_A_DIRECTORY = unchecked((int)0xC0000103);

        /// <summary>
        /// The logon session is not in a state that is consistent with the requested operation.
        /// </summary>
        public const int STATUS_BAD_LOGON_SESSION_STATE = unchecked((int)0xC0000104);

        /// <summary>
        /// An internal LSA error has occurred. An authentication package has requested the creation of a Logon Session but the ID of an already existing Logon Session has been specified.
        /// </summary>
        public const int STATUS_LOGON_SESSION_COLLISION = unchecked((int)0xC0000105);

        /// <summary>
        /// A specified name string is too long for its intended use.
        /// </summary>
        public const int STATUS_NAME_TOO_LONG = unchecked((int)0xC0000106);

        /// <summary>
        /// The user attempted to force close the files on a redirected drive, but there were opened files on the drive, and the user did not specify a sufficient level of force.
        /// </summary>
        public const int STATUS_FILES_OPEN = unchecked((int)0xC0000107);

        /// <summary>
        /// The user attempted to force close the files on a redirected drive, but there were opened directories on the drive, and the user did not specify a sufficient level of force.
        /// </summary>
        public const int STATUS_CONNECTION_IN_USE = unchecked((int)0xC0000108);

        /// <summary>
        /// RtlFindMessage could not locate the requested message ID in the message table resource.
        /// </summary>
        public const int STATUS_MESSAGE_NOT_FOUND = unchecked((int)0xC0000109);

        /// <summary>
        /// An attempt was made to access an exiting process.
        /// </summary>
        public const int STATUS_PROCESS_IS_TERMINATING = unchecked((int)0xC000010A);

        /// <summary>
        /// Indicates an invalid value has been provided for the LogonType requested.
        /// </summary>
        public const int STATUS_INVALID_LOGON_TYPE = unchecked((int)0xC000010B);

        /// <summary>
        /// Indicates that an attempt was made to assign protection to a file system file or directory and one of the SIDs in the security descriptor could not be translated into a GUID that could be stored by the file system.
        /// This causes the protection attempt to fail, which may cause a file creation attempt to fail.
        /// </summary>
        public const int STATUS_NO_GUID_TRANSLATION = unchecked((int)0xC000010C);

        /// <summary>
        /// Indicates that an attempt has been made to impersonate via a named pipe that has not yet been read from.
        /// </summary>
        public const int STATUS_CANNOT_IMPERSONATE = unchecked((int)0xC000010D);

        /// <summary>
        /// Indicates that the specified image is already loaded.
        /// </summary>
        public const int STATUS_IMAGE_ALREADY_LOADED = unchecked((int)0xC000010E);


        //
        // ============================================================
        // NOTE: The following ABIOS error code should be reserved on
        //       non ABIOS kernel. Eventually, I will remove the ifdef
        //       ABIOS.
        // ============================================================
        //
        /// <summary>
        /// STATUS_ABIOS_NOT_PRESENT
        /// </summary>
        public const int STATUS_ABIOS_NOT_PRESENT = unchecked((int)0xC000010F);

        /// <summary>
        /// STATUS_ABIOS_LID_NOT_EXIST
        /// </summary>
        public const int STATUS_ABIOS_LID_NOT_EXIST = unchecked((int)0xC0000110);

        /// <summary>
        /// STATUS_ABIOS_LID_ALREADY_OWNED
        /// </summary>
        public const int STATUS_ABIOS_LID_ALREADY_OWNED = unchecked((int)0xC0000111);

        /// <summary>
        /// STATUS_ABIOS_NOT_LID_OWNER
        /// </summary>
        public const int STATUS_ABIOS_NOT_LID_OWNER = unchecked((int)0xC0000112);

        /// <summary>
        /// STATUS_ABIOS_INVALID_COMMAND
        /// </summary>
        public const int STATUS_ABIOS_INVALID_COMMAND = unchecked((int)0xC0000113);

        /// <summary>
        /// STATUS_ABIOS_INVALID_LID
        /// </summary>
        public const int STATUS_ABIOS_INVALID_LID = unchecked((int)0xC0000114);

        /// <summary>
        /// STATUS_ABIOS_SELECTOR_NOT_AVAILABLE
        /// </summary>
        public const int STATUS_ABIOS_SELECTOR_NOT_AVAILABLE = unchecked((int)0xC0000115);

        /// <summary>
        /// STATUS_ABIOS_INVALID_SELECTOR
        /// </summary>
        public const int STATUS_ABIOS_INVALID_SELECTOR = unchecked((int)0xC0000116);

        /// <summary>
        /// Indicates that an attempt was made to change the size of the LDT for a process that has no LDT.
        /// </summary>
        public const int STATUS_NO_LDT = unchecked((int)0xC0000117);

        /// <summary>
        /// Indicates that an attempt was made to grow an LDT by setting its size, or that the size was not an even number of selectors.
        /// </summary>
        public const int STATUS_INVALID_LDT_SIZE = unchecked((int)0xC0000118);

        /// <summary>
        /// Indicates that the starting value for the LDT information was not an integral multiple of the selector size.
        /// </summary>
        public const int STATUS_INVALID_LDT_OFFSET = unchecked((int)0xC0000119);

        /// <summary>
        /// Indicates that the user supplied an invalid descriptor when trying to set up Ldt descriptors.
        /// </summary>
        public const int STATUS_INVALID_LDT_DESCRIPTOR = unchecked((int)0xC000011A);

        /// <summary>
        /// The specified image file did not have the correct format. It appears to be NE format.
        /// </summary>
        public const int STATUS_INVALID_IMAGE_NE_FORMAT = unchecked((int)0xC000011B);

        /// <summary>
        /// Indicates that the transaction state of a registry sub-tree is incompatible with the requested operation. For example, a request has been made to start a new transaction with one already in progress, or a request has been made to apply a transaction when one is not currently in progress.
        /// </summary>
        public const int STATUS_RXACT_INVALID_STATE = unchecked((int)0xC000011C);

        /// <summary>
        /// Indicates an error has occurred during a registry transaction commit. The database has been left in an unknown, but probably inconsistent, state. The state of the registry transaction is left as COMMITTING.
        /// </summary>
        public const int STATUS_RXACT_COMMIT_FAILURE = unchecked((int)0xC000011D);

        /// <summary>
        /// An attempt was made to map a file of size zero with the maximum size specified as zero.
        /// </summary>
        public const int STATUS_MAPPED_FILE_SIZE_ZERO = unchecked((int)0xC000011E);

        /// <summary>
        /// Too many files are opened on a remote server.
        /// This error should only be returned by the Windows redirector on a remote drive.
        /// </summary>
        public const int STATUS_TOO_MANY_OPENED_FILES = unchecked((int)0xC000011F);

        /// <summary>
        /// The I/O request was canceled.
        /// </summary>
        public const int STATUS_CANCELLED = unchecked((int)0xC0000120);

        /// <summary>
        /// An attempt has been made to remove a file or directory that cannot be deleted.
        /// </summary>
        public const int STATUS_CANNOT_DELETE = unchecked((int)0xC0000121);

        /// <summary>
        /// Indicates a name specified as a remote computer name is syntactically invalid.
        /// </summary>
        public const int STATUS_INVALID_COMPUTER_NAME = unchecked((int)0xC0000122);

        /// <summary>
        /// An I/O request other than close was performed on a file after it has been deleted, which can only happen to a request which did not complete before the last handle was closed via NtClose.
        /// </summary>
        public const int STATUS_FILE_DELETED = unchecked((int)0xC0000123);

        /// <summary>
        /// Indicates an operation has been attempted on a built-in (special) SAM account which is incompatible with built-in accounts. For example, built-in accounts cannot be deleted.
        /// </summary>
        public const int STATUS_SPECIAL_ACCOUNT = unchecked((int)0xC0000124);

        /// <summary>
        /// The operation requested may not be performed on the specified group because it is a built-in special group.
        /// </summary>
        public const int STATUS_SPECIAL_GROUP = unchecked((int)0xC0000125);

        /// <summary>
        /// The operation requested may not be performed on the specified user because it is a built-in special user.
        /// </summary>
        public const int STATUS_SPECIAL_USER = unchecked((int)0xC0000126);

        /// <summary>
        /// Indicates a member cannot be removed from a group because the group is currently the member's primary group.
        /// </summary>
        public const int STATUS_MEMBERS_PRIMARY_GROUP = unchecked((int)0xC0000127);

        /// <summary>
        /// An I/O request other than close and several other special case operations was attempted using a file object that had already been closed.
        /// </summary>
        public const int STATUS_FILE_CLOSED = unchecked((int)0xC0000128);

        /// <summary>
        /// Indicates a process has too many threads to perform the requested action. For example, assignment of a primary token may only be performed when a process has zero or one threads.
        /// </summary>
        public const int STATUS_TOO_MANY_THREADS = unchecked((int)0xC0000129);

        /// <summary>
        /// An attempt was made to operate on a thread within a specific process, but the thread specified is not in the process specified.
        /// </summary>
        public const int STATUS_THREAD_NOT_IN_PROCESS = unchecked((int)0xC000012A);

        /// <summary>
        /// An attempt was made to establish a token for use as a primary token but the token is already in use. A token can only be the primary token of one process at a time.
        /// </summary>
        public const int STATUS_TOKEN_ALREADY_IN_USE = unchecked((int)0xC000012B);

        /// <summary>
        /// Page file quota was exceeded.
        /// </summary>
        public const int STATUS_PAGEFILE_QUOTA_EXCEEDED = unchecked((int)0xC000012C);

        /// <summary>
        /// {Out of Virtual Memory}
        /// Your system is low on virtual memory. To ensure that Windows runs properly, increase the size of your virtual memory paging file. For more information, see Help.
        /// </summary>
        public const int STATUS_COMMITMENT_LIMIT = unchecked((int)0xC000012D);

        /// <summary>
        /// The specified image file did not have the correct format, it appears to be LE format.
        /// </summary>
        public const int STATUS_INVALID_IMAGE_LE_FORMAT = unchecked((int)0xC000012E);

        /// <summary>
        /// The specified image file did not have the correct format, it did not have an initial MZ.
        /// </summary>
        public const int STATUS_INVALID_IMAGE_NOT_MZ = unchecked((int)0xC000012F);

        /// <summary>
        /// The specified image file did not have the correct format, it did not have a proper e_lfarlc in the MZ header.
        /// </summary>
        public const int STATUS_INVALID_IMAGE_PROTECT = unchecked((int)0xC0000130);

        /// <summary>
        /// The specified image file did not have the correct format, it appears to be a 16-bit Windows image.
        /// </summary>
        public const int STATUS_INVALID_IMAGE_WIN_16 = unchecked((int)0xC0000131);

        /// <summary>
        /// The Netlogon service cannot start because another Netlogon service running in the domain conflicts with the specified role.
        /// </summary>
        public const int STATUS_LOGON_SERVER_CONFLICT = unchecked((int)0xC0000132);

        /// <summary>
        /// The time at the Primary Domain Controller is different than the time at the Backup Domain Controller or member server by too large an amount.
        /// </summary>
        public const int STATUS_TIME_DIFFERENCE_AT_DC = unchecked((int)0xC0000133);

        /// <summary>
        /// The SAM database on a Windows Server is significantly out of synchronization with the copy on the Domain Controller. A complete synchronization is required.
        /// </summary>
        public const int STATUS_SYNCHRONIZATION_REQUIRED = unchecked((int)0xC0000134);

        /// <summary>
        /// The code execution cannot proceed because %hs was not found. Reinstalling the program may fix this problem.
        /// </summary>
        public const int STATUS_DLL_NOT_FOUND = unchecked((int)0xC0000135); // winnt

        /// <summary>
        /// The NtCreateFile API failed. This error should never be returned to an application, it is a place holder for the Windows Lan Manager Redirector to use in its internal error mapping routines.
        /// </summary>
        public const int STATUS_OPEN_FAILED = unchecked((int)0xC0000136);

        /// <summary>
        /// {Privilege Failed}
        /// The I/O permissions for the process could not be changed.
        /// </summary>
        public const int STATUS_IO_PRIVILEGE_FAILED = unchecked((int)0xC0000137);

        /// <summary>
        /// {Ordinal Not Found}
        /// The ordinal %ld could not be located in the dynamic link library %hs.
        /// </summary>
        public const int STATUS_ORDINAL_NOT_FOUND = unchecked((int)0xC0000138); // winnt

        /// <summary>
        /// {Entry Point Not Found}
        /// The procedure entry point %hs could not be located in the dynamic link library %hs.
        /// </summary>
        public const int STATUS_ENTRYPOINT_NOT_FOUND = unchecked((int)0xC0000139); // winnt

        /// <summary>
        /// {Application Exit by CTRL+C}
        /// The application terminated as a result of a CTRL+C.
        /// </summary>
        public const int STATUS_CONTROL_C_EXIT = unchecked((int)0xC000013A); // winnt

        /// <summary>
        /// {Virtual Circuit Closed}
        /// The network transport on your computer has closed a network connection. There may or may not be I/O requests outstanding.
        /// </summary>
        public const int STATUS_LOCAL_DISCONNECT = unchecked((int)0xC000013B);

        /// <summary>
        /// {Virtual Circuit Closed}
        /// The network transport on a remote computer has closed a network connection. There may or may not be I/O requests outstanding.
        /// </summary>
        public const int STATUS_REMOTE_DISCONNECT = unchecked((int)0xC000013C);

        /// <summary>
        /// {Insufficient Resources on Remote Computer}
        /// The remote computer has insufficient resources to complete the network request. For instance, there may not be enough memory available on the remote computer to carry out the request at this time.
        /// </summary>
        public const int STATUS_REMOTE_RESOURCES = unchecked((int)0xC000013D);

        /// <summary>
        /// {Virtual Circuit Closed}
        /// An existing connection (virtual circuit) has been broken at the remote computer. There is probably something wrong with the network software protocol or the network hardware on the remote computer.
        /// </summary>
        public const int STATUS_LINK_FAILED = unchecked((int)0xC000013E);

        /// <summary>
        /// {Virtual Circuit Closed}
        /// The network transport on your computer has closed a network connection because it had to wait too long for a response from the remote computer.
        /// </summary>
        public const int STATUS_LINK_TIMEOUT = unchecked((int)0xC000013F);

        /// <summary>
        /// The connection handle given to the transport was invalid.
        /// </summary>
        public const int STATUS_INVALID_CONNECTION = unchecked((int)0xC0000140);

        /// <summary>
        /// The address handle given to the transport was invalid.
        /// </summary>
        public const int STATUS_INVALID_ADDRESS = unchecked((int)0xC0000141);

        /// <summary>
        /// {DLL Initialization Failed}
        /// Initialization of the dynamic link library %hs failed. The process is terminating abnormally.
        /// </summary>
        public const int STATUS_DLL_INIT_FAILED = unchecked((int)0xC0000142); // winnt

        /// <summary>
        /// {Missing System File}
        /// The required system file %hs is bad or missing.
        /// </summary>
        public const int STATUS_MISSING_SYSTEMFILE = unchecked((int)0xC0000143);

        /// <summary>
        /// {Application Error}
        /// The exception %s (0x%08lx) occurred in the application at location 0x%p.
        /// </summary>
        public const int STATUS_UNHANDLED_EXCEPTION = unchecked((int)0xC0000144);

        /// <summary>
        /// {Application Error}
        /// The application was unable to start correctly (0x%lx). Click OK to close the application.
        /// </summary>
        public const int STATUS_APP_INIT_FAILURE = unchecked((int)0xC0000145);

        /// <summary>
        /// {Unable to Create Paging File}
        /// The creation of the paging file %hs failed (%lx). The requested size was %ld.
        /// </summary>
        public const int STATUS_PAGEFILE_CREATE_FAILED = unchecked((int)0xC0000146);

        /// <summary>
        /// {No Paging File Specified}
        /// No paging file was specified in the system configuration.
        /// </summary>
        public const int STATUS_NO_PAGEFILE = unchecked((int)0xC0000147);

        /// <summary>
        /// {Incorrect System Call Level}
        /// An invalid level was passed into the specified system call.
        /// </summary>
        public const int STATUS_INVALID_LEVEL = unchecked((int)0xC0000148);

        /// <summary>
        /// {Incorrect Password to LAN Manager Server}
        /// You specified an incorrect password to a LAN Manager 2.x or MS-NET server.
        /// </summary>
        public const int STATUS_WRONG_PASSWORD_CORE = unchecked((int)0xC0000149);

        /// <summary>
        /// {EXCEPTION}
        /// A real-mode application issued a floating-point instruction and floating-point hardware is not present.
        /// </summary>
        public const int STATUS_ILLEGAL_FLOAT_CONTEXT = unchecked((int)0xC000014A);

        /// <summary>
        /// The pipe operation has failed because the other end of the pipe has been closed.
        /// </summary>
        public const int STATUS_PIPE_BROKEN = unchecked((int)0xC000014B);

        /// <summary>
        /// {The Registry Is Corrupt}
        /// The structure of one of the files that contains Registry data is corrupt, or the image of the file in memory is corrupt, or the file could not be recovered because the alternate copy or log was absent or corrupt.
        /// </summary>
        public const int STATUS_REGISTRY_CORRUPT = unchecked((int)0xC000014C);

        /// <summary>
        /// An I/O operation initiated by the Registry failed unrecoverably. The Registry could not read in, or write out, or flush, one of the files that contain the system's image of the Registry.
        /// </summary>
        public const int STATUS_REGISTRY_IO_FAILED = unchecked((int)0xC000014D);

        /// <summary>
        /// An event pair synchronization operation was performed using the thread specific client/server event pair object, but no event pair object was associated with the thread.
        /// </summary>
        public const int STATUS_NO_EVENT_PAIR = unchecked((int)0xC000014E);

        /// <summary>
        /// The volume does not contain a recognized file system. Please make sure that all required file system drivers are loaded and that the volume is not corrupt.
        /// </summary>
        public const int STATUS_UNRECOGNIZED_VOLUME = unchecked((int)0xC000014F);

        /// <summary>
        /// No serial device was successfully initialized. The serial driver will unload.
        /// </summary>
        public const int STATUS_SERIAL_NO_DEVICE_INITED = unchecked((int)0xC0000150);

        /// <summary>
        /// The specified local group does not exist.
        /// </summary>
        public const int STATUS_NO_SUCH_ALIAS = unchecked((int)0xC0000151);

        /// <summary>
        /// The specified account name is not a member of the group.
        /// </summary>
        public const int STATUS_MEMBER_NOT_IN_ALIAS = unchecked((int)0xC0000152);

        /// <summary>
        /// The specified account name is already a member of the group.
        /// </summary>
        public const int STATUS_MEMBER_IN_ALIAS = unchecked((int)0xC0000153);

        /// <summary>
        /// The specified local group already exists.
        /// </summary>
        public const int STATUS_ALIAS_EXISTS = unchecked((int)0xC0000154);

        /// <summary>
        /// A requested type of logon (e.g., Interactive, Network, Service) is not granted by the target system's local security policy.
        /// Please ask the system administrator to grant the necessary form of logon.
        /// </summary>
        public const int STATUS_LOGON_NOT_GRANTED = unchecked((int)0xC0000155);

        /// <summary>
        /// The maximum number of secrets that may be stored in a single system has been exceeded. The length and number of secrets is limited to satisfy United States State Department export restrictions.
        /// </summary>
        public const int STATUS_TOO_MANY_SECRETS = unchecked((int)0xC0000156);

        /// <summary>
        /// The length of a secret exceeds the maximum length allowed. The length and number of secrets is limited to satisfy United States State Department export restrictions.
        /// </summary>
        public const int STATUS_SECRET_TOO_LONG = unchecked((int)0xC0000157);

        /// <summary>
        /// The Local Security Authority (LSA) database contains an internal inconsistency.
        /// </summary>
        public const int STATUS_INTERNAL_DB_ERROR = unchecked((int)0xC0000158);

        /// <summary>
        /// The requested operation cannot be performed in fullscreen mode.
        /// </summary>
        public const int STATUS_FULLSCREEN_MODE = unchecked((int)0xC0000159);

        /// <summary>
        /// During a logon attempt, the user's security context accumulated too many security IDs. This is a very unusual situation. Remove the user from some global or local groups to reduce the number of security ids to incorporate into the security context.
        /// </summary>
        public const int STATUS_TOO_MANY_CONTEXT_IDS = unchecked((int)0xC000015A);

        /// <summary>
        /// A user has requested a type of logon (e.g., interactive or network) that has not been granted. An administrator has control over who may logon interactively and through the network.
        /// </summary>
        public const int STATUS_LOGON_TYPE_NOT_GRANTED = unchecked((int)0xC000015B);

        /// <summary>
        /// The system has attempted to load or restore a file into the registry, and the specified file is not in the format of a registry file.
        /// </summary>
        public const int STATUS_NOT_REGISTRY_FILE = unchecked((int)0xC000015C);

        /// <summary>
        /// An attempt was made to change a user password in the security account manager without providing the necessary Windows cross-encrypted password.
        /// </summary>
        public const int STATUS_NT_CROSS_ENCRYPTION_REQUIRED = unchecked((int)0xC000015D);

        /// <summary>
        /// A Windows Server has an incorrect configuration.
        /// </summary>
        public const int STATUS_DOMAIN_CTRLR_CONFIG_ERROR = unchecked((int)0xC000015E);

        /// <summary>
        /// An attempt was made to explicitly access the secondary copy of information via a device control to the Fault Tolerance driver and the secondary copy is not present in the system.
        /// </summary>
        public const int STATUS_FT_MISSING_MEMBER = unchecked((int)0xC000015F);

        /// <summary>
        /// A configuration registry node representing a driver service entry was ill-formed and did not contain required value entries.
        /// </summary>
        public const int STATUS_ILL_FORMED_SERVICE_ENTRY = unchecked((int)0xC0000160);

        /// <summary>
        /// An illegal character was encountered. For a multi-byte character set this includes a lead byte without a succeeding trail byte. For the Unicode character set this includes the characters 0xFFFF and 0xFFFE.
        /// </summary>
        public const int STATUS_ILLEGAL_CHARACTER = unchecked((int)0xC0000161);

        /// <summary>
        /// No mapping for the Unicode character exists in the target multi-byte code page.
        /// </summary>
        public const int STATUS_UNMAPPABLE_CHARACTER = unchecked((int)0xC0000162);

        /// <summary>
        /// The Unicode character is not defined in the Unicode character set installed on the system.
        /// </summary>
        public const int STATUS_UNDEFINED_CHARACTER = unchecked((int)0xC0000163);

        /// <summary>
        /// The paging file cannot be created on a floppy diskette.
        /// </summary>
        public const int STATUS_FLOPPY_VOLUME = unchecked((int)0xC0000164);

        /// <summary>
        /// {Floppy Disk Error}
        /// While accessing a floppy disk, an ID address mark was not found.
        /// </summary>
        public const int STATUS_FLOPPY_ID_MARK_NOT_FOUND = unchecked((int)0xC0000165);

        /// <summary>
        /// {Floppy Disk Error}
        /// While accessing a floppy disk, the track address from the sector ID field was found to be different than the track address maintained by the controller.
        /// </summary>
        public const int STATUS_FLOPPY_WRONG_CYLINDER = unchecked((int)0xC0000166);

        /// <summary>
        /// {Floppy Disk Error}
        /// The floppy disk controller reported an error that is not recognized by the floppy disk driver.
        /// </summary>
        public const int STATUS_FLOPPY_UNKNOWN_ERROR = unchecked((int)0xC0000167);

        /// <summary>
        /// {Floppy Disk Error}
        /// While accessing a floppy-disk, the controller returned inconsistent results via its registers.
        /// </summary>
        public const int STATUS_FLOPPY_BAD_REGISTERS = unchecked((int)0xC0000168);

        /// <summary>
        /// {Hard Disk Error}
        /// While accessing the hard disk, a recalibrate operation failed, even after retries.
        /// </summary>
        public const int STATUS_DISK_RECALIBRATE_FAILED = unchecked((int)0xC0000169);

        /// <summary>
        /// {Hard Disk Error}
        /// While accessing the hard disk, a disk operation failed even after retries.
        /// </summary>
        public const int STATUS_DISK_OPERATION_FAILED = unchecked((int)0xC000016A);

        /// <summary>
        /// {Hard Disk Error}
        /// While accessing the hard disk, a disk controller reset was needed, but even that failed.
        /// </summary>
        public const int STATUS_DISK_RESET_FAILED = unchecked((int)0xC000016B);

        /// <summary>
        /// An attempt was made to open a device that was sharing an IRQ with other devices.
        /// At least one other device that uses that IRQ was already opened.
        /// Two concurrent opens of devices that share an IRQ and only work via interrupts is not supported for the particular bus type that the devices use.
        /// </summary>
        public const int STATUS_SHARED_IRQ_BUSY = unchecked((int)0xC000016C);

        /// <summary>
        /// {FT Orphaning}
        /// A disk that is part of a fault-tolerant volume can no longer be accessed.
        /// </summary>
        public const int STATUS_FT_ORPHANING = unchecked((int)0xC000016D);

        /// <summary>
        /// The system bios failed to connect a system interrupt to the device or bus for which the device is connected.
        /// </summary>
        public const int STATUS_BIOS_FAILED_TO_CONNECT_INTERRUPT = unchecked((int)0xC000016E);

        /// <summary>
        /// Tape could not be partitioned.
        /// </summary>
        public const int STATUS_PARTITION_FAILURE = unchecked((int)0xC0000172);

        /// <summary>
        /// When accessing a new tape of a multivolume partition, the current blocksize is incorrect.
        /// </summary>
        public const int STATUS_INVALID_BLOCK_LENGTH = unchecked((int)0xC0000173);

        /// <summary>
        /// Tape partition information could not be found when loading a tape.
        /// </summary>
        public const int STATUS_DEVICE_NOT_PARTITIONED = unchecked((int)0xC0000174);

        /// <summary>
        /// Attempt to lock the eject media mechanism fails.
        /// </summary>
        public const int STATUS_UNABLE_TO_LOCK_MEDIA = unchecked((int)0xC0000175);

        /// <summary>
        /// Unload media fails.
        /// </summary>
        public const int STATUS_UNABLE_TO_UNLOAD_MEDIA = unchecked((int)0xC0000176);

        /// <summary>
        /// Physical end of tape was detected.
        /// </summary>
        public const int STATUS_EOM_OVERFLOW = unchecked((int)0xC0000177);

        /// <summary>
        /// {No Media}
        /// There is no media in the drive. Please insert media into drive %hs.
        /// </summary>
        public const int STATUS_NO_MEDIA = unchecked((int)0xC0000178);

        /// <summary>
        /// A member could not be added to or removed from the local group because the member does not exist.
        /// </summary>
        public const int STATUS_NO_SUCH_MEMBER = unchecked((int)0xC000017A);

        /// <summary>
        /// A new member could not be added to a local group because the member has the wrong account type.
        /// </summary>
        public const int STATUS_INVALID_MEMBER = unchecked((int)0xC000017B);

        /// <summary>
        /// Illegal operation attempted on a registry key which has been marked for deletion.
        /// </summary>
        public const int STATUS_KEY_DELETED = unchecked((int)0xC000017C);

        /// <summary>
        /// System could not allocate required space in a registry log.
        /// </summary>
        public const int STATUS_NO_LOG_SPACE = unchecked((int)0xC000017D);

        /// <summary>
        /// Too many Sids have been specified.
        /// </summary>
        public const int STATUS_TOO_MANY_SIDS = unchecked((int)0xC000017E);

        /// <summary>
        /// An attempt was made to change a user password in the security account manager without providing the necessary LM cross-encrypted password.
        /// </summary>
        public const int STATUS_LM_CROSS_ENCRYPTION_REQUIRED = unchecked((int)0xC000017F);

        /// <summary>
        /// An attempt was made to create a symbolic link in a registry key that already has subkeys or values.
        /// </summary>
        public const int STATUS_KEY_HAS_CHILDREN = unchecked((int)0xC0000180);

        /// <summary>
        /// An attempt was made to create a Stable subkey under a Volatile parent key.
        /// </summary>
        public const int STATUS_CHILD_MUST_BE_VOLATILE = unchecked((int)0xC0000181);

        /// <summary>
        /// The I/O device is configured incorrectly or the configuration parameters to the driver are incorrect.
        /// </summary>
        public const int STATUS_DEVICE_CONFIGURATION_ERROR = unchecked((int)0xC0000182);

        /// <summary>
        /// An error was detected between two drivers or within an I/O driver.
        /// </summary>
        public const int STATUS_DRIVER_INTERNAL_ERROR = unchecked((int)0xC0000183);

        /// <summary>
        /// The device is not in a valid state to perform this request.
        /// </summary>
        public const int STATUS_INVALID_DEVICE_STATE = unchecked((int)0xC0000184);

        /// <summary>
        /// The I/O device reported an I/O error.
        /// </summary>
        public const int STATUS_IO_DEVICE_ERROR = unchecked((int)0xC0000185);

        /// <summary>
        /// A protocol error was detected between the driver and the device.
        /// </summary>
        public const int STATUS_DEVICE_PROTOCOL_ERROR = unchecked((int)0xC0000186);

        /// <summary>
        /// This operation is only allowed for the Primary Domain Controller of the domain.
        /// </summary>
        public const int STATUS_BACKUP_CONTROLLER = unchecked((int)0xC0000187);

        /// <summary>
        /// Log file space is insufficient to support this operation.
        /// </summary>
        public const int STATUS_LOG_FILE_FULL = unchecked((int)0xC0000188);

        /// <summary>
        /// A write operation was attempted to a volume after it was dismounted.
        /// </summary>
        public const int STATUS_TOO_LATE = unchecked((int)0xC0000189);

        /// <summary>
        /// The workstation does not have a trust secret for the primary domain in the local LSA database.
        /// </summary>
        public const int STATUS_NO_TRUST_LSA_SECRET = unchecked((int)0xC000018A);

        /// <summary>
        /// The SAM database on the Windows Server does not have a computer account for this workstation trust relationship.
        /// </summary>
        public const int STATUS_NO_TRUST_SAM_ACCOUNT = unchecked((int)0xC000018B);

        /// <summary>
        /// The logon request failed because the trust relationship between the primary domain and the trusted domain failed.
        /// </summary>
        public const int STATUS_TRUSTED_DOMAIN_FAILURE = unchecked((int)0xC000018C);

        /// <summary>
        /// The logon request failed because the trust relationship between this workstation and the primary domain failed.
        /// </summary>
        public const int STATUS_TRUSTED_RELATIONSHIP_FAILURE = unchecked((int)0xC000018D);

        /// <summary>
        /// The Eventlog log file is corrupt.
        /// </summary>
        public const int STATUS_EVENTLOG_FILE_CORRUPT = unchecked((int)0xC000018E);

        /// <summary>
        /// No Eventlog log file could be opened. The Eventlog service did not start.
        /// </summary>
        public const int STATUS_EVENTLOG_CANT_START = unchecked((int)0xC000018F);

        /// <summary>
        /// The network logon failed. This may be because the validation authority can't be reached.
        /// </summary>
        public const int STATUS_TRUST_FAILURE = unchecked((int)0xC0000190);

        /// <summary>
        /// An attempt was made to acquire a mutant such that its maximum count would have been exceeded.
        /// </summary>
        public const int STATUS_MUTANT_LIMIT_EXCEEDED = unchecked((int)0xC0000191);

        /// <summary>
        /// An attempt was made to logon, but the netlogon service was not started.
        /// </summary>
        public const int STATUS_NETLOGON_NOT_STARTED = unchecked((int)0xC0000192);

        /// <summary>
        /// The user's account has expired.
        /// </summary>
        public const int STATUS_ACCOUNT_EXPIRED = unchecked((int)0xC0000193); // ntsubauth

        /// <summary>
        /// {EXCEPTION}
        /// Possible deadlock condition.
        /// </summary>
        public const int STATUS_POSSIBLE_DEADLOCK = unchecked((int)0xC0000194);

        /// <summary>
        /// Multiple connections to a server or shared resource by the same user, using more than one user name, are not allowed. Disconnect all previous connections to the server or shared resource and try again.
        /// </summary>
        public const int STATUS_NETWORK_CREDENTIAL_CONFLICT = unchecked((int)0xC0000195);

        /// <summary>
        /// An attempt was made to establish a session to a network server, but there are already too many sessions established to that server.
        /// </summary>
        public const int STATUS_REMOTE_SESSION_LIMIT = unchecked((int)0xC0000196);

        /// <summary>
        /// The log file has changed between reads.
        /// </summary>
        public const int STATUS_EVENTLOG_FILE_CHANGED = unchecked((int)0xC0000197);

        /// <summary>
        /// The account used is an Interdomain Trust account. Use your global user account or local user account to access this server.
        /// </summary>
        public const int STATUS_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT = unchecked((int)0xC0000198);

        /// <summary>
        /// The account used is a Computer Account. Use your global user account or local user account to access this server.
        /// </summary>
        public const int STATUS_NOLOGON_WORKSTATION_TRUST_ACCOUNT = unchecked((int)0xC0000199);

        /// <summary>
        /// The account used is an Server Trust account. Use your global user account or local user account to access this server.
        /// </summary>
        public const int STATUS_NOLOGON_SERVER_TRUST_ACCOUNT = unchecked((int)0xC000019A);

        /// <summary>
        /// The name or SID of the domain specified is inconsistent with the trust information for that domain.
        /// </summary>
        public const int STATUS_DOMAIN_TRUST_INCONSISTENT = unchecked((int)0xC000019B);

        /// <summary>
        /// A volume has been accessed for which a file system driver is required that has not yet been loaded.
        /// </summary>
        public const int STATUS_FS_DRIVER_REQUIRED = unchecked((int)0xC000019C);

        /// <summary>
        /// Indicates that the specified image is already loaded as a DLL.
        /// </summary>
        public const int STATUS_IMAGE_ALREADY_LOADED_AS_DLL = unchecked((int)0xC000019D);

        /// <summary>
        /// Short name settings may not be changed on this volume due to the global registry setting.
        /// </summary>
        public const int STATUS_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING = unchecked((int)0xC000019E);

        /// <summary>
        /// Short names are not enabled on this volume.
        /// </summary>
        public const int STATUS_SHORT_NAMES_NOT_ENABLED_ON_VOLUME = unchecked((int)0xC000019F);

        /// <summary>
        /// The security stream for the given volume is in an inconsistent state.
        /// Please run CHKDSK on the volume.
        /// </summary>
        public const int STATUS_SECURITY_STREAM_IS_INCONSISTENT = unchecked((int)0xC00001A0);

        /// <summary>
        /// A requested file lock operation cannot be processed due to an invalid byte range.
        /// </summary>
        public const int STATUS_INVALID_LOCK_RANGE = unchecked((int)0xC00001A1);

        /// <summary>
        /// {Invalid ACE Condition}
        /// The specified access control entry (ACE) contains an invalid condition.
        /// </summary>
        public const int STATUS_INVALID_ACE_CONDITION = unchecked((int)0xC00001A2);

        /// <summary>
        /// The subsystem needed to support the image type is not present.
        /// </summary>
        public const int STATUS_IMAGE_SUBSYSTEM_NOT_PRESENT = unchecked((int)0xC00001A3);

        /// <summary>
        /// {Invalid ACE Condition}
        /// The specified file already has a notification GUID associated with it.
        /// </summary>
        public const int STATUS_NOTIFICATION_GUID_ALREADY_DEFINED = unchecked((int)0xC00001A4);

        /// <summary>
        /// An invalid exception handler routine has been detected.
        /// </summary>
        public const int STATUS_INVALID_EXCEPTION_HANDLER = unchecked((int)0xC00001A5);

        /// <summary>
        /// Duplicate privileges were specified for the token.
        /// </summary>
        public const int STATUS_DUPLICATE_PRIVILEGES = unchecked((int)0xC00001A6);

        /// <summary>
        /// Requested action not allowed on a file system internal file.
        /// </summary>
        public const int STATUS_NOT_ALLOWED_ON_SYSTEM_FILE = unchecked((int)0xC00001A7);

        /// <summary>
        /// A portion of the file system requires repair.
        /// </summary>
        public const int STATUS_REPAIR_NEEDED = unchecked((int)0xC00001A8);

        /// <summary>
        /// Quota support is not enabled on the system.
        /// </summary>
        public const int STATUS_QUOTA_NOT_ENABLED = unchecked((int)0xC00001A9);

        /// <summary>
        /// The operation failed because the application is not part of an application package.
        /// </summary>
        public const int STATUS_NO_APPLICATION_PACKAGE = unchecked((int)0xC00001AA);

        /// <summary>
        /// File metadata optimization is already in progress.
        /// </summary>
        public const int STATUS_FILE_METADATA_OPTIMIZATION_IN_PROGRESS = unchecked((int)0xC00001AB);

        /// <summary>
        /// The objects are not identical.
        /// </summary>
        public const int STATUS_NOT_SAME_OBJECT = unchecked((int)0xC00001AC);

        /// <summary>
        /// The process has terminated because it could not allocate additional memory.
        /// </summary>
        public const int STATUS_FATAL_MEMORY_EXHAUSTION = unchecked((int)0xC00001AD);

        /// <summary>
        /// The process is not part of a job.
        /// </summary>
        public const int STATUS_ERROR_PROCESS_NOT_IN_JOB = unchecked((int)0xC00001AE);

        /// <summary>
        /// The specified CPU Set IDs are invalid.
        /// </summary>
        public const int STATUS_CPU_SET_INVALID = unchecked((int)0xC00001AF);

        //
        //  Available range of NTSTATUS codes
        //
        /// <summary>
        /// A remote open failed because the network open restrictions were not satisfied.
        /// </summary>
        public const int STATUS_NETWORK_OPEN_RESTRICTION = unchecked((int)0xC0000201);

        /// <summary>
        /// There is no user session key for the specified logon session.
        /// </summary>
        public const int STATUS_NO_USER_SESSION_KEY = unchecked((int)0xC0000202);

        /// <summary>
        /// The remote user session has been deleted.
        /// </summary>
        public const int STATUS_USER_SESSION_DELETED = unchecked((int)0xC0000203);

        /// <summary>
        /// Indicates the specified resource language ID cannot be found in the
        /// image file.
        /// </summary>
        public const int STATUS_RESOURCE_LANG_NOT_FOUND = unchecked((int)0xC0000204);

        /// <summary>
        /// Insufficient server resources exist to complete the request.
        /// </summary>
        public const int STATUS_INSUFF_SERVER_RESOURCES = unchecked((int)0xC0000205);

        /// <summary>
        /// The size of the buffer is invalid for the specified operation.
        /// </summary>
        public const int STATUS_INVALID_BUFFER_SIZE = unchecked((int)0xC0000206);

        /// <summary>
        /// The transport rejected the network address specified as invalid.
        /// </summary>
        public const int STATUS_INVALID_ADDRESS_COMPONENT = unchecked((int)0xC0000207);

        /// <summary>
        /// The transport rejected the network address specified due to an invalid use of a wildcard.
        /// </summary>
        public const int STATUS_INVALID_ADDRESS_WILDCARD = unchecked((int)0xC0000208);

        /// <summary>
        /// The transport address could not be opened because all the available addresses are in use.
        /// </summary>
        public const int STATUS_TOO_MANY_ADDRESSES = unchecked((int)0xC0000209);

        /// <summary>
        /// The transport address could not be opened because it already exists.
        /// </summary>
        public const int STATUS_ADDRESS_ALREADY_EXISTS = unchecked((int)0xC000020A);

        /// <summary>
        /// The transport address is now closed.
        /// </summary>
        public const int STATUS_ADDRESS_CLOSED = unchecked((int)0xC000020B);

        /// <summary>
        /// The transport connection is now disconnected.
        /// </summary>
        public const int STATUS_CONNECTION_DISCONNECTED = unchecked((int)0xC000020C);

        /// <summary>
        /// The transport connection has been reset.
        /// </summary>
        public const int STATUS_CONNECTION_RESET = unchecked((int)0xC000020D);

        /// <summary>
        /// The transport cannot dynamically acquire any more nodes.
        /// </summary>
        public const int STATUS_TOO_MANY_NODES = unchecked((int)0xC000020E);

        /// <summary>
        /// The transport aborted a pending transaction.
        /// </summary>
        public const int STATUS_TRANSACTION_ABORTED = unchecked((int)0xC000020F);

        /// <summary>
        /// The transport timed out a request waiting for a response.
        /// </summary>
        public const int STATUS_TRANSACTION_TIMED_OUT = unchecked((int)0xC0000210);

        /// <summary>
        /// The transport did not receive a release for a pending response.
        /// </summary>
        public const int STATUS_TRANSACTION_NO_RELEASE = unchecked((int)0xC0000211);

        /// <summary>
        /// The transport did not find a transaction matching the specific token.
        /// </summary>
        public const int STATUS_TRANSACTION_NO_MATCH = unchecked((int)0xC0000212);

        /// <summary>
        /// The transport had previously responded to a transaction request.
        /// </summary>
        public const int STATUS_TRANSACTION_RESPONDED = unchecked((int)0xC0000213);

        /// <summary>
        /// The transport does not recognized the transaction request identifier specified.
        /// </summary>
        public const int STATUS_TRANSACTION_INVALID_ID = unchecked((int)0xC0000214);

        /// <summary>
        /// The transport does not recognize the transaction request type specified.
        /// </summary>
        public const int STATUS_TRANSACTION_INVALID_TYPE = unchecked((int)0xC0000215);

        /// <summary>
        /// The transport can only process the specified request on the server side of a session.
        /// </summary>
        public const int STATUS_NOT_SERVER_SESSION = unchecked((int)0xC0000216);

        /// <summary>
        /// The transport can only process the specified request on the client side of a session.
        /// </summary>
        public const int STATUS_NOT_CLIENT_SESSION = unchecked((int)0xC0000217);

        /// <summary>
        /// {Registry File Failure}
        /// The registry cannot load the hive (file):
        /// %hs
        /// or its log or alternate.
        /// It is corrupt, absent, or not writable.
        /// </summary>
        public const int STATUS_CANNOT_LOAD_REGISTRY_FILE = unchecked((int)0xC0000218);

        /// <summary>
        /// {Unexpected Failure in DebugActiveProcess}
        /// An unexpected failure occurred while processing a DebugActiveProcess API request. You may choose OK to terminate the process, or Cancel to ignore the error.
        /// </summary>
        public const int STATUS_DEBUG_ATTACH_FAILED = unchecked((int)0xC0000219);

        /// <summary>
        /// {Fatal System Error}
        /// The %hs system process terminated unexpectedly with a status of 0x%08x (0x%08x 0x%08x).
        /// The system has been shut down.
        /// </summary>
        public const int STATUS_SYSTEM_PROCESS_TERMINATED = unchecked((int)0xC000021A);

        /// <summary>
        /// {Data Not Accepted}
        /// The TDI client could not handle the data received during an indication.
        /// </summary>
        public const int STATUS_DATA_NOT_ACCEPTED = unchecked((int)0xC000021B);

        /// <summary>
        /// {Unable to Retrieve Browser Server List}
        /// The list of servers for this workgroup is not currently available.
        /// </summary>
        public const int STATUS_NO_BROWSER_SERVERS_FOUND = unchecked((int)0xC000021C);

        /// <summary>
        /// NTVDM encountered a hard error.
        /// </summary>
        public const int STATUS_VDM_HARD_ERROR = unchecked((int)0xC000021D);

        /// <summary>
        /// {Cancel Timeout}
        /// The driver %hs failed to complete a cancelled I/O request in the allotted time.
        /// </summary>
        public const int STATUS_DRIVER_CANCEL_TIMEOUT = unchecked((int)0xC000021E);

        /// <summary>
        /// {Reply Message Mismatch}
        /// An attempt was made to reply to an LPC message, but the thread specified by the client ID in the message was not waiting on that message.
        /// </summary>
        public const int STATUS_REPLY_MESSAGE_MISMATCH = unchecked((int)0xC000021F);

        /// <summary>
        /// {Mapped View Alignment Incorrect}
        /// An attempt was made to map a view of a file, but either the specified base address or the offset into the file were not aligned on the proper allocation granularity.
        /// </summary>
        public const int STATUS_MAPPED_ALIGNMENT = unchecked((int)0xC0000220);

        /// <summary>
        /// {Bad Image Checksum}
        /// The image %hs is possibly corrupt. The header checksum does not match the computed checksum.
        /// </summary>
        public const int STATUS_IMAGE_CHECKSUM_MISMATCH = unchecked((int)0xC0000221);

        /// <summary>
        /// {Delayed Write Failed}
        /// Windows was unable to save all the data for the file %hs. The data has been lost. This error may be caused by a failure of your computer hardware or network connection. Please try to save this file elsewhere.
        /// </summary>
        public const int STATUS_LOST_WRITEBEHIND_DATA = unchecked((int)0xC0000222);

        /// <summary>
        /// The parameter(s) passed to the server in the client/server shared memory window were invalid. Too much data may have been put in the shared memory window.
        /// </summary>
        public const int STATUS_CLIENT_SERVER_PARAMETERS_INVALID = unchecked((int)0xC0000223);

        /// <summary>
        /// The user's password must be changed before signing in.
        /// </summary>
        public const int STATUS_PASSWORD_MUST_CHANGE = unchecked((int)0xC0000224); // ntsubauth

        /// <summary>
        /// The object was not found.
        /// </summary>
        public const int STATUS_NOT_FOUND = unchecked((int)0xC0000225);

        /// <summary>
        /// The stream is not a tiny stream.
        /// </summary>
        public const int STATUS_NOT_TINY_STREAM = unchecked((int)0xC0000226);

        /// <summary>
        /// A transaction recover failed.
        /// </summary>
        public const int STATUS_RECOVERY_FAILURE = unchecked((int)0xC0000227);

        /// <summary>
        /// The request must be handled by the stack overflow code.
        /// </summary>
        public const int STATUS_STACK_OVERFLOW_READ = unchecked((int)0xC0000228);

        /// <summary>
        /// A consistency check failed.
        /// </summary>
        public const int STATUS_FAIL_CHECK = unchecked((int)0xC0000229);

        /// <summary>
        /// The attempt to insert the ID in the index failed because the ID is already in the index.
        /// </summary>
        public const int STATUS_DUPLICATE_OBJECTID = unchecked((int)0xC000022A);

        /// <summary>
        /// The attempt to set the object's ID failed because the object already has an ID.
        /// </summary>
        public const int STATUS_OBJECTID_EXISTS = unchecked((int)0xC000022B);

        /// <summary>
        /// Internal OFS status codes indicating how an allocation operation is handled. Either it is retried after the containing onode is moved or the extent stream is converted to a large stream.
        /// </summary>
        public const int STATUS_CONVERT_TO_LARGE = unchecked((int)0xC000022C);

        /// <summary>
        /// The request needs to be retried.
        /// </summary>
        public const int STATUS_RETRY = unchecked((int)0xC000022D);

        /// <summary>
        /// The attempt to find the object found an object matching by ID on the volume but it is out of the scope of the handle used for the operation.
        /// </summary>
        public const int STATUS_FOUND_OUT_OF_SCOPE = unchecked((int)0xC000022E);

        /// <summary>
        /// The bucket array must be grown. Retry transaction after doing so.
        /// </summary>
        public const int STATUS_ALLOCATE_BUCKET = unchecked((int)0xC000022F);

        /// <summary>
        /// The property set specified does not exist on the object.
        /// </summary>
        public const int STATUS_PROPSET_NOT_FOUND = unchecked((int)0xC0000230);

        /// <summary>
        /// The user/kernel marshalling buffer has overflowed.
        /// </summary>
        public const int STATUS_MARSHALL_OVERFLOW = unchecked((int)0xC0000231);

        /// <summary>
        /// The supplied variant structure contains invalid data.
        /// </summary>
        public const int STATUS_INVALID_VARIANT = unchecked((int)0xC0000232);

        /// <summary>
        /// Could not find a domain controller for this domain.
        /// </summary>
        public const int STATUS_DOMAIN_CONTROLLER_NOT_FOUND = unchecked((int)0xC0000233);

        /// <summary>
        /// The user account has been automatically locked because too many invalid logon attempts or password change attempts have been requested.
        /// </summary>
        public const int STATUS_ACCOUNT_LOCKED_OUT = unchecked((int)0xC0000234); // ntsubauth

        /// <summary>
        /// NtClose was called on a handle that was protected from close via NtSetInformationObject.
        /// </summary>
        public const int STATUS_HANDLE_NOT_CLOSABLE = unchecked((int)0xC0000235);

        /// <summary>
        /// The transport connection attempt was refused by the remote system.
        /// </summary>
        public const int STATUS_CONNECTION_REFUSED = unchecked((int)0xC0000236);

        /// <summary>
        /// The transport connection was gracefully closed.
        /// </summary>
        public const int STATUS_GRACEFUL_DISCONNECT = unchecked((int)0xC0000237);

        /// <summary>
        /// The transport endpoint already has an address associated with it.
        /// </summary>
        public const int STATUS_ADDRESS_ALREADY_ASSOCIATED = unchecked((int)0xC0000238);

        /// <summary>
        /// An address has not yet been associated with the transport endpoint.
        /// </summary>
        public const int STATUS_ADDRESS_NOT_ASSOCIATED = unchecked((int)0xC0000239);

        /// <summary>
        /// An operation was attempted on a nonexistent transport connection.
        /// </summary>
        public const int STATUS_CONNECTION_INVALID = unchecked((int)0xC000023A);

        /// <summary>
        /// An invalid operation was attempted on an active transport connection.
        /// </summary>
        public const int STATUS_CONNECTION_ACTIVE = unchecked((int)0xC000023B);

        /// <summary>
        /// The remote network is not reachable by the transport.
        /// </summary>
        public const int STATUS_NETWORK_UNREACHABLE = unchecked((int)0xC000023C);

        /// <summary>
        /// The remote system is not reachable by the transport.
        /// </summary>
        public const int STATUS_HOST_UNREACHABLE = unchecked((int)0xC000023D);

        /// <summary>
        /// The remote system does not support the transport protocol.
        /// </summary>
        public const int STATUS_PROTOCOL_UNREACHABLE = unchecked((int)0xC000023E);

        /// <summary>
        /// No service is operating at the destination port of the transport on the remote system.
        /// </summary>
        public const int STATUS_PORT_UNREACHABLE = unchecked((int)0xC000023F);

        /// <summary>
        /// The request was aborted.
        /// </summary>
        public const int STATUS_REQUEST_ABORTED = unchecked((int)0xC0000240);

        /// <summary>
        /// The transport connection was aborted by the local system.
        /// </summary>
        public const int STATUS_CONNECTION_ABORTED = unchecked((int)0xC0000241);

        /// <summary>
        /// The specified buffer contains ill-formed data.
        /// </summary>
        public const int STATUS_BAD_COMPRESSION_BUFFER = unchecked((int)0xC0000242);

        /// <summary>
        /// The requested operation cannot be performed on a file with a user mapped section open.
        /// </summary>
        public const int STATUS_USER_MAPPED_FILE = unchecked((int)0xC0000243);

        /// <summary>
        /// {Audit Failed}
        /// An attempt to generate a security audit failed.
        /// </summary>
        public const int STATUS_AUDIT_FAILED = unchecked((int)0xC0000244);

        /// <summary>
        /// The timer resolution was not previously set by the current process.
        /// </summary>
        public const int STATUS_TIMER_RESOLUTION_NOT_SET = unchecked((int)0xC0000245);

        /// <summary>
        /// A connection to the server could not be made because the limit on the number of concurrent connections for this account has been reached.
        /// </summary>
        public const int STATUS_CONNECTION_COUNT_LIMIT = unchecked((int)0xC0000246);

        /// <summary>
        /// Attempting to login during an unauthorized time of day for this account.
        /// </summary>
        public const int STATUS_LOGIN_TIME_RESTRICTION = unchecked((int)0xC0000247);

        /// <summary>
        /// The account is not authorized to login from this station.
        /// </summary>
        public const int STATUS_LOGIN_WKSTA_RESTRICTION = unchecked((int)0xC0000248);

        /// <summary>
        /// {UP/MP Image Mismatch}
        /// The image %hs has been modified for use on a uniprocessor system, but you are running it on a multiprocessor machine.
        /// Please reinstall the image file.
        /// </summary>
        public const int STATUS_IMAGE_MP_UP_MISMATCH = unchecked((int)0xC0000249);

        /// <summary>
        /// There is insufficient account information to log you on.
        /// </summary>
        public const int STATUS_INSUFFICIENT_LOGON_INFO = unchecked((int)0xC0000250);

        /// <summary>
        /// {Invalid DLL Entrypoint}
        /// The dynamic link library %hs is not written correctly. The stack pointer has been left in an inconsistent state. The entrypoint should be declared as WINAPI or STDCALL. Select YES to fail the DLL load. Select NO to continue execution. Selecting NO may cause the application to operate incorrectly.
        /// </summary>
        public const int STATUS_BAD_DLL_ENTRYPOINT = unchecked((int)0xC0000251);

        /// <summary>
        /// {Invalid Service Callback Entrypoint}
        /// The %hs service is not written correctly. The stack pointer has been left in an inconsistent state. The callback entrypoint should be declared as WINAPI or STDCALL. Selecting OK will cause the service to continue operation. However, the service process may operate incorrectly.
        /// </summary>
        public const int STATUS_BAD_SERVICE_ENTRYPOINT = unchecked((int)0xC0000252);

        /// <summary>
        /// The server received the messages but did not send a reply.
        /// </summary>
        public const int STATUS_LPC_REPLY_LOST = unchecked((int)0xC0000253);

        /// <summary>
        /// There is an IP address conflict with another system on the network
        /// </summary>
        public const int STATUS_IP_ADDRESS_CONFLICT1 = unchecked((int)0xC0000254);

        /// <summary>
        /// There is an IP address conflict with another system on the network
        /// </summary>
        public const int STATUS_IP_ADDRESS_CONFLICT2 = unchecked((int)0xC0000255);

        /// <summary>
        /// {Low On Registry Space}
        /// The system has reached the maximum size allowed for the system part of the registry. Additional storage requests will be ignored.
        /// </summary>
        public const int STATUS_REGISTRY_QUOTA_LIMIT = unchecked((int)0xC0000256);

        /// <summary>
        /// The contacted server does not support the indicated part of the DFS namespace.
        /// </summary>
        public const int STATUS_PATH_NOT_COVERED = unchecked((int)0xC0000257);

        /// <summary>
        /// A callback return system service cannot be executed when no callback is active.
        /// </summary>
        public const int STATUS_NO_CALLBACK_ACTIVE = unchecked((int)0xC0000258);

        /// <summary>
        /// The service being accessed is licensed for a particular number of connections. No more connections can be made to the service at this time because there are already as many connections as the service can accept.
        /// </summary>
        public const int STATUS_LICENSE_QUOTA_EXCEEDED = unchecked((int)0xC0000259);

        /// <summary>
        /// The password provided is too short to meet the policy of your user account. Please choose a longer password.
        /// </summary>
        public const int STATUS_PWD_TOO_SHORT = unchecked((int)0xC000025A);

        /// <summary>
        /// The policy of your user account does not allow you to change passwords too frequently. This is done to prevent users from changing back to a familiar, but potentially discovered, password. If you feel your password has been compromised then please contact your administrator immediately to have a new one assigned.
        /// </summary>
        public const int STATUS_PWD_TOO_RECENT = unchecked((int)0xC000025B);

        /// <summary>
        /// You have attempted to change your password to one that you have used in the past. The policy of your user account does not allow this. Please select a password that you have not previously used.
        /// </summary>
        public const int STATUS_PWD_HISTORY_CONFLICT = unchecked((int)0xC000025C);

        /// <summary>
        /// You have attempted to load a legacy device driver while its device instance had been disabled.
        /// </summary>
        public const int STATUS_PLUGPLAY_NO_DEVICE = unchecked((int)0xC000025E);

        /// <summary>
        /// The specified compression format is unsupported.
        /// </summary>
        public const int STATUS_UNSUPPORTED_COMPRESSION = unchecked((int)0xC000025F);

        /// <summary>
        /// The specified hardware profile configuration is invalid.
        /// </summary>
        public const int STATUS_INVALID_HW_PROFILE = unchecked((int)0xC0000260);

        /// <summary>
        /// The specified Plug and Play registry device path is invalid.
        /// </summary>
        public const int STATUS_INVALID_PLUGPLAY_DEVICE_PATH = unchecked((int)0xC0000261);

        /// <summary>
        /// {Driver Entry Point Not Found}
        /// The %hs device driver could not locate the ordinal %ld in driver %hs.
        /// </summary>
        public const int STATUS_DRIVER_ORDINAL_NOT_FOUND = unchecked((int)0xC0000262);

        /// <summary>
        /// {Driver Entry Point Not Found}
        /// The %hs device driver could not locate the entry point %hs in driver %hs.
        /// </summary>
        public const int STATUS_DRIVER_ENTRYPOINT_NOT_FOUND = unchecked((int)0xC0000263);

        /// <summary>
        /// {Application Error}
        /// The application attempted to release a resource it did not own. Click OK to terminate the application.
        /// </summary>
        public const int STATUS_RESOURCE_NOT_OWNED = unchecked((int)0xC0000264);

        /// <summary>
        /// An attempt was made to create more links on a file than the file system supports.
        /// </summary>
        public const int STATUS_TOO_MANY_LINKS = unchecked((int)0xC0000265);

        /// <summary>
        /// The specified quota list is internally inconsistent with its descriptor.
        /// </summary>
        public const int STATUS_QUOTA_LIST_INCONSISTENT = unchecked((int)0xC0000266);

        /// <summary>
        /// The specified file has been relocated to offline storage.
        /// </summary>
        public const int STATUS_FILE_IS_OFFLINE = unchecked((int)0xC0000267);

        /// <summary>
        /// {Windows Evaluation Notification}
        /// The evaluation period for this installation of Windows has expired. This system will shutdown in 1 hour. To restore access to this installation of Windows, please upgrade this installation using a licensed distribution of this product.
        /// </summary>
        public const int STATUS_EVALUATION_EXPIRATION = unchecked((int)0xC0000268);

        /// <summary>
        /// {Illegal System DLL Relocation}
        /// The system DLL %hs was relocated in memory. The application will not run properly. The relocation occurred because the DLL %hs occupied an address range reserved for Windows system DLLs. The vendor supplying the DLL should be contacted for a new DLL.
        /// </summary>
        public const int STATUS_ILLEGAL_DLL_RELOCATION = unchecked((int)0xC0000269);

        /// <summary>
        /// {License Violation}
        /// The system has detected tampering with your registered product type. This is a violation of your software license. Tampering with product type is not permitted.
        /// </summary>
        public const int STATUS_LICENSE_VIOLATION = unchecked((int)0xC000026A);

        /// <summary>
        /// {DLL Initialization Failed}
        /// The application failed to initialize because the window station is shutting down.
        /// </summary>
        public const int STATUS_DLL_INIT_FAILED_LOGOFF = unchecked((int)0xC000026B);

        /// <summary>
        /// {Unable to Load Device Driver}
        /// %hs device driver could not be loaded.
        /// Error Status was 0x%x
        /// </summary>
        public const int STATUS_DRIVER_UNABLE_TO_LOAD = unchecked((int)0xC000026C);

        /// <summary>
        /// DFS is unavailable on the contacted server.
        /// </summary>
        public const int STATUS_DFS_UNAVAILABLE = unchecked((int)0xC000026D);

        /// <summary>
        /// An operation was attempted to a volume after it was dismounted.
        /// </summary>
        public const int STATUS_VOLUME_DISMOUNTED = unchecked((int)0xC000026E);

        /// <summary>
        /// An internal error occurred in the Win32 x86 emulation subsystem.
        /// </summary>
        public const int STATUS_WX86_INTERNAL_ERROR = unchecked((int)0xC000026F);

        /// <summary>
        /// Win32 x86 emulation subsystem Floating-point stack check.
        /// </summary>
        public const int STATUS_WX86_FLOAT_STACK_CHECK = unchecked((int)0xC0000270);

        /// <summary>
        /// The validation process needs to continue on to the next step.
        /// </summary>
        public const int STATUS_VALIDATE_CONTINUE = unchecked((int)0xC0000271);

        /// <summary>
        /// There was no match for the specified key in the index.
        /// </summary>
        public const int STATUS_NO_MATCH = unchecked((int)0xC0000272);

        /// <summary>
        /// There are no more matches for the current index enumeration.
        /// </summary>
        public const int STATUS_NO_MORE_MATCHES = unchecked((int)0xC0000273);

        /// <summary>
        /// The file or directory is not a reparse point.
        /// </summary>
        public const int STATUS_NOT_A_REPARSE_POINT = unchecked((int)0xC0000275);

        /// <summary>
        /// The Windows I/O reparse tag passed for the reparse point is invalid.
        /// </summary>
        public const int STATUS_IO_REPARSE_TAG_INVALID = unchecked((int)0xC0000276);

        /// <summary>
        /// The Windows I/O reparse tag does not match the one present in the reparse point.
        /// </summary>
        public const int STATUS_IO_REPARSE_TAG_MISMATCH = unchecked((int)0xC0000277);

        /// <summary>
        /// The user data passed for the reparse point is invalid.
        /// </summary>
        public const int STATUS_IO_REPARSE_DATA_INVALID = unchecked((int)0xC0000278);

        /// <summary>
        /// The layered file system driver for this IO tag did not handle it when needed.
        /// </summary>
        public const int STATUS_IO_REPARSE_TAG_NOT_HANDLED = unchecked((int)0xC0000279);

        /// <summary>
        /// The password provided is too long to meet the policy of your user account. Please choose a shorter password.
        /// </summary>
        public const int STATUS_PWD_TOO_LONG = unchecked((int)0xC000027A);

        /// <summary>
        /// An application-internal exception has occurred.
        /// </summary>
        public const int STATUS_STOWED_EXCEPTION = unchecked((int)0xC000027B);

        /// <summary>
        /// An application-internal exception has occurred.
        /// </summary>
        public const int STATUS_CONTEXT_STOWED_EXCEPTION = unchecked((int)0xC000027C);

        /// <summary>
        /// The symbolic link could not be resolved even though the initial file name is valid.
        /// </summary>
        public const int STATUS_REPARSE_POINT_NOT_RESOLVED = unchecked((int)0xC0000280);

        /// <summary>
        /// The directory is a reparse point.
        /// </summary>
        public const int STATUS_DIRECTORY_IS_A_REPARSE_POINT = unchecked((int)0xC0000281);

        /// <summary>
        /// The range could not be added to the range list because of a conflict.
        /// </summary>
        public const int STATUS_RANGE_LIST_CONFLICT = unchecked((int)0xC0000282);

        /// <summary>
        /// The specified medium changer source element contains no media.
        /// </summary>
        public const int STATUS_SOURCE_ELEMENT_EMPTY = unchecked((int)0xC0000283);

        /// <summary>
        /// The specified medium changer destination element already contains media.
        /// </summary>
        public const int STATUS_DESTINATION_ELEMENT_FULL = unchecked((int)0xC0000284);

        /// <summary>
        /// The specified medium changer element does not exist.
        /// </summary>
        public const int STATUS_ILLEGAL_ELEMENT_ADDRESS = unchecked((int)0xC0000285);

        /// <summary>
        /// The specified element is contained within a magazine that is no longer present.
        /// </summary>
        public const int STATUS_MAGAZINE_NOT_PRESENT = unchecked((int)0xC0000286);

        /// <summary>
        /// The device requires reinitialization due to hardware errors.
        /// </summary>
        public const int STATUS_REINITIALIZATION_NEEDED = unchecked((int)0xC0000287);

        /// <summary>
        /// The device has indicated that cleaning is necessary.
        /// </summary>
        public const int STATUS_DEVICE_REQUIRES_CLEANING = unchecked((int)0x80000288);

        /// <summary>
        /// The device has indicated that its door is open. Further operations require it closed and secured.
        /// </summary>
        public const int STATUS_DEVICE_DOOR_OPEN = unchecked((int)0x80000289);

        /// <summary>
        /// The file encryption attempt failed.
        /// </summary>
        public const int STATUS_ENCRYPTION_FAILED = unchecked((int)0xC000028A);

        /// <summary>
        /// The file decryption attempt failed.
        /// </summary>
        public const int STATUS_DECRYPTION_FAILED = unchecked((int)0xC000028B);

        /// <summary>
        /// The specified range could not be found in the range list.
        /// </summary>
        public const int STATUS_RANGE_NOT_FOUND = unchecked((int)0xC000028C);

        /// <summary>
        /// There is no encryption recovery policy configured for this system.
        /// </summary>
        public const int STATUS_NO_RECOVERY_POLICY = unchecked((int)0xC000028D);

        /// <summary>
        /// The required encryption driver is not loaded for this system.
        /// </summary>
        public const int STATUS_NO_EFS = unchecked((int)0xC000028E);

        /// <summary>
        /// The file was encrypted with a different encryption driver than is currently loaded.
        /// </summary>
        public const int STATUS_WRONG_EFS = unchecked((int)0xC000028F);

        /// <summary>
        /// There are no EFS keys defined for the user.
        /// </summary>
        public const int STATUS_NO_USER_KEYS = unchecked((int)0xC0000290);

        /// <summary>
        /// The specified file is not encrypted.
        /// </summary>
        public const int STATUS_FILE_NOT_ENCRYPTED = unchecked((int)0xC0000291);

        /// <summary>
        /// The specified file is not in the defined EFS export format.
        /// </summary>
        public const int STATUS_NOT_EXPORT_FORMAT = unchecked((int)0xC0000292);

        /// <summary>
        /// The specified file is encrypted and the user does not have the ability to decrypt it.
        /// </summary>
        public const int STATUS_FILE_ENCRYPTED = unchecked((int)0xC0000293);

        /// <summary>
        /// The system has awoken
        /// </summary>
        public const int STATUS_WAKE_SYSTEM = 0x40000294;

        /// <summary>
        /// The guid passed was not recognized as valid by a WMI data provider.
        /// </summary>
        public const int STATUS_WMI_GUID_NOT_FOUND = unchecked((int)0xC0000295);

        /// <summary>
        /// The instance name passed was not recognized as valid by a WMI data provider.
        /// </summary>
        public const int STATUS_WMI_INSTANCE_NOT_FOUND = unchecked((int)0xC0000296);

        /// <summary>
        /// The data item id passed was not recognized as valid by a WMI data provider.
        /// </summary>
        public const int STATUS_WMI_ITEMID_NOT_FOUND = unchecked((int)0xC0000297);

        /// <summary>
        /// The WMI request could not be completed and should be retried.
        /// </summary>
        public const int STATUS_WMI_TRY_AGAIN = unchecked((int)0xC0000298);

        /// <summary>
        /// The policy object is shared and can only be modified at the root
        /// </summary>
        public const int STATUS_SHARED_POLICY = unchecked((int)0xC0000299);

        /// <summary>
        /// The policy object does not exist when it should
        /// </summary>
        public const int STATUS_POLICY_OBJECT_NOT_FOUND = unchecked((int)0xC000029A);

        /// <summary>
        /// The requested policy information only lives in the Ds
        /// </summary>
        public const int STATUS_POLICY_ONLY_IN_DS = unchecked((int)0xC000029B);

        /// <summary>
        /// The volume must be upgraded to enable this feature
        /// </summary>
        public const int STATUS_VOLUME_NOT_UPGRADED = unchecked((int)0xC000029C);

        /// <summary>
        /// The remote storage service is not operational at this time.
        /// </summary>
        public const int STATUS_REMOTE_STORAGE_NOT_ACTIVE = unchecked((int)0xC000029D);

        /// <summary>
        /// The remote storage service encountered a media error.
        /// </summary>
        public const int STATUS_REMOTE_STORAGE_MEDIA_ERROR = unchecked((int)0xC000029E);

        /// <summary>
        /// The tracking (workstation) service is not running.
        /// </summary>
        public const int STATUS_NO_TRACKING_SERVICE = unchecked((int)0xC000029F);

        /// <summary>
        /// The server process is running under a SID different than that required by client.
        /// </summary>
        public const int STATUS_SERVER_SID_MISMATCH = unchecked((int)0xC00002A0);

        //
        // Directory Service specific Errors
        //
        /// <summary>
        /// The specified directory service attribute or value does not exist.
        /// </summary>
        public const int STATUS_DS_NO_ATTRIBUTE_OR_VALUE = unchecked((int)0xC00002A1);

        /// <summary>
        /// The attribute syntax specified to the directory service is invalid.
        /// </summary>
        public const int STATUS_DS_INVALID_ATTRIBUTE_SYNTAX = unchecked((int)0xC00002A2);

        /// <summary>
        /// The attribute type specified to the directory service is not defined.
        /// </summary>
        public const int STATUS_DS_ATTRIBUTE_TYPE_UNDEFINED = unchecked((int)0xC00002A3);

        /// <summary>
        /// The specified directory service attribute or value already exists.
        /// </summary>
        public const int STATUS_DS_ATTRIBUTE_OR_VALUE_EXISTS = unchecked((int)0xC00002A4);

        /// <summary>
        /// The directory service is busy.
        /// </summary>
        public const int STATUS_DS_BUSY = unchecked((int)0xC00002A5);

        /// <summary>
        /// The directory service is not available.
        /// </summary>
        public const int STATUS_DS_UNAVAILABLE = unchecked((int)0xC00002A6);

        /// <summary>
        /// The directory service was unable to allocate a relative identifier.
        /// </summary>
        public const int STATUS_DS_NO_RIDS_ALLOCATED = unchecked((int)0xC00002A7);

        /// <summary>
        /// The directory service has exhausted the pool of relative identifiers.
        /// </summary>
        public const int STATUS_DS_NO_MORE_RIDS = unchecked((int)0xC00002A8);

        /// <summary>
        /// The requested operation could not be performed because the directory service is not the master for that type of operation.
        /// </summary>
        public const int STATUS_DS_INCORRECT_ROLE_OWNER = unchecked((int)0xC00002A9);

        /// <summary>
        /// The directory service was unable to initialize the subsystem that allocates relative identifiers.
        /// </summary>
        public const int STATUS_DS_RIDMGR_INIT_ERROR = unchecked((int)0xC00002AA);

        /// <summary>
        /// The requested operation did not satisfy one or more constraints associated with the class of the object.
        /// </summary>
        public const int STATUS_DS_OBJ_CLASS_VIOLATION = unchecked((int)0xC00002AB);

        /// <summary>
        /// The directory service can perform the requested operation only on a leaf object.
        /// </summary>
        public const int STATUS_DS_CANT_ON_NON_LEAF = unchecked((int)0xC00002AC);

        /// <summary>
        /// The directory service cannot perform the requested operation on the Relatively Defined Name (RDN) attribute of an object.
        /// </summary>
        public const int STATUS_DS_CANT_ON_RDN = unchecked((int)0xC00002AD);

        /// <summary>
        /// The directory service detected an attempt to modify the object class of an object.
        /// </summary>
        public const int STATUS_DS_CANT_MOD_OBJ_CLASS = unchecked((int)0xC00002AE);

        /// <summary>
        /// An error occurred while performing a cross domain move operation.
        /// </summary>
        public const int STATUS_DS_CROSS_DOM_MOVE_FAILED = unchecked((int)0xC00002AF);

        /// <summary>
        /// Unable to Contact the Global Catalog Server.
        /// </summary>
        public const int STATUS_DS_GC_NOT_AVAILABLE = unchecked((int)0xC00002B0);

        /// <summary>
        /// The requested operation requires a directory service, and none was available.
        /// </summary>
        public const int STATUS_DIRECTORY_SERVICE_REQUIRED = unchecked((int)0xC00002B1);

        /// <summary>
        /// The reparse attribute cannot be set as it is incompatible with an existing attribute.
        /// </summary>
        public const int STATUS_REPARSE_ATTRIBUTE_CONFLICT = unchecked((int)0xC00002B2);

        /// <summary>
        /// A group marked use for deny only cannot be enabled.
        /// </summary>
        public const int STATUS_CANT_ENABLE_DENY_ONLY = unchecked((int)0xC00002B3);

        /// <summary>
        /// {EXCEPTION}
        /// Multiple floating point faults.
        /// </summary>
        public const int STATUS_FLOAT_MULTIPLE_FAULTS = unchecked((int)0xC00002B4); // winnt

        /// <summary>
        /// {EXCEPTION}
        /// Multiple floating point traps.
        /// </summary>
        public const int STATUS_FLOAT_MULTIPLE_TRAPS = unchecked((int)0xC00002B5); // winnt

        /// <summary>
        /// The device has been removed.
        /// </summary>
        public const int STATUS_DEVICE_REMOVED = unchecked((int)0xC00002B6);

        /// <summary>
        /// The volume change journal is being deleted.
        /// </summary>
        public const int STATUS_JOURNAL_DELETE_IN_PROGRESS = unchecked((int)0xC00002B7);

        /// <summary>
        /// The volume change journal is not active.
        /// </summary>
        public const int STATUS_JOURNAL_NOT_ACTIVE = unchecked((int)0xC00002B8);

        /// <summary>
        /// The requested interface is not supported.
        /// </summary>
        public const int STATUS_NOINTERFACE = unchecked((int)0xC00002B9);

        /// <summary>
        /// The directory service detected the subsystem that allocates relative identifiers is disabled. This can occur as a protective mechanism when the system determines a significant portion of relative identifiers (RIDs) have been exhausted. Please see http://go.microsoft.com/fwlink/?LinkId=228610 for recommended diagnostic steps and the procedure to re-enable account creation.
        /// </summary>
        public const int STATUS_DS_RIDMGR_DISABLED = unchecked((int)0xC00002BA);

        /// <summary>
        /// A directory service resource limit has been exceeded.
        /// </summary>
        public const int STATUS_DS_ADMIN_LIMIT_EXCEEDED = unchecked((int)0xC00002C1);

        /// <summary>
        /// {System Standby Failed}
        /// The driver %hs does not support standby mode. Updating this driver may allow the system to go to standby mode.
        /// </summary>
        public const int STATUS_DRIVER_FAILED_SLEEP = unchecked((int)0xC00002C2);

        /// <summary>
        /// Mutual Authentication failed. The server's password is out of date at the domain controller.
        /// </summary>
        public const int STATUS_MUTUAL_AUTHENTICATION_FAILED = unchecked((int)0xC00002C3);

        /// <summary>
        /// The system file %1 has become corrupt and has been replaced.
        /// </summary>
        public const int STATUS_CORRUPT_SYSTEM_FILE = unchecked((int)0xC00002C4);

        /// <summary>
        /// {EXCEPTION}
        /// Alignment Error
        /// A datatype misalignment error was detected in a load or store instruction.
        /// </summary>
        public const int STATUS_DATATYPE_MISALIGNMENT_ERROR = unchecked((int)0xC00002C5);

        /// <summary>
        /// The WMI data item or data block is read only.
        /// </summary>
        public const int STATUS_WMI_READ_ONLY = unchecked((int)0xC00002C6);

        /// <summary>
        /// The WMI data item or data block could not be changed.
        /// </summary>
        public const int STATUS_WMI_SET_FAILURE = unchecked((int)0xC00002C7);

        /// <summary>
        /// {Virtual Memory Minimum Too Low}
        /// Your system is low on virtual memory. Windows is increasing the size of your virtual memory paging file. During this process, memory requests for some applications may be denied. For more information, see Help.
        /// </summary>
        public const int STATUS_COMMITMENT_MINIMUM = unchecked((int)0xC00002C8);

        /// <summary>
        /// {EXCEPTION}
        /// Register NaT consumption faults.
        /// A NaT value is consumed on a non speculative instruction.
        /// </summary>
        public const int STATUS_REG_NAT_CONSUMPTION = unchecked((int)0xC00002C9); // winnt

        /// <summary>
        /// The medium changer's transport element contains media, which is causing the operation to fail.
        /// </summary>
        public const int STATUS_TRANSPORT_FULL = unchecked((int)0xC00002CA);

        /// <summary>
        /// Security Accounts Manager initialization failed because of the following error:
        /// %hs
        /// Error Status: 0x%x.
        /// Please shutdown this system and reboot into Directory Services Restore Mode, check the event log for more detailed information.
        /// </summary>
        public const int STATUS_DS_SAM_INIT_FAILURE = unchecked((int)0xC00002CB);

        /// <summary>
        /// This operation is supported only when you are connected to the server.
        /// </summary>
        public const int STATUS_ONLY_IF_CONNECTED = unchecked((int)0xC00002CC);

        /// <summary>
        /// Only an administrator can modify the membership list of an administrative group.
        /// </summary>
        public const int STATUS_DS_SENSITIVE_GROUP_VIOLATION = unchecked((int)0xC00002CD);

        /// <summary>
        /// A device was removed so enumeration must be restarted.
        /// </summary>
        public const int STATUS_PNP_RESTART_ENUMERATION = unchecked((int)0xC00002CE);

        /// <summary>
        /// The journal entry has been deleted from the journal.
        /// </summary>
        public const int STATUS_JOURNAL_ENTRY_DELETED = unchecked((int)0xC00002CF);

        /// <summary>
        /// Cannot change the primary group ID of a domain controller account.
        /// </summary>
        public const int STATUS_DS_CANT_MOD_PRIMARYGROUPID = unchecked((int)0xC00002D0);

        /// <summary>
        /// {Fatal System Error}
        /// The system image %s is not properly signed. The file has been replaced with the signed file. The system has been shut down.
        /// </summary>
        public const int STATUS_SYSTEM_IMAGE_BAD_SIGNATURE = unchecked((int)0xC00002D1);

        /// <summary>
        /// Device will not start without a reboot.
        /// </summary>
        public const int STATUS_PNP_REBOOT_REQUIRED = unchecked((int)0xC00002D2);

        /// <summary>
        /// Current device power state cannot support this request.
        /// </summary>
        public const int STATUS_POWER_STATE_INVALID = unchecked((int)0xC00002D3);

        /// <summary>
        /// The specified group type is invalid.
        /// </summary>
        public const int STATUS_DS_INVALID_GROUP_TYPE = unchecked((int)0xC00002D4);

        /// <summary>
        /// In mixed domain no nesting of global group if group is security enabled.
        /// </summary>
        public const int STATUS_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN = unchecked((int)0xC00002D5);

        /// <summary>
        /// In mixed domain, cannot nest local groups with other local groups, if the group is security enabled.
        /// </summary>
        public const int STATUS_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN = unchecked((int)0xC00002D6);

        /// <summary>
        /// A global group cannot have a local group as a member.
        /// </summary>
        public const int STATUS_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER = unchecked((int)0xC00002D7);

        /// <summary>
        /// A global group cannot have a universal group as a member.
        /// </summary>
        public const int STATUS_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER = unchecked((int)0xC00002D8);

        /// <summary>
        /// A universal group cannot have a local group as a member.
        /// </summary>
        public const int STATUS_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER = unchecked((int)0xC00002D9);

        /// <summary>
        /// A global group cannot have a cross domain member.
        /// </summary>
        public const int STATUS_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER = unchecked((int)0xC00002DA);

        /// <summary>
        /// A local group cannot have another cross domain local group as a member.
        /// </summary>
        public const int STATUS_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER = unchecked((int)0xC00002DB);

        /// <summary>
        /// Cannot change to security disabled group because of having primary members in this group.
        /// </summary>
        public const int STATUS_DS_HAVE_PRIMARY_MEMBERS = unchecked((int)0xC00002DC);

        /// <summary>
        /// The WMI operation is not supported by the data block or method.
        /// </summary>
        public const int STATUS_WMI_NOT_SUPPORTED = unchecked((int)0xC00002DD);

        /// <summary>
        /// There is not enough power to complete the requested operation.
        /// </summary>
        public const int STATUS_INSUFFICIENT_POWER = unchecked((int)0xC00002DE);

        /// <summary>
        /// Security Account Manager needs to get the boot password.
        /// </summary>
        public const int STATUS_SAM_NEED_BOOTKEY_PASSWORD = unchecked((int)0xC00002DF);

        /// <summary>
        /// Security Account Manager needs to get the boot key from floppy disk.
        /// </summary>
        public const int STATUS_SAM_NEED_BOOTKEY_FLOPPY = unchecked((int)0xC00002E0);

        /// <summary>
        /// Directory Service cannot start.
        /// </summary>
        public const int STATUS_DS_CANT_START = unchecked((int)0xC00002E1);

        /// <summary>
        /// Directory Services could not start because of the following error:
        /// %hs
        /// Error Status: 0x%x.
        /// Please shutdown this system and reboot into Directory Services Restore Mode, check the event log for more detailed information.
        /// </summary>
        public const int STATUS_DS_INIT_FAILURE = unchecked((int)0xC00002E2);

        /// <summary>
        /// Security Accounts Manager initialization failed because of the following error:
        /// %hs
        /// Error Status: 0x%x.
        /// Please click OK to shutdown this system and reboot into Safe Mode, check the event log for more detailed information.
        /// </summary>
        public const int STATUS_SAM_INIT_FAILURE = unchecked((int)0xC00002E3);

        /// <summary>
        /// The requested operation can be performed only on a global catalog server.
        /// </summary>
        public const int STATUS_DS_GC_REQUIRED = unchecked((int)0xC00002E4);

        /// <summary>
        /// A local group can only be a member of other local groups in the same domain.
        /// </summary>
        public const int STATUS_DS_LOCAL_MEMBER_OF_LOCAL_ONLY = unchecked((int)0xC00002E5);

        /// <summary>
        /// Foreign security principals cannot be members of universal groups.
        /// </summary>
        public const int STATUS_DS_NO_FPO_IN_UNIVERSAL_GROUPS = unchecked((int)0xC00002E6);

        /// <summary>
        /// Your computer could not be joined to the domain. You have exceeded the maximum number of computer accounts you are allowed to create in this domain. Contact your system administrator to have this limit reset or increased.
        /// </summary>
        public const int STATUS_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED = unchecked((int)0xC00002E7);

        /// <summary>
        /// STATUS_MULTIPLE_FAULT_VIOLATION
        /// </summary>
        public const int STATUS_MULTIPLE_FAULT_VIOLATION = unchecked((int)0xC00002E8);

        /// <summary>
        /// This operation cannot be performed on the current domain.
        /// </summary>
        public const int STATUS_CURRENT_DOMAIN_NOT_ALLOWED = unchecked((int)0xC00002E9);

        /// <summary>
        /// The directory or file cannot be created.
        /// </summary>
        public const int STATUS_CANNOT_MAKE = unchecked((int)0xC00002EA);

        /// <summary>
        /// The system is in the process of shutting down.
        /// </summary>
        public const int STATUS_SYSTEM_SHUTDOWN = unchecked((int)0xC00002EB);

        /// <summary>
        /// Directory Services could not start because of the following error:
        /// %hs
        /// Error Status: 0x%x.
        /// Please click OK to shutdown the system. You can use the recovery console to diagnose the system further.
        /// </summary>
        public const int STATUS_DS_INIT_FAILURE_CONSOLE = unchecked((int)0xC00002EC);

        /// <summary>
        /// Security Accounts Manager initialization failed because of the following error:
        /// %hs
        /// Error Status: 0x%x.
        /// Please click OK to shutdown the system. You can use the recovery console to diagnose the system further.
        /// </summary>
        public const int STATUS_DS_SAM_INIT_FAILURE_CONSOLE = unchecked((int)0xC00002ED);

        /// <summary>
        /// A security context was deleted before the context was completed. This is considered a logon failure.
        /// </summary>
        public const int STATUS_UNFINISHED_CONTEXT_DELETED = unchecked((int)0xC00002EE);

        /// <summary>
        /// The client is trying to negotiate a context and the server requires user-to-user but didn't send a TGT reply.
        /// </summary>
        public const int STATUS_NO_TGT_REPLY = unchecked((int)0xC00002EF);

        /// <summary>
        /// An object ID was not found in the file.
        /// </summary>
        public const int STATUS_OBJECTID_NOT_FOUND = unchecked((int)0xC00002F0);

        /// <summary>
        /// Unable to accomplish the requested task because the local machine does not have any IP addresses.
        /// </summary>
        public const int STATUS_NO_IP_ADDRESSES = unchecked((int)0xC00002F1);

        /// <summary>
        /// The supplied credential handle does not match the credential associated with the security context.
        /// </summary>
        public const int STATUS_WRONG_CREDENTIAL_HANDLE = unchecked((int)0xC00002F2);

        /// <summary>
        /// The crypto system or checksum function is invalid because a required function is unavailable.
        /// </summary>
        public const int STATUS_CRYPTO_SYSTEM_INVALID = unchecked((int)0xC00002F3);

        /// <summary>
        /// The number of maximum ticket referrals has been exceeded.
        /// </summary>
        public const int STATUS_MAX_REFERRALS_EXCEEDED = unchecked((int)0xC00002F4);

        /// <summary>
        /// The local machine must be a Kerberos KDC (domain controller) and it is not.
        /// </summary>
        public const int STATUS_MUST_BE_KDC = unchecked((int)0xC00002F5);

        /// <summary>
        /// The other end of the security negotiation is requires strong crypto but it is not supported on the local machine.
        /// </summary>
        public const int STATUS_STRONG_CRYPTO_NOT_SUPPORTED = unchecked((int)0xC00002F6);

        /// <summary>
        /// The KDC reply contained more than one principal name.
        /// </summary>
        public const int STATUS_TOO_MANY_PRINCIPALS = unchecked((int)0xC00002F7);

        /// <summary>
        /// Expected to find PA data for a hint of what etype to use, but it was not found.
        /// </summary>
        public const int STATUS_NO_PA_DATA = unchecked((int)0xC00002F8);

        /// <summary>
        /// The client certificate does not contain a valid UPN, or does not match the client name in the logon request. Please contact your administrator.
        /// </summary>
        public const int STATUS_PKINIT_NAME_MISMATCH = unchecked((int)0xC00002F9);

        /// <summary>
        /// Smartcard logon is required and was not used.
        /// </summary>
        public const int STATUS_SMARTCARD_LOGON_REQUIRED = unchecked((int)0xC00002FA);

        /// <summary>
        /// An invalid request was sent to the KDC.
        /// </summary>
        public const int STATUS_KDC_INVALID_REQUEST = unchecked((int)0xC00002FB);

        /// <summary>
        /// The KDC was unable to generate a referral for the service requested.
        /// </summary>
        public const int STATUS_KDC_UNABLE_TO_REFER = unchecked((int)0xC00002FC);

        /// <summary>
        /// The encryption type requested is not supported by the KDC.
        /// </summary>
        public const int STATUS_KDC_UNKNOWN_ETYPE = unchecked((int)0xC00002FD);

        /// <summary>
        /// A system shutdown is in progress.
        /// </summary>
        public const int STATUS_SHUTDOWN_IN_PROGRESS = unchecked((int)0xC00002FE);

        /// <summary>
        /// The server machine is shutting down.
        /// </summary>
        public const int STATUS_SERVER_SHUTDOWN_IN_PROGRESS = unchecked((int)0xC00002FF);

        /// <summary>
        /// This operation is not supported on a computer running Windows Server 2003 for Small Business Server
        /// </summary>
        public const int STATUS_NOT_SUPPORTED_ON_SBS = unchecked((int)0xC0000300);

        /// <summary>
        /// The WMI GUID is no longer available
        /// </summary>
        public const int STATUS_WMI_GUID_DISCONNECTED = unchecked((int)0xC0000301);

        /// <summary>
        /// Collection or events for the WMI GUID is already disabled.
        /// </summary>
        public const int STATUS_WMI_ALREADY_DISABLED = unchecked((int)0xC0000302);

        /// <summary>
        /// Collection or events for the WMI GUID is already enabled.
        /// </summary>
        public const int STATUS_WMI_ALREADY_ENABLED = unchecked((int)0xC0000303);

        /// <summary>
        /// The Master File Table on the volume is too fragmented to complete this operation.
        /// </summary>
        public const int STATUS_MFT_TOO_FRAGMENTED = unchecked((int)0xC0000304);

        /// <summary>
        /// Copy protection failure.
        /// </summary>
        public const int STATUS_COPY_PROTECTION_FAILURE = unchecked((int)0xC0000305);

        /// <summary>
        /// Copy protection error - DVD CSS Authentication failed.
        /// </summary>
        public const int STATUS_CSS_AUTHENTICATION_FAILURE = unchecked((int)0xC0000306);

        /// <summary>
        /// Copy protection error - The given sector does not contain a valid key.
        /// </summary>
        public const int STATUS_CSS_KEY_NOT_PRESENT = unchecked((int)0xC0000307);

        /// <summary>
        /// Copy protection error - DVD session key not established.
        /// </summary>
        public const int STATUS_CSS_KEY_NOT_ESTABLISHED = unchecked((int)0xC0000308);

        /// <summary>
        /// Copy protection error - The read failed because the sector is encrypted.
        /// </summary>
        public const int STATUS_CSS_SCRAMBLED_SECTOR = unchecked((int)0xC0000309);

        /// <summary>
        /// Copy protection error - The given DVD's region does not correspond to the
        /// region setting of the drive.
        /// </summary>
        public const int STATUS_CSS_REGION_MISMATCH = unchecked((int)0xC000030A);

        /// <summary>
        /// Copy protection error - The drive's region setting may be permanent.
        /// </summary>
        public const int STATUS_CSS_RESETS_EXHAUSTED = unchecked((int)0xC000030B);

        /// <summary>
        /// EAS policy requires that the user change their password before this operation can be performed.
        /// </summary>
        public const int STATUS_PASSWORD_CHANGE_REQUIRED = unchecked((int)0xC000030C);

        /// <summary>
        /// An administrator has restricted sign in. To sign in, make sure your device is connected to the Internet, and have your administrator sign in first.
        /// </summary>
        public const int STATUS_LOST_MODE_LOGON_RESTRICTION = unchecked((int)0xC000030D);

        /*++

         MessageId's 0x030e - 0x031f (inclusive) are reserved for future **STORAGE**
         copy protection errors.

        --*/
        /// <summary>
        /// The Kerberos protocol encountered an error while validating the KDC certificate during logon. There is more information in the system event log.
        /// </summary>
        public const int STATUS_PKINIT_FAILURE = unchecked((int)0xC0000320);

        /// <summary>
        /// The Kerberos protocol encountered an error while attempting to utilize the smartcard subsystem.
        /// </summary>
        public const int STATUS_SMARTCARD_SUBSYSTEM_FAILURE = unchecked((int)0xC0000321);

        /// <summary>
        /// The target server does not have acceptable Kerberos credentials.
        /// </summary>
        public const int STATUS_NO_KERB_KEY = unchecked((int)0xC0000322);

        /*++

         MessageId's 0x0323 - 0x034f (inclusive) are reserved for other future copy
         protection errors.

        --*/
        /// <summary>
        /// The transport determined that the remote system is down.
        /// </summary>
        public const int STATUS_HOST_DOWN = unchecked((int)0xC0000350);

        /// <summary>
        /// An unsupported preauthentication mechanism was presented to the Kerberos package.
        /// </summary>
        public const int STATUS_UNSUPPORTED_PREAUTH = unchecked((int)0xC0000351);

        /// <summary>
        /// The encryption algorithm used on the source file needs a bigger key buffer than the one used on the destination file.
        /// </summary>
        public const int STATUS_EFS_ALG_BLOB_TOO_BIG = unchecked((int)0xC0000352);

        /// <summary>
        /// An attempt to remove a process's DebugPort was made, but a port was not already associated with the process.
        /// </summary>
        public const int STATUS_PORT_NOT_SET = unchecked((int)0xC0000353);

        /// <summary>
        /// Debugger Inactive: Windows may have been started without kernel debugging enabled.
        /// </summary>
        public const int STATUS_DEBUGGER_INACTIVE = unchecked((int)0xC0000354);

        /// <summary>
        /// This version of Windows is not compatible with the behavior version of directory forest, domain or domain controller.
        /// </summary>
        public const int STATUS_DS_VERSION_CHECK_FAILURE = unchecked((int)0xC0000355);

        /// <summary>
        /// The specified event is currently not being audited.
        /// </summary>
        public const int STATUS_AUDITING_DISABLED = unchecked((int)0xC0000356);

        /// <summary>
        /// The machine account was created pre-NT4. The account needs to be recreated.
        /// </summary>
        public const int STATUS_PRENT4_MACHINE_ACCOUNT = unchecked((int)0xC0000357);

        /// <summary>
        /// A account group cannot have a universal group as a member.
        /// </summary>
        public const int STATUS_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER = unchecked((int)0xC0000358);

        /// <summary>
        /// The specified image file did not have the correct format, it appears to be a 32-bit Windows image.
        /// </summary>
        public const int STATUS_INVALID_IMAGE_WIN_32 = unchecked((int)0xC0000359);

        /// <summary>
        /// The specified image file did not have the correct format, it appears to be a 64-bit Windows image.
        /// </summary>
        public const int STATUS_INVALID_IMAGE_WIN_64 = unchecked((int)0xC000035A);

        /// <summary>
        /// Client's supplied SSPI channel bindings were incorrect.
        /// </summary>
        public const int STATUS_BAD_BINDINGS = unchecked((int)0xC000035B);

        /// <summary>
        /// The client's session has expired, so the client must reauthenticate to continue accessing the remote resources.
        /// </summary>
        public const int STATUS_NETWORK_SESSION_EXPIRED = unchecked((int)0xC000035C);

        /// <summary>
        /// AppHelp dialog canceled thus preventing the application from starting.
        /// </summary>
        public const int STATUS_APPHELP_BLOCK = unchecked((int)0xC000035D);

        /// <summary>
        /// The SID filtering operation removed all SIDs.
        /// </summary>
        public const int STATUS_ALL_SIDS_FILTERED = unchecked((int)0xC000035E);

        /// <summary>
        /// The driver was not loaded because the system is booting into safe mode.
        /// </summary>
        public const int STATUS_NOT_SAFE_MODE_DRIVER = unchecked((int)0xC000035F);

        /// <summary>
        /// Access to %1 has been restricted by your Administrator by the default software restriction policy level.
        /// </summary>
        public const int STATUS_ACCESS_DISABLED_BY_POLICY_DEFAULT = unchecked((int)0xC0000361);

        /// <summary>
        /// Access to %1 has been restricted by your Administrator by location with policy rule %2 placed on path %3
        /// </summary>
        public const int STATUS_ACCESS_DISABLED_BY_POLICY_PATH = unchecked((int)0xC0000362);

        /// <summary>
        /// Access to %1 has been restricted by your Administrator by software publisher policy.
        /// </summary>
        public const int STATUS_ACCESS_DISABLED_BY_POLICY_PUBLISHER = unchecked((int)0xC0000363);

        /// <summary>
        /// Access to %1 has been restricted by your Administrator by policy rule %2.
        /// </summary>
        public const int STATUS_ACCESS_DISABLED_BY_POLICY_OTHER = unchecked((int)0xC0000364);

        /// <summary>
        /// The driver was not loaded because it failed its initialization call.
        /// </summary>
        public const int STATUS_FAILED_DRIVER_ENTRY = unchecked((int)0xC0000365);

        /// <summary>
        /// The "%hs" encountered an error while applying power or reading the device configuration. This may be caused by a failure of your hardware or by a poor connection.
        /// </summary>
        public const int STATUS_DEVICE_ENUMERATION_ERROR = unchecked((int)0xC0000366);

        /// <summary>
        /// The create operation failed because the name contained at least one mount point which resolves to a volume to which the specified device object is not attached.
        /// </summary>
        public const int STATUS_MOUNT_POINT_NOT_RESOLVED = unchecked((int)0xC0000368);

        /// <summary>
        /// The device object parameter is either not a valid device object or is not attached to the volume specified by the file name.
        /// </summary>
        public const int STATUS_INVALID_DEVICE_OBJECT_PARAMETER = unchecked((int)0xC0000369);

        /// <summary>
        /// A Machine Check Error has occurred. Please check the system eventlog for additional information.
        /// </summary>
        public const int STATUS_MCA_OCCURED = unchecked((int)0xC000036A);

        /// <summary>
        /// Driver %2 has been blocked from loading.
        /// </summary>
        public const int STATUS_DRIVER_BLOCKED_CRITICAL = unchecked((int)0xC000036B);

        /// <summary>
        /// Driver %2 has been blocked from loading.
        /// </summary>
        public const int STATUS_DRIVER_BLOCKED = unchecked((int)0xC000036C);

        /// <summary>
        /// There was error [%2] processing the driver database.
        /// </summary>
        public const int STATUS_DRIVER_DATABASE_ERROR = unchecked((int)0xC000036D);

        /// <summary>
        /// System hive size has exceeded its limit.
        /// </summary>
        public const int STATUS_SYSTEM_HIVE_TOO_LARGE = unchecked((int)0xC000036E);

        /// <summary>
        /// A dynamic link library (DLL) referenced a module that was neither a DLL nor the process's executable image.
        /// </summary>
        public const int STATUS_INVALID_IMPORT_OF_NON_DLL = unchecked((int)0xC000036F);

        /// <summary>
        /// The Directory Service is shutting down.
        /// </summary>
        public const int STATUS_DS_SHUTTING_DOWN = 0x40000370;

        /// <summary>
        /// The local account store does not contain secret material for the specified account.
        /// </summary>
        public const int STATUS_NO_SECRETS = unchecked((int)0xC0000371);

        /// <summary>
        /// Access to %1 has been restricted by your Administrator by policy rule %2.
        /// </summary>
        public const int STATUS_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY = unchecked((int)0xC0000372);

        /// <summary>
        /// The system was not able to allocate enough memory to perform a stack switch.
        /// </summary>
        public const int STATUS_FAILED_STACK_SWITCH = unchecked((int)0xC0000373);

        /// <summary>
        /// A heap has been corrupted.
        /// </summary>
        public const int STATUS_HEAP_CORRUPTION = unchecked((int)0xC0000374); // winnt

        /// <summary>
        /// An incorrect PIN was presented to the smart card
        /// </summary>
        public const int STATUS_SMARTCARD_WRONG_PIN = unchecked((int)0xC0000380);

        /// <summary>
        /// The smart card is blocked
        /// </summary>
        public const int STATUS_SMARTCARD_CARD_BLOCKED = unchecked((int)0xC0000381);

        /// <summary>
        /// No PIN was presented to the smart card
        /// </summary>
        public const int STATUS_SMARTCARD_CARD_NOT_AUTHENTICATED = unchecked((int)0xC0000382);

        /// <summary>
        /// No smart card available
        /// </summary>
        public const int STATUS_SMARTCARD_NO_CARD = unchecked((int)0xC0000383);

        /// <summary>
        /// The requested key container does not exist on the smart card
        /// </summary>
        public const int STATUS_SMARTCARD_NO_KEY_CONTAINER = unchecked((int)0xC0000384);

        /// <summary>
        /// The requested certificate does not exist on the smart card
        /// </summary>
        public const int STATUS_SMARTCARD_NO_CERTIFICATE = unchecked((int)0xC0000385);

        /// <summary>
        /// The requested keyset does not exist
        /// </summary>
        public const int STATUS_SMARTCARD_NO_KEYSET = unchecked((int)0xC0000386);

        /// <summary>
        /// A communication error with the smart card has been detected.
        /// </summary>
        public const int STATUS_SMARTCARD_IO_ERROR = unchecked((int)0xC0000387);

        /// <summary>
        /// The system cannot contact a domain controller to service the authentication request. Please try again later.
        /// </summary>
        public const int STATUS_DOWNGRADE_DETECTED = unchecked((int)0xC0000388);

        /// <summary>
        /// The smartcard certificate used for authentication has been revoked. Please contact your system administrator. There may be additional information in the event log.
        /// </summary>
        public const int STATUS_SMARTCARD_CERT_REVOKED = unchecked((int)0xC0000389);

        /// <summary>
        /// An untrusted certificate authority was detected while processing the certificate used for authentication.
        /// </summary>
        public const int STATUS_ISSUING_CA_UNTRUSTED = unchecked((int)0xC000038A);

        /// <summary>
        /// The revocation status of the certificate used for authentication could not be determined.
        /// </summary>
        public const int STATUS_REVOCATION_OFFLINE_C = unchecked((int)0xC000038B);

        /// <summary>
        /// The client certificate used for authentication was not trusted.
        /// </summary>
        public const int STATUS_PKINIT_CLIENT_FAILURE = unchecked((int)0xC000038C);

        /// <summary>
        /// The smartcard certificate used for authentication has expired. Please
        /// contact your system administrator.
        /// </summary>
        public const int STATUS_SMARTCARD_CERT_EXPIRED = unchecked((int)0xC000038D);

        /// <summary>
        /// The driver could not be loaded because a previous version of the driver is still in memory.
        /// </summary>
        public const int STATUS_DRIVER_FAILED_PRIOR_UNLOAD = unchecked((int)0xC000038E);

        /// <summary>
        /// The smartcard provider could not perform the action since the context was acquired as silent.
        /// </summary>
        public const int STATUS_SMARTCARD_SILENT_CONTEXT = unchecked((int)0xC000038F);

        /* MessageId up to 0x400 is reserved for smart cards */
        /// <summary>
        /// The current user's delegated trust creation quota has been exceeded.
        /// </summary>
        public const int STATUS_PER_USER_TRUST_QUOTA_EXCEEDED = unchecked((int)0xC0000401);

        /// <summary>
        /// The total delegated trust creation quota has been exceeded.
        /// </summary>
        public const int STATUS_ALL_USER_TRUST_QUOTA_EXCEEDED = unchecked((int)0xC0000402);

        /// <summary>
        /// The current user's delegated trust deletion quota has been exceeded.
        /// </summary>
        public const int STATUS_USER_DELETE_TRUST_QUOTA_EXCEEDED = unchecked((int)0xC0000403);

        /// <summary>
        /// The requested name already exists as a unique identifier.
        /// </summary>
        public const int STATUS_DS_NAME_NOT_UNIQUE = unchecked((int)0xC0000404);

        /// <summary>
        /// The requested object has a non-unique identifier and cannot be retrieved.
        /// </summary>
        public const int STATUS_DS_DUPLICATE_ID_FOUND = unchecked((int)0xC0000405);

        /// <summary>
        /// The group cannot be converted due to attribute restrictions on the requested group type.
        /// </summary>
        public const int STATUS_DS_GROUP_CONVERSION_ERROR = unchecked((int)0xC0000406);

        /// <summary>
        /// {Volume Shadow Copy Service}
        /// Please wait while the Volume Shadow Copy Service prepares volume %hs for hibernation.
        /// </summary>
        public const int STATUS_VOLSNAP_PREPARE_HIBERNATE = unchecked((int)0xC0000407);

        /// <summary>
        /// Kerberos sub-protocol User2User is required.
        /// </summary>
        public const int STATUS_USER2USER_REQUIRED = unchecked((int)0xC0000408);

        /// <summary>
        /// The system detected an overrun of a stack-based buffer in this application. This overrun could potentially allow a malicious user to gain control of this application.
        /// </summary>
        public const int STATUS_STACK_BUFFER_OVERRUN = unchecked((int)0xC0000409); // winnt

        /// <summary>
        /// The Kerberos subsystem encountered an error. A service for user protocol request was made against a domain controller which does not support service for user.
        /// </summary>
        public const int STATUS_NO_S4U_PROT_SUPPORT = unchecked((int)0xC000040A);

        /// <summary>
        /// An attempt was made by this server to make a Kerberos constrained delegation request for a target outside of the server's realm. This is not supported, and indicates a misconfiguration on this server's allowed to delegate to list. Please contact your administrator.
        /// </summary>
        public const int STATUS_CROSSREALM_DELEGATION_FAILURE = unchecked((int)0xC000040B);

        /// <summary>
        /// The revocation status of the domain controller certificate used for authentication could not be determined. There is additional information in the system event log.
        /// </summary>
        public const int STATUS_REVOCATION_OFFLINE_KDC = unchecked((int)0xC000040C);

        /// <summary>
        /// An untrusted certificate authority was detected while processing the domain controller certificate used for authentication. There is additional information in the system event log. Please contact your system administrator.
        /// </summary>
        public const int STATUS_ISSUING_CA_UNTRUSTED_KDC = unchecked((int)0xC000040D);

        /// <summary>
        /// The domain controller certificate used for logon has expired. There is additional information in the system event log.
        /// </summary>
        public const int STATUS_KDC_CERT_EXPIRED = unchecked((int)0xC000040E);

        /// <summary>
        /// The domain controller certificate used for logon has been revoked. There is additional information in the system event log.
        /// </summary>
        public const int STATUS_KDC_CERT_REVOKED = unchecked((int)0xC000040F);

        /// <summary>
        /// Data present in one of the parameters is more than the function can operate on.
        /// </summary>
        public const int STATUS_PARAMETER_QUOTA_EXCEEDED = unchecked((int)0xC0000410);

        /// <summary>
        /// The system has failed to hibernate (The error code is %hs). Hibernation will be disabled until the system is restarted.
        /// </summary>
        public const int STATUS_HIBERNATION_FAILURE = unchecked((int)0xC0000411);

        /// <summary>
        /// An attempt to delay-load a .dll or get a function address in a delay-loaded .dll failed.
        /// </summary>
        public const int STATUS_DELAY_LOAD_FAILED = unchecked((int)0xC0000412);

        /// <summary>
        /// Logon Failure: The machine you are logging onto is protected by an authentication firewall. The specified account is not allowed to authenticate to the machine.
        /// </summary>
        public const int STATUS_AUTHENTICATION_FIREWALL_FAILED = unchecked((int)0xC0000413);

        /// <summary>
        /// %hs is a 16-bit application. You do not have permissions to execute 16-bit applications. Check your permissions with your system administrator.
        /// </summary>
        public const int STATUS_VDM_DISALLOWED = unchecked((int)0xC0000414);

        /// <summary>
        /// {Display Driver Stopped Responding}
        /// The %hs display driver has stopped working normally. Save your work and reboot the system to restore full display functionality. The next time you reboot the machine a dialog will be displayed giving you a chance to report this failure to Microsoft.
        /// </summary>
        public const int STATUS_HUNG_DISPLAY_DRIVER_THREAD = unchecked((int)0xC0000415);

        /// <summary>
        /// The Desktop heap encountered an error while allocating session memory. There is more information in the system event log.
        /// </summary>
        public const int STATUS_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE = unchecked((int)0xC0000416);

        /// <summary>
        /// An invalid parameter was passed to a C runtime function.
        /// </summary>
        public const int STATUS_INVALID_CRUNTIME_PARAMETER = unchecked((int)0xC0000417); // winnt

        /// <summary>
        /// The authentication failed since NTLM was blocked.
        /// </summary>
        public const int STATUS_NTLM_BLOCKED = unchecked((int)0xC0000418);

        /// <summary>
        /// The source object's SID already exists in destination forest.
        /// </summary>
        public const int STATUS_DS_SRC_SID_EXISTS_IN_FOREST = unchecked((int)0xC0000419);

        /// <summary>
        /// The domain name of the trusted domain already exists in the forest.
        /// </summary>
        public const int STATUS_DS_DOMAIN_NAME_EXISTS_IN_FOREST = unchecked((int)0xC000041A);

        /// <summary>
        /// The flat name of the trusted domain already exists in the forest.
        /// </summary>
        public const int STATUS_DS_FLAT_NAME_EXISTS_IN_FOREST = unchecked((int)0xC000041B);

        /// <summary>
        /// The User Principal Name (UPN) is invalid.
        /// </summary>
        public const int STATUS_INVALID_USER_PRINCIPAL_NAME = unchecked((int)0xC000041C);

        /// <summary>
        /// An unhandled exception was encountered during a user callback.
        /// </summary>
        public const int STATUS_FATAL_USER_CALLBACK_EXCEPTION = unchecked((int)0xC000041D);

        /// <summary>
        /// An assertion failure has occurred.
        /// </summary>
        public const int STATUS_ASSERTION_FAILURE = unchecked((int)0xC0000420); // winnt

        /// <summary>
        /// Application verifier has found an error in the current process.
        /// </summary>
        public const int STATUS_VERIFIER_STOP = unchecked((int)0xC0000421);

        /// <summary>
        /// An exception has occurred in a user mode callback and the kernel callback frame should be removed.
        /// </summary>
        public const int STATUS_CALLBACK_POP_STACK = unchecked((int)0xC0000423);

        /// <summary>
        /// %2 has been blocked from loading due to incompatibility with this system. Please contact your software vendor for a compatible version of the driver.
        /// </summary>
        public const int STATUS_INCOMPATIBLE_DRIVER_BLOCKED = unchecked((int)0xC0000424);

        /// <summary>
        /// Illegal operation attempted on a registry key which has already been unloaded.
        /// </summary>
        public const int STATUS_HIVE_UNLOADED = unchecked((int)0xC0000425);

        /// <summary>
        /// Compression is disabled for this volume.
        /// </summary>
        public const int STATUS_COMPRESSION_DISABLED = unchecked((int)0xC0000426);

        /// <summary>
        /// The requested operation could not be completed due to a file system limitation
        /// </summary>
        public const int STATUS_FILE_SYSTEM_LIMITATION = unchecked((int)0xC0000427);

        /// <summary>
        /// Windows cannot verify the digital signature for this file. A recent hardware or software change might have installed a file that is signed incorrectly or damaged, or that might be malicious software from an unknown source.
        /// </summary>
        public const int STATUS_INVALID_IMAGE_HASH = unchecked((int)0xC0000428);

        /// <summary>
        /// The implementation is not capable of performing the request.
        /// </summary>
        public const int STATUS_NOT_CAPABLE = unchecked((int)0xC0000429);

        /// <summary>
        /// The requested operation is out of order with respect to other operations.
        /// </summary>
        public const int STATUS_REQUEST_OUT_OF_SEQUENCE = unchecked((int)0xC000042A);

        /// <summary>
        /// An operation attempted to exceed an implementation-defined limit.
        /// </summary>
        public const int STATUS_IMPLEMENTATION_LIMIT = unchecked((int)0xC000042B);

        /// <summary>
        /// The requested operation requires elevation.
        /// </summary>
        public const int STATUS_ELEVATION_REQUIRED = unchecked((int)0xC000042C);

        /// <summary>
        /// The required security context does not exist.
        /// </summary>
        public const int STATUS_NO_SECURITY_CONTEXT = unchecked((int)0xC000042D);

        //
        // MessageId 0x042E is reserved and used in isolation lib as
        //
        // MessageId=0x042E Facility=System Severity=ERROR SymbolicName=STATUS_VERSION_PARSE_ERROR
        // Language=English
        // A version number could not be parsed.
        // .
        /// <summary>
        /// The PKU2U protocol encountered an error while attempting to utilize the associated certificates.
        /// </summary>
        public const int STATUS_PKU2U_CERT_FAILURE = unchecked((int)0xC000042F);

        /// <summary>
        /// The operation was attempted beyond the valid data length of the file.
        /// </summary>
        public const int STATUS_BEYOND_VDL = unchecked((int)0xC0000432);

        /// <summary>
        /// The attempted write operation encountered a write already in progress for some portion of the range.
        /// </summary>
        public const int STATUS_ENCOUNTERED_WRITE_IN_PROGRESS = unchecked((int)0xC0000433);

        /// <summary>
        /// The page fault mappings changed in the middle of processing a fault so the operation must be retried.
        /// </summary>
        public const int STATUS_PTE_CHANGED = unchecked((int)0xC0000434);

        /// <summary>
        /// The attempt to purge this file from memory failed to purge some or all the data from memory.
        /// </summary>
        public const int STATUS_PURGE_FAILED = unchecked((int)0xC0000435);

        /// <summary>
        /// The requested credential requires confirmation.
        /// </summary>
        public const int STATUS_CRED_REQUIRES_CONFIRMATION = unchecked((int)0xC0000440);

        /// <summary>
        /// The remote server sent an invalid response for a file being opened with Client Side Encryption.
        /// </summary>
        public const int STATUS_CS_ENCRYPTION_INVALID_SERVER_RESPONSE = unchecked((int)0xC0000441);

        /// <summary>
        /// Client Side Encryption is not supported by the remote server even though it claims to support it.
        /// </summary>
        public const int STATUS_CS_ENCRYPTION_UNSUPPORTED_SERVER = unchecked((int)0xC0000442);

        /// <summary>
        /// File is encrypted and should be opened in Client Side Encryption mode.
        /// </summary>
        public const int STATUS_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE = unchecked((int)0xC0000443);

        /// <summary>
        /// A new encrypted file is being created and a $EFS needs to be provided.
        /// </summary>
        public const int STATUS_CS_ENCRYPTION_NEW_ENCRYPTED_FILE = unchecked((int)0xC0000444);

        /// <summary>
        /// The SMB client requested a CSE FSCTL on a non-CSE file.
        /// </summary>
        public const int STATUS_CS_ENCRYPTION_FILE_NOT_CSE = unchecked((int)0xC0000445);

        /// <summary>
        /// Indicates a particular Security ID may not be assigned as the label of an object.
        /// </summary>
        public const int STATUS_INVALID_LABEL = unchecked((int)0xC0000446);

        /// <summary>
        /// The process hosting the driver for this device has terminated.
        /// </summary>
        public const int STATUS_DRIVER_PROCESS_TERMINATED = unchecked((int)0xC0000450);

        /// <summary>
        /// The requested system device cannot be identified due to multiple indistinguishable devices potentially matching the identification criteria.
        /// </summary>
        public const int STATUS_AMBIGUOUS_SYSTEM_DEVICE = unchecked((int)0xC0000451);

        /// <summary>
        /// The requested system device cannot be found.
        /// </summary>
        public const int STATUS_SYSTEM_DEVICE_NOT_FOUND = unchecked((int)0xC0000452);

        /// <summary>
        /// This boot application must be restarted.
        /// </summary>
        public const int STATUS_RESTART_BOOT_APPLICATION = unchecked((int)0xC0000453);

        /// <summary>
        /// Insufficient NVRAM resources exist to complete the API.  A reboot might be required.
        /// </summary>
        public const int STATUS_INSUFFICIENT_NVRAM_RESOURCES = unchecked((int)0xC0000454);

        /// <summary>
        /// The specified session is invalid.
        /// </summary>
        public const int STATUS_INVALID_SESSION = unchecked((int)0xC0000455);

        /// <summary>
        /// The specified thread is already in a session.
        /// </summary>
        public const int STATUS_THREAD_ALREADY_IN_SESSION = unchecked((int)0xC0000456);

        /// <summary>
        /// The specified thread is not in a session.
        /// </summary>
        public const int STATUS_THREAD_NOT_IN_SESSION = unchecked((int)0xC0000457);

        /// <summary>
        /// The specified weight is invalid.
        /// </summary>
        public const int STATUS_INVALID_WEIGHT = unchecked((int)0xC0000458);

        /// <summary>
        /// The operation was paused.
        /// </summary>
        public const int STATUS_REQUEST_PAUSED = unchecked((int)0xC0000459);

        /// <summary>
        /// No ranges for the specified operation were able to be processed.
        /// </summary>
        public const int STATUS_NO_RANGES_PROCESSED = unchecked((int)0xC0000460);

        /// <summary>
        /// The physical resources of this disk have been exhausted.
        /// </summary>
        public const int STATUS_DISK_RESOURCES_EXHAUSTED = unchecked((int)0xC0000461);

        /// <summary>
        /// The application cannot be started. Try reinstalling the application to fix the problem.
        /// </summary>
        public const int STATUS_NEEDS_REMEDIATION = unchecked((int)0xC0000462);

        /// <summary>
        /// {Device Feature Not Supported}
        /// The device does not support the command feature.
        /// </summary>
        public const int STATUS_DEVICE_FEATURE_NOT_SUPPORTED = unchecked((int)0xC0000463);

        /// <summary>
        /// {Source/Destination device unreachable}
        /// The device is unreachable.
        /// </summary>
        public const int STATUS_DEVICE_UNREACHABLE = unchecked((int)0xC0000464);

        /// <summary>
        /// {Invalid Proxy Data Token}
        /// The token representing the data is invalid.
        /// </summary>
        public const int STATUS_INVALID_TOKEN = unchecked((int)0xC0000465);

        /// <summary>
        /// The file server is temporarily unavailable.
        /// </summary>
        public const int STATUS_SERVER_UNAVAILABLE = unchecked((int)0xC0000466);

        /// <summary>
        /// The file is temporarily unavailable.
        /// </summary>
        public const int STATUS_FILE_NOT_AVAILABLE = unchecked((int)0xC0000467);

        /// <summary>
        /// {Device Insufficient Resources}
        /// The target device has insufficient resources to complete the operation.
        /// </summary>
        public const int STATUS_DEVICE_INSUFFICIENT_RESOURCES = unchecked((int)0xC0000468);

        /// <summary>
        /// The application cannot be started because it is currently updating.
        /// </summary>
        public const int STATUS_PACKAGE_UPDATING = unchecked((int)0xC0000469);

        /// <summary>
        /// The specified copy of the requested data could not be read.
        /// </summary>
        public const int STATUS_NOT_READ_FROM_COPY = unchecked((int)0xC000046A);

        /// <summary>
        /// The specified data could not be written to any of the copies.
        /// </summary>
        public const int STATUS_FT_WRITE_FAILURE = unchecked((int)0xC000046B);

        /// <summary>
        /// One or more copies of data on this device may be out of sync. No writes may be performed until a data integrity scan is completed.
        /// </summary>
        public const int STATUS_FT_DI_SCAN_REQUIRED = unchecked((int)0xC000046C);

        /// <summary>
        /// This object is not externally backed by any provider.
        /// </summary>
        public const int STATUS_OBJECT_NOT_EXTERNALLY_BACKED = unchecked((int)0xC000046D);

        /// <summary>
        /// The external backing provider is not recognized.
        /// </summary>
        public const int STATUS_EXTERNAL_BACKING_PROVIDER_UNKNOWN = unchecked((int)0xC000046E);

        /// <summary>
        /// Compressing this object would not save space.
        /// </summary>
        public const int STATUS_COMPRESSION_NOT_BENEFICIAL = unchecked((int)0xC000046F);

        /// <summary>
        /// A data integrity checksum error occurred. Data in the file stream is corrupt.
        /// </summary>
        public const int STATUS_DATA_CHECKSUM_ERROR = unchecked((int)0xC0000470);

        /// <summary>
        /// An attempt was made to modify both a KERNEL and normal Extended Attribute (EA) in the same operation.
        /// </summary>
        public const int STATUS_INTERMIXED_KERNEL_EA_OPERATION = unchecked((int)0xC0000471);

        /// <summary>
        /// {LogicalBlockProvisioningReadZero Not Supported}
        /// The target device does not support read returning zeros from trimmed/unmapped blocks.
        /// </summary>
        public const int STATUS_TRIM_READ_ZERO_NOT_SUPPORTED = unchecked((int)0xC0000472);

        /// <summary>
        /// {Maximum Segment Descriptors Exceeded}
        /// The command specified a number of descriptors that exceeded the maximum supported by the device.
        /// </summary>
        public const int STATUS_TOO_MANY_SEGMENT_DESCRIPTORS = unchecked((int)0xC0000473);

        /// <summary>
        /// {Alignment Violation}
        /// The command specified a data offset that does not align to the device's granularity/alignment.
        /// </summary>
        public const int STATUS_INVALID_OFFSET_ALIGNMENT = unchecked((int)0xC0000474);

        /// <summary>
        /// {Invalid Field In Parameter List}
        /// The command specified an invalid field in its parameter list.
        /// </summary>
        public const int STATUS_INVALID_FIELD_IN_PARAMETER_LIST = unchecked((int)0xC0000475);

        /// <summary>
        /// {Operation In Progress}
        /// An operation is currently in progress with the device.
        /// </summary>
        public const int STATUS_OPERATION_IN_PROGRESS = unchecked((int)0xC0000476);

        /// <summary>
        /// {Invalid I_T Nexus}
        /// An attempt was made to send down the command via an invalid path to the target device.
        /// </summary>
        public const int STATUS_INVALID_INITIATOR_TARGET_PATH = unchecked((int)0xC0000477);

        /// <summary>
        /// Scrub is disabled on the specified file.
        /// </summary>
        public const int STATUS_SCRUB_DATA_DISABLED = unchecked((int)0xC0000478);

        /// <summary>
        /// The storage device does not provide redundancy.
        /// </summary>
        public const int STATUS_NOT_REDUNDANT_STORAGE = unchecked((int)0xC0000479);

        /// <summary>
        /// An operation is not supported on a resident file.
        /// </summary>
        public const int STATUS_RESIDENT_FILE_NOT_SUPPORTED = unchecked((int)0xC000047A);

        /// <summary>
        /// An operation is not supported on a compressed file.
        /// </summary>
        public const int STATUS_COMPRESSED_FILE_NOT_SUPPORTED = unchecked((int)0xC000047B);

        /// <summary>
        /// An operation is not supported on a directory.
        /// </summary>
        public const int STATUS_DIRECTORY_NOT_SUPPORTED = unchecked((int)0xC000047C);

        /// <summary>
        /// {IO Operation Timeout}
        /// The specified I/O operation failed to complete within the expected time period.
        /// </summary>
        public const int STATUS_IO_OPERATION_TIMEOUT = unchecked((int)0xC000047D);

        /// <summary>
        /// An error in a system binary was detected. Try refreshing the PC to fix the problem.
        /// </summary>
        public const int STATUS_SYSTEM_NEEDS_REMEDIATION = unchecked((int)0xC000047E);

        /// <summary>
        /// A corrupted CLR NGEN binary was detected on the system.
        /// </summary>
        public const int STATUS_APPX_INTEGRITY_FAILURE_CLR_NGEN = unchecked((int)0xC000047F);

        /// <summary>
        /// The share is temporarily unavailable.
        /// </summary>
        public const int STATUS_SHARE_UNAVAILABLE = unchecked((int)0xC0000480);

        /// <summary>
        /// The target dll was not found because the apiset %hs is not hosted.
        /// </summary>
        public const int STATUS_APISET_NOT_HOSTED = unchecked((int)0xC0000481);

        /// <summary>
        /// The API set extension contains a host for a non-existent API set.
        /// </summary>
        public const int STATUS_APISET_NOT_PRESENT = unchecked((int)0xC0000482);

        /// <summary>
        /// The request failed due to a fatal device hardware error.
        /// </summary>
        public const int STATUS_DEVICE_HARDWARE_ERROR = unchecked((int)0xC0000483);

        /// <summary>
        /// The specified firmware slot is invalid.
        /// </summary>
        public const int STATUS_FIRMWARE_SLOT_INVALID = unchecked((int)0xC0000484);

        /// <summary>
        /// The specified firmware image is invalid.
        /// </summary>
        public const int STATUS_FIRMWARE_IMAGE_INVALID = unchecked((int)0xC0000485);

        /// <summary>
        /// The request failed due to a storage topology ID mismatch.
        /// </summary>
        public const int STATUS_STORAGE_TOPOLOGY_ID_MISMATCH = unchecked((int)0xC0000486);

        /// <summary>
        /// The specified Windows Image (WIM) is not marked as bootable.
        /// </summary>
        public const int STATUS_WIM_NOT_BOOTABLE = unchecked((int)0xC0000487);

        /// <summary>
        /// The operation was blocked by parental controls.
        /// </summary>
        public const int STATUS_BLOCKED_BY_PARENTAL_CONTROLS = unchecked((int)0xC0000488);

        /// <summary>
        /// The deployment operation failed because the specified application needs to be registered first.
        /// </summary>
        public const int STATUS_NEEDS_REGISTRATION = unchecked((int)0xC0000489);

        /// <summary>
        /// The requested operation failed due to quota operation is still in progress.
        /// </summary>
        public const int STATUS_QUOTA_ACTIVITY = unchecked((int)0xC000048A);

        /// <summary>
        /// The callback function must be invoked inline.
        /// </summary>
        public const int STATUS_CALLBACK_INVOKE_INLINE = unchecked((int)0xC000048B);

        /// <summary>
        /// A file system block being referenced has already reached the maximum reference count and can't be referenced any further.
        /// </summary>
        public const int STATUS_BLOCK_TOO_MANY_REFERENCES = unchecked((int)0xC000048C);

        /// <summary>
        /// The requested operation failed because the file stream is marked to disallow writes.
        /// </summary>
        public const int STATUS_MARKED_TO_DISALLOW_WRITES = unchecked((int)0xC000048D);

        /// <summary>
        /// Windows Information Protection policy does not allow access to this network resource.
        /// </summary>
        public const int STATUS_NETWORK_ACCESS_DENIED_EDP = unchecked((int)0xC000048E);

        /// <summary>
        /// The requested operation failed with an architecture-specific failure code.
        /// </summary>
        public const int STATUS_ENCLAVE_FAILURE = unchecked((int)0xC000048F);

        /// <summary>
        /// There are no compatible drivers available for this device.
        /// </summary>
        public const int STATUS_PNP_NO_COMPAT_DRIVERS = unchecked((int)0xC0000490);

        /// <summary>
        /// The specified driver package cannot be found on the system.
        /// </summary>
        public const int STATUS_PNP_DRIVER_PACKAGE_NOT_FOUND = unchecked((int)0xC0000491);

        /// <summary>
        /// The driver package cannot find a required driver configuration.
        /// </summary>
        public const int STATUS_PNP_DRIVER_CONFIGURATION_NOT_FOUND = unchecked((int)0xC0000492);

        /// <summary>
        /// The driver configuration is incomplete for use with this device.
        /// </summary>
        public const int STATUS_PNP_DRIVER_CONFIGURATION_INCOMPLETE = unchecked((int)0xC0000493);

        /// <summary>
        /// The device requires a driver configuration with a function driver.
        /// </summary>
        public const int STATUS_PNP_FUNCTION_DRIVER_REQUIRED = unchecked((int)0xC0000494);

        /// <summary>
        /// The device is pending further configuration.
        /// </summary>
        public const int STATUS_PNP_DEVICE_CONFIGURATION_PENDING = unchecked((int)0xC0000495);

        /// <summary>
        /// The device hint name buffer is too small to receive the remaining name.
        /// </summary>
        public const int STATUS_DEVICE_HINT_NAME_BUFFER_TOO_SMALL = unchecked((int)0xC0000496);

        /// <summary>
        /// The package is currently not available.
        /// </summary>
        public const int STATUS_PACKAGE_NOT_AVAILABLE = unchecked((int)0xC0000497);

        /// <summary>
        /// The device is in maintenance mode.
        /// </summary>
        public const int STATUS_DEVICE_IN_MAINTENANCE = unchecked((int)0xC0000499);

        /// <summary>
        /// This operation is not supported on a DAX volume.
        /// </summary>
        public const int STATUS_NOT_SUPPORTED_ON_DAX = unchecked((int)0xC000049A);

        /// <summary>
        /// The free space on the volume is too fragmented to complete this operation.
        /// </summary>
        public const int STATUS_FREE_SPACE_TOO_FRAGMENTED = unchecked((int)0xC000049B);

        /// <summary>
        /// The volume has active DAX mappings.
        /// </summary>
        public const int STATUS_DAX_MAPPING_EXISTS = unchecked((int)0xC000049C);

        /// <summary>
        /// The process creation has been blocked.
        /// </summary>
        public const int STATUS_CHILD_PROCESS_BLOCKED = unchecked((int)0xC000049D);

        /// <summary>
        /// The storage device has lost data or persistence.
        /// </summary>
        public const int STATUS_STORAGE_LOST_DATA_PERSISTENCE = unchecked((int)0xC000049E);

        /// <summary>
        /// Driver Verifier Volatile settings cannot be set when CFG is enabled.
        /// </summary>
        public const int STATUS_VRF_CFG_ENABLED = unchecked((int)0xC000049F);

        /// <summary>
        /// An attempt was made to access a partition that has begun termination.
        /// </summary>
        public const int STATUS_PARTITION_TERMINATING = unchecked((int)0xC00004A0);

        /// <summary>
        /// An externally encrypted syskey has been configured, but the system no longer supports this feature.  Please see https://go.microsoft.com/fwlink/?linkid=851152 for more information.
        /// </summary>
        public const int STATUS_EXTERNAL_SYSKEY_NOT_SUPPORTED = unchecked((int)0xC00004A1);

        /// <summary>
        /// An attempt was made to access protected memory in violation of its secure access policy.
        /// </summary>
        public const int STATUS_ENCLAVE_VIOLATION = unchecked((int)0xC00004A2); // winnt

        /// <summary>
        /// File is not accessible because it's currently protected under DPL.
        /// </summary>
        public const int STATUS_FILE_PROTECTED_UNDER_DPL = unchecked((int)0xC00004A3);

        /// <summary>
        /// The volume is not cluster aligned on the disk.
        /// </summary>
        public const int STATUS_VOLUME_NOT_CLUSTER_ALIGNED = unchecked((int)0xC00004A4);

        /// <summary>
        /// No physically aligned free space was found on the volume.
        /// </summary>
        public const int STATUS_NO_PHYSICALLY_ALIGNED_FREE_SPACE_FOUND = unchecked((int)0xC00004A5);

        /// <summary>
        /// The APPX file can not be accessed because it is not encrypted as expected.
        /// </summary>
        public const int STATUS_APPX_FILE_NOT_ENCRYPTED = unchecked((int)0xC00004A6);

        /// <summary>
        /// A read or write of raw encrypted data cannot be performed because the file is not encrypted.
        /// </summary>
        public const int STATUS_RWRAW_ENCRYPTED_FILE_NOT_ENCRYPTED = unchecked((int)0xC00004A7);

        /// <summary>
        /// An invalid file offset in the encrypted data info block was passed for read or write operation of file's raw encrypted data.
        /// </summary>
        public const int STATUS_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILEOFFSET = unchecked((int)0xC00004A8);

        /// <summary>
        /// An invalid offset and length combination in the encrypted data info was passed for read or write operation of file's raw encrypted data.
        /// </summary>
        public const int STATUS_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILERANGE = unchecked((int)0xC00004A9);

        /// <summary>
        /// An invalid parameter in the encrypted data info was passed for read or write operation of file's raw encrypted data.
        /// </summary>
        public const int STATUS_RWRAW_ENCRYPTED_INVALID_EDATAINFO_PARAMETER = unchecked((int)0xC00004AA);


        //     **** New SYSTEM error codes can be inserted here ****

        /// <summary>
        /// The specified task name is invalid.
        /// </summary>
        public const int STATUS_INVALID_TASK_NAME = unchecked((int)0xC0000500);

        /// <summary>
        /// The specified task index is invalid.
        /// </summary>
        public const int STATUS_INVALID_TASK_INDEX = unchecked((int)0xC0000501);

        /// <summary>
        /// The specified thread is already joining a task.
        /// </summary>
        public const int STATUS_THREAD_ALREADY_IN_TASK = unchecked((int)0xC0000502);

        /// <summary>
        /// A callback has requested to bypass native code.
        /// </summary>
        public const int STATUS_CALLBACK_BYPASS = unchecked((int)0xC0000503);

        /// <summary>
        /// The Central Access Policy specified is not defined on the target machine.
        /// </summary>
        public const int STATUS_UNDEFINED_SCOPE = unchecked((int)0xC0000504);

        /// <summary>
        /// The Central Access Policy obtained from Active Directory is invalid.
        /// </summary>
        public const int STATUS_INVALID_CAP = unchecked((int)0xC0000505);

        /// <summary>
        /// Unable to finish the requested operation because the specified process is not a GUI process.
        /// </summary>
        public const int STATUS_NOT_GUI_PROCESS = unchecked((int)0xC0000506);

        /// <summary>
        /// The device is not responding and cannot be safely removed.
        /// </summary>
        public const int STATUS_DEVICE_HUNG = unchecked((int)0xC0000507);

        /// <summary>
        /// The specified Job already has a container assigned to it.
        /// </summary>
        public const int STATUS_CONTAINER_ASSIGNED = unchecked((int)0xC0000508);

        /// <summary>
        /// The specified Job does not have a container assigned to it.
        /// </summary>
        public const int STATUS_JOB_NO_CONTAINER = unchecked((int)0xC0000509);

        /// <summary>
        /// The device is unresponsive.
        /// </summary>
        public const int STATUS_DEVICE_UNRESPONSIVE = unchecked((int)0xC000050A);

        /// <summary>
        /// The object manager encountered a reparse point while retrieving an object.
        /// </summary>
        public const int STATUS_REPARSE_POINT_ENCOUNTERED = unchecked((int)0xC000050B);

        /// <summary>
        /// The requested attribute is not present on the specified file or directory.
        /// </summary>
        public const int STATUS_ATTRIBUTE_NOT_PRESENT = unchecked((int)0xC000050C);

        /// <summary>
        /// This volume is not a tiered volume.
        /// </summary>
        public const int STATUS_NOT_A_TIERED_VOLUME = unchecked((int)0xC000050D);

        /// <summary>
        /// This file is currently associated with a different stream id.
        /// </summary>
        public const int STATUS_ALREADY_HAS_STREAM_ID = unchecked((int)0xC000050E);

        /// <summary>
        /// The requested operation could not be completed because the specified job has children.
        /// </summary>
        public const int STATUS_JOB_NOT_EMPTY = unchecked((int)0xC000050F);

        /// <summary>
        /// The specified object has already been initialized.
        /// </summary>
        public const int STATUS_ALREADY_INITIALIZED = unchecked((int)0xC0000510);

        /// <summary>
        /// The specified enclave has not yet been terminated.
        /// </summary>
        public const int STATUS_ENCLAVE_NOT_TERMINATED = unchecked((int)0xC0000511);

        /// <summary>
        /// An attempt was made to access an enclave that has begun termination.
        /// </summary>
        public const int STATUS_ENCLAVE_IS_TERMINATING = unchecked((int)0xC0000512);

        /// <summary>
        /// You can't connect to the file share because it's not secure. This share requires the obsolete SMB1 protocol, which is unsafe and could expose your system to attack.
        /// Your system requires SMB2 or higher. For more info on resolving this issue, see: https://go.microsoft.com/fwlink/?linkid=852747
        /// </summary>
        public const int STATUS_SMB1_NOT_AVAILABLE = unchecked((int)0xC0000513);

        /// <summary>
        /// The volume must undergo garbage collection.
        /// </summary>
        public const int STATUS_SMR_GARBAGE_COLLECTION_REQUIRED = unchecked((int)0xC0000514);


        //     **** New SYSTEM error codes can be inserted here ****

        /// <summary>
        /// {Fail Fast Exception}
        /// A fail fast exception occurred. Exception handlers will not be invoked and the process will be terminated immediately.
        /// </summary>
        public const int STATUS_FAIL_FAST_EXCEPTION = unchecked((int)0xC0000602);

        /// <summary>
        /// Windows cannot verify the digital signature for this file. The signing certificate for this file has been revoked.
        /// </summary>
        public const int STATUS_IMAGE_CERT_REVOKED = unchecked((int)0xC0000603);

        /// <summary>
        /// The operation was blocked as the process prohibits dynamic code generation.
        /// </summary>
        public const int STATUS_DYNAMIC_CODE_BLOCKED = unchecked((int)0xC0000604);

        /// <summary>
        /// Windows cannot verify the digital signature for this file. The signing certificate for this file has expired.
        /// </summary>
        public const int STATUS_IMAGE_CERT_EXPIRED = unchecked((int)0xC0000605);

        /// <summary>
        /// The specified image file was blocked from loading because it does not enable a feature required by the process: Control Flow Guard.
        /// </summary>
        public const int STATUS_STRICT_CFG_VIOLATION = unchecked((int)0xC0000606);

        /// <summary>
        /// The thread context could not be updated because this has been restricted for the process.
        /// </summary>
        public const int STATUS_SET_CONTEXT_DENIED = unchecked((int)0xC000060A);

        /// <summary>
        /// An attempt to access another partition's private file/section was rejected.
        /// </summary>
        public const int STATUS_CROSS_PARTITION_VIOLATION = unchecked((int)0xC000060B);

        /// <summary>
        /// The ALPC port is closed.
        /// </summary>
        public const int STATUS_PORT_CLOSED = unchecked((int)0xC0000700);

        /// <summary>
        /// The ALPC message requested is no longer available.
        /// </summary>
        public const int STATUS_MESSAGE_LOST = unchecked((int)0xC0000701);

        /// <summary>
        /// The ALPC message supplied is invalid.
        /// </summary>
        public const int STATUS_INVALID_MESSAGE = unchecked((int)0xC0000702);

        /// <summary>
        /// The ALPC message has been canceled.
        /// </summary>
        public const int STATUS_REQUEST_CANCELED = unchecked((int)0xC0000703);

        /// <summary>
        /// Invalid recursive dispatch attempt.
        /// </summary>
        public const int STATUS_RECURSIVE_DISPATCH = unchecked((int)0xC0000704);

        /// <summary>
        /// No receive buffer has been supplied in a synchrounus request.
        /// </summary>
        public const int STATUS_LPC_RECEIVE_BUFFER_EXPECTED = unchecked((int)0xC0000705);

        /// <summary>
        /// The connection port is used in an invalid context.
        /// </summary>
        public const int STATUS_LPC_INVALID_CONNECTION_USAGE = unchecked((int)0xC0000706);

        /// <summary>
        /// The ALPC port does not accept new request messages.
        /// </summary>
        public const int STATUS_LPC_REQUESTS_NOT_ALLOWED = unchecked((int)0xC0000707);

        /// <summary>
        /// The resource requested is already in use.
        /// </summary>
        public const int STATUS_RESOURCE_IN_USE = unchecked((int)0xC0000708);

        /// <summary>
        /// The hardware has reported an uncorrectable memory error.
        /// </summary>
        public const int STATUS_HARDWARE_MEMORY_ERROR = unchecked((int)0xC0000709);

        /// <summary>
        /// Status 0x%08x was returned, waiting on handle 0x%x for wait 0x%p, in waiter 0x%p.
        /// </summary>
        public const int STATUS_THREADPOOL_HANDLE_EXCEPTION = unchecked((int)0xC000070A);

        /// <summary>
        /// After a callback to 0x%p(0x%p), a completion call to SetEvent(0x%p) failed with status 0x%08x.
        /// </summary>
        public const int STATUS_THREADPOOL_SET_EVENT_ON_COMPLETION_FAILED = unchecked((int)0xC000070B);

        /// <summary>
        /// After a callback to 0x%p(0x%p), a completion call to ReleaseSemaphore(0x%p, %d) failed with status 0x%08x.
        /// </summary>
        public const int STATUS_THREADPOOL_RELEASE_SEMAPHORE_ON_COMPLETION_FAILED = unchecked((int)0xC000070C);

        /// <summary>
        /// After a callback to 0x%p(0x%p), a completion call to ReleaseMutex(%p) failed with status 0x%08x.
        /// </summary>
        public const int STATUS_THREADPOOL_RELEASE_MUTEX_ON_COMPLETION_FAILED = unchecked((int)0xC000070D);

        /// <summary>
        /// After a callback to 0x%p(0x%p), an completion call to FreeLibrary(%p) failed with status 0x%08x.
        /// </summary>
        public const int STATUS_THREADPOOL_FREE_LIBRARY_ON_COMPLETION_FAILED = unchecked((int)0xC000070E);

        /// <summary>
        /// The threadpool 0x%p was released while a thread was posting a callback to 0x%p(0x%p) to it.
        /// </summary>
        public const int STATUS_THREADPOOL_RELEASED_DURING_OPERATION = unchecked((int)0xC000070F);

        /// <summary>
        /// A threadpool worker thread is impersonating a client, after a callback to 0x%p(0x%p).
        /// This is unexpected, indicating that the callback is missing a call to revert the impersonation.
        /// </summary>
        public const int STATUS_CALLBACK_RETURNED_WHILE_IMPERSONATING = unchecked((int)0xC0000710);

        /// <summary>
        /// A threadpool worker thread is impersonating a client, after executing an APC.
        /// This is unexpected, indicating that the APC is missing a call to revert the impersonation.
        /// </summary>
        public const int STATUS_APC_RETURNED_WHILE_IMPERSONATING = unchecked((int)0xC0000711);

        /// <summary>
        /// Either the target process, or the target thread's containing process, is a protected process.
        /// </summary>
        public const int STATUS_PROCESS_IS_PROTECTED = unchecked((int)0xC0000712);

        /// <summary>
        /// A Thread is getting dispatched with MCA EXCEPTION because of MCA.
        /// </summary>
        public const int STATUS_MCA_EXCEPTION = unchecked((int)0xC0000713);

        /// <summary>
        /// The client certificate account mapping is not unique.
        /// </summary>
        public const int STATUS_CERTIFICATE_MAPPING_NOT_UNIQUE = unchecked((int)0xC0000714);

        /// <summary>
        /// The symbolic link cannot be followed because its type is disabled.
        /// </summary>
        public const int STATUS_SYMLINK_CLASS_DISABLED = unchecked((int)0xC0000715);

        /// <summary>
        /// Indicates that the specified string is not valid for IDN normalization.
        /// </summary>
        public const int STATUS_INVALID_IDN_NORMALIZATION = unchecked((int)0xC0000716);

        /// <summary>
        /// No mapping for the Unicode character exists in the target multi-byte code page.
        /// </summary>
        public const int STATUS_NO_UNICODE_TRANSLATION = unchecked((int)0xC0000717);

        /// <summary>
        /// The provided callback is already registered.
        /// </summary>
        public const int STATUS_ALREADY_REGISTERED = unchecked((int)0xC0000718);

        /// <summary>
        /// The provided context did not match the target.
        /// </summary>
        public const int STATUS_CONTEXT_MISMATCH = unchecked((int)0xC0000719);

        /// <summary>
        /// The specified port already has a completion list.
        /// </summary>
        public const int STATUS_PORT_ALREADY_HAS_COMPLETION_LIST = unchecked((int)0xC000071A);

        /// <summary>
        /// A threadpool worker thread enter a callback at thread base priority 0x%x and exited at priority 0x%x.
        /// This is unexpected, indicating that the callback missed restoring the priority.
        /// </summary>
        public const int STATUS_CALLBACK_RETURNED_THREAD_PRIORITY = unchecked((int)0xC000071B);

        /// <summary>
        /// An invalid thread, handle %p, is specified for this operation. Possibly, a threadpool worker thread was specified.
        /// </summary>
        public const int STATUS_INVALID_THREAD = unchecked((int)0xC000071C);

        /// <summary>
        /// A threadpool worker thread enter a callback, which left transaction state.
        /// This is unexpected, indicating that the callback missed clearing the transaction.
        /// </summary>
        public const int STATUS_CALLBACK_RETURNED_TRANSACTION = unchecked((int)0xC000071D);

        /// <summary>
        /// A threadpool worker thread enter a callback, which left the loader lock held.
        /// This is unexpected, indicating that the callback missed releasing the lock.
        /// </summary>
        public const int STATUS_CALLBACK_RETURNED_LDR_LOCK = unchecked((int)0xC000071E);

        /// <summary>
        /// A threadpool worker thread enter a callback, which left with preferred languages set.
        /// This is unexpected, indicating that the callback missed clearing them.
        /// </summary>
        public const int STATUS_CALLBACK_RETURNED_LANG = unchecked((int)0xC000071F);

        /// <summary>
        /// A threadpool worker thread enter a callback, which left with background priorities set.
        /// This is unexpected, indicating that the callback missed restoring the original priorities.
        /// </summary>
        public const int STATUS_CALLBACK_RETURNED_PRI_BACK = unchecked((int)0xC0000720);

        /// <summary>
        /// A threadpool worker thread enter a callback at thread affinity %p and exited at affinity %p.
        /// This is unexpected, indicating that the callback missed restoring the priority.
        /// </summary>
        public const int STATUS_CALLBACK_RETURNED_THREAD_AFFINITY = unchecked((int)0xC0000721);

        /// <summary>
        /// The caller has exceeded the maximum number of handles that may be transmitted in
        /// a single local procedure call.
        /// </summary>
        public const int STATUS_LPC_HANDLE_COUNT_EXCEEDED = unchecked((int)0xC0000722);

        /// <summary>
        /// A write to executable memory occurred for a process that is managing such operations.
        /// </summary>
        public const int STATUS_EXECUTABLE_MEMORY_WRITE = unchecked((int)0xC0000723);

        /// <summary>
        /// A write to executable memory occurred from kernel mode for a process that is managing such operations.
        /// </summary>
        public const int STATUS_KERNEL_EXECUTABLE_MEMORY_WRITE = unchecked((int)0xC0000724);

        /// <summary>
        /// A write to executable memory occurred from kernel mode while attached to a process that is managing such operations.
        /// </summary>
        public const int STATUS_ATTACHED_EXECUTABLE_MEMORY_WRITE = unchecked((int)0xC0000725);

        /// <summary>
        /// A write to executable memory was triggered cross-process to a process that is managing such operations.
        /// </summary>
        public const int STATUS_TRIGGERED_EXECUTABLE_MEMORY_WRITE = unchecked((int)0xC0000726);

        /// <summary>
        /// The attempted operation required self healing to be enabled.
        /// </summary>
        public const int STATUS_DISK_REPAIR_DISABLED = unchecked((int)0xC0000800);

        /// <summary>
        /// The Directory Service cannot perform the requested operation because a domain rename operation is in progress.
        /// </summary>
        public const int STATUS_DS_DOMAIN_RENAME_IN_PROGRESS = unchecked((int)0xC0000801);

        /// <summary>
        /// The requested file operation failed because the storage quota was exceeded.
        /// To free up disk space, move files to a different location or delete unnecessary files. For more information, contact your system administrator.
        /// </summary>
        public const int STATUS_DISK_QUOTA_EXCEEDED = unchecked((int)0xC0000802);

        /// <summary>
        /// Windows discovered a corruption in the file "%hs".
        /// This file has now been repaired.
        /// Please check if any data in the file was lost because of the corruption.
        /// </summary>
        public const int STATUS_DATA_LOST_REPAIR = unchecked((int)0x80000803);

        /// <summary>
        /// The requested file operation failed because the storage policy blocks that type of file. For more information, contact your system administrator.
        /// </summary>
        public const int STATUS_CONTENT_BLOCKED = unchecked((int)0xC0000804);

        /// <summary>
        /// The operation could not be completed due to bad clusters on disk.
        /// </summary>
        public const int STATUS_BAD_CLUSTERS = unchecked((int)0xC0000805);

        /// <summary>
        /// The operation could not be completed because the volume is dirty. Please run chkdsk and try again.
        /// </summary>
        public const int STATUS_VOLUME_DIRTY = unchecked((int)0xC0000806);

        /// <summary>
        /// The volume repair could not be performed while it is online.
        /// Please schedule to take the volume offline so that it can be repaired.
        /// </summary>
        public const int STATUS_DISK_REPAIR_REDIRECTED = 0x40000807;

        /// <summary>
        /// The volume repair was not successful.
        /// </summary>
        public const int STATUS_DISK_REPAIR_UNSUCCESSFUL = unchecked((int)0xC0000808);

        /// <summary>
        /// One of the volume corruption logs is full. Further corruptions that may be detected won't be logged.
        /// </summary>
        public const int STATUS_CORRUPT_LOG_OVERFULL = unchecked((int)0xC0000809);

        /// <summary>
        /// One of the volume corruption logs is internally corrupted and needs to be recreated. The volume may contain undetected corruptions and must be scanned.
        /// </summary>
        public const int STATUS_CORRUPT_LOG_CORRUPTED = unchecked((int)0xC000080A);

        /// <summary>
        /// One of the volume corruption logs is unavailable for being operated on.
        /// </summary>
        public const int STATUS_CORRUPT_LOG_UNAVAILABLE = unchecked((int)0xC000080B);

        /// <summary>
        /// One of the volume corruption logs was deleted while still having corruption records in them. The volume contains detected corruptions and must be scanned.
        /// </summary>
        public const int STATUS_CORRUPT_LOG_DELETED_FULL = unchecked((int)0xC000080C);

        /// <summary>
        /// One of the volume corruption logs was cleared by chkdsk and no longer contains real corruptions.
        /// </summary>
        public const int STATUS_CORRUPT_LOG_CLEARED = unchecked((int)0xC000080D);

        /// <summary>
        /// Orphaned files exist on the volume but could not be recovered because no more new names could be created in the recovery directory. Files must be moved from the recovery directory.
        /// </summary>
        public const int STATUS_ORPHAN_NAME_EXHAUSTED = unchecked((int)0xC000080E);

        /// <summary>
        /// The operation could not be completed because an instance of Proactive Scanner is currently running.
        /// </summary>
        public const int STATUS_PROACTIVE_SCAN_IN_PROGRESS = unchecked((int)0xC000080F);

        /// <summary>
        /// The read or write operation to an encrypted file could not be completed because the file has not been opened for data access.
        /// </summary>
        public const int STATUS_ENCRYPTED_IO_NOT_POSSIBLE = unchecked((int)0xC0000810);

        /// <summary>
        /// One of the volume corruption logs comes from a newer version of Windows and contains corruption records. The log will be emptied and reset to the current version, and the volume health state will be updated accordingly.
        /// </summary>
        public const int STATUS_CORRUPT_LOG_UPLEVEL_RECORDS = unchecked((int)0xC0000811);

        /// <summary>
        /// This file is checked out or locked for editing by another user.
        /// </summary>
        public const int STATUS_FILE_CHECKED_OUT = unchecked((int)0xC0000901);

        /// <summary>
        /// The file must be checked out before saving changes.
        /// </summary>
        public const int STATUS_CHECKOUT_REQUIRED = unchecked((int)0xC0000902);

        /// <summary>
        /// The file type being saved or retrieved has been blocked.
        /// </summary>
        public const int STATUS_BAD_FILE_TYPE = unchecked((int)0xC0000903);

        /// <summary>
        /// The file size exceeds the limit allowed and cannot be saved.
        /// </summary>
        public const int STATUS_FILE_TOO_LARGE = unchecked((int)0xC0000904);

        /// <summary>
        /// Access Denied. Before opening files in this location, you must first browse to the web site and select the option to login automatically.
        /// </summary>
        public const int STATUS_FORMS_AUTH_REQUIRED = unchecked((int)0xC0000905);

        /// <summary>
        /// Operation did not complete successfully because the file contains a virus or potentially unwanted software.
        /// </summary>
        public const int STATUS_VIRUS_INFECTED = unchecked((int)0xC0000906);

        /// <summary>
        /// This file contains a virus or potentially unwanted software and cannot be opened. Due to the nature of this virus or potentially unwanted software, the file has been removed from this location.
        /// </summary>
        public const int STATUS_VIRUS_DELETED = unchecked((int)0xC0000907);

        /// <summary>
        /// The resources required for this device conflict with the MCFG table.
        /// </summary>
        public const int STATUS_BAD_MCFG_TABLE = unchecked((int)0xC0000908);

        /// <summary>
        /// The operation did not complete successfully because it would cause an oplock to be broken. The caller has requested that existing oplocks not be broken.
        /// </summary>
        public const int STATUS_CANNOT_BREAK_OPLOCK = unchecked((int)0xC0000909);

        /// <summary>
        /// Bad key.
        /// </summary>
        public const int STATUS_BAD_KEY = unchecked((int)0xC000090A);

        /// <summary>
        /// Bad data.
        /// </summary>
        public const int STATUS_BAD_DATA = unchecked((int)0xC000090B);

        /// <summary>
        /// Key does not exist.
        /// </summary>
        public const int STATUS_NO_KEY = unchecked((int)0xC000090C);

        /// <summary>
        /// Access to the specified file handle has been revoked.
        /// </summary>
        public const int STATUS_FILE_HANDLE_REVOKED = unchecked((int)0xC0000910);

        /// <summary>
        /// WOW Assertion Error.
        /// </summary>
        public const int STATUS_WOW_ASSERTION = unchecked((int)0xC0009898);

        /// <summary>
        /// The cryptographic signature is invalid.
        /// </summary>
        public const int STATUS_INVALID_SIGNATURE = unchecked((int)0xC000A000);

        /// <summary>
        /// The cryptographic provider does not support HMAC.
        /// </summary>
        public const int STATUS_HMAC_NOT_SUPPORTED = unchecked((int)0xC000A001);

        /// <summary>
        /// The computed authentication tag did not match the input authentication tag.
        /// </summary>
        public const int STATUS_AUTH_TAG_MISMATCH = unchecked((int)0xC000A002);

        /// <summary>
        /// The requested state transition is invalid and cannot be performed.
        /// </summary>
        public const int STATUS_INVALID_STATE_TRANSITION = unchecked((int)0xC000A003);

        /// <summary>
        /// The supplied kernel information version is invalid.
        /// </summary>
        public const int STATUS_INVALID_KERNEL_INFO_VERSION = unchecked((int)0xC000A004);

        /// <summary>
        /// The supplied PEP information version is invalid.
        /// </summary>
        public const int STATUS_INVALID_PEP_INFO_VERSION = unchecked((int)0xC000A005);

        /// <summary>
        /// Access to the specified handle has been revoked.
        /// </summary>
        public const int STATUS_HANDLE_REVOKED = unchecked((int)0xC000A006);

        /// <summary>
        /// The file operation will result in the end of file being on a ghosted range.
        /// </summary>
        public const int STATUS_EOF_ON_GHOSTED_RANGE = unchecked((int)0xC000A007);

        /*++

         MessageId's 0xa010 - 0xa07f (inclusive) are reserved for TCPIP errors.

        --*/
        /// <summary>
        /// The IPSEC queue overflowed.
        /// </summary>
        public const int STATUS_IPSEC_QUEUE_OVERFLOW = unchecked((int)0xC000A010);

        /// <summary>
        /// The neighbor discovery queue overflowed.
        /// </summary>
        public const int STATUS_ND_QUEUE_OVERFLOW = unchecked((int)0xC000A011);

        /// <summary>
        /// An ICMP hop limit exceeded error was received.
        /// </summary>
        public const int STATUS_HOPLIMIT_EXCEEDED = unchecked((int)0xC000A012);

        /// <summary>
        /// The protocol is not installed on the local machine.
        /// </summary>
        public const int STATUS_PROTOCOL_NOT_SUPPORTED = unchecked((int)0xC000A013);

        /// <summary>
        /// An operation or data has been rejected while on the network fast path.
        /// </summary>
        public const int STATUS_FASTPATH_REJECTED = unchecked((int)0xC000A014);

        /*++

         MessageId's 0xa014 - 0xa07f (inclusive) are reserved for TCPIP errors.

        --*/
        /// <summary>
        /// {Delayed Write Failed}
        /// Windows was unable to save all the data for the file %hs; the data has been lost.
        /// This error may be caused by network connectivity issues. Please try to save this file elsewhere.
        /// </summary>
        public const int STATUS_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED = unchecked((int)0xC000A080);

        /// <summary>
        /// {Delayed Write Failed}
        /// Windows was unable to save all the data for the file %hs; the data has been lost.
        /// This error was returned by the server on which the file exists. Please try to save this file elsewhere.
        /// </summary>
        public const int STATUS_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR = unchecked((int)0xC000A081);

        /// <summary>
        /// {Delayed Write Failed}
        /// Windows was unable to save all the data for the file %hs; the data has been lost.
        /// This error may be caused if the device has been removed or the media is write-protected.
        /// </summary>
        public const int STATUS_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR = unchecked((int)0xC000A082);

        /// <summary>
        /// Windows was unable to parse the requested XML data.
        /// </summary>
        public const int STATUS_XML_PARSE_ERROR = unchecked((int)0xC000A083);

        /// <summary>
        /// An error was encountered while processing an XML digital signature.
        /// </summary>
        public const int STATUS_XMLDSIG_ERROR = unchecked((int)0xC000A084);

        /// <summary>
        /// Indicates that the caller made the connection request in the wrong routing compartment.
        /// </summary>
        public const int STATUS_WRONG_COMPARTMENT = unchecked((int)0xC000A085);

        /// <summary>
        /// Indicates that there was an AuthIP failure when attempting to connect to the remote host.
        /// </summary>
        public const int STATUS_AUTHIP_FAILURE = unchecked((int)0xC000A086);

        /// <summary>
        /// OID mapped groups cannot have members.
        /// </summary>
        public const int STATUS_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS = unchecked((int)0xC000A087);

        /// <summary>
        /// The specified OID cannot be found.
        /// </summary>
        public const int STATUS_DS_OID_NOT_FOUND = unchecked((int)0xC000A088);

        /// <summary>
        /// The system is not authoritative for the specified account and therefore cannot complete the operation. Please retry the operation using the provider associated with this account. If this is an online provider please use the provider's online site.
        /// </summary>
        public const int STATUS_INCORRECT_ACCOUNT_TYPE = unchecked((int)0xC000A089);

        /*++

         MessageId's 0xa100 - 0xa120 (inclusive) are for the SMB Hash Generation Service.

        --*/
        /// <summary>
        /// Hash generation for the specified version and hash type is not enabled on server.
        /// </summary>
        public const int STATUS_HASH_NOT_SUPPORTED = unchecked((int)0xC000A100);

        /// <summary>
        /// The hash requests is not present or not up to date with the current file contents.
        /// </summary>
        public const int STATUS_HASH_NOT_PRESENT = unchecked((int)0xC000A101);

        /*++

         MessageId's 0xa121 - 0xa140 (inclusive) are for GPIO (General Purpose I/O) controller related errors.

        --*/
        /// <summary>
        /// The secondary interrupt controller instance that manages the specified interrupt is not registered.
        /// </summary>
        public const int STATUS_SECONDARY_IC_PROVIDER_NOT_REGISTERED = unchecked((int)0xC000A121);

        /// <summary>
        /// The information supplied by the GPIO client driver is invalid.
        /// </summary>
        public const int STATUS_GPIO_CLIENT_INFORMATION_INVALID = unchecked((int)0xC000A122);

        /// <summary>
        /// The version specified by the GPIO client driver is not supported.
        /// </summary>
        public const int STATUS_GPIO_VERSION_NOT_SUPPORTED = unchecked((int)0xC000A123);

        /// <summary>
        /// The registration packet supplied by the GPIO client driver is not valid.
        /// </summary>
        public const int STATUS_GPIO_INVALID_REGISTRATION_PACKET = unchecked((int)0xC000A124);

        /// <summary>
        /// The requested operation is not suppported for the specified handle.
        /// </summary>
        public const int STATUS_GPIO_OPERATION_DENIED = unchecked((int)0xC000A125);

        /// <summary>
        /// The requested connect mode conflicts with an existing mode on one or more of the specified pins.
        /// </summary>
        public const int STATUS_GPIO_INCOMPATIBLE_CONNECT_MODE = unchecked((int)0xC000A126);

        /// <summary>
        /// The interrupt requested to be unmasked is not masked.
        /// </summary>
        public const int STATUS_GPIO_INTERRUPT_ALREADY_UNMASKED = unchecked((int)0x8000A127);

        /*++

         MessageId's 0xa141 - 0xa160 (inclusive) are for run levels support.

        --*/
        /// <summary>
        /// The requested run level switch cannot be completed successfully since
        /// one or more services refused to stop or restart.
        /// </summary>
        public const int STATUS_CANNOT_SWITCH_RUNLEVEL = unchecked((int)0xC000A141);

        /// <summary>
        /// The service has an invalid run level setting. The run level for a service
        /// must not be higher than the run level of its dependent services.
        /// </summary>
        public const int STATUS_INVALID_RUNLEVEL_SETTING = unchecked((int)0xC000A142);

        /// <summary>
        /// The requested run level switch cannot be completed successfully since
        /// one or more services will not stop or restart within the specified timeout.
        /// </summary>
        public const int STATUS_RUNLEVEL_SWITCH_TIMEOUT = unchecked((int)0xC000A143);

        /// <summary>
        /// One or more services failed to start during the service startup phase of a run level switch.
        /// </summary>
        public const int STATUS_SERVICES_FAILED_AUTOSTART = 0x4000A144;

        /// <summary>
        /// A run level switch agent did not respond within the specified timeout.
        /// </summary>
        public const int STATUS_RUNLEVEL_SWITCH_AGENT_TIMEOUT = unchecked((int)0xC000A145);

        /// <summary>
        /// A run level switch is currently in progress.
        /// </summary>
        public const int STATUS_RUNLEVEL_SWITCH_IN_PROGRESS = unchecked((int)0xC000A146);

        /*++

         MessageId's 0xa200 - 0xa280 (inclusive) are reserved for app container specific messages.

        --*/
        /// <summary>
        /// This operation is only valid in the context of an app container.
        /// </summary>
        public const int STATUS_NOT_APPCONTAINER = unchecked((int)0xC000A200);

        /// <summary>
        /// This functionality is not supported in the context of an app container.
        /// </summary>
        public const int STATUS_NOT_SUPPORTED_IN_APPCONTAINER = unchecked((int)0xC000A201);

        /// <summary>
        /// The length of the SID supplied is not a valid length for app container SIDs.
        /// </summary>
        public const int STATUS_INVALID_PACKAGE_SID_LENGTH = unchecked((int)0xC000A202);

        /// <summary>
        /// Access to the specified resource has been denied for a less privileged app container.
        /// </summary>
        public const int STATUS_LPAC_ACCESS_DENIED = unchecked((int)0xC000A203);

        /// <summary>
        /// Access to the specified resource has been denied for an adminless system.
        /// </summary>
        public const int STATUS_ADMINLESS_ACCESS_DENIED = unchecked((int)0xC000A204);

        /*++

         MessageId's 0xa281 - 0xa2a0 (inclusive) are reserved for Fast Cache specific messages.

        --*/
        /// <summary>
        /// Fast Cache data not found.
        /// </summary>
        public const int STATUS_APP_DATA_NOT_FOUND = unchecked((int)0xC000A281);

        /// <summary>
        /// Fast Cache data expired.
        /// </summary>
        public const int STATUS_APP_DATA_EXPIRED = unchecked((int)0xC000A282);

        /// <summary>
        /// Fast Cache data corrupt.
        /// </summary>
        public const int STATUS_APP_DATA_CORRUPT = unchecked((int)0xC000A283);

        /// <summary>
        /// Fast Cache data has exceeded its max size and cannot be updated.
        /// </summary>
        public const int STATUS_APP_DATA_LIMIT_EXCEEDED = unchecked((int)0xC000A284);

        /// <summary>
        /// Fast Cache has been ReArmed and requires a reboot until it can be updated.
        /// </summary>
        public const int STATUS_APP_DATA_REBOOT_REQUIRED = unchecked((int)0xC000A285);

        /*++

         MessageId's 0xa2a1 - 0xa300 (inclusive) are for File System specific messages.

        --*/
        /// <summary>
        /// The copy offload read operation is not supported by a filter.
        /// </summary>
        public const int STATUS_OFFLOAD_READ_FLT_NOT_SUPPORTED = unchecked((int)0xC000A2A1);

        /// <summary>
        /// The copy offload write operation is not supported by a filter.
        /// </summary>
        public const int STATUS_OFFLOAD_WRITE_FLT_NOT_SUPPORTED = unchecked((int)0xC000A2A2);

        /// <summary>
        /// The copy offload read operation is not supported for the file.
        /// </summary>
        public const int STATUS_OFFLOAD_READ_FILE_NOT_SUPPORTED = unchecked((int)0xC000A2A3);

        /// <summary>
        /// The copy offload write operation is not supported for the file.
        /// </summary>
        public const int STATUS_OFFLOAD_WRITE_FILE_NOT_SUPPORTED = unchecked((int)0xC000A2A4);

        /// <summary>
        /// The WOF driver encountered a corruption in WIM image's Header.
        /// </summary>
        public const int STATUS_WOF_WIM_HEADER_CORRUPT = unchecked((int)0xC000A2A5);

        /// <summary>
        /// The WOF driver encountered a corruption in WIM image's Resource Table.
        /// </summary>
        public const int STATUS_WOF_WIM_RESOURCE_TABLE_CORRUPT = unchecked((int)0xC000A2A6);

        /// <summary>
        /// The WOF driver encountered a corruption in the compressed file's Resource Table.
        /// </summary>
        public const int STATUS_WOF_FILE_RESOURCE_TABLE_CORRUPT = unchecked((int)0xC000A2A7);

        /*++

         MessageId's 0xce00 - 0xceff (inclusive) are for File System virtualization specific messages.

        --*/
        /// <summary>
        /// The provider that supports file system virtualization is temporarily unavailable.
        /// </summary>
        public const int STATUS_FILE_SYSTEM_VIRTUALIZATION_UNAVAILABLE = unchecked((int)0xC000CE01);

        /// <summary>
        /// The metadata for file system virtualization is corrupt and unreadable.
        /// </summary>
        public const int STATUS_FILE_SYSTEM_VIRTUALIZATION_METADATA_CORRUPT = unchecked((int)0xC000CE02);

        /// <summary>
        /// The provider that supports file system virtualization is too busy to complete this operation.
        /// </summary>
        public const int STATUS_FILE_SYSTEM_VIRTUALIZATION_BUSY = unchecked((int)0xC000CE03);

        /// <summary>
        /// The provider that supports file system virtualization is unknown.
        /// </summary>
        public const int STATUS_FILE_SYSTEM_VIRTUALIZATION_PROVIDER_UNKNOWN = unchecked((int)0xC000CE04);

        /// <summary>
        /// The virtualization operation is not allowed on the file in its current state.
        /// </summary>
        public const int STATUS_FILE_SYSTEM_VIRTUALIZATION_INVALID_OPERATION = unchecked((int)0xC000CE05);

        /*++

         MessageId's 0xcf00 - 0xcfff (inclusive) are for Cloud Files specific messages.

        --*/
        /// <summary>
        /// The cloud sync root metadata is corrupted.
        /// </summary>
        public const int STATUS_CLOUD_FILE_SYNC_ROOT_METADATA_CORRUPT = unchecked((int)0xC000CF00);

        /// <summary>
        /// The cloud file provider is not running.
        /// </summary>
        public const int STATUS_CLOUD_FILE_PROVIDER_NOT_RUNNING = unchecked((int)0xC000CF01);

        /// <summary>
        /// The cloud file metadata is corrupt and unreadable.
        /// </summary>
        public const int STATUS_CLOUD_FILE_METADATA_CORRUPT = unchecked((int)0xC000CF02);

        /// <summary>
        /// The cloud file metadata is too large.
        /// </summary>
        public const int STATUS_CLOUD_FILE_METADATA_TOO_LARGE = unchecked((int)0xC000CF03);

        /// <summary>
        /// The cloud file property is too large.
        /// </summary>
        public const int STATUS_CLOUD_FILE_PROPERTY_BLOB_TOO_LARGE = unchecked((int)0x8000CF04);

        /// <summary>
        /// The maximum number of cloud file properties has been reached.
        /// </summary>
        public const int STATUS_CLOUD_FILE_TOO_MANY_PROPERTY_BLOBS = unchecked((int)0x8000CF05);

        /// <summary>
        /// The version of the cloud file property store is not supported.
        /// </summary>
        public const int STATUS_CLOUD_FILE_PROPERTY_VERSION_NOT_SUPPORTED = unchecked((int)0xC000CF06);

        /// <summary>
        /// The file is not a cloud file.
        /// </summary>
        public const int STATUS_NOT_A_CLOUD_FILE = unchecked((int)0xC000CF07);

        /// <summary>
        /// The file is not in sync with the cloud.
        /// </summary>
        public const int STATUS_CLOUD_FILE_NOT_IN_SYNC = unchecked((int)0xC000CF08);

        /// <summary>
        /// The cloud sync root is already connected with another cloud sync provider.
        /// </summary>
        public const int STATUS_CLOUD_FILE_ALREADY_CONNECTED = unchecked((int)0xC000CF09);

        /// <summary>
        /// The operation is not supported by the cloud sync provider.
        /// </summary>
        public const int STATUS_CLOUD_FILE_NOT_SUPPORTED = unchecked((int)0xC000CF0A);

        /// <summary>
        /// The cloud operation is invalid.
        /// </summary>
        public const int STATUS_CLOUD_FILE_INVALID_REQUEST = unchecked((int)0xC000CF0B);

        /// <summary>
        /// The cloud operation is not supported on a read-only volume.
        /// </summary>
        public const int STATUS_CLOUD_FILE_READ_ONLY_VOLUME = unchecked((int)0xC000CF0C);

        /// <summary>
        /// The operation is reserved for a connected cloud sync provider.
        /// </summary>
        public const int STATUS_CLOUD_FILE_CONNECTED_PROVIDER_ONLY = unchecked((int)0xC000CF0D);

        /// <summary>
        /// The cloud sync provider failed to validate the downloaded data.
        /// </summary>
        public const int STATUS_CLOUD_FILE_VALIDATION_FAILED = unchecked((int)0xC000CF0E);

        /// <summary>
        /// The cloud sync provider failed user authentication.
        /// </summary>
        public const int STATUS_CLOUD_FILE_AUTHENTICATION_FAILED = unchecked((int)0xC000CF0F);

        /// <summary>
        /// The cloud sync provider failed to perform the operation due to low system resources.
        /// </summary>
        public const int STATUS_CLOUD_FILE_INSUFFICIENT_RESOURCES = unchecked((int)0xC000CF10);

        /// <summary>
        /// The cloud sync provider failed to perform the operation due to network being unavailable.
        /// </summary>
        public const int STATUS_CLOUD_FILE_NETWORK_UNAVAILABLE = unchecked((int)0xC000CF11);

        /// <summary>
        /// The cloud operation was unsuccessful.
        /// </summary>
        public const int STATUS_CLOUD_FILE_UNSUCCESSFUL = unchecked((int)0xC000CF12);

        /// <summary>
        /// The operation is only supported on files under a cloud sync root.
        /// </summary>
        public const int STATUS_CLOUD_FILE_NOT_UNDER_SYNC_ROOT = unchecked((int)0xC000CF13);

        /// <summary>
        /// The operation cannot be performed on cloud files in use.
        /// </summary>
        public const int STATUS_CLOUD_FILE_IN_USE = unchecked((int)0xC000CF14);

        /// <summary>
        /// The operation cannot be performed on pinned cloud files.
        /// </summary>
        public const int STATUS_CLOUD_FILE_PINNED = unchecked((int)0xC000CF15);

        /// <summary>
        /// The cloud operation was aborted.
        /// </summary>
        public const int STATUS_CLOUD_FILE_REQUEST_ABORTED = unchecked((int)0xC000CF16);

        /// <summary>
        /// The cloud file's property store is corrupt.
        /// </summary>
        public const int STATUS_CLOUD_FILE_PROPERTY_CORRUPT = unchecked((int)0xC000CF17);

        /// <summary>
        /// Access to the cloud file is denied.
        /// </summary>
        public const int STATUS_CLOUD_FILE_ACCESS_DENIED = unchecked((int)0xC000CF18);

        /// <summary>
        /// The cloud operation cannot be performed on a file with incompatible hardlinks.
        /// </summary>
        public const int STATUS_CLOUD_FILE_INCOMPATIBLE_HARDLINKS = unchecked((int)0xC000CF19);

        /// <summary>
        /// The operation failed due to a conflicting cloud file property lock.
        /// </summary>
        public const int STATUS_CLOUD_FILE_PROPERTY_LOCK_CONFLICT = unchecked((int)0xC000CF1A);

        /// <summary>
        /// The cloud operation was canceled by user.
        /// </summary>
        public const int STATUS_CLOUD_FILE_REQUEST_CANCELED = unchecked((int)0xC000CF1B);

        /// <summary>
        /// The cloud file provider exited unexpectedly.
        /// </summary>
        public const int STATUS_CLOUD_FILE_PROVIDER_TERMINATED = unchecked((int)0xC000CF1D);

        /// <summary>
        /// The file is not a cloud sync root.
        /// </summary>
        public const int STATUS_NOT_A_CLOUD_SYNC_ROOT = unchecked((int)0xC000CF1E);

        /*++

         End of Cloud Files specific messages.

        --*/

        //     **** New SYSTEM error codes can be inserted here ****


        //
        //  Debugger error values
        //

        /// <summary>
        /// Debugger did not perform a state change.
        /// </summary>
        public const int DBG_NO_STATE_CHANGE = unchecked((int)0xC0010001);

        /// <summary>
        /// Debugger has found the application is not idle.
        /// </summary>
        public const int DBG_APP_NOT_IDLE = unchecked((int)0xC0010002);


        //
        //  RPC error values
        //

        /// <summary>
        /// The string binding is invalid.
        /// </summary>
        public const int RPC_NT_INVALID_STRING_BINDING = unchecked((int)0xC0020001);

        /// <summary>
        /// The binding handle is not the correct type.
        /// </summary>
        public const int RPC_NT_WRONG_KIND_OF_BINDING = unchecked((int)0xC0020002);

        /// <summary>
        /// The binding handle is invalid.
        /// </summary>
        public const int RPC_NT_INVALID_BINDING = unchecked((int)0xC0020003);

        /// <summary>
        /// The RPC protocol sequence is not supported.
        /// </summary>
        public const int RPC_NT_PROTSEQ_NOT_SUPPORTED = unchecked((int)0xC0020004);

        /// <summary>
        /// The RPC protocol sequence is invalid.
        /// </summary>
        public const int RPC_NT_INVALID_RPC_PROTSEQ = unchecked((int)0xC0020005);

        /// <summary>
        /// The string UUID is invalid.
        /// </summary>
        public const int RPC_NT_INVALID_STRING_UUID = unchecked((int)0xC0020006);

        /// <summary>
        /// The endpoint format is invalid.
        /// </summary>
        public const int RPC_NT_INVALID_ENDPOINT_FORMAT = unchecked((int)0xC0020007);

        /// <summary>
        /// The network address is invalid.
        /// </summary>
        public const int RPC_NT_INVALID_NET_ADDR = unchecked((int)0xC0020008);

        /// <summary>
        /// No endpoint was found.
        /// </summary>
        public const int RPC_NT_NO_ENDPOINT_FOUND = unchecked((int)0xC0020009);

        /// <summary>
        /// The timeout value is invalid.
        /// </summary>
        public const int RPC_NT_INVALID_TIMEOUT = unchecked((int)0xC002000A);

        /// <summary>
        /// The object UUID was not found.
        /// </summary>
        public const int RPC_NT_OBJECT_NOT_FOUND = unchecked((int)0xC002000B);

        /// <summary>
        /// The object UUID has already been registered.
        /// </summary>
        public const int RPC_NT_ALREADY_REGISTERED = unchecked((int)0xC002000C);

        /// <summary>
        /// The type UUID has already been registered.
        /// </summary>
        public const int RPC_NT_TYPE_ALREADY_REGISTERED = unchecked((int)0xC002000D);

        /// <summary>
        /// The RPC server is already listening.
        /// </summary>
        public const int RPC_NT_ALREADY_LISTENING = unchecked((int)0xC002000E);

        /// <summary>
        /// No protocol sequences have been registered.
        /// </summary>
        public const int RPC_NT_NO_PROTSEQS_REGISTERED = unchecked((int)0xC002000F);

        /// <summary>
        /// The RPC server is not listening.
        /// </summary>
        public const int RPC_NT_NOT_LISTENING = unchecked((int)0xC0020010);

        /// <summary>
        /// The manager type is unknown.
        /// </summary>
        public const int RPC_NT_UNKNOWN_MGR_TYPE = unchecked((int)0xC0020011);

        /// <summary>
        /// The interface is unknown.
        /// </summary>
        public const int RPC_NT_UNKNOWN_IF = unchecked((int)0xC0020012);

        /// <summary>
        /// There are no bindings.
        /// </summary>
        public const int RPC_NT_NO_BINDINGS = unchecked((int)0xC0020013);

        /// <summary>
        /// There are no protocol sequences.
        /// </summary>
        public const int RPC_NT_NO_PROTSEQS = unchecked((int)0xC0020014);

        /// <summary>
        /// The endpoint cannot be created.
        /// </summary>
        public const int RPC_NT_CANT_CREATE_ENDPOINT = unchecked((int)0xC0020015);

        /// <summary>
        /// Not enough resources are available to complete this operation.
        /// </summary>
        public const int RPC_NT_OUT_OF_RESOURCES = unchecked((int)0xC0020016);

        /// <summary>
        /// The RPC server is unavailable.
        /// </summary>
        public const int RPC_NT_SERVER_UNAVAILABLE = unchecked((int)0xC0020017);

        /// <summary>
        /// The RPC server is too busy to complete this operation.
        /// </summary>
        public const int RPC_NT_SERVER_TOO_BUSY = unchecked((int)0xC0020018);

        /// <summary>
        /// The network options are invalid.
        /// </summary>
        public const int RPC_NT_INVALID_NETWORK_OPTIONS = unchecked((int)0xC0020019);

        /// <summary>
        /// There are no remote procedure calls active on this thread.
        /// </summary>
        public const int RPC_NT_NO_CALL_ACTIVE = unchecked((int)0xC002001A);

        /// <summary>
        /// The remote procedure call failed.
        /// </summary>
        public const int RPC_NT_CALL_FAILED = unchecked((int)0xC002001B);

        /// <summary>
        /// The remote procedure call failed and did not execute.
        /// </summary>
        public const int RPC_NT_CALL_FAILED_DNE = unchecked((int)0xC002001C);

        /// <summary>
        /// An RPC protocol error occurred.
        /// </summary>
        public const int RPC_NT_PROTOCOL_ERROR = unchecked((int)0xC002001D);

        /// <summary>
        /// The transfer syntax is not supported by the RPC server.
        /// </summary>
        public const int RPC_NT_UNSUPPORTED_TRANS_SYN = unchecked((int)0xC002001F);

        /// <summary>
        /// The type UUID is not supported.
        /// </summary>
        public const int RPC_NT_UNSUPPORTED_TYPE = unchecked((int)0xC0020021);

        /// <summary>
        /// The tag is invalid.
        /// </summary>
        public const int RPC_NT_INVALID_TAG = unchecked((int)0xC0020022);

        /// <summary>
        /// The array bounds are invalid.
        /// </summary>
        public const int RPC_NT_INVALID_BOUND = unchecked((int)0xC0020023);

        /// <summary>
        /// The binding does not contain an entry name.
        /// </summary>
        public const int RPC_NT_NO_ENTRY_NAME = unchecked((int)0xC0020024);

        /// <summary>
        /// The name syntax is invalid.
        /// </summary>
        public const int RPC_NT_INVALID_NAME_SYNTAX = unchecked((int)0xC0020025);

        /// <summary>
        /// The name syntax is not supported.
        /// </summary>
        public const int RPC_NT_UNSUPPORTED_NAME_SYNTAX = unchecked((int)0xC0020026);

        /// <summary>
        /// No network address is available to use to construct a UUID.
        /// </summary>
        public const int RPC_NT_UUID_NO_ADDRESS = unchecked((int)0xC0020028);

        /// <summary>
        /// The endpoint is a duplicate.
        /// </summary>
        public const int RPC_NT_DUPLICATE_ENDPOINT = unchecked((int)0xC0020029);

        /// <summary>
        /// The authentication type is unknown.
        /// </summary>
        public const int RPC_NT_UNKNOWN_AUTHN_TYPE = unchecked((int)0xC002002A);

        /// <summary>
        /// The maximum number of calls is too small.
        /// </summary>
        public const int RPC_NT_MAX_CALLS_TOO_SMALL = unchecked((int)0xC002002B);

        /// <summary>
        /// The string is too long.
        /// </summary>
        public const int RPC_NT_STRING_TOO_LONG = unchecked((int)0xC002002C);

        /// <summary>
        /// The RPC protocol sequence was not found.
        /// </summary>
        public const int RPC_NT_PROTSEQ_NOT_FOUND = unchecked((int)0xC002002D);

        /// <summary>
        /// The procedure number is out of range.
        /// </summary>
        public const int RPC_NT_PROCNUM_OUT_OF_RANGE = unchecked((int)0xC002002E);

        /// <summary>
        /// The binding does not contain any authentication information.
        /// </summary>
        public const int RPC_NT_BINDING_HAS_NO_AUTH = unchecked((int)0xC002002F);

        /// <summary>
        /// The authentication service is unknown.
        /// </summary>
        public const int RPC_NT_UNKNOWN_AUTHN_SERVICE = unchecked((int)0xC0020030);

        /// <summary>
        /// The authentication level is unknown.
        /// </summary>
        public const int RPC_NT_UNKNOWN_AUTHN_LEVEL = unchecked((int)0xC0020031);

        /// <summary>
        /// The security context is invalid.
        /// </summary>
        public const int RPC_NT_INVALID_AUTH_IDENTITY = unchecked((int)0xC0020032);

        /// <summary>
        /// The authorization service is unknown.
        /// </summary>
        public const int RPC_NT_UNKNOWN_AUTHZ_SERVICE = unchecked((int)0xC0020033);

        /// <summary>
        /// The entry is invalid.
        /// </summary>
        public const int EPT_NT_INVALID_ENTRY = unchecked((int)0xC0020034);

        /// <summary>
        /// The operation cannot be performed.
        /// </summary>
        public const int EPT_NT_CANT_PERFORM_OP = unchecked((int)0xC0020035);

        /// <summary>
        /// There are no more endpoints available from the endpoint mapper.
        /// </summary>
        public const int EPT_NT_NOT_REGISTERED = unchecked((int)0xC0020036);

        /// <summary>
        /// No interfaces have been exported.
        /// </summary>
        public const int RPC_NT_NOTHING_TO_EXPORT = unchecked((int)0xC0020037);

        /// <summary>
        /// The entry name is incomplete.
        /// </summary>
        public const int RPC_NT_INCOMPLETE_NAME = unchecked((int)0xC0020038);

        /// <summary>
        /// The version option is invalid.
        /// </summary>
        public const int RPC_NT_INVALID_VERS_OPTION = unchecked((int)0xC0020039);

        /// <summary>
        /// There are no more members.
        /// </summary>
        public const int RPC_NT_NO_MORE_MEMBERS = unchecked((int)0xC002003A);

        /// <summary>
        /// There is nothing to unexport.
        /// </summary>
        public const int RPC_NT_NOT_ALL_OBJS_UNEXPORTED = unchecked((int)0xC002003B);

        /// <summary>
        /// The interface was not found.
        /// </summary>
        public const int RPC_NT_INTERFACE_NOT_FOUND = unchecked((int)0xC002003C);

        /// <summary>
        /// The entry already exists.
        /// </summary>
        public const int RPC_NT_ENTRY_ALREADY_EXISTS = unchecked((int)0xC002003D);

        /// <summary>
        /// The entry is not found.
        /// </summary>
        public const int RPC_NT_ENTRY_NOT_FOUND = unchecked((int)0xC002003E);

        /// <summary>
        /// The name service is unavailable.
        /// </summary>
        public const int RPC_NT_NAME_SERVICE_UNAVAILABLE = unchecked((int)0xC002003F);

        /// <summary>
        /// The network address family is invalid.
        /// </summary>
        public const int RPC_NT_INVALID_NAF_ID = unchecked((int)0xC0020040);

        /// <summary>
        /// The requested operation is not supported.
        /// </summary>
        public const int RPC_NT_CANNOT_SUPPORT = unchecked((int)0xC0020041);

        /// <summary>
        /// No security context is available to allow impersonation.
        /// </summary>
        public const int RPC_NT_NO_CONTEXT_AVAILABLE = unchecked((int)0xC0020042);

        /// <summary>
        /// An internal error occurred in RPC.
        /// </summary>
        public const int RPC_NT_INTERNAL_ERROR = unchecked((int)0xC0020043);

        /// <summary>
        /// The RPC server attempted an integer divide by zero.
        /// </summary>
        public const int RPC_NT_ZERO_DIVIDE = unchecked((int)0xC0020044);

        /// <summary>
        /// An addressing error occurred in the RPC server.
        /// </summary>
        public const int RPC_NT_ADDRESS_ERROR = unchecked((int)0xC0020045);

        /// <summary>
        /// A floating point operation at the RPC server caused a divide by zero.
        /// </summary>
        public const int RPC_NT_FP_DIV_ZERO = unchecked((int)0xC0020046);

        /// <summary>
        /// A floating point underflow occurred at the RPC server.
        /// </summary>
        public const int RPC_NT_FP_UNDERFLOW = unchecked((int)0xC0020047);

        /// <summary>
        /// A floating point overflow occurred at the RPC server.
        /// </summary>
        public const int RPC_NT_FP_OVERFLOW = unchecked((int)0xC0020048);

        /// <summary>
        /// The list of RPC servers available for auto-handle binding has been exhausted.
        /// </summary>
        public const int RPC_NT_NO_MORE_ENTRIES = unchecked((int)0xC0030001);

        /// <summary>
        /// The file designated by DCERPCCHARTRANS cannot be opened.
        /// </summary>
        public const int RPC_NT_SS_CHAR_TRANS_OPEN_FAIL = unchecked((int)0xC0030002);

        /// <summary>
        /// The file containing the character translation table has fewer than 512 bytes.
        /// </summary>
        public const int RPC_NT_SS_CHAR_TRANS_SHORT_FILE = unchecked((int)0xC0030003);

        /// <summary>
        /// A null context handle is passed as an [in] parameter.
        /// </summary>
        public const int RPC_NT_SS_IN_NULL_CONTEXT = unchecked((int)0xC0030004);

        /// <summary>
        /// The context handle does not match any known context handles.
        /// </summary>
        public const int RPC_NT_SS_CONTEXT_MISMATCH = unchecked((int)0xC0030005);

        /// <summary>
        /// The context handle changed during a call.
        /// </summary>
        public const int RPC_NT_SS_CONTEXT_DAMAGED = unchecked((int)0xC0030006);

        /// <summary>
        /// The binding handles passed to a remote procedure call do not match.
        /// </summary>
        public const int RPC_NT_SS_HANDLES_MISMATCH = unchecked((int)0xC0030007);

        /// <summary>
        /// The stub is unable to get the call handle.
        /// </summary>
        public const int RPC_NT_SS_CANNOT_GET_CALL_HANDLE = unchecked((int)0xC0030008);

        /// <summary>
        /// A null reference pointer was passed to the stub.
        /// </summary>
        public const int RPC_NT_NULL_REF_POINTER = unchecked((int)0xC0030009);

        /// <summary>
        /// The enumeration value is out of range.
        /// </summary>
        public const int RPC_NT_ENUM_VALUE_OUT_OF_RANGE = unchecked((int)0xC003000A);

        /// <summary>
        /// The byte count is too small.
        /// </summary>
        public const int RPC_NT_BYTE_COUNT_TOO_SMALL = unchecked((int)0xC003000B);

        /// <summary>
        /// The stub received bad data.
        /// </summary>
        public const int RPC_NT_BAD_STUB_DATA = unchecked((int)0xC003000C);

        /// <summary>
        /// A remote procedure call is already in progress for this thread.
        /// </summary>
        public const int RPC_NT_CALL_IN_PROGRESS = unchecked((int)0xC0020049);

        /// <summary>
        /// There are no more bindings.
        /// </summary>
        public const int RPC_NT_NO_MORE_BINDINGS = unchecked((int)0xC002004A);

        /// <summary>
        /// The group member was not found.
        /// </summary>
        public const int RPC_NT_GROUP_MEMBER_NOT_FOUND = unchecked((int)0xC002004B);

        /// <summary>
        /// The endpoint mapper database entry could not be created.
        /// </summary>
        public const int EPT_NT_CANT_CREATE = unchecked((int)0xC002004C);

        /// <summary>
        /// The object UUID is the nil UUID.
        /// </summary>
        public const int RPC_NT_INVALID_OBJECT = unchecked((int)0xC002004D);

        /// <summary>
        /// No interfaces have been registered.
        /// </summary>
        public const int RPC_NT_NO_INTERFACES = unchecked((int)0xC002004F);

        /// <summary>
        /// The remote procedure call was cancelled.
        /// </summary>
        public const int RPC_NT_CALL_CANCELLED = unchecked((int)0xC0020050);

        /// <summary>
        /// The binding handle does not contain all required information.
        /// </summary>
        public const int RPC_NT_BINDING_INCOMPLETE = unchecked((int)0xC0020051);

        /// <summary>
        /// A communications failure occurred during a remote procedure call.
        /// </summary>
        public const int RPC_NT_COMM_FAILURE = unchecked((int)0xC0020052);

        /// <summary>
        /// The requested authentication level is not supported.
        /// </summary>
        public const int RPC_NT_UNSUPPORTED_AUTHN_LEVEL = unchecked((int)0xC0020053);

        /// <summary>
        /// No principal name registered.
        /// </summary>
        public const int RPC_NT_NO_PRINC_NAME = unchecked((int)0xC0020054);

        /// <summary>
        /// The error specified is not a valid Windows RPC error code.
        /// </summary>
        public const int RPC_NT_NOT_RPC_ERROR = unchecked((int)0xC0020055);

        /// <summary>
        /// A UUID that is valid only on this computer has been allocated.
        /// </summary>
        public const int RPC_NT_UUID_LOCAL_ONLY = 0x40020056;

        /// <summary>
        /// A security package specific error occurred.
        /// </summary>
        public const int RPC_NT_SEC_PKG_ERROR = unchecked((int)0xC0020057);

        /// <summary>
        /// Thread is not cancelled.
        /// </summary>
        public const int RPC_NT_NOT_CANCELLED = unchecked((int)0xC0020058);

        /// <summary>
        /// Invalid operation on the encoding/decoding handle.
        /// </summary>
        public const int RPC_NT_INVALID_ES_ACTION = unchecked((int)0xC0030059);

        /// <summary>
        /// Incompatible version of the serializing package.
        /// </summary>
        public const int RPC_NT_WRONG_ES_VERSION = unchecked((int)0xC003005A);

        /// <summary>
        /// Incompatible version of the RPC stub.
        /// </summary>
        public const int RPC_NT_WRONG_STUB_VERSION = unchecked((int)0xC003005B);

        /// <summary>
        /// The RPC pipe object is invalid or corrupted.
        /// </summary>
        public const int RPC_NT_INVALID_PIPE_OBJECT = unchecked((int)0xC003005C);

        /// <summary>
        /// An invalid operation was attempted on an RPC pipe object.
        /// </summary>
        public const int RPC_NT_INVALID_PIPE_OPERATION = unchecked((int)0xC003005D);

        /// <summary>
        /// Unsupported RPC pipe version.
        /// </summary>
        public const int RPC_NT_WRONG_PIPE_VERSION = unchecked((int)0xC003005E);

        /// <summary>
        /// The RPC pipe object has already been closed.
        /// </summary>
        public const int RPC_NT_PIPE_CLOSED = unchecked((int)0xC003005F);

        /// <summary>
        /// The RPC call completed before all pipes were processed.
        /// </summary>
        public const int RPC_NT_PIPE_DISCIPLINE_ERROR = unchecked((int)0xC0030060);

        /// <summary>
        /// No more data is available from the RPC pipe.
        /// </summary>
        public const int RPC_NT_PIPE_EMPTY = unchecked((int)0xC0030061);

        /// <summary>
        /// Invalid asynchronous remote procedure call handle.
        /// </summary>
        public const int RPC_NT_INVALID_ASYNC_HANDLE = unchecked((int)0xC0020062);

        /// <summary>
        /// Invalid asynchronous RPC call handle for this operation.
        /// </summary>
        public const int RPC_NT_INVALID_ASYNC_CALL = unchecked((int)0xC0020063);

        /// <summary>
        /// Access to the HTTP proxy is denied.
        /// </summary>
        public const int RPC_NT_PROXY_ACCESS_DENIED = unchecked((int)0xC0020064);

        /// <summary>
        /// HTTP proxy server rejected the connection because the cookie authentication failed.
        /// </summary>
        public const int RPC_NT_COOKIE_AUTH_FAILED = unchecked((int)0xC0020065);

        /// <summary>
        /// Some data remains to be sent in the request buffer.
        /// </summary>
        public const int RPC_NT_SEND_INCOMPLETE = 0x400200AF;


        //
        //  ACPI error values
        //

        /// <summary>
        /// An attempt was made to run an invalid AML opcode
        /// </summary>
        public const int STATUS_ACPI_INVALID_OPCODE = unchecked((int)0xC0140001);

        /// <summary>
        /// The AML Interpreter Stack has overflowed
        /// </summary>
        public const int STATUS_ACPI_STACK_OVERFLOW = unchecked((int)0xC0140002);

        /// <summary>
        /// An inconsistent state has occurred
        /// </summary>
        public const int STATUS_ACPI_ASSERT_FAILED = unchecked((int)0xC0140003);

        /// <summary>
        /// An attempt was made to access an array outside of its bounds
        /// </summary>
        public const int STATUS_ACPI_INVALID_INDEX = unchecked((int)0xC0140004);

        /// <summary>
        /// A required argument was not specified
        /// </summary>
        public const int STATUS_ACPI_INVALID_ARGUMENT = unchecked((int)0xC0140005);

        /// <summary>
        /// A fatal error has occurred
        /// </summary>
        public const int STATUS_ACPI_FATAL = unchecked((int)0xC0140006);

        /// <summary>
        /// An invalid SuperName was specified
        /// </summary>
        public const int STATUS_ACPI_INVALID_SUPERNAME = unchecked((int)0xC0140007);

        /// <summary>
        /// An argument with an incorrect type was specified
        /// </summary>
        public const int STATUS_ACPI_INVALID_ARGTYPE = unchecked((int)0xC0140008);

        /// <summary>
        /// An object with an incorrect type was specified
        /// </summary>
        public const int STATUS_ACPI_INVALID_OBJTYPE = unchecked((int)0xC0140009);

        /// <summary>
        /// A target with an incorrect type was specified
        /// </summary>
        public const int STATUS_ACPI_INVALID_TARGETTYPE = unchecked((int)0xC014000A);

        /// <summary>
        /// An incorrect number of arguments were specified
        /// </summary>
        public const int STATUS_ACPI_INCORRECT_ARGUMENT_COUNT = unchecked((int)0xC014000B);

        /// <summary>
        /// An address failed to translate
        /// </summary>
        public const int STATUS_ACPI_ADDRESS_NOT_MAPPED = unchecked((int)0xC014000C);

        /// <summary>
        /// An incorrect event type was specified
        /// </summary>
        public const int STATUS_ACPI_INVALID_EVENTTYPE = unchecked((int)0xC014000D);

        /// <summary>
        /// A handler for the target already exists
        /// </summary>
        public const int STATUS_ACPI_HANDLER_COLLISION = unchecked((int)0xC014000E);

        /// <summary>
        /// Invalid data for the target was specified
        /// </summary>
        public const int STATUS_ACPI_INVALID_DATA = unchecked((int)0xC014000F);

        /// <summary>
        /// An invalid region for the target was specified
        /// </summary>
        public const int STATUS_ACPI_INVALID_REGION = unchecked((int)0xC0140010);

        /// <summary>
        /// An attempt was made to access a field outside of the defined range
        /// </summary>
        public const int STATUS_ACPI_INVALID_ACCESS_SIZE = unchecked((int)0xC0140011);

        /// <summary>
        /// The Global system lock could not be acquired
        /// </summary>
        public const int STATUS_ACPI_ACQUIRE_GLOBAL_LOCK = unchecked((int)0xC0140012);

        /// <summary>
        /// An attempt was made to reinitialize the ACPI subsystem
        /// </summary>
        public const int STATUS_ACPI_ALREADY_INITIALIZED = unchecked((int)0xC0140013);

        /// <summary>
        /// The ACPI subsystem has not been initialized
        /// </summary>
        public const int STATUS_ACPI_NOT_INITIALIZED = unchecked((int)0xC0140014);

        /// <summary>
        /// An incorrect mutex was specified
        /// </summary>
        public const int STATUS_ACPI_INVALID_MUTEX_LEVEL = unchecked((int)0xC0140015);

        /// <summary>
        /// The mutex is not currently owned
        /// </summary>
        public const int STATUS_ACPI_MUTEX_NOT_OWNED = unchecked((int)0xC0140016);

        /// <summary>
        /// An attempt was made to access the mutex by a process that was not the owner
        /// </summary>
        public const int STATUS_ACPI_MUTEX_NOT_OWNER = unchecked((int)0xC0140017);

        /// <summary>
        /// An error occurred during an access to Region Space
        /// </summary>
        public const int STATUS_ACPI_RS_ACCESS = unchecked((int)0xC0140018);

        /// <summary>
        /// An attempt was made to use an incorrect table
        /// </summary>
        public const int STATUS_ACPI_INVALID_TABLE = unchecked((int)0xC0140019);

        /// <summary>
        /// The registration of an ACPI event failed
        /// </summary>
        public const int STATUS_ACPI_REG_HANDLER_FAILED = unchecked((int)0xC0140020);

        /// <summary>
        /// An ACPI Power Object failed to transition state
        /// </summary>
        public const int STATUS_ACPI_POWER_REQUEST_FAILED = unchecked((int)0xC0140021);

        //
        // Terminal Server specific Errors
        //
        /// <summary>
        /// Session name %1 is invalid.
        /// </summary>
        public const int STATUS_CTX_WINSTATION_NAME_INVALID = unchecked((int)0xC00A0001);

        /// <summary>
        /// The protocol driver %1 is invalid.
        /// </summary>
        public const int STATUS_CTX_INVALID_PD = unchecked((int)0xC00A0002);

        /// <summary>
        /// The protocol driver %1 was not found in the system path.
        /// </summary>
        public const int STATUS_CTX_PD_NOT_FOUND = unchecked((int)0xC00A0003);

        /// <summary>
        /// The Client Drive Mapping Service Has Connected on Terminal Connection.
        /// </summary>
        public const int STATUS_CTX_CDM_CONNECT = 0x400A0004;

        /// <summary>
        /// The Client Drive Mapping Service Has Disconnected on Terminal Connection.
        /// </summary>
        public const int STATUS_CTX_CDM_DISCONNECT = 0x400A0005;

        /// <summary>
        /// A close operation is pending on the Terminal Connection.
        /// </summary>
        public const int STATUS_CTX_CLOSE_PENDING = unchecked((int)0xC00A0006);

        /// <summary>
        /// There are no free output buffers available.
        /// </summary>
        public const int STATUS_CTX_NO_OUTBUF = unchecked((int)0xC00A0007);

        /// <summary>
        /// The MODEM.INF file was not found.
        /// </summary>
        public const int STATUS_CTX_MODEM_INF_NOT_FOUND = unchecked((int)0xC00A0008);

        /// <summary>
        /// The modem (%1) was not found in MODEM.INF.
        /// </summary>
        public const int STATUS_CTX_INVALID_MODEMNAME = unchecked((int)0xC00A0009);

        /// <summary>
        /// The modem did not accept the command sent to it.
        /// Verify the configured modem name matches the attached modem.
        /// </summary>
        public const int STATUS_CTX_RESPONSE_ERROR = unchecked((int)0xC00A000A);

        /// <summary>
        /// The modem did not respond to the command sent to it.
        /// Verify the modem is properly cabled and powered on.
        /// </summary>
        public const int STATUS_CTX_MODEM_RESPONSE_TIMEOUT = unchecked((int)0xC00A000B);

        /// <summary>
        /// Carrier detect has failed or carrier has been dropped due to disconnect.
        /// </summary>
        public const int STATUS_CTX_MODEM_RESPONSE_NO_CARRIER = unchecked((int)0xC00A000C);

        /// <summary>
        /// Dial tone not detected within required time.
        /// Verify phone cable is properly attached and functional.
        /// </summary>
        public const int STATUS_CTX_MODEM_RESPONSE_NO_DIALTONE = unchecked((int)0xC00A000D);

        /// <summary>
        /// Busy signal detected at remote site on callback.
        /// </summary>
        public const int STATUS_CTX_MODEM_RESPONSE_BUSY = unchecked((int)0xC00A000E);

        /// <summary>
        /// Voice detected at remote site on callback.
        /// </summary>
        public const int STATUS_CTX_MODEM_RESPONSE_VOICE = unchecked((int)0xC00A000F);

        /// <summary>
        /// Transport driver error
        /// </summary>
        public const int STATUS_CTX_TD_ERROR = unchecked((int)0xC00A0010);

        /// <summary>
        /// The client you are using is not licensed to use this system. Your logon request is denied.
        /// </summary>
        public const int STATUS_CTX_LICENSE_CLIENT_INVALID = unchecked((int)0xC00A0012);

        /// <summary>
        /// The system has reached its licensed logon limit.
        /// Please try again later.
        /// </summary>
        public const int STATUS_CTX_LICENSE_NOT_AVAILABLE = unchecked((int)0xC00A0013);

        /// <summary>
        /// The system license has expired. Your logon request is denied.
        /// </summary>
        public const int STATUS_CTX_LICENSE_EXPIRED = unchecked((int)0xC00A0014);

        /// <summary>
        /// The specified session cannot be found.
        /// </summary>
        public const int STATUS_CTX_WINSTATION_NOT_FOUND = unchecked((int)0xC00A0015);

        /// <summary>
        /// The specified session name is already in use.
        /// </summary>
        public const int STATUS_CTX_WINSTATION_NAME_COLLISION = unchecked((int)0xC00A0016);

        /// <summary>
        /// The task you are trying to do can't be completed because Remote Desktop Services is currently busy. Please try again in a few minutes. Other users should still be able to log on.
        /// </summary>
        public const int STATUS_CTX_WINSTATION_BUSY = unchecked((int)0xC00A0017);

        /// <summary>
        /// An attempt has been made to connect to a session whose video mode is not supported by the current client.
        /// </summary>
        public const int STATUS_CTX_BAD_VIDEO_MODE = unchecked((int)0xC00A0018);

        /// <summary>
        /// The application attempted to enable DOS graphics mode.
        /// DOS graphics mode is not supported.
        /// </summary>
        public const int STATUS_CTX_GRAPHICS_INVALID = unchecked((int)0xC00A0022);

        /// <summary>
        /// The requested operation can be performed only on the system console.
        /// This is most often the result of a driver or system DLL requiring direct console access.
        /// </summary>
        public const int STATUS_CTX_NOT_CONSOLE = unchecked((int)0xC00A0024);

        /// <summary>
        /// The client failed to respond to the server connect message.
        /// </summary>
        public const int STATUS_CTX_CLIENT_QUERY_TIMEOUT = unchecked((int)0xC00A0026);

        /// <summary>
        /// Disconnecting the console session is not supported.
        /// </summary>
        public const int STATUS_CTX_CONSOLE_DISCONNECT = unchecked((int)0xC00A0027);

        /// <summary>
        /// Reconnecting a disconnected session to the console is not supported.
        /// </summary>
        public const int STATUS_CTX_CONSOLE_CONNECT = unchecked((int)0xC00A0028);

        /// <summary>
        /// The request to control another session remotely was denied.
        /// </summary>
        public const int STATUS_CTX_SHADOW_DENIED = unchecked((int)0xC00A002A);

        /// <summary>
        /// A process has requested access to a session, but has not been granted those access rights.
        /// </summary>
        public const int STATUS_CTX_WINSTATION_ACCESS_DENIED = unchecked((int)0xC00A002B);

        /// <summary>
        /// The Terminal Connection driver %1 is invalid.
        /// </summary>
        public const int STATUS_CTX_INVALID_WD = unchecked((int)0xC00A002E);

        /// <summary>
        /// The Terminal Connection driver %1 was not found in the system path.
        /// </summary>
        public const int STATUS_CTX_WD_NOT_FOUND = unchecked((int)0xC00A002F);

        /// <summary>
        /// The requested session cannot be controlled remotely.
        /// You cannot control your own session, a session that is trying to control your session,
        /// a session that has no user logged on, nor control other sessions from the console.
        /// </summary>
        public const int STATUS_CTX_SHADOW_INVALID = unchecked((int)0xC00A0030);

        /// <summary>
        /// The requested session is not configured to allow remote control.
        /// </summary>
        public const int STATUS_CTX_SHADOW_DISABLED = unchecked((int)0xC00A0031);

        /// <summary>
        /// The RDP protocol component %2 detected an error in the protocol stream and has disconnected the client.
        /// </summary>
        public const int STATUS_RDP_PROTOCOL_ERROR = unchecked((int)0xC00A0032);

        /// <summary>
        /// Your request to connect to this Terminal server has been rejected.
        /// Your Terminal Server Client license number has not been entered for this copy of the Terminal Client.
        /// Please call your system administrator for help in entering a valid, unique license number for this Terminal Server Client.
        /// Click OK to continue.
        /// </summary>
        public const int STATUS_CTX_CLIENT_LICENSE_NOT_SET = unchecked((int)0xC00A0033);

        /// <summary>
        /// Your request to connect to this Terminal server has been rejected.
        /// Your Terminal Server Client license number is currently being used by another user.
        /// Please call your system administrator to obtain a new copy of the Terminal Server Client with a valid, unique license number.
        /// Click OK to continue.
        /// </summary>
        public const int STATUS_CTX_CLIENT_LICENSE_IN_USE = unchecked((int)0xC00A0034);

        /// <summary>
        /// The remote control of the console was terminated because the display mode was changed. Changing the display mode in a remote control session is not supported.
        /// </summary>
        public const int STATUS_CTX_SHADOW_ENDED_BY_MODE_CHANGE = unchecked((int)0xC00A0035);

        /// <summary>
        /// Remote control could not be terminated because the specified session is not currently being remotely controlled.
        /// </summary>
        public const int STATUS_CTX_SHADOW_NOT_RUNNING = unchecked((int)0xC00A0036);

        /// <summary>
        /// Your interactive logon privilege has been disabled.
        /// Please contact your system administrator.
        /// </summary>
        public const int STATUS_CTX_LOGON_DISABLED = unchecked((int)0xC00A0037);

        /// <summary>
        /// The Terminal Server security layer detected an error in the protocol stream and has disconnected the client.
        /// Client IP: %2.
        /// </summary>
        public const int STATUS_CTX_SECURITY_LAYER_ERROR = unchecked((int)0xC00A0038);

        /// <summary>
        /// The target session is incompatible with the current session.
        /// </summary>
        public const int STATUS_TS_INCOMPATIBLE_SESSIONS = unchecked((int)0xC00A0039);

        /// <summary>
        /// Windows can't connect to your session because a problem occurred in the Windows video subsystem. Try connecting again later, or contact the server administrator for assistance.
        /// </summary>
        public const int STATUS_TS_VIDEO_SUBSYSTEM_ERROR = unchecked((int)0xC00A003A);


        //
        //  IO error values
        //

        /// <summary>
        /// A device is missing in the system BIOS MPS table. This device will not be used.
        /// Please contact your system vendor for system BIOS update.
        /// </summary>
        public const int STATUS_PNP_BAD_MPS_TABLE = unchecked((int)0xC0040035);

        /// <summary>
        /// A translator failed to translate resources.
        /// </summary>
        public const int STATUS_PNP_TRANSLATION_FAILED = unchecked((int)0xC0040036);

        /// <summary>
        /// A IRQ translator failed to translate resources.
        /// </summary>
        public const int STATUS_PNP_IRQ_TRANSLATION_FAILED = unchecked((int)0xC0040037);

        /// <summary>
        /// Driver %2 returned invalid ID for a child device (%3).
        /// </summary>
        public const int STATUS_PNP_INVALID_ID = unchecked((int)0xC0040038);

        /// <summary>
        /// Reissue the given operation as a cached IO operation
        /// </summary>
        public const int STATUS_IO_REISSUE_AS_CACHED = unchecked((int)0xC0040039);


        //
        //  MUI error values
        //

        /// <summary>
        /// The resource loader failed to find MUI file.
        /// </summary>
        public const int STATUS_MUI_FILE_NOT_FOUND = unchecked((int)0xC00B0001);

        /// <summary>
        /// The resource loader failed to load MUI file because the file fail to pass validation.
        /// </summary>
        public const int STATUS_MUI_INVALID_FILE = unchecked((int)0xC00B0002);

        /// <summary>
        /// The RC Manifest is corrupted with garbage data or unsupported version or missing required item.
        /// </summary>
        public const int STATUS_MUI_INVALID_RC_CONFIG = unchecked((int)0xC00B0003);

        /// <summary>
        /// The RC Manifest has invalid culture name.
        /// </summary>
        public const int STATUS_MUI_INVALID_LOCALE_NAME = unchecked((int)0xC00B0004);

        /// <summary>
        /// The RC Manifest has invalid ultimatefallback name.
        /// </summary>
        public const int STATUS_MUI_INVALID_ULTIMATEFALLBACK_NAME = unchecked((int)0xC00B0005);

        /// <summary>
        /// The resource loader cache doesn't have loaded MUI entry.
        /// </summary>
        public const int STATUS_MUI_FILE_NOT_LOADED = unchecked((int)0xC00B0006);

        /// <summary>
        /// User stopped resource enumeration.
        /// </summary>
        public const int STATUS_RESOURCE_ENUM_USER_STOP = unchecked((int)0xC00B0007);


        //
        //  Filter Manager error values
        //

        /// <summary>
        /// A handler was not defined by the filter for this operation.
        /// </summary>
        public const int STATUS_FLT_NO_HANDLER_DEFINED = unchecked((int)0xC01C0001);

        /// <summary>
        /// A context is already defined for this object.
        /// </summary>
        public const int STATUS_FLT_CONTEXT_ALREADY_DEFINED = unchecked((int)0xC01C0002);

        /// <summary>
        /// Asynchronous requests are not valid for this operation.
        /// </summary>
        public const int STATUS_FLT_INVALID_ASYNCHRONOUS_REQUEST = unchecked((int)0xC01C0003);

        /// <summary>
        /// Internal error code used by the filter manager to determine if a fastio operation should be forced down the IRP path. Mini-filters should never return this value.
        /// </summary>
        public const int STATUS_FLT_DISALLOW_FAST_IO = unchecked((int)0xC01C0004);

        //
        //  The same code used to disallow fast IO is also used to disallow the FS
        //  filter QueryOpen callback.
        //

        public const int STATUS_FLT_DISALLOW_FSFILTER_IO = STATUS_FLT_DISALLOW_FAST_IO;

        /// <summary>
        /// An invalid name request was made. The name requested cannot be retrieved at this time.
        /// </summary>
        public const int STATUS_FLT_INVALID_NAME_REQUEST = unchecked((int)0xC01C0005);

        /// <summary>
        /// Posting this operation to a worker thread for further processing is not safe at this time because it could lead to a system deadlock.
        /// </summary>
        public const int STATUS_FLT_NOT_SAFE_TO_POST_OPERATION = unchecked((int)0xC01C0006);

        /// <summary>
        /// The Filter Manager was not initialized when a filter tried to register. Make sure that the Filter Manager is getting loaded as a driver.
        /// </summary>
        public const int STATUS_FLT_NOT_INITIALIZED = unchecked((int)0xC01C0007);

        /// <summary>
        /// The filter is not ready for attachment to volumes because it has not finished initializing (FltStartFiltering has not been called).
        /// </summary>
        public const int STATUS_FLT_FILTER_NOT_READY = unchecked((int)0xC01C0008);

        /// <summary>
        /// The filter must cleanup any operation specific context at this time because it is being removed from the system before the operation is completed by the lower drivers.
        /// </summary>
        public const int STATUS_FLT_POST_OPERATION_CLEANUP = unchecked((int)0xC01C0009);

        /// <summary>
        /// The Filter Manager had an internal error from which it cannot recover, therefore the operation has been failed. This is usually the result of a filter returning an invalid value from a pre-operation callback.
        /// </summary>
        public const int STATUS_FLT_INTERNAL_ERROR = unchecked((int)0xC01C000A);

        /// <summary>
        /// The object specified for this action is in the process of being deleted, therefore the action requested cannot be completed at this time.
        /// </summary>
        public const int STATUS_FLT_DELETING_OBJECT = unchecked((int)0xC01C000B);

        /// <summary>
        /// Non-paged pool must be used for this type of context.
        /// </summary>
        public const int STATUS_FLT_MUST_BE_NONPAGED_POOL = unchecked((int)0xC01C000C);

        /// <summary>
        /// A duplicate handler definition has been provided for an operation.
        /// </summary>
        public const int STATUS_FLT_DUPLICATE_ENTRY = unchecked((int)0xC01C000D);

        /// <summary>
        /// The callback data queue has been disabled.
        /// </summary>
        public const int STATUS_FLT_CBDQ_DISABLED = unchecked((int)0xC01C000E);

        /// <summary>
        /// Do not attach the filter to the volume at this time.
        /// </summary>
        public const int STATUS_FLT_DO_NOT_ATTACH = unchecked((int)0xC01C000F);

        /// <summary>
        /// Do not detach the filter from the volume at this time.
        /// </summary>
        public const int STATUS_FLT_DO_NOT_DETACH = unchecked((int)0xC01C0010);

        /// <summary>
        /// An instance already exists at this altitude on the volume specified.
        /// </summary>
        public const int STATUS_FLT_INSTANCE_ALTITUDE_COLLISION = unchecked((int)0xC01C0011);

        /// <summary>
        /// An instance already exists with this name on the volume specified.
        /// </summary>
        public const int STATUS_FLT_INSTANCE_NAME_COLLISION = unchecked((int)0xC01C0012);

        /// <summary>
        /// The system could not find the filter specified.
        /// </summary>
        public const int STATUS_FLT_FILTER_NOT_FOUND = unchecked((int)0xC01C0013);

        /// <summary>
        /// The system could not find the volume specified.
        /// </summary>
        public const int STATUS_FLT_VOLUME_NOT_FOUND = unchecked((int)0xC01C0014);

        /// <summary>
        /// The system could not find the instance specified.
        /// </summary>
        public const int STATUS_FLT_INSTANCE_NOT_FOUND = unchecked((int)0xC01C0015);

        /// <summary>
        /// No registered context allocation definition was found for the given request.
        /// </summary>
        public const int STATUS_FLT_CONTEXT_ALLOCATION_NOT_FOUND = unchecked((int)0xC01C0016);

        /// <summary>
        /// An invalid parameter was specified during context registration.
        /// </summary>
        public const int STATUS_FLT_INVALID_CONTEXT_REGISTRATION = unchecked((int)0xC01C0017);

        /// <summary>
        /// The name requested was not found in Filter Manager's name cache and could not be retrieved from the file system.
        /// </summary>
        public const int STATUS_FLT_NAME_CACHE_MISS = unchecked((int)0xC01C0018);

        /// <summary>
        /// The requested device object does not exist for the given volume.
        /// </summary>
        public const int STATUS_FLT_NO_DEVICE_OBJECT = unchecked((int)0xC01C0019);

        /// <summary>
        /// The specified volume is already mounted.
        /// </summary>
        public const int STATUS_FLT_VOLUME_ALREADY_MOUNTED = unchecked((int)0xC01C001A);

        /// <summary>
        /// The specified Transaction Context is already enlisted in a transaction
        /// </summary>
        public const int STATUS_FLT_ALREADY_ENLISTED = unchecked((int)0xC01C001B);

        /// <summary>
        /// The specifiec context is already attached to another object
        /// </summary>
        public const int STATUS_FLT_CONTEXT_ALREADY_LINKED = unchecked((int)0xC01C001C);

        /// <summary>
        /// No waiter is present for the filter's reply to this message.
        /// </summary>
        public const int STATUS_FLT_NO_WAITER_FOR_REPLY = unchecked((int)0xC01C0020);

        /// <summary>
        /// The filesystem database resource is in use. Registration cannot complete at this time.
        /// </summary>
        public const int STATUS_FLT_REGISTRATION_BUSY = unchecked((int)0xC01C0023);


        //
        //  Side-by-side (SXS) error values
        //

        /// <summary>
        /// The requested section is not present in the activation context.
        /// </summary>
        public const int STATUS_SXS_SECTION_NOT_FOUND = unchecked((int)0xC0150001);

        /// <summary>
        /// Windows was not able to process the application binding information.
        /// Please refer to your System Event Log for further information.
        /// </summary>
        public const int STATUS_SXS_CANT_GEN_ACTCTX = unchecked((int)0xC0150002);

        /// <summary>
        /// The application binding data format is invalid.
        /// </summary>
        public const int STATUS_SXS_INVALID_ACTCTXDATA_FORMAT = unchecked((int)0xC0150003);

        /// <summary>
        /// The referenced assembly is not installed on your system.
        /// </summary>
        public const int STATUS_SXS_ASSEMBLY_NOT_FOUND = unchecked((int)0xC0150004);

        /// <summary>
        /// The manifest file does not begin with the required tag and format information.
        /// </summary>
        public const int STATUS_SXS_MANIFEST_FORMAT_ERROR = unchecked((int)0xC0150005);

        /// <summary>
        /// The manifest file contains one or more syntax errors.
        /// </summary>
        public const int STATUS_SXS_MANIFEST_PARSE_ERROR = unchecked((int)0xC0150006);

        /// <summary>
        /// The application attempted to activate a disabled activation context.
        /// </summary>
        public const int STATUS_SXS_ACTIVATION_CONTEXT_DISABLED = unchecked((int)0xC0150007);

        /// <summary>
        /// The requested lookup key was not found in any active activation context.
        /// </summary>
        public const int STATUS_SXS_KEY_NOT_FOUND = unchecked((int)0xC0150008);

        /// <summary>
        /// A component version required by the application conflicts with another component version already active.
        /// </summary>
        public const int STATUS_SXS_VERSION_CONFLICT = unchecked((int)0xC0150009);

        /// <summary>
        /// The type requested activation context section does not match the query API used.
        /// </summary>
        public const int STATUS_SXS_WRONG_SECTION_TYPE = unchecked((int)0xC015000A);

        /// <summary>
        /// Lack of system resources has required isolated activation to be disabled for the current thread of execution.
        /// </summary>
        public const int STATUS_SXS_THREAD_QUERIES_DISABLED = unchecked((int)0xC015000B);

        /// <summary>
        /// The referenced assembly could not be found.
        /// </summary>
        public const int STATUS_SXS_ASSEMBLY_MISSING = unchecked((int)0xC015000C);

        /// <summary>
        /// A kernel mode component is releasing a reference on an activation context.
        /// </summary>
        public const int STATUS_SXS_RELEASE_ACTIVATION_CONTEXT = 0x4015000D;

        /// <summary>
        /// An attempt to set the process default activation context failed because the process default activation context was already set.
        /// </summary>
        public const int STATUS_SXS_PROCESS_DEFAULT_ALREADY_SET = unchecked((int)0xC015000E);

        /// <summary>
        /// The activation context being deactivated is not the most recently activated one.
        /// </summary>
        public const int STATUS_SXS_EARLY_DEACTIVATION = unchecked((int)0xC015000F); // winnt

        /// <summary>
        /// The activation context being deactivated is not active for the current thread of execution.
        /// </summary>
        public const int STATUS_SXS_INVALID_DEACTIVATION = unchecked((int)0xC0150010); // winnt

        /// <summary>
        /// The activation context being deactivated has already been deactivated.
        /// </summary>
        public const int STATUS_SXS_MULTIPLE_DEACTIVATION = unchecked((int)0xC0150011);

        /// <summary>
        /// The activation context of system default assembly could not be generated.
        /// </summary>
        public const int STATUS_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY = unchecked((int)0xC0150012);

        /// <summary>
        /// A component used by the isolation facility has requested to terminate the process.
        /// </summary>
        public const int STATUS_SXS_PROCESS_TERMINATION_REQUESTED = unchecked((int)0xC0150013);

        /// <summary>
        /// The activation context activation stack for the running thread of execution is corrupt.
        /// </summary>
        public const int STATUS_SXS_CORRUPT_ACTIVATION_STACK = unchecked((int)0xC0150014);

        /// <summary>
        /// The application isolation metadata for this process or thread has become corrupt.
        /// </summary>
        public const int STATUS_SXS_CORRUPTION = unchecked((int)0xC0150015);

        /// <summary>
        /// The value of an attribute in an identity is not within the legal range.
        /// </summary>
        public const int STATUS_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE = unchecked((int)0xC0150016);

        /// <summary>
        /// The name of an attribute in an identity is not within the legal range.
        /// </summary>
        public const int STATUS_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME = unchecked((int)0xC0150017);

        /// <summary>
        /// An identity contains two definitions for the same attribute.
        /// </summary>
        public const int STATUS_SXS_IDENTITY_DUPLICATE_ATTRIBUTE = unchecked((int)0xC0150018);

        /// <summary>
        /// The identity string is malformed. This may be due to a trailing comma, more than two unnamed attributes, missing attribute name or missing attribute value.
        /// </summary>
        public const int STATUS_SXS_IDENTITY_PARSE_ERROR = unchecked((int)0xC0150019);

        /// <summary>
        /// The component store has been corrupted.
        /// </summary>
        public const int STATUS_SXS_COMPONENT_STORE_CORRUPT = unchecked((int)0xC015001A);

        /// <summary>
        /// A component's file does not match the verification information present in the component manifest.
        /// </summary>
        public const int STATUS_SXS_FILE_HASH_MISMATCH = unchecked((int)0xC015001B);

        /// <summary>
        /// The identities of the manifests are identical but their contents are different.
        /// </summary>
        public const int STATUS_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT = unchecked((int)0xC015001C);

        /// <summary>
        /// The component identities are different.
        /// </summary>
        public const int STATUS_SXS_IDENTITIES_DIFFERENT = unchecked((int)0xC015001D);

        /// <summary>
        /// The assembly is not a deployment.
        /// </summary>
        public const int STATUS_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT = unchecked((int)0xC015001E);

        /// <summary>
        /// The file is not a part of the assembly.
        /// </summary>
        public const int STATUS_SXS_FILE_NOT_PART_OF_ASSEMBLY = unchecked((int)0xC015001F);

        /// <summary>
        /// An advanced installer failed during setup or servicing.
        /// </summary>
        public const int STATUS_ADVANCED_INSTALLER_FAILED = unchecked((int)0xC0150020);

        /// <summary>
        /// The character encoding in the XML declaration did not match the encoding used in the document.
        /// </summary>
        public const int STATUS_XML_ENCODING_MISMATCH = unchecked((int)0xC0150021);

        /// <summary>
        /// The size of the manifest exceeds the maximum allowed.
        /// </summary>
        public const int STATUS_SXS_MANIFEST_TOO_BIG = unchecked((int)0xC0150022);

        /// <summary>
        /// The setting is not registered.
        /// </summary>
        public const int STATUS_SXS_SETTING_NOT_REGISTERED = unchecked((int)0xC0150023);

        /// <summary>
        /// One or more required members of the transaction are not present.
        /// </summary>
        public const int STATUS_SXS_TRANSACTION_CLOSURE_INCOMPLETE = unchecked((int)0xC0150024);

        /// <summary>
        /// The SMI primitive installer failed during setup or servicing.
        /// </summary>
        public const int STATUS_SMI_PRIMITIVE_INSTALLER_FAILED = unchecked((int)0xC0150025);

        /// <summary>
        /// A generic command executable returned a result that indicates failure.
        /// </summary>
        public const int STATUS_GENERIC_COMMAND_FAILED = unchecked((int)0xC0150026);

        /// <summary>
        /// A component is missing file verification information in its manifest.
        /// </summary>
        public const int STATUS_SXS_FILE_HASH_MISSING = unchecked((int)0xC0150027);


        //
        //  Cluster error values
        //

        /// <summary>
        /// The cluster node is not valid.
        /// </summary>
        public const int STATUS_CLUSTER_INVALID_NODE = unchecked((int)0xC0130001);

        /// <summary>
        /// The cluster node already exists.
        /// </summary>
        public const int STATUS_CLUSTER_NODE_EXISTS = unchecked((int)0xC0130002);

        /// <summary>
        /// A node is in the process of joining the cluster.
        /// </summary>
        public const int STATUS_CLUSTER_JOIN_IN_PROGRESS = unchecked((int)0xC0130003);

        /// <summary>
        /// The cluster node was not found.
        /// </summary>
        public const int STATUS_CLUSTER_NODE_NOT_FOUND = unchecked((int)0xC0130004);

        /// <summary>
        /// The cluster local node information was not found.
        /// </summary>
        public const int STATUS_CLUSTER_LOCAL_NODE_NOT_FOUND = unchecked((int)0xC0130005);

        /// <summary>
        /// The cluster network already exists.
        /// </summary>
        public const int STATUS_CLUSTER_NETWORK_EXISTS = unchecked((int)0xC0130006);

        /// <summary>
        /// The cluster network was not found.
        /// </summary>
        public const int STATUS_CLUSTER_NETWORK_NOT_FOUND = unchecked((int)0xC0130007);

        /// <summary>
        /// The cluster network interface already exists.
        /// </summary>
        public const int STATUS_CLUSTER_NETINTERFACE_EXISTS = unchecked((int)0xC0130008);

        /// <summary>
        /// The cluster network interface was not found.
        /// </summary>
        public const int STATUS_CLUSTER_NETINTERFACE_NOT_FOUND = unchecked((int)0xC0130009);

        /// <summary>
        /// The cluster request is not valid for this object.
        /// </summary>
        public const int STATUS_CLUSTER_INVALID_REQUEST = unchecked((int)0xC013000A);

        /// <summary>
        /// The cluster network provider is not valid.
        /// </summary>
        public const int STATUS_CLUSTER_INVALID_NETWORK_PROVIDER = unchecked((int)0xC013000B);

        /// <summary>
        /// The cluster node is down.
        /// </summary>
        public const int STATUS_CLUSTER_NODE_DOWN = unchecked((int)0xC013000C);

        /// <summary>
        /// The cluster node is not reachable.
        /// </summary>
        public const int STATUS_CLUSTER_NODE_UNREACHABLE = unchecked((int)0xC013000D);

        /// <summary>
        /// The cluster node is not a member of the cluster.
        /// </summary>
        public const int STATUS_CLUSTER_NODE_NOT_MEMBER = unchecked((int)0xC013000E);

        /// <summary>
        /// A cluster join operation is not in progress.
        /// </summary>
        public const int STATUS_CLUSTER_JOIN_NOT_IN_PROGRESS = unchecked((int)0xC013000F);

        /// <summary>
        /// The cluster network is not valid.
        /// </summary>
        public const int STATUS_CLUSTER_INVALID_NETWORK = unchecked((int)0xC0130010);

        /// <summary>
        /// No network adapters are available.
        /// </summary>
        public const int STATUS_CLUSTER_NO_NET_ADAPTERS = unchecked((int)0xC0130011);

        /// <summary>
        /// The cluster node is up.
        /// </summary>
        public const int STATUS_CLUSTER_NODE_UP = unchecked((int)0xC0130012);

        /// <summary>
        /// The cluster node is paused.
        /// </summary>
        public const int STATUS_CLUSTER_NODE_PAUSED = unchecked((int)0xC0130013);

        /// <summary>
        /// The cluster node is not paused.
        /// </summary>
        public const int STATUS_CLUSTER_NODE_NOT_PAUSED = unchecked((int)0xC0130014);

        /// <summary>
        /// No cluster security context is available.
        /// </summary>
        public const int STATUS_CLUSTER_NO_SECURITY_CONTEXT = unchecked((int)0xC0130015);

        /// <summary>
        /// The cluster network is not configured for internal cluster communication.
        /// </summary>
        public const int STATUS_CLUSTER_NETWORK_NOT_INTERNAL = unchecked((int)0xC0130016);

        /// <summary>
        /// The cluster node has been poisoned.
        /// </summary>
        public const int STATUS_CLUSTER_POISONED = unchecked((int)0xC0130017);

        /// <summary>
        /// The path does not belong to a cluster shared volume.
        /// </summary>
        public const int STATUS_CLUSTER_NON_CSV_PATH = unchecked((int)0xC0130018);

        /// <summary>
        /// The cluster shared volume is not locally mounted.
        /// </summary>
        public const int STATUS_CLUSTER_CSV_VOLUME_NOT_LOCAL = unchecked((int)0xC0130019);

        /// <summary>
        /// The operation has failed because read oplock break is in progress.
        /// </summary>
        public const int STATUS_CLUSTER_CSV_READ_OPLOCK_BREAK_IN_PROGRESS = unchecked((int)0xC0130020);

        /// <summary>
        /// The operation has failed. CSVFS has to pause and refresh information.
        /// </summary>
        public const int STATUS_CLUSTER_CSV_AUTO_PAUSE_ERROR = unchecked((int)0xC0130021);

        /// <summary>
        /// The operation has failed. CSVFS does not allow block i/o in redirected mode.
        /// </summary>
        public const int STATUS_CLUSTER_CSV_REDIRECTED = unchecked((int)0xC0130022);

        /// <summary>
        /// The operation has failed. CSVFS is not in redirected mode.
        /// </summary>
        public const int STATUS_CLUSTER_CSV_NOT_REDIRECTED = unchecked((int)0xC0130023);

        /// <summary>
        /// CSVFS is failing operation because it is in draining state.
        /// </summary>
        public const int STATUS_CLUSTER_CSV_VOLUME_DRAINING = unchecked((int)0xC0130024);

        /// <summary>
        /// The operation has failed because snapshot creation is in progress.
        /// </summary>
        public const int STATUS_CLUSTER_CSV_SNAPSHOT_CREATION_IN_PROGRESS = unchecked((int)0xC0130025);

        /// <summary>
        /// The operation has succeeded on the down level file system, but CSV is failing it because it is in draining state.
        /// </summary>
        public const int STATUS_CLUSTER_CSV_VOLUME_DRAINING_SUCCEEDED_DOWNLEVEL = unchecked((int)0xC0130026);

        /// <summary>
        /// Volsnap on the coordinating node returned an error indicating that there is no snapshots on this volume.
        /// </summary>
        public const int STATUS_CLUSTER_CSV_NO_SNAPSHOTS = unchecked((int)0xC0130027);

        /// <summary>
        /// The operation has failed because CSV volume was not able to recover in time specified on this file object.
        /// </summary>
        public const int STATUS_CSV_IO_PAUSE_TIMEOUT = unchecked((int)0xC0130028);

        /// <summary>
        /// The operation has failed because CSV has invalidated this file object.
        /// </summary>
        public const int STATUS_CLUSTER_CSV_INVALID_HANDLE = unchecked((int)0xC0130029);

        /// <summary>
        /// This operation is supported only on the CSV coordinator node.
        /// </summary>
        public const int STATUS_CLUSTER_CSV_SUPPORTED_ONLY_ON_COORDINATOR = unchecked((int)0xC0130030);

        /// <summary>
        /// Cluster CAM has detected that somone is trying to reply ticket.
        /// </summary>
        public const int STATUS_CLUSTER_CAM_TICKET_REPLAY_DETECTED = unchecked((int)0xC0130031);


        //
        //  Transaction Manager error values
        //

        /// <summary>
        /// The function attempted to use a name that is reserved for use by another transaction.
        /// </summary>
        public const int STATUS_TRANSACTIONAL_CONFLICT = unchecked((int)0xC0190001);

        /// <summary>
        /// The transaction handle associated with this operation is not valid.
        /// </summary>
        public const int STATUS_INVALID_TRANSACTION = unchecked((int)0xC0190002);

        /// <summary>
        /// The requested operation was made in the context of a transaction that is no longer active.
        /// </summary>
        public const int STATUS_TRANSACTION_NOT_ACTIVE = unchecked((int)0xC0190003);

        /// <summary>
        /// The Transaction Manager was unable to be successfully initialized. Transacted operations are not supported.
        /// </summary>
        public const int STATUS_TM_INITIALIZATION_FAILED = unchecked((int)0xC0190004);

        /// <summary>
        /// Transaction support within the specified resource manager is not started or was shut down due to an error.
        /// </summary>
        public const int STATUS_RM_NOT_ACTIVE = unchecked((int)0xC0190005);

        /// <summary>
        /// The metadata of the RM has been corrupted. The RM will not function.
        /// </summary>
        public const int STATUS_RM_METADATA_CORRUPT = unchecked((int)0xC0190006);

        /// <summary>
        /// The resource manager has attempted to prepare a transaction that it has not successfully joined.
        /// </summary>
        public const int STATUS_TRANSACTION_NOT_JOINED = unchecked((int)0xC0190007);

        /// <summary>
        /// The specified directory does not contain a file system resource manager.
        /// </summary>
        public const int STATUS_DIRECTORY_NOT_RM = unchecked((int)0xC0190008);

        /// <summary>
        /// The log could not be set to the requested size.
        /// </summary>
        public const int STATUS_COULD_NOT_RESIZE_LOG = unchecked((int)0x80190009);

        /// <summary>
        /// The remote server or share does not support transacted file operations.
        /// </summary>
        public const int STATUS_TRANSACTIONS_UNSUPPORTED_REMOTE = unchecked((int)0xC019000A);

        /// <summary>
        /// The requested log size for the file system resource manager is invalid.
        /// </summary>
        public const int STATUS_LOG_RESIZE_INVALID_SIZE = unchecked((int)0xC019000B);

        /// <summary>
        /// The remote server sent mismatching version number or Fid for a file opened with transactions.
        /// </summary>
        public const int STATUS_REMOTE_FILE_VERSION_MISMATCH = unchecked((int)0xC019000C);

        /// <summary>
        /// The RM tried to register a protocol that already exists.
        /// </summary>
        public const int STATUS_CRM_PROTOCOL_ALREADY_EXISTS = unchecked((int)0xC019000F);

        /// <summary>
        /// The attempt to propagate the Transaction failed.
        /// </summary>
        public const int STATUS_TRANSACTION_PROPAGATION_FAILED = unchecked((int)0xC0190010);

        /// <summary>
        /// The requested propagation protocol was not registered as a CRM.
        /// </summary>
        public const int STATUS_CRM_PROTOCOL_NOT_FOUND = unchecked((int)0xC0190011);

        /// <summary>
        /// The Transaction object already has a superior enlistment, and the caller attempted an operation that would have created a new superior. Only a single superior enlistment is allowed.
        /// </summary>
        public const int STATUS_TRANSACTION_SUPERIOR_EXISTS = unchecked((int)0xC0190012);

        /// <summary>
        /// The requested operation is not valid on the Transaction object in its current state.
        /// </summary>
        public const int STATUS_TRANSACTION_REQUEST_NOT_VALID = unchecked((int)0xC0190013);

        /// <summary>
        /// The caller has called a response API, but the response is not expected because the TM did not issue the corresponding request to the caller.
        /// </summary>
        public const int STATUS_TRANSACTION_NOT_REQUESTED = unchecked((int)0xC0190014);

        /// <summary>
        /// It is too late to perform the requested operation, since the Transaction has already been aborted.
        /// </summary>
        public const int STATUS_TRANSACTION_ALREADY_ABORTED = unchecked((int)0xC0190015);

        /// <summary>
        /// It is too late to perform the requested operation, since the Transaction has already been committed.
        /// </summary>
        public const int STATUS_TRANSACTION_ALREADY_COMMITTED = unchecked((int)0xC0190016);

        /// <summary>
        /// The buffer passed in to NtPushTransaction or NtPullTransaction is not in a valid format.
        /// </summary>
        public const int STATUS_TRANSACTION_INVALID_MARSHALL_BUFFER = unchecked((int)0xC0190017);

        /// <summary>
        /// The current transaction context associated with the thread is not a valid handle to a transaction object.
        /// </summary>
        public const int STATUS_CURRENT_TRANSACTION_NOT_VALID = unchecked((int)0xC0190018);

        /// <summary>
        /// An attempt to create space in the transactional resource manager's log failed. The failure status has been recorded in the event log.
        /// </summary>
        public const int STATUS_LOG_GROWTH_FAILED = unchecked((int)0xC0190019);

        /// <summary>
        /// The object (file, stream, link) corresponding to the handle has been deleted by a transaction savepoint rollback.
        /// </summary>
        public const int STATUS_OBJECT_NO_LONGER_EXISTS = unchecked((int)0xC0190021);

        /// <summary>
        /// The specified file miniversion was not found for this transacted file open.
        /// </summary>
        public const int STATUS_STREAM_MINIVERSION_NOT_FOUND = unchecked((int)0xC0190022);

        /// <summary>
        /// The specified file miniversion was found but has been invalidated. Most likely cause is a transaction savepoint rollback.
        /// </summary>
        public const int STATUS_STREAM_MINIVERSION_NOT_VALID = unchecked((int)0xC0190023);

        /// <summary>
        /// A miniversion may only be opened in the context of the transaction that created it.
        /// </summary>
        public const int STATUS_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION = unchecked((int)0xC0190024);

        /// <summary>
        /// It is not possible to open a miniversion with modify access.
        /// </summary>
        public const int STATUS_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT = unchecked((int)0xC0190025);

        /// <summary>
        /// It is not possible to create any more miniversions for this stream.
        /// </summary>
        public const int STATUS_CANT_CREATE_MORE_STREAM_MINIVERSIONS = unchecked((int)0xC0190026);

        /// <summary>
        /// The handle has been invalidated by a transaction. The most likely cause is the presence of memory mapping on a file or an open handle when the transaction ended or rolled back to savepoint.
        /// </summary>
        public const int STATUS_HANDLE_NO_LONGER_VALID = unchecked((int)0xC0190028);

        /// <summary>
        /// There is no transaction metadata on the file.
        /// </summary>
        public const int STATUS_NO_TXF_METADATA = unchecked((int)0x80190029);

        /// <summary>
        /// The log data is corrupt.
        /// </summary>
        public const int STATUS_LOG_CORRUPTION_DETECTED = unchecked((int)0xC0190030);

        /// <summary>
        /// The file can't be recovered because there is a handle still open on it.
        /// </summary>
        public const int STATUS_CANT_RECOVER_WITH_HANDLE_OPEN = unchecked((int)0x80190031);

        /// <summary>
        /// The transaction outcome is unavailable because the resource manager responsible for it has disconnected.
        /// </summary>
        public const int STATUS_RM_DISCONNECTED = unchecked((int)0xC0190032);

        /// <summary>
        /// The request was rejected because the enlistment in question is not a superior enlistment.
        /// </summary>
        public const int STATUS_ENLISTMENT_NOT_SUPERIOR = unchecked((int)0xC0190033);

        /// <summary>
        /// The transactional resource manager is already consistent. Recovery is not needed.
        /// </summary>
        public const int STATUS_RECOVERY_NOT_NEEDED = 0x40190034;

        /// <summary>
        /// The transactional resource manager has already been started.
        /// </summary>
        public const int STATUS_RM_ALREADY_STARTED = 0x40190035;

        /// <summary>
        /// The file cannot be opened transactionally, because its identity depends on the outcome of an unresolved transaction.
        /// </summary>
        public const int STATUS_FILE_IDENTITY_NOT_PERSISTENT = unchecked((int)0xC0190036);

        /// <summary>
        /// The operation cannot be performed because another transaction is depending on the fact that this property will not change.
        /// </summary>
        public const int STATUS_CANT_BREAK_TRANSACTIONAL_DEPENDENCY = unchecked((int)0xC0190037);

        /// <summary>
        /// The operation would involve a single file with two transactional resource managers and is therefore not allowed.
        /// </summary>
        public const int STATUS_CANT_CROSS_RM_BOUNDARY = unchecked((int)0xC0190038);

        /// <summary>
        /// The $Txf directory must be empty for this operation to succeed.
        /// </summary>
        public const int STATUS_TXF_DIR_NOT_EMPTY = unchecked((int)0xC0190039);

        /// <summary>
        /// The operation would leave a transactional resource manager in an inconsistent state and is therefore not allowed.
        /// </summary>
        public const int STATUS_INDOUBT_TRANSACTIONS_EXIST = unchecked((int)0xC019003A);

        /// <summary>
        /// The operation could not be completed because the transaction manager does not have a log.
        /// </summary>
        public const int STATUS_TM_VOLATILE = unchecked((int)0xC019003B);

        /// <summary>
        /// A rollback could not be scheduled because a previously scheduled rollback has already executed or been queued for execution.
        /// </summary>
        public const int STATUS_ROLLBACK_TIMER_EXPIRED = unchecked((int)0xC019003C);

        /// <summary>
        /// The transactional metadata attribute on the file or directory %hs is corrupt and unreadable.
        /// </summary>
        public const int STATUS_TXF_ATTRIBUTE_CORRUPT = unchecked((int)0xC019003D);

        /// <summary>
        /// The encryption operation could not be completed because a transaction is active.
        /// </summary>
        public const int STATUS_EFS_NOT_ALLOWED_IN_TRANSACTION = unchecked((int)0xC019003E);

        /// <summary>
        /// This object is not allowed to be opened in a transaction.
        /// </summary>
        public const int STATUS_TRANSACTIONAL_OPEN_NOT_ALLOWED = unchecked((int)0xC019003F);

        /// <summary>
        /// Memory mapping (creating a mapped section) a remote file under a transaction is not supported.
        /// </summary>
        public const int STATUS_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE = unchecked((int)0xC0190040);

        /// <summary>
        /// Transaction metadata is already present on this file and cannot be superseded.
        /// </summary>
        public const int STATUS_TXF_METADATA_ALREADY_PRESENT = unchecked((int)0x80190041);

        /// <summary>
        /// A transaction scope could not be entered because the scope handler has not been initialized.
        /// </summary>
        public const int STATUS_TRANSACTION_SCOPE_CALLBACKS_NOT_SET = unchecked((int)0x80190042);

        /// <summary>
        /// Promotion was required in order to allow the resource manager to enlist, but the transaction was set to disallow it.
        /// </summary>
        public const int STATUS_TRANSACTION_REQUIRED_PROMOTION = unchecked((int)0xC0190043);

        /// <summary>
        /// This file is open for modification in an unresolved transaction and may be opened for execute only by a transacted reader.
        /// </summary>
        public const int STATUS_CANNOT_EXECUTE_FILE_IN_TRANSACTION = unchecked((int)0xC0190044);

        /// <summary>
        /// The request to thaw frozen transactions was ignored because transactions had not previously been frozen.
        /// </summary>
        public const int STATUS_TRANSACTIONS_NOT_FROZEN = unchecked((int)0xC0190045);

        /// <summary>
        /// Transactions cannot be frozen because a freeze is already in progress.
        /// </summary>
        public const int STATUS_TRANSACTION_FREEZE_IN_PROGRESS = unchecked((int)0xC0190046);

        /// <summary>
        /// The target volume is not a snapshot volume. This operation is only valid on a volume mounted as a snapshot.
        /// </summary>
        public const int STATUS_NOT_SNAPSHOT_VOLUME = unchecked((int)0xC0190047);

        /// <summary>
        /// The savepoint operation failed because files are open on the transaction. This is not permitted.
        /// </summary>
        public const int STATUS_NO_SAVEPOINT_WITH_OPEN_FILES = unchecked((int)0xC0190048);

        /// <summary>
        /// The sparse operation could not be completed because a transaction is active on the file.
        /// </summary>
        public const int STATUS_SPARSE_NOT_ALLOWED_IN_TRANSACTION = unchecked((int)0xC0190049);

        /// <summary>
        /// The call to create a TransactionManager object failed because the Tm Identity stored in the logfile does not match the Tm Identity that was passed in as an argument.
        /// </summary>
        public const int STATUS_TM_IDENTITY_MISMATCH = unchecked((int)0xC019004A);

        /// <summary>
        /// I/O was attempted on a section object that has been floated as a result of a transaction ending. There is no valid data.
        /// </summary>
        public const int STATUS_FLOATED_SECTION = unchecked((int)0xC019004B);

        /// <summary>
        /// The transactional resource manager cannot currently accept transacted work due to a transient condition such as low resources.
        /// </summary>
        public const int STATUS_CANNOT_ACCEPT_TRANSACTED_WORK = unchecked((int)0xC019004C);

        /// <summary>
        /// The transactional resource manager had too many tranactions outstanding that could not be aborted. The transactional resource manger has been shut down.
        /// </summary>
        public const int STATUS_CANNOT_ABORT_TRANSACTIONS = unchecked((int)0xC019004D);

        /// <summary>
        /// The specified Transaction was unable to be opened, because it was not found.
        /// </summary>
        public const int STATUS_TRANSACTION_NOT_FOUND = unchecked((int)0xC019004E);

        /// <summary>
        /// The specified ResourceManager was unable to be opened, because it was not found.
        /// </summary>
        public const int STATUS_RESOURCEMANAGER_NOT_FOUND = unchecked((int)0xC019004F);

        /// <summary>
        /// The specified Enlistment was unable to be opened, because it was not found.
        /// </summary>
        public const int STATUS_ENLISTMENT_NOT_FOUND = unchecked((int)0xC0190050);

        /// <summary>
        /// The specified TransactionManager was unable to be opened, because it was not found.
        /// </summary>
        public const int STATUS_TRANSACTIONMANAGER_NOT_FOUND = unchecked((int)0xC0190051);

        /// <summary>
        /// The object specified could not be created or opened, because its associated TransactionManager is not online.  The TransactionManager must be brought fully Online by calling RecoverTransactionManager to recover to the end of its LogFile before objects in its Transaction or ResourceManager namespaces can be opened.  In addition, errors in writing records to its LogFile can cause a TransactionManager to go offline.
        /// </summary>
        public const int STATUS_TRANSACTIONMANAGER_NOT_ONLINE = unchecked((int)0xC0190052);

        /// <summary>
        /// The specified TransactionManager was unable to create the objects contained in its logfile in the Ob namespace. Therefore, the TransactionManager was unable to recover.
        /// </summary>
        public const int STATUS_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION = unchecked((int)0xC0190053);

        /// <summary>
        /// The call to create a superior Enlistment on this Transaction object could not be completed, because the Transaction object specified for the enlistment is a subordinate branch of the Transaction. Only the root of the Transaction can be enlisted on as a superior.
        /// </summary>
        public const int STATUS_TRANSACTION_NOT_ROOT = unchecked((int)0xC0190054);

        /// <summary>
        /// Because the associated transaction manager or resource manager has been closed, the handle is no longer valid.
        /// </summary>
        public const int STATUS_TRANSACTION_OBJECT_EXPIRED = unchecked((int)0xC0190055);

        /// <summary>
        /// The compression operation could not be completed because a transaction is active on the file.
        /// </summary>
        public const int STATUS_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION = unchecked((int)0xC0190056);

        /// <summary>
        /// The specified operation could not be performed on this Superior enlistment, because the enlistment was not created with the corresponding completion response in the NotificationMask.
        /// </summary>
        public const int STATUS_TRANSACTION_RESPONSE_NOT_ENLISTED = unchecked((int)0xC0190057);

        /// <summary>
        /// The specified operation could not be performed, because the record that would be logged was too long. This can occur because of two conditions:  either there are too many Enlistments on this Transaction, or the combined RecoveryInformation being logged on behalf of those Enlistments is too long.
        /// </summary>
        public const int STATUS_TRANSACTION_RECORD_TOO_LONG = unchecked((int)0xC0190058);

        /// <summary>
        /// The link tracking operation could not be completed because a transaction is active.
        /// </summary>
        public const int STATUS_NO_LINK_TRACKING_IN_TRANSACTION = unchecked((int)0xC0190059);

        /// <summary>
        /// This operation cannot be performed in a transaction.
        /// </summary>
        public const int STATUS_OPERATION_NOT_SUPPORTED_IN_TRANSACTION = unchecked((int)0xC019005A);

        /// <summary>
        /// The kernel transaction manager had to abort or forget the transaction because it blocked forward progress.
        /// </summary>
        public const int STATUS_TRANSACTION_INTEGRITY_VIOLATED = unchecked((int)0xC019005B);

        /// <summary>
        /// The TransactionManager identity that was supplied did not match the one recorded in the TransactionManager's log file.
        /// </summary>
        public const int STATUS_TRANSACTIONMANAGER_IDENTITY_MISMATCH = unchecked((int)0xC019005C);

        /// <summary>
        /// This snapshot operation cannot continue because a transactional resource manager cannot be frozen in its current state.  Please try again.
        /// </summary>
        public const int STATUS_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT = unchecked((int)0xC019005D);

        /// <summary>
        /// The transaction cannot be enlisted on with the specified EnlistmentMask, because the transaction has already completed the PrePrepare phase.  In order to ensure correctness, the ResourceManager must switch to a write-through mode and cease caching data within this transaction.  Enlisting for only subsequent transaction phases may still succeed.
        /// </summary>
        public const int STATUS_TRANSACTION_MUST_WRITETHROUGH = unchecked((int)0xC019005E);

        /// <summary>
        /// The transaction does not have a superior enlistment.
        /// </summary>
        public const int STATUS_TRANSACTION_NO_SUPERIOR = unchecked((int)0xC019005F);

        /// <summary>
        /// The handle is no longer properly associated with its transaction.  It may have been opened in a transactional resource manager that was subsequently forced to restart.  Please close the handle and open a new one.
        /// </summary>
        public const int STATUS_EXPIRED_HANDLE = unchecked((int)0xC0190060);

        /// <summary>
        /// The specified operation could not be performed because the resource manager is not enlisted in the transaction.
        /// </summary>
        public const int STATUS_TRANSACTION_NOT_ENLISTED = unchecked((int)0xC0190061);


        //
        //  CLFS (common log file system) error values
        //

        /// <summary>
        /// Log service found an invalid log sector.
        /// </summary>
        public const int STATUS_LOG_SECTOR_INVALID = unchecked((int)0xC01A0001);

        /// <summary>
        /// Log service encountered a log sector with invalid block parity.
        /// </summary>
        public const int STATUS_LOG_SECTOR_PARITY_INVALID = unchecked((int)0xC01A0002);

        /// <summary>
        /// Log service encountered a remapped log sector.
        /// </summary>
        public const int STATUS_LOG_SECTOR_REMAPPED = unchecked((int)0xC01A0003);

        /// <summary>
        /// Log service encountered a partial or incomplete log block.
        /// </summary>
        public const int STATUS_LOG_BLOCK_INCOMPLETE = unchecked((int)0xC01A0004);

        /// <summary>
        /// Log service encountered an attempt access data outside the active log range.
        /// </summary>
        public const int STATUS_LOG_INVALID_RANGE = unchecked((int)0xC01A0005);

        /// <summary>
        /// Log service user log marshalling buffers are exhausted.
        /// </summary>
        public const int STATUS_LOG_BLOCKS_EXHAUSTED = unchecked((int)0xC01A0006);

        /// <summary>
        /// Log service encountered an attempt read from a marshalling area with an invalid read context.
        /// </summary>
        public const int STATUS_LOG_READ_CONTEXT_INVALID = unchecked((int)0xC01A0007);

        /// <summary>
        /// Log service encountered an invalid log restart area.
        /// </summary>
        public const int STATUS_LOG_RESTART_INVALID = unchecked((int)0xC01A0008);

        /// <summary>
        /// Log service encountered an invalid log block version.
        /// </summary>
        public const int STATUS_LOG_BLOCK_VERSION = unchecked((int)0xC01A0009);

        /// <summary>
        /// Log service encountered an invalid log block.
        /// </summary>
        public const int STATUS_LOG_BLOCK_INVALID = unchecked((int)0xC01A000A);

        /// <summary>
        /// Log service encountered an attempt to read the log with an invalid read mode.
        /// </summary>
        public const int STATUS_LOG_READ_MODE_INVALID = unchecked((int)0xC01A000B);

        /// <summary>
        /// Log service encountered a log stream with no restart area.
        /// </summary>
        public const int STATUS_LOG_NO_RESTART = 0x401A000C;

        /// <summary>
        /// Log service encountered a corrupted metadata file.
        /// </summary>
        public const int STATUS_LOG_METADATA_CORRUPT = unchecked((int)0xC01A000D);

        /// <summary>
        /// Log service encountered a metadata file that could not be created by the log file system.
        /// </summary>
        public const int STATUS_LOG_METADATA_INVALID = unchecked((int)0xC01A000E);

        /// <summary>
        /// Log service encountered a metadata file with inconsistent data.
        /// </summary>
        public const int STATUS_LOG_METADATA_INCONSISTENT = unchecked((int)0xC01A000F);

        /// <summary>
        /// Log service encountered an attempt to erroneously allocate or dispose reservation space.
        /// </summary>
        public const int STATUS_LOG_RESERVATION_INVALID = unchecked((int)0xC01A0010);

        /// <summary>
        /// Log service cannot delete log file or file system container.
        /// </summary>
        public const int STATUS_LOG_CANT_DELETE = unchecked((int)0xC01A0011);

        /// <summary>
        /// Log service has reached the maximum allowable containers allocated to a log file.
        /// </summary>
        public const int STATUS_LOG_CONTAINER_LIMIT_EXCEEDED = unchecked((int)0xC01A0012);

        /// <summary>
        /// Log service has attempted to read or write backwards past the start of the log.
        /// </summary>
        public const int STATUS_LOG_START_OF_LOG = unchecked((int)0xC01A0013);

        /// <summary>
        /// Log policy could not be installed because a policy of the same type is already present.
        /// </summary>
        public const int STATUS_LOG_POLICY_ALREADY_INSTALLED = unchecked((int)0xC01A0014);

        /// <summary>
        /// Log policy in question was not installed at the time of the request.
        /// </summary>
        public const int STATUS_LOG_POLICY_NOT_INSTALLED = unchecked((int)0xC01A0015);

        /// <summary>
        /// The installed set of policies on the log is invalid.
        /// </summary>
        public const int STATUS_LOG_POLICY_INVALID = unchecked((int)0xC01A0016);

        /// <summary>
        /// A policy on the log in question prevented the operation from completing.
        /// </summary>
        public const int STATUS_LOG_POLICY_CONFLICT = unchecked((int)0xC01A0017);

        /// <summary>
        /// Log space cannot be reclaimed because the log is pinned by the archive tail.
        /// </summary>
        public const int STATUS_LOG_PINNED_ARCHIVE_TAIL = unchecked((int)0xC01A0018);

        /// <summary>
        /// Log record is not a record in the log file.
        /// </summary>
        public const int STATUS_LOG_RECORD_NONEXISTENT = unchecked((int)0xC01A0019);

        /// <summary>
        /// Number of reserved log records or the adjustment of the number of reserved log records is invalid.
        /// </summary>
        public const int STATUS_LOG_RECORDS_RESERVED_INVALID = unchecked((int)0xC01A001A);

        /// <summary>
        /// Reserved log space or the adjustment of the log space is invalid.
        /// </summary>
        public const int STATUS_LOG_SPACE_RESERVED_INVALID = unchecked((int)0xC01A001B);

        /// <summary>
        /// A new or existing archive tail or base of the active log is invalid.
        /// </summary>
        public const int STATUS_LOG_TAIL_INVALID = unchecked((int)0xC01A001C);

        /// <summary>
        /// Log space is exhausted.
        /// </summary>
        public const int STATUS_LOG_FULL = unchecked((int)0xC01A001D);

        /// <summary>
        /// Log is multiplexed, no direct writes to the physical log is allowed.
        /// </summary>
        public const int STATUS_LOG_MULTIPLEXED = unchecked((int)0xC01A001E);

        /// <summary>
        /// The operation failed because the log is a dedicated log.
        /// </summary>
        public const int STATUS_LOG_DEDICATED = unchecked((int)0xC01A001F);

        /// <summary>
        /// The operation requires an archive context.
        /// </summary>
        public const int STATUS_LOG_ARCHIVE_NOT_IN_PROGRESS = unchecked((int)0xC01A0020);

        /// <summary>
        /// Log archival is in progress.
        /// </summary>
        public const int STATUS_LOG_ARCHIVE_IN_PROGRESS = unchecked((int)0xC01A0021);

        /// <summary>
        /// The operation requires a non-ephemeral log, but the log is ephemeral.
        /// </summary>
        public const int STATUS_LOG_EPHEMERAL = unchecked((int)0xC01A0022);

        /// <summary>
        /// The log must have at least two containers before it can be read from or written to.
        /// </summary>
        public const int STATUS_LOG_NOT_ENOUGH_CONTAINERS = unchecked((int)0xC01A0023);

        /// <summary>
        /// A log client has already registered on the stream.
        /// </summary>
        public const int STATUS_LOG_CLIENT_ALREADY_REGISTERED = unchecked((int)0xC01A0024);

        /// <summary>
        /// A log client has not been registered on the stream.
        /// </summary>
        public const int STATUS_LOG_CLIENT_NOT_REGISTERED = unchecked((int)0xC01A0025);

        /// <summary>
        /// A request has already been made to handle the log full condition.
        /// </summary>
        public const int STATUS_LOG_FULL_HANDLER_IN_PROGRESS = unchecked((int)0xC01A0026);

        /// <summary>
        /// Log service encountered an error when attempting to read from a log container.
        /// </summary>
        public const int STATUS_LOG_CONTAINER_READ_FAILED = unchecked((int)0xC01A0027);

        /// <summary>
        /// Log service encountered an error when attempting to write to a log container.
        /// </summary>
        public const int STATUS_LOG_CONTAINER_WRITE_FAILED = unchecked((int)0xC01A0028);

        /// <summary>
        /// Log service encountered an error when attempting open a log container.
        /// </summary>
        public const int STATUS_LOG_CONTAINER_OPEN_FAILED = unchecked((int)0xC01A0029);

        /// <summary>
        /// Log service encountered an invalid container state when attempting a requested action.
        /// </summary>
        public const int STATUS_LOG_CONTAINER_STATE_INVALID = unchecked((int)0xC01A002A);

        /// <summary>
        /// Log service is not in the correct state to perform a requested action.
        /// </summary>
        public const int STATUS_LOG_STATE_INVALID = unchecked((int)0xC01A002B);

        /// <summary>
        /// Log space cannot be reclaimed because the log is pinned.
        /// </summary>
        public const int STATUS_LOG_PINNED = unchecked((int)0xC01A002C);

        /// <summary>
        /// Log metadata flush failed.
        /// </summary>
        public const int STATUS_LOG_METADATA_FLUSH_FAILED = unchecked((int)0xC01A002D);

        /// <summary>
        /// Security on the log and its containers is inconsistent.
        /// </summary>
        public const int STATUS_LOG_INCONSISTENT_SECURITY = unchecked((int)0xC01A002E);

        /// <summary>
        /// Records were appended to the log or reservation changes were made, but the log could not be flushed.
        /// </summary>
        public const int STATUS_LOG_APPENDED_FLUSH_FAILED = unchecked((int)0xC01A002F);

        /// <summary>
        /// The log is pinned due to reservation consuming most of the log space. Free some reserved records to make space available.
        /// </summary>
        public const int STATUS_LOG_PINNED_RESERVATION = unchecked((int)0xC01A0030);


        //
        // XDDM Video Facility Error codes (videoprt.sys)
        //

        /// <summary>
        /// {Display Driver Stopped Responding}
        /// The %hs display driver has stopped working normally. Save your work and reboot the system to restore full display functionality. The next time you reboot the machine a dialog will be displayed giving you a chance to upload data about this failure to Microsoft.
        /// </summary>
        public const int STATUS_VIDEO_HUNG_DISPLAY_DRIVER_THREAD = unchecked((int)0xC01B00EA);

        /// <summary>
        /// {Display Driver Stopped Responding and recovered}
        /// The %hs display driver has stopped working normally. The recovery had been performed.
        /// </summary>
        public const int STATUS_VIDEO_HUNG_DISPLAY_DRIVER_THREAD_RECOVERED = unchecked((int)0x801B00EB);

        /// <summary>
        /// {Display Driver Recovered From Failure}
        /// The %hs display driver has detected and recovered from a failure. Some graphical operations may have failed. The next time you reboot the machine a dialog will be displayed giving you a chance to upload data about this failure to Microsoft.
        /// </summary>
        public const int STATUS_VIDEO_DRIVER_DEBUG_REPORT_REQUEST = 0x401B00EC;


        //
        // Monitor Facility Error codes (monitor.sys)
        //

        /// <summary>
        /// Monitor descriptor could not be obtained.
        /// </summary>
        public const int STATUS_MONITOR_NO_DESCRIPTOR = unchecked((int)0xC01D0001);

        /// <summary>
        /// Format of the obtained monitor descriptor is not supported by this release.
        /// </summary>
        public const int STATUS_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT = unchecked((int)0xC01D0002);

        /// <summary>
        /// Checksum of the obtained monitor descriptor is invalid.
        /// </summary>
        public const int STATUS_MONITOR_INVALID_DESCRIPTOR_CHECKSUM = unchecked((int)0xC01D0003);

        /// <summary>
        /// Monitor descriptor contains an invalid standard timing block.
        /// </summary>
        public const int STATUS_MONITOR_INVALID_STANDARD_TIMING_BLOCK = unchecked((int)0xC01D0004);

        /// <summary>
        /// WMI data block registration failed for one of the MSMonitorClass WMI subclasses.
        /// </summary>
        public const int STATUS_MONITOR_WMI_DATABLOCK_REGISTRATION_FAILED = unchecked((int)0xC01D0005);

        /// <summary>
        /// Provided monitor descriptor block is either corrupted or does not contain monitor's detailed serial number.
        /// </summary>
        public const int STATUS_MONITOR_INVALID_SERIAL_NUMBER_MONDSC_BLOCK = unchecked((int)0xC01D0006);

        /// <summary>
        /// Provided monitor descriptor block is either corrupted or does not contain monitor's user friendly name.
        /// </summary>
        public const int STATUS_MONITOR_INVALID_USER_FRIENDLY_MONDSC_BLOCK = unchecked((int)0xC01D0007);

        /// <summary>
        /// There is no monitor descriptor data at the specified (offset, size) region.
        /// </summary>
        public const int STATUS_MONITOR_NO_MORE_DESCRIPTOR_DATA = unchecked((int)0xC01D0008);

        /// <summary>
        /// Monitor descriptor contains an invalid detailed timing block.
        /// </summary>
        public const int STATUS_MONITOR_INVALID_DETAILED_TIMING_BLOCK = unchecked((int)0xC01D0009);

        /// <summary>
        /// Monitor descriptor contains invalid manufacture date.
        /// </summary>
        public const int STATUS_MONITOR_INVALID_MANUFACTURE_DATE = unchecked((int)0xC01D000A);


        //
        // Graphics Facility Error codes (dxg.sys, dxgkrnl.sys)
        //

        //
        //   Common Windows Graphics Kernel Subsystem status codes {0x0000..0x00ff}
        //
        /// <summary>
        /// Exclusive mode ownership is needed to create unmanaged primary allocation.
        /// </summary>
        public const int STATUS_GRAPHICS_NOT_EXCLUSIVE_MODE_OWNER = unchecked((int)0xC01E0000);

        /// <summary>
        /// The driver needs more DMA buffer space in order to complete the requested operation.
        /// </summary>
        public const int STATUS_GRAPHICS_INSUFFICIENT_DMA_BUFFER = unchecked((int)0xC01E0001);

        /// <summary>
        /// Specified display adapter handle is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_DISPLAY_ADAPTER = unchecked((int)0xC01E0002);

        /// <summary>
        /// Specified display adapter and all of its state has been reset.
        /// </summary>
        public const int STATUS_GRAPHICS_ADAPTER_WAS_RESET = unchecked((int)0xC01E0003);

        /// <summary>
        /// The driver stack doesn't match the expected driver model.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_DRIVER_MODEL = unchecked((int)0xC01E0004);

        /// <summary>
        /// Present happened but ended up into the changed desktop mode
        /// </summary>
        public const int STATUS_GRAPHICS_PRESENT_MODE_CHANGED = unchecked((int)0xC01E0005);

        /// <summary>
        /// Nothing to present due to desktop occlusion
        /// </summary>
        public const int STATUS_GRAPHICS_PRESENT_OCCLUDED = unchecked((int)0xC01E0006);

        /// <summary>
        /// Not able to present due to denial of desktop access
        /// </summary>
        public const int STATUS_GRAPHICS_PRESENT_DENIED = unchecked((int)0xC01E0007);

        /// <summary>
        /// Not able to present with color convertion
        /// </summary>
        public const int STATUS_GRAPHICS_CANNOTCOLORCONVERT = unchecked((int)0xC01E0008);

        /// <summary>
        /// The kernel driver detected a version mismatch between it and the user mode driver.
        /// </summary>
        public const int STATUS_GRAPHICS_DRIVER_MISMATCH = unchecked((int)0xC01E0009);

        /// <summary>
        /// Specified buffer is not big enough to contain entire requested dataset. Partial data populated upto the size of the buffer. Caller needs to provide buffer of size as specified in the partially populated buffer's content (interface specific).
        /// </summary>
        public const int STATUS_GRAPHICS_PARTIAL_DATA_POPULATED = 0x401E000A;

        /// <summary>
        /// Present redirection is disabled (desktop windowing management subsystem is off).
        /// </summary>
        public const int STATUS_GRAPHICS_PRESENT_REDIRECTION_DISABLED = unchecked((int)0xC01E000B);

        /// <summary>
        /// Previous exclusive VidPn source owner has released its ownership
        /// </summary>
        public const int STATUS_GRAPHICS_PRESENT_UNOCCLUDED = unchecked((int)0xC01E000C);

        /// <summary>
        /// Window DC is not available for presentation
        /// </summary>
        public const int STATUS_GRAPHICS_WINDOWDC_NOT_AVAILABLE = unchecked((int)0xC01E000D);

        /// <summary>
        /// Windowless present is disabled (desktop windowing management subsystem is off).
        /// </summary>
        public const int STATUS_GRAPHICS_WINDOWLESS_PRESENT_DISABLED = unchecked((int)0xC01E000E);

        //
        //   Video Memory Manager (VidMM) specific status codes {0x0100..0x01ff}
        //
        /// <summary>
        /// Not enough video memory available to complete the operation.
        /// </summary>
        public const int STATUS_GRAPHICS_NO_VIDEO_MEMORY = unchecked((int)0xC01E0100);

        /// <summary>
        /// Couldn't probe and lock the underlying memory of an allocation.
        /// </summary>
        public const int STATUS_GRAPHICS_CANT_LOCK_MEMORY = unchecked((int)0xC01E0101);

        /// <summary>
        /// The allocation is currently busy.
        /// </summary>
        public const int STATUS_GRAPHICS_ALLOCATION_BUSY = unchecked((int)0xC01E0102);

        /// <summary>
        /// An object being referenced has already reached the maximum reference count and can't be referenced any further.
        /// </summary>
        public const int STATUS_GRAPHICS_TOO_MANY_REFERENCES = unchecked((int)0xC01E0103);

        /// <summary>
        /// A problem couldn't be solved due to some currently existing condition. The problem should be tried again later.
        /// </summary>
        public const int STATUS_GRAPHICS_TRY_AGAIN_LATER = unchecked((int)0xC01E0104);

        /// <summary>
        /// A problem couldn't be solved due to some currently existing condition. The problem should be tried again immediately.
        /// </summary>
        public const int STATUS_GRAPHICS_TRY_AGAIN_NOW = unchecked((int)0xC01E0105);

        /// <summary>
        /// The allocation is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_ALLOCATION_INVALID = unchecked((int)0xC01E0106);

        /// <summary>
        /// No more unswizzling aperture are currently available.
        /// </summary>
        public const int STATUS_GRAPHICS_UNSWIZZLING_APERTURE_UNAVAILABLE = unchecked((int)0xC01E0107);

        /// <summary>
        /// The current allocation can't be unswizzled by an aperture.
        /// </summary>
        public const int STATUS_GRAPHICS_UNSWIZZLING_APERTURE_UNSUPPORTED = unchecked((int)0xC01E0108);

        /// <summary>
        /// The request failed because a pinned allocation can't be evicted.
        /// </summary>
        public const int STATUS_GRAPHICS_CANT_EVICT_PINNED_ALLOCATION = unchecked((int)0xC01E0109);

        /// <summary>
        /// The allocation can't be used from its current segment location for the specified operation.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_ALLOCATION_USAGE = unchecked((int)0xC01E0110);

        /// <summary>
        /// A locked allocation can't be used in the current command buffer.
        /// </summary>
        public const int STATUS_GRAPHICS_CANT_RENDER_LOCKED_ALLOCATION = unchecked((int)0xC01E0111);

        /// <summary>
        /// The allocation being referenced has been closed permanently.
        /// </summary>
        public const int STATUS_GRAPHICS_ALLOCATION_CLOSED = unchecked((int)0xC01E0112);

        /// <summary>
        /// An invalid allocation instance is being referenced.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_ALLOCATION_INSTANCE = unchecked((int)0xC01E0113);

        /// <summary>
        /// An invalid allocation handle is being referenced.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_ALLOCATION_HANDLE = unchecked((int)0xC01E0114);

        /// <summary>
        /// The allocation being referenced doesn't belong to the current device.
        /// </summary>
        public const int STATUS_GRAPHICS_WRONG_ALLOCATION_DEVICE = unchecked((int)0xC01E0115);

        /// <summary>
        /// The specified allocation lost its content.
        /// </summary>
        public const int STATUS_GRAPHICS_ALLOCATION_CONTENT_LOST = unchecked((int)0xC01E0116);

        //
        //   Video GPU Scheduler (VidSch) specific status codes {0x0200..0x02ff}
        //
        /// <summary>
        /// GPU exception is detected on the given device. The device is not able to be scheduled.
        /// </summary>
        public const int STATUS_GRAPHICS_GPU_EXCEPTION_ON_DEVICE = unchecked((int)0xC01E0200);

        /// <summary>
        /// Skip preparation of allocations referenced by the DMA buffer.
        /// </summary>
        public const int STATUS_GRAPHICS_SKIP_ALLOCATION_PREPARATION = 0x401E0201;

        //
        //   Video Present Network Management (VidPNMgr) specific status codes {0x0300..0x03ff}
        //
        /// <summary>
        /// Specified VidPN topology is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDPN_TOPOLOGY = unchecked((int)0xC01E0300);

        /// <summary>
        /// Specified VidPN topology is valid but is not supported by this model of the display adapter.
        /// </summary>
        public const int STATUS_GRAPHICS_VIDPN_TOPOLOGY_NOT_SUPPORTED = unchecked((int)0xC01E0301);

        /// <summary>
        /// Specified VidPN topology is valid but is not supported by the display adapter at this time, due to current allocation of its resources.
        /// </summary>
        public const int STATUS_GRAPHICS_VIDPN_TOPOLOGY_CURRENTLY_NOT_SUPPORTED = unchecked((int)0xC01E0302);

        /// <summary>
        /// Specified VidPN handle is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDPN = unchecked((int)0xC01E0303);

        /// <summary>
        /// Specified video present source is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE = unchecked((int)0xC01E0304);

        /// <summary>
        /// Specified video present target is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET = unchecked((int)0xC01E0305);

        /// <summary>
        /// Specified VidPN modality is not supported (e.g. at least two of the pinned modes are not cofunctional).
        /// </summary>
        public const int STATUS_GRAPHICS_VIDPN_MODALITY_NOT_SUPPORTED = unchecked((int)0xC01E0306);

        /// <summary>
        /// No mode is pinned on the specified VidPN source/target.
        /// </summary>
        public const int STATUS_GRAPHICS_MODE_NOT_PINNED = 0x401E0307;

        /// <summary>
        /// Specified VidPN source mode set is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDPN_SOURCEMODESET = unchecked((int)0xC01E0308);

        /// <summary>
        /// Specified VidPN target mode set is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDPN_TARGETMODESET = unchecked((int)0xC01E0309);

        /// <summary>
        /// Specified video signal frequency is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_FREQUENCY = unchecked((int)0xC01E030A);

        /// <summary>
        /// Specified video signal active region is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_ACTIVE_REGION = unchecked((int)0xC01E030B);

        /// <summary>
        /// Specified video signal total region is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_TOTAL_REGION = unchecked((int)0xC01E030C);

        /// <summary>
        /// Specified video present source mode is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE_MODE = unchecked((int)0xC01E0310);

        /// <summary>
        /// Specified video present target mode is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET_MODE = unchecked((int)0xC01E0311);

        /// <summary>
        /// Pinned mode must remain in the set on VidPN's cofunctional modality enumeration.
        /// </summary>
        public const int STATUS_GRAPHICS_PINNED_MODE_MUST_REMAIN_IN_SET = unchecked((int)0xC01E0312);

        /// <summary>
        /// Specified video present path is already in VidPN's topology.
        /// </summary>
        public const int STATUS_GRAPHICS_PATH_ALREADY_IN_TOPOLOGY = unchecked((int)0xC01E0313);

        /// <summary>
        /// Specified mode is already in the mode set.
        /// </summary>
        public const int STATUS_GRAPHICS_MODE_ALREADY_IN_MODESET = unchecked((int)0xC01E0314);

        /// <summary>
        /// Specified video present source set is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDEOPRESENTSOURCESET = unchecked((int)0xC01E0315);

        /// <summary>
        /// Specified video present target set is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDEOPRESENTTARGETSET = unchecked((int)0xC01E0316);

        /// <summary>
        /// Specified video present source is already in the video present source set.
        /// </summary>
        public const int STATUS_GRAPHICS_SOURCE_ALREADY_IN_SET = unchecked((int)0xC01E0317);

        /// <summary>
        /// Specified video present target is already in the video present target set.
        /// </summary>
        public const int STATUS_GRAPHICS_TARGET_ALREADY_IN_SET = unchecked((int)0xC01E0318);

        /// <summary>
        /// Specified VidPN present path is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDPN_PRESENT_PATH = unchecked((int)0xC01E0319);

        /// <summary>
        /// Miniport has no recommendation for augmentation of the specified VidPN's topology.
        /// </summary>
        public const int STATUS_GRAPHICS_NO_RECOMMENDED_VIDPN_TOPOLOGY = unchecked((int)0xC01E031A);

        /// <summary>
        /// Specified monitor frequency range set is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGESET = unchecked((int)0xC01E031B);

        /// <summary>
        /// Specified monitor frequency range is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE = unchecked((int)0xC01E031C);

        /// <summary>
        /// Specified frequency range is not in the specified monitor frequency range set.
        /// </summary>
        public const int STATUS_GRAPHICS_FREQUENCYRANGE_NOT_IN_SET = unchecked((int)0xC01E031D);

        /// <summary>
        /// Specified mode set does not specify preference for one of its modes.
        /// </summary>
        public const int STATUS_GRAPHICS_NO_PREFERRED_MODE = 0x401E031E;

        /// <summary>
        /// Specified frequency range is already in the specified monitor frequency range set.
        /// </summary>
        public const int STATUS_GRAPHICS_FREQUENCYRANGE_ALREADY_IN_SET = unchecked((int)0xC01E031F);

        /// <summary>
        /// Specified mode set is stale. Please reacquire the new mode set.
        /// </summary>
        public const int STATUS_GRAPHICS_STALE_MODESET = unchecked((int)0xC01E0320);

        /// <summary>
        /// Specified monitor source mode set is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_MONITOR_SOURCEMODESET = unchecked((int)0xC01E0321);

        /// <summary>
        /// Specified monitor source mode is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_MONITOR_SOURCE_MODE = unchecked((int)0xC01E0322);

        /// <summary>
        /// Miniport does not have any recommendation regarding the request to provide a functional VidPN given the current display adapter configuration.
        /// </summary>
        public const int STATUS_GRAPHICS_NO_RECOMMENDED_FUNCTIONAL_VIDPN = unchecked((int)0xC01E0323);

        /// <summary>
        /// ID of the specified mode is already used by another mode in the set.
        /// </summary>
        public const int STATUS_GRAPHICS_MODE_ID_MUST_BE_UNIQUE = unchecked((int)0xC01E0324);

        /// <summary>
        /// System failed to determine a mode that is supported by both the display adapter and the monitor connected to it.
        /// </summary>
        public const int STATUS_GRAPHICS_EMPTY_ADAPTER_MONITOR_MODE_SUPPORT_INTERSECTION = unchecked((int)0xC01E0325);

        /// <summary>
        /// Number of video present targets must be greater than or equal to the number of video present sources.
        /// </summary>
        public const int STATUS_GRAPHICS_VIDEO_PRESENT_TARGETS_LESS_THAN_SOURCES = unchecked((int)0xC01E0326);

        /// <summary>
        /// Specified present path is not in VidPN's topology.
        /// </summary>
        public const int STATUS_GRAPHICS_PATH_NOT_IN_TOPOLOGY = unchecked((int)0xC01E0327);

        /// <summary>
        /// Display adapter must have at least one video present source.
        /// </summary>
        public const int STATUS_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_SOURCE = unchecked((int)0xC01E0328);

        /// <summary>
        /// Display adapter must have at least one video present target.
        /// </summary>
        public const int STATUS_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_TARGET = unchecked((int)0xC01E0329);

        /// <summary>
        /// Specified monitor descriptor set is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_MONITORDESCRIPTORSET = unchecked((int)0xC01E032A);

        /// <summary>
        /// Specified monitor descriptor is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_MONITORDESCRIPTOR = unchecked((int)0xC01E032B);

        /// <summary>
        /// Specified descriptor is not in the specified monitor descriptor set.
        /// </summary>
        public const int STATUS_GRAPHICS_MONITORDESCRIPTOR_NOT_IN_SET = unchecked((int)0xC01E032C);

        /// <summary>
        /// Specified descriptor is already in the specified monitor descriptor set.
        /// </summary>
        public const int STATUS_GRAPHICS_MONITORDESCRIPTOR_ALREADY_IN_SET = unchecked((int)0xC01E032D);

        /// <summary>
        /// ID of the specified monitor descriptor is already used by another descriptor in the set.
        /// </summary>
        public const int STATUS_GRAPHICS_MONITORDESCRIPTOR_ID_MUST_BE_UNIQUE = unchecked((int)0xC01E032E);

        /// <summary>
        /// Specified video present target subset type is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDPN_TARGET_SUBSET_TYPE = unchecked((int)0xC01E032F);

        /// <summary>
        /// Two or more of the specified resources are not related to each other, as defined by the interface semantics.
        /// </summary>
        public const int STATUS_GRAPHICS_RESOURCES_NOT_RELATED = unchecked((int)0xC01E0330);

        /// <summary>
        /// ID of the specified video present source is already used by another source in the set.
        /// </summary>
        public const int STATUS_GRAPHICS_SOURCE_ID_MUST_BE_UNIQUE = unchecked((int)0xC01E0331);

        /// <summary>
        /// ID of the specified video present target is already used by another target in the set.
        /// </summary>
        public const int STATUS_GRAPHICS_TARGET_ID_MUST_BE_UNIQUE = unchecked((int)0xC01E0332);

        /// <summary>
        /// Specified VidPN source cannot be used because there is no available VidPN target to connect it to.
        /// </summary>
        public const int STATUS_GRAPHICS_NO_AVAILABLE_VIDPN_TARGET = unchecked((int)0xC01E0333);

        /// <summary>
        /// Newly arrived monitor could not be associated with a display adapter.
        /// </summary>
        public const int STATUS_GRAPHICS_MONITOR_COULD_NOT_BE_ASSOCIATED_WITH_ADAPTER = unchecked((int)0xC01E0334);

        /// <summary>
        /// Display adapter in question does not have an associated VidPN manager.
        /// </summary>
        public const int STATUS_GRAPHICS_NO_VIDPNMGR = unchecked((int)0xC01E0335);

        /// <summary>
        /// VidPN manager of the display adapter in question does not have an active VidPN.
        /// </summary>
        public const int STATUS_GRAPHICS_NO_ACTIVE_VIDPN = unchecked((int)0xC01E0336);

        /// <summary>
        /// Specified VidPN topology is stale. Please reacquire the new topology.
        /// </summary>
        public const int STATUS_GRAPHICS_STALE_VIDPN_TOPOLOGY = unchecked((int)0xC01E0337);

        /// <summary>
        /// There is no monitor connected on the specified video present target.
        /// </summary>
        public const int STATUS_GRAPHICS_MONITOR_NOT_CONNECTED = unchecked((int)0xC01E0338);

        /// <summary>
        /// Specified source is not part of the specified VidPN's topology.
        /// </summary>
        public const int STATUS_GRAPHICS_SOURCE_NOT_IN_TOPOLOGY = unchecked((int)0xC01E0339);

        /// <summary>
        /// Specified primary surface size is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_PRIMARYSURFACE_SIZE = unchecked((int)0xC01E033A);

        /// <summary>
        /// Specified visible region size is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VISIBLEREGION_SIZE = unchecked((int)0xC01E033B);

        /// <summary>
        /// Specified stride is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_STRIDE = unchecked((int)0xC01E033C);

        /// <summary>
        /// Specified pixel format is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_PIXELFORMAT = unchecked((int)0xC01E033D);

        /// <summary>
        /// Specified color basis is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_COLORBASIS = unchecked((int)0xC01E033E);

        /// <summary>
        /// Specified pixel value access mode is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_PIXELVALUEACCESSMODE = unchecked((int)0xC01E033F);

        /// <summary>
        /// Specified target is not part of the specified VidPN's topology.
        /// </summary>
        public const int STATUS_GRAPHICS_TARGET_NOT_IN_TOPOLOGY = unchecked((int)0xC01E0340);

        /// <summary>
        /// Failed to acquire display mode management interface.
        /// </summary>
        public const int STATUS_GRAPHICS_NO_DISPLAY_MODE_MANAGEMENT_SUPPORT = unchecked((int)0xC01E0341);

        /// <summary>
        /// Specified VidPN source is already owned by a DMM client and cannot be used until that client releases it.
        /// </summary>
        public const int STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE = unchecked((int)0xC01E0342);

        /// <summary>
        /// Specified VidPN is active and cannot be accessed.
        /// </summary>
        public const int STATUS_GRAPHICS_CANT_ACCESS_ACTIVE_VIDPN = unchecked((int)0xC01E0343);

        /// <summary>
        /// Specified VidPN present path importance ordinal is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_PATH_IMPORTANCE_ORDINAL = unchecked((int)0xC01E0344);

        /// <summary>
        /// Specified VidPN present path content geometry transformation is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_PATH_CONTENT_GEOMETRY_TRANSFORMATION = unchecked((int)0xC01E0345);

        /// <summary>
        /// Specified content geometry transformation is not supported on the respective VidPN present path.
        /// </summary>
        public const int STATUS_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_SUPPORTED = unchecked((int)0xC01E0346);

        /// <summary>
        /// Specified gamma ramp is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_GAMMA_RAMP = unchecked((int)0xC01E0347);

        /// <summary>
        /// Specified gamma ramp is not supported on the respective VidPN present path.
        /// </summary>
        public const int STATUS_GRAPHICS_GAMMA_RAMP_NOT_SUPPORTED = unchecked((int)0xC01E0348);

        /// <summary>
        /// Multi-sampling is not supported on the respective VidPN present path.
        /// </summary>
        public const int STATUS_GRAPHICS_MULTISAMPLING_NOT_SUPPORTED = unchecked((int)0xC01E0349);

        /// <summary>
        /// Specified mode is not in the specified mode set.
        /// </summary>
        public const int STATUS_GRAPHICS_MODE_NOT_IN_MODESET = unchecked((int)0xC01E034A);

        /// <summary>
        /// Specified data set (e.g. mode set, frequency range set, descriptor set, topology, etc.) is empty.
        /// </summary>
        public const int STATUS_GRAPHICS_DATASET_IS_EMPTY = 0x401E034B;

        /// <summary>
        /// Specified data set (e.g. mode set, frequency range set, descriptor set, topology, etc.) does not contain any more elements.
        /// </summary>
        public const int STATUS_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET = 0x401E034C;

        /// <summary>
        /// Specified VidPN topology recommendation reason is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_VIDPN_TOPOLOGY_RECOMMENDATION_REASON = unchecked((int)0xC01E034D);

        /// <summary>
        /// Specified VidPN present path content type is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_PATH_CONTENT_TYPE = unchecked((int)0xC01E034E);

        /// <summary>
        /// Specified VidPN present path copy protection type is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_COPYPROTECTION_TYPE = unchecked((int)0xC01E034F);

        /// <summary>
        /// No more than one unassigned mode set can exist at any given time for a given VidPN source/target.
        /// </summary>
        public const int STATUS_GRAPHICS_UNASSIGNED_MODESET_ALREADY_EXISTS = unchecked((int)0xC01E0350);

        /// <summary>
        /// Specified content transformation is not pinned on the specified VidPN present path.
        /// </summary>
        public const int STATUS_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED = 0x401E0351;

        /// <summary>
        /// Specified scanline ordering type is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_SCANLINE_ORDERING = unchecked((int)0xC01E0352);

        /// <summary>
        /// Topology changes are not allowed for the specified VidPN.
        /// </summary>
        public const int STATUS_GRAPHICS_TOPOLOGY_CHANGES_NOT_ALLOWED = unchecked((int)0xC01E0353);

        /// <summary>
        /// All available importance ordinals are already used in specified topology.
        /// </summary>
        public const int STATUS_GRAPHICS_NO_AVAILABLE_IMPORTANCE_ORDINALS = unchecked((int)0xC01E0354);

        /// <summary>
        /// Specified primary surface has a different private format attribute than the current primary surface
        /// </summary>
        public const int STATUS_GRAPHICS_INCOMPATIBLE_PRIVATE_FORMAT = unchecked((int)0xC01E0355);

        /// <summary>
        /// Specified mode pruning algorithm is invalid
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_MODE_PRUNING_ALGORITHM = unchecked((int)0xC01E0356);

        /// <summary>
        /// Specified monitor capability origin is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_MONITOR_CAPABILITY_ORIGIN = unchecked((int)0xC01E0357);

        /// <summary>
        /// Specified monitor frequency range constraint is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE_CONSTRAINT = unchecked((int)0xC01E0358);

        /// <summary>
        /// Maximum supported number of present paths has been reached.
        /// </summary>
        public const int STATUS_GRAPHICS_MAX_NUM_PATHS_REACHED = unchecked((int)0xC01E0359);

        /// <summary>
        /// Miniport requested that augmentation be cancelled for the specified source of the specified VidPN's topology.
        /// </summary>
        public const int STATUS_GRAPHICS_CANCEL_VIDPN_TOPOLOGY_AUGMENTATION = unchecked((int)0xC01E035A);

        /// <summary>
        /// Specified client type was not recognized.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_CLIENT_TYPE = unchecked((int)0xC01E035B);

        /// <summary>
        /// Client VidPN is not set on this adapter (e.g. no user mode initiated mode changes took place on this adapter yet).
        /// </summary>
        public const int STATUS_GRAPHICS_CLIENTVIDPN_NOT_SET = unchecked((int)0xC01E035C);

        //
        //   Port specific status codes {0x0400..0x04ff}
        //
        /// <summary>
        /// Specified display adapter child device already has an external device connected to it.
        /// </summary>
        public const int STATUS_GRAPHICS_SPECIFIED_CHILD_ALREADY_CONNECTED = unchecked((int)0xC01E0400);

        /// <summary>
        /// Specified display adapter child device does not support descriptor exposure.
        /// </summary>
        public const int STATUS_GRAPHICS_CHILD_DESCRIPTOR_NOT_SUPPORTED = unchecked((int)0xC01E0401);

        /// <summary>
        /// Child device presence was not reliably detected.
        /// </summary>
        public const int STATUS_GRAPHICS_UNKNOWN_CHILD_STATUS = 0x401E042F;

        /// <summary>
        /// The display adapter is not linked to any other adapters.
        /// </summary>
        public const int STATUS_GRAPHICS_NOT_A_LINKED_ADAPTER = unchecked((int)0xC01E0430);

        /// <summary>
        /// Lead adapter in a linked configuration was not enumerated yet.
        /// </summary>
        public const int STATUS_GRAPHICS_LEADLINK_NOT_ENUMERATED = unchecked((int)0xC01E0431);

        /// <summary>
        /// Some chain adapters in a linked configuration were not enumerated yet.
        /// </summary>
        public const int STATUS_GRAPHICS_CHAINLINKS_NOT_ENUMERATED = unchecked((int)0xC01E0432);

        /// <summary>
        /// The chain of linked adapters is not ready to start because of an unknown failure.
        /// </summary>
        public const int STATUS_GRAPHICS_ADAPTER_CHAIN_NOT_READY = unchecked((int)0xC01E0433);

        /// <summary>
        /// An attempt was made to start a lead link display adapter when the chain links were not started yet.
        /// </summary>
        public const int STATUS_GRAPHICS_CHAINLINKS_NOT_STARTED = unchecked((int)0xC01E0434);

        /// <summary>
        /// An attempt was made to power up a lead link display adapter when the chain links were powered down.
        /// </summary>
        public const int STATUS_GRAPHICS_CHAINLINKS_NOT_POWERED_ON = unchecked((int)0xC01E0435);

        /// <summary>
        /// The adapter link was found to be in an inconsistent state. Not all adapters are in an expected PNP/Power state.
        /// </summary>
        public const int STATUS_GRAPHICS_INCONSISTENT_DEVICE_LINK_STATE = unchecked((int)0xC01E0436);

        /// <summary>
        /// Starting the leadlink adapter has been deferred temporarily.
        /// </summary>
        public const int STATUS_GRAPHICS_LEADLINK_START_DEFERRED = 0x401E0437;

        /// <summary>
        /// The driver trying to start is not the same as the driver for the POSTed display adapter.
        /// </summary>
        public const int STATUS_GRAPHICS_NOT_POST_DEVICE_DRIVER = unchecked((int)0xC01E0438);

        /// <summary>
        /// The display adapter is being polled for children too frequently at the same polling level.
        /// </summary>
        public const int STATUS_GRAPHICS_POLLING_TOO_FREQUENTLY = 0x401E0439;

        /// <summary>
        /// Starting the adapter has been deferred temporarily.
        /// </summary>
        public const int STATUS_GRAPHICS_START_DEFERRED = 0x401E043A;

        /// <summary>
        /// An operation is being attempted that requires the display adapter to be in a quiescent state.
        /// </summary>
        public const int STATUS_GRAPHICS_ADAPTER_ACCESS_NOT_EXCLUDED = unchecked((int)0xC01E043B);

        /// <summary>
        /// We can depend on the child device presence returned by the driver.
        /// </summary>
        public const int STATUS_GRAPHICS_DEPENDABLE_CHILD_STATUS = 0x401E043C;

        //
        //   OPM, PVP and UAB status codes {0x0500..0x057F}
        //
        /// <summary>
        /// The driver does not support OPM.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_NOT_SUPPORTED = unchecked((int)0xC01E0500);

        /// <summary>
        /// The driver does not support COPP.
        /// </summary>
        public const int STATUS_GRAPHICS_COPP_NOT_SUPPORTED = unchecked((int)0xC01E0501);

        /// <summary>
        /// The driver does not support UAB.
        /// </summary>
        public const int STATUS_GRAPHICS_UAB_NOT_SUPPORTED = unchecked((int)0xC01E0502);

        /// <summary>
        /// The specified encrypted parameters are invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_INVALID_ENCRYPTED_PARAMETERS = unchecked((int)0xC01E0503);

        /// <summary>
        /// The GDI display device passed to this function does not have any active protected outputs.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_NO_PROTECTED_OUTPUTS_EXIST = unchecked((int)0xC01E0505);

        /// <summary>
        /// An internal error caused an operation to fail.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_INTERNAL_ERROR = unchecked((int)0xC01E050B);

        /// <summary>
        /// The function failed because the caller passed in an invalid OPM user mode handle.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_INVALID_HANDLE = unchecked((int)0xC01E050C);

        /// <summary>
        /// A certificate could not be returned because the certificate buffer passed to the function was too small.
        /// </summary>
        public const int STATUS_GRAPHICS_PVP_INVALID_CERTIFICATE_LENGTH = unchecked((int)0xC01E050E);

        /// <summary>
        /// The DxgkDdiOpmCreateProtectedOutput function could not create a protected output because the Video Present Target is in spanning mode.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_SPANNING_MODE_ENABLED = unchecked((int)0xC01E050F);

        /// <summary>
        /// The DxgkDdiOpmCreateProtectedOutput function could not create a protected output because the Video Present Target is in theater mode.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_THEATER_MODE_ENABLED = unchecked((int)0xC01E0510);

        /// <summary>
        /// The function failed because the display adapter's Hardware Functionality Scan failed to validate the graphics hardware.
        /// </summary>
        public const int STATUS_GRAPHICS_PVP_HFS_FAILED = unchecked((int)0xC01E0511);

        /// <summary>
        /// The HDCP System Renewability Message passed to this function did not comply with section 5 of the HDCP 1.1 specification.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_INVALID_SRM = unchecked((int)0xC01E0512);

        /// <summary>
        /// The protected output cannot enable the High-bandwidth Digital Content Protection (HDCP) System because it does not support HDCP.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_HDCP = unchecked((int)0xC01E0513);

        /// <summary>
        /// The protected output cannot enable Analogue Copy Protection (ACP) because it does not support ACP.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_ACP = unchecked((int)0xC01E0514);

        /// <summary>
        /// The protected output cannot enable the Content Generation Management System Analogue (CGMS-A) protection technology because it does not support CGMS-A.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_CGMSA = unchecked((int)0xC01E0515);

        /// <summary>
        /// The DxgkDdiOPMGetInformation function cannot return the version of the SRM being used because the application never successfully passed an SRM to the protected output.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_HDCP_SRM_NEVER_SET = unchecked((int)0xC01E0516);

        /// <summary>
        /// The DxgkDdiOPMConfigureProtectedOutput function cannot enable the specified output protection technology because the output's screen resolution is too high.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_RESOLUTION_TOO_HIGH = unchecked((int)0xC01E0517);

        /// <summary>
        /// The DxgkDdiOPMConfigureProtectedOutput function cannot enable HDCP because the display adapter's HDCP hardware is already being used by other physical outputs.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_ALL_HDCP_HARDWARE_ALREADY_IN_USE = unchecked((int)0xC01E0518);

        /// <summary>
        /// The operating system asynchronously destroyed this OPM protected output because the operating system's state changed. This error typically occurs because the monitor PDO associated with this protected output was removed, the monitor PDO associated with this protected output was stopped, or the protected output's session became a non-console session.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_NO_LONGER_EXISTS = unchecked((int)0xC01E051A);

        /// <summary>
        /// Either the DxgkDdiOPMGetCOPPCompatibleInformation, DxgkDdiOPMGetInformation, or DxgkDdiOPMConfigureProtectedOutput function failed. This error is returned when the caller tries to use a COPP specific command while the protected output has OPM semantics only.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_DOES_NOT_HAVE_COPP_SEMANTICS = unchecked((int)0xC01E051C);

        /// <summary>
        /// The DxgkDdiOPMGetInformation and DxgkDdiOPMGetCOPPCompatibleInformation functions return this error code if the passed in sequence number is not the expected sequence number or the passed in OMAC value is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_INVALID_INFORMATION_REQUEST = unchecked((int)0xC01E051D);

        /// <summary>
        /// The function failed because an unexpected error occurred inside of a display driver.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_DRIVER_INTERNAL_ERROR = unchecked((int)0xC01E051E);

        /// <summary>
        /// Either the DxgkDdiOPMGetCOPPCompatibleInformation, DxgkDdiOPMGetInformation, or DxgkDdiOPMConfigureProtectedOutput function failed. This error is returned when the caller tries to use an OPM specific command while the protected output has COPP semantics only.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_DOES_NOT_HAVE_OPM_SEMANTICS = unchecked((int)0xC01E051F);

        /// <summary>
        /// The DxgkDdiOPMGetCOPPCompatibleInformation and DxgkDdiOPMConfigureProtectedOutput functions return this error if the display driver does not support the DXGKMDT_OPM_GET_ACP_AND_CGMSA_SIGNALING and DXGKMDT_OPM_SET_ACP_AND_CGMSA_SIGNALING GUIDs.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_SIGNALING_NOT_SUPPORTED = unchecked((int)0xC01E0520);

        /// <summary>
        /// The DxgkDdiOPMConfigureProtectedOutput function returns this error code if the passed in sequence number is not the expected sequence number or the passed in OMAC value is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_OPM_INVALID_CONFIGURATION_REQUEST = unchecked((int)0xC01E0521);

        //
        //   Monitor Configuration API status codes {0x0580..0x05DF}
        //
        /// <summary>
        /// The monitor connected to the specified video output does not have an I2C bus.
        /// </summary>
        public const int STATUS_GRAPHICS_I2C_NOT_SUPPORTED = unchecked((int)0xC01E0580);

        /// <summary>
        /// No device on the I2C bus has the specified address.
        /// </summary>
        public const int STATUS_GRAPHICS_I2C_DEVICE_DOES_NOT_EXIST = unchecked((int)0xC01E0581);

        /// <summary>
        /// An error occurred while transmitting data to the device on the I2C bus.
        /// </summary>
        public const int STATUS_GRAPHICS_I2C_ERROR_TRANSMITTING_DATA = unchecked((int)0xC01E0582);

        /// <summary>
        /// An error occurred while receiving data from the device on the I2C bus.
        /// </summary>
        public const int STATUS_GRAPHICS_I2C_ERROR_RECEIVING_DATA = unchecked((int)0xC01E0583);

        /// <summary>
        /// The monitor does not support the specified VCP code.
        /// </summary>
        public const int STATUS_GRAPHICS_DDCCI_VCP_NOT_SUPPORTED = unchecked((int)0xC01E0584);

        /// <summary>
        /// The data received from the monitor is invalid.
        /// </summary>
        public const int STATUS_GRAPHICS_DDCCI_INVALID_DATA = unchecked((int)0xC01E0585);

        /// <summary>
        /// The function failed because a monitor returned an invalid Timing Status byte when the operating system used the DDC/CI Get Timing Report &amp; Timing Message command to get a timing report from a monitor.
        /// </summary>
        public const int STATUS_GRAPHICS_DDCCI_MONITOR_RETURNED_INVALID_TIMING_STATUS_BYTE = unchecked((int)0xC01E0586);

        /// <summary>
        /// A monitor returned a DDC/CI capabilities string which did not comply with the ACCESS.bus 3.0, DDC/CI 1.1, or MCCS 2 Revision 1 specification.
        /// </summary>
        public const int STATUS_GRAPHICS_DDCCI_INVALID_CAPABILITIES_STRING = unchecked((int)0xC01E0587);

        /// <summary>
        /// An internal error caused an operation to fail.
        /// </summary>
        public const int STATUS_GRAPHICS_MCA_INTERNAL_ERROR = unchecked((int)0xC01E0588);

        /// <summary>
        /// An operation failed because a DDC/CI message had an invalid value in its command field.
        /// </summary>
        public const int STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_COMMAND = unchecked((int)0xC01E0589);

        /// <summary>
        /// An error occurred because the field length of a DDC/CI message contained an invalid value.
        /// </summary>
        public const int STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_LENGTH = unchecked((int)0xC01E058A);

        /// <summary>
        /// An error occurred because the checksum field in a DDC/CI message did not match the message's computed checksum value. This error implies that the data was corrupted while it was being transmitted from a monitor to a computer.
        /// </summary>
        public const int STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_CHECKSUM = unchecked((int)0xC01E058B);

        /// <summary>
        /// This function failed because an invalid monitor handle was passed to it.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_PHYSICAL_MONITOR_HANDLE = unchecked((int)0xC01E058C);

        /// <summary>
        /// The operating system asynchronously destroyed the monitor which corresponds to this handle because the operating system's state changed. This error typically occurs because the monitor PDO associated with this handle was removed, the monitor PDO associated with this handle was stopped, or a display mode change occurred. A display mode change occurs when windows sends a WM_DISPLAYCHANGE windows message to applications.
        /// </summary>
        public const int STATUS_GRAPHICS_MONITOR_NO_LONGER_EXISTS = unchecked((int)0xC01E058D);

        //
        //   OPM, UAB, PVP and DDC/CI shared status codes {0x25E0..0x25FF}
        //
        /// <summary>
        /// This function can only be used if a program is running in the local console session. It cannot be used if a program is running on a remote desktop session or on a terminal server session.
        /// </summary>
        public const int STATUS_GRAPHICS_ONLY_CONSOLE_SESSION_SUPPORTED = unchecked((int)0xC01E05E0);

        /// <summary>
        /// This function cannot find an actual GDI display device which corresponds to the specified GDI display device name.
        /// </summary>
        public const int STATUS_GRAPHICS_NO_DISPLAY_DEVICE_CORRESPONDS_TO_NAME = unchecked((int)0xC01E05E1);

        /// <summary>
        /// The function failed because the specified GDI display device was not attached to the Windows desktop.
        /// </summary>
        public const int STATUS_GRAPHICS_DISPLAY_DEVICE_NOT_ATTACHED_TO_DESKTOP = unchecked((int)0xC01E05E2);

        /// <summary>
        /// This function does not support GDI mirroring display devices because GDI mirroring display devices do not have any physical monitors associated with them.
        /// </summary>
        public const int STATUS_GRAPHICS_MIRRORING_DEVICES_NOT_SUPPORTED = unchecked((int)0xC01E05E3);

        /// <summary>
        /// The function failed because an invalid pointer parameter was passed to it. A pointer parameter is invalid if it is NULL, it points to an invalid address, it points to a kernel mode address or it is not correctly aligned.
        /// </summary>
        public const int STATUS_GRAPHICS_INVALID_POINTER = unchecked((int)0xC01E05E4);

        /// <summary>
        /// This function failed because the GDI device passed to it did not have any monitors associated with it.
        /// </summary>
        public const int STATUS_GRAPHICS_NO_MONITORS_CORRESPOND_TO_DISPLAY_DEVICE = unchecked((int)0xC01E05E5);

        /// <summary>
        /// An array passed to the function cannot hold all of the data that the function must copy into the array.
        /// </summary>
        public const int STATUS_GRAPHICS_PARAMETER_ARRAY_TOO_SMALL = unchecked((int)0xC01E05E6);

        /// <summary>
        /// An internal error caused an operation to fail.
        /// </summary>
        public const int STATUS_GRAPHICS_INTERNAL_ERROR = unchecked((int)0xC01E05E7);

        /// <summary>
        /// The function failed because the current session is changing its type. This function cannot be called when the current session is changing its type. There are currently three types of sessions: console, disconnected and remote.
        /// </summary>
        public const int STATUS_GRAPHICS_SESSION_TYPE_CHANGE_IN_PROGRESS = unchecked((int)0xC01E05E8);


        //
        // Full Volume Encryption Error codes (fvevol.sys)
        //

        /// <summary>
        /// This volume is locked by BitLocker Drive Encryption.
        /// </summary>
        public const int STATUS_FVE_LOCKED_VOLUME = unchecked((int)0xC0210000);

        /// <summary>
        /// The volume is not encrypted, no key is available.
        /// </summary>
        public const int STATUS_FVE_NOT_ENCRYPTED = unchecked((int)0xC0210001);

        /// <summary>
        /// The control block for the encrypted volume is not valid.
        /// </summary>
        public const int STATUS_FVE_BAD_INFORMATION = unchecked((int)0xC0210002);

        /// <summary>
        /// The volume cannot be encrypted because it does not have enough free space.
        /// </summary>
        public const int STATUS_FVE_TOO_SMALL = unchecked((int)0xC0210003);

        /// <summary>
        /// The volume cannot be encrypted because the file system is not supported.
        /// </summary>
        public const int STATUS_FVE_FAILED_WRONG_FS = unchecked((int)0xC0210004);

        /// <summary>
        /// The file system size is larger than the partition size in the partition table.
        /// </summary>
        public const int STATUS_FVE_BAD_PARTITION_SIZE = unchecked((int)0xC0210005);

        /// <summary>
        /// The file system does not extend to the end of the volume.
        /// </summary>
        public const int STATUS_FVE_FS_NOT_EXTENDED = unchecked((int)0xC0210006);

        /// <summary>
        /// This operation cannot be performed while a file system is mounted on the volume.
        /// </summary>
        public const int STATUS_FVE_FS_MOUNTED = unchecked((int)0xC0210007);

        /// <summary>
        /// BitLocker Drive Encryption is not included with this version of Windows.
        /// </summary>
        public const int STATUS_FVE_NO_LICENSE = unchecked((int)0xC0210008);

        /// <summary>
        /// Requested action not allowed in the current volume state.
        /// </summary>
        public const int STATUS_FVE_ACTION_NOT_ALLOWED = unchecked((int)0xC0210009);

        /// <summary>
        /// Data supplied is malformed.
        /// </summary>
        public const int STATUS_FVE_BAD_DATA = unchecked((int)0xC021000A);

        /// <summary>
        /// The volume is not bound to the system.
        /// </summary>
        public const int STATUS_FVE_VOLUME_NOT_BOUND = unchecked((int)0xC021000B);

        /// <summary>
        /// That volume is not a data volume.
        /// </summary>
        public const int STATUS_FVE_NOT_DATA_VOLUME = unchecked((int)0xC021000C);

        /// <summary>
        /// A read operation failed while converting the volume.
        /// </summary>
        public const int STATUS_FVE_CONV_READ_ERROR = unchecked((int)0xC021000D);

        /// <summary>
        /// A write operation failed while converting the volume.
        /// </summary>
        public const int STATUS_FVE_CONV_WRITE_ERROR = unchecked((int)0xC021000E);

        /// <summary>
        /// The control block for the encrypted volume was updated by another thread. Try again.
        /// </summary>
        public const int STATUS_FVE_OVERLAPPED_UPDATE = unchecked((int)0xC021000F);

        /// <summary>
        /// The encryption algorithm does not support the sector size of that volume.
        /// </summary>
        public const int STATUS_FVE_FAILED_SECTOR_SIZE = unchecked((int)0xC0210010);

        /// <summary>
        /// BitLocker recovery authentication failed.
        /// </summary>
        public const int STATUS_FVE_FAILED_AUTHENTICATION = unchecked((int)0xC0210011);

        /// <summary>
        /// That volume is not the OS volume.
        /// </summary>
        public const int STATUS_FVE_NOT_OS_VOLUME = unchecked((int)0xC0210012);

        /// <summary>
        /// The BitLocker startup key or recovery password could not be read from external media.
        /// </summary>
        public const int STATUS_FVE_KEYFILE_NOT_FOUND = unchecked((int)0xC0210013);

        /// <summary>
        /// The BitLocker startup key or recovery password file is corrupt or invalid.
        /// </summary>
        public const int STATUS_FVE_KEYFILE_INVALID = unchecked((int)0xC0210014);

        /// <summary>
        /// The BitLocker encryption key could not be obtained from the startup key or recovery password.
        /// </summary>
        public const int STATUS_FVE_KEYFILE_NO_VMK = unchecked((int)0xC0210015);

        /// <summary>
        /// The Trusted Platform Module (TPM) is disabled.
        /// </summary>
        public const int STATUS_FVE_TPM_DISABLED = unchecked((int)0xC0210016);

        /// <summary>
        /// The authorization data for the Storage Root Key (SRK) of the Trusted Platform Module (TPM) is not zero.
        /// </summary>
        public const int STATUS_FVE_TPM_SRK_AUTH_NOT_ZERO = unchecked((int)0xC0210017);

        /// <summary>
        /// The system boot information changed or the Trusted Platform Module (TPM) locked out access to BitLocker encryption keys until the computer is restarted.
        /// </summary>
        public const int STATUS_FVE_TPM_INVALID_PCR = unchecked((int)0xC0210018);

        /// <summary>
        /// The BitLocker encryption key could not be obtained from the Trusted Platform Module (TPM).
        /// </summary>
        public const int STATUS_FVE_TPM_NO_VMK = unchecked((int)0xC0210019);

        /// <summary>
        /// The BitLocker encryption key could not be obtained from the Trusted Platform Module (TPM) and PIN.
        /// </summary>
        public const int STATUS_FVE_PIN_INVALID = unchecked((int)0xC021001A);

        /// <summary>
        /// A boot application hash does not match the hash computed when BitLocker was turned on.
        /// </summary>
        public const int STATUS_FVE_AUTH_INVALID_APPLICATION = unchecked((int)0xC021001B);

        /// <summary>
        /// The Boot Configuration Data (BCD) settings are not supported or have changed since BitLocker was enabled.
        /// </summary>
        public const int STATUS_FVE_AUTH_INVALID_CONFIG = unchecked((int)0xC021001C);

        /// <summary>
        /// Boot debugging is enabled. Run bcdedit to turn it off.
        /// </summary>
        public const int STATUS_FVE_DEBUGGER_ENABLED = unchecked((int)0xC021001D);

        /// <summary>
        /// The BitLocker encryption key could not be obtained.
        /// </summary>
        public const int STATUS_FVE_DRY_RUN_FAILED = unchecked((int)0xC021001E);

        /// <summary>
        /// The metadata disk region pointer is incorrect.
        /// </summary>
        public const int STATUS_FVE_BAD_METADATA_POINTER = unchecked((int)0xC021001F);

        /// <summary>
        /// The backup copy of the metadata is out of date.
        /// </summary>
        public const int STATUS_FVE_OLD_METADATA_COPY = unchecked((int)0xC0210020);

        /// <summary>
        /// No action was taken as a system reboot is required.
        /// </summary>
        public const int STATUS_FVE_REBOOT_REQUIRED = unchecked((int)0xC0210021);

        /// <summary>
        /// No action was taken as BitLocker Drive Encryption is in RAW access mode.
        /// </summary>
        public const int STATUS_FVE_RAW_ACCESS = unchecked((int)0xC0210022);

        /// <summary>
        /// BitLocker Drive Encryption cannot enter raw access mode for this volume.
        /// </summary>
        public const int STATUS_FVE_RAW_BLOCKED = unchecked((int)0xC0210023);

        /// <summary>
        /// The auto-unlock master key was not available from the operating system volume. Retry the operation using the BitLocker WMI interface.
        /// </summary>
        public const int STATUS_FVE_NO_AUTOUNLOCK_MASTER_KEY = unchecked((int)0xC0210024);

        /// <summary>
        /// The system firmware failed to enable clearing of system memory on reboot.
        /// </summary>
        public const int STATUS_FVE_MOR_FAILED = unchecked((int)0xC0210025);

        /// <summary>
        /// This feature of BitLocker Drive Encryption is not included with this version of Windows.
        /// </summary>
        public const int STATUS_FVE_NO_FEATURE_LICENSE = unchecked((int)0xC0210026);

        /// <summary>
        /// Group policy does not permit turning off BitLocker Drive Encryption on roaming data volumes.
        /// </summary>
        public const int STATUS_FVE_POLICY_USER_DISABLE_RDV_NOT_ALLOWED = unchecked((int)0xC0210027);

        /// <summary>
        /// Bitlocker Drive Encryption failed to recover from aborted conversion. This could be due to either all conversion logs being corrupted or the media being write-protected.
        /// </summary>
        public const int STATUS_FVE_CONV_RECOVERY_FAILED = unchecked((int)0xC0210028);

        /// <summary>
        /// The requested virtualization size is too big.
        /// </summary>
        public const int STATUS_FVE_VIRTUALIZED_SPACE_TOO_BIG = unchecked((int)0xC0210029);

        /// <summary>
        /// The management information stored on the drive contained an unknown type. If you are using an old version of Windows, try accessing the drive from the latest version.
        /// </summary>
        public const int STATUS_FVE_INVALID_DATUM_TYPE = unchecked((int)0xC021002A);

        /// <summary>
        /// The drive is too small to be protected using BitLocker Drive Encryption.
        /// </summary>
        public const int STATUS_FVE_VOLUME_TOO_SMALL = unchecked((int)0xC0210030);

        /// <summary>
        /// The BitLocker encryption key could not be obtained from the Trusted Platform Module (TPM) and enhanced PIN. Try using a PIN containing only numerals.
        /// </summary>
        public const int STATUS_FVE_ENH_PIN_INVALID = unchecked((int)0xC0210031);

        /// <summary>
        /// BitLocker Drive Encryption only supports Used Space Only encryption on thin provisioned storage.
        /// </summary>
        public const int STATUS_FVE_FULL_ENCRYPTION_NOT_ALLOWED_ON_TP_STORAGE = unchecked((int)0xC0210032);

        /// <summary>
        /// BitLocker Drive Encryption does not support wiping free space on thin provisioned storage.
        /// </summary>
        public const int STATUS_FVE_WIPE_NOT_ALLOWED_ON_TP_STORAGE = unchecked((int)0xC0210033);

        /// <summary>
        /// This command can only be performed from the coordinator node for the specified CSV volume.
        /// </summary>
        public const int STATUS_FVE_NOT_ALLOWED_ON_CSV_STACK = unchecked((int)0xC0210034);

        /// <summary>
        /// This command cannot be performed on a volume when it is part of a cluster.
        /// </summary>
        public const int STATUS_FVE_NOT_ALLOWED_ON_CLUSTER = unchecked((int)0xC0210035);

        /// <summary>
        /// BitLocker cannot be upgraded during disk encryption or decryption.
        /// </summary>
        public const int STATUS_FVE_NOT_ALLOWED_TO_UPGRADE_WHILE_CONVERTING = unchecked((int)0xC0210036);

        /// <summary>
        /// Wipe of free space is not currently taking place.
        /// </summary>
        public const int STATUS_FVE_WIPE_CANCEL_NOT_APPLICABLE = unchecked((int)0xC0210037);

        /// <summary>
        /// Your computer doesn't support BitLocker hardware-based encryption. Check with your computer manufacturer for firmware updates.
        /// </summary>
        public const int STATUS_FVE_EDRIVE_DRY_RUN_FAILED = unchecked((int)0xC0210038);

        /// <summary>
        /// Secure Boot has been disabled. Either Secure Boot must be re-enabled, or BitLocker must be suspended for Windows to start normally.
        /// </summary>
        public const int STATUS_FVE_SECUREBOOT_DISABLED = unchecked((int)0xC0210039);

        /// <summary>
        /// Secure Boot policy has unexpectedly changed.
        /// </summary>
        public const int STATUS_FVE_SECUREBOOT_CONFIG_CHANGE = unchecked((int)0xC021003A);

        /// <summary>
        /// Device Lock has been triggered due to too many incorrect password attempts.
        /// </summary>
        public const int STATUS_FVE_DEVICE_LOCKEDOUT = unchecked((int)0xC021003B);

        /// <summary>
        /// Device encryption removal is blocked due to volume being extended beyond its original size.
        /// </summary>
        public const int STATUS_FVE_VOLUME_EXTEND_PREVENTS_EOW_DECRYPT = unchecked((int)0xC021003C);

        /// <summary>
        /// This action isn't supported because this drive isn't automatically managed with device encryption.
        /// </summary>
        public const int STATUS_FVE_NOT_DE_VOLUME = unchecked((int)0xC021003D);

        /// <summary>
        /// BitLocker Drive Encryption has been suspended on this drive. All BitLocker key protectors configured for this drive are effectively disabled, and the drive will be automatically unlocked using an unencrypted (clear) key.
        /// </summary>
        public const int STATUS_FVE_PROTECTION_DISABLED = unchecked((int)0xC021003E);

        /// <summary>
        /// BitLocker can't be suspended on this drive until the next restart.
        /// </summary>
        public const int STATUS_FVE_PROTECTION_CANNOT_BE_DISABLED = unchecked((int)0xC021003F);

        /// <summary>
        /// BitLocker Drive Encryption policy does not allow KSR operation with protected OS volume.
        /// </summary>
        public const int STATUS_FVE_OSV_KSR_NOT_ALLOWED = unchecked((int)0xC0210040);


        //
        // FWP error codes (fwpkclnt.sys)
        //

        /// <summary>
        /// The callout does not exist.
        /// </summary>
        public const int STATUS_FWP_CALLOUT_NOT_FOUND = unchecked((int)0xC0220001);

        /// <summary>
        /// The filter condition does not exist.
        /// </summary>
        public const int STATUS_FWP_CONDITION_NOT_FOUND = unchecked((int)0xC0220002);

        /// <summary>
        /// The filter does not exist.
        /// </summary>
        public const int STATUS_FWP_FILTER_NOT_FOUND = unchecked((int)0xC0220003);

        /// <summary>
        /// The layer does not exist.
        /// </summary>
        public const int STATUS_FWP_LAYER_NOT_FOUND = unchecked((int)0xC0220004);

        /// <summary>
        /// The provider does not exist.
        /// </summary>
        public const int STATUS_FWP_PROVIDER_NOT_FOUND = unchecked((int)0xC0220005);

        /// <summary>
        /// The provider context does not exist.
        /// </summary>
        public const int STATUS_FWP_PROVIDER_CONTEXT_NOT_FOUND = unchecked((int)0xC0220006);

        /// <summary>
        /// The sublayer does not exist.
        /// </summary>
        public const int STATUS_FWP_SUBLAYER_NOT_FOUND = unchecked((int)0xC0220007);

        /// <summary>
        /// The object does not exist.
        /// </summary>
        public const int STATUS_FWP_NOT_FOUND = unchecked((int)0xC0220008);

        /// <summary>
        /// An object with that GUID or LUID already exists.
        /// </summary>
        public const int STATUS_FWP_ALREADY_EXISTS = unchecked((int)0xC0220009);

        /// <summary>
        /// The object is referenced by other objects so cannot be deleted.
        /// </summary>
        public const int STATUS_FWP_IN_USE = unchecked((int)0xC022000A);

        /// <summary>
        /// The call is not allowed from within a dynamic session.
        /// </summary>
        public const int STATUS_FWP_DYNAMIC_SESSION_IN_PROGRESS = unchecked((int)0xC022000B);

        /// <summary>
        /// The call was made from the wrong session so cannot be completed.
        /// </summary>
        public const int STATUS_FWP_WRONG_SESSION = unchecked((int)0xC022000C);

        /// <summary>
        /// The call must be made from within an explicit transaction.
        /// </summary>
        public const int STATUS_FWP_NO_TXN_IN_PROGRESS = unchecked((int)0xC022000D);

        /// <summary>
        /// The call is not allowed from within an explicit transaction.
        /// </summary>
        public const int STATUS_FWP_TXN_IN_PROGRESS = unchecked((int)0xC022000E);

        /// <summary>
        /// The explicit transaction has been forcibly cancelled.
        /// </summary>
        public const int STATUS_FWP_TXN_ABORTED = unchecked((int)0xC022000F);

        /// <summary>
        /// The session has been cancelled.
        /// </summary>
        public const int STATUS_FWP_SESSION_ABORTED = unchecked((int)0xC0220010);

        /// <summary>
        /// The call is not allowed from within a read-only transaction.
        /// </summary>
        public const int STATUS_FWP_INCOMPATIBLE_TXN = unchecked((int)0xC0220011);

        /// <summary>
        /// The call timed out while waiting to acquire the transaction lock.
        /// </summary>
        public const int STATUS_FWP_TIMEOUT = unchecked((int)0xC0220012);

        /// <summary>
        /// Collection of network diagnostic events is disabled.
        /// </summary>
        public const int STATUS_FWP_NET_EVENTS_DISABLED = unchecked((int)0xC0220013);

        /// <summary>
        /// The operation is not supported by the specified layer.
        /// </summary>
        public const int STATUS_FWP_INCOMPATIBLE_LAYER = unchecked((int)0xC0220014);

        /// <summary>
        /// The call is allowed for kernel-mode callers only.
        /// </summary>
        public const int STATUS_FWP_KM_CLIENTS_ONLY = unchecked((int)0xC0220015);

        /// <summary>
        /// The call tried to associate two objects with incompatible lifetimes.
        /// </summary>
        public const int STATUS_FWP_LIFETIME_MISMATCH = unchecked((int)0xC0220016);

        /// <summary>
        /// The object is built in so cannot be deleted.
        /// </summary>
        public const int STATUS_FWP_BUILTIN_OBJECT = unchecked((int)0xC0220017);

        /// <summary>
        /// The maximum number of callouts has been reached.
        /// </summary>
        public const int STATUS_FWP_TOO_MANY_CALLOUTS = unchecked((int)0xC0220018);

        /// <summary>
        /// A notification could not be delivered because a message queue is at its maximum capacity.
        /// </summary>
        public const int STATUS_FWP_NOTIFICATION_DROPPED = unchecked((int)0xC0220019);

        /// <summary>
        /// The traffic parameters do not match those for the security association context.
        /// </summary>
        public const int STATUS_FWP_TRAFFIC_MISMATCH = unchecked((int)0xC022001A);

        /// <summary>
        /// The call is not allowed for the current security association state.
        /// </summary>
        public const int STATUS_FWP_INCOMPATIBLE_SA_STATE = unchecked((int)0xC022001B);

        /// <summary>
        /// A required pointer is null.
        /// </summary>
        public const int STATUS_FWP_NULL_POINTER = unchecked((int)0xC022001C);

        /// <summary>
        /// An enumerator is not valid.
        /// </summary>
        public const int STATUS_FWP_INVALID_ENUMERATOR = unchecked((int)0xC022001D);

        /// <summary>
        /// The flags field contains an invalid value.
        /// </summary>
        public const int STATUS_FWP_INVALID_FLAGS = unchecked((int)0xC022001E);

        /// <summary>
        /// A network mask is not valid.
        /// </summary>
        public const int STATUS_FWP_INVALID_NET_MASK = unchecked((int)0xC022001F);

        /// <summary>
        /// An FWP_RANGE is not valid.
        /// </summary>
        public const int STATUS_FWP_INVALID_RANGE = unchecked((int)0xC0220020);

        /// <summary>
        /// The time interval is not valid.
        /// </summary>
        public const int STATUS_FWP_INVALID_INTERVAL = unchecked((int)0xC0220021);

        /// <summary>
        /// An array that must contain at least one element is zero length.
        /// </summary>
        public const int STATUS_FWP_ZERO_LENGTH_ARRAY = unchecked((int)0xC0220022);

        /// <summary>
        /// The displayData.name field cannot be null.
        /// </summary>
        public const int STATUS_FWP_NULL_DISPLAY_NAME = unchecked((int)0xC0220023);

        /// <summary>
        /// The action type is not one of the allowed action types for a filter.
        /// </summary>
        public const int STATUS_FWP_INVALID_ACTION_TYPE = unchecked((int)0xC0220024);

        /// <summary>
        /// The filter weight is not valid.
        /// </summary>
        public const int STATUS_FWP_INVALID_WEIGHT = unchecked((int)0xC0220025);

        /// <summary>
        /// A filter condition contains a match type that is not compatible with the operands.
        /// </summary>
        public const int STATUS_FWP_MATCH_TYPE_MISMATCH = unchecked((int)0xC0220026);

        /// <summary>
        /// An FWP_VALUE or FWPM_CONDITION_VALUE is of the wrong type.
        /// </summary>
        public const int STATUS_FWP_TYPE_MISMATCH = unchecked((int)0xC0220027);

        /// <summary>
        /// An integer value is outside the allowed range.
        /// </summary>
        public const int STATUS_FWP_OUT_OF_BOUNDS = unchecked((int)0xC0220028);

        /// <summary>
        /// A reserved field is non-zero.
        /// </summary>
        public const int STATUS_FWP_RESERVED = unchecked((int)0xC0220029);

        /// <summary>
        /// A filter cannot contain multiple conditions operating on a single field.
        /// </summary>
        public const int STATUS_FWP_DUPLICATE_CONDITION = unchecked((int)0xC022002A);

        /// <summary>
        /// A policy cannot contain the same keying module more than once.
        /// </summary>
        public const int STATUS_FWP_DUPLICATE_KEYMOD = unchecked((int)0xC022002B);

        /// <summary>
        /// The action type is not compatible with the layer.
        /// </summary>
        public const int STATUS_FWP_ACTION_INCOMPATIBLE_WITH_LAYER = unchecked((int)0xC022002C);

        /// <summary>
        /// The action type is not compatible with the sublayer.
        /// </summary>
        public const int STATUS_FWP_ACTION_INCOMPATIBLE_WITH_SUBLAYER = unchecked((int)0xC022002D);

        /// <summary>
        /// The raw context or the provider context is not compatible with the layer.
        /// </summary>
        public const int STATUS_FWP_CONTEXT_INCOMPATIBLE_WITH_LAYER = unchecked((int)0xC022002E);

        /// <summary>
        /// The raw context or the provider context is not compatible with the callout.
        /// </summary>
        public const int STATUS_FWP_CONTEXT_INCOMPATIBLE_WITH_CALLOUT = unchecked((int)0xC022002F);

        /// <summary>
        /// The authentication method is not compatible with the policy type.
        /// </summary>
        public const int STATUS_FWP_INCOMPATIBLE_AUTH_METHOD = unchecked((int)0xC0220030);

        /// <summary>
        /// The Diffie-Hellman group is not compatible with the policy type.
        /// </summary>
        public const int STATUS_FWP_INCOMPATIBLE_DH_GROUP = unchecked((int)0xC0220031);

        /// <summary>
        /// An IKE policy cannot contain an Extended Mode policy.
        /// </summary>
        public const int STATUS_FWP_EM_NOT_SUPPORTED = unchecked((int)0xC0220032);

        /// <summary>
        /// The enumeration template or subscription will never match any objects.
        /// </summary>
        public const int STATUS_FWP_NEVER_MATCH = unchecked((int)0xC0220033);

        /// <summary>
        /// The provider context is of the wrong type.
        /// </summary>
        public const int STATUS_FWP_PROVIDER_CONTEXT_MISMATCH = unchecked((int)0xC0220034);

        /// <summary>
        /// The parameter is incorrect.
        /// </summary>
        public const int STATUS_FWP_INVALID_PARAMETER = unchecked((int)0xC0220035);

        /// <summary>
        /// The maximum number of sublayers has been reached.
        /// </summary>
        public const int STATUS_FWP_TOO_MANY_SUBLAYERS = unchecked((int)0xC0220036);

        /// <summary>
        /// The notification function for a callout returned an error.
        /// </summary>
        public const int STATUS_FWP_CALLOUT_NOTIFICATION_FAILED = unchecked((int)0xC0220037);

        /// <summary>
        /// The IPsec authentication transform is not valid.
        /// </summary>
        public const int STATUS_FWP_INVALID_AUTH_TRANSFORM = unchecked((int)0xC0220038);

        /// <summary>
        /// The IPsec cipher transform is not valid.
        /// </summary>
        public const int STATUS_FWP_INVALID_CIPHER_TRANSFORM = unchecked((int)0xC0220039);

        /// <summary>
        /// The IPsec cipher transform is not compatible with the policy.
        /// </summary>
        public const int STATUS_FWP_INCOMPATIBLE_CIPHER_TRANSFORM = unchecked((int)0xC022003A);

        /// <summary>
        /// The combination of IPsec transform types is not valid.
        /// </summary>
        public const int STATUS_FWP_INVALID_TRANSFORM_COMBINATION = unchecked((int)0xC022003B);

        /// <summary>
        /// A policy cannot contain the same auth method more than once.
        /// </summary>
        public const int STATUS_FWP_DUPLICATE_AUTH_METHOD = unchecked((int)0xC022003C);

        /// <summary>
        /// A tunnel endpoint configuration is invalid.
        /// </summary>
        public const int STATUS_FWP_INVALID_TUNNEL_ENDPOINT = unchecked((int)0xC022003D);

        /// <summary>
        /// The WFP MAC Layers are not ready.
        /// </summary>
        public const int STATUS_FWP_L2_DRIVER_NOT_READY = unchecked((int)0xC022003E);

        /// <summary>
        /// A key manager capable of key dictation is already registered
        /// </summary>
        public const int STATUS_FWP_KEY_DICTATOR_ALREADY_REGISTERED = unchecked((int)0xC022003F);

        /// <summary>
        /// A key manager dictated invalid keys
        /// </summary>
        public const int STATUS_FWP_KEY_DICTATION_INVALID_KEYING_MATERIAL = unchecked((int)0xC0220040);

        /// <summary>
        /// The BFE IPsec Connection Tracking is disabled.
        /// </summary>
        public const int STATUS_FWP_CONNECTIONS_DISABLED = unchecked((int)0xC0220041);

        /// <summary>
        /// The DNS name is invalid.
        /// </summary>
        public const int STATUS_FWP_INVALID_DNS_NAME = unchecked((int)0xC0220042);

        /// <summary>
        /// The engine option is still enabled due to other configuration settings.
        /// </summary>
        public const int STATUS_FWP_STILL_ON = unchecked((int)0xC0220043);

        /// <summary>
        /// The IKEEXT service is not running.  This service only runs when there is IPsec policy applied to the machine.
        /// </summary>
        public const int STATUS_FWP_IKEEXT_NOT_RUNNING = unchecked((int)0xC0220044);

        /// <summary>
        /// The TCP/IP stack is not ready.
        /// </summary>
        public const int STATUS_FWP_TCPIP_NOT_READY = unchecked((int)0xC0220100);

        /// <summary>
        /// The injection handle is being closed by another thread.
        /// </summary>
        public const int STATUS_FWP_INJECT_HANDLE_CLOSING = unchecked((int)0xC0220101);

        /// <summary>
        /// The injection handle is stale.
        /// </summary>
        public const int STATUS_FWP_INJECT_HANDLE_STALE = unchecked((int)0xC0220102);

        /// <summary>
        /// The classify cannot be pended.
        /// </summary>
        public const int STATUS_FWP_CANNOT_PEND = unchecked((int)0xC0220103);

        /// <summary>
        /// The packet should be dropped, no ICMP should be sent.
        /// </summary>
        public const int STATUS_FWP_DROP_NOICMP = unchecked((int)0xC0220104);


        //
        // NDIS error codes (ndis.sys)
        //

        /// <summary>
        /// The binding to the network interface is being closed.
        /// </summary>
        public const int STATUS_NDIS_CLOSING = unchecked((int)0xC0230002);

        /// <summary>
        /// An invalid version was specified.
        /// </summary>
        public const int STATUS_NDIS_BAD_VERSION = unchecked((int)0xC0230004);

        /// <summary>
        /// An invalid characteristics table was used.
        /// </summary>
        public const int STATUS_NDIS_BAD_CHARACTERISTICS = unchecked((int)0xC0230005);

        /// <summary>
        /// Failed to find the network interface or network interface is not ready.
        /// </summary>
        public const int STATUS_NDIS_ADAPTER_NOT_FOUND = unchecked((int)0xC0230006);

        /// <summary>
        /// Failed to open the network interface.
        /// </summary>
        public const int STATUS_NDIS_OPEN_FAILED = unchecked((int)0xC0230007);

        /// <summary>
        /// Network interface has encountered an internal unrecoverable failure.
        /// </summary>
        public const int STATUS_NDIS_DEVICE_FAILED = unchecked((int)0xC0230008);

        /// <summary>
        /// The multicast list on the network interface is full.
        /// </summary>
        public const int STATUS_NDIS_MULTICAST_FULL = unchecked((int)0xC0230009);

        /// <summary>
        /// An attempt was made to add a duplicate multicast address to the list.
        /// </summary>
        public const int STATUS_NDIS_MULTICAST_EXISTS = unchecked((int)0xC023000A);

        /// <summary>
        /// At attempt was made to remove a multicast address that was never added.
        /// </summary>
        public const int STATUS_NDIS_MULTICAST_NOT_FOUND = unchecked((int)0xC023000B);

        /// <summary>
        /// Netowork interface aborted the request.
        /// </summary>
        public const int STATUS_NDIS_REQUEST_ABORTED = unchecked((int)0xC023000C);

        /// <summary>
        /// Network interface can not process the request because it is being reset.
        /// </summary>
        public const int STATUS_NDIS_RESET_IN_PROGRESS = unchecked((int)0xC023000D);

        /// <summary>
        /// Netword interface does not support this request.
        /// </summary>
        public const int STATUS_NDIS_NOT_SUPPORTED = unchecked((int)0xC02300BB);

        /// <summary>
        /// An attempt was made to send an invalid packet on a network interface.
        /// </summary>
        public const int STATUS_NDIS_INVALID_PACKET = unchecked((int)0xC023000F);

        /// <summary>
        /// Network interface is not ready to complete this operation.
        /// </summary>
        public const int STATUS_NDIS_ADAPTER_NOT_READY = unchecked((int)0xC0230011);

        /// <summary>
        /// The length of the buffer submitted for this operation is not valid.
        /// </summary>
        public const int STATUS_NDIS_INVALID_LENGTH = unchecked((int)0xC0230014);

        /// <summary>
        /// The data used for this operation is not valid.
        /// </summary>
        public const int STATUS_NDIS_INVALID_DATA = unchecked((int)0xC0230015);

        /// <summary>
        /// The length of buffer submitted for this operation is too small.
        /// </summary>
        public const int STATUS_NDIS_BUFFER_TOO_SHORT = unchecked((int)0xC0230016);

        /// <summary>
        /// Network interface does not support this OID (Object Identifier)
        /// </summary>
        public const int STATUS_NDIS_INVALID_OID = unchecked((int)0xC0230017);

        /// <summary>
        /// The network interface has been removed.
        /// </summary>
        public const int STATUS_NDIS_ADAPTER_REMOVED = unchecked((int)0xC0230018);

        /// <summary>
        /// Network interface does not support this media type.
        /// </summary>
        public const int STATUS_NDIS_UNSUPPORTED_MEDIA = unchecked((int)0xC0230019);

        /// <summary>
        /// An attempt was made to remove a token ring group address that is in use by other components.
        /// </summary>
        public const int STATUS_NDIS_GROUP_ADDRESS_IN_USE = unchecked((int)0xC023001A);

        /// <summary>
        /// An attempt was made to map a file that can not be found.
        /// </summary>
        public const int STATUS_NDIS_FILE_NOT_FOUND = unchecked((int)0xC023001B);

        /// <summary>
        /// An error occurred while NDIS tried to map the file.
        /// </summary>
        public const int STATUS_NDIS_ERROR_READING_FILE = unchecked((int)0xC023001C);

        /// <summary>
        /// An attempt was made to map a file that is alreay mapped.
        /// </summary>
        public const int STATUS_NDIS_ALREADY_MAPPED = unchecked((int)0xC023001D);

        /// <summary>
        /// An attempt to allocate a hardware resource failed because the resource is used by another component.
        /// </summary>
        public const int STATUS_NDIS_RESOURCE_CONFLICT = unchecked((int)0xC023001E);

        /// <summary>
        /// The I/O operation failed because network media is disconnected or wireless access point is out of range.
        /// </summary>
        public const int STATUS_NDIS_MEDIA_DISCONNECTED = unchecked((int)0xC023001F);

        /// <summary>
        /// The network address used in the request is invalid.
        /// </summary>
        public const int STATUS_NDIS_INVALID_ADDRESS = unchecked((int)0xC0230022);

        /// <summary>
        /// The specified request is not a valid operation for the target device.
        /// </summary>
        public const int STATUS_NDIS_INVALID_DEVICE_REQUEST = unchecked((int)0xC0230010);

        /// <summary>
        /// The offload operation on the network interface has been paused.
        /// </summary>
        public const int STATUS_NDIS_PAUSED = unchecked((int)0xC023002A);

        /// <summary>
        /// Network interface was not found.
        /// </summary>
        public const int STATUS_NDIS_INTERFACE_NOT_FOUND = unchecked((int)0xC023002B);

        /// <summary>
        /// The revision number specified in the structure is not supported.
        /// </summary>
        public const int STATUS_NDIS_UNSUPPORTED_REVISION = unchecked((int)0xC023002C);

        /// <summary>
        /// The specified port does not exist on this network interface.
        /// </summary>
        public const int STATUS_NDIS_INVALID_PORT = unchecked((int)0xC023002D);

        /// <summary>
        /// The current state of the specified port on this network interface does not support the requested operation.
        /// </summary>
        public const int STATUS_NDIS_INVALID_PORT_STATE = unchecked((int)0xC023002E);

        /// <summary>
        /// The miniport adapter is in lower power state.
        /// </summary>
        public const int STATUS_NDIS_LOW_POWER_STATE = unchecked((int)0xC023002F);

        /// <summary>
        /// This operation requires the miniport adapter to be reinitialized.
        /// </summary>
        public const int STATUS_NDIS_REINIT_REQUIRED = unchecked((int)0xC0230030);


        //
        // NDIS error codes (802.11 wireless LAN)
        //

        /// <summary>
        /// The wireless local area network interface is in auto configuration mode and doesn't support the requested parameter change operation.
        /// </summary>
        public const int STATUS_NDIS_DOT11_AUTO_CONFIG_ENABLED = unchecked((int)0xC0232000);

        /// <summary>
        /// The wireless local area network interface is busy and can not perform the requested operation.
        /// </summary>
        public const int STATUS_NDIS_DOT11_MEDIA_IN_USE = unchecked((int)0xC0232001);

        /// <summary>
        /// The wireless local area network interface is powered down and doesn't support the requested operation.
        /// </summary>
        public const int STATUS_NDIS_DOT11_POWER_STATE_INVALID = unchecked((int)0xC0232002);

        /// <summary>
        /// The list of wake on LAN patterns is full.
        /// </summary>
        public const int STATUS_NDIS_PM_WOL_PATTERN_LIST_FULL = unchecked((int)0xC0232003);

        /// <summary>
        /// The list of low power protocol offloads is full.
        /// </summary>
        public const int STATUS_NDIS_PM_PROTOCOL_OFFLOAD_LIST_FULL = unchecked((int)0xC0232004);

        /// <summary>
        /// The wireless local area network interface cannot start an AP on the specified channel right now.
        /// </summary>
        public const int STATUS_NDIS_DOT11_AP_CHANNEL_CURRENTLY_NOT_AVAILABLE = unchecked((int)0xC0232005);

        /// <summary>
        /// The wireless local area network interface cannot start an AP on the specified band right now.
        /// </summary>
        public const int STATUS_NDIS_DOT11_AP_BAND_CURRENTLY_NOT_AVAILABLE = unchecked((int)0xC0232006);

        /// <summary>
        /// The wireless local area network interface cannot start an AP on this channel due to regulatory reasons.
        /// </summary>
        public const int STATUS_NDIS_DOT11_AP_CHANNEL_NOT_ALLOWED = unchecked((int)0xC0232007);

        /// <summary>
        /// The wireless local area network interface cannot start an AP on this band due to regulatory reasons.
        /// </summary>
        public const int STATUS_NDIS_DOT11_AP_BAND_NOT_ALLOWED = unchecked((int)0xC0232008);

        //
        // NDIS informational codes(ndis.sys)
        //

        /// <summary>
        /// The request will be completed later by NDIS status indication.
        /// </summary>
        public const int STATUS_NDIS_INDICATION_REQUIRED = 0x40230001;

        //
        // NDIS Chimney Offload codes (ndis.sys)
        //

        /// <summary>
        /// The TCP connection is not offloadable because of a local policy setting.
        /// </summary>
        public const int STATUS_NDIS_OFFLOAD_POLICY = unchecked((int)0xC023100F);

        /// <summary>
        /// The TCP connection is not offloadable by the Chimney offload target.
        /// </summary>
        public const int STATUS_NDIS_OFFLOAD_CONNECTION_REJECTED = unchecked((int)0xC0231012);

        /// <summary>
        /// The IP Path object is not in an offloadable state.
        /// </summary>
        public const int STATUS_NDIS_OFFLOAD_PATH_REJECTED = unchecked((int)0xC0231013);

        //
        // TPM hardware errors {0x0000..0x003ff}
        //
        /// <summary>
        /// This is an error mask to convert TPM hardware errors to win errors.
        /// </summary>
        public const int STATUS_TPM_ERROR_MASK = unchecked((int)0xC0290000);

        /// <summary>
        /// Authentication failed.
        /// </summary>
        public const int STATUS_TPM_AUTHFAIL = unchecked((int)0xC0290001);

        /// <summary>
        /// The index to a PCR, DIR or other register is incorrect.
        /// </summary>
        public const int STATUS_TPM_BADINDEX = unchecked((int)0xC0290002);

        /// <summary>
        /// One or more parameter is bad.
        /// </summary>
        public const int STATUS_TPM_BAD_PARAMETER = unchecked((int)0xC0290003);

        /// <summary>
        /// An operation completed successfully but the auditing of that operation failed.
        /// </summary>
        public const int STATUS_TPM_AUDITFAILURE = unchecked((int)0xC0290004);

        /// <summary>
        /// The clear disable flag is set and all clear operations now require physical access.
        /// </summary>
        public const int STATUS_TPM_CLEAR_DISABLED = unchecked((int)0xC0290005);

        /// <summary>
        /// Activate the Trusted Platform Module (TPM).
        /// </summary>
        public const int STATUS_TPM_DEACTIVATED = unchecked((int)0xC0290006);

        /// <summary>
        /// Enable the Trusted Platform Module (TPM).
        /// </summary>
        public const int STATUS_TPM_DISABLED = unchecked((int)0xC0290007);

        /// <summary>
        /// The target command has been disabled.
        /// </summary>
        public const int STATUS_TPM_DISABLED_CMD = unchecked((int)0xC0290008);

        /// <summary>
        /// The operation failed.
        /// </summary>
        public const int STATUS_TPM_FAIL = unchecked((int)0xC0290009);

        /// <summary>
        /// The ordinal was unknown or inconsistent.
        /// </summary>
        public const int STATUS_TPM_BAD_ORDINAL = unchecked((int)0xC029000A);

        /// <summary>
        /// The ability to install an owner is disabled.
        /// </summary>
        public const int STATUS_TPM_INSTALL_DISABLED = unchecked((int)0xC029000B);

        /// <summary>
        /// The key handle cannot be interpreted.
        /// </summary>
        public const int STATUS_TPM_INVALID_KEYHANDLE = unchecked((int)0xC029000C);

        /// <summary>
        /// The key handle points to an invalid key.
        /// </summary>
        public const int STATUS_TPM_KEYNOTFOUND = unchecked((int)0xC029000D);

        /// <summary>
        /// Unacceptable encryption scheme.
        /// </summary>
        public const int STATUS_TPM_INAPPROPRIATE_ENC = unchecked((int)0xC029000E);

        /// <summary>
        /// Migration authorization failed.
        /// </summary>
        public const int STATUS_TPM_MIGRATEFAIL = unchecked((int)0xC029000F);

        /// <summary>
        /// PCR information could not be interpreted.
        /// </summary>
        public const int STATUS_TPM_INVALID_PCR_INFO = unchecked((int)0xC0290010);

        /// <summary>
        /// No room to load key.
        /// </summary>
        public const int STATUS_TPM_NOSPACE = unchecked((int)0xC0290011);

        /// <summary>
        /// There is no Storage Root Key (SRK) set.
        /// </summary>
        public const int STATUS_TPM_NOSRK = unchecked((int)0xC0290012);

        /// <summary>
        /// An encrypted blob is invalid or was not created by this TPM.
        /// </summary>
        public const int STATUS_TPM_NOTSEALED_BLOB = unchecked((int)0xC0290013);

        /// <summary>
        /// The Trusted Platform Module (TPM) already has an owner.
        /// </summary>
        public const int STATUS_TPM_OWNER_SET = unchecked((int)0xC0290014);

        /// <summary>
        /// The TPM has insufficient internal resources to perform the requested action.
        /// </summary>
        public const int STATUS_TPM_RESOURCES = unchecked((int)0xC0290015);

        /// <summary>
        /// A random string was too short.
        /// </summary>
        public const int STATUS_TPM_SHORTRANDOM = unchecked((int)0xC0290016);

        /// <summary>
        /// The TPM does not have the space to perform the operation.
        /// </summary>
        public const int STATUS_TPM_SIZE = unchecked((int)0xC0290017);

        /// <summary>
        /// The named PCR value does not match the current PCR value.
        /// </summary>
        public const int STATUS_TPM_WRONGPCRVAL = unchecked((int)0xC0290018);

        /// <summary>
        /// The paramSize argument to the command has the incorrect value .
        /// </summary>
        public const int STATUS_TPM_BAD_PARAM_SIZE = unchecked((int)0xC0290019);

        /// <summary>
        /// There is no existing SHA-1 thread.
        /// </summary>
        public const int STATUS_TPM_SHA_THREAD = unchecked((int)0xC029001A);

        /// <summary>
        /// The calculation is unable to proceed because the existing SHA-1 thread has already encountered an error.
        /// </summary>
        public const int STATUS_TPM_SHA_ERROR = unchecked((int)0xC029001B);

        /// <summary>
        /// The TPM hardware device reported a failure during its internal self test. Try restarting the computer to resolve the problem. If the problem continues, you might need to replace your TPM hardware or motherboard.
        /// </summary>
        public const int STATUS_TPM_FAILEDSELFTEST = unchecked((int)0xC029001C);

        /// <summary>
        /// The authorization for the second key in a 2 key function failed authorization.
        /// </summary>
        public const int STATUS_TPM_AUTH2FAIL = unchecked((int)0xC029001D);

        /// <summary>
        /// The tag value sent to for a command is invalid.
        /// </summary>
        public const int STATUS_TPM_BADTAG = unchecked((int)0xC029001E);

        /// <summary>
        /// An IO error occurred transmitting information to the TPM.
        /// </summary>
        public const int STATUS_TPM_IOERROR = unchecked((int)0xC029001F);

        /// <summary>
        /// The encryption process had a problem.
        /// </summary>
        public const int STATUS_TPM_ENCRYPT_ERROR = unchecked((int)0xC0290020);

        /// <summary>
        /// The decryption process did not complete.
        /// </summary>
        public const int STATUS_TPM_DECRYPT_ERROR = unchecked((int)0xC0290021);

        /// <summary>
        /// An invalid handle was used.
        /// </summary>
        public const int STATUS_TPM_INVALID_AUTHHANDLE = unchecked((int)0xC0290022);

        /// <summary>
        /// The TPM does not have an Endorsement Key (EK) installed.
        /// </summary>
        public const int STATUS_TPM_NO_ENDORSEMENT = unchecked((int)0xC0290023);

        /// <summary>
        /// The usage of a key is not allowed.
        /// </summary>
        public const int STATUS_TPM_INVALID_KEYUSAGE = unchecked((int)0xC0290024);

        /// <summary>
        /// The submitted entity type is not allowed.
        /// </summary>
        public const int STATUS_TPM_WRONG_ENTITYTYPE = unchecked((int)0xC0290025);

        /// <summary>
        /// The command was received in the wrong sequence relative to TPM_Init and a subsequent TPM_Startup.
        /// </summary>
        public const int STATUS_TPM_INVALID_POSTINIT = unchecked((int)0xC0290026);

        /// <summary>
        /// Signed data cannot include additional DER information.
        /// </summary>
        public const int STATUS_TPM_INAPPROPRIATE_SIG = unchecked((int)0xC0290027);

        /// <summary>
        /// The key properties in TPM_KEY_PARMs are not supported by this TPM.
        /// </summary>
        public const int STATUS_TPM_BAD_KEY_PROPERTY = unchecked((int)0xC0290028);

        /// <summary>
        /// The migration properties of this key are incorrect.
        /// </summary>
        public const int STATUS_TPM_BAD_MIGRATION = unchecked((int)0xC0290029);

        /// <summary>
        /// The signature or encryption scheme for this key is incorrect or not permitted in this situation.
        /// </summary>
        public const int STATUS_TPM_BAD_SCHEME = unchecked((int)0xC029002A);

        /// <summary>
        /// The size of the data (or blob) parameter is bad or inconsistent with the referenced key.
        /// </summary>
        public const int STATUS_TPM_BAD_DATASIZE = unchecked((int)0xC029002B);

        /// <summary>
        /// A mode parameter is bad, such as capArea or subCapArea for TPM_GetCapability, phsicalPresence parameter for TPM_PhysicalPresence, or migrationType for TPM_CreateMigrationBlob.
        /// </summary>
        public const int STATUS_TPM_BAD_MODE = unchecked((int)0xC029002C);

        /// <summary>
        /// Either the physicalPresence or physicalPresenceLock bits have the wrong value.
        /// </summary>
        public const int STATUS_TPM_BAD_PRESENCE = unchecked((int)0xC029002D);

        /// <summary>
        /// The TPM cannot perform this version of the capability.
        /// </summary>
        public const int STATUS_TPM_BAD_VERSION = unchecked((int)0xC029002E);

        /// <summary>
        /// The TPM does not allow for wrapped transport sessions.
        /// </summary>
        public const int STATUS_TPM_NO_WRAP_TRANSPORT = unchecked((int)0xC029002F);

        /// <summary>
        /// TPM audit construction failed and the underlying command was returning a failure code also.
        /// </summary>
        public const int STATUS_TPM_AUDITFAIL_UNSUCCESSFUL = unchecked((int)0xC0290030);

        /// <summary>
        /// TPM audit construction failed and the underlying command was returning success.
        /// </summary>
        public const int STATUS_TPM_AUDITFAIL_SUCCESSFUL = unchecked((int)0xC0290031);

        /// <summary>
        /// Attempt to reset a PCR register that does not have the resettable attribute.
        /// </summary>
        public const int STATUS_TPM_NOTRESETABLE = unchecked((int)0xC0290032);

        /// <summary>
        /// Attempt to reset a PCR register that requires locality and locality modifier not part of command transport.
        /// </summary>
        public const int STATUS_TPM_NOTLOCAL = unchecked((int)0xC0290033);

        /// <summary>
        /// Make identity blob not properly typed.
        /// </summary>
        public const int STATUS_TPM_BAD_TYPE = unchecked((int)0xC0290034);

        /// <summary>
        /// When saving context identified resource type does not match actual resource.
        /// </summary>
        public const int STATUS_TPM_INVALID_RESOURCE = unchecked((int)0xC0290035);

        /// <summary>
        /// The TPM is attempting to execute a command only available when in FIPS mode.
        /// </summary>
        public const int STATUS_TPM_NOTFIPS = unchecked((int)0xC0290036);

        /// <summary>
        /// The command is attempting to use an invalid family ID.
        /// </summary>
        public const int STATUS_TPM_INVALID_FAMILY = unchecked((int)0xC0290037);

        /// <summary>
        /// The permission to manipulate the NV storage is not available.
        /// </summary>
        public const int STATUS_TPM_NO_NV_PERMISSION = unchecked((int)0xC0290038);

        /// <summary>
        /// The operation requires a signed command.
        /// </summary>
        public const int STATUS_TPM_REQUIRES_SIGN = unchecked((int)0xC0290039);

        /// <summary>
        /// Wrong operation to load an NV key.
        /// </summary>
        public const int STATUS_TPM_KEY_NOTSUPPORTED = unchecked((int)0xC029003A);

        /// <summary>
        /// NV_LoadKey blob requires both owner and blob authorization.
        /// </summary>
        public const int STATUS_TPM_AUTH_CONFLICT = unchecked((int)0xC029003B);

        /// <summary>
        /// The NV area is locked and not writtable.
        /// </summary>
        public const int STATUS_TPM_AREA_LOCKED = unchecked((int)0xC029003C);

        /// <summary>
        /// The locality is incorrect for the attempted operation.
        /// </summary>
        public const int STATUS_TPM_BAD_LOCALITY = unchecked((int)0xC029003D);

        /// <summary>
        /// The NV area is read only and can't be written to.
        /// </summary>
        public const int STATUS_TPM_READ_ONLY = unchecked((int)0xC029003E);

        /// <summary>
        /// There is no protection on the write to the NV area.
        /// </summary>
        public const int STATUS_TPM_PER_NOWRITE = unchecked((int)0xC029003F);

        /// <summary>
        /// The family count value does not match.
        /// </summary>
        public const int STATUS_TPM_FAMILYCOUNT = unchecked((int)0xC0290040);

        /// <summary>
        /// The NV area has already been written to.
        /// </summary>
        public const int STATUS_TPM_WRITE_LOCKED = unchecked((int)0xC0290041);

        /// <summary>
        /// The NV area attributes conflict.
        /// </summary>
        public const int STATUS_TPM_BAD_ATTRIBUTES = unchecked((int)0xC0290042);

        /// <summary>
        /// The structure tag and version are invalid or inconsistent.
        /// </summary>
        public const int STATUS_TPM_INVALID_STRUCTURE = unchecked((int)0xC0290043);

        /// <summary>
        /// The key is under control of the TPM Owner and can only be evicted by the TPM Owner.
        /// </summary>
        public const int STATUS_TPM_KEY_OWNER_CONTROL = unchecked((int)0xC0290044);

        /// <summary>
        /// The counter handle is incorrect.
        /// </summary>
        public const int STATUS_TPM_BAD_COUNTER = unchecked((int)0xC0290045);

        /// <summary>
        /// The write is not a complete write of the area.
        /// </summary>
        public const int STATUS_TPM_NOT_FULLWRITE = unchecked((int)0xC0290046);

        /// <summary>
        /// The gap between saved context counts is too large.
        /// </summary>
        public const int STATUS_TPM_CONTEXT_GAP = unchecked((int)0xC0290047);

        /// <summary>
        /// The maximum number of NV writes without an owner has been exceeded.
        /// </summary>
        public const int STATUS_TPM_MAXNVWRITES = unchecked((int)0xC0290048);

        /// <summary>
        /// No operator AuthData value is set.
        /// </summary>
        public const int STATUS_TPM_NOOPERATOR = unchecked((int)0xC0290049);

        /// <summary>
        /// The resource pointed to by context is not loaded.
        /// </summary>
        public const int STATUS_TPM_RESOURCEMISSING = unchecked((int)0xC029004A);

        /// <summary>
        /// The delegate administration is locked.
        /// </summary>
        public const int STATUS_TPM_DELEGATE_LOCK = unchecked((int)0xC029004B);

        /// <summary>
        /// Attempt to manage a family other then the delegated family.
        /// </summary>
        public const int STATUS_TPM_DELEGATE_FAMILY = unchecked((int)0xC029004C);

        /// <summary>
        /// Delegation table management not enabled.
        /// </summary>
        public const int STATUS_TPM_DELEGATE_ADMIN = unchecked((int)0xC029004D);

        /// <summary>
        /// There was a command executed outside of an exclusive transport session.
        /// </summary>
        public const int STATUS_TPM_TRANSPORT_NOTEXCLUSIVE = unchecked((int)0xC029004E);

        /// <summary>
        /// Attempt to context save a owner evict controlled key.
        /// </summary>
        public const int STATUS_TPM_OWNER_CONTROL = unchecked((int)0xC029004F);

        /// <summary>
        /// The DAA command has no resources availble to execute the command.
        /// </summary>
        public const int STATUS_TPM_DAA_RESOURCES = unchecked((int)0xC0290050);

        /// <summary>
        /// The consistency check on DAA parameter inputData0 has failed.
        /// </summary>
        public const int STATUS_TPM_DAA_INPUT_DATA0 = unchecked((int)0xC0290051);

        /// <summary>
        /// The consistency check on DAA parameter inputData1 has failed.
        /// </summary>
        public const int STATUS_TPM_DAA_INPUT_DATA1 = unchecked((int)0xC0290052);

        /// <summary>
        /// The consistency check on DAA_issuerSettings has failed.
        /// </summary>
        public const int STATUS_TPM_DAA_ISSUER_SETTINGS = unchecked((int)0xC0290053);

        /// <summary>
        /// The consistency check on DAA_tpmSpecific has failed.
        /// </summary>
        public const int STATUS_TPM_DAA_TPM_SETTINGS = unchecked((int)0xC0290054);

        /// <summary>
        /// The atomic process indicated by the submitted DAA command is not the expected process.
        /// </summary>
        public const int STATUS_TPM_DAA_STAGE = unchecked((int)0xC0290055);

        /// <summary>
        /// The issuer's validity check has detected an inconsistency.
        /// </summary>
        public const int STATUS_TPM_DAA_ISSUER_VALIDITY = unchecked((int)0xC0290056);

        /// <summary>
        /// The consistency check on w has failed.
        /// </summary>
        public const int STATUS_TPM_DAA_WRONG_W = unchecked((int)0xC0290057);

        /// <summary>
        /// The handle is incorrect.
        /// </summary>
        public const int STATUS_TPM_BAD_HANDLE = unchecked((int)0xC0290058);

        /// <summary>
        /// Delegation is not correct.
        /// </summary>
        public const int STATUS_TPM_BAD_DELEGATE = unchecked((int)0xC0290059);

        /// <summary>
        /// The context blob is invalid.
        /// </summary>
        public const int STATUS_TPM_BADCONTEXT = unchecked((int)0xC029005A);

        /// <summary>
        /// Too many contexts held by the TPM.
        /// </summary>
        public const int STATUS_TPM_TOOMANYCONTEXTS = unchecked((int)0xC029005B);

        /// <summary>
        /// Migration authority signature validation failure.
        /// </summary>
        public const int STATUS_TPM_MA_TICKET_SIGNATURE = unchecked((int)0xC029005C);

        /// <summary>
        /// Migration destination not authenticated.
        /// </summary>
        public const int STATUS_TPM_MA_DESTINATION = unchecked((int)0xC029005D);

        /// <summary>
        /// Migration source incorrect.
        /// </summary>
        public const int STATUS_TPM_MA_SOURCE = unchecked((int)0xC029005E);

        /// <summary>
        /// Incorrect migration authority.
        /// </summary>
        public const int STATUS_TPM_MA_AUTHORITY = unchecked((int)0xC029005F);

        /// <summary>
        /// Attempt to revoke the EK and the EK is not revocable.
        /// </summary>
        public const int STATUS_TPM_PERMANENTEK = unchecked((int)0xC0290061);

        /// <summary>
        /// Bad signature of CMK ticket.
        /// </summary>
        public const int STATUS_TPM_BAD_SIGNATURE = unchecked((int)0xC0290062);

        /// <summary>
        /// There is no room in the context list for additional contexts.
        /// </summary>
        public const int STATUS_TPM_NOCONTEXTSPACE = unchecked((int)0xC0290063);

        //
        // TPM vendor specific hardware errors {0x0400..0x04ff}
        //
        /// <summary>
        /// The command was blocked.
        /// </summary>
        public const int STATUS_TPM_COMMAND_BLOCKED = unchecked((int)0xC0290400);

        /// <summary>
        /// The specified handle was not found.
        /// </summary>
        public const int STATUS_TPM_INVALID_HANDLE = unchecked((int)0xC0290401);

        /// <summary>
        /// The TPM returned a duplicate handle and the command needs to be resubmitted.
        /// </summary>
        public const int STATUS_TPM_DUPLICATE_VHANDLE = unchecked((int)0xC0290402);

        /// <summary>
        /// The command within the transport was blocked.
        /// </summary>
        public const int STATUS_TPM_EMBEDDED_COMMAND_BLOCKED = unchecked((int)0xC0290403);

        /// <summary>
        /// The command within the transport is not supported.
        /// </summary>
        public const int STATUS_TPM_EMBEDDED_COMMAND_UNSUPPORTED = unchecked((int)0xC0290404);

        //
        // TPM non-fatal hardware errors {0x0800..0x08ff}
        //
        /// <summary>
        /// The TPM is too busy to respond to the command immediately, but the command could be resubmitted at a later time.
        /// </summary>
        public const int STATUS_TPM_RETRY = unchecked((int)0xC0290800);

        /// <summary>
        /// SelfTestFull has not been run.
        /// </summary>
        public const int STATUS_TPM_NEEDS_SELFTEST = unchecked((int)0xC0290801);

        /// <summary>
        /// The TPM is currently executing a full selftest.
        /// </summary>
        public const int STATUS_TPM_DOING_SELFTEST = unchecked((int)0xC0290802);

        /// <summary>
        /// The TPM is defending against dictionary attacks and is in a time-out period.
        /// </summary>
        public const int STATUS_TPM_DEFEND_LOCK_RUNNING = unchecked((int)0xC0290803);


        //
        // TPM software Error codes (tpm.sys)
        //

        /// <summary>
        /// The command was cancelled.
        /// </summary>
        public const int STATUS_TPM_COMMAND_CANCELED = unchecked((int)0xC0291001);

        /// <summary>
        /// A new TPM context could not be created because there are too many open contexts.
        /// </summary>
        public const int STATUS_TPM_TOO_MANY_CONTEXTS = unchecked((int)0xC0291002);

        /// <summary>
        /// TPM driver is not compatible with the version of TPM found on the system.
        /// </summary>
        public const int STATUS_TPM_NOT_FOUND = unchecked((int)0xC0291003);

        /// <summary>
        /// The caller does not have the appropriate rights to perform the requested operation.
        /// </summary>
        public const int STATUS_TPM_ACCESS_DENIED = unchecked((int)0xC0291004);

        /// <summary>
        /// The caller does not have the appropriate rights to perform the requested operation.
        /// </summary>
        public const int STATUS_TPM_INSUFFICIENT_BUFFER = unchecked((int)0xC0291005);

        /// <summary>
        /// The Physical Presence Interface of this firmware does not support the requested method.
        /// </summary>
        public const int STATUS_TPM_PPI_FUNCTION_UNSUPPORTED = unchecked((int)0xC0291006);


        //
        // Platform Crypto Provider Error Codes (PCPKSP.dll and future platform crypto providers)
        //

        /// <summary>
        /// This is an error mask to convert Platform Crypto Provider errors to win errors.
        /// </summary>
        public const int STATUS_PCP_ERROR_MASK = unchecked((int)0xC0292000);

        /// <summary>
        /// The Platform Crypto Device is currently not ready. It needs to be fully provisioned to be operational.
        /// </summary>
        public const int STATUS_PCP_DEVICE_NOT_READY = unchecked((int)0xC0292001);

        /// <summary>
        /// The handle provided to the Platform Crypto Provider is invalid.
        /// </summary>
        public const int STATUS_PCP_INVALID_HANDLE = unchecked((int)0xC0292002);

        /// <summary>
        /// A parameter provided to the Platform Crypto Provider is invalid.
        /// </summary>
        public const int STATUS_PCP_INVALID_PARAMETER = unchecked((int)0xC0292003);

        /// <summary>
        /// A provided flag to the Platform Crypto Provider is not supported.
        /// </summary>
        public const int STATUS_PCP_FLAG_NOT_SUPPORTED = unchecked((int)0xC0292004);

        /// <summary>
        /// The requested operation is not supported by this Platform Crypto Provider.
        /// </summary>
        public const int STATUS_PCP_NOT_SUPPORTED = unchecked((int)0xC0292005);

        /// <summary>
        /// The buffer is too small to contain all data. No information has been written to the buffer.
        /// </summary>
        public const int STATUS_PCP_BUFFER_TOO_SMALL = unchecked((int)0xC0292006);

        /// <summary>
        /// An unexpected internal error has occurred in the Platform Crypto Provider.
        /// </summary>
        public const int STATUS_PCP_INTERNAL_ERROR = unchecked((int)0xC0292007);

        /// <summary>
        /// The authorization to use a provider object has failed.
        /// </summary>
        public const int STATUS_PCP_AUTHENTICATION_FAILED = unchecked((int)0xC0292008);

        /// <summary>
        /// The Platform Crypto Device has ignored the authorization for the provider object, to mitigate against a dictionary attack.
        /// </summary>
        public const int STATUS_PCP_AUTHENTICATION_IGNORED = unchecked((int)0xC0292009);

        /// <summary>
        /// The referenced policy was not found.
        /// </summary>
        public const int STATUS_PCP_POLICY_NOT_FOUND = unchecked((int)0xC029200A);

        /// <summary>
        /// The referenced profile was not found.
        /// </summary>
        public const int STATUS_PCP_PROFILE_NOT_FOUND = unchecked((int)0xC029200B);

        /// <summary>
        /// The validation was not succesful.
        /// </summary>
        public const int STATUS_PCP_VALIDATION_FAILED = unchecked((int)0xC029200C);

        /// <summary>
        /// A Platform Crypto Device was not found.  Operations that require a Platform Crypto Device will not be submitted.
        /// </summary>
        public const int STATUS_PCP_DEVICE_NOT_FOUND = unchecked((int)0xC029200D);

        /// <summary>
        /// An attempt was made to import or load a key under an incorrect storage parent.
        /// </summary>
        public const int STATUS_PCP_WRONG_PARENT = unchecked((int)0xC029200E);

        /// <summary>
        /// The TPM key is not loaded.
        /// </summary>
        public const int STATUS_PCP_KEY_NOT_LOADED = unchecked((int)0xC029200F);

        /// <summary>
        /// The TPM key certification has not been generated.
        /// </summary>
        public const int STATUS_PCP_NO_KEY_CERTIFICATION = unchecked((int)0xC0292010);

        /// <summary>
        /// The TPM key is not yet finalized.
        /// </summary>
        public const int STATUS_PCP_KEY_NOT_FINALIZED = unchecked((int)0xC0292011);

        /// <summary>
        /// The TPM attestation challenge is not set.
        /// </summary>
        public const int STATUS_PCP_ATTESTATION_CHALLENGE_NOT_SET = unchecked((int)0xC0292012);

        /// <summary>
        /// The TPM key is not bound to PCR info.
        /// </summary>
        public const int STATUS_PCP_NOT_PCR_BOUND = unchecked((int)0xC0292013);

        /// <summary>
        /// The TPM key is already finalized.
        /// </summary>
        public const int STATUS_PCP_KEY_ALREADY_FINALIZED = unchecked((int)0xC0292014);

        /// <summary>
        /// The TPM key usage policy is not supported.
        /// </summary>
        public const int STATUS_PCP_KEY_USAGE_POLICY_NOT_SUPPORTED = unchecked((int)0xC0292015);

        /// <summary>
        /// The TPM key usage policy is invalid.
        /// </summary>
        public const int STATUS_PCP_KEY_USAGE_POLICY_INVALID = unchecked((int)0xC0292016);

        /// <summary>
        /// There was a problem with the software key being imported into the TPM.
        /// </summary>
        public const int STATUS_PCP_SOFT_KEY_ERROR = unchecked((int)0xC0292017);

        /// <summary>
        /// The TPM key is not authenticated.
        /// </summary>
        public const int STATUS_PCP_KEY_NOT_AUTHENTICATED = unchecked((int)0xC0292018);

        /// <summary>
        /// The TPM key is not an AIK.
        /// </summary>
        public const int STATUS_PCP_KEY_NOT_AIK = unchecked((int)0xC0292019);

        /// <summary>
        /// The TPM key is not a signing key.
        /// </summary>
        public const int STATUS_PCP_KEY_NOT_SIGNING_KEY = unchecked((int)0xC029201A);

        /// <summary>
        /// The TPM is locked out.
        /// </summary>
        public const int STATUS_PCP_LOCKED_OUT = unchecked((int)0xC029201B);

        /// <summary>
        /// The claim type requested is not supported.
        /// </summary>
        public const int STATUS_PCP_CLAIM_TYPE_NOT_SUPPORTED = unchecked((int)0xC029201C);

        /// <summary>
        /// The current TPM version is not supported.
        /// </summary>
        public const int STATUS_PCP_TPM_VERSION_NOT_SUPPORTED = unchecked((int)0xC029201D);

        /// <summary>
        /// The buffer lengths do not match.
        /// </summary>
        public const int STATUS_PCP_BUFFER_LENGTH_MISMATCH = unchecked((int)0xC029201E);

        /// <summary>
        /// The RSA key creation is blocked on this TPM due to known security vulnerabilities.
        /// </summary>
        public const int STATUS_PCP_IFX_RSA_KEY_CREATION_BLOCKED = unchecked((int)0xC029201F);

        /// <summary>
        /// A ticket required to use a key was not provided.
        /// </summary>
        public const int STATUS_PCP_TICKET_MISSING = unchecked((int)0xC0292020);

        /// <summary>
        /// This key has a raw policy so the KSP can't authenticate against it.
        /// </summary>
        public const int STATUS_PCP_RAW_POLICY_NOT_SUPPORTED = unchecked((int)0xC0292021);


        //
        // Remote TPM Error Codes
        //

        /// <summary>
        /// The remote TPM context exchange is not complete. The context should be transported to the target and continued.
        /// </summary>
        public const int STATUS_RTPM_CONTEXT_CONTINUE = 0x00293000;

        /// <summary>
        /// The remote TPM operation is complete.
        /// </summary>
        public const int STATUS_RTPM_CONTEXT_COMPLETE = 0x00293001;

        /// <summary>
        /// No result associated with this instance exists.
        /// </summary>
        public const int STATUS_RTPM_NO_RESULT = unchecked((int)0xC0293002);

        /// <summary>
        /// The TPM returned incomplete PCR results. This maybe due to an unsupported selection set. Attempt the read again with a different selection set.
        /// </summary>
        public const int STATUS_RTPM_PCR_READ_INCOMPLETE = unchecked((int)0xC0293003);

        /// <summary>
        /// The rTPM context has been corrupted. The rTPM operation must be restarted.
        /// </summary>
        public const int STATUS_RTPM_INVALID_CONTEXT = unchecked((int)0xC0293004);

        /// <summary>
        /// The rTPM target does not support remote processing of the specified TPM command.
        /// </summary>
        public const int STATUS_RTPM_UNSUPPORTED_CMD = unchecked((int)0xC0293005);


        //
        // Misc TPM Error Codes
        //

        /// <summary>
        /// TPM related network operations are blocked as Zero Exhaust mode is enabled on client.
        /// </summary>
        public const int STATUS_TPM_ZERO_EXHAUST_ENABLED = unchecked((int)0xC0294000);

        //
        // Hypervisor error codes - changes to these codes must be reflected in HvStatus.h
        //

        /// <summary>
        /// The hypervisor does not support the operation because the specified hypercall code is not supported.
        /// </summary>
        public const int STATUS_HV_INVALID_HYPERCALL_CODE = unchecked((int)0xC0350002);

        /// <summary>
        /// The hypervisor does not support the operation because the encoding for the hypercall input register is not supported.
        /// </summary>
        public const int STATUS_HV_INVALID_HYPERCALL_INPUT = unchecked((int)0xC0350003);

        /// <summary>
        /// The hypervisor could not perform the operation because a parameter has an invalid alignment.
        /// </summary>
        public const int STATUS_HV_INVALID_ALIGNMENT = unchecked((int)0xC0350004);

        /// <summary>
        /// The hypervisor could not perform the operation because an invalid parameter was specified.
        /// </summary>
        public const int STATUS_HV_INVALID_PARAMETER = unchecked((int)0xC0350005);

        /// <summary>
        /// Access to the specified object was denied.
        /// </summary>
        public const int STATUS_HV_ACCESS_DENIED = unchecked((int)0xC0350006);

        /// <summary>
        /// The hypervisor could not perform the operation because the partition is entering or in an invalid state.
        /// </summary>
        public const int STATUS_HV_INVALID_PARTITION_STATE = unchecked((int)0xC0350007);

        /// <summary>
        /// The operation is not allowed in the current state.
        /// </summary>
        public const int STATUS_HV_OPERATION_DENIED = unchecked((int)0xC0350008);

        /// <summary>
        /// The hypervisor does not recognize the specified partition property.
        /// </summary>
        public const int STATUS_HV_UNKNOWN_PROPERTY = unchecked((int)0xC0350009);

        /// <summary>
        /// The specified value of a partition property is out of range or violates an invariant.
        /// </summary>
        public const int STATUS_HV_PROPERTY_VALUE_OUT_OF_RANGE = unchecked((int)0xC035000A);

        /// <summary>
        /// There is not enough memory in the hypervisor pool to complete the operation.
        /// </summary>
        public const int STATUS_HV_INSUFFICIENT_MEMORY = unchecked((int)0xC035000B);

        /// <summary>
        /// The maximum partition depth has been exceeded for the partition hierarchy.
        /// </summary>
        public const int STATUS_HV_PARTITION_TOO_DEEP = unchecked((int)0xC035000C);

        /// <summary>
        /// A partition with the specified partition Id does not exist.
        /// </summary>
        public const int STATUS_HV_INVALID_PARTITION_ID = unchecked((int)0xC035000D);

        /// <summary>
        /// The hypervisor could not perform the operation because the specified VP index is invalid.
        /// </summary>
        public const int STATUS_HV_INVALID_VP_INDEX = unchecked((int)0xC035000E);

        /// <summary>
        /// The hypervisor could not perform the operation because the specified port identifier is invalid.
        /// </summary>
        public const int STATUS_HV_INVALID_PORT_ID = unchecked((int)0xC0350011);

        /// <summary>
        /// The hypervisor could not perform the operation because the specified connection identifier is invalid.
        /// </summary>
        public const int STATUS_HV_INVALID_CONNECTION_ID = unchecked((int)0xC0350012);

        /// <summary>
        /// Not enough buffers were supplied to send a message.
        /// </summary>
        public const int STATUS_HV_INSUFFICIENT_BUFFERS = unchecked((int)0xC0350013);

        /// <summary>
        /// The previous virtual interrupt has not been acknowledged.
        /// </summary>
        public const int STATUS_HV_NOT_ACKNOWLEDGED = unchecked((int)0xC0350014);

        /// <summary>
        /// A virtual processor is not in the correct state for the indicated operation.
        /// </summary>
        public const int STATUS_HV_INVALID_VP_STATE = unchecked((int)0xC0350015);

        /// <summary>
        /// The previous virtual interrupt has already been acknowledged.
        /// </summary>
        public const int STATUS_HV_ACKNOWLEDGED = unchecked((int)0xC0350016);

        /// <summary>
        /// The indicated partition is not in a valid state for saving or restoring.
        /// </summary>
        public const int STATUS_HV_INVALID_SAVE_RESTORE_STATE = unchecked((int)0xC0350017);

        /// <summary>
        /// The hypervisor could not complete the operation because a required feature of the synthetic interrupt controller (SynIC) was disabled.
        /// </summary>
        public const int STATUS_HV_INVALID_SYNIC_STATE = unchecked((int)0xC0350018);

        /// <summary>
        /// The hypervisor could not perform the operation because the object or value was either already in use or being used for a purpose that would not permit completing the operation.
        /// </summary>
        public const int STATUS_HV_OBJECT_IN_USE = unchecked((int)0xC0350019);

        /// <summary>
        /// The proximity domain information is invalid.
        /// </summary>
        public const int STATUS_HV_INVALID_PROXIMITY_DOMAIN_INFO = unchecked((int)0xC035001A);

        /// <summary>
        /// An attempt to retrieve debugging data failed because none was available.
        /// </summary>
        public const int STATUS_HV_NO_DATA = unchecked((int)0xC035001B);

        /// <summary>
        /// The physical connection being used for debugging has not recorded any receive activity since the last operation.
        /// </summary>
        public const int STATUS_HV_INACTIVE = unchecked((int)0xC035001C);

        /// <summary>
        /// There are not enough resources to complete the operation.
        /// </summary>
        public const int STATUS_HV_NO_RESOURCES = unchecked((int)0xC035001D);

        /// <summary>
        /// A hypervisor feature is not available to the user.
        /// </summary>
        public const int STATUS_HV_FEATURE_UNAVAILABLE = unchecked((int)0xC035001E);

        /// <summary>
        /// The specified buffer was too small to contain all of the requested data.
        /// </summary>
        public const int STATUS_HV_INSUFFICIENT_BUFFER = unchecked((int)0xC0350033);

        /// <summary>
        /// The maximum number of domains supported by the platform I/O remapping hardware is currently in use. No domains are available to assign this device to this partition.
        /// </summary>
        public const int STATUS_HV_INSUFFICIENT_DEVICE_DOMAINS = unchecked((int)0xC0350038);

        /// <summary>
        /// Validation of CPUID data of the processor failed.
        /// </summary>
        public const int STATUS_HV_CPUID_FEATURE_VALIDATION_ERROR = unchecked((int)0xC035003C);

        /// <summary>
        /// Validation of XSAVE CPUID data of the processor failed.
        /// </summary>
        public const int STATUS_HV_CPUID_XSAVE_FEATURE_VALIDATION_ERROR = unchecked((int)0xC035003D);

        /// <summary>
        /// Processor did not respond within the timeout period.
        /// </summary>
        public const int STATUS_HV_PROCESSOR_STARTUP_TIMEOUT = unchecked((int)0xC035003E);

        /// <summary>
        /// SMX has been enabled in the BIOS.
        /// </summary>
        public const int STATUS_HV_SMX_ENABLED = unchecked((int)0xC035003F);

        /// <summary>
        /// The hypervisor could not perform the operation because the specified LP index is invalid.
        /// </summary>
        public const int STATUS_HV_INVALID_LP_INDEX = unchecked((int)0xC0350041);

        /// <summary>
        /// The supplied register value is invalid.
        /// </summary>
        public const int STATUS_HV_INVALID_REGISTER_VALUE = unchecked((int)0xC0350050);

        /// <summary>
        /// The supplied virtual trust level is not in the correct state to perform the requested operation.
        /// </summary>
        public const int STATUS_HV_INVALID_VTL_STATE = unchecked((int)0xC0350051);

        /// <summary>
        /// No execute feature (NX) is not present or not enabled in the BIOS.
        /// </summary>
        public const int STATUS_HV_NX_NOT_DETECTED = unchecked((int)0xC0350055);

        /// <summary>
        /// The supplied device ID is invalid.
        /// </summary>
        public const int STATUS_HV_INVALID_DEVICE_ID = unchecked((int)0xC0350057);

        /// <summary>
        /// The operation is not allowed in the current device state.
        /// </summary>
        public const int STATUS_HV_INVALID_DEVICE_STATE = unchecked((int)0xC0350058);

        /// <summary>
        /// The device had pending page requests which were discarded.
        /// </summary>
        public const int STATUS_HV_PENDING_PAGE_REQUESTS = 0x00350059;

        /// <summary>
        /// The supplied page request specifies a memory access that the guest does not have permissions to perform.
        /// </summary>
        public const int STATUS_HV_PAGE_REQUEST_INVALID = unchecked((int)0xC0350060);

        /// <summary>
        /// A CPU group with the specified CPU group Id does not exist.
        /// </summary>
        public const int STATUS_HV_INVALID_CPU_GROUP_ID = unchecked((int)0xC035006F);

        /// <summary>
        /// The hypervisor could not perform the operation because the CPU group is entering or in an invalid state.
        /// </summary>
        public const int STATUS_HV_INVALID_CPU_GROUP_STATE = unchecked((int)0xC0350070);

        /// <summary>
        /// The requested operation failed.
        /// </summary>
        public const int STATUS_HV_OPERATION_FAILED = unchecked((int)0xC0350071);

        /// <summary>
        /// The hypervisor could not perform the operation because it is not allowed with nested virtualization active.
        /// </summary>
        public const int STATUS_HV_NOT_ALLOWED_WITH_NESTED_VIRT_ACTIVE = unchecked((int)0xC0350072);

        /// <summary>
        /// No hypervisor is present on this system.
        /// </summary>
        public const int STATUS_HV_NOT_PRESENT = unchecked((int)0xC0351000);

        //
        // Virtualization status codes - these codes are used by the Virtualization Infrustructure Driver (VID) and other components
        //                               of the virtualization stack.
        //
        //
        // Errors:
        //

        /// <summary>
        /// The handler for the virtualization infrastructure driver is already registered. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_DUPLICATE_HANDLER = unchecked((int)0xC0370001);

        /// <summary>
        /// The number of registered handlers for the virtualization infrastructure driver exceeded the maximum. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_TOO_MANY_HANDLERS = unchecked((int)0xC0370002);

        /// <summary>
        /// The message queue for the virtualization infrastructure driver is full and cannot accept new messages. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_QUEUE_FULL = unchecked((int)0xC0370003);

        /// <summary>
        /// No handler exists to handle the message for the virtualization infrastructure driver. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_HANDLER_NOT_PRESENT = unchecked((int)0xC0370004);

        /// <summary>
        /// The name of the partition or message queue for the virtualization infrastructure driver is invalid. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_INVALID_OBJECT_NAME = unchecked((int)0xC0370005);

        /// <summary>
        /// The partition name of the virtualization infrastructure driver exceeds the maximum.
        /// </summary>
        public const int STATUS_VID_PARTITION_NAME_TOO_LONG = unchecked((int)0xC0370006);

        /// <summary>
        /// The message queue name of the virtualization infrastructure driver exceeds the maximum.
        /// </summary>
        public const int STATUS_VID_MESSAGE_QUEUE_NAME_TOO_LONG = unchecked((int)0xC0370007);

        /// <summary>
        /// Cannot create the partition for the virtualization infrastructure driver because another partition with the same name already exists.
        /// </summary>
        public const int STATUS_VID_PARTITION_ALREADY_EXISTS = unchecked((int)0xC0370008);

        /// <summary>
        /// The virtualization infrastructure driver has encountered an error. The requested partition does not exist. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_PARTITION_DOES_NOT_EXIST = unchecked((int)0xC0370009);

        /// <summary>
        /// The virtualization infrastructure driver has encountered an error. Could not find the requested partition. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_PARTITION_NAME_NOT_FOUND = unchecked((int)0xC037000A);

        /// <summary>
        /// A message queue with the same name already exists for the virtualization infrastructure driver.
        /// </summary>
        public const int STATUS_VID_MESSAGE_QUEUE_ALREADY_EXISTS = unchecked((int)0xC037000B);

        /// <summary>
        /// The memory block page for the virtualization infrastructure driver cannot be mapped because the page map limit has been reached. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_EXCEEDED_MBP_ENTRY_MAP_LIMIT = unchecked((int)0xC037000C);

        /// <summary>
        /// The memory block for the virtualization infrastructure driver is still being used and cannot be destroyed.
        /// </summary>
        public const int STATUS_VID_MB_STILL_REFERENCED = unchecked((int)0xC037000D);

        /// <summary>
        /// Cannot unlock the page array for the guest operating system memory address because it does not match a previous lock request. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_CHILD_GPA_PAGE_SET_CORRUPTED = unchecked((int)0xC037000E);

        /// <summary>
        /// The non-uniform memory access (NUMA) node settings do not match the system NUMA topology. In order to start the virtual machine, you will need to modify the NUMA configuration.
        /// </summary>
        public const int STATUS_VID_INVALID_NUMA_SETTINGS = unchecked((int)0xC037000F);

        /// <summary>
        /// The non-uniform memory access (NUMA) node index does not match a valid index in the system NUMA topology.
        /// </summary>
        public const int STATUS_VID_INVALID_NUMA_NODE_INDEX = unchecked((int)0xC0370010);

        /// <summary>
        /// The memory block for the virtualization infrastructure driver is already associated with a message queue.
        /// </summary>
        public const int STATUS_VID_NOTIFICATION_QUEUE_ALREADY_ASSOCIATED = unchecked((int)0xC0370011);

        /// <summary>
        /// The handle is not a valid memory block handle for the virtualization infrastructure driver.
        /// </summary>
        public const int STATUS_VID_INVALID_MEMORY_BLOCK_HANDLE = unchecked((int)0xC0370012);

        /// <summary>
        /// The request exceeded the memory block page limit for the virtualization infrastructure driver. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_PAGE_RANGE_OVERFLOW = unchecked((int)0xC0370013);

        /// <summary>
        /// The handle is not a valid message queue handle for the virtualization infrastructure driver.
        /// </summary>
        public const int STATUS_VID_INVALID_MESSAGE_QUEUE_HANDLE = unchecked((int)0xC0370014);

        /// <summary>
        /// The handle is not a valid page range handle for the virtualization infrastructure driver.
        /// </summary>
        public const int STATUS_VID_INVALID_GPA_RANGE_HANDLE = unchecked((int)0xC0370015);

        /// <summary>
        /// Cannot install client notifications because no message queue for the virtualization infrastructure driver is associated with the memory block.
        /// </summary>
        public const int STATUS_VID_NO_MEMORY_BLOCK_NOTIFICATION_QUEUE = unchecked((int)0xC0370016);

        /// <summary>
        /// The request to lock or map a memory block page failed because the virtualization infrastructure driver memory block limit has been reached. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_MEMORY_BLOCK_LOCK_COUNT_EXCEEDED = unchecked((int)0xC0370017);

        /// <summary>
        /// The handle is not a valid parent partition mapping handle for the virtualization infrastructure driver.
        /// </summary>
        public const int STATUS_VID_INVALID_PPM_HANDLE = unchecked((int)0xC0370018);

        /// <summary>
        /// Notifications cannot be created on the memory block because it is use.
        /// </summary>
        public const int STATUS_VID_MBPS_ARE_LOCKED = unchecked((int)0xC0370019);

        /// <summary>
        /// The message queue for the virtualization infrastructure driver has been closed. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_MESSAGE_QUEUE_CLOSED = unchecked((int)0xC037001A);

        /// <summary>
        /// Cannot add a virtual processor to the partition because the maximum has been reached.
        /// </summary>
        public const int STATUS_VID_VIRTUAL_PROCESSOR_LIMIT_EXCEEDED = unchecked((int)0xC037001B);

        /// <summary>
        /// Cannot stop the virtual processor immediately because of a pending intercept.
        /// </summary>
        public const int STATUS_VID_STOP_PENDING = unchecked((int)0xC037001C);

        /// <summary>
        /// Invalid state for the virtual processor. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_INVALID_PROCESSOR_STATE = unchecked((int)0xC037001D);

        /// <summary>
        /// The maximum number of kernel mode clients for the virtualization infrastructure driver has been reached. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_EXCEEDED_KM_CONTEXT_COUNT_LIMIT = unchecked((int)0xC037001E);

        /// <summary>
        /// This kernel mode interface for the virtualization infrastructure driver has already been initialized. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_KM_INTERFACE_ALREADY_INITIALIZED = unchecked((int)0xC037001F);

        /// <summary>
        /// Cannot set or reset the memory block property more than once for the virtualization infrastructure driver. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_MB_PROPERTY_ALREADY_SET_RESET = unchecked((int)0xC0370020);

        /// <summary>
        /// The memory mapped I/O for this page range no longer exists. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_MMIO_RANGE_DESTROYED = unchecked((int)0xC0370021);

        /// <summary>
        /// The lock or unlock request uses an invalid guest operating system memory address. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_INVALID_CHILD_GPA_PAGE_SET = unchecked((int)0xC0370022);

        /// <summary>
        /// Cannot destroy or reuse the reserve page set for the virtualization infrastructure driver because it is in use. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_RESERVE_PAGE_SET_IS_BEING_USED = unchecked((int)0xC0370023);

        /// <summary>
        /// The reserve page set for the virtualization infrastructure driver is too small to use in the lock request. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_RESERVE_PAGE_SET_TOO_SMALL = unchecked((int)0xC0370024);

        /// <summary>
        /// Cannot lock or map the memory block page for the virtualization infrastructure driver because it has already been locked using a reserve page set page. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_MBP_ALREADY_LOCKED_USING_RESERVED_PAGE = unchecked((int)0xC0370025);

        /// <summary>
        /// Cannot create the memory block for the virtualization infrastructure driver because the requested number of pages exceeded the limit. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int STATUS_VID_MBP_COUNT_EXCEEDED_LIMIT = unchecked((int)0xC0370026);

        /// <summary>
        /// Cannot restore this virtual machine because the saved state data cannot be read. Delete the saved state data and then try to start the virtual machine.
        /// </summary>
        public const int STATUS_VID_SAVED_STATE_CORRUPT = unchecked((int)0xC0370027);

        /// <summary>
        /// Cannot restore this virtual machine because an item read from the saved state data is not recognized. Delete the saved state data and then try to start the virtual machine.
        /// </summary>
        public const int STATUS_VID_SAVED_STATE_UNRECOGNIZED_ITEM = unchecked((int)0xC0370028);

        /// <summary>
        /// Cannot restore this virtual machine to the saved state because of hypervisor incompatibility. Delete the saved state data and then try to start the virtual machine.
        /// </summary>
        public const int STATUS_VID_SAVED_STATE_INCOMPATIBLE = unchecked((int)0xC0370029);

        /// <summary>
        /// The specified VTL does not have the permission to access the resource.
        /// </summary>
        public const int STATUS_VID_VTL_ACCESS_DENIED = unchecked((int)0xC037002A);

        //
        // Warnings:
        //

        /// <summary>
        /// A virtual machine is running with its memory allocated across multiple NUMA nodes. This does not indicate a problem unless the performance of your virtual machine is unusually slow. If you are experiencing performance problems, you may need to modify the NUMA configuration.
        /// </summary>
        public const int STATUS_VID_REMOTE_NODE_PARENT_GPA_PAGES_USED = unchecked((int)0x80370001);

        //
        // IPSEC error codes (tcpip.sys)
        //

        /// <summary>
        /// The SPI in the packet does not match a valid IPsec SA.
        /// </summary>
        public const int STATUS_IPSEC_BAD_SPI = unchecked((int)0xC0360001);

        /// <summary>
        /// Packet was received on an IPsec SA whose lifetime has expired.
        /// </summary>
        public const int STATUS_IPSEC_SA_LIFETIME_EXPIRED = unchecked((int)0xC0360002);

        /// <summary>
        /// Packet was received on an IPsec SA that does not match the packet characteristics.
        /// </summary>
        public const int STATUS_IPSEC_WRONG_SA = unchecked((int)0xC0360003);

        /// <summary>
        /// Packet sequence number replay check failed.
        /// </summary>
        public const int STATUS_IPSEC_REPLAY_CHECK_FAILED = unchecked((int)0xC0360004);

        /// <summary>
        /// IPsec header and/or trailer in the packet is invalid.
        /// </summary>
        public const int STATUS_IPSEC_INVALID_PACKET = unchecked((int)0xC0360005);

        /// <summary>
        /// IPsec integrity check failed.
        /// </summary>
        public const int STATUS_IPSEC_INTEGRITY_CHECK_FAILED = unchecked((int)0xC0360006);

        /// <summary>
        /// IPsec dropped a clear text packet.
        /// </summary>
        public const int STATUS_IPSEC_CLEAR_TEXT_DROP = unchecked((int)0xC0360007);

        /// <summary>
        /// IPsec dropped an incoming ESP packet in authenticated firewall mode. This drop is benign.
        /// </summary>
        public const int STATUS_IPSEC_AUTH_FIREWALL_DROP = unchecked((int)0xC0360008);

        /// <summary>
        /// IPsec dropped a packet due to DoS throttling.
        /// </summary>
        public const int STATUS_IPSEC_THROTTLE_DROP = unchecked((int)0xC0360009);

        /// <summary>
        /// IPsec DoS Protection matched an explicit block rule.
        /// </summary>
        public const int STATUS_IPSEC_DOSP_BLOCK = unchecked((int)0xC0368000);

        /// <summary>
        /// IPsec DoS Protection received an IPsec specific multicast packet which is not allowed.
        /// </summary>
        public const int STATUS_IPSEC_DOSP_RECEIVED_MULTICAST = unchecked((int)0xC0368001);

        /// <summary>
        /// IPsec DoS Protection received an incorrectly formatted packet.
        /// </summary>
        public const int STATUS_IPSEC_DOSP_INVALID_PACKET = unchecked((int)0xC0368002);

        /// <summary>
        /// IPsec DoS Protection failed to look up state.
        /// </summary>
        public const int STATUS_IPSEC_DOSP_STATE_LOOKUP_FAILED = unchecked((int)0xC0368003);

        /// <summary>
        /// IPsec DoS Protection failed to create state because the maximum number of entries allowed by policy has been reached.
        /// </summary>
        public const int STATUS_IPSEC_DOSP_MAX_ENTRIES = unchecked((int)0xC0368004);

        /// <summary>
        /// IPsec DoS Protection received an IPsec negotiation packet for a keying module which is not allowed by policy.
        /// </summary>
        public const int STATUS_IPSEC_DOSP_KEYMOD_NOT_ALLOWED = unchecked((int)0xC0368005);

        /// <summary>
        /// IPsec DoS Protection failed to create a per internal IP rate limit queue because the maximum number of queues allowed by policy has been reached.
        /// </summary>
        public const int STATUS_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES = unchecked((int)0xC0368006);


        //
        // Volume manager status codes (volmgr.sys and volmgrx.sys)
        //

        //
        // WARNINGS
        //
        /// <summary>
        /// The regeneration operation was not able to copy all data from the active plexes due to bad sectors.
        /// </summary>
        public const int STATUS_VOLMGR_INCOMPLETE_REGENERATION = unchecked((int)0x80380001);

        /// <summary>
        /// One or more disks were not fully migrated to the target pack. They may or may not require reimport after fixing the hardware problems.
        /// </summary>
        public const int STATUS_VOLMGR_INCOMPLETE_DISK_MIGRATION = unchecked((int)0x80380002);

        //
        // ERRORS
        //
        /// <summary>
        /// The configuration database is full.
        /// </summary>
        public const int STATUS_VOLMGR_DATABASE_FULL = unchecked((int)0xC0380001);

        /// <summary>
        /// The configuration data on the disk is corrupted.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_CONFIGURATION_CORRUPTED = unchecked((int)0xC0380002);

        /// <summary>
        /// The configuration on the disk is not insync with the in-memory configuration.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_CONFIGURATION_NOT_IN_SYNC = unchecked((int)0xC0380003);

        /// <summary>
        /// A majority of disks failed to be updated with the new configuration.
        /// </summary>
        public const int STATUS_VOLMGR_PACK_CONFIG_UPDATE_FAILED = unchecked((int)0xC0380004);

        /// <summary>
        /// The disk contains non-simple volumes.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_CONTAINS_NON_SIMPLE_VOLUME = unchecked((int)0xC0380005);

        /// <summary>
        /// The same disk was specified more than once in the migration list.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_DUPLICATE = unchecked((int)0xC0380006);

        /// <summary>
        /// The disk is already dynamic.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_DYNAMIC = unchecked((int)0xC0380007);

        /// <summary>
        /// The specified disk id is invalid. There are no disks with the specified disk id.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_ID_INVALID = unchecked((int)0xC0380008);

        /// <summary>
        /// The specified disk is an invalid disk. Operation cannot complete on an invalid disk.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_INVALID = unchecked((int)0xC0380009);

        /// <summary>
        /// The specified disk(s) cannot be removed since it is the last remaining voter.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_LAST_VOTER = unchecked((int)0xC038000A);

        /// <summary>
        /// The specified disk has an invalid disk layout.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_LAYOUT_INVALID = unchecked((int)0xC038000B);

        /// <summary>
        /// The disk layout contains non-basic partitions which appear after basic paritions. This is an invalid disk layout.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_LAYOUT_NON_BASIC_BETWEEN_BASIC_PARTITIONS = unchecked((int)0xC038000C);

        /// <summary>
        /// The disk layout contains partitions which are not cylinder aligned.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_LAYOUT_NOT_CYLINDER_ALIGNED = unchecked((int)0xC038000D);

        /// <summary>
        /// The disk layout contains partitions which are samller than the minimum size.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_LAYOUT_PARTITIONS_TOO_SMALL = unchecked((int)0xC038000E);

        /// <summary>
        /// The disk layout contains primary partitions in between logical drives. This is an invalid disk layout.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_LAYOUT_PRIMARY_BETWEEN_LOGICAL_PARTITIONS = unchecked((int)0xC038000F);

        /// <summary>
        /// The disk layout contains more than the maximum number of supported partitions.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_LAYOUT_TOO_MANY_PARTITIONS = unchecked((int)0xC0380010);

        /// <summary>
        /// The specified disk is missing. The operation cannot complete on a missing disk.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_MISSING = unchecked((int)0xC0380011);

        /// <summary>
        /// The specified disk is not empty.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_NOT_EMPTY = unchecked((int)0xC0380012);

        /// <summary>
        /// There is not enough usable space for this operation.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_NOT_ENOUGH_SPACE = unchecked((int)0xC0380013);

        /// <summary>
        /// The force revectoring of bad sectors failed.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_REVECTORING_FAILED = unchecked((int)0xC0380014);

        /// <summary>
        /// The specified disk has an invalid sector size.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_SECTOR_SIZE_INVALID = unchecked((int)0xC0380015);

        /// <summary>
        /// The specified disk set contains volumes which exist on disks outside of the set.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_SET_NOT_CONTAINED = unchecked((int)0xC0380016);

        /// <summary>
        /// A disk in the volume layout provides extents to more than one member of a plex.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_USED_BY_MULTIPLE_MEMBERS = unchecked((int)0xC0380017);

        /// <summary>
        /// A disk in the volume layout provides extents to more than one plex.
        /// </summary>
        public const int STATUS_VOLMGR_DISK_USED_BY_MULTIPLE_PLEXES = unchecked((int)0xC0380018);

        /// <summary>
        /// Dynamic disks are not supported on this system.
        /// </summary>
        public const int STATUS_VOLMGR_DYNAMIC_DISK_NOT_SUPPORTED = unchecked((int)0xC0380019);

        /// <summary>
        /// The specified extent is already used by other volumes.
        /// </summary>
        public const int STATUS_VOLMGR_EXTENT_ALREADY_USED = unchecked((int)0xC038001A);

        /// <summary>
        /// The specified volume is retained and can only be extended into a contiguous extent. The specified extent to grow the volume is not contiguous with the specified volume.
        /// </summary>
        public const int STATUS_VOLMGR_EXTENT_NOT_CONTIGUOUS = unchecked((int)0xC038001B);

        /// <summary>
        /// The specified volume extent is not within the public region of the disk.
        /// </summary>
        public const int STATUS_VOLMGR_EXTENT_NOT_IN_PUBLIC_REGION = unchecked((int)0xC038001C);

        /// <summary>
        /// The specifed volume extent is not sector aligned.
        /// </summary>
        public const int STATUS_VOLMGR_EXTENT_NOT_SECTOR_ALIGNED = unchecked((int)0xC038001D);

        /// <summary>
        /// The specified parition overlaps an EBR (the first track of an extended partition on a MBR disks).
        /// </summary>
        public const int STATUS_VOLMGR_EXTENT_OVERLAPS_EBR_PARTITION = unchecked((int)0xC038001E);

        /// <summary>
        /// The specified extent lengths cannot be used to construct a volume with specified length.
        /// </summary>
        public const int STATUS_VOLMGR_EXTENT_VOLUME_LENGTHS_DO_NOT_MATCH = unchecked((int)0xC038001F);

        /// <summary>
        /// The system does not support fault tolerant volumes.
        /// </summary>
        public const int STATUS_VOLMGR_FAULT_TOLERANT_NOT_SUPPORTED = unchecked((int)0xC0380020);

        /// <summary>
        /// The specified interleave length is invalid.
        /// </summary>
        public const int STATUS_VOLMGR_INTERLEAVE_LENGTH_INVALID = unchecked((int)0xC0380021);

        /// <summary>
        /// There is already a maximum number of registered users.
        /// </summary>
        public const int STATUS_VOLMGR_MAXIMUM_REGISTERED_USERS = unchecked((int)0xC0380022);

        /// <summary>
        /// The specified member is already in-sync with the other active members. It does not need to be regenerated.
        /// </summary>
        public const int STATUS_VOLMGR_MEMBER_IN_SYNC = unchecked((int)0xC0380023);

        /// <summary>
        /// The same member index was specified more than once.
        /// </summary>
        public const int STATUS_VOLMGR_MEMBER_INDEX_DUPLICATE = unchecked((int)0xC0380024);

        /// <summary>
        /// The specified member index is greater or equal than the number of members in the volume plex.
        /// </summary>
        public const int STATUS_VOLMGR_MEMBER_INDEX_INVALID = unchecked((int)0xC0380025);

        /// <summary>
        /// The specified member is missing. It cannot be regenerated.
        /// </summary>
        public const int STATUS_VOLMGR_MEMBER_MISSING = unchecked((int)0xC0380026);

        /// <summary>
        /// The specified member is not detached. Cannot replace a member which is not detached.
        /// </summary>
        public const int STATUS_VOLMGR_MEMBER_NOT_DETACHED = unchecked((int)0xC0380027);

        /// <summary>
        /// The specified member is already regenerating.
        /// </summary>
        public const int STATUS_VOLMGR_MEMBER_REGENERATING = unchecked((int)0xC0380028);

        /// <summary>
        /// All disks belonging to the pack failed.
        /// </summary>
        public const int STATUS_VOLMGR_ALL_DISKS_FAILED = unchecked((int)0xC0380029);

        /// <summary>
        /// There are currently no registered users for notifications. The task number is irrelevant unless there are registered users.
        /// </summary>
        public const int STATUS_VOLMGR_NO_REGISTERED_USERS = unchecked((int)0xC038002A);

        /// <summary>
        /// The specified notification user does not exist. Failed to unregister user for notifications.
        /// </summary>
        public const int STATUS_VOLMGR_NO_SUCH_USER = unchecked((int)0xC038002B);

        /// <summary>
        /// The notifications have been reset. Notifications for the current user are invalid. Unregister and re-register for notifications.
        /// </summary>
        public const int STATUS_VOLMGR_NOTIFICATION_RESET = unchecked((int)0xC038002C);

        /// <summary>
        /// The specified number of members is invalid.
        /// </summary>
        public const int STATUS_VOLMGR_NUMBER_OF_MEMBERS_INVALID = unchecked((int)0xC038002D);

        /// <summary>
        /// The specified number of plexes is invalid.
        /// </summary>
        public const int STATUS_VOLMGR_NUMBER_OF_PLEXES_INVALID = unchecked((int)0xC038002E);

        /// <summary>
        /// The specified source and target packs are identical.
        /// </summary>
        public const int STATUS_VOLMGR_PACK_DUPLICATE = unchecked((int)0xC038002F);

        /// <summary>
        /// The specified pack id is invalid. There are no packs with the specified pack id.
        /// </summary>
        public const int STATUS_VOLMGR_PACK_ID_INVALID = unchecked((int)0xC0380030);

        /// <summary>
        /// The specified pack is the invalid pack. The operation cannot complete with the invalid pack.
        /// </summary>
        public const int STATUS_VOLMGR_PACK_INVALID = unchecked((int)0xC0380031);

        /// <summary>
        /// The specified pack name is invalid.
        /// </summary>
        public const int STATUS_VOLMGR_PACK_NAME_INVALID = unchecked((int)0xC0380032);

        /// <summary>
        /// The specified pack is offline.
        /// </summary>
        public const int STATUS_VOLMGR_PACK_OFFLINE = unchecked((int)0xC0380033);

        /// <summary>
        /// The specified pack already has a quorum of healthy disks.
        /// </summary>
        public const int STATUS_VOLMGR_PACK_HAS_QUORUM = unchecked((int)0xC0380034);

        /// <summary>
        /// The pack does not have a quorum of healthy disks.
        /// </summary>
        public const int STATUS_VOLMGR_PACK_WITHOUT_QUORUM = unchecked((int)0xC0380035);

        /// <summary>
        /// The specified disk has an unsupported partition style. Only MBR and GPT partition styles are supported.
        /// </summary>
        public const int STATUS_VOLMGR_PARTITION_STYLE_INVALID = unchecked((int)0xC0380036);

        /// <summary>
        /// Failed to update the disk's partition layout.
        /// </summary>
        public const int STATUS_VOLMGR_PARTITION_UPDATE_FAILED = unchecked((int)0xC0380037);

        /// <summary>
        /// The specified plex is already in-sync with the other active plexes. It does not need to be regenerated.
        /// </summary>
        public const int STATUS_VOLMGR_PLEX_IN_SYNC = unchecked((int)0xC0380038);

        /// <summary>
        /// The same plex index was specified more than once.
        /// </summary>
        public const int STATUS_VOLMGR_PLEX_INDEX_DUPLICATE = unchecked((int)0xC0380039);

        /// <summary>
        /// The specified plex index is greater or equal than the number of plexes in the volume.
        /// </summary>
        public const int STATUS_VOLMGR_PLEX_INDEX_INVALID = unchecked((int)0xC038003A);

        /// <summary>
        /// The specified plex is the last active plex in the volume. The plex cannot be removed or else the volume will go offline.
        /// </summary>
        public const int STATUS_VOLMGR_PLEX_LAST_ACTIVE = unchecked((int)0xC038003B);

        /// <summary>
        /// The specified plex is missing.
        /// </summary>
        public const int STATUS_VOLMGR_PLEX_MISSING = unchecked((int)0xC038003C);

        /// <summary>
        /// The specified plex is currently regenerating.
        /// </summary>
        public const int STATUS_VOLMGR_PLEX_REGENERATING = unchecked((int)0xC038003D);

        /// <summary>
        /// The specified plex type is invalid.
        /// </summary>
        public const int STATUS_VOLMGR_PLEX_TYPE_INVALID = unchecked((int)0xC038003E);

        /// <summary>
        /// The operation is only supported on RAID-5 plexes.
        /// </summary>
        public const int STATUS_VOLMGR_PLEX_NOT_RAID5 = unchecked((int)0xC038003F);

        /// <summary>
        /// The operation is only supported on simple plexes.
        /// </summary>
        public const int STATUS_VOLMGR_PLEX_NOT_SIMPLE = unchecked((int)0xC0380040);

        /// <summary>
        /// The Size fields in the VM_VOLUME_LAYOUT input structure are incorrectly set.
        /// </summary>
        public const int STATUS_VOLMGR_STRUCTURE_SIZE_INVALID = unchecked((int)0xC0380041);

        /// <summary>
        /// There is already a pending request for notifications. Wait for the existing request to return before requesting for more notifications.
        /// </summary>
        public const int STATUS_VOLMGR_TOO_MANY_NOTIFICATION_REQUESTS = unchecked((int)0xC0380042);

        /// <summary>
        /// There is currently a transaction in process.
        /// </summary>
        public const int STATUS_VOLMGR_TRANSACTION_IN_PROGRESS = unchecked((int)0xC0380043);

        /// <summary>
        /// An unexpected layout change occurred outside of the volume manager.
        /// </summary>
        public const int STATUS_VOLMGR_UNEXPECTED_DISK_LAYOUT_CHANGE = unchecked((int)0xC0380044);

        /// <summary>
        /// The specified volume contains a missing disk.
        /// </summary>
        public const int STATUS_VOLMGR_VOLUME_CONTAINS_MISSING_DISK = unchecked((int)0xC0380045);

        /// <summary>
        /// The specified volume id is invalid. There are no volumes with the specified volume id.
        /// </summary>
        public const int STATUS_VOLMGR_VOLUME_ID_INVALID = unchecked((int)0xC0380046);

        /// <summary>
        /// The specified volume length is invalid.
        /// </summary>
        public const int STATUS_VOLMGR_VOLUME_LENGTH_INVALID = unchecked((int)0xC0380047);

        /// <summary>
        /// The specified size for the volume is not a multiple of the sector size.
        /// </summary>
        public const int STATUS_VOLMGR_VOLUME_LENGTH_NOT_SECTOR_SIZE_MULTIPLE = unchecked((int)0xC0380048);

        /// <summary>
        /// The operation is only supported on mirrored volumes.
        /// </summary>
        public const int STATUS_VOLMGR_VOLUME_NOT_MIRRORED = unchecked((int)0xC0380049);

        /// <summary>
        /// The specified volume does not have a retain partition.
        /// </summary>
        public const int STATUS_VOLMGR_VOLUME_NOT_RETAINED = unchecked((int)0xC038004A);

        /// <summary>
        /// The specified volume is offline.
        /// </summary>
        public const int STATUS_VOLMGR_VOLUME_OFFLINE = unchecked((int)0xC038004B);

        /// <summary>
        /// The specified volume already has a retain partition.
        /// </summary>
        public const int STATUS_VOLMGR_VOLUME_RETAINED = unchecked((int)0xC038004C);

        /// <summary>
        /// The specified number of extents is invalid.
        /// </summary>
        public const int STATUS_VOLMGR_NUMBER_OF_EXTENTS_INVALID = unchecked((int)0xC038004D);

        /// <summary>
        /// All disks participating to the volume must have the same sector size.
        /// </summary>
        public const int STATUS_VOLMGR_DIFFERENT_SECTOR_SIZE = unchecked((int)0xC038004E);

        /// <summary>
        /// The boot disk experienced failures.
        /// </summary>
        public const int STATUS_VOLMGR_BAD_BOOT_DISK = unchecked((int)0xC038004F);

        /// <summary>
        /// The configuration of the pack is offline.
        /// </summary>
        public const int STATUS_VOLMGR_PACK_CONFIG_OFFLINE = unchecked((int)0xC0380050);

        /// <summary>
        /// The configuration of the pack is online.
        /// </summary>
        public const int STATUS_VOLMGR_PACK_CONFIG_ONLINE = unchecked((int)0xC0380051);

        /// <summary>
        /// The specified pack is not the primary pack.
        /// </summary>
        public const int STATUS_VOLMGR_NOT_PRIMARY_PACK = unchecked((int)0xC0380052);

        /// <summary>
        /// All disks failed to be updated with the new content of the log.
        /// </summary>
        public const int STATUS_VOLMGR_PACK_LOG_UPDATE_FAILED = unchecked((int)0xC0380053);

        /// <summary>
        /// The specified number of disks in a plex is invalid.
        /// </summary>
        public const int STATUS_VOLMGR_NUMBER_OF_DISKS_IN_PLEX_INVALID = unchecked((int)0xC0380054);

        /// <summary>
        /// The specified number of disks in a plex member is invalid.
        /// </summary>
        public const int STATUS_VOLMGR_NUMBER_OF_DISKS_IN_MEMBER_INVALID = unchecked((int)0xC0380055);

        /// <summary>
        /// The operation is not supported on mirrored volumes.
        /// </summary>
        public const int STATUS_VOLMGR_VOLUME_MIRRORED = unchecked((int)0xC0380056);

        /// <summary>
        /// The operation is only supported on simple and spanned plexes.
        /// </summary>
        public const int STATUS_VOLMGR_PLEX_NOT_SIMPLE_SPANNED = unchecked((int)0xC0380057);

        /// <summary>
        /// The pack has no valid log copies.
        /// </summary>
        public const int STATUS_VOLMGR_NO_VALID_LOG_COPIES = unchecked((int)0xC0380058);

        /// <summary>
        /// A primary pack is already present.
        /// </summary>
        public const int STATUS_VOLMGR_PRIMARY_PACK_PRESENT = unchecked((int)0xC0380059);

        /// <summary>
        /// The specified number of disks is invalid.
        /// </summary>
        public const int STATUS_VOLMGR_NUMBER_OF_DISKS_INVALID = unchecked((int)0xC038005A);

        /// <summary>
        /// The system does not support mirrored volumes.
        /// </summary>
        public const int STATUS_VOLMGR_MIRROR_NOT_SUPPORTED = unchecked((int)0xC038005B);

        /// <summary>
        /// The system does not support RAID-5 volumes.
        /// </summary>
        public const int STATUS_VOLMGR_RAID5_NOT_SUPPORTED = unchecked((int)0xC038005C);

        //
        // Boot Code Data (BCD) status codes
        //

        /// <summary>
        /// Some BCD entries were not imported correctly from the BCD store.
        /// </summary>
        public const int STATUS_BCD_NOT_ALL_ENTRIES_IMPORTED = unchecked((int)0x80390001);

        /// <summary>
        /// Entries enumerated have exceeded the allowed threshold.
        /// </summary>
        public const int STATUS_BCD_TOO_MANY_ELEMENTS = unchecked((int)0xC0390002);

        /// <summary>
        /// Some BCD entries were not synchronized correctly with the firmware.
        /// </summary>
        public const int STATUS_BCD_NOT_ALL_ENTRIES_SYNCHRONIZED = unchecked((int)0x80390003);


        //
        // vhdparser error codes (vhdmp.sys)
        //

        /// <summary>
        /// The virtual hard disk is corrupted. The virtual hard disk drive footer is missing.
        /// </summary>
        public const int STATUS_VHD_DRIVE_FOOTER_MISSING = unchecked((int)0xC03A0001);

        /// <summary>
        /// The virtual hard disk is corrupted. The virtual hard disk drive footer checksum does not match the on-disk checksum.
        /// </summary>
        public const int STATUS_VHD_DRIVE_FOOTER_CHECKSUM_MISMATCH = unchecked((int)0xC03A0002);

        /// <summary>
        /// The virtual hard disk is corrupted. The virtual hard disk drive footer in the virtual hard disk is corrupted.
        /// </summary>
        public const int STATUS_VHD_DRIVE_FOOTER_CORRUPT = unchecked((int)0xC03A0003);

        /// <summary>
        /// The system does not recognize the file format of this virtual hard disk.
        /// </summary>
        public const int STATUS_VHD_FORMAT_UNKNOWN = unchecked((int)0xC03A0004);

        /// <summary>
        /// The version does not support this version of the file format.
        /// </summary>
        public const int STATUS_VHD_FORMAT_UNSUPPORTED_VERSION = unchecked((int)0xC03A0005);

        /// <summary>
        /// The virtual hard disk is corrupted. The sparse header checksum does not match the on-disk checksum.
        /// </summary>
        public const int STATUS_VHD_SPARSE_HEADER_CHECKSUM_MISMATCH = unchecked((int)0xC03A0006);

        /// <summary>
        /// The system does not support this version of the virtual hard disk.This version of the sparse header is not supported.
        /// </summary>
        public const int STATUS_VHD_SPARSE_HEADER_UNSUPPORTED_VERSION = unchecked((int)0xC03A0007);

        /// <summary>
        /// The virtual hard disk is corrupted. The sparse header in the virtual hard disk is corrupt.
        /// </summary>
        public const int STATUS_VHD_SPARSE_HEADER_CORRUPT = unchecked((int)0xC03A0008);

        /// <summary>
        /// Failed to write to the virtual hard disk failed because the system failed to allocate a new block in the virtual hard disk.
        /// </summary>
        public const int STATUS_VHD_BLOCK_ALLOCATION_FAILURE = unchecked((int)0xC03A0009);

        /// <summary>
        /// The virtual hard disk is corrupted. The block allocation table in the virtual hard disk is corrupt.
        /// </summary>
        public const int STATUS_VHD_BLOCK_ALLOCATION_TABLE_CORRUPT = unchecked((int)0xC03A000A);

        /// <summary>
        /// The system does not support this version of the virtual hard disk. The block size is invalid.
        /// </summary>
        public const int STATUS_VHD_INVALID_BLOCK_SIZE = unchecked((int)0xC03A000B);

        /// <summary>
        /// The virtual hard disk is corrupted. The block bitmap does not match with the block data present in the virtual hard disk.
        /// </summary>
        public const int STATUS_VHD_BITMAP_MISMATCH = unchecked((int)0xC03A000C);

        /// <summary>
        /// The chain of virtual hard disks is broken. The system cannot locate the parent virtual hard disk for the differencing disk.
        /// </summary>
        public const int STATUS_VHD_PARENT_VHD_NOT_FOUND = unchecked((int)0xC03A000D);

        /// <summary>
        /// The chain of virtual hard disks is corrupted. There is a mismatch in the identifiers of the parent virtual hard disk and differencing disk.
        /// </summary>
        public const int STATUS_VHD_CHILD_PARENT_ID_MISMATCH = unchecked((int)0xC03A000E);

        /// <summary>
        /// The chain of virtual hard disks is corrupted. The time stamp of the parent virtual hard disk does not match the time stamp of the differencing disk.
        /// </summary>
        public const int STATUS_VHD_CHILD_PARENT_TIMESTAMP_MISMATCH = unchecked((int)0xC03A000F);

        /// <summary>
        /// Failed to read the metadata of the virtual hard disk.
        /// </summary>
        public const int STATUS_VHD_METADATA_READ_FAILURE = unchecked((int)0xC03A0010);

        /// <summary>
        /// Failed to write to the metadata of the virtual hard disk.
        /// </summary>
        public const int STATUS_VHD_METADATA_WRITE_FAILURE = unchecked((int)0xC03A0011);

        /// <summary>
        /// The size of the virtual hard disk is not valid.
        /// </summary>
        public const int STATUS_VHD_INVALID_SIZE = unchecked((int)0xC03A0012);

        /// <summary>
        /// The file size of this virtual hard disk is not valid.
        /// </summary>
        public const int STATUS_VHD_INVALID_FILE_SIZE = unchecked((int)0xC03A0013);

        /// <summary>
        /// A virtual disk support provider for the specified file was not found.
        /// </summary>
        public const int STATUS_VIRTDISK_PROVIDER_NOT_FOUND = unchecked((int)0xC03A0014);

        /// <summary>
        /// The specified disk is not a virtual disk.
        /// </summary>
        public const int STATUS_VIRTDISK_NOT_VIRTUAL_DISK = unchecked((int)0xC03A0015);

        /// <summary>
        /// The chain of virtual hard disks is inaccessible. The process has not been granted access rights to the parent virtual hard disk for the differencing disk.
        /// </summary>
        public const int STATUS_VHD_PARENT_VHD_ACCESS_DENIED = unchecked((int)0xC03A0016);

        /// <summary>
        /// The chain of virtual hard disks is corrupted. There is a mismatch in the virtual sizes of the parent virtual hard disk and differencing disk.
        /// </summary>
        public const int STATUS_VHD_CHILD_PARENT_SIZE_MISMATCH = unchecked((int)0xC03A0017);

        /// <summary>
        /// The chain of virtual hard disks is corrupted. A differencing disk is indicated in its own parent chain.
        /// </summary>
        public const int STATUS_VHD_DIFFERENCING_CHAIN_CYCLE_DETECTED = unchecked((int)0xC03A0018);

        /// <summary>
        /// The chain of virtual hard disks is inaccessible. There was an error opening a virtual hard disk further up the chain.
        /// </summary>
        public const int STATUS_VHD_DIFFERENCING_CHAIN_ERROR_IN_PARENT = unchecked((int)0xC03A0019);

        /// <summary>
        /// The requested operation could not be completed due to a virtual disk system limitation.  Virtual hard disk files must be uncompressed and unencrypted and must not be sparse.
        /// </summary>
        public const int STATUS_VIRTUAL_DISK_LIMITATION = unchecked((int)0xC03A001A);

        /// <summary>
        /// The requested operation cannot be performed on a virtual disk of this type.
        /// </summary>
        public const int STATUS_VHD_INVALID_TYPE = unchecked((int)0xC03A001B);

        /// <summary>
        /// The requested operation cannot be performed on the virtual disk in its current state.
        /// </summary>
        public const int STATUS_VHD_INVALID_STATE = unchecked((int)0xC03A001C);

        /// <summary>
        /// The sector size of the physical disk on which the virtual disk resides is not supported.
        /// </summary>
        public const int STATUS_VIRTDISK_UNSUPPORTED_DISK_SECTOR_SIZE = unchecked((int)0xC03A001D);

        /// <summary>
        /// The disk is already owned by a different owner.
        /// </summary>
        public const int STATUS_VIRTDISK_DISK_ALREADY_OWNED = unchecked((int)0xC03A001E);

        /// <summary>
        /// The disk must be offline or read-only.
        /// </summary>
        public const int STATUS_VIRTDISK_DISK_ONLINE_AND_WRITABLE = unchecked((int)0xC03A001F);

        /// <summary>
        /// Change Tracking is not initialized for this virtual disk.
        /// </summary>
        public const int STATUS_CTLOG_TRACKING_NOT_INITIALIZED = unchecked((int)0xC03A0020);

        /// <summary>
        /// Size of change tracking file exceeded the maximum size limit.
        /// </summary>
        public const int STATUS_CTLOG_LOGFILE_SIZE_EXCEEDED_MAXSIZE = unchecked((int)0xC03A0021);

        /// <summary>
        /// VHD file is changed due to compaction, expansion, or offline updates.
        /// </summary>
        public const int STATUS_CTLOG_VHD_CHANGED_OFFLINE = unchecked((int)0xC03A0022);

        /// <summary>
        /// Change Tracking for the virtual disk is not in a valid state to perform this request.  Change tracking could be discontinued or already in the requested state.
        /// </summary>
        public const int STATUS_CTLOG_INVALID_TRACKING_STATE = unchecked((int)0xC03A0023);

        /// <summary>
        /// Change Tracking file for the virtual disk is not in a valid state.
        /// </summary>
        public const int STATUS_CTLOG_INCONSISTENT_TRACKING_FILE = unchecked((int)0xC03A0024);

        /// <summary>
        /// There is not enough space in the virtual disk file for the provided metadata item.
        /// </summary>
        public const int STATUS_VHD_METADATA_FULL = unchecked((int)0xC03A0028);

        /// <summary>
        /// The specified change tracking identifier is not valid.
        /// </summary>
        public const int STATUS_VHD_INVALID_CHANGE_TRACKING_ID = unchecked((int)0xC03A0029);

        /// <summary>
        /// Change tracking is disabled for the specified virtual hard disk, so no change tracking information is available.
        /// </summary>
        public const int STATUS_VHD_CHANGE_TRACKING_DISABLED = unchecked((int)0xC03A002A);

        /// <summary>
        /// There is no change tracking data available associated with the specified change tracking identifier.
        /// </summary>
        public const int STATUS_VHD_MISSING_CHANGE_TRACKING_INFORMATION = unchecked((int)0xC03A0030);

        /// <summary>
        /// The requested resize operation might truncate user data residing on the virtual disk.
        /// </summary>
        public const int STATUS_VHD_RESIZE_WOULD_TRUNCATE_DATA = unchecked((int)0xC03A0031);

        /// <summary>
        /// The minimum safe size of the virtual disk could not be determined. This may be due to a missing or corrupt partition table.
        /// </summary>
        public const int STATUS_VHD_COULD_NOT_COMPUTE_MINIMUM_VIRTUAL_SIZE = unchecked((int)0xC03A0032);

        /// <summary>
        /// The size of the virtual disk cannot be safely reduced further.
        /// </summary>
        public const int STATUS_VHD_ALREADY_AT_OR_BELOW_MINIMUM_VIRTUAL_SIZE = unchecked((int)0xC03A0033);


        //
        // Vhd warnings.
        //

        /// <summary>
        /// The virtualization storage subsystem has generated an error.
        /// </summary>
        public const int STATUS_QUERY_STORAGE_ERROR = unchecked((int)0x803A0001);


        //
        // NtGdi warnings.
        //

        /// <summary>
        /// GDI handles were potentially leaked by the application.
        /// </summary>
        public const int STATUS_GDI_HANDLE_LEAK = unchecked((int)0x803F0001);


        //
        // Resume Key Filter (RKF) error codes.
        //
        /// <summary>
        /// The Resume Key Filter could not find the resume key supplied for the operation.
        /// </summary>
        public const int STATUS_RKF_KEY_NOT_FOUND = unchecked((int)0xC0400001);

        /// <summary>
        /// The Resume Key Filter found an existing resume key that matches the one supplied for the handle.
        /// </summary>
        public const int STATUS_RKF_DUPLICATE_KEY = unchecked((int)0xC0400002);

        /// <summary>
        /// The Resume Key Filter data blob attached to the handle is full. No more space is available.
        /// </summary>
        public const int STATUS_RKF_BLOB_FULL = unchecked((int)0xC0400003);

        /// <summary>
        /// The Resume Key Filter handle store is full. No more resume handles can be accepted.
        /// </summary>
        public const int STATUS_RKF_STORE_FULL = unchecked((int)0xC0400004);

        /// <summary>
        /// The Resume Key Filter failed the operation because the file is temporarily blocked pending the resume of existing handles on the file.
        /// </summary>
        public const int STATUS_RKF_FILE_BLOCKED = unchecked((int)0xC0400005);

        /// <summary>
        /// The Resume Key Filter found an existing resume key that matches the one supplied on a handle that's active/open. The operation requires an inactive/closed handle.
        /// </summary>
        public const int STATUS_RKF_ACTIVE_KEY = unchecked((int)0xC0400006);


        //
        // RDBSS / MiniRdr internal error codes.
        //
        /// <summary>
        /// The operation must be restarted by RDBSS.
        /// </summary>
        public const int STATUS_RDBSS_RESTART_OPERATION = unchecked((int)0xC0410001);

        /// <summary>
        /// The operation must continue processing.
        /// </summary>
        public const int STATUS_RDBSS_CONTINUE_OPERATION = unchecked((int)0xC0410002);

        /// <summary>
        /// The operation must be posted to a thread to be retried at passive IRQL.
        /// </summary>
        public const int STATUS_RDBSS_POST_OPERATION = unchecked((int)0xC0410003);

        /// <summary>
        /// The caller must retry by looking up the object in the name table.
        /// </summary>
        public const int STATUS_RDBSS_RETRY_LOOKUP = unchecked((int)0xC0410004);

        //
        // Bluetooth Attribute Protocol Warnings
        //

        /// <summary>
        /// The attribute handle given was not valid on this server.
        /// </summary>
        public const int STATUS_BTH_ATT_INVALID_HANDLE = unchecked((int)0xC0420001);

        /// <summary>
        /// The attribute cannot be read.
        /// </summary>
        public const int STATUS_BTH_ATT_READ_NOT_PERMITTED = unchecked((int)0xC0420002);

        /// <summary>
        /// The attribute cannot be written.
        /// </summary>
        public const int STATUS_BTH_ATT_WRITE_NOT_PERMITTED = unchecked((int)0xC0420003);

        /// <summary>
        /// The attribute PDU was invalid.
        /// </summary>
        public const int STATUS_BTH_ATT_INVALID_PDU = unchecked((int)0xC0420004);

        /// <summary>
        /// The attribute requires authentication before it can be read or written.
        /// </summary>
        public const int STATUS_BTH_ATT_INSUFFICIENT_AUTHENTICATION = unchecked((int)0xC0420005);

        /// <summary>
        /// Attribute server does not support the request received from the client.
        /// </summary>
        public const int STATUS_BTH_ATT_REQUEST_NOT_SUPPORTED = unchecked((int)0xC0420006);

        /// <summary>
        /// Offset specified was past the end of the attribute.
        /// </summary>
        public const int STATUS_BTH_ATT_INVALID_OFFSET = unchecked((int)0xC0420007);

        /// <summary>
        /// The attribute requires authorization before it can be read or written.
        /// </summary>
        public const int STATUS_BTH_ATT_INSUFFICIENT_AUTHORIZATION = unchecked((int)0xC0420008);

        /// <summary>
        /// Too many prepare writes have been queued.
        /// </summary>
        public const int STATUS_BTH_ATT_PREPARE_QUEUE_FULL = unchecked((int)0xC0420009);

        /// <summary>
        /// No attribute found within the given attribute handle range.
        /// </summary>
        public const int STATUS_BTH_ATT_ATTRIBUTE_NOT_FOUND = unchecked((int)0xC042000A);

        /// <summary>
        /// The attribute cannot be read or written using the Read Blob Request.
        /// </summary>
        public const int STATUS_BTH_ATT_ATTRIBUTE_NOT_LONG = unchecked((int)0xC042000B);

        /// <summary>
        /// The Encryption Key Size used for encrypting this link is insufficient.
        /// </summary>
        public const int STATUS_BTH_ATT_INSUFFICIENT_ENCRYPTION_KEY_SIZE = unchecked((int)0xC042000C);

        /// <summary>
        /// The attribute value length is invalid for the operation.
        /// </summary>
        public const int STATUS_BTH_ATT_INVALID_ATTRIBUTE_VALUE_LENGTH = unchecked((int)0xC042000D);

        /// <summary>
        /// The attribute request that was requested has encountered an error that was unlikely, and therefore could not be completed as requested.
        /// </summary>
        public const int STATUS_BTH_ATT_UNLIKELY = unchecked((int)0xC042000E);

        /// <summary>
        /// The attribute requires encryption before it can be read or written.
        /// </summary>
        public const int STATUS_BTH_ATT_INSUFFICIENT_ENCRYPTION = unchecked((int)0xC042000F);

        /// <summary>
        /// The attribute type is not a supported grouping attribute as defined by a higher layer specification.
        /// </summary>
        public const int STATUS_BTH_ATT_UNSUPPORTED_GROUP_TYPE = unchecked((int)0xC0420010);

        /// <summary>
        /// Insufficient Resources to complete the request.
        /// </summary>
        public const int STATUS_BTH_ATT_INSUFFICIENT_RESOURCES = unchecked((int)0xC0420011);

        /// <summary>
        /// An error that lies in the reserved range has been received.
        /// </summary>
        public const int STATUS_BTH_ATT_UNKNOWN_ERROR = unchecked((int)0xC0421000);

        //
        // Secure Boot error messages.
        //
        /// <summary>
        /// Secure Boot detected that rollback of protected data has been attempted.
        /// </summary>
        public const int STATUS_SECUREBOOT_ROLLBACK_DETECTED = unchecked((int)0xC0430001);

        /// <summary>
        /// The value is protected by Secure Boot policy and cannot be modified or deleted.
        /// </summary>
        public const int STATUS_SECUREBOOT_POLICY_VIOLATION = unchecked((int)0xC0430002);

        /// <summary>
        /// The Secure Boot policy is invalid.
        /// </summary>
        public const int STATUS_SECUREBOOT_INVALID_POLICY = unchecked((int)0xC0430003);

        /// <summary>
        /// A new Secure Boot policy did not contain the current publisher on its update list.
        /// </summary>
        public const int STATUS_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND = unchecked((int)0xC0430004);

        /// <summary>
        /// The Secure Boot policy is either not signed or is signed by a non-trusted signer.
        /// </summary>
        public const int STATUS_SECUREBOOT_POLICY_NOT_SIGNED = unchecked((int)0xC0430005);

        /// <summary>
        /// Secure Boot is not enabled on this machine.
        /// </summary>
        public const int STATUS_SECUREBOOT_NOT_ENABLED = unchecked((int)0x80430006);

        /// <summary>
        /// Secure Boot requires that certain files and drivers are not replaced by other files or drivers.
        /// </summary>
        public const int STATUS_SECUREBOOT_FILE_REPLACED = unchecked((int)0xC0430007);

        /// <summary>
        /// The Secure Boot Supplemental Policy file was not authorized on this machine.
        /// </summary>
        public const int STATUS_SECUREBOOT_POLICY_NOT_AUTHORIZED = unchecked((int)0xC0430008);

        /// <summary>
        /// The Supplemntal Policy is not recognized on this device.
        /// </summary>
        public const int STATUS_SECUREBOOT_POLICY_UNKNOWN = unchecked((int)0xC0430009);

        /// <summary>
        /// The Antirollback version was not found in the Secure Boot Policy.
        /// </summary>
        public const int STATUS_SECUREBOOT_POLICY_MISSING_ANTIROLLBACKVERSION = unchecked((int)0xC043000A);

        /// <summary>
        /// The Platform ID specified in the Secure Boot policy does not match the Platform ID on this device.
        /// </summary>
        public const int STATUS_SECUREBOOT_PLATFORM_ID_MISMATCH = unchecked((int)0xC043000B);

        /// <summary>
        /// The Secure Boot policy file has an older Antirollback Version than this device.
        /// </summary>
        public const int STATUS_SECUREBOOT_POLICY_ROLLBACK_DETECTED = unchecked((int)0xC043000C);

        /// <summary>
        /// The Secure Boot policy file does not match the upgraded legacy policy.
        /// </summary>
        public const int STATUS_SECUREBOOT_POLICY_UPGRADE_MISMATCH = unchecked((int)0xC043000D);

        /// <summary>
        /// The Secure Boot policy file is required but could not be found.
        /// </summary>
        public const int STATUS_SECUREBOOT_REQUIRED_POLICY_FILE_MISSING = unchecked((int)0xC043000E);

        /// <summary>
        /// Supplemental Secure Boot policy file can not be loaded as a base Secure Boot policy.
        /// </summary>
        public const int STATUS_SECUREBOOT_NOT_BASE_POLICY = unchecked((int)0xC043000F);

        /// <summary>
        /// Base Secure Boot policy file can not be loaded as a Supplemental Secure Boot policy.
        /// </summary>
        public const int STATUS_SECUREBOOT_NOT_SUPPLEMENTAL_POLICY = unchecked((int)0xC0430010);

        //
        // Platform Manifest Error Messages
        //
        /// <summary>
        /// The Platform Manifest file was not authorized on this machine.
        /// </summary>
        public const int STATUS_PLATFORM_MANIFEST_NOT_AUTHORIZED = unchecked((int)0xC0EB0001);

        /// <summary>
        /// The Platform Manifest file was not valid.
        /// </summary>
        public const int STATUS_PLATFORM_MANIFEST_INVALID = unchecked((int)0xC0EB0002);

        /// <summary>
        /// The file is not authorized on this platform because an entry was not found in the Platform Manifest.
        /// </summary>
        public const int STATUS_PLATFORM_MANIFEST_FILE_NOT_AUTHORIZED = unchecked((int)0xC0EB0003);

        /// <summary>
        /// The catalog is not authorized on this platform because an entry was not found in the Platform Manifest.
        /// </summary>
        public const int STATUS_PLATFORM_MANIFEST_CATALOG_NOT_AUTHORIZED = unchecked((int)0xC0EB0004);

        /// <summary>
        /// The file is not authorized on this platform because a Binary ID was not found in the embedded signature.
        /// </summary>
        public const int STATUS_PLATFORM_MANIFEST_BINARY_ID_NOT_FOUND = unchecked((int)0xC0EB0005);

        /// <summary>
        /// No active Platform Manifest exists on this system.
        /// </summary>
        public const int STATUS_PLATFORM_MANIFEST_NOT_ACTIVE = unchecked((int)0xC0EB0006);

        /// <summary>
        /// The Platform Manifest file was not properly signed.
        /// </summary>
        public const int STATUS_PLATFORM_MANIFEST_NOT_SIGNED = unchecked((int)0xC0EB0007);

        //
        // System Integrity Policy error messages.
        //
        /// <summary>
        /// System Integrity detected that policy rollback has been attempted.
        /// </summary>
        public const int STATUS_SYSTEM_INTEGRITY_ROLLBACK_DETECTED = unchecked((int)0xC0E90001);

        /// <summary>
        /// System Integrity policy has been violated.
        /// </summary>
        public const int STATUS_SYSTEM_INTEGRITY_POLICY_VIOLATION = unchecked((int)0xC0E90002);

        /// <summary>
        /// The System Integrity policy is invalid.
        /// </summary>
        public const int STATUS_SYSTEM_INTEGRITY_INVALID_POLICY = unchecked((int)0xC0E90003);

        /// <summary>
        /// The System Integrity policy is either not signed or is signed by a non-trusted signer.
        /// </summary>
        public const int STATUS_SYSTEM_INTEGRITY_POLICY_NOT_SIGNED = unchecked((int)0xC0E90004);

        //
        // Clip modern app and windows licensing error messages.
        //
        /// <summary>
        /// No applicable app licenses found.
        /// </summary>
        public const int STATUS_NO_APPLICABLE_APP_LICENSES_FOUND = unchecked((int)0xC0EA0001);

        /// <summary>
        /// CLiP license not found.
        /// </summary>
        public const int STATUS_CLIP_LICENSE_NOT_FOUND = unchecked((int)0xC0EA0002);

        /// <summary>
        /// CLiP device license not found.
        /// </summary>
        public const int STATUS_CLIP_DEVICE_LICENSE_MISSING = unchecked((int)0xC0EA0003);

        /// <summary>
        /// CLiP license has an invalid signature.
        /// </summary>
        public const int STATUS_CLIP_LICENSE_INVALID_SIGNATURE = unchecked((int)0xC0EA0004);

        /// <summary>
        /// CLiP keyholder license is invalid or missing.
        /// </summary>
        public const int STATUS_CLIP_KEYHOLDER_LICENSE_MISSING_OR_INVALID = unchecked((int)0xC0EA0005);

        /// <summary>
        /// CLiP license has expired.
        /// </summary>
        public const int STATUS_CLIP_LICENSE_EXPIRED = unchecked((int)0xC0EA0006);

        /// <summary>
        /// CLiP license is signed by an unknown source.
        /// </summary>
        public const int STATUS_CLIP_LICENSE_SIGNED_BY_UNKNOWN_SOURCE = unchecked((int)0xC0EA0007);

        /// <summary>
        /// CLiP license is not signed.
        /// </summary>
        public const int STATUS_CLIP_LICENSE_NOT_SIGNED = unchecked((int)0xC0EA0008);

        /// <summary>
        /// CLiP license hardware ID is out of tolerance.
        /// </summary>
        public const int STATUS_CLIP_LICENSE_HARDWARE_ID_OUT_OF_TOLERANCE = unchecked((int)0xC0EA0009);

        /// <summary>
        /// CLiP license device ID does not match the device ID in the bound device license.
        /// </summary>
        public const int STATUS_CLIP_LICENSE_DEVICE_ID_MISMATCH = unchecked((int)0xC0EA000A);

        //
        // Audio error messages.
        //
        /// <summary>
        /// PortCls could not find an audio engine node exposed by a miniport driver claiming support for IMiniportAudioEngineNode.
        /// </summary>
        public const int STATUS_AUDIO_ENGINE_NODE_NOT_FOUND = unchecked((int)0xC0440001);

        /// <summary>
        /// HD Audio widget encountered an unexpected empty connection list.
        /// </summary>
        public const int STATUS_HDAUDIO_EMPTY_CONNECTION_LIST = unchecked((int)0xC0440002);

        /// <summary>
        /// HD Audio widget does not support the connection list parameter.
        /// </summary>
        public const int STATUS_HDAUDIO_CONNECTION_LIST_NOT_SUPPORTED = unchecked((int)0xC0440003);

        /// <summary>
        /// No HD Audio subdevices were successfully created.
        /// </summary>
        public const int STATUS_HDAUDIO_NO_LOGICAL_DEVICES_CREATED = unchecked((int)0xC0440004);

        /// <summary>
        /// An unexpected NULL pointer was encountered in a linked list.
        /// </summary>
        public const int STATUS_HDAUDIO_NULL_LINKED_LIST_ENTRY = unchecked((int)0xC0440005);

        //
        // Spaceport success codes (spaceport.sys)
        //
        /// <summary>
        /// The repair was successful.
        /// </summary>
        public const int STATUS_SPACES_REPAIRED = 0x00E70000;

        /// <summary>
        /// The operation has been paused.
        /// </summary>
        public const int STATUS_SPACES_PAUSE = 0x00E70001;

        /// <summary>
        /// The operation is complete.
        /// </summary>
        public const int STATUS_SPACES_COMPLETE = 0x00E70002;

        /// <summary>
        /// The operation should be redirected to another node.
        /// </summary>
        public const int STATUS_SPACES_REDIRECT = 0x00E70003;

        //
        // Spaceport error codes (spaceport.sys)
        //
        /// <summary>
        /// The specified fault domain type or combination of minimum / maximum fault domain type is not valid.
        /// </summary>
        public const int STATUS_SPACES_FAULT_DOMAIN_TYPE_INVALID = unchecked((int)0xC0E70001);

        /// <summary>
        /// The specified resiliency type is not valid.
        /// </summary>
        public const int STATUS_SPACES_RESILIENCY_TYPE_INVALID = unchecked((int)0xC0E70003);

        /// <summary>
        /// The sector size of the physical disk is not supported by the storage pool.
        /// </summary>
        public const int STATUS_SPACES_DRIVE_SECTOR_SIZE_INVALID = unchecked((int)0xC0E70004);

        /// <summary>
        /// The value for fault tolerance is outside of the supported range of values.
        /// </summary>
        public const int STATUS_SPACES_DRIVE_REDUNDANCY_INVALID = unchecked((int)0xC0E70006);

        /// <summary>
        /// The number of data copies requested is outside of the supported range of values.
        /// </summary>
        public const int STATUS_SPACES_NUMBER_OF_DATA_COPIES_INVALID = unchecked((int)0xC0E70007);

        /// <summary>
        /// The value for interleave length is outside of the supported range of values or is not a power of 2.
        /// </summary>
        public const int STATUS_SPACES_INTERLEAVE_LENGTH_INVALID = unchecked((int)0xC0E70009);

        /// <summary>
        /// The number of columns specified is outside of the supported range of values.
        /// </summary>
        public const int STATUS_SPACES_NUMBER_OF_COLUMNS_INVALID = unchecked((int)0xC0E7000A);

        /// <summary>
        /// There were not enough physical disks to complete the requested operation.
        /// </summary>
        public const int STATUS_SPACES_NOT_ENOUGH_DRIVES = unchecked((int)0xC0E7000B);

        /// <summary>
        /// Extended error information is available.
        /// </summary>
        public const int STATUS_SPACES_EXTENDED_ERROR = unchecked((int)0xC0E7000C);

        /// <summary>
        /// The specified provisioning type is not valid.
        /// </summary>
        public const int STATUS_SPACES_PROVISIONING_TYPE_INVALID = unchecked((int)0xC0E7000D);

        /// <summary>
        /// The allocation size is outside of the supported range of values.
        /// </summary>
        public const int STATUS_SPACES_ALLOCATION_SIZE_INVALID = unchecked((int)0xC0E7000E);

        /// <summary>
        /// Enclosure awareness is not supported for this virtual disk.
        /// </summary>
        public const int STATUS_SPACES_ENCLOSURE_AWARE_INVALID = unchecked((int)0xC0E7000F);

        /// <summary>
        /// The write cache size is outside of the supported range of values.
        /// </summary>
        public const int STATUS_SPACES_WRITE_CACHE_SIZE_INVALID = unchecked((int)0xC0E70010);

        /// <summary>
        /// The value for number of groups is outside of the supported range of values.
        /// </summary>
        public const int STATUS_SPACES_NUMBER_OF_GROUPS_INVALID = unchecked((int)0xC0E70011);

        /// <summary>
        /// The OperationalState of the physical disk is invalid for this operation.
        /// </summary>
        public const int STATUS_SPACES_DRIVE_OPERATIONAL_STATE_INVALID = unchecked((int)0xC0E70012);

        /// <summary>
        /// A column's state needs to be updated.
        /// </summary>
        public const int STATUS_SPACES_UPDATE_COLUMN_STATE = unchecked((int)0xC0E70013);

        /// <summary>
        /// An extent needs to be allocated.
        /// </summary>
        public const int STATUS_SPACES_MAP_REQUIRED = unchecked((int)0xC0E70014);

        /// <summary>
        /// The metadata version is unsupported.
        /// </summary>
        public const int STATUS_SPACES_UNSUPPORTED_VERSION = unchecked((int)0xC0E70015);

        /// <summary>
        /// The metadata read was corrupt.
        /// </summary>
        public const int STATUS_SPACES_CORRUPT_METADATA = unchecked((int)0xC0E70016);

        /// <summary>
        /// The DRT is full.
        /// </summary>
        public const int STATUS_SPACES_DRT_FULL = unchecked((int)0xC0E70017);

        /// <summary>
        /// An inconsistency was found.
        /// </summary>
        public const int STATUS_SPACES_INCONSISTENCY = unchecked((int)0xC0E70018);

        /// <summary>
        /// The log is not ready.
        /// </summary>
        public const int STATUS_SPACES_LOG_NOT_READY = unchecked((int)0xC0E70019);

        /// <summary>
        /// No good copy of data was available.
        /// </summary>
        public const int STATUS_SPACES_NO_REDUNDANCY = unchecked((int)0xC0E7001A);

        /// <summary>
        /// The drive is not ready.
        /// </summary>
        public const int STATUS_SPACES_DRIVE_NOT_READY = unchecked((int)0xC0E7001B);

        /// <summary>
        /// The data on this drive is stale.
        /// </summary>
        public const int STATUS_SPACES_DRIVE_SPLIT = unchecked((int)0xC0E7001C);

        /// <summary>
        /// The data on this drive has been lost.
        /// </summary>
        public const int STATUS_SPACES_DRIVE_LOST_DATA = unchecked((int)0xC0E7001D);

        //
        // Volsnap status codes (volsnap.sys)
        //
        /// <summary>
        /// The bootfile is too small to support persistent snapshots.
        /// </summary>
        public const int STATUS_VOLSNAP_BOOTFILE_NOT_VALID = unchecked((int)0xC0500003);

        /// <summary>
        /// Activation of persistent snapshots on this volume took longer than was allowed.
        /// </summary>
        public const int STATUS_VOLSNAP_ACTIVATION_TIMEOUT = unchecked((int)0xC0500004);

        //
        // Sdbus status codes (sdbus.sys)
        //
        /// <summary>
        /// The operation was preempted by a higher priority operation. It must be resumed later.
        /// </summary>
        public const int STATUS_IO_PREEMPTED = unchecked((int)0xC0510001);

        //
        // Shared VHDX status codes (svhdxflt.sys)
        //
        /// <summary>
        /// The proper error code with sense data was stored on server side.
        /// </summary>
        public const int STATUS_SVHDX_ERROR_STORED = unchecked((int)0xC05C0000);

        /// <summary>
        /// The requested error data is not available on the server.
        /// </summary>
        public const int STATUS_SVHDX_ERROR_NOT_AVAILABLE = unchecked((int)0xC05CFF00);

        /// <summary>
        /// Unit Attention data is available for the initiator to query.
        /// </summary>
        public const int STATUS_SVHDX_UNIT_ATTENTION_AVAILABLE = unchecked((int)0xC05CFF01);

        /// <summary>
        /// The data capacity of the device has changed, resulting in a Unit Attention condition.
        /// </summary>
        public const int STATUS_SVHDX_UNIT_ATTENTION_CAPACITY_DATA_CHANGED = unchecked((int)0xC05CFF02);

        /// <summary>
        /// A previous operation resulted in this initiator's reservations being preempted, resulting in a Unit Attention condition.
        /// </summary>
        public const int STATUS_SVHDX_UNIT_ATTENTION_RESERVATIONS_PREEMPTED = unchecked((int)0xC05CFF03);

        /// <summary>
        /// A previous operation resulted in this initiator's reservations being released, resulting in a Unit Attention condition.
        /// </summary>
        public const int STATUS_SVHDX_UNIT_ATTENTION_RESERVATIONS_RELEASED = unchecked((int)0xC05CFF04);

        /// <summary>
        /// A previous operation resulted in this initiator's registrations being preempted, resulting in a Unit Attention condition.
        /// </summary>
        public const int STATUS_SVHDX_UNIT_ATTENTION_REGISTRATIONS_PREEMPTED = unchecked((int)0xC05CFF05);

        /// <summary>
        /// The data storage format of the device has changed, resulting in a Unit Attention condition.
        /// </summary>
        public const int STATUS_SVHDX_UNIT_ATTENTION_OPERATING_DEFINITION_CHANGED = unchecked((int)0xC05CFF06);

        /// <summary>
        /// The current initiator is not allowed to perform the SCSI command because of a reservation conflict.
        /// </summary>
        public const int STATUS_SVHDX_RESERVATION_CONFLICT = unchecked((int)0xC05CFF07);

        /// <summary>
        /// Multiple virtual machines sharing a virtual hard disk is supported only on Fixed or Dynamic VHDX format virtual hard disks.
        /// </summary>
        public const int STATUS_SVHDX_WRONG_FILE_TYPE = unchecked((int)0xC05CFF08);

        /// <summary>
        /// The server version does not match the requested version.
        /// </summary>
        public const int STATUS_SVHDX_VERSION_MISMATCH = unchecked((int)0xC05CFF09);

        /// <summary>
        /// The requested operation cannot be performed on the virtual disk as it is currently used in shared mode.
        /// </summary>
        public const int STATUS_VHD_SHARED = unchecked((int)0xC05CFF0A);

        /// <summary>
        /// Invalid Shared VHDX open due to lack of initiator ID. Check for related Continuous Availability failures.
        /// </summary>
        public const int STATUS_SVHDX_NO_INITIATOR = unchecked((int)0xC05CFF0B);

        /// <summary>
        /// The requested operation failed due to a missing backing storage file.
        /// </summary>
        public const int STATUS_VHDSET_BACKING_STORAGE_NOT_FOUND = unchecked((int)0xC05CFF0C);

        //
        // SMB status codes
        //
        /// <summary>
        /// Failed to negotiate a preauthentication integrity hash function.
        /// </summary>
        public const int STATUS_SMB_NO_PREAUTH_INTEGRITY_HASH_OVERLAP = unchecked((int)0xC05D0000);

        /// <summary>
        /// The current cluster functional level does not support this SMB dialect.
        /// </summary>
        public const int STATUS_SMB_BAD_CLUSTER_DIALECT = unchecked((int)0xC05D0001);

        /// <summary>
        /// You can't access this shared folder because your organization's security policies block unauthenticated guest access. These policies help protect your PC from unsafe or malicious devices on the network.
        /// </summary>
        public const int STATUS_SMB_GUEST_LOGON_BLOCKED = unchecked((int)0xC05D0002);

        //
        // Embedded Security Core
        //
        // Reserved id values 0x0001 - 0x00FF
        //                    0x8xxx
        //                    0x4xxx
        /// <summary>
        /// The command was not recognized by the security core
        /// </summary>
        public const int STATUS_SECCORE_INVALID_COMMAND = unchecked((int)0xC0E80000);

        //
        // Virtual Secure Mode (VSM)
        //
        /// <summary>
        /// Virtual Secure Mode (VSM) is not initialized. The hypervisor or VSM may not be present or enabled.
        /// </summary>
        public const int STATUS_VSM_NOT_INITIALIZED = unchecked((int)0xC0450000);

        /// <summary>
        /// The hypervisor is not protecting DMA because an IOMMU is not present or not enabled in the BIOS.
        /// </summary>
        public const int STATUS_VSM_DMA_PROTECTION_NOT_IN_USE = unchecked((int)0xC0450001);

        //
        // Application Execution (AppExec)
        //
        /// <summary>
        /// The condition supplied for the app execution request was not satisfied, so the request was not performed.
        /// </summary>
        public const int STATUS_APPEXEC_CONDITION_NOT_SATISFIED = unchecked((int)0xC0EC0000);

        /// <summary>
        /// The supplied handle has been invalidated and may not be used for the requested operation.
        /// </summary>
        public const int STATUS_APPEXEC_HANDLE_INVALIDATED = unchecked((int)0xC0EC0001);

        /// <summary>
        /// The supplied host generation has been invalidated and may not be used for the requested operation.
        /// </summary>
        public const int STATUS_APPEXEC_INVALID_HOST_GENERATION = unchecked((int)0xC0EC0002);

        /// <summary>
        /// An attempt to register a process failed because the target host was not in a valid state to receive process registrations.
        /// </summary>
        public const int STATUS_APPEXEC_UNEXPECTED_PROCESS_REGISTRATION = unchecked((int)0xC0EC0003);

        /// <summary>
        /// The host is not in a valid state to support the execution request.
        /// </summary>
        public const int STATUS_APPEXEC_INVALID_HOST_STATE = unchecked((int)0xC0EC0004);

        /// <summary>
        /// The operation was not completed because a required resource donor was not found for the host.
        /// </summary>
        public const int STATUS_APPEXEC_NO_DONOR = unchecked((int)0xC0EC0005);

        /// <summary>
        /// The operation was not completed because an unexpected host ID was encountered.
        /// </summary>
        public const int STATUS_APPEXEC_HOST_ID_MISMATCH = unchecked((int)0xC0EC0006);
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

namespace THNETII.WindowsProtocols.WindowsErrorCodes.Constants
{
    using static WinErrorConstants;
    using static WinErrorFunctions;

    /// <summary>
    /// <para>COM Error Codes</para>
    /// <para>
    /// The return value of COM functions and methods is an <see cref="T:THNETII.WindowsProtocols.WindowsErrorCodes.HRESULT"/>.
    /// This is not a handle to anything, but is merely a 32-bit value
    /// with several fields encoded in the value. The parts of an
    /// <see cref="T:THNETII.WindowsProtocols.WindowsErrorCodes.HRESULT"/> are shown below.
    /// </para>
    /// </summary>
    /// <remarks>
    /// <see cref="T:THNETII.WindowsProtocols.WindowsErrorCodes.HRESULT"/>s are 32 bit values layed out as follows:
    /// <code>
    ///  3 3 2 2 2 2 2 2 2 2 2 2 1 1 1 1 1 1 1 1 1 1
    ///  1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0
    /// +-+-+-+-+-+---------------------+-------------------------------+
    /// |S|R|C|N|r|    Facility         |               Code            |
    /// +-+-+-+-+-+---------------------+-------------------------------+
    /// </code>
    /// where
    /// <list type="table">
    /// <listheader><term>Field</term><description>Description</description></listheader>
    /// <item>
    /// <term><c>S</c></term>
    /// <description>
    /// Severity – indicates success/fail
    /// <list type="table">
    /// <listheader><term>Value</term><description>Meaning</description></listheader>
    /// <item><term><c>0</c> (zero)</term><description>Success</description></item>
    /// <item><term><c>1</c></term><description>Fail (COERROR)</description></item>
    /// </list>
    /// </description>
    /// </item>
    /// <item>
    /// <term><c>R</c></term>
    /// <description>reserved portion of the facility code, corresponds to NT's second severity bit.</description>
    /// </item>
    /// <item>
    /// <term><c>C</c></term>
    /// <description>reserved portion of the facility code, corresponds to NT's C field.</description>
    /// </item>
    /// <item>
    /// <term><c>N</c></term>
    /// <description>reserved portion of the facility code. Used to indicate a mapped NT status value.</description>
    /// </item>
    /// <item>
    /// <term><c>r</c></term>
    /// <description>
    /// reserved portion of the facility code. Reserved for internal
    /// use. Used to indicate <see cref="T:THNETII.WindowsProtocols.WindowsErrorCodes.HRESULT"/> values that are not status
    /// values, but are instead message ids for display strings.
    /// </description>
    /// </item>
    /// <item><term>Facility</term><description>is the facility code</description></item>
    /// <item><term>Code</term><description>is the facility's status code</description></item>
    /// </list>
    /// </remarks>
    /// <seealso cref="T:THNETII.WindowsProtocols.WindowsErrorCodes.HRESULT"/>
    public static class HResultConstants
    {
        ////////////////////////////////////
        //                                //
        //     COM Error Codes            //
        //                                //
        ////////////////////////////////////


        //
        // The return value of COM functions and methods is an HRESULT.
        // This is not a handle to anything, but is merely a 32-bit value
        // with several fields encoded in the value. The parts of an
        // HRESULT are shown below.
        //
        // Many of the macros and functions below were orginally defined to
        // operate on SCODEs. SCODEs are no longer used. The macros are
        // still present for compatibility and easy porting of Win16 code.
        // Newly written code should use the HRESULT macros and functions.
        //

        //
        //  HRESULTs are 32 bit values layed out as follows:
        //
        //   3 3 2 2 2 2 2 2 2 2 2 2 1 1 1 1 1 1 1 1 1 1
        //   1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0
        //  +-+-+-+-+-+---------------------+-------------------------------+
        //  |S|R|C|N|r|    Facility         |               Code            |
        //  +-+-+-+-+-+---------------------+-------------------------------+
        //
        //  where
        //
        //      S - Severity - indicates success/fail
        //
        //          0 - Success
        //          1 - Fail (COERROR)
        //
        //      R - reserved portion of the facility code, corresponds to NT's
        //              second severity bit.
        //
        //      C - reserved portion of the facility code, corresponds to NT's
        //              C field.
        //
        //      N - reserved portion of the facility code. Used to indicate a
        //              mapped NT status value.
        //
        //      r - reserved portion of the facility code. Reserved for internal
        //              use. Used to indicate HRESULT values that are not status
        //              values, but are instead message ids for display strings.
        //
        //      Facility - is the facility code
        //
        //      Code - is the facility's status code
        //

        //
        // Map a WIN32 error value into a HRESULT
        // Note: This assumes that WIN32 errors fall in the range -32k to 32k.
        //
        // Define bits here so macros are guaranteed to work

        public const int FACILITY_NT_BIT = 0x10000000;

        public static readonly int E_NOT_SET = HRESULT_FROM_WIN32(ERROR_NOT_FOUND);
        public static readonly int E_NOT_VALID_STATE = HRESULT_FROM_WIN32(ERROR_INVALID_STATE);
        public static readonly int E_NOT_SUFFICIENT_BUFFER = HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER);

        // ---------------------- HRESULT value definitions -----------------
        //
        // HRESULT definitions
        //

        public const int NOERROR = 0;

        //
        // Error definitions follow
        //

        //
        // Codes 0x4000-0x40ff are reserved for OLE
        //
        //
        // Error codes
        //
        /// <summary>
        /// Catastrophic failure
        /// </summary>
        public const int E_UNEXPECTED = unchecked((int)0x8000FFFF);

        /// <summary>
        /// Not implemented
        /// </summary>
        public const int E_NOTIMPL = unchecked((int)0x80004001);

        /// <summary>
        /// Ran out of memory
        /// </summary>
        public const int E_OUTOFMEMORY = unchecked((int)0x8007000E);

        /// <summary>
        /// One or more arguments are invalid
        /// </summary>
        public const int E_INVALIDARG = unchecked((int)0x80070057);

        /// <summary>
        /// No such interface supported
        /// </summary>
        public const int E_NOINTERFACE = unchecked((int)0x80004002);

        /// <summary>
        /// Invalid pointer
        /// </summary>
        public const int E_POINTER = unchecked((int)0x80004003);

        /// <summary>
        /// Invalid handle
        /// </summary>
        public const int E_HANDLE = unchecked((int)0x80070006);

        /// <summary>
        /// Operation aborted
        /// </summary>
        public const int E_ABORT = unchecked((int)0x80004004);

        /// <summary>
        /// Unspecified error
        /// </summary>
        public const int E_FAIL = unchecked((int)0x80004005);

        /// <summary>
        /// General access denied error
        /// </summary>
        public const int E_ACCESSDENIED = unchecked((int)0x80070005);

        /// <summary>
        /// The data necessary to complete this operation is not yet available.
        /// </summary>
        public const int E_PENDING = unchecked((int)0x8000000A);

        /// <summary>
        /// The operation attempted to access data outside the valid range
        /// </summary>
        public const int E_BOUNDS = unchecked((int)0x8000000B);

        /// <summary>
        /// A concurrent or interleaved operation changed the state of the object, invalidating this operation.
        /// </summary>
        public const int E_CHANGED_STATE = unchecked((int)0x8000000C);

        /// <summary>
        /// An illegal state change was requested.
        /// </summary>
        public const int E_ILLEGAL_STATE_CHANGE = unchecked((int)0x8000000D);

        /// <summary>
        /// A method was called at an unexpected time.
        /// </summary>
        public const int E_ILLEGAL_METHOD_CALL = unchecked((int)0x8000000E);

        /// <summary>
        /// Typename or Namespace was not found in metadata file.
        /// </summary>
        public const int RO_E_METADATA_NAME_NOT_FOUND = unchecked((int)0x8000000F);

        /// <summary>
        /// Name is an existing namespace rather than a typename.
        /// </summary>
        public const int RO_E_METADATA_NAME_IS_NAMESPACE = unchecked((int)0x80000010);

        /// <summary>
        /// Typename has an invalid format.
        /// </summary>
        public const int RO_E_METADATA_INVALID_TYPE_FORMAT = unchecked((int)0x80000011);

        /// <summary>
        /// Metadata file is invalid or corrupted.
        /// </summary>
        public const int RO_E_INVALID_METADATA_FILE = unchecked((int)0x80000012);

        /// <summary>
        /// The object has been closed.
        /// </summary>
        public const int RO_E_CLOSED = unchecked((int)0x80000013);

        /// <summary>
        /// Only one thread may access the object during a write operation.
        /// </summary>
        public const int RO_E_EXCLUSIVE_WRITE = unchecked((int)0x80000014);

        /// <summary>
        /// Operation is prohibited during change notification.
        /// </summary>
        public const int RO_E_CHANGE_NOTIFICATION_IN_PROGRESS = unchecked((int)0x80000015);

        /// <summary>
        /// The text associated with this error code could not be found.
        /// </summary>
        public const int RO_E_ERROR_STRING_NOT_FOUND = unchecked((int)0x80000016);

        /// <summary>
        /// String not null terminated.
        /// </summary>
        public const int E_STRING_NOT_NULL_TERMINATED = unchecked((int)0x80000017);

        /// <summary>
        /// A delegate was assigned when not allowed.
        /// </summary>
        public const int E_ILLEGAL_DELEGATE_ASSIGNMENT = unchecked((int)0x80000018);

        /// <summary>
        /// An async operation was not properly started.
        /// </summary>
        public const int E_ASYNC_OPERATION_NOT_STARTED = unchecked((int)0x80000019);

        /// <summary>
        /// The application is exiting and cannot service this request
        /// </summary>
        public const int E_APPLICATION_EXITING = unchecked((int)0x8000001A);

        /// <summary>
        /// The application view is exiting and cannot service this request
        /// </summary>
        public const int E_APPLICATION_VIEW_EXITING = unchecked((int)0x8000001B);

        /// <summary>
        /// The object must support the IAgileObject interface
        /// </summary>
        public const int RO_E_MUST_BE_AGILE = unchecked((int)0x8000001C);

        /// <summary>
        /// Activating a single-threaded class from MTA is not supported
        /// </summary>
        public const int RO_E_UNSUPPORTED_FROM_MTA = unchecked((int)0x8000001D);

        /// <summary>
        /// The object has been committed.
        /// </summary>
        public const int RO_E_COMMITTED = unchecked((int)0x8000001E);

        /// <summary>
        /// A COM call to an ASTA was blocked because the call chain originated in or passed through another ASTA. This call pattern is deadlock-prone and disallowed by apartment call control.
        /// </summary>
        public const int RO_E_BLOCKED_CROSS_ASTA_CALL = unchecked((int)0x8000001F);

        /// <summary>
        /// A universal application process cannot activate a packaged WinRT server that is declared to run full trust.
        /// </summary>
        public const int RO_E_CANNOT_ACTIVATE_FULL_TRUST_SERVER = unchecked((int)0x80000020);

        /// <summary>
        /// A full trust packaged application process cannot activate a packaged WinRT server unless it is also declared to run full trust.
        /// </summary>
        public const int RO_E_CANNOT_ACTIVATE_UNIVERSAL_APPLICATION_SERVER = unchecked((int)0x80000021);

        /// <summary>
        /// Thread local storage failure
        /// </summary>
        public const int CO_E_INIT_TLS = unchecked((int)0x80004006);

        /// <summary>
        /// Get shared memory allocator failure
        /// </summary>
        public const int CO_E_INIT_SHARED_ALLOCATOR = unchecked((int)0x80004007);

        /// <summary>
        /// Get memory allocator failure
        /// </summary>
        public const int CO_E_INIT_MEMORY_ALLOCATOR = unchecked((int)0x80004008);

        /// <summary>
        /// Unable to initialize class cache
        /// </summary>
        public const int CO_E_INIT_CLASS_CACHE = unchecked((int)0x80004009);

        /// <summary>
        /// Unable to initialize RPC services
        /// </summary>
        public const int CO_E_INIT_RPC_CHANNEL = unchecked((int)0x8000400A);

        /// <summary>
        /// Cannot set thread local storage channel control
        /// </summary>
        public const int CO_E_INIT_TLS_SET_CHANNEL_CONTROL = unchecked((int)0x8000400B);

        /// <summary>
        /// Could not allocate thread local storage channel control
        /// </summary>
        public const int CO_E_INIT_TLS_CHANNEL_CONTROL = unchecked((int)0x8000400C);

        /// <summary>
        /// The user supplied memory allocator is unacceptable
        /// </summary>
        public const int CO_E_INIT_UNACCEPTED_USER_ALLOCATOR = unchecked((int)0x8000400D);

        /// <summary>
        /// The OLE service mutex already exists
        /// </summary>
        public const int CO_E_INIT_SCM_MUTEX_EXISTS = unchecked((int)0x8000400E);

        /// <summary>
        /// The OLE service file mapping already exists
        /// </summary>
        public const int CO_E_INIT_SCM_FILE_MAPPING_EXISTS = unchecked((int)0x8000400F);

        /// <summary>
        /// Unable to map view of file for OLE service
        /// </summary>
        public const int CO_E_INIT_SCM_MAP_VIEW_OF_FILE = unchecked((int)0x80004010);

        /// <summary>
        /// Failure attempting to launch OLE service
        /// </summary>
        public const int CO_E_INIT_SCM_EXEC_FAILURE = unchecked((int)0x80004011);

        /// <summary>
        /// There was an attempt to call CoInitialize a second time while single threaded
        /// </summary>
        public const int CO_E_INIT_ONLY_SINGLE_THREADED = unchecked((int)0x80004012);

        /// <summary>
        /// A Remote activation was necessary but was not allowed
        /// </summary>
        public const int CO_E_CANT_REMOTE = unchecked((int)0x80004013);

        /// <summary>
        /// A Remote activation was necessary but the server name provided was invalid
        /// </summary>
        public const int CO_E_BAD_SERVER_NAME = unchecked((int)0x80004014);

        /// <summary>
        /// The class is configured to run as a security id different from the caller
        /// </summary>
        public const int CO_E_WRONG_SERVER_IDENTITY = unchecked((int)0x80004015);

        /// <summary>
        /// Use of Ole1 services requiring DDE windows is disabled
        /// </summary>
        public const int CO_E_OLE1DDE_DISABLED = unchecked((int)0x80004016);

        /// <summary>
        /// A RunAs specification must be &lt;domain name&gt;\&lt;user name&gt; or simply &lt;user name&gt;
        /// </summary>
        public const int CO_E_RUNAS_SYNTAX = unchecked((int)0x80004017);

        /// <summary>
        /// The server process could not be started. The pathname may be incorrect.
        /// </summary>
        public const int CO_E_CREATEPROCESS_FAILURE = unchecked((int)0x80004018);

        /// <summary>
        /// The server process could not be started as the configured identity. The pathname may be incorrect or unavailable.
        /// </summary>
        public const int CO_E_RUNAS_CREATEPROCESS_FAILURE = unchecked((int)0x80004019);

        /// <summary>
        /// The server process could not be started because the configured identity is incorrect. Check the username and password.
        /// </summary>
        public const int CO_E_RUNAS_LOGON_FAILURE = unchecked((int)0x8000401A);

        /// <summary>
        /// The client is not allowed to launch this server.
        /// </summary>
        public const int CO_E_LAUNCH_PERMSSION_DENIED = unchecked((int)0x8000401B);

        /// <summary>
        /// The service providing this server could not be started.
        /// </summary>
        public const int CO_E_START_SERVICE_FAILURE = unchecked((int)0x8000401C);

        /// <summary>
        /// This computer was unable to communicate with the computer providing the server.
        /// </summary>
        public const int CO_E_REMOTE_COMMUNICATION_FAILURE = unchecked((int)0x8000401D);

        /// <summary>
        /// The server did not respond after being launched.
        /// </summary>
        public const int CO_E_SERVER_START_TIMEOUT = unchecked((int)0x8000401E);

        /// <summary>
        /// The registration information for this server is inconsistent or incomplete.
        /// </summary>
        public const int CO_E_CLSREG_INCONSISTENT = unchecked((int)0x8000401F);

        /// <summary>
        /// The registration information for this interface is inconsistent or incomplete.
        /// </summary>
        public const int CO_E_IIDREG_INCONSISTENT = unchecked((int)0x80004020);

        /// <summary>
        /// The operation attempted is not supported.
        /// </summary>
        public const int CO_E_NOT_SUPPORTED = unchecked((int)0x80004021);

        /// <summary>
        /// A dll must be loaded.
        /// </summary>
        public const int CO_E_RELOAD_DLL = unchecked((int)0x80004022);

        /// <summary>
        /// A Microsoft Software Installer error was encountered.
        /// </summary>
        public const int CO_E_MSI_ERROR = unchecked((int)0x80004023);

        /// <summary>
        /// The specified activation could not occur in the client context as specified.
        /// </summary>
        public const int CO_E_ATTEMPT_TO_CREATE_OUTSIDE_CLIENT_CONTEXT = unchecked((int)0x80004024);

        /// <summary>
        /// Activations on the server are paused.
        /// </summary>
        public const int CO_E_SERVER_PAUSED = unchecked((int)0x80004025);

        /// <summary>
        /// Activations on the server are not paused.
        /// </summary>
        public const int CO_E_SERVER_NOT_PAUSED = unchecked((int)0x80004026);

        /// <summary>
        /// The component or application containing the component has been disabled.
        /// </summary>
        public const int CO_E_CLASS_DISABLED = unchecked((int)0x80004027);

        /// <summary>
        /// The common language runtime is not available
        /// </summary>
        public const int CO_E_CLRNOTAVAILABLE = unchecked((int)0x80004028);

        /// <summary>
        /// The thread-pool rejected the submitted asynchronous work.
        /// </summary>
        public const int CO_E_ASYNC_WORK_REJECTED = unchecked((int)0x80004029);

        /// <summary>
        /// The server started, but did not finish initializing in a timely fashion.
        /// </summary>
        public const int CO_E_SERVER_INIT_TIMEOUT = unchecked((int)0x8000402A);

        /// <summary>
        /// Unable to complete the call since there is no COM+ security context inside IObjectControl.Activate.
        /// </summary>
        public const int CO_E_NO_SECCTX_IN_ACTIVATE = unchecked((int)0x8000402B);

        /// <summary>
        /// The provided tracker configuration is invalid
        /// </summary>
        public const int CO_E_TRACKER_CONFIG = unchecked((int)0x80004030);

        /// <summary>
        /// The provided thread pool configuration is invalid
        /// </summary>
        public const int CO_E_THREADPOOL_CONFIG = unchecked((int)0x80004031);

        /// <summary>
        /// The provided side-by-side configuration is invalid
        /// </summary>
        public const int CO_E_SXS_CONFIG = unchecked((int)0x80004032);

        /// <summary>
        /// The server principal name (SPN) obtained during security negotiation is malformed.
        /// </summary>
        public const int CO_E_MALFORMED_SPN = unchecked((int)0x80004033);

        /// <summary>
        /// The caller failed to revoke a per-apartment registration before apartment shutdown.
        /// </summary>
        public const int CO_E_UNREVOKED_REGISTRATION_ON_APARTMENT_SHUTDOWN = unchecked((int)0x80004034);

        /// <summary>
        /// The object has been rundown by the stub manager while there are external clients.
        /// </summary>
        public const int CO_E_PREMATURE_STUB_RUNDOWN = unchecked((int)0x80004035);


        //
        // Success codes
        //

        public const int S_OK = 0;
        public const int S_FALSE = 1;

        // ******************
        // FACILITY_ITF
        // ******************

        //
        // Codes 0x0-0x01ff are reserved for the OLE group of
        // interfaces.
        //


        //
        // Generic OLE errors that may be returned by many inerfaces
        //

        public const int OLE_E_FIRST = unchecked((int)0x80040000);
        public const int OLE_E_LAST = unchecked((int)0x800400FF);
        public const int OLE_S_FIRST = 0x00040000;
        public const int OLE_S_LAST = 0x000400FF;

        //
        // Old OLE errors
        //

        /// <summary>
        /// Invalid OLEVERB structure
        /// </summary>
        public const int OLE_E_OLEVERB = unchecked((int)0x80040000);

        /// <summary>
        /// Invalid advise flags
        /// </summary>
        public const int OLE_E_ADVF = unchecked((int)0x80040001);

        /// <summary>
        /// Can't enumerate any more, because the associated data is missing
        /// </summary>
        public const int OLE_E_ENUM_NOMORE = unchecked((int)0x80040002);

        /// <summary>
        /// This implementation doesn't take advises
        /// </summary>
        public const int OLE_E_ADVISENOTSUPPORTED = unchecked((int)0x80040003);

        /// <summary>
        /// There is no connection for this connection ID
        /// </summary>
        public const int OLE_E_NOCONNECTION = unchecked((int)0x80040004);

        /// <summary>
        /// Need to run the object to perform this operation
        /// </summary>
        public const int OLE_E_NOTRUNNING = unchecked((int)0x80040005);

        /// <summary>
        /// There is no cache to operate on
        /// </summary>
        public const int OLE_E_NOCACHE = unchecked((int)0x80040006);

        /// <summary>
        /// Uninitialized object
        /// </summary>
        public const int OLE_E_BLANK = unchecked((int)0x80040007);

        /// <summary>
        /// Linked object's source class has changed
        /// </summary>
        public const int OLE_E_CLASSDIFF = unchecked((int)0x80040008);

        /// <summary>
        /// Not able to get the moniker of the object
        /// </summary>
        public const int OLE_E_CANT_GETMONIKER = unchecked((int)0x80040009);

        /// <summary>
        /// Not able to bind to the source
        /// </summary>
        public const int OLE_E_CANT_BINDTOSOURCE = unchecked((int)0x8004000A);

        /// <summary>
        /// Object is static; operation not allowed
        /// </summary>
        public const int OLE_E_STATIC = unchecked((int)0x8004000B);

        /// <summary>
        /// User canceled out of save dialog
        /// </summary>
        public const int OLE_E_PROMPTSAVECANCELLED = unchecked((int)0x8004000C);

        /// <summary>
        /// Invalid rectangle
        /// </summary>
        public const int OLE_E_INVALIDRECT = unchecked((int)0x8004000D);

        /// <summary>
        /// compobj.dll is too old for the ole2.dll initialized
        /// </summary>
        public const int OLE_E_WRONGCOMPOBJ = unchecked((int)0x8004000E);

        /// <summary>
        /// Invalid window handle
        /// </summary>
        public const int OLE_E_INVALIDHWND = unchecked((int)0x8004000F);

        /// <summary>
        /// Object is not in any of the inplace active states
        /// </summary>
        public const int OLE_E_NOT_INPLACEACTIVE = unchecked((int)0x80040010);

        /// <summary>
        /// Not able to convert object
        /// </summary>
        public const int OLE_E_CANTCONVERT = unchecked((int)0x80040011);

        /// <summary>
        /// Not able to perform the operation because object is not given storage yet
        /// </summary>
        public const int OLE_E_NOSTORAGE = unchecked((int)0x80040012);

        /// <summary>
        /// Invalid FORMATETC structure
        /// </summary>
        public const int DV_E_FORMATETC = unchecked((int)0x80040064);

        /// <summary>
        /// Invalid DVTARGETDEVICE structure
        /// </summary>
        public const int DV_E_DVTARGETDEVICE = unchecked((int)0x80040065);

        /// <summary>
        /// Invalid STDGMEDIUM structure
        /// </summary>
        public const int DV_E_STGMEDIUM = unchecked((int)0x80040066);

        /// <summary>
        /// Invalid STATDATA structure
        /// </summary>
        public const int DV_E_STATDATA = unchecked((int)0x80040067);

        /// <summary>
        /// Invalid lindex
        /// </summary>
        public const int DV_E_LINDEX = unchecked((int)0x80040068);

        /// <summary>
        /// Invalid tymed
        /// </summary>
        public const int DV_E_TYMED = unchecked((int)0x80040069);

        /// <summary>
        /// Invalid clipboard format
        /// </summary>
        public const int DV_E_CLIPFORMAT = unchecked((int)0x8004006A);

        /// <summary>
        /// Invalid aspect(s)
        /// </summary>
        public const int DV_E_DVASPECT = unchecked((int)0x8004006B);

        /// <summary>
        /// tdSize parameter of the DVTARGETDEVICE structure is invalid
        /// </summary>
        public const int DV_E_DVTARGETDEVICE_SIZE = unchecked((int)0x8004006C);

        /// <summary>
        /// Object doesn't support IViewObject interface
        /// </summary>
        public const int DV_E_NOIVIEWOBJECT = unchecked((int)0x8004006D);

        public const int DRAGDROP_E_FIRST = unchecked((int)0x80040100);
        public const int DRAGDROP_E_LAST = unchecked((int)0x8004010F);
        public const int DRAGDROP_S_FIRST = 0x00040100;
        public const int DRAGDROP_S_LAST = 0x0004010F;
        /// <summary>
        /// Trying to revoke a drop target that has not been registered
        /// </summary>
        public const int DRAGDROP_E_NOTREGISTERED = unchecked((int)0x80040100);

        /// <summary>
        /// This window has already been registered as a drop target
        /// </summary>
        public const int DRAGDROP_E_ALREADYREGISTERED = unchecked((int)0x80040101);

        /// <summary>
        /// Invalid window handle
        /// </summary>
        public const int DRAGDROP_E_INVALIDHWND = unchecked((int)0x80040102);

        /// <summary>
        /// A drag operation is already in progress
        /// </summary>
        public const int DRAGDROP_E_CONCURRENT_DRAG_ATTEMPTED = unchecked((int)0x80040103);

        public const int CLASSFACTORY_E_FIRST = unchecked((int)0x80040110);
        public const int CLASSFACTORY_E_LAST = unchecked((int)0x8004011F);
        public const int CLASSFACTORY_S_FIRST = 0x00040110;
        public const int CLASSFACTORY_S_LAST = 0x0004011F;
        /// <summary>
        /// Class does not support aggregation (or class object is remote)
        /// </summary>
        public const int CLASS_E_NOAGGREGATION = unchecked((int)0x80040110);

        /// <summary>
        /// ClassFactory cannot supply requested class
        /// </summary>
        public const int CLASS_E_CLASSNOTAVAILABLE = unchecked((int)0x80040111);

        /// <summary>
        /// Class is not licensed for use
        /// </summary>
        public const int CLASS_E_NOTLICENSED = unchecked((int)0x80040112);

        public const int MARSHAL_E_FIRST = unchecked((int)0x80040120);
        public const int MARSHAL_E_LAST = unchecked((int)0x8004012F);
        public const int MARSHAL_S_FIRST = 0x00040120;
        public const int MARSHAL_S_LAST = 0x0004012F;
        public const int DATA_E_FIRST = unchecked((int)0x80040130);
        public const int DATA_E_LAST = unchecked((int)0x8004013F);
        public const int DATA_S_FIRST = 0x00040130;
        public const int DATA_S_LAST = 0x0004013F;
        public const int VIEW_E_FIRST = unchecked((int)0x80040140);
        public const int VIEW_E_LAST = unchecked((int)0x8004014F);
        public const int VIEW_S_FIRST = 0x00040140;
        public const int VIEW_S_LAST = 0x0004014F;
        /// <summary>
        /// Error drawing view
        /// </summary>
        public const int VIEW_E_DRAW = unchecked((int)0x80040140);

        public const int REGDB_E_FIRST = unchecked((int)0x80040150);
        public const int REGDB_E_LAST = unchecked((int)0x8004015F);
        public const int REGDB_S_FIRST = 0x00040150;
        public const int REGDB_S_LAST = 0x0004015F;
        /// <summary>
        /// Could not read key from registry
        /// </summary>
        public const int REGDB_E_READREGDB = unchecked((int)0x80040150);

        /// <summary>
        /// Could not write key to registry
        /// </summary>
        public const int REGDB_E_WRITEREGDB = unchecked((int)0x80040151);

        /// <summary>
        /// Could not find the key in the registry
        /// </summary>
        public const int REGDB_E_KEYMISSING = unchecked((int)0x80040152);

        /// <summary>
        /// Invalid value for registry
        /// </summary>
        public const int REGDB_E_INVALIDVALUE = unchecked((int)0x80040153);

        /// <summary>
        /// Class not registered
        /// </summary>
        public const int REGDB_E_CLASSNOTREG = unchecked((int)0x80040154);

        /// <summary>
        /// Interface not registered
        /// </summary>
        public const int REGDB_E_IIDNOTREG = unchecked((int)0x80040155);

        /// <summary>
        /// Threading model entry is not valid
        /// </summary>
        public const int REGDB_E_BADTHREADINGMODEL = unchecked((int)0x80040156);

        /// <summary>
        /// A registration in a package violates package-specific policies
        /// </summary>
        public const int REGDB_E_PACKAGEPOLICYVIOLATION = unchecked((int)0x80040157);

        public const int CAT_E_FIRST = unchecked((int)0x80040160);
        public const int CAT_E_LAST = unchecked((int)0x80040161);
        /// <summary>
        /// CATID does not exist
        /// </summary>
        public const int CAT_E_CATIDNOEXIST = unchecked((int)0x80040160);

        /// <summary>
        /// Description not found
        /// </summary>
        public const int CAT_E_NODESCRIPTION = unchecked((int)0x80040161);

        ////////////////////////////////////
        //                                //
        //     Class Store Error Codes    //
        //                                //
        ////////////////////////////////////
        public const int CS_E_FIRST = unchecked((int)0x80040164);
        public const int CS_E_LAST = unchecked((int)0x8004016F);
        /// <summary>
        /// No package in the software installation data in the Active Directory meets this criteria.
        /// </summary>
        public const int CS_E_PACKAGE_NOTFOUND = unchecked((int)0x80040164);

        /// <summary>
        /// Deleting this will break the referential integrity of the software installation data in the Active Directory.
        /// </summary>
        public const int CS_E_NOT_DELETABLE = unchecked((int)0x80040165);

        /// <summary>
        /// The CLSID was not found in the software installation data in the Active Directory.
        /// </summary>
        public const int CS_E_CLASS_NOTFOUND = unchecked((int)0x80040166);

        /// <summary>
        /// The software installation data in the Active Directory is corrupt.
        /// </summary>
        public const int CS_E_INVALID_VERSION = unchecked((int)0x80040167);

        /// <summary>
        /// There is no software installation data in the Active Directory.
        /// </summary>
        public const int CS_E_NO_CLASSSTORE = unchecked((int)0x80040168);

        /// <summary>
        /// There is no software installation data object in the Active Directory.
        /// </summary>
        public const int CS_E_OBJECT_NOTFOUND = unchecked((int)0x80040169);

        /// <summary>
        /// The software installation data object in the Active Directory already exists.
        /// </summary>
        public const int CS_E_OBJECT_ALREADY_EXISTS = unchecked((int)0x8004016A);

        /// <summary>
        /// The path to the software installation data in the Active Directory is not correct.
        /// </summary>
        public const int CS_E_INVALID_PATH = unchecked((int)0x8004016B);

        /// <summary>
        /// A network error interrupted the operation.
        /// </summary>
        public const int CS_E_NETWORK_ERROR = unchecked((int)0x8004016C);

        /// <summary>
        /// The size of this object exceeds the maximum size set by the Administrator.
        /// </summary>
        public const int CS_E_ADMIN_LIMIT_EXCEEDED = unchecked((int)0x8004016D);

        /// <summary>
        /// The schema for the software installation data in the Active Directory does not match the required schema.
        /// </summary>
        public const int CS_E_SCHEMA_MISMATCH = unchecked((int)0x8004016E);

        /// <summary>
        /// An error occurred in the software installation data in the Active Directory.
        /// </summary>
        public const int CS_E_INTERNAL_ERROR = unchecked((int)0x8004016F);

        public const int CACHE_E_FIRST = unchecked((int)0x80040170);
        public const int CACHE_E_LAST = unchecked((int)0x8004017F);
        public const int CACHE_S_FIRST = 0x00040170;
        public const int CACHE_S_LAST = 0x0004017F;
        /// <summary>
        /// Cache not updated
        /// </summary>
        public const int CACHE_E_NOCACHE_UPDATED = unchecked((int)0x80040170);

        public const int OLEOBJ_E_FIRST = unchecked((int)0x80040180);
        public const int OLEOBJ_E_LAST = unchecked((int)0x8004018F);
        public const int OLEOBJ_S_FIRST = 0x00040180;
        public const int OLEOBJ_S_LAST = 0x0004018F;
        /// <summary>
        /// No verbs for OLE object
        /// </summary>
        public const int OLEOBJ_E_NOVERBS = unchecked((int)0x80040180);

        /// <summary>
        /// Invalid verb for OLE object
        /// </summary>
        public const int OLEOBJ_E_INVALIDVERB = unchecked((int)0x80040181);

        public const int CLIENTSITE_E_FIRST = unchecked((int)0x80040190);
        public const int CLIENTSITE_E_LAST = unchecked((int)0x8004019F);
        public const int CLIENTSITE_S_FIRST = 0x00040190;
        public const int CLIENTSITE_S_LAST = 0x0004019F;
        /// <summary>
        /// Undo is not available
        /// </summary>
        public const int INPLACE_E_NOTUNDOABLE = unchecked((int)0x800401A0);

        /// <summary>
        /// Space for tools is not available
        /// </summary>
        public const int INPLACE_E_NOTOOLSPACE = unchecked((int)0x800401A1);

        public const int INPLACE_E_FIRST = unchecked((int)0x800401A0);
        public const int INPLACE_E_LAST = unchecked((int)0x800401AF);
        public const int INPLACE_S_FIRST = 0x000401A0;
        public const int INPLACE_S_LAST = 0x000401AF;
        public const int ENUM_E_FIRST = unchecked((int)0x800401B0);
        public const int ENUM_E_LAST = unchecked((int)0x800401BF);
        public const int ENUM_S_FIRST = 0x000401B0;
        public const int ENUM_S_LAST = 0x000401BF;
        public const int CONVERT10_E_FIRST = unchecked((int)0x800401C0);
        public const int CONVERT10_E_LAST = unchecked((int)0x800401CF);
        public const int CONVERT10_S_FIRST = 0x000401C0;
        public const int CONVERT10_S_LAST = 0x000401CF;
        /// <summary>
        /// OLESTREAM Get method failed
        /// </summary>
        public const int CONVERT10_E_OLESTREAM_GET = unchecked((int)0x800401C0);

        /// <summary>
        /// OLESTREAM Put method failed
        /// </summary>
        public const int CONVERT10_E_OLESTREAM_PUT = unchecked((int)0x800401C1);

        /// <summary>
        /// Contents of the OLESTREAM not in correct format
        /// </summary>
        public const int CONVERT10_E_OLESTREAM_FMT = unchecked((int)0x800401C2);

        /// <summary>
        /// There was an error in a Windows GDI call while converting the bitmap to a DIB
        /// </summary>
        public const int CONVERT10_E_OLESTREAM_BITMAP_TO_DIB = unchecked((int)0x800401C3);

        /// <summary>
        /// Contents of the IStorage not in correct format
        /// </summary>
        public const int CONVERT10_E_STG_FMT = unchecked((int)0x800401C4);

        /// <summary>
        /// Contents of IStorage is missing one of the standard streams
        /// </summary>
        public const int CONVERT10_E_STG_NO_STD_STREAM = unchecked((int)0x800401C5);

        /// <summary>
        /// There was an error in a Windows GDI call while converting the DIB to a bitmap.
        /// </summary>
        public const int CONVERT10_E_STG_DIB_TO_BITMAP = unchecked((int)0x800401C6);

        public const int CLIPBRD_E_FIRST = unchecked((int)0x800401D0);
        public const int CLIPBRD_E_LAST = unchecked((int)0x800401DF);
        public const int CLIPBRD_S_FIRST = 0x000401D0;
        public const int CLIPBRD_S_LAST = 0x000401DF;
        /// <summary>
        /// OpenClipboard Failed
        /// </summary>
        public const int CLIPBRD_E_CANT_OPEN = unchecked((int)0x800401D0);

        /// <summary>
        /// EmptyClipboard Failed
        /// </summary>
        public const int CLIPBRD_E_CANT_EMPTY = unchecked((int)0x800401D1);

        /// <summary>
        /// SetClipboard Failed
        /// </summary>
        public const int CLIPBRD_E_CANT_SET = unchecked((int)0x800401D2);

        /// <summary>
        /// Data on clipboard is invalid
        /// </summary>
        public const int CLIPBRD_E_BAD_DATA = unchecked((int)0x800401D3);

        /// <summary>
        /// CloseClipboard Failed
        /// </summary>
        public const int CLIPBRD_E_CANT_CLOSE = unchecked((int)0x800401D4);

        public const int MK_E_FIRST = unchecked((int)0x800401E0);
        public const int MK_E_LAST = unchecked((int)0x800401EF);
        public const int MK_S_FIRST = 0x000401E0;
        public const int MK_S_LAST = 0x000401EF;
        /// <summary>
        /// Moniker needs to be connected manually
        /// </summary>
        public const int MK_E_CONNECTMANUALLY = unchecked((int)0x800401E0);

        /// <summary>
        /// Operation exceeded deadline
        /// </summary>
        public const int MK_E_EXCEEDEDDEADLINE = unchecked((int)0x800401E1);

        /// <summary>
        /// Moniker needs to be generic
        /// </summary>
        public const int MK_E_NEEDGENERIC = unchecked((int)0x800401E2);

        /// <summary>
        /// Operation unavailable
        /// </summary>
        public const int MK_E_UNAVAILABLE = unchecked((int)0x800401E3);

        /// <summary>
        /// Invalid syntax
        /// </summary>
        public const int MK_E_SYNTAX = unchecked((int)0x800401E4);

        /// <summary>
        /// No object for moniker
        /// </summary>
        public const int MK_E_NOOBJECT = unchecked((int)0x800401E5);

        /// <summary>
        /// Bad extension for file
        /// </summary>
        public const int MK_E_INVALIDEXTENSION = unchecked((int)0x800401E6);

        /// <summary>
        /// Intermediate operation failed
        /// </summary>
        public const int MK_E_INTERMEDIATEINTERFACENOTSUPPORTED = unchecked((int)0x800401E7);

        /// <summary>
        /// Moniker is not bindable
        /// </summary>
        public const int MK_E_NOTBINDABLE = unchecked((int)0x800401E8);

        /// <summary>
        /// Moniker is not bound
        /// </summary>
        public const int MK_E_NOTBOUND = unchecked((int)0x800401E9);

        /// <summary>
        /// Moniker cannot open file
        /// </summary>
        public const int MK_E_CANTOPENFILE = unchecked((int)0x800401EA);

        /// <summary>
        /// User input required for operation to succeed
        /// </summary>
        public const int MK_E_MUSTBOTHERUSER = unchecked((int)0x800401EB);

        /// <summary>
        /// Moniker class has no inverse
        /// </summary>
        public const int MK_E_NOINVERSE = unchecked((int)0x800401EC);

        /// <summary>
        /// Moniker does not refer to storage
        /// </summary>
        public const int MK_E_NOSTORAGE = unchecked((int)0x800401ED);

        /// <summary>
        /// No common prefix
        /// </summary>
        public const int MK_E_NOPREFIX = unchecked((int)0x800401EE);

        /// <summary>
        /// Moniker could not be enumerated
        /// </summary>
        public const int MK_E_ENUMERATION_FAILED = unchecked((int)0x800401EF);

        public const int CO_E_FIRST = unchecked((int)0x800401F0);
        public const int CO_E_LAST = unchecked((int)0x800401FF);
        public const int CO_S_FIRST = 0x000401F0;
        public const int CO_S_LAST = 0x000401FF;
        /// <summary>
        /// CoInitialize has not been called.
        /// </summary>
        public const int CO_E_NOTINITIALIZED = unchecked((int)0x800401F0);

        /// <summary>
        /// CoInitialize has already been called.
        /// </summary>
        public const int CO_E_ALREADYINITIALIZED = unchecked((int)0x800401F1);

        /// <summary>
        /// Class of object cannot be determined
        /// </summary>
        public const int CO_E_CANTDETERMINECLASS = unchecked((int)0x800401F2);

        /// <summary>
        /// Invalid class string
        /// </summary>
        public const int CO_E_CLASSSTRING = unchecked((int)0x800401F3);

        /// <summary>
        /// Invalid interface string
        /// </summary>
        public const int CO_E_IIDSTRING = unchecked((int)0x800401F4);

        /// <summary>
        /// Application not found
        /// </summary>
        public const int CO_E_APPNOTFOUND = unchecked((int)0x800401F5);

        /// <summary>
        /// Application cannot be run more than once
        /// </summary>
        public const int CO_E_APPSINGLEUSE = unchecked((int)0x800401F6);

        /// <summary>
        /// Some error in application program
        /// </summary>
        public const int CO_E_ERRORINAPP = unchecked((int)0x800401F7);

        /// <summary>
        /// DLL for class not found
        /// </summary>
        public const int CO_E_DLLNOTFOUND = unchecked((int)0x800401F8);

        /// <summary>
        /// Error in the DLL
        /// </summary>
        public const int CO_E_ERRORINDLL = unchecked((int)0x800401F9);

        /// <summary>
        /// Wrong OS or OS version for application
        /// </summary>
        public const int CO_E_WRONGOSFORAPP = unchecked((int)0x800401FA);

        /// <summary>
        /// Object is not registered
        /// </summary>
        public const int CO_E_OBJNOTREG = unchecked((int)0x800401FB);

        /// <summary>
        /// Object is already registered
        /// </summary>
        public const int CO_E_OBJISREG = unchecked((int)0x800401FC);

        /// <summary>
        /// Object is not connected to server
        /// </summary>
        public const int CO_E_OBJNOTCONNECTED = unchecked((int)0x800401FD);

        /// <summary>
        /// Application was launched but it didn't register a class factory
        /// </summary>
        public const int CO_E_APPDIDNTREG = unchecked((int)0x800401FE);

        /// <summary>
        /// Object has been released
        /// </summary>
        public const int CO_E_RELEASED = unchecked((int)0x800401FF);

        public const int EVENT_E_FIRST = unchecked((int)0x80040200);
        public const int EVENT_E_LAST = unchecked((int)0x8004021F);
        public const int EVENT_S_FIRST = 0x00040200;
        public const int EVENT_S_LAST = 0x0004021F;
        /// <summary>
        /// An event was able to invoke some but not all of the subscribers
        /// </summary>
        public const int EVENT_S_SOME_SUBSCRIBERS_FAILED = 0x00040200;

        /// <summary>
        /// An event was unable to invoke any of the subscribers
        /// </summary>
        public const int EVENT_E_ALL_SUBSCRIBERS_FAILED = unchecked((int)0x80040201);

        /// <summary>
        /// An event was delivered but there were no subscribers
        /// </summary>
        public const int EVENT_S_NOSUBSCRIBERS = 0x00040202;

        /// <summary>
        /// A syntax error occurred trying to evaluate a query string
        /// </summary>
        public const int EVENT_E_QUERYSYNTAX = unchecked((int)0x80040203);

        /// <summary>
        /// An invalid field name was used in a query string
        /// </summary>
        public const int EVENT_E_QUERYFIELD = unchecked((int)0x80040204);

        /// <summary>
        /// An unexpected exception was raised
        /// </summary>
        public const int EVENT_E_INTERNALEXCEPTION = unchecked((int)0x80040205);

        /// <summary>
        /// An unexpected internal error was detected
        /// </summary>
        public const int EVENT_E_INTERNALERROR = unchecked((int)0x80040206);

        /// <summary>
        /// The owner SID on a per-user subscription doesn't exist
        /// </summary>
        public const int EVENT_E_INVALID_PER_USER_SID = unchecked((int)0x80040207);

        /// <summary>
        /// A user-supplied component or subscriber raised an exception
        /// </summary>
        public const int EVENT_E_USER_EXCEPTION = unchecked((int)0x80040208);

        /// <summary>
        /// An interface has too many methods to fire events from
        /// </summary>
        public const int EVENT_E_TOO_MANY_METHODS = unchecked((int)0x80040209);

        /// <summary>
        /// A subscription cannot be stored unless its event class already exists
        /// </summary>
        public const int EVENT_E_MISSING_EVENTCLASS = unchecked((int)0x8004020A);

        /// <summary>
        /// Not all the objects requested could be removed
        /// </summary>
        public const int EVENT_E_NOT_ALL_REMOVED = unchecked((int)0x8004020B);

        /// <summary>
        /// COM+ is required for this operation, but is not installed
        /// </summary>
        public const int EVENT_E_COMPLUS_NOT_INSTALLED = unchecked((int)0x8004020C);

        /// <summary>
        /// Cannot modify or delete an object that was not added using the COM+ Admin SDK
        /// </summary>
        public const int EVENT_E_CANT_MODIFY_OR_DELETE_UNCONFIGURED_OBJECT = unchecked((int)0x8004020D);

        /// <summary>
        /// Cannot modify or delete an object that was added using the COM+ Admin SDK
        /// </summary>
        public const int EVENT_E_CANT_MODIFY_OR_DELETE_CONFIGURED_OBJECT = unchecked((int)0x8004020E);

        /// <summary>
        /// The event class for this subscription is in an invalid partition
        /// </summary>
        public const int EVENT_E_INVALID_EVENT_CLASS_PARTITION = unchecked((int)0x8004020F);

        /// <summary>
        /// The owner of the PerUser subscription is not logged on to the system specified
        /// </summary>
        public const int EVENT_E_PER_USER_SID_NOT_LOGGED_ON = unchecked((int)0x80040210);

        /// <summary>
        /// TabletPC inking error code. The property was not found, or supported by the recognizer
        /// </summary>
        public const int TPC_E_INVALID_PROPERTY = unchecked((int)0x80040241);

        /// <summary>
        /// TabletPC inking error code. No default tablet
        /// </summary>
        public const int TPC_E_NO_DEFAULT_TABLET = unchecked((int)0x80040212);

        /// <summary>
        /// TabletPC inking error code. Unknown property specified
        /// </summary>
        public const int TPC_E_UNKNOWN_PROPERTY = unchecked((int)0x8004021B);

        /// <summary>
        /// TabletPC inking error code. An invalid input rectangle was specified
        /// </summary>
        public const int TPC_E_INVALID_INPUT_RECT = unchecked((int)0x80040219);

        /// <summary>
        /// TabletPC inking error code. The stroke object was deleted
        /// </summary>
        public const int TPC_E_INVALID_STROKE = unchecked((int)0x80040222);

        /// <summary>
        /// TabletPC inking error code. Initialization failure
        /// </summary>
        public const int TPC_E_INITIALIZE_FAIL = unchecked((int)0x80040223);

        /// <summary>
        /// TabletPC inking error code. The data required for the operation was not supplied
        /// </summary>
        public const int TPC_E_NOT_RELEVANT = unchecked((int)0x80040232);

        /// <summary>
        /// TabletPC inking error code. Invalid packet description
        /// </summary>
        public const int TPC_E_INVALID_PACKET_DESCRIPTION = unchecked((int)0x80040233);

        /// <summary>
        /// TabletPC inking error code. There are no handwriting recognizers registered
        /// </summary>
        public const int TPC_E_RECOGNIZER_NOT_REGISTERED = unchecked((int)0x80040235);

        /// <summary>
        /// TabletPC inking error code. User does not have the necessary rights to read recognizer information
        /// </summary>
        public const int TPC_E_INVALID_RIGHTS = unchecked((int)0x80040236);

        /// <summary>
        /// TabletPC inking error code. API calls were made in an incorrect order
        /// </summary>
        public const int TPC_E_OUT_OF_ORDER_CALL = unchecked((int)0x80040237);

        /// <summary>
        /// TabletPC inking error code. Queue is full
        /// </summary>
        public const int TPC_E_QUEUE_FULL = unchecked((int)0x80040238);

        /// <summary>
        /// TabletPC inking error code. RtpEnabled called multiple times
        /// </summary>
        public const int TPC_E_INVALID_CONFIGURATION = unchecked((int)0x80040239);

        /// <summary>
        /// TabletPC inking error code. A recognizer returned invalid data
        /// </summary>
        public const int TPC_E_INVALID_DATA_FROM_RECOGNIZER = unchecked((int)0x8004023A);

        /// <summary>
        /// TabletPC inking error code. String was truncated
        /// </summary>
        public const int TPC_S_TRUNCATED = 0x00040252;

        /// <summary>
        /// TabletPC inking error code. Recognition or training was interrupted
        /// </summary>
        public const int TPC_S_INTERRUPTED = 0x00040253;

        /// <summary>
        /// TabletPC inking error code. No personalization update to the recognizer because no training data found
        /// </summary>
        public const int TPC_S_NO_DATA_TO_PROCESS = 0x00040254;

        public const int XACT_E_FIRST = unchecked((int)0x8004D000);
        public const int XACT_E_LAST = unchecked((int)0x8004D02B);
        public const int XACT_S_FIRST = 0x0004D000;
        public const int XACT_S_LAST = 0x0004D010;
        /// <summary>
        /// Another single phase resource manager has already been enlisted in this transaction.
        /// </summary>
        public const int XACT_E_ALREADYOTHERSINGLEPHASE = unchecked((int)0x8004D000);

        /// <summary>
        /// A retaining commit or abort is not supported
        /// </summary>
        public const int XACT_E_CANTRETAIN = unchecked((int)0x8004D001);

        /// <summary>
        /// The transaction failed to commit for an unknown reason. The transaction was aborted.
        /// </summary>
        public const int XACT_E_COMMITFAILED = unchecked((int)0x8004D002);

        /// <summary>
        /// Cannot call commit on this transaction object because the calling application did not initiate the transaction.
        /// </summary>
        public const int XACT_E_COMMITPREVENTED = unchecked((int)0x8004D003);

        /// <summary>
        /// Instead of committing, the resource heuristically aborted.
        /// </summary>
        public const int XACT_E_HEURISTICABORT = unchecked((int)0x8004D004);

        /// <summary>
        /// Instead of aborting, the resource heuristically committed.
        /// </summary>
        public const int XACT_E_HEURISTICCOMMIT = unchecked((int)0x8004D005);

        /// <summary>
        /// Some of the states of the resource were committed while others were aborted, likely because of heuristic decisions.
        /// </summary>
        public const int XACT_E_HEURISTICDAMAGE = unchecked((int)0x8004D006);

        /// <summary>
        /// Some of the states of the resource may have been committed while others may have been aborted, likely because of heuristic decisions.
        /// </summary>
        public const int XACT_E_HEURISTICDANGER = unchecked((int)0x8004D007);

        /// <summary>
        /// The requested isolation level is not valid or supported.
        /// </summary>
        public const int XACT_E_ISOLATIONLEVEL = unchecked((int)0x8004D008);

        /// <summary>
        /// The transaction manager doesn't support an asynchronous operation for this method.
        /// </summary>
        public const int XACT_E_NOASYNC = unchecked((int)0x8004D009);

        /// <summary>
        /// Unable to enlist in the transaction.
        /// </summary>
        public const int XACT_E_NOENLIST = unchecked((int)0x8004D00A);

        /// <summary>
        /// The requested semantics of retention of isolation across retaining commit and abort boundaries cannot be supported by this transaction implementation, or isoFlags was not equal to zero.
        /// </summary>
        public const int XACT_E_NOISORETAIN = unchecked((int)0x8004D00B);

        /// <summary>
        /// There is no resource presently associated with this enlistment
        /// </summary>
        public const int XACT_E_NORESOURCE = unchecked((int)0x8004D00C);

        /// <summary>
        /// The transaction failed to commit due to the failure of optimistic concurrency control in at least one of the resource managers.
        /// </summary>
        public const int XACT_E_NOTCURRENT = unchecked((int)0x8004D00D);

        /// <summary>
        /// The transaction has already been implicitly or explicitly committed or aborted
        /// </summary>
        public const int XACT_E_NOTRANSACTION = unchecked((int)0x8004D00E);

        /// <summary>
        /// An invalid combination of flags was specified
        /// </summary>
        public const int XACT_E_NOTSUPPORTED = unchecked((int)0x8004D00F);

        /// <summary>
        /// The resource manager id is not associated with this transaction or the transaction manager.
        /// </summary>
        public const int XACT_E_UNKNOWNRMGRID = unchecked((int)0x8004D010);

        /// <summary>
        /// This method was called in the wrong state
        /// </summary>
        public const int XACT_E_WRONGSTATE = unchecked((int)0x8004D011);

        /// <summary>
        /// The indicated unit of work does not match the unit of work expected by the resource manager.
        /// </summary>
        public const int XACT_E_WRONGUOW = unchecked((int)0x8004D012);

        /// <summary>
        /// An enlistment in a transaction already exists.
        /// </summary>
        public const int XACT_E_XTIONEXISTS = unchecked((int)0x8004D013);

        /// <summary>
        /// An import object for the transaction could not be found.
        /// </summary>
        public const int XACT_E_NOIMPORTOBJECT = unchecked((int)0x8004D014);

        /// <summary>
        /// The transaction cookie is invalid.
        /// </summary>
        public const int XACT_E_INVALIDCOOKIE = unchecked((int)0x8004D015);

        /// <summary>
        /// The transaction status is in doubt. A communication failure occurred, or a transaction manager or resource manager has failed
        /// </summary>
        public const int XACT_E_INDOUBT = unchecked((int)0x8004D016);

        /// <summary>
        /// A time-out was specified, but time-outs are not supported.
        /// </summary>
        public const int XACT_E_NOTIMEOUT = unchecked((int)0x8004D017);

        /// <summary>
        /// The requested operation is already in progress for the transaction.
        /// </summary>
        public const int XACT_E_ALREADYINPROGRESS = unchecked((int)0x8004D018);

        /// <summary>
        /// The transaction has already been aborted.
        /// </summary>
        public const int XACT_E_ABORTED = unchecked((int)0x8004D019);

        /// <summary>
        /// The Transaction Manager returned a log full error.
        /// </summary>
        public const int XACT_E_LOGFULL = unchecked((int)0x8004D01A);

        /// <summary>
        /// The Transaction Manager is not available.
        /// </summary>
        public const int XACT_E_TMNOTAVAILABLE = unchecked((int)0x8004D01B);

        /// <summary>
        /// A connection with the transaction manager was lost.
        /// </summary>
        public const int XACT_E_CONNECTION_DOWN = unchecked((int)0x8004D01C);

        /// <summary>
        /// A request to establish a connection with the transaction manager was denied.
        /// </summary>
        public const int XACT_E_CONNECTION_DENIED = unchecked((int)0x8004D01D);

        /// <summary>
        /// Resource manager reenlistment to determine transaction status timed out.
        /// </summary>
        public const int XACT_E_REENLISTTIMEOUT = unchecked((int)0x8004D01E);

        /// <summary>
        /// This transaction manager failed to establish a connection with another TIP transaction manager.
        /// </summary>
        public const int XACT_E_TIP_CONNECT_FAILED = unchecked((int)0x8004D01F);

        /// <summary>
        /// This transaction manager encountered a protocol error with another TIP transaction manager.
        /// </summary>
        public const int XACT_E_TIP_PROTOCOL_ERROR = unchecked((int)0x8004D020);

        /// <summary>
        /// This transaction manager could not propagate a transaction from another TIP transaction manager.
        /// </summary>
        public const int XACT_E_TIP_PULL_FAILED = unchecked((int)0x8004D021);

        /// <summary>
        /// The Transaction Manager on the destination machine is not available.
        /// </summary>
        public const int XACT_E_DEST_TMNOTAVAILABLE = unchecked((int)0x8004D022);

        /// <summary>
        /// The Transaction Manager has disabled its support for TIP.
        /// </summary>
        public const int XACT_E_TIP_DISABLED = unchecked((int)0x8004D023);

        /// <summary>
        /// The transaction manager has disabled its support for remote/network transactions.
        /// </summary>
        public const int XACT_E_NETWORK_TX_DISABLED = unchecked((int)0x8004D024);

        /// <summary>
        /// The partner transaction manager has disabled its support for remote/network transactions.
        /// </summary>
        public const int XACT_E_PARTNER_NETWORK_TX_DISABLED = unchecked((int)0x8004D025);

        /// <summary>
        /// The transaction manager has disabled its support for XA transactions.
        /// </summary>
        public const int XACT_E_XA_TX_DISABLED = unchecked((int)0x8004D026);

        /// <summary>
        /// MSDTC was unable to read its configuration information.
        /// </summary>
        public const int XACT_E_UNABLE_TO_READ_DTC_CONFIG = unchecked((int)0x8004D027);

        /// <summary>
        /// MSDTC was unable to load the dtc proxy dll.
        /// </summary>
        public const int XACT_E_UNABLE_TO_LOAD_DTC_PROXY = unchecked((int)0x8004D028);

        /// <summary>
        /// The local transaction has aborted.
        /// </summary>
        public const int XACT_E_ABORTING = unchecked((int)0x8004D029);

        /// <summary>
        /// The MSDTC transaction manager was unable to push the transaction to the destination transaction manager due to communication problems. Possible causes are: a firewall is present and it doesn't have an exception for the MSDTC process, the two machines cannot find each other by their NetBIOS names, or the support for network transactions is not enabled for one of the two transaction managers.
        /// </summary>
        public const int XACT_E_PUSH_COMM_FAILURE = unchecked((int)0x8004D02A);

        /// <summary>
        /// The MSDTC transaction manager was unable to pull the transaction from the source transaction manager due to communication problems. Possible causes are: a firewall is present and it doesn't have an exception for the MSDTC process, the two machines cannot find each other by their NetBIOS names, or the support for network transactions is not enabled for one of the two transaction managers.
        /// </summary>
        public const int XACT_E_PULL_COMM_FAILURE = unchecked((int)0x8004D02B);

        /// <summary>
        /// The MSDTC transaction manager has disabled its support for SNA LU 6.2 transactions.
        /// </summary>
        public const int XACT_E_LU_TX_DISABLED = unchecked((int)0x8004D02C);

        //
        // TXF & CRM errors start 4d080.
        /// <summary>
        /// XACT_E_CLERKNOTFOUND
        /// </summary>
        public const int XACT_E_CLERKNOTFOUND = unchecked((int)0x8004D080);

        /// <summary>
        /// XACT_E_CLERKEXISTS
        /// </summary>
        public const int XACT_E_CLERKEXISTS = unchecked((int)0x8004D081);

        /// <summary>
        /// XACT_E_RECOVERYINPROGRESS
        /// </summary>
        public const int XACT_E_RECOVERYINPROGRESS = unchecked((int)0x8004D082);

        /// <summary>
        /// XACT_E_TRANSACTIONCLOSED
        /// </summary>
        public const int XACT_E_TRANSACTIONCLOSED = unchecked((int)0x8004D083);

        /// <summary>
        /// XACT_E_INVALIDLSN
        /// </summary>
        public const int XACT_E_INVALIDLSN = unchecked((int)0x8004D084);

        /// <summary>
        /// XACT_E_REPLAYREQUEST
        /// </summary>
        public const int XACT_E_REPLAYREQUEST = unchecked((int)0x8004D085);

        // Begin XACT_DTC_CONSTANTS enumerated values defined in txdtc.h

        // SymbolicName=XACT_E_CONNECTION_REQUEST_DENIED
        //
        // MessageId: 0x8004D100L (No symbolic name defined)
        //
        // MessageText:
        //
        // The request to connect to the specified transaction coordinator was denied.
        //


        // SymbolicName=XACT_E_TOOMANY_ENLISTMENTS
        //
        // MessageId: 0x8004D101L (No symbolic name defined)
        //
        // MessageText:
        //
        // The maximum number of enlistments for the specified transaction has been reached.
        //


        // SymbolicName=XACT_E_DUPLICATE_GUID
        //
        // MessageId: 0x8004D102L (No symbolic name defined)
        //
        // MessageText:
        //
        // A resource manager with the same identifier is already registered with the specified transaction coordinator.
        //


        // SymbolicName=XACT_E_NOTSINGLEPHASE
        //
        // MessageId: 0x8004D103L (No symbolic name defined)
        //
        // MessageText:
        //
        // The prepare request given was not eligible for single phase optimizations.
        //


        // SymbolicName=XACT_E_RECOVERYALREADYDONE
        //
        // MessageId: 0x8004D104L (No symbolic name defined)
        //
        // MessageText:
        //
        // RecoveryComplete has already been called for the given resource manager.
        //


        // SymbolicName=XACT_E_PROTOCOL
        //
        // MessageId: 0x8004D105L (No symbolic name defined)
        //
        // MessageText:
        //
        // The interface call made was incorrect for the current state of the protocol.
        //


        // SymbolicName=XACT_E_RM_FAILURE
        //
        // MessageId: 0x8004D106L (No symbolic name defined)
        //
        // MessageText:
        //
        // xa_open call failed for the XA resource.
        //


        // SymbolicName=XACT_E_RECOVERY_FAILED
        //
        // MessageId: 0x8004D107L (No symbolic name defined)
        //
        // MessageText:
        //
        // xa_recover call failed for the XA resource.
        //


        // SymbolicName=XACT_E_LU_NOT_FOUND
        //
        // MessageId: 0x8004D108L (No symbolic name defined)
        //
        // MessageText:
        //
        // The Logical Unit of Work specified cannot be found.
        //


        // SymbolicName=XACT_E_DUPLICATE_LU
        //
        // MessageId: 0x8004D109L (No symbolic name defined)
        //
        // MessageText:
        //
        // The specified Logical Unit of Work already exists.
        //


        // SymbolicName=XACT_E_LU_NOT_CONNECTED
        //
        // MessageId: 0x8004D10AL (No symbolic name defined)
        //
        // MessageText:
        //
        // Subordinate creation failed. The specified Logical Unit of Work was not connected.
        //


        // SymbolicName=XACT_E_DUPLICATE_TRANSID
        //
        // MessageId: 0x8004D10BL (No symbolic name defined)
        //
        // MessageText:
        //
        // A transaction with the given identifier already exists.
        //


        // SymbolicName=XACT_E_LU_BUSY
        //
        // MessageId: 0x8004D10CL (No symbolic name defined)
        //
        // MessageText:
        //
        // The resource is in use.
        //


        // SymbolicName=XACT_E_LU_NO_RECOVERY_PROCESS
        //
        // MessageId: 0x8004D10DL (No symbolic name defined)
        //
        // MessageText:
        //
        // The LU Recovery process is down.
        //


        // SymbolicName=XACT_E_LU_DOWN
        //
        // MessageId: 0x8004D10EL (No symbolic name defined)
        //
        // MessageText:
        //
        // The remote session was lost.
        //


        // SymbolicName=XACT_E_LU_RECOVERING
        //
        // MessageId: 0x8004D10FL (No symbolic name defined)
        //
        // MessageText:
        //
        // The resource is currently recovering.
        //


        // SymbolicName=XACT_E_LU_RECOVERY_MISMATCH
        //
        // MessageId: 0x8004D110L (No symbolic name defined)
        //
        // MessageText:
        //
        // There was a mismatch in driving recovery.
        //


        // SymbolicName=XACT_E_RM_UNAVAILABLE
        //
        // MessageId: 0x8004D111L (No symbolic name defined)
        //
        // MessageText:
        //
        // An error occurred with the XA resource.
        //


        // End XACT_DTC_CONSTANTS enumerated values defined in txdtc.h

        //
        // OleTx Success codes.
        //
        /// <summary>
        /// An asynchronous operation was specified. The operation has begun, but its outcome is not known yet.
        /// </summary>
        public const int XACT_S_ASYNC = 0x0004D000;

        /// <summary>
        /// XACT_S_DEFECT
        /// </summary>
        public const int XACT_S_DEFECT = 0x0004D001;

        /// <summary>
        /// The method call succeeded because the transaction was read-only.
        /// </summary>
        public const int XACT_S_READONLY = 0x0004D002;

        /// <summary>
        /// The transaction was successfully aborted. However, this is a coordinated transaction, and some number of enlisted resources were aborted outright because they could not support abort-retaining semantics
        /// </summary>
        public const int XACT_S_SOMENORETAIN = 0x0004D003;

        /// <summary>
        /// No changes were made during this call, but the sink wants another chance to look if any other sinks make further changes.
        /// </summary>
        public const int XACT_S_OKINFORM = 0x0004D004;

        /// <summary>
        /// The sink is content and wishes the transaction to proceed. Changes were made to one or more resources during this call.
        /// </summary>
        public const int XACT_S_MADECHANGESCONTENT = 0x0004D005;

        /// <summary>
        /// The sink is for the moment and wishes the transaction to proceed, but if other changes are made following this return by other event sinks then this sink wants another chance to look
        /// </summary>
        public const int XACT_S_MADECHANGESINFORM = 0x0004D006;

        /// <summary>
        /// The transaction was successfully aborted. However, the abort was non-retaining.
        /// </summary>
        public const int XACT_S_ALLNORETAIN = 0x0004D007;

        /// <summary>
        /// An abort operation was already in progress.
        /// </summary>
        public const int XACT_S_ABORTING = 0x0004D008;

        /// <summary>
        /// The resource manager has performed a single-phase commit of the transaction.
        /// </summary>
        public const int XACT_S_SINGLEPHASE = 0x0004D009;

        /// <summary>
        /// The local transaction has not aborted.
        /// </summary>
        public const int XACT_S_LOCALLY_OK = 0x0004D00A;

        /// <summary>
        /// The resource manager has requested to be the coordinator (last resource manager) for the transaction.
        /// </summary>
        public const int XACT_S_LASTRESOURCEMANAGER = 0x0004D010;

        public const int CONTEXT_E_FIRST = unchecked((int)0x8004E000);
        public const int CONTEXT_E_LAST = unchecked((int)0x8004E02F);
        public const int CONTEXT_S_FIRST = 0x0004E000;
        public const int CONTEXT_S_LAST = 0x0004E02F;
        /// <summary>
        /// The root transaction wanted to commit, but transaction aborted
        /// </summary>
        public const int CONTEXT_E_ABORTED = unchecked((int)0x8004E002);

        /// <summary>
        /// You made a method call on a COM+ component that has a transaction that has already aborted or in the process of aborting.
        /// </summary>
        public const int CONTEXT_E_ABORTING = unchecked((int)0x8004E003);

        /// <summary>
        /// There is no MTS object context
        /// </summary>
        public const int CONTEXT_E_NOCONTEXT = unchecked((int)0x8004E004);

        /// <summary>
        /// The component is configured to use synchronization and this method call would cause a deadlock to occur.
        /// </summary>
        public const int CONTEXT_E_WOULD_DEADLOCK = unchecked((int)0x8004E005);

        /// <summary>
        /// The component is configured to use synchronization and a thread has timed out waiting to enter the context.
        /// </summary>
        public const int CONTEXT_E_SYNCH_TIMEOUT = unchecked((int)0x8004E006);

        /// <summary>
        /// You made a method call on a COM+ component that has a transaction that has already committed or aborted.
        /// </summary>
        public const int CONTEXT_E_OLDREF = unchecked((int)0x8004E007);

        /// <summary>
        /// The specified role was not configured for the application
        /// </summary>
        public const int CONTEXT_E_ROLENOTFOUND = unchecked((int)0x8004E00C);

        /// <summary>
        /// COM+ was unable to talk to the Microsoft Distributed Transaction Coordinator
        /// </summary>
        public const int CONTEXT_E_TMNOTAVAILABLE = unchecked((int)0x8004E00F);

        /// <summary>
        /// An unexpected error occurred during COM+ Activation.
        /// </summary>
        public const int CO_E_ACTIVATIONFAILED = unchecked((int)0x8004E021);

        /// <summary>
        /// COM+ Activation failed. Check the event log for more information
        /// </summary>
        public const int CO_E_ACTIVATIONFAILED_EVENTLOGGED = unchecked((int)0x8004E022);

        /// <summary>
        /// COM+ Activation failed due to a catalog or configuration error.
        /// </summary>
        public const int CO_E_ACTIVATIONFAILED_CATALOGERROR = unchecked((int)0x8004E023);

        /// <summary>
        /// COM+ activation failed because the activation could not be completed in the specified amount of time.
        /// </summary>
        public const int CO_E_ACTIVATIONFAILED_TIMEOUT = unchecked((int)0x8004E024);

        /// <summary>
        /// COM+ Activation failed because an initialization function failed. Check the event log for more information.
        /// </summary>
        public const int CO_E_INITIALIZATIONFAILED = unchecked((int)0x8004E025);

        /// <summary>
        /// The requested operation requires that JIT be in the current context and it is not
        /// </summary>
        public const int CONTEXT_E_NOJIT = unchecked((int)0x8004E026);

        /// <summary>
        /// The requested operation requires that the current context have a Transaction, and it does not
        /// </summary>
        public const int CONTEXT_E_NOTRANSACTION = unchecked((int)0x8004E027);

        /// <summary>
        /// The components threading model has changed after install into a COM+ Application. Please re-install component.
        /// </summary>
        public const int CO_E_THREADINGMODEL_CHANGED = unchecked((int)0x8004E028);

        /// <summary>
        /// IIS intrinsics not available. Start your work with IIS.
        /// </summary>
        public const int CO_E_NOIISINTRINSICS = unchecked((int)0x8004E029);

        /// <summary>
        /// An attempt to write a cookie failed.
        /// </summary>
        public const int CO_E_NOCOOKIES = unchecked((int)0x8004E02A);

        /// <summary>
        /// An attempt to use a database generated a database specific error.
        /// </summary>
        public const int CO_E_DBERROR = unchecked((int)0x8004E02B);

        /// <summary>
        /// The COM+ component you created must use object pooling to work.
        /// </summary>
        public const int CO_E_NOTPOOLED = unchecked((int)0x8004E02C);

        /// <summary>
        /// The COM+ component you created must use object construction to work correctly.
        /// </summary>
        public const int CO_E_NOTCONSTRUCTED = unchecked((int)0x8004E02D);

        /// <summary>
        /// The COM+ component requires synchronization, and it is not configured for it.
        /// </summary>
        public const int CO_E_NOSYNCHRONIZATION = unchecked((int)0x8004E02E);

        /// <summary>
        /// The TxIsolation Level property for the COM+ component being created is stronger than the TxIsolationLevel for the "root" component for the transaction. The creation failed.
        /// </summary>
        public const int CO_E_ISOLEVELMISMATCH = unchecked((int)0x8004E02F);

        /// <summary>
        /// The component attempted to make a cross-context call between invocations of EnterTransactionScopeand ExitTransactionScope. This is not allowed. Cross-context calls cannot be made while inside of a transaction scope.
        /// </summary>
        public const int CO_E_CALL_OUT_OF_TX_SCOPE_NOT_ALLOWED = unchecked((int)0x8004E030);

        /// <summary>
        /// The component made a call to EnterTransactionScope, but did not make a corresponding call to ExitTransactionScope before returning.
        /// </summary>
        public const int CO_E_EXIT_TRANSACTION_SCOPE_NOT_CALLED = unchecked((int)0x8004E031);

        //
        // Old OLE Success Codes
        //
        /// <summary>
        /// Use the registry database to provide the requested information
        /// </summary>
        public const int OLE_S_USEREG = 0x00040000;

        /// <summary>
        /// Success, but static
        /// </summary>
        public const int OLE_S_STATIC = 0x00040001;

        /// <summary>
        /// Macintosh clipboard format
        /// </summary>
        public const int OLE_S_MAC_CLIPFORMAT = 0x00040002;

        /// <summary>
        /// Successful drop took place
        /// </summary>
        public const int DRAGDROP_S_DROP = 0x00040100;

        /// <summary>
        /// Drag-drop operation canceled
        /// </summary>
        public const int DRAGDROP_S_CANCEL = 0x00040101;

        /// <summary>
        /// Use the default cursor
        /// </summary>
        public const int DRAGDROP_S_USEDEFAULTCURSORS = 0x00040102;

        /// <summary>
        /// Data has same FORMATETC
        /// </summary>
        public const int DATA_S_SAMEFORMATETC = 0x00040130;

        /// <summary>
        /// View is already frozen
        /// </summary>
        public const int VIEW_S_ALREADY_FROZEN = 0x00040140;

        /// <summary>
        /// FORMATETC not supported
        /// </summary>
        public const int CACHE_S_FORMATETC_NOTSUPPORTED = 0x00040170;

        /// <summary>
        /// Same cache
        /// </summary>
        public const int CACHE_S_SAMECACHE = 0x00040171;

        /// <summary>
        /// Some cache(s) not updated
        /// </summary>
        public const int CACHE_S_SOMECACHES_NOTUPDATED = 0x00040172;

        /// <summary>
        /// Invalid verb for OLE object
        /// </summary>
        public const int OLEOBJ_S_INVALIDVERB = 0x00040180;

        /// <summary>
        /// Verb number is valid but verb cannot be done now
        /// </summary>
        public const int OLEOBJ_S_CANNOT_DOVERB_NOW = 0x00040181;

        /// <summary>
        /// Invalid window handle passed
        /// </summary>
        public const int OLEOBJ_S_INVALIDHWND = 0x00040182;

        /// <summary>
        /// Message is too long; some of it had to be truncated before displaying
        /// </summary>
        public const int INPLACE_S_TRUNCATED = 0x000401A0;

        /// <summary>
        /// Unable to convert OLESTREAM to IStorage
        /// </summary>
        public const int CONVERT10_S_NO_PRESENTATION = 0x000401C0;

        /// <summary>
        /// Moniker reduced to itself
        /// </summary>
        public const int MK_S_REDUCED_TO_SELF = 0x000401E2;

        /// <summary>
        /// Common prefix is this moniker
        /// </summary>
        public const int MK_S_ME = 0x000401E4;

        /// <summary>
        /// Common prefix is input moniker
        /// </summary>
        public const int MK_S_HIM = 0x000401E5;

        /// <summary>
        /// Common prefix is both monikers
        /// </summary>
        public const int MK_S_US = 0x000401E6;

        /// <summary>
        /// Moniker is already registered in running object table
        /// </summary>
        public const int MK_S_MONIKERALREADYREGISTERED = 0x000401E7;

        //
        // Task Scheduler errors
        //
        /// <summary>
        /// The task is ready to run at its next scheduled time.
        /// </summary>
        public const int SCHED_S_TASK_READY = 0x00041300;

        /// <summary>
        /// The task is currently running.
        /// </summary>
        public const int SCHED_S_TASK_RUNNING = 0x00041301;

        /// <summary>
        /// The task will not run at the scheduled times because it has been disabled.
        /// </summary>
        public const int SCHED_S_TASK_DISABLED = 0x00041302;

        /// <summary>
        /// The task has not yet run.
        /// </summary>
        public const int SCHED_S_TASK_HAS_NOT_RUN = 0x00041303;

        /// <summary>
        /// There are no more runs scheduled for this task.
        /// </summary>
        public const int SCHED_S_TASK_NO_MORE_RUNS = 0x00041304;

        /// <summary>
        /// One or more of the properties that are needed to run this task on a schedule have not been set.
        /// </summary>
        public const int SCHED_S_TASK_NOT_SCHEDULED = 0x00041305;

        /// <summary>
        /// The last run of the task was terminated by the user.
        /// </summary>
        public const int SCHED_S_TASK_TERMINATED = 0x00041306;

        /// <summary>
        /// Either the task has no triggers or the existing triggers are disabled or not set.
        /// </summary>
        public const int SCHED_S_TASK_NO_VALID_TRIGGERS = 0x00041307;

        /// <summary>
        /// Event triggers don't have set run times.
        /// </summary>
        public const int SCHED_S_EVENT_TRIGGER = 0x00041308;

        /// <summary>
        /// Trigger not found.
        /// </summary>
        public const int SCHED_E_TRIGGER_NOT_FOUND = unchecked((int)0x80041309);

        /// <summary>
        /// One or more of the properties that are needed to run this task have not been set.
        /// </summary>
        public const int SCHED_E_TASK_NOT_READY = unchecked((int)0x8004130A);

        /// <summary>
        /// There is no running instance of the task.
        /// </summary>
        public const int SCHED_E_TASK_NOT_RUNNING = unchecked((int)0x8004130B);

        /// <summary>
        /// The Task Scheduler Service is not installed on this computer.
        /// </summary>
        public const int SCHED_E_SERVICE_NOT_INSTALLED = unchecked((int)0x8004130C);

        /// <summary>
        /// The task object could not be opened.
        /// </summary>
        public const int SCHED_E_CANNOT_OPEN_TASK = unchecked((int)0x8004130D);

        /// <summary>
        /// The object is either an invalid task object or is not a task object.
        /// </summary>
        public const int SCHED_E_INVALID_TASK = unchecked((int)0x8004130E);

        /// <summary>
        /// No account information could be found in the Task Scheduler security database for the task indicated.
        /// </summary>
        public const int SCHED_E_ACCOUNT_INFORMATION_NOT_SET = unchecked((int)0x8004130F);

        /// <summary>
        /// Unable to establish existence of the account specified.
        /// </summary>
        public const int SCHED_E_ACCOUNT_NAME_NOT_FOUND = unchecked((int)0x80041310);

        /// <summary>
        /// Corruption was detected in the Task Scheduler security database; the database has been reset.
        /// </summary>
        public const int SCHED_E_ACCOUNT_DBASE_CORRUPT = unchecked((int)0x80041311);

        /// <summary>
        /// Task Scheduler security services are available only on Windows NT.
        /// </summary>
        public const int SCHED_E_NO_SECURITY_SERVICES = unchecked((int)0x80041312);

        /// <summary>
        /// The task object version is either unsupported or invalid.
        /// </summary>
        public const int SCHED_E_UNKNOWN_OBJECT_VERSION = unchecked((int)0x80041313);

        /// <summary>
        /// The task has been configured with an unsupported combination of account settings and run time options.
        /// </summary>
        public const int SCHED_E_UNSUPPORTED_ACCOUNT_OPTION = unchecked((int)0x80041314);

        /// <summary>
        /// The Task Scheduler Service is not running.
        /// </summary>
        public const int SCHED_E_SERVICE_NOT_RUNNING = unchecked((int)0x80041315);

        /// <summary>
        /// The task XML contains an unexpected node.
        /// </summary>
        public const int SCHED_E_UNEXPECTEDNODE = unchecked((int)0x80041316);

        /// <summary>
        /// The task XML contains an element or attribute from an unexpected namespace.
        /// </summary>
        public const int SCHED_E_NAMESPACE = unchecked((int)0x80041317);

        /// <summary>
        /// The task XML contains a value which is incorrectly formatted or out of range.
        /// </summary>
        public const int SCHED_E_INVALIDVALUE = unchecked((int)0x80041318);

        /// <summary>
        /// The task XML is missing a required element or attribute.
        /// </summary>
        public const int SCHED_E_MISSINGNODE = unchecked((int)0x80041319);

        /// <summary>
        /// The task XML is malformed.
        /// </summary>
        public const int SCHED_E_MALFORMEDXML = unchecked((int)0x8004131A);

        /// <summary>
        /// The task is registered, but not all specified triggers will start the task, check task scheduler event log for detailed information.
        /// </summary>
        public const int SCHED_S_SOME_TRIGGERS_FAILED = 0x0004131B;

        /// <summary>
        /// The task is registered, but may fail to start. Batch logon privilege needs to be enabled for the task principal.
        /// </summary>
        public const int SCHED_S_BATCH_LOGON_PROBLEM = 0x0004131C;

        /// <summary>
        /// The task XML contains too many nodes of the same type.
        /// </summary>
        public const int SCHED_E_TOO_MANY_NODES = unchecked((int)0x8004131D);

        /// <summary>
        /// The task cannot be started after the trigger's end boundary.
        /// </summary>
        public const int SCHED_E_PAST_END_BOUNDARY = unchecked((int)0x8004131E);

        /// <summary>
        /// An instance of this task is already running.
        /// </summary>
        public const int SCHED_E_ALREADY_RUNNING = unchecked((int)0x8004131F);

        /// <summary>
        /// The task will not run because the user is not logged on.
        /// </summary>
        public const int SCHED_E_USER_NOT_LOGGED_ON = unchecked((int)0x80041320);

        /// <summary>
        /// The task image is corrupt or has been tampered with.
        /// </summary>
        public const int SCHED_E_INVALID_TASK_HASH = unchecked((int)0x80041321);

        /// <summary>
        /// The Task Scheduler service is not available.
        /// </summary>
        public const int SCHED_E_SERVICE_NOT_AVAILABLE = unchecked((int)0x80041322);

        /// <summary>
        /// The Task Scheduler service is too busy to handle your request. Please try again later.
        /// </summary>
        public const int SCHED_E_SERVICE_TOO_BUSY = unchecked((int)0x80041323);

        /// <summary>
        /// The Task Scheduler service attempted to run the task, but the task did not run due to one of the constraints in the task definition.
        /// </summary>
        public const int SCHED_E_TASK_ATTEMPTED = unchecked((int)0x80041324);

        /// <summary>
        /// The Task Scheduler service has asked the task to run.
        /// </summary>
        public const int SCHED_S_TASK_QUEUED = 0x00041325;

        /// <summary>
        /// The task is disabled.
        /// </summary>
        public const int SCHED_E_TASK_DISABLED = unchecked((int)0x80041326);

        /// <summary>
        /// The task has properties that are not compatible with previous versions of Windows.
        /// </summary>
        public const int SCHED_E_TASK_NOT_V1_COMPAT = unchecked((int)0x80041327);

        /// <summary>
        /// The task settings do not allow the task to start on demand.
        /// </summary>
        public const int SCHED_E_START_ON_DEMAND = unchecked((int)0x80041328);

        /// <summary>
        /// The combination of properties that task is using is not compatible with the scheduling engine.
        /// </summary>
        public const int SCHED_E_TASK_NOT_UBPM_COMPAT = unchecked((int)0x80041329);

        /// <summary>
        /// The task definition uses a deprecated feature.
        /// </summary>
        public const int SCHED_E_DEPRECATED_FEATURE_USED = unchecked((int)0x80041330);

        // ******************
        // FACILITY_WINDOWS
        // ******************
        //
        // Codes 0x0-0x01ff are reserved for the OLE group of
        // interfaces.
        //
        /// <summary>
        /// Attempt to create a class object failed
        /// </summary>
        public const int CO_E_CLASS_CREATE_FAILED = unchecked((int)0x80080001);

        /// <summary>
        /// OLE service could not bind object
        /// </summary>
        public const int CO_E_SCM_ERROR = unchecked((int)0x80080002);

        /// <summary>
        /// RPC communication failed with OLE service
        /// </summary>
        public const int CO_E_SCM_RPC_FAILURE = unchecked((int)0x80080003);

        /// <summary>
        /// Bad path to object
        /// </summary>
        public const int CO_E_BAD_PATH = unchecked((int)0x80080004);

        /// <summary>
        /// Server execution failed
        /// </summary>
        public const int CO_E_SERVER_EXEC_FAILURE = unchecked((int)0x80080005);

        /// <summary>
        /// OLE service could not communicate with the object server
        /// </summary>
        public const int CO_E_OBJSRV_RPC_FAILURE = unchecked((int)0x80080006);

        /// <summary>
        /// Moniker path could not be normalized
        /// </summary>
        public const int MK_E_NO_NORMALIZED = unchecked((int)0x80080007);

        /// <summary>
        /// Object server is stopping when OLE service contacts it
        /// </summary>
        public const int CO_E_SERVER_STOPPING = unchecked((int)0x80080008);

        /// <summary>
        /// An invalid root block pointer was specified
        /// </summary>
        public const int MEM_E_INVALID_ROOT = unchecked((int)0x80080009);

        /// <summary>
        /// An allocation chain contained an invalid link pointer
        /// </summary>
        public const int MEM_E_INVALID_LINK = unchecked((int)0x80080010);

        /// <summary>
        /// The requested allocation size was too large
        /// </summary>
        public const int MEM_E_INVALID_SIZE = unchecked((int)0x80080011);

        /// <summary>
        /// Not all the requested interfaces were available
        /// </summary>
        public const int CO_S_NOTALLINTERFACES = 0x00080012;

        /// <summary>
        /// The specified machine name was not found in the cache.
        /// </summary>
        public const int CO_S_MACHINENAMENOTFOUND = 0x00080013;

        /// <summary>
        /// The activation requires a display name to be present under the CLSID key.
        /// </summary>
        public const int CO_E_MISSING_DISPLAYNAME = unchecked((int)0x80080015);

        /// <summary>
        /// The activation requires that the RunAs value for the application is Activate As Activator.
        /// </summary>
        public const int CO_E_RUNAS_VALUE_MUST_BE_AAA = unchecked((int)0x80080016);

        /// <summary>
        /// The class is not configured to support Elevated activation.
        /// </summary>
        public const int CO_E_ELEVATION_DISABLED = unchecked((int)0x80080017);

        //
        // Codes 0x0200-0x02ff are reserved for the APPX errors
        //
        /// <summary>
        /// Appx packaging API has encountered an internal error.
        /// </summary>
        public const int APPX_E_PACKAGING_INTERNAL = unchecked((int)0x80080200);

        /// <summary>
        /// The file is not a valid Appx package because its contents are interleaved.
        /// </summary>
        public const int APPX_E_INTERLEAVING_NOT_ALLOWED = unchecked((int)0x80080201);

        /// <summary>
        /// The file is not a valid Appx package because it contains OPC relationships.
        /// </summary>
        public const int APPX_E_RELATIONSHIPS_NOT_ALLOWED = unchecked((int)0x80080202);

        /// <summary>
        /// The file is not a valid Appx package because it is missing a manifest or block map, or missing a signature file when the code integrity file is present.
        /// </summary>
        public const int APPX_E_MISSING_REQUIRED_FILE = unchecked((int)0x80080203);

        /// <summary>
        /// The Appx package's manifest is invalid.
        /// </summary>
        public const int APPX_E_INVALID_MANIFEST = unchecked((int)0x80080204);

        /// <summary>
        /// The Appx package's block map is invalid.
        /// </summary>
        public const int APPX_E_INVALID_BLOCKMAP = unchecked((int)0x80080205);

        /// <summary>
        /// The Appx package's content cannot be read because it is corrupt.
        /// </summary>
        public const int APPX_E_CORRUPT_CONTENT = unchecked((int)0x80080206);

        /// <summary>
        /// The computed hash value of the block does not match the one stored in the block map.
        /// </summary>
        public const int APPX_E_BLOCK_HASH_INVALID = unchecked((int)0x80080207);

        /// <summary>
        /// The requested byte range is over 4GB when translated to byte range of blocks.
        /// </summary>
        public const int APPX_E_REQUESTED_RANGE_TOO_LARGE = unchecked((int)0x80080208);

        /// <summary>
        /// The SIP_SUBJECTINFO structure used to sign the package didn't contain the required data.
        /// </summary>
        public const int APPX_E_INVALID_SIP_CLIENT_DATA = unchecked((int)0x80080209);

        /// <summary>
        /// The APPX_KEY_INFO structure used to encrypt or decrypt the package contains invalid data.
        /// </summary>
        public const int APPX_E_INVALID_KEY_INFO = unchecked((int)0x8008020A);

        /// <summary>
        /// The Appx package's content group map is invalid.
        /// </summary>
        public const int APPX_E_INVALID_CONTENTGROUPMAP = unchecked((int)0x8008020B);

        /// <summary>
        /// The .appinstaller file is invalid.
        /// </summary>
        public const int APPX_E_INVALID_APPINSTALLER = unchecked((int)0x8008020C);

        /// <summary>
        /// The baseline package version in delta package does not match the version in the baseline package to be updated.
        /// </summary>
        public const int APPX_E_DELTA_BASELINE_VERSION_MISMATCH = unchecked((int)0x8008020D);

        /// <summary>
        /// The delta package is missing a file from the updated package.
        /// </summary>
        public const int APPX_E_DELTA_PACKAGE_MISSING_FILE = unchecked((int)0x8008020E);

        /// <summary>
        /// The delta package is invalid.
        /// </summary>
        public const int APPX_E_INVALID_DELTA_PACKAGE = unchecked((int)0x8008020F);

        /// <summary>
        /// The delta appended package is not allowed for the current operation.
        /// </summary>
        public const int APPX_E_DELTA_APPENDED_PACKAGE_NOT_ALLOWED = unchecked((int)0x80080210);

        /// <summary>
        /// The packaging layout file is invalid.
        /// </summary>
        public const int APPX_E_INVALID_PACKAGING_LAYOUT = unchecked((int)0x80080211);

        /// <summary>
        /// The packageSignConfig file is invalid.
        /// </summary>
        public const int APPX_E_INVALID_PACKAGESIGNCONFIG = unchecked((int)0x80080212);

        /// <summary>
        /// The resources.pri file is not allowed when there are no resource elements in the package manifest.
        /// </summary>
        public const int APPX_E_RESOURCESPRI_NOT_ALLOWED = unchecked((int)0x80080213);

        /// <summary>
        /// The compression state of file in baseline and updated package does not match.
        /// </summary>
        public const int APPX_E_FILE_COMPRESSION_MISMATCH = unchecked((int)0x80080214);

        //
        // Codes 0x0300-0x030f are reserved for background task error codes.
        //
        /// <summary>
        /// The background task activation is spurious.
        /// </summary>
        public const int BT_E_SPURIOUS_ACTIVATION = unchecked((int)0x80080300);

        // ******************
        // FACILITY_DISPATCH
        // ******************
        /// <summary>
        /// Unknown interface.
        /// </summary>
        public const int DISP_E_UNKNOWNINTERFACE = unchecked((int)0x80020001);

        /// <summary>
        /// Member not found.
        /// </summary>
        public const int DISP_E_MEMBERNOTFOUND = unchecked((int)0x80020003);

        /// <summary>
        /// Parameter not found.
        /// </summary>
        public const int DISP_E_PARAMNOTFOUND = unchecked((int)0x80020004);

        /// <summary>
        /// Type mismatch.
        /// </summary>
        public const int DISP_E_TYPEMISMATCH = unchecked((int)0x80020005);

        /// <summary>
        /// Unknown name.
        /// </summary>
        public const int DISP_E_UNKNOWNNAME = unchecked((int)0x80020006);

        /// <summary>
        /// No named arguments.
        /// </summary>
        public const int DISP_E_NONAMEDARGS = unchecked((int)0x80020007);

        /// <summary>
        /// Bad variable type.
        /// </summary>
        public const int DISP_E_BADVARTYPE = unchecked((int)0x80020008);

        /// <summary>
        /// Exception occurred.
        /// </summary>
        public const int DISP_E_EXCEPTION = unchecked((int)0x80020009);

        /// <summary>
        /// Out of present range.
        /// </summary>
        public const int DISP_E_OVERFLOW = unchecked((int)0x8002000A);

        /// <summary>
        /// Invalid index.
        /// </summary>
        public const int DISP_E_BADINDEX = unchecked((int)0x8002000B);

        /// <summary>
        /// Unknown language.
        /// </summary>
        public const int DISP_E_UNKNOWNLCID = unchecked((int)0x8002000C);

        /// <summary>
        /// Memory is locked.
        /// </summary>
        public const int DISP_E_ARRAYISLOCKED = unchecked((int)0x8002000D);

        /// <summary>
        /// Invalid number of parameters.
        /// </summary>
        public const int DISP_E_BADPARAMCOUNT = unchecked((int)0x8002000E);

        /// <summary>
        /// Parameter not optional.
        /// </summary>
        public const int DISP_E_PARAMNOTOPTIONAL = unchecked((int)0x8002000F);

        /// <summary>
        /// Invalid callee.
        /// </summary>
        public const int DISP_E_BADCALLEE = unchecked((int)0x80020010);

        /// <summary>
        /// Does not support a collection.
        /// </summary>
        public const int DISP_E_NOTACOLLECTION = unchecked((int)0x80020011);

        /// <summary>
        /// Division by zero.
        /// </summary>
        public const int DISP_E_DIVBYZERO = unchecked((int)0x80020012);

        /// <summary>
        /// Buffer too small
        /// </summary>
        public const int DISP_E_BUFFERTOOSMALL = unchecked((int)0x80020013);

        /// <summary>
        /// Buffer too small.
        /// </summary>
        public const int TYPE_E_BUFFERTOOSMALL = unchecked((int)0x80028016);

        /// <summary>
        /// Field name not defined in the record.
        /// </summary>
        public const int TYPE_E_FIELDNOTFOUND = unchecked((int)0x80028017);

        /// <summary>
        /// Old format or invalid type library.
        /// </summary>
        public const int TYPE_E_INVDATAREAD = unchecked((int)0x80028018);

        /// <summary>
        /// Old format or invalid type library.
        /// </summary>
        public const int TYPE_E_UNSUPFORMAT = unchecked((int)0x80028019);

        /// <summary>
        /// Error accessing the OLE registry.
        /// </summary>
        public const int TYPE_E_REGISTRYACCESS = unchecked((int)0x8002801C);

        /// <summary>
        /// Library not registered.
        /// </summary>
        public const int TYPE_E_LIBNOTREGISTERED = unchecked((int)0x8002801D);

        /// <summary>
        /// Bound to unknown type.
        /// </summary>
        public const int TYPE_E_UNDEFINEDTYPE = unchecked((int)0x80028027);

        /// <summary>
        /// Qualified name disallowed.
        /// </summary>
        public const int TYPE_E_QUALIFIEDNAMEDISALLOWED = unchecked((int)0x80028028);

        /// <summary>
        /// Invalid forward reference, or reference to uncompiled type.
        /// </summary>
        public const int TYPE_E_INVALIDSTATE = unchecked((int)0x80028029);

        /// <summary>
        /// Type mismatch.
        /// </summary>
        public const int TYPE_E_WRONGTYPEKIND = unchecked((int)0x8002802A);

        /// <summary>
        /// Element not found.
        /// </summary>
        public const int TYPE_E_ELEMENTNOTFOUND = unchecked((int)0x8002802B);

        /// <summary>
        /// Ambiguous name.
        /// </summary>
        public const int TYPE_E_AMBIGUOUSNAME = unchecked((int)0x8002802C);

        /// <summary>
        /// Name already exists in the library.
        /// </summary>
        public const int TYPE_E_NAMECONFLICT = unchecked((int)0x8002802D);

        /// <summary>
        /// Unknown LCID.
        /// </summary>
        public const int TYPE_E_UNKNOWNLCID = unchecked((int)0x8002802E);

        /// <summary>
        /// Function not defined in specified DLL.
        /// </summary>
        public const int TYPE_E_DLLFUNCTIONNOTFOUND = unchecked((int)0x8002802F);

        /// <summary>
        /// Wrong module kind for the operation.
        /// </summary>
        public const int TYPE_E_BADMODULEKIND = unchecked((int)0x800288BD);

        /// <summary>
        /// Size may not exceed 64K.
        /// </summary>
        public const int TYPE_E_SIZETOOBIG = unchecked((int)0x800288C5);

        /// <summary>
        /// Duplicate ID in inheritance hierarchy.
        /// </summary>
        public const int TYPE_E_DUPLICATEID = unchecked((int)0x800288C6);

        /// <summary>
        /// Incorrect inheritance depth in standard OLE hmember.
        /// </summary>
        public const int TYPE_E_INVALIDID = unchecked((int)0x800288CF);

        /// <summary>
        /// Type mismatch.
        /// </summary>
        public const int TYPE_E_TYPEMISMATCH = unchecked((int)0x80028CA0);

        /// <summary>
        /// Invalid number of arguments.
        /// </summary>
        public const int TYPE_E_OUTOFBOUNDS = unchecked((int)0x80028CA1);

        /// <summary>
        /// I/O Error.
        /// </summary>
        public const int TYPE_E_IOERROR = unchecked((int)0x80028CA2);

        /// <summary>
        /// Error creating unique tmp file.
        /// </summary>
        public const int TYPE_E_CANTCREATETMPFILE = unchecked((int)0x80028CA3);

        /// <summary>
        /// Error loading type library/DLL.
        /// </summary>
        public const int TYPE_E_CANTLOADLIBRARY = unchecked((int)0x80029C4A);

        /// <summary>
        /// Inconsistent property functions.
        /// </summary>
        public const int TYPE_E_INCONSISTENTPROPFUNCS = unchecked((int)0x80029C83);

        /// <summary>
        /// Circular dependency between types/modules.
        /// </summary>
        public const int TYPE_E_CIRCULARTYPE = unchecked((int)0x80029C84);

        // ******************
        // FACILITY_STORAGE
        // ******************
        /// <summary>
        /// Unable to perform requested operation.
        /// </summary>
        public const int STG_E_INVALIDFUNCTION = unchecked((int)0x80030001);

        /// <summary>
        /// %1 could not be found.
        /// </summary>
        public const int STG_E_FILENOTFOUND = unchecked((int)0x80030002);

        /// <summary>
        /// The path %1 could not be found.
        /// </summary>
        public const int STG_E_PATHNOTFOUND = unchecked((int)0x80030003);

        /// <summary>
        /// There are insufficient resources to open another file.
        /// </summary>
        public const int STG_E_TOOMANYOPENFILES = unchecked((int)0x80030004);

        /// <summary>
        /// Access Denied.
        /// </summary>
        public const int STG_E_ACCESSDENIED = unchecked((int)0x80030005);

        /// <summary>
        /// Attempted an operation on an invalid object.
        /// </summary>
        public const int STG_E_INVALIDHANDLE = unchecked((int)0x80030006);

        /// <summary>
        /// There is insufficient memory available to complete operation.
        /// </summary>
        public const int STG_E_INSUFFICIENTMEMORY = unchecked((int)0x80030008);

        /// <summary>
        /// Invalid pointer error.
        /// </summary>
        public const int STG_E_INVALIDPOINTER = unchecked((int)0x80030009);

        /// <summary>
        /// There are no more entries to return.
        /// </summary>
        public const int STG_E_NOMOREFILES = unchecked((int)0x80030012);

        /// <summary>
        /// Disk is write-protected.
        /// </summary>
        public const int STG_E_DISKISWRITEPROTECTED = unchecked((int)0x80030013);

        /// <summary>
        /// An error occurred during a seek operation.
        /// </summary>
        public const int STG_E_SEEKERROR = unchecked((int)0x80030019);

        /// <summary>
        /// A disk error occurred during a write operation.
        /// </summary>
        public const int STG_E_WRITEFAULT = unchecked((int)0x8003001D);

        /// <summary>
        /// A disk error occurred during a read operation.
        /// </summary>
        public const int STG_E_READFAULT = unchecked((int)0x8003001E);

        /// <summary>
        /// A share violation has occurred.
        /// </summary>
        public const int STG_E_SHAREVIOLATION = unchecked((int)0x80030020);

        /// <summary>
        /// A lock violation has occurred.
        /// </summary>
        public const int STG_E_LOCKVIOLATION = unchecked((int)0x80030021);

        /// <summary>
        /// %1 already exists.
        /// </summary>
        public const int STG_E_FILEALREADYEXISTS = unchecked((int)0x80030050);

        /// <summary>
        /// Invalid parameter error.
        /// </summary>
        public const int STG_E_INVALIDPARAMETER = unchecked((int)0x80030057);

        /// <summary>
        /// There is insufficient disk space to complete operation.
        /// </summary>
        public const int STG_E_MEDIUMFULL = unchecked((int)0x80030070);

        /// <summary>
        /// Illegal write of non-simple property to simple property set.
        /// </summary>
        public const int STG_E_PROPSETMISMATCHED = unchecked((int)0x800300F0);

        /// <summary>
        /// An API call exited abnormally.
        /// </summary>
        public const int STG_E_ABNORMALAPIEXIT = unchecked((int)0x800300FA);

        /// <summary>
        /// The file %1 is not a valid compound file.
        /// </summary>
        public const int STG_E_INVALIDHEADER = unchecked((int)0x800300FB);

        /// <summary>
        /// The name %1 is not valid.
        /// </summary>
        public const int STG_E_INVALIDNAME = unchecked((int)0x800300FC);

        /// <summary>
        /// An unexpected error occurred.
        /// </summary>
        public const int STG_E_UNKNOWN = unchecked((int)0x800300FD);

        /// <summary>
        /// That function is not implemented.
        /// </summary>
        public const int STG_E_UNIMPLEMENTEDFUNCTION = unchecked((int)0x800300FE);

        /// <summary>
        /// Invalid flag error.
        /// </summary>
        public const int STG_E_INVALIDFLAG = unchecked((int)0x800300FF);

        /// <summary>
        /// Attempted to use an object that is busy.
        /// </summary>
        public const int STG_E_INUSE = unchecked((int)0x80030100);

        /// <summary>
        /// The storage has been changed since the last commit.
        /// </summary>
        public const int STG_E_NOTCURRENT = unchecked((int)0x80030101);

        /// <summary>
        /// Attempted to use an object that has ceased to exist.
        /// </summary>
        public const int STG_E_REVERTED = unchecked((int)0x80030102);

        /// <summary>
        /// Can't save.
        /// </summary>
        public const int STG_E_CANTSAVE = unchecked((int)0x80030103);

        /// <summary>
        /// The compound file %1 was produced with an incompatible version of storage.
        /// </summary>
        public const int STG_E_OLDFORMAT = unchecked((int)0x80030104);

        /// <summary>
        /// The compound file %1 was produced with a newer version of storage.
        /// </summary>
        public const int STG_E_OLDDLL = unchecked((int)0x80030105);

        /// <summary>
        /// Share.exe or equivalent is required for operation.
        /// </summary>
        public const int STG_E_SHAREREQUIRED = unchecked((int)0x80030106);

        /// <summary>
        /// Illegal operation called on non-file based storage.
        /// </summary>
        public const int STG_E_NOTFILEBASEDSTORAGE = unchecked((int)0x80030107);

        /// <summary>
        /// Illegal operation called on object with extant marshallings.
        /// </summary>
        public const int STG_E_EXTANTMARSHALLINGS = unchecked((int)0x80030108);

        /// <summary>
        /// The docfile has been corrupted.
        /// </summary>
        public const int STG_E_DOCFILECORRUPT = unchecked((int)0x80030109);

        /// <summary>
        /// OLE32.DLL has been loaded at the wrong address.
        /// </summary>
        public const int STG_E_BADBASEADDRESS = unchecked((int)0x80030110);

        /// <summary>
        /// The compound file is too large for the current implementation
        /// </summary>
        public const int STG_E_DOCFILETOOLARGE = unchecked((int)0x80030111);

        /// <summary>
        /// The compound file was not created with the STGM_SIMPLE flag
        /// </summary>
        public const int STG_E_NOTSIMPLEFORMAT = unchecked((int)0x80030112);

        /// <summary>
        /// The file download was aborted abnormally. The file is incomplete.
        /// </summary>
        public const int STG_E_INCOMPLETE = unchecked((int)0x80030201);

        /// <summary>
        /// The file download has been terminated.
        /// </summary>
        public const int STG_E_TERMINATED = unchecked((int)0x80030202);

        /// <summary>
        /// The underlying file was converted to compound file format.
        /// </summary>
        public const int STG_S_CONVERTED = 0x00030200;

        /// <summary>
        /// The storage operation should block until more data is available.
        /// </summary>
        public const int STG_S_BLOCK = 0x00030201;

        /// <summary>
        /// The storage operation should retry immediately.
        /// </summary>
        public const int STG_S_RETRYNOW = 0x00030202;

        /// <summary>
        /// The notified event sink will not influence the storage operation.
        /// </summary>
        public const int STG_S_MONITORING = 0x00030203;

        /// <summary>
        /// Multiple opens prevent consolidated. (commit succeeded).
        /// </summary>
        public const int STG_S_MULTIPLEOPENS = 0x00030204;

        /// <summary>
        /// Consolidation of the storage file failed. (commit succeeded).
        /// </summary>
        public const int STG_S_CONSOLIDATIONFAILED = 0x00030205;

        /// <summary>
        /// Consolidation of the storage file is inappropriate. (commit succeeded).
        /// </summary>
        public const int STG_S_CANNOTCONSOLIDATE = 0x00030206;

        /// <summary>
        /// The device needs to be power cycled. (commit succeeded).
        /// </summary>
        public const int STG_S_POWER_CYCLE_REQUIRED = 0x00030207;

        /// <summary>
        /// The specified firmware slot is invalid.
        /// </summary>
        public const int STG_E_FIRMWARE_SLOT_INVALID = unchecked((int)0x80030208);

        /// <summary>
        /// The specified firmware image is invalid.
        /// </summary>
        public const int STG_E_FIRMWARE_IMAGE_INVALID = unchecked((int)0x80030209);

        /// <summary>
        /// The storage device is unresponsive.
        /// </summary>
        public const int STG_E_DEVICE_UNRESPONSIVE = unchecked((int)0x8003020A);

        /*++

         MessageId's 0x0305 - 0x031f (inclusive) are reserved for **STORAGE**
         copy protection errors.

        --*/
        /// <summary>
        /// Generic Copy Protection Error.
        /// </summary>
        public const int STG_E_STATUS_COPY_PROTECTION_FAILURE = unchecked((int)0x80030305);

        /// <summary>
        /// Copy Protection Error - DVD CSS Authentication failed.
        /// </summary>
        public const int STG_E_CSS_AUTHENTICATION_FAILURE = unchecked((int)0x80030306);

        /// <summary>
        /// Copy Protection Error - The given sector does not have a valid CSS key.
        /// </summary>
        public const int STG_E_CSS_KEY_NOT_PRESENT = unchecked((int)0x80030307);

        /// <summary>
        /// Copy Protection Error - DVD session key not established.
        /// </summary>
        public const int STG_E_CSS_KEY_NOT_ESTABLISHED = unchecked((int)0x80030308);

        /// <summary>
        /// Copy Protection Error - The read failed because the sector is encrypted.
        /// </summary>
        public const int STG_E_CSS_SCRAMBLED_SECTOR = unchecked((int)0x80030309);

        /// <summary>
        /// Copy Protection Error - The current DVD's region does not correspond to the region setting of the drive.
        /// </summary>
        public const int STG_E_CSS_REGION_MISMATCH = unchecked((int)0x8003030A);

        /// <summary>
        /// Copy Protection Error - The drive's region setting may be permanent or the number of user resets has been exhausted.
        /// </summary>
        public const int STG_E_RESETS_EXHAUSTED = unchecked((int)0x8003030B);

        /*++

         MessageId's 0x0305 - 0x031f (inclusive) are reserved for **STORAGE**
         copy protection errors.

        --*/
        // ******************
        // FACILITY_RPC
        // ******************
        //
        // Codes 0x0-0x11 are propagated from 16 bit OLE.
        //
        /// <summary>
        /// Call was rejected by callee.
        /// </summary>
        public const int RPC_E_CALL_REJECTED = unchecked((int)0x80010001);

        /// <summary>
        /// Call was canceled by the message filter.
        /// </summary>
        public const int RPC_E_CALL_CANCELED = unchecked((int)0x80010002);

        /// <summary>
        /// The caller is dispatching an intertask SendMessage call and cannot call out via PostMessage.
        /// </summary>
        public const int RPC_E_CANTPOST_INSENDCALL = unchecked((int)0x80010003);

        /// <summary>
        /// The caller is dispatching an asynchronous call and cannot make an outgoing call on behalf of this call.
        /// </summary>
        public const int RPC_E_CANTCALLOUT_INASYNCCALL = unchecked((int)0x80010004);

        /// <summary>
        /// It is illegal to call out while inside message filter.
        /// </summary>
        public const int RPC_E_CANTCALLOUT_INEXTERNALCALL = unchecked((int)0x80010005);

        /// <summary>
        /// The connection terminated or is in a bogus state and cannot be used any more. Other connections are still valid.
        /// </summary>
        public const int RPC_E_CONNECTION_TERMINATED = unchecked((int)0x80010006);

        /// <summary>
        /// The callee (server [not server application]) is not available and disappeared; all connections are invalid. The call may have executed.
        /// </summary>
        public const int RPC_E_SERVER_DIED = unchecked((int)0x80010007);

        /// <summary>
        /// The caller (client) disappeared while the callee (server) was processing a call.
        /// </summary>
        public const int RPC_E_CLIENT_DIED = unchecked((int)0x80010008);

        /// <summary>
        /// The data packet with the marshalled parameter data is incorrect.
        /// </summary>
        public const int RPC_E_INVALID_DATAPACKET = unchecked((int)0x80010009);

        /// <summary>
        /// The call was not transmitted properly; the message queue was full and was not emptied after yielding.
        /// </summary>
        public const int RPC_E_CANTTRANSMIT_CALL = unchecked((int)0x8001000A);

        /// <summary>
        /// The client (caller) cannot marshall the parameter data - low memory, etc.
        /// </summary>
        public const int RPC_E_CLIENT_CANTMARSHAL_DATA = unchecked((int)0x8001000B);

        /// <summary>
        /// The client (caller) cannot unmarshall the return data - low memory, etc.
        /// </summary>
        public const int RPC_E_CLIENT_CANTUNMARSHAL_DATA = unchecked((int)0x8001000C);

        /// <summary>
        /// The server (callee) cannot marshall the return data - low memory, etc.
        /// </summary>
        public const int RPC_E_SERVER_CANTMARSHAL_DATA = unchecked((int)0x8001000D);

        /// <summary>
        /// The server (callee) cannot unmarshall the parameter data - low memory, etc.
        /// </summary>
        public const int RPC_E_SERVER_CANTUNMARSHAL_DATA = unchecked((int)0x8001000E);

        /// <summary>
        /// Received data is invalid; could be server or client data.
        /// </summary>
        public const int RPC_E_INVALID_DATA = unchecked((int)0x8001000F);

        /// <summary>
        /// A particular parameter is invalid and cannot be (un)marshalled.
        /// </summary>
        public const int RPC_E_INVALID_PARAMETER = unchecked((int)0x80010010);

        /// <summary>
        /// There is no second outgoing call on same channel in DDE conversation.
        /// </summary>
        public const int RPC_E_CANTCALLOUT_AGAIN = unchecked((int)0x80010011);

        /// <summary>
        /// The callee (server [not server application]) is not available and disappeared; all connections are invalid. The call did not execute.
        /// </summary>
        public const int RPC_E_SERVER_DIED_DNE = unchecked((int)0x80010012);

        /// <summary>
        /// System call failed.
        /// </summary>
        public const int RPC_E_SYS_CALL_FAILED = unchecked((int)0x80010100);

        /// <summary>
        /// Could not allocate some required resource (memory, events, ...)
        /// </summary>
        public const int RPC_E_OUT_OF_RESOURCES = unchecked((int)0x80010101);

        /// <summary>
        /// Attempted to make calls on more than one thread in single threaded mode.
        /// </summary>
        public const int RPC_E_ATTEMPTED_MULTITHREAD = unchecked((int)0x80010102);

        /// <summary>
        /// The requested interface is not registered on the server object.
        /// </summary>
        public const int RPC_E_NOT_REGISTERED = unchecked((int)0x80010103);

        /// <summary>
        /// RPC could not call the server or could not return the results of calling the server.
        /// </summary>
        public const int RPC_E_FAULT = unchecked((int)0x80010104);

        /// <summary>
        /// The server threw an exception.
        /// </summary>
        public const int RPC_E_SERVERFAULT = unchecked((int)0x80010105);

        /// <summary>
        /// Cannot change thread mode after it is set.
        /// </summary>
        public const int RPC_E_CHANGED_MODE = unchecked((int)0x80010106);

        /// <summary>
        /// The method called does not exist on the server.
        /// </summary>
        public const int RPC_E_INVALIDMETHOD = unchecked((int)0x80010107);

        /// <summary>
        /// The object invoked has disconnected from its clients.
        /// </summary>
        public const int RPC_E_DISCONNECTED = unchecked((int)0x80010108);

        /// <summary>
        /// The object invoked chose not to process the call now. Try again later.
        /// </summary>
        public const int RPC_E_RETRY = unchecked((int)0x80010109);

        /// <summary>
        /// The message filter indicated that the application is busy.
        /// </summary>
        public const int RPC_E_SERVERCALL_RETRYLATER = unchecked((int)0x8001010A);

        /// <summary>
        /// The message filter rejected the call.
        /// </summary>
        public const int RPC_E_SERVERCALL_REJECTED = unchecked((int)0x8001010B);

        /// <summary>
        /// A call control interfaces was called with invalid data.
        /// </summary>
        public const int RPC_E_INVALID_CALLDATA = unchecked((int)0x8001010C);

        /// <summary>
        /// An outgoing call cannot be made since the application is dispatching an input-synchronous call.
        /// </summary>
        public const int RPC_E_CANTCALLOUT_ININPUTSYNCCALL = unchecked((int)0x8001010D);

        /// <summary>
        /// The application called an interface that was marshalled for a different thread.
        /// </summary>
        public const int RPC_E_WRONG_THREAD = unchecked((int)0x8001010E);

        /// <summary>
        /// CoInitialize has not been called on the current thread.
        /// </summary>
        public const int RPC_E_THREAD_NOT_INIT = unchecked((int)0x8001010F);

        /// <summary>
        /// The version of OLE on the client and server machines does not match.
        /// </summary>
        public const int RPC_E_VERSION_MISMATCH = unchecked((int)0x80010110);

        /// <summary>
        /// OLE received a packet with an invalid header.
        /// </summary>
        public const int RPC_E_INVALID_HEADER = unchecked((int)0x80010111);

        /// <summary>
        /// OLE received a packet with an invalid extension.
        /// </summary>
        public const int RPC_E_INVALID_EXTENSION = unchecked((int)0x80010112);

        /// <summary>
        /// The requested object or interface does not exist.
        /// </summary>
        public const int RPC_E_INVALID_IPID = unchecked((int)0x80010113);

        /// <summary>
        /// The requested object does not exist.
        /// </summary>
        public const int RPC_E_INVALID_OBJECT = unchecked((int)0x80010114);

        /// <summary>
        /// OLE has sent a request and is waiting for a reply.
        /// </summary>
        public const int RPC_S_CALLPENDING = unchecked((int)0x80010115);

        /// <summary>
        /// OLE is waiting before retrying a request.
        /// </summary>
        public const int RPC_S_WAITONTIMER = unchecked((int)0x80010116);

        /// <summary>
        /// Call context cannot be accessed after call completed.
        /// </summary>
        public const int RPC_E_CALL_COMPLETE = unchecked((int)0x80010117);

        /// <summary>
        /// Impersonate on unsecure calls is not supported.
        /// </summary>
        public const int RPC_E_UNSECURE_CALL = unchecked((int)0x80010118);

        /// <summary>
        /// Security must be initialized before any interfaces are marshalled or unmarshalled. It cannot be changed once initialized.
        /// </summary>
        public const int RPC_E_TOO_LATE = unchecked((int)0x80010119);

        /// <summary>
        /// No security packages are installed on this machine or the user is not logged on or there are no compatible security packages between the client and server.
        /// </summary>
        public const int RPC_E_NO_GOOD_SECURITY_PACKAGES = unchecked((int)0x8001011A);

        /// <summary>
        /// Access is denied.
        /// </summary>
        public const int RPC_E_ACCESS_DENIED = unchecked((int)0x8001011B);

        /// <summary>
        /// Remote calls are not allowed for this process.
        /// </summary>
        public const int RPC_E_REMOTE_DISABLED = unchecked((int)0x8001011C);

        /// <summary>
        /// The marshaled interface data packet (OBJREF) has an invalid or unknown format.
        /// </summary>
        public const int RPC_E_INVALID_OBJREF = unchecked((int)0x8001011D);

        /// <summary>
        /// No context is associated with this call. This happens for some custom marshalled calls and on the client side of the call.
        /// </summary>
        public const int RPC_E_NO_CONTEXT = unchecked((int)0x8001011E);

        /// <summary>
        /// This operation returned because the timeout period expired.
        /// </summary>
        public const int RPC_E_TIMEOUT = unchecked((int)0x8001011F);

        /// <summary>
        /// There are no synchronize objects to wait on.
        /// </summary>
        public const int RPC_E_NO_SYNC = unchecked((int)0x80010120);

        /// <summary>
        /// Full subject issuer chain SSL principal name expected from the server.
        /// </summary>
        public const int RPC_E_FULLSIC_REQUIRED = unchecked((int)0x80010121);

        /// <summary>
        /// Principal name is not a valid MSSTD name.
        /// </summary>
        public const int RPC_E_INVALID_STD_NAME = unchecked((int)0x80010122);

        /// <summary>
        /// Unable to impersonate DCOM client
        /// </summary>
        public const int CO_E_FAILEDTOIMPERSONATE = unchecked((int)0x80010123);

        /// <summary>
        /// Unable to obtain server's security context
        /// </summary>
        public const int CO_E_FAILEDTOGETSECCTX = unchecked((int)0x80010124);

        /// <summary>
        /// Unable to open the access token of the current thread
        /// </summary>
        public const int CO_E_FAILEDTOOPENTHREADTOKEN = unchecked((int)0x80010125);

        /// <summary>
        /// Unable to obtain user info from an access token
        /// </summary>
        public const int CO_E_FAILEDTOGETTOKENINFO = unchecked((int)0x80010126);

        /// <summary>
        /// The client who called IAccessControl::IsAccessPermitted was not the trustee provided to the method
        /// </summary>
        public const int CO_E_TRUSTEEDOESNTMATCHCLIENT = unchecked((int)0x80010127);

        /// <summary>
        /// Unable to obtain the client's security blanket
        /// </summary>
        public const int CO_E_FAILEDTOQUERYCLIENTBLANKET = unchecked((int)0x80010128);

        /// <summary>
        /// Unable to set a discretionary ACL into a security descriptor
        /// </summary>
        public const int CO_E_FAILEDTOSETDACL = unchecked((int)0x80010129);

        /// <summary>
        /// The system function, AccessCheck, returned false
        /// </summary>
        public const int CO_E_ACCESSCHECKFAILED = unchecked((int)0x8001012A);

        /// <summary>
        /// Either NetAccessDel or NetAccessAdd returned an error code.
        /// </summary>
        public const int CO_E_NETACCESSAPIFAILED = unchecked((int)0x8001012B);

        /// <summary>
        /// One of the trustee strings provided by the user did not conform to the &lt;Domain&gt;\&lt;Name&gt; syntax and it was not the "*" string
        /// </summary>
        public const int CO_E_WRONGTRUSTEENAMESYNTAX = unchecked((int)0x8001012C);

        /// <summary>
        /// One of the security identifiers provided by the user was invalid
        /// </summary>
        public const int CO_E_INVALIDSID = unchecked((int)0x8001012D);

        /// <summary>
        /// Unable to convert a wide character trustee string to a multibyte trustee string
        /// </summary>
        public const int CO_E_CONVERSIONFAILED = unchecked((int)0x8001012E);

        /// <summary>
        /// Unable to find a security identifier that corresponds to a trustee string provided by the user
        /// </summary>
        public const int CO_E_NOMATCHINGSIDFOUND = unchecked((int)0x8001012F);

        /// <summary>
        /// The system function, LookupAccountSID, failed
        /// </summary>
        public const int CO_E_LOOKUPACCSIDFAILED = unchecked((int)0x80010130);

        /// <summary>
        /// Unable to find a trustee name that corresponds to a security identifier provided by the user
        /// </summary>
        public const int CO_E_NOMATCHINGNAMEFOUND = unchecked((int)0x80010131);

        /// <summary>
        /// The system function, LookupAccountName, failed
        /// </summary>
        public const int CO_E_LOOKUPACCNAMEFAILED = unchecked((int)0x80010132);

        /// <summary>
        /// Unable to set or reset a serialization handle
        /// </summary>
        public const int CO_E_SETSERLHNDLFAILED = unchecked((int)0x80010133);

        /// <summary>
        /// Unable to obtain the Windows directory
        /// </summary>
        public const int CO_E_FAILEDTOGETWINDIR = unchecked((int)0x80010134);

        /// <summary>
        /// Path too long
        /// </summary>
        public const int CO_E_PATHTOOLONG = unchecked((int)0x80010135);

        /// <summary>
        /// Unable to generate a uuid.
        /// </summary>
        public const int CO_E_FAILEDTOGENUUID = unchecked((int)0x80010136);

        /// <summary>
        /// Unable to create file
        /// </summary>
        public const int CO_E_FAILEDTOCREATEFILE = unchecked((int)0x80010137);

        /// <summary>
        /// Unable to close a serialization handle or a file handle.
        /// </summary>
        public const int CO_E_FAILEDTOCLOSEHANDLE = unchecked((int)0x80010138);

        /// <summary>
        /// The number of ACEs in an ACL exceeds the system limit.
        /// </summary>
        public const int CO_E_EXCEEDSYSACLLIMIT = unchecked((int)0x80010139);

        /// <summary>
        /// Not all the DENY_ACCESS ACEs are arranged in front of the GRANT_ACCESS ACEs in the stream.
        /// </summary>
        public const int CO_E_ACESINWRONGORDER = unchecked((int)0x8001013A);

        /// <summary>
        /// The version of ACL format in the stream is not supported by this implementation of IAccessControl
        /// </summary>
        public const int CO_E_INCOMPATIBLESTREAMVERSION = unchecked((int)0x8001013B);

        /// <summary>
        /// Unable to open the access token of the server process
        /// </summary>
        public const int CO_E_FAILEDTOOPENPROCESSTOKEN = unchecked((int)0x8001013C);

        /// <summary>
        /// Unable to decode the ACL in the stream provided by the user
        /// </summary>
        public const int CO_E_DECODEFAILED = unchecked((int)0x8001013D);

        /// <summary>
        /// The COM IAccessControl object is not initialized
        /// </summary>
        public const int CO_E_ACNOTINITIALIZED = unchecked((int)0x8001013F);

        /// <summary>
        /// Call Cancellation is disabled
        /// </summary>
        public const int CO_E_CANCEL_DISABLED = unchecked((int)0x80010140);

        /// <summary>
        /// An internal error occurred.
        /// </summary>
        public const int RPC_E_UNEXPECTED = unchecked((int)0x8001FFFF);



        //////////////////////////////////////
        //                                  //
        // Additional Security Status Codes //
        //                                  //
        // Facility=Security                //
        //                                  //
        //////////////////////////////////////


        /// <summary>
        /// The specified event is currently not being audited.
        /// </summary>
        public const int ERROR_AUDITING_DISABLED = unchecked((int)0xC0090001);

        /// <summary>
        /// The SID filtering operation removed all SIDs.
        /// </summary>
        public const int ERROR_ALL_SIDS_FILTERED = unchecked((int)0xC0090002);

        /// <summary>
        /// Business rule scripts are disabled for the calling application.
        /// </summary>
        public const int ERROR_BIZRULES_NOT_ENABLED = unchecked((int)0xC0090003);



        /////////////////////////////////////////////
        //                                         //
        // end of Additional Security Status Codes //
        //                                         //
        /////////////////////////////////////////////



        /////////////////
        //
        //  FACILITY_SSPI
        //
        /////////////////

        /// <summary>
        /// Bad UID.
        /// </summary>
        public const int NTE_BAD_UID = unchecked((int)0x80090001);

        /// <summary>
        /// Bad Hash.
        /// </summary>
        public const int NTE_BAD_HASH = unchecked((int)0x80090002);

        /// <summary>
        /// Bad Key.
        /// </summary>
        public const int NTE_BAD_KEY = unchecked((int)0x80090003);

        /// <summary>
        /// Bad Length.
        /// </summary>
        public const int NTE_BAD_LEN = unchecked((int)0x80090004);

        /// <summary>
        /// Bad Data.
        /// </summary>
        public const int NTE_BAD_DATA = unchecked((int)0x80090005);

        /// <summary>
        /// Invalid Signature.
        /// </summary>
        public const int NTE_BAD_SIGNATURE = unchecked((int)0x80090006);

        /// <summary>
        /// Bad Version of provider.
        /// </summary>
        public const int NTE_BAD_VER = unchecked((int)0x80090007);

        /// <summary>
        /// Invalid algorithm specified.
        /// </summary>
        public const int NTE_BAD_ALGID = unchecked((int)0x80090008);

        /// <summary>
        /// Invalid flags specified.
        /// </summary>
        public const int NTE_BAD_FLAGS = unchecked((int)0x80090009);

        /// <summary>
        /// Invalid type specified.
        /// </summary>
        public const int NTE_BAD_TYPE = unchecked((int)0x8009000A);

        /// <summary>
        /// Key not valid for use in specified state.
        /// </summary>
        public const int NTE_BAD_KEY_STATE = unchecked((int)0x8009000B);

        /// <summary>
        /// Hash not valid for use in specified state.
        /// </summary>
        public const int NTE_BAD_HASH_STATE = unchecked((int)0x8009000C);

        /// <summary>
        /// Key does not exist.
        /// </summary>
        public const int NTE_NO_KEY = unchecked((int)0x8009000D);

        /// <summary>
        /// Insufficient memory available for the operation.
        /// </summary>
        public const int NTE_NO_MEMORY = unchecked((int)0x8009000E);

        /// <summary>
        /// Object already exists.
        /// </summary>
        public const int NTE_EXISTS = unchecked((int)0x8009000F);

        /// <summary>
        /// Access denied.
        /// </summary>
        public const int NTE_PERM = unchecked((int)0x80090010);

        /// <summary>
        /// Object was not found.
        /// </summary>
        public const int NTE_NOT_FOUND = unchecked((int)0x80090011);

        /// <summary>
        /// Data already encrypted.
        /// </summary>
        public const int NTE_DOUBLE_ENCRYPT = unchecked((int)0x80090012);

        /// <summary>
        /// Invalid provider specified.
        /// </summary>
        public const int NTE_BAD_PROVIDER = unchecked((int)0x80090013);

        /// <summary>
        /// Invalid provider type specified.
        /// </summary>
        public const int NTE_BAD_PROV_TYPE = unchecked((int)0x80090014);

        /// <summary>
        /// Provider's public key is invalid.
        /// </summary>
        public const int NTE_BAD_PUBLIC_KEY = unchecked((int)0x80090015);

        /// <summary>
        /// Keyset does not exist
        /// </summary>
        public const int NTE_BAD_KEYSET = unchecked((int)0x80090016);

        /// <summary>
        /// Provider type not defined.
        /// </summary>
        public const int NTE_PROV_TYPE_NOT_DEF = unchecked((int)0x80090017);

        /// <summary>
        /// Provider type as registered is invalid.
        /// </summary>
        public const int NTE_PROV_TYPE_ENTRY_BAD = unchecked((int)0x80090018);

        /// <summary>
        /// The keyset is not defined.
        /// </summary>
        public const int NTE_KEYSET_NOT_DEF = unchecked((int)0x80090019);

        /// <summary>
        /// Keyset as registered is invalid.
        /// </summary>
        public const int NTE_KEYSET_ENTRY_BAD = unchecked((int)0x8009001A);

        /// <summary>
        /// Provider type does not match registered value.
        /// </summary>
        public const int NTE_PROV_TYPE_NO_MATCH = unchecked((int)0x8009001B);

        /// <summary>
        /// The digital signature file is corrupt.
        /// </summary>
        public const int NTE_SIGNATURE_FILE_BAD = unchecked((int)0x8009001C);

        /// <summary>
        /// Provider DLL failed to initialize correctly.
        /// </summary>
        public const int NTE_PROVIDER_DLL_FAIL = unchecked((int)0x8009001D);

        /// <summary>
        /// Provider DLL could not be found.
        /// </summary>
        public const int NTE_PROV_DLL_NOT_FOUND = unchecked((int)0x8009001E);

        /// <summary>
        /// The Keyset parameter is invalid.
        /// </summary>
        public const int NTE_BAD_KEYSET_PARAM = unchecked((int)0x8009001F);

        /// <summary>
        /// An internal error occurred.
        /// </summary>
        public const int NTE_FAIL = unchecked((int)0x80090020);

        /// <summary>
        /// A base error occurred.
        /// </summary>
        public const int NTE_SYS_ERR = unchecked((int)0x80090021);

        /// <summary>
        /// Provider could not perform the action since the context was acquired as silent.
        /// </summary>
        public const int NTE_SILENT_CONTEXT = unchecked((int)0x80090022);

        /// <summary>
        /// The security token does not have storage space available for an additional container.
        /// </summary>
        public const int NTE_TOKEN_KEYSET_STORAGE_FULL = unchecked((int)0x80090023);

        /// <summary>
        /// The profile for the user is a temporary profile.
        /// </summary>
        public const int NTE_TEMPORARY_PROFILE = unchecked((int)0x80090024);

        /// <summary>
        /// The key parameters could not be set because the CSP uses fixed parameters.
        /// </summary>
        public const int NTE_FIXEDPARAMETER = unchecked((int)0x80090025);

        /// <summary>
        /// The supplied handle is invalid.
        /// </summary>
        public const int NTE_INVALID_HANDLE = unchecked((int)0x80090026);

        /// <summary>
        /// The parameter is incorrect.
        /// </summary>
        public const int NTE_INVALID_PARAMETER = unchecked((int)0x80090027);

        /// <summary>
        /// The buffer supplied to a function was too small.
        /// </summary>
        public const int NTE_BUFFER_TOO_SMALL = unchecked((int)0x80090028);

        /// <summary>
        /// The requested operation is not supported.
        /// </summary>
        public const int NTE_NOT_SUPPORTED = unchecked((int)0x80090029);

        /// <summary>
        /// No more data is available.
        /// </summary>
        public const int NTE_NO_MORE_ITEMS = unchecked((int)0x8009002A);

        /// <summary>
        /// The supplied buffers overlap incorrectly.
        /// </summary>
        public const int NTE_BUFFERS_OVERLAP = unchecked((int)0x8009002B);

        /// <summary>
        /// The specified data could not be decrypted.
        /// </summary>
        public const int NTE_DECRYPTION_FAILURE = unchecked((int)0x8009002C);

        /// <summary>
        /// An internal consistency check failed.
        /// </summary>
        public const int NTE_INTERNAL_ERROR = unchecked((int)0x8009002D);

        /// <summary>
        /// This operation requires input from the user.
        /// </summary>
        public const int NTE_UI_REQUIRED = unchecked((int)0x8009002E);

        /// <summary>
        /// The cryptographic provider does not support HMAC.
        /// </summary>
        public const int NTE_HMAC_NOT_SUPPORTED = unchecked((int)0x8009002F);

        /// <summary>
        /// The device that is required by this cryptographic provider is not ready for use.
        /// </summary>
        public const int NTE_DEVICE_NOT_READY = unchecked((int)0x80090030);

        /// <summary>
        /// The dictionary attack mitigation is triggered and the provided authorization was ignored by the provider.
        /// </summary>
        public const int NTE_AUTHENTICATION_IGNORED = unchecked((int)0x80090031);

        /// <summary>
        /// The validation of the provided data failed the integrity or signature validation.
        /// </summary>
        public const int NTE_VALIDATION_FAILED = unchecked((int)0x80090032);

        /// <summary>
        /// Incorrect password.
        /// </summary>
        public const int NTE_INCORRECT_PASSWORD = unchecked((int)0x80090033);

        /// <summary>
        /// Encryption failed.
        /// </summary>
        public const int NTE_ENCRYPTION_FAILURE = unchecked((int)0x80090034);

        /// <summary>
        /// The device that is required by this cryptographic provider is not found on this platform.
        /// </summary>
        public const int NTE_DEVICE_NOT_FOUND = unchecked((int)0x80090035);

        /// <summary>
        /// The action was cancelled by the user.
        /// </summary>
        public const int NTE_USER_CANCELLED = unchecked((int)0x80090036);

        /// <summary>
        /// The password is no longer valid and must be changed.
        /// </summary>
        public const int NTE_PASSWORD_CHANGE_REQUIRED = unchecked((int)0x80090037);

        /// <summary>
        /// The operation cannot be completed from Terminal Server client sessions.
        /// </summary>
        public const int NTE_NOT_ACTIVE_CONSOLE = unchecked((int)0x80090038);

        /// <summary>
        /// Not enough memory is available to complete this request
        /// </summary>
        public const int SEC_E_INSUFFICIENT_MEMORY = unchecked((int)0x80090300);

        /// <summary>
        /// The handle specified is invalid
        /// </summary>
        public const int SEC_E_INVALID_HANDLE = unchecked((int)0x80090301);

        /// <summary>
        /// The function requested is not supported
        /// </summary>
        public const int SEC_E_UNSUPPORTED_FUNCTION = unchecked((int)0x80090302);

        /// <summary>
        /// The specified target is unknown or unreachable
        /// </summary>
        public const int SEC_E_TARGET_UNKNOWN = unchecked((int)0x80090303);

        /// <summary>
        /// The Local Security Authority cannot be contacted
        /// </summary>
        public const int SEC_E_INTERNAL_ERROR = unchecked((int)0x80090304);

        /// <summary>
        /// The requested security package does not exist
        /// </summary>
        public const int SEC_E_SECPKG_NOT_FOUND = unchecked((int)0x80090305);

        /// <summary>
        /// The caller is not the owner of the desired credentials
        /// </summary>
        public const int SEC_E_NOT_OWNER = unchecked((int)0x80090306);

        /// <summary>
        /// The security package failed to initialize, and cannot be installed
        /// </summary>
        public const int SEC_E_CANNOT_INSTALL = unchecked((int)0x80090307);

        /// <summary>
        /// The token supplied to the function is invalid
        /// </summary>
        public const int SEC_E_INVALID_TOKEN = unchecked((int)0x80090308);

        /// <summary>
        /// The security package is not able to marshall the logon buffer, so the logon attempt has failed
        /// </summary>
        public const int SEC_E_CANNOT_PACK = unchecked((int)0x80090309);

        /// <summary>
        /// The per-message Quality of Protection is not supported by the security package
        /// </summary>
        public const int SEC_E_QOP_NOT_SUPPORTED = unchecked((int)0x8009030A);

        /// <summary>
        /// The security context does not allow impersonation of the client
        /// </summary>
        public const int SEC_E_NO_IMPERSONATION = unchecked((int)0x8009030B);

        /// <summary>
        /// The logon attempt failed
        /// </summary>
        public const int SEC_E_LOGON_DENIED = unchecked((int)0x8009030C);

        /// <summary>
        /// The credentials supplied to the package were not recognized
        /// </summary>
        public const int SEC_E_UNKNOWN_CREDENTIALS = unchecked((int)0x8009030D);

        /// <summary>
        /// No credentials are available in the security package
        /// </summary>
        public const int SEC_E_NO_CREDENTIALS = unchecked((int)0x8009030E);

        /// <summary>
        /// The message or signature supplied for verification has been altered
        /// </summary>
        public const int SEC_E_MESSAGE_ALTERED = unchecked((int)0x8009030F);

        /// <summary>
        /// The message supplied for verification is out of sequence
        /// </summary>
        public const int SEC_E_OUT_OF_SEQUENCE = unchecked((int)0x80090310);

        /// <summary>
        /// No authority could be contacted for authentication.
        /// </summary>
        public const int SEC_E_NO_AUTHENTICATING_AUTHORITY = unchecked((int)0x80090311);

        /// <summary>
        /// The function completed successfully, but must be called again to complete the context
        /// </summary>
        public const int SEC_I_CONTINUE_NEEDED = 0x00090312;

        /// <summary>
        /// The function completed successfully, but CompleteToken must be called
        /// </summary>
        public const int SEC_I_COMPLETE_NEEDED = 0x00090313;

        /// <summary>
        /// The function completed successfully, but both CompleteToken and this function must be called to complete the context
        /// </summary>
        public const int SEC_I_COMPLETE_AND_CONTINUE = 0x00090314;

        /// <summary>
        /// The logon was completed, but no network authority was available. The logon was made using locally known information
        /// </summary>
        public const int SEC_I_LOCAL_LOGON = 0x00090315;

        /// <summary>
        /// The requested security package does not exist
        /// </summary>
        public const int SEC_E_BAD_PKGID = unchecked((int)0x80090316);

        /// <summary>
        /// The context has expired and can no longer be used.
        /// </summary>
        public const int SEC_E_CONTEXT_EXPIRED = unchecked((int)0x80090317);

        /// <summary>
        /// The context has expired and can no longer be used.
        /// </summary>
        public const int SEC_I_CONTEXT_EXPIRED = 0x00090317;

        /// <summary>
        /// The supplied message is incomplete. The signature was not verified.
        /// </summary>
        public const int SEC_E_INCOMPLETE_MESSAGE = unchecked((int)0x80090318);

        /// <summary>
        /// The credentials supplied were not complete, and could not be verified. The context could not be initialized.
        /// </summary>
        public const int SEC_E_INCOMPLETE_CREDENTIALS = unchecked((int)0x80090320);

        /// <summary>
        /// The buffers supplied to a function was too small.
        /// </summary>
        public const int SEC_E_BUFFER_TOO_SMALL = unchecked((int)0x80090321);

        /// <summary>
        /// The credentials supplied were not complete, and could not be verified. Additional information can be returned from the context.
        /// </summary>
        public const int SEC_I_INCOMPLETE_CREDENTIALS = 0x00090320;

        /// <summary>
        /// The context data must be renegotiated with the peer.
        /// </summary>
        public const int SEC_I_RENEGOTIATE = 0x00090321;

        /// <summary>
        /// The target principal name is incorrect.
        /// </summary>
        public const int SEC_E_WRONG_PRINCIPAL = unchecked((int)0x80090322);

        /// <summary>
        /// There is no LSA mode context associated with this context.
        /// </summary>
        public const int SEC_I_NO_LSA_CONTEXT = 0x00090323;

        /// <summary>
        /// The clocks on the client and server machines are skewed.
        /// </summary>
        public const int SEC_E_TIME_SKEW = unchecked((int)0x80090324);

        /// <summary>
        /// The certificate chain was issued by an authority that is not trusted.
        /// </summary>
        public const int SEC_E_UNTRUSTED_ROOT = unchecked((int)0x80090325);

        /// <summary>
        /// The message received was unexpected or badly formatted.
        /// </summary>
        public const int SEC_E_ILLEGAL_MESSAGE = unchecked((int)0x80090326);

        /// <summary>
        /// An unknown error occurred while processing the certificate.
        /// </summary>
        public const int SEC_E_CERT_UNKNOWN = unchecked((int)0x80090327);

        /// <summary>
        /// The received certificate has expired.
        /// </summary>
        public const int SEC_E_CERT_EXPIRED = unchecked((int)0x80090328);

        /// <summary>
        /// The specified data could not be encrypted.
        /// </summary>
        public const int SEC_E_ENCRYPT_FAILURE = unchecked((int)0x80090329);

        /// <summary>
        /// The specified data could not be decrypted.
        /// </summary>
        public const int SEC_E_DECRYPT_FAILURE = unchecked((int)0x80090330);

        /// <summary>
        /// The client and server cannot communicate, because they do not possess a common algorithm.
        /// </summary>
        public const int SEC_E_ALGORITHM_MISMATCH = unchecked((int)0x80090331);

        /// <summary>
        /// The security context could not be established due to a failure in the requested quality of service (e.g. mutual authentication or delegation).
        /// </summary>
        public const int SEC_E_SECURITY_QOS_FAILED = unchecked((int)0x80090332);

        /// <summary>
        /// A security context was deleted before the context was completed. This is considered a logon failure.
        /// </summary>
        public const int SEC_E_UNFINISHED_CONTEXT_DELETED = unchecked((int)0x80090333);

        /// <summary>
        /// The client is trying to negotiate a context and the server requires user-to-user but didn't send a TGT reply.
        /// </summary>
        public const int SEC_E_NO_TGT_REPLY = unchecked((int)0x80090334);

        /// <summary>
        /// Unable to accomplish the requested task because the local machine does not have any IP addresses.
        /// </summary>
        public const int SEC_E_NO_IP_ADDRESSES = unchecked((int)0x80090335);

        /// <summary>
        /// The supplied credential handle does not match the credential associated with the security context.
        /// </summary>
        public const int SEC_E_WRONG_CREDENTIAL_HANDLE = unchecked((int)0x80090336);

        /// <summary>
        /// The crypto system or checksum function is invalid because a required function is unavailable.
        /// </summary>
        public const int SEC_E_CRYPTO_SYSTEM_INVALID = unchecked((int)0x80090337);

        /// <summary>
        /// The number of maximum ticket referrals has been exceeded.
        /// </summary>
        public const int SEC_E_MAX_REFERRALS_EXCEEDED = unchecked((int)0x80090338);

        /// <summary>
        /// The local machine must be a Kerberos KDC (domain controller) and it is not.
        /// </summary>
        public const int SEC_E_MUST_BE_KDC = unchecked((int)0x80090339);

        /// <summary>
        /// The other end of the security negotiation is requires strong crypto but it is not supported on the local machine.
        /// </summary>
        public const int SEC_E_STRONG_CRYPTO_NOT_SUPPORTED = unchecked((int)0x8009033A);

        /// <summary>
        /// The KDC reply contained more than one principal name.
        /// </summary>
        public const int SEC_E_TOO_MANY_PRINCIPALS = unchecked((int)0x8009033B);

        /// <summary>
        /// Expected to find PA data for a hint of what etype to use, but it was not found.
        /// </summary>
        public const int SEC_E_NO_PA_DATA = unchecked((int)0x8009033C);

        /// <summary>
        /// The client certificate does not contain a valid UPN, or does not match the client name in the logon request. Please contact your administrator.
        /// </summary>
        public const int SEC_E_PKINIT_NAME_MISMATCH = unchecked((int)0x8009033D);

        /// <summary>
        /// Smartcard logon is required and was not used.
        /// </summary>
        public const int SEC_E_SMARTCARD_LOGON_REQUIRED = unchecked((int)0x8009033E);

        /// <summary>
        /// A system shutdown is in progress.
        /// </summary>
        public const int SEC_E_SHUTDOWN_IN_PROGRESS = unchecked((int)0x8009033F);

        /// <summary>
        /// An invalid request was sent to the KDC.
        /// </summary>
        public const int SEC_E_KDC_INVALID_REQUEST = unchecked((int)0x80090340);

        /// <summary>
        /// The KDC was unable to generate a referral for the service requested.
        /// </summary>
        public const int SEC_E_KDC_UNABLE_TO_REFER = unchecked((int)0x80090341);

        /// <summary>
        /// The encryption type requested is not supported by the KDC.
        /// </summary>
        public const int SEC_E_KDC_UNKNOWN_ETYPE = unchecked((int)0x80090342);

        /// <summary>
        /// An unsupported preauthentication mechanism was presented to the Kerberos package.
        /// </summary>
        public const int SEC_E_UNSUPPORTED_PREAUTH = unchecked((int)0x80090343);

        /// <summary>
        /// The requested operation cannot be completed. The computer must be trusted for delegation and the current user account must be configured to allow delegation.
        /// </summary>
        public const int SEC_E_DELEGATION_REQUIRED = unchecked((int)0x80090345);

        /// <summary>
        /// Client's supplied SSPI channel bindings were incorrect.
        /// </summary>
        public const int SEC_E_BAD_BINDINGS = unchecked((int)0x80090346);

        /// <summary>
        /// The received certificate was mapped to multiple accounts.
        /// </summary>
        public const int SEC_E_MULTIPLE_ACCOUNTS = unchecked((int)0x80090347);

        /// <summary>
        /// SEC_E_NO_KERB_KEY
        /// </summary>
        public const int SEC_E_NO_KERB_KEY = unchecked((int)0x80090348);

        /// <summary>
        /// The certificate is not valid for the requested usage.
        /// </summary>
        public const int SEC_E_CERT_WRONG_USAGE = unchecked((int)0x80090349);

        /// <summary>
        /// The system cannot contact a domain controller to service the authentication request. Please try again later.
        /// </summary>
        public const int SEC_E_DOWNGRADE_DETECTED = unchecked((int)0x80090350);

        /// <summary>
        /// The smartcard certificate used for authentication has been revoked. Please contact your system administrator. There may be additional information in the event log.
        /// </summary>
        public const int SEC_E_SMARTCARD_CERT_REVOKED = unchecked((int)0x80090351);

        /// <summary>
        /// An untrusted certificate authority was detected while processing the smartcard certificate used for authentication. Please contact your system administrator.
        /// </summary>
        public const int SEC_E_ISSUING_CA_UNTRUSTED = unchecked((int)0x80090352);

        /// <summary>
        /// The revocation status of the smartcard certificate used for authentication could not be determined. Please contact your system administrator.
        /// </summary>
        public const int SEC_E_REVOCATION_OFFLINE_C = unchecked((int)0x80090353);

        /// <summary>
        /// The smartcard certificate used for authentication was not trusted. Please contact your system administrator.
        /// </summary>
        public const int SEC_E_PKINIT_CLIENT_FAILURE = unchecked((int)0x80090354);

        /// <summary>
        /// The smartcard certificate used for authentication has expired. Please contact your system administrator.
        /// </summary>
        public const int SEC_E_SMARTCARD_CERT_EXPIRED = unchecked((int)0x80090355);

        /// <summary>
        /// The Kerberos subsystem encountered an error. A service for user protocol request was made against a domain controller which does not support service for user.
        /// </summary>
        public const int SEC_E_NO_S4U_PROT_SUPPORT = unchecked((int)0x80090356);

        /// <summary>
        /// An attempt was made by this server to make a Kerberos constrained delegation request for a target outside of the server's realm. This is not supported, and indicates a misconfiguration on this server's allowed to delegate to list. Please contact your administrator.
        /// </summary>
        public const int SEC_E_CROSSREALM_DELEGATION_FAILURE = unchecked((int)0x80090357);

        /// <summary>
        /// The revocation status of the domain controller certificate used for smartcard authentication could not be determined. There is additional information in the system event log. Please contact your system administrator.
        /// </summary>
        public const int SEC_E_REVOCATION_OFFLINE_KDC = unchecked((int)0x80090358);

        /// <summary>
        /// An untrusted certificate authority was detected while processing the domain controller certificate used for authentication. There is additional information in the system event log. Please contact your system administrator.
        /// </summary>
        public const int SEC_E_ISSUING_CA_UNTRUSTED_KDC = unchecked((int)0x80090359);

        /// <summary>
        /// The domain controller certificate used for smartcard logon has expired. Please contact your system administrator with the contents of your system event log.
        /// </summary>
        public const int SEC_E_KDC_CERT_EXPIRED = unchecked((int)0x8009035A);

        /// <summary>
        /// The domain controller certificate used for smartcard logon has been revoked. Please contact your system administrator with the contents of your system event log.
        /// </summary>
        public const int SEC_E_KDC_CERT_REVOKED = unchecked((int)0x8009035B);

        /// <summary>
        /// A signature operation must be performed before the user can authenticate.
        /// </summary>
        public const int SEC_I_SIGNATURE_NEEDED = 0x0009035C;

        /// <summary>
        /// One or more of the parameters passed to the function was invalid.
        /// </summary>
        public const int SEC_E_INVALID_PARAMETER = unchecked((int)0x8009035D);

        /// <summary>
        /// Client policy does not allow credential delegation to target server.
        /// </summary>
        public const int SEC_E_DELEGATION_POLICY = unchecked((int)0x8009035E);

        /// <summary>
        /// Client policy does not allow credential delegation to target server with NLTM only authentication.
        /// </summary>
        public const int SEC_E_POLICY_NLTM_ONLY = unchecked((int)0x8009035F);

        /// <summary>
        /// The recipient rejected the renegotiation request.
        /// </summary>
        public const int SEC_I_NO_RENEGOTIATION = 0x00090360;

        /// <summary>
        /// The required security context does not exist.
        /// </summary>
        public const int SEC_E_NO_CONTEXT = unchecked((int)0x80090361);

        /// <summary>
        /// The PKU2U protocol encountered an error while attempting to utilize the associated certificates.
        /// </summary>
        public const int SEC_E_PKU2U_CERT_FAILURE = unchecked((int)0x80090362);

        /// <summary>
        /// The identity of the server computer could not be verified.
        /// </summary>
        public const int SEC_E_MUTUAL_AUTH_FAILED = unchecked((int)0x80090363);

        /// <summary>
        /// The returned buffer is only a fragment of the message.  More fragments need to be returned.
        /// </summary>
        public const int SEC_I_MESSAGE_FRAGMENT = 0x00090364;

        /// <summary>
        /// Only https scheme is allowed.
        /// </summary>
        public const int SEC_E_ONLY_HTTPS_ALLOWED = unchecked((int)0x80090365);

        /// <summary>
        /// The function completed successfully, but must be called again to complete the context.  Early start can be used.
        /// </summary>
        public const int SEC_I_CONTINUE_NEEDED_MESSAGE_OK = 0x00090366;

        /// <summary>
        /// No common application protocol exists between the client and the server. Application protocol negotiation failed.
        /// </summary>
        public const int SEC_E_APPLICATION_PROTOCOL_MISMATCH = unchecked((int)0x80090367);

        /// <summary>
        /// An asynchronous SSPI routine has been called and the work is pending completion.
        /// </summary>
        public const int SEC_I_ASYNC_CALL_PENDING = 0x00090368;

        /// <summary>
        /// You can't sign in with a user ID in this format. Try using your email address instead.
        /// </summary>
        public const int SEC_E_INVALID_UPN_NAME = unchecked((int)0x80090369);

        //
        // Provided for backwards compatibility
        //

        public const int SEC_E_NO_SPM = SEC_E_INTERNAL_ERROR;
        public const int SEC_E_NOT_SUPPORTED = SEC_E_UNSUPPORTED_FUNCTION;

        /// <summary>
        /// An error occurred while performing an operation on a cryptographic message.
        /// </summary>
        public const int CRYPT_E_MSG_ERROR = unchecked((int)0x80091001);

        /// <summary>
        /// Unknown cryptographic algorithm.
        /// </summary>
        public const int CRYPT_E_UNKNOWN_ALGO = unchecked((int)0x80091002);

        /// <summary>
        /// The object identifier is poorly formatted.
        /// </summary>
        public const int CRYPT_E_OID_FORMAT = unchecked((int)0x80091003);

        /// <summary>
        /// Invalid cryptographic message type.
        /// </summary>
        public const int CRYPT_E_INVALID_MSG_TYPE = unchecked((int)0x80091004);

        /// <summary>
        /// Unexpected cryptographic message encoding.
        /// </summary>
        public const int CRYPT_E_UNEXPECTED_ENCODING = unchecked((int)0x80091005);

        /// <summary>
        /// The cryptographic message does not contain an expected authenticated attribute.
        /// </summary>
        public const int CRYPT_E_AUTH_ATTR_MISSING = unchecked((int)0x80091006);

        /// <summary>
        /// The hash value is not correct.
        /// </summary>
        public const int CRYPT_E_HASH_VALUE = unchecked((int)0x80091007);

        /// <summary>
        /// The index value is not valid.
        /// </summary>
        public const int CRYPT_E_INVALID_INDEX = unchecked((int)0x80091008);

        /// <summary>
        /// The content of the cryptographic message has already been decrypted.
        /// </summary>
        public const int CRYPT_E_ALREADY_DECRYPTED = unchecked((int)0x80091009);

        /// <summary>
        /// The content of the cryptographic message has not been decrypted yet.
        /// </summary>
        public const int CRYPT_E_NOT_DECRYPTED = unchecked((int)0x8009100A);

        /// <summary>
        /// The enveloped-data message does not contain the specified recipient.
        /// </summary>
        public const int CRYPT_E_RECIPIENT_NOT_FOUND = unchecked((int)0x8009100B);

        /// <summary>
        /// Invalid control type.
        /// </summary>
        public const int CRYPT_E_CONTROL_TYPE = unchecked((int)0x8009100C);

        /// <summary>
        /// Invalid issuer and/or serial number.
        /// </summary>
        public const int CRYPT_E_ISSUER_SERIALNUMBER = unchecked((int)0x8009100D);

        /// <summary>
        /// Cannot find the original signer.
        /// </summary>
        public const int CRYPT_E_SIGNER_NOT_FOUND = unchecked((int)0x8009100E);

        /// <summary>
        /// The cryptographic message does not contain all of the requested attributes.
        /// </summary>
        public const int CRYPT_E_ATTRIBUTES_MISSING = unchecked((int)0x8009100F);

        /// <summary>
        /// The streamed cryptographic message is not ready to return data.
        /// </summary>
        public const int CRYPT_E_STREAM_MSG_NOT_READY = unchecked((int)0x80091010);

        /// <summary>
        /// The streamed cryptographic message requires more data to complete the decode operation.
        /// </summary>
        public const int CRYPT_E_STREAM_INSUFFICIENT_DATA = unchecked((int)0x80091011);

        /// <summary>
        /// The protected data needs to be re-protected.
        /// </summary>
        public const int CRYPT_I_NEW_PROTECTION_REQUIRED = 0x00091012;

        /// <summary>
        /// The length specified for the output data was insufficient.
        /// </summary>
        public const int CRYPT_E_BAD_LEN = unchecked((int)0x80092001);

        /// <summary>
        /// An error occurred during encode or decode operation.
        /// </summary>
        public const int CRYPT_E_BAD_ENCODE = unchecked((int)0x80092002);

        /// <summary>
        /// An error occurred while reading or writing to a file.
        /// </summary>
        public const int CRYPT_E_FILE_ERROR = unchecked((int)0x80092003);

        /// <summary>
        /// Cannot find object or property.
        /// </summary>
        public const int CRYPT_E_NOT_FOUND = unchecked((int)0x80092004);

        /// <summary>
        /// The object or property already exists.
        /// </summary>
        public const int CRYPT_E_EXISTS = unchecked((int)0x80092005);

        /// <summary>
        /// No provider was specified for the store or object.
        /// </summary>
        public const int CRYPT_E_NO_PROVIDER = unchecked((int)0x80092006);

        /// <summary>
        /// The specified certificate is self signed.
        /// </summary>
        public const int CRYPT_E_SELF_SIGNED = unchecked((int)0x80092007);

        /// <summary>
        /// The previous certificate or CRL context was deleted.
        /// </summary>
        public const int CRYPT_E_DELETED_PREV = unchecked((int)0x80092008);

        /// <summary>
        /// Cannot find the requested object.
        /// </summary>
        public const int CRYPT_E_NO_MATCH = unchecked((int)0x80092009);

        /// <summary>
        /// The certificate does not have a property that references a private key.
        /// </summary>
        public const int CRYPT_E_UNEXPECTED_MSG_TYPE = unchecked((int)0x8009200A);

        /// <summary>
        /// Cannot find the certificate and private key for decryption.
        /// </summary>
        public const int CRYPT_E_NO_KEY_PROPERTY = unchecked((int)0x8009200B);

        /// <summary>
        /// Cannot find the certificate and private key to use for decryption.
        /// </summary>
        public const int CRYPT_E_NO_DECRYPT_CERT = unchecked((int)0x8009200C);

        /// <summary>
        /// Not a cryptographic message or the cryptographic message is not formatted correctly.
        /// </summary>
        public const int CRYPT_E_BAD_MSG = unchecked((int)0x8009200D);

        /// <summary>
        /// The signed cryptographic message does not have a signer for the specified signer index.
        /// </summary>
        public const int CRYPT_E_NO_SIGNER = unchecked((int)0x8009200E);

        /// <summary>
        /// Final closure is pending until additional frees or closes.
        /// </summary>
        public const int CRYPT_E_PENDING_CLOSE = unchecked((int)0x8009200F);

        /// <summary>
        /// The certificate is revoked.
        /// </summary>
        public const int CRYPT_E_REVOKED = unchecked((int)0x80092010);

        /// <summary>
        /// No Dll or exported function was found to verify revocation.
        /// </summary>
        public const int CRYPT_E_NO_REVOCATION_DLL = unchecked((int)0x80092011);

        /// <summary>
        /// The revocation function was unable to check revocation for the certificate.
        /// </summary>
        public const int CRYPT_E_NO_REVOCATION_CHECK = unchecked((int)0x80092012);

        /// <summary>
        /// The revocation function was unable to check revocation because the revocation server was offline.
        /// </summary>
        public const int CRYPT_E_REVOCATION_OFFLINE = unchecked((int)0x80092013);

        /// <summary>
        /// The certificate is not in the revocation server's database.
        /// </summary>
        public const int CRYPT_E_NOT_IN_REVOCATION_DATABASE = unchecked((int)0x80092014);

        /// <summary>
        /// The string contains a non-numeric character.
        /// </summary>
        public const int CRYPT_E_INVALID_NUMERIC_STRING = unchecked((int)0x80092020);

        /// <summary>
        /// The string contains a non-printable character.
        /// </summary>
        public const int CRYPT_E_INVALID_PRINTABLE_STRING = unchecked((int)0x80092021);

        /// <summary>
        /// The string contains a character not in the 7 bit ASCII character set.
        /// </summary>
        public const int CRYPT_E_INVALID_IA5_STRING = unchecked((int)0x80092022);

        /// <summary>
        /// The string contains an invalid X500 name attribute key, oid, value or delimiter.
        /// </summary>
        public const int CRYPT_E_INVALID_X500_STRING = unchecked((int)0x80092023);

        /// <summary>
        /// The dwValueType for the CERT_NAME_VALUE is not one of the character strings. Most likely it is either a CERT_RDN_ENCODED_BLOB or CERT_RDN_OCTET_STRING.
        /// </summary>
        public const int CRYPT_E_NOT_CHAR_STRING = unchecked((int)0x80092024);

        /// <summary>
        /// The Put operation cannot continue. The file needs to be resized. However, there is already a signature present. A complete signing operation must be done.
        /// </summary>
        public const int CRYPT_E_FILERESIZED = unchecked((int)0x80092025);

        /// <summary>
        /// The cryptographic operation failed due to a local security option setting.
        /// </summary>
        public const int CRYPT_E_SECURITY_SETTINGS = unchecked((int)0x80092026);

        /// <summary>
        /// No DLL or exported function was found to verify subject usage.
        /// </summary>
        public const int CRYPT_E_NO_VERIFY_USAGE_DLL = unchecked((int)0x80092027);

        /// <summary>
        /// The called function was unable to do a usage check on the subject.
        /// </summary>
        public const int CRYPT_E_NO_VERIFY_USAGE_CHECK = unchecked((int)0x80092028);

        /// <summary>
        /// Since the server was offline, the called function was unable to complete the usage check.
        /// </summary>
        public const int CRYPT_E_VERIFY_USAGE_OFFLINE = unchecked((int)0x80092029);

        /// <summary>
        /// The subject was not found in a Certificate Trust List (CTL).
        /// </summary>
        public const int CRYPT_E_NOT_IN_CTL = unchecked((int)0x8009202A);

        /// <summary>
        /// None of the signers of the cryptographic message or certificate trust list is trusted.
        /// </summary>
        public const int CRYPT_E_NO_TRUSTED_SIGNER = unchecked((int)0x8009202B);

        /// <summary>
        /// The public key's algorithm parameters are missing.
        /// </summary>
        public const int CRYPT_E_MISSING_PUBKEY_PARA = unchecked((int)0x8009202C);

        /// <summary>
        /// An object could not be located using the object locator infrastructure with the given name.
        /// </summary>
        public const int CRYPT_E_OBJECT_LOCATOR_OBJECT_NOT_FOUND = unchecked((int)0x8009202D);

        /// <summary>
        /// <para>OSS Certificate encode/decode error code base</para>
        /// <para>See asn1code.h for a definition of the OSS runtime errors. The OSS error values are offset by CRYPT_E_OSS_ERROR.</para>
        /// </summary>
        public const int CRYPT_E_OSS_ERROR = unchecked((int)0x80093000);

        /// <summary>
        /// OSS ASN.1 Error: Output Buffer is too small.
        /// </summary>
        public const int OSS_MORE_BUF = unchecked((int)0x80093001);

        /// <summary>
        /// OSS ASN.1 Error: Signed integer is encoded as a unsigned integer.
        /// </summary>
        public const int OSS_NEGATIVE_UINTEGER = unchecked((int)0x80093002);

        /// <summary>
        /// OSS ASN.1 Error: Unknown ASN.1 data type.
        /// </summary>
        public const int OSS_PDU_RANGE = unchecked((int)0x80093003);

        /// <summary>
        /// OSS ASN.1 Error: Output buffer is too small, the decoded data has been truncated.
        /// </summary>
        public const int OSS_MORE_INPUT = unchecked((int)0x80093004);

        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_DATA_ERROR = unchecked((int)0x80093005);

        /// <summary>
        /// OSS ASN.1 Error: Invalid argument.
        /// </summary>
        public const int OSS_BAD_ARG = unchecked((int)0x80093006);

        /// <summary>
        /// OSS ASN.1 Error: Encode/Decode version mismatch.
        /// </summary>
        public const int OSS_BAD_VERSION = unchecked((int)0x80093007);

        /// <summary>
        /// OSS ASN.1 Error: Out of memory.
        /// </summary>
        public const int OSS_OUT_MEMORY = unchecked((int)0x80093008);

        /// <summary>
        /// OSS ASN.1 Error: Encode/Decode Error.
        /// </summary>
        public const int OSS_PDU_MISMATCH = unchecked((int)0x80093009);

        /// <summary>
        /// OSS ASN.1 Error: Internal Error.
        /// </summary>
        public const int OSS_LIMITED = unchecked((int)0x8009300A);

        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_BAD_PTR = unchecked((int)0x8009300B);

        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_BAD_TIME = unchecked((int)0x8009300C);

        /// <summary>
        /// OSS ASN.1 Error: Unsupported BER indefinite-length encoding.
        /// </summary>
        public const int OSS_INDEFINITE_NOT_SUPPORTED = unchecked((int)0x8009300D);

        /// <summary>
        /// OSS ASN.1 Error: Access violation.
        /// </summary>
        public const int OSS_MEM_ERROR = unchecked((int)0x8009300E);

        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_BAD_TABLE = unchecked((int)0x8009300F);

        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_TOO_LONG = unchecked((int)0x80093010);

        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_CONSTRAINT_VIOLATED = unchecked((int)0x80093011);

        /// <summary>
        /// OSS ASN.1 Error: Internal Error.
        /// </summary>
        public const int OSS_FATAL_ERROR = unchecked((int)0x80093012);

        /// <summary>
        /// OSS ASN.1 Error: Multi-threading conflict.
        /// </summary>
        public const int OSS_ACCESS_SERIALIZATION_ERROR = unchecked((int)0x80093013);

        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_NULL_TBL = unchecked((int)0x80093014);

        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_NULL_FCN = unchecked((int)0x80093015);

        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_BAD_ENCRULES = unchecked((int)0x80093016);

        /// <summary>
        /// OSS ASN.1 Error: Encode/Decode function not implemented.
        /// </summary>
        public const int OSS_UNAVAIL_ENCRULES = unchecked((int)0x80093017);

        /// <summary>
        /// OSS ASN.1 Error: Trace file error.
        /// </summary>
        public const int OSS_CANT_OPEN_TRACE_WINDOW = unchecked((int)0x80093018);

        /// <summary>
        /// OSS ASN.1 Error: Function not implemented.
        /// </summary>
        public const int OSS_UNIMPLEMENTED = unchecked((int)0x80093019);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_OID_DLL_NOT_LINKED = unchecked((int)0x8009301A);

        /// <summary>
        /// OSS ASN.1 Error: Trace file error.
        /// </summary>
        public const int OSS_CANT_OPEN_TRACE_FILE = unchecked((int)0x8009301B);

        /// <summary>
        /// OSS ASN.1 Error: Trace file error.
        /// </summary>
        public const int OSS_TRACE_FILE_ALREADY_OPEN = unchecked((int)0x8009301C);

        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_TABLE_MISMATCH = unchecked((int)0x8009301D);

        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_TYPE_NOT_SUPPORTED = unchecked((int)0x8009301E);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_REAL_DLL_NOT_LINKED = unchecked((int)0x8009301F);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_REAL_CODE_NOT_LINKED = unchecked((int)0x80093020);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_OUT_OF_RANGE = unchecked((int)0x80093021);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_COPIER_DLL_NOT_LINKED = unchecked((int)0x80093022);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_CONSTRAINT_DLL_NOT_LINKED = unchecked((int)0x80093023);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_COMPARATOR_DLL_NOT_LINKED = unchecked((int)0x80093024);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_COMPARATOR_CODE_NOT_LINKED = unchecked((int)0x80093025);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_MEM_MGR_DLL_NOT_LINKED = unchecked((int)0x80093026);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_PDV_DLL_NOT_LINKED = unchecked((int)0x80093027);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_PDV_CODE_NOT_LINKED = unchecked((int)0x80093028);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_API_DLL_NOT_LINKED = unchecked((int)0x80093029);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_BERDER_DLL_NOT_LINKED = unchecked((int)0x8009302A);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_PER_DLL_NOT_LINKED = unchecked((int)0x8009302B);

        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_OPEN_TYPE_ERROR = unchecked((int)0x8009302C);

        /// <summary>
        /// OSS ASN.1 Error: System resource error.
        /// </summary>
        public const int OSS_MUTEX_NOT_CREATED = unchecked((int)0x8009302D);

        /// <summary>
        /// OSS ASN.1 Error: Trace file error.
        /// </summary>
        public const int OSS_CANT_CLOSE_TRACE_FILE = unchecked((int)0x8009302E);

        /// <summary>
        /// ASN1 Certificate encode/decode error code base. The ASN1 error values are offset by CRYPT_E_ASN1_ERROR.
        /// </summary>
        public const int CRYPT_E_ASN1_ERROR = unchecked((int)0x80093100);

        /// <summary>
        /// ASN1 internal encode or decode error.
        /// </summary>
        public const int CRYPT_E_ASN1_INTERNAL = unchecked((int)0x80093101);

        /// <summary>
        /// ASN1 unexpected end of data.
        /// </summary>
        public const int CRYPT_E_ASN1_EOD = unchecked((int)0x80093102);

        /// <summary>
        /// ASN1 corrupted data.
        /// </summary>
        public const int CRYPT_E_ASN1_CORRUPT = unchecked((int)0x80093103);

        /// <summary>
        /// ASN1 value too large.
        /// </summary>
        public const int CRYPT_E_ASN1_LARGE = unchecked((int)0x80093104);

        /// <summary>
        /// ASN1 constraint violated.
        /// </summary>
        public const int CRYPT_E_ASN1_CONSTRAINT = unchecked((int)0x80093105);

        /// <summary>
        /// ASN1 out of memory.
        /// </summary>
        public const int CRYPT_E_ASN1_MEMORY = unchecked((int)0x80093106);

        /// <summary>
        /// ASN1 buffer overflow.
        /// </summary>
        public const int CRYPT_E_ASN1_OVERFLOW = unchecked((int)0x80093107);

        /// <summary>
        /// ASN1 function not supported for this PDU.
        /// </summary>
        public const int CRYPT_E_ASN1_BADPDU = unchecked((int)0x80093108);

        /// <summary>
        /// ASN1 bad arguments to function call.
        /// </summary>
        public const int CRYPT_E_ASN1_BADARGS = unchecked((int)0x80093109);

        /// <summary>
        /// ASN1 bad real value.
        /// </summary>
        public const int CRYPT_E_ASN1_BADREAL = unchecked((int)0x8009310A);

        /// <summary>
        /// ASN1 bad tag value met.
        /// </summary>
        public const int CRYPT_E_ASN1_BADTAG = unchecked((int)0x8009310B);

        /// <summary>
        /// ASN1 bad choice value.
        /// </summary>
        public const int CRYPT_E_ASN1_CHOICE = unchecked((int)0x8009310C);

        /// <summary>
        /// ASN1 bad encoding rule.
        /// </summary>
        public const int CRYPT_E_ASN1_RULE = unchecked((int)0x8009310D);

        /// <summary>
        /// ASN1 bad unicode (UTF8).
        /// </summary>
        public const int CRYPT_E_ASN1_UTF8 = unchecked((int)0x8009310E);

        /// <summary>
        /// ASN1 bad PDU type.
        /// </summary>
        public const int CRYPT_E_ASN1_PDU_TYPE = unchecked((int)0x80093133);

        /// <summary>
        /// ASN1 not yet implemented.
        /// </summary>
        public const int CRYPT_E_ASN1_NYI = unchecked((int)0x80093134);

        /// <summary>
        /// ASN1 skipped unknown extension(s).
        /// </summary>
        public const int CRYPT_E_ASN1_EXTENDED = unchecked((int)0x80093201);

        /// <summary>
        /// ASN1 end of data expected
        /// </summary>
        public const int CRYPT_E_ASN1_NOEOD = unchecked((int)0x80093202);

        /// <summary>
        /// The request subject name is invalid or too long.
        /// </summary>
        public const int CERTSRV_E_BAD_REQUESTSUBJECT = unchecked((int)0x80094001);

        /// <summary>
        /// The request does not exist.
        /// </summary>
        public const int CERTSRV_E_NO_REQUEST = unchecked((int)0x80094002);

        /// <summary>
        /// The request's current status does not allow this operation.
        /// </summary>
        public const int CERTSRV_E_BAD_REQUESTSTATUS = unchecked((int)0x80094003);

        /// <summary>
        /// The requested property value is empty.
        /// </summary>
        public const int CERTSRV_E_PROPERTY_EMPTY = unchecked((int)0x80094004);

        /// <summary>
        /// The certification authority's certificate contains invalid data.
        /// </summary>
        public const int CERTSRV_E_INVALID_CA_CERTIFICATE = unchecked((int)0x80094005);

        /// <summary>
        /// Certificate service has been suspended for a database restore operation.
        /// </summary>
        public const int CERTSRV_E_SERVER_SUSPENDED = unchecked((int)0x80094006);

        /// <summary>
        /// The certificate contains an encoded length that is potentially incompatible with older enrollment software.
        /// </summary>
        public const int CERTSRV_E_ENCODING_LENGTH = unchecked((int)0x80094007);

        /// <summary>
        /// The operation is denied. The user has multiple roles assigned and the certification authority is configured to enforce role separation.
        /// </summary>
        public const int CERTSRV_E_ROLECONFLICT = unchecked((int)0x80094008);

        /// <summary>
        /// The operation is denied. It can only be performed by a certificate manager that is allowed to manage certificates for the current requester.
        /// </summary>
        public const int CERTSRV_E_RESTRICTEDOFFICER = unchecked((int)0x80094009);

        /// <summary>
        /// Cannot archive private key. The certification authority is not configured for key archival.
        /// </summary>
        public const int CERTSRV_E_KEY_ARCHIVAL_NOT_CONFIGURED = unchecked((int)0x8009400A);

        /// <summary>
        /// Cannot archive private key. The certification authority could not verify one or more key recovery certificates.
        /// </summary>
        public const int CERTSRV_E_NO_VALID_KRA = unchecked((int)0x8009400B);

        /// <summary>
        /// The request is incorrectly formatted. The encrypted private key must be in an unauthenticated attribute in an outermost signature.
        /// </summary>
        public const int CERTSRV_E_BAD_REQUEST_KEY_ARCHIVAL = unchecked((int)0x8009400C);

        /// <summary>
        /// At least one security principal must have the permission to manage this CA.
        /// </summary>
        public const int CERTSRV_E_NO_CAADMIN_DEFINED = unchecked((int)0x8009400D);

        /// <summary>
        /// The request contains an invalid renewal certificate attribute.
        /// </summary>
        public const int CERTSRV_E_BAD_RENEWAL_CERT_ATTRIBUTE = unchecked((int)0x8009400E);

        /// <summary>
        /// An attempt was made to open a Certification Authority database session, but there are already too many active sessions. The server may need to be configured to allow additional sessions.
        /// </summary>
        public const int CERTSRV_E_NO_DB_SESSIONS = unchecked((int)0x8009400F);

        /// <summary>
        /// A memory reference caused a data alignment fault.
        /// </summary>
        public const int CERTSRV_E_ALIGNMENT_FAULT = unchecked((int)0x80094010);

        /// <summary>
        /// The permissions on this certification authority do not allow the current user to enroll for certificates.
        /// </summary>
        public const int CERTSRV_E_ENROLL_DENIED = unchecked((int)0x80094011);

        /// <summary>
        /// The permissions on the certificate template do not allow the current user to enroll for this type of certificate.
        /// </summary>
        public const int CERTSRV_E_TEMPLATE_DENIED = unchecked((int)0x80094012);

        /// <summary>
        /// The contacted domain controller cannot support signed LDAP traffic. Update the domain controller or configure Certificate Services to use SSL for Active Directory access.
        /// </summary>
        public const int CERTSRV_E_DOWNLEVEL_DC_SSL_OR_UPGRADE = unchecked((int)0x80094013);

        /// <summary>
        /// The request was denied by a certificate manager or CA administrator.
        /// </summary>
        public const int CERTSRV_E_ADMIN_DENIED_REQUEST = unchecked((int)0x80094014);

        /// <summary>
        /// An enrollment policy server cannot be located.
        /// </summary>
        public const int CERTSRV_E_NO_POLICY_SERVER = unchecked((int)0x80094015);

        /// <summary>
        /// A signature algorithm or public key length does not meet the system's minimum required strength.
        /// </summary>
        public const int CERTSRV_E_WEAK_SIGNATURE_OR_KEY = unchecked((int)0x80094016);

        /// <summary>
        /// Failed to create an attested key.  This computer or the cryptographic provider may not meet the hardware requirements to support key attestation.
        /// </summary>
        public const int CERTSRV_E_KEY_ATTESTATION_NOT_SUPPORTED = unchecked((int)0x80094017);

        /// <summary>
        /// No encryption certificate was specified.
        /// </summary>
        public const int CERTSRV_E_ENCRYPTION_CERT_REQUIRED = unchecked((int)0x80094018);

        /// <summary>
        /// The requested certificate template is not supported by this CA.
        /// </summary>
        public const int CERTSRV_E_UNSUPPORTED_CERT_TYPE = unchecked((int)0x80094800);

        /// <summary>
        /// The request contains no certificate template information.
        /// </summary>
        public const int CERTSRV_E_NO_CERT_TYPE = unchecked((int)0x80094801);

        /// <summary>
        /// The request contains conflicting template information.
        /// </summary>
        public const int CERTSRV_E_TEMPLATE_CONFLICT = unchecked((int)0x80094802);

        /// <summary>
        /// The request is missing a required Subject Alternate name extension.
        /// </summary>
        public const int CERTSRV_E_SUBJECT_ALT_NAME_REQUIRED = unchecked((int)0x80094803);

        /// <summary>
        /// The request is missing a required private key for archival by the server.
        /// </summary>
        public const int CERTSRV_E_ARCHIVED_KEY_REQUIRED = unchecked((int)0x80094804);

        /// <summary>
        /// The request is missing a required SMIME capabilities extension.
        /// </summary>
        public const int CERTSRV_E_SMIME_REQUIRED = unchecked((int)0x80094805);

        /// <summary>
        /// The request was made on behalf of a subject other than the caller. The certificate template must be configured to require at least one signature to authorize the request.
        /// </summary>
        public const int CERTSRV_E_BAD_RENEWAL_SUBJECT = unchecked((int)0x80094806);

        /// <summary>
        /// The request template version is newer than the supported template version.
        /// </summary>
        public const int CERTSRV_E_BAD_TEMPLATE_VERSION = unchecked((int)0x80094807);

        /// <summary>
        /// The template is missing a required signature policy attribute.
        /// </summary>
        public const int CERTSRV_E_TEMPLATE_POLICY_REQUIRED = unchecked((int)0x80094808);

        /// <summary>
        /// The request is missing required signature policy information.
        /// </summary>
        public const int CERTSRV_E_SIGNATURE_POLICY_REQUIRED = unchecked((int)0x80094809);

        /// <summary>
        /// The request is missing one or more required signatures.
        /// </summary>
        public const int CERTSRV_E_SIGNATURE_COUNT = unchecked((int)0x8009480A);

        /// <summary>
        /// One or more signatures did not include the required application or issuance policies. The request is missing one or more required valid signatures.
        /// </summary>
        public const int CERTSRV_E_SIGNATURE_REJECTED = unchecked((int)0x8009480B);

        /// <summary>
        /// The request is missing one or more required signature issuance policies.
        /// </summary>
        public const int CERTSRV_E_ISSUANCE_POLICY_REQUIRED = unchecked((int)0x8009480C);

        /// <summary>
        /// The UPN is unavailable and cannot be added to the Subject Alternate name.
        /// </summary>
        public const int CERTSRV_E_SUBJECT_UPN_REQUIRED = unchecked((int)0x8009480D);

        /// <summary>
        /// The Active Directory GUID is unavailable and cannot be added to the Subject Alternate name.
        /// </summary>
        public const int CERTSRV_E_SUBJECT_DIRECTORY_GUID_REQUIRED = unchecked((int)0x8009480E);

        /// <summary>
        /// The DNS name is unavailable and cannot be added to the Subject Alternate name.
        /// </summary>
        public const int CERTSRV_E_SUBJECT_DNS_REQUIRED = unchecked((int)0x8009480F);

        /// <summary>
        /// The request includes a private key for archival by the server, but key archival is not enabled for the specified certificate template.
        /// </summary>
        public const int CERTSRV_E_ARCHIVED_KEY_UNEXPECTED = unchecked((int)0x80094810);

        /// <summary>
        /// The public key does not meet the minimum size required by the specified certificate template.
        /// </summary>
        public const int CERTSRV_E_KEY_LENGTH = unchecked((int)0x80094811);

        /// <summary>
        /// The EMail name is unavailable and cannot be added to the Subject or Subject Alternate name.
        /// </summary>
        public const int CERTSRV_E_SUBJECT_EMAIL_REQUIRED = unchecked((int)0x80094812);

        /// <summary>
        /// One or more certificate templates to be enabled on this certification authority could not be found.
        /// </summary>
        public const int CERTSRV_E_UNKNOWN_CERT_TYPE = unchecked((int)0x80094813);

        /// <summary>
        /// The certificate template renewal period is longer than the certificate validity period. The template should be reconfigured or the CA certificate renewed.
        /// </summary>
        public const int CERTSRV_E_CERT_TYPE_OVERLAP = unchecked((int)0x80094814);

        /// <summary>
        /// The certificate template requires too many RA signatures. Only one RA signature is allowed.
        /// </summary>
        public const int CERTSRV_E_TOO_MANY_SIGNATURES = unchecked((int)0x80094815);

        /// <summary>
        /// The certificate template requires renewal with the same public key, but the request uses a different public key.
        /// </summary>
        public const int CERTSRV_E_RENEWAL_BAD_PUBLIC_KEY = unchecked((int)0x80094816);

        /// <summary>
        /// The certification authority cannot interpret or verify the endorsement key information supplied in the request, or the information is inconsistent.
        /// </summary>
        public const int CERTSRV_E_INVALID_EK = unchecked((int)0x80094817);

        /// <summary>
        /// The certification authority cannot validate the Attestation Identity Key Id Binding.
        /// </summary>
        public const int CERTSRV_E_INVALID_IDBINDING = unchecked((int)0x80094818);

        /// <summary>
        /// The certification authority cannot validate the private key attestation data.
        /// </summary>
        public const int CERTSRV_E_INVALID_ATTESTATION = unchecked((int)0x80094819);

        /// <summary>
        /// The request does not support private key attestation as defined in the certificate template.
        /// </summary>
        public const int CERTSRV_E_KEY_ATTESTATION = unchecked((int)0x8009481A);

        /// <summary>
        /// The request public key is not consistent with the private key attestation data.
        /// </summary>
        public const int CERTSRV_E_CORRUPT_KEY_ATTESTATION = unchecked((int)0x8009481B);

        /// <summary>
        /// The private key attestation challenge cannot be validated because the encryption certificate has expired, or the certificate or key is unavailable.
        /// </summary>
        public const int CERTSRV_E_EXPIRED_CHALLENGE = unchecked((int)0x8009481C);

        /// <summary>
        /// The client's response could not be validated. It is either unexpected or incorrect.
        /// </summary>
        public const int CERTSRV_E_INVALID_RESPONSE = unchecked((int)0x8009481D);

        /// <summary>
        /// A valid Request ID was not detected in the request attributes, or an invalid one was submitted.
        /// </summary>
        public const int CERTSRV_E_INVALID_REQUESTID = unchecked((int)0x8009481E);

        /// <summary>
        /// The request is not consistent with the previously generated precertificate.
        /// </summary>
        public const int CERTSRV_E_REQUEST_PRECERTIFICATE_MISMATCH = unchecked((int)0x8009481F);

        /// <summary>
        /// The request is locked against edits until a response is received from the client.
        /// </summary>
        public const int CERTSRV_E_PENDING_CLIENT_RESPONSE = unchecked((int)0x80094820);

        //
        // The range 0x5000-0x51ff is reserved for XENROLL errors.
        //
        /// <summary>
        /// The key is not exportable.
        /// </summary>
        public const int XENROLL_E_KEY_NOT_EXPORTABLE = unchecked((int)0x80095000);

        /// <summary>
        /// You cannot add the root CA certificate into your local store.
        /// </summary>
        public const int XENROLL_E_CANNOT_ADD_ROOT_CERT = unchecked((int)0x80095001);

        /// <summary>
        /// The key archival hash attribute was not found in the response.
        /// </summary>
        public const int XENROLL_E_RESPONSE_KA_HASH_NOT_FOUND = unchecked((int)0x80095002);

        /// <summary>
        /// An unexpected key archival hash attribute was found in the response.
        /// </summary>
        public const int XENROLL_E_RESPONSE_UNEXPECTED_KA_HASH = unchecked((int)0x80095003);

        /// <summary>
        /// There is a key archival hash mismatch between the request and the response.
        /// </summary>
        public const int XENROLL_E_RESPONSE_KA_HASH_MISMATCH = unchecked((int)0x80095004);

        /// <summary>
        /// Signing certificate cannot include SMIME extension.
        /// </summary>
        public const int XENROLL_E_KEYSPEC_SMIME_MISMATCH = unchecked((int)0x80095005);

        /// <summary>
        /// A system-level error occurred while verifying trust.
        /// </summary>
        public const int TRUST_E_SYSTEM_ERROR = unchecked((int)0x80096001);

        /// <summary>
        /// The certificate for the signer of the message is invalid or not found.
        /// </summary>
        public const int TRUST_E_NO_SIGNER_CERT = unchecked((int)0x80096002);

        /// <summary>
        /// One of the counter signatures was invalid.
        /// </summary>
        public const int TRUST_E_COUNTER_SIGNER = unchecked((int)0x80096003);

        /// <summary>
        /// The signature of the certificate cannot be verified.
        /// </summary>
        public const int TRUST_E_CERT_SIGNATURE = unchecked((int)0x80096004);

        /// <summary>
        /// The timestamp signature and/or certificate could not be verified or is malformed.
        /// </summary>
        public const int TRUST_E_TIME_STAMP = unchecked((int)0x80096005);

        /// <summary>
        /// The digital signature of the object did not verify.
        /// </summary>
        public const int TRUST_E_BAD_DIGEST = unchecked((int)0x80096010);

        /// <summary>
        /// The digital signature of the object is malformed. For technical detail, see security bulletin MS13-098.
        /// </summary>
        public const int TRUST_E_MALFORMED_SIGNATURE = unchecked((int)0x80096011);

        /// <summary>
        /// A certificate's basic constraint extension has not been observed.
        /// </summary>
        public const int TRUST_E_BASIC_CONSTRAINTS = unchecked((int)0x80096019);

        /// <summary>
        /// The certificate does not meet or contain the Authenticode(tm) financial extensions.
        /// </summary>
        public const int TRUST_E_FINANCIAL_CRITERIA = unchecked((int)0x8009601E);

        //
        // Error codes for mssipotf.dll
        // Most of the error codes can only occur when an error occurs
        //    during font file signing
        //
        //
        /// <summary>
        /// Tried to reference a part of the file outside the proper range.
        /// </summary>
        public const int MSSIPOTF_E_OUTOFMEMRANGE = unchecked((int)0x80097001);

        /// <summary>
        /// Could not retrieve an object from the file.
        /// </summary>
        public const int MSSIPOTF_E_CANTGETOBJECT = unchecked((int)0x80097002);

        /// <summary>
        /// Could not find the head table in the file.
        /// </summary>
        public const int MSSIPOTF_E_NOHEADTABLE = unchecked((int)0x80097003);

        /// <summary>
        /// The magic number in the head table is incorrect.
        /// </summary>
        public const int MSSIPOTF_E_BAD_MAGICNUMBER = unchecked((int)0x80097004);

        /// <summary>
        /// The offset table has incorrect values.
        /// </summary>
        public const int MSSIPOTF_E_BAD_OFFSET_TABLE = unchecked((int)0x80097005);

        /// <summary>
        /// Duplicate table tags or tags out of alphabetical order.
        /// </summary>
        public const int MSSIPOTF_E_TABLE_TAGORDER = unchecked((int)0x80097006);

        /// <summary>
        /// A table does not start on a long word boundary.
        /// </summary>
        public const int MSSIPOTF_E_TABLE_LONGWORD = unchecked((int)0x80097007);

        /// <summary>
        /// First table does not appear after header information.
        /// </summary>
        public const int MSSIPOTF_E_BAD_FIRST_TABLE_PLACEMENT = unchecked((int)0x80097008);

        /// <summary>
        /// Two or more tables overlap.
        /// </summary>
        public const int MSSIPOTF_E_TABLES_OVERLAP = unchecked((int)0x80097009);

        /// <summary>
        /// Too many pad bytes between tables or pad bytes are not 0.
        /// </summary>
        public const int MSSIPOTF_E_TABLE_PADBYTES = unchecked((int)0x8009700A);

        /// <summary>
        /// File is too small to contain the last table.
        /// </summary>
        public const int MSSIPOTF_E_FILETOOSMALL = unchecked((int)0x8009700B);

        /// <summary>
        /// A table checksum is incorrect.
        /// </summary>
        public const int MSSIPOTF_E_TABLE_CHECKSUM = unchecked((int)0x8009700C);

        /// <summary>
        /// The file checksum is incorrect.
        /// </summary>
        public const int MSSIPOTF_E_FILE_CHECKSUM = unchecked((int)0x8009700D);

        /// <summary>
        /// The signature does not have the correct attributes for the policy.
        /// </summary>
        public const int MSSIPOTF_E_FAILED_POLICY = unchecked((int)0x80097010);

        /// <summary>
        /// The file did not pass the hints check.
        /// </summary>
        public const int MSSIPOTF_E_FAILED_HINTS_CHECK = unchecked((int)0x80097011);

        /// <summary>
        /// The file is not an OpenType file.
        /// </summary>
        public const int MSSIPOTF_E_NOT_OPENTYPE = unchecked((int)0x80097012);

        /// <summary>
        /// Failed on a file operation (open, map, read, write).
        /// </summary>
        public const int MSSIPOTF_E_FILE = unchecked((int)0x80097013);

        /// <summary>
        /// A call to a CryptoAPI function failed.
        /// </summary>
        public const int MSSIPOTF_E_CRYPT = unchecked((int)0x80097014);

        /// <summary>
        /// There is a bad version number in the file.
        /// </summary>
        public const int MSSIPOTF_E_BADVERSION = unchecked((int)0x80097015);

        /// <summary>
        /// The structure of the DSIG table is incorrect.
        /// </summary>
        public const int MSSIPOTF_E_DSIG_STRUCTURE = unchecked((int)0x80097016);

        /// <summary>
        /// A check failed in a partially constant table.
        /// </summary>
        public const int MSSIPOTF_E_PCONST_CHECK = unchecked((int)0x80097017);

        /// <summary>
        /// Some kind of structural error.
        /// </summary>
        public const int MSSIPOTF_E_STRUCTURE = unchecked((int)0x80097018);

        /// <summary>
        /// The requested credential requires confirmation.
        /// </summary>
        public const int ERROR_CRED_REQUIRES_CONFIRMATION = unchecked((int)0x80097019);

        public const int NTE_OP_OK = 0;

        //
        // Note that additional FACILITY_SSPI errors are in issperr.h
        //
        // ******************
        // FACILITY_CERT
        // ******************
        /// <summary>
        /// Unknown trust provider.
        /// </summary>
        public const int TRUST_E_PROVIDER_UNKNOWN = unchecked((int)0x800B0001);

        /// <summary>
        /// The trust verification action specified is not supported by the specified trust provider.
        /// </summary>
        public const int TRUST_E_ACTION_UNKNOWN = unchecked((int)0x800B0002);

        /// <summary>
        /// The form specified for the subject is not one supported or known by the specified trust provider.
        /// </summary>
        public const int TRUST_E_SUBJECT_FORM_UNKNOWN = unchecked((int)0x800B0003);

        /// <summary>
        /// The subject is not trusted for the specified action.
        /// </summary>
        public const int TRUST_E_SUBJECT_NOT_TRUSTED = unchecked((int)0x800B0004);

        /// <summary>
        /// Error due to problem in ASN.1 encoding process.
        /// </summary>
        public const int DIGSIG_E_ENCODE = unchecked((int)0x800B0005);

        /// <summary>
        /// Error due to problem in ASN.1 decoding process.
        /// </summary>
        public const int DIGSIG_E_DECODE = unchecked((int)0x800B0006);

        /// <summary>
        /// Reading / writing Extensions where Attributes are appropriate, and vice versa.
        /// </summary>
        public const int DIGSIG_E_EXTENSIBILITY = unchecked((int)0x800B0007);

        /// <summary>
        /// Unspecified cryptographic failure.
        /// </summary>
        public const int DIGSIG_E_CRYPTO = unchecked((int)0x800B0008);

        /// <summary>
        /// The size of the data could not be determined.
        /// </summary>
        public const int PERSIST_E_SIZEDEFINITE = unchecked((int)0x800B0009);

        /// <summary>
        /// The size of the indefinite-sized data could not be determined.
        /// </summary>
        public const int PERSIST_E_SIZEINDEFINITE = unchecked((int)0x800B000A);

        /// <summary>
        /// This object does not read and write self-sizing data.
        /// </summary>
        public const int PERSIST_E_NOTSELFSIZING = unchecked((int)0x800B000B);

        /// <summary>
        /// No signature was present in the subject.
        /// </summary>
        public const int TRUST_E_NOSIGNATURE = unchecked((int)0x800B0100);

        /// <summary>
        /// A required certificate is not within its validity period when verifying against the current system clock or the timestamp in the signed file.
        /// </summary>
        public const int CERT_E_EXPIRED = unchecked((int)0x800B0101);

        /// <summary>
        /// The validity periods of the certification chain do not nest correctly.
        /// </summary>
        public const int CERT_E_VALIDITYPERIODNESTING = unchecked((int)0x800B0102);

        /// <summary>
        /// A certificate that can only be used as an end-entity is being used as a CA or vice versa.
        /// </summary>
        public const int CERT_E_ROLE = unchecked((int)0x800B0103);

        /// <summary>
        /// A path length constraint in the certification chain has been violated.
        /// </summary>
        public const int CERT_E_PATHLENCONST = unchecked((int)0x800B0104);

        /// <summary>
        /// A certificate contains an unknown extension that is marked 'critical'.
        /// </summary>
        public const int CERT_E_CRITICAL = unchecked((int)0x800B0105);

        /// <summary>
        /// A certificate being used for a purpose other than the ones specified by its CA.
        /// </summary>
        public const int CERT_E_PURPOSE = unchecked((int)0x800B0106);

        /// <summary>
        /// A parent of a given certificate in fact did not issue that child certificate.
        /// </summary>
        public const int CERT_E_ISSUERCHAINING = unchecked((int)0x800B0107);

        /// <summary>
        /// A certificate is missing or has an empty value for an important field, such as a subject or issuer name.
        /// </summary>
        public const int CERT_E_MALFORMED = unchecked((int)0x800B0108);

        /// <summary>
        /// A certificate chain processed, but terminated in a root certificate which is not trusted by the trust provider.
        /// </summary>
        public const int CERT_E_UNTRUSTEDROOT = unchecked((int)0x800B0109);

        /// <summary>
        /// A certificate chain could not be built to a trusted root authority.
        /// </summary>
        public const int CERT_E_CHAINING = unchecked((int)0x800B010A);

        /// <summary>
        /// Generic trust failure.
        /// </summary>
        public const int TRUST_E_FAIL = unchecked((int)0x800B010B);

        /// <summary>
        /// A certificate was explicitly revoked by its issuer.
        /// </summary>
        public const int CERT_E_REVOKED = unchecked((int)0x800B010C);

        /// <summary>
        /// The certification path terminates with the test root which is not trusted with the current policy settings.
        /// </summary>
        public const int CERT_E_UNTRUSTEDTESTROOT = unchecked((int)0x800B010D);

        /// <summary>
        /// The revocation process could not continue - the certificate(s) could not be checked.
        /// </summary>
        public const int CERT_E_REVOCATION_FAILURE = unchecked((int)0x800B010E);

        /// <summary>
        /// The certificate's CN name does not match the passed value.
        /// </summary>
        public const int CERT_E_CN_NO_MATCH = unchecked((int)0x800B010F);

        /// <summary>
        /// The certificate is not valid for the requested usage.
        /// </summary>
        public const int CERT_E_WRONG_USAGE = unchecked((int)0x800B0110);

        /// <summary>
        /// The certificate was explicitly marked as untrusted by the user.
        /// </summary>
        public const int TRUST_E_EXPLICIT_DISTRUST = unchecked((int)0x800B0111);

        /// <summary>
        /// A certification chain processed correctly, but one of the CA certificates is not trusted by the policy provider.
        /// </summary>
        public const int CERT_E_UNTRUSTEDCA = unchecked((int)0x800B0112);

        /// <summary>
        /// The certificate has invalid policy.
        /// </summary>
        public const int CERT_E_INVALID_POLICY = unchecked((int)0x800B0113);

        /// <summary>
        /// The certificate has an invalid name. The name is not included in the permitted list or is explicitly excluded.
        /// </summary>
        public const int CERT_E_INVALID_NAME = unchecked((int)0x800B0114);

        // *****************
        // FACILITY_MEDIASERVER
        // *****************
        //
        // Also known as FACILITY_MF and FACILITY_NS
        //
        // The error codes are defined in mferror.mc, dlnaerror.mc, nserror.mc, and neterror.mc
        //
        // *****************
        // FACILITY_SETUPAPI
        // *****************
        /// <summary>
        /// A non-empty line was encountered in the INF before the start of a section.
        /// </summary>
        public const int SPAPI_E_EXPECTED_SECTION_NAME = unchecked((int)0x800F0000);

        /// <summary>
        /// A section name marker in the INF is not complete, or does not exist on a line by itself.
        /// </summary>
        public const int SPAPI_E_BAD_SECTION_NAME_LINE = unchecked((int)0x800F0001);

        /// <summary>
        /// An INF section was encountered whose name exceeds the maximum section name length.
        /// </summary>
        public const int SPAPI_E_SECTION_NAME_TOO_LONG = unchecked((int)0x800F0002);

        /// <summary>
        /// The syntax of the INF is invalid.
        /// </summary>
        public const int SPAPI_E_GENERAL_SYNTAX = unchecked((int)0x800F0003);

        /// <summary>
        /// The style of the INF is different than what was requested.
        /// </summary>
        public const int SPAPI_E_WRONG_INF_STYLE = unchecked((int)0x800F0100);

        /// <summary>
        /// The required section was not found in the INF.
        /// </summary>
        public const int SPAPI_E_SECTION_NOT_FOUND = unchecked((int)0x800F0101);

        /// <summary>
        /// The required line was not found in the INF.
        /// </summary>
        public const int SPAPI_E_LINE_NOT_FOUND = unchecked((int)0x800F0102);

        /// <summary>
        /// The files affected by the installation of this file queue have not been backed up for uninstall.
        /// </summary>
        public const int SPAPI_E_NO_BACKUP = unchecked((int)0x800F0103);

        /// <summary>
        /// The INF or the device information set or element does not have an associated install class.
        /// </summary>
        public const int SPAPI_E_NO_ASSOCIATED_CLASS = unchecked((int)0x800F0200);

        /// <summary>
        /// The INF or the device information set or element does not match the specified install class.
        /// </summary>
        public const int SPAPI_E_CLASS_MISMATCH = unchecked((int)0x800F0201);

        /// <summary>
        /// An existing device was found that is a duplicate of the device being manually installed.
        /// </summary>
        public const int SPAPI_E_DUPLICATE_FOUND = unchecked((int)0x800F0202);

        /// <summary>
        /// There is no driver selected for the device information set or element.
        /// </summary>
        public const int SPAPI_E_NO_DRIVER_SELECTED = unchecked((int)0x800F0203);

        /// <summary>
        /// The requested device registry key does not exist.
        /// </summary>
        public const int SPAPI_E_KEY_DOES_NOT_EXIST = unchecked((int)0x800F0204);

        /// <summary>
        /// The device instance name is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_DEVINST_NAME = unchecked((int)0x800F0205);

        /// <summary>
        /// The install class is not present or is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_CLASS = unchecked((int)0x800F0206);

        /// <summary>
        /// The device instance cannot be created because it already exists.
        /// </summary>
        public const int SPAPI_E_DEVINST_ALREADY_EXISTS = unchecked((int)0x800F0207);

        /// <summary>
        /// The operation cannot be performed on a device information element that has not been registered.
        /// </summary>
        public const int SPAPI_E_DEVINFO_NOT_REGISTERED = unchecked((int)0x800F0208);

        /// <summary>
        /// The device property code is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_REG_PROPERTY = unchecked((int)0x800F0209);

        /// <summary>
        /// The INF from which a driver list is to be built does not exist.
        /// </summary>
        public const int SPAPI_E_NO_INF = unchecked((int)0x800F020A);

        /// <summary>
        /// The device instance does not exist in the hardware tree.
        /// </summary>
        public const int SPAPI_E_NO_SUCH_DEVINST = unchecked((int)0x800F020B);

        /// <summary>
        /// The icon representing this install class cannot be loaded.
        /// </summary>
        public const int SPAPI_E_CANT_LOAD_CLASS_ICON = unchecked((int)0x800F020C);

        /// <summary>
        /// The class installer registry entry is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_CLASS_INSTALLER = unchecked((int)0x800F020D);

        /// <summary>
        /// The class installer has indicated that the default action should be performed for this installation request.
        /// </summary>
        public const int SPAPI_E_DI_DO_DEFAULT = unchecked((int)0x800F020E);

        /// <summary>
        /// The operation does not require any files to be copied.
        /// </summary>
        public const int SPAPI_E_DI_NOFILECOPY = unchecked((int)0x800F020F);

        /// <summary>
        /// The specified hardware profile does not exist.
        /// </summary>
        public const int SPAPI_E_INVALID_HWPROFILE = unchecked((int)0x800F0210);

        /// <summary>
        /// There is no device information element currently selected for this device information set.
        /// </summary>
        public const int SPAPI_E_NO_DEVICE_SELECTED = unchecked((int)0x800F0211);

        /// <summary>
        /// The operation cannot be performed because the device information set is locked.
        /// </summary>
        public const int SPAPI_E_DEVINFO_LIST_LOCKED = unchecked((int)0x800F0212);

        /// <summary>
        /// The operation cannot be performed because the device information element is locked.
        /// </summary>
        public const int SPAPI_E_DEVINFO_DATA_LOCKED = unchecked((int)0x800F0213);

        /// <summary>
        /// The specified path does not contain any applicable device INFs.
        /// </summary>
        public const int SPAPI_E_DI_BAD_PATH = unchecked((int)0x800F0214);

        /// <summary>
        /// No class installer parameters have been set for the device information set or element.
        /// </summary>
        public const int SPAPI_E_NO_CLASSINSTALL_PARAMS = unchecked((int)0x800F0215);

        /// <summary>
        /// The operation cannot be performed because the file queue is locked.
        /// </summary>
        public const int SPAPI_E_FILEQUEUE_LOCKED = unchecked((int)0x800F0216);

        /// <summary>
        /// A service installation section in this INF is invalid.
        /// </summary>
        public const int SPAPI_E_BAD_SERVICE_INSTALLSECT = unchecked((int)0x800F0217);

        /// <summary>
        /// There is no class driver list for the device information element.
        /// </summary>
        public const int SPAPI_E_NO_CLASS_DRIVER_LIST = unchecked((int)0x800F0218);

        /// <summary>
        /// The installation failed because a function driver was not specified for this device instance.
        /// </summary>
        public const int SPAPI_E_NO_ASSOCIATED_SERVICE = unchecked((int)0x800F0219);

        /// <summary>
        /// There is presently no default device interface designated for this interface class.
        /// </summary>
        public const int SPAPI_E_NO_DEFAULT_DEVICE_INTERFACE = unchecked((int)0x800F021A);

        /// <summary>
        /// The operation cannot be performed because the device interface is currently active.
        /// </summary>
        public const int SPAPI_E_DEVICE_INTERFACE_ACTIVE = unchecked((int)0x800F021B);

        /// <summary>
        /// The operation cannot be performed because the device interface has been removed from the system.
        /// </summary>
        public const int SPAPI_E_DEVICE_INTERFACE_REMOVED = unchecked((int)0x800F021C);

        /// <summary>
        /// An interface installation section in this INF is invalid.
        /// </summary>
        public const int SPAPI_E_BAD_INTERFACE_INSTALLSECT = unchecked((int)0x800F021D);

        /// <summary>
        /// This interface class does not exist in the system.
        /// </summary>
        public const int SPAPI_E_NO_SUCH_INTERFACE_CLASS = unchecked((int)0x800F021E);

        /// <summary>
        /// The reference string supplied for this interface device is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_REFERENCE_STRING = unchecked((int)0x800F021F);

        /// <summary>
        /// The specified machine name does not conform to UNC naming conventions.
        /// </summary>
        public const int SPAPI_E_INVALID_MACHINENAME = unchecked((int)0x800F0220);

        /// <summary>
        /// A general remote communication error occurred.
        /// </summary>
        public const int SPAPI_E_REMOTE_COMM_FAILURE = unchecked((int)0x800F0221);

        /// <summary>
        /// The machine selected for remote communication is not available at this time.
        /// </summary>
        public const int SPAPI_E_MACHINE_UNAVAILABLE = unchecked((int)0x800F0222);

        /// <summary>
        /// The Plug and Play service is not available on the remote machine.
        /// </summary>
        public const int SPAPI_E_NO_CONFIGMGR_SERVICES = unchecked((int)0x800F0223);

        /// <summary>
        /// The property page provider registry entry is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_PROPPAGE_PROVIDER = unchecked((int)0x800F0224);

        /// <summary>
        /// The requested device interface is not present in the system.
        /// </summary>
        public const int SPAPI_E_NO_SUCH_DEVICE_INTERFACE = unchecked((int)0x800F0225);

        /// <summary>
        /// The device's co-installer has additional work to perform after installation is complete.
        /// </summary>
        public const int SPAPI_E_DI_POSTPROCESSING_REQUIRED = unchecked((int)0x800F0226);

        /// <summary>
        /// The device's co-installer is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_COINSTALLER = unchecked((int)0x800F0227);

        /// <summary>
        /// There are no compatible drivers for this device.
        /// </summary>
        public const int SPAPI_E_NO_COMPAT_DRIVERS = unchecked((int)0x800F0228);

        /// <summary>
        /// There is no icon that represents this device or device type.
        /// </summary>
        public const int SPAPI_E_NO_DEVICE_ICON = unchecked((int)0x800F0229);

        /// <summary>
        /// A logical configuration specified in this INF is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_INF_LOGCONFIG = unchecked((int)0x800F022A);

        /// <summary>
        /// The class installer has denied the request to install or upgrade this device.
        /// </summary>
        public const int SPAPI_E_DI_DONT_INSTALL = unchecked((int)0x800F022B);

        /// <summary>
        /// One of the filter drivers installed for this device is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_FILTER_DRIVER = unchecked((int)0x800F022C);

        /// <summary>
        /// The driver selected for this device does not support this version of Windows.
        /// </summary>
        public const int SPAPI_E_NON_WINDOWS_NT_DRIVER = unchecked((int)0x800F022D);

        /// <summary>
        /// The driver selected for this device does not support Windows.
        /// </summary>
        public const int SPAPI_E_NON_WINDOWS_DRIVER = unchecked((int)0x800F022E);

        /// <summary>
        /// The third-party INF does not contain digital signature information.
        /// </summary>
        public const int SPAPI_E_NO_CATALOG_FOR_OEM_INF = unchecked((int)0x800F022F);

        /// <summary>
        /// An invalid attempt was made to use a device installation file queue for verification of digital signatures relative to other platforms.
        /// </summary>
        public const int SPAPI_E_DEVINSTALL_QUEUE_NONNATIVE = unchecked((int)0x800F0230);

        /// <summary>
        /// The device cannot be disabled.
        /// </summary>
        public const int SPAPI_E_NOT_DISABLEABLE = unchecked((int)0x800F0231);

        /// <summary>
        /// The device could not be dynamically removed.
        /// </summary>
        public const int SPAPI_E_CANT_REMOVE_DEVINST = unchecked((int)0x800F0232);

        /// <summary>
        /// Cannot copy to specified target.
        /// </summary>
        public const int SPAPI_E_INVALID_TARGET = unchecked((int)0x800F0233);

        /// <summary>
        /// Driver is not intended for this platform.
        /// </summary>
        public const int SPAPI_E_DRIVER_NONNATIVE = unchecked((int)0x800F0234);

        /// <summary>
        /// Operation not allowed in WOW64.
        /// </summary>
        public const int SPAPI_E_IN_WOW64 = unchecked((int)0x800F0235);

        /// <summary>
        /// The operation involving unsigned file copying was rolled back, so that a system restore point could be set.
        /// </summary>
        public const int SPAPI_E_SET_SYSTEM_RESTORE_POINT = unchecked((int)0x800F0236);

        /// <summary>
        /// An INF was copied into the Windows INF directory in an improper manner.
        /// </summary>
        public const int SPAPI_E_INCORRECTLY_COPIED_INF = unchecked((int)0x800F0237);

        /// <summary>
        /// The Security Configuration Editor (SCE) APIs have been disabled on this Embedded product.
        /// </summary>
        public const int SPAPI_E_SCE_DISABLED = unchecked((int)0x800F0238);

        /// <summary>
        /// An unknown exception was encountered.
        /// </summary>
        public const int SPAPI_E_UNKNOWN_EXCEPTION = unchecked((int)0x800F0239);

        /// <summary>
        /// A problem was encountered when accessing the Plug and Play registry database.
        /// </summary>
        public const int SPAPI_E_PNP_REGISTRY_ERROR = unchecked((int)0x800F023A);

        /// <summary>
        /// The requested operation is not supported for a remote machine.
        /// </summary>
        public const int SPAPI_E_REMOTE_REQUEST_UNSUPPORTED = unchecked((int)0x800F023B);

        /// <summary>
        /// The specified file is not an installed OEM INF.
        /// </summary>
        public const int SPAPI_E_NOT_AN_INSTALLED_OEM_INF = unchecked((int)0x800F023C);

        /// <summary>
        /// One or more devices are presently installed using the specified INF.
        /// </summary>
        public const int SPAPI_E_INF_IN_USE_BY_DEVICES = unchecked((int)0x800F023D);

        /// <summary>
        /// The requested device install operation is obsolete.
        /// </summary>
        public const int SPAPI_E_DI_FUNCTION_OBSOLETE = unchecked((int)0x800F023E);

        /// <summary>
        /// A file could not be verified because it does not have an associated catalog signed via Authenticode(tm).
        /// </summary>
        public const int SPAPI_E_NO_AUTHENTICODE_CATALOG = unchecked((int)0x800F023F);

        /// <summary>
        /// Authenticode(tm) signature verification is not supported for the specified INF.
        /// </summary>
        public const int SPAPI_E_AUTHENTICODE_DISALLOWED = unchecked((int)0x800F0240);

        /// <summary>
        /// The INF was signed with an Authenticode(tm) catalog from a trusted publisher.
        /// </summary>
        public const int SPAPI_E_AUTHENTICODE_TRUSTED_PUBLISHER = unchecked((int)0x800F0241);

        /// <summary>
        /// The publisher of an Authenticode(tm) signed catalog has not yet been established as trusted.
        /// </summary>
        public const int SPAPI_E_AUTHENTICODE_TRUST_NOT_ESTABLISHED = unchecked((int)0x800F0242);

        /// <summary>
        /// The publisher of an Authenticode(tm) signed catalog was not established as trusted.
        /// </summary>
        public const int SPAPI_E_AUTHENTICODE_PUBLISHER_NOT_TRUSTED = unchecked((int)0x800F0243);

        /// <summary>
        /// The software was tested for compliance with Windows Logo requirements on a different version of Windows, and may not be compatible with this version.
        /// </summary>
        public const int SPAPI_E_SIGNATURE_OSATTRIBUTE_MISMATCH = unchecked((int)0x800F0244);

        /// <summary>
        /// The file may only be validated by a catalog signed via Authenticode(tm).
        /// </summary>
        public const int SPAPI_E_ONLY_VALIDATE_VIA_AUTHENTICODE = unchecked((int)0x800F0245);

        /// <summary>
        /// One of the installers for this device cannot perform the installation at this time.
        /// </summary>
        public const int SPAPI_E_DEVICE_INSTALLER_NOT_READY = unchecked((int)0x800F0246);

        /// <summary>
        /// A problem was encountered while attempting to add the driver to the store.
        /// </summary>
        public const int SPAPI_E_DRIVER_STORE_ADD_FAILED = unchecked((int)0x800F0247);

        /// <summary>
        /// The installation of this device is forbidden by system policy. Contact your system administrator.
        /// </summary>
        public const int SPAPI_E_DEVICE_INSTALL_BLOCKED = unchecked((int)0x800F0248);

        /// <summary>
        /// The installation of this driver is forbidden by system policy. Contact your system administrator.
        /// </summary>
        public const int SPAPI_E_DRIVER_INSTALL_BLOCKED = unchecked((int)0x800F0249);

        /// <summary>
        /// The specified INF is the wrong type for this operation.
        /// </summary>
        public const int SPAPI_E_WRONG_INF_TYPE = unchecked((int)0x800F024A);

        /// <summary>
        /// The hash for the file is not present in the specified catalog file. The file is likely corrupt or the victim of tampering.
        /// </summary>
        public const int SPAPI_E_FILE_HASH_NOT_IN_CATALOG = unchecked((int)0x800F024B);

        /// <summary>
        /// A problem was encountered while attempting to delete the driver from the store.
        /// </summary>
        public const int SPAPI_E_DRIVER_STORE_DELETE_FAILED = unchecked((int)0x800F024C);

        /// <summary>
        /// An unrecoverable stack overflow was encountered.
        /// </summary>
        public const int SPAPI_E_UNRECOVERABLE_STACK_OVERFLOW = unchecked((int)0x800F0300);

        /// <summary>
        /// No installed components were detected.
        /// </summary>
        public const int SPAPI_E_ERROR_NOT_INSTALLED = unchecked((int)0x800F1000);

        // *****************
        // FACILITY_SCARD
        // *****************
        //

        // =============================
        // Facility SCARD Error Messages
        // =============================

        public const int SCARD_S_SUCCESS = NO_ERROR;
        /// <summary>
        /// An internal consistency check failed.
        /// </summary>
        public const int SCARD_F_INTERNAL_ERROR = unchecked((int)0x80100001);

        /// <summary>
        /// The action was cancelled by an SCardCancel request.
        /// </summary>
        public const int SCARD_E_CANCELLED = unchecked((int)0x80100002);

        /// <summary>
        /// The supplied handle was invalid.
        /// </summary>
        public const int SCARD_E_INVALID_HANDLE = unchecked((int)0x80100003);

        /// <summary>
        /// One or more of the supplied parameters could not be properly interpreted.
        /// </summary>
        public const int SCARD_E_INVALID_PARAMETER = unchecked((int)0x80100004);

        /// <summary>
        /// Registry startup information is missing or invalid.
        /// </summary>
        public const int SCARD_E_INVALID_TARGET = unchecked((int)0x80100005);

        /// <summary>
        /// Not enough memory available to complete this command.
        /// </summary>
        public const int SCARD_E_NO_MEMORY = unchecked((int)0x80100006);

        /// <summary>
        /// An internal consistency timer has expired.
        /// </summary>
        public const int SCARD_F_WAITED_TOO_LONG = unchecked((int)0x80100007);

        /// <summary>
        /// The data buffer to receive returned data is too small for the returned data.
        /// </summary>
        public const int SCARD_E_INSUFFICIENT_BUFFER = unchecked((int)0x80100008);

        /// <summary>
        /// The specified reader name is not recognized.
        /// </summary>
        public const int SCARD_E_UNKNOWN_READER = unchecked((int)0x80100009);

        /// <summary>
        /// The user-specified timeout value has expired.
        /// </summary>
        public const int SCARD_E_TIMEOUT = unchecked((int)0x8010000A);

        /// <summary>
        /// The smart card cannot be accessed because of other connections outstanding.
        /// </summary>
        public const int SCARD_E_SHARING_VIOLATION = unchecked((int)0x8010000B);

        /// <summary>
        /// The operation requires a smart card, but no smart card is currently in the device.
        /// </summary>
        public const int SCARD_E_NO_SMARTCARD = unchecked((int)0x8010000C);

        /// <summary>
        /// The specified smart card name is not recognized.
        /// </summary>
        public const int SCARD_E_UNKNOWN_CARD = unchecked((int)0x8010000D);

        /// <summary>
        /// The system could not dispose of the media in the requested manner.
        /// </summary>
        public const int SCARD_E_CANT_DISPOSE = unchecked((int)0x8010000E);

        /// <summary>
        /// The requested protocols are incompatible with the protocol currently in use with the smart card.
        /// </summary>
        public const int SCARD_E_PROTO_MISMATCH = unchecked((int)0x8010000F);

        /// <summary>
        /// The reader or smart card is not ready to accept commands.
        /// </summary>
        public const int SCARD_E_NOT_READY = unchecked((int)0x80100010);

        /// <summary>
        /// One or more of the supplied parameters values could not be properly interpreted.
        /// </summary>
        public const int SCARD_E_INVALID_VALUE = unchecked((int)0x80100011);

        /// <summary>
        /// The action was cancelled by the system, presumably to log off or shut down.
        /// </summary>
        public const int SCARD_E_SYSTEM_CANCELLED = unchecked((int)0x80100012);

        /// <summary>
        /// An internal communications error has been detected.
        /// </summary>
        public const int SCARD_F_COMM_ERROR = unchecked((int)0x80100013);

        /// <summary>
        /// An internal error has been detected, but the source is unknown.
        /// </summary>
        public const int SCARD_F_UNKNOWN_ERROR = unchecked((int)0x80100014);

        /// <summary>
        /// An ATR obtained from the registry is not a valid ATR string.
        /// </summary>
        public const int SCARD_E_INVALID_ATR = unchecked((int)0x80100015);

        /// <summary>
        /// An attempt was made to end a non-existent transaction.
        /// </summary>
        public const int SCARD_E_NOT_TRANSACTED = unchecked((int)0x80100016);

        /// <summary>
        /// The specified reader is not currently available for use.
        /// </summary>
        public const int SCARD_E_READER_UNAVAILABLE = unchecked((int)0x80100017);

        /// <summary>
        /// The operation has been aborted to allow the server application to exit.
        /// </summary>
        public const int SCARD_P_SHUTDOWN = unchecked((int)0x80100018);

        /// <summary>
        /// The PCI Receive buffer was too small.
        /// </summary>
        public const int SCARD_E_PCI_TOO_SMALL = unchecked((int)0x80100019);

        /// <summary>
        /// The reader driver does not meet minimal requirements for support.
        /// </summary>
        public const int SCARD_E_READER_UNSUPPORTED = unchecked((int)0x8010001A);

        /// <summary>
        /// The reader driver did not produce a unique reader name.
        /// </summary>
        public const int SCARD_E_DUPLICATE_READER = unchecked((int)0x8010001B);

        /// <summary>
        /// The smart card does not meet minimal requirements for support.
        /// </summary>
        public const int SCARD_E_CARD_UNSUPPORTED = unchecked((int)0x8010001C);

        /// <summary>
        /// The Smart Card Resource Manager is not running.
        /// </summary>
        public const int SCARD_E_NO_SERVICE = unchecked((int)0x8010001D);

        /// <summary>
        /// The Smart Card Resource Manager has shut down.
        /// </summary>
        public const int SCARD_E_SERVICE_STOPPED = unchecked((int)0x8010001E);

        /// <summary>
        /// An unexpected card error has occurred.
        /// </summary>
        public const int SCARD_E_UNEXPECTED = unchecked((int)0x8010001F);

        /// <summary>
        /// No Primary Provider can be found for the smart card.
        /// </summary>
        public const int SCARD_E_ICC_INSTALLATION = unchecked((int)0x80100020);

        /// <summary>
        /// The requested order of object creation is not supported.
        /// </summary>
        public const int SCARD_E_ICC_CREATEORDER = unchecked((int)0x80100021);

        /// <summary>
        /// This smart card does not support the requested feature.
        /// </summary>
        public const int SCARD_E_UNSUPPORTED_FEATURE = unchecked((int)0x80100022);

        /// <summary>
        /// The identified directory does not exist in the smart card.
        /// </summary>
        public const int SCARD_E_DIR_NOT_FOUND = unchecked((int)0x80100023);

        /// <summary>
        /// The identified file does not exist in the smart card.
        /// </summary>
        public const int SCARD_E_FILE_NOT_FOUND = unchecked((int)0x80100024);

        /// <summary>
        /// The supplied path does not represent a smart card directory.
        /// </summary>
        public const int SCARD_E_NO_DIR = unchecked((int)0x80100025);

        /// <summary>
        /// The supplied path does not represent a smart card file.
        /// </summary>
        public const int SCARD_E_NO_FILE = unchecked((int)0x80100026);

        /// <summary>
        /// Access is denied to this file.
        /// </summary>
        public const int SCARD_E_NO_ACCESS = unchecked((int)0x80100027);

        /// <summary>
        /// The smart card does not have enough memory to store the information.
        /// </summary>
        public const int SCARD_E_WRITE_TOO_MANY = unchecked((int)0x80100028);

        /// <summary>
        /// There was an error trying to set the smart card file object pointer.
        /// </summary>
        public const int SCARD_E_BAD_SEEK = unchecked((int)0x80100029);

        /// <summary>
        /// The supplied PIN is incorrect.
        /// </summary>
        public const int SCARD_E_INVALID_CHV = unchecked((int)0x8010002A);

        /// <summary>
        /// An unrecognized error code was returned from a layered component.
        /// </summary>
        public const int SCARD_E_UNKNOWN_RES_MNG = unchecked((int)0x8010002B);

        /// <summary>
        /// The requested certificate does not exist.
        /// </summary>
        public const int SCARD_E_NO_SUCH_CERTIFICATE = unchecked((int)0x8010002C);

        /// <summary>
        /// The requested certificate could not be obtained.
        /// </summary>
        public const int SCARD_E_CERTIFICATE_UNAVAILABLE = unchecked((int)0x8010002D);

        /// <summary>
        /// Cannot find a smart card reader.
        /// </summary>
        public const int SCARD_E_NO_READERS_AVAILABLE = unchecked((int)0x8010002E);

        /// <summary>
        /// A communications error with the smart card has been detected. Retry the operation.
        /// </summary>
        public const int SCARD_E_COMM_DATA_LOST = unchecked((int)0x8010002F);

        /// <summary>
        /// The requested key container does not exist on the smart card.
        /// </summary>
        public const int SCARD_E_NO_KEY_CONTAINER = unchecked((int)0x80100030);

        /// <summary>
        /// The Smart Card Resource Manager is too busy to complete this operation.
        /// </summary>
        public const int SCARD_E_SERVER_TOO_BUSY = unchecked((int)0x80100031);

        /// <summary>
        /// The smart card PIN cache has expired.
        /// </summary>
        public const int SCARD_E_PIN_CACHE_EXPIRED = unchecked((int)0x80100032);

        /// <summary>
        /// The smart card PIN cannot be cached.
        /// </summary>
        public const int SCARD_E_NO_PIN_CACHE = unchecked((int)0x80100033);

        /// <summary>
        /// The smart card is read only and cannot be written to.
        /// </summary>
        public const int SCARD_E_READ_ONLY_CARD = unchecked((int)0x80100034);

        //
        // These are warning codes.
        //
        /// <summary>
        /// The reader cannot communicate with the smart card, due to ATR configuration conflicts.
        /// </summary>
        public const int SCARD_W_UNSUPPORTED_CARD = unchecked((int)0x80100065);

        /// <summary>
        /// The smart card is not responding to a reset.
        /// </summary>
        public const int SCARD_W_UNRESPONSIVE_CARD = unchecked((int)0x80100066);

        /// <summary>
        /// Power has been removed from the smart card, so that further communication is not possible.
        /// </summary>
        public const int SCARD_W_UNPOWERED_CARD = unchecked((int)0x80100067);

        /// <summary>
        /// The smart card has been reset, so any shared state information is invalid.
        /// </summary>
        public const int SCARD_W_RESET_CARD = unchecked((int)0x80100068);

        /// <summary>
        /// The smart card has been removed, so that further communication is not possible.
        /// </summary>
        public const int SCARD_W_REMOVED_CARD = unchecked((int)0x80100069);

        /// <summary>
        /// Access was denied because of a security violation.
        /// </summary>
        public const int SCARD_W_SECURITY_VIOLATION = unchecked((int)0x8010006A);

        /// <summary>
        /// The card cannot be accessed because the wrong PIN was presented.
        /// </summary>
        public const int SCARD_W_WRONG_CHV = unchecked((int)0x8010006B);

        /// <summary>
        /// The card cannot be accessed because the maximum number of PIN entry attempts has been reached.
        /// </summary>
        public const int SCARD_W_CHV_BLOCKED = unchecked((int)0x8010006C);

        /// <summary>
        /// The end of the smart card file has been reached.
        /// </summary>
        public const int SCARD_W_EOF = unchecked((int)0x8010006D);

        /// <summary>
        /// The action was cancelled by the user.
        /// </summary>
        public const int SCARD_W_CANCELLED_BY_USER = unchecked((int)0x8010006E);

        /// <summary>
        /// No PIN was presented to the smart card.
        /// </summary>
        public const int SCARD_W_CARD_NOT_AUTHENTICATED = unchecked((int)0x8010006F);

        /// <summary>
        /// The requested item could not be found in the cache.
        /// </summary>
        public const int SCARD_W_CACHE_ITEM_NOT_FOUND = unchecked((int)0x80100070);

        /// <summary>
        /// The requested cache item is too old and was deleted from the cache.
        /// </summary>
        public const int SCARD_W_CACHE_ITEM_STALE = unchecked((int)0x80100071);

        /// <summary>
        /// The new cache item exceeds the maximum per-item size defined for the cache.
        /// </summary>
        public const int SCARD_W_CACHE_ITEM_TOO_BIG = unchecked((int)0x80100072);

        // *****************
        // FACILITY_COMPLUS
        // *****************
        //
        // ===============================
        // Facility COMPLUS Error Messages
        // ===============================
        //
        //
        // The following are the subranges  within the COMPLUS facility
        // 0x400 - 0x4ff               COMADMIN_E_CAT
        // 0x600 - 0x6ff               COMQC errors
        // 0x700 - 0x7ff               MSDTC errors
        // 0x800 - 0x8ff               Other COMADMIN errors
        //
        // COMPLUS Admin errors
        //
        /// <summary>
        /// Errors occurred accessing one or more objects - the ErrorInfo collection may have more detail
        /// </summary>
        public const int COMADMIN_E_OBJECTERRORS = unchecked((int)0x80110401);

        /// <summary>
        /// One or more of the object's properties are missing or invalid
        /// </summary>
        public const int COMADMIN_E_OBJECTINVALID = unchecked((int)0x80110402);

        /// <summary>
        /// The object was not found in the catalog
        /// </summary>
        public const int COMADMIN_E_KEYMISSING = unchecked((int)0x80110403);

        /// <summary>
        /// The object is already registered
        /// </summary>
        public const int COMADMIN_E_ALREADYINSTALLED = unchecked((int)0x80110404);

        /// <summary>
        /// Error occurred writing to the application file
        /// </summary>
        public const int COMADMIN_E_APP_FILE_WRITEFAIL = unchecked((int)0x80110407);

        /// <summary>
        /// Error occurred reading the application file
        /// </summary>
        public const int COMADMIN_E_APP_FILE_READFAIL = unchecked((int)0x80110408);

        /// <summary>
        /// Invalid version number in application file
        /// </summary>
        public const int COMADMIN_E_APP_FILE_VERSION = unchecked((int)0x80110409);

        /// <summary>
        /// The file path is invalid
        /// </summary>
        public const int COMADMIN_E_BADPATH = unchecked((int)0x8011040A);

        /// <summary>
        /// The application is already installed
        /// </summary>
        public const int COMADMIN_E_APPLICATIONEXISTS = unchecked((int)0x8011040B);

        /// <summary>
        /// The role already exists
        /// </summary>
        public const int COMADMIN_E_ROLEEXISTS = unchecked((int)0x8011040C);

        /// <summary>
        /// An error occurred copying the file
        /// </summary>
        public const int COMADMIN_E_CANTCOPYFILE = unchecked((int)0x8011040D);

        /// <summary>
        /// One or more users are not valid
        /// </summary>
        public const int COMADMIN_E_NOUSER = unchecked((int)0x8011040F);

        /// <summary>
        /// One or more users in the application file are not valid
        /// </summary>
        public const int COMADMIN_E_INVALIDUSERIDS = unchecked((int)0x80110410);

        /// <summary>
        /// The component's CLSID is missing or corrupt
        /// </summary>
        public const int COMADMIN_E_NOREGISTRYCLSID = unchecked((int)0x80110411);

        /// <summary>
        /// The component's progID is missing or corrupt
        /// </summary>
        public const int COMADMIN_E_BADREGISTRYPROGID = unchecked((int)0x80110412);

        /// <summary>
        /// Unable to set required authentication level for update request
        /// </summary>
        public const int COMADMIN_E_AUTHENTICATIONLEVEL = unchecked((int)0x80110413);

        /// <summary>
        /// The identity or password set on the application is not valid
        /// </summary>
        public const int COMADMIN_E_USERPASSWDNOTVALID = unchecked((int)0x80110414);

        /// <summary>
        /// Application file CLSIDs or IIDs do not match corresponding DLLs
        /// </summary>
        public const int COMADMIN_E_CLSIDORIIDMISMATCH = unchecked((int)0x80110418);

        /// <summary>
        /// Interface information is either missing or changed
        /// </summary>
        public const int COMADMIN_E_REMOTEINTERFACE = unchecked((int)0x80110419);

        /// <summary>
        /// DllRegisterServer failed on component install
        /// </summary>
        public const int COMADMIN_E_DLLREGISTERSERVER = unchecked((int)0x8011041A);

        /// <summary>
        /// No server file share available
        /// </summary>
        public const int COMADMIN_E_NOSERVERSHARE = unchecked((int)0x8011041B);

        /// <summary>
        /// DLL could not be loaded
        /// </summary>
        public const int COMADMIN_E_DLLLOADFAILED = unchecked((int)0x8011041D);

        /// <summary>
        /// The registered TypeLib ID is not valid
        /// </summary>
        public const int COMADMIN_E_BADREGISTRYLIBID = unchecked((int)0x8011041E);

        /// <summary>
        /// Application install directory not found
        /// </summary>
        public const int COMADMIN_E_APPDIRNOTFOUND = unchecked((int)0x8011041F);

        /// <summary>
        /// Errors occurred while in the component registrar
        /// </summary>
        public const int COMADMIN_E_REGISTRARFAILED = unchecked((int)0x80110423);

        /// <summary>
        /// The file does not exist
        /// </summary>
        public const int COMADMIN_E_COMPFILE_DOESNOTEXIST = unchecked((int)0x80110424);

        /// <summary>
        /// The DLL could not be loaded
        /// </summary>
        public const int COMADMIN_E_COMPFILE_LOADDLLFAIL = unchecked((int)0x80110425);

        /// <summary>
        /// GetClassObject failed in the DLL
        /// </summary>
        public const int COMADMIN_E_COMPFILE_GETCLASSOBJ = unchecked((int)0x80110426);

        /// <summary>
        /// The DLL does not support the components listed in the TypeLib
        /// </summary>
        public const int COMADMIN_E_COMPFILE_CLASSNOTAVAIL = unchecked((int)0x80110427);

        /// <summary>
        /// The TypeLib could not be loaded
        /// </summary>
        public const int COMADMIN_E_COMPFILE_BADTLB = unchecked((int)0x80110428);

        /// <summary>
        /// The file does not contain components or component information
        /// </summary>
        public const int COMADMIN_E_COMPFILE_NOTINSTALLABLE = unchecked((int)0x80110429);

        /// <summary>
        /// Changes to this object and its sub-objects have been disabled
        /// </summary>
        public const int COMADMIN_E_NOTCHANGEABLE = unchecked((int)0x8011042A);

        /// <summary>
        /// The delete function has been disabled for this object
        /// </summary>
        public const int COMADMIN_E_NOTDELETEABLE = unchecked((int)0x8011042B);

        /// <summary>
        /// The server catalog version is not supported
        /// </summary>
        public const int COMADMIN_E_SESSION = unchecked((int)0x8011042C);

        /// <summary>
        /// The component move was disallowed, because the source or destination application is either a system application or currently locked against changes
        /// </summary>
        public const int COMADMIN_E_COMP_MOVE_LOCKED = unchecked((int)0x8011042D);

        /// <summary>
        /// The component move failed because the destination application no longer exists
        /// </summary>
        public const int COMADMIN_E_COMP_MOVE_BAD_DEST = unchecked((int)0x8011042E);

        /// <summary>
        /// The system was unable to register the TypeLib
        /// </summary>
        public const int COMADMIN_E_REGISTERTLB = unchecked((int)0x80110430);

        /// <summary>
        /// This operation cannot be performed on the system application
        /// </summary>
        public const int COMADMIN_E_SYSTEMAPP = unchecked((int)0x80110433);

        /// <summary>
        /// The component registrar referenced in this file is not available
        /// </summary>
        public const int COMADMIN_E_COMPFILE_NOREGISTRAR = unchecked((int)0x80110434);

        /// <summary>
        /// A component in the same DLL is already installed
        /// </summary>
        public const int COMADMIN_E_COREQCOMPINSTALLED = unchecked((int)0x80110435);

        /// <summary>
        /// The service is not installed
        /// </summary>
        public const int COMADMIN_E_SERVICENOTINSTALLED = unchecked((int)0x80110436);

        /// <summary>
        /// One or more property settings are either invalid or in conflict with each other
        /// </summary>
        public const int COMADMIN_E_PROPERTYSAVEFAILED = unchecked((int)0x80110437);

        /// <summary>
        /// The object you are attempting to add or rename already exists
        /// </summary>
        public const int COMADMIN_E_OBJECTEXISTS = unchecked((int)0x80110438);

        /// <summary>
        /// The component already exists
        /// </summary>
        public const int COMADMIN_E_COMPONENTEXISTS = unchecked((int)0x80110439);

        /// <summary>
        /// The registration file is corrupt
        /// </summary>
        public const int COMADMIN_E_REGFILE_CORRUPT = unchecked((int)0x8011043B);

        /// <summary>
        /// The property value is too large
        /// </summary>
        public const int COMADMIN_E_PROPERTY_OVERFLOW = unchecked((int)0x8011043C);

        /// <summary>
        /// Object was not found in registry
        /// </summary>
        public const int COMADMIN_E_NOTINREGISTRY = unchecked((int)0x8011043E);

        /// <summary>
        /// This object is not poolable
        /// </summary>
        public const int COMADMIN_E_OBJECTNOTPOOLABLE = unchecked((int)0x8011043F);

        /// <summary>
        /// A CLSID with the same GUID as the new application ID is already installed on this machine
        /// </summary>
        public const int COMADMIN_E_APPLID_MATCHES_CLSID = unchecked((int)0x80110446);

        /// <summary>
        /// A role assigned to a component, interface, or method did not exist in the application
        /// </summary>
        public const int COMADMIN_E_ROLE_DOES_NOT_EXIST = unchecked((int)0x80110447);

        /// <summary>
        /// You must have components in an application in order to start the application
        /// </summary>
        public const int COMADMIN_E_START_APP_NEEDS_COMPONENTS = unchecked((int)0x80110448);

        /// <summary>
        /// This operation is not enabled on this platform
        /// </summary>
        public const int COMADMIN_E_REQUIRES_DIFFERENT_PLATFORM = unchecked((int)0x80110449);

        /// <summary>
        /// Application Proxy is not exportable
        /// </summary>
        public const int COMADMIN_E_CAN_NOT_EXPORT_APP_PROXY = unchecked((int)0x8011044A);

        /// <summary>
        /// Failed to start application because it is either a library application or an application proxy
        /// </summary>
        public const int COMADMIN_E_CAN_NOT_START_APP = unchecked((int)0x8011044B);

        /// <summary>
        /// System application is not exportable
        /// </summary>
        public const int COMADMIN_E_CAN_NOT_EXPORT_SYS_APP = unchecked((int)0x8011044C);

        /// <summary>
        /// Cannot subscribe to this component (the component may have been imported)
        /// </summary>
        public const int COMADMIN_E_CANT_SUBSCRIBE_TO_COMPONENT = unchecked((int)0x8011044D);

        /// <summary>
        /// An event class cannot also be a subscriber component
        /// </summary>
        public const int COMADMIN_E_EVENTCLASS_CANT_BE_SUBSCRIBER = unchecked((int)0x8011044E);

        /// <summary>
        /// Library applications and application proxies are incompatible
        /// </summary>
        public const int COMADMIN_E_LIB_APP_PROXY_INCOMPATIBLE = unchecked((int)0x8011044F);

        /// <summary>
        /// This function is valid for the base partition only
        /// </summary>
        public const int COMADMIN_E_BASE_PARTITION_ONLY = unchecked((int)0x80110450);

        /// <summary>
        /// You cannot start an application that has been disabled
        /// </summary>
        public const int COMADMIN_E_START_APP_DISABLED = unchecked((int)0x80110451);

        /// <summary>
        /// The specified partition name is already in use on this computer
        /// </summary>
        public const int COMADMIN_E_CAT_DUPLICATE_PARTITION_NAME = unchecked((int)0x80110457);

        /// <summary>
        /// The specified partition name is invalid. Check that the name contains at least one visible character
        /// </summary>
        public const int COMADMIN_E_CAT_INVALID_PARTITION_NAME = unchecked((int)0x80110458);

        /// <summary>
        /// The partition cannot be deleted because it is the default partition for one or more users
        /// </summary>
        public const int COMADMIN_E_CAT_PARTITION_IN_USE = unchecked((int)0x80110459);

        /// <summary>
        /// The partition cannot be exported, because one or more components in the partition have the same file name
        /// </summary>
        public const int COMADMIN_E_FILE_PARTITION_DUPLICATE_FILES = unchecked((int)0x8011045A);

        /// <summary>
        /// Applications that contain one or more imported components cannot be installed into a non-base partition
        /// </summary>
        public const int COMADMIN_E_CAT_IMPORTED_COMPONENTS_NOT_ALLOWED = unchecked((int)0x8011045B);

        /// <summary>
        /// The application name is not unique and cannot be resolved to an application id
        /// </summary>
        public const int COMADMIN_E_AMBIGUOUS_APPLICATION_NAME = unchecked((int)0x8011045C);

        /// <summary>
        /// The partition name is not unique and cannot be resolved to a partition id
        /// </summary>
        public const int COMADMIN_E_AMBIGUOUS_PARTITION_NAME = unchecked((int)0x8011045D);

        /// <summary>
        /// The COM+ registry database has not been initialized
        /// </summary>
        public const int COMADMIN_E_REGDB_NOTINITIALIZED = unchecked((int)0x80110472);

        /// <summary>
        /// The COM+ registry database is not open
        /// </summary>
        public const int COMADMIN_E_REGDB_NOTOPEN = unchecked((int)0x80110473);

        /// <summary>
        /// The COM+ registry database detected a system error
        /// </summary>
        public const int COMADMIN_E_REGDB_SYSTEMERR = unchecked((int)0x80110474);

        /// <summary>
        /// The COM+ registry database is already running
        /// </summary>
        public const int COMADMIN_E_REGDB_ALREADYRUNNING = unchecked((int)0x80110475);

        /// <summary>
        /// This version of the COM+ registry database cannot be migrated
        /// </summary>
        public const int COMADMIN_E_MIG_VERSIONNOTSUPPORTED = unchecked((int)0x80110480);

        /// <summary>
        /// The schema version to be migrated could not be found in the COM+ registry database
        /// </summary>
        public const int COMADMIN_E_MIG_SCHEMANOTFOUND = unchecked((int)0x80110481);

        /// <summary>
        /// There was a type mismatch between binaries
        /// </summary>
        public const int COMADMIN_E_CAT_BITNESSMISMATCH = unchecked((int)0x80110482);

        /// <summary>
        /// A binary of unknown or invalid type was provided
        /// </summary>
        public const int COMADMIN_E_CAT_UNACCEPTABLEBITNESS = unchecked((int)0x80110483);

        /// <summary>
        /// There was a type mismatch between a binary and an application
        /// </summary>
        public const int COMADMIN_E_CAT_WRONGAPPBITNESS = unchecked((int)0x80110484);

        /// <summary>
        /// The application cannot be paused or resumed
        /// </summary>
        public const int COMADMIN_E_CAT_PAUSE_RESUME_NOT_SUPPORTED = unchecked((int)0x80110485);

        /// <summary>
        /// The COM+ Catalog Server threw an exception during execution
        /// </summary>
        public const int COMADMIN_E_CAT_SERVERFAULT = unchecked((int)0x80110486);

        //
        // COMPLUS Queued component errors
        //
        /// <summary>
        /// Only COM+ Applications marked "queued" can be invoked using the "queue" moniker
        /// </summary>
        public const int COMQC_E_APPLICATION_NOT_QUEUED = unchecked((int)0x80110600);

        /// <summary>
        /// At least one interface must be marked "queued" in order to create a queued component instance with the "queue" moniker
        /// </summary>
        public const int COMQC_E_NO_QUEUEABLE_INTERFACES = unchecked((int)0x80110601);

        /// <summary>
        /// MSMQ is required for the requested operation and is not installed
        /// </summary>
        public const int COMQC_E_QUEUING_SERVICE_NOT_AVAILABLE = unchecked((int)0x80110602);

        /// <summary>
        /// Unable to marshal an interface that does not support IPersistStream
        /// </summary>
        public const int COMQC_E_NO_IPERSISTSTREAM = unchecked((int)0x80110603);

        /// <summary>
        /// The message is improperly formatted or was damaged in transit
        /// </summary>
        public const int COMQC_E_BAD_MESSAGE = unchecked((int)0x80110604);

        /// <summary>
        /// An unauthenticated message was received by an application that accepts only authenticated messages
        /// </summary>
        public const int COMQC_E_UNAUTHENTICATED = unchecked((int)0x80110605);

        /// <summary>
        /// The message was requeued or moved by a user not in the "QC Trusted User" role
        /// </summary>
        public const int COMQC_E_UNTRUSTED_ENQUEUER = unchecked((int)0x80110606);

        //
        // The range 0x700-0x7ff is reserved for MSDTC errors.
        //
        /// <summary>
        /// Cannot create a duplicate resource of type Distributed Transaction Coordinator
        /// </summary>
        public const int MSDTC_E_DUPLICATE_RESOURCE = unchecked((int)0x80110701);

        //
        // More COMADMIN errors from 0x8**
        //
        /// <summary>
        /// One of the objects being inserted or updated does not belong to a valid parent collection
        /// </summary>
        public const int COMADMIN_E_OBJECT_PARENT_MISSING = unchecked((int)0x80110808);

        /// <summary>
        /// One of the specified objects cannot be found
        /// </summary>
        public const int COMADMIN_E_OBJECT_DOES_NOT_EXIST = unchecked((int)0x80110809);

        /// <summary>
        /// The specified application is not currently running
        /// </summary>
        public const int COMADMIN_E_APP_NOT_RUNNING = unchecked((int)0x8011080A);

        /// <summary>
        /// The partition(s) specified are not valid.
        /// </summary>
        public const int COMADMIN_E_INVALID_PARTITION = unchecked((int)0x8011080B);

        /// <summary>
        /// COM+ applications that run as NT service may not be pooled or recycled
        /// </summary>
        public const int COMADMIN_E_SVCAPP_NOT_POOLABLE_OR_RECYCLABLE = unchecked((int)0x8011080D);

        /// <summary>
        /// One or more users are already assigned to a local partition set.
        /// </summary>
        public const int COMADMIN_E_USER_IN_SET = unchecked((int)0x8011080E);

        /// <summary>
        /// Library applications may not be recycled.
        /// </summary>
        public const int COMADMIN_E_CANTRECYCLELIBRARYAPPS = unchecked((int)0x8011080F);

        /// <summary>
        /// Applications running as NT services may not be recycled.
        /// </summary>
        public const int COMADMIN_E_CANTRECYCLESERVICEAPPS = unchecked((int)0x80110811);

        /// <summary>
        /// The process has already been recycled.
        /// </summary>
        public const int COMADMIN_E_PROCESSALREADYRECYCLED = unchecked((int)0x80110812);

        /// <summary>
        /// A paused process may not be recycled.
        /// </summary>
        public const int COMADMIN_E_PAUSEDPROCESSMAYNOTBERECYCLED = unchecked((int)0x80110813);

        /// <summary>
        /// Library applications may not be NT services.
        /// </summary>
        public const int COMADMIN_E_CANTMAKEINPROCSERVICE = unchecked((int)0x80110814);

        /// <summary>
        /// The ProgID provided to the copy operation is invalid. The ProgID is in use by another registered CLSID.
        /// </summary>
        public const int COMADMIN_E_PROGIDINUSEBYCLSID = unchecked((int)0x80110815);

        /// <summary>
        /// The partition specified as default is not a member of the partition set.
        /// </summary>
        public const int COMADMIN_E_DEFAULT_PARTITION_NOT_IN_SET = unchecked((int)0x80110816);

        /// <summary>
        /// A recycled process may not be paused.
        /// </summary>
        public const int COMADMIN_E_RECYCLEDPROCESSMAYNOTBEPAUSED = unchecked((int)0x80110817);

        /// <summary>
        /// Access to the specified partition is denied.
        /// </summary>
        public const int COMADMIN_E_PARTITION_ACCESSDENIED = unchecked((int)0x80110818);

        /// <summary>
        /// Only Application Files (*.MSI files) can be installed into partitions.
        /// </summary>
        public const int COMADMIN_E_PARTITION_MSI_ONLY = unchecked((int)0x80110819);

        /// <summary>
        /// Applications containing one or more legacy components may not be exported to 1.0 format.
        /// </summary>
        public const int COMADMIN_E_LEGACYCOMPS_NOT_ALLOWED_IN_1_0_FORMAT = unchecked((int)0x8011081A);

        /// <summary>
        /// Legacy components may not exist in non-base partitions.
        /// </summary>
        public const int COMADMIN_E_LEGACYCOMPS_NOT_ALLOWED_IN_NONBASE_PARTITIONS = unchecked((int)0x8011081B);

        /// <summary>
        /// A component cannot be moved (or copied) from the System Application, an application proxy or a non-changeable application
        /// </summary>
        public const int COMADMIN_E_COMP_MOVE_SOURCE = unchecked((int)0x8011081C);

        /// <summary>
        /// A component cannot be moved (or copied) to the System Application, an application proxy or a non-changeable application
        /// </summary>
        public const int COMADMIN_E_COMP_MOVE_DEST = unchecked((int)0x8011081D);

        /// <summary>
        /// A private component cannot be moved (or copied) to a library application or to the base partition
        /// </summary>
        public const int COMADMIN_E_COMP_MOVE_PRIVATE = unchecked((int)0x8011081E);

        /// <summary>
        /// The Base Application Partition exists in all partition sets and cannot be removed.
        /// </summary>
        public const int COMADMIN_E_BASEPARTITION_REQUIRED_IN_SET = unchecked((int)0x8011081F);

        /// <summary>
        /// Alas, Event Class components cannot be aliased.
        /// </summary>
        public const int COMADMIN_E_CANNOT_ALIAS_EVENTCLASS = unchecked((int)0x80110820);

        /// <summary>
        /// Access is denied because the component is private.
        /// </summary>
        public const int COMADMIN_E_PRIVATE_ACCESSDENIED = unchecked((int)0x80110821);

        /// <summary>
        /// The specified SAFER level is invalid.
        /// </summary>
        public const int COMADMIN_E_SAFERINVALID = unchecked((int)0x80110822);

        /// <summary>
        /// The specified user cannot write to the system registry
        /// </summary>
        public const int COMADMIN_E_REGISTRY_ACCESSDENIED = unchecked((int)0x80110823);

        /// <summary>
        /// COM+ partitions are currently disabled.
        /// </summary>
        public const int COMADMIN_E_PARTITIONS_DISABLED = unchecked((int)0x80110824);

        //
        // FACILITY_WER
        //
        /// <summary>
        /// Debugger was attached.
        /// </summary>
        public const int WER_S_REPORT_DEBUG = 0x001B0000;

        /// <summary>
        /// Report was uploaded.
        /// </summary>
        public const int WER_S_REPORT_UPLOADED = 0x001B0001;

        /// <summary>
        /// Report was queued.
        /// </summary>
        public const int WER_S_REPORT_QUEUED = 0x001B0002;

        /// <summary>
        /// Reporting was disabled.
        /// </summary>
        public const int WER_S_DISABLED = 0x001B0003;

        /// <summary>
        /// Reporting was temporarily suspended.
        /// </summary>
        public const int WER_S_SUSPENDED_UPLOAD = 0x001B0004;

        /// <summary>
        /// Report was not queued to queueing being disabled.
        /// </summary>
        public const int WER_S_DISABLED_QUEUE = 0x001B0005;

        /// <summary>
        /// Report was uploaded, but not archived due to archiving being disabled.
        /// </summary>
        public const int WER_S_DISABLED_ARCHIVE = 0x001B0006;

        /// <summary>
        /// Reporting was successfully spun off as an asynchronous operation.
        /// </summary>
        public const int WER_S_REPORT_ASYNC = 0x001B0007;

        /// <summary>
        /// The assertion was handled.
        /// </summary>
        public const int WER_S_IGNORE_ASSERT_INSTANCE = 0x001B0008;

        /// <summary>
        /// The assertion was handled and added to a permanent ignore list.
        /// </summary>
        public const int WER_S_IGNORE_ALL_ASSERTS = 0x001B0009;

        /// <summary>
        /// The assertion was resumed as unhandled.
        /// </summary>
        public const int WER_S_ASSERT_CONTINUE = 0x001B000A;

        /// <summary>
        /// Report was throttled.
        /// </summary>
        public const int WER_S_THROTTLED = 0x001B000B;

        /// <summary>
        /// Report was uploaded with cab.
        /// </summary>
        public const int WER_S_REPORT_UPLOADED_CAB = 0x001B000C;

        /// <summary>
        /// Crash reporting failed.
        /// </summary>
        public const int WER_E_CRASH_FAILURE = unchecked((int)0x801B8000);

        /// <summary>
        /// Report aborted due to user cancelation.
        /// </summary>
        public const int WER_E_CANCELED = unchecked((int)0x801B8001);

        /// <summary>
        /// Report aborted due to network failure.
        /// </summary>
        public const int WER_E_NETWORK_FAILURE = unchecked((int)0x801B8002);

        /// <summary>
        /// Report not initialized.
        /// </summary>
        public const int WER_E_NOT_INITIALIZED = unchecked((int)0x801B8003);

        /// <summary>
        /// Reporting is already in progress for the specified process.
        /// </summary>
        public const int WER_E_ALREADY_REPORTING = unchecked((int)0x801B8004);

        /// <summary>
        /// Dump not generated due to a throttle.
        /// </summary>
        public const int WER_E_DUMP_THROTTLED = unchecked((int)0x801B8005);

        /// <summary>
        /// Operation failed due to insufficient user consent.
        /// </summary>
        public const int WER_E_INSUFFICIENT_CONSENT = unchecked((int)0x801B8006);

        /// <summary>
        /// Report aborted due to performance criteria.
        /// </summary>
        public const int WER_E_TOO_HEAVY = unchecked((int)0x801B8007);

        // ***********************
        // FACILITY_USERMODE_FILTER_MANAGER
        // ***********************
        /// <summary>
        /// The IO was completed by a filter.
        /// </summary>
        public const int ERROR_FLT_IO_COMPLETE = 0x001F0001;

        /// <summary>
        /// A handler was not defined by the filter for this operation.
        /// </summary>
        public const int ERROR_FLT_NO_HANDLER_DEFINED = unchecked((int)0x801F0001);

        /// <summary>
        /// A context is already defined for this object.
        /// </summary>
        public const int ERROR_FLT_CONTEXT_ALREADY_DEFINED = unchecked((int)0x801F0002);

        /// <summary>
        /// Asynchronous requests are not valid for this operation.
        /// </summary>
        public const int ERROR_FLT_INVALID_ASYNCHRONOUS_REQUEST = unchecked((int)0x801F0003);

        /// <summary>
        /// Disallow the Fast IO path for this operation.
        /// </summary>
        public const int ERROR_FLT_DISALLOW_FAST_IO = unchecked((int)0x801F0004);

        /// <summary>
        /// An invalid name request was made. The name requested cannot be retrieved at this time.
        /// </summary>
        public const int ERROR_FLT_INVALID_NAME_REQUEST = unchecked((int)0x801F0005);

        /// <summary>
        /// Posting this operation to a worker thread for further processing is not safe at this time because it could lead to a system deadlock.
        /// </summary>
        public const int ERROR_FLT_NOT_SAFE_TO_POST_OPERATION = unchecked((int)0x801F0006);

        /// <summary>
        /// The Filter Manager was not initialized when a filter tried to register. Make sure that the Filter Manager is getting loaded as a driver.
        /// </summary>
        public const int ERROR_FLT_NOT_INITIALIZED = unchecked((int)0x801F0007);

        /// <summary>
        /// The filter is not ready for attachment to volumes because it has not finished initializing (FltStartFiltering has not been called).
        /// </summary>
        public const int ERROR_FLT_FILTER_NOT_READY = unchecked((int)0x801F0008);

        /// <summary>
        /// The filter must cleanup any operation specific context at this time because it is being removed from the system before the operation is completed by the lower drivers.
        /// </summary>
        public const int ERROR_FLT_POST_OPERATION_CLEANUP = unchecked((int)0x801F0009);

        /// <summary>
        /// The Filter Manager had an internal error from which it cannot recover, therefore the operation has been failed. This is usually the result of a filter returning an invalid value from a pre-operation callback.
        /// </summary>
        public const int ERROR_FLT_INTERNAL_ERROR = unchecked((int)0x801F000A);

        /// <summary>
        /// The object specified for this action is in the process of being deleted, therefore the action requested cannot be completed at this time.
        /// </summary>
        public const int ERROR_FLT_DELETING_OBJECT = unchecked((int)0x801F000B);

        /// <summary>
        /// Non-paged pool must be used for this type of context.
        /// </summary>
        public const int ERROR_FLT_MUST_BE_NONPAGED_POOL = unchecked((int)0x801F000C);

        /// <summary>
        /// A duplicate handler definition has been provided for an operation.
        /// </summary>
        public const int ERROR_FLT_DUPLICATE_ENTRY = unchecked((int)0x801F000D);

        /// <summary>
        /// The callback data queue has been disabled.
        /// </summary>
        public const int ERROR_FLT_CBDQ_DISABLED = unchecked((int)0x801F000E);

        /// <summary>
        /// Do not attach the filter to the volume at this time.
        /// </summary>
        public const int ERROR_FLT_DO_NOT_ATTACH = unchecked((int)0x801F000F);

        /// <summary>
        /// Do not detach the filter from the volume at this time.
        /// </summary>
        public const int ERROR_FLT_DO_NOT_DETACH = unchecked((int)0x801F0010);

        /// <summary>
        /// An instance already exists at this altitude on the volume specified.
        /// </summary>
        public const int ERROR_FLT_INSTANCE_ALTITUDE_COLLISION = unchecked((int)0x801F0011);

        /// <summary>
        /// An instance already exists with this name on the volume specified.
        /// </summary>
        public const int ERROR_FLT_INSTANCE_NAME_COLLISION = unchecked((int)0x801F0012);

        /// <summary>
        /// The system could not find the filter specified.
        /// </summary>
        public const int ERROR_FLT_FILTER_NOT_FOUND = unchecked((int)0x801F0013);

        /// <summary>
        /// The system could not find the volume specified.
        /// </summary>
        public const int ERROR_FLT_VOLUME_NOT_FOUND = unchecked((int)0x801F0014);

        /// <summary>
        /// The system could not find the instance specified.
        /// </summary>
        public const int ERROR_FLT_INSTANCE_NOT_FOUND = unchecked((int)0x801F0015);

        /// <summary>
        /// No registered context allocation definition was found for the given request.
        /// </summary>
        public const int ERROR_FLT_CONTEXT_ALLOCATION_NOT_FOUND = unchecked((int)0x801F0016);

        /// <summary>
        /// An invalid parameter was specified during context registration.
        /// </summary>
        public const int ERROR_FLT_INVALID_CONTEXT_REGISTRATION = unchecked((int)0x801F0017);

        /// <summary>
        /// The name requested was not found in Filter Manager's name cache and could not be retrieved from the file system.
        /// </summary>
        public const int ERROR_FLT_NAME_CACHE_MISS = unchecked((int)0x801F0018);

        /// <summary>
        /// The requested device object does not exist for the given volume.
        /// </summary>
        public const int ERROR_FLT_NO_DEVICE_OBJECT = unchecked((int)0x801F0019);

        /// <summary>
        /// The specified volume is already mounted.
        /// </summary>
        public const int ERROR_FLT_VOLUME_ALREADY_MOUNTED = unchecked((int)0x801F001A);

        /// <summary>
        /// The specified Transaction Context is already enlisted in a transaction
        /// </summary>
        public const int ERROR_FLT_ALREADY_ENLISTED = unchecked((int)0x801F001B);

        /// <summary>
        /// The specifiec context is already attached to another object
        /// </summary>
        public const int ERROR_FLT_CONTEXT_ALREADY_LINKED = unchecked((int)0x801F001C);

        /// <summary>
        /// No waiter is present for the filter's reply to this message.
        /// </summary>
        public const int ERROR_FLT_NO_WAITER_FOR_REPLY = unchecked((int)0x801F0020);

        /// <summary>
        /// The filesystem database resource is in use. Registration cannot complete at this time.
        /// </summary>
        public const int ERROR_FLT_REGISTRATION_BUSY = unchecked((int)0x801F0023);

        //
        // ===============================
        // Facility Graphics Error Messages
        // ===============================
        //
        //
        // The following are the subranges within the Graphics facility
        //
        // 0x0000 - 0x0fff     Display Driver Loader driver & Video Port errors (displdr.sys, videoprt.sys)
        // 0x1000 - 0x1fff     Monitor Class Function driver errors             (monitor.sys)
        // 0x2000 - 0x2fff     Windows Graphics Kernel Subsystem errors         (dxgkrnl.sys)
        // 0x3000 - 0x3fff               Desktop Window Manager errors
        //   0x2000 - 0x20ff      Common errors
        //   0x2100 - 0x21ff      Video Memory Manager (VidMM) subsystem errors
        //   0x2200 - 0x22ff      Video GPU Scheduler (VidSch) subsystem errors
        //   0x2300 - 0x23ff      Video Display Mode Management (VidDMM) subsystem errors
        //
        // Display Driver Loader driver & Video Port errors {0x0000..0x0fff}
        //
        /// <summary>
        /// {Display Driver Stopped Responding}
        /// The %hs display driver has stopped working normally. Save your work and reboot the system to restore full display functionality.
        /// The next time you reboot the machine a dialog will be displayed giving you a chance to report this failure to Microsoft.
        /// </summary>
        public const int ERROR_HUNG_DISPLAY_DRIVER_THREAD = unchecked((int)0x80260001);

        //
        // Desktop Window Manager errors {0x3000..0x3fff}
        //
        /// <summary>
        /// {Desktop composition is disabled}
        /// The operation could not be completed because desktop composition is disabled.
        /// </summary>
        public const int DWM_E_COMPOSITIONDISABLED = unchecked((int)0x80263001);

        /// <summary>
        /// {Some desktop composition APIs are not supported while remoting}
        /// The operation is not supported while running in a remote session.
        /// </summary>
        public const int DWM_E_REMOTING_NOT_SUPPORTED = unchecked((int)0x80263002);

        /// <summary>
        /// {No DWM redirection surface is available}
        /// The DWM was unable to provide a redireciton surface to complete the DirectX present.
        /// </summary>
        public const int DWM_E_NO_REDIRECTION_SURFACE_AVAILABLE = unchecked((int)0x80263003);

        /// <summary>
        /// {DWM is not queuing presents for the specified window}
        /// The window specified is not currently using queued presents.
        /// </summary>
        public const int DWM_E_NOT_QUEUING_PRESENTS = unchecked((int)0x80263004);

        /// <summary>
        /// {The adapter specified by the LUID is not found}
        /// DWM can not find the adapter specified by the LUID.
        /// </summary>
        public const int DWM_E_ADAPTER_NOT_FOUND = unchecked((int)0x80263005);

        /// <summary>
        /// {GDI redirection surface was returned}
        /// GDI redirection surface of the top level window was returned.
        /// </summary>
        public const int DWM_S_GDI_REDIRECTION_SURFACE = 0x00263005;

        /// <summary>
        /// {Redirection surface can not be created.  The size of the surface is larger than what is supported on this machine}
        /// Redirection surface can not be created.  The size of the surface is larger than what is supported on this machine.
        /// </summary>
        public const int DWM_E_TEXTURE_TOO_LARGE = unchecked((int)0x80263007);

        /// <summary>
        /// {GDI redirection surface is either on a different adapter or in system memory. Perform blt via GDI}
        /// GDI redirection surface is either on a different adapter or in system memory. Perform blt via GDI.
        /// </summary>
        public const int DWM_S_GDI_REDIRECTION_SURFACE_BLT_VIA_GDI = 0x00263008;

        //
        // Monitor class function driver errors {0x1000..0x1fff}
        //
        /// <summary>
        /// Monitor descriptor could not be obtained.
        /// </summary>
        public const int ERROR_MONITOR_NO_DESCRIPTOR = 0x00261001;

        /// <summary>
        /// Format of the obtained monitor descriptor is not supported by this release.
        /// </summary>
        public const int ERROR_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT = 0x00261002;

        /// <summary>
        /// Checksum of the obtained monitor descriptor is invalid.
        /// </summary>
        public const int ERROR_MONITOR_INVALID_DESCRIPTOR_CHECKSUM = unchecked((int)0xC0261003);

        /// <summary>
        /// Monitor descriptor contains an invalid standard timing block.
        /// </summary>
        public const int ERROR_MONITOR_INVALID_STANDARD_TIMING_BLOCK = unchecked((int)0xC0261004);

        /// <summary>
        /// WMI data block registration failed for one of the MSMonitorClass WMI subclasses.
        /// </summary>
        public const int ERROR_MONITOR_WMI_DATABLOCK_REGISTRATION_FAILED = unchecked((int)0xC0261005);

        /// <summary>
        /// Provided monitor descriptor block is either corrupted or does not contain monitor's detailed serial number.
        /// </summary>
        public const int ERROR_MONITOR_INVALID_SERIAL_NUMBER_MONDSC_BLOCK = unchecked((int)0xC0261006);

        /// <summary>
        /// Provided monitor descriptor block is either corrupted or does not contain monitor's user friendly name.
        /// </summary>
        public const int ERROR_MONITOR_INVALID_USER_FRIENDLY_MONDSC_BLOCK = unchecked((int)0xC0261007);

        /// <summary>
        /// There is no monitor descriptor data at the specified (offset, size) region.
        /// </summary>
        public const int ERROR_MONITOR_NO_MORE_DESCRIPTOR_DATA = unchecked((int)0xC0261008);

        /// <summary>
        /// Monitor descriptor contains an invalid detailed timing block.
        /// </summary>
        public const int ERROR_MONITOR_INVALID_DETAILED_TIMING_BLOCK = unchecked((int)0xC0261009);

        /// <summary>
        /// Monitor descriptor contains invalid manufacture date.
        /// </summary>
        public const int ERROR_MONITOR_INVALID_MANUFACTURE_DATE = unchecked((int)0xC026100A);

        //
        // Windows Graphics Kernel Subsystem errors {0x2000..0x2fff}
        //
        // TODO: Add DXG Win32 errors here
        //
        // Common errors {0x2000..0x20ff}
        //
        /// <summary>
        /// Exclusive mode ownership is needed to create unmanaged primary allocation.
        /// </summary>
        public const int ERROR_GRAPHICS_NOT_EXCLUSIVE_MODE_OWNER = unchecked((int)0xC0262000);

        /// <summary>
        /// The driver needs more DMA buffer space in order to complete the requested operation.
        /// </summary>
        public const int ERROR_GRAPHICS_INSUFFICIENT_DMA_BUFFER = unchecked((int)0xC0262001);

        /// <summary>
        /// Specified display adapter handle is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_DISPLAY_ADAPTER = unchecked((int)0xC0262002);

        /// <summary>
        /// Specified display adapter and all of its state has been reset.
        /// </summary>
        public const int ERROR_GRAPHICS_ADAPTER_WAS_RESET = unchecked((int)0xC0262003);

        /// <summary>
        /// The driver stack doesn't match the expected driver model.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_DRIVER_MODEL = unchecked((int)0xC0262004);

        /// <summary>
        /// Present happened but ended up into the changed desktop mode
        /// </summary>
        public const int ERROR_GRAPHICS_PRESENT_MODE_CHANGED = unchecked((int)0xC0262005);

        /// <summary>
        /// Nothing to present due to desktop occlusion
        /// </summary>
        public const int ERROR_GRAPHICS_PRESENT_OCCLUDED = unchecked((int)0xC0262006);

        /// <summary>
        /// Not able to present due to denial of desktop access
        /// </summary>
        public const int ERROR_GRAPHICS_PRESENT_DENIED = unchecked((int)0xC0262007);

        /// <summary>
        /// Not able to present with color convertion
        /// </summary>
        public const int ERROR_GRAPHICS_CANNOTCOLORCONVERT = unchecked((int)0xC0262008);

        /// <summary>
        /// The kernel driver detected a version mismatch between it and the user mode driver.
        /// </summary>
        public const int ERROR_GRAPHICS_DRIVER_MISMATCH = unchecked((int)0xC0262009);

        /// <summary>
        /// Specified buffer is not big enough to contain entire requested dataset. Partial data populated up to the size of the buffer. Caller needs to provide buffer of size as specified in the partially populated buffer's content (interface specific).
        /// </summary>
        public const int ERROR_GRAPHICS_PARTIAL_DATA_POPULATED = 0x4026200A;

        /// <summary>
        /// Present redirection is disabled (desktop windowing management subsystem is off).
        /// </summary>
        public const int ERROR_GRAPHICS_PRESENT_REDIRECTION_DISABLED = unchecked((int)0xC026200B);

        /// <summary>
        /// Previous exclusive VidPn source owner has released its ownership
        /// </summary>
        public const int ERROR_GRAPHICS_PRESENT_UNOCCLUDED = unchecked((int)0xC026200C);

        /// <summary>
        /// Window DC is not available for presentation
        /// </summary>
        public const int ERROR_GRAPHICS_WINDOWDC_NOT_AVAILABLE = unchecked((int)0xC026200D);

        /// <summary>
        /// Windowless present is disabled (desktop windowing management subsystem is off).
        /// </summary>
        public const int ERROR_GRAPHICS_WINDOWLESS_PRESENT_DISABLED = unchecked((int)0xC026200E);

        //
        // Video Memory Manager (VidMM) subsystem errors {0x2100..0x21ff}
        //
        /// <summary>
        /// Not enough video memory available to complete the operation.
        /// </summary>
        public const int ERROR_GRAPHICS_NO_VIDEO_MEMORY = unchecked((int)0xC0262100);

        /// <summary>
        /// Couldn't probe and lock the underlying memory of an allocation.
        /// </summary>
        public const int ERROR_GRAPHICS_CANT_LOCK_MEMORY = unchecked((int)0xC0262101);

        /// <summary>
        /// The allocation is currently busy.
        /// </summary>
        public const int ERROR_GRAPHICS_ALLOCATION_BUSY = unchecked((int)0xC0262102);

        /// <summary>
        /// An object being referenced has reach the maximum reference count already and can't be reference further.
        /// </summary>
        public const int ERROR_GRAPHICS_TOO_MANY_REFERENCES = unchecked((int)0xC0262103);

        /// <summary>
        /// A problem couldn't be solved due to some currently existing condition. The problem should be tried again later.
        /// </summary>
        public const int ERROR_GRAPHICS_TRY_AGAIN_LATER = unchecked((int)0xC0262104);

        /// <summary>
        /// A problem couldn't be solved due to some currently existing condition. The problem should be tried again immediately.
        /// </summary>
        public const int ERROR_GRAPHICS_TRY_AGAIN_NOW = unchecked((int)0xC0262105);

        /// <summary>
        /// The allocation is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_ALLOCATION_INVALID = unchecked((int)0xC0262106);

        /// <summary>
        /// No more unswizzling aperture are currently available.
        /// </summary>
        public const int ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNAVAILABLE = unchecked((int)0xC0262107);

        /// <summary>
        /// The current allocation can't be unswizzled by an aperture.
        /// </summary>
        public const int ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNSUPPORTED = unchecked((int)0xC0262108);

        /// <summary>
        /// The request failed because a pinned allocation can't be evicted.
        /// </summary>
        public const int ERROR_GRAPHICS_CANT_EVICT_PINNED_ALLOCATION = unchecked((int)0xC0262109);

        /// <summary>
        /// The allocation can't be used from its current segment location for the specified operation.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_ALLOCATION_USAGE = unchecked((int)0xC0262110);

        /// <summary>
        /// A locked allocation can't be used in the current command buffer.
        /// </summary>
        public const int ERROR_GRAPHICS_CANT_RENDER_LOCKED_ALLOCATION = unchecked((int)0xC0262111);

        /// <summary>
        /// The allocation being referenced has been closed permanently.
        /// </summary>
        public const int ERROR_GRAPHICS_ALLOCATION_CLOSED = unchecked((int)0xC0262112);

        /// <summary>
        /// An invalid allocation instance is being referenced.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_ALLOCATION_INSTANCE = unchecked((int)0xC0262113);

        /// <summary>
        /// An invalid allocation handle is being referenced.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_ALLOCATION_HANDLE = unchecked((int)0xC0262114);

        /// <summary>
        /// The allocation being referenced doesn't belong to the current device.
        /// </summary>
        public const int ERROR_GRAPHICS_WRONG_ALLOCATION_DEVICE = unchecked((int)0xC0262115);

        /// <summary>
        /// The specified allocation lost its content.
        /// </summary>
        public const int ERROR_GRAPHICS_ALLOCATION_CONTENT_LOST = unchecked((int)0xC0262116);

        //
        // Video GPU Scheduler (VidSch) subsystem errors {0x2200..0x22ff}
        //
        /// <summary>
        /// GPU exception is detected on the given device. The device is not able to be scheduled.
        /// </summary>
        public const int ERROR_GRAPHICS_GPU_EXCEPTION_ON_DEVICE = unchecked((int)0xC0262200);

        /// <summary>
        /// Skip preparation of allocations referenced by the DMA buffer.
        /// </summary>
        public const int ERROR_GRAPHICS_SKIP_ALLOCATION_PREPARATION = 0x40262201;

        //
        // Video Present Network Management (VidPNMgr) subsystem errors {0x2300..0x23ff}
        //
        /// <summary>
        /// Specified VidPN topology is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY = unchecked((int)0xC0262300);

        /// <summary>
        /// Specified VidPN topology is valid but is not supported by this model of the display adapter.
        /// </summary>
        public const int ERROR_GRAPHICS_VIDPN_TOPOLOGY_NOT_SUPPORTED = unchecked((int)0xC0262301);

        /// <summary>
        /// Specified VidPN topology is valid but is not supported by the display adapter at this time, due to current allocation of its resources.
        /// </summary>
        public const int ERROR_GRAPHICS_VIDPN_TOPOLOGY_CURRENTLY_NOT_SUPPORTED = unchecked((int)0xC0262302);

        /// <summary>
        /// Specified VidPN handle is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDPN = unchecked((int)0xC0262303);

        /// <summary>
        /// Specified video present source is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE = unchecked((int)0xC0262304);

        /// <summary>
        /// Specified video present target is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET = unchecked((int)0xC0262305);

        /// <summary>
        /// Specified VidPN modality is not supported (e.g. at least two of the pinned modes are not cofunctional).
        /// </summary>
        public const int ERROR_GRAPHICS_VIDPN_MODALITY_NOT_SUPPORTED = unchecked((int)0xC0262306);

        /// <summary>
        /// No mode is pinned on the specified VidPN source/target.
        /// </summary>
        public const int ERROR_GRAPHICS_MODE_NOT_PINNED = 0x00262307;

        /// <summary>
        /// Specified VidPN source mode set is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDPN_SOURCEMODESET = unchecked((int)0xC0262308);

        /// <summary>
        /// Specified VidPN target mode set is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDPN_TARGETMODESET = unchecked((int)0xC0262309);

        /// <summary>
        /// Specified video signal frequency is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_FREQUENCY = unchecked((int)0xC026230A);

        /// <summary>
        /// Specified video signal active region is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_ACTIVE_REGION = unchecked((int)0xC026230B);

        /// <summary>
        /// Specified video signal total region is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_TOTAL_REGION = unchecked((int)0xC026230C);

        /// <summary>
        /// Specified video present source mode is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE_MODE = unchecked((int)0xC0262310);

        /// <summary>
        /// Specified video present target mode is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET_MODE = unchecked((int)0xC0262311);

        /// <summary>
        /// Pinned mode must remain in the set on VidPN's cofunctional modality enumeration.
        /// </summary>
        public const int ERROR_GRAPHICS_PINNED_MODE_MUST_REMAIN_IN_SET = unchecked((int)0xC0262312);

        /// <summary>
        /// Specified video present path is already in VidPN's topology.
        /// </summary>
        public const int ERROR_GRAPHICS_PATH_ALREADY_IN_TOPOLOGY = unchecked((int)0xC0262313);

        /// <summary>
        /// Specified mode is already in the mode set.
        /// </summary>
        public const int ERROR_GRAPHICS_MODE_ALREADY_IN_MODESET = unchecked((int)0xC0262314);

        /// <summary>
        /// Specified video present source set is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDEOPRESENTSOURCESET = unchecked((int)0xC0262315);

        /// <summary>
        /// Specified video present target set is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDEOPRESENTTARGETSET = unchecked((int)0xC0262316);

        /// <summary>
        /// Specified video present source is already in the video present source set.
        /// </summary>
        public const int ERROR_GRAPHICS_SOURCE_ALREADY_IN_SET = unchecked((int)0xC0262317);

        /// <summary>
        /// Specified video present target is already in the video present target set.
        /// </summary>
        public const int ERROR_GRAPHICS_TARGET_ALREADY_IN_SET = unchecked((int)0xC0262318);

        /// <summary>
        /// Specified VidPN present path is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDPN_PRESENT_PATH = unchecked((int)0xC0262319);

        /// <summary>
        /// Miniport has no recommendation for augmentation of the specified VidPN's topology.
        /// </summary>
        public const int ERROR_GRAPHICS_NO_RECOMMENDED_VIDPN_TOPOLOGY = unchecked((int)0xC026231A);

        /// <summary>
        /// Specified monitor frequency range set is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGESET = unchecked((int)0xC026231B);

        /// <summary>
        /// Specified monitor frequency range is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE = unchecked((int)0xC026231C);

        /// <summary>
        /// Specified frequency range is not in the specified monitor frequency range set.
        /// </summary>
        public const int ERROR_GRAPHICS_FREQUENCYRANGE_NOT_IN_SET = unchecked((int)0xC026231D);

        /// <summary>
        /// Specified mode set does not specify preference for one of its modes.
        /// </summary>
        public const int ERROR_GRAPHICS_NO_PREFERRED_MODE = 0x0026231E;

        /// <summary>
        /// Specified frequency range is already in the specified monitor frequency range set.
        /// </summary>
        public const int ERROR_GRAPHICS_FREQUENCYRANGE_ALREADY_IN_SET = unchecked((int)0xC026231F);

        /// <summary>
        /// Specified mode set is stale. Please reacquire the new mode set.
        /// </summary>
        public const int ERROR_GRAPHICS_STALE_MODESET = unchecked((int)0xC0262320);

        /// <summary>
        /// Specified monitor source mode set is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_MONITOR_SOURCEMODESET = unchecked((int)0xC0262321);

        /// <summary>
        /// Specified monitor source mode is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_MONITOR_SOURCE_MODE = unchecked((int)0xC0262322);

        /// <summary>
        /// Miniport does not have any recommendation regarding the request to provide a functional VidPN given the current display adapter configuration.
        /// </summary>
        public const int ERROR_GRAPHICS_NO_RECOMMENDED_FUNCTIONAL_VIDPN = unchecked((int)0xC0262323);

        /// <summary>
        /// ID of the specified mode is already used by another mode in the set.
        /// </summary>
        public const int ERROR_GRAPHICS_MODE_ID_MUST_BE_UNIQUE = unchecked((int)0xC0262324);

        /// <summary>
        /// System failed to determine a mode that is supported by both the display adapter and the monitor connected to it.
        /// </summary>
        public const int ERROR_GRAPHICS_EMPTY_ADAPTER_MONITOR_MODE_SUPPORT_INTERSECTION = unchecked((int)0xC0262325);

        /// <summary>
        /// Number of video present targets must be greater than or equal to the number of video present sources.
        /// </summary>
        public const int ERROR_GRAPHICS_VIDEO_PRESENT_TARGETS_LESS_THAN_SOURCES = unchecked((int)0xC0262326);

        /// <summary>
        /// Specified present path is not in VidPN's topology.
        /// </summary>
        public const int ERROR_GRAPHICS_PATH_NOT_IN_TOPOLOGY = unchecked((int)0xC0262327);

        /// <summary>
        /// Display adapter must have at least one video present source.
        /// </summary>
        public const int ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_SOURCE = unchecked((int)0xC0262328);

        /// <summary>
        /// Display adapter must have at least one video present target.
        /// </summary>
        public const int ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_TARGET = unchecked((int)0xC0262329);

        /// <summary>
        /// Specified monitor descriptor set is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_MONITORDESCRIPTORSET = unchecked((int)0xC026232A);

        /// <summary>
        /// Specified monitor descriptor is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_MONITORDESCRIPTOR = unchecked((int)0xC026232B);

        /// <summary>
        /// Specified descriptor is not in the specified monitor descriptor set.
        /// </summary>
        public const int ERROR_GRAPHICS_MONITORDESCRIPTOR_NOT_IN_SET = unchecked((int)0xC026232C);

        /// <summary>
        /// Specified descriptor is already in the specified monitor descriptor set.
        /// </summary>
        public const int ERROR_GRAPHICS_MONITORDESCRIPTOR_ALREADY_IN_SET = unchecked((int)0xC026232D);

        /// <summary>
        /// ID of the specified monitor descriptor is already used by another descriptor in the set.
        /// </summary>
        public const int ERROR_GRAPHICS_MONITORDESCRIPTOR_ID_MUST_BE_UNIQUE = unchecked((int)0xC026232E);

        /// <summary>
        /// Specified video present target subset type is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDPN_TARGET_SUBSET_TYPE = unchecked((int)0xC026232F);

        /// <summary>
        /// Two or more of the specified resources are not related to each other, as defined by the interface semantics.
        /// </summary>
        public const int ERROR_GRAPHICS_RESOURCES_NOT_RELATED = unchecked((int)0xC0262330);

        /// <summary>
        /// ID of the specified video present source is already used by another source in the set.
        /// </summary>
        public const int ERROR_GRAPHICS_SOURCE_ID_MUST_BE_UNIQUE = unchecked((int)0xC0262331);

        /// <summary>
        /// ID of the specified video present target is already used by another target in the set.
        /// </summary>
        public const int ERROR_GRAPHICS_TARGET_ID_MUST_BE_UNIQUE = unchecked((int)0xC0262332);

        /// <summary>
        /// Specified VidPN source cannot be used because there is no available VidPN target to connect it to.
        /// </summary>
        public const int ERROR_GRAPHICS_NO_AVAILABLE_VIDPN_TARGET = unchecked((int)0xC0262333);

        /// <summary>
        /// Newly arrived monitor could not be associated with a display adapter.
        /// </summary>
        public const int ERROR_GRAPHICS_MONITOR_COULD_NOT_BE_ASSOCIATED_WITH_ADAPTER = unchecked((int)0xC0262334);

        /// <summary>
        /// Display adapter in question does not have an associated VidPN manager.
        /// </summary>
        public const int ERROR_GRAPHICS_NO_VIDPNMGR = unchecked((int)0xC0262335);

        /// <summary>
        /// VidPN manager of the display adapter in question does not have an active VidPN.
        /// </summary>
        public const int ERROR_GRAPHICS_NO_ACTIVE_VIDPN = unchecked((int)0xC0262336);

        /// <summary>
        /// Specified VidPN topology is stale. Please reacquire the new topology.
        /// </summary>
        public const int ERROR_GRAPHICS_STALE_VIDPN_TOPOLOGY = unchecked((int)0xC0262337);

        /// <summary>
        /// There is no monitor connected on the specified video present target.
        /// </summary>
        public const int ERROR_GRAPHICS_MONITOR_NOT_CONNECTED = unchecked((int)0xC0262338);

        /// <summary>
        /// Specified source is not part of the specified VidPN's topology.
        /// </summary>
        public const int ERROR_GRAPHICS_SOURCE_NOT_IN_TOPOLOGY = unchecked((int)0xC0262339);

        /// <summary>
        /// Specified primary surface size is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_PRIMARYSURFACE_SIZE = unchecked((int)0xC026233A);

        /// <summary>
        /// Specified visible region size is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VISIBLEREGION_SIZE = unchecked((int)0xC026233B);

        /// <summary>
        /// Specified stride is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_STRIDE = unchecked((int)0xC026233C);

        /// <summary>
        /// Specified pixel format is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_PIXELFORMAT = unchecked((int)0xC026233D);

        /// <summary>
        /// Specified color basis is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_COLORBASIS = unchecked((int)0xC026233E);

        /// <summary>
        /// Specified pixel value access mode is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_PIXELVALUEACCESSMODE = unchecked((int)0xC026233F);

        /// <summary>
        /// Specified target is not part of the specified VidPN's topology.
        /// </summary>
        public const int ERROR_GRAPHICS_TARGET_NOT_IN_TOPOLOGY = unchecked((int)0xC0262340);

        /// <summary>
        /// Failed to acquire display mode management interface.
        /// </summary>
        public const int ERROR_GRAPHICS_NO_DISPLAY_MODE_MANAGEMENT_SUPPORT = unchecked((int)0xC0262341);

        /// <summary>
        /// Specified VidPN source is already owned by a DMM client and cannot be used until that client releases it.
        /// </summary>
        public const int ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE = unchecked((int)0xC0262342);

        /// <summary>
        /// Specified VidPN is active and cannot be accessed.
        /// </summary>
        public const int ERROR_GRAPHICS_CANT_ACCESS_ACTIVE_VIDPN = unchecked((int)0xC0262343);

        /// <summary>
        /// Specified VidPN present path importance ordinal is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_PATH_IMPORTANCE_ORDINAL = unchecked((int)0xC0262344);

        /// <summary>
        /// Specified VidPN present path content geometry transformation is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_PATH_CONTENT_GEOMETRY_TRANSFORMATION = unchecked((int)0xC0262345);

        /// <summary>
        /// Specified content geometry transformation is not supported on the respective VidPN present path.
        /// </summary>
        public const int ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_SUPPORTED = unchecked((int)0xC0262346);

        /// <summary>
        /// Specified gamma ramp is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_GAMMA_RAMP = unchecked((int)0xC0262347);

        /// <summary>
        /// Specified gamma ramp is not supported on the respective VidPN present path.
        /// </summary>
        public const int ERROR_GRAPHICS_GAMMA_RAMP_NOT_SUPPORTED = unchecked((int)0xC0262348);

        /// <summary>
        /// Multi-sampling is not supported on the respective VidPN present path.
        /// </summary>
        public const int ERROR_GRAPHICS_MULTISAMPLING_NOT_SUPPORTED = unchecked((int)0xC0262349);

        /// <summary>
        /// Specified mode is not in the specified mode set.
        /// </summary>
        public const int ERROR_GRAPHICS_MODE_NOT_IN_MODESET = unchecked((int)0xC026234A);

        /// <summary>
        /// Specified data set (e.g. mode set, frequency range set, descriptor set, topology, etc.) is empty.
        /// </summary>
        public const int ERROR_GRAPHICS_DATASET_IS_EMPTY = 0x0026234B;

        /// <summary>
        /// Specified data set (e.g. mode set, frequency range set, descriptor set, topology, etc.) does not contain any more elements.
        /// </summary>
        public const int ERROR_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET = 0x0026234C;

        /// <summary>
        /// Specified VidPN topology recommendation reason is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY_RECOMMENDATION_REASON = unchecked((int)0xC026234D);

        /// <summary>
        /// Specified VidPN present path content type is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_PATH_CONTENT_TYPE = unchecked((int)0xC026234E);

        /// <summary>
        /// Specified VidPN present path copy protection type is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_COPYPROTECTION_TYPE = unchecked((int)0xC026234F);

        /// <summary>
        /// No more than one unassigned mode set can exist at any given time for a given VidPN source/target.
        /// </summary>
        public const int ERROR_GRAPHICS_UNASSIGNED_MODESET_ALREADY_EXISTS = unchecked((int)0xC0262350);

        /// <summary>
        /// Specified content transformation is not pinned on the specified VidPN present path.
        /// </summary>
        public const int ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED = 0x00262351;

        /// <summary>
        /// Specified scanline ordering type is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_SCANLINE_ORDERING = unchecked((int)0xC0262352);

        /// <summary>
        /// Topology changes are not allowed for the specified VidPN.
        /// </summary>
        public const int ERROR_GRAPHICS_TOPOLOGY_CHANGES_NOT_ALLOWED = unchecked((int)0xC0262353);

        /// <summary>
        /// All available importance ordinals are already used in specified topology.
        /// </summary>
        public const int ERROR_GRAPHICS_NO_AVAILABLE_IMPORTANCE_ORDINALS = unchecked((int)0xC0262354);

        /// <summary>
        /// Specified primary surface has a different private format attribute than the current primary surface
        /// </summary>
        public const int ERROR_GRAPHICS_INCOMPATIBLE_PRIVATE_FORMAT = unchecked((int)0xC0262355);

        /// <summary>
        /// Specified mode pruning algorithm is invalid
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_MODE_PRUNING_ALGORITHM = unchecked((int)0xC0262356);

        /// <summary>
        /// Specified monitor capability origin is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_MONITOR_CAPABILITY_ORIGIN = unchecked((int)0xC0262357);

        /// <summary>
        /// Specified monitor frequency range constraint is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE_CONSTRAINT = unchecked((int)0xC0262358);

        /// <summary>
        /// Maximum supported number of present paths has been reached.
        /// </summary>
        public const int ERROR_GRAPHICS_MAX_NUM_PATHS_REACHED = unchecked((int)0xC0262359);

        /// <summary>
        /// Miniport requested that augmentation be cancelled for the specified source of the specified VidPN's topology.
        /// </summary>
        public const int ERROR_GRAPHICS_CANCEL_VIDPN_TOPOLOGY_AUGMENTATION = unchecked((int)0xC026235A);

        /// <summary>
        /// Specified client type was not recognized.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_CLIENT_TYPE = unchecked((int)0xC026235B);

        /// <summary>
        /// Client VidPN is not set on this adapter (e.g. no user mode initiated mode changes took place on this adapter yet).
        /// </summary>
        public const int ERROR_GRAPHICS_CLIENTVIDPN_NOT_SET = unchecked((int)0xC026235C);

        //
        // Port specific status codes {0x2400..0x24ff}
        //
        /// <summary>
        /// Specified display adapter child device already has an external device connected to it.
        /// </summary>
        public const int ERROR_GRAPHICS_SPECIFIED_CHILD_ALREADY_CONNECTED = unchecked((int)0xC0262400);

        /// <summary>
        /// Specified display adapter child device does not support descriptor exposure.
        /// </summary>
        public const int ERROR_GRAPHICS_CHILD_DESCRIPTOR_NOT_SUPPORTED = unchecked((int)0xC0262401);

        /// <summary>
        /// Child device presence was not reliably detected.
        /// </summary>
        public const int ERROR_GRAPHICS_UNKNOWN_CHILD_STATUS = 0x4026242F;

        /// <summary>
        /// The display adapter is not linked to any other adapters.
        /// </summary>
        public const int ERROR_GRAPHICS_NOT_A_LINKED_ADAPTER = unchecked((int)0xC0262430);

        /// <summary>
        /// Lead adapter in a linked configuration was not enumerated yet.
        /// </summary>
        public const int ERROR_GRAPHICS_LEADLINK_NOT_ENUMERATED = unchecked((int)0xC0262431);

        /// <summary>
        /// Some chain adapters in a linked configuration were not enumerated yet.
        /// </summary>
        public const int ERROR_GRAPHICS_CHAINLINKS_NOT_ENUMERATED = unchecked((int)0xC0262432);

        /// <summary>
        /// The chain of linked adapters is not ready to start because of an unknown failure.
        /// </summary>
        public const int ERROR_GRAPHICS_ADAPTER_CHAIN_NOT_READY = unchecked((int)0xC0262433);

        /// <summary>
        /// An attempt was made to start a lead link display adapter when the chain links were not started yet.
        /// </summary>
        public const int ERROR_GRAPHICS_CHAINLINKS_NOT_STARTED = unchecked((int)0xC0262434);

        /// <summary>
        /// An attempt was made to power up a lead link display adapter when the chain links were powered down.
        /// </summary>
        public const int ERROR_GRAPHICS_CHAINLINKS_NOT_POWERED_ON = unchecked((int)0xC0262435);

        /// <summary>
        /// The adapter link was found to be in an inconsistent state. Not all adapters are in an expected PNP/Power state.
        /// </summary>
        public const int ERROR_GRAPHICS_INCONSISTENT_DEVICE_LINK_STATE = unchecked((int)0xC0262436);

        /// <summary>
        /// Starting the leadlink adapter has been deferred temporarily.
        /// </summary>
        public const int ERROR_GRAPHICS_LEADLINK_START_DEFERRED = 0x40262437;

        /// <summary>
        /// The driver trying to start is not the same as the driver for the POSTed display adapter.
        /// </summary>
        public const int ERROR_GRAPHICS_NOT_POST_DEVICE_DRIVER = unchecked((int)0xC0262438);

        /// <summary>
        /// The display adapter is being polled for children too frequently at the same polling level.
        /// </summary>
        public const int ERROR_GRAPHICS_POLLING_TOO_FREQUENTLY = 0x40262439;

        /// <summary>
        /// Starting the adapter has been deferred temporarily.
        /// </summary>
        public const int ERROR_GRAPHICS_START_DEFERRED = 0x4026243A;

        /// <summary>
        /// An operation is being attempted that requires the display adapter to be in a quiescent state.
        /// </summary>
        public const int ERROR_GRAPHICS_ADAPTER_ACCESS_NOT_EXCLUDED = unchecked((int)0xC026243B);

        /// <summary>
        /// We can depend on the child device presence returned by the driver.
        /// </summary>
        public const int ERROR_GRAPHICS_DEPENDABLE_CHILD_STATUS = 0x4026243C;

        //
        // OPM, UAB and PVP specific error codes {0x2500..0x257f}
        //
        /// <summary>
        /// The driver does not support OPM.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_NOT_SUPPORTED = unchecked((int)0xC0262500);

        /// <summary>
        /// The driver does not support COPP.
        /// </summary>
        public const int ERROR_GRAPHICS_COPP_NOT_SUPPORTED = unchecked((int)0xC0262501);

        /// <summary>
        /// The driver does not support UAB.
        /// </summary>
        public const int ERROR_GRAPHICS_UAB_NOT_SUPPORTED = unchecked((int)0xC0262502);

        /// <summary>
        /// The specified encrypted parameters are invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_INVALID_ENCRYPTED_PARAMETERS = unchecked((int)0xC0262503);

        /// <summary>
        /// The GDI display device passed to this function does not have any active video outputs.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_NO_VIDEO_OUTPUTS_EXIST = unchecked((int)0xC0262505);

        /// <summary>
        /// An internal error caused this operation to fail.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_INTERNAL_ERROR = unchecked((int)0xC026250B);

        /// <summary>
        /// The function failed because the caller passed in an invalid OPM user mode handle.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_INVALID_HANDLE = unchecked((int)0xC026250C);

        /// <summary>
        /// A certificate could not be returned because the certificate buffer passed to the function was too small.
        /// </summary>
        public const int ERROR_GRAPHICS_PVP_INVALID_CERTIFICATE_LENGTH = unchecked((int)0xC026250E);

        /// <summary>
        /// A video output could not be created because the frame buffer is in spanning mode.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_SPANNING_MODE_ENABLED = unchecked((int)0xC026250F);

        /// <summary>
        /// A video output could not be created because the frame buffer is in theater mode.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_THEATER_MODE_ENABLED = unchecked((int)0xC0262510);

        /// <summary>
        /// The function failed because the display adapter's Hardware Functionality Scan failed to validate the graphics hardware.
        /// </summary>
        public const int ERROR_GRAPHICS_PVP_HFS_FAILED = unchecked((int)0xC0262511);

        /// <summary>
        /// The HDCP System Renewability Message passed to this function did not comply with section 5 of the HDCP 1.1 specification.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_INVALID_SRM = unchecked((int)0xC0262512);

        /// <summary>
        /// The video output cannot enable the High-bandwidth Digital Content Protection (HDCP) System because it does not support HDCP.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_HDCP = unchecked((int)0xC0262513);

        /// <summary>
        /// The video output cannot enable Analogue Copy Protection (ACP) because it does not support ACP.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_ACP = unchecked((int)0xC0262514);

        /// <summary>
        /// The video output cannot enable the Content Generation Management System Analogue (CGMS-A) protection technology because it does not support CGMS-A.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_CGMSA = unchecked((int)0xC0262515);

        /// <summary>
        /// The IOPMVideoOutput::GetInformation method cannot return the version of the SRM being used because the application never successfully passed an SRM to the video output.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_HDCP_SRM_NEVER_SET = unchecked((int)0xC0262516);

        /// <summary>
        /// The IOPMVideoOutput::Configure method cannot enable the specified output protection technology because the output's screen resolution is too high.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_RESOLUTION_TOO_HIGH = unchecked((int)0xC0262517);

        /// <summary>
        /// The IOPMVideoOutput::Configure method cannot enable HDCP because the display adapter's HDCP hardware is already being used by other physical outputs.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_ALL_HDCP_HARDWARE_ALREADY_IN_USE = unchecked((int)0xC0262518);

        /// <summary>
        /// The operating system asynchronously destroyed this OPM video output because the operating system's state changed. This error typically occurs because the monitor PDO associated with this video output was removed, the monitor PDO associated with this video output was stopped, the video output's session became a non-console session or the video output's desktop became an inactive desktop.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_NO_LONGER_EXISTS = unchecked((int)0xC026251A);

        /// <summary>
        /// The method failed because the session is changing its type. No IOPMVideoOutput methods can be called when a session is changing its type. There are currently three types of sessions: console, disconnected and remote.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_SESSION_TYPE_CHANGE_IN_PROGRESS = unchecked((int)0xC026251B);

        /// <summary>
        /// Either the IOPMVideoOutput::COPPCompatibleGetInformation, IOPMVideoOutput::GetInformation, or IOPMVideoOutput::Configure method failed. This error is returned when the caller tries to use a COPP specific command while the video output has OPM semantics only.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_COPP_SEMANTICS = unchecked((int)0xC026251C);

        /// <summary>
        /// The IOPMVideoOutput::GetInformation and IOPMVideoOutput::COPPCompatibleGetInformation methods return this error if the passed in sequence number is not the expected sequence number or the passed in OMAC value is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_INVALID_INFORMATION_REQUEST = unchecked((int)0xC026251D);

        /// <summary>
        /// The method failed because an unexpected error occurred inside of a display driver.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_DRIVER_INTERNAL_ERROR = unchecked((int)0xC026251E);

        /// <summary>
        /// Either the IOPMVideoOutput::COPPCompatibleGetInformation, IOPMVideoOutput::GetInformation, or IOPMVideoOutput::Configure method failed. This error is returned when the caller tries to use an OPM specific command while the video output has COPP semantics only.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_OPM_SEMANTICS = unchecked((int)0xC026251F);

        /// <summary>
        /// The IOPMVideoOutput::COPPCompatibleGetInformation or IOPMVideoOutput::Configure method failed because the display driver does not support the OPM_GET_ACP_AND_CGMSA_SIGNALING and OPM_SET_ACP_AND_CGMSA_SIGNALING GUIDs.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_SIGNALING_NOT_SUPPORTED = unchecked((int)0xC0262520);

        /// <summary>
        /// The IOPMVideoOutput::Configure function returns this error code if the passed in sequence number is not the expected sequence number or the passed in OMAC value is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_OPM_INVALID_CONFIGURATION_REQUEST = unchecked((int)0xC0262521);

        //
        // Monitor Configuration API error codes {0x2580..0x25DF}
        //
        /// <summary>
        /// The monitor connected to the specified video output does not have an I2C bus.
        /// </summary>
        public const int ERROR_GRAPHICS_I2C_NOT_SUPPORTED = unchecked((int)0xC0262580);

        /// <summary>
        /// No device on the I2C bus has the specified address.
        /// </summary>
        public const int ERROR_GRAPHICS_I2C_DEVICE_DOES_NOT_EXIST = unchecked((int)0xC0262581);

        /// <summary>
        /// An error occurred while transmitting data to the device on the I2C bus.
        /// </summary>
        public const int ERROR_GRAPHICS_I2C_ERROR_TRANSMITTING_DATA = unchecked((int)0xC0262582);

        /// <summary>
        /// An error occurred while receiving data from the device on the I2C bus.
        /// </summary>
        public const int ERROR_GRAPHICS_I2C_ERROR_RECEIVING_DATA = unchecked((int)0xC0262583);

        /// <summary>
        /// The monitor does not support the specified VCP code.
        /// </summary>
        public const int ERROR_GRAPHICS_DDCCI_VCP_NOT_SUPPORTED = unchecked((int)0xC0262584);

        /// <summary>
        /// The data received from the monitor is invalid.
        /// </summary>
        public const int ERROR_GRAPHICS_DDCCI_INVALID_DATA = unchecked((int)0xC0262585);

        /// <summary>
        /// The function failed because a monitor returned an invalid Timing Status byte when the operating system used the DDC/CI Get Timing Report &amp; Timing Message command to get a timing report from a monitor.
        /// </summary>
        public const int ERROR_GRAPHICS_DDCCI_MONITOR_RETURNED_INVALID_TIMING_STATUS_BYTE = unchecked((int)0xC0262586);

        /// <summary>
        /// The monitor returned a DDC/CI capabilities string which did not comply with the ACCESS.bus 3.0, DDC/CI 1.1, or MCCS 2 Revision 1 specification.
        /// </summary>
        public const int ERROR_GRAPHICS_MCA_INVALID_CAPABILITIES_STRING = unchecked((int)0xC0262587);

        /// <summary>
        /// An internal Monitor Configuration API error occurred.
        /// </summary>
        public const int ERROR_GRAPHICS_MCA_INTERNAL_ERROR = unchecked((int)0xC0262588);

        /// <summary>
        /// An operation failed because a DDC/CI message had an invalid value in its command field.
        /// </summary>
        public const int ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_COMMAND = unchecked((int)0xC0262589);

        /// <summary>
        /// An error occurred because the field length of a DDC/CI message contained an invalid value.
        /// </summary>
        public const int ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_LENGTH = unchecked((int)0xC026258A);

        /// <summary>
        /// An error occurred because the checksum field in a DDC/CI message did not match the message's computed checksum value. This error implies that the data was corrupted while it was being transmitted from a monitor to a computer.
        /// </summary>
        public const int ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_CHECKSUM = unchecked((int)0xC026258B);

        /// <summary>
        /// This function failed because an invalid monitor handle was passed to it.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_PHYSICAL_MONITOR_HANDLE = unchecked((int)0xC026258C);

        /// <summary>
        /// The operating system asynchronously destroyed the monitor which corresponds to this handle because the operating system's state changed. This error typically occurs because the monitor PDO associated with this handle was removed, the monitor PDO associated with this handle was stopped, or a display mode change occurred. A display mode change occurs when windows sends a WM_DISPLAYCHANGE windows message to applications.
        /// </summary>
        public const int ERROR_GRAPHICS_MONITOR_NO_LONGER_EXISTS = unchecked((int)0xC026258D);

        /// <summary>
        /// A continuous VCP code's current value is greater than its maximum value. This error code indicates that a monitor returned an invalid value.
        /// </summary>
        public const int ERROR_GRAPHICS_DDCCI_CURRENT_CURRENT_VALUE_GREATER_THAN_MAXIMUM_VALUE = unchecked((int)0xC02625D8);

        /// <summary>
        /// The monitor's VCP Version (0xDF) VCP code returned an invalid version value.
        /// </summary>
        public const int ERROR_GRAPHICS_MCA_INVALID_VCP_VERSION = unchecked((int)0xC02625D9);

        /// <summary>
        /// The monitor does not comply with the MCCS specification it claims to support.
        /// </summary>
        public const int ERROR_GRAPHICS_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION = unchecked((int)0xC02625DA);

        /// <summary>
        /// The MCCS version in a monitor's mccs_ver capability does not match the MCCS version the monitor reports when the VCP Version (0xDF) VCP code is used.
        /// </summary>
        public const int ERROR_GRAPHICS_MCA_MCCS_VERSION_MISMATCH = unchecked((int)0xC02625DB);

        /// <summary>
        /// The Monitor Configuration API only works with monitors which support the MCCS 1.0 specification, MCCS 2.0 specification or the MCCS 2.0 Revision 1 specification.
        /// </summary>
        public const int ERROR_GRAPHICS_MCA_UNSUPPORTED_MCCS_VERSION = unchecked((int)0xC02625DC);

        /// <summary>
        /// The monitor returned an invalid monitor technology type. CRT, Plasma and LCD (TFT) are examples of monitor technology types. This error implies that the monitor violated the MCCS 2.0 or MCCS 2.0 Revision 1 specification.
        /// </summary>
        public const int ERROR_GRAPHICS_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED = unchecked((int)0xC02625DE);

        /// <summary>
        /// SetMonitorColorTemperature()'s caller passed a color temperature to it which the current monitor did not support. This error implies that the monitor violated the MCCS 2.0 or MCCS 2.0 Revision 1 specification.
        /// </summary>
        public const int ERROR_GRAPHICS_MCA_UNSUPPORTED_COLOR_TEMPERATURE = unchecked((int)0xC02625DF);

        //
        // OPM, UAB, PVP and DDC/CI shared error codes {0x25E0..0x25ff}
        //
        /// <summary>
        /// This function can only be used if a program is running in the local console session. It cannot be used if the program is running on a remote desktop session or on a terminal server session.
        /// </summary>
        public const int ERROR_GRAPHICS_ONLY_CONSOLE_SESSION_SUPPORTED = unchecked((int)0xC02625E0);

        /// <summary>
        /// This function cannot find an actual GDI display device which corresponds to the specified GDI display device name.
        /// </summary>
        public const int ERROR_GRAPHICS_NO_DISPLAY_DEVICE_CORRESPONDS_TO_NAME = unchecked((int)0xC02625E1);

        /// <summary>
        /// The function failed because the specified GDI display device was not attached to the Windows desktop.
        /// </summary>
        public const int ERROR_GRAPHICS_DISPLAY_DEVICE_NOT_ATTACHED_TO_DESKTOP = unchecked((int)0xC02625E2);

        /// <summary>
        /// This function does not support GDI mirroring display devices because GDI mirroring display devices do not have any physical monitors associated with them.
        /// </summary>
        public const int ERROR_GRAPHICS_MIRRORING_DEVICES_NOT_SUPPORTED = unchecked((int)0xC02625E3);

        /// <summary>
        /// The function failed because an invalid pointer parameter was passed to it. A pointer parameter is invalid if it is NULL, points to an invalid address, points to a kernel mode address, or is not correctly aligned.
        /// </summary>
        public const int ERROR_GRAPHICS_INVALID_POINTER = unchecked((int)0xC02625E4);

        /// <summary>
        /// The function failed because the specified GDI device did not have any monitors associated with it.
        /// </summary>
        public const int ERROR_GRAPHICS_NO_MONITORS_CORRESPOND_TO_DISPLAY_DEVICE = unchecked((int)0xC02625E5);

        /// <summary>
        /// An array passed to the function cannot hold all of the data that the function must copy into the array.
        /// </summary>
        public const int ERROR_GRAPHICS_PARAMETER_ARRAY_TOO_SMALL = unchecked((int)0xC02625E6);

        /// <summary>
        /// An internal error caused an operation to fail.
        /// </summary>
        public const int ERROR_GRAPHICS_INTERNAL_ERROR = unchecked((int)0xC02625E7);

        /// <summary>
        /// The function failed because the current session is changing its type. This function cannot be called when the current session is changing its type. There are currently three types of sessions: console, disconnected and remote.
        /// </summary>
        public const int ERROR_GRAPHICS_SESSION_TYPE_CHANGE_IN_PROGRESS = unchecked((int)0xC02605E8);


        // FACILITY_NAP

        /// <summary>
        /// The NAP SoH packet is invalid.
        /// </summary>
        public const int NAP_E_INVALID_PACKET = unchecked((int)0x80270001);

        /// <summary>
        /// An SoH was missing from the NAP packet.
        /// </summary>
        public const int NAP_E_MISSING_SOH = unchecked((int)0x80270002);

        /// <summary>
        /// The entity ID conflicts with an already registered id.
        /// </summary>
        public const int NAP_E_CONFLICTING_ID = unchecked((int)0x80270003);

        /// <summary>
        /// No cached SoH is present.
        /// </summary>
        public const int NAP_E_NO_CACHED_SOH = unchecked((int)0x80270004);

        /// <summary>
        /// The entity is still bound to the NAP system.
        /// </summary>
        public const int NAP_E_STILL_BOUND = unchecked((int)0x80270005);

        /// <summary>
        /// The entity is not registered with the NAP system.
        /// </summary>
        public const int NAP_E_NOT_REGISTERED = unchecked((int)0x80270006);

        /// <summary>
        /// The entity is not initialized with the NAP system.
        /// </summary>
        public const int NAP_E_NOT_INITIALIZED = unchecked((int)0x80270007);

        /// <summary>
        /// The correlation id in the SoH-Request and SoH-Response do not match up.
        /// </summary>
        public const int NAP_E_MISMATCHED_ID = unchecked((int)0x80270008);

        /// <summary>
        /// Completion was indicated on a request that is not currently pending.
        /// </summary>
        public const int NAP_E_NOT_PENDING = unchecked((int)0x80270009);

        /// <summary>
        /// The NAP component's id was not found.
        /// </summary>
        public const int NAP_E_ID_NOT_FOUND = unchecked((int)0x8027000A);

        /// <summary>
        /// The maximum size of the connection is too small for an SoH packet.
        /// </summary>
        public const int NAP_E_MAXSIZE_TOO_SMALL = unchecked((int)0x8027000B);

        /// <summary>
        /// The NapAgent service is not running.
        /// </summary>
        public const int NAP_E_SERVICE_NOT_RUNNING = unchecked((int)0x8027000C);

        /// <summary>
        /// A certificate is already present in the cert store.
        /// </summary>
        public const int NAP_S_CERT_ALREADY_PRESENT = 0x0027000D;

        /// <summary>
        /// The entity is disabled with the NapAgent service.
        /// </summary>
        public const int NAP_E_ENTITY_DISABLED = unchecked((int)0x8027000E);

        /// <summary>
        /// Group Policy is not configured.
        /// </summary>
        public const int NAP_E_NETSH_GROUPPOLICY_ERROR = unchecked((int)0x8027000F);

        /// <summary>
        /// Too many simultaneous calls.
        /// </summary>
        public const int NAP_E_TOO_MANY_CALLS = unchecked((int)0x80270010);

        /// <summary>
        /// SHV configuration already existed.
        /// </summary>
        public const int NAP_E_SHV_CONFIG_EXISTED = unchecked((int)0x80270011);

        /// <summary>
        /// SHV configuration is not found.
        /// </summary>
        public const int NAP_E_SHV_CONFIG_NOT_FOUND = unchecked((int)0x80270012);

        /// <summary>
        /// SHV timed out on the request.
        /// </summary>
        public const int NAP_E_SHV_TIMEOUT = unchecked((int)0x80270013);

        //
        // ===============================
        // TPM Services and TPM Software Error Messages
        // ===============================
        //
        // The TPM services and TPM software facilities are used by the various
        // TPM software components. There are two facilities because the services
        // errors are within the TCG-defined error space and the software errors
        // are not.
        //
        // The following are the subranges within the TPM Services facility.
        // The TPM hardware errors are defined in the document
        // TPM Main Specification 1.2 Part 2 TPM Structures.
        // The TBS errors are slotted into the TCG error namespace at the TBS layer.
        //
        // 0x0000 - 0x08ff     TPM hardware errors
        // 0x4000 - 0x40ff     TPM Base Services errors (tbssvc.dll)
        //
        // The following are the subranges within the TPM Software facility. The TBS
        // has two classes of errors - those that can be returned (the public errors,
        // defined in the TBS spec), which are in the TPM services facility,  and
        // those that are internal or implementation specific, which are here in the
        // TPM software facility.
        //
        // 0x0000 - 0x00ff     TPM device driver errors (tpm.sys)
        // 0x0100 - 0x01ff     TPM API errors (tpmapi.lib)
        // 0x0200 - 0x02ff     TBS internal errors (tbssvc.dll)
        // 0x0300 - 0x03ff     TPM Physical Presence errors
        //
        //
        // TPM hardware error codes {0x0000..0x08ff}
        // This space is further subdivided into hardware errors, vendor-specific
        // errors, and non-fatal errors.
        //
        //
        // TPM hardware errors {0x0000..0x003ff}
        //
        /// <summary>
        /// This is an error mask to convert TPM hardware errors to win errors.
        /// </summary>
        public const int TPM_E_ERROR_MASK = unchecked((int)0x80280000);

        /// <summary>
        /// Authentication failed.
        /// </summary>
        public const int TPM_E_AUTHFAIL = unchecked((int)0x80280001);

        /// <summary>
        /// The index to a PCR, DIR or other register is incorrect.
        /// </summary>
        public const int TPM_E_BADINDEX = unchecked((int)0x80280002);

        /// <summary>
        /// One or more parameter is bad.
        /// </summary>
        public const int TPM_E_BAD_PARAMETER = unchecked((int)0x80280003);

        /// <summary>
        /// An operation completed successfully but the auditing of that operation failed.
        /// </summary>
        public const int TPM_E_AUDITFAILURE = unchecked((int)0x80280004);

        /// <summary>
        /// The clear disable flag is set and all clear operations now require physical access.
        /// </summary>
        public const int TPM_E_CLEAR_DISABLED = unchecked((int)0x80280005);

        /// <summary>
        /// Activate the Trusted Platform Module (TPM).
        /// </summary>
        public const int TPM_E_DEACTIVATED = unchecked((int)0x80280006);

        /// <summary>
        /// Enable the Trusted Platform Module (TPM).
        /// </summary>
        public const int TPM_E_DISABLED = unchecked((int)0x80280007);

        /// <summary>
        /// The target command has been disabled.
        /// </summary>
        public const int TPM_E_DISABLED_CMD = unchecked((int)0x80280008);

        /// <summary>
        /// The operation failed.
        /// </summary>
        public const int TPM_E_FAIL = unchecked((int)0x80280009);

        /// <summary>
        /// The ordinal was unknown or inconsistent.
        /// </summary>
        public const int TPM_E_BAD_ORDINAL = unchecked((int)0x8028000A);

        /// <summary>
        /// The ability to install an owner is disabled.
        /// </summary>
        public const int TPM_E_INSTALL_DISABLED = unchecked((int)0x8028000B);

        /// <summary>
        /// The key handle cannot be interpreted.
        /// </summary>
        public const int TPM_E_INVALID_KEYHANDLE = unchecked((int)0x8028000C);

        /// <summary>
        /// The key handle points to an invalid key.
        /// </summary>
        public const int TPM_E_KEYNOTFOUND = unchecked((int)0x8028000D);

        /// <summary>
        /// Unacceptable encryption scheme.
        /// </summary>
        public const int TPM_E_INAPPROPRIATE_ENC = unchecked((int)0x8028000E);

        /// <summary>
        /// Migration authorization failed.
        /// </summary>
        public const int TPM_E_MIGRATEFAIL = unchecked((int)0x8028000F);

        /// <summary>
        /// PCR information could not be interpreted.
        /// </summary>
        public const int TPM_E_INVALID_PCR_INFO = unchecked((int)0x80280010);

        /// <summary>
        /// No room to load key.
        /// </summary>
        public const int TPM_E_NOSPACE = unchecked((int)0x80280011);

        /// <summary>
        /// There is no Storage Root Key (SRK) set.
        /// </summary>
        public const int TPM_E_NOSRK = unchecked((int)0x80280012);

        /// <summary>
        /// An encrypted blob is invalid or was not created by this TPM.
        /// </summary>
        public const int TPM_E_NOTSEALED_BLOB = unchecked((int)0x80280013);

        /// <summary>
        /// The Trusted Platform Module (TPM) already has an owner.
        /// </summary>
        public const int TPM_E_OWNER_SET = unchecked((int)0x80280014);

        /// <summary>
        /// The TPM has insufficient internal resources to perform the requested action.
        /// </summary>
        public const int TPM_E_RESOURCES = unchecked((int)0x80280015);

        /// <summary>
        /// A random string was too short.
        /// </summary>
        public const int TPM_E_SHORTRANDOM = unchecked((int)0x80280016);

        /// <summary>
        /// The TPM does not have the space to perform the operation.
        /// </summary>
        public const int TPM_E_SIZE = unchecked((int)0x80280017);

        /// <summary>
        /// The named PCR value does not match the current PCR value.
        /// </summary>
        public const int TPM_E_WRONGPCRVAL = unchecked((int)0x80280018);

        /// <summary>
        /// The paramSize argument to the command has the incorrect value .
        /// </summary>
        public const int TPM_E_BAD_PARAM_SIZE = unchecked((int)0x80280019);

        /// <summary>
        /// There is no existing SHA-1 thread.
        /// </summary>
        public const int TPM_E_SHA_THREAD = unchecked((int)0x8028001A);

        /// <summary>
        /// The calculation is unable to proceed because the existing SHA-1 thread has already encountered an error.
        /// </summary>
        public const int TPM_E_SHA_ERROR = unchecked((int)0x8028001B);

        /// <summary>
        /// The TPM hardware device reported a failure during its internal self test. Try restarting the computer to resolve the problem. If the problem continues, check for the latest BIOS or firmware update for your TPM hardware. Consult the computer manufacturer's documentation for instructions.
        /// </summary>
        public const int TPM_E_FAILEDSELFTEST = unchecked((int)0x8028001C);

        /// <summary>
        /// The authorization for the second key in a 2 key function failed authorization.
        /// </summary>
        public const int TPM_E_AUTH2FAIL = unchecked((int)0x8028001D);

        /// <summary>
        /// The tag value sent to for a command is invalid.
        /// </summary>
        public const int TPM_E_BADTAG = unchecked((int)0x8028001E);

        /// <summary>
        /// An IO error occurred transmitting information to the TPM.
        /// </summary>
        public const int TPM_E_IOERROR = unchecked((int)0x8028001F);

        /// <summary>
        /// The encryption process had a problem.
        /// </summary>
        public const int TPM_E_ENCRYPT_ERROR = unchecked((int)0x80280020);

        /// <summary>
        /// The decryption process did not complete.
        /// </summary>
        public const int TPM_E_DECRYPT_ERROR = unchecked((int)0x80280021);

        /// <summary>
        /// An invalid handle was used.
        /// </summary>
        public const int TPM_E_INVALID_AUTHHANDLE = unchecked((int)0x80280022);

        /// <summary>
        /// The TPM does not have an Endorsement Key (EK) installed.
        /// </summary>
        public const int TPM_E_NO_ENDORSEMENT = unchecked((int)0x80280023);

        /// <summary>
        /// The usage of a key is not allowed.
        /// </summary>
        public const int TPM_E_INVALID_KEYUSAGE = unchecked((int)0x80280024);

        /// <summary>
        /// The submitted entity type is not allowed.
        /// </summary>
        public const int TPM_E_WRONG_ENTITYTYPE = unchecked((int)0x80280025);

        /// <summary>
        /// The command was received in the wrong sequence relative to TPM_Init and a subsequent TPM_Startup.
        /// </summary>
        public const int TPM_E_INVALID_POSTINIT = unchecked((int)0x80280026);

        /// <summary>
        /// Signed data cannot include additional DER information.
        /// </summary>
        public const int TPM_E_INAPPROPRIATE_SIG = unchecked((int)0x80280027);

        /// <summary>
        /// The key properties in TPM_KEY_PARMs are not supported by this TPM.
        /// </summary>
        public const int TPM_E_BAD_KEY_PROPERTY = unchecked((int)0x80280028);

        /// <summary>
        /// The migration properties of this key are incorrect.
        /// </summary>
        public const int TPM_E_BAD_MIGRATION = unchecked((int)0x80280029);

        /// <summary>
        /// The signature or encryption scheme for this key is incorrect or not permitted in this situation.
        /// </summary>
        public const int TPM_E_BAD_SCHEME = unchecked((int)0x8028002A);

        /// <summary>
        /// The size of the data (or blob) parameter is bad or inconsistent with the referenced key.
        /// </summary>
        public const int TPM_E_BAD_DATASIZE = unchecked((int)0x8028002B);

        /// <summary>
        /// A mode parameter is bad, such as capArea or subCapArea for TPM_GetCapability, phsicalPresence parameter for TPM_PhysicalPresence, or migrationType for TPM_CreateMigrationBlob.
        /// </summary>
        public const int TPM_E_BAD_MODE = unchecked((int)0x8028002C);

        /// <summary>
        /// Either the physicalPresence or physicalPresenceLock bits have the wrong value.
        /// </summary>
        public const int TPM_E_BAD_PRESENCE = unchecked((int)0x8028002D);

        /// <summary>
        /// The TPM cannot perform this version of the capability.
        /// </summary>
        public const int TPM_E_BAD_VERSION = unchecked((int)0x8028002E);

        /// <summary>
        /// The TPM does not allow for wrapped transport sessions.
        /// </summary>
        public const int TPM_E_NO_WRAP_TRANSPORT = unchecked((int)0x8028002F);

        /// <summary>
        /// TPM audit construction failed and the underlying command was returning a failure code also.
        /// </summary>
        public const int TPM_E_AUDITFAIL_UNSUCCESSFUL = unchecked((int)0x80280030);

        /// <summary>
        /// TPM audit construction failed and the underlying command was returning success.
        /// </summary>
        public const int TPM_E_AUDITFAIL_SUCCESSFUL = unchecked((int)0x80280031);

        /// <summary>
        /// Attempt to reset a PCR register that does not have the resettable attribute.
        /// </summary>
        public const int TPM_E_NOTRESETABLE = unchecked((int)0x80280032);

        /// <summary>
        /// Attempt to reset a PCR register that requires locality and locality modifier not part of command transport.
        /// </summary>
        public const int TPM_E_NOTLOCAL = unchecked((int)0x80280033);

        /// <summary>
        /// Make identity blob not properly typed.
        /// </summary>
        public const int TPM_E_BAD_TYPE = unchecked((int)0x80280034);

        /// <summary>
        /// When saving context identified resource type does not match actual resource.
        /// </summary>
        public const int TPM_E_INVALID_RESOURCE = unchecked((int)0x80280035);

        /// <summary>
        /// The TPM is attempting to execute a command only available when in FIPS mode.
        /// </summary>
        public const int TPM_E_NOTFIPS = unchecked((int)0x80280036);

        /// <summary>
        /// The command is attempting to use an invalid family ID.
        /// </summary>
        public const int TPM_E_INVALID_FAMILY = unchecked((int)0x80280037);

        /// <summary>
        /// The permission to manipulate the NV storage is not available.
        /// </summary>
        public const int TPM_E_NO_NV_PERMISSION = unchecked((int)0x80280038);

        /// <summary>
        /// The operation requires a signed command.
        /// </summary>
        public const int TPM_E_REQUIRES_SIGN = unchecked((int)0x80280039);

        /// <summary>
        /// Wrong operation to load an NV key.
        /// </summary>
        public const int TPM_E_KEY_NOTSUPPORTED = unchecked((int)0x8028003A);

        /// <summary>
        /// NV_LoadKey blob requires both owner and blob authorization.
        /// </summary>
        public const int TPM_E_AUTH_CONFLICT = unchecked((int)0x8028003B);

        /// <summary>
        /// The NV area is locked and not writtable.
        /// </summary>
        public const int TPM_E_AREA_LOCKED = unchecked((int)0x8028003C);

        /// <summary>
        /// The locality is incorrect for the attempted operation.
        /// </summary>
        public const int TPM_E_BAD_LOCALITY = unchecked((int)0x8028003D);

        /// <summary>
        /// The NV area is read only and can't be written to.
        /// </summary>
        public const int TPM_E_READ_ONLY = unchecked((int)0x8028003E);

        /// <summary>
        /// There is no protection on the write to the NV area.
        /// </summary>
        public const int TPM_E_PER_NOWRITE = unchecked((int)0x8028003F);

        /// <summary>
        /// The family count value does not match.
        /// </summary>
        public const int TPM_E_FAMILYCOUNT = unchecked((int)0x80280040);

        /// <summary>
        /// The NV area has already been written to.
        /// </summary>
        public const int TPM_E_WRITE_LOCKED = unchecked((int)0x80280041);

        /// <summary>
        /// The NV area attributes conflict.
        /// </summary>
        public const int TPM_E_BAD_ATTRIBUTES = unchecked((int)0x80280042);

        /// <summary>
        /// The structure tag and version are invalid or inconsistent.
        /// </summary>
        public const int TPM_E_INVALID_STRUCTURE = unchecked((int)0x80280043);

        /// <summary>
        /// The key is under control of the TPM Owner and can only be evicted by the TPM Owner.
        /// </summary>
        public const int TPM_E_KEY_OWNER_CONTROL = unchecked((int)0x80280044);

        /// <summary>
        /// The counter handle is incorrect.
        /// </summary>
        public const int TPM_E_BAD_COUNTER = unchecked((int)0x80280045);

        /// <summary>
        /// The write is not a complete write of the area.
        /// </summary>
        public const int TPM_E_NOT_FULLWRITE = unchecked((int)0x80280046);

        /// <summary>
        /// The gap between saved context counts is too large.
        /// </summary>
        public const int TPM_E_CONTEXT_GAP = unchecked((int)0x80280047);

        /// <summary>
        /// The maximum number of NV writes without an owner has been exceeded.
        /// </summary>
        public const int TPM_E_MAXNVWRITES = unchecked((int)0x80280048);

        /// <summary>
        /// No operator AuthData value is set.
        /// </summary>
        public const int TPM_E_NOOPERATOR = unchecked((int)0x80280049);

        /// <summary>
        /// The resource pointed to by context is not loaded.
        /// </summary>
        public const int TPM_E_RESOURCEMISSING = unchecked((int)0x8028004A);

        /// <summary>
        /// The delegate administration is locked.
        /// </summary>
        public const int TPM_E_DELEGATE_LOCK = unchecked((int)0x8028004B);

        /// <summary>
        /// Attempt to manage a family other then the delegated family.
        /// </summary>
        public const int TPM_E_DELEGATE_FAMILY = unchecked((int)0x8028004C);

        /// <summary>
        /// Delegation table management not enabled.
        /// </summary>
        public const int TPM_E_DELEGATE_ADMIN = unchecked((int)0x8028004D);

        /// <summary>
        /// There was a command executed outside of an exclusive transport session.
        /// </summary>
        public const int TPM_E_TRANSPORT_NOTEXCLUSIVE = unchecked((int)0x8028004E);

        /// <summary>
        /// Attempt to context save a owner evict controlled key.
        /// </summary>
        public const int TPM_E_OWNER_CONTROL = unchecked((int)0x8028004F);

        /// <summary>
        /// The DAA command has no resources availble to execute the command.
        /// </summary>
        public const int TPM_E_DAA_RESOURCES = unchecked((int)0x80280050);

        /// <summary>
        /// The consistency check on DAA parameter inputData0 has failed.
        /// </summary>
        public const int TPM_E_DAA_INPUT_DATA0 = unchecked((int)0x80280051);

        /// <summary>
        /// The consistency check on DAA parameter inputData1 has failed.
        /// </summary>
        public const int TPM_E_DAA_INPUT_DATA1 = unchecked((int)0x80280052);

        /// <summary>
        /// The consistency check on DAA_issuerSettings has failed.
        /// </summary>
        public const int TPM_E_DAA_ISSUER_SETTINGS = unchecked((int)0x80280053);

        /// <summary>
        /// The consistency check on DAA_tpmSpecific has failed.
        /// </summary>
        public const int TPM_E_DAA_TPM_SETTINGS = unchecked((int)0x80280054);

        /// <summary>
        /// The atomic process indicated by the submitted DAA command is not the expected process.
        /// </summary>
        public const int TPM_E_DAA_STAGE = unchecked((int)0x80280055);

        /// <summary>
        /// The issuer's validity check has detected an inconsistency.
        /// </summary>
        public const int TPM_E_DAA_ISSUER_VALIDITY = unchecked((int)0x80280056);

        /// <summary>
        /// The consistency check on w has failed.
        /// </summary>
        public const int TPM_E_DAA_WRONG_W = unchecked((int)0x80280057);

        /// <summary>
        /// The handle is incorrect.
        /// </summary>
        public const int TPM_E_BAD_HANDLE = unchecked((int)0x80280058);

        /// <summary>
        /// Delegation is not correct.
        /// </summary>
        public const int TPM_E_BAD_DELEGATE = unchecked((int)0x80280059);

        /// <summary>
        /// The context blob is invalid.
        /// </summary>
        public const int TPM_E_BADCONTEXT = unchecked((int)0x8028005A);

        /// <summary>
        /// Too many contexts held by the TPM.
        /// </summary>
        public const int TPM_E_TOOMANYCONTEXTS = unchecked((int)0x8028005B);

        /// <summary>
        /// Migration authority signature validation failure.
        /// </summary>
        public const int TPM_E_MA_TICKET_SIGNATURE = unchecked((int)0x8028005C);

        /// <summary>
        /// Migration destination not authenticated.
        /// </summary>
        public const int TPM_E_MA_DESTINATION = unchecked((int)0x8028005D);

        /// <summary>
        /// Migration source incorrect.
        /// </summary>
        public const int TPM_E_MA_SOURCE = unchecked((int)0x8028005E);

        /// <summary>
        /// Incorrect migration authority.
        /// </summary>
        public const int TPM_E_MA_AUTHORITY = unchecked((int)0x8028005F);

        /// <summary>
        /// Attempt to revoke the EK and the EK is not revocable.
        /// </summary>
        public const int TPM_E_PERMANENTEK = unchecked((int)0x80280061);

        /// <summary>
        /// Bad signature of CMK ticket.
        /// </summary>
        public const int TPM_E_BAD_SIGNATURE = unchecked((int)0x80280062);

        /// <summary>
        /// There is no room in the context list for additional contexts.
        /// </summary>
        public const int TPM_E_NOCONTEXTSPACE = unchecked((int)0x80280063);

        /// <summary>
        /// TPM2.0 Asymmetric algorithm not supported or not correct.
        /// </summary>
        public const int TPM_E_ASYMMETRIC = unchecked((int)0x80280081);

        /// <summary>
        /// TPM2.0 Inconsistent attributes.
        /// </summary>
        public const int TPM_20_E_ATTRIBUTES = unchecked((int)0x80280082);

        /// <summary>
        /// TPM2.0 Hash algorithm not supported or not appropriate.
        /// </summary>
        public const int TPM_20_E_HASH = unchecked((int)0x80280083);

        /// <summary>
        /// TPM2.0 Value is out of range or is not correct for the context.
        /// </summary>
        public const int TPM_20_E_VALUE = unchecked((int)0x80280084);

        /// <summary>
        /// TPM2.0 Hierarchy is not enabled or is not correct for the use.
        /// </summary>
        public const int TPM_20_E_HIERARCHY = unchecked((int)0x80280085);

        /// <summary>
        /// TPM2.0 Key size is not supported.
        /// </summary>
        public const int TPM_20_E_KEY_SIZE = unchecked((int)0x80280087);

        /// <summary>
        /// TPM2.0 Mask generation function not supported.
        /// </summary>
        public const int TPM_20_E_MGF = unchecked((int)0x80280088);

        /// <summary>
        /// TPM2.0 Mode of operation not supported.
        /// </summary>
        public const int TPM_20_E_MODE = unchecked((int)0x80280089);

        /// <summary>
        /// TPM2.0 The type of the value is not appropriate for the use.
        /// </summary>
        public const int TPM_20_E_TYPE = unchecked((int)0x8028008A);

        /// <summary>
        /// TPM2.0 The Handle is not correct for the use.
        /// </summary>
        public const int TPM_20_E_HANDLE = unchecked((int)0x8028008B);

        /// <summary>
        /// TPM2.0 Unsupported key derivation function or function not appropriate for use.
        /// </summary>
        public const int TPM_20_E_KDF = unchecked((int)0x8028008C);

        /// <summary>
        /// TPM2.0 Value was out of allowed range.
        /// </summary>
        public const int TPM_20_E_RANGE = unchecked((int)0x8028008D);

        /// <summary>
        /// TPM2.0 The authorization HMAC check failed and DA counter incremented.
        /// </summary>
        public const int TPM_20_E_AUTH_FAIL = unchecked((int)0x8028008E);

        /// <summary>
        /// TPM2.0 Invalid nonce size.
        /// </summary>
        public const int TPM_20_E_NONCE = unchecked((int)0x8028008F);

        /// <summary>
        /// TPM2.0 Authorization requires assertion of PP.
        /// </summary>
        public const int TPM_20_E_PP = unchecked((int)0x80280090);

        /// <summary>
        /// TPM2.0 Unsupported or incompatible scheme.
        /// </summary>
        public const int TPM_20_E_SCHEME = unchecked((int)0x80280092);

        /// <summary>
        /// TPM2.0 Strucutre is wrong size.
        /// </summary>
        public const int TPM_20_E_SIZE = unchecked((int)0x80280095);

        /// <summary>
        /// TPM2.0 Unsupported symmetric algorithm or key size, or not appropriate for instance.
        /// </summary>
        public const int TPM_20_E_SYMMETRIC = unchecked((int)0x80280096);

        /// <summary>
        /// TPM2.0 Incorrect strucutre tag.
        /// </summary>
        public const int TPM_20_E_TAG = unchecked((int)0x80280097);

        /// <summary>
        /// TPM2.0 Union selector is incorrect.
        /// </summary>
        public const int TPM_20_E_SELECTOR = unchecked((int)0x80280098);

        /// <summary>
        /// TPM2.0 The TPM was unable to unmarshal a value because there were not enough octets in the input buffer.
        /// </summary>
        public const int TPM_20_E_INSUFFICIENT = unchecked((int)0x8028009A);

        /// <summary>
        /// TPM2.0 The signature is not valid.
        /// </summary>
        public const int TPM_20_E_SIGNATURE = unchecked((int)0x8028009B);

        /// <summary>
        /// TPM2.0 Key fields are not compatible with the selected use.
        /// </summary>
        public const int TPM_20_E_KEY = unchecked((int)0x8028009C);

        /// <summary>
        /// TPM2.0 A policy check failed.
        /// </summary>
        public const int TPM_20_E_POLICY_FAIL = unchecked((int)0x8028009D);

        /// <summary>
        /// TPM2.0 Integrity check failed.
        /// </summary>
        public const int TPM_20_E_INTEGRITY = unchecked((int)0x8028009F);

        /// <summary>
        /// TPM2.0 Invalid ticket.
        /// </summary>
        public const int TPM_20_E_TICKET = unchecked((int)0x802800A0);

        /// <summary>
        /// TPM2.0 Reserved bits not set to zero as required.
        /// </summary>
        public const int TPM_20_E_RESERVED_BITS = unchecked((int)0x802800A1);

        /// <summary>
        /// TPM2.0 Authorization failure without DA implications.
        /// </summary>
        public const int TPM_20_E_BAD_AUTH = unchecked((int)0x802800A2);

        /// <summary>
        /// TPM2.0 The policy has expired.
        /// </summary>
        public const int TPM_20_E_EXPIRED = unchecked((int)0x802800A3);

        /// <summary>
        /// TPM2.0 The command code in the policy is not the command code of the command or the command code in a policy command references a command that is not implemented.
        /// </summary>
        public const int TPM_20_E_POLICY_CC = unchecked((int)0x802800A4);

        /// <summary>
        /// TPM2.0 Public and sensitive portions of an object are not cryptographically bound.
        /// </summary>
        public const int TPM_20_E_BINDING = unchecked((int)0x802800A5);

        /// <summary>
        /// TPM2.0 Curve not supported.
        /// </summary>
        public const int TPM_20_E_CURVE = unchecked((int)0x802800A6);

        /// <summary>
        /// TPM2.0 Point is not on the required curve.
        /// </summary>
        public const int TPM_20_E_ECC_POINT = unchecked((int)0x802800A7);

        /// <summary>
        /// TPM2.0 TPM not initialized.
        /// </summary>
        public const int TPM_20_E_INITIALIZE = unchecked((int)0x80280100);

        /// <summary>
        /// TPM2.0 Commands not being accepted because of a TPM failure.
        /// </summary>
        public const int TPM_20_E_FAILURE = unchecked((int)0x80280101);

        /// <summary>
        /// TPM2.0 Improper use of a sequence handle.
        /// </summary>
        public const int TPM_20_E_SEQUENCE = unchecked((int)0x80280103);

        /// <summary>
        /// TPM2.0 TPM_RC_PRIVATE error.
        /// </summary>
        public const int TPM_20_E_PRIVATE = unchecked((int)0x8028010B);

        /// <summary>
        /// TPM2.0 TPM_RC_HMAC.
        /// </summary>
        public const int TPM_20_E_HMAC = unchecked((int)0x80280119);

        /// <summary>
        /// TPM2.0 TPM_RC_DISABLED.
        /// </summary>
        public const int TPM_20_E_DISABLED = unchecked((int)0x80280120);

        /// <summary>
        /// TPM2.0 Command failed because audit sequence required exclusivity.
        /// </summary>
        public const int TPM_20_E_EXCLUSIVE = unchecked((int)0x80280121);

        /// <summary>
        /// TPM2.0 Authorization handle is not correct for command.
        /// </summary>
        public const int TPM_20_E_AUTH_TYPE = unchecked((int)0x80280124);

        /// <summary>
        /// TPM2.0 Command requires an authorization session for handle and is not present.
        /// </summary>
        public const int TPM_20_E_AUTH_MISSING = unchecked((int)0x80280125);

        /// <summary>
        /// TPM2.0 Policy failure in Math Operation or an invalid authPolicy value.
        /// </summary>
        public const int TPM_20_E_POLICY = unchecked((int)0x80280126);

        /// <summary>
        /// TPM2.0 PCR check fail.
        /// </summary>
        public const int TPM_20_E_PCR = unchecked((int)0x80280127);

        /// <summary>
        /// TPM2.0 PCR have changed since checked.
        /// </summary>
        public const int TPM_20_E_PCR_CHANGED = unchecked((int)0x80280128);

        /// <summary>
        /// TPM2.0 TPM_RC_UPGRADE.
        /// </summary>
        public const int TPM_20_E_UPGRADE = unchecked((int)0x8028012D);

        /// <summary>
        /// TPM2.0 Context ID counter is at maximum.
        /// </summary>
        public const int TPM_20_E_TOO_MANY_CONTEXTS = unchecked((int)0x8028012E);

        /// <summary>
        /// TPM2.0 authValue or authPolicy is not available for selected entity.
        /// </summary>
        public const int TPM_20_E_AUTH_UNAVAILABLE = unchecked((int)0x8028012F);

        /// <summary>
        /// TPM2.0 A _TPM_Init and Startup(CLEAR) is required before the TPM can resume operation.
        /// </summary>
        public const int TPM_20_E_REBOOT = unchecked((int)0x80280130);

        /// <summary>
        /// TPM2.0 The protection algorithms (hash and symmetric) are not reasonably balanced. The digest size of the hash must be larger than the key size of the symmetric algorithm.
        /// </summary>
        public const int TPM_20_E_UNBALANCED = unchecked((int)0x80280131);

        /// <summary>
        /// TPM2.0 TPM_RC_COMMAND_SIZE.
        /// </summary>
        public const int TPM_20_E_COMMAND_SIZE = unchecked((int)0x80280142);

        /// <summary>
        /// TPM2.0 Command code not supported.
        /// </summary>
        public const int TPM_20_E_COMMAND_CODE = unchecked((int)0x80280143);

        /// <summary>
        /// TPM2.0 The value of authorizationSize is out of range or the number of octets in the authorization Area is greater than required.
        /// </summary>
        public const int TPM_20_E_AUTHSIZE = unchecked((int)0x80280144);

        /// <summary>
        /// TPM2.0 Use of an authorization sessino with a context command or another command that cannot have an authorization session.
        /// </summary>
        public const int TPM_20_E_AUTH_CONTEXT = unchecked((int)0x80280145);

        /// <summary>
        /// TPM2.0 NV offset+size is out of range.
        /// </summary>
        public const int TPM_20_E_NV_RANGE = unchecked((int)0x80280146);

        /// <summary>
        /// TPM2.0 Requested allocation size is larger than allowed.
        /// </summary>
        public const int TPM_20_E_NV_SIZE = unchecked((int)0x80280147);

        /// <summary>
        /// TPM2.0 NV access locked.
        /// </summary>
        public const int TPM_20_E_NV_LOCKED = unchecked((int)0x80280148);

        /// <summary>
        /// TPM2.0 NV access authorization fails in command actions
        /// </summary>
        public const int TPM_20_E_NV_AUTHORIZATION = unchecked((int)0x80280149);

        /// <summary>
        /// TPM2.0 An NV index is used before being initialized or the state saved by TPM2_Shutdown(STATE) could not be restored.
        /// </summary>
        public const int TPM_20_E_UNINITIALIZED = unchecked((int)0x8028014A);

        /// <summary>
        /// TPM2.0 Insufficient space for NV allocation.
        /// </summary>
        public const int TPM_20_E_NV_SPACE = unchecked((int)0x8028014B);

        /// <summary>
        /// TPM2.0 NV index or persistent object already defined.
        /// </summary>
        public const int TPM_20_E_NV_DEFINED = unchecked((int)0x8028014C);

        /// <summary>
        /// TPM2.0 Context in TPM2_ContextLoad() is not valid.
        /// </summary>
        public const int TPM_20_E_BAD_CONTEXT = unchecked((int)0x80280150);

        /// <summary>
        /// TPM2.0 chHash value already set or not correct for use.
        /// </summary>
        public const int TPM_20_E_CPHASH = unchecked((int)0x80280151);

        /// <summary>
        /// TPM2.0 Handle for parent is not a valid parent.
        /// </summary>
        public const int TPM_20_E_PARENT = unchecked((int)0x80280152);

        /// <summary>
        /// TPM2.0 Some function needs testing.
        /// </summary>
        public const int TPM_20_E_NEEDS_TEST = unchecked((int)0x80280153);

        /// <summary>
        /// TPM2.0 TPM_RC_NO_RESULT.
        /// </summary>
        public const int TPM_20_E_NO_RESULT = unchecked((int)0x80280154);

        /// <summary>
        /// TPM2.0 TPM_RC_SENSITIVE.
        /// </summary>
        public const int TPM_20_E_SENSITIVE = unchecked((int)0x80280155);

        //
        // TPM vendor specific hardware errors {0x0400..0x04ff}
        //
        /// <summary>
        /// The command was blocked.
        /// </summary>
        public const int TPM_E_COMMAND_BLOCKED = unchecked((int)0x80280400);

        /// <summary>
        /// The specified handle was not found.
        /// </summary>
        public const int TPM_E_INVALID_HANDLE = unchecked((int)0x80280401);

        /// <summary>
        /// The TPM returned a duplicate handle and the command needs to be resubmitted.
        /// </summary>
        public const int TPM_E_DUPLICATE_VHANDLE = unchecked((int)0x80280402);

        /// <summary>
        /// The command within the transport was blocked.
        /// </summary>
        public const int TPM_E_EMBEDDED_COMMAND_BLOCKED = unchecked((int)0x80280403);

        /// <summary>
        /// The command within the transport is not supported.
        /// </summary>
        public const int TPM_E_EMBEDDED_COMMAND_UNSUPPORTED = unchecked((int)0x80280404);

        //
        // TPM non-fatal hardware errors {0x0800..0x08ff}
        //
        /// <summary>
        /// The TPM is too busy to respond to the command immediately, but the command could be resubmitted at a later time.
        /// </summary>
        public const int TPM_E_RETRY = unchecked((int)0x80280800);

        /// <summary>
        /// SelfTestFull has not been run.
        /// </summary>
        public const int TPM_E_NEEDS_SELFTEST = unchecked((int)0x80280801);

        /// <summary>
        /// The TPM is currently executing a full selftest.
        /// </summary>
        public const int TPM_E_DOING_SELFTEST = unchecked((int)0x80280802);

        /// <summary>
        /// The TPM is defending against dictionary attacks and is in a time-out period.
        /// </summary>
        public const int TPM_E_DEFEND_LOCK_RUNNING = unchecked((int)0x80280803);

        /// <summary>
        /// TPM2.0 Gap for context ID is too large.
        /// </summary>
        public const int TPM_20_E_CONTEXT_GAP = unchecked((int)0x80280901);

        /// <summary>
        /// TPM2.0 Out of memory for object contexts.
        /// </summary>
        public const int TPM_20_E_OBJECT_MEMORY = unchecked((int)0x80280902);

        /// <summary>
        /// TPM2.0 Out of memory for session contexts.
        /// </summary>
        public const int TPM_20_E_SESSION_MEMORY = unchecked((int)0x80280903);

        /// <summary>
        /// TPM2.0 Out of shared object/session memory or need space for internal operations.
        /// </summary>
        public const int TPM_20_E_MEMORY = unchecked((int)0x80280904);

        /// <summary>
        /// TPM2.0 Out of session handles - a session must be flushed before a nes session may be created.
        /// </summary>
        public const int TPM_20_E_SESSION_HANDLES = unchecked((int)0x80280905);

        /// <summary>
        /// TPM2.0 Out of object handles - the handle space for objects is depleted and a reboot is required.
        /// </summary>
        public const int TPM_20_E_OBJECT_HANDLES = unchecked((int)0x80280906);

        /// <summary>
        /// TPM2.0 Bad locality.
        /// </summary>
        public const int TPM_20_E_LOCALITY = unchecked((int)0x80280907);

        /// <summary>
        /// TPM2.0 The TPM has suspended operation on the command; forward progress was made and the command may be retried.
        /// </summary>
        public const int TPM_20_E_YIELDED = unchecked((int)0x80280908);

        /// <summary>
        /// TPM2.0 The command was canceled.
        /// </summary>
        public const int TPM_20_E_CANCELED = unchecked((int)0x80280909);

        /// <summary>
        /// TPM2.0 TPM is performing self-tests.
        /// </summary>
        public const int TPM_20_E_TESTING = unchecked((int)0x8028090A);

        /// <summary>
        /// TPM2.0 The TPM is rate-limiting accesses to prevent wearout of NV
        /// </summary>
        public const int TPM_20_E_NV_RATE = unchecked((int)0x80280920);

        /// <summary>
        /// TPM2.0 Authorization for objects subject to DA protection are not allowed at this time because the TPM is in DA lockout mode.
        /// </summary>
        public const int TPM_20_E_LOCKOUT = unchecked((int)0x80280921);

        /// <summary>
        /// TPM2.0 The TPM was not able to start the command.
        /// </summary>
        public const int TPM_20_E_RETRY = unchecked((int)0x80280922);

        /// <summary>
        /// TPM2.0 the command may require writing of NV and NV is not current accessible.
        /// </summary>
        public const int TPM_20_E_NV_UNAVAILABLE = unchecked((int)0x80280923);

        //
        // TPM Base Services error codes {0x4000..0x40ff}
        //
        /// <summary>
        /// An internal error has occurred within the Trusted Platform Module support program.
        /// </summary>
        public const int TBS_E_INTERNAL_ERROR = unchecked((int)0x80284001);

        /// <summary>
        /// One or more input parameters is bad.
        /// </summary>
        public const int TBS_E_BAD_PARAMETER = unchecked((int)0x80284002);

        /// <summary>
        /// A specified output pointer is bad.
        /// </summary>
        public const int TBS_E_INVALID_OUTPUT_POINTER = unchecked((int)0x80284003);

        /// <summary>
        /// The specified context handle does not refer to a valid context.
        /// </summary>
        public const int TBS_E_INVALID_CONTEXT = unchecked((int)0x80284004);

        /// <summary>
        /// A specified output buffer is too small.
        /// </summary>
        public const int TBS_E_INSUFFICIENT_BUFFER = unchecked((int)0x80284005);

        /// <summary>
        /// An error occurred while communicating with the TPM.
        /// </summary>
        public const int TBS_E_IOERROR = unchecked((int)0x80284006);

        /// <summary>
        /// One or more context parameters is invalid.
        /// </summary>
        public const int TBS_E_INVALID_CONTEXT_PARAM = unchecked((int)0x80284007);

        /// <summary>
        /// The TBS service is not running and could not be started.
        /// </summary>
        public const int TBS_E_SERVICE_NOT_RUNNING = unchecked((int)0x80284008);

        /// <summary>
        /// A new context could not be created because there are too many open contexts.
        /// </summary>
        public const int TBS_E_TOO_MANY_TBS_CONTEXTS = unchecked((int)0x80284009);

        /// <summary>
        /// A new virtual resource could not be created because there are too many open virtual resources.
        /// </summary>
        public const int TBS_E_TOO_MANY_RESOURCES = unchecked((int)0x8028400A);

        /// <summary>
        /// The TBS service has been started but is not yet running.
        /// </summary>
        public const int TBS_E_SERVICE_START_PENDING = unchecked((int)0x8028400B);

        /// <summary>
        /// The physical presence interface is not supported.
        /// </summary>
        public const int TBS_E_PPI_NOT_SUPPORTED = unchecked((int)0x8028400C);

        /// <summary>
        /// The command was canceled.
        /// </summary>
        public const int TBS_E_COMMAND_CANCELED = unchecked((int)0x8028400D);

        /// <summary>
        /// The input or output buffer is too large.
        /// </summary>
        public const int TBS_E_BUFFER_TOO_LARGE = unchecked((int)0x8028400E);

        /// <summary>
        /// A compatible Trusted Platform Module (TPM) Security Device cannot be found on this computer.
        /// </summary>
        public const int TBS_E_TPM_NOT_FOUND = unchecked((int)0x8028400F);

        /// <summary>
        /// The TBS service has been disabled.
        /// </summary>
        public const int TBS_E_SERVICE_DISABLED = unchecked((int)0x80284010);

        /// <summary>
        /// No TCG event log is available.
        /// </summary>
        public const int TBS_E_NO_EVENT_LOG = unchecked((int)0x80284011);

        /// <summary>
        /// The caller does not have the appropriate rights to perform the requested operation.
        /// </summary>
        public const int TBS_E_ACCESS_DENIED = unchecked((int)0x80284012);

        /// <summary>
        /// The TPM provisioning action is not allowed by the specified flags.  For provisioning to be successful, one of several actions may be required.  The TPM management console (tpm.msc) action to make the TPM Ready may help.  For further information, see the documentation for the Win32_Tpm WMI method 'Provision'.  (The actions that may be required include importing the TPM Owner Authorization value into the system, calling the Win32_Tpm WMI method for provisioning the TPM and specifying TRUE for either 'ForceClear_Allowed' or 'PhysicalPresencePrompts_Allowed' (as indicated by the value returned in the Additional Information), or enabling the TPM in the system BIOS.)
        /// </summary>
        public const int TBS_E_PROVISIONING_NOT_ALLOWED = unchecked((int)0x80284013);

        /// <summary>
        /// The Physical Presence Interface of this firmware does not support the requested method.
        /// </summary>
        public const int TBS_E_PPI_FUNCTION_UNSUPPORTED = unchecked((int)0x80284014);

        /// <summary>
        /// The requested TPM OwnerAuth value was not found.
        /// </summary>
        public const int TBS_E_OWNERAUTH_NOT_FOUND = unchecked((int)0x80284015);

        /// <summary>
        /// The TPM provisioning did not complete.  For more information on completing the provisioning, call the Win32_Tpm WMI method for provisioning the TPM ('Provision') and check the returned Information.
        /// </summary>
        public const int TBS_E_PROVISIONING_INCOMPLETE = unchecked((int)0x80284016);

        //
        // TPM API error codes {0x0100..0x01ff}
        //
        /// <summary>
        /// The command buffer is not in the correct state.
        /// </summary>
        public const int TPMAPI_E_INVALID_STATE = unchecked((int)0x80290100);

        /// <summary>
        /// The command buffer does not contain enough data to satisfy the request.
        /// </summary>
        public const int TPMAPI_E_NOT_ENOUGH_DATA = unchecked((int)0x80290101);

        /// <summary>
        /// The command buffer cannot contain any more data.
        /// </summary>
        public const int TPMAPI_E_TOO_MUCH_DATA = unchecked((int)0x80290102);

        /// <summary>
        /// One or more output parameters was NULL or invalid.
        /// </summary>
        public const int TPMAPI_E_INVALID_OUTPUT_POINTER = unchecked((int)0x80290103);

        /// <summary>
        /// One or more input parameters is invalid.
        /// </summary>
        public const int TPMAPI_E_INVALID_PARAMETER = unchecked((int)0x80290104);

        /// <summary>
        /// Not enough memory was available to satisfy the request.
        /// </summary>
        public const int TPMAPI_E_OUT_OF_MEMORY = unchecked((int)0x80290105);

        /// <summary>
        /// The specified buffer was too small.
        /// </summary>
        public const int TPMAPI_E_BUFFER_TOO_SMALL = unchecked((int)0x80290106);

        /// <summary>
        /// An internal error was detected.
        /// </summary>
        public const int TPMAPI_E_INTERNAL_ERROR = unchecked((int)0x80290107);

        /// <summary>
        /// The caller does not have the appropriate rights to perform the requested operation.
        /// </summary>
        public const int TPMAPI_E_ACCESS_DENIED = unchecked((int)0x80290108);

        /// <summary>
        /// The specified authorization information was invalid.
        /// </summary>
        public const int TPMAPI_E_AUTHORIZATION_FAILED = unchecked((int)0x80290109);

        /// <summary>
        /// The specified context handle was not valid.
        /// </summary>
        public const int TPMAPI_E_INVALID_CONTEXT_HANDLE = unchecked((int)0x8029010A);

        /// <summary>
        /// An error occurred while communicating with the TBS.
        /// </summary>
        public const int TPMAPI_E_TBS_COMMUNICATION_ERROR = unchecked((int)0x8029010B);

        /// <summary>
        /// The TPM returned an unexpected result.
        /// </summary>
        public const int TPMAPI_E_TPM_COMMAND_ERROR = unchecked((int)0x8029010C);

        /// <summary>
        /// The message was too large for the encoding scheme.
        /// </summary>
        public const int TPMAPI_E_MESSAGE_TOO_LARGE = unchecked((int)0x8029010D);

        /// <summary>
        /// The encoding in the blob was not recognized.
        /// </summary>
        public const int TPMAPI_E_INVALID_ENCODING = unchecked((int)0x8029010E);

        /// <summary>
        /// The key size is not valid.
        /// </summary>
        public const int TPMAPI_E_INVALID_KEY_SIZE = unchecked((int)0x8029010F);

        /// <summary>
        /// The encryption operation failed.
        /// </summary>
        public const int TPMAPI_E_ENCRYPTION_FAILED = unchecked((int)0x80290110);

        /// <summary>
        /// The key parameters structure was not valid
        /// </summary>
        public const int TPMAPI_E_INVALID_KEY_PARAMS = unchecked((int)0x80290111);

        /// <summary>
        /// The requested supplied data does not appear to be a valid migration authorization blob.
        /// </summary>
        public const int TPMAPI_E_INVALID_MIGRATION_AUTHORIZATION_BLOB = unchecked((int)0x80290112);

        /// <summary>
        /// The specified PCR index was invalid
        /// </summary>
        public const int TPMAPI_E_INVALID_PCR_INDEX = unchecked((int)0x80290113);

        /// <summary>
        /// The data given does not appear to be a valid delegate blob.
        /// </summary>
        public const int TPMAPI_E_INVALID_DELEGATE_BLOB = unchecked((int)0x80290114);

        /// <summary>
        /// One or more of the specified context parameters was not valid.
        /// </summary>
        public const int TPMAPI_E_INVALID_CONTEXT_PARAMS = unchecked((int)0x80290115);

        /// <summary>
        /// The data given does not appear to be a valid key blob
        /// </summary>
        public const int TPMAPI_E_INVALID_KEY_BLOB = unchecked((int)0x80290116);

        /// <summary>
        /// The specified PCR data was invalid.
        /// </summary>
        public const int TPMAPI_E_INVALID_PCR_DATA = unchecked((int)0x80290117);

        /// <summary>
        /// The format of the owner auth data was invalid.
        /// </summary>
        public const int TPMAPI_E_INVALID_OWNER_AUTH = unchecked((int)0x80290118);

        /// <summary>
        /// The random number generated did not pass FIPS RNG check.
        /// </summary>
        public const int TPMAPI_E_FIPS_RNG_CHECK_FAILED = unchecked((int)0x80290119);

        /// <summary>
        /// The TCG Event Log does not contain any data.
        /// </summary>
        public const int TPMAPI_E_EMPTY_TCG_LOG = unchecked((int)0x8029011A);

        /// <summary>
        /// An entry in the TCG Event Log was invalid.
        /// </summary>
        public const int TPMAPI_E_INVALID_TCG_LOG_ENTRY = unchecked((int)0x8029011B);

        /// <summary>
        /// A TCG Separator was not found.
        /// </summary>
        public const int TPMAPI_E_TCG_SEPARATOR_ABSENT = unchecked((int)0x8029011C);

        /// <summary>
        /// A digest value in a TCG Log entry did not match hashed data.
        /// </summary>
        public const int TPMAPI_E_TCG_INVALID_DIGEST_ENTRY = unchecked((int)0x8029011D);

        /// <summary>
        /// The requested operation was blocked by current TPM policy. Please contact your system administrator for assistance.
        /// </summary>
        public const int TPMAPI_E_POLICY_DENIES_OPERATION = unchecked((int)0x8029011E);

        //
        // TBS implementation error codes {0x0200..0x02ff}
        //
        /// <summary>
        /// The specified buffer was too small.
        /// </summary>
        public const int TBSIMP_E_BUFFER_TOO_SMALL = unchecked((int)0x80290200);

        /// <summary>
        /// The context could not be cleaned up.
        /// </summary>
        public const int TBSIMP_E_CLEANUP_FAILED = unchecked((int)0x80290201);

        /// <summary>
        /// The specified context handle is invalid.
        /// </summary>
        public const int TBSIMP_E_INVALID_CONTEXT_HANDLE = unchecked((int)0x80290202);

        /// <summary>
        /// An invalid context parameter was specified.
        /// </summary>
        public const int TBSIMP_E_INVALID_CONTEXT_PARAM = unchecked((int)0x80290203);

        /// <summary>
        /// An error occurred while communicating with the TPM
        /// </summary>
        public const int TBSIMP_E_TPM_ERROR = unchecked((int)0x80290204);

        /// <summary>
        /// No entry with the specified key was found.
        /// </summary>
        public const int TBSIMP_E_HASH_BAD_KEY = unchecked((int)0x80290205);

        /// <summary>
        /// The specified virtual handle matches a virtual handle already in use.
        /// </summary>
        public const int TBSIMP_E_DUPLICATE_VHANDLE = unchecked((int)0x80290206);

        /// <summary>
        /// The pointer to the returned handle location was NULL or invalid
        /// </summary>
        public const int TBSIMP_E_INVALID_OUTPUT_POINTER = unchecked((int)0x80290207);

        /// <summary>
        /// One or more parameters is invalid
        /// </summary>
        public const int TBSIMP_E_INVALID_PARAMETER = unchecked((int)0x80290208);

        /// <summary>
        /// The RPC subsystem could not be initialized.
        /// </summary>
        public const int TBSIMP_E_RPC_INIT_FAILED = unchecked((int)0x80290209);

        /// <summary>
        /// The TBS scheduler is not running.
        /// </summary>
        public const int TBSIMP_E_SCHEDULER_NOT_RUNNING = unchecked((int)0x8029020A);

        /// <summary>
        /// The command was canceled.
        /// </summary>
        public const int TBSIMP_E_COMMAND_CANCELED = unchecked((int)0x8029020B);

        /// <summary>
        /// There was not enough memory to fulfill the request
        /// </summary>
        public const int TBSIMP_E_OUT_OF_MEMORY = unchecked((int)0x8029020C);

        /// <summary>
        /// The specified list is empty, or the iteration has reached the end of the list.
        /// </summary>
        public const int TBSIMP_E_LIST_NO_MORE_ITEMS = unchecked((int)0x8029020D);

        /// <summary>
        /// The specified item was not found in the list.
        /// </summary>
        public const int TBSIMP_E_LIST_NOT_FOUND = unchecked((int)0x8029020E);

        /// <summary>
        /// The TPM does not have enough space to load the requested resource.
        /// </summary>
        public const int TBSIMP_E_NOT_ENOUGH_SPACE = unchecked((int)0x8029020F);

        /// <summary>
        /// There are too many TPM contexts in use.
        /// </summary>
        public const int TBSIMP_E_NOT_ENOUGH_TPM_CONTEXTS = unchecked((int)0x80290210);

        /// <summary>
        /// The TPM command failed.
        /// </summary>
        public const int TBSIMP_E_COMMAND_FAILED = unchecked((int)0x80290211);

        /// <summary>
        /// The TBS does not recognize the specified ordinal.
        /// </summary>
        public const int TBSIMP_E_UNKNOWN_ORDINAL = unchecked((int)0x80290212);

        /// <summary>
        /// The requested resource is no longer available.
        /// </summary>
        public const int TBSIMP_E_RESOURCE_EXPIRED = unchecked((int)0x80290213);

        /// <summary>
        /// The resource type did not match.
        /// </summary>
        public const int TBSIMP_E_INVALID_RESOURCE = unchecked((int)0x80290214);

        /// <summary>
        /// No resources can be unloaded.
        /// </summary>
        public const int TBSIMP_E_NOTHING_TO_UNLOAD = unchecked((int)0x80290215);

        /// <summary>
        /// No new entries can be added to the hash table.
        /// </summary>
        public const int TBSIMP_E_HASH_TABLE_FULL = unchecked((int)0x80290216);

        /// <summary>
        /// A new TBS context could not be created because there are too many open contexts.
        /// </summary>
        public const int TBSIMP_E_TOO_MANY_TBS_CONTEXTS = unchecked((int)0x80290217);

        /// <summary>
        /// A new virtual resource could not be created because there are too many open virtual resources.
        /// </summary>
        public const int TBSIMP_E_TOO_MANY_RESOURCES = unchecked((int)0x80290218);

        /// <summary>
        /// The physical presence interface is not supported.
        /// </summary>
        public const int TBSIMP_E_PPI_NOT_SUPPORTED = unchecked((int)0x80290219);

        /// <summary>
        /// TBS is not compatible with the version of TPM found on the system.
        /// </summary>
        public const int TBSIMP_E_TPM_INCOMPATIBLE = unchecked((int)0x8029021A);

        /// <summary>
        /// No TCG event log is available.
        /// </summary>
        public const int TBSIMP_E_NO_EVENT_LOG = unchecked((int)0x8029021B);

        //
        // TPM Physical Presence implementation error codes {0x0300..0x03ff}
        //
        /// <summary>
        /// A general error was detected when attempting to acquire the BIOS's response to a Physical Presence command.
        /// </summary>
        public const int TPM_E_PPI_ACPI_FAILURE = unchecked((int)0x80290300);

        /// <summary>
        /// The user failed to confirm the TPM operation request.
        /// </summary>
        public const int TPM_E_PPI_USER_ABORT = unchecked((int)0x80290301);

        /// <summary>
        /// The BIOS failure prevented the successful execution of the requested TPM operation (e.g. invalid TPM operation request, BIOS communication error with the TPM).
        /// </summary>
        public const int TPM_E_PPI_BIOS_FAILURE = unchecked((int)0x80290302);

        /// <summary>
        /// The BIOS does not support the physical presence interface.
        /// </summary>
        public const int TPM_E_PPI_NOT_SUPPORTED = unchecked((int)0x80290303);

        /// <summary>
        /// The Physical Presence command was blocked by current BIOS settings. The system owner may be able to reconfigure the BIOS settings to allow the command.
        /// </summary>
        public const int TPM_E_PPI_BLOCKED_IN_BIOS = unchecked((int)0x80290304);

        //
        // Platform Crypto Provider (PCPTPM12.dll and future platform crypto providers)  error codes {0x0400..0x04ff}
        //
        /// <summary>
        /// This is an error mask to convert Platform Crypto Provider errors to win errors.
        /// </summary>
        public const int TPM_E_PCP_ERROR_MASK = unchecked((int)0x80290400);

        /// <summary>
        /// The Platform Crypto Device is currently not ready. It needs to be fully provisioned to be operational.
        /// </summary>
        public const int TPM_E_PCP_DEVICE_NOT_READY = unchecked((int)0x80290401);

        /// <summary>
        /// The handle provided to the Platform Crypto Provider is invalid.
        /// </summary>
        public const int TPM_E_PCP_INVALID_HANDLE = unchecked((int)0x80290402);

        /// <summary>
        /// A parameter provided to the Platform Crypto Provider is invalid.
        /// </summary>
        public const int TPM_E_PCP_INVALID_PARAMETER = unchecked((int)0x80290403);

        /// <summary>
        /// A provided flag to the Platform Crypto Provider is not supported.
        /// </summary>
        public const int TPM_E_PCP_FLAG_NOT_SUPPORTED = unchecked((int)0x80290404);

        /// <summary>
        /// The requested operation is not supported by this Platform Crypto Provider.
        /// </summary>
        public const int TPM_E_PCP_NOT_SUPPORTED = unchecked((int)0x80290405);

        /// <summary>
        /// The buffer is too small to contain all data. No information has been written to the buffer.
        /// </summary>
        public const int TPM_E_PCP_BUFFER_TOO_SMALL = unchecked((int)0x80290406);

        /// <summary>
        /// An unexpected internal error has occurred in the Platform Crypto Provider.
        /// </summary>
        public const int TPM_E_PCP_INTERNAL_ERROR = unchecked((int)0x80290407);

        /// <summary>
        /// The authorization to use a provider object has failed.
        /// </summary>
        public const int TPM_E_PCP_AUTHENTICATION_FAILED = unchecked((int)0x80290408);

        /// <summary>
        /// The Platform Crypto Device has ignored the authorization for the provider object, to mitigate against a dictionary attack.
        /// </summary>
        public const int TPM_E_PCP_AUTHENTICATION_IGNORED = unchecked((int)0x80290409);

        /// <summary>
        /// The referenced policy was not found.
        /// </summary>
        public const int TPM_E_PCP_POLICY_NOT_FOUND = unchecked((int)0x8029040A);

        /// <summary>
        /// The referenced profile was not found.
        /// </summary>
        public const int TPM_E_PCP_PROFILE_NOT_FOUND = unchecked((int)0x8029040B);

        /// <summary>
        /// The validation was not succesful.
        /// </summary>
        public const int TPM_E_PCP_VALIDATION_FAILED = unchecked((int)0x8029040C);

        /// <summary>
        /// An attempt was made to import or load a key under an incorrect storage parent.
        /// </summary>
        public const int TPM_E_PCP_WRONG_PARENT = unchecked((int)0x8029040E);

        /// <summary>
        /// The TPM key is not loaded.
        /// </summary>
        public const int TPM_E_KEY_NOT_LOADED = unchecked((int)0x8029040F);

        /// <summary>
        /// The TPM key certification has not been generated.
        /// </summary>
        public const int TPM_E_NO_KEY_CERTIFICATION = unchecked((int)0x80290410);

        /// <summary>
        /// The TPM key is not yet finalized.
        /// </summary>
        public const int TPM_E_KEY_NOT_FINALIZED = unchecked((int)0x80290411);

        /// <summary>
        /// The TPM attestation challenge is not set.
        /// </summary>
        public const int TPM_E_ATTESTATION_CHALLENGE_NOT_SET = unchecked((int)0x80290412);

        /// <summary>
        /// The TPM PCR info is not available.
        /// </summary>
        public const int TPM_E_NOT_PCR_BOUND = unchecked((int)0x80290413);

        /// <summary>
        /// The TPM key is already finalized.
        /// </summary>
        public const int TPM_E_KEY_ALREADY_FINALIZED = unchecked((int)0x80290414);

        /// <summary>
        /// The TPM key usage policy is not supported.
        /// </summary>
        public const int TPM_E_KEY_USAGE_POLICY_NOT_SUPPORTED = unchecked((int)0x80290415);

        /// <summary>
        /// The TPM key usage policy is invalid.
        /// </summary>
        public const int TPM_E_KEY_USAGE_POLICY_INVALID = unchecked((int)0x80290416);

        /// <summary>
        /// There was a problem with the software key being imported into the TPM.
        /// </summary>
        public const int TPM_E_SOFT_KEY_ERROR = unchecked((int)0x80290417);

        /// <summary>
        /// The TPM key is not authenticated.
        /// </summary>
        public const int TPM_E_KEY_NOT_AUTHENTICATED = unchecked((int)0x80290418);

        /// <summary>
        /// The TPM key is not an AIK.
        /// </summary>
        public const int TPM_E_PCP_KEY_NOT_AIK = unchecked((int)0x80290419);

        /// <summary>
        /// The TPM key is not a signing key.
        /// </summary>
        public const int TPM_E_KEY_NOT_SIGNING_KEY = unchecked((int)0x8029041A);

        /// <summary>
        /// The TPM is locked out.
        /// </summary>
        public const int TPM_E_LOCKED_OUT = unchecked((int)0x8029041B);

        /// <summary>
        /// The claim type requested is not supported.
        /// </summary>
        public const int TPM_E_CLAIM_TYPE_NOT_SUPPORTED = unchecked((int)0x8029041C);

        /// <summary>
        /// TPM version is not supported.
        /// </summary>
        public const int TPM_E_VERSION_NOT_SUPPORTED = unchecked((int)0x8029041D);

        /// <summary>
        /// The buffer lengths do not match.
        /// </summary>
        public const int TPM_E_BUFFER_LENGTH_MISMATCH = unchecked((int)0x8029041E);

        /// <summary>
        /// The RSA key creation is blocked on this TPM due to known security vulnerabilities.
        /// </summary>
        public const int TPM_E_PCP_IFX_RSA_KEY_CREATION_BLOCKED = unchecked((int)0x8029041F);

        /// <summary>
        /// A ticket required to use a key was not provided.
        /// </summary>
        public const int TPM_E_PCP_TICKET_MISSING = unchecked((int)0x80290420);

        /// <summary>
        /// This key has a raw policy so the KSP can't authenticate against it.
        /// </summary>
        public const int TPM_E_PCP_RAW_POLICY_NOT_SUPPORTED = unchecked((int)0x80290421);

        //
        // Misc error codes in TPM code {0x0500..0x05ff}
        //
        /// <summary>
        /// TPM related network operations are blocked as Zero Exhaust mode is enabled on client.
        /// </summary>
        public const int TPM_E_ZERO_EXHAUST_ENABLED = unchecked((int)0x80290500);

        //
        // If the application is designed to use TCG defined TPM return codes
        // then undefine the Windows defined codes for the same symbols. The application
        // declares usage of TCG return codes by defining WIN_OMIT_TSS_TPM_RETURN_CODES
        // before including windows.h
        //

        //
        // =======================================================
        // Facility Performance Logs & Alerts (PLA) Error Messages
        // =======================================================
        //
        /// <summary>
        /// Data Collector Set was not found.
        /// </summary>
        public const int PLA_E_DCS_NOT_FOUND = unchecked((int)0x80300002);

        /// <summary>
        /// The Data Collector Set or one of its dependencies is already in use.
        /// </summary>
        public const int PLA_E_DCS_IN_USE = unchecked((int)0x803000AA);

        /// <summary>
        /// Unable to start Data Collector Set because there are too many folders.
        /// </summary>
        public const int PLA_E_TOO_MANY_FOLDERS = unchecked((int)0x80300045);

        /// <summary>
        /// Not enough free disk space to start Data Collector Set.
        /// </summary>
        public const int PLA_E_NO_MIN_DISK = unchecked((int)0x80300070);

        /// <summary>
        /// Data Collector Set already exists.
        /// </summary>
        public const int PLA_E_DCS_ALREADY_EXISTS = unchecked((int)0x803000B7);

        /// <summary>
        /// Property value will be ignored.
        /// </summary>
        public const int PLA_S_PROPERTY_IGNORED = 0x00300100;

        /// <summary>
        /// Property value conflict.
        /// </summary>
        public const int PLA_E_PROPERTY_CONFLICT = unchecked((int)0x80300101);

        /// <summary>
        /// The current configuration for this Data Collector Set requires that it contain exactly one Data Collector.
        /// </summary>
        public const int PLA_E_DCS_SINGLETON_REQUIRED = unchecked((int)0x80300102);

        /// <summary>
        /// A user account is required in order to commit the current Data Collector Set properties.
        /// </summary>
        public const int PLA_E_CREDENTIALS_REQUIRED = unchecked((int)0x80300103);

        /// <summary>
        /// Data Collector Set is not running.
        /// </summary>
        public const int PLA_E_DCS_NOT_RUNNING = unchecked((int)0x80300104);

        /// <summary>
        /// A conflict was detected in the list of include/exclude APIs. Do not specify the same API in both the include list and the exclude list.
        /// </summary>
        public const int PLA_E_CONFLICT_INCL_EXCL_API = unchecked((int)0x80300105);

        /// <summary>
        /// The executable path you have specified refers to a network share or UNC path.
        /// </summary>
        public const int PLA_E_NETWORK_EXE_NOT_VALID = unchecked((int)0x80300106);

        /// <summary>
        /// The executable path you have specified is already configured for API tracing.
        /// </summary>
        public const int PLA_E_EXE_ALREADY_CONFIGURED = unchecked((int)0x80300107);

        /// <summary>
        /// The executable path you have specified does not exist. Verify that the specified path is correct.
        /// </summary>
        public const int PLA_E_EXE_PATH_NOT_VALID = unchecked((int)0x80300108);

        /// <summary>
        /// Data Collector already exists.
        /// </summary>
        public const int PLA_E_DC_ALREADY_EXISTS = unchecked((int)0x80300109);

        /// <summary>
        /// The wait for the Data Collector Set start notification has timed out.
        /// </summary>
        public const int PLA_E_DCS_START_WAIT_TIMEOUT = unchecked((int)0x8030010A);

        /// <summary>
        /// The wait for the Data Collector to start has timed out.
        /// </summary>
        public const int PLA_E_DC_START_WAIT_TIMEOUT = unchecked((int)0x8030010B);

        /// <summary>
        /// The wait for the report generation tool to finish has timed out.
        /// </summary>
        public const int PLA_E_REPORT_WAIT_TIMEOUT = unchecked((int)0x8030010C);

        /// <summary>
        /// Duplicate items are not allowed.
        /// </summary>
        public const int PLA_E_NO_DUPLICATES = unchecked((int)0x8030010D);

        /// <summary>
        /// When specifying the executable that you want to trace, you must specify a full path to the executable and not just a filename.
        /// </summary>
        public const int PLA_E_EXE_FULL_PATH_REQUIRED = unchecked((int)0x8030010E);

        /// <summary>
        /// The session name provided is invalid.
        /// </summary>
        public const int PLA_E_INVALID_SESSION_NAME = unchecked((int)0x8030010F);

        /// <summary>
        /// The Event Log channel Microsoft-Windows-Diagnosis-PLA/Operational must be enabled to perform this operation.
        /// </summary>
        public const int PLA_E_PLA_CHANNEL_NOT_ENABLED = unchecked((int)0x80300110);

        /// <summary>
        /// The Event Log channel Microsoft-Windows-TaskScheduler must be enabled to perform this operation.
        /// </summary>
        public const int PLA_E_TASKSCHED_CHANNEL_NOT_ENABLED = unchecked((int)0x80300111);

        /// <summary>
        /// The execution of the Rules Manager failed.
        /// </summary>
        public const int PLA_E_RULES_MANAGER_FAILED = unchecked((int)0x80300112);

        /// <summary>
        /// An error occurred while attempting to compress or extract the data.
        /// </summary>
        public const int PLA_E_CABAPI_FAILURE = unchecked((int)0x80300113);

        //
        // =======================================================
        // Full Volume Encryption Error Messages
        // =======================================================
        //
        /// <summary>
        /// This drive is locked by BitLocker Drive Encryption. You must unlock this drive from Control Panel.
        /// </summary>
        public const int FVE_E_LOCKED_VOLUME = unchecked((int)0x80310000);

        /// <summary>
        /// This drive is not encrypted.
        /// </summary>
        public const int FVE_E_NOT_ENCRYPTED = unchecked((int)0x80310001);

        /// <summary>
        /// The BIOS did not correctly communicate with the Trusted Platform Module (TPM). Contact the computer manufacturer for BIOS upgrade instructions.
        /// </summary>
        public const int FVE_E_NO_TPM_BIOS = unchecked((int)0x80310002);

        /// <summary>
        /// The BIOS did not correctly communicate with the master boot record (MBR). Contact the computer manufacturer for BIOS upgrade instructions.
        /// </summary>
        public const int FVE_E_NO_MBR_METRIC = unchecked((int)0x80310003);

        /// <summary>
        /// A required TPM measurement is missing. If there is a bootable CD or DVD in your computer, remove it, restart the computer, and turn on BitLocker again. If the problem persists, ensure the master boot record is up to date.
        /// </summary>
        public const int FVE_E_NO_BOOTSECTOR_METRIC = unchecked((int)0x80310004);

        /// <summary>
        /// The boot sector of this drive is not compatible with BitLocker Drive Encryption. Use the Bootrec.exe tool in the Windows Recovery Environment to update or repair the boot manager (BOOTMGR).
        /// </summary>
        public const int FVE_E_NO_BOOTMGR_METRIC = unchecked((int)0x80310005);

        /// <summary>
        /// The boot manager of this operating system is not compatible with BitLocker Drive Encryption. Use the Bootrec.exe tool in the Windows Recovery Environment to update or repair the boot manager (BOOTMGR).
        /// </summary>
        public const int FVE_E_WRONG_BOOTMGR = unchecked((int)0x80310006);

        /// <summary>
        /// At least one secure key protector is required for this operation to be performed.
        /// </summary>
        public const int FVE_E_SECURE_KEY_REQUIRED = unchecked((int)0x80310007);

        /// <summary>
        /// BitLocker Drive Encryption is not enabled on this drive. Turn on BitLocker.
        /// </summary>
        public const int FVE_E_NOT_ACTIVATED = unchecked((int)0x80310008);

        /// <summary>
        /// BitLocker Drive Encryption cannot perform the requested action. This condition may occur when two requests are issued at the same time. Wait a few moments and then try the action again.
        /// </summary>
        public const int FVE_E_ACTION_NOT_ALLOWED = unchecked((int)0x80310009);

        /// <summary>
        /// The Active Directory Domain Services forest does not contain the required attributes and classes to host BitLocker Drive Encryption or Trusted Platform Module information. Contact your domain administrator to verify that any required BitLocker Active Directory schema extensions have been installed.
        /// </summary>
        public const int FVE_E_AD_SCHEMA_NOT_INSTALLED = unchecked((int)0x8031000A);

        /// <summary>
        /// The type of the data obtained from Active Directory was not expected. The BitLocker recovery information may be missing or corrupted.
        /// </summary>
        public const int FVE_E_AD_INVALID_DATATYPE = unchecked((int)0x8031000B);

        /// <summary>
        /// The size of the data obtained from Active Directory was not expected. The BitLocker recovery information may be missing or corrupted.
        /// </summary>
        public const int FVE_E_AD_INVALID_DATASIZE = unchecked((int)0x8031000C);

        /// <summary>
        /// The attribute read from Active Directory does not contain any values. The BitLocker recovery information may be missing or corrupted.
        /// </summary>
        public const int FVE_E_AD_NO_VALUES = unchecked((int)0x8031000D);

        /// <summary>
        /// The attribute was not set. Verify that you are logged on with a domain account that has the ability to write information to Active Directory objects.
        /// </summary>
        public const int FVE_E_AD_ATTR_NOT_SET = unchecked((int)0x8031000E);

        /// <summary>
        /// The specified attribute cannot be found in Active Directory Domain Services. Contact your domain administrator to verify that any required BitLocker Active Directory schema extensions have been installed.
        /// </summary>
        public const int FVE_E_AD_GUID_NOT_FOUND = unchecked((int)0x8031000F);

        /// <summary>
        /// The BitLocker metadata for the encrypted drive is not valid. You can attempt to repair the drive to restore access.
        /// </summary>
        public const int FVE_E_BAD_INFORMATION = unchecked((int)0x80310010);

        /// <summary>
        /// The drive cannot be encrypted because it does not have enough free space. Delete any unnecessary data on the drive to create additional free space and then try again.
        /// </summary>
        public const int FVE_E_TOO_SMALL = unchecked((int)0x80310011);

        /// <summary>
        /// The drive cannot be encrypted because it contains system boot information. Create a separate partition for use as the system drive that contains the boot information and a second partition for use as the operating system drive and then encrypt the operating system drive.
        /// </summary>
        public const int FVE_E_SYSTEM_VOLUME = unchecked((int)0x80310012);

        /// <summary>
        /// The drive cannot be encrypted because the file system is not supported.
        /// </summary>
        public const int FVE_E_FAILED_WRONG_FS = unchecked((int)0x80310013);

        /// <summary>
        /// The file system size is larger than the partition size in the partition table. This drive may be corrupt or may have been tampered with. To use it with BitLocker, you must reformat the partition.
        /// </summary>
        public const int FVE_E_BAD_PARTITION_SIZE = unchecked((int)0x80310014);

        /// <summary>
        /// This drive cannot be encrypted.
        /// </summary>
        public const int FVE_E_NOT_SUPPORTED = unchecked((int)0x80310015);

        /// <summary>
        /// The data is not valid.
        /// </summary>
        public const int FVE_E_BAD_DATA = unchecked((int)0x80310016);

        /// <summary>
        /// The data drive specified is not set to automatically unlock on the current computer and cannot be unlocked automatically.
        /// </summary>
        public const int FVE_E_VOLUME_NOT_BOUND = unchecked((int)0x80310017);

        /// <summary>
        /// You must initialize the Trusted Platform Module (TPM) before you can use BitLocker Drive Encryption.
        /// </summary>
        public const int FVE_E_TPM_NOT_OWNED = unchecked((int)0x80310018);

        /// <summary>
        /// The operation attempted cannot be performed on an operating system drive.
        /// </summary>
        public const int FVE_E_NOT_DATA_VOLUME = unchecked((int)0x80310019);

        /// <summary>
        /// The buffer supplied to a function was insufficient to contain the returned data. Increase the buffer size before running the function again.
        /// </summary>
        public const int FVE_E_AD_INSUFFICIENT_BUFFER = unchecked((int)0x8031001A);

        /// <summary>
        /// A read operation failed while converting the drive. The drive was not converted. Please re-enable BitLocker.
        /// </summary>
        public const int FVE_E_CONV_READ = unchecked((int)0x8031001B);

        /// <summary>
        /// A write operation failed while converting the drive. The drive was not converted. Please re-enable BitLocker.
        /// </summary>
        public const int FVE_E_CONV_WRITE = unchecked((int)0x8031001C);

        /// <summary>
        /// One or more BitLocker key protectors are required. You cannot delete the last key on this drive.
        /// </summary>
        public const int FVE_E_KEY_REQUIRED = unchecked((int)0x8031001D);

        /// <summary>
        /// Cluster configurations are not supported by BitLocker Drive Encryption.
        /// </summary>
        public const int FVE_E_CLUSTERING_NOT_SUPPORTED = unchecked((int)0x8031001E);

        /// <summary>
        /// The drive specified is already configured to be automatically unlocked on the current computer.
        /// </summary>
        public const int FVE_E_VOLUME_BOUND_ALREADY = unchecked((int)0x8031001F);

        /// <summary>
        /// The operating system drive is not protected by BitLocker Drive Encryption.
        /// </summary>
        public const int FVE_E_OS_NOT_PROTECTED = unchecked((int)0x80310020);

        /// <summary>
        /// BitLocker Drive Encryption has been suspended on this drive. All BitLocker key protectors configured for this drive are effectively disabled, and the drive will be automatically unlocked using an unencrypted (clear) key.
        /// </summary>
        public const int FVE_E_PROTECTION_DISABLED = unchecked((int)0x80310021);

        /// <summary>
        /// The drive you are attempting to lock does not have any key protectors available for encryption because BitLocker protection is currently suspended. Re-enable BitLocker to lock this drive.
        /// </summary>
        public const int FVE_E_RECOVERY_KEY_REQUIRED = unchecked((int)0x80310022);

        /// <summary>
        /// BitLocker cannot use the Trusted Platform Module (TPM) to protect a data drive. TPM protection can only be used with the operating system drive.
        /// </summary>
        public const int FVE_E_FOREIGN_VOLUME = unchecked((int)0x80310023);

        /// <summary>
        /// The BitLocker metadata for the encrypted drive cannot be updated because it was locked for updating by another process. Please try this process again.
        /// </summary>
        public const int FVE_E_OVERLAPPED_UPDATE = unchecked((int)0x80310024);

        /// <summary>
        /// The authorization data for the storage root key (SRK) of the Trusted Platform Module (TPM) is not zero and is therefore incompatible with BitLocker. Please initialize the TPM before attempting to use it with BitLocker.
        /// </summary>
        public const int FVE_E_TPM_SRK_AUTH_NOT_ZERO = unchecked((int)0x80310025);

        /// <summary>
        /// The drive encryption algorithm cannot be used on this sector size.
        /// </summary>
        public const int FVE_E_FAILED_SECTOR_SIZE = unchecked((int)0x80310026);

        /// <summary>
        /// The drive cannot be unlocked with the key provided. Confirm that you have provided the correct key and try again.
        /// </summary>
        public const int FVE_E_FAILED_AUTHENTICATION = unchecked((int)0x80310027);

        /// <summary>
        /// The drive specified is not the operating system drive.
        /// </summary>
        public const int FVE_E_NOT_OS_VOLUME = unchecked((int)0x80310028);

        /// <summary>
        /// BitLocker Drive Encryption cannot be turned off on the operating system drive until the auto unlock feature has been disabled for the fixed data drives and removable data drives associated with this computer.
        /// </summary>
        public const int FVE_E_AUTOUNLOCK_ENABLED = unchecked((int)0x80310029);

        /// <summary>
        /// The system partition boot sector does not perform Trusted Platform Module (TPM) measurements. Use the Bootrec.exe tool in the Windows Recovery Environment to update or repair the boot sector.
        /// </summary>
        public const int FVE_E_WRONG_BOOTSECTOR = unchecked((int)0x8031002A);

        /// <summary>
        /// BitLocker Drive Encryption operating system drives must be formatted with the NTFS file system in order to be encrypted. Convert the drive to NTFS, and then turn on BitLocker.
        /// </summary>
        public const int FVE_E_WRONG_SYSTEM_FS = unchecked((int)0x8031002B);

        /// <summary>
        /// Group Policy settings require that a recovery password be specified before encrypting the drive.
        /// </summary>
        public const int FVE_E_POLICY_PASSWORD_REQUIRED = unchecked((int)0x8031002C);

        /// <summary>
        /// The drive encryption algorithm and key cannot be set on a previously encrypted drive. To encrypt this drive with BitLocker Drive Encryption, remove the previous encryption and then turn on BitLocker.
        /// </summary>
        public const int FVE_E_CANNOT_SET_FVEK_ENCRYPTED = unchecked((int)0x8031002D);

        /// <summary>
        /// BitLocker Drive Encryption cannot encrypt the specified drive because an encryption key is not available. Add a key protector to encrypt this drive.
        /// </summary>
        public const int FVE_E_CANNOT_ENCRYPT_NO_KEY = unchecked((int)0x8031002E);

        /// <summary>
        /// BitLocker Drive Encryption detected bootable media (CD or DVD) in the computer. Remove the media and restart the computer before configuring BitLocker.
        /// </summary>
        public const int FVE_E_BOOTABLE_CDDVD = unchecked((int)0x80310030);

        /// <summary>
        /// This key protector cannot be added. Only one key protector of this type is allowed for this drive.
        /// </summary>
        public const int FVE_E_PROTECTOR_EXISTS = unchecked((int)0x80310031);

        /// <summary>
        /// The recovery password file was not found because a relative path was specified. Recovery passwords must be saved to a fully qualified path. Environment variables configured on the computer can be used in the path.
        /// </summary>
        public const int FVE_E_RELATIVE_PATH = unchecked((int)0x80310032);

        /// <summary>
        /// The specified key protector was not found on the drive. Try another key protector.
        /// </summary>
        public const int FVE_E_PROTECTOR_NOT_FOUND = unchecked((int)0x80310033);

        /// <summary>
        /// The recovery key provided is corrupt and cannot be used to access the drive. An alternative recovery method, such as recovery password, a data recovery agent, or a backup version of the recovery key must be used to recover access to the drive.
        /// </summary>
        public const int FVE_E_INVALID_KEY_FORMAT = unchecked((int)0x80310034);

        /// <summary>
        /// The format of the recovery password provided is invalid. BitLocker recovery passwords are 48 digits. Verify that the recovery password is in the correct format and then try again.
        /// </summary>
        public const int FVE_E_INVALID_PASSWORD_FORMAT = unchecked((int)0x80310035);

        /// <summary>
        /// The random number generator check test failed.
        /// </summary>
        public const int FVE_E_FIPS_RNG_CHECK_FAILED = unchecked((int)0x80310036);

        /// <summary>
        /// The Group Policy setting requiring FIPS compliance prevents a local recovery password from being generated or used by BitLocker Drive Encryption. When operating in FIPS-compliant mode, BitLocker recovery options can be either a recovery key stored on a USB drive or recovery through a data recovery agent.
        /// </summary>
        public const int FVE_E_FIPS_PREVENTS_RECOVERY_PASSWORD = unchecked((int)0x80310037);

        /// <summary>
        /// The Group Policy setting requiring FIPS compliance prevents the recovery password from being saved to Active Directory. When operating in FIPS-compliant mode, BitLocker recovery options can be either a recovery key stored on a USB drive or recovery through a data recovery agent. Check your Group Policy settings configuration.
        /// </summary>
        public const int FVE_E_FIPS_PREVENTS_EXTERNAL_KEY_EXPORT = unchecked((int)0x80310038);

        /// <summary>
        /// The drive must be fully decrypted to complete this operation.
        /// </summary>
        public const int FVE_E_NOT_DECRYPTED = unchecked((int)0x80310039);

        /// <summary>
        /// The key protector specified cannot be used for this operation.
        /// </summary>
        public const int FVE_E_INVALID_PROTECTOR_TYPE = unchecked((int)0x8031003A);

        /// <summary>
        /// No key protectors exist on the drive to perform the hardware test.
        /// </summary>
        public const int FVE_E_NO_PROTECTORS_TO_TEST = unchecked((int)0x8031003B);

        /// <summary>
        /// The BitLocker startup key or recovery password cannot be found on the USB device. Verify that you have the correct USB device, that the USB device is plugged into the computer on an active USB port, restart the computer, and then try again. If the problem persists, contact the computer manufacturer for BIOS upgrade instructions.
        /// </summary>
        public const int FVE_E_KEYFILE_NOT_FOUND = unchecked((int)0x8031003C);

        /// <summary>
        /// The BitLocker startup key or recovery password file provided is corrupt or invalid. Verify that you have the correct startup key or recovery password file and try again.
        /// </summary>
        public const int FVE_E_KEYFILE_INVALID = unchecked((int)0x8031003D);

        /// <summary>
        /// The BitLocker encryption key cannot be obtained from the startup key or recovery password. Verify that you have the correct startup key or recovery password and try again.
        /// </summary>
        public const int FVE_E_KEYFILE_NO_VMK = unchecked((int)0x8031003E);

        /// <summary>
        /// The Trusted Platform Module (TPM) is disabled. The TPM must be enabled, initialized, and have valid ownership before it can be used with BitLocker Drive Encryption.
        /// </summary>
        public const int FVE_E_TPM_DISABLED = unchecked((int)0x8031003F);

        /// <summary>
        /// The BitLocker configuration of the specified drive cannot be managed because this computer is currently operating in Safe Mode. While in Safe Mode, BitLocker Drive Encryption can only be used for recovery purposes.
        /// </summary>
        public const int FVE_E_NOT_ALLOWED_IN_SAFE_MODE = unchecked((int)0x80310040);

        /// <summary>
        /// The Trusted Platform Module (TPM) was unable to unlock the drive. Either the system boot information changed after choosing BitLocker settings or the PIN did not match. If the problem persists after several tries, there may be a hardware or firmware problem.
        /// </summary>
        public const int FVE_E_TPM_INVALID_PCR = unchecked((int)0x80310041);

        /// <summary>
        /// The BitLocker encryption key cannot be obtained from the Trusted Platform Module (TPM).
        /// </summary>
        public const int FVE_E_TPM_NO_VMK = unchecked((int)0x80310042);

        /// <summary>
        /// The BitLocker encryption key cannot be obtained from the Trusted Platform Module (TPM) and PIN.
        /// </summary>
        public const int FVE_E_PIN_INVALID = unchecked((int)0x80310043);

        /// <summary>
        /// A boot application has changed since BitLocker Drive Encryption was enabled.
        /// </summary>
        public const int FVE_E_AUTH_INVALID_APPLICATION = unchecked((int)0x80310044);

        /// <summary>
        /// The Boot Configuration Data (BCD) settings have changed since BitLocker Drive Encryption was enabled.
        /// </summary>
        public const int FVE_E_AUTH_INVALID_CONFIG = unchecked((int)0x80310045);

        /// <summary>
        /// The Group Policy setting requiring FIPS compliance prohibits the use of unencrypted keys, which prevents BitLocker from being suspended on this drive. Please contact your domain administrator for more information.
        /// </summary>
        public const int FVE_E_FIPS_DISABLE_PROTECTION_NOT_ALLOWED = unchecked((int)0x80310046);

        /// <summary>
        /// This drive cannot be encrypted by BitLocker Drive Encryption because the file system does not extend to the end of the drive. Repartition this drive and then try again.
        /// </summary>
        public const int FVE_E_FS_NOT_EXTENDED = unchecked((int)0x80310047);

        /// <summary>
        /// BitLocker Drive Encryption cannot be enabled on the operating system drive. Contact the computer manufacturer for BIOS upgrade instructions.
        /// </summary>
        public const int FVE_E_FIRMWARE_TYPE_NOT_SUPPORTED = unchecked((int)0x80310048);

        /// <summary>
        /// This version of Windows does not include BitLocker Drive Encryption. To use BitLocker Drive Encryption, please upgrade the operating system.
        /// </summary>
        public const int FVE_E_NO_LICENSE = unchecked((int)0x80310049);

        /// <summary>
        /// BitLocker Drive Encryption cannot be used because critical BitLocker system files are missing or corrupted. Use Windows Startup Repair to restore these files to your computer.
        /// </summary>
        public const int FVE_E_NOT_ON_STACK = unchecked((int)0x8031004A);

        /// <summary>
        /// The drive cannot be locked when the drive is in use.
        /// </summary>
        public const int FVE_E_FS_MOUNTED = unchecked((int)0x8031004B);

        /// <summary>
        /// The access token associated with the current thread is not an impersonated token.
        /// </summary>
        public const int FVE_E_TOKEN_NOT_IMPERSONATED = unchecked((int)0x8031004C);

        /// <summary>
        /// The BitLocker encryption key cannot be obtained. Verify that the Trusted Platform Module (TPM) is enabled and ownership has been taken. If this computer does not have a TPM, verify that the USB drive is inserted and available.
        /// </summary>
        public const int FVE_E_DRY_RUN_FAILED = unchecked((int)0x8031004D);

        /// <summary>
        /// You must restart your computer before continuing with BitLocker Drive Encryption.
        /// </summary>
        public const int FVE_E_REBOOT_REQUIRED = unchecked((int)0x8031004E);

        /// <summary>
        /// Drive encryption cannot occur while boot debugging is enabled. Use the bcdedit command-line tool to turn off boot debugging.
        /// </summary>
        public const int FVE_E_DEBUGGER_ENABLED = unchecked((int)0x8031004F);

        /// <summary>
        /// No action was taken as BitLocker Drive Encryption is in raw access mode.
        /// </summary>
        public const int FVE_E_RAW_ACCESS = unchecked((int)0x80310050);

        /// <summary>
        /// BitLocker Drive Encryption cannot enter raw access mode for this drive because the drive is currently in use.
        /// </summary>
        public const int FVE_E_RAW_BLOCKED = unchecked((int)0x80310051);

        /// <summary>
        /// The path specified in the Boot Configuration Data (BCD) for a BitLocker Drive Encryption integrity-protected application is incorrect. Please verify and correct your BCD settings and try again.
        /// </summary>
        public const int FVE_E_BCD_APPLICATIONS_PATH_INCORRECT = unchecked((int)0x80310052);

        /// <summary>
        /// BitLocker Drive Encryption can only be used for limited provisioning or recovery purposes when the computer is running in pre-installation or recovery environments.
        /// </summary>
        public const int FVE_E_NOT_ALLOWED_IN_VERSION = unchecked((int)0x80310053);

        /// <summary>
        /// The auto-unlock master key was not available from the operating system drive.
        /// </summary>
        public const int FVE_E_NO_AUTOUNLOCK_MASTER_KEY = unchecked((int)0x80310054);

        /// <summary>
        /// The system firmware failed to enable clearing of system memory when the computer was restarted.
        /// </summary>
        public const int FVE_E_MOR_FAILED = unchecked((int)0x80310055);

        /// <summary>
        /// The hidden drive cannot be encrypted.
        /// </summary>
        public const int FVE_E_HIDDEN_VOLUME = unchecked((int)0x80310056);

        /// <summary>
        /// BitLocker encryption keys were ignored because the drive was in a transient state.
        /// </summary>
        public const int FVE_E_TRANSIENT_STATE = unchecked((int)0x80310057);

        /// <summary>
        /// Public key based protectors are not allowed on this drive.
        /// </summary>
        public const int FVE_E_PUBKEY_NOT_ALLOWED = unchecked((int)0x80310058);

        /// <summary>
        /// BitLocker Drive Encryption is already performing an operation on this drive. Please complete all operations before continuing.
        /// </summary>
        public const int FVE_E_VOLUME_HANDLE_OPEN = unchecked((int)0x80310059);

        /// <summary>
        /// This version of Windows does not support this feature of BitLocker Drive Encryption. To use this feature, upgrade the operating system.
        /// </summary>
        public const int FVE_E_NO_FEATURE_LICENSE = unchecked((int)0x8031005A);

        /// <summary>
        /// The Group Policy settings for BitLocker startup options are in conflict and cannot be applied. Contact your system administrator for more information.
        /// </summary>
        public const int FVE_E_INVALID_STARTUP_OPTIONS = unchecked((int)0x8031005B);

        /// <summary>
        /// Group Policy settings do not permit the creation of a recovery password.
        /// </summary>
        public const int FVE_E_POLICY_RECOVERY_PASSWORD_NOT_ALLOWED = unchecked((int)0x8031005C);

        /// <summary>
        /// Group Policy settings require the creation of a recovery password.
        /// </summary>
        public const int FVE_E_POLICY_RECOVERY_PASSWORD_REQUIRED = unchecked((int)0x8031005D);

        /// <summary>
        /// Group Policy settings do not permit the creation of a recovery key.
        /// </summary>
        public const int FVE_E_POLICY_RECOVERY_KEY_NOT_ALLOWED = unchecked((int)0x8031005E);

        /// <summary>
        /// Group Policy settings require the creation of a recovery key.
        /// </summary>
        public const int FVE_E_POLICY_RECOVERY_KEY_REQUIRED = unchecked((int)0x8031005F);

        /// <summary>
        /// Group Policy settings do not permit the use of a PIN at startup. Please choose a different BitLocker startup option.
        /// </summary>
        public const int FVE_E_POLICY_STARTUP_PIN_NOT_ALLOWED = unchecked((int)0x80310060);

        /// <summary>
        /// Group Policy settings require the use of a PIN at startup. Please choose this BitLocker startup option.
        /// </summary>
        public const int FVE_E_POLICY_STARTUP_PIN_REQUIRED = unchecked((int)0x80310061);

        /// <summary>
        /// Group Policy settings do not permit the use of a startup key. Please choose a different BitLocker startup option.
        /// </summary>
        public const int FVE_E_POLICY_STARTUP_KEY_NOT_ALLOWED = unchecked((int)0x80310062);

        /// <summary>
        /// Group Policy settings require the use of a startup key. Please choose this BitLocker startup option.
        /// </summary>
        public const int FVE_E_POLICY_STARTUP_KEY_REQUIRED = unchecked((int)0x80310063);

        /// <summary>
        /// Group Policy settings do not permit the use of a startup key and PIN. Please choose a different BitLocker startup option.
        /// </summary>
        public const int FVE_E_POLICY_STARTUP_PIN_KEY_NOT_ALLOWED = unchecked((int)0x80310064);

        /// <summary>
        /// Group Policy settings require the use of a startup key and PIN. Please choose this BitLocker startup option.
        /// </summary>
        public const int FVE_E_POLICY_STARTUP_PIN_KEY_REQUIRED = unchecked((int)0x80310065);

        /// <summary>
        /// Group policy does not permit the use of TPM-only at startup. Please choose a different BitLocker startup option.
        /// </summary>
        public const int FVE_E_POLICY_STARTUP_TPM_NOT_ALLOWED = unchecked((int)0x80310066);

        /// <summary>
        /// Group Policy settings require the use of TPM-only at startup. Please choose this BitLocker startup option.
        /// </summary>
        public const int FVE_E_POLICY_STARTUP_TPM_REQUIRED = unchecked((int)0x80310067);

        /// <summary>
        /// The PIN provided does not meet minimum or maximum length requirements.
        /// </summary>
        public const int FVE_E_POLICY_INVALID_PIN_LENGTH = unchecked((int)0x80310068);

        /// <summary>
        /// The key protector is not supported by the version of BitLocker Drive Encryption currently on the drive. Upgrade the drive to add the key protector.
        /// </summary>
        public const int FVE_E_KEY_PROTECTOR_NOT_SUPPORTED = unchecked((int)0x80310069);

        /// <summary>
        /// Group Policy settings do not permit the creation of a password.
        /// </summary>
        public const int FVE_E_POLICY_PASSPHRASE_NOT_ALLOWED = unchecked((int)0x8031006A);

        /// <summary>
        /// Group Policy settings require the creation of a password.
        /// </summary>
        public const int FVE_E_POLICY_PASSPHRASE_REQUIRED = unchecked((int)0x8031006B);

        /// <summary>
        /// The Group Policy setting requiring FIPS compliance prevents passwords from being generated or used. Please contact your system administrator for more information.
        /// </summary>
        public const int FVE_E_FIPS_PREVENTS_PASSPHRASE = unchecked((int)0x8031006C);

        /// <summary>
        /// A password cannot be added to the operating system drive.
        /// </summary>
        public const int FVE_E_OS_VOLUME_PASSPHRASE_NOT_ALLOWED = unchecked((int)0x8031006D);

        /// <summary>
        /// The BitLocker object identifier (OID) on the drive appears to be invalid or corrupt. Use manage-BDE to reset the OID on this drive.
        /// </summary>
        public const int FVE_E_INVALID_BITLOCKER_OID = unchecked((int)0x8031006E);

        /// <summary>
        /// The drive is too small to be protected using BitLocker Drive Encryption.
        /// </summary>
        public const int FVE_E_VOLUME_TOO_SMALL = unchecked((int)0x8031006F);

        /// <summary>
        /// The selected discovery drive type is incompatible with the file system on the drive. BitLocker To Go discovery drives must be created on FAT formatted drives.
        /// </summary>
        public const int FVE_E_DV_NOT_SUPPORTED_ON_FS = unchecked((int)0x80310070);

        /// <summary>
        /// The selected discovery drive type is not allowed by the computer's Group Policy settings. Verify that Group Policy settings allow the creation of discovery drives for use with BitLocker To Go.
        /// </summary>
        public const int FVE_E_DV_NOT_ALLOWED_BY_GP = unchecked((int)0x80310071);

        /// <summary>
        /// Group Policy settings do not permit user certificates such as smart cards to be used with BitLocker Drive Encryption.
        /// </summary>
        public const int FVE_E_POLICY_USER_CERTIFICATE_NOT_ALLOWED = unchecked((int)0x80310072);

        /// <summary>
        /// Group Policy settings require that you have a valid user certificate, such as a smart card, to be used with BitLocker Drive Encryption.
        /// </summary>
        public const int FVE_E_POLICY_USER_CERTIFICATE_REQUIRED = unchecked((int)0x80310073);

        /// <summary>
        /// Group Policy settings requires that you use a smart card-based key protector with BitLocker Drive Encryption.
        /// </summary>
        public const int FVE_E_POLICY_USER_CERT_MUST_BE_HW = unchecked((int)0x80310074);

        /// <summary>
        /// Group Policy settings do not permit BitLocker-protected fixed data drives to be automatically unlocked.
        /// </summary>
        public const int FVE_E_POLICY_USER_CONFIGURE_FDV_AUTOUNLOCK_NOT_ALLOWED = unchecked((int)0x80310075);

        /// <summary>
        /// Group Policy settings do not permit BitLocker-protected removable data drives to be automatically unlocked.
        /// </summary>
        public const int FVE_E_POLICY_USER_CONFIGURE_RDV_AUTOUNLOCK_NOT_ALLOWED = unchecked((int)0x80310076);

        /// <summary>
        /// Group Policy settings do not permit you to configure BitLocker Drive Encryption on removable data drives.
        /// </summary>
        public const int FVE_E_POLICY_USER_CONFIGURE_RDV_NOT_ALLOWED = unchecked((int)0x80310077);

        /// <summary>
        /// Group Policy settings do not permit you to turn on BitLocker Drive Encryption on removable data drives. Please contact your system administrator if you need to turn on BitLocker.
        /// </summary>
        public const int FVE_E_POLICY_USER_ENABLE_RDV_NOT_ALLOWED = unchecked((int)0x80310078);

        /// <summary>
        /// Group Policy settings do not permit turning off BitLocker Drive Encryption on removable data drives. Please contact your system administrator if you need to turn off BitLocker.
        /// </summary>
        public const int FVE_E_POLICY_USER_DISABLE_RDV_NOT_ALLOWED = unchecked((int)0x80310079);

        /// <summary>
        /// Your password does not meet minimum password length requirements. By default, passwords must be at least 8 characters in length. Check with your system administrator for the password length requirement in your organization.
        /// </summary>
        public const int FVE_E_POLICY_INVALID_PASSPHRASE_LENGTH = unchecked((int)0x80310080);

        /// <summary>
        /// Your password does not meet the complexity requirements set by your system administrator. Try adding upper and lowercase characters, numbers, and symbols.
        /// </summary>
        public const int FVE_E_POLICY_PASSPHRASE_TOO_SIMPLE = unchecked((int)0x80310081);

        /// <summary>
        /// This drive cannot be encrypted because it is reserved for Windows System Recovery Options.
        /// </summary>
        public const int FVE_E_RECOVERY_PARTITION = unchecked((int)0x80310082);

        /// <summary>
        /// BitLocker Drive Encryption cannot be applied to this drive because of conflicting Group Policy settings. BitLocker cannot be configured to automatically unlock fixed data drives when user recovery options are disabled. If you want BitLocker-protected fixed data drives to be automatically unlocked after key validation has occurred, please ask your system administrator to resolve the settings conflict before enabling BitLocker.
        /// </summary>
        public const int FVE_E_POLICY_CONFLICT_FDV_RK_OFF_AUK_ON = unchecked((int)0x80310083);

        /// <summary>
        /// BitLocker Drive Encryption cannot be applied to this drive because of conflicting Group Policy settings. BitLocker cannot be configured to automatically unlock removable data drives when user recovery option are disabled. If you want BitLocker-protected removable data drives to be automatically unlocked after key validation has occurred, please ask your system administrator to resolve the settings conflict before enabling BitLocker.
        /// </summary>
        public const int FVE_E_POLICY_CONFLICT_RDV_RK_OFF_AUK_ON = unchecked((int)0x80310084);

        /// <summary>
        /// The Enhanced Key Usage (EKU) attribute of the specified certificate does not permit it to be used for BitLocker Drive Encryption. BitLocker does not require that a certificate have an EKU attribute, but if one is configured it must be set to an object identifier (OID) that matches the OID configured for BitLocker.
        /// </summary>
        public const int FVE_E_NON_BITLOCKER_OID = unchecked((int)0x80310085);

        /// <summary>
        /// BitLocker Drive Encryption cannot be applied to this drive as currently configured because of Group Policy settings. The certificate you provided for drive encryption is self-signed. Current Group Policy settings do not permit the use of self-signed certificates. Obtain a new certificate from your certification authority before attempting to enable BitLocker.
        /// </summary>
        public const int FVE_E_POLICY_PROHIBITS_SELFSIGNED = unchecked((int)0x80310086);

        /// <summary>
        /// BitLocker Encryption cannot be applied to this drive because of conflicting Group Policy settings. When write access to drives not protected by BitLocker is denied, the use of a USB startup key cannot be required. Please have your system administrator resolve these policy conflicts before attempting to enable BitLocker.
        /// </summary>
        public const int FVE_E_POLICY_CONFLICT_RO_AND_STARTUP_KEY_REQUIRED = unchecked((int)0x80310087);

        /// <summary>
        /// BitLocker Drive Encryption failed to recover from an abruptly terminated conversion. This could be due to either all conversion logs being corrupted or the media being write-protected.
        /// </summary>
        public const int FVE_E_CONV_RECOVERY_FAILED = unchecked((int)0x80310088);

        /// <summary>
        /// The requested virtualization size is too big.
        /// </summary>
        public const int FVE_E_VIRTUALIZED_SPACE_TOO_BIG = unchecked((int)0x80310089);

        /// <summary>
        /// BitLocker Drive Encryption cannot be applied to this drive because there are conflicting Group Policy settings for recovery options on operating system drives. Storing recovery information to Active Directory Domain Services cannot be required when the generation of recovery passwords is not permitted. Please have your system administrator resolve these policy conflicts before attempting to enable BitLocker.
        /// </summary>
        public const int FVE_E_POLICY_CONFLICT_OSV_RP_OFF_ADB_ON = unchecked((int)0x80310090);

        /// <summary>
        /// BitLocker Drive Encryption cannot be applied to this drive because there are conflicting Group Policy settings for recovery options on fixed data drives. Storing recovery information to Active Directory Domain Services cannot be required when the generation of recovery passwords is not permitted. Please have your system administrator resolve these policy conflicts before attempting to enable BitLocker.
        /// </summary>
        public const int FVE_E_POLICY_CONFLICT_FDV_RP_OFF_ADB_ON = unchecked((int)0x80310091);

        /// <summary>
        /// BitLocker Drive Encryption cannot be applied to this drive because there are conflicting Group Policy settings for recovery options on removable data drives. Storing recovery information to Active Directory Domain Services cannot be required when the generation of recovery passwords is not permitted. Please have your system administrator resolve these policy conflicts before attempting to enable BitLocker.
        /// </summary>
        public const int FVE_E_POLICY_CONFLICT_RDV_RP_OFF_ADB_ON = unchecked((int)0x80310092);

        /// <summary>
        /// The Key Usage (KU) attribute of the specified certificate does not permit it to be used for BitLocker Drive Encryption. BitLocker does not require that a certificate have a KU attribute, but if one is configured it must be set to either Key Encipherment or Key Agreement.
        /// </summary>
        public const int FVE_E_NON_BITLOCKER_KU = unchecked((int)0x80310093);

        /// <summary>
        /// The private key associated with the specified certificate cannot be authorized. The private key authorization was either not provided or the provided authorization was invalid.
        /// </summary>
        public const int FVE_E_PRIVATEKEY_AUTH_FAILED = unchecked((int)0x80310094);

        /// <summary>
        /// Removal of the data recovery agent certificate must be done using the Certificates snap-in.
        /// </summary>
        public const int FVE_E_REMOVAL_OF_DRA_FAILED = unchecked((int)0x80310095);

        /// <summary>
        /// This drive was encrypted using the version of BitLocker Drive Encryption included with Windows Vista and Windows Server 2008 which does not support organizational identifiers. To specify organizational identifiers for this drive upgrade the drive encryption to the latest version using the "manage-bde -upgrade" command.
        /// </summary>
        public const int FVE_E_OPERATION_NOT_SUPPORTED_ON_VISTA_VOLUME = unchecked((int)0x80310096);

        /// <summary>
        /// The drive cannot be locked because it is automatically unlocked on this computer.  Remove the automatic unlock protector to lock this drive.
        /// </summary>
        public const int FVE_E_CANT_LOCK_AUTOUNLOCK_ENABLED_VOLUME = unchecked((int)0x80310097);

        /// <summary>
        /// The default BitLocker Key Derivation Function SP800-56A for ECC smart cards is not supported by your smart card. The Group Policy setting requiring FIPS-compliance prevents BitLocker from using any other key derivation function for encryption. You have to use a FIPS compliant smart card in FIPS restricted environments.
        /// </summary>
        public const int FVE_E_FIPS_HASH_KDF_NOT_ALLOWED = unchecked((int)0x80310098);

        /// <summary>
        /// The BitLocker encryption key could not be obtained from the Trusted Platform Module (TPM) and enhanced PIN. Try using a PIN containing only numerals.
        /// </summary>
        public const int FVE_E_ENH_PIN_INVALID = unchecked((int)0x80310099);

        /// <summary>
        /// The requested TPM PIN contains invalid characters.
        /// </summary>
        public const int FVE_E_INVALID_PIN_CHARS = unchecked((int)0x8031009A);

        /// <summary>
        /// The management information stored on the drive contained an unknown type. If you are using an old version of Windows, try accessing the drive from the latest version.
        /// </summary>
        public const int FVE_E_INVALID_DATUM_TYPE = unchecked((int)0x8031009B);

        /// <summary>
        /// The feature is only supported on EFI systems.
        /// </summary>
        public const int FVE_E_EFI_ONLY = unchecked((int)0x8031009C);

        /// <summary>
        /// More than one Network Key Protector certificate has been found on the system.
        /// </summary>
        public const int FVE_E_MULTIPLE_NKP_CERTS = unchecked((int)0x8031009D);

        /// <summary>
        /// Removal of the Network Key Protector certificate must be done using the Certificates snap-in.
        /// </summary>
        public const int FVE_E_REMOVAL_OF_NKP_FAILED = unchecked((int)0x8031009E);

        /// <summary>
        /// An invalid certificate has been found in the Network Key Protector certificate store.
        /// </summary>
        public const int FVE_E_INVALID_NKP_CERT = unchecked((int)0x8031009F);

        /// <summary>
        /// This drive isn't protected with a PIN.
        /// </summary>
        public const int FVE_E_NO_EXISTING_PIN = unchecked((int)0x803100A0);

        /// <summary>
        /// Please enter the correct current PIN.
        /// </summary>
        public const int FVE_E_PROTECTOR_CHANGE_PIN_MISMATCH = unchecked((int)0x803100A1);

        /// <summary>
        /// You must be logged on with an administrator account to change the PIN. Click the link to reset the PIN as an administrator.
        /// </summary>
        public const int FVE_E_PIN_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED = unchecked((int)0x803100A2);

        /// <summary>
        /// BitLocker has disabled PIN changes after too many failed requests. Click the link to reset the PIN as an administrator.
        /// </summary>
        public const int FVE_E_PROTECTOR_CHANGE_MAX_PIN_CHANGE_ATTEMPTS_REACHED = unchecked((int)0x803100A3);

        /// <summary>
        /// Your system administrator requires that passwords contain only printable ASCII characters. This includes unaccented letters (A-Z, a-z), numbers (0-9), space, arithmetic signs, common punctuation, separators, and the following symbols: # $ &amp; @ ^ _ ~ .
        /// </summary>
        public const int FVE_E_POLICY_PASSPHRASE_REQUIRES_ASCII = unchecked((int)0x803100A4);

        /// <summary>
        /// BitLocker Drive Encryption only supports Used Space Only encryption on thin provisioned storage.
        /// </summary>
        public const int FVE_E_FULL_ENCRYPTION_NOT_ALLOWED_ON_TP_STORAGE = unchecked((int)0x803100A5);

        /// <summary>
        /// BitLocker Drive Encryption does not support wiping free space on thin provisioned storage.
        /// </summary>
        public const int FVE_E_WIPE_NOT_ALLOWED_ON_TP_STORAGE = unchecked((int)0x803100A6);

        /// <summary>
        /// The required authentication key length is not supported by the drive.
        /// </summary>
        public const int FVE_E_KEY_LENGTH_NOT_SUPPORTED_BY_EDRIVE = unchecked((int)0x803100A7);

        /// <summary>
        /// This drive isn't protected with a password.
        /// </summary>
        public const int FVE_E_NO_EXISTING_PASSPHRASE = unchecked((int)0x803100A8);

        /// <summary>
        /// Please enter the correct current password.
        /// </summary>
        public const int FVE_E_PROTECTOR_CHANGE_PASSPHRASE_MISMATCH = unchecked((int)0x803100A9);

        /// <summary>
        /// The password cannot exceed 256 characters.
        /// </summary>
        public const int FVE_E_PASSPHRASE_TOO_LONG = unchecked((int)0x803100AA);

        /// <summary>
        /// A password key protector cannot be added because a TPM protector exists on the drive.
        /// </summary>
        public const int FVE_E_NO_PASSPHRASE_WITH_TPM = unchecked((int)0x803100AB);

        /// <summary>
        /// A TPM key protector cannot be added because a password protector exists on the drive.
        /// </summary>
        public const int FVE_E_NO_TPM_WITH_PASSPHRASE = unchecked((int)0x803100AC);

        /// <summary>
        /// This command can only be performed from the coordinator node for the specified CSV volume.
        /// </summary>
        public const int FVE_E_NOT_ALLOWED_ON_CSV_STACK = unchecked((int)0x803100AD);

        /// <summary>
        /// This command cannot be performed on a volume when it is part of a cluster.
        /// </summary>
        public const int FVE_E_NOT_ALLOWED_ON_CLUSTER = unchecked((int)0x803100AE);

        /// <summary>
        /// BitLocker did not revert to using BitLocker software encryption due to group policy configuration.
        /// </summary>
        public const int FVE_E_EDRIVE_NO_FAILOVER_TO_SW = unchecked((int)0x803100AF);

        /// <summary>
        /// The drive cannot be managed by BitLocker because the drive's hardware encryption feature is already in use.
        /// </summary>
        public const int FVE_E_EDRIVE_BAND_IN_USE = unchecked((int)0x803100B0);

        /// <summary>
        /// Group Policy settings do not allow the use of hardware-based encryption.
        /// </summary>
        public const int FVE_E_EDRIVE_DISALLOWED_BY_GP = unchecked((int)0x803100B1);

        /// <summary>
        /// The drive specified does not support hardware-based encryption.
        /// </summary>
        public const int FVE_E_EDRIVE_INCOMPATIBLE_VOLUME = unchecked((int)0x803100B2);

        /// <summary>
        /// BitLocker cannot be upgraded during disk encryption or decryption.
        /// </summary>
        public const int FVE_E_NOT_ALLOWED_TO_UPGRADE_WHILE_CONVERTING = unchecked((int)0x803100B3);

        /// <summary>
        /// Discovery Volumes are not supported for volumes using hardware encryption.
        /// </summary>
        public const int FVE_E_EDRIVE_DV_NOT_SUPPORTED = unchecked((int)0x803100B4);

        /// <summary>
        /// No pre-boot keyboard detected. The user may not be able to provide required input to unlock the volume.
        /// </summary>
        public const int FVE_E_NO_PREBOOT_KEYBOARD_DETECTED = unchecked((int)0x803100B5);

        /// <summary>
        /// No pre-boot keyboard or Windows Recovery Environment detected. The user may not be able to provide required input to unlock the volume.
        /// </summary>
        public const int FVE_E_NO_PREBOOT_KEYBOARD_OR_WINRE_DETECTED = unchecked((int)0x803100B6);

        /// <summary>
        /// Group Policy settings require the creation of a startup PIN, but a pre-boot keyboard is not available on this device. The user may not be able to provide required input to unlock the volume.
        /// </summary>
        public const int FVE_E_POLICY_REQUIRES_STARTUP_PIN_ON_TOUCH_DEVICE = unchecked((int)0x803100B7);

        /// <summary>
        /// Group Policy settings require the creation of a recovery password, but neither a pre-boot keyboard nor Windows Recovery Environment is available on this device. The user may not be able to provide required input to unlock the volume.
        /// </summary>
        public const int FVE_E_POLICY_REQUIRES_RECOVERY_PASSWORD_ON_TOUCH_DEVICE = unchecked((int)0x803100B8);

        /// <summary>
        /// Wipe of free space is not currently taking place.
        /// </summary>
        public const int FVE_E_WIPE_CANCEL_NOT_APPLICABLE = unchecked((int)0x803100B9);

        /// <summary>
        /// BitLocker cannot use Secure Boot for platform integrity because Secure Boot has been disabled.
        /// </summary>
        public const int FVE_E_SECUREBOOT_DISABLED = unchecked((int)0x803100BA);

        /// <summary>
        /// BitLocker cannot use Secure Boot for platform integrity because the Secure Boot configuration does not meet the requirements for BitLocker.
        /// </summary>
        public const int FVE_E_SECUREBOOT_CONFIGURATION_INVALID = unchecked((int)0x803100BB);

        /// <summary>
        /// Your computer doesn't support BitLocker hardware-based encryption. Check with your computer manufacturer for firmware updates.
        /// </summary>
        public const int FVE_E_EDRIVE_DRY_RUN_FAILED = unchecked((int)0x803100BC);

        /// <summary>
        /// BitLocker cannot be enabled on the volume because it contains a Volume Shadow Copy. Remove all Volume Shadow Copies before encrypting the volume.
        /// </summary>
        public const int FVE_E_SHADOW_COPY_PRESENT = unchecked((int)0x803100BD);

        /// <summary>
        /// BitLocker Drive Encryption cannot be applied to this drive because the Group Policy setting for Enhanced Boot Configuration Data contains invalid data. Please have your system administrator resolve this invalid configuration before attempting to enable BitLocker.
        /// </summary>
        public const int FVE_E_POLICY_INVALID_ENHANCED_BCD_SETTINGS = unchecked((int)0x803100BE);

        /// <summary>
        /// This PC's firmware is not capable of supporting hardware encryption.
        /// </summary>
        public const int FVE_E_EDRIVE_INCOMPATIBLE_FIRMWARE = unchecked((int)0x803100BF);

        /// <summary>
        /// BitLocker has disabled password changes after too many failed requests. Click the link to reset the password as an administrator.
        /// </summary>
        public const int FVE_E_PROTECTOR_CHANGE_MAX_PASSPHRASE_CHANGE_ATTEMPTS_REACHED = unchecked((int)0x803100C0);

        /// <summary>
        /// You must be logged on with an administrator account to change the password. Click the link to reset the password as an administrator.
        /// </summary>
        public const int FVE_E_PASSPHRASE_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED = unchecked((int)0x803100C1);

        /// <summary>
        /// BitLocker cannot save the recovery password because the specified Microsoft account is Suspended.
        /// </summary>
        public const int FVE_E_LIVEID_ACCOUNT_SUSPENDED = unchecked((int)0x803100C2);

        /// <summary>
        /// BitLocker cannot save the recovery password because the specified Microsoft account is Blocked.
        /// </summary>
        public const int FVE_E_LIVEID_ACCOUNT_BLOCKED = unchecked((int)0x803100C3);

        /// <summary>
        /// This PC is not provisioned to support device encryption. Please enable BitLocker on all volumes to comply with device encryption policy.
        /// </summary>
        public const int FVE_E_NOT_PROVISIONED_ON_ALL_VOLUMES = unchecked((int)0x803100C4);

        /// <summary>
        /// This PC cannot support device encryption because unencrypted fixed data volumes are present.
        /// </summary>
        public const int FVE_E_DE_FIXED_DATA_NOT_SUPPORTED = unchecked((int)0x803100C5);

        /// <summary>
        /// This PC does not meet the hardware requirements to support device encryption.
        /// </summary>
        public const int FVE_E_DE_HARDWARE_NOT_COMPLIANT = unchecked((int)0x803100C6);

        /// <summary>
        /// This PC cannot support device encryption because WinRE is not properly configured.
        /// </summary>
        public const int FVE_E_DE_WINRE_NOT_CONFIGURED = unchecked((int)0x803100C7);

        /// <summary>
        /// Protection is enabled on the volume but has been suspended. This is likely to have happened due to an update being applied to your system. Please try again after a reboot.
        /// </summary>
        public const int FVE_E_DE_PROTECTION_SUSPENDED = unchecked((int)0x803100C8);

        /// <summary>
        /// This PC is not provisioned to support device encryption.
        /// </summary>
        public const int FVE_E_DE_OS_VOLUME_NOT_PROTECTED = unchecked((int)0x803100C9);

        /// <summary>
        /// Device Lock has been triggered due to too many incorrect password attempts.
        /// </summary>
        public const int FVE_E_DE_DEVICE_LOCKEDOUT = unchecked((int)0x803100CA);

        /// <summary>
        /// Protection has not been enabled on the volume. Enabling protection requires a connected account. If you already have a connected account and are seeing this error, please refer to the event log for more information.
        /// </summary>
        public const int FVE_E_DE_PROTECTION_NOT_YET_ENABLED = unchecked((int)0x803100CB);

        /// <summary>
        /// Your PIN can only contain numbers from 0 to 9.
        /// </summary>
        public const int FVE_E_INVALID_PIN_CHARS_DETAILED = unchecked((int)0x803100CC);

        /// <summary>
        /// BitLocker cannot use hardware replay protection because no counter is available on your PC.
        /// </summary>
        public const int FVE_E_DEVICE_LOCKOUT_COUNTER_UNAVAILABLE = unchecked((int)0x803100CD);

        /// <summary>
        /// Device Lockout state validation failed due to counter mismatch.
        /// </summary>
        public const int FVE_E_DEVICELOCKOUT_COUNTER_MISMATCH = unchecked((int)0x803100CE);

        /// <summary>
        /// The input buffer is too large.
        /// </summary>
        public const int FVE_E_BUFFER_TOO_LARGE = unchecked((int)0x803100CF);

        /// <summary>
        /// The target of an invocation does not support requested capability.
        /// </summary>
        public const int FVE_E_NO_SUCH_CAPABILITY_ON_TARGET = unchecked((int)0x803100D0);

        /// <summary>
        /// Device encryption is currently blocked by this PC's configuration.
        /// </summary>
        public const int FVE_E_DE_PREVENTED_FOR_OS = unchecked((int)0x803100D1);

        /// <summary>
        /// This drive has been opted out of device encryption.
        /// </summary>
        public const int FVE_E_DE_VOLUME_OPTED_OUT = unchecked((int)0x803100D2);

        /// <summary>
        /// Device encryption isn't available for this drive.
        /// </summary>
        public const int FVE_E_DE_VOLUME_NOT_SUPPORTED = unchecked((int)0x803100D3);

        /// <summary>
        /// The encrypt on write mode for BitLocker is not supported in this version of Windows. You can turn on BitLocker without using the encrypt on write mode.
        /// </summary>
        public const int FVE_E_EOW_NOT_SUPPORTED_IN_VERSION = unchecked((int)0x803100D4);

        /// <summary>
        /// Group policy prevents you from backing up your recovery password to Active Directory for this drive type. For more info, contact your system administrator.
        /// </summary>
        public const int FVE_E_ADBACKUP_NOT_ENABLED = unchecked((int)0x803100D5);

        /// <summary>
        /// Device encryption can't be turned off while this drive is being encrypted. Please try again later.
        /// </summary>
        public const int FVE_E_VOLUME_EXTEND_PREVENTS_EOW_DECRYPT = unchecked((int)0x803100D6);

        /// <summary>
        /// This action isn't supported because this drive isn't automatically managed with device encryption.
        /// </summary>
        public const int FVE_E_NOT_DE_VOLUME = unchecked((int)0x803100D7);

        /// <summary>
        /// BitLocker can't be suspended on this drive until the next restart.
        /// </summary>
        public const int FVE_E_PROTECTION_CANNOT_BE_DISABLED = unchecked((int)0x803100D8);

        /// <summary>
        /// BitLocker Drive Encryption policy does not allow KSR operation with protected OS volume.
        /// </summary>
        public const int FVE_E_OSV_KSR_NOT_ALLOWED = unchecked((int)0x803100D9);

        //
        // =======================================================
        // Windows Filtering Platform Error Messages
        // =======================================================
        //
        /// <summary>
        /// The callout does not exist.
        /// </summary>
        public const int FWP_E_CALLOUT_NOT_FOUND = unchecked((int)0x80320001);

        /// <summary>
        /// The filter condition does not exist.
        /// </summary>
        public const int FWP_E_CONDITION_NOT_FOUND = unchecked((int)0x80320002);

        /// <summary>
        /// The filter does not exist.
        /// </summary>
        public const int FWP_E_FILTER_NOT_FOUND = unchecked((int)0x80320003);

        /// <summary>
        /// The layer does not exist.
        /// </summary>
        public const int FWP_E_LAYER_NOT_FOUND = unchecked((int)0x80320004);

        /// <summary>
        /// The provider does not exist.
        /// </summary>
        public const int FWP_E_PROVIDER_NOT_FOUND = unchecked((int)0x80320005);

        /// <summary>
        /// The provider context does not exist.
        /// </summary>
        public const int FWP_E_PROVIDER_CONTEXT_NOT_FOUND = unchecked((int)0x80320006);

        /// <summary>
        /// The sublayer does not exist.
        /// </summary>
        public const int FWP_E_SUBLAYER_NOT_FOUND = unchecked((int)0x80320007);

        /// <summary>
        /// The object does not exist.
        /// </summary>
        public const int FWP_E_NOT_FOUND = unchecked((int)0x80320008);

        /// <summary>
        /// An object with that GUID or LUID already exists.
        /// </summary>
        public const int FWP_E_ALREADY_EXISTS = unchecked((int)0x80320009);

        /// <summary>
        /// The object is referenced by other objects so cannot be deleted.
        /// </summary>
        public const int FWP_E_IN_USE = unchecked((int)0x8032000A);

        /// <summary>
        /// The call is not allowed from within a dynamic session.
        /// </summary>
        public const int FWP_E_DYNAMIC_SESSION_IN_PROGRESS = unchecked((int)0x8032000B);

        /// <summary>
        /// The call was made from the wrong session so cannot be completed.
        /// </summary>
        public const int FWP_E_WRONG_SESSION = unchecked((int)0x8032000C);

        /// <summary>
        /// The call must be made from within an explicit transaction.
        /// </summary>
        public const int FWP_E_NO_TXN_IN_PROGRESS = unchecked((int)0x8032000D);

        /// <summary>
        /// The call is not allowed from within an explicit transaction.
        /// </summary>
        public const int FWP_E_TXN_IN_PROGRESS = unchecked((int)0x8032000E);

        /// <summary>
        /// The explicit transaction has been forcibly cancelled.
        /// </summary>
        public const int FWP_E_TXN_ABORTED = unchecked((int)0x8032000F);

        /// <summary>
        /// The session has been cancelled.
        /// </summary>
        public const int FWP_E_SESSION_ABORTED = unchecked((int)0x80320010);

        /// <summary>
        /// The call is not allowed from within a read-only transaction.
        /// </summary>
        public const int FWP_E_INCOMPATIBLE_TXN = unchecked((int)0x80320011);

        /// <summary>
        /// The call timed out while waiting to acquire the transaction lock.
        /// </summary>
        public const int FWP_E_TIMEOUT = unchecked((int)0x80320012);

        /// <summary>
        /// Collection of network diagnostic events is disabled.
        /// </summary>
        public const int FWP_E_NET_EVENTS_DISABLED = unchecked((int)0x80320013);

        /// <summary>
        /// The operation is not supported by the specified layer.
        /// </summary>
        public const int FWP_E_INCOMPATIBLE_LAYER = unchecked((int)0x80320014);

        /// <summary>
        /// The call is allowed for kernel-mode callers only.
        /// </summary>
        public const int FWP_E_KM_CLIENTS_ONLY = unchecked((int)0x80320015);

        /// <summary>
        /// The call tried to associate two objects with incompatible lifetimes.
        /// </summary>
        public const int FWP_E_LIFETIME_MISMATCH = unchecked((int)0x80320016);

        /// <summary>
        /// The object is built in so cannot be deleted.
        /// </summary>
        public const int FWP_E_BUILTIN_OBJECT = unchecked((int)0x80320017);

        /// <summary>
        /// The maximum number of callouts has been reached.
        /// </summary>
        public const int FWP_E_TOO_MANY_CALLOUTS = unchecked((int)0x80320018);

        /// <summary>
        /// A notification could not be delivered because a message queue is at its maximum capacity.
        /// </summary>
        public const int FWP_E_NOTIFICATION_DROPPED = unchecked((int)0x80320019);

        /// <summary>
        /// The traffic parameters do not match those for the security association context.
        /// </summary>
        public const int FWP_E_TRAFFIC_MISMATCH = unchecked((int)0x8032001A);

        /// <summary>
        /// The call is not allowed for the current security association state.
        /// </summary>
        public const int FWP_E_INCOMPATIBLE_SA_STATE = unchecked((int)0x8032001B);

        /// <summary>
        /// A required pointer is null.
        /// </summary>
        public const int FWP_E_NULL_POINTER = unchecked((int)0x8032001C);

        /// <summary>
        /// An enumerator is not valid.
        /// </summary>
        public const int FWP_E_INVALID_ENUMERATOR = unchecked((int)0x8032001D);

        /// <summary>
        /// The flags field contains an invalid value.
        /// </summary>
        public const int FWP_E_INVALID_FLAGS = unchecked((int)0x8032001E);

        /// <summary>
        /// A network mask is not valid.
        /// </summary>
        public const int FWP_E_INVALID_NET_MASK = unchecked((int)0x8032001F);

        /// <summary>
        /// An FWP_RANGE is not valid.
        /// </summary>
        public const int FWP_E_INVALID_RANGE = unchecked((int)0x80320020);

        /// <summary>
        /// The time interval is not valid.
        /// </summary>
        public const int FWP_E_INVALID_INTERVAL = unchecked((int)0x80320021);

        /// <summary>
        /// An array that must contain at least one element is zero length.
        /// </summary>
        public const int FWP_E_ZERO_LENGTH_ARRAY = unchecked((int)0x80320022);

        /// <summary>
        /// The displayData.name field cannot be null.
        /// </summary>
        public const int FWP_E_NULL_DISPLAY_NAME = unchecked((int)0x80320023);

        /// <summary>
        /// The action type is not one of the allowed action types for a filter.
        /// </summary>
        public const int FWP_E_INVALID_ACTION_TYPE = unchecked((int)0x80320024);

        /// <summary>
        /// The filter weight is not valid.
        /// </summary>
        public const int FWP_E_INVALID_WEIGHT = unchecked((int)0x80320025);

        /// <summary>
        /// A filter condition contains a match type that is not compatible with the operands.
        /// </summary>
        public const int FWP_E_MATCH_TYPE_MISMATCH = unchecked((int)0x80320026);

        /// <summary>
        /// An FWP_VALUE or FWPM_CONDITION_VALUE is of the wrong type.
        /// </summary>
        public const int FWP_E_TYPE_MISMATCH = unchecked((int)0x80320027);

        /// <summary>
        /// An integer value is outside the allowed range.
        /// </summary>
        public const int FWP_E_OUT_OF_BOUNDS = unchecked((int)0x80320028);

        /// <summary>
        /// A reserved field is non-zero.
        /// </summary>
        public const int FWP_E_RESERVED = unchecked((int)0x80320029);

        /// <summary>
        /// A filter cannot contain multiple conditions operating on a single field.
        /// </summary>
        public const int FWP_E_DUPLICATE_CONDITION = unchecked((int)0x8032002A);

        /// <summary>
        /// A policy cannot contain the same keying module more than once.
        /// </summary>
        public const int FWP_E_DUPLICATE_KEYMOD = unchecked((int)0x8032002B);

        /// <summary>
        /// The action type is not compatible with the layer.
        /// </summary>
        public const int FWP_E_ACTION_INCOMPATIBLE_WITH_LAYER = unchecked((int)0x8032002C);

        /// <summary>
        /// The action type is not compatible with the sublayer.
        /// </summary>
        public const int FWP_E_ACTION_INCOMPATIBLE_WITH_SUBLAYER = unchecked((int)0x8032002D);

        /// <summary>
        /// The raw context or the provider context is not compatible with the layer.
        /// </summary>
        public const int FWP_E_CONTEXT_INCOMPATIBLE_WITH_LAYER = unchecked((int)0x8032002E);

        /// <summary>
        /// The raw context or the provider context is not compatible with the callout.
        /// </summary>
        public const int FWP_E_CONTEXT_INCOMPATIBLE_WITH_CALLOUT = unchecked((int)0x8032002F);

        /// <summary>
        /// The authentication method is not compatible with the policy type.
        /// </summary>
        public const int FWP_E_INCOMPATIBLE_AUTH_METHOD = unchecked((int)0x80320030);

        /// <summary>
        /// The Diffie-Hellman group is not compatible with the policy type.
        /// </summary>
        public const int FWP_E_INCOMPATIBLE_DH_GROUP = unchecked((int)0x80320031);

        /// <summary>
        /// An IKE policy cannot contain an Extended Mode policy.
        /// </summary>
        public const int FWP_E_EM_NOT_SUPPORTED = unchecked((int)0x80320032);

        /// <summary>
        /// The enumeration template or subscription will never match any objects.
        /// </summary>
        public const int FWP_E_NEVER_MATCH = unchecked((int)0x80320033);

        /// <summary>
        /// The provider context is of the wrong type.
        /// </summary>
        public const int FWP_E_PROVIDER_CONTEXT_MISMATCH = unchecked((int)0x80320034);

        /// <summary>
        /// The parameter is incorrect.
        /// </summary>
        public const int FWP_E_INVALID_PARAMETER = unchecked((int)0x80320035);

        /// <summary>
        /// The maximum number of sublayers has been reached.
        /// </summary>
        public const int FWP_E_TOO_MANY_SUBLAYERS = unchecked((int)0x80320036);

        /// <summary>
        /// The notification function for a callout returned an error.
        /// </summary>
        public const int FWP_E_CALLOUT_NOTIFICATION_FAILED = unchecked((int)0x80320037);

        /// <summary>
        /// The IPsec authentication transform is not valid.
        /// </summary>
        public const int FWP_E_INVALID_AUTH_TRANSFORM = unchecked((int)0x80320038);

        /// <summary>
        /// The IPsec cipher transform is not valid.
        /// </summary>
        public const int FWP_E_INVALID_CIPHER_TRANSFORM = unchecked((int)0x80320039);

        /// <summary>
        /// The IPsec cipher transform is not compatible with the policy.
        /// </summary>
        public const int FWP_E_INCOMPATIBLE_CIPHER_TRANSFORM = unchecked((int)0x8032003A);

        /// <summary>
        /// The combination of IPsec transform types is not valid.
        /// </summary>
        public const int FWP_E_INVALID_TRANSFORM_COMBINATION = unchecked((int)0x8032003B);

        /// <summary>
        /// A policy cannot contain the same auth method more than once.
        /// </summary>
        public const int FWP_E_DUPLICATE_AUTH_METHOD = unchecked((int)0x8032003C);

        /// <summary>
        /// A tunnel endpoint configuration is invalid.
        /// </summary>
        public const int FWP_E_INVALID_TUNNEL_ENDPOINT = unchecked((int)0x8032003D);

        /// <summary>
        /// The WFP MAC Layers are not ready.
        /// </summary>
        public const int FWP_E_L2_DRIVER_NOT_READY = unchecked((int)0x8032003E);

        /// <summary>
        /// A key manager capable of key dictation is already registered
        /// </summary>
        public const int FWP_E_KEY_DICTATOR_ALREADY_REGISTERED = unchecked((int)0x8032003F);

        /// <summary>
        /// A key manager dictated invalid keys
        /// </summary>
        public const int FWP_E_KEY_DICTATION_INVALID_KEYING_MATERIAL = unchecked((int)0x80320040);

        /// <summary>
        /// The BFE IPsec Connection Tracking is disabled.
        /// </summary>
        public const int FWP_E_CONNECTIONS_DISABLED = unchecked((int)0x80320041);

        /// <summary>
        /// The DNS name is invalid.
        /// </summary>
        public const int FWP_E_INVALID_DNS_NAME = unchecked((int)0x80320042);

        /// <summary>
        /// The engine option is still enabled due to other configuration settings.
        /// </summary>
        public const int FWP_E_STILL_ON = unchecked((int)0x80320043);

        /// <summary>
        /// The IKEEXT service is not running.  This service only runs when there is IPsec policy applied to the machine.
        /// </summary>
        public const int FWP_E_IKEEXT_NOT_RUNNING = unchecked((int)0x80320044);

        /// <summary>
        /// The packet should be dropped, no ICMP should be sent.
        /// </summary>
        public const int FWP_E_DROP_NOICMP = unchecked((int)0x80320104);


        ///////////////////////////////////////////////////
        //                                               //
        //       Web Services Platform Error Codes       //
        //                                               //
        ///////////////////////////////////////////////////

        /// <summary>
        /// The function call is completing asynchronously.
        /// </summary>
        public const int WS_S_ASYNC = 0x003D0000;

        /// <summary>
        /// There are no more messages available on the channel.
        /// </summary>
        public const int WS_S_END = 0x003D0001;

        /// <summary>
        /// The input data was not in the expected format or did not have the expected value.
        /// </summary>
        public const int WS_E_INVALID_FORMAT = unchecked((int)0x803D0000);

        /// <summary>
        /// The operation could not be completed because the object is in a faulted state due to a previous error.
        /// </summary>
        public const int WS_E_OBJECT_FAULTED = unchecked((int)0x803D0001);

        /// <summary>
        /// The operation could not be completed because it would lead to numeric overflow.
        /// </summary>
        public const int WS_E_NUMERIC_OVERFLOW = unchecked((int)0x803D0002);

        /// <summary>
        /// The operation is not allowed due to the current state of the object.
        /// </summary>
        public const int WS_E_INVALID_OPERATION = unchecked((int)0x803D0003);

        /// <summary>
        /// The operation was aborted.
        /// </summary>
        public const int WS_E_OPERATION_ABORTED = unchecked((int)0x803D0004);

        /// <summary>
        /// Access was denied by the remote endpoint.
        /// </summary>
        public const int WS_E_ENDPOINT_ACCESS_DENIED = unchecked((int)0x803D0005);

        /// <summary>
        /// The operation did not complete within the time allotted.
        /// </summary>
        public const int WS_E_OPERATION_TIMED_OUT = unchecked((int)0x803D0006);

        /// <summary>
        /// The operation was abandoned.
        /// </summary>
        public const int WS_E_OPERATION_ABANDONED = unchecked((int)0x803D0007);

        /// <summary>
        /// A quota was exceeded.
        /// </summary>
        public const int WS_E_QUOTA_EXCEEDED = unchecked((int)0x803D0008);

        /// <summary>
        /// The information was not available in the specified language.
        /// </summary>
        public const int WS_E_NO_TRANSLATION_AVAILABLE = unchecked((int)0x803D0009);

        /// <summary>
        /// Security verification was not successful for the received data.
        /// </summary>
        public const int WS_E_SECURITY_VERIFICATION_FAILURE = unchecked((int)0x803D000A);

        /// <summary>
        /// The address is already being used.
        /// </summary>
        public const int WS_E_ADDRESS_IN_USE = unchecked((int)0x803D000B);

        /// <summary>
        /// The address is not valid for this context.
        /// </summary>
        public const int WS_E_ADDRESS_NOT_AVAILABLE = unchecked((int)0x803D000C);

        /// <summary>
        /// The remote endpoint does not exist or could not be located.
        /// </summary>
        public const int WS_E_ENDPOINT_NOT_FOUND = unchecked((int)0x803D000D);

        /// <summary>
        /// The remote endpoint is not currently in service at this location.
        /// </summary>
        public const int WS_E_ENDPOINT_NOT_AVAILABLE = unchecked((int)0x803D000E);

        /// <summary>
        /// The remote endpoint could not process the request.
        /// </summary>
        public const int WS_E_ENDPOINT_FAILURE = unchecked((int)0x803D000F);

        /// <summary>
        /// The remote endpoint was not reachable.
        /// </summary>
        public const int WS_E_ENDPOINT_UNREACHABLE = unchecked((int)0x803D0010);

        /// <summary>
        /// The operation was not supported by the remote endpoint.
        /// </summary>
        public const int WS_E_ENDPOINT_ACTION_NOT_SUPPORTED = unchecked((int)0x803D0011);

        /// <summary>
        /// The remote endpoint is unable to process the request due to being overloaded.
        /// </summary>
        public const int WS_E_ENDPOINT_TOO_BUSY = unchecked((int)0x803D0012);

        /// <summary>
        /// A message containing a fault was received from the remote endpoint.
        /// </summary>
        public const int WS_E_ENDPOINT_FAULT_RECEIVED = unchecked((int)0x803D0013);

        /// <summary>
        /// The connection with the remote endpoint was terminated.
        /// </summary>
        public const int WS_E_ENDPOINT_DISCONNECTED = unchecked((int)0x803D0014);

        /// <summary>
        /// The HTTP proxy server could not process the request.
        /// </summary>
        public const int WS_E_PROXY_FAILURE = unchecked((int)0x803D0015);

        /// <summary>
        /// Access was denied by the HTTP proxy server.
        /// </summary>
        public const int WS_E_PROXY_ACCESS_DENIED = unchecked((int)0x803D0016);

        /// <summary>
        /// The requested feature is not available on this platform.
        /// </summary>
        public const int WS_E_NOT_SUPPORTED = unchecked((int)0x803D0017);

        /// <summary>
        /// The HTTP proxy server requires HTTP authentication scheme 'basic'.
        /// </summary>
        public const int WS_E_PROXY_REQUIRES_BASIC_AUTH = unchecked((int)0x803D0018);

        /// <summary>
        /// The HTTP proxy server requires HTTP authentication scheme 'digest'.
        /// </summary>
        public const int WS_E_PROXY_REQUIRES_DIGEST_AUTH = unchecked((int)0x803D0019);

        /// <summary>
        /// The HTTP proxy server requires HTTP authentication scheme 'NTLM'.
        /// </summary>
        public const int WS_E_PROXY_REQUIRES_NTLM_AUTH = unchecked((int)0x803D001A);

        /// <summary>
        /// The HTTP proxy server requires HTTP authentication scheme 'negotiate'.
        /// </summary>
        public const int WS_E_PROXY_REQUIRES_NEGOTIATE_AUTH = unchecked((int)0x803D001B);

        /// <summary>
        /// The remote endpoint requires HTTP authentication scheme 'basic'.
        /// </summary>
        public const int WS_E_SERVER_REQUIRES_BASIC_AUTH = unchecked((int)0x803D001C);

        /// <summary>
        /// The remote endpoint requires HTTP authentication scheme 'digest'.
        /// </summary>
        public const int WS_E_SERVER_REQUIRES_DIGEST_AUTH = unchecked((int)0x803D001D);

        /// <summary>
        /// The remote endpoint requires HTTP authentication scheme 'NTLM'.
        /// </summary>
        public const int WS_E_SERVER_REQUIRES_NTLM_AUTH = unchecked((int)0x803D001E);

        /// <summary>
        /// The remote endpoint requires HTTP authentication scheme 'negotiate'.
        /// </summary>
        public const int WS_E_SERVER_REQUIRES_NEGOTIATE_AUTH = unchecked((int)0x803D001F);

        /// <summary>
        /// The endpoint address URL is invalid.
        /// </summary>
        public const int WS_E_INVALID_ENDPOINT_URL = unchecked((int)0x803D0020);

        /// <summary>
        /// Unrecognized error occurred in the Windows Web Services framework.
        /// </summary>
        public const int WS_E_OTHER = unchecked((int)0x803D0021);

        /// <summary>
        /// A security token was rejected by the server because it has expired.
        /// </summary>
        public const int WS_E_SECURITY_TOKEN_EXPIRED = unchecked((int)0x803D0022);

        /// <summary>
        /// A security operation failed in the Windows Web Services framework.
        /// </summary>
        public const int WS_E_SECURITY_SYSTEM_FAILURE = unchecked((int)0x803D0023);


        //
        // NDIS error codes (ndis.sys)
        //

        /// <summary>
        /// The binding to the network interface is being closed.
        /// </summary>
        public const int ERROR_NDIS_INTERFACE_CLOSING = unchecked((int)0x80340002);

        /// <summary>
        /// An invalid version was specified.
        /// </summary>
        public const int ERROR_NDIS_BAD_VERSION = unchecked((int)0x80340004);

        /// <summary>
        /// An invalid characteristics table was used.
        /// </summary>
        public const int ERROR_NDIS_BAD_CHARACTERISTICS = unchecked((int)0x80340005);

        /// <summary>
        /// Failed to find the network interface or network interface is not ready.
        /// </summary>
        public const int ERROR_NDIS_ADAPTER_NOT_FOUND = unchecked((int)0x80340006);

        /// <summary>
        /// Failed to open the network interface.
        /// </summary>
        public const int ERROR_NDIS_OPEN_FAILED = unchecked((int)0x80340007);

        /// <summary>
        /// Network interface has encountered an internal unrecoverable failure.
        /// </summary>
        public const int ERROR_NDIS_DEVICE_FAILED = unchecked((int)0x80340008);

        /// <summary>
        /// The multicast list on the network interface is full.
        /// </summary>
        public const int ERROR_NDIS_MULTICAST_FULL = unchecked((int)0x80340009);

        /// <summary>
        /// An attempt was made to add a duplicate multicast address to the list.
        /// </summary>
        public const int ERROR_NDIS_MULTICAST_EXISTS = unchecked((int)0x8034000A);

        /// <summary>
        /// At attempt was made to remove a multicast address that was never added.
        /// </summary>
        public const int ERROR_NDIS_MULTICAST_NOT_FOUND = unchecked((int)0x8034000B);

        /// <summary>
        /// Netowork interface aborted the request.
        /// </summary>
        public const int ERROR_NDIS_REQUEST_ABORTED = unchecked((int)0x8034000C);

        /// <summary>
        /// Network interface can not process the request because it is being reset.
        /// </summary>
        public const int ERROR_NDIS_RESET_IN_PROGRESS = unchecked((int)0x8034000D);

        /// <summary>
        /// Netword interface does not support this request.
        /// </summary>
        public const int ERROR_NDIS_NOT_SUPPORTED = unchecked((int)0x803400BB);

        /// <summary>
        /// An attempt was made to send an invalid packet on a network interface.
        /// </summary>
        public const int ERROR_NDIS_INVALID_PACKET = unchecked((int)0x8034000F);

        /// <summary>
        /// Network interface is not ready to complete this operation.
        /// </summary>
        public const int ERROR_NDIS_ADAPTER_NOT_READY = unchecked((int)0x80340011);

        /// <summary>
        /// The length of the buffer submitted for this operation is not valid.
        /// </summary>
        public const int ERROR_NDIS_INVALID_LENGTH = unchecked((int)0x80340014);

        /// <summary>
        /// The data used for this operation is not valid.
        /// </summary>
        public const int ERROR_NDIS_INVALID_DATA = unchecked((int)0x80340015);

        /// <summary>
        /// The length of buffer submitted for this operation is too small.
        /// </summary>
        public const int ERROR_NDIS_BUFFER_TOO_SHORT = unchecked((int)0x80340016);

        /// <summary>
        /// Network interface does not support this OID (Object Identifier)
        /// </summary>
        public const int ERROR_NDIS_INVALID_OID = unchecked((int)0x80340017);

        /// <summary>
        /// The network interface has been removed.
        /// </summary>
        public const int ERROR_NDIS_ADAPTER_REMOVED = unchecked((int)0x80340018);

        /// <summary>
        /// Network interface does not support this media type.
        /// </summary>
        public const int ERROR_NDIS_UNSUPPORTED_MEDIA = unchecked((int)0x80340019);

        /// <summary>
        /// An attempt was made to remove a token ring group address that is in use by other components.
        /// </summary>
        public const int ERROR_NDIS_GROUP_ADDRESS_IN_USE = unchecked((int)0x8034001A);

        /// <summary>
        /// An attempt was made to map a file that can not be found.
        /// </summary>
        public const int ERROR_NDIS_FILE_NOT_FOUND = unchecked((int)0x8034001B);

        /// <summary>
        /// An error occurred while NDIS tried to map the file.
        /// </summary>
        public const int ERROR_NDIS_ERROR_READING_FILE = unchecked((int)0x8034001C);

        /// <summary>
        /// An attempt was made to map a file that is alreay mapped.
        /// </summary>
        public const int ERROR_NDIS_ALREADY_MAPPED = unchecked((int)0x8034001D);

        /// <summary>
        /// An attempt to allocate a hardware resource failed because the resource is used by another component.
        /// </summary>
        public const int ERROR_NDIS_RESOURCE_CONFLICT = unchecked((int)0x8034001E);

        /// <summary>
        /// The I/O operation failed because network media is disconnected or wireless access point is out of range.
        /// </summary>
        public const int ERROR_NDIS_MEDIA_DISCONNECTED = unchecked((int)0x8034001F);

        /// <summary>
        /// The network address used in the request is invalid.
        /// </summary>
        public const int ERROR_NDIS_INVALID_ADDRESS = unchecked((int)0x80340022);

        /// <summary>
        /// The specified request is not a valid operation for the target device.
        /// </summary>
        public const int ERROR_NDIS_INVALID_DEVICE_REQUEST = unchecked((int)0x80340010);

        /// <summary>
        /// The offload operation on the network interface has been paused.
        /// </summary>
        public const int ERROR_NDIS_PAUSED = unchecked((int)0x8034002A);

        /// <summary>
        /// Network interface was not found.
        /// </summary>
        public const int ERROR_NDIS_INTERFACE_NOT_FOUND = unchecked((int)0x8034002B);

        /// <summary>
        /// The revision number specified in the structure is not supported.
        /// </summary>
        public const int ERROR_NDIS_UNSUPPORTED_REVISION = unchecked((int)0x8034002C);

        /// <summary>
        /// The specified port does not exist on this network interface.
        /// </summary>
        public const int ERROR_NDIS_INVALID_PORT = unchecked((int)0x8034002D);

        /// <summary>
        /// The current state of the specified port on this network interface does not support the requested operation.
        /// </summary>
        public const int ERROR_NDIS_INVALID_PORT_STATE = unchecked((int)0x8034002E);

        /// <summary>
        /// The miniport adapter is in low power state.
        /// </summary>
        public const int ERROR_NDIS_LOW_POWER_STATE = unchecked((int)0x8034002F);

        /// <summary>
        /// This operation requires the miniport adapter to be reinitialized.
        /// </summary>
        public const int ERROR_NDIS_REINIT_REQUIRED = unchecked((int)0x80340030);


        //
        // NDIS error codes (802.11 wireless LAN)
        //

        /// <summary>
        /// The wireless local area network interface is in auto configuration mode and doesn't support the requested parameter change operation.
        /// </summary>
        public const int ERROR_NDIS_DOT11_AUTO_CONFIG_ENABLED = unchecked((int)0x80342000);

        /// <summary>
        /// The wireless local area network interface is busy and can not perform the requested operation.
        /// </summary>
        public const int ERROR_NDIS_DOT11_MEDIA_IN_USE = unchecked((int)0x80342001);

        /// <summary>
        /// The wireless local area network interface is powered down and doesn't support the requested operation.
        /// </summary>
        public const int ERROR_NDIS_DOT11_POWER_STATE_INVALID = unchecked((int)0x80342002);

        /// <summary>
        /// The list of wake on LAN patterns is full.
        /// </summary>
        public const int ERROR_NDIS_PM_WOL_PATTERN_LIST_FULL = unchecked((int)0x80342003);

        /// <summary>
        /// The list of low power protocol offloads is full.
        /// </summary>
        public const int ERROR_NDIS_PM_PROTOCOL_OFFLOAD_LIST_FULL = unchecked((int)0x80342004);

        /// <summary>
        /// The wireless local area network interface cannot start an AP on the specified channel right now.
        /// </summary>
        public const int ERROR_NDIS_DOT11_AP_CHANNEL_CURRENTLY_NOT_AVAILABLE = unchecked((int)0x80342005);

        /// <summary>
        /// The wireless local area network interface cannot start an AP on the specified band right now.
        /// </summary>
        public const int ERROR_NDIS_DOT11_AP_BAND_CURRENTLY_NOT_AVAILABLE = unchecked((int)0x80342006);

        /// <summary>
        /// The wireless local area network interface cannot start an AP on this channel due to regulatory reasons.
        /// </summary>
        public const int ERROR_NDIS_DOT11_AP_CHANNEL_NOT_ALLOWED = unchecked((int)0x80342007);

        /// <summary>
        /// The wireless local area network interface cannot start an AP on this band due to regulatory reasons.
        /// </summary>
        public const int ERROR_NDIS_DOT11_AP_BAND_NOT_ALLOWED = unchecked((int)0x80342008);

        //
        // NDIS informational code (ndis.sys)
        //

        /// <summary>
        /// The request will be completed later by NDIS status indication.
        /// </summary>
        public const int ERROR_NDIS_INDICATION_REQUIRED = 0x00340001;

        //
        // NDIS Chimney Offload codes (ndis.sys)
        //

        /// <summary>
        /// The TCP connection is not offloadable because of a local policy setting.
        /// </summary>
        public const int ERROR_NDIS_OFFLOAD_POLICY = unchecked((int)0xC034100F);

        /// <summary>
        /// The TCP connection is not offloadable by the Chimney Offload target.
        /// </summary>
        public const int ERROR_NDIS_OFFLOAD_CONNECTION_REJECTED = unchecked((int)0xC0341012);

        /// <summary>
        /// The IP Path object is not in an offloadable state.
        /// </summary>
        public const int ERROR_NDIS_OFFLOAD_PATH_REJECTED = unchecked((int)0xC0341013);

        //
        // Hypervisor error codes
        //

        /// <summary>
        /// The hypervisor does not support the operation because the specified hypercall code is not supported.
        /// </summary>
        public const int ERROR_HV_INVALID_HYPERCALL_CODE = unchecked((int)0xC0350002);

        /// <summary>
        /// The hypervisor does not support the operation because the encoding for the hypercall input register is not supported.
        /// </summary>
        public const int ERROR_HV_INVALID_HYPERCALL_INPUT = unchecked((int)0xC0350003);

        /// <summary>
        /// The hypervisor could not perform the operation because a parameter has an invalid alignment.
        /// </summary>
        public const int ERROR_HV_INVALID_ALIGNMENT = unchecked((int)0xC0350004);

        /// <summary>
        /// The hypervisor could not perform the operation because an invalid parameter was specified.
        /// </summary>
        public const int ERROR_HV_INVALID_PARAMETER = unchecked((int)0xC0350005);

        /// <summary>
        /// Access to the specified object was denied.
        /// </summary>
        public const int ERROR_HV_ACCESS_DENIED = unchecked((int)0xC0350006);

        /// <summary>
        /// The hypervisor could not perform the operation because the partition is entering or in an invalid state.
        /// </summary>
        public const int ERROR_HV_INVALID_PARTITION_STATE = unchecked((int)0xC0350007);

        /// <summary>
        /// The operation is not allowed in the current state.
        /// </summary>
        public const int ERROR_HV_OPERATION_DENIED = unchecked((int)0xC0350008);

        /// <summary>
        /// The hypervisor does not recognize the specified partition property.
        /// </summary>
        public const int ERROR_HV_UNKNOWN_PROPERTY = unchecked((int)0xC0350009);

        /// <summary>
        /// The specified value of a partition property is out of range or violates an invariant.
        /// </summary>
        public const int ERROR_HV_PROPERTY_VALUE_OUT_OF_RANGE = unchecked((int)0xC035000A);

        /// <summary>
        /// There is not enough memory in the hypervisor pool to complete the operation.
        /// </summary>
        public const int ERROR_HV_INSUFFICIENT_MEMORY = unchecked((int)0xC035000B);

        /// <summary>
        /// The maximum partition depth has been exceeded for the partition hierarchy.
        /// </summary>
        public const int ERROR_HV_PARTITION_TOO_DEEP = unchecked((int)0xC035000C);

        /// <summary>
        /// A partition with the specified partition Id does not exist.
        /// </summary>
        public const int ERROR_HV_INVALID_PARTITION_ID = unchecked((int)0xC035000D);

        /// <summary>
        /// The hypervisor could not perform the operation because the specified VP index is invalid.
        /// </summary>
        public const int ERROR_HV_INVALID_VP_INDEX = unchecked((int)0xC035000E);

        /// <summary>
        /// The hypervisor could not perform the operation because the specified port identifier is invalid.
        /// </summary>
        public const int ERROR_HV_INVALID_PORT_ID = unchecked((int)0xC0350011);

        /// <summary>
        /// The hypervisor could not perform the operation because the specified connection identifier is invalid.
        /// </summary>
        public const int ERROR_HV_INVALID_CONNECTION_ID = unchecked((int)0xC0350012);

        /// <summary>
        /// Not enough buffers were supplied to send a message.
        /// </summary>
        public const int ERROR_HV_INSUFFICIENT_BUFFERS = unchecked((int)0xC0350013);

        /// <summary>
        /// The previous virtual interrupt has not been acknowledged.
        /// </summary>
        public const int ERROR_HV_NOT_ACKNOWLEDGED = unchecked((int)0xC0350014);

        /// <summary>
        /// A virtual processor is not in the correct state for the indicated operation.
        /// </summary>
        public const int ERROR_HV_INVALID_VP_STATE = unchecked((int)0xC0350015);

        /// <summary>
        /// The previous virtual interrupt has already been acknowledged.
        /// </summary>
        public const int ERROR_HV_ACKNOWLEDGED = unchecked((int)0xC0350016);

        /// <summary>
        /// The indicated partition is not in a valid state for saving or restoring.
        /// </summary>
        public const int ERROR_HV_INVALID_SAVE_RESTORE_STATE = unchecked((int)0xC0350017);

        /// <summary>
        /// The hypervisor could not complete the operation because a required feature of the synthetic interrupt controller (SynIC) was disabled.
        /// </summary>
        public const int ERROR_HV_INVALID_SYNIC_STATE = unchecked((int)0xC0350018);

        /// <summary>
        /// The hypervisor could not perform the operation because the object or value was either already in use or being used for a purpose that would not permit completing the operation.
        /// </summary>
        public const int ERROR_HV_OBJECT_IN_USE = unchecked((int)0xC0350019);

        /// <summary>
        /// The proximity domain information is invalid.
        /// </summary>
        public const int ERROR_HV_INVALID_PROXIMITY_DOMAIN_INFO = unchecked((int)0xC035001A);

        /// <summary>
        /// An attempt to retrieve debugging data failed because none was available.
        /// </summary>
        public const int ERROR_HV_NO_DATA = unchecked((int)0xC035001B);

        /// <summary>
        /// The physical connection being used for debuggging has not recorded any receive activity since the last operation.
        /// </summary>
        public const int ERROR_HV_INACTIVE = unchecked((int)0xC035001C);

        /// <summary>
        /// There are not enough resources to complete the operation.
        /// </summary>
        public const int ERROR_HV_NO_RESOURCES = unchecked((int)0xC035001D);

        /// <summary>
        /// A hypervisor feature is not available to the user.
        /// </summary>
        public const int ERROR_HV_FEATURE_UNAVAILABLE = unchecked((int)0xC035001E);

        /// <summary>
        /// The specified buffer was too small to contain all of the requested data.
        /// </summary>
        public const int ERROR_HV_INSUFFICIENT_BUFFER = unchecked((int)0xC0350033);

        /// <summary>
        /// The maximum number of domains supported by the platform I/O remapping hardware is currently in use. No domains are available to assign this device to this partition.
        /// </summary>
        public const int ERROR_HV_INSUFFICIENT_DEVICE_DOMAINS = unchecked((int)0xC0350038);

        /// <summary>
        /// Validation of CPUID data of the processor failed.
        /// </summary>
        public const int ERROR_HV_CPUID_FEATURE_VALIDATION = unchecked((int)0xC035003C);

        /// <summary>
        /// Validation of XSAVE CPUID data of the processor failed.
        /// </summary>
        public const int ERROR_HV_CPUID_XSAVE_FEATURE_VALIDATION = unchecked((int)0xC035003D);

        /// <summary>
        /// Processor did not respond within the timeout period.
        /// </summary>
        public const int ERROR_HV_PROCESSOR_STARTUP_TIMEOUT = unchecked((int)0xC035003E);

        /// <summary>
        /// SMX has been enabled in the BIOS.
        /// </summary>
        public const int ERROR_HV_SMX_ENABLED = unchecked((int)0xC035003F);

        /// <summary>
        /// The hypervisor could not perform the operation because the specified LP index is invalid.
        /// </summary>
        public const int ERROR_HV_INVALID_LP_INDEX = unchecked((int)0xC0350041);

        /// <summary>
        /// The supplied register value is invalid.
        /// </summary>
        public const int ERROR_HV_INVALID_REGISTER_VALUE = unchecked((int)0xC0350050);

        /// <summary>
        /// The supplied virtual trust level is not in the correct state to perform the requested operation.
        /// </summary>
        public const int ERROR_HV_INVALID_VTL_STATE = unchecked((int)0xC0350051);

        /// <summary>
        /// No execute feature (NX) is not present or not enabled in the BIOS.
        /// </summary>
        public const int ERROR_HV_NX_NOT_DETECTED = unchecked((int)0xC0350055);

        /// <summary>
        /// The supplied device ID is invalid.
        /// </summary>
        public const int ERROR_HV_INVALID_DEVICE_ID = unchecked((int)0xC0350057);

        /// <summary>
        /// The operation is not allowed in the current device state.
        /// </summary>
        public const int ERROR_HV_INVALID_DEVICE_STATE = unchecked((int)0xC0350058);

        /// <summary>
        /// The device had pending page requests which were discarded.
        /// </summary>
        public const int ERROR_HV_PENDING_PAGE_REQUESTS = 0x00350059;

        /// <summary>
        /// The supplied page request specifies a memory access that the guest does not have permissions to perform.
        /// </summary>
        public const int ERROR_HV_PAGE_REQUEST_INVALID = unchecked((int)0xC0350060);

        /// <summary>
        /// A CPU group with the specified CPU group Id does not exist.
        /// </summary>
        public const int ERROR_HV_INVALID_CPU_GROUP_ID = unchecked((int)0xC035006F);

        /// <summary>
        /// The hypervisor could not perform the operation because the CPU group is entering or in an invalid state.
        /// </summary>
        public const int ERROR_HV_INVALID_CPU_GROUP_STATE = unchecked((int)0xC0350070);

        /// <summary>
        /// The requested operation failed.
        /// </summary>
        public const int ERROR_HV_OPERATION_FAILED = unchecked((int)0xC0350071);

        /// <summary>
        /// The hypervisor could not perform the operation because it is not allowed with nested virtualization active.
        /// </summary>
        public const int ERROR_HV_NOT_ALLOWED_WITH_NESTED_VIRT_ACTIVE = unchecked((int)0xC0350072);

        /// <summary>
        /// No hypervisor is present on this system.
        /// </summary>
        public const int ERROR_HV_NOT_PRESENT = unchecked((int)0xC0351000);

        //
        // Virtualization error codes - these codes are used by the Virtualization Infrustructure Driver (VID) and other components
        //                              of the virtualization stack.
        //
        // VID errors (0x0001 - 0x00ff)
        //

        /// <summary>
        /// The handler for the virtualization infrastructure driver is already registered. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_DUPLICATE_HANDLER = unchecked((int)0xC0370001);

        /// <summary>
        /// The number of registered handlers for the virtualization infrastructure driver exceeded the maximum. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_TOO_MANY_HANDLERS = unchecked((int)0xC0370002);

        /// <summary>
        /// The message queue for the virtualization infrastructure driver is full and cannot accept new messages. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_QUEUE_FULL = unchecked((int)0xC0370003);

        /// <summary>
        /// No handler exists to handle the message for the virtualization infrastructure driver. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_HANDLER_NOT_PRESENT = unchecked((int)0xC0370004);

        /// <summary>
        /// The name of the partition or message queue for the virtualization infrastructure driver is invalid. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_INVALID_OBJECT_NAME = unchecked((int)0xC0370005);

        /// <summary>
        /// The partition name of the virtualization infrastructure driver exceeds the maximum.
        /// </summary>
        public const int ERROR_VID_PARTITION_NAME_TOO_LONG = unchecked((int)0xC0370006);

        /// <summary>
        /// The message queue name of the virtualization infrastructure driver exceeds the maximum.
        /// </summary>
        public const int ERROR_VID_MESSAGE_QUEUE_NAME_TOO_LONG = unchecked((int)0xC0370007);

        /// <summary>
        /// Cannot create the partition for the virtualization infrastructure driver because another partition with the same name already exists.
        /// </summary>
        public const int ERROR_VID_PARTITION_ALREADY_EXISTS = unchecked((int)0xC0370008);

        /// <summary>
        /// The virtualization infrastructure driver has encountered an error. The requested partition does not exist. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_PARTITION_DOES_NOT_EXIST = unchecked((int)0xC0370009);

        /// <summary>
        /// The virtualization infrastructure driver has encountered an error. Could not find the requested partition. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_PARTITION_NAME_NOT_FOUND = unchecked((int)0xC037000A);

        /// <summary>
        /// A message queue with the same name already exists for the virtualization infrastructure driver.
        /// </summary>
        public const int ERROR_VID_MESSAGE_QUEUE_ALREADY_EXISTS = unchecked((int)0xC037000B);

        /// <summary>
        /// The memory block page for the virtualization infrastructure driver cannot be mapped because the page map limit has been reached. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_EXCEEDED_MBP_ENTRY_MAP_LIMIT = unchecked((int)0xC037000C);

        /// <summary>
        /// The memory block for the virtualization infrastructure driver is still being used and cannot be destroyed.
        /// </summary>
        public const int ERROR_VID_MB_STILL_REFERENCED = unchecked((int)0xC037000D);

        /// <summary>
        /// Cannot unlock the page array for the guest operating system memory address because it does not match a previous lock request. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_CHILD_GPA_PAGE_SET_CORRUPTED = unchecked((int)0xC037000E);

        /// <summary>
        /// The non-uniform memory access (NUMA) node settings do not match the system NUMA topology. In order to start the virtual machine, you will need to modify the NUMA configuration.
        /// </summary>
        public const int ERROR_VID_INVALID_NUMA_SETTINGS = unchecked((int)0xC037000F);

        /// <summary>
        /// The non-uniform memory access (NUMA) node index does not match a valid index in the system NUMA topology.
        /// </summary>
        public const int ERROR_VID_INVALID_NUMA_NODE_INDEX = unchecked((int)0xC0370010);

        /// <summary>
        /// The memory block for the virtualization infrastructure driver is already associated with a message queue.
        /// </summary>
        public const int ERROR_VID_NOTIFICATION_QUEUE_ALREADY_ASSOCIATED = unchecked((int)0xC0370011);

        /// <summary>
        /// The handle is not a valid memory block handle for the virtualization infrastructure driver.
        /// </summary>
        public const int ERROR_VID_INVALID_MEMORY_BLOCK_HANDLE = unchecked((int)0xC0370012);

        /// <summary>
        /// The request exceeded the memory block page limit for the virtualization infrastructure driver. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_PAGE_RANGE_OVERFLOW = unchecked((int)0xC0370013);

        /// <summary>
        /// The handle is not a valid message queue handle for the virtualization infrastructure driver.
        /// </summary>
        public const int ERROR_VID_INVALID_MESSAGE_QUEUE_HANDLE = unchecked((int)0xC0370014);

        /// <summary>
        /// The handle is not a valid page range handle for the virtualization infrastructure driver.
        /// </summary>
        public const int ERROR_VID_INVALID_GPA_RANGE_HANDLE = unchecked((int)0xC0370015);

        /// <summary>
        /// Cannot install client notifications because no message queue for the virtualization infrastructure driver is associated with the memory block.
        /// </summary>
        public const int ERROR_VID_NO_MEMORY_BLOCK_NOTIFICATION_QUEUE = unchecked((int)0xC0370016);

        /// <summary>
        /// The request to lock or map a memory block page failed because the virtualization infrastructure driver memory block limit has been reached. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_MEMORY_BLOCK_LOCK_COUNT_EXCEEDED = unchecked((int)0xC0370017);

        /// <summary>
        /// The handle is not a valid parent partition mapping handle for the virtualization infrastructure driver.
        /// </summary>
        public const int ERROR_VID_INVALID_PPM_HANDLE = unchecked((int)0xC0370018);

        /// <summary>
        /// Notifications cannot be created on the memory block because it is use.
        /// </summary>
        public const int ERROR_VID_MBPS_ARE_LOCKED = unchecked((int)0xC0370019);

        /// <summary>
        /// The message queue for the virtualization infrastructure driver has been closed. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_MESSAGE_QUEUE_CLOSED = unchecked((int)0xC037001A);

        /// <summary>
        /// Cannot add a virtual processor to the partition because the maximum has been reached.
        /// </summary>
        public const int ERROR_VID_VIRTUAL_PROCESSOR_LIMIT_EXCEEDED = unchecked((int)0xC037001B);

        /// <summary>
        /// Cannot stop the virtual processor immediately because of a pending intercept.
        /// </summary>
        public const int ERROR_VID_STOP_PENDING = unchecked((int)0xC037001C);

        /// <summary>
        /// Invalid state for the virtual processor. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_INVALID_PROCESSOR_STATE = unchecked((int)0xC037001D);

        /// <summary>
        /// The maximum number of kernel mode clients for the virtualization infrastructure driver has been reached. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_EXCEEDED_KM_CONTEXT_COUNT_LIMIT = unchecked((int)0xC037001E);

        /// <summary>
        /// This kernel mode interface for the virtualization infrastructure driver has already been initialized. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_KM_INTERFACE_ALREADY_INITIALIZED = unchecked((int)0xC037001F);

        /// <summary>
        /// Cannot set or reset the memory block property more than once for the virtualization infrastructure driver. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_MB_PROPERTY_ALREADY_SET_RESET = unchecked((int)0xC0370020);

        /// <summary>
        /// The memory mapped I/O for this page range no longer exists. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_MMIO_RANGE_DESTROYED = unchecked((int)0xC0370021);

        /// <summary>
        /// The lock or unlock request uses an invalid guest operating system memory address. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_INVALID_CHILD_GPA_PAGE_SET = unchecked((int)0xC0370022);

        /// <summary>
        /// Cannot destroy or reuse the reserve page set for the virtualization infrastructure driver because it is in use. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_RESERVE_PAGE_SET_IS_BEING_USED = unchecked((int)0xC0370023);

        /// <summary>
        /// The reserve page set for the virtualization infrastructure driver is too small to use in the lock request. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_RESERVE_PAGE_SET_TOO_SMALL = unchecked((int)0xC0370024);

        /// <summary>
        /// Cannot lock or map the memory block page for the virtualization infrastructure driver because it has already been locked using a reserve page set page. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_MBP_ALREADY_LOCKED_USING_RESERVED_PAGE = unchecked((int)0xC0370025);

        /// <summary>
        /// Cannot create the memory block for the virtualization infrastructure driver because the requested number of pages exceeded the limit. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.
        /// </summary>
        public const int ERROR_VID_MBP_COUNT_EXCEEDED_LIMIT = unchecked((int)0xC0370026);

        /// <summary>
        /// Cannot restore this virtual machine because the saved state data cannot be read. Delete the saved state data and then try to start the virtual machine.
        /// </summary>
        public const int ERROR_VID_SAVED_STATE_CORRUPT = unchecked((int)0xC0370027);

        /// <summary>
        /// Cannot restore this virtual machine because an item read from the saved state data is not recognized. Delete the saved state data and then try to start the virtual machine.
        /// </summary>
        public const int ERROR_VID_SAVED_STATE_UNRECOGNIZED_ITEM = unchecked((int)0xC0370028);

        /// <summary>
        /// Cannot restore this virtual machine to the saved state because of hypervisor incompatibility. Delete the saved state data and then try to start the virtual machine.
        /// </summary>
        public const int ERROR_VID_SAVED_STATE_INCOMPATIBLE = unchecked((int)0xC0370029);

        /// <summary>
        /// The specified VTL does not have the permission to access the resource.
        /// </summary>
        public const int ERROR_VID_VTL_ACCESS_DENIED = unchecked((int)0xC037002A);

        //
        // Host compute service errors (0x0100-0x01ff)
        //
        /// <summary>
        /// The compute system unexpectedly terminated while starting.
        /// </summary>
        public const int ERROR_VMCOMPUTE_TERMINATED_DURING_START = unchecked((int)0xC0370100);

        /// <summary>
        /// The operating system of the container does not match the operating system of the host.
        /// </summary>
        public const int ERROR_VMCOMPUTE_IMAGE_MISMATCH = unchecked((int)0xC0370101);

        /// <summary>
        /// A Virtual Machine could not be started because Hyper-V is not installed.
        /// </summary>
        public const int ERROR_VMCOMPUTE_HYPERV_NOT_INSTALLED = unchecked((int)0xC0370102);

        /// <summary>
        /// The call to start an asynchronous operation succeeded and the operation is performed in the background.
        /// </summary>
        public const int ERROR_VMCOMPUTE_OPERATION_PENDING = unchecked((int)0xC0370103);

        /// <summary>
        /// The supported number of notification callbacks has been exceeded.
        /// </summary>
        public const int ERROR_VMCOMPUTE_TOO_MANY_NOTIFICATIONS = unchecked((int)0xC0370104);

        /// <summary>
        /// The requested compute system operation is not valid in the current state.
        /// </summary>
        public const int ERROR_VMCOMPUTE_INVALID_STATE = unchecked((int)0xC0370105);

        /// <summary>
        /// The compute system exited unexpectedly.
        /// </summary>
        public const int ERROR_VMCOMPUTE_UNEXPECTED_EXIT = unchecked((int)0xC0370106);

        /// <summary>
        /// The compute system was forcefully terminated.
        /// </summary>
        public const int ERROR_VMCOMPUTE_TERMINATED = unchecked((int)0xC0370107);

        /// <summary>
        /// A connection could not be established with the Virtual Machine hosting the Container.
        /// </summary>
        public const int ERROR_VMCOMPUTE_CONNECT_FAILED = unchecked((int)0xC0370108);

        /// <summary>
        /// The operation timed out because a response was not received from the Virtual Machine hosting the Container.
        /// </summary>
        public const int ERROR_VMCOMPUTE_TIMEOUT = unchecked((int)0xC0370109);

        /// <summary>
        /// The connection with the Virtual Machine hosting the container was closed.
        /// </summary>
        public const int ERROR_VMCOMPUTE_CONNECTION_CLOSED = unchecked((int)0xC037010A);

        /// <summary>
        /// An unknown internal message was received by the Hyper-V Compute Service.
        /// </summary>
        public const int ERROR_VMCOMPUTE_UNKNOWN_MESSAGE = unchecked((int)0xC037010B);

        /// <summary>
        /// The communication protocol version between the Hyper-V Host and Guest Compute Services is not supported.
        /// </summary>
        public const int ERROR_VMCOMPUTE_UNSUPPORTED_PROTOCOL_VERSION = unchecked((int)0xC037010C);

        /// <summary>
        /// The JSON document is invalid.
        /// </summary>
        public const int ERROR_VMCOMPUTE_INVALID_JSON = unchecked((int)0xC037010D);

        /// <summary>
        /// A Compute System with the specified identifier does not exist.
        /// </summary>
        public const int ERROR_VMCOMPUTE_SYSTEM_NOT_FOUND = unchecked((int)0xC037010E);

        /// <summary>
        /// A Compute System with the specified identifier already exists.
        /// </summary>
        public const int ERROR_VMCOMPUTE_SYSTEM_ALREADY_EXISTS = unchecked((int)0xC037010F);

        /// <summary>
        /// The Compute System with the specified identifier did already stop.
        /// </summary>
        public const int ERROR_VMCOMPUTE_SYSTEM_ALREADY_STOPPED = unchecked((int)0xC0370110);

        /// <summary>
        /// A communication protocol error has occurred between the Hyper-V Host and Guest Compute Service.
        /// </summary>
        public const int ERROR_VMCOMPUTE_PROTOCOL_ERROR = unchecked((int)0xC0370111);

        /// <summary>
        /// The container's image contains a layer with an unrecognized format.
        /// </summary>
        public const int ERROR_VMCOMPUTE_INVALID_LAYER = unchecked((int)0xC0370112);

        /// <summary>
        /// To use this container image, you must join the Windows Insider Program. Please see https://go.microsoft.com/fwlink/?linkid=850659 for more information.
        /// </summary>
        public const int ERROR_VMCOMPUTE_WINDOWS_INSIDER_REQUIRED = unchecked((int)0xC0370113);

        //
        // Virtual networking errors (0x0200-0x02ff)
        //
        /// <summary>
        /// A virtual switch with the given name was not found.
        /// </summary>
        public const int ERROR_VNET_VIRTUAL_SWITCH_NAME_NOT_FOUND = unchecked((int)0xC0370200);

        //
        // VID warnings (0x0000 - 0x00ff):
        //
        /// <summary>
        /// A virtual machine is running with its memory allocated across multiple NUMA nodes. This does not indicate a problem unless the performance of your virtual machine is unusually slow. If you are experiencing performance problems, you may need to modify the NUMA configuration.
        /// </summary>
        public const int ERROR_VID_REMOTE_NODE_PARENT_GPA_PAGES_USED = unchecked((int)0x80370001);

        //
        // User-mode Hypervisor API error codes (0x0300-0x03ff)
        //
        /// <summary>
        /// The specified capability does not exist.
        /// </summary>
        public const int WHV_E_UNKNOWN_CAPABILITY = unchecked((int)0x80370300);

        /// <summary>
        /// The specified buffer is too small for the requested data.
        /// </summary>
        public const int WHV_E_INSUFFICIENT_BUFFER = unchecked((int)0x80370301);

        /// <summary>
        /// The specified property does not exist.
        /// </summary>
        public const int WHV_E_UNKNOWN_PROPERTY = unchecked((int)0x80370302);

        /// <summary>
        /// The configuration of the hypervisor on this system is not supported.
        /// </summary>
        public const int WHV_E_UNSUPPORTED_HYPERVISOR_CONFIG = unchecked((int)0x80370303);

        /// <summary>
        /// The configuration of the partition is not valid.
        /// </summary>
        public const int WHV_E_INVALID_PARTITION_CONFIG = unchecked((int)0x80370304);

        /// <summary>
        /// The specified GPA range was not found.
        /// </summary>
        public const int WHV_E_GPA_RANGE_NOT_FOUND = unchecked((int)0x80370305);

        /// <summary>
        /// A virtual processor with the specified index already exists.
        /// </summary>
        public const int WHV_E_VP_ALREADY_EXISTS = unchecked((int)0x80370306);

        /// <summary>
        /// A virtual processor with the specified index does not exist.
        /// </summary>
        public const int WHV_E_VP_DOES_NOT_EXIST = unchecked((int)0x80370307);

        /// <summary>
        /// The virtual processor is not in the correct state to perform the requested operation.
        /// </summary>
        public const int WHV_E_INVALID_VP_STATE = unchecked((int)0x80370308);

        /// <summary>
        /// A virtual processor register with the specified name does not exist.
        /// </summary>
        public const int WHV_E_INVALID_VP_REGISTER_NAME = unchecked((int)0x80370309);


        //
        // Volume manager error codes mapped from status codes
        //

        //
        // WARNINGS
        //
        /// <summary>
        /// The regeneration operation was not able to copy all data from the active plexes due to bad sectors.
        /// </summary>
        public const int ERROR_VOLMGR_INCOMPLETE_REGENERATION = unchecked((int)0x80380001);

        /// <summary>
        /// One or more disks were not fully migrated to the target pack. They may or may not require reimport after fixing the hardware problems.
        /// </summary>
        public const int ERROR_VOLMGR_INCOMPLETE_DISK_MIGRATION = unchecked((int)0x80380002);

        //
        // ERRORS
        //
        /// <summary>
        /// The configuration database is full.
        /// </summary>
        public const int ERROR_VOLMGR_DATABASE_FULL = unchecked((int)0xC0380001);

        /// <summary>
        /// The configuration data on the disk is corrupted.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_CONFIGURATION_CORRUPTED = unchecked((int)0xC0380002);

        /// <summary>
        /// The configuration on the disk is not insync with the in-memory configuration.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_CONFIGURATION_NOT_IN_SYNC = unchecked((int)0xC0380003);

        /// <summary>
        /// A majority of disks failed to be updated with the new configuration.
        /// </summary>
        public const int ERROR_VOLMGR_PACK_CONFIG_UPDATE_FAILED = unchecked((int)0xC0380004);

        /// <summary>
        /// The disk contains non-simple volumes.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_CONTAINS_NON_SIMPLE_VOLUME = unchecked((int)0xC0380005);

        /// <summary>
        /// The same disk was specified more than once in the migration list.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_DUPLICATE = unchecked((int)0xC0380006);

        /// <summary>
        /// The disk is already dynamic.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_DYNAMIC = unchecked((int)0xC0380007);

        /// <summary>
        /// The specified disk id is invalid. There are no disks with the specified disk id.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_ID_INVALID = unchecked((int)0xC0380008);

        /// <summary>
        /// The specified disk is an invalid disk. Operation cannot complete on an invalid disk.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_INVALID = unchecked((int)0xC0380009);

        /// <summary>
        /// The specified disk(s) cannot be removed since it is the last remaining voter.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_LAST_VOTER = unchecked((int)0xC038000A);

        /// <summary>
        /// The specified disk has an invalid disk layout.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_LAYOUT_INVALID = unchecked((int)0xC038000B);

        /// <summary>
        /// The disk layout contains non-basic partitions which appear after basic paritions. This is an invalid disk layout.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_LAYOUT_NON_BASIC_BETWEEN_BASIC_PARTITIONS = unchecked((int)0xC038000C);

        /// <summary>
        /// The disk layout contains partitions which are not cylinder aligned.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_LAYOUT_NOT_CYLINDER_ALIGNED = unchecked((int)0xC038000D);

        /// <summary>
        /// The disk layout contains partitions which are samller than the minimum size.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_LAYOUT_PARTITIONS_TOO_SMALL = unchecked((int)0xC038000E);

        /// <summary>
        /// The disk layout contains primary partitions in between logical drives. This is an invalid disk layout.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_LAYOUT_PRIMARY_BETWEEN_LOGICAL_PARTITIONS = unchecked((int)0xC038000F);

        /// <summary>
        /// The disk layout contains more than the maximum number of supported partitions.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_LAYOUT_TOO_MANY_PARTITIONS = unchecked((int)0xC0380010);

        /// <summary>
        /// The specified disk is missing. The operation cannot complete on a missing disk.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_MISSING = unchecked((int)0xC0380011);

        /// <summary>
        /// The specified disk is not empty.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_NOT_EMPTY = unchecked((int)0xC0380012);

        /// <summary>
        /// There is not enough usable space for this operation.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_NOT_ENOUGH_SPACE = unchecked((int)0xC0380013);

        /// <summary>
        /// The force revectoring of bad sectors failed.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_REVECTORING_FAILED = unchecked((int)0xC0380014);

        /// <summary>
        /// The specified disk has an invalid sector size.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_SECTOR_SIZE_INVALID = unchecked((int)0xC0380015);

        /// <summary>
        /// The specified disk set contains volumes which exist on disks outside of the set.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_SET_NOT_CONTAINED = unchecked((int)0xC0380016);

        /// <summary>
        /// A disk in the volume layout provides extents to more than one member of a plex.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_MEMBERS = unchecked((int)0xC0380017);

        /// <summary>
        /// A disk in the volume layout provides extents to more than one plex.
        /// </summary>
        public const int ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_PLEXES = unchecked((int)0xC0380018);

        /// <summary>
        /// Dynamic disks are not supported on this system.
        /// </summary>
        public const int ERROR_VOLMGR_DYNAMIC_DISK_NOT_SUPPORTED = unchecked((int)0xC0380019);

        /// <summary>
        /// The specified extent is already used by other volumes.
        /// </summary>
        public const int ERROR_VOLMGR_EXTENT_ALREADY_USED = unchecked((int)0xC038001A);

        /// <summary>
        /// The specified volume is retained and can only be extended into a contiguous extent. The specified extent to grow the volume is not contiguous with the specified volume.
        /// </summary>
        public const int ERROR_VOLMGR_EXTENT_NOT_CONTIGUOUS = unchecked((int)0xC038001B);

        /// <summary>
        /// The specified volume extent is not within the public region of the disk.
        /// </summary>
        public const int ERROR_VOLMGR_EXTENT_NOT_IN_PUBLIC_REGION = unchecked((int)0xC038001C);

        /// <summary>
        /// The specifed volume extent is not sector aligned.
        /// </summary>
        public const int ERROR_VOLMGR_EXTENT_NOT_SECTOR_ALIGNED = unchecked((int)0xC038001D);

        /// <summary>
        /// The specified parition overlaps an EBR (the first track of an extended partition on a MBR disks).
        /// </summary>
        public const int ERROR_VOLMGR_EXTENT_OVERLAPS_EBR_PARTITION = unchecked((int)0xC038001E);

        /// <summary>
        /// The specified extent lengths cannot be used to construct a volume with specified length.
        /// </summary>
        public const int ERROR_VOLMGR_EXTENT_VOLUME_LENGTHS_DO_NOT_MATCH = unchecked((int)0xC038001F);

        /// <summary>
        /// The system does not support fault tolerant volumes.
        /// </summary>
        public const int ERROR_VOLMGR_FAULT_TOLERANT_NOT_SUPPORTED = unchecked((int)0xC0380020);

        /// <summary>
        /// The specified interleave length is invalid.
        /// </summary>
        public const int ERROR_VOLMGR_INTERLEAVE_LENGTH_INVALID = unchecked((int)0xC0380021);

        /// <summary>
        /// There is already a maximum number of registered users.
        /// </summary>
        public const int ERROR_VOLMGR_MAXIMUM_REGISTERED_USERS = unchecked((int)0xC0380022);

        /// <summary>
        /// The specified member is already in-sync with the other active members. It does not need to be regenerated.
        /// </summary>
        public const int ERROR_VOLMGR_MEMBER_IN_SYNC = unchecked((int)0xC0380023);

        /// <summary>
        /// The same member index was specified more than once.
        /// </summary>
        public const int ERROR_VOLMGR_MEMBER_INDEX_DUPLICATE = unchecked((int)0xC0380024);

        /// <summary>
        /// The specified member index is greater or equal than the number of members in the volume plex.
        /// </summary>
        public const int ERROR_VOLMGR_MEMBER_INDEX_INVALID = unchecked((int)0xC0380025);

        /// <summary>
        /// The specified member is missing. It cannot be regenerated.
        /// </summary>
        public const int ERROR_VOLMGR_MEMBER_MISSING = unchecked((int)0xC0380026);

        /// <summary>
        /// The specified member is not detached. Cannot replace a member which is not detached.
        /// </summary>
        public const int ERROR_VOLMGR_MEMBER_NOT_DETACHED = unchecked((int)0xC0380027);

        /// <summary>
        /// The specified member is already regenerating.
        /// </summary>
        public const int ERROR_VOLMGR_MEMBER_REGENERATING = unchecked((int)0xC0380028);

        /// <summary>
        /// All disks belonging to the pack failed.
        /// </summary>
        public const int ERROR_VOLMGR_ALL_DISKS_FAILED = unchecked((int)0xC0380029);

        /// <summary>
        /// There are currently no registered users for notifications. The task number is irrelevant unless there are registered users.
        /// </summary>
        public const int ERROR_VOLMGR_NO_REGISTERED_USERS = unchecked((int)0xC038002A);

        /// <summary>
        /// The specified notification user does not exist. Failed to unregister user for notifications.
        /// </summary>
        public const int ERROR_VOLMGR_NO_SUCH_USER = unchecked((int)0xC038002B);

        /// <summary>
        /// The notifications have been reset. Notifications for the current user are invalid. Unregister and re-register for notifications.
        /// </summary>
        public const int ERROR_VOLMGR_NOTIFICATION_RESET = unchecked((int)0xC038002C);

        /// <summary>
        /// The specified number of members is invalid.
        /// </summary>
        public const int ERROR_VOLMGR_NUMBER_OF_MEMBERS_INVALID = unchecked((int)0xC038002D);

        /// <summary>
        /// The specified number of plexes is invalid.
        /// </summary>
        public const int ERROR_VOLMGR_NUMBER_OF_PLEXES_INVALID = unchecked((int)0xC038002E);

        /// <summary>
        /// The specified source and target packs are identical.
        /// </summary>
        public const int ERROR_VOLMGR_PACK_DUPLICATE = unchecked((int)0xC038002F);

        /// <summary>
        /// The specified pack id is invalid. There are no packs with the specified pack id.
        /// </summary>
        public const int ERROR_VOLMGR_PACK_ID_INVALID = unchecked((int)0xC0380030);

        /// <summary>
        /// The specified pack is the invalid pack. The operation cannot complete with the invalid pack.
        /// </summary>
        public const int ERROR_VOLMGR_PACK_INVALID = unchecked((int)0xC0380031);

        /// <summary>
        /// The specified pack name is invalid.
        /// </summary>
        public const int ERROR_VOLMGR_PACK_NAME_INVALID = unchecked((int)0xC0380032);

        /// <summary>
        /// The specified pack is offline.
        /// </summary>
        public const int ERROR_VOLMGR_PACK_OFFLINE = unchecked((int)0xC0380033);

        /// <summary>
        /// The specified pack already has a quorum of healthy disks.
        /// </summary>
        public const int ERROR_VOLMGR_PACK_HAS_QUORUM = unchecked((int)0xC0380034);

        /// <summary>
        /// The pack does not have a quorum of healthy disks.
        /// </summary>
        public const int ERROR_VOLMGR_PACK_WITHOUT_QUORUM = unchecked((int)0xC0380035);

        /// <summary>
        /// The specified disk has an unsupported partition style. Only MBR and GPT partition styles are supported.
        /// </summary>
        public const int ERROR_VOLMGR_PARTITION_STYLE_INVALID = unchecked((int)0xC0380036);

        /// <summary>
        /// Failed to update the disk's partition layout.
        /// </summary>
        public const int ERROR_VOLMGR_PARTITION_UPDATE_FAILED = unchecked((int)0xC0380037);

        /// <summary>
        /// The specified plex is already in-sync with the other active plexes. It does not need to be regenerated.
        /// </summary>
        public const int ERROR_VOLMGR_PLEX_IN_SYNC = unchecked((int)0xC0380038);

        /// <summary>
        /// The same plex index was specified more than once.
        /// </summary>
        public const int ERROR_VOLMGR_PLEX_INDEX_DUPLICATE = unchecked((int)0xC0380039);

        /// <summary>
        /// The specified plex index is greater or equal than the number of plexes in the volume.
        /// </summary>
        public const int ERROR_VOLMGR_PLEX_INDEX_INVALID = unchecked((int)0xC038003A);

        /// <summary>
        /// The specified plex is the last active plex in the volume. The plex cannot be removed or else the volume will go offline.
        /// </summary>
        public const int ERROR_VOLMGR_PLEX_LAST_ACTIVE = unchecked((int)0xC038003B);

        /// <summary>
        /// The specified plex is missing.
        /// </summary>
        public const int ERROR_VOLMGR_PLEX_MISSING = unchecked((int)0xC038003C);

        /// <summary>
        /// The specified plex is currently regenerating.
        /// </summary>
        public const int ERROR_VOLMGR_PLEX_REGENERATING = unchecked((int)0xC038003D);

        /// <summary>
        /// The specified plex type is invalid.
        /// </summary>
        public const int ERROR_VOLMGR_PLEX_TYPE_INVALID = unchecked((int)0xC038003E);

        /// <summary>
        /// The operation is only supported on RAID-5 plexes.
        /// </summary>
        public const int ERROR_VOLMGR_PLEX_NOT_RAID5 = unchecked((int)0xC038003F);

        /// <summary>
        /// The operation is only supported on simple plexes.
        /// </summary>
        public const int ERROR_VOLMGR_PLEX_NOT_SIMPLE = unchecked((int)0xC0380040);

        /// <summary>
        /// The Size fields in the VM_VOLUME_LAYOUT input structure are incorrectly set.
        /// </summary>
        public const int ERROR_VOLMGR_STRUCTURE_SIZE_INVALID = unchecked((int)0xC0380041);

        /// <summary>
        /// There is already a pending request for notifications. Wait for the existing request to return before requesting for more notifications.
        /// </summary>
        public const int ERROR_VOLMGR_TOO_MANY_NOTIFICATION_REQUESTS = unchecked((int)0xC0380042);

        /// <summary>
        /// There is currently a transaction in process.
        /// </summary>
        public const int ERROR_VOLMGR_TRANSACTION_IN_PROGRESS = unchecked((int)0xC0380043);

        /// <summary>
        /// An unexpected layout change occurred outside of the volume manager.
        /// </summary>
        public const int ERROR_VOLMGR_UNEXPECTED_DISK_LAYOUT_CHANGE = unchecked((int)0xC0380044);

        /// <summary>
        /// The specified volume contains a missing disk.
        /// </summary>
        public const int ERROR_VOLMGR_VOLUME_CONTAINS_MISSING_DISK = unchecked((int)0xC0380045);

        /// <summary>
        /// The specified volume id is invalid. There are no volumes with the specified volume id.
        /// </summary>
        public const int ERROR_VOLMGR_VOLUME_ID_INVALID = unchecked((int)0xC0380046);

        /// <summary>
        /// The specified volume length is invalid.
        /// </summary>
        public const int ERROR_VOLMGR_VOLUME_LENGTH_INVALID = unchecked((int)0xC0380047);

        /// <summary>
        /// The specified size for the volume is not a multiple of the sector size.
        /// </summary>
        public const int ERROR_VOLMGR_VOLUME_LENGTH_NOT_SECTOR_SIZE_MULTIPLE = unchecked((int)0xC0380048);

        /// <summary>
        /// The operation is only supported on mirrored volumes.
        /// </summary>
        public const int ERROR_VOLMGR_VOLUME_NOT_MIRRORED = unchecked((int)0xC0380049);

        /// <summary>
        /// The specified volume does not have a retain partition.
        /// </summary>
        public const int ERROR_VOLMGR_VOLUME_NOT_RETAINED = unchecked((int)0xC038004A);

        /// <summary>
        /// The specified volume is offline.
        /// </summary>
        public const int ERROR_VOLMGR_VOLUME_OFFLINE = unchecked((int)0xC038004B);

        /// <summary>
        /// The specified volume already has a retain partition.
        /// </summary>
        public const int ERROR_VOLMGR_VOLUME_RETAINED = unchecked((int)0xC038004C);

        /// <summary>
        /// The specified number of extents is invalid.
        /// </summary>
        public const int ERROR_VOLMGR_NUMBER_OF_EXTENTS_INVALID = unchecked((int)0xC038004D);

        /// <summary>
        /// All disks participating to the volume must have the same sector size.
        /// </summary>
        public const int ERROR_VOLMGR_DIFFERENT_SECTOR_SIZE = unchecked((int)0xC038004E);

        /// <summary>
        /// The boot disk experienced failures.
        /// </summary>
        public const int ERROR_VOLMGR_BAD_BOOT_DISK = unchecked((int)0xC038004F);

        /// <summary>
        /// The configuration of the pack is offline.
        /// </summary>
        public const int ERROR_VOLMGR_PACK_CONFIG_OFFLINE = unchecked((int)0xC0380050);

        /// <summary>
        /// The configuration of the pack is online.
        /// </summary>
        public const int ERROR_VOLMGR_PACK_CONFIG_ONLINE = unchecked((int)0xC0380051);

        /// <summary>
        /// The specified pack is not the primary pack.
        /// </summary>
        public const int ERROR_VOLMGR_NOT_PRIMARY_PACK = unchecked((int)0xC0380052);

        /// <summary>
        /// All disks failed to be updated with the new content of the log.
        /// </summary>
        public const int ERROR_VOLMGR_PACK_LOG_UPDATE_FAILED = unchecked((int)0xC0380053);

        /// <summary>
        /// The specified number of disks in a plex is invalid.
        /// </summary>
        public const int ERROR_VOLMGR_NUMBER_OF_DISKS_IN_PLEX_INVALID = unchecked((int)0xC0380054);

        /// <summary>
        /// The specified number of disks in a plex member is invalid.
        /// </summary>
        public const int ERROR_VOLMGR_NUMBER_OF_DISKS_IN_MEMBER_INVALID = unchecked((int)0xC0380055);

        /// <summary>
        /// The operation is not supported on mirrored volumes.
        /// </summary>
        public const int ERROR_VOLMGR_VOLUME_MIRRORED = unchecked((int)0xC0380056);

        /// <summary>
        /// The operation is only supported on simple and spanned plexes.
        /// </summary>
        public const int ERROR_VOLMGR_PLEX_NOT_SIMPLE_SPANNED = unchecked((int)0xC0380057);

        /// <summary>
        /// The pack has no valid log copies.
        /// </summary>
        public const int ERROR_VOLMGR_NO_VALID_LOG_COPIES = unchecked((int)0xC0380058);

        /// <summary>
        /// A primary pack is already present.
        /// </summary>
        public const int ERROR_VOLMGR_PRIMARY_PACK_PRESENT = unchecked((int)0xC0380059);

        /// <summary>
        /// The specified number of disks is invalid.
        /// </summary>
        public const int ERROR_VOLMGR_NUMBER_OF_DISKS_INVALID = unchecked((int)0xC038005A);

        /// <summary>
        /// The system does not support mirrored volumes.
        /// </summary>
        public const int ERROR_VOLMGR_MIRROR_NOT_SUPPORTED = unchecked((int)0xC038005B);

        /// <summary>
        /// The system does not support RAID-5 volumes.
        /// </summary>
        public const int ERROR_VOLMGR_RAID5_NOT_SUPPORTED = unchecked((int)0xC038005C);


        //
        // Boot Code Data (BCD) error codes
        //

        /// <summary>
        /// Some BCD entries were not imported correctly from the BCD store.
        /// </summary>
        public const int ERROR_BCD_NOT_ALL_ENTRIES_IMPORTED = unchecked((int)0x80390001);

        /// <summary>
        /// Entries enumerated have exceeded the allowed threshold.
        /// </summary>
        public const int ERROR_BCD_TOO_MANY_ELEMENTS = unchecked((int)0xC0390002);

        /// <summary>
        /// Some BCD entries were not synchronized correctly with the firmware.
        /// </summary>
        public const int ERROR_BCD_NOT_ALL_ENTRIES_SYNCHRONIZED = unchecked((int)0x80390003);

        //
        // Vhd error codes - These codes are used by the virtual hard diskparser component.
        //
        //
        // Errors:
        //

        /// <summary>
        /// The virtual hard disk is corrupted. The virtual hard disk drive footer is missing.
        /// </summary>
        public const int ERROR_VHD_DRIVE_FOOTER_MISSING = unchecked((int)0xC03A0001);

        /// <summary>
        /// The virtual hard disk is corrupted. The virtual hard disk drive footer checksum does not match the on-disk checksum.
        /// </summary>
        public const int ERROR_VHD_DRIVE_FOOTER_CHECKSUM_MISMATCH = unchecked((int)0xC03A0002);

        /// <summary>
        /// The virtual hard disk is corrupted. The virtual hard disk drive footer in the virtual hard disk is corrupted.
        /// </summary>
        public const int ERROR_VHD_DRIVE_FOOTER_CORRUPT = unchecked((int)0xC03A0003);

        /// <summary>
        /// The system does not recognize the file format of this virtual hard disk.
        /// </summary>
        public const int ERROR_VHD_FORMAT_UNKNOWN = unchecked((int)0xC03A0004);

        /// <summary>
        /// The version does not support this version of the file format.
        /// </summary>
        public const int ERROR_VHD_FORMAT_UNSUPPORTED_VERSION = unchecked((int)0xC03A0005);

        /// <summary>
        /// The virtual hard disk is corrupted. The sparse header checksum does not match the on-disk checksum.
        /// </summary>
        public const int ERROR_VHD_SPARSE_HEADER_CHECKSUM_MISMATCH = unchecked((int)0xC03A0006);

        /// <summary>
        /// The system does not support this version of the virtual hard disk.This version of the sparse header is not supported.
        /// </summary>
        public const int ERROR_VHD_SPARSE_HEADER_UNSUPPORTED_VERSION = unchecked((int)0xC03A0007);

        /// <summary>
        /// The virtual hard disk is corrupted. The sparse header in the virtual hard disk is corrupt.
        /// </summary>
        public const int ERROR_VHD_SPARSE_HEADER_CORRUPT = unchecked((int)0xC03A0008);

        /// <summary>
        /// Failed to write to the virtual hard disk failed because the system failed to allocate a new block in the virtual hard disk.
        /// </summary>
        public const int ERROR_VHD_BLOCK_ALLOCATION_FAILURE = unchecked((int)0xC03A0009);

        /// <summary>
        /// The virtual hard disk is corrupted. The block allocation table in the virtual hard disk is corrupt.
        /// </summary>
        public const int ERROR_VHD_BLOCK_ALLOCATION_TABLE_CORRUPT = unchecked((int)0xC03A000A);

        /// <summary>
        /// The system does not support this version of the virtual hard disk. The block size is invalid.
        /// </summary>
        public const int ERROR_VHD_INVALID_BLOCK_SIZE = unchecked((int)0xC03A000B);

        /// <summary>
        /// The virtual hard disk is corrupted. The block bitmap does not match with the block data present in the virtual hard disk.
        /// </summary>
        public const int ERROR_VHD_BITMAP_MISMATCH = unchecked((int)0xC03A000C);

        /// <summary>
        /// The chain of virtual hard disks is broken. The system cannot locate the parent virtual hard disk for the differencing disk.
        /// </summary>
        public const int ERROR_VHD_PARENT_VHD_NOT_FOUND = unchecked((int)0xC03A000D);

        /// <summary>
        /// The chain of virtual hard disks is corrupted. There is a mismatch in the identifiers of the parent virtual hard disk and differencing disk.
        /// </summary>
        public const int ERROR_VHD_CHILD_PARENT_ID_MISMATCH = unchecked((int)0xC03A000E);

        /// <summary>
        /// The chain of virtual hard disks is corrupted. The time stamp of the parent virtual hard disk does not match the time stamp of the differencing disk.
        /// </summary>
        public const int ERROR_VHD_CHILD_PARENT_TIMESTAMP_MISMATCH = unchecked((int)0xC03A000F);

        /// <summary>
        /// Failed to read the metadata of the virtual hard disk.
        /// </summary>
        public const int ERROR_VHD_METADATA_READ_FAILURE = unchecked((int)0xC03A0010);

        /// <summary>
        /// Failed to write to the metadata of the virtual hard disk.
        /// </summary>
        public const int ERROR_VHD_METADATA_WRITE_FAILURE = unchecked((int)0xC03A0011);

        /// <summary>
        /// The size of the virtual hard disk is not valid.
        /// </summary>
        public const int ERROR_VHD_INVALID_SIZE = unchecked((int)0xC03A0012);

        /// <summary>
        /// The file size of this virtual hard disk is not valid.
        /// </summary>
        public const int ERROR_VHD_INVALID_FILE_SIZE = unchecked((int)0xC03A0013);

        /// <summary>
        /// A virtual disk support provider for the specified file was not found.
        /// </summary>
        public const int ERROR_VIRTDISK_PROVIDER_NOT_FOUND = unchecked((int)0xC03A0014);

        /// <summary>
        /// The specified disk is not a virtual disk.
        /// </summary>
        public const int ERROR_VIRTDISK_NOT_VIRTUAL_DISK = unchecked((int)0xC03A0015);

        /// <summary>
        /// The chain of virtual hard disks is inaccessible. The process has not been granted access rights to the parent virtual hard disk for the differencing disk.
        /// </summary>
        public const int ERROR_VHD_PARENT_VHD_ACCESS_DENIED = unchecked((int)0xC03A0016);

        /// <summary>
        /// The chain of virtual hard disks is corrupted. There is a mismatch in the virtual sizes of the parent virtual hard disk and differencing disk.
        /// </summary>
        public const int ERROR_VHD_CHILD_PARENT_SIZE_MISMATCH = unchecked((int)0xC03A0017);

        /// <summary>
        /// The chain of virtual hard disks is corrupted. A differencing disk is indicated in its own parent chain.
        /// </summary>
        public const int ERROR_VHD_DIFFERENCING_CHAIN_CYCLE_DETECTED = unchecked((int)0xC03A0018);

        /// <summary>
        /// The chain of virtual hard disks is inaccessible. There was an error opening a virtual hard disk further up the chain.
        /// </summary>
        public const int ERROR_VHD_DIFFERENCING_CHAIN_ERROR_IN_PARENT = unchecked((int)0xC03A0019);

        /// <summary>
        /// The requested operation could not be completed due to a virtual disk system limitation.  Virtual hard disk files must be uncompressed and unencrypted and must not be sparse.
        /// </summary>
        public const int ERROR_VIRTUAL_DISK_LIMITATION = unchecked((int)0xC03A001A);

        /// <summary>
        /// The requested operation cannot be performed on a virtual disk of this type.
        /// </summary>
        public const int ERROR_VHD_INVALID_TYPE = unchecked((int)0xC03A001B);

        /// <summary>
        /// The requested operation cannot be performed on the virtual disk in its current state.
        /// </summary>
        public const int ERROR_VHD_INVALID_STATE = unchecked((int)0xC03A001C);

        /// <summary>
        /// The sector size of the physical disk on which the virtual disk resides is not supported.
        /// </summary>
        public const int ERROR_VIRTDISK_UNSUPPORTED_DISK_SECTOR_SIZE = unchecked((int)0xC03A001D);

        /// <summary>
        /// The disk is already owned by a different owner.
        /// </summary>
        public const int ERROR_VIRTDISK_DISK_ALREADY_OWNED = unchecked((int)0xC03A001E);

        /// <summary>
        /// The disk must be offline or read-only.
        /// </summary>
        public const int ERROR_VIRTDISK_DISK_ONLINE_AND_WRITABLE = unchecked((int)0xC03A001F);

        /// <summary>
        /// Change Tracking is not initialized for this virtual disk.
        /// </summary>
        public const int ERROR_CTLOG_TRACKING_NOT_INITIALIZED = unchecked((int)0xC03A0020);

        /// <summary>
        /// Size of change tracking file exceeded the maximum size limit.
        /// </summary>
        public const int ERROR_CTLOG_LOGFILE_SIZE_EXCEEDED_MAXSIZE = unchecked((int)0xC03A0021);

        /// <summary>
        /// VHD file is changed due to compaction, expansion, or offline updates.
        /// </summary>
        public const int ERROR_CTLOG_VHD_CHANGED_OFFLINE = unchecked((int)0xC03A0022);

        /// <summary>
        /// Change Tracking for the virtual disk is not in a valid state to perform this request.  Change tracking could be discontinued or already in the requested state.
        /// </summary>
        public const int ERROR_CTLOG_INVALID_TRACKING_STATE = unchecked((int)0xC03A0023);

        /// <summary>
        /// Change Tracking file for the virtual disk is not in a valid state.
        /// </summary>
        public const int ERROR_CTLOG_INCONSISTENT_TRACKING_FILE = unchecked((int)0xC03A0024);

        /// <summary>
        /// The requested resize operation could not be completed because it might truncate user data residing on the virtual disk.
        /// </summary>
        public const int ERROR_VHD_RESIZE_WOULD_TRUNCATE_DATA = unchecked((int)0xC03A0025);

        /// <summary>
        /// The requested operation could not be completed because the virtual disk's minimum safe size could not be determined.
        /// This may be due to a missing or corrupt partition table.
        /// </summary>
        public const int ERROR_VHD_COULD_NOT_COMPUTE_MINIMUM_VIRTUAL_SIZE = unchecked((int)0xC03A0026);

        /// <summary>
        /// The requested operation could not be completed because the virtual disk's size cannot be safely reduced further.
        /// </summary>
        public const int ERROR_VHD_ALREADY_AT_OR_BELOW_MINIMUM_VIRTUAL_SIZE = unchecked((int)0xC03A0027);

        /// <summary>
        /// There is not enough space in the virtual disk file for the provided metadata item.
        /// </summary>
        public const int ERROR_VHD_METADATA_FULL = unchecked((int)0xC03A0028);

        /// <summary>
        /// The specified change tracking identifier is not valid.
        /// </summary>
        public const int ERROR_VHD_INVALID_CHANGE_TRACKING_ID = unchecked((int)0xC03A0029);

        /// <summary>
        /// Change tracking is disabled for the specified virtual hard disk, so no change tracking information is available.
        /// </summary>
        public const int ERROR_VHD_CHANGE_TRACKING_DISABLED = unchecked((int)0xC03A002A);

        /// <summary>
        /// There is no change tracking data available associated with the specified change tracking identifier.
        /// </summary>
        public const int ERROR_VHD_MISSING_CHANGE_TRACKING_INFORMATION = unchecked((int)0xC03A0030);

        //
        // Warnings:
        //
        /// <summary>
        /// The virtualization storage subsystem has generated an error.
        /// </summary>
        public const int ERROR_QUERY_STORAGE_ERROR = unchecked((int)0x803A0001);

        //
        // =======================================================
        // Host Network Service (HNS) Error Messages
        // =======================================================
        //
        /// <summary>
        /// The network was not found.
        /// </summary>
        public const int HNS_NETWORK_NOT_FOUND = unchecked((int)0xC03B0001);

        /// <summary>
        /// The endpoint was not found.
        /// </summary>
        public const int HNS_ENDPOINT_NOT_FOUND = unchecked((int)0xC03B0002);

        /// <summary>
        /// The network's underlying layer was not found.
        /// </summary>
        public const int HNS_LAYER_NOT_FOUND = unchecked((int)0xC03B0003);

        /// <summary>
        /// The virtual switch was not found.
        /// </summary>
        public const int HNS_SWITCH_NOT_FOUND = unchecked((int)0xC03B0004);

        /// <summary>
        /// The network does not have a subnet for this endpoint.
        /// </summary>
        public const int HNS_SUBNET_NOT_FOUND = unchecked((int)0xC03B0005);

        /// <summary>
        /// An adapter was not found.
        /// </summary>
        public const int HNS_ADAPTER_NOT_FOUND = unchecked((int)0xC03B0006);

        /// <summary>
        /// The switch-port was not found.
        /// </summary>
        public const int HNS_PORT_NOT_FOUND = unchecked((int)0xC03B0007);

        /// <summary>
        /// An expected policy was not found.
        /// </summary>
        public const int HNS_POLICY_NOT_FOUND = unchecked((int)0xC03B0008);

        /// <summary>
        /// A required VFP port setting was not found.
        /// </summary>
        public const int HNS_VFP_PORTSETTING_NOT_FOUND = unchecked((int)0xC03B0009);

        /// <summary>
        /// The provided network configuration is invalid or missing parameters.
        /// </summary>
        public const int HNS_INVALID_NETWORK = unchecked((int)0xC03B000A);

        /// <summary>
        /// Invalid network type.
        /// </summary>
        public const int HNS_INVALID_NETWORK_TYPE = unchecked((int)0xC03B000B);

        /// <summary>
        /// The provided endpoint configuration is invalid or missing parameters.
        /// </summary>
        public const int HNS_INVALID_ENDPOINT = unchecked((int)0xC03B000C);

        /// <summary>
        /// The provided policy configuration is invalid or missing parameters.
        /// </summary>
        public const int HNS_INVALID_POLICY = unchecked((int)0xC03B000D);

        /// <summary>
        /// Invalid policy type.
        /// </summary>
        public const int HNS_INVALID_POLICY_TYPE = unchecked((int)0xC03B000E);

        /// <summary>
        /// This requested operation is invalid for a remote endpoint.
        /// </summary>
        public const int HNS_INVALID_REMOTE_ENDPOINT_OPERATION = unchecked((int)0xC03B000F);

        /// <summary>
        /// A network with this name already exists.
        /// </summary>
        public const int HNS_NETWORK_ALREADY_EXISTS = unchecked((int)0xC03B0010);

        /// <summary>
        /// A network with this name already exists.
        /// </summary>
        public const int HNS_LAYER_ALREADY_EXISTS = unchecked((int)0xC03B0011);

        /// <summary>
        /// Policy information already exists on this object.
        /// </summary>
        public const int HNS_POLICY_ALREADY_EXISTS = unchecked((int)0xC03B0012);

        /// <summary>
        /// The specified port already exists.
        /// </summary>
        public const int HNS_PORT_ALREADY_EXISTS = unchecked((int)0xC03B0013);

        /// <summary>
        /// This endpoint is already attached to the switch.
        /// </summary>
        public const int HNS_ENDPOINT_ALREADY_ATTACHED = unchecked((int)0xC03B0014);

        /// <summary>
        /// The specified request is unsupported.
        /// </summary>
        public const int HNS_REQUEST_UNSUPPORTED = unchecked((int)0xC03B0015);

        /// <summary>
        /// Port mapping is not supported on the given network.
        /// </summary>
        public const int HNS_MAPPING_NOT_SUPPORTED = unchecked((int)0xC03B0016);

        /// <summary>
        /// There was an operation attempted on a degraded object.
        /// </summary>
        public const int HNS_DEGRADED_OPERATION = unchecked((int)0xC03B0017);

        /// <summary>
        /// Cannot modify a switch shared by multiple networks.
        /// </summary>
        public const int HNS_SHARED_SWITCH_MODIFICATION = unchecked((int)0xC03B0018);

        /// <summary>
        /// Failed to interpret a parameter as a GUID.
        /// </summary>
        public const int HNS_GUID_CONVERSION_FAILURE = unchecked((int)0xC03B0019);

        /// <summary>
        /// Failed to process registry key.
        /// </summary>
        public const int HNS_REGKEY_FAILURE = unchecked((int)0xC03B001A);

        /// <summary>
        /// Invalid JSON document string.
        /// </summary>
        public const int HNS_INVALID_JSON = unchecked((int)0xC03B001B);

        /// <summary>
        /// The reference is invalid in the JSON document.
        /// </summary>
        public const int HNS_INVALID_JSON_REFERENCE = unchecked((int)0xC03B001C);

        /// <summary>
        /// Endpoint sharing is disabled.
        /// </summary>
        public const int HNS_ENDPOINT_SHARING_DISABLED = unchecked((int)0xC03B001D);

        /// <summary>
        /// IP address is either invalid or not part of any configured subnet(s).
        /// </summary>
        public const int HNS_INVALID_IP = unchecked((int)0xC03B001E);

        /// <summary>
        /// The specified switch extension does not exist on this switch.
        /// </summary>
        public const int HNS_SWITCH_EXTENSION_NOT_FOUND = unchecked((int)0xC03B001F);

        //
        // =======================================================
        // Facility Scripted Diagnostics (SDIAG) Error Messages
        // =======================================================
        //
        /// <summary>
        /// The operation was cancelled.
        /// </summary>
        public const int SDIAG_E_CANCELLED = unchecked((int)0x803C0100);

        /// <summary>
        /// An error occurred when running a PowerShell script.
        /// </summary>
        public const int SDIAG_E_SCRIPT = unchecked((int)0x803C0101);

        /// <summary>
        /// An error occurred when interacting with PowerShell runtime.
        /// </summary>
        public const int SDIAG_E_POWERSHELL = unchecked((int)0x803C0102);

        /// <summary>
        /// An error occurred in the Scripted Diagnostic Managed Host.
        /// </summary>
        public const int SDIAG_E_MANAGEDHOST = unchecked((int)0x803C0103);

        /// <summary>
        /// The troubleshooting pack does not contain a required verifier to complete the verification.
        /// </summary>
        public const int SDIAG_E_NOVERIFIER = unchecked((int)0x803C0104);

        /// <summary>
        /// The troubleshooting pack cannot be executed on this system.
        /// </summary>
        public const int SDIAG_S_CANNOTRUN = 0x003C0105;

        /// <summary>
        /// Scripted diagnostics is disabled by group policy.
        /// </summary>
        public const int SDIAG_E_DISABLED = unchecked((int)0x803C0106);

        /// <summary>
        /// Trust validation of the troubleshooting pack failed.
        /// </summary>
        public const int SDIAG_E_TRUST = unchecked((int)0x803C0107);

        /// <summary>
        /// The troubleshooting pack cannot be executed on this system.
        /// </summary>
        public const int SDIAG_E_CANNOTRUN = unchecked((int)0x803C0108);

        /// <summary>
        /// This version of the troubleshooting pack is not supported.
        /// </summary>
        public const int SDIAG_E_VERSION = unchecked((int)0x803C0109);

        /// <summary>
        /// A required resource cannot be loaded.
        /// </summary>
        public const int SDIAG_E_RESOURCE = unchecked((int)0x803C010A);

        /// <summary>
        /// The troubleshooting pack reported information for a root cause without adding the root cause.
        /// </summary>
        public const int SDIAG_E_ROOTCAUSE = unchecked((int)0x803C010B);

        //
        // =======================================================
        // Facility Windows Push Notifications (WPN) Error Messages
        // =======================================================
        //
        /// <summary>
        /// The notification channel has already been closed.
        /// </summary>
        public const int WPN_E_CHANNEL_CLOSED = unchecked((int)0x803E0100);

        /// <summary>
        /// The notification channel request did not complete successfully.
        /// </summary>
        public const int WPN_E_CHANNEL_REQUEST_NOT_COMPLETE = unchecked((int)0x803E0101);

        /// <summary>
        /// The application identifier provided is invalid.
        /// </summary>
        public const int WPN_E_INVALID_APP = unchecked((int)0x803E0102);

        /// <summary>
        /// A notification channel request for the provided application identifier is in progress.
        /// </summary>
        public const int WPN_E_OUTSTANDING_CHANNEL_REQUEST = unchecked((int)0x803E0103);

        /// <summary>
        /// The channel identifier is already tied to another application endpoint.
        /// </summary>
        public const int WPN_E_DUPLICATE_CHANNEL = unchecked((int)0x803E0104);

        /// <summary>
        /// The notification platform is unavailable.
        /// </summary>
        public const int WPN_E_PLATFORM_UNAVAILABLE = unchecked((int)0x803E0105);

        /// <summary>
        /// The notification has already been posted.
        /// </summary>
        public const int WPN_E_NOTIFICATION_POSTED = unchecked((int)0x803E0106);

        /// <summary>
        /// The notification has already been hidden.
        /// </summary>
        public const int WPN_E_NOTIFICATION_HIDDEN = unchecked((int)0x803E0107);

        /// <summary>
        /// The notification cannot be hidden until it has been shown.
        /// </summary>
        public const int WPN_E_NOTIFICATION_NOT_POSTED = unchecked((int)0x803E0108);

        /// <summary>
        /// Cloud notifications have been turned off.
        /// </summary>
        public const int WPN_E_CLOUD_DISABLED = unchecked((int)0x803E0109);

        /// <summary>
        /// The application does not have the cloud notification capability.
        /// </summary>
        public const int WPN_E_CLOUD_INCAPABLE = unchecked((int)0x803E0110);

        /// <summary>
        /// The notification platform is unable to retrieve the authentication credentials required to connect to the cloud notification service.
        /// </summary>
        public const int WPN_E_CLOUD_AUTH_UNAVAILABLE = unchecked((int)0x803E011A);

        /// <summary>
        /// The notification platform is unable to connect to the cloud notification service.
        /// </summary>
        public const int WPN_E_CLOUD_SERVICE_UNAVAILABLE = unchecked((int)0x803E011B);

        /// <summary>
        /// The notification platform is unable to initialize a callback for lock screen updates.
        /// </summary>
        public const int WPN_E_FAILED_LOCK_SCREEN_UPDATE_INTIALIZATION = unchecked((int)0x803E011C);

        /// <summary>
        /// Settings prevent the notification from being delivered.
        /// </summary>
        public const int WPN_E_NOTIFICATION_DISABLED = unchecked((int)0x803E0111);

        /// <summary>
        /// Application capabilities prevent the notification from being delivered.
        /// </summary>
        public const int WPN_E_NOTIFICATION_INCAPABLE = unchecked((int)0x803E0112);

        /// <summary>
        /// The application does not have the internet access capability.
        /// </summary>
        public const int WPN_E_INTERNET_INCAPABLE = unchecked((int)0x803E0113);

        /// <summary>
        /// Settings prevent the notification type from being delivered.
        /// </summary>
        public const int WPN_E_NOTIFICATION_TYPE_DISABLED = unchecked((int)0x803E0114);

        /// <summary>
        /// The size of the notification content is too large.
        /// </summary>
        public const int WPN_E_NOTIFICATION_SIZE = unchecked((int)0x803E0115);

        /// <summary>
        /// The size of the notification tag is too large.
        /// </summary>
        public const int WPN_E_TAG_SIZE = unchecked((int)0x803E0116);

        /// <summary>
        /// The notification platform doesn't have appropriate privilege on resources.
        /// </summary>
        public const int WPN_E_ACCESS_DENIED = unchecked((int)0x803E0117);

        /// <summary>
        /// The notification platform found application is already registered.
        /// </summary>
        public const int WPN_E_DUPLICATE_REGISTRATION = unchecked((int)0x803E0118);

        /// <summary>
        /// The application background task does not have the push notification capability.
        /// </summary>
        public const int WPN_E_PUSH_NOTIFICATION_INCAPABLE = unchecked((int)0x803E0119);

        /// <summary>
        /// The size of the developer id for scheduled notification is too large.
        /// </summary>
        public const int WPN_E_DEV_ID_SIZE = unchecked((int)0x803E0120);

        /// <summary>
        /// The notification tag is not alphanumeric.
        /// </summary>
        public const int WPN_E_TAG_ALPHANUMERIC = unchecked((int)0x803E012A);

        /// <summary>
        /// The notification platform has received invalid HTTP status code other than 2xx for polling.
        /// </summary>
        public const int WPN_E_INVALID_HTTP_STATUS_CODE = unchecked((int)0x803E012B);

        /// <summary>
        /// The notification platform has run out of presentation layer sessions.
        /// </summary>
        public const int WPN_E_OUT_OF_SESSION = unchecked((int)0x803E0200);

        /// <summary>
        /// The notification platform rejects image download request due to system in power save mode.
        /// </summary>
        public const int WPN_E_POWER_SAVE = unchecked((int)0x803E0201);

        /// <summary>
        /// The notification platform doesn't have the requested image in its cache.
        /// </summary>
        public const int WPN_E_IMAGE_NOT_FOUND_IN_CACHE = unchecked((int)0x803E0202);

        /// <summary>
        /// The notification platform cannot complete all of requested image.
        /// </summary>
        public const int WPN_E_ALL_URL_NOT_COMPLETED = unchecked((int)0x803E0203);

        /// <summary>
        /// A cloud image downloaded from the notification platform is invalid.
        /// </summary>
        public const int WPN_E_INVALID_CLOUD_IMAGE = unchecked((int)0x803E0204);

        /// <summary>
        /// Notification Id provided as filter is matched with what the notification platform maintains.
        /// </summary>
        public const int WPN_E_NOTIFICATION_ID_MATCHED = unchecked((int)0x803E0205);

        /// <summary>
        /// Notification callback interface is already registered.
        /// </summary>
        public const int WPN_E_CALLBACK_ALREADY_REGISTERED = unchecked((int)0x803E0206);

        /// <summary>
        /// Toast Notification was dropped without being displayed to the user.
        /// </summary>
        public const int WPN_E_TOAST_NOTIFICATION_DROPPED = unchecked((int)0x803E0207);

        /// <summary>
        /// The notification platform does not have the proper privileges to complete the request.
        /// </summary>
        public const int WPN_E_STORAGE_LOCKED = unchecked((int)0x803E0208);

        /// <summary>
        /// The size of the notification group is too large.
        /// </summary>
        public const int WPN_E_GROUP_SIZE = unchecked((int)0x803E0209);

        /// <summary>
        /// The notification group is not alphanumeric.
        /// </summary>
        public const int WPN_E_GROUP_ALPHANUMERIC = unchecked((int)0x803E020A);

        /// <summary>
        /// Cloud notifications have been disabled for the application due to a policy setting.
        /// </summary>
        public const int WPN_E_CLOUD_DISABLED_FOR_APP = unchecked((int)0x803E020B);


        //
        // MBN error codes
        //

        /// <summary>
        /// Context is not activated.
        /// </summary>
        public const int E_MBN_CONTEXT_NOT_ACTIVATED = unchecked((int)0x80548201);

        /// <summary>
        /// Bad SIM is inserted.
        /// </summary>
        public const int E_MBN_BAD_SIM = unchecked((int)0x80548202);

        /// <summary>
        /// Requested data class is not avaialable.
        /// </summary>
        public const int E_MBN_DATA_CLASS_NOT_AVAILABLE = unchecked((int)0x80548203);

        /// <summary>
        /// Access point name (APN) or Access string is incorrect.
        /// </summary>
        public const int E_MBN_INVALID_ACCESS_STRING = unchecked((int)0x80548204);

        /// <summary>
        /// Max activated contexts have reached.
        /// </summary>
        public const int E_MBN_MAX_ACTIVATED_CONTEXTS = unchecked((int)0x80548205);

        /// <summary>
        /// Device is in packet detach state.
        /// </summary>
        public const int E_MBN_PACKET_SVC_DETACHED = unchecked((int)0x80548206);

        /// <summary>
        /// Provider is not visible.
        /// </summary>
        public const int E_MBN_PROVIDER_NOT_VISIBLE = unchecked((int)0x80548207);

        /// <summary>
        /// Radio is powered off.
        /// </summary>
        public const int E_MBN_RADIO_POWER_OFF = unchecked((int)0x80548208);

        /// <summary>
        /// MBN subscription is not activated.
        /// </summary>
        public const int E_MBN_SERVICE_NOT_ACTIVATED = unchecked((int)0x80548209);

        /// <summary>
        /// SIM is not inserted.
        /// </summary>
        public const int E_MBN_SIM_NOT_INSERTED = unchecked((int)0x8054820A);

        /// <summary>
        /// Voice call in progress.
        /// </summary>
        public const int E_MBN_VOICE_CALL_IN_PROGRESS = unchecked((int)0x8054820B);

        /// <summary>
        /// Visible provider cache is invalid.
        /// </summary>
        public const int E_MBN_INVALID_CACHE = unchecked((int)0x8054820C);

        /// <summary>
        /// Device is not registered.
        /// </summary>
        public const int E_MBN_NOT_REGISTERED = unchecked((int)0x8054820D);

        /// <summary>
        /// Providers not found.
        /// </summary>
        public const int E_MBN_PROVIDERS_NOT_FOUND = unchecked((int)0x8054820E);

        /// <summary>
        /// Pin is not supported.
        /// </summary>
        public const int E_MBN_PIN_NOT_SUPPORTED = unchecked((int)0x8054820F);

        /// <summary>
        /// Pin is required.
        /// </summary>
        public const int E_MBN_PIN_REQUIRED = unchecked((int)0x80548210);

        /// <summary>
        /// PIN is disabled.
        /// </summary>
        public const int E_MBN_PIN_DISABLED = unchecked((int)0x80548211);

        /// <summary>
        /// Generic Failure.
        /// </summary>
        public const int E_MBN_FAILURE = unchecked((int)0x80548212);

        // Profile related error messages
        /// <summary>
        /// Profile is invalid.
        /// </summary>
        public const int E_MBN_INVALID_PROFILE = unchecked((int)0x80548218);

        /// <summary>
        /// Default profile exist.
        /// </summary>
        public const int E_MBN_DEFAULT_PROFILE_EXIST = unchecked((int)0x80548219);

        // SMS related error messages
        /// <summary>
        /// SMS encoding is not supported.
        /// </summary>
        public const int E_MBN_SMS_ENCODING_NOT_SUPPORTED = unchecked((int)0x80548220);

        /// <summary>
        /// SMS filter is not supported.
        /// </summary>
        public const int E_MBN_SMS_FILTER_NOT_SUPPORTED = unchecked((int)0x80548221);

        /// <summary>
        /// Invalid SMS memory index is used.
        /// </summary>
        public const int E_MBN_SMS_INVALID_MEMORY_INDEX = unchecked((int)0x80548222);

        /// <summary>
        /// SMS language is not supported.
        /// </summary>
        public const int E_MBN_SMS_LANG_NOT_SUPPORTED = unchecked((int)0x80548223);

        /// <summary>
        /// SMS memory failure occurred.
        /// </summary>
        public const int E_MBN_SMS_MEMORY_FAILURE = unchecked((int)0x80548224);

        /// <summary>
        /// SMS network timeout happened.
        /// </summary>
        public const int E_MBN_SMS_NETWORK_TIMEOUT = unchecked((int)0x80548225);

        /// <summary>
        /// Unknown SMSC address is used.
        /// </summary>
        public const int E_MBN_SMS_UNKNOWN_SMSC_ADDRESS = unchecked((int)0x80548226);

        /// <summary>
        /// SMS format is not supported.
        /// </summary>
        public const int E_MBN_SMS_FORMAT_NOT_SUPPORTED = unchecked((int)0x80548227);

        /// <summary>
        /// SMS operation is not allowed.
        /// </summary>
        public const int E_MBN_SMS_OPERATION_NOT_ALLOWED = unchecked((int)0x80548228);

        /// <summary>
        /// Device SMS memory is full.
        /// </summary>
        public const int E_MBN_SMS_MEMORY_FULL = unchecked((int)0x80548229);


        //
        // P2P error codes
        //

        /// <summary>
        /// The IPv6 protocol is not installed.
        /// </summary>
        public const int PEER_E_IPV6_NOT_INSTALLED = unchecked((int)0x80630001);

        /// <summary>
        /// The compoment has not been initialized.
        /// </summary>
        public const int PEER_E_NOT_INITIALIZED = unchecked((int)0x80630002);

        /// <summary>
        /// The required service canot be started.
        /// </summary>
        public const int PEER_E_CANNOT_START_SERVICE = unchecked((int)0x80630003);

        /// <summary>
        /// The P2P protocol is not licensed to run on this OS.
        /// </summary>
        public const int PEER_E_NOT_LICENSED = unchecked((int)0x80630004);

        /// <summary>
        /// The graph handle is invalid.
        /// </summary>
        public const int PEER_E_INVALID_GRAPH = unchecked((int)0x80630010);

        /// <summary>
        /// The graph database name has changed.
        /// </summary>
        public const int PEER_E_DBNAME_CHANGED = unchecked((int)0x80630011);

        /// <summary>
        /// A graph with the same ID already exists.
        /// </summary>
        public const int PEER_E_DUPLICATE_GRAPH = unchecked((int)0x80630012);

        /// <summary>
        /// The graph is not ready.
        /// </summary>
        public const int PEER_E_GRAPH_NOT_READY = unchecked((int)0x80630013);

        /// <summary>
        /// The graph is shutting down.
        /// </summary>
        public const int PEER_E_GRAPH_SHUTTING_DOWN = unchecked((int)0x80630014);

        /// <summary>
        /// The graph is still in use.
        /// </summary>
        public const int PEER_E_GRAPH_IN_USE = unchecked((int)0x80630015);

        /// <summary>
        /// The graph database is corrupt.
        /// </summary>
        public const int PEER_E_INVALID_DATABASE = unchecked((int)0x80630016);

        /// <summary>
        /// Too many attributes have been used.
        /// </summary>
        public const int PEER_E_TOO_MANY_ATTRIBUTES = unchecked((int)0x80630017);

        /// <summary>
        /// The connection can not be found.
        /// </summary>
        public const int PEER_E_CONNECTION_NOT_FOUND = unchecked((int)0x80630103);

        /// <summary>
        /// The peer attempted to connect to itself.
        /// </summary>
        public const int PEER_E_CONNECT_SELF = unchecked((int)0x80630106);

        /// <summary>
        /// The peer is already listening for connections.
        /// </summary>
        public const int PEER_E_ALREADY_LISTENING = unchecked((int)0x80630107);

        /// <summary>
        /// The node was not found.
        /// </summary>
        public const int PEER_E_NODE_NOT_FOUND = unchecked((int)0x80630108);

        /// <summary>
        /// The Connection attempt failed.
        /// </summary>
        public const int PEER_E_CONNECTION_FAILED = unchecked((int)0x80630109);

        /// <summary>
        /// The peer connection could not be authenticated.
        /// </summary>
        public const int PEER_E_CONNECTION_NOT_AUTHENTICATED = unchecked((int)0x8063010A);

        /// <summary>
        /// The connection was refused.
        /// </summary>
        public const int PEER_E_CONNECTION_REFUSED = unchecked((int)0x8063010B);

        /// <summary>
        /// The peer name classifier is too long.
        /// </summary>
        public const int PEER_E_CLASSIFIER_TOO_LONG = unchecked((int)0x80630201);

        /// <summary>
        /// The maximum number of identities have been created.
        /// </summary>
        public const int PEER_E_TOO_MANY_IDENTITIES = unchecked((int)0x80630202);

        /// <summary>
        /// Unable to access a key.
        /// </summary>
        public const int PEER_E_NO_KEY_ACCESS = unchecked((int)0x80630203);

        /// <summary>
        /// The group already exists.
        /// </summary>
        public const int PEER_E_GROUPS_EXIST = unchecked((int)0x80630204);

        // record error codes
        /// <summary>
        /// The requested record could not be found.
        /// </summary>
        public const int PEER_E_RECORD_NOT_FOUND = unchecked((int)0x80630301);

        /// <summary>
        /// Access to the database was denied.
        /// </summary>
        public const int PEER_E_DATABASE_ACCESSDENIED = unchecked((int)0x80630302);

        /// <summary>
        /// The Database could not be initialized.
        /// </summary>
        public const int PEER_E_DBINITIALIZATION_FAILED = unchecked((int)0x80630303);

        /// <summary>
        /// The record is too big.
        /// </summary>
        public const int PEER_E_MAX_RECORD_SIZE_EXCEEDED = unchecked((int)0x80630304);

        /// <summary>
        /// The database already exists.
        /// </summary>
        public const int PEER_E_DATABASE_ALREADY_PRESENT = unchecked((int)0x80630305);

        /// <summary>
        /// The database could not be found.
        /// </summary>
        public const int PEER_E_DATABASE_NOT_PRESENT = unchecked((int)0x80630306);

        /// <summary>
        /// The identity could not be found.
        /// </summary>
        public const int PEER_E_IDENTITY_NOT_FOUND = unchecked((int)0x80630401);

        // eventing error
        /// <summary>
        /// The event handle could not be found.
        /// </summary>
        public const int PEER_E_EVENT_HANDLE_NOT_FOUND = unchecked((int)0x80630501);

        // searching error
        /// <summary>
        /// Invalid search.
        /// </summary>
        public const int PEER_E_INVALID_SEARCH = unchecked((int)0x80630601);

        /// <summary>
        /// The search atributes are invalid.
        /// </summary>
        public const int PEER_E_INVALID_ATTRIBUTES = unchecked((int)0x80630602);


        // certificate verification error codes
        /// <summary>
        /// The invitiation is not trusted.
        /// </summary>
        public const int PEER_E_INVITATION_NOT_TRUSTED = unchecked((int)0x80630701);

        /// <summary>
        /// The certchain is too long.
        /// </summary>
        public const int PEER_E_CHAIN_TOO_LONG = unchecked((int)0x80630703);

        /// <summary>
        /// The time period is invalid.
        /// </summary>
        public const int PEER_E_INVALID_TIME_PERIOD = unchecked((int)0x80630705);

        /// <summary>
        /// A circular cert chain was detected.
        /// </summary>
        public const int PEER_E_CIRCULAR_CHAIN_DETECTED = unchecked((int)0x80630706);

        /// <summary>
        /// The certstore is corrupted.
        /// </summary>
        public const int PEER_E_CERT_STORE_CORRUPTED = unchecked((int)0x80630801);

        /// <summary>
        /// The specified PNRP cloud deos not exist.
        /// </summary>
        public const int PEER_E_NO_CLOUD = unchecked((int)0x80631001);

        /// <summary>
        /// The cloud name is ambiguous.
        /// </summary>
        public const int PEER_E_CLOUD_NAME_AMBIGUOUS = unchecked((int)0x80631005);

        /// <summary>
        /// The record is invlaid.
        /// </summary>
        public const int PEER_E_INVALID_RECORD = unchecked((int)0x80632010);

        /// <summary>
        /// Not authorized.
        /// </summary>
        public const int PEER_E_NOT_AUTHORIZED = unchecked((int)0x80632020);

        /// <summary>
        /// The password does not meet policy requirements.
        /// </summary>
        public const int PEER_E_PASSWORD_DOES_NOT_MEET_POLICY = unchecked((int)0x80632021);

        /// <summary>
        /// The record validation has been defered.
        /// </summary>
        public const int PEER_E_DEFERRED_VALIDATION = unchecked((int)0x80632030);

        /// <summary>
        /// The group properies are invalid.
        /// </summary>
        public const int PEER_E_INVALID_GROUP_PROPERTIES = unchecked((int)0x80632040);

        /// <summary>
        /// The peername is invalid.
        /// </summary>
        public const int PEER_E_INVALID_PEER_NAME = unchecked((int)0x80632050);

        /// <summary>
        /// The classifier is invalid.
        /// </summary>
        public const int PEER_E_INVALID_CLASSIFIER = unchecked((int)0x80632060);

        /// <summary>
        /// The friendly name is invalid.
        /// </summary>
        public const int PEER_E_INVALID_FRIENDLY_NAME = unchecked((int)0x80632070);

        /// <summary>
        /// Invalid role property.
        /// </summary>
        public const int PEER_E_INVALID_ROLE_PROPERTY = unchecked((int)0x80632071);

        /// <summary>
        /// Invalid classifer property.
        /// </summary>
        public const int PEER_E_INVALID_CLASSIFIER_PROPERTY = unchecked((int)0x80632072);

        /// <summary>
        /// Invlaid record expiration.
        /// </summary>
        public const int PEER_E_INVALID_RECORD_EXPIRATION = unchecked((int)0x80632080);

        /// <summary>
        /// Invlaid credential info.
        /// </summary>
        public const int PEER_E_INVALID_CREDENTIAL_INFO = unchecked((int)0x80632081);

        /// <summary>
        /// Invalid credential.
        /// </summary>
        public const int PEER_E_INVALID_CREDENTIAL = unchecked((int)0x80632082);

        /// <summary>
        /// Invalid record size.
        /// </summary>
        public const int PEER_E_INVALID_RECORD_SIZE = unchecked((int)0x80632083);

        /// <summary>
        /// Unsupported version.
        /// </summary>
        public const int PEER_E_UNSUPPORTED_VERSION = unchecked((int)0x80632090);

        /// <summary>
        /// The group is not ready.
        /// </summary>
        public const int PEER_E_GROUP_NOT_READY = unchecked((int)0x80632091);

        /// <summary>
        /// The group is still in use.
        /// </summary>
        public const int PEER_E_GROUP_IN_USE = unchecked((int)0x80632092);

        /// <summary>
        /// The group is invalid.
        /// </summary>
        public const int PEER_E_INVALID_GROUP = unchecked((int)0x80632093);

        /// <summary>
        /// No members were found.
        /// </summary>
        public const int PEER_E_NO_MEMBERS_FOUND = unchecked((int)0x80632094);

        /// <summary>
        /// There are no member connections.
        /// </summary>
        public const int PEER_E_NO_MEMBER_CONNECTIONS = unchecked((int)0x80632095);

        /// <summary>
        /// Unable to listen.
        /// </summary>
        public const int PEER_E_UNABLE_TO_LISTEN = unchecked((int)0x80632096);

        /// <summary>
        /// The identity does not exist.
        /// </summary>
        public const int PEER_E_IDENTITY_DELETED = unchecked((int)0x806320A0);

        /// <summary>
        /// The service is not availible.
        /// </summary>
        public const int PEER_E_SERVICE_NOT_AVAILABLE = unchecked((int)0x806320A1);

        // Contacts APIs error code
        /// <summary>
        /// THe contact could not be found.
        /// </summary>
        public const int PEER_E_CONTACT_NOT_FOUND = unchecked((int)0x80636001);

        // Special success codes
        /// <summary>
        /// The graph data was created.
        /// </summary>
        public const int PEER_S_GRAPH_DATA_CREATED = 0x00630001;

        /// <summary>
        /// There is not more event data.
        /// </summary>
        public const int PEER_S_NO_EVENT_DATA = 0x00630002;

        /// <summary>
        /// The graph is already connect.
        /// </summary>
        public const int PEER_S_ALREADY_CONNECTED = 0x00632000;

        /// <summary>
        /// The subscription already exists.
        /// </summary>
        public const int PEER_S_SUBSCRIPTION_EXISTS = 0x00636000;

        /// <summary>
        /// No connectivity.
        /// </summary>
        public const int PEER_S_NO_CONNECTIVITY = 0x00630005;

        /// <summary>
        /// Already a member.
        /// </summary>
        public const int PEER_S_ALREADY_A_MEMBER = 0x00630006;

        // Pnrp helpers errors
        /// <summary>
        /// The peername could not be converted to a DNS pnrp name.
        /// </summary>
        public const int PEER_E_CANNOT_CONVERT_PEER_NAME = unchecked((int)0x80634001);

        /// <summary>
        /// Invalid peer host name.
        /// </summary>
        public const int PEER_E_INVALID_PEER_HOST_NAME = unchecked((int)0x80634002);

        /// <summary>
        /// No more data could be found.
        /// </summary>
        public const int PEER_E_NO_MORE = unchecked((int)0x80634003);

        /// <summary>
        /// The existing peer name is already registered.
        /// </summary>
        public const int PEER_E_PNRP_DUPLICATE_PEER_NAME = unchecked((int)0x80634005);

        // AppInvite APIs error code
        /// <summary>
        /// The app invite request was cancelled by the user.
        /// </summary>
        public const int PEER_E_INVITE_CANCELLED = unchecked((int)0x80637000);

        /// <summary>
        /// No response of the invite was received.
        /// </summary>
        public const int PEER_E_INVITE_RESPONSE_NOT_AVAILABLE = unchecked((int)0x80637001);

        // Serverless presence error codes
        /// <summary>
        /// User is not signed into serverless presence.
        /// </summary>
        public const int PEER_E_NOT_SIGNED_IN = unchecked((int)0x80637003);

        /// <summary>
        /// The user declined the privacy policy prompt.
        /// </summary>
        public const int PEER_E_PRIVACY_DECLINED = unchecked((int)0x80637004);

        /// <summary>
        /// A timeout occurred.
        /// </summary>
        public const int PEER_E_TIMEOUT = unchecked((int)0x80637005);

        /// <summary>
        /// The address is invalid.
        /// </summary>
        public const int PEER_E_INVALID_ADDRESS = unchecked((int)0x80637007);

        /// <summary>
        /// A required firewall exception is disabled.
        /// </summary>
        public const int PEER_E_FW_EXCEPTION_DISABLED = unchecked((int)0x80637008);

        /// <summary>
        /// The service is blocked by a firewall policy.
        /// </summary>
        public const int PEER_E_FW_BLOCKED_BY_POLICY = unchecked((int)0x80637009);

        /// <summary>
        /// Firewall exceptions are disabled.
        /// </summary>
        public const int PEER_E_FW_BLOCKED_BY_SHIELDS_UP = unchecked((int)0x8063700A);

        /// <summary>
        /// The user declined to enable the firewall exceptions.
        /// </summary>
        public const int PEER_E_FW_DECLINED = unchecked((int)0x8063700B);


        //
        // UI error codes
        //

        /// <summary>
        /// The object could not be created.
        /// </summary>
        public const int UI_E_CREATE_FAILED = unchecked((int)0x802A0001);

        /// <summary>
        /// Shutdown was already called on this object or the object that owns it.
        /// </summary>
        public const int UI_E_SHUTDOWN_CALLED = unchecked((int)0x802A0002);

        /// <summary>
        /// This method cannot be called during this type of callback.
        /// </summary>
        public const int UI_E_ILLEGAL_REENTRANCY = unchecked((int)0x802A0003);

        /// <summary>
        /// This object has been sealed, so this change is no longer allowed.
        /// </summary>
        public const int UI_E_OBJECT_SEALED = unchecked((int)0x802A0004);

        /// <summary>
        /// The requested value was never set.
        /// </summary>
        public const int UI_E_VALUE_NOT_SET = unchecked((int)0x802A0005);

        /// <summary>
        /// The requested value cannot be determined.
        /// </summary>
        public const int UI_E_VALUE_NOT_DETERMINED = unchecked((int)0x802A0006);

        /// <summary>
        /// A callback returned an invalid output parameter.
        /// </summary>
        public const int UI_E_INVALID_OUTPUT = unchecked((int)0x802A0007);

        /// <summary>
        /// A callback returned a success code other than S_OK or S_FALSE.
        /// </summary>
        public const int UI_E_BOOLEAN_EXPECTED = unchecked((int)0x802A0008);

        /// <summary>
        /// A parameter that should be owned by this object is owned by a different object.
        /// </summary>
        public const int UI_E_DIFFERENT_OWNER = unchecked((int)0x802A0009);

        /// <summary>
        /// More than one item matched the search criteria.
        /// </summary>
        public const int UI_E_AMBIGUOUS_MATCH = unchecked((int)0x802A000A);

        /// <summary>
        /// A floating-point overflow occurred.
        /// </summary>
        public const int UI_E_FP_OVERFLOW = unchecked((int)0x802A000B);

        /// <summary>
        /// This method can only be called from the thread that created the object.
        /// </summary>
        public const int UI_E_WRONG_THREAD = unchecked((int)0x802A000C);

        /// <summary>
        /// The storyboard is currently in the schedule.
        /// </summary>
        public const int UI_E_STORYBOARD_ACTIVE = unchecked((int)0x802A0101);

        /// <summary>
        /// The storyboard is not playing.
        /// </summary>
        public const int UI_E_STORYBOARD_NOT_PLAYING = unchecked((int)0x802A0102);

        /// <summary>
        /// The start keyframe might occur after the end keyframe.
        /// </summary>
        public const int UI_E_START_KEYFRAME_AFTER_END = unchecked((int)0x802A0103);

        /// <summary>
        /// It might not be possible to determine the end keyframe time when the start keyframe is reached.
        /// </summary>
        public const int UI_E_END_KEYFRAME_NOT_DETERMINED = unchecked((int)0x802A0104);

        /// <summary>
        /// Two repeated portions of a storyboard might overlap.
        /// </summary>
        public const int UI_E_LOOPS_OVERLAP = unchecked((int)0x802A0105);

        /// <summary>
        /// The transition has already been added to a storyboard.
        /// </summary>
        public const int UI_E_TRANSITION_ALREADY_USED = unchecked((int)0x802A0106);

        /// <summary>
        /// The transition has not been added to a storyboard.
        /// </summary>
        public const int UI_E_TRANSITION_NOT_IN_STORYBOARD = unchecked((int)0x802A0107);

        /// <summary>
        /// The transition might eclipse the beginning of another transition in the storyboard.
        /// </summary>
        public const int UI_E_TRANSITION_ECLIPSED = unchecked((int)0x802A0108);

        /// <summary>
        /// The given time is earlier than the time passed to the last update.
        /// </summary>
        public const int UI_E_TIME_BEFORE_LAST_UPDATE = unchecked((int)0x802A0109);

        /// <summary>
        /// This client is already connected to a timer.
        /// </summary>
        public const int UI_E_TIMER_CLIENT_ALREADY_CONNECTED = unchecked((int)0x802A010A);

        /// <summary>
        /// The passed dimension is invalid or does not match the object's dimension.
        /// </summary>
        public const int UI_E_INVALID_DIMENSION = unchecked((int)0x802A010B);

        /// <summary>
        /// The added primitive begins at or beyond the duration of the interpolator.
        /// </summary>
        public const int UI_E_PRIMITIVE_OUT_OF_BOUNDS = unchecked((int)0x802A010C);

        /// <summary>
        /// The operation cannot be completed because the window is being closed.
        /// </summary>
        public const int UI_E_WINDOW_CLOSED = unchecked((int)0x802A0201);


        //
        // Bluetooth Attribute Protocol Warnings
        //

        /// <summary>
        /// The attribute handle given was not valid on this server.
        /// </summary>
        public const int E_BLUETOOTH_ATT_INVALID_HANDLE = unchecked((int)0x80650001);

        /// <summary>
        /// The attribute cannot be read.
        /// </summary>
        public const int E_BLUETOOTH_ATT_READ_NOT_PERMITTED = unchecked((int)0x80650002);

        /// <summary>
        /// The attribute cannot be written.
        /// </summary>
        public const int E_BLUETOOTH_ATT_WRITE_NOT_PERMITTED = unchecked((int)0x80650003);

        /// <summary>
        /// The attribute PDU was invalid.
        /// </summary>
        public const int E_BLUETOOTH_ATT_INVALID_PDU = unchecked((int)0x80650004);

        /// <summary>
        /// The attribute requires authentication before it can be read or written.
        /// </summary>
        public const int E_BLUETOOTH_ATT_INSUFFICIENT_AUTHENTICATION = unchecked((int)0x80650005);

        /// <summary>
        /// Attribute server does not support the request received from the client.
        /// </summary>
        public const int E_BLUETOOTH_ATT_REQUEST_NOT_SUPPORTED = unchecked((int)0x80650006);

        /// <summary>
        /// Offset specified was past the end of the attribute.
        /// </summary>
        public const int E_BLUETOOTH_ATT_INVALID_OFFSET = unchecked((int)0x80650007);

        /// <summary>
        /// The attribute requires authorization before it can be read or written.
        /// </summary>
        public const int E_BLUETOOTH_ATT_INSUFFICIENT_AUTHORIZATION = unchecked((int)0x80650008);

        /// <summary>
        /// Too many prepare writes have been queued.
        /// </summary>
        public const int E_BLUETOOTH_ATT_PREPARE_QUEUE_FULL = unchecked((int)0x80650009);

        /// <summary>
        /// No attribute found within the given attribute handle range.
        /// </summary>
        public const int E_BLUETOOTH_ATT_ATTRIBUTE_NOT_FOUND = unchecked((int)0x8065000A);

        /// <summary>
        /// The attribute cannot be read or written using the Read Blob Request.
        /// </summary>
        public const int E_BLUETOOTH_ATT_ATTRIBUTE_NOT_LONG = unchecked((int)0x8065000B);

        /// <summary>
        /// The Encryption Key Size used for encrypting this link is insufficient.
        /// </summary>
        public const int E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION_KEY_SIZE = unchecked((int)0x8065000C);

        /// <summary>
        /// The attribute value length is invalid for the operation.
        /// </summary>
        public const int E_BLUETOOTH_ATT_INVALID_ATTRIBUTE_VALUE_LENGTH = unchecked((int)0x8065000D);

        /// <summary>
        /// The attribute request that was requested has encountered an error that was unlikely, and therefore could not be completed as requested.
        /// </summary>
        public const int E_BLUETOOTH_ATT_UNLIKELY = unchecked((int)0x8065000E);

        /// <summary>
        /// The attribute requires encryption before it can be read or written.
        /// </summary>
        public const int E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION = unchecked((int)0x8065000F);

        /// <summary>
        /// The attribute type is not a supported grouping attribute as defined by a higher layer specification.
        /// </summary>
        public const int E_BLUETOOTH_ATT_UNSUPPORTED_GROUP_TYPE = unchecked((int)0x80650010);

        /// <summary>
        /// Insufficient Resources to complete the request.
        /// </summary>
        public const int E_BLUETOOTH_ATT_INSUFFICIENT_RESOURCES = unchecked((int)0x80650011);

        /// <summary>
        /// An error that lies in the reserved range has been received.
        /// </summary>
        public const int E_BLUETOOTH_ATT_UNKNOWN_ERROR = unchecked((int)0x80651000);


        //
        // Audio errors
        //

        /// <summary>
        /// PortCls could not find an audio engine node exposed by a miniport driver claiming support for IMiniportAudioEngineNode.
        /// </summary>
        public const int E_AUDIO_ENGINE_NODE_NOT_FOUND = unchecked((int)0x80660001);

        /// <summary>
        /// HD Audio widget encountered an unexpected empty connection list.
        /// </summary>
        public const int E_HDAUDIO_EMPTY_CONNECTION_LIST = unchecked((int)0x80660002);

        /// <summary>
        /// HD Audio widget does not support the connection list parameter.
        /// </summary>
        public const int E_HDAUDIO_CONNECTION_LIST_NOT_SUPPORTED = unchecked((int)0x80660003);

        /// <summary>
        /// No HD Audio subdevices were successfully created.
        /// </summary>
        public const int E_HDAUDIO_NO_LOGICAL_DEVICES_CREATED = unchecked((int)0x80660004);

        /// <summary>
        /// An unexpected NULL pointer was encountered in a linked list.
        /// </summary>
        public const int E_HDAUDIO_NULL_LINKED_LIST_ENTRY = unchecked((int)0x80660005);

        //
        // StateRepository errors
        //
        /// <summary>
        /// Optimistic locking failure. Data cannot be updated if it has changed since it was read.
        /// </summary>
        public const int STATEREPOSITORY_E_CONCURRENCY_LOCKING_FAILURE = unchecked((int)0x80670001);

        /// <summary>
        /// A prepared statement has been stepped at least once but not run to completion or reset. This may result in busy waits.
        /// </summary>
        public const int STATEREPOSITORY_E_STATEMENT_INPROGRESS = unchecked((int)0x80670002);

        /// <summary>
        /// The StateRepository configuration is not valid.
        /// </summary>
        public const int STATEREPOSITORY_E_CONFIGURATION_INVALID = unchecked((int)0x80670003);

        /// <summary>
        /// The StateRepository schema version is not known.
        /// </summary>
        public const int STATEREPOSITORY_E_UNKNOWN_SCHEMA_VERSION = unchecked((int)0x80670004);

        /// <summary>
        /// A StateRepository dictionary is not valid.
        /// </summary>
        public const int STATEREPOSITORY_ERROR_DICTIONARY_CORRUPTED = unchecked((int)0x80670005);

        /// <summary>
        /// The request failed because the StateRepository is actively blocking requests.
        /// </summary>
        public const int STATEREPOSITORY_E_BLOCKED = unchecked((int)0x80670006);

        /// <summary>
        /// The database file is locked. The request will be retried.
        /// </summary>
        public const int STATEREPOSITORY_E_BUSY_RETRY = unchecked((int)0x80670007);

        /// <summary>
        /// The database file is locked because another process is busy recovering the database. The request will be retried.
        /// </summary>
        public const int STATEREPOSITORY_E_BUSY_RECOVERY_RETRY = unchecked((int)0x80670008);

        /// <summary>
        /// A table in the database is locked. The request will be retried.
        /// </summary>
        public const int STATEREPOSITORY_E_LOCKED_RETRY = unchecked((int)0x80670009);

        /// <summary>
        /// The shared cache for the database is locked by another connection. The request will be retried.
        /// </summary>
        public const int STATEREPOSITORY_E_LOCKED_SHAREDCACHE_RETRY = unchecked((int)0x8067000A);

        /// <summary>
        /// A transaction is required to perform the request operation.
        /// </summary>
        public const int STATEREPOSITORY_E_TRANSACTION_REQUIRED = unchecked((int)0x8067000B);

        /// <summary>
        /// The database file is locked. The request has exceeded the allowed threshold.
        /// </summary>
        public const int STATEREPOSITORY_E_BUSY_TIMEOUT_EXCEEDED = unchecked((int)0x8067000C);

        /// <summary>
        /// The database file is locked because another process is busy recovering the database. The request has exceeded the allowed threshold.
        /// </summary>
        public const int STATEREPOSITORY_E_BUSY_RECOVERY_TIMEOUT_EXCEEDED = unchecked((int)0x8067000D);

        /// <summary>
        /// A table in the database is locked. The request has exceeded the allowed threshold.
        /// </summary>
        public const int STATEREPOSITORY_E_LOCKED_TIMEOUT_EXCEEDED = unchecked((int)0x8067000E);

        /// <summary>
        /// The shared cache for the database is locked by another connection. The request has exceeded the allowed threshold.
        /// </summary>
        public const int STATEREPOSITORY_E_LOCKED_SHAREDCACHE_TIMEOUT_EXCEEDED = unchecked((int)0x8067000F);

        /// <summary>
        /// The StateRepository service Stop event is in progress.
        /// </summary>
        public const int STATEREPOSITORY_E_SERVICE_STOP_IN_PROGRESS = unchecked((int)0x80670010);

        /// <summary>
        /// Nested transactions are not supported.
        /// </summary>
        public const int STATEREPOSTORY_E_NESTED_TRANSACTION_NOT_SUPPORTED = unchecked((int)0x80670011);

        /// <summary>
        /// The StateRepository cache is not valid.
        /// </summary>
        public const int STATEREPOSITORY_ERROR_CACHE_CORRUPTED = unchecked((int)0x80670012);

        /// <summary>
        /// The transaction caller id has changed.
        /// </summary>
        public const int STATEREPOSITORY_TRANSACTION_CALLER_ID_CHANGED = 0x00670013;

        //
        // Spaceport errors
        //
        // Success
        /// <summary>
        /// The storage pool was deleted by the driver. The object cache should be updated.
        /// </summary>
        public const int ERROR_SPACES_POOL_WAS_DELETED = 0x00E70001;

        // Errors
        /// <summary>
        /// The specified fault domain type or combination of minimum / maximum fault domain type is not valid.
        /// </summary>
        public const int ERROR_SPACES_FAULT_DOMAIN_TYPE_INVALID = unchecked((int)0x80E70001);

        /// <summary>
        /// A Storage Spaces internal error occurred.
        /// </summary>
        public const int ERROR_SPACES_INTERNAL_ERROR = unchecked((int)0x80E70002);

        /// <summary>
        /// The specified resiliency type is not valid.
        /// </summary>
        public const int ERROR_SPACES_RESILIENCY_TYPE_INVALID = unchecked((int)0x80E70003);

        /// <summary>
        /// The physical disk's sector size is not supported by the storage pool.
        /// </summary>
        public const int ERROR_SPACES_DRIVE_SECTOR_SIZE_INVALID = unchecked((int)0x80E70004);

        /// <summary>
        /// The requested redundancy is outside of the supported range of values.
        /// </summary>
        public const int ERROR_SPACES_DRIVE_REDUNDANCY_INVALID = unchecked((int)0x80E70006);

        /// <summary>
        /// The number of data copies requested is outside of the supported range of values.
        /// </summary>
        public const int ERROR_SPACES_NUMBER_OF_DATA_COPIES_INVALID = unchecked((int)0x80E70007);

        /// <summary>
        /// The value for ParityLayout is outside of the supported range of values.
        /// </summary>
        public const int ERROR_SPACES_PARITY_LAYOUT_INVALID = unchecked((int)0x80E70008);

        /// <summary>
        /// The value for interleave length is outside of the supported range of values or is not a power of 2.
        /// </summary>
        public const int ERROR_SPACES_INTERLEAVE_LENGTH_INVALID = unchecked((int)0x80E70009);

        /// <summary>
        /// The number of columns specified is outside of the supported range of values.
        /// </summary>
        public const int ERROR_SPACES_NUMBER_OF_COLUMNS_INVALID = unchecked((int)0x80E7000A);

        /// <summary>
        /// There were not enough physical disks to complete the requested operation.
        /// </summary>
        public const int ERROR_SPACES_NOT_ENOUGH_DRIVES = unchecked((int)0x80E7000B);

        /// <summary>
        /// Extended error information is available.
        /// </summary>
        public const int ERROR_SPACES_EXTENDED_ERROR = unchecked((int)0x80E7000C);

        /// <summary>
        /// The specified provisioning type is not valid.
        /// </summary>
        public const int ERROR_SPACES_PROVISIONING_TYPE_INVALID = unchecked((int)0x80E7000D);

        /// <summary>
        /// The allocation size is outside of the supported range of values.
        /// </summary>
        public const int ERROR_SPACES_ALLOCATION_SIZE_INVALID = unchecked((int)0x80E7000E);

        /// <summary>
        /// Enclosure awareness is not supported for this virtual disk.
        /// </summary>
        public const int ERROR_SPACES_ENCLOSURE_AWARE_INVALID = unchecked((int)0x80E7000F);

        /// <summary>
        /// The write cache size is outside of the supported range of values.
        /// </summary>
        public const int ERROR_SPACES_WRITE_CACHE_SIZE_INVALID = unchecked((int)0x80E70010);

        /// <summary>
        /// The value for number of groups is outside of the supported range of values.
        /// </summary>
        public const int ERROR_SPACES_NUMBER_OF_GROUPS_INVALID = unchecked((int)0x80E70011);

        /// <summary>
        /// The OperationalState of the physical disk is invalid for this operation.
        /// </summary>
        public const int ERROR_SPACES_DRIVE_OPERATIONAL_STATE_INVALID = unchecked((int)0x80E70012);

        //
        // Volsnap errors
        //
        // Success
        /// <summary>
        /// The bootfile is too small to support persistent snapshots.
        /// </summary>
        public const int ERROR_VOLSNAP_BOOTFILE_NOT_VALID = unchecked((int)0x80820001);

        /// <summary>
        /// Activation of persistent snapshots on this volume took longer than was allowed.
        /// </summary>
        public const int ERROR_VOLSNAP_ACTIVATION_TIMEOUT = unchecked((int)0x80820002);

        //
        // Tiering errors
        //
        // Errors
        /// <summary>
        /// The specified volume does not support storage tiers.
        /// </summary>
        public const int ERROR_TIERING_NOT_SUPPORTED_ON_VOLUME = unchecked((int)0x80830001);

        /// <summary>
        /// The Storage Tiers Management service detected that the specified volume is in the process of being dismounted.
        /// </summary>
        public const int ERROR_TIERING_VOLUME_DISMOUNT_IN_PROGRESS = unchecked((int)0x80830002);

        /// <summary>
        /// The specified storage tier could not be found on the volume. Confirm that the storage tier name is valid.
        /// </summary>
        public const int ERROR_TIERING_STORAGE_TIER_NOT_FOUND = unchecked((int)0x80830003);

        /// <summary>
        /// The file identifier specified is not valid on the volume.
        /// </summary>
        public const int ERROR_TIERING_INVALID_FILE_ID = unchecked((int)0x80830004);

        /// <summary>
        /// Storage tier operations must be called on the clustering node that owns the metadata volume.
        /// </summary>
        public const int ERROR_TIERING_WRONG_CLUSTER_NODE = unchecked((int)0x80830005);

        /// <summary>
        /// The Storage Tiers Management service is already optimizing the storage tiers on the specified volume.
        /// </summary>
        public const int ERROR_TIERING_ALREADY_PROCESSING = unchecked((int)0x80830006);

        /// <summary>
        /// The requested object type cannot be assigned to a storage tier.
        /// </summary>
        public const int ERROR_TIERING_CANNOT_PIN_OBJECT = unchecked((int)0x80830007);

        /// <summary>
        /// The requested file is not pinned to a tier.
        /// </summary>
        public const int ERROR_TIERING_FILE_IS_NOT_PINNED = unchecked((int)0x80830008);

        /// <summary>
        /// The volume is not a tiered volume.
        /// </summary>
        public const int ERROR_NOT_A_TIERED_VOLUME = unchecked((int)0x80830009);

        /// <summary>
        /// The requested attribute is not present on the specified file or directory.
        /// </summary>
        public const int ERROR_ATTRIBUTE_NOT_PRESENT = unchecked((int)0x8083000A);

        //
        // Embedded Security Core
        //
        // Reserved id values 0x0001 - 0x00FF
        //                    0x8xxx
        //                    0x4xxx
        /// <summary>
        /// The command was not recognized by the security core
        /// </summary>
        public const int ERROR_SECCORE_INVALID_COMMAND = unchecked((int)0xC0E80000);

        //
        // Clip modern app and windows licensing error messages.
        //
        /// <summary>
        /// No applicable app licenses found.
        /// </summary>
        public const int ERROR_NO_APPLICABLE_APP_LICENSES_FOUND = unchecked((int)0xC0EA0001);

        /// <summary>
        /// CLiP license not found.
        /// </summary>
        public const int ERROR_CLIP_LICENSE_NOT_FOUND = unchecked((int)0xC0EA0002);

        /// <summary>
        /// CLiP device license not found.
        /// </summary>
        public const int ERROR_CLIP_DEVICE_LICENSE_MISSING = unchecked((int)0xC0EA0003);

        /// <summary>
        /// CLiP license has an invalid signature.
        /// </summary>
        public const int ERROR_CLIP_LICENSE_INVALID_SIGNATURE = unchecked((int)0xC0EA0004);

        /// <summary>
        /// CLiP keyholder license is invalid or missing.
        /// </summary>
        public const int ERROR_CLIP_KEYHOLDER_LICENSE_MISSING_OR_INVALID = unchecked((int)0xC0EA0005);

        /// <summary>
        /// CLiP license has expired.
        /// </summary>
        public const int ERROR_CLIP_LICENSE_EXPIRED = unchecked((int)0xC0EA0006);

        /// <summary>
        /// CLiP license is signed by an unknown source.
        /// </summary>
        public const int ERROR_CLIP_LICENSE_SIGNED_BY_UNKNOWN_SOURCE = unchecked((int)0xC0EA0007);

        /// <summary>
        /// CLiP license is not signed.
        /// </summary>
        public const int ERROR_CLIP_LICENSE_NOT_SIGNED = unchecked((int)0xC0EA0008);

        /// <summary>
        /// CLiP license hardware ID is out of tolerance.
        /// </summary>
        public const int ERROR_CLIP_LICENSE_HARDWARE_ID_OUT_OF_TOLERANCE = unchecked((int)0xC0EA0009);

        /// <summary>
        /// CLiP license device ID does not match the device ID in the bound device license.
        /// </summary>
        public const int ERROR_CLIP_LICENSE_DEVICE_ID_MISMATCH = unchecked((int)0xC0EA000A);

        //
        // ===============================
        // Facility Direct* Error Messages
        // ===============================
        //
        //

        //
        // DXGI status (success) codes
        //

        /// <summary>
        /// The Present operation was invisible to the user.
        /// </summary>
        public const int DXGI_STATUS_OCCLUDED = 0x087A0001;

        /// <summary>
        /// The Present operation was partially invisible to the user.
        /// </summary>
        public const int DXGI_STATUS_CLIPPED = 0x087A0002;

        /// <summary>
        /// The driver is requesting that the DXGI runtime not use shared resources to communicate with the Desktop Window Manager.
        /// </summary>
        public const int DXGI_STATUS_NO_REDIRECTION = 0x087A0004;

        /// <summary>
        /// The Present operation was not visible because the Windows session has switched to another desktop (for example, ctrl-alt-del).
        /// </summary>
        public const int DXGI_STATUS_NO_DESKTOP_ACCESS = 0x087A0005;

        /// <summary>
        /// The Present operation was not visible because the target monitor was being used for some other purpose.
        /// </summary>
        public const int DXGI_STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE = 0x087A0006;

        /// <summary>
        /// The Present operation was not visible because the display mode changed. DXGI will have re-attempted the presentation.
        /// </summary>
        public const int DXGI_STATUS_MODE_CHANGED = 0x087A0007;

        /// <summary>
        /// The Present operation was not visible because another Direct3D device was attempting to take fullscreen mode at the time.
        /// </summary>
        public const int DXGI_STATUS_MODE_CHANGE_IN_PROGRESS = 0x087A0008;


        //
        // DXGI error codes
        //

        /// <summary>
        /// The application made a call that is invalid. Either the parameters of the call or the state of some object was incorrect.
        /// Enable the D3D debug layer in order to see details via debug messages.
        /// </summary>
        public const int DXGI_ERROR_INVALID_CALL = unchecked((int)0x887A0001);

        /// <summary>
        /// The object was not found. If calling IDXGIFactory::EnumAdaptes, there is no adapter with the specified ordinal.
        /// </summary>
        public const int DXGI_ERROR_NOT_FOUND = unchecked((int)0x887A0002);

        /// <summary>
        /// The caller did not supply a sufficiently large buffer.
        /// </summary>
        public const int DXGI_ERROR_MORE_DATA = unchecked((int)0x887A0003);

        /// <summary>
        /// The specified device interface or feature level is not supported on this system.
        /// </summary>
        public const int DXGI_ERROR_UNSUPPORTED = unchecked((int)0x887A0004);

        /// <summary>
        /// The GPU device instance has been suspended. Use GetDeviceRemovedReason to determine the appropriate action.
        /// </summary>
        public const int DXGI_ERROR_DEVICE_REMOVED = unchecked((int)0x887A0005);

        /// <summary>
        /// The GPU will not respond to more commands, most likely because of an invalid command passed by the calling application.
        /// </summary>
        public const int DXGI_ERROR_DEVICE_HUNG = unchecked((int)0x887A0006);

        /// <summary>
        /// The GPU will not respond to more commands, most likely because some other application submitted invalid commands.
        /// The calling application should re-create the device and continue.
        /// </summary>
        public const int DXGI_ERROR_DEVICE_RESET = unchecked((int)0x887A0007);

        /// <summary>
        /// The GPU was busy at the moment when the call was made, and the call was neither executed nor scheduled.
        /// </summary>
        public const int DXGI_ERROR_WAS_STILL_DRAWING = unchecked((int)0x887A000A);

        /// <summary>
        /// An event (such as power cycle) interrupted the gathering of presentation statistics. Any previous statistics should be
        /// considered invalid.
        /// </summary>
        public const int DXGI_ERROR_FRAME_STATISTICS_DISJOINT = unchecked((int)0x887A000B);

        /// <summary>
        /// Fullscreen mode could not be achieved because the specified output was already in use.
        /// </summary>
        public const int DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE = unchecked((int)0x887A000C);

        /// <summary>
        /// An internal issue prevented the driver from carrying out the specified operation. The driver's state is probably suspect,
        /// and the application should not continue.
        /// </summary>
        public const int DXGI_ERROR_DRIVER_INTERNAL_ERROR = unchecked((int)0x887A0020);

        /// <summary>
        /// A global counter resource was in use, and the specified counter cannot be used by this Direct3D device at this time.
        /// </summary>
        public const int DXGI_ERROR_NONEXCLUSIVE = unchecked((int)0x887A0021);

        /// <summary>
        /// A resource is not available at the time of the call, but may become available later.
        /// </summary>
        public const int DXGI_ERROR_NOT_CURRENTLY_AVAILABLE = unchecked((int)0x887A0022);

        /// <summary>
        /// The application's remote device has been removed due to session disconnect or network disconnect.
        /// The application should call IDXGIFactory1::IsCurrent to find out when the remote device becomes available again.
        /// </summary>
        public const int DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED = unchecked((int)0x887A0023);

        /// <summary>
        /// The device has been removed during a remote session because the remote computer ran out of memory.
        /// </summary>
        public const int DXGI_ERROR_REMOTE_OUTOFMEMORY = unchecked((int)0x887A0024);

        /// <summary>
        /// The keyed mutex was abandoned.
        /// </summary>
        public const int DXGI_ERROR_ACCESS_LOST = unchecked((int)0x887A0026);

        /// <summary>
        /// The timeout value has elapsed and the resource is not yet available.
        /// </summary>
        public const int DXGI_ERROR_WAIT_TIMEOUT = unchecked((int)0x887A0027);

        /// <summary>
        /// The output duplication has been turned off because the Windows session ended or was disconnected.
        /// This happens when a remote user disconnects, or when "switch user" is used locally.
        /// </summary>
        public const int DXGI_ERROR_SESSION_DISCONNECTED = unchecked((int)0x887A0028);

        /// <summary>
        /// The DXGI outuput (monitor) to which the swapchain content was restricted, has been disconnected or changed.
        /// </summary>
        public const int DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE = unchecked((int)0x887A0029);

        /// <summary>
        /// DXGI is unable to provide content protection on the swapchain. This is typically caused by an older driver,
        /// or by the application using a swapchain that is incompatible with content protection.
        /// </summary>
        public const int DXGI_ERROR_CANNOT_PROTECT_CONTENT = unchecked((int)0x887A002A);

        /// <summary>
        /// The application is trying to use a resource to which it does not have the required access privileges.
        /// This is most commonly caused by writing to a shared resource with read-only access.
        /// </summary>
        public const int DXGI_ERROR_ACCESS_DENIED = unchecked((int)0x887A002B);

        /// <summary>
        /// The application is trying to create a shared handle using a name that is already associated with some other resource.
        /// </summary>
        public const int DXGI_ERROR_NAME_ALREADY_EXISTS = unchecked((int)0x887A002C);

        /// <summary>
        /// The application requested an operation that depends on an SDK component that is missing or mismatched.
        /// </summary>
        public const int DXGI_ERROR_SDK_COMPONENT_MISSING = unchecked((int)0x887A002D);

        /// <summary>
        /// The DXGI objects that the application has created are no longer current &amp; need to be recreated for this operation to be performed.
        /// </summary>
        public const int DXGI_ERROR_NOT_CURRENT = unchecked((int)0x887A002E);

        /// <summary>
        /// Insufficient HW protected memory exits for proper function.
        /// </summary>
        public const int DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY = unchecked((int)0x887A0030);

        /// <summary>
        /// Creating this device would violate the process's dynamic code policy.
        /// </summary>
        public const int DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION = unchecked((int)0x887A0031);

        /// <summary>
        /// The operation failed because the compositor is not in control of the output.
        /// </summary>
        public const int DXGI_ERROR_NON_COMPOSITED_UI = unchecked((int)0x887A0032);


        //
        // DXGI errors that are internal to the Desktop Window Manager
        //

        /// <summary>
        /// The swapchain has become unoccluded.
        /// </summary>
        public const int DXGI_STATUS_UNOCCLUDED = 0x087A0009;

        /// <summary>
        /// The adapter did not have access to the required resources to complete the Desktop Duplication Present() call, the Present() call needs to be made again
        /// </summary>
        public const int DXGI_STATUS_DDA_WAS_STILL_DRAWING = 0x087A000A;

        /// <summary>
        /// An on-going mode change prevented completion of the call. The call may succeed if attempted later.
        /// </summary>
        public const int DXGI_ERROR_MODE_CHANGE_IN_PROGRESS = unchecked((int)0x887A0025);

        /// <summary>
        /// The present succeeded but the caller should present again on the next V-sync, even if there are no changes to the content.
        /// </summary>
        public const int DXGI_STATUS_PRESENT_REQUIRED = 0x087A002F;


        //
        // DXGI errors that are produced by the D3D Shader Cache component
        //

        /// <summary>
        /// The cache is corrupt and either could not be opened or could not be reset.
        /// </summary>
        public const int DXGI_ERROR_CACHE_CORRUPT = unchecked((int)0x887A0033);

        /// <summary>
        /// This entry would cause the cache to exceed its quota. On a load operation, this may indicate exceeding the maximum in-memory size.
        /// </summary>
        public const int DXGI_ERROR_CACHE_FULL = unchecked((int)0x887A0034);

        /// <summary>
        /// A cache entry was found, but the key provided does not match the key stored in the entry.
        /// </summary>
        public const int DXGI_ERROR_CACHE_HASH_COLLISION = unchecked((int)0x887A0035);

        /// <summary>
        /// The desired element already exists.
        /// </summary>
        public const int DXGI_ERROR_ALREADY_EXISTS = unchecked((int)0x887A0036);


        //
        // DXGI DDI
        //

        /// <summary>
        /// The GPU was busy when the operation was requested.
        /// </summary>
        public const int DXGI_DDI_ERR_WASSTILLDRAWING = unchecked((int)0x887B0001);

        /// <summary>
        /// The driver has rejected the creation of this resource.
        /// </summary>
        public const int DXGI_DDI_ERR_UNSUPPORTED = unchecked((int)0x887B0002);

        /// <summary>
        /// The GPU counter was in use by another process or d3d device when application requested access to it.
        /// </summary>
        public const int DXGI_DDI_ERR_NONEXCLUSIVE = unchecked((int)0x887B0003);


        //
        // Direct3D10
        //

        /// <summary>
        /// The application has exceeded the maximum number of unique state objects per Direct3D device.
        /// The limit is 4096 for feature levels up to 11.1.
        /// </summary>
        public const int D3D10_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS = unchecked((int)0x88790001);

        /// <summary>
        /// The specified file was not found.
        /// </summary>
        public const int D3D10_ERROR_FILE_NOT_FOUND = unchecked((int)0x88790002);


        //
        // Direct3D11
        //

        /// <summary>
        /// The application has exceeded the maximum number of unique state objects per Direct3D device.
        /// The limit is 4096 for feature levels up to 11.1.
        /// </summary>
        public const int D3D11_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS = unchecked((int)0x887C0001);

        /// <summary>
        /// The specified file was not found.
        /// </summary>
        public const int D3D11_ERROR_FILE_NOT_FOUND = unchecked((int)0x887C0002);

        /// <summary>
        /// The application has exceeded the maximum number of unique view objects per Direct3D device.
        /// The limit is 2^20 for feature levels up to 11.1.
        /// </summary>
        public const int D3D11_ERROR_TOO_MANY_UNIQUE_VIEW_OBJECTS = unchecked((int)0x887C0003);

        /// <summary>
        /// The application's first call per command list to Map on a deferred context did not use D3D11_MAP_WRITE_DISCARD.
        /// </summary>
        public const int D3D11_ERROR_DEFERRED_CONTEXT_MAP_WITHOUT_INITIAL_DISCARD = unchecked((int)0x887C0004);


        //
        // Direct3D12
        //

        /// <summary>
        /// The blob provided does not match the adapter that the device was created on.
        /// </summary>
        public const int D3D12_ERROR_ADAPTER_NOT_FOUND = unchecked((int)0x887E0001);

        /// <summary>
        /// The blob provided was created for a different version of the driver, and must be re-created.
        /// </summary>
        public const int D3D12_ERROR_DRIVER_VERSION_MISMATCH = unchecked((int)0x887E0002);


        //
        // Direct2D
        //

        /// <summary>
        /// The object was not in the correct state to process the method.
        /// </summary>
        public const int D2DERR_WRONG_STATE = unchecked((int)0x88990001);

        /// <summary>
        /// The object has not yet been initialized.
        /// </summary>
        public const int D2DERR_NOT_INITIALIZED = unchecked((int)0x88990002);

        /// <summary>
        /// The requested operation is not supported.
        /// </summary>
        public const int D2DERR_UNSUPPORTED_OPERATION = unchecked((int)0x88990003);

        /// <summary>
        /// The geometry scanner failed to process the data.
        /// </summary>
        public const int D2DERR_SCANNER_FAILED = unchecked((int)0x88990004);

        /// <summary>
        /// Direct2D could not access the screen.
        /// </summary>
        public const int D2DERR_SCREEN_ACCESS_DENIED = unchecked((int)0x88990005);

        /// <summary>
        /// A valid display state could not be determined.
        /// </summary>
        public const int D2DERR_DISPLAY_STATE_INVALID = unchecked((int)0x88990006);

        /// <summary>
        /// The supplied vector is zero.
        /// </summary>
        public const int D2DERR_ZERO_VECTOR = unchecked((int)0x88990007);

        /// <summary>
        /// An internal error (Direct2D bug) occurred. On checked builds, we would assert. The application should close this instance of Direct2D and should consider restarting its process.
        /// </summary>
        public const int D2DERR_INTERNAL_ERROR = unchecked((int)0x88990008);

        /// <summary>
        /// The display format Direct2D needs to render is not supported by the hardware device.
        /// </summary>
        public const int D2DERR_DISPLAY_FORMAT_NOT_SUPPORTED = unchecked((int)0x88990009);

        /// <summary>
        /// A call to this method is invalid.
        /// </summary>
        public const int D2DERR_INVALID_CALL = unchecked((int)0x8899000A);

        /// <summary>
        /// No hardware rendering device is available for this operation.
        /// </summary>
        public const int D2DERR_NO_HARDWARE_DEVICE = unchecked((int)0x8899000B);

        /// <summary>
        /// There has been a presentation error that may be recoverable. The caller needs to recreate, rerender the entire frame, and reattempt present.
        /// </summary>
        public const int D2DERR_RECREATE_TARGET = unchecked((int)0x8899000C);

        /// <summary>
        /// Shader construction failed because it was too complex.
        /// </summary>
        public const int D2DERR_TOO_MANY_SHADER_ELEMENTS = unchecked((int)0x8899000D);

        /// <summary>
        /// Shader compilation failed.
        /// </summary>
        public const int D2DERR_SHADER_COMPILE_FAILED = unchecked((int)0x8899000E);

        /// <summary>
        /// Requested DirectX surface size exceeded maximum texture size.
        /// </summary>
        public const int D2DERR_MAX_TEXTURE_SIZE_EXCEEDED = unchecked((int)0x8899000F);

        /// <summary>
        /// The requested Direct2D version is not supported.
        /// </summary>
        public const int D2DERR_UNSUPPORTED_VERSION = unchecked((int)0x88990010);

        /// <summary>
        /// Invalid number.
        /// </summary>
        public const int D2DERR_BAD_NUMBER = unchecked((int)0x88990011);

        /// <summary>
        /// Objects used together must be created from the same factory instance.
        /// </summary>
        public const int D2DERR_WRONG_FACTORY = unchecked((int)0x88990012);

        /// <summary>
        /// A layer resource can only be in use once at any point in time.
        /// </summary>
        public const int D2DERR_LAYER_ALREADY_IN_USE = unchecked((int)0x88990013);

        /// <summary>
        /// The pop call did not match the corresponding push call.
        /// </summary>
        public const int D2DERR_POP_CALL_DID_NOT_MATCH_PUSH = unchecked((int)0x88990014);

        /// <summary>
        /// The resource was realized on the wrong render target.
        /// </summary>
        public const int D2DERR_WRONG_RESOURCE_DOMAIN = unchecked((int)0x88990015);

        /// <summary>
        /// The push and pop calls were unbalanced.
        /// </summary>
        public const int D2DERR_PUSH_POP_UNBALANCED = unchecked((int)0x88990016);

        /// <summary>
        /// Attempt to copy from a render target while a layer or clip rect is applied.
        /// </summary>
        public const int D2DERR_RENDER_TARGET_HAS_LAYER_OR_CLIPRECT = unchecked((int)0x88990017);

        /// <summary>
        /// The brush types are incompatible for the call.
        /// </summary>
        public const int D2DERR_INCOMPATIBLE_BRUSH_TYPES = unchecked((int)0x88990018);

        /// <summary>
        /// An unknown win32 failure occurred.
        /// </summary>
        public const int D2DERR_WIN32_ERROR = unchecked((int)0x88990019);

        /// <summary>
        /// The render target is not compatible with GDI.
        /// </summary>
        public const int D2DERR_TARGET_NOT_GDI_COMPATIBLE = unchecked((int)0x8899001A);

        /// <summary>
        /// A text client drawing effect object is of the wrong type.
        /// </summary>
        public const int D2DERR_TEXT_EFFECT_IS_WRONG_TYPE = unchecked((int)0x8899001B);

        /// <summary>
        /// The application is holding a reference to the IDWriteTextRenderer interface after the corresponding DrawText or DrawTextLayout call has returned. The IDWriteTextRenderer instance will be invalid.
        /// </summary>
        public const int D2DERR_TEXT_RENDERER_NOT_RELEASED = unchecked((int)0x8899001C);

        /// <summary>
        /// The requested size is larger than the guaranteed supported texture size at the Direct3D device's current feature level.
        /// </summary>
        public const int D2DERR_EXCEEDS_MAX_BITMAP_SIZE = unchecked((int)0x8899001D);

        /// <summary>
        /// There was a configuration error in the graph.
        /// </summary>
        public const int D2DERR_INVALID_GRAPH_CONFIGURATION = unchecked((int)0x8899001E);

        /// <summary>
        /// There was a internal configuration error in the graph.
        /// </summary>
        public const int D2DERR_INVALID_INTERNAL_GRAPH_CONFIGURATION = unchecked((int)0x8899001F);

        /// <summary>
        /// There was a cycle in the graph.
        /// </summary>
        public const int D2DERR_CYCLIC_GRAPH = unchecked((int)0x88990020);

        /// <summary>
        /// Cannot draw with a bitmap that has the D2D1_BITMAP_OPTIONS_CANNOT_DRAW option.
        /// </summary>
        public const int D2DERR_BITMAP_CANNOT_DRAW = unchecked((int)0x88990021);

        /// <summary>
        /// The operation cannot complete while there are outstanding references to the target bitmap.
        /// </summary>
        public const int D2DERR_OUTSTANDING_BITMAP_REFERENCES = unchecked((int)0x88990022);

        /// <summary>
        /// The operation failed because the original target is not currently bound as a target.
        /// </summary>
        public const int D2DERR_ORIGINAL_TARGET_NOT_BOUND = unchecked((int)0x88990023);

        /// <summary>
        /// Cannot set the image as a target because it is either an effect or is a bitmap that does not have the D2D1_BITMAP_OPTIONS_TARGET flag set.
        /// </summary>
        public const int D2DERR_INVALID_TARGET = unchecked((int)0x88990024);

        /// <summary>
        /// Cannot draw with a bitmap that is currently bound as the target bitmap.
        /// </summary>
        public const int D2DERR_BITMAP_BOUND_AS_TARGET = unchecked((int)0x88990025);

        /// <summary>
        /// D3D Device does not have sufficient capabilities to perform the requested action.
        /// </summary>
        public const int D2DERR_INSUFFICIENT_DEVICE_CAPABILITIES = unchecked((int)0x88990026);

        /// <summary>
        /// The graph could not be rendered with the context's current tiling settings.
        /// </summary>
        public const int D2DERR_INTERMEDIATE_TOO_LARGE = unchecked((int)0x88990027);

        /// <summary>
        /// The CLSID provided to Unregister did not correspond to a registered effect.
        /// </summary>
        public const int D2DERR_EFFECT_IS_NOT_REGISTERED = unchecked((int)0x88990028);

        /// <summary>
        /// The specified property does not exist.
        /// </summary>
        public const int D2DERR_INVALID_PROPERTY = unchecked((int)0x88990029);

        /// <summary>
        /// The specified sub-property does not exist.
        /// </summary>
        public const int D2DERR_NO_SUBPROPERTIES = unchecked((int)0x8899002A);

        /// <summary>
        /// AddPage or Close called after print job is already closed.
        /// </summary>
        public const int D2DERR_PRINT_JOB_CLOSED = unchecked((int)0x8899002B);

        /// <summary>
        /// Error during print control creation. Indicates that none of the package target types (representing printer formats) are supported by Direct2D print control.
        /// </summary>
        public const int D2DERR_PRINT_FORMAT_NOT_SUPPORTED = unchecked((int)0x8899002C);

        /// <summary>
        /// An effect attempted to use a transform with too many inputs.
        /// </summary>
        public const int D2DERR_TOO_MANY_TRANSFORM_INPUTS = unchecked((int)0x8899002D);

        /// <summary>
        /// An error was encountered while decoding or parsing the requested glyph image.
        /// </summary>
        public const int D2DERR_INVALID_GLYPH_IMAGE = unchecked((int)0x8899002E);


        //
        // DirectWrite
        //

        /// <summary>
        /// Indicates an error in an input file such as a font file.
        /// </summary>
        public const int DWRITE_E_FILEFORMAT = unchecked((int)0x88985000);

        /// <summary>
        /// Indicates an error originating in DirectWrite code, which is not expected to occur but is safe to recover from.
        /// </summary>
        public const int DWRITE_E_UNEXPECTED = unchecked((int)0x88985001);

        /// <summary>
        /// Indicates the specified font does not exist.
        /// </summary>
        public const int DWRITE_E_NOFONT = unchecked((int)0x88985002);

        /// <summary>
        /// A font file could not be opened because the file, directory, network location, drive, or other storage location does not exist or is unavailable.
        /// </summary>
        public const int DWRITE_E_FILENOTFOUND = unchecked((int)0x88985003);

        /// <summary>
        /// A font file exists but could not be opened due to access denied, sharing violation, or similar error.
        /// </summary>
        public const int DWRITE_E_FILEACCESS = unchecked((int)0x88985004);

        /// <summary>
        /// A font collection is obsolete due to changes in the system.
        /// </summary>
        public const int DWRITE_E_FONTCOLLECTIONOBSOLETE = unchecked((int)0x88985005);

        /// <summary>
        /// The given interface is already registered.
        /// </summary>
        public const int DWRITE_E_ALREADYREGISTERED = unchecked((int)0x88985006);

        /// <summary>
        /// The font cache contains invalid data.
        /// </summary>
        public const int DWRITE_E_CACHEFORMAT = unchecked((int)0x88985007);

        /// <summary>
        /// A font cache file corresponds to a different version of DirectWrite.
        /// </summary>
        public const int DWRITE_E_CACHEVERSION = unchecked((int)0x88985008);

        /// <summary>
        /// The operation is not supported for this type of font.
        /// </summary>
        public const int DWRITE_E_UNSUPPORTEDOPERATION = unchecked((int)0x88985009);

        /// <summary>
        /// The version of the text renderer interface is not compatible.
        /// </summary>
        public const int DWRITE_E_TEXTRENDERERINCOMPATIBLE = unchecked((int)0x8898500A);

        /// <summary>
        /// The flow direction conflicts with the reading direction. They must be perpendicular to each other.
        /// </summary>
        public const int DWRITE_E_FLOWDIRECTIONCONFLICTS = unchecked((int)0x8898500B);

        /// <summary>
        /// The font or glyph run does not contain any colored glyphs.
        /// </summary>
        public const int DWRITE_E_NOCOLOR = unchecked((int)0x8898500C);

        /// <summary>
        /// A font resource could not be accessed because it is remote.
        /// </summary>
        public const int DWRITE_E_REMOTEFONT = unchecked((int)0x8898500D);

        /// <summary>
        /// A font download was canceled.
        /// </summary>
        public const int DWRITE_E_DOWNLOADCANCELLED = unchecked((int)0x8898500E);

        /// <summary>
        /// A font download failed.
        /// </summary>
        public const int DWRITE_E_DOWNLOADFAILED = unchecked((int)0x8898500F);

        /// <summary>
        /// A font download request was not added or a download failed because there are too many active downloads.
        /// </summary>
        public const int DWRITE_E_TOOMANYDOWNLOADS = unchecked((int)0x88985010);


        //
        // Windows Codecs
        //

        /// <summary>
        /// The codec is in the wrong state.
        /// </summary>
        public const int WINCODEC_ERR_WRONGSTATE = unchecked((int)0x88982F04);

        /// <summary>
        /// The value is out of range.
        /// </summary>
        public const int WINCODEC_ERR_VALUEOUTOFRANGE = unchecked((int)0x88982F05);

        /// <summary>
        /// The image format is unknown.
        /// </summary>
        public const int WINCODEC_ERR_UNKNOWNIMAGEFORMAT = unchecked((int)0x88982F07);

        /// <summary>
        /// The SDK version is unsupported.
        /// </summary>
        public const int WINCODEC_ERR_UNSUPPORTEDVERSION = unchecked((int)0x88982F0B);

        /// <summary>
        /// The component is not initialized.
        /// </summary>
        public const int WINCODEC_ERR_NOTINITIALIZED = unchecked((int)0x88982F0C);

        /// <summary>
        /// There is already an outstanding read or write lock.
        /// </summary>
        public const int WINCODEC_ERR_ALREADYLOCKED = unchecked((int)0x88982F0D);

        /// <summary>
        /// The specified bitmap property cannot be found.
        /// </summary>
        public const int WINCODEC_ERR_PROPERTYNOTFOUND = unchecked((int)0x88982F40);

        /// <summary>
        /// The bitmap codec does not support the bitmap property.
        /// </summary>
        public const int WINCODEC_ERR_PROPERTYNOTSUPPORTED = unchecked((int)0x88982F41);

        /// <summary>
        /// The bitmap property size is invalid.
        /// </summary>
        public const int WINCODEC_ERR_PROPERTYSIZE = unchecked((int)0x88982F42);

        /// <summary>
        /// An unknown error has occurred.
        /// </summary>
        public const int WINCODEC_ERR_CODECPRESENT = unchecked((int)0x88982F43);

        /// <summary>
        /// The bitmap codec does not support a thumbnail.
        /// </summary>
        public const int WINCODEC_ERR_CODECNOTHUMBNAIL = unchecked((int)0x88982F44);

        /// <summary>
        /// The bitmap palette is unavailable.
        /// </summary>
        public const int WINCODEC_ERR_PALETTEUNAVAILABLE = unchecked((int)0x88982F45);

        /// <summary>
        /// Too many scanlines were requested.
        /// </summary>
        public const int WINCODEC_ERR_CODECTOOMANYSCANLINES = unchecked((int)0x88982F46);

        /// <summary>
        /// An internal error occurred.
        /// </summary>
        public const int WINCODEC_ERR_INTERNALERROR = unchecked((int)0x88982F48);

        /// <summary>
        /// The bitmap bounds do not match the bitmap dimensions.
        /// </summary>
        public const int WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS = unchecked((int)0x88982F49);

        /// <summary>
        /// The component cannot be found.
        /// </summary>
        public const int WINCODEC_ERR_COMPONENTNOTFOUND = unchecked((int)0x88982F50);

        /// <summary>
        /// The bitmap size is outside the valid range.
        /// </summary>
        public const int WINCODEC_ERR_IMAGESIZEOUTOFRANGE = unchecked((int)0x88982F51);

        /// <summary>
        /// There is too much metadata to be written to the bitmap.
        /// </summary>
        public const int WINCODEC_ERR_TOOMUCHMETADATA = unchecked((int)0x88982F52);

        /// <summary>
        /// The image is unrecognized.
        /// </summary>
        public const int WINCODEC_ERR_BADIMAGE = unchecked((int)0x88982F60);

        /// <summary>
        /// The image header is unrecognized.
        /// </summary>
        public const int WINCODEC_ERR_BADHEADER = unchecked((int)0x88982F61);

        /// <summary>
        /// The bitmap frame is missing.
        /// </summary>
        public const int WINCODEC_ERR_FRAMEMISSING = unchecked((int)0x88982F62);

        /// <summary>
        /// The image metadata header is unrecognized.
        /// </summary>
        public const int WINCODEC_ERR_BADMETADATAHEADER = unchecked((int)0x88982F63);

        /// <summary>
        /// The stream data is unrecognized.
        /// </summary>
        public const int WINCODEC_ERR_BADSTREAMDATA = unchecked((int)0x88982F70);

        /// <summary>
        /// Failed to write to the stream.
        /// </summary>
        public const int WINCODEC_ERR_STREAMWRITE = unchecked((int)0x88982F71);

        /// <summary>
        /// Failed to read from the stream.
        /// </summary>
        public const int WINCODEC_ERR_STREAMREAD = unchecked((int)0x88982F72);

        /// <summary>
        /// The stream is not available.
        /// </summary>
        public const int WINCODEC_ERR_STREAMNOTAVAILABLE = unchecked((int)0x88982F73);

        /// <summary>
        /// The bitmap pixel format is unsupported.
        /// </summary>
        public const int WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT = unchecked((int)0x88982F80);

        /// <summary>
        /// The operation is unsupported.
        /// </summary>
        public const int WINCODEC_ERR_UNSUPPORTEDOPERATION = unchecked((int)0x88982F81);

        /// <summary>
        /// The component registration is invalid.
        /// </summary>
        public const int WINCODEC_ERR_INVALIDREGISTRATION = unchecked((int)0x88982F8A);

        /// <summary>
        /// The component initialization has failed.
        /// </summary>
        public const int WINCODEC_ERR_COMPONENTINITIALIZEFAILURE = unchecked((int)0x88982F8B);

        /// <summary>
        /// The buffer allocated is insufficient.
        /// </summary>
        public const int WINCODEC_ERR_INSUFFICIENTBUFFER = unchecked((int)0x88982F8C);

        /// <summary>
        /// Duplicate metadata is present.
        /// </summary>
        public const int WINCODEC_ERR_DUPLICATEMETADATAPRESENT = unchecked((int)0x88982F8D);

        /// <summary>
        /// The bitmap property type is unexpected.
        /// </summary>
        public const int WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE = unchecked((int)0x88982F8E);

        /// <summary>
        /// The size is unexpected.
        /// </summary>
        public const int WINCODEC_ERR_UNEXPECTEDSIZE = unchecked((int)0x88982F8F);

        /// <summary>
        /// The property query is invalid.
        /// </summary>
        public const int WINCODEC_ERR_INVALIDQUERYREQUEST = unchecked((int)0x88982F90);

        /// <summary>
        /// The metadata type is unexpected.
        /// </summary>
        public const int WINCODEC_ERR_UNEXPECTEDMETADATATYPE = unchecked((int)0x88982F91);

        /// <summary>
        /// The specified bitmap property is only valid at root level.
        /// </summary>
        public const int WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT = unchecked((int)0x88982F92);

        /// <summary>
        /// The query string contains an invalid character.
        /// </summary>
        public const int WINCODEC_ERR_INVALIDQUERYCHARACTER = unchecked((int)0x88982F93);

        /// <summary>
        /// Windows Codecs received an error from the Win32 system.
        /// </summary>
        public const int WINCODEC_ERR_WIN32ERROR = unchecked((int)0x88982F94);

        /// <summary>
        /// The requested level of detail is not present.
        /// </summary>
        public const int WINCODEC_ERR_INVALIDPROGRESSIVELEVEL = unchecked((int)0x88982F95);

        /// <summary>
        /// The scan index is invalid.
        /// </summary>
        public const int WINCODEC_ERR_INVALIDJPEGSCANINDEX = unchecked((int)0x88982F96);


        //
        // MIL/DWM
        //

        /// <summary>
        /// MILERR_OBJECTBUSY
        /// </summary>
        public const int MILERR_OBJECTBUSY = unchecked((int)0x88980001);

        /// <summary>
        /// MILERR_INSUFFICIENTBUFFER
        /// </summary>
        public const int MILERR_INSUFFICIENTBUFFER = unchecked((int)0x88980002);

        /// <summary>
        /// MILERR_WIN32ERROR
        /// </summary>
        public const int MILERR_WIN32ERROR = unchecked((int)0x88980003);

        /// <summary>
        /// MILERR_SCANNER_FAILED
        /// </summary>
        public const int MILERR_SCANNER_FAILED = unchecked((int)0x88980004);

        /// <summary>
        /// MILERR_SCREENACCESSDENIED
        /// </summary>
        public const int MILERR_SCREENACCESSDENIED = unchecked((int)0x88980005);

        /// <summary>
        /// MILERR_DISPLAYSTATEINVALID
        /// </summary>
        public const int MILERR_DISPLAYSTATEINVALID = unchecked((int)0x88980006);

        /// <summary>
        /// MILERR_NONINVERTIBLEMATRIX
        /// </summary>
        public const int MILERR_NONINVERTIBLEMATRIX = unchecked((int)0x88980007);

        /// <summary>
        /// MILERR_ZEROVECTOR
        /// </summary>
        public const int MILERR_ZEROVECTOR = unchecked((int)0x88980008);

        /// <summary>
        /// MILERR_TERMINATED
        /// </summary>
        public const int MILERR_TERMINATED = unchecked((int)0x88980009);

        /// <summary>
        /// MILERR_BADNUMBER
        /// </summary>
        public const int MILERR_BADNUMBER = unchecked((int)0x8898000A);

        /// <summary>
        /// An internal error (MIL bug) occurred. On checked builds, an assert would be raised.
        /// </summary>
        public const int MILERR_INTERNALERROR = unchecked((int)0x88980080);

        /// <summary>
        /// The display format we need to render is not supported by the hardware device.
        /// </summary>
        public const int MILERR_DISPLAYFORMATNOTSUPPORTED = unchecked((int)0x88980084);

        /// <summary>
        /// A call to this method is invalid.
        /// </summary>
        public const int MILERR_INVALIDCALL = unchecked((int)0x88980085);

        /// <summary>
        /// Lock attempted on an already locked object.
        /// </summary>
        public const int MILERR_ALREADYLOCKED = unchecked((int)0x88980086);

        /// <summary>
        /// Unlock attempted on an unlocked object.
        /// </summary>
        public const int MILERR_NOTLOCKED = unchecked((int)0x88980087);

        /// <summary>
        /// No algorithm avaliable to render text with this device
        /// </summary>
        public const int MILERR_DEVICECANNOTRENDERTEXT = unchecked((int)0x88980088);

        /// <summary>
        /// Some glyph bitmaps, required for glyph run rendering, are not contained in glyph cache.
        /// </summary>
        public const int MILERR_GLYPHBITMAPMISSED = unchecked((int)0x88980089);

        /// <summary>
        /// Some glyph bitmaps in glyph cache are unexpectedly big.
        /// </summary>
        public const int MILERR_MALFORMEDGLYPHCACHE = unchecked((int)0x8898008A);

        /// <summary>
        /// Marker error for known Win32 errors that are currently being ignored by the compositor. This is to avoid returning S_OK when an error has occurred, but still unwind the stack in the correct location.
        /// </summary>
        public const int MILERR_GENERIC_IGNORE = unchecked((int)0x8898008B);

        /// <summary>
        /// Guideline coordinates are not sorted properly or contain NaNs.
        /// </summary>
        public const int MILERR_MALFORMED_GUIDELINE_DATA = unchecked((int)0x8898008C);

        /// <summary>
        /// No HW rendering device is available for this operation.
        /// </summary>
        public const int MILERR_NO_HARDWARE_DEVICE = unchecked((int)0x8898008D);

        /// <summary>
        /// There has been a presentation error that may be recoverable. The caller needs to recreate, rerender the entire frame, and reattempt present.
        /// There are two known case for this: 1) D3D Driver Internal error 2) D3D E_FAIL 2a) Unknown root cause b) When resizing too quickly for DWM and D3D stay in sync
        /// </summary>
        public const int MILERR_NEED_RECREATE_AND_PRESENT = unchecked((int)0x8898008E);

        /// <summary>
        /// The object has already been initialized.
        /// </summary>
        public const int MILERR_ALREADY_INITIALIZED = unchecked((int)0x8898008F);

        /// <summary>
        /// The size of the object does not match the expected size.
        /// </summary>
        public const int MILERR_MISMATCHED_SIZE = unchecked((int)0x88980090);

        /// <summary>
        /// No Redirection surface available.
        /// </summary>
        public const int MILERR_NO_REDIRECTION_SURFACE_AVAILABLE = unchecked((int)0x88980091);

        /// <summary>
        /// Remoting of this content is not supported.
        /// </summary>
        public const int MILERR_REMOTING_NOT_SUPPORTED = unchecked((int)0x88980092);

        /// <summary>
        /// Queued Presents are not supported.
        /// </summary>
        public const int MILERR_QUEUED_PRESENT_NOT_SUPPORTED = unchecked((int)0x88980093);

        /// <summary>
        /// Queued Presents are not being used.
        /// </summary>
        public const int MILERR_NOT_QUEUING_PRESENTS = unchecked((int)0x88980094);

        /// <summary>
        /// No redirection surface was available. Caller should retry the call.
        /// </summary>
        public const int MILERR_NO_REDIRECTION_SURFACE_RETRY_LATER = unchecked((int)0x88980095);

        /// <summary>
        /// Shader construction failed because it was too complex.
        /// </summary>
        public const int MILERR_TOOMANYSHADERELEMNTS = unchecked((int)0x88980096);

        /// <summary>
        /// MROW attempt to get a read lock failed.
        /// </summary>
        public const int MILERR_MROW_READLOCK_FAILED = unchecked((int)0x88980097);

        /// <summary>
        /// MROW attempt to update the data failed because another update was outstanding.
        /// </summary>
        public const int MILERR_MROW_UPDATE_FAILED = unchecked((int)0x88980098);

        /// <summary>
        /// Shader compilation failed.
        /// </summary>
        public const int MILERR_SHADER_COMPILE_FAILED = unchecked((int)0x88980099);

        /// <summary>
        /// Requested DX redirection surface size exceeded maximum texture size.
        /// </summary>
        public const int MILERR_MAX_TEXTURE_SIZE_EXCEEDED = unchecked((int)0x8898009A);

        /// <summary>
        /// QueryPerformanceCounter returned a time in the past.
        /// </summary>
        public const int MILERR_QPC_TIME_WENT_BACKWARD = unchecked((int)0x8898009B);

        /// <summary>
        /// Primary Display device returned an invalid refresh rate.
        /// </summary>
        public const int MILERR_DXGI_ENUMERATION_OUT_OF_SYNC = unchecked((int)0x8898009D);

        /// <summary>
        /// DWM can not find the adapter specified by the LUID.
        /// </summary>
        public const int MILERR_ADAPTER_NOT_FOUND = unchecked((int)0x8898009E);

        /// <summary>
        /// The requested bitmap color space is not supported.
        /// </summary>
        public const int MILERR_COLORSPACE_NOT_SUPPORTED = unchecked((int)0x8898009F);

        /// <summary>
        /// The requested bitmap pre-filtering state is not supported.
        /// </summary>
        public const int MILERR_PREFILTER_NOT_SUPPORTED = unchecked((int)0x889800A0);

        /// <summary>
        /// Access is denied to the requested bitmap for the specified display id.
        /// </summary>
        public const int MILERR_DISPLAYID_ACCESS_DENIED = unchecked((int)0x889800A1);

        // Composition engine errors
        /// <summary>
        /// UCEERR_INVALIDPACKETHEADER
        /// </summary>
        public const int UCEERR_INVALIDPACKETHEADER = unchecked((int)0x88980400);

        /// <summary>
        /// UCEERR_UNKNOWNPACKET
        /// </summary>
        public const int UCEERR_UNKNOWNPACKET = unchecked((int)0x88980401);

        /// <summary>
        /// UCEERR_ILLEGALPACKET
        /// </summary>
        public const int UCEERR_ILLEGALPACKET = unchecked((int)0x88980402);

        /// <summary>
        /// UCEERR_MALFORMEDPACKET
        /// </summary>
        public const int UCEERR_MALFORMEDPACKET = unchecked((int)0x88980403);

        /// <summary>
        /// UCEERR_ILLEGALHANDLE
        /// </summary>
        public const int UCEERR_ILLEGALHANDLE = unchecked((int)0x88980404);

        /// <summary>
        /// UCEERR_HANDLELOOKUPFAILED
        /// </summary>
        public const int UCEERR_HANDLELOOKUPFAILED = unchecked((int)0x88980405);

        /// <summary>
        /// UCEERR_RENDERTHREADFAILURE
        /// </summary>
        public const int UCEERR_RENDERTHREADFAILURE = unchecked((int)0x88980406);

        /// <summary>
        /// UCEERR_CTXSTACKFRSTTARGETNULL
        /// </summary>
        public const int UCEERR_CTXSTACKFRSTTARGETNULL = unchecked((int)0x88980407);

        /// <summary>
        /// UCEERR_CONNECTIONIDLOOKUPFAILED
        /// </summary>
        public const int UCEERR_CONNECTIONIDLOOKUPFAILED = unchecked((int)0x88980408);

        /// <summary>
        /// UCEERR_BLOCKSFULL
        /// </summary>
        public const int UCEERR_BLOCKSFULL = unchecked((int)0x88980409);

        /// <summary>
        /// UCEERR_MEMORYFAILURE
        /// </summary>
        public const int UCEERR_MEMORYFAILURE = unchecked((int)0x8898040A);

        /// <summary>
        /// UCEERR_PACKETRECORDOUTOFRANGE
        /// </summary>
        public const int UCEERR_PACKETRECORDOUTOFRANGE = unchecked((int)0x8898040B);

        /// <summary>
        /// UCEERR_ILLEGALRECORDTYPE
        /// </summary>
        public const int UCEERR_ILLEGALRECORDTYPE = unchecked((int)0x8898040C);

        /// <summary>
        /// UCEERR_OUTOFHANDLES
        /// </summary>
        public const int UCEERR_OUTOFHANDLES = unchecked((int)0x8898040D);

        /// <summary>
        /// UCEERR_UNCHANGABLE_UPDATE_ATTEMPTED
        /// </summary>
        public const int UCEERR_UNCHANGABLE_UPDATE_ATTEMPTED = unchecked((int)0x8898040E);

        /// <summary>
        /// UCEERR_NO_MULTIPLE_WORKER_THREADS
        /// </summary>
        public const int UCEERR_NO_MULTIPLE_WORKER_THREADS = unchecked((int)0x8898040F);

        /// <summary>
        /// UCEERR_REMOTINGNOTSUPPORTED
        /// </summary>
        public const int UCEERR_REMOTINGNOTSUPPORTED = unchecked((int)0x88980410);

        /// <summary>
        /// UCEERR_MISSINGENDCOMMAND
        /// </summary>
        public const int UCEERR_MISSINGENDCOMMAND = unchecked((int)0x88980411);

        /// <summary>
        /// UCEERR_MISSINGBEGINCOMMAND
        /// </summary>
        public const int UCEERR_MISSINGBEGINCOMMAND = unchecked((int)0x88980412);

        /// <summary>
        /// UCEERR_CHANNELSYNCTIMEDOUT
        /// </summary>
        public const int UCEERR_CHANNELSYNCTIMEDOUT = unchecked((int)0x88980413);

        /// <summary>
        /// UCEERR_CHANNELSYNCABANDONED
        /// </summary>
        public const int UCEERR_CHANNELSYNCABANDONED = unchecked((int)0x88980414);

        /// <summary>
        /// UCEERR_UNSUPPORTEDTRANSPORTVERSION
        /// </summary>
        public const int UCEERR_UNSUPPORTEDTRANSPORTVERSION = unchecked((int)0x88980415);

        /// <summary>
        /// UCEERR_TRANSPORTUNAVAILABLE
        /// </summary>
        public const int UCEERR_TRANSPORTUNAVAILABLE = unchecked((int)0x88980416);

        /// <summary>
        /// UCEERR_FEEDBACK_UNSUPPORTED
        /// </summary>
        public const int UCEERR_FEEDBACK_UNSUPPORTED = unchecked((int)0x88980417);

        /// <summary>
        /// UCEERR_COMMANDTRANSPORTDENIED
        /// </summary>
        public const int UCEERR_COMMANDTRANSPORTDENIED = unchecked((int)0x88980418);

        /// <summary>
        /// UCEERR_GRAPHICSSTREAMUNAVAILABLE
        /// </summary>
        public const int UCEERR_GRAPHICSSTREAMUNAVAILABLE = unchecked((int)0x88980419);

        /// <summary>
        /// UCEERR_GRAPHICSSTREAMALREADYOPEN
        /// </summary>
        public const int UCEERR_GRAPHICSSTREAMALREADYOPEN = unchecked((int)0x88980420);

        /// <summary>
        /// UCEERR_TRANSPORTDISCONNECTED
        /// </summary>
        public const int UCEERR_TRANSPORTDISCONNECTED = unchecked((int)0x88980421);

        /// <summary>
        /// UCEERR_TRANSPORTOVERLOADED
        /// </summary>
        public const int UCEERR_TRANSPORTOVERLOADED = unchecked((int)0x88980422);

        /// <summary>
        /// UCEERR_PARTITION_ZOMBIED
        /// </summary>
        public const int UCEERR_PARTITION_ZOMBIED = unchecked((int)0x88980423);

        // MIL AV Specific errors
        /// <summary>
        /// MILAVERR_NOCLOCK
        /// </summary>
        public const int MILAVERR_NOCLOCK = unchecked((int)0x88980500);

        /// <summary>
        /// MILAVERR_NOMEDIATYPE
        /// </summary>
        public const int MILAVERR_NOMEDIATYPE = unchecked((int)0x88980501);

        /// <summary>
        /// MILAVERR_NOVIDEOMIXER
        /// </summary>
        public const int MILAVERR_NOVIDEOMIXER = unchecked((int)0x88980502);

        /// <summary>
        /// MILAVERR_NOVIDEOPRESENTER
        /// </summary>
        public const int MILAVERR_NOVIDEOPRESENTER = unchecked((int)0x88980503);

        /// <summary>
        /// MILAVERR_NOREADYFRAMES
        /// </summary>
        public const int MILAVERR_NOREADYFRAMES = unchecked((int)0x88980504);

        /// <summary>
        /// MILAVERR_MODULENOTLOADED
        /// </summary>
        public const int MILAVERR_MODULENOTLOADED = unchecked((int)0x88980505);

        /// <summary>
        /// MILAVERR_WMPFACTORYNOTREGISTERED
        /// </summary>
        public const int MILAVERR_WMPFACTORYNOTREGISTERED = unchecked((int)0x88980506);

        /// <summary>
        /// MILAVERR_INVALIDWMPVERSION
        /// </summary>
        public const int MILAVERR_INVALIDWMPVERSION = unchecked((int)0x88980507);

        /// <summary>
        /// MILAVERR_INSUFFICIENTVIDEORESOURCES
        /// </summary>
        public const int MILAVERR_INSUFFICIENTVIDEORESOURCES = unchecked((int)0x88980508);

        /// <summary>
        /// MILAVERR_VIDEOACCELERATIONNOTAVAILABLE
        /// </summary>
        public const int MILAVERR_VIDEOACCELERATIONNOTAVAILABLE = unchecked((int)0x88980509);

        /// <summary>
        /// MILAVERR_REQUESTEDTEXTURETOOBIG
        /// </summary>
        public const int MILAVERR_REQUESTEDTEXTURETOOBIG = unchecked((int)0x8898050A);

        /// <summary>
        /// MILAVERR_SEEKFAILED
        /// </summary>
        public const int MILAVERR_SEEKFAILED = unchecked((int)0x8898050B);

        /// <summary>
        /// MILAVERR_UNEXPECTEDWMPFAILURE
        /// </summary>
        public const int MILAVERR_UNEXPECTEDWMPFAILURE = unchecked((int)0x8898050C);

        /// <summary>
        /// MILAVERR_MEDIAPLAYERCLOSED
        /// </summary>
        public const int MILAVERR_MEDIAPLAYERCLOSED = unchecked((int)0x8898050D);

        /// <summary>
        /// MILAVERR_UNKNOWNHARDWAREERROR
        /// </summary>
        public const int MILAVERR_UNKNOWNHARDWAREERROR = unchecked((int)0x8898050E);

        // MIL Bitmap Effet errors
        /// <summary>
        /// MILEFFECTSERR_UNKNOWNPROPERTY
        /// </summary>
        public const int MILEFFECTSERR_UNKNOWNPROPERTY = unchecked((int)0x8898060E);

        /// <summary>
        /// MILEFFECTSERR_EFFECTNOTPARTOFGROUP
        /// </summary>
        public const int MILEFFECTSERR_EFFECTNOTPARTOFGROUP = unchecked((int)0x8898060F);

        /// <summary>
        /// MILEFFECTSERR_NOINPUTSOURCEATTACHED
        /// </summary>
        public const int MILEFFECTSERR_NOINPUTSOURCEATTACHED = unchecked((int)0x88980610);

        /// <summary>
        /// MILEFFECTSERR_CONNECTORNOTCONNECTED
        /// </summary>
        public const int MILEFFECTSERR_CONNECTORNOTCONNECTED = unchecked((int)0x88980611);

        /// <summary>
        /// MILEFFECTSERR_CONNECTORNOTASSOCIATEDWITHEFFECT
        /// </summary>
        public const int MILEFFECTSERR_CONNECTORNOTASSOCIATEDWITHEFFECT = unchecked((int)0x88980612);

        /// <summary>
        /// MILEFFECTSERR_RESERVED
        /// </summary>
        public const int MILEFFECTSERR_RESERVED = unchecked((int)0x88980613);

        /// <summary>
        /// MILEFFECTSERR_CYCLEDETECTED
        /// </summary>
        public const int MILEFFECTSERR_CYCLEDETECTED = unchecked((int)0x88980614);

        /// <summary>
        /// MILEFFECTSERR_EFFECTINMORETHANONEGRAPH
        /// </summary>
        public const int MILEFFECTSERR_EFFECTINMORETHANONEGRAPH = unchecked((int)0x88980615);

        /// <summary>
        /// MILEFFECTSERR_EFFECTALREADYINAGRAPH
        /// </summary>
        public const int MILEFFECTSERR_EFFECTALREADYINAGRAPH = unchecked((int)0x88980616);

        /// <summary>
        /// MILEFFECTSERR_EFFECTHASNOCHILDREN
        /// </summary>
        public const int MILEFFECTSERR_EFFECTHASNOCHILDREN = unchecked((int)0x88980617);

        /// <summary>
        /// MILEFFECTSERR_ALREADYATTACHEDTOLISTENER
        /// </summary>
        public const int MILEFFECTSERR_ALREADYATTACHEDTOLISTENER = unchecked((int)0x88980618);

        /// <summary>
        /// MILEFFECTSERR_NOTAFFINETRANSFORM
        /// </summary>
        public const int MILEFFECTSERR_NOTAFFINETRANSFORM = unchecked((int)0x88980619);

        /// <summary>
        /// MILEFFECTSERR_EMPTYBOUNDS
        /// </summary>
        public const int MILEFFECTSERR_EMPTYBOUNDS = unchecked((int)0x8898061A);

        /// <summary>
        /// MILEFFECTSERR_OUTPUTSIZETOOLARGE
        /// </summary>
        public const int MILEFFECTSERR_OUTPUTSIZETOOLARGE = unchecked((int)0x8898061B);

        // DWM specific errors
        /// <summary>
        /// DWMERR_STATE_TRANSITION_FAILED
        /// </summary>
        public const int DWMERR_STATE_TRANSITION_FAILED = unchecked((int)0x88980700);

        /// <summary>
        /// DWMERR_THEME_FAILED
        /// </summary>
        public const int DWMERR_THEME_FAILED = unchecked((int)0x88980701);

        /// <summary>
        /// DWMERR_CATASTROPHIC_FAILURE
        /// </summary>
        public const int DWMERR_CATASTROPHIC_FAILURE = unchecked((int)0x88980702);


        //
        // DirectComposition
        //

        /// <summary>
        /// DCOMPOSITION_ERROR_WINDOW_ALREADY_COMPOSED
        /// </summary>
        public const int DCOMPOSITION_ERROR_WINDOW_ALREADY_COMPOSED = unchecked((int)0x88980800);

        /// <summary>
        /// DCOMPOSITION_ERROR_SURFACE_BEING_RENDERED
        /// </summary>
        public const int DCOMPOSITION_ERROR_SURFACE_BEING_RENDERED = unchecked((int)0x88980801);

        /// <summary>
        /// DCOMPOSITION_ERROR_SURFACE_NOT_BEING_RENDERED
        /// </summary>
        public const int DCOMPOSITION_ERROR_SURFACE_NOT_BEING_RENDERED = unchecked((int)0x88980802);


        //
        // OnlineId
        //

        /// <summary>
        /// Authentication target is invalid or not configured correctly.
        /// </summary>
        public const int ONL_E_INVALID_AUTHENTICATION_TARGET = unchecked((int)0x80860001);

        /// <summary>
        /// Your application cannot get the Online Id properties due to the Terms of Use accepted by the user.
        /// </summary>
        public const int ONL_E_ACCESS_DENIED_BY_TOU = unchecked((int)0x80860002);

        /// <summary>
        /// The application requesting authentication tokens is either disabled or incorrectly configured.
        /// </summary>
        public const int ONL_E_INVALID_APPLICATION = unchecked((int)0x80860003);

        /// <summary>
        /// Online Id password must be updated before signin.
        /// </summary>
        public const int ONL_E_PASSWORD_UPDATE_REQUIRED = unchecked((int)0x80860004);

        /// <summary>
        /// Online Id account properties must be updated before signin.
        /// </summary>
        public const int ONL_E_ACCOUNT_UPDATE_REQUIRED = unchecked((int)0x80860005);

        /// <summary>
        /// To help protect your Online Id account you must signin again.
        /// </summary>
        public const int ONL_E_FORCESIGNIN = unchecked((int)0x80860006);

        /// <summary>
        /// Online Id account was locked because there have been too many attempts to sign in.
        /// </summary>
        public const int ONL_E_ACCOUNT_LOCKED = unchecked((int)0x80860007);

        /// <summary>
        /// Online Id account requires parental consent before proceeding.
        /// </summary>
        public const int ONL_E_PARENTAL_CONSENT_REQUIRED = unchecked((int)0x80860008);

        /// <summary>
        /// Online Id signin name is not yet verified. Email verification is required before signin.
        /// </summary>
        public const int ONL_E_EMAIL_VERIFICATION_REQUIRED = unchecked((int)0x80860009);

        /// <summary>
        /// We have noticed some unusual activity in your Online Id account. Your action is needed to make sure no one else is using your account.
        /// </summary>
        public const int ONL_E_ACCOUNT_SUSPENDED_COMPROIMISE = unchecked((int)0x8086000A);

        /// <summary>
        /// We detected some suspicious activity with your Online Id account. To help protect you, we've temporarily blocked your account.
        /// </summary>
        public const int ONL_E_ACCOUNT_SUSPENDED_ABUSE = unchecked((int)0x8086000B);

        /// <summary>
        /// User interaction is required for authentication.
        /// </summary>
        public const int ONL_E_ACTION_REQUIRED = unchecked((int)0x8086000C);

        /// <summary>
        /// User has reached the maximum device associations per user limit.
        /// </summary>
        public const int ONL_CONNECTION_COUNT_LIMIT = unchecked((int)0x8086000D);

        /// <summary>
        /// Cannot sign out from the application since the user account is connected.
        /// </summary>
        public const int ONL_E_CONNECTED_ACCOUNT_CAN_NOT_SIGNOUT = unchecked((int)0x8086000E);

        /// <summary>
        /// User authentication is required for this operation.
        /// </summary>
        public const int ONL_E_USER_AUTHENTICATION_REQUIRED = unchecked((int)0x8086000F);

        /// <summary>
        /// We want to make sure this is you. User interaction is required for authentication.
        /// </summary>
        public const int ONL_E_REQUEST_THROTTLED = unchecked((int)0x80860010);


        //
        // Facility Shell Error codes
        //

        /// <summary>
        /// The maximum number of items for the access list has been reached. An item must be removed before another item is added.
        /// </summary>
        public const int FA_E_MAX_PERSISTED_ITEMS_REACHED = unchecked((int)0x80270220);

        /// <summary>
        /// Cannot access Homegroup. Homegroup may not be set up or may have encountered an error.
        /// </summary>
        public const int FA_E_HOMEGROUP_NOT_AVAILABLE = unchecked((int)0x80270222);

        /// <summary>
        /// This app can't start because the screen resolution is below 1024x768. Choose a higher screen resolution and then try again.
        /// </summary>
        public const int E_MONITOR_RESOLUTION_TOO_LOW = unchecked((int)0x80270250);

        /// <summary>
        /// This app can't be activated from an elevated context.
        /// </summary>
        public const int E_ELEVATED_ACTIVATION_NOT_SUPPORTED = unchecked((int)0x80270251);

        /// <summary>
        /// This app can't be activated when UAC is disabled.
        /// </summary>
        public const int E_UAC_DISABLED = unchecked((int)0x80270252);

        /// <summary>
        /// This app can't be activated by the Built-in Administrator.
        /// </summary>
        public const int E_FULL_ADMIN_NOT_SUPPORTED = unchecked((int)0x80270253);

        /// <summary>
        /// This app does not support the contract specified or is not installed.
        /// </summary>
        public const int E_APPLICATION_NOT_REGISTERED = unchecked((int)0x80270254);

        /// <summary>
        /// This app has mulitple extensions registered to support the specified contract. Activation by AppUserModelId is ambiguous.
        /// </summary>
        public const int E_MULTIPLE_EXTENSIONS_FOR_APPLICATION = unchecked((int)0x80270255);

        /// <summary>
        /// This app's package family has more than one package installed. This is not supported.
        /// </summary>
        public const int E_MULTIPLE_PACKAGES_FOR_FAMILY = unchecked((int)0x80270256);

        /// <summary>
        /// The app manager is required to activate applications, but is not running.
        /// </summary>
        public const int E_APPLICATION_MANAGER_NOT_RUNNING = unchecked((int)0x80270257);

        /// <summary>
        /// The Store was launched instead of the specified app because the app's package was in an invalid state.
        /// </summary>
        public const int S_STORE_LAUNCHED_FOR_REMEDIATION = 0x00270258;

        /// <summary>
        /// This app failed to launch, but the error was handled with a dialog.
        /// </summary>
        public const int S_APPLICATION_ACTIVATION_ERROR_HANDLED_BY_DIALOG = 0x00270259;

        /// <summary>
        /// The app didn't start in the required time.
        /// </summary>
        public const int E_APPLICATION_ACTIVATION_TIMED_OUT = unchecked((int)0x8027025A);

        /// <summary>
        /// The app didn't start.
        /// </summary>
        public const int E_APPLICATION_ACTIVATION_EXEC_FAILURE = unchecked((int)0x8027025B);

        /// <summary>
        /// This app failed to launch because of an issue with its license. Please try again in a moment.
        /// </summary>
        public const int E_APPLICATION_TEMPORARY_LICENSE_ERROR = unchecked((int)0x8027025C);

        /// <summary>
        /// This app failed to launch because its trial license has expired.
        /// </summary>
        public const int E_APPLICATION_TRIAL_LICENSE_EXPIRED = unchecked((int)0x8027025D);

        /// <summary>
        /// Please choose a folder on a drive that's formatted with the NTFS file system.
        /// </summary>
        public const int E_SKYDRIVE_ROOT_TARGET_FILE_SYSTEM_NOT_SUPPORTED = unchecked((int)0x80270260);

        /// <summary>
        /// This location is already being used. Please choose a different location.
        /// </summary>
        public const int E_SKYDRIVE_ROOT_TARGET_OVERLAP = unchecked((int)0x80270261);

        /// <summary>
        /// This location cannot be indexed. Please choose a different location.
        /// </summary>
        public const int E_SKYDRIVE_ROOT_TARGET_CANNOT_INDEX = unchecked((int)0x80270262);

        /// <summary>
        /// Sorry, the action couldn't be completed because the file hasn't finished uploading. Try again later.
        /// </summary>
        public const int E_SKYDRIVE_FILE_NOT_UPLOADED = unchecked((int)0x80270263);

        /// <summary>
        /// Sorry, the action couldn't be completed.
        /// </summary>
        public const int E_SKYDRIVE_UPDATE_AVAILABILITY_FAIL = unchecked((int)0x80270264);

        /// <summary>
        /// This content can only be moved to a folder. To move the content to this drive, please choose or create a folder.
        /// </summary>
        public const int E_SKYDRIVE_ROOT_TARGET_VOLUME_ROOT_NOT_SUPPORTED = unchecked((int)0x80270265);


        // Sync Engine File Error Codes

        /// <summary>
        /// The file size is larger than supported by the sync engine.
        /// </summary>
        public const int E_SYNCENGINE_FILE_SIZE_OVER_LIMIT = unchecked((int)0x8802B001);

        /// <summary>
        /// The file cannot be uploaded because it doesn't fit in the user's available service provided storage space.
        /// </summary>
        public const int E_SYNCENGINE_FILE_SIZE_EXCEEDS_REMAINING_QUOTA = unchecked((int)0x8802B002);

        /// <summary>
        /// The file name contains invalid characters.
        /// </summary>
        public const int E_SYNCENGINE_UNSUPPORTED_FILE_NAME = unchecked((int)0x8802B003);

        /// <summary>
        /// The maximum file count has been reached for this folder in the sync engine.
        /// </summary>
        public const int E_SYNCENGINE_FOLDER_ITEM_COUNT_LIMIT_EXCEEDED = unchecked((int)0x8802B004);

        /// <summary>
        /// The file sync has been delegated to another program and has run into an issue.
        /// </summary>
        public const int E_SYNCENGINE_FILE_SYNC_PARTNER_ERROR = unchecked((int)0x8802B005);

        /// <summary>
        /// Sync has been delayed due to a throttling request from the service.
        /// </summary>
        public const int E_SYNCENGINE_SYNC_PAUSED_BY_SERVICE = unchecked((int)0x8802B006);


        // Sync Engine Stream Resolver Errors

        /// <summary>
        /// We can't seem to find that file. Please try again later.
        /// </summary>
        public const int E_SYNCENGINE_FILE_IDENTIFIER_UNKNOWN = unchecked((int)0x8802C002);

        /// <summary>
        /// The account you're signed in with doesn't have permission to open this file.
        /// </summary>
        public const int E_SYNCENGINE_SERVICE_AUTHENTICATION_FAILED = unchecked((int)0x8802C003);

        /// <summary>
        /// There was a problem connecting to the service. Please try again later.
        /// </summary>
        public const int E_SYNCENGINE_UNKNOWN_SERVICE_ERROR = unchecked((int)0x8802C004);

        /// <summary>
        /// Sorry, there was a problem downloading the file.
        /// </summary>
        public const int E_SYNCENGINE_SERVICE_RETURNED_UNEXPECTED_SIZE = unchecked((int)0x8802C005);

        /// <summary>
        /// We're having trouble downloading the file right now. Please try again later.
        /// </summary>
        public const int E_SYNCENGINE_REQUEST_BLOCKED_BY_SERVICE = unchecked((int)0x8802C006);

        /// <summary>
        /// We're having trouble downloading the file right now. Please try again later.
        /// </summary>
        public const int E_SYNCENGINE_REQUEST_BLOCKED_DUE_TO_CLIENT_ERROR = unchecked((int)0x8802C007);


        // Sync Engine Global Errors

        /// <summary>
        /// The sync engine does not have permissions to access a local folder under the sync root.
        /// </summary>
        public const int E_SYNCENGINE_FOLDER_INACCESSIBLE = unchecked((int)0x8802D001);

        /// <summary>
        /// The folder name contains invalid characters.
        /// </summary>
        public const int E_SYNCENGINE_UNSUPPORTED_FOLDER_NAME = unchecked((int)0x8802D002);

        /// <summary>
        /// The sync engine is not allowed to run in your current market.
        /// </summary>
        public const int E_SYNCENGINE_UNSUPPORTED_MARKET = unchecked((int)0x8802D003);

        /// <summary>
        /// All files and folders can't be uploaded because a path of a file or folder is too long.
        /// </summary>
        public const int E_SYNCENGINE_PATH_LENGTH_LIMIT_EXCEEDED = unchecked((int)0x8802D004);

        /// <summary>
        /// All file and folders cannot be synchronized because a path of a file or folder would exceed the local path limit.
        /// </summary>
        public const int E_SYNCENGINE_REMOTE_PATH_LENGTH_LIMIT_EXCEEDED = unchecked((int)0x8802D005);

        /// <summary>
        /// Updates are needed in order to use the sync engine.
        /// </summary>
        public const int E_SYNCENGINE_CLIENT_UPDATE_NEEDED = unchecked((int)0x8802D006);

        /// <summary>
        /// The sync engine needs to authenticate with a proxy server.
        /// </summary>
        public const int E_SYNCENGINE_PROXY_AUTHENTICATION_REQUIRED = unchecked((int)0x8802D007);

        /// <summary>
        /// There was a problem setting up the storage services for the account.
        /// </summary>
        public const int E_SYNCENGINE_STORAGE_SERVICE_PROVISIONING_FAILED = unchecked((int)0x8802D008);

        /// <summary>
        /// Files can't be uploaded because there's an unsupported reparse point.
        /// </summary>
        public const int E_SYNCENGINE_UNSUPPORTED_REPARSE_POINT = unchecked((int)0x8802D009);

        /// <summary>
        /// The service has blocked your account from accessing the storage service.
        /// </summary>
        public const int E_SYNCENGINE_STORAGE_SERVICE_BLOCKED = unchecked((int)0x8802D00A);

        /// <summary>
        /// The action can't be performed right now because this folder is being moved. Please try again later.
        /// </summary>
        public const int E_SYNCENGINE_FOLDER_IN_REDIRECTION = unchecked((int)0x8802D00B);


        //
        // EAS
        //

        /// <summary>
        /// Windows cannot evaluate this EAS policy since this is not managed by the operating system.
        /// </summary>
        public const int EAS_E_POLICY_NOT_MANAGED_BY_OS = unchecked((int)0x80550001);

        /// <summary>
        /// The system can be made compliant to this EAS policy if certain actions are performed by the user.
        /// </summary>
        public const int EAS_E_POLICY_COMPLIANT_WITH_ACTIONS = unchecked((int)0x80550002);

        /// <summary>
        /// The EAS policy being evaluated cannot be enforced by the system.
        /// </summary>
        public const int EAS_E_REQUESTED_POLICY_NOT_ENFORCEABLE = unchecked((int)0x80550003);

        /// <summary>
        /// EAS password policies for the user cannot be evaluated as the user has a blank password.
        /// </summary>
        public const int EAS_E_CURRENT_USER_HAS_BLANK_PASSWORD = unchecked((int)0x80550004);

        /// <summary>
        /// EAS password expiration policy cannot be satisfied as the password expiration interval is less than the minimum password interval of the system.
        /// </summary>
        public const int EAS_E_REQUESTED_POLICY_PASSWORD_EXPIRATION_INCOMPATIBLE = unchecked((int)0x80550005);

        /// <summary>
        /// The user is not allowed to change her password.
        /// </summary>
        public const int EAS_E_USER_CANNOT_CHANGE_PASSWORD = unchecked((int)0x80550006);

        /// <summary>
        /// EAS password policies cannot be evaluated as one or more admins have blank passwords.
        /// </summary>
        public const int EAS_E_ADMINS_HAVE_BLANK_PASSWORD = unchecked((int)0x80550007);

        /// <summary>
        /// One or more admins are not allowed to change their password.
        /// </summary>
        public const int EAS_E_ADMINS_CANNOT_CHANGE_PASSWORD = unchecked((int)0x80550008);

        /// <summary>
        /// There are other standard users present who are not allowed to change their password.
        /// </summary>
        public const int EAS_E_LOCAL_CONTROLLED_USERS_CANNOT_CHANGE_PASSWORD = unchecked((int)0x80550009);

        /// <summary>
        /// The EAS password policy cannot be enforced by the connected account provider of at least one administrator.
        /// </summary>
        public const int EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CONNECTED_ADMINS = unchecked((int)0x8055000A);

        /// <summary>
        /// There is at least one administrator whose connected account password needs to be changed for EAS password policy compliance.
        /// </summary>
        public const int EAS_E_CONNECTED_ADMINS_NEED_TO_CHANGE_PASSWORD = unchecked((int)0x8055000B);

        /// <summary>
        /// The EAS password policy cannot be enforced by the connected account provider of the current user.
        /// </summary>
        public const int EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CURRENT_CONNECTED_USER = unchecked((int)0x8055000C);

        /// <summary>
        /// The connected account password of the current user needs to be changed for EAS password policy compliance.
        /// </summary>
        public const int EAS_E_CURRENT_CONNECTED_USER_NEED_TO_CHANGE_PASSWORD = unchecked((int)0x8055000D);

        /// <summary>
        /// Unsupported format.
        /// </summary>
        public const int WEB_E_UNSUPPORTED_FORMAT = unchecked((int)0x83750001);

        /// <summary>
        /// Invalid XML.
        /// </summary>
        public const int WEB_E_INVALID_XML = unchecked((int)0x83750002);

        /// <summary>
        /// Missing required element.
        /// </summary>
        public const int WEB_E_MISSING_REQUIRED_ELEMENT = unchecked((int)0x83750003);

        /// <summary>
        /// Missing required attribute.
        /// </summary>
        public const int WEB_E_MISSING_REQUIRED_ATTRIBUTE = unchecked((int)0x83750004);

        /// <summary>
        /// Unexpected content.
        /// </summary>
        public const int WEB_E_UNEXPECTED_CONTENT = unchecked((int)0x83750005);

        /// <summary>
        /// Resource too large.
        /// </summary>
        public const int WEB_E_RESOURCE_TOO_LARGE = unchecked((int)0x83750006);

        /// <summary>
        /// Invalid JSON string.
        /// </summary>
        public const int WEB_E_INVALID_JSON_STRING = unchecked((int)0x83750007);

        /// <summary>
        /// Invalid JSON number.
        /// </summary>
        public const int WEB_E_INVALID_JSON_NUMBER = unchecked((int)0x83750008);

        /// <summary>
        /// JSON value not found.
        /// </summary>
        public const int WEB_E_JSON_VALUE_NOT_FOUND = unchecked((int)0x83750009);

        /// <summary>
        /// Unexpected HTTP status code.
        /// </summary>
        public const int HTTP_E_STATUS_UNEXPECTED = unchecked((int)0x80190001);

        /// <summary>
        /// Unexpected redirection status code (3xx).
        /// </summary>
        public const int HTTP_E_STATUS_UNEXPECTED_REDIRECTION = unchecked((int)0x80190003);

        /// <summary>
        /// Unexpected client error status code (4xx).
        /// </summary>
        public const int HTTP_E_STATUS_UNEXPECTED_CLIENT_ERROR = unchecked((int)0x80190004);

        /// <summary>
        /// Unexpected server error status code (5xx).
        /// </summary>
        public const int HTTP_E_STATUS_UNEXPECTED_SERVER_ERROR = unchecked((int)0x80190005);

        /// <summary>
        /// Multiple choices (300).
        /// </summary>
        public const int HTTP_E_STATUS_AMBIGUOUS = unchecked((int)0x8019012C);

        /// <summary>
        /// Moved permanently (301).
        /// </summary>
        public const int HTTP_E_STATUS_MOVED = unchecked((int)0x8019012D);

        /// <summary>
        /// Found (302).
        /// </summary>
        public const int HTTP_E_STATUS_REDIRECT = unchecked((int)0x8019012E);

        /// <summary>
        /// See Other (303).
        /// </summary>
        public const int HTTP_E_STATUS_REDIRECT_METHOD = unchecked((int)0x8019012F);

        /// <summary>
        /// Not modified (304).
        /// </summary>
        public const int HTTP_E_STATUS_NOT_MODIFIED = unchecked((int)0x80190130);

        /// <summary>
        /// Use proxy (305).
        /// </summary>
        public const int HTTP_E_STATUS_USE_PROXY = unchecked((int)0x80190131);

        /// <summary>
        /// Temporary redirect (307).
        /// </summary>
        public const int HTTP_E_STATUS_REDIRECT_KEEP_VERB = unchecked((int)0x80190133);

        /// <summary>
        /// Bad request (400).
        /// </summary>
        public const int HTTP_E_STATUS_BAD_REQUEST = unchecked((int)0x80190190);

        /// <summary>
        /// Unauthorized (401).
        /// </summary>
        public const int HTTP_E_STATUS_DENIED = unchecked((int)0x80190191);

        /// <summary>
        /// Payment required (402).
        /// </summary>
        public const int HTTP_E_STATUS_PAYMENT_REQ = unchecked((int)0x80190192);

        /// <summary>
        /// Forbidden (403).
        /// </summary>
        public const int HTTP_E_STATUS_FORBIDDEN = unchecked((int)0x80190193);

        /// <summary>
        /// Not found (404).
        /// </summary>
        public const int HTTP_E_STATUS_NOT_FOUND = unchecked((int)0x80190194);

        /// <summary>
        /// Method not allowed (405).
        /// </summary>
        public const int HTTP_E_STATUS_BAD_METHOD = unchecked((int)0x80190195);

        /// <summary>
        /// Not acceptable (406).
        /// </summary>
        public const int HTTP_E_STATUS_NONE_ACCEPTABLE = unchecked((int)0x80190196);

        /// <summary>
        /// Proxy authentication required (407).
        /// </summary>
        public const int HTTP_E_STATUS_PROXY_AUTH_REQ = unchecked((int)0x80190197);

        /// <summary>
        /// Request timeout (408).
        /// </summary>
        public const int HTTP_E_STATUS_REQUEST_TIMEOUT = unchecked((int)0x80190198);

        /// <summary>
        /// Conflict (409).
        /// </summary>
        public const int HTTP_E_STATUS_CONFLICT = unchecked((int)0x80190199);

        /// <summary>
        /// Gone (410).
        /// </summary>
        public const int HTTP_E_STATUS_GONE = unchecked((int)0x8019019A);

        /// <summary>
        /// Length required (411).
        /// </summary>
        public const int HTTP_E_STATUS_LENGTH_REQUIRED = unchecked((int)0x8019019B);

        /// <summary>
        /// Precondition failed (412).
        /// </summary>
        public const int HTTP_E_STATUS_PRECOND_FAILED = unchecked((int)0x8019019C);

        /// <summary>
        /// Request entity too large (413).
        /// </summary>
        public const int HTTP_E_STATUS_REQUEST_TOO_LARGE = unchecked((int)0x8019019D);

        /// <summary>
        /// Request-URI too long (414).
        /// </summary>
        public const int HTTP_E_STATUS_URI_TOO_LONG = unchecked((int)0x8019019E);

        /// <summary>
        /// Unsupported media type (415).
        /// </summary>
        public const int HTTP_E_STATUS_UNSUPPORTED_MEDIA = unchecked((int)0x8019019F);

        /// <summary>
        /// Requested range not satisfiable (416).
        /// </summary>
        public const int HTTP_E_STATUS_RANGE_NOT_SATISFIABLE = unchecked((int)0x801901A0);

        /// <summary>
        /// Expectation failed (417).
        /// </summary>
        public const int HTTP_E_STATUS_EXPECTATION_FAILED = unchecked((int)0x801901A1);

        /// <summary>
        /// Internal server error (500).
        /// </summary>
        public const int HTTP_E_STATUS_SERVER_ERROR = unchecked((int)0x801901F4);

        /// <summary>
        /// Not implemented (501).
        /// </summary>
        public const int HTTP_E_STATUS_NOT_SUPPORTED = unchecked((int)0x801901F5);

        /// <summary>
        /// Bad gateway (502).
        /// </summary>
        public const int HTTP_E_STATUS_BAD_GATEWAY = unchecked((int)0x801901F6);

        /// <summary>
        /// Service unavailable (503).
        /// </summary>
        public const int HTTP_E_STATUS_SERVICE_UNAVAIL = unchecked((int)0x801901F7);

        /// <summary>
        /// Gateway timeout (504).
        /// </summary>
        public const int HTTP_E_STATUS_GATEWAY_TIMEOUT = unchecked((int)0x801901F8);

        /// <summary>
        /// Version not supported (505).
        /// </summary>
        public const int HTTP_E_STATUS_VERSION_NOT_SUP = unchecked((int)0x801901F9);


        //
        // WebSocket
        //

        /// <summary>
        /// Invalid operation performed by the protocol.
        /// </summary>
        public const int E_INVALID_PROTOCOL_OPERATION = unchecked((int)0x83760001);

        /// <summary>
        /// Invalid data format for the specific protocol operation.
        /// </summary>
        public const int E_INVALID_PROTOCOL_FORMAT = unchecked((int)0x83760002);

        /// <summary>
        /// Protocol extensions are not supported.
        /// </summary>
        public const int E_PROTOCOL_EXTENSIONS_NOT_SUPPORTED = unchecked((int)0x83760003);

        /// <summary>
        /// Subrotocol is not supported.
        /// </summary>
        public const int E_SUBPROTOCOL_NOT_SUPPORTED = unchecked((int)0x83760004);

        /// <summary>
        /// Incorrect protocol version.
        /// </summary>
        public const int E_PROTOCOL_VERSION_NOT_SUPPORTED = unchecked((int)0x83760005);


        //
        // Touch and Pen Input Platform Error Codes
        //

        /// <summary>
        /// Input data cannot be processed in the non-chronological order.
        /// </summary>
        public const int INPUT_E_OUT_OF_ORDER = unchecked((int)0x80400000);

        /// <summary>
        /// Requested operation cannot be performed inside the callback or event handler.
        /// </summary>
        public const int INPUT_E_REENTRANCY = unchecked((int)0x80400001);

        /// <summary>
        /// Input cannot be processed because there is ongoing interaction with another pointer type.
        /// </summary>
        public const int INPUT_E_MULTIMODAL = unchecked((int)0x80400002);

        /// <summary>
        /// One or more fields in the input packet are invalid.
        /// </summary>
        public const int INPUT_E_PACKET = unchecked((int)0x80400003);

        /// <summary>
        /// Packets in the frame are inconsistent. Either pointer ids are not unique or there is a discrepancy in timestamps, frame ids, pointer types or source devices.
        /// </summary>
        public const int INPUT_E_FRAME = unchecked((int)0x80400004);

        /// <summary>
        /// The history of frames is inconsistent. Pointer ids, types, source devices don't match, or frame ids are not unique, or timestamps are out of order.
        /// </summary>
        public const int INPUT_E_HISTORY = unchecked((int)0x80400005);

        /// <summary>
        /// Failed to retrieve information about the input device.
        /// </summary>
        public const int INPUT_E_DEVICE_INFO = unchecked((int)0x80400006);

        /// <summary>
        /// Coordinate system transformation failed to transform the data.
        /// </summary>
        public const int INPUT_E_TRANSFORM = unchecked((int)0x80400007);

        /// <summary>
        /// The property is not supported or not reported correctly by the input device.
        /// </summary>
        public const int INPUT_E_DEVICE_PROPERTY = unchecked((int)0x80400008);

        //
        // Internet
        //
        /// <summary>
        /// The URL is invalid.
        /// </summary>
        public const int INET_E_INVALID_URL = unchecked((int)0x800C0002);

        /// <summary>
        /// No Internet session has been established.
        /// </summary>
        public const int INET_E_NO_SESSION = unchecked((int)0x800C0003);

        /// <summary>
        /// Unable to connect to the target server.
        /// </summary>
        public const int INET_E_CANNOT_CONNECT = unchecked((int)0x800C0004);

        /// <summary>
        /// The system cannot locate the resource specified.
        /// </summary>
        public const int INET_E_RESOURCE_NOT_FOUND = unchecked((int)0x800C0005);

        /// <summary>
        /// The system cannot locate the object specified.
        /// </summary>
        public const int INET_E_OBJECT_NOT_FOUND = unchecked((int)0x800C0006);

        /// <summary>
        /// No data is available for the requested resource.
        /// </summary>
        public const int INET_E_DATA_NOT_AVAILABLE = unchecked((int)0x800C0007);

        /// <summary>
        /// The download of the specified resource has failed.
        /// </summary>
        public const int INET_E_DOWNLOAD_FAILURE = unchecked((int)0x800C0008);

        /// <summary>
        /// Authentication is required to access this resource.
        /// </summary>
        public const int INET_E_AUTHENTICATION_REQUIRED = unchecked((int)0x800C0009);

        /// <summary>
        /// The server could not recognize the provided mime type.
        /// </summary>
        public const int INET_E_NO_VALID_MEDIA = unchecked((int)0x800C000A);

        /// <summary>
        /// The operation was timed out.
        /// </summary>
        public const int INET_E_CONNECTION_TIMEOUT = unchecked((int)0x800C000B);

        /// <summary>
        /// The server did not understand the request, or the request was invalid.
        /// </summary>
        public const int INET_E_INVALID_REQUEST = unchecked((int)0x800C000C);

        /// <summary>
        /// The specified protocol is unknown.
        /// </summary>
        public const int INET_E_UNKNOWN_PROTOCOL = unchecked((int)0x800C000D);

        /// <summary>
        /// A security problem occurred.
        /// </summary>
        public const int INET_E_SECURITY_PROBLEM = unchecked((int)0x800C000E);

        /// <summary>
        /// The system could not load the persisted data.
        /// </summary>
        public const int INET_E_CANNOT_LOAD_DATA = unchecked((int)0x800C000F);

        /// <summary>
        /// Unable to instantiate the object.
        /// </summary>
        public const int INET_E_CANNOT_INSTANTIATE_OBJECT = unchecked((int)0x800C0010);

        /// <summary>
        /// Security certificate required to access this resource is invalid.
        /// </summary>
        public const int INET_E_INVALID_CERTIFICATE = unchecked((int)0x800C0019);

        /// <summary>
        /// A redirection problem occurred.
        /// </summary>
        public const int INET_E_REDIRECT_FAILED = unchecked((int)0x800C0014);

        /// <summary>
        /// The requested resource is a directory, not a file.
        /// </summary>
        public const int INET_E_REDIRECT_TO_DIR = unchecked((int)0x800C0015);

        //
        // Debuggers
        //
        /// <summary>
        /// Could not create new process from ARM architecture device.
        /// </summary>
        public const int ERROR_DBG_CREATE_PROCESS_FAILURE_LOCKDOWN = unchecked((int)0x80B00001);

        /// <summary>
        /// Could not attach to the application process from ARM architecture device.
        /// </summary>
        public const int ERROR_DBG_ATTACH_PROCESS_FAILURE_LOCKDOWN = unchecked((int)0x80B00002);

        /// <summary>
        /// Could not connect to dbgsrv server from ARM architecture device.
        /// </summary>
        public const int ERROR_DBG_CONNECT_SERVER_FAILURE_LOCKDOWN = unchecked((int)0x80B00003);

        /// <summary>
        /// Could not start dbgsrv server from ARM architecture device.
        /// </summary>
        public const int ERROR_DBG_START_SERVER_FAILURE_LOCKDOWN = unchecked((int)0x80B00004);

        //
        //Sdbus
        //
        /// <summary>
        /// The operation was preempted by a higher priority operation. It must be resumed later.
        /// </summary>
        public const int ERROR_IO_PREEMPTED = unchecked((int)0x89010001);

        //
        //JScript
        //
        /// <summary>
        /// Function could not execute because it was deleted or garbage collected.
        /// </summary>
        public const int JSCRIPT_E_CANTEXECUTE = unchecked((int)0x89020001);

        //
        //WEP - Windows Encryption Providers
        //
        /// <summary>
        /// One or more fixed volumes are not provisioned with the 3rd party encryption providers to support device encryption. Enable encryption with the 3rd party provider to comply with policy.
        /// </summary>
        public const int WEP_E_NOT_PROVISIONED_ON_ALL_VOLUMES = unchecked((int)0x88010001);

        /// <summary>
        /// This computer is not fully encrypted. There are fixed volumes present which are not supported for encryption.
        /// </summary>
        public const int WEP_E_FIXED_DATA_NOT_SUPPORTED = unchecked((int)0x88010002);

        /// <summary>
        /// This computer does not meet the hardware requirements to support device encryption with the installed 3rd party provider.
        /// </summary>
        public const int WEP_E_HARDWARE_NOT_COMPLIANT = unchecked((int)0x88010003);

        //
        //device lock feature - requires encryption software to use something like a TPM or a secure location to store failed counts of the password in an interactive logon to lock out the device
        //
        /// <summary>
        /// This computer cannot support device encryption because the requisites for the device lock feature are not configured.
        /// </summary>
        public const int WEP_E_LOCK_NOT_CONFIGURED = unchecked((int)0x88010004);

        /// <summary>
        /// Protection is enabled on this volume but is not in the active state.
        /// </summary>
        public const int WEP_E_PROTECTION_SUSPENDED = unchecked((int)0x88010005);

        /// <summary>
        /// The 3rd party provider has been installed, but cannot activate encryption beacuse a license has not been activated.
        /// </summary>
        public const int WEP_E_NO_LICENSE = unchecked((int)0x88010006);

        /// <summary>
        /// The operating system drive is not protected by 3rd party drive encryption.
        /// </summary>
        public const int WEP_E_OS_NOT_PROTECTED = unchecked((int)0x88010007);

        /// <summary>
        /// Unexpected failure was encountered while calling into the 3rd Party drive encryption plugin.
        /// </summary>
        public const int WEP_E_UNEXPECTED_FAIL = unchecked((int)0x88010008);

        /// <summary>
        /// The input buffer size for the lockout metadata used by the 3rd party drive encryption is too large.
        /// </summary>
        public const int WEP_E_BUFFER_TOO_LARGE = unchecked((int)0x88010009);

        //
        // Shared VHDX status codes (svhdxflt.sys)
        //
        /// <summary>
        /// The proper error code with sense data was stored on server side.
        /// </summary>
        public const int ERROR_SVHDX_ERROR_STORED = unchecked((int)0xC05C0000);

        /// <summary>
        /// The requested error data is not available on the server.
        /// </summary>
        public const int ERROR_SVHDX_ERROR_NOT_AVAILABLE = unchecked((int)0xC05CFF00);

        /// <summary>
        /// Unit Attention data is available for the initiator to query.
        /// </summary>
        public const int ERROR_SVHDX_UNIT_ATTENTION_AVAILABLE = unchecked((int)0xC05CFF01);

        /// <summary>
        /// The data capacity of the device has changed, resulting in a Unit Attention condition.
        /// </summary>
        public const int ERROR_SVHDX_UNIT_ATTENTION_CAPACITY_DATA_CHANGED = unchecked((int)0xC05CFF02);

        /// <summary>
        /// A previous operation resulted in this initiator's reservations being preempted, resulting in a Unit Attention condition.
        /// </summary>
        public const int ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_PREEMPTED = unchecked((int)0xC05CFF03);

        /// <summary>
        /// A previous operation resulted in this initiator's reservations being released, resulting in a Unit Attention condition.
        /// </summary>
        public const int ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_RELEASED = unchecked((int)0xC05CFF04);

        /// <summary>
        /// A previous operation resulted in this initiator's registrations being preempted, resulting in a Unit Attention condition.
        /// </summary>
        public const int ERROR_SVHDX_UNIT_ATTENTION_REGISTRATIONS_PREEMPTED = unchecked((int)0xC05CFF05);

        /// <summary>
        /// The data storage format of the device has changed, resulting in a Unit Attention condition.
        /// </summary>
        public const int ERROR_SVHDX_UNIT_ATTENTION_OPERATING_DEFINITION_CHANGED = unchecked((int)0xC05CFF06);

        /// <summary>
        /// The current initiator is not allowed to perform the SCSI command because of a reservation conflict.
        /// </summary>
        public const int ERROR_SVHDX_RESERVATION_CONFLICT = unchecked((int)0xC05CFF07);

        /// <summary>
        /// Multiple virtual machines sharing a virtual hard disk is supported only on Fixed or Dynamic VHDX format virtual hard disks.
        /// </summary>
        public const int ERROR_SVHDX_WRONG_FILE_TYPE = unchecked((int)0xC05CFF08);

        /// <summary>
        /// The server version does not match the requested version.
        /// </summary>
        public const int ERROR_SVHDX_VERSION_MISMATCH = unchecked((int)0xC05CFF09);

        /// <summary>
        /// The requested operation cannot be performed on the virtual disk as it is currently used in shared mode.
        /// </summary>
        public const int ERROR_VHD_SHARED = unchecked((int)0xC05CFF0A);

        /// <summary>
        /// Invalid Shared VHDX open due to lack of initiator ID. Check for related Continuous Availability failures.
        /// </summary>
        public const int ERROR_SVHDX_NO_INITIATOR = unchecked((int)0xC05CFF0B);

        /// <summary>
        /// The requested operation failed due to a missing backing storage file.
        /// </summary>
        public const int ERROR_VHDSET_BACKING_STORAGE_NOT_FOUND = unchecked((int)0xC05CFF0C);

        //
        // SMB status codes
        //
        /// <summary>
        /// Failed to negotiate a preauthentication integrity hash function.
        /// </summary>
        public const int ERROR_SMB_NO_PREAUTH_INTEGRITY_HASH_OVERLAP = unchecked((int)0xC05D0000);

        /// <summary>
        /// The current cluster functional level does not support this SMB dialect.
        /// </summary>
        public const int ERROR_SMB_BAD_CLUSTER_DIALECT = unchecked((int)0xC05D0001);

        //
        // WININET.DLL errors - propagated as HRESULT's using FACILITY=WIN32
        //
        /// <summary>
        /// No more Internet handles can be allocated
        /// </summary>
        public const int WININET_E_OUT_OF_HANDLES = unchecked((int)0x80072EE1);

        /// <summary>
        /// The operation timed out
        /// </summary>
        public const int WININET_E_TIMEOUT = unchecked((int)0x80072EE2);

        /// <summary>
        /// The server returned extended information
        /// </summary>
        public const int WININET_E_EXTENDED_ERROR = unchecked((int)0x80072EE3);

        /// <summary>
        /// An internal error occurred in the Microsoft Internet extensions
        /// </summary>
        public const int WININET_E_INTERNAL_ERROR = unchecked((int)0x80072EE4);

        /// <summary>
        /// The URL is invalid
        /// </summary>
        public const int WININET_E_INVALID_URL = unchecked((int)0x80072EE5);

        /// <summary>
        /// The URL does not use a recognized protocol
        /// </summary>
        public const int WININET_E_UNRECOGNIZED_SCHEME = unchecked((int)0x80072EE6);

        /// <summary>
        /// The server name or address could not be resolved
        /// </summary>
        public const int WININET_E_NAME_NOT_RESOLVED = unchecked((int)0x80072EE7);

        /// <summary>
        /// A protocol with the required capabilities was not found
        /// </summary>
        public const int WININET_E_PROTOCOL_NOT_FOUND = unchecked((int)0x80072EE8);

        /// <summary>
        /// The option is invalid
        /// </summary>
        public const int WININET_E_INVALID_OPTION = unchecked((int)0x80072EE9);

        /// <summary>
        /// The length is incorrect for the option type
        /// </summary>
        public const int WININET_E_BAD_OPTION_LENGTH = unchecked((int)0x80072EEA);

        /// <summary>
        /// The option value cannot be set
        /// </summary>
        public const int WININET_E_OPTION_NOT_SETTABLE = unchecked((int)0x80072EEB);

        /// <summary>
        /// Microsoft Internet Extension support has been shut down
        /// </summary>
        public const int WININET_E_SHUTDOWN = unchecked((int)0x80072EEC);

        /// <summary>
        /// The user name was not allowed
        /// </summary>
        public const int WININET_E_INCORRECT_USER_NAME = unchecked((int)0x80072EED);

        /// <summary>
        /// The password was not allowed
        /// </summary>
        public const int WININET_E_INCORRECT_PASSWORD = unchecked((int)0x80072EEE);

        /// <summary>
        /// The login request was denied
        /// </summary>
        public const int WININET_E_LOGIN_FAILURE = unchecked((int)0x80072EEF);

        /// <summary>
        /// The requested operation is invalid
        /// </summary>
        public const int WININET_E_INVALID_OPERATION = unchecked((int)0x80072EF0);

        /// <summary>
        /// The operation has been canceled
        /// </summary>
        public const int WININET_E_OPERATION_CANCELLED = unchecked((int)0x80072EF1);

        /// <summary>
        /// The supplied handle is the wrong type for the requested operation
        /// </summary>
        public const int WININET_E_INCORRECT_HANDLE_TYPE = unchecked((int)0x80072EF2);

        /// <summary>
        /// The handle is in the wrong state for the requested operation
        /// </summary>
        public const int WININET_E_INCORRECT_HANDLE_STATE = unchecked((int)0x80072EF3);

        /// <summary>
        /// The request cannot be made on a Proxy session
        /// </summary>
        public const int WININET_E_NOT_PROXY_REQUEST = unchecked((int)0x80072EF4);

        /// <summary>
        /// The registry value could not be found
        /// </summary>
        public const int WININET_E_REGISTRY_VALUE_NOT_FOUND = unchecked((int)0x80072EF5);

        /// <summary>
        /// The registry parameter is incorrect
        /// </summary>
        public const int WININET_E_BAD_REGISTRY_PARAMETER = unchecked((int)0x80072EF6);

        /// <summary>
        /// Direct Internet access is not available
        /// </summary>
        public const int WININET_E_NO_DIRECT_ACCESS = unchecked((int)0x80072EF7);

        /// <summary>
        /// No context value was supplied
        /// </summary>
        public const int WININET_E_NO_CONTEXT = unchecked((int)0x80072EF8);

        /// <summary>
        /// No status callback was supplied
        /// </summary>
        public const int WININET_E_NO_CALLBACK = unchecked((int)0x80072EF9);

        /// <summary>
        /// There are outstanding requests
        /// </summary>
        public const int WININET_E_REQUEST_PENDING = unchecked((int)0x80072EFA);

        /// <summary>
        /// The information format is incorrect
        /// </summary>
        public const int WININET_E_INCORRECT_FORMAT = unchecked((int)0x80072EFB);

        /// <summary>
        /// The requested item could not be found
        /// </summary>
        public const int WININET_E_ITEM_NOT_FOUND = unchecked((int)0x80072EFC);

        /// <summary>
        /// A connection with the server could not be established
        /// </summary>
        public const int WININET_E_CANNOT_CONNECT = unchecked((int)0x80072EFD);

        /// <summary>
        /// The connection with the server was terminated abnormally
        /// </summary>
        public const int WININET_E_CONNECTION_ABORTED = unchecked((int)0x80072EFE);

        /// <summary>
        /// The connection with the server was reset
        /// </summary>
        public const int WININET_E_CONNECTION_RESET = unchecked((int)0x80072EFF);

        /// <summary>
        /// The action must be retried
        /// </summary>
        public const int WININET_E_FORCE_RETRY = unchecked((int)0x80072F00);

        /// <summary>
        /// The proxy request is invalid
        /// </summary>
        public const int WININET_E_INVALID_PROXY_REQUEST = unchecked((int)0x80072F01);

        /// <summary>
        /// User interaction is required to complete the operation
        /// </summary>
        public const int WININET_E_NEED_UI = unchecked((int)0x80072F02);

        /// <summary>
        /// The handle already exists
        /// </summary>
        public const int WININET_E_HANDLE_EXISTS = unchecked((int)0x80072F04);

        /// <summary>
        /// The date in the certificate is invalid or has expired
        /// </summary>
        public const int WININET_E_SEC_CERT_DATE_INVALID = unchecked((int)0x80072F05);

        /// <summary>
        /// The host name in the certificate is invalid or does not match
        /// </summary>
        public const int WININET_E_SEC_CERT_CN_INVALID = unchecked((int)0x80072F06);

        /// <summary>
        /// A redirect request will change a non-secure to a secure connection
        /// </summary>
        public const int WININET_E_HTTP_TO_HTTPS_ON_REDIR = unchecked((int)0x80072F07);

        /// <summary>
        /// A redirect request will change a secure to a non-secure connection
        /// </summary>
        public const int WININET_E_HTTPS_TO_HTTP_ON_REDIR = unchecked((int)0x80072F08);

        /// <summary>
        /// Mixed secure and non-secure connections
        /// </summary>
        public const int WININET_E_MIXED_SECURITY = unchecked((int)0x80072F09);

        /// <summary>
        /// Changing to non-secure post
        /// </summary>
        public const int WININET_E_CHG_POST_IS_NON_SECURE = unchecked((int)0x80072F0A);

        /// <summary>
        /// Data is being posted on a non-secure connection
        /// </summary>
        public const int WININET_E_POST_IS_NON_SECURE = unchecked((int)0x80072F0B);

        /// <summary>
        /// A certificate is required to complete client authentication
        /// </summary>
        public const int WININET_E_CLIENT_AUTH_CERT_NEEDED = unchecked((int)0x80072F0C);

        /// <summary>
        /// The certificate authority is invalid or incorrect
        /// </summary>
        public const int WININET_E_INVALID_CA = unchecked((int)0x80072F0D);

        /// <summary>
        /// Client authentication has not been correctly installed
        /// </summary>
        public const int WININET_E_CLIENT_AUTH_NOT_SETUP = unchecked((int)0x80072F0E);

        /// <summary>
        /// An error has occurred in a Wininet asynchronous thread. You may need to restart
        /// </summary>
        public const int WININET_E_ASYNC_THREAD_FAILED = unchecked((int)0x80072F0F);

        /// <summary>
        /// The protocol scheme has changed during a redirect operaiton
        /// </summary>
        public const int WININET_E_REDIRECT_SCHEME_CHANGE = unchecked((int)0x80072F10);

        /// <summary>
        /// There are operations awaiting retry
        /// </summary>
        public const int WININET_E_DIALOG_PENDING = unchecked((int)0x80072F11);

        /// <summary>
        /// The operation must be retried
        /// </summary>
        public const int WININET_E_RETRY_DIALOG = unchecked((int)0x80072F12);

        /// <summary>
        /// There are no new cache containers
        /// </summary>
        public const int WININET_E_NO_NEW_CONTAINERS = unchecked((int)0x80072F13);

        /// <summary>
        /// A security zone check indicates the operation must be retried
        /// </summary>
        public const int WININET_E_HTTPS_HTTP_SUBMIT_REDIR = unchecked((int)0x80072F14);

        /// <summary>
        /// The SSL certificate contains errors.
        /// </summary>
        public const int WININET_E_SEC_CERT_ERRORS = unchecked((int)0x80072F17);

        /// <summary>
        /// It was not possible to connect to the revocation server or a definitive response could not be obtained.
        /// </summary>
        public const int WININET_E_SEC_CERT_REV_FAILED = unchecked((int)0x80072F19);

        /// <summary>
        /// The requested header was not found
        /// </summary>
        public const int WININET_E_HEADER_NOT_FOUND = unchecked((int)0x80072F76);

        /// <summary>
        /// The server does not support the requested protocol level
        /// </summary>
        public const int WININET_E_DOWNLEVEL_SERVER = unchecked((int)0x80072F77);

        /// <summary>
        /// The server returned an invalid or unrecognized response
        /// </summary>
        public const int WININET_E_INVALID_SERVER_RESPONSE = unchecked((int)0x80072F78);

        /// <summary>
        /// The supplied HTTP header is invalid
        /// </summary>
        public const int WININET_E_INVALID_HEADER = unchecked((int)0x80072F79);

        /// <summary>
        /// The request for a HTTP header is invalid
        /// </summary>
        public const int WININET_E_INVALID_QUERY_REQUEST = unchecked((int)0x80072F7A);

        /// <summary>
        /// The HTTP header already exists
        /// </summary>
        public const int WININET_E_HEADER_ALREADY_EXISTS = unchecked((int)0x80072F7B);

        /// <summary>
        /// The HTTP redirect request failed
        /// </summary>
        public const int WININET_E_REDIRECT_FAILED = unchecked((int)0x80072F7C);

        /// <summary>
        /// An error occurred in the secure channel support
        /// </summary>
        public const int WININET_E_SECURITY_CHANNEL_ERROR = unchecked((int)0x80072F7D);

        /// <summary>
        /// The file could not be written to the cache
        /// </summary>
        public const int WININET_E_UNABLE_TO_CACHE_FILE = unchecked((int)0x80072F7E);

        /// <summary>
        /// The TCP/IP protocol is not installed properly
        /// </summary>
        public const int WININET_E_TCPIP_NOT_INSTALLED = unchecked((int)0x80072F7F);

        /// <summary>
        /// The computer is disconnected from the network
        /// </summary>
        public const int WININET_E_DISCONNECTED = unchecked((int)0x80072F83);

        /// <summary>
        /// The server is unreachable
        /// </summary>
        public const int WININET_E_SERVER_UNREACHABLE = unchecked((int)0x80072F84);

        /// <summary>
        /// The proxy server is unreachable
        /// </summary>
        public const int WININET_E_PROXY_SERVER_UNREACHABLE = unchecked((int)0x80072F85);

        /// <summary>
        /// The proxy auto-configuration script is in error
        /// </summary>
        public const int WININET_E_BAD_AUTO_PROXY_SCRIPT = unchecked((int)0x80072F86);

        /// <summary>
        /// Could not download the proxy auto-configuration script file
        /// </summary>
        public const int WININET_E_UNABLE_TO_DOWNLOAD_SCRIPT = unchecked((int)0x80072F87);

        /// <summary>
        /// The supplied certificate is invalid
        /// </summary>
        public const int WININET_E_SEC_INVALID_CERT = unchecked((int)0x80072F89);

        /// <summary>
        /// The supplied certificate has been revoked
        /// </summary>
        public const int WININET_E_SEC_CERT_REVOKED = unchecked((int)0x80072F8A);

        /// <summary>
        /// The Dialup failed because file sharing was turned on and a failure was requested if security check was needed
        /// </summary>
        public const int WININET_E_FAILED_DUETOSECURITYCHECK = unchecked((int)0x80072F8B);

        /// <summary>
        /// Initialization of the WinINet API has not occurred
        /// </summary>
        public const int WININET_E_NOT_INITIALIZED = unchecked((int)0x80072F8C);

        /// <summary>
        /// Login failed and the client should display the entity body to the user
        /// </summary>
        public const int WININET_E_LOGIN_FAILURE_DISPLAY_ENTITY_BODY = unchecked((int)0x80072F8E);

        /// <summary>
        /// Content decoding has failed
        /// </summary>
        public const int WININET_E_DECODING_FAILED = unchecked((int)0x80072F8F);

        /// <summary>
        /// The HTTP request was not redirected
        /// </summary>
        public const int WININET_E_NOT_REDIRECTED = unchecked((int)0x80072F80);

        /// <summary>
        /// A cookie from the server must be confirmed by the user
        /// </summary>
        public const int WININET_E_COOKIE_NEEDS_CONFIRMATION = unchecked((int)0x80072F81);

        /// <summary>
        /// A cookie from the server has been declined acceptance
        /// </summary>
        public const int WININET_E_COOKIE_DECLINED = unchecked((int)0x80072F82);

        /// <summary>
        /// The HTTP redirect request must be confirmed by the user
        /// </summary>
        public const int WININET_E_REDIRECT_NEEDS_CONFIRMATION = unchecked((int)0x80072F88);


        //
        // SQLite
        //

        /// <summary>
        /// SQL error or missing database
        /// </summary>
        public const int SQLITE_E_ERROR = unchecked((int)0x87AF0001);

        /// <summary>
        /// Internal logic error in SQLite
        /// </summary>
        public const int SQLITE_E_INTERNAL = unchecked((int)0x87AF0002);

        /// <summary>
        /// Access permission denied
        /// </summary>
        public const int SQLITE_E_PERM = unchecked((int)0x87AF0003);

        /// <summary>
        /// Callback routine requested an abort
        /// </summary>
        public const int SQLITE_E_ABORT = unchecked((int)0x87AF0004);

        /// <summary>
        /// The database file is locked
        /// </summary>
        public const int SQLITE_E_BUSY = unchecked((int)0x87AF0005);

        /// <summary>
        /// A table in the database is locked
        /// </summary>
        public const int SQLITE_E_LOCKED = unchecked((int)0x87AF0006);

        /// <summary>
        /// A malloc() failed
        /// </summary>
        public const int SQLITE_E_NOMEM = unchecked((int)0x87AF0007);

        /// <summary>
        /// Attempt to write a readonly database
        /// </summary>
        public const int SQLITE_E_READONLY = unchecked((int)0x87AF0008);

        /// <summary>
        /// Operation terminated by sqlite3_interrupt()
        /// </summary>
        public const int SQLITE_E_INTERRUPT = unchecked((int)0x87AF0009);

        /// <summary>
        /// Some kind of disk I/O error occurred
        /// </summary>
        public const int SQLITE_E_IOERR = unchecked((int)0x87AF000A);

        /// <summary>
        /// The database disk image is malformed
        /// </summary>
        public const int SQLITE_E_CORRUPT = unchecked((int)0x87AF000B);

        /// <summary>
        /// Unknown opcode in sqlite3_file_control()
        /// </summary>
        public const int SQLITE_E_NOTFOUND = unchecked((int)0x87AF000C);

        /// <summary>
        /// Insertion failed because database is full
        /// </summary>
        public const int SQLITE_E_FULL = unchecked((int)0x87AF000D);

        /// <summary>
        /// Unable to open the database file
        /// </summary>
        public const int SQLITE_E_CANTOPEN = unchecked((int)0x87AF000E);

        /// <summary>
        /// Database lock protocol error
        /// </summary>
        public const int SQLITE_E_PROTOCOL = unchecked((int)0x87AF000F);

        /// <summary>
        /// Database is empty
        /// </summary>
        public const int SQLITE_E_EMPTY = unchecked((int)0x87AF0010);

        /// <summary>
        /// The database schema changed
        /// </summary>
        public const int SQLITE_E_SCHEMA = unchecked((int)0x87AF0011);

        /// <summary>
        /// String or BLOB exceeds size limit
        /// </summary>
        public const int SQLITE_E_TOOBIG = unchecked((int)0x87AF0012);

        /// <summary>
        /// Abort due to constraint violation
        /// </summary>
        public const int SQLITE_E_CONSTRAINT = unchecked((int)0x87AF0013);

        /// <summary>
        /// Data type mismatch
        /// </summary>
        public const int SQLITE_E_MISMATCH = unchecked((int)0x87AF0014);

        /// <summary>
        /// Library used incorrectly
        /// </summary>
        public const int SQLITE_E_MISUSE = unchecked((int)0x87AF0015);

        /// <summary>
        /// Uses OS features not supported on host
        /// </summary>
        public const int SQLITE_E_NOLFS = unchecked((int)0x87AF0016);

        /// <summary>
        /// Authorization denied
        /// </summary>
        public const int SQLITE_E_AUTH = unchecked((int)0x87AF0017);

        /// <summary>
        /// Auxiliary database format error
        /// </summary>
        public const int SQLITE_E_FORMAT = unchecked((int)0x87AF0018);

        /// <summary>
        /// 2nd parameter to sqlite3_bind out of range
        /// </summary>
        public const int SQLITE_E_RANGE = unchecked((int)0x87AF0019);

        /// <summary>
        /// File opened that is not a database file
        /// </summary>
        public const int SQLITE_E_NOTADB = unchecked((int)0x87AF001A);

        /// <summary>
        /// Notifications from sqlite3_log()
        /// </summary>
        public const int SQLITE_E_NOTICE = unchecked((int)0x87AF001B);

        /// <summary>
        /// Warnings from sqlite3_log()
        /// </summary>
        public const int SQLITE_E_WARNING = unchecked((int)0x87AF001C);

        /// <summary>
        /// sqlite3_step() has another row ready
        /// </summary>
        public const int SQLITE_E_ROW = unchecked((int)0x87AF0064);

        /// <summary>
        /// sqlite3_step() has finished executing
        /// </summary>
        public const int SQLITE_E_DONE = unchecked((int)0x87AF0065);

        /// <summary>
        /// SQLITE_IOERR_READ
        /// </summary>
        public const int SQLITE_E_IOERR_READ = unchecked((int)0x87AF010A);

        /// <summary>
        /// SQLITE_IOERR_SHORT_READ
        /// </summary>
        public const int SQLITE_E_IOERR_SHORT_READ = unchecked((int)0x87AF020A);

        /// <summary>
        /// SQLITE_IOERR_WRITE
        /// </summary>
        public const int SQLITE_E_IOERR_WRITE = unchecked((int)0x87AF030A);

        /// <summary>
        /// SQLITE_IOERR_FSYNC
        /// </summary>
        public const int SQLITE_E_IOERR_FSYNC = unchecked((int)0x87AF040A);

        /// <summary>
        /// SQLITE_IOERR_DIR_FSYNC
        /// </summary>
        public const int SQLITE_E_IOERR_DIR_FSYNC = unchecked((int)0x87AF050A);

        /// <summary>
        /// SQLITE_IOERR_TRUNCATE
        /// </summary>
        public const int SQLITE_E_IOERR_TRUNCATE = unchecked((int)0x87AF060A);

        /// <summary>
        /// SQLITE_IOERR_FSTAT
        /// </summary>
        public const int SQLITE_E_IOERR_FSTAT = unchecked((int)0x87AF070A);

        /// <summary>
        /// SQLITE_IOERR_UNLOCK
        /// </summary>
        public const int SQLITE_E_IOERR_UNLOCK = unchecked((int)0x87AF080A);

        /// <summary>
        /// SQLITE_IOERR_RDLOCK
        /// </summary>
        public const int SQLITE_E_IOERR_RDLOCK = unchecked((int)0x87AF090A);

        /// <summary>
        /// SQLITE_IOERR_DELETE
        /// </summary>
        public const int SQLITE_E_IOERR_DELETE = unchecked((int)0x87AF0A0A);

        /// <summary>
        /// SQLITE_IOERR_BLOCKED
        /// </summary>
        public const int SQLITE_E_IOERR_BLOCKED = unchecked((int)0x87AF0B0A);

        /// <summary>
        /// SQLITE_IOERR_NOMEM
        /// </summary>
        public const int SQLITE_E_IOERR_NOMEM = unchecked((int)0x87AF0C0A);

        /// <summary>
        /// SQLITE_IOERR_ACCESS
        /// </summary>
        public const int SQLITE_E_IOERR_ACCESS = unchecked((int)0x87AF0D0A);

        /// <summary>
        /// SQLITE_IOERR_CHECKRESERVEDLOCK
        /// </summary>
        public const int SQLITE_E_IOERR_CHECKRESERVEDLOCK = unchecked((int)0x87AF0E0A);

        /// <summary>
        /// SQLITE_IOERR_LOCK
        /// </summary>
        public const int SQLITE_E_IOERR_LOCK = unchecked((int)0x87AF0F0A);

        /// <summary>
        /// SQLITE_IOERR_CLOSE
        /// </summary>
        public const int SQLITE_E_IOERR_CLOSE = unchecked((int)0x87AF100A);

        /// <summary>
        /// SQLITE_IOERR_DIR_CLOSE
        /// </summary>
        public const int SQLITE_E_IOERR_DIR_CLOSE = unchecked((int)0x87AF110A);

        /// <summary>
        /// SQLITE_IOERR_SHMOPEN
        /// </summary>
        public const int SQLITE_E_IOERR_SHMOPEN = unchecked((int)0x87AF120A);

        /// <summary>
        /// SQLITE_IOERR_SHMSIZE
        /// </summary>
        public const int SQLITE_E_IOERR_SHMSIZE = unchecked((int)0x87AF130A);

        /// <summary>
        /// SQLITE_IOERR_SHMLOCK
        /// </summary>
        public const int SQLITE_E_IOERR_SHMLOCK = unchecked((int)0x87AF140A);

        /// <summary>
        /// SQLITE_IOERR_SHMMAP
        /// </summary>
        public const int SQLITE_E_IOERR_SHMMAP = unchecked((int)0x87AF150A);

        /// <summary>
        /// SQLITE_IOERR_SEEK
        /// </summary>
        public const int SQLITE_E_IOERR_SEEK = unchecked((int)0x87AF160A);

        /// <summary>
        /// SQLITE_IOERR_DELETE_NOENT
        /// </summary>
        public const int SQLITE_E_IOERR_DELETE_NOENT = unchecked((int)0x87AF170A);

        /// <summary>
        /// SQLITE_IOERR_MMAP
        /// </summary>
        public const int SQLITE_E_IOERR_MMAP = unchecked((int)0x87AF180A);

        /// <summary>
        /// SQLITE_IOERR_GETTEMPPATH
        /// </summary>
        public const int SQLITE_E_IOERR_GETTEMPPATH = unchecked((int)0x87AF190A);

        /// <summary>
        /// SQLITE_IOERR_CONVPATH
        /// </summary>
        public const int SQLITE_E_IOERR_CONVPATH = unchecked((int)0x87AF1A0A);

        /// <summary>
        /// SQLITE_IOERR_VNODE
        /// </summary>
        public const int SQLITE_E_IOERR_VNODE = unchecked((int)0x87AF1A02);

        /// <summary>
        /// SQLITE_IOERR_AUTH
        /// </summary>
        public const int SQLITE_E_IOERR_AUTH = unchecked((int)0x87AF1A03);

        /// <summary>
        /// SQLITE_LOCKED_SHAREDCACHE
        /// </summary>
        public const int SQLITE_E_LOCKED_SHAREDCACHE = unchecked((int)0x87AF0106);

        /// <summary>
        /// SQLITE_BUSY_RECOVERY
        /// </summary>
        public const int SQLITE_E_BUSY_RECOVERY = unchecked((int)0x87AF0105);

        /// <summary>
        /// SQLITE_BUSY_SNAPSHOT
        /// </summary>
        public const int SQLITE_E_BUSY_SNAPSHOT = unchecked((int)0x87AF0205);

        /// <summary>
        /// SQLITE_CANTOPEN_NOTEMPDIR
        /// </summary>
        public const int SQLITE_E_CANTOPEN_NOTEMPDIR = unchecked((int)0x87AF010E);

        /// <summary>
        /// SQLITE_CANTOPEN_ISDIR
        /// </summary>
        public const int SQLITE_E_CANTOPEN_ISDIR = unchecked((int)0x87AF020E);

        /// <summary>
        /// SQLITE_CANTOPEN_FULLPATH
        /// </summary>
        public const int SQLITE_E_CANTOPEN_FULLPATH = unchecked((int)0x87AF030E);

        /// <summary>
        /// SQLITE_CANTOPEN_CONVPATH
        /// </summary>
        public const int SQLITE_E_CANTOPEN_CONVPATH = unchecked((int)0x87AF040E);

        /// <summary>
        /// SQLITE_CORRUPT_VTAB
        /// </summary>
        public const int SQLITE_E_CORRUPT_VTAB = unchecked((int)0x87AF010B);

        /// <summary>
        /// SQLITE_READONLY_RECOVERY
        /// </summary>
        public const int SQLITE_E_READONLY_RECOVERY = unchecked((int)0x87AF0108);

        /// <summary>
        /// SQLITE_READONLY_CANTLOCK
        /// </summary>
        public const int SQLITE_E_READONLY_CANTLOCK = unchecked((int)0x87AF0208);

        /// <summary>
        /// SQLITE_READONLY_ROLLBACK
        /// </summary>
        public const int SQLITE_E_READONLY_ROLLBACK = unchecked((int)0x87AF0308);

        /// <summary>
        /// SQLITE_READONLY_DBMOVED
        /// </summary>
        public const int SQLITE_E_READONLY_DBMOVED = unchecked((int)0x87AF0408);

        /// <summary>
        /// SQLITE_ABORT_ROLLBACK
        /// </summary>
        public const int SQLITE_E_ABORT_ROLLBACK = unchecked((int)0x87AF0204);

        /// <summary>
        /// SQLITE_CONSTRAINT_CHECK
        /// </summary>
        public const int SQLITE_E_CONSTRAINT_CHECK = unchecked((int)0x87AF0113);

        /// <summary>
        /// SQLITE_CONSTRAINT_COMMITHOOK
        /// </summary>
        public const int SQLITE_E_CONSTRAINT_COMMITHOOK = unchecked((int)0x87AF0213);

        /// <summary>
        /// SQLITE_CONSTRAINT_FOREIGNKEY
        /// </summary>
        public const int SQLITE_E_CONSTRAINT_FOREIGNKEY = unchecked((int)0x87AF0313);

        /// <summary>
        /// SQLITE_CONSTRAINT_FUNCTION
        /// </summary>
        public const int SQLITE_E_CONSTRAINT_FUNCTION = unchecked((int)0x87AF0413);

        /// <summary>
        /// SQLITE_CONSTRAINT_NOTNULL
        /// </summary>
        public const int SQLITE_E_CONSTRAINT_NOTNULL = unchecked((int)0x87AF0513);

        /// <summary>
        /// SQLITE_CONSTRAINT_PRIMARYKEY
        /// </summary>
        public const int SQLITE_E_CONSTRAINT_PRIMARYKEY = unchecked((int)0x87AF0613);

        /// <summary>
        /// SQLITE_CONSTRAINT_TRIGGER
        /// </summary>
        public const int SQLITE_E_CONSTRAINT_TRIGGER = unchecked((int)0x87AF0713);

        /// <summary>
        /// SQLITE_CONSTRAINT_UNIQUE
        /// </summary>
        public const int SQLITE_E_CONSTRAINT_UNIQUE = unchecked((int)0x87AF0813);

        /// <summary>
        /// SQLITE_CONSTRAINT_VTAB
        /// </summary>
        public const int SQLITE_E_CONSTRAINT_VTAB = unchecked((int)0x87AF0913);

        /// <summary>
        /// SQLITE_CONSTRAINT_ROWID
        /// </summary>
        public const int SQLITE_E_CONSTRAINT_ROWID = unchecked((int)0x87AF0A13);

        /// <summary>
        /// SQLITE_NOTICE_RECOVER_WAL
        /// </summary>
        public const int SQLITE_E_NOTICE_RECOVER_WAL = unchecked((int)0x87AF011B);

        /// <summary>
        /// SQLITE_NOTICE_RECOVER_ROLLBACK
        /// </summary>
        public const int SQLITE_E_NOTICE_RECOVER_ROLLBACK = unchecked((int)0x87AF021B);

        /// <summary>
        /// SQLITE_WARNING_AUTOINDEX
        /// </summary>
        public const int SQLITE_E_WARNING_AUTOINDEX = unchecked((int)0x87AF011C);

        //
        // FACILITY_UTC
        //
        /// <summary>
        /// Toggle (alternative) trace started
        /// </summary>
        public const int UTC_E_TOGGLE_TRACE_STARTED = unchecked((int)0x87C51001);

        /// <summary>
        /// Cannot pre-empt running trace: The current trace has a higher priority
        /// </summary>
        public const int UTC_E_ALTERNATIVE_TRACE_CANNOT_PREEMPT = unchecked((int)0x87C51002);

        /// <summary>
        /// The always-on-trace is not running
        /// </summary>
        public const int UTC_E_AOT_NOT_RUNNING = unchecked((int)0x87C51003);

        /// <summary>
        /// RunScriptAction contains an invalid script type
        /// </summary>
        public const int UTC_E_SCRIPT_TYPE_INVALID = unchecked((int)0x87C51004);

        /// <summary>
        /// Requested scenario definition cannot be found
        /// </summary>
        public const int UTC_E_SCENARIODEF_NOT_FOUND = unchecked((int)0x87C51005);

        /// <summary>
        /// Requested trace profile cannot be found
        /// </summary>
        public const int UTC_E_TRACEPROFILE_NOT_FOUND = unchecked((int)0x87C51006);

        /// <summary>
        /// Trigger forwarder is already enabled
        /// </summary>
        public const int UTC_E_FORWARDER_ALREADY_ENABLED = unchecked((int)0x87C51007);

        /// <summary>
        /// Trigger forwarder is already disabled
        /// </summary>
        public const int UTC_E_FORWARDER_ALREADY_DISABLED = unchecked((int)0x87C51008);

        /// <summary>
        /// Cannot parse EventLog XML: The entry is malformed
        /// </summary>
        public const int UTC_E_EVENTLOG_ENTRY_MALFORMED = unchecked((int)0x87C51009);

        /// <summary>
        /// &lt;diagrules&gt; node contains a schemaversion which is not compatible with this client
        /// </summary>
        public const int UTC_E_DIAGRULES_SCHEMAVERSION_MISMATCH = unchecked((int)0x87C5100A);

        /// <summary>
        /// RunScriptAction was forced to terminate a script
        /// </summary>
        public const int UTC_E_SCRIPT_TERMINATED = unchecked((int)0x87C5100B);

        /// <summary>
        /// ToggleTraceWithCustomFilterAction contains an invalid custom filter
        /// </summary>
        public const int UTC_E_INVALID_CUSTOM_FILTER = unchecked((int)0x87C5100C);

        /// <summary>
        /// The trace is not running
        /// </summary>
        public const int UTC_E_TRACE_NOT_RUNNING = unchecked((int)0x87C5100D);

        /// <summary>
        /// A scenario failed to escalate: This scenario has escalated too recently
        /// </summary>
        public const int UTC_E_REESCALATED_TOO_QUICKLY = unchecked((int)0x87C5100E);

        /// <summary>
        /// A scenario failed to escalate: This scenario is already running an escalation
        /// </summary>
        public const int UTC_E_ESCALATION_ALREADY_RUNNING = unchecked((int)0x87C5100F);

        /// <summary>
        /// Cannot start tracing: PerfTrack component is already tracing
        /// </summary>
        public const int UTC_E_PERFTRACK_ALREADY_TRACING = unchecked((int)0x87C51010);

        /// <summary>
        /// A scenario failed to escalate: This scenario has reached max escalations for this escalation type
        /// </summary>
        public const int UTC_E_REACHED_MAX_ESCALATIONS = unchecked((int)0x87C51011);

        /// <summary>
        /// Cannot update forwarder: The forwarder passed to the function is of a different type
        /// </summary>
        public const int UTC_E_FORWARDER_PRODUCER_MISMATCH = unchecked((int)0x87C51012);

        /// <summary>
        /// RunScriptAction failed intentionally to force this escalation to terminate
        /// </summary>
        public const int UTC_E_INTENTIONAL_SCRIPT_FAILURE = unchecked((int)0x87C51013);

        /// <summary>
        /// Failed to initialize SQM logger
        /// </summary>
        public const int UTC_E_SQM_INIT_FAILED = unchecked((int)0x87C51014);

        /// <summary>
        /// Failed to initialize WER logger: This system does not support WER for UTC
        /// </summary>
        public const int UTC_E_NO_WER_LOGGER_SUPPORTED = unchecked((int)0x87C51015);

        /// <summary>
        /// The TraceManager has attempted to take a tracing action without initializing tracers
        /// </summary>
        public const int UTC_E_TRACERS_DONT_EXIST = unchecked((int)0x87C51016);

        /// <summary>
        /// WinRT initialization failed
        /// </summary>
        public const int UTC_E_WINRT_INIT_FAILED = unchecked((int)0x87C51017);

        /// <summary>
        /// &lt;scenario&gt; node contains a schemaversion that is not compatible with this client
        /// </summary>
        public const int UTC_E_SCENARIODEF_SCHEMAVERSION_MISMATCH = unchecked((int)0x87C51018);

        /// <summary>
        /// Scenario contains an invalid filter that can never be satisfied
        /// </summary>
        public const int UTC_E_INVALID_FILTER = unchecked((int)0x87C51019);

        /// <summary>
        /// RunExeWithArgsAction was forced to terminate a running executable
        /// </summary>
        public const int UTC_E_EXE_TERMINATED = unchecked((int)0x87C5101A);

        /// <summary>
        /// Escalation for scenario failed due to insufficient permissions
        /// </summary>
        public const int UTC_E_ESCALATION_NOT_AUTHORIZED = unchecked((int)0x87C5101B);

        /// <summary>
        /// Setup for scenario failed due to insufficient permissions
        /// </summary>
        public const int UTC_E_SETUP_NOT_AUTHORIZED = unchecked((int)0x87C5101C);

        /// <summary>
        /// A process launched by UTC failed with a non-zero exit code.
        /// </summary>
        public const int UTC_E_CHILD_PROCESS_FAILED = unchecked((int)0x87C5101D);

        /// <summary>
        /// A RunExeWithArgs action contains an unauthorized command line.
        /// </summary>
        public const int UTC_E_COMMAND_LINE_NOT_AUTHORIZED = unchecked((int)0x87C5101E);

        /// <summary>
        /// UTC cannot load Scenario Editor XML. Convert the scenario file to a DiagTrack XML using the editor.
        /// </summary>
        public const int UTC_E_CANNOT_LOAD_SCENARIO_EDITOR_XML = unchecked((int)0x87C5101F);

        /// <summary>
        /// Escalation for scenario has timed out
        /// </summary>
        public const int UTC_E_ESCALATION_TIMED_OUT = unchecked((int)0x87C51020);

        /// <summary>
        /// Setup for scenario has timed out
        /// </summary>
        public const int UTC_E_SETUP_TIMED_OUT = unchecked((int)0x87C51021);

        /// <summary>
        /// The given trigger does not match the expected trigger type
        /// </summary>
        public const int UTC_E_TRIGGER_MISMATCH = unchecked((int)0x87C51022);

        /// <summary>
        /// Requested trigger cannot be found
        /// </summary>
        public const int UTC_E_TRIGGER_NOT_FOUND = unchecked((int)0x87C51023);

        /// <summary>
        /// SIF is not supported on the machine
        /// </summary>
        public const int UTC_E_SIF_NOT_SUPPORTED = unchecked((int)0x87C51024);

        /// <summary>
        /// The delay action was terminated
        /// </summary>
        public const int UTC_E_DELAY_TERMINATED = unchecked((int)0x87C51025);

        /// <summary>
        /// The device ticket was not obtained
        /// </summary>
        public const int UTC_E_DEVICE_TICKET_ERROR = unchecked((int)0x87C51026);

        /// <summary>
        /// The trace profile needs more memory than is available for tracing
        /// </summary>
        public const int UTC_E_TRACE_BUFFER_LIMIT_EXCEEDED = unchecked((int)0x87C51027);

        /// <summary>
        /// The API was not completed successfully so the result is unavailable
        /// </summary>
        public const int UTC_E_API_RESULT_UNAVAILABLE = unchecked((int)0x87C51028);

        /// <summary>
        /// The requested API encountered a timeout in the API manager
        /// </summary>
        public const int UTC_E_RPC_TIMEOUT = unchecked((int)0x87C51029);

        /// <summary>
        /// The synchronous API encountered a wait failure
        /// </summary>
        public const int UTC_E_RPC_WAIT_FAILED = unchecked((int)0x87C5102A);

        /// <summary>
        /// The UTC API is busy with another request
        /// </summary>
        public const int UTC_E_API_BUSY = unchecked((int)0x87C5102B);

        /// <summary>
        /// The running trace profile does not have a sufficient runtime to fulfill the escalation request
        /// </summary>
        public const int UTC_E_TRACE_MIN_DURATION_REQUIREMENT_NOT_MET = unchecked((int)0x87C5102C);

        /// <summary>
        /// The trace profile could not be started because it requires exclusivity and another higher priority trace is already running
        /// </summary>
        public const int UTC_E_EXCLUSIVITY_NOT_AVAILABLE = unchecked((int)0x87C5102D);

        /// <summary>
        /// The file path is not approved for the GetFile escalation action
        /// </summary>
        public const int UTC_E_GETFILE_FILE_PATH_NOT_APPROVED = unchecked((int)0x87C5102E);

        /// <summary>
        /// The escalation working directory for the requested escalation could not be created because it already exists
        /// </summary>
        public const int UTC_E_ESCALATION_DIRECTORY_ALREADY_EXISTS = unchecked((int)0x87C5102F);

        /// <summary>
        /// Time triggers cannot be used on a transition originating from the "_start" state
        /// </summary>
        public const int UTC_E_TIME_TRIGGER_ON_START_INVALID = unchecked((int)0x87C51030);

        /// <summary>
        /// Time triggers can only be attached to a single transition
        /// </summary>
        public const int UTC_E_TIME_TRIGGER_ONLY_VALID_ON_SINGLE_TRANSITION = unchecked((int)0x87C51031);

        /// <summary>
        /// Time trigger duration must fall within an inclusive range of one second and 15 minutes
        /// </summary>
        public const int UTC_E_TIME_TRIGGER_INVALID_TIME_RANGE = unchecked((int)0x87C51032);

        /// <summary>
        /// Only one Time Trigger is allowed per state
        /// </summary>
        public const int UTC_E_MULTIPLE_TIME_TRIGGER_ON_SINGLE_STATE = unchecked((int)0x87C51033);

        /// <summary>
        /// A RunExeWithArgs action contains a binary which is not present on the targeted device.
        /// </summary>
        public const int UTC_E_BINARY_MISSING = unchecked((int)0x87C51034);

        /// <summary>
        /// A network capture trace is not allowed.
        /// </summary>
        public const int UTC_E_NETWORK_CAPTURE_NOT_ALLOWED = unchecked((int)0x87C51035);

        /// <summary>
        /// UTC failed to identify the container id to use for a scenario escalation action.
        /// </summary>
        public const int UTC_E_FAILED_TO_RESOLVE_CONTAINER_ID = unchecked((int)0x87C51036);

        /// <summary>
        /// Failed to resolve session ID during API invocation.
        /// </summary>
        public const int UTC_E_UNABLE_TO_RESOLVE_SESSION = unchecked((int)0x87C51037);

        /// <summary>
        /// UTC has throttled the event for firing too often.
        /// </summary>
        public const int UTC_E_THROTTLED = unchecked((int)0x87C51038);

        /// <summary>
        /// The script is not approved to run as part of DiagTrack scenario.
        /// </summary>
        public const int UTC_E_UNAPPROVED_SCRIPT = unchecked((int)0x87C51039);

        /// <summary>
        /// The script referenced in DiagTrack scenario is not present on the system.
        /// </summary>
        public const int UTC_E_SCRIPT_MISSING = unchecked((int)0x87C5103A);

        /// <summary>
        /// A trigger in this scenario is throttled, blocking the scenario from being loaded.
        /// </summary>
        public const int UTC_E_SCENARIO_THROTTLED = unchecked((int)0x87C5103B);

        /// <summary>
        /// The requested UTC API call is not supported on this device.
        /// </summary>
        public const int UTC_E_API_NOT_SUPPORTED = unchecked((int)0x87C5103C);

        /// <summary>
        /// The file path is not approved for collection on external rings for the GetFile escalation action.
        /// </summary>
        public const int UTC_E_GETFILE_EXTERNAL_PATH_NOT_APPROVED = unchecked((int)0x87C5103D);

        /// <summary>
        /// Querying a scenario definition exceeded the specified maximum timeout.
        /// </summary>
        public const int UTC_E_TRY_GET_SCENARIO_TIMEOUT_EXCEEDED = unchecked((int)0x87C5103E);

        /// <summary>
        /// Certification revocation checking has been enabled, but the revocation check failed to verify whether a certificate has been revoked. The server used to check for revocation might be unreachable.
        /// </summary>
        public const int UTC_E_CERT_REV_FAILED = unchecked((int)0x87C5103F);

        /// <summary>
        /// Failed to start NDISCAP service for network packet capture trace.
        /// </summary>
        public const int UTC_E_FAILED_TO_START_NDISCAP = unchecked((int)0x87C51040);

        /// <summary>
        /// UTC can perform no more than one KernelDump action on a device every 24 hours.
        /// </summary>
        public const int UTC_E_KERNELDUMP_LIMIT_REACHED = unchecked((int)0x87C51041);

        /// <summary>
        /// The event contained an aggregation or differential privacy structure, but did not specify MICROSOFT_EVENTTAG_AGGREGATE.
        /// </summary>
        public const int UTC_E_MISSING_AGGREGATE_EVENT_TAG = unchecked((int)0x87C51042);

        /// <summary>
        /// The event contained an invalid aggregation or differential privacy structure.
        /// </summary>
        public const int UTC_E_INVALID_AGGREGATION_STRUCT = unchecked((int)0x87C51043);

        /// <summary>
        /// The action cannot be completed in the specified destination.
        /// </summary>
        public const int UTC_E_ACTION_NOT_SUPPORTED_IN_DESTINATION = unchecked((int)0x87C51044);

        /// <summary>
        /// Filter command is missing a required attribute.
        /// </summary>
        public const int UTC_E_FILTER_MISSING_ATTRIBUTE = unchecked((int)0x87C51045);

        /// <summary>
        /// Filter command contains an unsupported type.
        /// </summary>
        public const int UTC_E_FILTER_INVALID_TYPE = unchecked((int)0x87C51046);

        /// <summary>
        /// Filter variable does not exist at point of evaluation.
        /// </summary>
        public const int UTC_E_FILTER_VARIABLE_NOT_FOUND = unchecked((int)0x87C51047);

        /// <summary>
        /// Filter command is not allowed in the current context.
        /// </summary>
        public const int UTC_E_FILTER_FUNCTION_RESTRICTED = unchecked((int)0x87C51048);

        /// <summary>
        /// Requested filter version is incompatible with available version.
        /// </summary>
        public const int UTC_E_FILTER_VERSION_MISMATCH = unchecked((int)0x87C51049);

        /// <summary>
        /// Filter does not support this function.
        /// </summary>
        public const int UTC_E_FILTER_INVALID_FUNCTION = unchecked((int)0x87C51050);

        /// <summary>
        /// Filter function does not accept the provided parameter types and/or count.
        /// </summary>
        public const int UTC_E_FILTER_INVALID_FUNCTION_PARAMS = unchecked((int)0x87C51051);

        /// <summary>
        /// Filter command does not exist or is incorrectly formatted.
        /// </summary>
        public const int UTC_E_FILTER_INVALID_COMMAND = unchecked((int)0x87C51052);

        /// <summary>
        /// Filter types can not be compared to each other.
        /// </summary>
        public const int UTC_E_FILTER_ILLEGAL_EVAL = unchecked((int)0x87C51053);


        //
        // WinML
        //

        /// <summary>
        /// The device is invalid or does not support machine learning.
        /// </summary>
        public const int WINML_ERR_INVALID_DEVICE = unchecked((int)0x88900001);

        /// <summary>
        /// The binding is incomplete or does not match the input/output description.
        /// </summary>
        public const int WINML_ERR_INVALID_BINDING = unchecked((int)0x88900002);

        /// <summary>
        /// An attempt was made to bind an unknown input or output.
        /// </summary>
        public const int WINML_ERR_VALUE_NOTFOUND = unchecked((int)0x88900003);

        /// <summary>
        /// The size of the buffer provided for a bound variable is invalid.
        /// </summary>
        public const int WINML_ERR_SIZE_MISMATCH = unchecked((int)0x88900004);
    }
}

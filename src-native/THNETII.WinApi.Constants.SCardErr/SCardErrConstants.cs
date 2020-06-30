using THNETII.WinApi.Native.WinError;

namespace THNETII.WinApi.Native.SCardErr
{
    using static WinErrorConstants;

    public static class SCardErrConstants
    {
        //
        // =============================
        // Facility SCARD Error Messages
        // =============================
        //
        public const int SCARD_S_SUCCESS = NO_ERROR;
        //
        //  Values are 32 bit values laid out as follows:
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
        // Define the facility codes
        //
        public const int FACILITY_SYSTEM = 0x0;
        public const int FACILITY_SCARD = 0x10;


        //
        // Define the severity codes
        //
        public const int STATUS_SEVERITY_INFORMATIONAL = 0x1;
        public const int STATUS_SEVERITY_WARNING = 0x2;
        public const int STATUS_SEVERITY_ERROR = 0x3;


        /// <summary>
        ///  An internal consistency check failed.
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
        /// A communications error with the smart card has been detected.  Retry the operation.
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
    }
}

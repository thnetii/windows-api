using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinSmcrd;

namespace THNETII.WinApi.Native.WinSCard
{
    using static READER_SEL_REQUEST_MATCH_TYPE;
    using static WinSCardFunctions;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 1023
    /// <summary>
    /// Reader selection request to reader selection provider
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct READER_SEL_REQUEST
    {
        /// <summary>
        /// Share mode used by <see cref="SCardConnect"/> to connect to smart cards
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_SHARE_MODE dwShareMode;
        /// <summary>
        /// Acceptable protocols for <see cref="SCardConnect"/> to connect to smart cards
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SCARD_PROTOCOL_FLAGS dwPreferredProtocols;
        /// <summary>
        /// Indicates how the caller wants the reader selection provider to verify smart
        /// cards.
        /// </summary>
        public READER_SEL_REQUEST_MATCH_TYPE MatchType;
        #region public union { ... } DUMMYUNIONNAME;
        internal READER_SEL_REQUEST_PARAMETER Parameter;
        public unsafe ref READER_SEL_REQUEST_READER_AND_CONTAINER_PARAMETER ReaderAndContainerParameter
        {
            get
            {
                fixed (READER_SEL_REQUEST* pThis = &this)
                    return ref pThis->Parameter.ReaderAndContainerParameter;
            }
        }
        public unsafe ref READER_SEL_REQUEST_SERIAL_NUMBER_PARAMETER SerialNumberParameter
        {
            get
            {
                fixed (READER_SEL_REQUEST* pThis = &this)
                    return ref pThis->Parameter.SerialNumberParameter;
            }
        }
        #endregion

        /// <summary>
        /// Gets the span of characters storing the Reader Name as indicated by
        /// <see cref="ReaderAndContainerParameter"/>.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// <see cref="MatchType"/> is not <see cref="RSR_MATCH_TYPE_READER_AND_CONTAINER"/>
        /// </exception>
        [SuppressMessage("Globalization", "CA1303: Do not pass literals as localized parameters")]
        public unsafe Span<char> GetReaderName()
        {
            if (MatchType != RSR_MATCH_TYPE_READER_AND_CONTAINER)
                throw new InvalidOperationException($"{nameof(MatchType)} != {nameof(RSR_MATCH_TYPE_READER_AND_CONTAINER)}");
            fixed (READER_SEL_REQUEST* pThis = &this)
            {
                void* pReaderName = ((byte*)(pThis + 1)) + ReaderAndContainerParameter.cbReaderNameOffset;
                return new Span<char>(pReaderName, ReaderAndContainerParameter.cchReaderNameLength);
            }
        }

        /// <summary>
        /// Gets the span of characters storing the Container Name as indicated by
        /// <see cref="ReaderAndContainerParameter"/>.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// <see cref="MatchType"/> is not <see cref="RSR_MATCH_TYPE_READER_AND_CONTAINER"/>
        /// </exception>
        [SuppressMessage("Globalization", "CA1303: Do not pass literals as localized parameters")]
        public unsafe Span<char> GetContainerName()
        {
            if (MatchType != RSR_MATCH_TYPE_READER_AND_CONTAINER)
                throw new InvalidOperationException($"{nameof(MatchType)} != {nameof(RSR_MATCH_TYPE_READER_AND_CONTAINER)}");
            fixed (READER_SEL_REQUEST* pThis = &this)
            {
                void* pContainerName = ((byte*)(pThis + 1)) + ReaderAndContainerParameter.cbContainerNameOffset;
                return new Span<char>(pContainerName, ReaderAndContainerParameter.cchContainerNameLength);
            }
        }

        /// <summary>
        /// Gets the span of bytes storing the Serial Number as indicated by
        /// <see cref="SerialNumberParameter"/>.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// <see cref="MatchType"/> is not <see cref="RSR_MATCH_TYPE_SERIAL_NUMBER"/>
        /// </exception>
        [SuppressMessage("Globalization", "CA1303: Do not pass literals as localized parameters")]
        public unsafe Span<byte> GetSerialNumber()
        {
            if (MatchType != RSR_MATCH_TYPE_SERIAL_NUMBER)
                throw new InvalidOperationException($"{nameof(MatchType)} != {nameof(RSR_MATCH_TYPE_SERIAL_NUMBER)}");
            fixed (READER_SEL_REQUEST* pThis = &this)
            {
                void* pSerialNumber = ((byte*)(pThis + 1)) + SerialNumberParameter.cbSerialNumberOffset;
                return new Span<byte>(pSerialNumber, SerialNumberParameter.cbSerialNumberLength);
            }
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct READER_SEL_REQUEST_PARAMETER
    {
        [FieldOffset(0)]
        public READER_SEL_REQUEST_READER_AND_CONTAINER_PARAMETER ReaderAndContainerParameter;
        [FieldOffset(0)]
        public READER_SEL_REQUEST_SERIAL_NUMBER_PARAMETER SerialNumberParameter;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct READER_SEL_REQUEST_READER_AND_CONTAINER_PARAMETER
    {
        /// <summary>
        /// Byte offset of reader name UNICODE string from the beginning of
        /// <see cref="READER_SEL_REQUEST"/> structure
        /// </summary>
        public int cbReaderNameOffset;
        /// <summary>
        /// Number of characters in reader name UNICODE string including the terminating
        /// NULL character
        /// </summary>
        public int cchReaderNameLength;
        /// <summary>
        /// Byte offset of container name UNICODE string from the beginning of
        /// <see cref="READER_SEL_REQUEST"/> structure
        /// </summary>
        public int cbContainerNameOffset;
        /// <summary>
        /// Number of characters in container name UNICODE string including the
        /// terminating NULL character
        /// </summary>
        public int cchContainerNameLength;
        /// <summary>
        /// The desired smart card module version
        /// </summary>
        public int dwDesiredCardModuleVersion;
        /// <summary>
        /// CSP and KSP flags to indicate how smart cards will be used
        /// (Valid flags include <see cref="CRYPT_NEWKEYSET"/>, <see cref="CRYPT_DELETEKEYSET"/>, <see cref="CRYPT_VERIFYCONTEXT"/>
        /// and <see cref="CRYPT_DEFAULT_CONTAINER_OPTIONAL"/>)
        /// </summary>
        public int dwCspFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct READER_SEL_REQUEST_SERIAL_NUMBER_PARAMETER
    {
        /// <summary>
        /// Byte offset of serial number byte array from the beginning of
        /// <see cref="READER_SEL_REQUEST"/> structure
        /// </summary>
        public int cbSerialNumberOffset;
        /// <summary>
        /// Number of bytes in serial number byte array
        /// </summary>
        public int cbSerialNumberLength;
        /// <summary>
        /// The desired smart card module version
        /// </summary>
        public int dwDesiredCardModuleVersion;
    }
}

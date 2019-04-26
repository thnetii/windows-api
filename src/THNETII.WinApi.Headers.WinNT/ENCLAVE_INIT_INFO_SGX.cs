using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    using static ENCLAVE_TYPE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12787
    /// <summary>
    /// Contains architecture-specific information to use to initialize an enclave when the enclave type is <see cref="ENCLAVE_TYPE_SGX"/>, which specifies an enclave for the Intel Software Guard Extensions (SGX) architecture extension.
    /// </summary>
    /// <remarks>
    /// For more information about the <strong>SIGSTRUCT</strong> and <strong>EINITTOKEN</strong> structures, see the Intel SGX Programming Reference that is available from <a href="https://go.microsoft.com/fwlink/p/?linkid=691175">Intel Software Guard Extensions</a>.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-enclave_init_info_sgx">ENCLAVE_INIT_INFO_SGX structure</a></para>
    /// </remarks>
    /// <seealso cref="ENCLAVE_CREATE_INFO_SGX"/>
    /// <seealso cref="InitializeEnclave"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct ENCLAVE_INIT_INFO_SGX
    {
        #region public byte[] SigStruct = new byte[1808];
        [StructLayout(LayoutKind.Explicit, Size = 1808)]
        private struct SIG_STRUCT { }
        private SIG_STRUCT SigStructField;
        /// <summary>
        /// The enclave signature structure (<strong>SIGSTRUCT</strong>) to use to initialize the enclave. This structure specifies information about the enclave from the enclave signer.
        /// </summary>
        public Span<byte> SigStruct => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref SigStructField));
        #endregion
        #region public byte[] Reserved1 = new byte[240];
        [StructLayout(LayoutKind.Explicit, Size = 240)]
        private struct RESERVED1 { }
        private RESERVED1 Reserved1Field;
        /// <summary>
        /// Not used.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Span<byte> Reserved1 => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref Reserved1Field));
        #endregion
        #region public byte[] EInitToken = new byte[304];
        [StructLayout(LayoutKind.Explicit, Size = 304)]
        private struct EINITTOKEN { }
        private EINITTOKEN EInitTokenField;
        /// <summary>
        /// The EINIT token structure (<strong>EINITTOKEN</strong>) to use to initialize the enclave. The initialization operation uses this structure to verify that the enclave has permission to start.
        /// </summary>
        public Span<byte> EInitToken => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref EInitTokenField));
        #endregion
        #region public byte[] Reserved2 = new byte[1744];
        [StructLayout(LayoutKind.Explicit, Size = 1744)]
        private struct RESERVED2 { }
        private RESERVED2 Reserved2Field;
        /// <summary>
        /// Not used.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Span<byte> Reserved2 => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref Reserved2Field));
        #endregion
    }
}

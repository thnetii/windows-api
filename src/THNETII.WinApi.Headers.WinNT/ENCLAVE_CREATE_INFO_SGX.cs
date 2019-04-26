using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    using static ENCLAVE_TYPE;

    /// <summary>
    /// Contains architecture-specific information to use to create an enclave when the enclave type is <see cref="ENCLAVE_TYPE_SGX"/>, which specifies an enclave for the Intel Software Guard Extensions (SGX) architecture extension.
    /// </summary>
    /// <remarks>
    /// <para>For more information about the SECS structure, see the Intel SGX Programming Reference that is available from <a href="https://go.microsoft.com/fwlink/p/?linkid=691175">Intel Software Guard Extensions</a>.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-enclave_create_info_sgx">ENCLAVE_CREATE_INFO_SGX structure</a></para>
    /// </remarks>
    /// <seealso cref="CreateEnclave"/>
    /// <seealso cref="ENCLAVE_INIT_INFO_SGX"/>
    [StructLayout(LayoutKind.Sequential, Size = Length)]
    public struct ENCLAVE_CREATE_INFO_SGX
    {
        public const int Length = 4096;
        /// <summary>
        /// The SGX enclave control structure (<strong>SECS</strong>) to use to create the enclave.
        /// </summary>
        public Span<byte> Secs => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref this));
        internal ref byte this[int index] => ref Secs[index];
    }
}

using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static ENCLAVE_TYPE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12783
    /// <summary>
    /// Contains architecture-specific information to use to create an enclave when the enclave type is <see cref="ENCLAVE_TYPE_SGX"/>, which specifies an enclave for the Intel Software Guard Extensions (SGX) architecture extension.
    /// </summary>
    /// <remarks>
    /// <para>For more information about the SECS structure, see the Intel SGX Programming Reference that is available from <a href="https://go.microsoft.com/fwlink/p/?linkid=691175">Intel Software Guard Extensions</a>.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-enclave_create_info_sgx">ENCLAVE_CREATE_INFO_SGX structure</a></para>
    /// </remarks>
    /// <seealso cref="CreateEnclave"/>
    /// <seealso cref="ENCLAVE_INIT_INFO_SGX"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ENCLAVE_CREATE_INFO_SGX
    {
        /// <summary>
        /// The SGX enclave control structure (<strong>SECS</strong>) to use to create the enclave.
        /// </summary>
        public fixed byte Secs[4096];
    }
}

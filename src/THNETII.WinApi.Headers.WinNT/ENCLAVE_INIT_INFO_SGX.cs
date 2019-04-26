using System.ComponentModel;
using System.Runtime.InteropServices;

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
    public unsafe struct ENCLAVE_INIT_INFO_SGX
    {
        /// <summary>
        /// The enclave signature structure (<strong>SIGSTRUCT</strong>) to use to initialize the enclave. This structure specifies information about the enclave from the enclave signer.
        /// </summary>
        public fixed byte SigStruct[1808];
        /// <summary>
        /// Not used.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed byte Reserved1[240];
        /// <summary>
        /// The EINIT token structure (<strong>EINITTOKEN</strong>) to use to initialize the enclave. The initialization operation uses this structure to verify that the enclave has permission to start.
        /// </summary>
        public fixed byte EInitToken[304];
        /// <summary>
        /// Not used.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed byte Reserved2[1744];
    }
}

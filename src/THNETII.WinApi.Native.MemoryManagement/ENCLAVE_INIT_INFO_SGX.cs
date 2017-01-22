using System.Runtime.InteropServices;
using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.MemoryManagementFunctions;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
    /// <summary>
    /// Contains architecture-specific information to use to initialize an enclave when the enclave type is <see cref="ENCLAVE_TYPE_SGX"/>, which specifies an enclave for the Intel Software Guard Extensions (SGX) architecture extension.
    /// </summary>
    /// <remarks>
    /// For more information about the <strong>SIGSTRUCT</strong> and <strong>EINITTOKEN</strong> structures, see the Intel SGX Programming Reference that is available from <a href="https://go.microsoft.com/fwlink/p/?linkid=691175">Intel Software Guard Extensions</a>.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/mt592868.aspx">ENCLAVE_INIT_INFO_SGX structure</a></para>
    /// </remarks>
    /// <seealso cref="InitializeEnclave"/>
    /// <seealso cref="ENCLAVE_CREATE_INFO_SGX"/>
    [StructLayout(LayoutKind.Sequential)]
    public class ENCLAVE_INIT_INFO_SGX
    {
        /// <summary>The enclave signature structure (<strong>SIGSTRUCT</strong>) to use to initialize the enclave. This structure specifies information about the enclave from the enclave signer.</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1808)]
        public byte[] SigStruct;
        /// <summary>Not used.</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 240)]
        public byte[] Reserved;
        /// <summary>The EINIT token structure (<strong>EINITTOKEN</strong>) to use to initialize the enclave. The initialization operation uses this structure to verify that the enclave has permission to start.</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 304)]
        public byte[] EInitToken;
        /// <summary>Not used.</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 744)]
        public byte[] Reserved2;
    }
}

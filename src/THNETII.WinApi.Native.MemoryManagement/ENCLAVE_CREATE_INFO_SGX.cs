using System.Runtime.InteropServices;
using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.MemoryManagementFunctions;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
    /// <summary>
    /// Contains architecture-specific information to use to create an enclave when the enclave type is <see cref="ENCLAVE_TYPE_SGX"/>, which specifies an enclave for the Intel Software Guard Extensions (SGX) architecture extension.
    /// </summary>
    /// <remarks>
    /// For more information about the <strong>SECS</strong> structure, see the Intel SGX Programming Reference that is available from <a href="https://go.microsoft.com/fwlink/p/?linkid=691175">Intel Software Guard Extensions</a>.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/mt592867.aspx">ENCLAVE_CREATE_INFO_SGX structure</a></para>
    /// </remarks>
    /// <seealso cref="CreateEnclave"/>
    /// <seealso cref="ENCLAVE_INIT_INFO_SGX"/>
    [StructLayout(LayoutKind.Sequential)]
    public class ENCLAVE_CREATE_INFO_SGX
    {
        /// <summary>
        /// The SGX enclave control structure (<strong>SECS</strong>) to use to create the enclave.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4096)]
        public byte[] Secs;
    }
}

using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static ENCLAVE_TYPE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12804
    /// <summary>
    /// Contains architecture-specific information to use to initialize an enclave when the enclave type is <see cref="ENCLAVE_TYPE_VBS"/>, which specifies a virtualization-based security (VBS) enclave.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-enclave_init_info_vbs">ENCLAVE_INIT_INFO_VBS structure</a></para>
    /// </remarks>
    /// <seealso cref="InitializeEnclave"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct ENCLAVE_INIT_INFO_VBS
    {
        /// <summary>
        /// The total length of the <see cref="ENCLAVE_INIT_INFO_VBS"/> structure, in bytes.
        /// </summary>
        public int Length;
        /// <summary>
        /// Upon entry to the <see cref="InitializeEnclave"/> function, specifies the number of threads to create in the enclave. Upon successful return from <see cref="InitializeEnclave"/>, contains the number of threads the function actually created.
        /// </summary>
        public int ThreadCount;
    }
}

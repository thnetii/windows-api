using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static ENCLAVE_TYPE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12796
    /// <summary>
    /// Contains architecture-specific information to use to create an enclave when the enclave type is <see cref="ENCLAVE_TYPE_VBS"/>, which specifies a virtualization-based security (VBS) enclave.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-enclave_create_info_vbs">ENCLAVE_CREATE_INFO_VBS structure</a></para>
    /// </remarks>
    /// <seealso cref="CreateEnclave"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ENCLAVE_CREATE_INFO_VBS
    {
        /// <summary>
        /// A flag that indicates whether the enclave permits debugging.
        /// </summary>
        public ENCLAVE_VBS_FLAGS Flags;
        /// <summary>
        /// The identifier of the owner of the enclave.
        /// </summary>
        public fixed byte OwnerID[32];
    }
}

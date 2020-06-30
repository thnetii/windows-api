using System;

namespace THNETII.WinApi
{
    using static THNETII.WinApi.Native.NTStatus.NTStatusConstants;

    /// <summary>
    /// The <see cref="NTSTATUS"/> facility values that are defined by Windows.
    /// </summary>
    public enum NTFacility
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        Debugger = FACILITY_DEBUGGER,
        RpcRuntime = FACILITY_RPC_RUNTIME,
        RpcStubs = FACILITY_RPC_STUBS,
        IOErrorCode = FACILITY_IO_ERROR_CODE,
        CodClassErrorCode = FACILITY_CODCLASS_ERROR_CODE,
        NtWin32 = FACILITY_NTWIN32,
        NtCert = FACILITY_NTCERT,
        NtSspi = FACILITY_NTSSPI,
        TerminalServer = FACILITY_TERMINAL_SERVER,
        MuiErrorCode = FACILTIY_MUI_ERROR_CODE,
        UsbErrorCode = FACILITY_USB_ERROR_CODE,
        HidErrorCode = FACILITY_HID_ERROR_CODE,
        FirewireErrorCode = FACILITY_FIREWIRE_ERROR_CODE,
        ClusterErrorCode = FACILITY_CLUSTER_ERROR_CODE,
        AcpiErrorCode = FACILITY_ACPI_ERROR_CODE,
        SxsErrorCode = FACILITY_SXS_ERROR_CODE,
        Transaction = FACILITY_TRANSACTION,
        Commonlog = FACILITY_COMMONLOG,
        Video = FACILITY_VIDEO,
        FilterManager = FACILITY_FILTER_MANAGER,
        Monitor = FACILITY_MONITOR,
        GraphicsKernel = FACILITY_GRAPHICS_KERNEL,
        DriverFramework = FACILITY_DRIVER_FRAMEWORK,
        FveErrorCode = FACILITY_FVE_ERROR_CODE,
        FwpErrorCode = FACILITY_FWP_ERROR_CODE,
        NdisErrorCode = FACILITY_NDIS_ERROR_CODE,
        Tpm = FACILITY_TPM,
        Rtpm = FACILITY_RTPM,
        Hypervisor = FACILITY_HYPERVISOR,
        IPSec = FACILITY_IPSEC,
        Virtualization = FACILITY_VIRTUALIZATION,
        VolMgr = FACILITY_VOLMGR,
        BcdErrorCode = FACILITY_BCD_ERROR_CODE,
        Win32kNTUser = FACILITY_WIN32K_NTUSER,
        Win32kNTGdi = FACILITY_WIN32K_NTGDI,
        ResumeKeyFilter = FACILITY_RESUME_KEY_FILTER,
        Rdbss = FACILITY_RDBSS,
        BthAtt = FACILITY_BTH_ATT,
        SecureBoot = FACILITY_SECUREBOOT,
        AudioKernel = FACILITY_AUDIO_KERNEL,
        Vsm = FACILITY_VSM,
        VolSnap = FACILITY_VOLSNAP,
        SdBus = FACILITY_SDBUS,
        SharedVhdx = FACILITY_SHARED_VHDX,
        Smb = FACILITY_SMB,
        Interix = FACILITY_INTERIX,
        Spaces = FACILITY_SPACES,
        SecurityCore = FACILITY_SECURITY_CORE,
        SystemIntegrity = FACILITY_SYSTEM_INTEGRITY,
        Licensing = FACILITY_LICENSING,
        PlatformManifest = FACILITY_PLATFORM_MANIFEST,
        AppExecution = FACILITY_APP_EXEC,
        [Obsolete(nameof(FACILITY_MAXIMUM_VALUE) + " should not be used.")]
        MaximumValue = FACILITY_MAXIMUM_VALUE,
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}

namespace THNETII.WinApi
{
    using static Native.WinError.WinErrorConstants;

    /// <summary>
    /// A Win32 Facility code, indicating which part of the Win32 system reported
    /// a system error code.
    /// </summary>
    /// <remarks>The <see cref="HResultFacility"/> codes differ from the <see cref="NTFacility"/> codes.</remarks>
    public enum HResultFacility
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        /// <summary>
        /// The default facility code.
        /// </summary>
        Null = FACILITY_NULL,
        /// <summary>
        /// The source of the error code is an RPC subsystem.
        /// </summary>
        Rpc = FACILITY_RPC,
        /// <summary>
        /// The source of the error code is a COM Dispatch.
        /// </summary>
        Dispatch = FACILITY_DISPATCH,
        /// <summary>
        /// The source of the error code is OLE Storage.
        /// </summary>
        Storage = FACILITY_STORAGE,
        /// <summary>
        /// The source of the error code is COM/OLE Interface management.
        /// </summary>
        Itf = FACILITY_ITF,
        /// <summary>
        /// This region is reserved to map undecorated error codes into <see cref="HRESULT"/>s.
        /// </summary>
        Win32 = FACILITY_WIN32,
        /// <summary>
        /// The source of the error code is the Windows subsystem.
        /// </summary>
        Windows = FACILITY_WINDOWS,
        /// <summary>
        /// The source of the error code is the Security API layer.
        /// </summary>
        Sspi = FACILITY_SSPI,
        /// <summary>
        /// The source of the error code is the Security API layer.
        /// </summary>
        Security = FACILITY_SECURITY,
        /// <summary>
        /// The source of the error code is the control mechanism.
        /// </summary>
        Control = FACILITY_CONTROL,
        /// <summary>
        /// The source of the error code is a certificate client or server?  
        /// </summary>
        Cert = FACILITY_CERT,
        /// <summary>
        /// The source of the error code is Wininet related.
        /// </summary>
        Internet = FACILITY_INTERNET,
        /// <summary>
        /// The source of the error code is the Windows Media Server.
        /// </summary>
        Mediaserver = FACILITY_MEDIASERVER,
        /// <summary>
        /// The source of the error code is the Microsoft Message Queue.
        /// </summary>
        Msmq = FACILITY_MSMQ,
        /// <summary>
        /// The source of the error code is the Setup API.
        /// </summary>
        SetupApi = FACILITY_SETUPAPI,
        /// <summary>
        /// The source of the error code is the Smart-card subsystem.
        /// </summary>
        SCard = FACILITY_SCARD,
        /// <summary>
        /// The source of the error code is COM+.
        /// </summary>
        COMPlus = FACILITY_COMPLUS,
        /// <summary>
        /// The source of the error code is the Microsoft agent.
        /// </summary>
        Aaf = FACILITY_AAF,
        /// <summary>
        /// The source of the error code is .NET CLR.
        /// </summary>
        Urt = FACILITY_URT,
        /// <summary>
        /// The source of the error code is the audit collection service.
        /// </summary>
        Acs = FACILITY_ACS,
        /// <summary>
        /// The source of the error code is Direct Play.
        /// </summary>
        DPlay = FACILITY_DPLAY,
        /// <summary>
        /// The source of the error code is the ubiquitous memoryintrospection service.
        /// </summary>
        Umi = FACILITY_UMI,
        /// <summary>
        /// The source of the error code is Side-by-side servicing.
        /// </summary>
        Sxs = FACILITY_SXS,
        /// <summary>
        /// The error code is specific to Windows CE.
        /// </summary>
        WindowsCE = FACILITY_WINDOWS_CE,
        /// <summary>
        /// The source of the error code is HTTP support.
        /// </summary>
        Http = FACILITY_HTTP,
        /// <summary>
        /// The source of the error code is common Logging support.
        /// </summary>
        UsermodeCommonlog = FACILITY_USERMODE_COMMONLOG,
        Wer = FACILITY_WER,
        /// <summary>
        /// The source of the error code is the user mode filter manager.
        /// </summary>
        UsermodeFilterManager = FACILITY_USERMODE_FILTER_MANAGER,
        /// <summary>
        /// The source of the error code is background copy control
        /// </summary>
        BackgroundCopy = FACILITY_BACKGROUNDCOPY,
        /// <summary>
        /// The source of the error code is configuration services.
        /// </summary>
        Configuration = FACILITY_CONFIGURATION,
        Wia = FACILITY_WIA,
        /// <summary>
        /// The source of the error code is state management services.
        /// </summary>
        StateManagement = FACILITY_STATE_MANAGEMENT,
        /// <summary>
        /// The source of the error code is the Microsoft Identity Server.
        /// </summary>
        MetaDirectory = FACILITY_METADIRECTORY,
        /// <summary>
        /// The source of the error code is a Windows update.
        /// </summary>
        WindowsUpdate = FACILITY_WINDOWSUPDATE,
        /// <summary>
        /// The source of the error code is Active Directory.
        /// </summary>
        DirectoryService = FACILITY_DIRECTORYSERVICE,
        /// <summary>
        /// The source of the error code is the graphics drivers.
        /// </summary>
        Graphics = FACILITY_GRAPHICS,
        /// <summary>
        /// The source of the error code is the user Shell.
        /// </summary>
        Shell = FACILITY_SHELL,
        Nap = FACILITY_NAP,
        /// <summary>
        /// The source of the error code is the Trusted Platform Module services.
        /// </summary>
        TpmServices = FACILITY_TPM_SERVICES,
        /// <summary>
        /// The source of the error code is the Trusted Platform Module applications.
        /// </summary>
        TpmSoftware = FACILITY_TPM_SOFTWARE,

        UI = FACILITY_UI,

        Xaml = FACILITY_XAML,

        ActionQueue = FACILITY_ACTION_QUEUE,
        /// <summary>
        /// The source of the error code is Performance Logs and Alerts
        /// </summary>
        Pla = FACILITY_PLA,

        WindowsSetup = FACILITY_WINDOWS_SETUP,
        /// <summary>
        /// The source of the error code is Full volume encryption.
        /// </summary>
        Fve = FACILITY_FVE,
        /// <summary>
        /// The source of the error code is the Firewall Platform.
        /// </summary>
        Fwp = FACILITY_FWP,
        /// <summary>
        /// The source of the error code is the Windows Resource Manager.
        /// </summary>
        WinRM = FACILITY_WINRM,
        /// <summary>
        /// The source of the error code is the Network Driver Interface.
        /// </summary>
        Ndis = FACILITY_NDIS,
        /// <summary>
        /// The source of the error code is the Usermode Hypervisor components.
        /// </summary>
        UsermodeHypervisor = FACILITY_USERMODE_HYPERVISOR,
        /// <summary>
        /// The source of the error code is the Configuration Management Infrastructure.
        /// </summary>
        Cmi = FACILITY_CMI,
        /// <summary>
        /// The source of the error code is the user mode virtualization subsystem.
        /// </summary>
        UsermodeVirtualization = FACILITY_USERMODE_VIRTUALIZATION,
        /// <summary>
        /// The source of the error code is  the user mode volume manager
        /// </summary>
        UsermodeVolumeManager = FACILITY_USERMODE_VOLMGR,
        /// <summary>
        /// The source of the error code is the Boot Configuration Database.
        /// </summary>
        Bcd = FACILITY_BCD,
        /// <summary>
        /// The source of the error code is user mode virtual hard disk support.
        /// </summary>
        UsermodeVhd = FACILITY_USERMODE_VHD,

        UsermodeHns = FACILITY_USERMODE_HNS,
        /// <summary>
        /// The source of the error code is System Diagnostics.
        /// </summary>
        SDiag = FACILITY_SDIAG,
        /// <summary>
        /// The source of the error code is the Web Services.
        /// </summary>
        WebServices = FACILITY_WEBSERVICES,

        WinPE = FACILITY_WINPE,

        Wpn = FACILITY_WPN,

        WindowsStore = FACILITY_WINDOWS_STORE,

        Input = FACILITY_INPUT,

        Eap = FACILITY_EAP,
        /// <summary>
        /// The source of the error code is a Windows Defender component.
        /// </summary>
        WindowsDefender = FACILITY_WINDOWS_DEFENDER,
        /// <summary>
        /// The source of the error code is the open connectivity service.
        /// </summary>
        Opc = FACILITY_OPC,

        Xps = FACILITY_XPS,

        Mbn = FACILITY_MBN,

        Powershell = FACILITY_POWERSHELL,

        Ras = FACILITY_RAS,

        P2PInt = FACILITY_P2P_INT,

        P2P = FACILITY_P2P,

        Daf = FACILITY_DAF,

        BluetoothAtt = FACILITY_BLUETOOTH_ATT,

        Audio = FACILITY_AUDIO,

        StateRepository = FACILITY_STATEREPOSITORY,

        VisualCpp = FACILITY_VISUALCPP,

        Script = FACILITY_SCRIPT,

        Parse = FACILITY_PARSE,

        Blb = FACILITY_BLB,

        BlbCli = FACILITY_BLB_CLI,

        WsbApp = FACILITY_WSBAPP,

        BlbUi = FACILITY_BLBUI,

        Usn = FACILITY_USN,

        UsermodeVolSnap = FACILITY_USERMODE_VOLSNAP,

        Tiering = FACILITY_TIERING,

        WsbOnline = FACILITY_WSB_ONLINE,

        OnlineId = FACILITY_ONLINE_ID,

        DeviceUpdateAgent = FACILITY_DEVICE_UPDATE_AGENT,

        Dls = FACILITY_DLS,

        DeliveryOptimization = FACILITY_DELIVERY_OPTIMIZATION,

        UsermodeSpaces = FACILITY_USERMODE_SPACES,

        UsermodeSecurityCore = FACILITY_USER_MODE_SECURITY_CORE,

        UsermodeLicensing = FACILITY_USERMODE_LICENSING,

        Sos = FACILITY_SOS,

        Debuggers = FACILITY_DEBUGGERS,

        Spp = FACILITY_SPP,

        Restore = FACILITY_RESTORE,

        DMServer = FACILITY_DMSERVER,

        DeploymentServicesServer = FACILITY_DEPLOYMENT_SERVICES_SERVER,

        DeploymentServicesImaging = FACILITY_DEPLOYMENT_SERVICES_IMAGING,

        DeploymentServicesManagement = FACILITY_DEPLOYMENT_SERVICES_MANAGEMENT,

        DeploymentServicesUtil = FACILITY_DEPLOYMENT_SERVICES_UTIL,

        DeploymentServicesBinLsvc = FACILITY_DEPLOYMENT_SERVICES_BINLSVC,

        DeploymentServicesPxe = FACILITY_DEPLOYMENT_SERVICES_PXE,

        DeploymentServicesTftp = FACILITY_DEPLOYMENT_SERVICES_TFTP,

        DeploymentServicesTransportManagement = FACILITY_DEPLOYMENT_SERVICES_TRANSPORT_MANAGEMENT,

        DeploymentServicesDriverProvisioning = FACILITY_DEPLOYMENT_SERVICES_DRIVER_PROVISIONING,

        DeploymentServicesMulticastServer = FACILITY_DEPLOYMENT_SERVICES_MULTICAST_SERVER,

        DeploymentServicesMulticastClient = FACILITY_DEPLOYMENT_SERVICES_MULTICAST_CLIENT,

        DeploymentServicesContentProvider = FACILITY_DEPLOYMENT_SERVICES_CONTENT_PROVIDER,

        LinguisticServices = FACILITY_LINGUISTIC_SERVICES,

        AudioStreaming = FACILITY_AUDIOSTREAMING,

        Accelerator = FACILITY_ACCELERATOR,

        WmaaEcma = FACILITY_WMAAECMA,

        DirectMusic = FACILITY_DIRECTMUSIC,

        Direct3D10 = FACILITY_DIRECT3D10,

        Dxgi = FACILITY_DXGI,

        DxgiDd = FACILITY_DXGI_DDI,

        Direct3D11 = FACILITY_DIRECT3D11,

        Direct3D11Debug = FACILITY_DIRECT3D11_DEBUG,

        Direct3D12 = FACILITY_DIRECT3D12,

        Direct3D12Debug = FACILITY_DIRECT3D12_DEBUG,

        Leap = FACILITY_LEAP,

        AudClnt = FACILITY_AUDCLNT,

        WinCodecDWriteDwm = FACILITY_WINCODEC_DWRITE_DWM,

        WinMl = FACILITY_WINML,

        Direct2D = FACILITY_DIRECT2D,

        Defrag = FACILITY_DEFRAG,

        UsermodeSDBus = FACILITY_USERMODE_SDBUS,

        JScript = FACILITY_JSCRIPT,

        PidGenX = FACILITY_PIDGENX,

        Eas = FACILITY_EAS,

        Web = FACILITY_WEB,

        WebSocket = FACILITY_WEB_SOCKET,

        Mobile = FACILITY_MOBILE,

        Sqlite = FACILITY_SQLITE,

        Utc = FACILITY_UTC,

        Wep = FACILITY_WEP,

        SyncEngine = FACILITY_SYNCENGINE,

        Xbox = FACILITY_XBOX,

        Pix = FACILITY_PIX,
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}

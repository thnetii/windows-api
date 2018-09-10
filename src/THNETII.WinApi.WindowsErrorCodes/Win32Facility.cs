using static THNETII.WinApiNative.WinError.WinErrorConstants;

namespace THNETII.WinApi.WindowsErrorCodes
{
    public enum Win32Facility
    {
        Null = FACILITY_NULL,
        Rpc = FACILITY_RPC,
        Dispatch = FACILITY_DISPATCH,
        Storage = FACILITY_STORAGE,
        Itf = FACILITY_ITF,
        Win32 = FACILITY_WIN32,
        Windows = FACILITY_WINDOWS,
        Sspi = FACILITY_SSPI,
        Security = FACILITY_SECURITY,
        Control = FACILITY_CONTROL,
        Cert = FACILITY_CERT,
        Internet = FACILITY_INTERNET,
        Mediaserver = FACILITY_MEDIASERVER,
        Msmq = FACILITY_MSMQ,
        SetupApi = FACILITY_SETUPAPI,
        SCard = FACILITY_SCARD,
        COMPlus = FACILITY_COMPLUS,
        Aaf = FACILITY_AAF,
        Urt = FACILITY_URT,
        Acs = FACILITY_ACS,
        DPlay = FACILITY_DPLAY,
        Umi = FACILITY_UMI,
        Sxs = FACILITY_SXS,
        WindowsCE = FACILITY_WINDOWS_CE,
        Http = FACILITY_HTTP,
        UsermodeCommonlog = FACILITY_USERMODE_COMMONLOG,
        Wer = FACILITY_WER,
        UsermodeFilterManager = FACILITY_USERMODE_FILTER_MANAGER,
        BackgroundCopy = FACILITY_BACKGROUNDCOPY,
        Configuration = FACILITY_CONFIGURATION,
        Wia = FACILITY_WIA,
        StateManagement = FACILITY_STATE_MANAGEMENT,
        MetaDirectory = FACILITY_METADIRECTORY,
        WindowsUpdate = FACILITY_WINDOWSUPDATE,
        DirectoryService = FACILITY_DIRECTORYSERVICE,
        Graphics = FACILITY_GRAPHICS,
        Shell = FACILITY_SHELL,

        Nap = FACILITY_NAP,

        TpmServices = FACILITY_TPM_SERVICES,

        TpmSoftware = FACILITY_TPM_SOFTWARE,

        UI = FACILITY_UI,

        Xaml = FACILITY_XAML,

        ActionQueue = FACILITY_ACTION_QUEUE,

        Pla = FACILITY_PLA,

        WindowsSetup = FACILITY_WINDOWS_SETUP,

        Fve = FACILITY_FVE,

        Fwp = FACILITY_FWP,

        WinRM = FACILITY_WINRM,

        Ndis = FACILITY_NDIS,

        UsermodeHypervisor = FACILITY_USERMODE_HYPERVISOR,

        Cmi = FACILITY_CMI,

        UsermodeVirtualization = FACILITY_USERMODE_VIRTUALIZATION,

        UsermodeVolumeManager = FACILITY_USERMODE_VOLMGR,

        Bcd = FACILITY_BCD,

        UsermodeVhd = FACILITY_USERMODE_VHD,

        UsermodeHns = FACILITY_USERMODE_HNS,

        SDiag = FACILITY_SDIAG,

        WebServices = FACILITY_WEBSERVICES,

        WinPE = FACILITY_WINPE,

        Wpn = FACILITY_WPN,

        WindowsStore = FACILITY_WINDOWS_STORE,

        Input = FACILITY_INPUT,

        Eap = FACILITY_EAP,

        WindowsDefender = FACILITY_WINDOWS_DEFENDER,

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
    }
}

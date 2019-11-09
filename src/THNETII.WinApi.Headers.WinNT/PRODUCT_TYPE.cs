namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// <para>Product types</para>
    /// </summary>
    /// <remarks>
    /// <para>This list grows with each OS release.</para>
    /// <para>
    /// There is no ordering of values to ensure callers
    /// do an equality test i.e. greater-than and less-than
    /// comparisons are not useful.
    /// </para>
    /// <para>
    /// <strong>NOTE:</strong> Values in this list should never be deleted.
    /// When a product-type 'X' gets dropped from a
    /// OS release onwards, the value of 'X' continues
    /// to be used in the mapping table of <see cref="GetProductInfo"/>.
    /// </para>
    /// </remarks>
    public enum PRODUCT_TYPE : int
    {
        /// <summary>An unknown product </summary>
        PRODUCT_UNDEFINED = WinNTConstants.PRODUCT_UNDEFINED,

        /// <summary>Ultimate </summary>
        PRODUCT_ULTIMATE = WinNTConstants.PRODUCT_ULTIMATE,
        /// <summary>Home Basic </summary>
        PRODUCT_HOME_BASIC = WinNTConstants.PRODUCT_HOME_BASIC,
        /// <summary>Home Premium </summary>
        PRODUCT_HOME_PREMIUM = WinNTConstants.PRODUCT_HOME_PREMIUM,
        /// <summary>Windows 10 Enterprise </summary>
        PRODUCT_ENTERPRISE = WinNTConstants.PRODUCT_ENTERPRISE,
        /// <summary>Home Basic N </summary>
        PRODUCT_HOME_BASIC_N = WinNTConstants.PRODUCT_HOME_BASIC_N,
        /// <summary> Business </summary>
        PRODUCT_BUSINESS = WinNTConstants.PRODUCT_BUSINESS,
        /// <summary> Server Standard (full installation. For Server Core installations of Windows Server 2012 and later, use the method, <a href="https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh846315(v=vs.85)">Determining whether Server Core is running</a>.) </summary>
        PRODUCT_STANDARD_SERVER = WinNTConstants.PRODUCT_STANDARD_SERVER,
        /// <summary>Server Datacenter (full installation. For Server Core installations of Windows Server 2012 and later, use the method, <a href="https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh846315(v=vs.85)">Determining whether Server Core is running</a>.) </summary>
        PRODUCT_DATACENTER_SERVER = WinNTConstants.PRODUCT_DATACENTER_SERVER,
        /// <summary>Windows Small Business Server </summary>
        PRODUCT_SMALLBUSINESS_SERVER = WinNTConstants.PRODUCT_SMALLBUSINESS_SERVER,
        /// <summary>Server Enterprise (full installation) </summary>
        PRODUCT_ENTERPRISE_SERVER = WinNTConstants.PRODUCT_ENTERPRISE_SERVER,
        /// <summary>Starter </summary>
        PRODUCT_STARTER = WinNTConstants.PRODUCT_STARTER,
        /// <summary> Server Datacenter (core installation, Windows Server 2008 R2 and earlier) </summary>
        PRODUCT_DATACENTER_SERVER_CORE = WinNTConstants.PRODUCT_DATACENTER_SERVER_CORE,
        /// <summary> Server Standard (core installation, Windows Server 2008 R2 and earlier) </summary>
        PRODUCT_STANDARD_SERVER_CORE = WinNTConstants.PRODUCT_STANDARD_SERVER_CORE,
        /// <summary>Server Enterprise (core installation) </summary>
        PRODUCT_ENTERPRISE_SERVER_CORE = WinNTConstants.PRODUCT_ENTERPRISE_SERVER_CORE,
        /// <summary>Server Enterprise for Itanium-based Systems </summary>
        PRODUCT_ENTERPRISE_SERVER_IA64 = WinNTConstants.PRODUCT_ENTERPRISE_SERVER_IA64,
        /// <summary> Business N </summary>
        PRODUCT_BUSINESS_N = WinNTConstants.PRODUCT_BUSINESS_N,
        /// <summary>Web Server (full installation) </summary>
        PRODUCT_WEB_SERVER = WinNTConstants.PRODUCT_WEB_SERVER,
        /// <summary>HPC Edition </summary>
        PRODUCT_CLUSTER_SERVER = WinNTConstants.PRODUCT_CLUSTER_SERVER,
        /// <summary>Windows Storage Server 2008 R2 Essentials </summary>
        PRODUCT_HOME_SERVER = WinNTConstants.PRODUCT_HOME_SERVER,
        /// <summary>Storage Server Express </summary>
        PRODUCT_STORAGE_EXPRESS_SERVER = WinNTConstants.PRODUCT_STORAGE_EXPRESS_SERVER,
        /// <summary>Storage Server Standard </summary>
        PRODUCT_STORAGE_STANDARD_SERVER = WinNTConstants.PRODUCT_STORAGE_STANDARD_SERVER,
        /// <summary>Storage Server Workgroup </summary>
        PRODUCT_STORAGE_WORKGROUP_SERVER = WinNTConstants.PRODUCT_STORAGE_WORKGROUP_SERVER,
        /// <summary>Storage Server Enterprise </summary>
        PRODUCT_STORAGE_ENTERPRISE_SERVER = WinNTConstants.PRODUCT_STORAGE_ENTERPRISE_SERVER,
        /// <summary>Windows Server 2008 for Windows Essential Server Solutions </summary>
        PRODUCT_SERVER_FOR_SMALLBUSINESS = WinNTConstants.PRODUCT_SERVER_FOR_SMALLBUSINESS,
        /// <summary>Small Business Server Premium </summary>
        PRODUCT_SMALLBUSINESS_SERVER_PREMIUM = WinNTConstants.PRODUCT_SMALLBUSINESS_SERVER_PREMIUM,
        /// <summary> Home Premium N </summary>
        PRODUCT_HOME_PREMIUM_N = WinNTConstants.PRODUCT_HOME_PREMIUM_N,
        /// <summary>Windows 10 Enterprise N </summary>
        PRODUCT_ENTERPRISE_N = WinNTConstants.PRODUCT_ENTERPRISE_N,
        /// <summary>Ultimate N </summary>
        PRODUCT_ULTIMATE_N = WinNTConstants.PRODUCT_ULTIMATE_N,
        /// <summary>Web Server (core installation) </summary>
        PRODUCT_WEB_SERVER_CORE = WinNTConstants.PRODUCT_WEB_SERVER_CORE,
        /// <summary>Windows Essential Business Server Management Server </summary>
        PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT = WinNTConstants.PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT,
        /// <summary>Windows Essential Business Server Security Server </summary>
        PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY = WinNTConstants.PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY,
        /// <summary>Windows Essential Business Server Messaging Server </summary>
        PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING = WinNTConstants.PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING,
        /// <summary>Server Foundation </summary>
        PRODUCT_SERVER_FOUNDATION = WinNTConstants.PRODUCT_SERVER_FOUNDATION,
        /// <summary>Windows Home Server 2011 </summary>
        PRODUCT_HOME_PREMIUM_SERVER = WinNTConstants.PRODUCT_HOME_PREMIUM_SERVER,
        /// <summary> Windows Server 2008 without Hyper-V for Windows Essential Server Solutions </summary>
        PRODUCT_SERVER_FOR_SMALLBUSINESS_V = WinNTConstants.PRODUCT_SERVER_FOR_SMALLBUSINESS_V,
        /// <summary>Server Standard without Hyper-V </summary>
        PRODUCT_STANDARD_SERVER_V = WinNTConstants.PRODUCT_STANDARD_SERVER_V,
        /// <summary>Server Datacenter without Hyper-V (full installation) </summary>
        PRODUCT_DATACENTER_SERVER_V = WinNTConstants.PRODUCT_DATACENTER_SERVER_V,
        /// <summary>Server Enterprise without Hyper-V (full installation) </summary>
        PRODUCT_ENTERPRISE_SERVER_V = WinNTConstants.PRODUCT_ENTERPRISE_SERVER_V,
        /// <summary>Server Datacenter without Hyper-V (core installation) </summary>
        PRODUCT_DATACENTER_SERVER_CORE_V = WinNTConstants.PRODUCT_DATACENTER_SERVER_CORE_V,
        /// <summary>Server Standard without Hyper-V (core installation) </summary>
        PRODUCT_STANDARD_SERVER_CORE_V = WinNTConstants.PRODUCT_STANDARD_SERVER_CORE_V,
        /// <summary>Server Enterprise without Hyper-V (core installation) </summary>
        PRODUCT_ENTERPRISE_SERVER_CORE_V = WinNTConstants.PRODUCT_ENTERPRISE_SERVER_CORE_V,
        /// <summary>Microsoft Hyper-V Server </summary>
        PRODUCT_HYPERV = WinNTConstants.PRODUCT_HYPERV,
        /// <summary>Storage Server Express (core installation) </summary>
        PRODUCT_STORAGE_EXPRESS_SERVER_CORE = WinNTConstants.PRODUCT_STORAGE_EXPRESS_SERVER_CORE,
        /// <summary>Storage Server Standard (core installation) </summary>
        PRODUCT_STORAGE_STANDARD_SERVER_CORE = WinNTConstants.PRODUCT_STORAGE_STANDARD_SERVER_CORE,
        /// <summary> Storage Server Workgroup (core installation) </summary>
        PRODUCT_STORAGE_WORKGROUP_SERVER_CORE = WinNTConstants.PRODUCT_STORAGE_WORKGROUP_SERVER_CORE,
        /// <summary>Storage Server Enterprise (core installation) </summary>
        PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE = WinNTConstants.PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE,
        /// <summary>Starter N </summary>
        PRODUCT_STARTER_N = WinNTConstants.PRODUCT_STARTER_N,
        /// <summary>Windows 10 Pro </summary>
        PRODUCT_PROFESSIONAL = WinNTConstants.PRODUCT_PROFESSIONAL,
        /// <summary>Windows 10 Pro N </summary>
        PRODUCT_PROFESSIONAL_N = WinNTConstants.PRODUCT_PROFESSIONAL_N,
        /// <summary>Windows Small Business Server 2011 Essentials </summary>
        PRODUCT_SB_SOLUTION_SERVER = WinNTConstants.PRODUCT_SB_SOLUTION_SERVER,
        /// <summary>Server For SB Solutions </summary>
        PRODUCT_SERVER_FOR_SB_SOLUTIONS = WinNTConstants.PRODUCT_SERVER_FOR_SB_SOLUTIONS,
        /// <summary> Server Solutions Premium </summary>
        PRODUCT_STANDARD_SERVER_SOLUTIONS = WinNTConstants.PRODUCT_STANDARD_SERVER_SOLUTIONS,
        /// <summary> Server Solutions Premium (core installation) </summary>
        PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE = WinNTConstants.PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE,
        /// <summary>Server For SB Solutions EM </summary>
        PRODUCT_SB_SOLUTION_SERVER_EM = WinNTConstants.PRODUCT_SB_SOLUTION_SERVER_EM,
        /// <summary>Server For SB Solutions EM </summary>
        PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM = WinNTConstants.PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM,
        /// <summary>Windows MultiPoint Server </summary>
        PRODUCT_SOLUTION_EMBEDDEDSERVER = WinNTConstants.PRODUCT_SOLUTION_EMBEDDEDSERVER,
        PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE = WinNTConstants.PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE,
        PRODUCT_PROFESSIONAL_EMBEDDED = WinNTConstants.PRODUCT_PROFESSIONAL_EMBEDDED,
        /// <summary>Windows Essential Server Solution Management </summary>
        PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT = WinNTConstants.PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT,
        /// <summary>Windows Essential Server Solution Additional </summary>
        PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL = WinNTConstants.PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL,
        /// <summary>Windows Essential Server Solution Management SVC </summary>
        PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC = WinNTConstants.PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC,
        /// <summary>Windows Essential Server Solution Additional SVC </summary>
        PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC = WinNTConstants.PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC,
        /// <summary>Small Business Server Premium (core installation) </summary>
        PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE = WinNTConstants.PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE,
        /// <summary>Server Hyper Core V </summary>
        PRODUCT_CLUSTER_SERVER_V = WinNTConstants.PRODUCT_CLUSTER_SERVER_V,
        PRODUCT_EMBEDDED = WinNTConstants.PRODUCT_EMBEDDED,
        /// <summary>Not supported </summary>
        PRODUCT_STARTER_E = WinNTConstants.PRODUCT_STARTER_E,
        /// <summary>Not supported </summary>
        PRODUCT_HOME_BASIC_E = WinNTConstants.PRODUCT_HOME_BASIC_E,
        /// <summary>Not supported </summary>
        PRODUCT_HOME_PREMIUM_E = WinNTConstants.PRODUCT_HOME_PREMIUM_E,
        /// <summary>Not supported </summary>
        PRODUCT_PROFESSIONAL_E = WinNTConstants.PRODUCT_PROFESSIONAL_E,
        /// <summary>Windows 10 Enterprise E </summary>
        PRODUCT_ENTERPRISE_E = WinNTConstants.PRODUCT_ENTERPRISE_E,
        /// <summary>Not supported </summary>
        PRODUCT_ULTIMATE_E = WinNTConstants.PRODUCT_ULTIMATE_E,
        /// <summary>Windows 10 Enterprise Evaluation </summary>
        PRODUCT_ENTERPRISE_EVALUATION = WinNTConstants.PRODUCT_ENTERPRISE_EVALUATION,
        /// <summary>Windows MultiPoint Server Standard (full installation) </summary>
        PRODUCT_MULTIPOINT_STANDARD_SERVER = WinNTConstants.PRODUCT_MULTIPOINT_STANDARD_SERVER,
        /// <summary>Windows MultiPoint Server Premium (full installation) </summary>
        PRODUCT_MULTIPOINT_PREMIUM_SERVER = WinNTConstants.PRODUCT_MULTIPOINT_PREMIUM_SERVER,
        /// <summary>Server Standard (evaluation installation) </summary>
        PRODUCT_STANDARD_EVALUATION_SERVER = WinNTConstants.PRODUCT_STANDARD_EVALUATION_SERVER,
        /// <summary>Server Datacenter (evaluation installation) </summary>
        PRODUCT_DATACENTER_EVALUATION_SERVER = WinNTConstants.PRODUCT_DATACENTER_EVALUATION_SERVER,
        /// <summary>Windows 10 Enterprise N Evaluation </summary>
        PRODUCT_ENTERPRISE_N_EVALUATION = WinNTConstants.PRODUCT_ENTERPRISE_N_EVALUATION,
        PRODUCT_EMBEDDED_AUTOMOTIVE = WinNTConstants.PRODUCT_EMBEDDED_AUTOMOTIVE,
        PRODUCT_EMBEDDED_INDUSTRY_A = WinNTConstants.PRODUCT_EMBEDDED_INDUSTRY_A,
        PRODUCT_THINPC = WinNTConstants.PRODUCT_THINPC,
        PRODUCT_EMBEDDED_A = WinNTConstants.PRODUCT_EMBEDDED_A,
        PRODUCT_EMBEDDED_INDUSTRY = WinNTConstants.PRODUCT_EMBEDDED_INDUSTRY,
        PRODUCT_EMBEDDED_E = WinNTConstants.PRODUCT_EMBEDDED_E,
        PRODUCT_EMBEDDED_INDUSTRY_E = WinNTConstants.PRODUCT_EMBEDDED_INDUSTRY_E,
        PRODUCT_EMBEDDED_INDUSTRY_A_E = WinNTConstants.PRODUCT_EMBEDDED_INDUSTRY_A_E,
        /// <summary>Storage Server Workgroup (evaluation installation) </summary>
        PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER = WinNTConstants.PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER,
        /// <summary>Storage Server Standard (evaluation installation) </summary>
        PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER = WinNTConstants.PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER,
        PRODUCT_CORE_ARM = WinNTConstants.PRODUCT_CORE_ARM,
        /// <summary>Windows 10 Home N </summary>
        PRODUCT_CORE_N = WinNTConstants.PRODUCT_CORE_N,
        /// <summary>Windows 10 Home China </summary>
        PRODUCT_CORE_COUNTRYSPECIFIC = WinNTConstants.PRODUCT_CORE_COUNTRYSPECIFIC,
        /// <summary>Windows 10 Home Single Language </summary>
        PRODUCT_CORE_SINGLELANGUAGE = WinNTConstants.PRODUCT_CORE_SINGLELANGUAGE,
        /// <summary>Windows 10 Home </summary>
        PRODUCT_CORE = WinNTConstants.PRODUCT_CORE,
        /// <summary>Professional with Media Center </summary>
        PRODUCT_PROFESSIONAL_WMC = WinNTConstants.PRODUCT_PROFESSIONAL_WMC,
        /// <summary>Windows 10 Mobile </summary>
        PRODUCT_MOBILE_CORE = WinNTConstants.PRODUCT_MOBILE_CORE,
        PRODUCT_EMBEDDED_INDUSTRY_EVAL = WinNTConstants.PRODUCT_EMBEDDED_INDUSTRY_EVAL,
        PRODUCT_EMBEDDED_INDUSTRY_E_EVAL = WinNTConstants.PRODUCT_EMBEDDED_INDUSTRY_E_EVAL,
        PRODUCT_EMBEDDED_EVAL = WinNTConstants.PRODUCT_EMBEDDED_EVAL,
        PRODUCT_EMBEDDED_E_EVAL = WinNTConstants.PRODUCT_EMBEDDED_E_EVAL,
        PRODUCT_NANO_SERVER = WinNTConstants.PRODUCT_NANO_SERVER,
        PRODUCT_CLOUD_STORAGE_SERVER = WinNTConstants.PRODUCT_CLOUD_STORAGE_SERVER,
        PRODUCT_CORE_CONNECTED = WinNTConstants.PRODUCT_CORE_CONNECTED,
        PRODUCT_PROFESSIONAL_STUDENT = WinNTConstants.PRODUCT_PROFESSIONAL_STUDENT,
        PRODUCT_CORE_CONNECTED_N = WinNTConstants.PRODUCT_CORE_CONNECTED_N,
        PRODUCT_PROFESSIONAL_STUDENT_N = WinNTConstants.PRODUCT_PROFESSIONAL_STUDENT_N,
        PRODUCT_CORE_CONNECTED_SINGLELANGUAGE = WinNTConstants.PRODUCT_CORE_CONNECTED_SINGLELANGUAGE,
        PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC = WinNTConstants.PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC,
        PRODUCT_CONNECTED_CAR = WinNTConstants.PRODUCT_CONNECTED_CAR,
        PRODUCT_INDUSTRY_HANDHELD = WinNTConstants.PRODUCT_INDUSTRY_HANDHELD,
        PRODUCT_PPI_PRO = WinNTConstants.PRODUCT_PPI_PRO,
        PRODUCT_ARM64_SERVER = WinNTConstants.PRODUCT_ARM64_SERVER,
        /// <summary>Windows 10 Education </summary>
        PRODUCT_EDUCATION = WinNTConstants.PRODUCT_EDUCATION,
        /// <summary>Windows 10 Education N </summary>
        PRODUCT_EDUCATION_N = WinNTConstants.PRODUCT_EDUCATION_N,
        /// <summary>Windows 10 IoT Core </summary>
        PRODUCT_IOTUAP = WinNTConstants.PRODUCT_IOTUAP,
        PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER = WinNTConstants.PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER,
        /// <summary>Windows 10 Enterprise 2015 LTSB </summary>
        PRODUCT_ENTERPRISE_S = WinNTConstants.PRODUCT_ENTERPRISE_S,
        /// <summary> Windows 10 Enterprise 2015 LTSB N</summary>
        PRODUCT_ENTERPRISE_S_N = WinNTConstants.PRODUCT_ENTERPRISE_S_N,
        PRODUCT_PROFESSIONAL_S = WinNTConstants.PRODUCT_PROFESSIONAL_S,
        PRODUCT_PROFESSIONAL_S_N = WinNTConstants.PRODUCT_PROFESSIONAL_S_N,
        /// <summary>Windows 10 Enterprise 2015 LTSB Evaluation </summary>
        PRODUCT_ENTERPRISE_S_EVALUATION = WinNTConstants.PRODUCT_ENTERPRISE_S_EVALUATION,
        /// <summary> Windows 10 Enterprise 2015 LTSB N Evaluation </summary>
        PRODUCT_ENTERPRISE_S_N_EVALUATION = WinNTConstants.PRODUCT_ENTERPRISE_S_N_EVALUATION,
        /// <summary>Windows 10 IoT Core Commercial </summary>
        PRODUCT_IOTUAPCOMMERCIAL = WinNTConstants.PRODUCT_IOTUAPCOMMERCIAL,
        /// <summary> Windows 10 Mobile Enterprise </summary>
        PRODUCT_MOBILE_ENTERPRISE = WinNTConstants.PRODUCT_MOBILE_ENTERPRISE,
        PRODUCT_HOLOGRAPHIC = WinNTConstants.PRODUCT_HOLOGRAPHIC,
        PRODUCT_PRO_SINGLE_LANGUAGE = WinNTConstants.PRODUCT_PRO_SINGLE_LANGUAGE,
        PRODUCT_PRO_CHINA = WinNTConstants.PRODUCT_PRO_CHINA,
        PRODUCT_ENTERPRISE_SUBSCRIPTION = WinNTConstants.PRODUCT_ENTERPRISE_SUBSCRIPTION,
        PRODUCT_ENTERPRISE_SUBSCRIPTION_N = WinNTConstants.PRODUCT_ENTERPRISE_SUBSCRIPTION_N,
        PRODUCT_DATACENTER_NANO_SERVER = WinNTConstants.PRODUCT_DATACENTER_NANO_SERVER,
        PRODUCT_STANDARD_NANO_SERVER = WinNTConstants.PRODUCT_STANDARD_NANO_SERVER,
        /// <summary>Server Datacenter, Semi-Annual Channel (core installation) </summary>
        PRODUCT_DATACENTER_A_SERVER_CORE = WinNTConstants.PRODUCT_DATACENTER_A_SERVER_CORE,
        /// <summary>Server Standard, Semi-Annual Channel (core installation) </summary>
        PRODUCT_STANDARD_A_SERVER_CORE = WinNTConstants.PRODUCT_STANDARD_A_SERVER_CORE,
        PRODUCT_DATACENTER_WS_SERVER_CORE = WinNTConstants.PRODUCT_DATACENTER_WS_SERVER_CORE,
        PRODUCT_STANDARD_WS_SERVER_CORE = WinNTConstants.PRODUCT_STANDARD_WS_SERVER_CORE,
        PRODUCT_UTILITY_VM = WinNTConstants.PRODUCT_UTILITY_VM,
        PRODUCT_DATACENTER_EVALUATION_SERVER_CORE = WinNTConstants.PRODUCT_DATACENTER_EVALUATION_SERVER_CORE,
        PRODUCT_STANDARD_EVALUATION_SERVER_CORE = WinNTConstants.PRODUCT_STANDARD_EVALUATION_SERVER_CORE,
        /// <summary>Windows 10 Pro for Workstations </summary>
        PRODUCT_PRO_WORKSTATION = WinNTConstants.PRODUCT_PRO_WORKSTATION,
        /// <summary>Windows 10 Pro for Workstations N</summary>
        PRODUCT_PRO_WORKSTATION_N = WinNTConstants.PRODUCT_PRO_WORKSTATION_N,
        PRODUCT_PRO_FOR_EDUCATION = WinNTConstants.PRODUCT_PRO_FOR_EDUCATION,
        PRODUCT_PRO_FOR_EDUCATION_N = WinNTConstants.PRODUCT_PRO_FOR_EDUCATION_N,
        PRODUCT_AZURE_SERVER_CORE = WinNTConstants.PRODUCT_AZURE_SERVER_CORE,
        PRODUCT_AZURE_NANO_SERVER = WinNTConstants.PRODUCT_AZURE_NANO_SERVER,
        PRODUCT_ENTERPRISEG = WinNTConstants.PRODUCT_ENTERPRISEG,
        PRODUCT_ENTERPRISEGN = WinNTConstants.PRODUCT_ENTERPRISEGN,
        PRODUCT_SERVERRDSH = WinNTConstants.PRODUCT_SERVERRDSH,
        PRODUCT_CLOUD = WinNTConstants.PRODUCT_CLOUD,
        PRODUCT_CLOUDN = WinNTConstants.PRODUCT_CLOUDN,
        PRODUCT_HUBOS = WinNTConstants.PRODUCT_HUBOS,
        PRODUCT_ONECOREUPDATEOS = WinNTConstants.PRODUCT_ONECOREUPDATEOS,
        PRODUCT_ANDROMEDA = WinNTConstants.PRODUCT_ANDROMEDA,

        PRODUCT_UNLICENSED = WinNTConstants.PRODUCT_UNLICENSED,
    }
}

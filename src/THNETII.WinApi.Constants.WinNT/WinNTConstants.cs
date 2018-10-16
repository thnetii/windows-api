using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.WinNT
{
    using static WinNTMacros;

    public static class WinNTConstants
    {
        public const int ANYSIZE_ARRAY = 1;

        public static readonly int MAX_NATURAL_ALIGNMENT = IntPtr.Size;

        // #if defined(_WIN64) || defined(_M_ALPHA)
        // public const int MEMORY_ALLOCATION_ALIGNMENT = 16;
        // #else
        // public const int MEMORY_ALLOCATION_ALIGNMENT = 8;
        // #endif

        // #if defined(_AMD64_) || defined(_X86_)
        // public const int SYSTEM_CACHE_ALIGNMENT_SIZE = 64;
        // #else
        // public const int SYSTEM_CACHE_ALIGNMENT_SIZE = 128;
        // #endif

        public const int ALL_PROCESSOR_GROUPS = 0xffff;

        private static int GET_MAXIMUM_PROC_PER_GROUP()
        {
            switch (RuntimeInformation.OSArchitecture)
            {
                case Architecture.X86:
                case Architecture.Arm:
                    return 32;
                case Architecture.X64:
                case Architecture.Arm64:
                    return 64;
                default: return default;
            }
        }

        public static readonly int MAXIMUM_PROC_PER_GROUP = GET_MAXIMUM_PROC_PER_GROUP();

        public static readonly int MAXIMUM_PROCESSORS = MAXIMUM_PROC_PER_GROUP;

        public const int APPLICATION_ERROR_MASK = 0x20000000;
        public const int ERROR_SEVERITY_SUCCESS = 0x00000000;
        public const int ERROR_SEVERITY_INFORMATIONAL = 0x40000000;
        public const int ERROR_SEVERITY_WARNING = unchecked((int)0x80000000);
        public const int ERROR_SEVERITY_ERROR = unchecked((int)0xC0000000);

        public const int UNICODE_STRING_MAX_BYTES = 65534;
        public const int UNICODE_STRING_MAX_CHARS = 32767;

        public const int VER_SERVER_NT = unchecked((int)0x80000000);
        public const int VER_WORKSTATION_NT = 0x40000000;
        public const int VER_SUITE_SMALLBUSINESS = 0x00000001;
        public const int VER_SUITE_ENTERPRISE = 0x00000002;
        public const int VER_SUITE_BACKOFFICE = 0x00000004;
        public const int VER_SUITE_COMMUNICATIONS = 0x00000008;
        public const int VER_SUITE_TERMINAL = 0x00000010;
        public const int VER_SUITE_SMALLBUSINESS_RESTRICTED = 0x00000020;
        public const int VER_SUITE_EMBEDDEDNT = 0x00000040;
        public const int VER_SUITE_DATACENTER = 0x00000080;
        public const int VER_SUITE_SINGLEUSERTS = 0x00000100;
        public const int VER_SUITE_PERSONAL = 0x00000200;
        public const int VER_SUITE_BLADE = 0x00000400;
        public const int VER_SUITE_EMBEDDED_RESTRICTED = 0x00000800;
        public const int VER_SUITE_SECURITY_APPLIANCE = 0x00001000;
        public const int VER_SUITE_STORAGE_SERVER = 0x00002000;
        public const int VER_SUITE_COMPUTE_SERVER = 0x00004000;
        public const int VER_SUITE_WH_SERVER = 0x00008000;
        public const int VER_SUITE_MULTIUSERTS = 0x00020000;

        //
        // Product types
        // This list grows with each OS release.
        //
        // There is no ordering of values to ensure callers
        // do an equality test i.e. greater-than and less-than
        // comparisons are not useful.
        //
        // NOTE: Values in this list should never be deleted.
        //       When a product-type 'X' gets dropped from a
        //       OS release onwards, the value of 'X' continues
        //       to be used in the mapping table of GetProductInfo.
        //

        public const int PRODUCT_UNDEFINED = 0x00000000;

        public const int PRODUCT_ULTIMATE = 0x00000001;
        public const int PRODUCT_HOME_BASIC = 0x00000002;
        public const int PRODUCT_HOME_PREMIUM = 0x00000003;
        public const int PRODUCT_ENTERPRISE = 0x00000004;
        public const int PRODUCT_HOME_BASIC_N = 0x00000005;
        public const int PRODUCT_BUSINESS = 0x00000006;
        public const int PRODUCT_STANDARD_SERVER = 0x00000007;
        public const int PRODUCT_DATACENTER_SERVER = 0x00000008;
        public const int PRODUCT_SMALLBUSINESS_SERVER = 0x00000009;
        public const int PRODUCT_ENTERPRISE_SERVER = 0x0000000A;
        public const int PRODUCT_STARTER = 0x0000000B;
        public const int PRODUCT_DATACENTER_SERVER_CORE = 0x0000000C;
        public const int PRODUCT_STANDARD_SERVER_CORE = 0x0000000D;
        public const int PRODUCT_ENTERPRISE_SERVER_CORE = 0x0000000E;
        public const int PRODUCT_ENTERPRISE_SERVER_IA64 = 0x0000000F;
        public const int PRODUCT_BUSINESS_N = 0x00000010;
        public const int PRODUCT_WEB_SERVER = 0x00000011;
        public const int PRODUCT_CLUSTER_SERVER = 0x00000012;
        public const int PRODUCT_HOME_SERVER = 0x00000013;
        public const int PRODUCT_STORAGE_EXPRESS_SERVER = 0x00000014;
        public const int PRODUCT_STORAGE_STANDARD_SERVER = 0x00000015;
        public const int PRODUCT_STORAGE_WORKGROUP_SERVER = 0x00000016;
        public const int PRODUCT_STORAGE_ENTERPRISE_SERVER = 0x00000017;
        public const int PRODUCT_SERVER_FOR_SMALLBUSINESS = 0x00000018;
        public const int PRODUCT_SMALLBUSINESS_SERVER_PREMIUM = 0x00000019;
        public const int PRODUCT_HOME_PREMIUM_N = 0x0000001A;
        public const int PRODUCT_ENTERPRISE_N = 0x0000001B;
        public const int PRODUCT_ULTIMATE_N = 0x0000001C;
        public const int PRODUCT_WEB_SERVER_CORE = 0x0000001D;
        public const int PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT = 0x0000001E;
        public const int PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY = 0x0000001F;
        public const int PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING = 0x00000020;
        public const int PRODUCT_SERVER_FOUNDATION = 0x00000021;
        public const int PRODUCT_HOME_PREMIUM_SERVER = 0x00000022;
        public const int PRODUCT_SERVER_FOR_SMALLBUSINESS_V = 0x00000023;
        public const int PRODUCT_STANDARD_SERVER_V = 0x00000024;
        public const int PRODUCT_DATACENTER_SERVER_V = 0x00000025;
        public const int PRODUCT_ENTERPRISE_SERVER_V = 0x00000026;
        public const int PRODUCT_DATACENTER_SERVER_CORE_V = 0x00000027;
        public const int PRODUCT_STANDARD_SERVER_CORE_V = 0x00000028;
        public const int PRODUCT_ENTERPRISE_SERVER_CORE_V = 0x00000029;
        public const int PRODUCT_HYPERV = 0x0000002A;
        public const int PRODUCT_STORAGE_EXPRESS_SERVER_CORE = 0x0000002B;
        public const int PRODUCT_STORAGE_STANDARD_SERVER_CORE = 0x0000002C;
        public const int PRODUCT_STORAGE_WORKGROUP_SERVER_CORE = 0x0000002D;
        public const int PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE = 0x0000002E;
        public const int PRODUCT_STARTER_N = 0x0000002F;
        public const int PRODUCT_PROFESSIONAL = 0x00000030;
        public const int PRODUCT_PROFESSIONAL_N = 0x00000031;
        public const int PRODUCT_SB_SOLUTION_SERVER = 0x00000032;
        public const int PRODUCT_SERVER_FOR_SB_SOLUTIONS = 0x00000033;
        public const int PRODUCT_STANDARD_SERVER_SOLUTIONS = 0x00000034;
        public const int PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE = 0x00000035;
        public const int PRODUCT_SB_SOLUTION_SERVER_EM = 0x00000036;
        public const int PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM = 0x00000037;
        public const int PRODUCT_SOLUTION_EMBEDDEDSERVER = 0x00000038;
        public const int PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE = 0x00000039;
        public const int PRODUCT_PROFESSIONAL_EMBEDDED = 0x0000003A;
        public const int PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT = 0x0000003B;
        public const int PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL = 0x0000003C;
        public const int PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC = 0x0000003D;
        public const int PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC = 0x0000003E;
        public const int PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE = 0x0000003F;
        public const int PRODUCT_CLUSTER_SERVER_V = 0x00000040;
        public const int PRODUCT_EMBEDDED = 0x00000041;
        public const int PRODUCT_STARTER_E = 0x00000042;
        public const int PRODUCT_HOME_BASIC_E = 0x00000043;
        public const int PRODUCT_HOME_PREMIUM_E = 0x00000044;
        public const int PRODUCT_PROFESSIONAL_E = 0x00000045;
        public const int PRODUCT_ENTERPRISE_E = 0x00000046;
        public const int PRODUCT_ULTIMATE_E = 0x00000047;
        public const int PRODUCT_ENTERPRISE_EVALUATION = 0x00000048;
        public const int PRODUCT_MULTIPOINT_STANDARD_SERVER = 0x0000004C;
        public const int PRODUCT_MULTIPOINT_PREMIUM_SERVER = 0x0000004D;
        public const int PRODUCT_STANDARD_EVALUATION_SERVER = 0x0000004F;
        public const int PRODUCT_DATACENTER_EVALUATION_SERVER = 0x00000050;
        public const int PRODUCT_ENTERPRISE_N_EVALUATION = 0x00000054;
        public const int PRODUCT_EMBEDDED_AUTOMOTIVE = 0x00000055;
        public const int PRODUCT_EMBEDDED_INDUSTRY_A = 0x00000056;
        public const int PRODUCT_THINPC = 0x00000057;
        public const int PRODUCT_EMBEDDED_A = 0x00000058;
        public const int PRODUCT_EMBEDDED_INDUSTRY = 0x00000059;
        public const int PRODUCT_EMBEDDED_E = 0x0000005A;
        public const int PRODUCT_EMBEDDED_INDUSTRY_E = 0x0000005B;
        public const int PRODUCT_EMBEDDED_INDUSTRY_A_E = 0x0000005C;
        public const int PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER = 0x0000005F;
        public const int PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER = 0x00000060;
        public const int PRODUCT_CORE_ARM = 0x00000061;
        public const int PRODUCT_CORE_N = 0x00000062;
        public const int PRODUCT_CORE_COUNTRYSPECIFIC = 0x00000063;
        public const int PRODUCT_CORE_SINGLELANGUAGE = 0x00000064;
        public const int PRODUCT_CORE = 0x00000065;
        public const int PRODUCT_PROFESSIONAL_WMC = 0x00000067;
        public const int PRODUCT_EMBEDDED_INDUSTRY_EVAL = 0x00000069;
        public const int PRODUCT_EMBEDDED_INDUSTRY_E_EVAL = 0x0000006A;
        public const int PRODUCT_EMBEDDED_EVAL = 0x0000006B;
        public const int PRODUCT_EMBEDDED_E_EVAL = 0x0000006C;
        public const int PRODUCT_NANO_SERVER = 0x0000006D;
        public const int PRODUCT_CLOUD_STORAGE_SERVER = 0x0000006E;
        public const int PRODUCT_CORE_CONNECTED = 0x0000006F;
        public const int PRODUCT_PROFESSIONAL_STUDENT = 0x00000070;
        public const int PRODUCT_CORE_CONNECTED_N = 0x00000071;
        public const int PRODUCT_PROFESSIONAL_STUDENT_N = 0x00000072;
        public const int PRODUCT_CORE_CONNECTED_SINGLELANGUAGE = 0x00000073;
        public const int PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC = 0x00000074;
        public const int PRODUCT_CONNECTED_CAR = 0x00000075;
        public const int PRODUCT_INDUSTRY_HANDHELD = 0x00000076;
        public const int PRODUCT_PPI_PRO = 0x00000077;
        public const int PRODUCT_ARM64_SERVER = 0x00000078;
        public const int PRODUCT_EDUCATION = 0x00000079;
        public const int PRODUCT_EDUCATION_N = 0x0000007A;
        public const int PRODUCT_IOTUAP = 0x0000007B;
        public const int PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER = 0x0000007C;
        public const int PRODUCT_ENTERPRISE_S = 0x0000007D;
        public const int PRODUCT_ENTERPRISE_S_N = 0x0000007E;
        public const int PRODUCT_PROFESSIONAL_S = 0x0000007F;
        public const int PRODUCT_PROFESSIONAL_S_N = 0x00000080;
        public const int PRODUCT_ENTERPRISE_S_EVALUATION = 0x00000081;
        public const int PRODUCT_ENTERPRISE_S_N_EVALUATION = 0x00000082;
        public const int PRODUCT_HOLOGRAPHIC = 0x00000087;
        public const int PRODUCT_PRO_SINGLE_LANGUAGE = 0x0000008A;
        public const int PRODUCT_PRO_CHINA = 0x0000008B;
        public const int PRODUCT_ENTERPRISE_SUBSCRIPTION = 0x0000008C;
        public const int PRODUCT_ENTERPRISE_SUBSCRIPTION_N = 0x0000008D;
        public const int PRODUCT_DATACENTER_NANO_SERVER = 0x0000008F;
        public const int PRODUCT_STANDARD_NANO_SERVER = 0x00000090;
        public const int PRODUCT_DATACENTER_A_SERVER_CORE = 0x00000091;
        public const int PRODUCT_STANDARD_A_SERVER_CORE = 0x00000092;
        public const int PRODUCT_DATACENTER_WS_SERVER_CORE = 0x00000093;
        public const int PRODUCT_STANDARD_WS_SERVER_CORE = 0x00000094;
        public const int PRODUCT_UTILITY_VM = 0x00000095;
        public const int PRODUCT_DATACENTER_EVALUATION_SERVER_CORE = 0x0000009F;
        public const int PRODUCT_STANDARD_EVALUATION_SERVER_CORE = 0x000000A0;
        public const int PRODUCT_PRO_WORKSTATION = 0x000000A1;
        public const int PRODUCT_PRO_WORKSTATION_N = 0x000000A2;
        public const int PRODUCT_PRO_FOR_EDUCATION = 0x000000A4;
        public const int PRODUCT_PRO_FOR_EDUCATION_N = 0x000000A5;
        public const int PRODUCT_AZURE_SERVER_CORE = 0x000000A8;
        public const int PRODUCT_AZURE_NANO_SERVER = 0x000000A9;
        public const int PRODUCT_ENTERPRISEG = 0x000000AB;
        public const int PRODUCT_ENTERPRISEGN = 0x000000AC;
        public const int PRODUCT_SERVERRDSH = 0x000000AF;
        public const int PRODUCT_CLOUD = 0x000000B2;
        public const int PRODUCT_CLOUDN = 0x000000B3;
        public const int PRODUCT_HUBOS = 0x000000B4;
        public const int PRODUCT_ONECOREUPDATEOS = 0x000000B6;
        public const int PRODUCT_ANDROMEDA = 0x000000B8;

        public const int PRODUCT_UNLICENSED = unchecked((int)0xABCDABCD);

        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        //  DEPRECATED: The Language ID  concept is deprecated, please use
        //  Locale Names instead, eg: "en" instead of a LANGID like 0x09.
        //  See the documentation for GetLocaleInfoEx.
        //
        //  Note that the named locale APIs (eg GetLocaleInfoEx) are preferred.
        //
        //  WARNING: Not all locales/languages have unique Language IDs
        //
        //  The following two combinations of primary language ID and
        //  sublanguage ID have special semantics:
        //
        //    Primary Language ID   Sublanguage ID      Result
        //    -------------------   ---------------     ------------------------
        //    LANG_NEUTRAL          SUBLANG_NEUTRAL     Language neutral
        //    LANG_NEUTRAL          SUBLANG_DEFAULT     User default language
        //    LANG_NEUTRAL          SUBLANG_SYS_DEFAULT System default language
        //    LANG_INVARIANT        SUBLANG_NEUTRAL     Invariant locale
        //
        //  This concept is deprecated.  It is strongly recommended that
        //  applications test for locale names instead of Language IDs / LCIDs.
        //
        //  Primary language IDs.
        //
        //  WARNING: This pattern is broken and not followed for all languages.
        //           Serbian, Bosnian & Croatian are a few examples.
        //
        //  WARNING: There are > 6000 human languages.  The PRIMARYLANGID construct
        //           cannot support all languages your application may encounter.
        //           Please use Language Names, such as "en".
        //
        //  WARNING: Some languages may have more than one PRIMARYLANGID.  Please
        //           use Locale Names, such as "en-FJ".
        //
        //  WARNING: Some languages do not have assigned LANGIDs.  Please use
        //           Locale Names, such as "tlh-Piqd".
        //
        //  It is recommended that applications test for locale names or actual LCIDs.
        //
        //  Note that the LANG, SUBLANG construction is not always consistent.
        //  The named locale APIs (eg GetLocaleInfoEx) are recommended.
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        public const int LANG_NEUTRAL = 0x00;
        public const int LANG_INVARIANT = 0x7f;

        public const int LANG_AFRIKAANS = 0x36;
        public const int LANG_ALBANIAN = 0x1c;
        public const int LANG_ALSATIAN = 0x84;
        public const int LANG_AMHARIC = 0x5e;
        public const int LANG_ARABIC = 0x01;
        public const int LANG_ARMENIAN = 0x2b;
        public const int LANG_ASSAMESE = 0x4d;
        /// <summary>for Azerbaijani, <see cref="LANG_AZERBAIJANI"/> is preferred</summary>
        public const int LANG_AZERI = 0x2c;
        public const int LANG_AZERBAIJANI = 0x2c;
        public const int LANG_BANGLA = 0x45;
        public const int LANG_BASHKIR = 0x6d;
        public const int LANG_BASQUE = 0x2d;
        public const int LANG_BELARUSIAN = 0x23;
        /// <summary>Some prefer to use <see cref="LANG_BANGLA"/></summary>
        public const int LANG_BENGALI = 0x45;
        public const int LANG_BRETON = 0x7e;
        /// <summary>Use with <strong>SUBLANG_BOSNIAN_*</strong> Sublanguage IDs</summary>
        public const int LANG_BOSNIAN = 0x1a;
        /// <summary>Use with the <see cref="ConvertDefaultLocale"/> function</summary>
        public const int LANG_BOSNIAN_NEUTRAL = 0x781a;
        public const int LANG_BULGARIAN = 0x02;
        public const int LANG_CATALAN = 0x03;
        public const int LANG_CENTRAL_KURDISH = 0x92;
        public const int LANG_CHEROKEE = 0x5c;
        /// <summary>Use with <strong>SUBLANG_CHINESE_*</strong> Sublanguage IDs</summary>
        public const int LANG_CHINESE = 0x04;
        /// <summary>Use with the <see cref="ConvertDefaultLocale"/> function</summary>
        public const int LANG_CHINESE_SIMPLIFIED = 0x04;
        /// <summary>Use with the <see cref="ConvertDefaultLocale"/> function</summary>
        public const int LANG_CHINESE_TRADITIONAL = 0x7c04;
        public const int LANG_CORSICAN = 0x83;
        public const int LANG_CROATIAN = 0x1a;
        public const int LANG_CZECH = 0x05;
        public const int LANG_DANISH = 0x06;
        public const int LANG_DARI = 0x8c;
        public const int LANG_DIVEHI = 0x65;
        public const int LANG_DUTCH = 0x13;
        public const int LANG_ENGLISH = 0x09;
        public const int LANG_ESTONIAN = 0x25;
        public const int LANG_FAEROESE = 0x38;
        [Obsolete("use LANG_PERSIAN instead")]
        public const int LANG_FARSI = 0x29;
        public const int LANG_FILIPINO = 0x64;
        public const int LANG_FINNISH = 0x0b;
        public const int LANG_FRENCH = 0x0c;
        public const int LANG_FRISIAN = 0x62;
        public const int LANG_FULAH = 0x67;
        public const int LANG_GALICIAN = 0x56;
        public const int LANG_GEORGIAN = 0x37;
        public const int LANG_GERMAN = 0x07;
        public const int LANG_GREEK = 0x08;
        public const int LANG_GREENLANDIC = 0x6f;
        public const int LANG_GUJARATI = 0x47;
        public const int LANG_HAUSA = 0x68;
        public const int LANG_HAWAIIAN = 0x75;
        public const int LANG_HEBREW = 0x0d;
        public const int LANG_HINDI = 0x39;
        public const int LANG_HUNGARIAN = 0x0e;
        public const int LANG_ICELANDIC = 0x0f;
        public const int LANG_IGBO = 0x70;
        public const int LANG_INDONESIAN = 0x21;
        public const int LANG_INUKTITUT = 0x5d;
        /// <summary>Use with the <see cref="SUBLANG_IRISH_IRELAND"/> Sublanguage ID</summary>
        public const int LANG_IRISH = 0x3c;
        public const int LANG_ITALIAN = 0x10;
        public const int LANG_JAPANESE = 0x11;
        public const int LANG_KANNADA = 0x4b;
        public const int LANG_KASHMIRI = 0x60;
        public const int LANG_KAZAK = 0x3f;
        public const int LANG_KHMER = 0x53;
        public const int LANG_KICHE = 0x86;
        public const int LANG_KINYARWANDA = 0x87;
        public const int LANG_KONKANI = 0x57;
        public const int LANG_KOREAN = 0x12;
        public const int LANG_KYRGYZ = 0x40;
        public const int LANG_LAO = 0x54;
        public const int LANG_LATVIAN = 0x26;
        public const int LANG_LITHUANIAN = 0x27;
        public const int LANG_LOWER_SORBIAN = 0x2e;
        public const int LANG_LUXEMBOURGISH = 0x6e;
        /// <summary>the Former Yugoslav Republic of Macedonia</summary>
        public const int LANG_MACEDONIAN = 0x2f;
        public const int LANG_MALAY = 0x3e;
        public const int LANG_MALAYALAM = 0x4c;
        public const int LANG_MALTESE = 0x3a;
        public const int LANG_MANIPURI = 0x58;
        public const int LANG_MAORI = 0x81;
        public const int LANG_MAPUDUNGUN = 0x7a;
        public const int LANG_MARATHI = 0x4e;
        public const int LANG_MOHAWK = 0x7c;
        public const int LANG_MONGOLIAN = 0x50;
        public const int LANG_NEPALI = 0x61;
        public const int LANG_NORWEGIAN = 0x14;
        public const int LANG_OCCITAN = 0x82;
        public const int LANG_ODIA = 0x48;
        [Obsolete("use LANG_ODIA, instead.")]
        public const int LANG_ORIYA = 0x48;
        public const int LANG_PASHTO = 0x63;
        public const int LANG_PERSIAN = 0x29;
        public const int LANG_POLISH = 0x15;
        public const int LANG_PORTUGUESE = 0x16;
        [Obsolete("use LANG_FULAH instead")]
        public const int LANG_PULAR = 0x67;
        public const int LANG_PUNJABI = 0x46;
        public const int LANG_QUECHUA = 0x6b;
        public const int LANG_ROMANIAN = 0x18;
        public const int LANG_ROMANSH = 0x17;
        public const int LANG_RUSSIAN = 0x19;
        public const int LANG_SAKHA = 0x85;
        public const int LANG_SAMI = 0x3b;
        public const int LANG_SANSKRIT = 0x4f;
        public const int LANG_SCOTTISH_GAELIC = 0x91;
        /// <summary>Use with the <strong>SUBLANG_SERBIAN_*</strong> Sublanguage IDs</summary>
        public const int LANG_SERBIAN = 0x1a;
        /// <summary>Use with the <see cref="ConvertDefaultLocale"/> function</summary>
        public const int LANG_SERBIAN_NEUTRAL = 0x7c1a;
        public const int LANG_SINDHI = 0x59;
        public const int LANG_SINHALESE = 0x5b;
        public const int LANG_SLOVAK = 0x1b;
        public const int LANG_SLOVENIAN = 0x24;
        public const int LANG_SOTHO = 0x6c;
        public const int LANG_SPANISH = 0x0a;
        public const int LANG_SWAHILI = 0x41;
        public const int LANG_SWEDISH = 0x1d;
        public const int LANG_SYRIAC = 0x5a;
        public const int LANG_TAJIK = 0x28;
        public const int LANG_TAMAZIGHT = 0x5f;
        public const int LANG_TAMIL = 0x49;
        public const int LANG_TATAR = 0x44;
        public const int LANG_TELUGU = 0x4a;
        public const int LANG_THAI = 0x1e;
        public const int LANG_TIBETAN = 0x51;
        public const int LANG_TIGRIGNA = 0x73;
        /// <summary>Preferred spelling in locale</summary>
        public const int LANG_TIGRINYA = 0x73;
        public const int LANG_TSWANA = 0x32;
        public const int LANG_TURKISH = 0x1f;
        public const int LANG_TURKMEN = 0x42;
        public const int LANG_UIGHUR = 0x80;
        public const int LANG_UKRAINIAN = 0x22;
        public const int LANG_UPPER_SORBIAN = 0x2e;
        public const int LANG_URDU = 0x20;
        public const int LANG_UZBEK = 0x43;
        public const int LANG_VALENCIAN = 0x03;
        public const int LANG_VIETNAMESE = 0x2a;
        public const int LANG_WELSH = 0x52;
        public const int LANG_WOLOF = 0x88;
        public const int LANG_XHOSA = 0x34;
        [Obsolete("use LANG_SAKHA,instead")]
        public const int LANG_YAKUT = 0x85;
        public const int LANG_YI = 0x78;
        public const int LANG_YORUBA = 0x6a;
        public const int LANG_ZULU = 0x35;

        // 
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        //  DEPRECATED: The Sublanguage ID concept is deprecated, please use
        //  Locale Names instead, eg: "en-US" instead of an LCID like 0x0409.
        //  See the documentation for GetLocaleInfoEx.
        //
        //  The name immediately following SUBLANG_ dictates which primary
        //  language ID that sublanguage ID can be combined with to form a
        //  valid language ID.
        //
        //  Note that the LANG, SUBLANG construction is not always consistent.
        //  The named locale APIs (eg GetLocaleInfoEx) are recommended.
        //
        //  WARNING: The pattern is broken and not followed for all languages.
        //           Serbian, Bosnian & Croatian are a few examples.
        //
        //  WARNING: The "SUBLANG" depends on the primary language and is inconsistent.
        //           SUBLANG_ENGLISH_US is 0x1 and SUBLANG_SPANISH_US is 0x15, so
        //           it is impossible to determine region merely by inspecting the
        //           SUBLANG.  Please use Locale Names such as "en-US" instead.
        //
        //  WARNING: Numerous SUBLANGS are assigned the same value, so 0x01 could be
        //           US, French, or many other variations.  Please use Locale Names
        //           such as "en-US" instead.  If that is not possible, consider
        //           testing the entire LCID, eg: 0x0409.
        //
        //  WARNING: There are > 6000 human languages.  The PRIMARYLANGID construct
        //           cannot support all languages your application may encounter.
        //           Please use Language Names, such as "en".
        //
        //  WARNING: There are > 200 country-regions.  The SUBLANGID construct cannot
        //           represent all valid dialects of languages such as English.
        //           Please use Locale Names, such as "en-US".
        //
        //  WARNING: Some languages may have more than one PRIMARYLANGID.  Please
        //           use Locale Names, such as "en-FJ".
        //
        //  WARNING: Some languages do not have assigned LANGIDs.  Please use
        //           Locale Names, such as "tlh-Piqd".
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        /// <summary>language neutral</summary>
        public const int SUBLANG_NEUTRAL = 0x00;
        /// <summary>user default</summary>
        public const int SUBLANG_DEFAULT = 0x01;
        /// <summary>system default</summary>
        public const int SUBLANG_SYS_DEFAULT = 0x02;
        /// <summary>default custom language/locale</summary>
        public const int SUBLANG_CUSTOM_DEFAULT = 0x03;
        /// <summary>custom language/locale</summary>
        public const int SUBLANG_CUSTOM_UNSPECIFIED = 0x04;
        /// <summary>Default custom MUI language/locale</summary>
        public const int SUBLANG_UI_CUSTOM_DEFAULT = 0x05;


        /// <summary>Afrikaans (South Africa) 0x0436 af-ZA</summary>
        public const int SUBLANG_AFRIKAANS_SOUTH_AFRICA = 0x01;
        /// <summary>Albanian (Albania) 0x041c sq-AL</summary>
        public const int SUBLANG_ALBANIAN_ALBANIA = 0x01;
        /// <summary>Alsatian (France) 0x0484</summary>
        public const int SUBLANG_ALSATIAN_FRANCE = 0x01;
        /// <summary>Amharic (Ethiopia) 0x045e</summary>
        public const int SUBLANG_AMHARIC_ETHIOPIA = 0x01;
        /// <summary>Arabic (Saudi Arabia)</summary>
        public const int SUBLANG_ARABIC_SAUDI_ARABIA = 0x01;
        /// <summary>Arabic (Iraq)</summary>
        public const int SUBLANG_ARABIC_IRAQ = 0x02;
        /// <summary>Arabic (Egypt)</summary>
        public const int SUBLANG_ARABIC_EGYPT = 0x03;
        /// <summary>Arabic (Libya)</summary>
        public const int SUBLANG_ARABIC_LIBYA = 0x04;
        /// <summary>Arabic (Algeria)</summary>
        public const int SUBLANG_ARABIC_ALGERIA = 0x05;
        /// <summary>Arabic (Morocco)</summary>
        public const int SUBLANG_ARABIC_MOROCCO = 0x06;
        /// <summary>Arabic (Tunisia)</summary>
        public const int SUBLANG_ARABIC_TUNISIA = 0x07;
        /// <summary>Arabic (Oman)</summary>
        public const int SUBLANG_ARABIC_OMAN = 0x08;
        /// <summary>Arabic (Yemen)</summary>
        public const int SUBLANG_ARABIC_YEMEN = 0x09;
        /// <summary>Arabic (Syria)</summary>
        public const int SUBLANG_ARABIC_SYRIA = 0x0a;
        /// <summary>Arabic (Jordan)</summary>
        public const int SUBLANG_ARABIC_JORDAN = 0x0b;
        /// <summary>Arabic (Lebanon)</summary>
        public const int SUBLANG_ARABIC_LEBANON = 0x0c;
        /// <summary>Arabic (Kuwait)</summary>
        public const int SUBLANG_ARABIC_KUWAIT = 0x0d;
        /// <summary>Arabic (U.A.E)</summary>
        public const int SUBLANG_ARABIC_UAE = 0x0e;
        /// <summary>Arabic (Bahrain)</summary>
        public const int SUBLANG_ARABIC_BAHRAIN = 0x0f;
        /// <summary>Arabic (Qatar)</summary>
        public const int SUBLANG_ARABIC_QATAR = 0x10;
        /// <summary>Armenian (Armenia) 0x042b hy-AM</summary>
        public const int SUBLANG_ARMENIAN_ARMENIA = 0x01;
        /// <summary>Assamese (India) 0x044d</summary>
        public const int SUBLANG_ASSAMESE_INDIA = 0x01;
        /// <summary>Azeri (Latin) - for Azerbaijani, <see cref="SUBLANG_AZERBAIJANI_AZERBAIJAN_LATIN"/> preferred</summary>
        public const int SUBLANG_AZERI_LATIN = 0x01;
        /// <summary>Azeri (Cyrillic) - for Azerbaijani, <see cref="SUBLANG_AZERBAIJANI_AZERBAIJAN_CYRILLIC"/> preferred</summary>
        public const int SUBLANG_AZERI_CYRILLIC = 0x02;
        /// <summary>Azerbaijani (Azerbaijan, Latin)</summary>
        public const int SUBLANG_AZERBAIJANI_AZERBAIJAN_LATIN = 0x01;
        /// <summary>Azerbaijani (Azerbaijan, Cyrillic)</summary>
        public const int SUBLANG_AZERBAIJANI_AZERBAIJAN_CYRILLIC = 0x02;
        /// <summary>Bangla (India)</summary>
        public const int SUBLANG_BANGLA_INDIA = 0x01;
        /// <summary>Bangla (Bangladesh)</summary>
        public const int SUBLANG_BANGLA_BANGLADESH = 0x02;
        /// <summary>Bashkir (Russia) 0x046d ba-RU</summary>
        public const int SUBLANG_BASHKIR_RUSSIA = 0x01;
        /// <summary>Basque (Basque) 0x042d eu-ES</summary>
        public const int SUBLANG_BASQUE_BASQUE = 0x01;
        /// <summary>Belarusian (Belarus) 0x0423 be-BY</summary>
        public const int SUBLANG_BELARUSIAN_BELARUS = 0x01;
        /// <summary>Bengali (India) - Note some prefer <see cref="SUBLANG_BANGLA_INDIA"/></summary>
        public const int SUBLANG_BENGALI_INDIA = 0x01;
        /// <summary>Bengali (Bangladesh) - Note some prefer <see cref="SUBLANG_BANGLA_BANGLADESH"/></summary>
        public const int SUBLANG_BENGALI_BANGLADESH = 0x02;
        /// <summary>Bosnian (Bosnia and Herzegovina - Latin) 0x141a bs-BA-Latn</summary>
        public const int SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_LATIN = 0x05;
        /// <summary>Bosnian (Bosnia and Herzegovina - Cyrillic) 0x201a bs-BA-Cyrl</summary>
        public const int SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_CYRILLIC = 0x08;
        /// <summary>Breton (France) 0x047e</summary>
        public const int SUBLANG_BRETON_FRANCE = 0x01;
        /// <summary>Bulgarian (Bulgaria) 0x0402</summary>
        public const int SUBLANG_BULGARIAN_BULGARIA = 0x01;
        /// <summary>Catalan (Catalan) 0x0403</summary>
        public const int SUBLANG_CATALAN_CATALAN = 0x01;
        /// <summary>Central Kurdish (Iraq) 0x0492 ku-Arab-IQ</summary>
        public const int SUBLANG_CENTRAL_KURDISH_IRAQ = 0x01;
        /// <summary>Cherokee (Cherokee) 0x045c chr-Cher-US</summary>
        public const int SUBLANG_CHEROKEE_CHEROKEE = 0x01;
        /// <summary>Chinese (Taiwan) 0x0404 zh-TW</summary>
        public const int SUBLANG_CHINESE_TRADITIONAL = 0x01;
        /// <summary>Chinese (PR China) 0x0804 zh-CN</summary>
        public const int SUBLANG_CHINESE_SIMPLIFIED = 0x02;
        /// <summary>Chinese (Hong Kong S.A.R., P.R.C.) 0x0c04 zh-HK</summary>
        public const int SUBLANG_CHINESE_HONGKONG = 0x03;
        /// <summary>Chinese (Singapore) 0x1004 zh-SG</summary>
        public const int SUBLANG_CHINESE_SINGAPORE = 0x04;
        /// <summary>Chinese (Macau S.A.R.) 0x1404 zh-MO</summary>
        public const int SUBLANG_CHINESE_MACAU = 0x05;
        /// <summary>Corsican (France) 0x0483</summary>
        public const int SUBLANG_CORSICAN_FRANCE = 0x01;
        /// <summary>Czech (Czech Republic) 0x0405</summary>
        public const int SUBLANG_CZECH_CZECH_REPUBLIC = 0x01;
        /// <summary>Croatian (Croatia)</summary>
        public const int SUBLANG_CROATIAN_CROATIA = 0x01;
        /// <summary>Croatian (Bosnia and Herzegovina - Latin) 0x101a hr-BA</summary>
        public const int SUBLANG_CROATIAN_BOSNIA_HERZEGOVINA_LATIN = 0x04;
        /// <summary>Danish (Denmark) 0x0406</summary>
        public const int SUBLANG_DANISH_DENMARK = 0x01;
        /// <summary>Dari (Afghanistan)</summary>
        public const int SUBLANG_DARI_AFGHANISTAN = 0x01;
        /// <summary>Divehi (Maldives) 0x0465 div-MV</summary>
        public const int SUBLANG_DIVEHI_MALDIVES = 0x01;
        /// <summary>Dutch</summary>
        public const int SUBLANG_DUTCH = 0x01;
        /// <summary>Dutch (Belgian)</summary>
        public const int SUBLANG_DUTCH_BELGIAN = 0x02;
        /// <summary>English (USA)</summary>
        public const int SUBLANG_ENGLISH_US = 0x01;
        /// <summary>English (UK)</summary>
        public const int SUBLANG_ENGLISH_UK = 0x02;
        /// <summary>English (Australian)</summary>
        public const int SUBLANG_ENGLISH_AUS = 0x03;
        /// <summary>English (Canadian)</summary>
        public const int SUBLANG_ENGLISH_CAN = 0x04;
        /// <summary>English (New Zealand)</summary>
        public const int SUBLANG_ENGLISH_NZ = 0x05;
        /// <summary>English (Irish)</summary>
        public const int SUBLANG_ENGLISH_EIRE = 0x06;
        /// <summary>English (South Africa)</summary>
        public const int SUBLANG_ENGLISH_SOUTH_AFRICA = 0x07;
        /// <summary>English (Jamaica)</summary>
        public const int SUBLANG_ENGLISH_JAMAICA = 0x08;
        /// <summary>English (Caribbean)</summary>
        public const int SUBLANG_ENGLISH_CARIBBEAN = 0x09;
        /// <summary>English (Belize)</summary>
        public const int SUBLANG_ENGLISH_BELIZE = 0x0a;
        /// <summary>English (Trinidad)</summary>
        public const int SUBLANG_ENGLISH_TRINIDAD = 0x0b;
        /// <summary>English (Zimbabwe)</summary>
        public const int SUBLANG_ENGLISH_ZIMBABWE = 0x0c;
        /// <summary>English (Philippines)</summary>
        public const int SUBLANG_ENGLISH_PHILIPPINES = 0x0d;
        /// <summary>English (India)</summary>
        public const int SUBLANG_ENGLISH_INDIA = 0x10;
        /// <summary>English (Malaysia)</summary>
        public const int SUBLANG_ENGLISH_MALAYSIA = 0x11;
        /// <summary>English (Singapore)</summary>
        public const int SUBLANG_ENGLISH_SINGAPORE = 0x12;
        /// <summary>Estonian (Estonia) 0x0425 et-EE</summary>
        public const int SUBLANG_ESTONIAN_ESTONIA = 0x01;
        /// <summary>Faroese (Faroe Islands) 0x0438 fo-FO</summary>
        public const int SUBLANG_FAEROESE_FAROE_ISLANDS = 0x01;
        /// <summary>Filipino (Philippines) 0x0464 fil-PH</summary>
        public const int SUBLANG_FILIPINO_PHILIPPINES = 0x01;
        /// <summary>Finnish (Finland) 0x040b</summary>
        public const int SUBLANG_FINNISH_FINLAND = 0x01;
        /// <summary>French</summary>
        public const int SUBLANG_FRENCH = 0x01;
        /// <summary>French (Belgian)</summary>
        public const int SUBLANG_FRENCH_BELGIAN = 0x02;
        /// <summary>French (Canadian)</summary>
        public const int SUBLANG_FRENCH_CANADIAN = 0x03;
        /// <summary>French (Swiss)</summary>
        public const int SUBLANG_FRENCH_SWISS = 0x04;
        /// <summary>French (Luxembourg)</summary>
        public const int SUBLANG_FRENCH_LUXEMBOURG = 0x05;
        /// <summary>French (Monaco)</summary>
        public const int SUBLANG_FRENCH_MONACO = 0x06;
        /// <summary>Frisian (Netherlands) 0x0462 fy-NL</summary>
        public const int SUBLANG_FRISIAN_NETHERLANDS = 0x01;
        /// <summary>Fulah (Senegal) 0x0867 ff-SN</summary>
        public const int SUBLANG_FULAH_SENEGAL = 0x02;
        /// <summary>Galician (Galician) 0x0456 gl-ES</summary>
        public const int SUBLANG_GALICIAN_GALICIAN = 0x01;
        /// <summary>Georgian (Georgia) 0x0437 ka-GE</summary>
        public const int SUBLANG_GEORGIAN_GEORGIA = 0x01;
        /// <summary>German</summary>
        public const int SUBLANG_GERMAN = 0x01;
        /// <summary>German (Swiss)</summary>
        public const int SUBLANG_GERMAN_SWISS = 0x02;
        /// <summary>German (Austrian)</summary>
        public const int SUBLANG_GERMAN_AUSTRIAN = 0x03;
        /// <summary>German (Luxembourg)</summary>
        public const int SUBLANG_GERMAN_LUXEMBOURG = 0x04;
        /// <summary>German (Liechtenstein)</summary>
        public const int SUBLANG_GERMAN_LIECHTENSTEIN = 0x05;
        /// <summary>Greek (Greece)</summary>
        public const int SUBLANG_GREEK_GREECE = 0x01;
        /// <summary>Greenlandic (Greenland) 0x046f kl-GL</summary>
        public const int SUBLANG_GREENLANDIC_GREENLAND = 0x01;
        /// <summary>Gujarati (India (Gujarati Script)) 0x0447 gu-IN</summary>
        public const int SUBLANG_GUJARATI_INDIA = 0x01;
        /// <summary>Hausa (Latin, Nigeria) 0x0468 ha-NG-Latn</summary>
        public const int SUBLANG_HAUSA_NIGERIA_LATIN = 0x01;
        /// <summary>Hawiian (US) 0x0475 haw-US</summary>
        public const int SUBLANG_HAWAIIAN_US = 0x01;
        /// <summary>Hebrew (Israel) 0x040d</summary>
        public const int SUBLANG_HEBREW_ISRAEL = 0x01;
        /// <summary>Hindi (India) 0x0439 hi-IN</summary>
        public const int SUBLANG_HINDI_INDIA = 0x01;
        /// <summary>Hungarian (Hungary) 0x040e</summary>
        public const int SUBLANG_HUNGARIAN_HUNGARY = 0x01;
        /// <summary>Icelandic (Iceland) 0x040f</summary>
        public const int SUBLANG_ICELANDIC_ICELAND = 0x01;
        /// <summary>Igbo (Nigeria) 0x0470 ig-NG</summary>
        public const int SUBLANG_IGBO_NIGERIA = 0x01;
        /// <summary>Indonesian (Indonesia) 0x0421 id-ID</summary>
        public const int SUBLANG_INDONESIAN_INDONESIA = 0x01;
        /// <summary>Inuktitut (Syllabics) (Canada) 0x045d iu-CA-Cans</summary>
        public const int SUBLANG_INUKTITUT_CANADA = 0x01;
        /// <summary>Inuktitut (Canada - Latin)</summary>
        public const int SUBLANG_INUKTITUT_CANADA_LATIN = 0x02;
        /// <summary>Irish (Ireland)</summary>
        public const int SUBLANG_IRISH_IRELAND = 0x02;
        /// <summary>Italian</summary>
        public const int SUBLANG_ITALIAN = 0x01;
        /// <summary>Italian (Swiss)</summary>
        public const int SUBLANG_ITALIAN_SWISS = 0x02;
        /// <summary>Japanese (Japan) 0x0411</summary>
        public const int SUBLANG_JAPANESE_JAPAN = 0x01;
        /// <summary>Kannada (India (Kannada Script)) 0x044b kn-IN</summary>
        public const int SUBLANG_KANNADA_INDIA = 0x01;
        /// <summary>Kashmiri (South Asia)</summary>
        public const int SUBLANG_KASHMIRI_SASIA = 0x02;
        /// <summary>For app compatibility only</summary>
        public const int SUBLANG_KASHMIRI_INDIA = 0x02;
        /// <summary>Kazakh (Kazakhstan) 0x043f kk-KZ</summary>
        public const int SUBLANG_KAZAK_KAZAKHSTAN = 0x01;
        /// <summary>Khmer (Cambodia) 0x0453 kh-KH</summary>
        public const int SUBLANG_KHMER_CAMBODIA = 0x01;
        /// <summary>K'iche (Guatemala)</summary>
        public const int SUBLANG_KICHE_GUATEMALA = 0x01;
        /// <summary>Kinyarwanda (Rwanda) 0x0487 rw-RW</summary>
        public const int SUBLANG_KINYARWANDA_RWANDA = 0x01;
        /// <summary>Konkani (India) 0x0457 kok-IN</summary>
        public const int SUBLANG_KONKANI_INDIA = 0x01;
        /// <summary>Korean (Extended Wansung)</summary>
        public const int SUBLANG_KOREAN = 0x01;
        /// <summary>Kyrgyz (Kyrgyzstan) 0x0440 ky-KG</summary>
        public const int SUBLANG_KYRGYZ_KYRGYZSTAN = 0x01;
        /// <summary>Lao (Lao PDR) 0x0454 lo-LA</summary>
        public const int SUBLANG_LAO_LAO = 0x01;
        /// <summary>Latvian (Latvia) 0x0426 lv-LV</summary>
        public const int SUBLANG_LATVIAN_LATVIA = 0x01;
        /// <summary>Lithuanian</summary>
        public const int SUBLANG_LITHUANIAN = 0x01;
        /// <summary>Lower Sorbian (Germany) 0x082e wee-DE</summary>
        public const int SUBLANG_LOWER_SORBIAN_GERMANY = 0x02;
        /// <summary>Luxembourgish (Luxembourg) 0x046e lb-LU</summary>
        public const int SUBLANG_LUXEMBOURGISH_LUXEMBOURG = 0x01;
        /// <summary>Macedonian (Macedonia (FYROM)) 0x042f mk-MK</summary>
        public const int SUBLANG_MACEDONIAN_MACEDONIA = 0x01;
        /// <summary>Malay (Malaysia)</summary>
        public const int SUBLANG_MALAY_MALAYSIA = 0x01;
        /// <summary>Malay (Brunei Darussalam)</summary>
        public const int SUBLANG_MALAY_BRUNEI_DARUSSALAM = 0x02;
        /// <summary>Malayalam (India (Malayalam Script) ) 0x044c ml-IN</summary>
        public const int SUBLANG_MALAYALAM_INDIA = 0x01;
        /// <summary>Maltese (Malta) 0x043a mt-MT</summary>
        public const int SUBLANG_MALTESE_MALTA = 0x01;
        /// <summary>Maori (New Zealand) 0x0481 mi-NZ</summary>
        public const int SUBLANG_MAORI_NEW_ZEALAND = 0x01;
        /// <summary>Mapudungun (Chile) 0x047a arn-CL</summary>
        public const int SUBLANG_MAPUDUNGUN_CHILE = 0x01;
        /// <summary>Marathi (India) 0x044e mr-IN</summary>
        public const int SUBLANG_MARATHI_INDIA = 0x01;
        /// <summary>Mohawk (Mohawk) 0x047c moh-CA</summary>
        public const int SUBLANG_MOHAWK_MOHAWK = 0x01;
        /// <summary>Mongolian (Cyrillic, Mongolia)</summary>
        public const int SUBLANG_MONGOLIAN_CYRILLIC_MONGOLIA = 0x01;
        /// <summary>Mongolian (PRC)</summary>
        public const int SUBLANG_MONGOLIAN_PRC = 0x02;
        /// <summary>Nepali (India)</summary>
        public const int SUBLANG_NEPALI_INDIA = 0x02;
        /// <summary>Nepali (Nepal) 0x0461 ne-NP</summary>
        public const int SUBLANG_NEPALI_NEPAL = 0x01;
        /// <summary>Norwegian (Bokmal)</summary>
        public const int SUBLANG_NORWEGIAN_BOKMAL = 0x01;
        /// <summary>Norwegian (Nynorsk)</summary>
        public const int SUBLANG_NORWEGIAN_NYNORSK = 0x02;
        /// <summary>Occitan (France) 0x0482 oc-FR</summary>
        public const int SUBLANG_OCCITAN_FRANCE = 0x01;
        /// <summary>Odia (India (Odia Script)) 0x0448 or-IN</summary>
        public const int SUBLANG_ODIA_INDIA = 0x01;
        [Obsolete("use SUBLANG_ODIA_INDIA instead")]
        public const int SUBLANG_ORIYA_INDIA = 0x01;
        /// <summary>Pashto (Afghanistan)</summary>
        public const int SUBLANG_PASHTO_AFGHANISTAN = 0x01;
        /// <summary>Persian (Iran) 0x0429 fa-IR</summary>
        public const int SUBLANG_PERSIAN_IRAN = 0x01;
        /// <summary>Polish (Poland) 0x0415</summary>
        public const int SUBLANG_POLISH_POLAND = 0x01;
        /// <summary>Portuguese</summary>
        public const int SUBLANG_PORTUGUESE = 0x02;
        /// <summary>Portuguese (Brazil)</summary>
        public const int SUBLANG_PORTUGUESE_BRAZILIAN = 0x01;
        [Obsolete("Use SUBLANG_FULAH_SENEGAL instead")]
        public const int SUBLANG_PULAR_SENEGAL = 0x02;
        /// <summary>Punjabi (India (Gurmukhi Script)) 0x0446 pa-IN</summary>
        public const int SUBLANG_PUNJABI_INDIA = 0x01;
        /// <summary>Punjabi (Pakistan (Arabic Script)) 0x0846 pa-Arab-PK</summary>
        public const int SUBLANG_PUNJABI_PAKISTAN = 0x02;
        /// <summary>Quechua (Bolivia)</summary>
        public const int SUBLANG_QUECHUA_BOLIVIA = 0x01;
        /// <summary>Quechua (Ecuador)</summary>
        public const int SUBLANG_QUECHUA_ECUADOR = 0x02;
        /// <summary>Quechua (Peru)</summary>
        public const int SUBLANG_QUECHUA_PERU = 0x03;
        /// <summary>Romanian (Romania) 0x0418</summary>
        public const int SUBLANG_ROMANIAN_ROMANIA = 0x01;
        /// <summary>Romansh (Switzerland) 0x0417 rm-CH</summary>
        public const int SUBLANG_ROMANSH_SWITZERLAND = 0x01;
        /// <summary>Russian (Russia) 0x0419</summary>
        public const int SUBLANG_RUSSIAN_RUSSIA = 0x01;
        /// <summary>Sakha (Russia) 0x0485 sah-RU</summary>
        public const int SUBLANG_SAKHA_RUSSIA = 0x01;
        /// <summary>Northern Sami (Norway)</summary>
        public const int SUBLANG_SAMI_NORTHERN_NORWAY = 0x01;
        /// <summary>Northern Sami (Sweden)</summary>
        public const int SUBLANG_SAMI_NORTHERN_SWEDEN = 0x02;
        /// <summary>Northern Sami (Finland)</summary>
        public const int SUBLANG_SAMI_NORTHERN_FINLAND = 0x03;
        /// <summary>Lule Sami (Norway)</summary>
        public const int SUBLANG_SAMI_LULE_NORWAY = 0x04;
        /// <summary>Lule Sami (Sweden)</summary>
        public const int SUBLANG_SAMI_LULE_SWEDEN = 0x05;
        /// <summary>Southern Sami (Norway)</summary>
        public const int SUBLANG_SAMI_SOUTHERN_NORWAY = 0x06;
        /// <summary>Southern Sami (Sweden)</summary>
        public const int SUBLANG_SAMI_SOUTHERN_SWEDEN = 0x07;
        /// <summary>Skolt Sami (Finland)</summary>
        public const int SUBLANG_SAMI_SKOLT_FINLAND = 0x08;
        /// <summary>Inari Sami (Finland)</summary>
        public const int SUBLANG_SAMI_INARI_FINLAND = 0x09;
        /// <summary>Sanskrit (India) 0x044f sa-IN</summary>
        public const int SUBLANG_SANSKRIT_INDIA = 0x01;
        /// <summary>Scottish Gaelic (United Kingdom) 0x0491 gd-GB</summary>
        public const int SUBLANG_SCOTTISH_GAELIC = 0x01;
        /// <summary>Serbian (Bosnia and Herzegovina - Latin)</summary>
        public const int SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_LATIN = 0x06;
        /// <summary>Serbian (Bosnia and Herzegovina - Cyrillic)</summary>
        public const int SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_CYRILLIC = 0x07;
        /// <summary>Serbian (Montenegro - Latn)</summary>
        public const int SUBLANG_SERBIAN_MONTENEGRO_LATIN = 0x0b;
        /// <summary>Serbian (Montenegro - Cyrillic)</summary>
        public const int SUBLANG_SERBIAN_MONTENEGRO_CYRILLIC = 0x0c;
        /// <summary>Serbian (Serbia - Latin)</summary>
        public const int SUBLANG_SERBIAN_SERBIA_LATIN = 0x09;
        /// <summary>Serbian (Serbia - Cyrillic)</summary>
        public const int SUBLANG_SERBIAN_SERBIA_CYRILLIC = 0x0a;
        /// <summary>Croatian (Croatia) 0x041a hr-HR</summary>
        public const int SUBLANG_SERBIAN_CROATIA = 0x01;
        /// <summary>Serbian (Latin)</summary>
        public const int SUBLANG_SERBIAN_LATIN = 0x02;
        /// <summary>Serbian (Cyrillic)</summary>
        public const int SUBLANG_SERBIAN_CYRILLIC = 0x03;
        /// <summary>Sindhi (India) reserved 0x0459</summary>
        public const int SUBLANG_SINDHI_INDIA = 0x01;
        /// <summary>Sindhi (Pakistan) 0x0859 sd-Arab-PK</summary>
        public const int SUBLANG_SINDHI_PAKISTAN = 0x02;
        /// <summary>For app compatibility only</summary>
        public const int SUBLANG_SINDHI_AFGHANISTAN = 0x02;
        /// <summary>Sinhalese (Sri Lanka)</summary>
        public const int SUBLANG_SINHALESE_SRI_LANKA = 0x01;
        /// <summary>Northern Sotho (South Africa)</summary>
        public const int SUBLANG_SOTHO_NORTHERN_SOUTH_AFRICA = 0x01;
        /// <summary>Slovak (Slovakia) 0x041b sk-SK</summary>
        public const int SUBLANG_SLOVAK_SLOVAKIA = 0x01;
        /// <summary>Slovenian (Slovenia) 0x0424 sl-SI</summary>
        public const int SUBLANG_SLOVENIAN_SLOVENIA = 0x01;
        /// <summary>Spanish (Castilian)</summary>
        public const int SUBLANG_SPANISH = 0x01;
        /// <summary>Spanish (Mexico)</summary>
        public const int SUBLANG_SPANISH_MEXICAN = 0x02;
        /// <summary>Spanish (Modern)</summary>
        public const int SUBLANG_SPANISH_MODERN = 0x03;
        /// <summary>Spanish (Guatemala)</summary>
        public const int SUBLANG_SPANISH_GUATEMALA = 0x04;
        /// <summary>Spanish (Costa Rica)</summary>
        public const int SUBLANG_SPANISH_COSTA_RICA = 0x05;
        /// <summary>Spanish (Panama)</summary>
        public const int SUBLANG_SPANISH_PANAMA = 0x06;
        /// <summary>Spanish (Dominican Republic)</summary>
        public const int SUBLANG_SPANISH_DOMINICAN_REPUBLIC = 0x07;
        /// <summary>Spanish (Venezuela)</summary>
        public const int SUBLANG_SPANISH_VENEZUELA = 0x08;
        /// <summary>Spanish (Colombia)</summary>
        public const int SUBLANG_SPANISH_COLOMBIA = 0x09;
        /// <summary>Spanish (Peru)</summary>
        public const int SUBLANG_SPANISH_PERU = 0x0a;
        /// <summary>Spanish (Argentina)</summary>
        public const int SUBLANG_SPANISH_ARGENTINA = 0x0b;
        /// <summary>Spanish (Ecuador)</summary>
        public const int SUBLANG_SPANISH_ECUADOR = 0x0c;
        /// <summary>Spanish (Chile)</summary>
        public const int SUBLANG_SPANISH_CHILE = 0x0d;
        /// <summary>Spanish (Uruguay)</summary>
        public const int SUBLANG_SPANISH_URUGUAY = 0x0e;
        /// <summary>Spanish (Paraguay)</summary>
        public const int SUBLANG_SPANISH_PARAGUAY = 0x0f;
        /// <summary>Spanish (Bolivia)</summary>
        public const int SUBLANG_SPANISH_BOLIVIA = 0x10;
        /// <summary>Spanish (El Salvador)</summary>
        public const int SUBLANG_SPANISH_EL_SALVADOR = 0x11;
        /// <summary>Spanish (Honduras)</summary>
        public const int SUBLANG_SPANISH_HONDURAS = 0x12;
        /// <summary>Spanish (Nicaragua)</summary>
        public const int SUBLANG_SPANISH_NICARAGUA = 0x13;
        /// <summary>Spanish (Puerto Rico)</summary>
        public const int SUBLANG_SPANISH_PUERTO_RICO = 0x14;
        /// <summary>Spanish (United States)</summary>
        public const int SUBLANG_SPANISH_US = 0x15;
        /// <summary>Swahili (Kenya) 0x0441 sw-KE</summary>
        public const int SUBLANG_SWAHILI_KENYA = 0x01;
        /// <summary>Swedish</summary>
        public const int SUBLANG_SWEDISH = 0x01;
        /// <summary>Swedish (Finland)</summary>
        public const int SUBLANG_SWEDISH_FINLAND = 0x02;
        /// <summary>Syriac (Syria) 0x045a syr-SY</summary>
        public const int SUBLANG_SYRIAC_SYRIA = 0x01;
        /// <summary>Tajik (Tajikistan) 0x0428 tg-TJ-Cyrl</summary>
        public const int SUBLANG_TAJIK_TAJIKISTAN = 0x01;
        /// <summary>Tamazight (Latin, Algeria) 0x085f tzm-Latn-DZ</summary>
        public const int SUBLANG_TAMAZIGHT_ALGERIA_LATIN = 0x02;
        /// <summary>Tamazight (Tifinagh) 0x105f tzm-Tfng-MA</summary>
        public const int SUBLANG_TAMAZIGHT_MOROCCO_TIFINAGH = 0x04;
        /// <summary>Tamil (India)</summary>
        public const int SUBLANG_TAMIL_INDIA = 0x01;
        /// <summary>Tamil (Sri Lanka) 0x0849 ta-LK</summary>
        public const int SUBLANG_TAMIL_SRI_LANKA = 0x02;
        /// <summary>Tatar (Russia) 0x0444 tt-RU</summary>
        public const int SUBLANG_TATAR_RUSSIA = 0x01;
        /// <summary>Telugu (India (Telugu Script)) 0x044a te-IN</summary>
        public const int SUBLANG_TELUGU_INDIA = 0x01;
        /// <summary>Thai (Thailand) 0x041e th-TH</summary>
        public const int SUBLANG_THAI_THAILAND = 0x01;
        /// <summary>Tibetan (PRC)</summary>
        public const int SUBLANG_TIBETAN_PRC = 0x01;
        /// <summary>Tigrigna (Eritrea)</summary>
        public const int SUBLANG_TIGRIGNA_ERITREA = 0x02;
        /// <summary>Tigrinya (Eritrea) 0x0873 ti-ER (preferred spelling)</summary>
        public const int SUBLANG_TIGRINYA_ERITREA = 0x02;
        /// <summary>Tigrinya (Ethiopia) 0x0473 ti-ET</summary>
        public const int SUBLANG_TIGRINYA_ETHIOPIA = 0x01;
        /// <summary>Setswana / Tswana (Botswana) 0x0832 tn-BW</summary>
        public const int SUBLANG_TSWANA_BOTSWANA = 0x02;
        /// <summary>Setswana / Tswana (South Africa) 0x0432 tn-ZA</summary>
        public const int SUBLANG_TSWANA_SOUTH_AFRICA = 0x01;
        /// <summary>Turkish (Turkey) 0x041f tr-TR</summary>
        public const int SUBLANG_TURKISH_TURKEY = 0x01;
        /// <summary>Turkmen (Turkmenistan) 0x0442 tk-TM</summary>
        public const int SUBLANG_TURKMEN_TURKMENISTAN = 0x01;
        /// <summary>Uighur (PRC) 0x0480 ug-CN</summary>
        public const int SUBLANG_UIGHUR_PRC = 0x01;
        /// <summary>Ukrainian (Ukraine) 0x0422 uk-UA</summary>
        public const int SUBLANG_UKRAINIAN_UKRAINE = 0x01;
        /// <summary>Upper Sorbian (Germany) 0x042e wen-DE</summary>
        public const int SUBLANG_UPPER_SORBIAN_GERMANY = 0x01;
        /// <summary>Urdu (Pakistan)</summary>
        public const int SUBLANG_URDU_PAKISTAN = 0x01;
        /// <summary>Urdu (India)</summary>
        public const int SUBLANG_URDU_INDIA = 0x02;
        /// <summary>Uzbek (Latin)</summary>
        public const int SUBLANG_UZBEK_LATIN = 0x01;
        /// <summary>Uzbek (Cyrillic)</summary>
        public const int SUBLANG_UZBEK_CYRILLIC = 0x02;
        /// <summary>Valencian (Valencia) 0x0803 ca-ES-Valencia</summary>
        public const int SUBLANG_VALENCIAN_VALENCIA = 0x02;
        /// <summary>Vietnamese (Vietnam) 0x042a vi-VN</summary>
        public const int SUBLANG_VIETNAMESE_VIETNAM = 0x01;
        /// <summary>Welsh (United Kingdom) 0x0452 cy-GB</summary>
        public const int SUBLANG_WELSH_UNITED_KINGDOM = 0x01;
        /// <summary>Wolof (Senegal)</summary>
        public const int SUBLANG_WOLOF_SENEGAL = 0x01;
        /// <summary>isiXhosa / Xhosa (South Africa) 0x0434 xh-ZA</summary>
        public const int SUBLANG_XHOSA_SOUTH_AFRICA = 0x01;
        [Obsolete("use SUBLANG_SAKHA_RUSSIA instead")]
        public const int SUBLANG_YAKUT_RUSSIA = 0x01;
        /// <summary>Yi (PRC)) 0x0478</summary>
        public const int SUBLANG_YI_PRC = 0x01;
        /// <summary>Yoruba (Nigeria) 046a yo-NG</summary>
        public const int SUBLANG_YORUBA_NIGERIA = 0x01;
        /// <summary>isiZulu / Zulu (South Africa) 0x0435 zu-ZA</summary>
        public const int SUBLANG_ZULU_SOUTH_AFRICA = 0x01;

        //
        //  Sorting IDs.
        //
        //  Note that the named locale APIs (eg CompareStringExEx) are recommended.
        //

        /// <summary>sorting default</summary>
        public const int SORT_DEFAULT = 0x0;

        /// <summary>Invariant (Mathematical Symbols)</summary>
        public const int SORT_INVARIANT_MATH = 0x1;

        /// <summary>Japanese XJIS order</summary>
        public const int SORT_JAPANESE_XJIS = 0x0;
        /// <summary>Japanese Unicode order (no longer supported)</summary>
        public const int SORT_JAPANESE_UNICODE = 0x1;
        /// <summary>Japanese radical/stroke order</summary>
        public const int SORT_JAPANESE_RADICALSTROKE = 0x4;

        /// <summary>Chinese BIG5 order</summary>
        public const int SORT_CHINESE_BIG5 = 0x0;
        /// <summary>PRC Chinese Phonetic order</summary>
        public const int SORT_CHINESE_PRCP = 0x0;
        /// <summary>Chinese Unicode order (no longer supported)</summary>
        public const int SORT_CHINESE_UNICODE = 0x1;
        /// <summary>PRC Chinese Stroke Count order</summary>
        public const int SORT_CHINESE_PRC = 0x2;
        /// <summary>Traditional Chinese Bopomofo order</summary>
        public const int SORT_CHINESE_BOPOMOFO = 0x3;
        /// <summary>Traditional Chinese radical/stroke order.</summary>
        public const int SORT_CHINESE_RADICALSTROKE = 0x4;

        /// <summary>Korean KSC order</summary>
        public const int SORT_KOREAN_KSC = 0x0;
        /// <summary>Korean Unicode order (no longer supported)</summary>
        public const int SORT_KOREAN_UNICODE = 0x1;

        /// <summary>German Phone Book order</summary>
        public const int SORT_GERMAN_PHONE_BOOK = 0x1;

        /// <summary>Hungarian Default order</summary>
        public const int SORT_HUNGARIAN_DEFAULT = 0x0;
        /// <summary>Hungarian Technical order</summary>
        public const int SORT_HUNGARIAN_TECHNICAL = 0x1;

        /// <summary>Georgian Traditional order</summary>
        public const int SORT_GEORGIAN_TRADITIONAL = 0x0;
        /// <summary>Georgian Modern order</summary>
        public const int SORT_GEORGIAN_MODERN = 0x1;

        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        //  DEPRECATED: The LCID/LANGID/SORTID concept is deprecated, please use
        //  Locale Names instead, eg: en-US instead of an LCID like 0x0409.
        //  See the documentation for GetLocaleInfoEx.
        //
        //  A locale ID is a 32 bit value which is the combination of a
        //  language ID, a sort ID, and a reserved area.  The bits are
        //  allocated as follows:
        //
        //       +-------------+---------+-------------------------+
        //       |   Reserved  | Sort ID |      Language ID        |
        //       +-------------+---------+-------------------------+
        //        31         20 19     16 15                      0   bit
        //
        //  WARNING: This pattern isn't always followed (es-ES_tradnl vs es-ES for example)
        //
        //  WARNING: Some locales do not have assigned LCIDs.  Please use
        //           Locale Names, such as "tlh-Piqd".
        //
        //  It is recommended that applications test for locale names rather than
        //  attempting to rely on LCID or LANGID behavior.
        //
        //  DEPRECATED: Locale ID creation/extraction macros:
        //
        //    MAKELCID            - construct the locale id from a language id and a sort id.
        //    MAKESORTLCID        - construct the locale id from a language id, sort id, and sort version.
        //    LANGIDFROMLCID      - extract the language id from a locale id.
        //    SORTIDFROMLCID      - extract the sort id from a locale id.
        //    SORTVERSIONFROMLCID - extract the sort version from a locale id.
        //
        //  Note that the LANG, SUBLANG construction is not always consistent.
        //  The named locale APIs (eg GetLocaleInfoEx) are recommended.
        //
        //  DEPRECATED: LCIDs do not exist for all locales.
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        public const int NLS_VALID_LOCALE_MASK = 0x000fffff;

        /// <summary>
        /// <para>Maximum Locale Name Length in Windows</para>
        /// <para>Locale names are preferred to the deprecated LCID/LANGID concepts.</para>
        /// </summary>
        /// <remarks>
        /// Locale names should follow the BCP47 recommendations and typically
        /// include language, script, regional variant, and perhaps additional specifiers.
        /// BCP47 allows some variation, eg: en-US is preferred to en-Latn-US.
        /// </remarks>
        public const int LOCALE_NAME_MAX_LENGTH = 85;

        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        //  Deprecated default System and User IDs for language and locale.
        //
        //  Locale names such as LOCALE_NAME_SYSTEM_DEFAULT, LOCALE_NAME_USER_DEFAULT,
        //  and LOCALE_NAME_INVARIANT are preferred.  See documentation for GetLocaleInfoEx.
        //

        public static readonly int LANG_SYSTEM_DEFAULT = (MAKELANGID(LANG_NEUTRAL, SUBLANG_SYS_DEFAULT));
        public static readonly int LANG_USER_DEFAULT = (MAKELANGID(LANG_NEUTRAL, SUBLANG_DEFAULT));

        public static readonly int LOCALE_SYSTEM_DEFAULT = (MAKELCID(LANG_SYSTEM_DEFAULT, SORT_DEFAULT));
        public static readonly int LOCALE_USER_DEFAULT = (MAKELCID(LANG_USER_DEFAULT, SORT_DEFAULT));

        //
        //  Other special IDs for language and locale.
        //
        //  DEPRECATED: These identifiers are all underspecified and lose information.
        //              Please use Locale Names such as "en-FJ".
        //              See documentation for GetLocaleInfoEx.
        //
        public static readonly int LOCALE_CUSTOM_DEFAULT =
            (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_CUSTOM_DEFAULT), SORT_DEFAULT));

        public static readonly int LOCALE_CUSTOM_UNSPECIFIED =
            (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_CUSTOM_UNSPECIFIED), SORT_DEFAULT));

        public static readonly int LOCALE_CUSTOM_UI_DEFAULT =
            (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_UI_CUSTOM_DEFAULT), SORT_DEFAULT));

        public static readonly int LOCALE_NEUTRAL =
            (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_NEUTRAL), SORT_DEFAULT));

        public static readonly int LOCALE_INVARIANT =
            (MAKELCID(MAKELANGID(LANG_INVARIANT, SUBLANG_NEUTRAL), SORT_DEFAULT));

        //
        // Transient keyboard Locale IDs (LCIDs)
        // Should only be used for keyboard layout identification
        //

        [Obsolete(
    "These identifiers are all transient and will change, even at " +
    "different times on the same system. " +
    "Please use Locale Names such as \"en - FJ\". " +
    "See documentation for GetLocaleInfoEx."
    )]
        public const int LOCALE_TRANSIENT_KEYBOARD1 = 0x2000;
        [Obsolete(
    "These identifiers are all transient and will change, even at " +
    "different times on the same system. " +
    "Please use Locale Names such as \"en - FJ\". " +
    "See documentation for GetLocaleInfoEx."
    )]
        public const int LOCALE_TRANSIENT_KEYBOARD2 = 0x2400;
        [Obsolete(
    "These identifiers are all transient and will change, even at " +
    "different times on the same system. " +
    "Please use Locale Names such as \"en - FJ\". " +
    "See documentation for GetLocaleInfoEx."
    )]
        public const int LOCALE_TRANSIENT_KEYBOARD3 = 0x2800;
        [Obsolete(
    "These identifiers are all transient and will change, even at " +
    "different times on the same system. " +
    "Please use Locale Names such as \"en - FJ\". " +
    "See documentation for GetLocaleInfoEx."
    )]
        public const int LOCALE_TRANSIENT_KEYBOARD4 = 0x2c00;

        /// <summary>
        /// Locale with an unassigned LCID
        /// These locales cannot be queried by LCID
        /// Currently same as <see cref="LOCALE_CUSTOM_UNSPECIFIED"/>
        /// </summary>
        [Obsolete("Please use Locale Names; see documentation for GetLocaleInfoEx.")]
        public static readonly int LOCALE_UNASSIGNED_LCID = LOCALE_CUSTOM_UNSPECIFIED;

        /// <summary>Maximum number of wait objects</summary>
        public const int MAXIMUM_WAIT_OBJECTS = 64;

        /// <summary>Maximum times thread can be suspended</summary>
        public const int MAXIMUM_SUSPEND_COUNT = 0x7f;
    }
}

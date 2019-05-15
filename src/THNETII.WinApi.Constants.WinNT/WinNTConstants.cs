using System;
using System.Security.Principal;

namespace THNETII.WinApi.Native.WinNT
{
    public static class WinNTConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 36
        public const int ANYSIZE_ARRAY = 1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 590
        public const int ALL_PROCESSOR_GROUPS = 0xffff;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 750
        public const int APPLICATION_ERROR_MASK = 0x20000000;
        public const int ERROR_SEVERITY_SUCCESS = 0x00000000;
        public const int ERROR_SEVERITY_INFORMATIONAL = 0x40000000;
        public const int ERROR_SEVERITY_WARNING = unchecked((int)0x80000000);
        public const int ERROR_SEVERITY_ERROR = unchecked((int)0xC0000000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 1110
        public const int UNICODE_STRING_MAX_BYTES = 65534;
        public const int UNICODE_STRING_MAX_CHARS = 32767;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 1393
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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 1414
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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 1582
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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 1770
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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2063
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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2151
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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2201
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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2246
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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2444
        public const int STATUS_WAIT_0 = 0x00000000;
        public const int STATUS_ABANDONED_WAIT_0 = 0x00000080;
        public const int STATUS_USER_APC = 0x000000C0;
        public const int STATUS_TIMEOUT = 0x00000102;
        public const int STATUS_PENDING = 0x00000103;
        public const int DBG_EXCEPTION_HANDLED = 0x00010001;
        public const int DBG_CONTINUE = 0x00010002;
        public const int STATUS_SEGMENT_NOTIFICATION = 0x40000005;
        public const int STATUS_FATAL_APP_EXIT = 0x40000015;
        public const int DBG_REPLY_LATER = 0x40010001;
        public const int DBG_TERMINATE_THREAD = 0x40010003;
        public const int DBG_TERMINATE_PROCESS = 0x40010004;
        public const int DBG_CONTROL_C = 0x40010005;
        public const int DBG_PRINTEXCEPTION_C = 0x40010006;
        public const int DBG_RIPEXCEPTION = 0x40010007;
        public const int DBG_CONTROL_BREAK = 0x40010008;
        public const int DBG_COMMAND_EXCEPTION = 0x40010009;
        public const int DBG_PRINTEXCEPTION_WIDE_C = 0x4001000A;
        public const int STATUS_GUARD_PAGE_VIOLATION = unchecked((int)0x80000001);
        public const int STATUS_DATATYPE_MISALIGNMENT = unchecked((int)0x80000002);
        public const int STATUS_BREAKPOINT = unchecked((int)0x80000003);
        public const int STATUS_SINGLE_STEP = unchecked((int)0x80000004);
        public const int STATUS_LONGJUMP = unchecked((int)0x80000026);
        public const int STATUS_UNWIND_CONSOLIDATE = unchecked((int)0x80000029);
        public const int DBG_EXCEPTION_NOT_HANDLED = unchecked((int)0x80010001);
        public const int STATUS_ACCESS_VIOLATION = unchecked((int)0xC0000005);
        public const int STATUS_IN_PAGE_ERROR = unchecked((int)0xC0000006);
        public const int STATUS_INVALID_HANDLE = unchecked((int)0xC0000008);
        public const int STATUS_INVALID_PARAMETER = unchecked((int)0xC000000D);
        public const int STATUS_NO_MEMORY = unchecked((int)0xC0000017);
        public const int STATUS_ILLEGAL_INSTRUCTION = unchecked((int)0xC000001D);
        public const int STATUS_NONCONTINUABLE_EXCEPTION = unchecked((int)0xC0000025);
        public const int STATUS_INVALID_DISPOSITION = unchecked((int)0xC0000026);
        public const int STATUS_ARRAY_BOUNDS_EXCEEDED = unchecked((int)0xC000008C);
        public const int STATUS_FLOAT_DENORMAL_OPERAND = unchecked((int)0xC000008D);
        public const int STATUS_FLOAT_DIVIDE_BY_ZERO = unchecked((int)0xC000008E);
        public const int STATUS_FLOAT_INEXACT_RESULT = unchecked((int)0xC000008F);
        public const int STATUS_FLOAT_INVALID_OPERATION = unchecked((int)0xC0000090);
        public const int STATUS_FLOAT_OVERFLOW = unchecked((int)0xC0000091);
        public const int STATUS_FLOAT_STACK_CHECK = unchecked((int)0xC0000092);
        public const int STATUS_FLOAT_UNDERFLOW = unchecked((int)0xC0000093);
        public const int STATUS_INTEGER_DIVIDE_BY_ZERO = unchecked((int)0xC0000094);
        public const int STATUS_INTEGER_OVERFLOW = unchecked((int)0xC0000095);
        public const int STATUS_PRIVILEGED_INSTRUCTION = unchecked((int)0xC0000096);
        public const int STATUS_STACK_OVERFLOW = unchecked((int)0xC00000FD);
        public const int STATUS_DLL_NOT_FOUND = unchecked((int)0xC0000135);
        public const int STATUS_ORDINAL_NOT_FOUND = unchecked((int)0xC0000138);
        public const int STATUS_ENTRYPOINT_NOT_FOUND = unchecked((int)0xC0000139);
        public const int STATUS_CONTROL_C_EXIT = unchecked((int)0xC000013A);
        public const int STATUS_DLL_INIT_FAILED = unchecked((int)0xC0000142);
        public const int STATUS_FLOAT_MULTIPLE_FAULTS = unchecked((int)0xC00002B4);
        public const int STATUS_FLOAT_MULTIPLE_TRAPS = unchecked((int)0xC00002B5);
        public const int STATUS_REG_NAT_CONSUMPTION = unchecked((int)0xC00002C9);
        public const int STATUS_HEAP_CORRUPTION = unchecked((int)0xC0000374);
        public const int STATUS_STACK_BUFFER_OVERRUN = unchecked((int)0xC0000409);
        public const int STATUS_INVALID_CRUNTIME_PARAMETER = unchecked((int)0xC0000417);
        public const int STATUS_ASSERTION_FAILURE = unchecked((int)0xC0000420);
        public const int STATUS_ENCLAVE_VIOLATION = unchecked((int)0xC00004A2);
        public const int STATUS_SXS_EARLY_DEACTIVATION = unchecked((int)0xC015000F);
        public const int STATUS_SXS_INVALID_DEACTIVATION = unchecked((int)0xC0150010);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2513
        /// <summary>Maximum number of wait objects</summary>
        public const int MAXIMUM_WAIT_OBJECTS = 64;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2515
        /// <summary>Maximum times thread can be suspended</summary>
        public const int MAXIMUM_SUSPEND_COUNT = 0x7f;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 3736
        //
        // The following flags control the contents of the CONTEXT structure.
        //

        public const int CONTEXT_AMD64 = 0x00100000;

        //public const int CONTEXT_CONTROL = (CONTEXT_AMD64 | 0x00000001);
        //public const int CONTEXT_INTEGER = (CONTEXT_AMD64 | 0x00000002);
        //public const int CONTEXT_SEGMENTS = (CONTEXT_AMD64 | 0x00000004);
        //public const int CONTEXT_FLOATING_POINT = (CONTEXT_AMD64 | 0x00000008);
        //public const int CONTEXT_DEBUG_REGISTERS = (CONTEXT_AMD64 | 0x00000010);

        //public const int CONTEXT_FULL = (CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_FLOATING_POINT);

        //public const int CONTEXT_ALL = (CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_SEGMENTS | CONTEXT_FLOATING_POINT | CONTEXT_DEBUG_REGISTERS);

        //public const int CONTEXT_XSTATE = (CONTEXT_AMD64 | 0x00000040);

        public const int CONTEXT_KERNEL_DEBUGGER = 0x04000000;

        //public const int CONTEXT_EXCEPTION_ACTIVE = 0x08000000;
        //public const int CONTEXT_SERVICE_ACTIVE = 0x10000000;
        //public const int CONTEXT_EXCEPTION_REQUEST = 0x40000000;
        //public const int CONTEXT_EXCEPTION_REPORTING = unchecked((int)0x80000000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 3776
        //
        // Define initial MxCsr and FpCsr control.
        //

        /// <summary>initial MXCSR value</summary>
        public const short INITIAL_MXCSR = 0x1f80;
        /// <summary>initial FPCSR value</summary>
        public const short INITIAL_FPCSR = 0x027f;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 3951
        public const int RUNTIME_FUNCTION_INDIRECT = 0x1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 3953
        //
        // Define unwind information flags.
        //

        public const int UNW_FLAG_NHANDLER = 0x0;
        public const int UNW_FLAG_EHANDLER = 0x1;
        public const int UNW_FLAG_UHANDLER = 0x2;
        public const int UNW_FLAG_CHAININFO = 0x4;

        /// <summary>Software only flag</summary>
        public const uint UNW_FLAG_NO_EPILOGUE = 0x80000000U;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 3968
        public const int UNWIND_HISTORY_TABLE_SIZE = 12;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 4010
        public const string OUT_OF_PROCESS_FUNCTION_TABLE_CALLBACK_EXPORT_NAME = "OutOfProcessFunctionTableCallback";

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 4799
        public const int CONTEXT_ARM = 0x00200000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 4817
        /// <summary>
        /// This flag is set by the unwinder if it has unwound to a call
        /// site, and cleared whenever it unwinds through a trap frame.
        /// It is used by language-specific exception handlers to help
        /// differentiate exception scopes during dispatching.
        /// </summary>
        public const int CONTEXT_UNWOUND_TO_CALL = 0x20000000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 4830
        //
        // Define initial Cpsr/Fpscr value
        //

        public const int INITIAL_CPSR = 0x10;
        public const int INITIAL_FPSCR = 0;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 4837
        //
        // Specify the number of breakpoints and watchpoints that the OS
        // will track. Architecturally, ARM supports up to 16. In practice,
        // however, almost no one implements more than 4 of each.
        //

        public const int ARM_MAX_BREAKPOINTS = 8;
        public const int ARM_MAX_WATCHPOINTS = 1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 5911
        public const int CONTEXT_ARM64 = 0x00400000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 5915
        public const int CONTEXT_ARM64_CONTROL = (CONTEXT_ARM64 | 0x1);
        public const int CONTEXT_ARM64_INTEGER = (CONTEXT_ARM64 | 0x2);
        public const int CONTEXT_ARM64_FLOATING_POINT = (CONTEXT_ARM64 | 0x4);
        public const int CONTEXT_ARM64_DEBUG_REGISTERS = (CONTEXT_ARM64 | 0x8);
        public const int CONTEXT_ARM64_X18 = (CONTEXT_ARM64 | 0x10);

        //
        // CONTEXT_ARM64_X18 is not part of CONTEXT_ARM64_FULL because in NT user-mode
        // threads, x18 contains a pointer to the TEB and should generally not be set
        // without intending to.
        //

        public const int CONTEXT_ARM64_FULL = (CONTEXT_ARM64_CONTROL | CONTEXT_ARM64_INTEGER | CONTEXT_ARM64_FLOATING_POINT);
        public const int CONTEXT_ARM64_ALL = (CONTEXT_ARM64_CONTROL | CONTEXT_ARM64_INTEGER | CONTEXT_ARM64_FLOATING_POINT | CONTEXT_ARM64_DEBUG_REGISTERS | CONTEXT_ARM64_X18);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 5956
        public const int CONTEXT_RET_TO_GUEST = 0x04000000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 5966
        //
        // Specify the number of breakpoints and watchpoints that the OS
        // will track. Architecturally, ARM64 supports up to 16. In practice,
        // however, almost no one implements more than 4 of each.
        //

        public const int ARM64_MAX_BREAKPOINTS = 8;
        public const int ARM64_MAX_WATCHPOINTS = 2;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 7439
        //
        // The following values specify the type of failing access when the status is
        // STATUS_ACCESS_VIOLATION and the first parameter in the execpetion record.
        //

        /// <summary>Access violation was caused by a read</summary>
        public const int EXCEPTION_READ_FAULT = 0;
        /// <summary>Access violation was caused by a write</summary>
        public const int EXCEPTION_WRITE_FAULT = 1;
        /// <summary>Access violation was caused by an instruction fetch</summary>
        public const int EXCEPTION_EXECUTE_FAULT = 8;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 7452
        /// <summary>
        /// Define the size of the 80387 save area, which is in the context frame.
        /// </summary>
        public const int SIZE_OF_80387_REGISTERS = 80;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 7458
        //
        // The following flags control the contents of the CONTEXT structure.
        //

        public const int CONTEXT_i386 = 0x00010000;    // this assumes that i386 and
        public const int CONTEXT_i486 = 0x00010000;    // i486 have identical context records

        /// <summary>SS:SP, CS:IP, FLAGS, BP</summary>
        public const int CONTEXT_CONTROL = 0x00000001;
        /// <summary>AX, BX, CX, DX, SI, DI</summary>
        public const int CONTEXT_INTEGER = 0x00000002;
        /// <summary>DS, ES, FS, GS</summary>
        public const int CONTEXT_SEGMENTS = 0x00000004;
        /// <summary>387 state</summary>
        public const int CONTEXT_FLOATING_POINT = 0x00000008;
        /// <summary>DB 0-3,6,7</summary>
        public const int CONTEXT_DEBUG_REGISTERS = 0x00000010;
        /// <summary>cpu specific extensions</summary>
        public const int CONTEXT_EXTENDED_REGISTERS = 0x00000020;

        public const int CONTEXT_FULL = CONTEXT_CONTROL | CONTEXT_INTEGER |
                                         CONTEXT_SEGMENTS;

        public const int CONTEXT_ALL = CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_SEGMENTS |
                                        CONTEXT_FLOATING_POINT | CONTEXT_DEBUG_REGISTERS |
                                        CONTEXT_EXTENDED_REGISTERS;

        public const int CONTEXT_XSTATE = 0x00000040;

        public const int CONTEXT_EXCEPTION_ACTIVE = 0x08000000;
        public const int CONTEXT_SERVICE_ACTIVE = 0x10000000;
        public const int CONTEXT_EXCEPTION_REQUEST = 0x40000000;
        public const int CONTEXT_EXCEPTION_REPORTING = unchecked((int)0x80000000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 7512
        public const int MAXIMUM_SUPPORTED_EXTENSION = 512;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8561
        // this assumes that i386 and
        // i486 have identical context records
        public const int WOW64_CONTEXT_i386 = 0x00010000;
        public const int WOW64_CONTEXT_i486 = 0x00010000;

        // SS:SP, CS:IP, FLAGS, BP
        public const int WOW64_CONTEXT_CONTROL = (WOW64_CONTEXT_i386 | 0x00000001);
        // AX, BX, CX, DX, SI, DI
        public const int WOW64_CONTEXT_INTEGER = (WOW64_CONTEXT_i386 | 0x00000002);
        // DS, ES, FS, GS
        public const int WOW64_CONTEXT_SEGMENTS = (WOW64_CONTEXT_i386 | 0x00000004);
        // 387 state
        public const int WOW64_CONTEXT_FLOATING_POINT = (WOW64_CONTEXT_i386 | 0x00000008);
        // DB 0-3,6,7
        public const int WOW64_CONTEXT_DEBUG_REGISTERS = (WOW64_CONTEXT_i386 | 0x00000010);
        // cpu specific extensions
        public const int WOW64_CONTEXT_EXTENDED_REGISTERS = (WOW64_CONTEXT_i386 | 0x00000020);

        public const int WOW64_CONTEXT_FULL = (WOW64_CONTEXT_CONTROL | WOW64_CONTEXT_INTEGER | WOW64_CONTEXT_SEGMENTS);

        public const int WOW64_CONTEXT_ALL = (WOW64_CONTEXT_CONTROL | WOW64_CONTEXT_INTEGER | WOW64_CONTEXT_SEGMENTS | WOW64_CONTEXT_FLOATING_POINT | WOW64_CONTEXT_DEBUG_REGISTERS | WOW64_CONTEXT_EXTENDED_REGISTERS);

        public const int WOW64_CONTEXT_XSTATE = (WOW64_CONTEXT_i386 | 0x00000040);

        public const int WOW64_CONTEXT_EXCEPTION_ACTIVE = 0x08000000;
        public const int WOW64_CONTEXT_SERVICE_ACTIVE = 0x10000000;
        public const int WOW64_CONTEXT_EXCEPTION_REQUEST = 0x40000000;
        public const int WOW64_CONTEXT_EXCEPTION_REPORTING = unchecked((int)0x80000000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8586
        //
        //  Define the size of the 80387 save area, which is in the context frame.
        //

        public const int WOW64_SIZE_OF_80387_REGISTERS = 80;

        public const int WOW64_MAXIMUM_SUPPORTED_EXTENSION = 512;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8741
        /// <summary>Noncontinuable exception</summary>
        public const int EXCEPTION_NONCONTINUABLE = 0x1;
        /// <summary>Unwind is in progress</summary>
        public const int EXCEPTION_UNWINDING = 0x2;
        /// <summary>Exit unwind is in progress</summary>
        public const int EXCEPTION_EXIT_UNWIND = 0x4;
        /// <summary>Stack out of limits or unaligned</summary>
        public const int EXCEPTION_STACK_INVALID = 0x8;
        /// <summary>Nested exception handler call</summary>
        public const int EXCEPTION_NESTED_CALL = 0x10;
        /// <summary>Target unwind in progress</summary>
        public const int EXCEPTION_TARGET_UNWIND = 0x20;
        /// <summary>Collided exception handler call</summary>
        public const int EXCEPTION_COLLIDED_UNWIND = 0x40;

        public const int EXCEPTION_UNWIND = EXCEPTION_UNWINDING | EXCEPTION_EXIT_UNWIND | EXCEPTION_TARGET_UNWIND | EXCEPTION_COLLIDED_UNWIND;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8756
        /// <summary>maximum number of exception parameters</summary>
        public const int EXCEPTION_MAXIMUM_PARAMETERS = 15;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8869
        ////////////////////////////////////////////////////////////////////////
        //                                                                    //
        //                             ACCESS TYPES                           //
        //                                                                    //
        ////////////////////////////////////////////////////////////////////////

        //
        //  The following are masks for the predefined standard access types
        //

        public const int DELETE = 0x00010000;
        public const int READ_CONTROL = 0x00020000;
        public const int WRITE_DAC = 0x00040000;
        public const int WRITE_OWNER = 0x00080000;
        public const int SYNCHRONIZE = 0x00100000;

        public const int STANDARD_RIGHTS_REQUIRED = 0x000F0000;

        public const int STANDARD_RIGHTS_READ = READ_CONTROL;
        public const int STANDARD_RIGHTS_WRITE = READ_CONTROL;
        public const int STANDARD_RIGHTS_EXECUTE = READ_CONTROL;

        public const int STANDARD_RIGHTS_ALL = 0x001F0000;

        public const int SPECIFIC_RIGHTS_ALL = 0x0000FFFF;

        /// <summary>
        /// AccessSystemAcl access type
        /// </summary>
        public const int ACCESS_SYSTEM_SECURITY = 0x01000000;

        /// <summary>
        /// MaximumAllowed access type
        /// </summary>
        public const int MAXIMUM_ALLOWED = 0x02000000;

        //
        //  These are the generic rights.
        //

        public const int GENERIC_READ = unchecked((int)0x80000000);
        public const int GENERIC_WRITE = 0x40000000;
        public const int GENERIC_EXECUTE = 0x20000000;
        public const int GENERIC_ALL = 0x10000000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8869
        /// <summary>Current revision level</summary>
        public const byte SID_REVISION = 1;
        public const byte SID_MAX_SUB_AUTHORITIES = 15;
        public const byte SID_RECOMMENDED_SUB_AUTHORITIES = 1;

        public const int SECURITY_MAX_SID_SIZE = sizeof(byte) * 2 + sizeof(byte) * 6
            + (SID_MAX_SUB_AUTHORITIES * sizeof(int));

        // 2 (S-)
        // 4 (Rev(max: 255)-)
        // 15 (
        //      If (Auth < 2^32): Auth(max:4294967295)-
        //      Else:             0xAuth(max:FFFFFFFFFFFF)-
        //    )
        // (11 * SID_MAX_SUB_AUTHORITIES) (SubN(max:4294967295)-)
        // 1 (NULL character)
        // = 187 (assuming SID_MAX_SUB_AUTHORITIES = 15)
        public const int SECURITY_MAX_SID_STRING_CHARACTERS =
            2 + 4 + 15 + (11 * SID_MAX_SUB_AUTHORITIES) + 1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9071
        public const int SID_HASH_SIZE = 32;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9071
        /////////////////////////////////////////////////////////////////////////////
        //                                                                         //
        // Universal well-known SIDs                                               //
        //                                                                         //
        //     Null SID                     S-1-0-0                                //
        //     World                        S-1-1-0                                //
        //     Local                        S-1-2-0                                //
        //     Creator Owner ID             S-1-3-0                                //
        //     Creator Group ID             S-1-3-1                                //
        //     Creator Owner Server ID      S-1-3-2                                //
        //     Creator Group Server ID      S-1-3-3                                //
        //                                                                         //
        //     (Non-unique IDs)             S-1-4                                  //
        //                                                                         //
        /////////////////////////////////////////////////////////////////////////////

        public const int SECURITY_NULL_RID = 0x00000000;
        public const int SECURITY_WORLD_RID = 0x00000000;
        public const int SECURITY_LOCAL_RID = 0x00000000;
        public const int SECURITY_LOCAL_LOGON_RID = 0x00000001;

        public const int SECURITY_CREATOR_OWNER_RID = 0x00000000;
        public const int SECURITY_CREATOR_GROUP_RID = 0x00000001;

        public const int SECURITY_CREATOR_OWNER_SERVER_RID = 0x00000002;
        public const int SECURITY_CREATOR_GROUP_SERVER_RID = 0x00000003;

        public const int SECURITY_CREATOR_OWNER_RIGHTS_RID = 0x00000004;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9115
        ///////////////////////////////////////////////////////////////////////////////
        //                                                                           //
        // NT well-known SIDs                                                        //
        //                                                                           //
        //     NT Authority            S-1-5                                         //
        //     Dialup                  S-1-5-1                                       //
        //                                                                           //
        //     Network                 S-1-5-2                                       //
        //     Batch                   S-1-5-3                                       //
        //     Interactive             S-1-5-4                                       //
        //     (Logon IDs)             S-1-5-5-X-Y                                   //
        //     Service                 S-1-5-6                                       //
        //     AnonymousLogon          S-1-5-7       (aka null logon session)        //
        //     Proxy                   S-1-5-8                                       //
        //     Enterprise DC (EDC)     S-1-5-9       (aka domain controller account) //
        //     Self                    S-1-5-10      (self RID)                      //
        //     Authenticated User      S-1-5-11      (Authenticated user somewhere)  //
        //     Restricted Code         S-1-5-12      (Running restricted code)       //
        //     Terminal Server         S-1-5-13      (Running on Terminal Server)    //
        //     Remote Logon            S-1-5-14      (Remote Interactive Logon)      //
        //     This Organization       S-1-5-15                                      //
        //                                                                           //
        //     IUser                   S-1-5-17
        //     Local System            S-1-5-18                                      //
        //     Local Service           S-1-5-19                                      //
        //     Network Service         S-1-5-20                                      //
        //                                                                           //
        //     (NT non-unique IDs)     S-1-5-0x15-... (NT Domain Sids)               //
        //                                                                           //
        //     (Built-in domain)       S-1-5-0x20                                    //
        //                                                                           //
        //     (Security Package IDs)  S-1-5-0x40                                    //
        //     NTLM Authentication     S-1-5-0x40-10                                 //
        //     SChannel Authentication S-1-5-0x40-14                                 //
        //     Digest Authentication   S-1-5-0x40-21                                 //
        //                                                                           //
        //     Other Organization      S-1-5-1000    (>=1000 can not be filtered)    //
        //                                                                           //
        //                                                                           //
        // NOTE: the relative identifier values (RIDs) determine which security      //
        //       boundaries the SID is allowed to cross.  Before adding new RIDs,    //
        //       a determination needs to be made regarding which range they should  //
        //       be added to in order to ensure proper "SID filtering"               //
        //                                                                           //
        ///////////////////////////////////////////////////////////////////////////////

        public const int SECURITY_DIALUP_RID = 0x00000001;
        public const int SECURITY_NETWORK_RID = 0x00000002;
        public const int SECURITY_BATCH_RID = 0x00000003;
        public const int SECURITY_INTERACTIVE_RID = 0x00000004;
        public const int SECURITY_LOGON_IDS_RID = 0x00000005;
        public const int SECURITY_LOGON_IDS_RID_COUNT = 3;
        public const int SECURITY_SERVICE_RID = 0x00000006;
        public const int SECURITY_ANONYMOUS_LOGON_RID = 0x00000007;
        public const int SECURITY_PROXY_RID = 0x00000008;
        public const int SECURITY_ENTERPRISE_CONTROLLERS_RID = 0x00000009;
        public const int SECURITY_SERVER_LOGON_RID = SECURITY_ENTERPRISE_CONTROLLERS_RID;
        public const int SECURITY_PRINCIPAL_SELF_RID = 0x0000000A;
        public const int SECURITY_AUTHENTICATED_USER_RID = 0x0000000B;
        public const int SECURITY_RESTRICTED_CODE_RID = 0x0000000C;
        public const int SECURITY_TERMINAL_SERVER_RID = 0x0000000D;
        public const int SECURITY_REMOTE_LOGON_RID = 0x0000000E;
        public const int SECURITY_THIS_ORGANIZATION_RID = 0x0000000F;
        public const int SECURITY_IUSER_RID = 0x00000011;
        public const int SECURITY_LOCAL_SYSTEM_RID = 0x00000012;
        public const int SECURITY_LOCAL_SERVICE_RID = 0x00000013;
        public const int SECURITY_NETWORK_SERVICE_RID = 0x00000014;

        public const int SECURITY_NT_NON_UNIQUE = 0x00000015;
        public const int SECURITY_NT_NON_UNIQUE_SUB_AUTH_COUNT = 3;

        public const int SECURITY_ENTERPRISE_READONLY_CONTROLLERS_RID = 0x00000016;

        public const int SECURITY_BUILTIN_DOMAIN_RID = 0x00000020;
        public const int SECURITY_WRITE_RESTRICTED_CODE_RID = 0x00000021;


        public const int SECURITY_PACKAGE_BASE_RID = 0x00000040;
        public const int SECURITY_PACKAGE_RID_COUNT = 2;
        public const int SECURITY_PACKAGE_NTLM_RID = 0x0000000A;
        public const int SECURITY_PACKAGE_SCHANNEL_RID = 0x0000000E;
        public const int SECURITY_PACKAGE_DIGEST_RID = 0x00000015;

        public const int SECURITY_CRED_TYPE_BASE_RID = 0x00000041;
        public const int SECURITY_CRED_TYPE_RID_COUNT = 2;
        public const int SECURITY_CRED_TYPE_THIS_ORG_CERT_RID = 0x00000001;

        public const int SECURITY_MIN_BASE_RID = 0x00000050;

        public const int SECURITY_SERVICE_ID_BASE_RID = 0x00000050;
        public const int SECURITY_SERVICE_ID_RID_COUNT = 6;

        public const int SECURITY_RESERVED_ID_BASE_RID = 0x00000051;

        public const int SECURITY_APPPOOL_ID_BASE_RID = 0x00000052;
        public const int SECURITY_APPPOOL_ID_RID_COUNT = 6;

        public const int SECURITY_VIRTUALSERVER_ID_BASE_RID = 0x00000053;
        public const int SECURITY_VIRTUALSERVER_ID_RID_COUNT = 6;

        public const int SECURITY_USERMODEDRIVERHOST_ID_BASE_RID = 0x00000054;
        public const int SECURITY_USERMODEDRIVERHOST_ID_RID_COUNT = 6;

        public const int SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_BASE_RID = 0x00000055;
        public const int SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_RID_COUNT = 6;

        public const int SECURITY_WMIHOST_ID_BASE_RID = 0x00000056;
        public const int SECURITY_WMIHOST_ID_RID_COUNT = 6;

        public const int SECURITY_TASK_ID_BASE_RID = 0x00000057;

        public const int SECURITY_NFS_ID_BASE_RID = 0x00000058;

        public const int SECURITY_COM_ID_BASE_RID = 0x00000059;

        public const int SECURITY_WINDOW_MANAGER_BASE_RID = 0x0000005A;

        public const int SECURITY_RDV_GFX_BASE_RID = 0x0000005B;

        public const int SECURITY_DASHOST_ID_BASE_RID = 0x0000005C;
        public const int SECURITY_DASHOST_ID_RID_COUNT = 6;

        public const int SECURITY_USERMANAGER_ID_BASE_RID = 0x0000005D;
        public const int SECURITY_USERMANAGER_ID_RID_COUNT = 6;

        public const int SECURITY_WINRM_ID_BASE_RID = 0x0000005E;
        public const int SECURITY_WINRM_ID_RID_COUNT = 6;

        public const int SECURITY_CCG_ID_BASE_RID = 0x0000005F;
        public const int SECURITY_UMFD_BASE_RID = 0x00000060;

        public const int SECURITY_VIRTUALACCOUNT_ID_RID_COUNT = 6;

        public const int SECURITY_MAX_BASE_RID = 0x0000006F;
        public const int SECURITY_MAX_ALWAYS_FILTERED = 0x000003E7;
        public const int SECURITY_MIN_NEVER_FILTERED = 0x000003E8;

        public const int SECURITY_OTHER_ORGANIZATION_RID = 0x000003E8;

        //
        //Service SID type RIDs are in the range 0x50- 0x6F.  Therefore, we are giving  the next available RID to Windows Mobile team.
        //
        public const int SECURITY_WINDOWSMOBILE_ID_BASE_RID = 0x00000070;

        //
        // Installer Capability Group Sid related. Currently Base RID is same as LOCAL DOMAIN.
        //
        public const int SECURITY_INSTALLER_GROUP_CAPABILITY_BASE = 0x20;
        public const int SECURITY_INSTALLER_GROUP_CAPABILITY_RID_COUNT = 9;

        // Note: This is because the App Capability Rid is S-1-15-3-1024-...
        //       whereas the service group rid is          S-1-5-32-...
        //	The number of RIDs from hash (8) are the same for both
        public const int SECURITY_INSTALLER_CAPABILITY_RID_COUNT = 10;

        //
        //Well-known group for local accounts
        //
        public const int SECURITY_LOCAL_ACCOUNT_RID = 0x00000071;
        public const int SECURITY_LOCAL_ACCOUNT_AND_ADMIN_RID = 0x00000072;

        /////////////////////////////////////////////////////////////////////////////
        //                                                                         //
        // well-known domain relative sub-authority values (RIDs)...               //
        //                                                                         //
        /////////////////////////////////////////////////////////////////////////////


        public const int DOMAIN_GROUP_RID_AUTHORIZATION_DATA_IS_COMPOUNDED = 0x000001F0;
        public const int DOMAIN_GROUP_RID_AUTHORIZATION_DATA_CONTAINS_CLAIMS = 0x000001F1;
        public const int DOMAIN_GROUP_RID_ENTERPRISE_READONLY_DOMAIN_CONTROLLERS = 0x000001F2;

        public const int FOREST_USER_RID_MAX = 0x000001F3;

        // Well-known users ...

        public const int DOMAIN_USER_RID_ADMIN = 0x000001F4;
        public const int DOMAIN_USER_RID_GUEST = 0x000001F5;
        public const int DOMAIN_USER_RID_KRBTGT = 0x000001F6;
        public const int DOMAIN_USER_RID_DEFAULT_ACCOUNT = 0x000001F7;
        public const int DOMAIN_USER_RID_WDAG_ACCOUNT = 0x000001F8;

        public const int DOMAIN_USER_RID_MAX = 0x000003E7;


        // well-known groups ...

        public const int DOMAIN_GROUP_RID_ADMINS = 0x00000200;
        public const int DOMAIN_GROUP_RID_USERS = 0x00000201;
        public const int DOMAIN_GROUP_RID_GUESTS = 0x00000202;
        public const int DOMAIN_GROUP_RID_COMPUTERS = 0x00000203;
        public const int DOMAIN_GROUP_RID_CONTROLLERS = 0x00000204;
        public const int DOMAIN_GROUP_RID_CERT_ADMINS = 0x00000205;
        public const int DOMAIN_GROUP_RID_SCHEMA_ADMINS = 0x00000206;
        public const int DOMAIN_GROUP_RID_ENTERPRISE_ADMINS = 0x00000207;
        public const int DOMAIN_GROUP_RID_POLICY_ADMINS = 0x00000208;
        public const int DOMAIN_GROUP_RID_READONLY_CONTROLLERS = 0x00000209;
        public const int DOMAIN_GROUP_RID_CLONEABLE_CONTROLLERS = 0x0000020A;
        public const int DOMAIN_GROUP_RID_CDC_RESERVED = 0x0000020C;
        public const int DOMAIN_GROUP_RID_PROTECTED_USERS = 0x0000020D;
        public const int DOMAIN_GROUP_RID_KEY_ADMINS = 0x0000020E;
        public const int DOMAIN_GROUP_RID_ENTERPRISE_KEY_ADMINS = 0x0000020F;

        // well-known aliases ...

        public const int DOMAIN_ALIAS_RID_ADMINS = 0x00000220;
        public const int DOMAIN_ALIAS_RID_USERS = 0x00000221;
        public const int DOMAIN_ALIAS_RID_GUESTS = 0x00000222;
        public const int DOMAIN_ALIAS_RID_POWER_USERS = 0x00000223;

        public const int DOMAIN_ALIAS_RID_ACCOUNT_OPS = 0x00000224;
        public const int DOMAIN_ALIAS_RID_SYSTEM_OPS = 0x00000225;
        public const int DOMAIN_ALIAS_RID_PRINT_OPS = 0x00000226;
        public const int DOMAIN_ALIAS_RID_BACKUP_OPS = 0x00000227;

        public const int DOMAIN_ALIAS_RID_REPLICATOR = 0x00000228;
        public const int DOMAIN_ALIAS_RID_RAS_SERVERS = 0x00000229;
        public const int DOMAIN_ALIAS_RID_PREW2KCOMPACCESS = 0x0000022A;
        public const int DOMAIN_ALIAS_RID_REMOTE_DESKTOP_USERS = 0x0000022B;
        public const int DOMAIN_ALIAS_RID_NETWORK_CONFIGURATION_OPS = 0x0000022C;
        public const int DOMAIN_ALIAS_RID_INCOMING_FOREST_TRUST_BUILDERS = 0x0000022D;

        public const int DOMAIN_ALIAS_RID_MONITORING_USERS = 0x0000022E;
        public const int DOMAIN_ALIAS_RID_LOGGING_USERS = 0x0000022F;
        public const int DOMAIN_ALIAS_RID_AUTHORIZATIONACCESS = 0x00000230;
        public const int DOMAIN_ALIAS_RID_TS_LICENSE_SERVERS = 0x00000231;
        public const int DOMAIN_ALIAS_RID_DCOM_USERS = 0x00000232;
        public const int DOMAIN_ALIAS_RID_IUSERS = 0x00000238;
        public const int DOMAIN_ALIAS_RID_CRYPTO_OPERATORS = 0x00000239;
        public const int DOMAIN_ALIAS_RID_CACHEABLE_PRINCIPALS_GROUP = 0x0000023B;
        public const int DOMAIN_ALIAS_RID_NON_CACHEABLE_PRINCIPALS_GROUP = 0x0000023C;
        public const int DOMAIN_ALIAS_RID_EVENT_LOG_READERS_GROUP = 0x0000023D;
        public const int DOMAIN_ALIAS_RID_CERTSVC_DCOM_ACCESS_GROUP = 0x0000023E;
        public const int DOMAIN_ALIAS_RID_RDS_REMOTE_ACCESS_SERVERS = 0x0000023F;
        public const int DOMAIN_ALIAS_RID_RDS_ENDPOINT_SERVERS = 0x00000240;
        public const int DOMAIN_ALIAS_RID_RDS_MANAGEMENT_SERVERS = 0x00000241;
        public const int DOMAIN_ALIAS_RID_HYPER_V_ADMINS = 0x00000242;
        public const int DOMAIN_ALIAS_RID_ACCESS_CONTROL_ASSISTANCE_OPS = 0x00000243;
        public const int DOMAIN_ALIAS_RID_REMOTE_MANAGEMENT_USERS = 0x00000244;
        public const int DOMAIN_ALIAS_RID_DEFAULT_ACCOUNT = 0x00000245;
        public const int DOMAIN_ALIAS_RID_STORAGE_REPLICA_ADMINS = 0x00000246;
        public const int DOMAIN_ALIAS_RID_DEVICE_OWNERS = 0x00000247;

        //
        // Application Package Authority.
        //

        public const int SECURITY_APP_PACKAGE_BASE_RID = 0x00000002;
        public const int SECURITY_BUILTIN_APP_PACKAGE_RID_COUNT = 2;
        public const int SECURITY_APP_PACKAGE_RID_COUNT = 8;
        public const int SECURITY_CAPABILITY_BASE_RID = 0x00000003;
        public const int SECURITY_CAPABILITY_APP_RID = 0x000000400;
        public const int SECURITY_BUILTIN_CAPABILITY_RID_COUNT = 2;
        public const int SECURITY_CAPABILITY_RID_COUNT = 5;
        public const int SECURITY_PARENT_PACKAGE_RID_COUNT = SECURITY_APP_PACKAGE_RID_COUNT;
        public const int SECURITY_CHILD_PACKAGE_RID_COUNT = 12;

        //
        // Built-in Packages.
        //

        public const int SECURITY_BUILTIN_PACKAGE_ANY_PACKAGE = 0x00000001;
        public const int SECURITY_BUILTIN_PACKAGE_ANY_RESTRICTED_PACKAGE = 0x00000002;

        //
        // Built-in Capabilities.
        //

        public const int SECURITY_CAPABILITY_INTERNET_CLIENT = 0x00000001;
        public const int SECURITY_CAPABILITY_INTERNET_CLIENT_SERVER = 0x00000002;
        public const int SECURITY_CAPABILITY_PRIVATE_NETWORK_CLIENT_SERVER = 0x00000003;
        public const int SECURITY_CAPABILITY_PICTURES_LIBRARY = 0x00000004;
        public const int SECURITY_CAPABILITY_VIDEOS_LIBRARY = 0x00000005;
        public const int SECURITY_CAPABILITY_MUSIC_LIBRARY = 0x00000006;
        public const int SECURITY_CAPABILITY_DOCUMENTS_LIBRARY = 0x00000007;
        public const int SECURITY_CAPABILITY_ENTERPRISE_AUTHENTICATION = 0x00000008;
        public const int SECURITY_CAPABILITY_SHARED_USER_CERTIFICATES = 0x00000009;
        public const int SECURITY_CAPABILITY_REMOVABLE_STORAGE = 0x0000000A;
        public const int SECURITY_CAPABILITY_APPOINTMENTS = 0x0000000B;
        public const int SECURITY_CAPABILITY_CONTACTS = 0x0000000C;

        public const int SECURITY_CAPABILITY_INTERNET_EXPLORER = 0x00001000;

        //
        // Mandatory Label Authority.
        //

        public const int SECURITY_MANDATORY_UNTRUSTED_RID = 0x00000000;
        public const int SECURITY_MANDATORY_LOW_RID = 0x00001000;
        public const int SECURITY_MANDATORY_MEDIUM_RID = 0x00002000;
        public const int SECURITY_MANDATORY_MEDIUM_PLUS_RID = SECURITY_MANDATORY_MEDIUM_RID + 0x100;
        public const int SECURITY_MANDATORY_HIGH_RID = 0x00003000;
        public const int SECURITY_MANDATORY_SYSTEM_RID = 0x00004000;
        public const int SECURITY_MANDATORY_PROTECTED_PROCESS_RID = 0x00005000;

        /// <summary>
        /// <see cref="SECURITY_MANDATORY_MAXIMUM_USER_RID"/> is the highest RID that
        /// can be set by a usermode caller. 
        /// </summary>
        public const int SECURITY_MANDATORY_MAXIMUM_USER_RID = SECURITY_MANDATORY_SYSTEM_RID;

        //
        // Authentication Authority
        //

        public const int SECURITY_AUTHENTICATION_AUTHORITY_RID_COUNT = 1;
        public const int SECURITY_AUTHENTICATION_AUTHORITY_ASSERTED_RID = 0x00000001;
        public const int SECURITY_AUTHENTICATION_SERVICE_ASSERTED_RID = 0x00000002;
        public const int SECURITY_AUTHENTICATION_FRESH_KEY_AUTH_RID = 0x00000003;
        public const int SECURITY_AUTHENTICATION_KEY_TRUST_RID = 0x00000004;
        public const int SECURITY_AUTHENTICATION_KEY_PROPERTY_MFA_RID = 0x00000005;
        public const int SECURITY_AUTHENTICATION_KEY_PROPERTY_ATTESTATION_RID = 0x00000006;

        //
        // Process Trust Authority
        //

        public const int SECURITY_PROCESS_TRUST_AUTHORITY_RID_COUNT = 2;

        public const int SECURITY_PROCESS_PROTECTION_TYPE_FULL_RID = 0x00000400;
        public const int SECURITY_PROCESS_PROTECTION_TYPE_LITE_RID = 0x00000200;
        public const int SECURITY_PROCESS_PROTECTION_TYPE_NONE_RID = 0x00000000;

        public const int SECURITY_PROCESS_PROTECTION_LEVEL_WINTCB_RID = 0x00002000;
        public const int SECURITY_PROCESS_PROTECTION_LEVEL_WINDOWS_RID = 0x00001000;
        public const int SECURITY_PROCESS_PROTECTION_LEVEL_APP_RID = 0x00000800;
        public const int SECURITY_PROCESS_PROTECTION_LEVEL_ANTIMALWARE_RID = 0x00000600;
        public const int SECURITY_PROCESS_PROTECTION_LEVEL_AUTHENTICODE_RID = 0x00000400;
        public const int SECURITY_PROCESS_PROTECTION_LEVEL_NONE_RID = 0x00000000;

        //
        // Trusted Installer RIDs
        //

        public const int SECURITY_TRUSTED_INSTALLER_RID1 = 956008885;
        public const int SECURITY_TRUSTED_INSTALLER_RID2 = unchecked((int)3418522649);
        public const int SECURITY_TRUSTED_INSTALLER_RID3 = 1831038044;
        public const int SECURITY_TRUSTED_INSTALLER_RID4 = 1853292631;
        public const int SECURITY_TRUSTED_INSTALLER_RID5 = unchecked((int)2271478464);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9613
        ////////////////////////////////////////////////////////////////////////
        //                                                                    //
        //                          User and Group related SID attributes     //
        //                                                                    //
        ////////////////////////////////////////////////////////////////////////

        //
        // Group attributes
        //

        public const int SE_GROUP_MANDATORY = 0x00000001;
        public const int SE_GROUP_ENABLED_BY_DEFAULT = 0x00000002;
        public const int SE_GROUP_ENABLED = 0x00000004;
        public const int SE_GROUP_OWNER = 0x00000008;
        public const int SE_GROUP_USE_FOR_DENY_ONLY = 0x00000010;
        public const int SE_GROUP_INTEGRITY = 0x00000020;
        public const int SE_GROUP_INTEGRITY_ENABLED = 0x00000040;
        public const int SE_GROUP_LOGON_ID = unchecked((int)0xC0000000);
        public const int SE_GROUP_RESOURCE = 0x20000000;

        public const int SE_GROUP_VALID_ATTRIBUTES = SE_GROUP_MANDATORY | SE_GROUP_ENABLED_BY_DEFAULT | SE_GROUP_ENABLED | SE_GROUP_OWNER | SE_GROUP_USE_FOR_DENY_ONLY | SE_GROUP_LOGON_ID | SE_GROUP_RESOURCE | SE_GROUP_INTEGRITY | SE_GROUP_INTEGRITY_ENABLED;

        //
        // User attributes
        //

        // (None yet defined.)

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9652
        ////////////////////////////////////////////////////////////////////////
        //                                                                    //
        //                         ACL  and  ACE                              //
        //                                                                    //
        ////////////////////////////////////////////////////////////////////////

        //
        //  Define an ACL and the ACE format.  The structure of an ACL header
        //  followed by one or more ACEs.  Pictorally the structure of an ACL header
        //  is as follows:
        //
        //       3 3 2 2 2 2 2 2 2 2 2 2 1 1 1 1 1 1 1 1 1 1
        //       1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0
        //      +-------------------------------+---------------+---------------+
        //      |            AclSize            |      Sbz1     |  AclRevision  |
        //      +-------------------------------+---------------+---------------+
        //      |              Sbz2             |           AceCount            |
        //      +-------------------------------+-------------------------------+
        //
        //  The current AclRevision is defined to be ACL_REVISION.
        //
        //  AclSize is the size, in bytes, allocated for the ACL.  This includes
        //  the ACL header, ACES, and remaining free space in the buffer.
        //
        //  AceCount is the number of ACES in the ACL.
        //

        // begin_wdm
        // This is the *current* ACL revision

        public const byte ACL_REVISION = 2;
        public const byte ACL_REVISION_DS = 4;

        // This is the history of ACL revisions.  Add a new one whenever
        // ACL_REVISION is updated

        public const byte ACL_REVISION1 = 1;
        public const byte MIN_ACL_REVISION = ACL_REVISION2;
        public const byte ACL_REVISION2 = 2;
        public const byte ACL_REVISION3 = 3;
        public const byte ACL_REVISION4 = 4;
        public const byte MAX_ACL_REVISION = ACL_REVISION4;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9732
        //
        //  The following are the predefined ace types that go into the AceType
        //  field of an Ace header.
        //

        public const byte ACCESS_MIN_MS_ACE_TYPE = 0x0;
        public const byte ACCESS_ALLOWED_ACE_TYPE = 0x0;
        public const byte ACCESS_DENIED_ACE_TYPE = 0x1;
        public const byte SYSTEM_AUDIT_ACE_TYPE = 0x2;
        public const byte SYSTEM_ALARM_ACE_TYPE = 0x3;
        public const byte ACCESS_MAX_MS_V2_ACE_TYPE = 0x3;

        public const byte ACCESS_ALLOWED_COMPOUND_ACE_TYPE = 0x4;
        public const byte ACCESS_MAX_MS_V3_ACE_TYPE = 0x4;

        public const byte ACCESS_MIN_MS_OBJECT_ACE_TYPE = 0x5;
        public const byte ACCESS_ALLOWED_OBJECT_ACE_TYPE = 0x5;
        public const byte ACCESS_DENIED_OBJECT_ACE_TYPE = 0x6;
        public const byte SYSTEM_AUDIT_OBJECT_ACE_TYPE = 0x7;
        public const byte SYSTEM_ALARM_OBJECT_ACE_TYPE = 0x8;
        public const byte ACCESS_MAX_MS_OBJECT_ACE_TYPE = 0x8;

        public const byte ACCESS_MAX_MS_V4_ACE_TYPE = 0x8;
        public const byte ACCESS_MAX_MS_ACE_TYPE = 0x8;

        public const byte ACCESS_ALLOWED_CALLBACK_ACE_TYPE = 0x9;
        public const byte ACCESS_DENIED_CALLBACK_ACE_TYPE = 0xA;
        public const byte ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE = 0xB;
        public const byte ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE = 0xC;
        public const byte SYSTEM_AUDIT_CALLBACK_ACE_TYPE = 0xD;
        public const byte SYSTEM_ALARM_CALLBACK_ACE_TYPE = 0xE;
        public const byte SYSTEM_AUDIT_CALLBACK_OBJECT_ACE_TYPE = 0xF;
        public const byte SYSTEM_ALARM_CALLBACK_OBJECT_ACE_TYPE = 0x10;

        public const byte SYSTEM_MANDATORY_LABEL_ACE_TYPE = 0x11;
        public const byte SYSTEM_RESOURCE_ATTRIBUTE_ACE_TYPE = 0x12;
        public const byte SYSTEM_SCOPED_POLICY_ID_ACE_TYPE = 0x13;
        public const byte SYSTEM_PROCESS_TRUST_LABEL_ACE_TYPE = 0x14;
        public const byte SYSTEM_ACCESS_FILTER_ACE_TYPE = 0x15;
        public const byte ACCESS_MAX_MS_V5_ACE_TYPE = 0x15;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9774
        //
        //  The following are the inherit flags that go into the AceFlags field
        //  of an Ace header.
        //

        public const byte OBJECT_INHERIT_ACE = 0x1;
        public const byte CONTAINER_INHERIT_ACE = 0x2;
        public const byte NO_PROPAGATE_INHERIT_ACE = 0x4;
        public const byte INHERIT_ONLY_ACE = 0x8;
        public const byte INHERITED_ACE = 0x10;
        public const byte VALID_INHERIT_FLAGS = 0x1F;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9787
        //  The following are the currently defined ACE flags that go into the
        //  AceFlags field of an ACE header.  Each ACE type has its own set of
        //  AceFlags.
        //
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9793
        //
        //  SYSTEM_AUDIT and SYSTEM_ALARM AceFlags
        //
        //  These control the signaling of audit and alarms for success or failure.
        //
        //  SUCCESSFUL_ACCESS_ACE_FLAG - used only with system audit and alarm ACE
        //  types to indicate that a message is generated for successful accesses.
        //
        //  FAILED_ACCESS_ACE_FLAG - used only with system audit and alarm ACE types
        //  to indicate that a message is generated for failed accesses.
        //

        public const byte SUCCESSFUL_ACCESS_ACE_FLAG = 0x40;
        public const byte FAILED_ACCESS_ACE_FLAG = 0x80;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9808
        //
        //  SYSTEM_ACCESS_FILTER_ACE AceFlags
        //
        //  These control the behaviour of SYSTEM_ACCESS_FILTER_ACE .
        //
        //  TRUST_PROTECTED_FILTER_ACE_FLAG - used only with SYSTEM_FILTERING_ACE_TYPE
        //  ACEs to indicate that this ACE may not be deleted/modified except when the,
        //  the current Trust Level dominates the one specified in the Ace SID.
        //  If this flag is set then the SID in the ACE should be a valid TrustLevelSid.
        //

        public const byte TRUST_PROTECTED_FILTER_ACE_FLAG = 0x40;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9915
        public const int SYSTEM_MANDATORY_LABEL_NO_WRITE_UP = 0x1;
        public const int SYSTEM_MANDATORY_LABEL_NO_READ_UP = 0x2;
        public const int SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP = 0x4;

        public const int SYSTEM_MANDATORY_LABEL_VALID_MASK =
            SYSTEM_MANDATORY_LABEL_NO_WRITE_UP |
            SYSTEM_MANDATORY_LABEL_NO_READ_UP |
            SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP;

        // Placeholder value that allows all ranges
        public const int SYSTEM_PROCESS_TRUST_LABEL_VALID_MASK = 0x00ffffff;
        public const int SYSTEM_PROCESS_TRUST_NOCONSTRAINT_MASK = unchecked((int)0xffffffff);
        public const int SYSTEM_ACCESS_FILTER_VALID_MASK = 0x00ffffff;
        public const int SYSTEM_ACCESS_FILTER_NOCONSTRAINT_MASK = unchecked((int)0xffffffff);
        // end_ntifs

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10040
        //
        // Currently define Flags for "OBJECT" ACE types.
        //

        public const int ACE_OBJECT_TYPE_PRESENT = 0x1;
        public const int ACE_INHERITED_OBJECT_TYPE_PRESENT = 0x2;


        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10081
        ////////////////////////////////////////////////////////////////////////
        //                                                                    //
        //                             SECURITY_DESCRIPTOR                    //
        //                                                                    //
        ////////////////////////////////////////////////////////////////////////
        //
        //  Define the Security Descriptor and related data types.
        //  This is an opaque data structure.
        //

        //
        // Current security descriptor revision value
        //

        public const byte SECURITY_DESCRIPTOR_REVISION = 1;
        public const byte SECURITY_DESCRIPTOR_REVISION1 = 1;

        public const short SE_OWNER_DEFAULTED = 0x0001;
        public const short SE_GROUP_DEFAULTED = 0x0002;
        public const short SE_DACL_PRESENT = 0x0004;
        public const short SE_DACL_DEFAULTED = 0x0008;
        public const short SE_SACL_PRESENT = 0x0010;
        public const short SE_SACL_DEFAULTED = 0x0020;
        public const short SE_DACL_AUTO_INHERIT_REQ = 0x0100;
        public const short SE_SACL_AUTO_INHERIT_REQ = 0x0200;
        public const short SE_DACL_AUTO_INHERITED = 0x0400;
        public const short SE_SACL_AUTO_INHERITED = 0x0800;
        public const short SE_DACL_PROTECTED = 0x1000;
        public const short SE_SACL_PROTECTED = 0x2000;
        public const short SE_RM_CONTROL_VALID = 0x4000;
        public const short SE_SELF_RELATIVE = unchecked((short)0x8000);

        //
        //  Where:
        //
        //      SE_OWNER_DEFAULTED - This boolean flag, when set, indicates that the
        //          SID pointed to by the Owner field was provided by a
        //          defaulting mechanism rather than explicitly provided by the
        //          original provider of the security descriptor.  This may
        //          affect the treatment of the SID with respect to inheritence
        //          of an owner.
        //
        //      SE_GROUP_DEFAULTED - This boolean flag, when set, indicates that the
        //          SID in the Group field was provided by a defaulting mechanism
        //          rather than explicitly provided by the original provider of
        //          the security descriptor.  This may affect the treatment of
        //          the SID with respect to inheritence of a primary group.
        //
        //      SE_DACL_PRESENT - This boolean flag, when set, indicates that the
        //          security descriptor contains a discretionary ACL.  If this
        //          flag is set and the Dacl field of the SECURITY_DESCRIPTOR is
        //          null, then a null ACL is explicitly being specified.
        //
        //      SE_DACL_DEFAULTED - This boolean flag, when set, indicates that the
        //          ACL pointed to by the Dacl field was provided by a defaulting
        //          mechanism rather than explicitly provided by the original
        //          provider of the security descriptor.  This may affect the
        //          treatment of the ACL with respect to inheritence of an ACL.
        //          This flag is ignored if the DaclPresent flag is not set.
        //
        //      SE_SACL_PRESENT - This boolean flag, when set,  indicates that the
        //          security descriptor contains a system ACL pointed to by the
        //          Sacl field.  If this flag is set and the Sacl field of the
        //          SECURITY_DESCRIPTOR is null, then an empty (but present)
        //          ACL is being specified.
        //
        //      SE_SACL_DEFAULTED - This boolean flag, when set, indicates that the
        //          ACL pointed to by the Sacl field was provided by a defaulting
        //          mechanism rather than explicitly provided by the original
        //          provider of the security descriptor.  This may affect the
        //          treatment of the ACL with respect to inheritence of an ACL.
        //          This flag is ignored if the SaclPresent flag is not set.
        //
        //      SE_SELF_RELATIVE - This boolean flag, when set, indicates that the
        //          security descriptor is in self-relative form.  In this form,
        //          all fields of the security descriptor are contiguous in memory
        //          and all pointer fields are expressed as offsets from the
        //          beginning of the security descriptor.  This form is useful
        //          for treating security descriptors as opaque data structures
        //          for transmission in communication protocol or for storage on
        //          secondary media.
        //


        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10278
        //
        // DS values for Level
        //

        public const short ACCESS_OBJECT_GUID = 0;
        public const short ACCESS_PROPERTY_SET_GUID = 1;
        public const short ACCESS_PROPERTY_GUID = 2;

        public const short ACCESS_MAX_LEVEL = 4;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10278
        public const int AUDIT_ALLOW_NO_PRIVILEGE = 0x1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10278
        //
        // DS values for Source and ObjectTypeName
        //

        public const string ACCESS_DS_SOURCE_A = "DS";
        public const string ACCESS_DS_SOURCE_W = "DS";
        public const string ACCESS_DS_OBJECT_TYPE_NAME_A = "Directory Service Object";
        public const string ACCESS_DS_OBJECT_TYPE_NAME_W = "Directory Service Object";

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10278
        ////////////////////////////////////////////////////////////////////////
        //                                                                    //
        //               Privilege Related Data Structures                    //
        //                                                                    //
        ////////////////////////////////////////////////////////////////////////

        //
        // Privilege attributes
        //

        public const int SE_PRIVILEGE_ENABLED_BY_DEFAULT = 0x00000001;
        public const int SE_PRIVILEGE_ENABLED = 0x00000002;
        public const int SE_PRIVILEGE_REMOVED = 0X00000004;
        public const int SE_PRIVILEGE_USED_FOR_ACCESS = unchecked((int)0x80000000);

        public const int SE_PRIVILEGE_VALID_ATTRIBUTES = SE_PRIVILEGE_ENABLED_BY_DEFAULT | SE_PRIVILEGE_ENABLED | SE_PRIVILEGE_REMOVED | SE_PRIVILEGE_USED_FOR_ACCESS;

        //
        // Privilege Set Control flags
        //

        public const int PRIVILEGE_SET_ALL_NECESSARY = 1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10278
        public const int ACCESS_REASON_TYPE_MASK = 0x00ff0000;
        public const int ACCESS_REASON_DATA_MASK = 0x0000ffff;

        public const int ACCESS_REASON_STAGING_MASK = unchecked((int)0x80000000);
        public const int ACCESS_REASON_EXDATA_MASK = 0x7f000000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10445
        public const int SE_SECURITY_DESCRIPTOR_FLAG_NO_OWNER_ACE = 0x00000001;
        public const int SE_SECURITY_DESCRIPTOR_FLAG_NO_LABEL_ACE = 0x00000002;
        public const int SE_SECURITY_DESCRIPTOR_FLAG_NO_ACCESS_FILTER_ACE = 0x00000004;
        public const int SE_SECURITY_DESCRIPTOR_VALID_FLAGS = 0x00000007;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10482
        ////////////////////////////////////////////////////////////////////////
        //                                                                    //
        //               NT Defined Privileges                                //
        //                                                                    //
        ////////////////////////////////////////////////////////////////////////

        public const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";
        public const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";
        public const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";
        public const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";
        public const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";
        public const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";
        public const string SE_TCB_NAME = "SeTcbPrivilege";
        public const string SE_SECURITY_NAME = "SeSecurityPrivilege";
        public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";
        public const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";
        public const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";
        public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";
        public const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";
        public const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";
        public const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";
        public const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";
        public const string SE_BACKUP_NAME = "SeBackupPrivilege";
        public const string SE_RESTORE_NAME = "SeRestorePrivilege";
        public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        public const string SE_DEBUG_NAME = "SeDebugPrivilege";
        public const string SE_AUDIT_NAME = "SeAuditPrivilege";
        public const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";
        public const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";
        public const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";
        public const string SE_UNDOCK_NAME = "SeUndockPrivilege";
        public const string SE_SYNC_AGENT_NAME = "SeSyncAgentPrivilege";
        public const string SE_ENABLE_DELEGATION_NAME = "SeEnableDelegationPrivilege";
        public const string SE_MANAGE_VOLUME_NAME = "SeManageVolumePrivilege";
        public const string SE_IMPERSONATE_NAME = "SeImpersonatePrivilege";
        public const string SE_CREATE_GLOBAL_NAME = "SeCreateGlobalPrivilege";
        public const string SE_TRUSTED_CREDMAN_ACCESS_NAME = "SeTrustedCredManAccessPrivilege";
        public const string SE_RELABEL_NAME = "SeRelabelPrivilege";
        public const string SE_INC_WORKING_SET_NAME = "SeIncreaseWorkingSetPrivilege";
        public const string SE_TIME_ZONE_NAME = "SeTimeZonePrivilege";
        public const string SE_CREATE_SYMBOLIC_LINK_NAME = "SeCreateSymbolicLinkPrivilege";
        public const string SE_DELEGATE_SESSION_USER_IMPERSONATE_NAME = "SeDelegateSessionUserImpersonatePrivilege";

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10527
        //
        // List Of String Capabilities.
        //
        public const string SE_ACTIVATE_AS_USER_CAPABILITY = "activateAsUser";
        public const string SE_CONSTRAINED_IMPERSONATION_CAPABILITY = "constrainedImpersonation";
        public const string SE_SESSION_IMPERSONATION_CAPABILITY = "sessionImpersonation";
        public const string SE_MUMA_CAPABILITY = "muma";
        public const string SE_DEVELOPMENT_MODE_NETWORK_CAPABILITY = "developmentModeNetwork";

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10527
        ////////////////////////////////////////////////////////////////////
        //                                                                //
        //           Security Quality Of Service                          //
        //                                                                //
        //                                                                //
        ////////////////////////////////////////////////////////////////////

        //
        // Impersonation Level
        //
        // Impersonation level is represented by a pair of bits in Windows.
        //

        public const TokenImpersonationLevel SECURITY_MAX_IMPERSONATION_LEVEL = TokenImpersonationLevel.Delegation;
        public const TokenImpersonationLevel SECURITY_MIN_IMPERSONATION_LEVEL = TokenImpersonationLevel.Anonymous;
        public const TokenImpersonationLevel DEFAULT_IMPERSONATION_LEVEL = TokenImpersonationLevel.Impersonation;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10569
        ////////////////////////////////////////////////////////////////////
        //                                                                //
        //           Token Object Definitions                             //
        //                                                                //
        //                                                                //
        ////////////////////////////////////////////////////////////////////

        //
        // Token Specific Access Rights.
        //

        public const TokenAccessLevels TOKEN_ASSIGN_PRIMARY = TokenAccessLevels.AssignPrimary;
        public const TokenAccessLevels TOKEN_DUPLICATE = TokenAccessLevels.Duplicate;
        public const TokenAccessLevels TOKEN_IMPERSONATE = TokenAccessLevels.Impersonate;
        public const TokenAccessLevels TOKEN_QUERY = TokenAccessLevels.Query;
        public const TokenAccessLevels TOKEN_QUERY_SOURCE = TokenAccessLevels.QuerySource;
        public const TokenAccessLevels TOKEN_ADJUST_PRIVILEGES = TokenAccessLevels.AdjustPrivileges;
        public const TokenAccessLevels TOKEN_ADJUST_GROUPS = TokenAccessLevels.AdjustGroups;
        public const TokenAccessLevels TOKEN_ADJUST_DEFAULT = TokenAccessLevels.AdjustDefault;
        public const TokenAccessLevels TOKEN_ADJUST_SESSIONID = TokenAccessLevels.AdjustSessionId;

        public const TokenAccessLevels TOKEN_ALL_ACCESS_P = (TokenAccessLevels)STANDARD_RIGHTS_REQUIRED | TOKEN_ASSIGN_PRIMARY | TOKEN_DUPLICATE | TOKEN_IMPERSONATE | TOKEN_QUERY | TOKEN_QUERY_SOURCE | TOKEN_ADJUST_PRIVILEGES | TOKEN_ADJUST_GROUPS | TOKEN_ADJUST_DEFAULT;

        public const TokenAccessLevels TOKEN_ALL_ACCESS = TOKEN_ALL_ACCESS_P | TOKEN_ADJUST_SESSIONID;

        public const TokenAccessLevels TOKEN_READ = TokenAccessLevels.Read;
        public const TokenAccessLevels TOKEN_WRITE = TokenAccessLevels.Write;
        public const TokenAccessLevels TOKEN_EXECUTE = (TokenAccessLevels)STANDARD_RIGHTS_EXECUTE;

        public const TokenAccessLevels TOKEN_TRUST_CONSTRAINT_MASK = (TokenAccessLevels)STANDARD_RIGHTS_READ | TOKEN_QUERY | TOKEN_QUERY_SOURCE;

        public const TokenAccessLevels TOKEN_ACCESS_PSEUDO_HANDLE_WIN8 = TOKEN_QUERY | TOKEN_QUERY_SOURCE;
        public const TokenAccessLevels TOKEN_ACCESS_PSEUDO_HANDLE = TOKEN_ACCESS_PSEUDO_HANDLE_WIN8;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10803
        public const int TOKEN_MANDATORY_POLICY_OFF = 0x0;
        public const int TOKEN_MANDATORY_POLICY_NO_WRITE_UP = 0x1;
        public const int TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN = 0x2;

        public const int TOKEN_MANDATORY_POLICY_VALID_MASK = TOKEN_MANDATORY_POLICY_NO_WRITE_UP | TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10840
        public const int POLICY_AUDIT_SUBCATEGORY_COUNT = 59;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10846
        public const int TOKEN_SOURCE_LENGTH = 8;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10908
        //
        //  *** Claim Security attributes ***
        //
        //      These #defines and data structures (almost) exactly mirror
        //      the Token_XXX definitions (except for PWSTR/PUNICODE changes)
        //      in ntseapi.w as well as AUTHZ_XXX in authz.w. 
        //      Keep them in sync. 
        //
        //
        //  Security attribute data types ...
        //

        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID = 0x00;

        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64 = 0x01;
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64 = 0x02;

        /// <summary>
        /// Case insensitive attribute value string by default.
        /// Unless the flag <see cref="CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE"/>
        /// is set indicating otherwise.
        /// </summary>
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING = 0x03;

        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN = 0x04;

        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_SID = 0x05;

        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN = 0x06;

        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING = 0x10;

        //
        // Attribute Flags
        //

        /// <summary>
        /// Attribute must not be inherited across process spawns.
        /// </summary>
        public const int CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE = 0x0001;

        /// <summary>
        /// Attribute value is compared in a case sensitive way. It is valid with string value
        /// or composite type containing string value. For other types of value, this flag
        /// will be ignored. Currently, it is valid with the two types:
        /// <see cref="CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING"/> and <see cref="CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN"/>.
        /// </summary>
        public const int CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE = 0x0002;

        /// <summary>
        /// Attribute is considered only for Deny Aces.
        /// </summary>
        public const int CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY = 0x0004;

        /// <summary>
        /// Attribute is disabled by default.
        /// </summary>
        public const int CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT = 0x0008;

        /// <summary>
        /// Attribute is disabled.
        /// </summary>
        public const int CLAIM_SECURITY_ATTRIBUTE_DISABLED = 0x0010;

        /// <summary>
        /// Attribute is mandatory.
        /// </summary>
        public const int CLAIM_SECURITY_ATTRIBUTE_MANDATORY = 0x0020;

        public const int CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS =
            CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE |
            CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE |
            CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY |
            CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT |
            CLAIM_SECURITY_ATTRIBUTE_DISABLED |
            CLAIM_SECURITY_ATTRIBUTE_MANDATORY;

        /// <summary>
        /// Reserve upper 16 bits for custom flags. These should be preserved but not
        /// validated as they do not affect security in any way.
        /// </summary>
        public const int CLAIM_SECURITY_ATTRIBUTE_CUSTOM_FLAGS = unchecked((int)0xFFFF0000);

        public const int CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1 = 1;

        /// <summary>
        /// Versioning. 
        /// <para>
        /// Get operations return the version while the set operation
        /// MUST specify the version of the data structure passed in.
        /// </para>
        /// </summary>
        public const int CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION =
            CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11160
        //
        // Security Tracking Mode
        //

        public const byte SECURITY_DYNAMIC_TRACKING = 1;
        public const byte SECURITY_STATIC_TRACKING = 0;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11195
        public const int DISABLE_MAX_PRIVILEGE = 0x1;
        public const int SANDBOX_INERT = 0x2;
        public const int LUA_TOKEN = 0x4;
        public const int WRITE_RESTRICTED = 0x8;

        public const int OWNER_SECURITY_INFORMATION = 0x00000001;
        public const int GROUP_SECURITY_INFORMATION = 0x00000002;
        public const int DACL_SECURITY_INFORMATION = 0x00000004;
        public const int SACL_SECURITY_INFORMATION = 0x00000008;
        public const int LABEL_SECURITY_INFORMATION = 0x00000010;
        public const int ATTRIBUTE_SECURITY_INFORMATION = 0x00000020;
        public const int SCOPE_SECURITY_INFORMATION = 0x00000040;
        public const int PROCESS_TRUST_LABEL_SECURITY_INFORMATION = 0x00000080;
        public const int ACCESS_FILTER_SECURITY_INFORMATION = 0x00000100;
        public const int BACKUP_SECURITY_INFORMATION = 0x00010000;

        public const int PROTECTED_DACL_SECURITY_INFORMATION = unchecked((int)0x80000000);
        public const int PROTECTED_SACL_SECURITY_INFORMATION = 0x40000000;
        public const int UNPROTECTED_DACL_SECURITY_INFORMATION = 0x20000000;
        public const int UNPROTECTED_SACL_SECURITY_INFORMATION = 0x10000000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11219
        //
        // Base signing levels.
        //

        public const byte SE_SIGNING_LEVEL_UNCHECKED = 0x00000000;
        public const byte SE_SIGNING_LEVEL_UNSIGNED = 0x00000001;
        public const byte SE_SIGNING_LEVEL_ENTERPRISE = 0x00000002;
        public const byte SE_SIGNING_LEVEL_CUSTOM_1 = 0x00000003;
        public const byte SE_SIGNING_LEVEL_AUTHENTICODE = 0x00000004;
        public const byte SE_SIGNING_LEVEL_CUSTOM_2 = 0x00000005;
        public const byte SE_SIGNING_LEVEL_STORE = 0x00000006;
        public const byte SE_SIGNING_LEVEL_CUSTOM_3 = 0x00000007;
        public const byte SE_SIGNING_LEVEL_ANTIMALWARE = SE_SIGNING_LEVEL_CUSTOM_3;
        public const byte SE_SIGNING_LEVEL_MICROSOFT = 0x00000008;
        public const byte SE_SIGNING_LEVEL_CUSTOM_4 = 0x00000009;
        public const byte SE_SIGNING_LEVEL_CUSTOM_5 = 0x0000000A;
        public const byte SE_SIGNING_LEVEL_DYNAMIC_CODEGEN = 0x0000000B;
        public const byte SE_SIGNING_LEVEL_WINDOWS = 0x0000000C;
        public const byte SE_SIGNING_LEVEL_CUSTOM_7 = 0x0000000D;
        public const byte SE_SIGNING_LEVEL_WINDOWS_TCB = 0x0000000E;
        public const byte SE_SIGNING_LEVEL_CUSTOM_6 = 0x0000000F;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11269
        public const int SE_LEARNING_MODE_FLAG_PERMISSIVE = 0x00000001;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11284
        public const int PROCESS_TERMINATE = 0x0001;
        public const int PROCESS_CREATE_THREAD = 0x0002;
        public const int PROCESS_SET_SESSIONID = 0x0004;
        public const int PROCESS_VM_OPERATION = 0x0008;
        public const int PROCESS_VM_READ = 0x0010;
        public const int PROCESS_VM_WRITE = 0x0020;
        public const int PROCESS_DUP_HANDLE = 0x0040;
        public const int PROCESS_CREATE_PROCESS = 0x0080;
        public const int PROCESS_SET_QUOTA = 0x0100;
        public const int PROCESS_SET_INFORMATION = 0x0200;
        public const int PROCESS_QUERY_INFORMATION = 0x0400;
        public const int PROCESS_SUSPEND_RESUME = 0x0800;
        public const int PROCESS_QUERY_LIMITED_INFORMATION = 0x1000;
        public const int PROCESS_SET_LIMITED_INFORMATION = 0x2000;
        public const int PROCESS_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0xFFFF;

        public const int THREAD_TERMINATE = 0x0001;
        public const int THREAD_SUSPEND_RESUME = 0x0002;
        public const int THREAD_GET_CONTEXT = 0x0008;
        public const int THREAD_SET_CONTEXT = 0x0010;
        public const int THREAD_QUERY_INFORMATION = 0x0040;
        public const int THREAD_SET_INFORMATION = 0x0020;
        public const int THREAD_SET_THREAD_TOKEN = 0x0080;
        public const int THREAD_IMPERSONATE = 0x0100;
        public const int THREAD_DIRECT_IMPERSONATION = 0x0200;
        // begin_wdm
        public const int THREAD_SET_LIMITED_INFORMATION = 0x0400;  // winnt
        public const int THREAD_QUERY_LIMITED_INFORMATION = 0x0800;  // winnt
        public const int THREAD_RESUME = 0x1000;  // winnt
        public const int THREAD_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0xFFFF;

        public const int JOB_OBJECT_ASSIGN_PROCESS = 0x0001;
        public const int JOB_OBJECT_SET_ATTRIBUTES = 0x0002;
        public const int JOB_OBJECT_QUERY = 0x0004;
        public const int JOB_OBJECT_TERMINATE = 0x0008;
        public const int JOB_OBJECT_SET_SECURITY_ATTRIBUTES = 0x0010;
        public const int JOB_OBJECT_IMPERSONATE = 0x0020;
        public const int JOB_OBJECT_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3F;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11343
        public const int FLS_MAXIMUM_AVAILABLE = 128;
        public const int TLS_MINIMUM_AVAILABLE = 64;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11415
        /// <summary>Opt-out of dynamic code generation.</summary>
        public const int THREAD_DYNAMIC_CODE_ALLOW = 1;

        /// <summary>value that gets a thread to LowRealtime-1</summary>
        public const int THREAD_BASE_PRIORITY_LOWRT = 15;
        /// <summary>maximum thread base priority boost</summary>
        public const int THREAD_BASE_PRIORITY_MAX = 2;
        /// <summary>minimum thread base priority boost</summary>
        public const int THREAD_BASE_PRIORITY_MIN = -2;
        /// <summary>value that gets a thread to idle</summary>
        public const int THREAD_BASE_PRIORITY_IDLE = -15;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13566
        //
        // Object Manager Symbolic Link Specific Access Rights.
        //

        public const int DUPLICATE_CLOSE_SOURCE = 0x00000001;
        public const int DUPLICATE_SAME_ACCESS = 0x00000002;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11438
        //
        // Page/memory priorities.
        //

        public const int MEMORY_PRIORITY_LOWEST = 0;
        public const int MEMORY_PRIORITY_VERY_LOW = 1;
        public const int MEMORY_PRIORITY_LOW = 2;
        public const int MEMORY_PRIORITY_MEDIUM = 3;
        public const int MEMORY_PRIORITY_BELOW_NORMAL = 4;
        public const int MEMORY_PRIORITY_NORMAL = 5;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11459
        public const int QUOTA_LIMITS_HARDWS_MIN_ENABLE = 0x00000001;
        public const int QUOTA_LIMITS_HARDWS_MIN_DISABLE = 0x00000002;
        public const int QUOTA_LIMITS_HARDWS_MAX_ENABLE = 0x00000004;
        public const int QUOTA_LIMITS_HARDWS_MAX_DISABLE = 0x00000008;
        public const int QUOTA_LIMITS_USE_DEFAULT_LIMITS = 0x00000010;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11498
        public const int MAX_HW_COUNTERS = 16;
        public const int THREAD_PROFILING_FLAG_DISPATCH = 0x00000001;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11905
        public const int JOB_OBJECT_NET_RATE_CONTROL_MAX_DSCP_TAG = 64;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12014
        public const int JOB_OBJECT_TERMINATE_AT_END_OF_JOB = 0;
        public const int JOB_OBJECT_POST_AT_END_OF_JOB = 1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12017
        //
        // Completion Port Messages for job objects
        //
        // These values are returned via the lpNumberOfBytesTransferred parameter
        //

        public const int JOB_OBJECT_MSG_END_OF_JOB_TIME = 1;
        public const int JOB_OBJECT_MSG_END_OF_PROCESS_TIME = 2;
        public const int JOB_OBJECT_MSG_ACTIVE_PROCESS_LIMIT = 3;
        public const int JOB_OBJECT_MSG_ACTIVE_PROCESS_ZERO = 4;
        public const int JOB_OBJECT_MSG_NEW_PROCESS = 6;
        public const int JOB_OBJECT_MSG_EXIT_PROCESS = 7;
        public const int JOB_OBJECT_MSG_ABNORMAL_EXIT_PROCESS = 8;
        public const int JOB_OBJECT_MSG_PROCESS_MEMORY_LIMIT = 9;
        public const int JOB_OBJECT_MSG_JOB_MEMORY_LIMIT = 10;
        public const int JOB_OBJECT_MSG_NOTIFICATION_LIMIT = 11;
        public const int JOB_OBJECT_MSG_JOB_CYCLE_TIME_LIMIT = 12;
        public const int JOB_OBJECT_MSG_SILO_TERMINATED = 13;


        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12047
        //
        // Basic Limits
        //
        public const int JOB_OBJECT_LIMIT_WORKINGSET = 0x00000001;
        public const int JOB_OBJECT_LIMIT_PROCESS_TIME = 0x00000002;
        public const int JOB_OBJECT_LIMIT_JOB_TIME = 0x00000004;
        public const int JOB_OBJECT_LIMIT_ACTIVE_PROCESS = 0x00000008;
        public const int JOB_OBJECT_LIMIT_AFFINITY = 0x00000010;
        public const int JOB_OBJECT_LIMIT_PRIORITY_CLASS = 0x00000020;
        public const int JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME = 0x00000040;
        public const int JOB_OBJECT_LIMIT_SCHEDULING_CLASS = 0x00000080;

        //
        // Extended Limits
        //
        public const int JOB_OBJECT_LIMIT_PROCESS_MEMORY = 0x00000100;
        public const int JOB_OBJECT_LIMIT_JOB_MEMORY = 0x00000200;
        public const int JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH = JOB_OBJECT_LIMIT_JOB_MEMORY;
        public const int JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION = 0x00000400;
        public const int JOB_OBJECT_LIMIT_BREAKAWAY_OK = 0x00000800;
        public const int JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK = 0x00001000;
        public const int JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE = 0x00002000;
        public const int JOB_OBJECT_LIMIT_SUBSET_AFFINITY = 0x00004000;
        public const int JOB_OBJECT_LIMIT_JOB_MEMORY_LOW = 0x00008000;

        //
        // Notification Limits
        //

        public const int JOB_OBJECT_LIMIT_JOB_READ_BYTES = 0x00010000;
        public const int JOB_OBJECT_LIMIT_JOB_WRITE_BYTES = 0x00020000;
        public const int JOB_OBJECT_LIMIT_RATE_CONTROL = 0x00040000;
        public const int JOB_OBJECT_LIMIT_CPU_RATE_CONTROL = JOB_OBJECT_LIMIT_RATE_CONTROL;
        public const int JOB_OBJECT_LIMIT_IO_RATE_CONTROL = 0x00080000;
        public const int JOB_OBJECT_LIMIT_NET_RATE_CONTROL = 0x00100000;


        //
        // Valid Job Object Limits
        //

        public const int JOB_OBJECT_LIMIT_VALID_FLAGS = 0x0007ffff;
        public const int JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS = 0x000000ff;
        public const int JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS = 0x00007fff;
        public const int JOB_OBJECT_NOTIFICATION_LIMIT_VALID_FLAGS =
            JOB_OBJECT_LIMIT_JOB_READ_BYTES |
            JOB_OBJECT_LIMIT_JOB_WRITE_BYTES |
            JOB_OBJECT_LIMIT_JOB_TIME |
            JOB_OBJECT_LIMIT_JOB_MEMORY_LOW |
            JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH |
            JOB_OBJECT_LIMIT_CPU_RATE_CONTROL |
            JOB_OBJECT_LIMIT_IO_RATE_CONTROL |
            JOB_OBJECT_LIMIT_NET_RATE_CONTROL;

        //
        // UI restrictions for jobs
        //

        public const int JOB_OBJECT_UILIMIT_NONE = 0x00000000;

        public const int JOB_OBJECT_UILIMIT_HANDLES = 0x00000001;
        public const int JOB_OBJECT_UILIMIT_READCLIPBOARD = 0x00000002;
        public const int JOB_OBJECT_UILIMIT_WRITECLIPBOARD = 0x00000004;
        public const int JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS = 0x00000008;
        public const int JOB_OBJECT_UILIMIT_DISPLAYSETTINGS = 0x00000010;
        public const int JOB_OBJECT_UILIMIT_GLOBALATOMS = 0x00000020;
        public const int JOB_OBJECT_UILIMIT_DESKTOP = 0x00000040;
        public const int JOB_OBJECT_UILIMIT_EXITWINDOWS = 0x00000080;

        public const int JOB_OBJECT_UILIMIT_ALL = 0x000000FF;

        public const int JOB_OBJECT_UI_VALID_FLAGS = 0x000000FF;

        public const int JOB_OBJECT_SECURITY_NO_ADMIN = 0x00000001;
        public const int JOB_OBJECT_SECURITY_RESTRICTED_TOKEN = 0x00000002;
        public const int JOB_OBJECT_SECURITY_ONLY_TOKEN = 0x00000004;
        public const int JOB_OBJECT_SECURITY_FILTER_TOKENS = 0x00000008;

        public const int JOB_OBJECT_SECURITY_VALID_FLAGS = 0x0000000f;

        //
        // Control flags for CPU rate control.
        //

        public const int JOB_OBJECT_CPU_RATE_CONTROL_ENABLE = 0x1;
        public const int JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED = 0x2;
        public const int JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP = 0x4;
        public const int JOB_OBJECT_CPU_RATE_CONTROL_NOTIFY = 0x8;
        public const int JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE = 0x10;
        public const int JOB_OBJECT_CPU_RATE_CONTROL_VALID_FLAGS = 0x1f;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12223
        public const int EVENT_MODIFY_STATE = 0x0002;
        public const int EVENT_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12226
        //
        // Mutant Specific Access Rights
        //
        public const int MUTANT_QUERY_STATE = 0x0001;

        public const int MUTANT_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE |
            MUTANT_QUERY_STATE;

        public const int SEMAPHORE_MODIFY_STATE = 0x0002;
        public const int SEMAPHORE_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3;

        //
        // Timer Specific Access Rights.
        //

        public const int TIMER_QUERY_STATE = 0x0001;
        public const int TIMER_MODIFY_STATE = 0x0002;

        public const int TIMER_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE |
            TIMER_QUERY_STATE | TIMER_MODIFY_STATE;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12249
        public const int TIME_ZONE_ID_UNKNOWN = 0;
        public const int TIME_ZONE_ID_STANDARD = 1;
        public const int TIME_ZONE_ID_DAYLIGHT = 2;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12264
        public const int LTP_PC_SMT = 0x1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12273
        public const int CACHE_FULLY_ASSOCIATIVE = 0xFF;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12400
        public const int PROCESSOR_INTEL_386 = 386;
        public const int PROCESSOR_INTEL_486 = 486;
        public const int PROCESSOR_INTEL_PENTIUM = 586;
        public const int PROCESSOR_INTEL_IA64 = 2200;
        public const int PROCESSOR_AMD_X8664 = 8664;
        /// <summary>incl R4101 &amp; R3910 for Windows CE</summary>
        public const int PROCESSOR_MIPS_R4000 = 4000;
        public const int PROCESSOR_ALPHA_21064 = 21064;
        public const int PROCESSOR_PPC_601 = 601;
        public const int PROCESSOR_PPC_603 = 603;
        public const int PROCESSOR_PPC_604 = 604;
        public const int PROCESSOR_PPC_620 = 620;
        /// <summary>Windows CE</summary>
        public const int PROCESSOR_HITACHI_SH3 = 10003;
        /// <summary>Windows CE</summary>
        public const int PROCESSOR_HITACHI_SH3E = 10004;
        /// <summary>Windows CE</summary>
        public const int PROCESSOR_HITACHI_SH4 = 10005;
        /// <summary>Windows CE</summary>
        public const int PROCESSOR_MOTOROLA_821 = 821;
        /// <summary>Windows CE</summary>
        public const int PROCESSOR_SHx_SH3 = 103;
        /// <summary>Windows CE</summary>
        public const int PROCESSOR_SHx_SH4 = 104;
        /// <summary>Windows CE - 0xA11</summary>
        public const int PROCESSOR_STRONGARM = 2577;
        /// <summary>Windows CE - 0x720</summary>
        public const int PROCESSOR_ARM720 = 1824;
        /// <summary>Windows CE - 0x820</summary>
        public const int PROCESSOR_ARM820 = 2080;
        /// <summary>Windows CE - 0x920</summary>
        public const int PROCESSOR_ARM920 = 2336;
        /// <summary>Windows CE</summary>
        public const int PROCESSOR_ARM_7TDMI = 70001;
        /// <summary>MSIL</summary>
        public const int PROCESSOR_OPTIL = 0x494f;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12424
        public const int PROCESSOR_ARCHITECTURE_INTEL = 0;
        public const int PROCESSOR_ARCHITECTURE_MIPS = 1;
        public const int PROCESSOR_ARCHITECTURE_ALPHA = 2;
        public const int PROCESSOR_ARCHITECTURE_PPC = 3;
        public const int PROCESSOR_ARCHITECTURE_SHX = 4;
        public const int PROCESSOR_ARCHITECTURE_ARM = 5;
        public const int PROCESSOR_ARCHITECTURE_IA64 = 6;
        public const int PROCESSOR_ARCHITECTURE_ALPHA64 = 7;
        public const int PROCESSOR_ARCHITECTURE_MSIL = 8;
        public const int PROCESSOR_ARCHITECTURE_AMD64 = 9;
        public const int PROCESSOR_ARCHITECTURE_IA32_ON_WIN64 = 10;
        public const int PROCESSOR_ARCHITECTURE_NEUTRAL = 11;
        public const int PROCESSOR_ARCHITECTURE_ARM64 = 12;
        public const int PROCESSOR_ARCHITECTURE_ARM32_ON_WIN64 = 13;
        public const int PROCESSOR_ARCHITECTURE_IA32_ON_ARM64 = 14;

        public const int PROCESSOR_ARCHITECTURE_UNKNOWN = 0xFFFF;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12442
        public const int PF_FLOATING_POINT_PRECISION_ERRATA = 0;
        public const int PF_FLOATING_POINT_EMULATED = 1;
        public const int PF_COMPARE_EXCHANGE_DOUBLE = 2;
        public const int PF_MMX_INSTRUCTIONS_AVAILABLE = 3;
        public const int PF_PPC_MOVEMEM_64BIT_OK = 4;
        public const int PF_ALPHA_BYTE_INSTRUCTIONS = 5;
        public const int PF_XMMI_INSTRUCTIONS_AVAILABLE = 6;
        public const int PF_3DNOW_INSTRUCTIONS_AVAILABLE = 7;
        public const int PF_RDTSC_INSTRUCTION_AVAILABLE = 8;
        public const int PF_PAE_ENABLED = 9;
        public const int PF_XMMI64_INSTRUCTIONS_AVAILABLE = 10;
        public const int PF_SSE_DAZ_MODE_AVAILABLE = 11;
        public const int PF_NX_ENABLED = 12;
        public const int PF_SSE3_INSTRUCTIONS_AVAILABLE = 13;
        public const int PF_COMPARE_EXCHANGE128 = 14;
        public const int PF_COMPARE64_EXCHANGE128 = 15;
        public const int PF_CHANNELS_ENABLED = 16;
        public const int PF_XSAVE_ENABLED = 17;
        public const int PF_ARM_VFP_32_REGISTERS_AVAILABLE = 18;
        public const int PF_ARM_NEON_INSTRUCTIONS_AVAILABLE = 19;
        public const int PF_SECOND_LEVEL_ADDRESS_TRANSLATION = 20;
        public const int PF_VIRT_FIRMWARE_ENABLED = 21;
        public const int PF_RDWRFSGSBASE_AVAILABLE = 22;
        public const int PF_FASTFAIL_AVAILABLE = 23;
        public const int PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE = 24;
        public const int PF_ARM_64BIT_LOADSTORE_ATOMIC = 25;
        public const int PF_ARM_EXTERNAL_CACHE_AVAILABLE = 26;
        public const int PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE = 27;
        public const int PF_RDRAND_INSTRUCTION_AVAILABLE = 28;
        public const int PF_ARM_V8_INSTRUCTIONS_AVAILABLE = 29;
        public const int PF_ARM_V8_CRYPTO_INSTRUCTIONS_AVAILABLE = 30;
        public const int PF_ARM_V8_CRC32_INSTRUCTIONS_AVAILABLE = 31;
        public const int PF_RDTSCP_INSTRUCTION_AVAILABLE = 32;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12476
        //
        // Known extended CPU state feature BITs
        //
        // 0    x87
        // 1    SSE
        // 2    AVX
        // 3    BNDREGS (B0.LB-B3.LB B0.UB-B3.UB)
        // 4    BNDCSR  (BNDCFGU + BNDSTATUS)       Persistent
        // 5    KMASK   (KMASK [63:0][0-7])
        // 6    ZMM_H   (ZMM_H[511:256][0-15])
        // 7    ZMM     (ZMM[511:0][16-31])
        // 8    IPT                                 Supervisor
        //
        // 62   LWP                                 Persistent
        //
        // 63   RZ0                                 Reserved
        //

        public const int XSTATE_LEGACY_FLOATING_POINT = 0;
        public const int XSTATE_LEGACY_SSE = 1;
        public const int XSTATE_GSSE = 2;
        public const int XSTATE_AVX = XSTATE_GSSE;
        public const int XSTATE_MPX_BNDREGS = 3;
        public const int XSTATE_MPX_BNDCSR = 4;
        public const int XSTATE_AVX512_KMASK = 5;
        public const int XSTATE_AVX512_ZMM_H = 6;
        public const int XSTATE_AVX512_ZMM = 7;
        public const int XSTATE_IPT = 8;
        public const int XSTATE_LWP = 62;
        public const int MAXIMUM_XSTATE_FEATURES = 64;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12507
        //
        // Known extended CPU state feature MASKs
        //

        public const ulong XSTATE_MASK_LEGACY_FLOATING_POINT =
            1UL << (XSTATE_LEGACY_FLOATING_POINT);
        public const ulong XSTATE_MASK_LEGACY_SSE =
            1UL << (XSTATE_LEGACY_SSE);
        public const ulong XSTATE_MASK_LEGACY =
            XSTATE_MASK_LEGACY_FLOATING_POINT |
            XSTATE_MASK_LEGACY_SSE;

        public const ulong XSTATE_MASK_GSSE =
            1UL << (XSTATE_GSSE);
        public const ulong XSTATE_MASK_AVX =
            XSTATE_MASK_GSSE;
        public const ulong XSTATE_MASK_MPX =
            (1UL << (XSTATE_MPX_BNDREGS)) |
            (1UL << (XSTATE_MPX_BNDCSR));

        public const ulong XSTATE_MASK_AVX512 =
            (1UL << (XSTATE_AVX512_KMASK)) |
            (1UL << (XSTATE_AVX512_ZMM_H)) |
            (1UL << (XSTATE_AVX512_ZMM));

        public const ulong XSTATE_MASK_IPT = 1UL << (XSTATE_IPT);
        public const ulong XSTATE_MASK_LWP = 1UL << (XSTATE_LWP);

        public const ulong XSTATE_MASK_ALLOWED =
            XSTATE_MASK_LEGACY |
            XSTATE_MASK_AVX |
            XSTATE_MASK_MPX |
            XSTATE_MASK_AVX512 |
            XSTATE_MASK_IPT |
            XSTATE_MASK_LWP;

        public const ulong XSTATE_MASK_PERSISTENT =
            (1UL << (XSTATE_MPX_BNDCSR)) |
            XSTATE_MASK_LWP;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12538
        //
        // Flags associated with compaction mask
        //

        public const int XSTATE_COMPACTION_ENABLE = 63;
        public const ulong XSTATE_COMPACTION_ENABLE_MASK =
            1UL << (XSTATE_COMPACTION_ENABLE);

        public const int XSTATE_ALIGN_BIT = 1;
        public const ulong XSTATE_ALIGN_MASK = 1UL << (XSTATE_ALIGN_BIT);

        public const ulong XSTATE_CONTROLFLAG_XSAVEOPT_MASK = 1;
        public const ulong XSTATE_CONTROLFLAG_XSAVEC_MASK = 2;
        public const ulong XSTATE_CONTROLFLAG_VALID_MASK =
            XSTATE_CONTROLFLAG_XSAVEOPT_MASK | XSTATE_CONTROLFLAG_XSAVEC_MASK;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12635
        //
        // Define flags for setting process CFG valid call target entries.
        //

        /// <summary>
        /// Call target should be made valid.  If not set, the call target is made
        /// invalid.  Input flag.
        /// </summary>
        public const int CFG_CALL_TARGET_VALID = 0x00000001;

        /// <summary>
        /// Call target has been successfully processed.  Used to report to the caller
        /// how much progress has been made.  Output flag.
        /// </summary>
        public const int CFG_CALL_TARGET_PROCESSED = 0x00000002;

        /// <summary>
        /// Call target should be made valid only if it is suppressed export.
        /// What this flag means is that it can *only* be used on a cell which is
        /// currently in the CFG export suppressed state (only considered for export
        /// suppressed processes and not legacy CFG processes!), and it is also
        /// allowed to be used even if the process is a restricted (i.e. no ACG) process.
        /// </summary>
        public const int CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID = 0x00000004;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12668
        public const int SECTION_QUERY = 0x0001;
        public const int SECTION_MAP_WRITE = 0x0002;
        public const int SECTION_MAP_READ = 0x0004;
        public const int SECTION_MAP_EXECUTE = 0x0008;
        public const int SECTION_EXTEND_SIZE = 0x0010;
        /// <summary>not included in <see cref="SECTION_ALL_ACCESS"/></summary>
        public const int SECTION_MAP_EXECUTE_EXPLICIT = 0x0020;

        public const int SECTION_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED
                                               | SECTION_QUERY
                                               | SECTION_MAP_WRITE
                                               | SECTION_MAP_READ
                                               | SECTION_MAP_EXECUTE
                                               | SECTION_EXTEND_SIZE;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12681
        //
        // Session Specific Access Rights.
        //

        public const int SESSION_QUERY_ACCESS = 0x0001;
        public const int SESSION_MODIFY_ACCESS = 0x0002;

        public const int SESSION_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED
                                               | SESSION_QUERY_ACCESS
                                               | SESSION_MODIFY_ACCESS;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12692
        public const int PAGE_NOACCESS = 0x01;
        public const int PAGE_READONLY = 0x02;
        public const int PAGE_READWRITE = 0x04;
        public const int PAGE_WRITECOPY = 0x08;
        public const int PAGE_EXECUTE = 0x10;
        public const int PAGE_EXECUTE_READ = 0x20;
        public const int PAGE_EXECUTE_READWRITE = 0x40;
        public const int PAGE_EXECUTE_WRITECOPY = 0x80;
        public const int PAGE_GUARD = 0x100;
        public const int PAGE_NOCACHE = 0x200;
        public const int PAGE_WRITECOMBINE = 0x400;
        public const int PAGE_ENCLAVE_THREAD_CONTROL = unchecked((int)0x80000000);
        public const int PAGE_REVERT_TO_FILE_MAP = unchecked((int)0x80000000);
        public const int PAGE_TARGETS_NO_UPDATE = 0x40000000;
        public const int PAGE_TARGETS_INVALID = 0x40000000;
        public const int PAGE_ENCLAVE_UNVALIDATED = 0x20000000;
        public const int PAGE_ENCLAVE_DECOMMIT = 0x10000000;
        public const int MEM_COMMIT = 0x00001000;
        public const int MEM_RESERVE = 0x00002000;
        public const int MEM_REPLACE_PLACEHOLDER = 0x00004000;
        public const int MEM_RESERVE_PLACEHOLDER = 0x00040000;
        public const int MEM_RESET = 0x00080000;
        public const int MEM_TOP_DOWN = 0x00100000;
        public const int MEM_WRITE_WATCH = 0x00200000;
        public const int MEM_PHYSICAL = 0x00400000;
        public const int MEM_ROTATE = 0x00800000;
        public const int MEM_DIFFERENT_IMAGE_BASE_OK = 0x00800000;
        public const int MEM_RESET_UNDO = 0x01000000;
        public const int MEM_LARGE_PAGES = 0x20000000;
        public const int MEM_4MB_PAGES = unchecked((int)0x80000000);
        public const int MEM_64K_PAGES = MEM_LARGE_PAGES | MEM_PHYSICAL;
        public const int MEM_UNMAP_WITH_TRANSIENT_BOOST = 0x00000001;
        public const int MEM_COALESCE_PLACEHOLDERS = 0x00000001;
        public const int MEM_PRESERVE_PLACEHOLDER = 0x00000002;
        public const int MEM_DECOMMIT = 0x00004000;
        public const int MEM_RELEASE = 0x00008000;
        public const int MEM_FREE = 0x00010000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12745
        public const int MEM_EXTENDED_PARAMETER_TYPE_BITS = 8;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12764
        public const int SEC_PARTITION_OWNER_HANDLE = 0x00040000;
        public const int SEC_64K_PAGES = 0x00080000;
        public const int SEC_FILE = 0x00800000;
        public const int SEC_IMAGE = 0x01000000;
        public const int SEC_PROTECTED_IMAGE = 0x02000000;
        public const int SEC_RESERVE = 0x04000000;
        public const int SEC_COMMIT = 0x08000000;
        public const int SEC_NOCACHE = 0x10000000;
        public const int SEC_WRITECOMBINE = 0x40000000;
        public const int SEC_LARGE_PAGES = unchecked((int)0x80000000);
        public const int SEC_IMAGE_NO_EXECUTE = SEC_IMAGE | SEC_NOCACHE;
        public const int MEM_PRIVATE = 0x00020000;
        public const int MEM_MAPPED = 0x00040000;
        public const int MEM_IMAGE = 0x01000000;
        public const int WRITE_WATCH_FLAG_RESET = 0x01;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12780
        public const int ENCLAVE_TYPE_SGX = 0x00000001;
        public const int ENCLAVE_TYPE_SGX2 = 0x00000002;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12794
        public const int ENCLAVE_TYPE_VBS = 0x00000010;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12801
        public const int ENCLAVE_VBS_FLAG_DEBUG = 0x00000001;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12819
        //
        // Define access rights to files and directories
        //

        //
        // The FILE_READ_DATA and FILE_WRITE_DATA constants are also defined in
        // devioctl.h as FILE_READ_ACCESS and FILE_WRITE_ACCESS. The values for these
        // constants *MUST* always be in sync.
        // The values are redefined in devioctl.h because they must be available to
        // both DOS and NT.
        //

        public const int FILE_READ_DATA = 0x0001;    // file & pipe
        public const int FILE_LIST_DIRECTORY = 0x0001;    // directory

        public const int FILE_WRITE_DATA = 0x0002;    // file & pipe
        public const int FILE_ADD_FILE = 0x0002;    // directory

        public const int FILE_APPEND_DATA = 0x0004;    // file
        public const int FILE_ADD_SUBDIRECTORY = 0x0004;    // directory
        public const int FILE_CREATE_PIPE_INSTANCE = 0x0004;    // named pipe


        public const int FILE_READ_EA = 0x0008;    // file & directory

        public const int FILE_WRITE_EA = 0x0010;    // file & directory

        public const int FILE_EXECUTE = 0x0020;    // file
        public const int FILE_TRAVERSE = 0x0020;    // directory

        public const int FILE_DELETE_CHILD = 0x0040;    // directory

        public const int FILE_READ_ATTRIBUTES = 0x0080;    // all

        public const int FILE_WRITE_ATTRIBUTES = 0x0100;    // all

        public const int FILE_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x1FF;

        public const int FILE_GENERIC_READ = STANDARD_RIGHTS_READ
                                             | FILE_READ_DATA
                                             | FILE_READ_ATTRIBUTES
                                             | FILE_READ_EA
                                             | SYNCHRONIZE;


        public const int FILE_GENERIC_WRITE = STANDARD_RIGHTS_WRITE
                                              | FILE_WRITE_DATA
                                              | FILE_WRITE_ATTRIBUTES
                                              | FILE_WRITE_EA
                                              | FILE_APPEND_DATA
                                              | SYNCHRONIZE;


        public const int FILE_GENERIC_EXECUTE = STANDARD_RIGHTS_EXECUTE | FILE_READ_ATTRIBUTES | FILE_EXECUTE | SYNCHRONIZE;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12878
        public const int FILE_SHARE_READ = 0x00000001;
        public const int FILE_SHARE_WRITE = 0x00000002;
        public const int FILE_SHARE_DELETE = 0x00000004;
        public const int FILE_ATTRIBUTE_READONLY = 0x00000001;
        public const int FILE_ATTRIBUTE_HIDDEN = 0x00000002;
        public const int FILE_ATTRIBUTE_SYSTEM = 0x00000004;
        public const int FILE_ATTRIBUTE_DIRECTORY = 0x00000010;
        public const int FILE_ATTRIBUTE_ARCHIVE = 0x00000020;
        public const int FILE_ATTRIBUTE_DEVICE = 0x00000040;
        public const int FILE_ATTRIBUTE_NORMAL = 0x00000080;
        public const int FILE_ATTRIBUTE_TEMPORARY = 0x00000100;
        public const int FILE_ATTRIBUTE_SPARSE_FILE = 0x00000200;
        public const int FILE_ATTRIBUTE_REPARSE_POINT = 0x00000400;
        public const int FILE_ATTRIBUTE_COMPRESSED = 0x00000800;
        public const int FILE_ATTRIBUTE_OFFLINE = 0x00001000;
        public const int FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 0x00002000;
        public const int FILE_ATTRIBUTE_ENCRYPTED = 0x00004000;
        public const int FILE_ATTRIBUTE_INTEGRITY_STREAM = 0x00008000;
        public const int FILE_ATTRIBUTE_VIRTUAL = 0x00010000;
        public const int FILE_ATTRIBUTE_NO_SCRUB_DATA = 0x00020000;
        public const int FILE_ATTRIBUTE_EA = 0x00040000;
        public const int FILE_ATTRIBUTE_PINNED = 0x00080000;
        public const int FILE_ATTRIBUTE_UNPINNED = 0x00100000;
        public const int FILE_ATTRIBUTE_RECALL_ON_OPEN = 0x00040000;
        public const int FILE_ATTRIBUTE_RECALL_ON_DATA_ACCESS = 0x00400000;
        public const int TREE_CONNECT_ATTRIBUTE_PRIVACY = 0x00004000;
        public const int TREE_CONNECT_ATTRIBUTE_INTEGRITY = 0x00008000;
        public const int TREE_CONNECT_ATTRIBUTE_GLOBAL = 0x00000004;
        public const int FILE_ATTRIBUTE_STRICTLY_SEQUENTIAL = 0x20000000;
        public const int FILE_NOTIFY_CHANGE_FILE_NAME = 0x00000001;
        public const int FILE_NOTIFY_CHANGE_DIR_NAME = 0x00000002;
        public const int FILE_NOTIFY_CHANGE_ATTRIBUTES = 0x00000004;
        public const int FILE_NOTIFY_CHANGE_SIZE = 0x00000008;
        public const int FILE_NOTIFY_CHANGE_LAST_WRITE = 0x00000010;
        public const int FILE_NOTIFY_CHANGE_LAST_ACCESS = 0x00000020;
        public const int FILE_NOTIFY_CHANGE_CREATION = 0x00000040;
        public const int FILE_NOTIFY_CHANGE_SECURITY = 0x00000100;
        public const int FILE_ACTION_ADDED = 0x00000001;
        public const int FILE_ACTION_REMOVED = 0x00000002;
        public const int FILE_ACTION_MODIFIED = 0x00000003;
        public const int FILE_ACTION_RENAMED_OLD_NAME = 0x00000004;
        public const int FILE_ACTION_RENAMED_NEW_NAME = 0x00000005;
        public const int MAILSLOT_NO_MESSAGE = -1;
        public const int MAILSLOT_WAIT_FOREVER = -1;
        public const int FILE_CASE_SENSITIVE_SEARCH = 0x00000001;
        public const int FILE_CASE_PRESERVED_NAMES = 0x00000002;
        public const int FILE_UNICODE_ON_DISK = 0x00000004;
        public const int FILE_PERSISTENT_ACLS = 0x00000008;
        public const int FILE_FILE_COMPRESSION = 0x00000010;
        public const int FILE_VOLUME_QUOTAS = 0x00000020;
        public const int FILE_SUPPORTS_SPARSE_FILES = 0x00000040;
        public const int FILE_SUPPORTS_REPARSE_POINTS = 0x00000080;
        public const int FILE_SUPPORTS_REMOTE_STORAGE = 0x00000100;
        public const int FILE_RETURNS_CLEANUP_RESULT_INFO = 0x00000200;
        public const int FILE_SUPPORTS_POSIX_UNLINK_RENAME = 0x00000400;

        public const int FILE_VOLUME_IS_COMPRESSED = 0x00008000;
        public const int FILE_SUPPORTS_OBJECT_IDS = 0x00010000;
        public const int FILE_SUPPORTS_ENCRYPTION = 0x00020000;
        public const int FILE_NAMED_STREAMS = 0x00040000;
        public const int FILE_READ_ONLY_VOLUME = 0x00080000;
        public const int FILE_SEQUENTIAL_WRITE_ONCE = 0x00100000;
        public const int FILE_SUPPORTS_TRANSACTIONS = 0x00200000;
        public const int FILE_SUPPORTS_HARD_LINKS = 0x00400000;
        public const int FILE_SUPPORTS_EXTENDED_ATTRIBUTES = 0x00800000;
        public const int FILE_SUPPORTS_OPEN_BY_FILE_ID = 0x01000000;
        public const int FILE_SUPPORTS_USN_JOURNAL = 0x02000000;
        public const int FILE_SUPPORTS_INTEGRITY_STREAMS = 0x04000000;
        public const int FILE_SUPPORTS_BLOCK_REFCOUNTING = 0x08000000;
        public const int FILE_SUPPORTS_SPARSE_VDL = 0x10000000;
        public const int FILE_DAX_VOLUME = 0x20000000;
        public const int FILE_SUPPORTS_GHOSTING = 0x40000000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12954
        public const long FILE_INVALID_FILE_ID = -1L;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13001
        //
        //  Flag defintions for NtFlushBuffersFileEx
        //
        //  If none of the below flags are specified the following will occur for a
        //  given file handle:
        //      - Write any modified data for the given file from the Windows in-memory
        //        cache.
        //      - Commit all pending metadata changes for the given file from the
        //        Windows in-memory cache.
        //      - Send a SYNC command to the underlying storage device to commit all
        //        written data in the devices cache to persistent storage.
        //
        //  If a volume handle is specified:
        //      - Write all modified data for all files on the volume from the Windows
        //        in-memory cache.
        //      - Commit all pending metadata changes for all files on the volume from
        //        the Windows in-memory cache.
        //      - Send a SYNC command to the underlying storage device to commit all
        //        written data in the devices cache to persistent storage.
        //
        //  This is equivalent to how NtFlushBuffersFile has always worked.
        //

        /// <summary>
        /// If set, this operation will write the data for the given file from the
        /// Windows in-memory cache.  This will NOT commit any associated metadata
        /// changes.  This will NOT send a SYNC to the storage device to flush its
        /// cache.  Not supported on volume handles.  Only supported by the NTFS
        /// filesystem.
        /// </summary>
        public const int FLUSH_FLAGS_FILE_DATA_ONLY = 0x00000001;

        /// <summary>
        /// If set, this operation will commit both the data and metadata changes for
        /// the given file from the Windows in-memory cache.  This will NOT send a SYNC
        /// to the storage device to flush its cache.  Not supported on volume handles.
        /// Only supported by the NTFS filesystem.
        /// </summary>
        public const int FLUSH_FLAGS_NO_SYNC = 0x00000002;

        /// <summary>
        /// If set, this operation will write the data for the given file from the
        /// Windows in-memory cache.  It will also try to skip updating the timestamp
        /// as much as possible.  This will send a SYNC to the storage device to flush its
        /// cache.  Not supported on volume or directory handles.  Only supported by the NTFS
        /// filesystem.
        /// </summary>
        public const int FLUSH_FLAGS_FILE_DATA_SYNC_ONLY = 0x00000004;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13080
        /// <summary>
        /// Maximum allowed size of the reparse data.
        /// </summary>
        public const int MAXIMUM_REPARSE_DATA_BUFFER_SIZE = 16 * 1024;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13086
        //
        // Predefined reparse tags.
        // These tags need to avoid conflicting with IO_REMOUNT defined in ntos\inc\io.h
        //

        public const int IO_REPARSE_TAG_RESERVED_ZERO = 0;
        public const int IO_REPARSE_TAG_RESERVED_ONE = 1;
        public const int IO_REPARSE_TAG_RESERVED_TWO = 2;

        //
        // The value of the following constant needs to satisfy the following conditions:
        //  (1) Be at least as large as the largest of the reserved tags.
        //  (2) Be strictly smaller than all the tags in use.
        //

        public const int IO_REPARSE_TAG_RESERVED_RANGE = IO_REPARSE_TAG_RESERVED_TWO;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13156
        public const int IO_REPARSE_TAG_MOUNT_POINT = unchecked((int)0xA0000003L);
        public const int IO_REPARSE_TAG_HSM = unchecked((int)0xC0000004L);
        public const int IO_REPARSE_TAG_HSM2 = unchecked((int)0x80000006L);
        public const int IO_REPARSE_TAG_SIS = unchecked((int)0x80000007L);
        public const int IO_REPARSE_TAG_WIM = unchecked((int)0x80000008L);
        public const int IO_REPARSE_TAG_CSV = unchecked((int)0x80000009L);
        public const int IO_REPARSE_TAG_DFS = unchecked((int)0x8000000AL);
        public const int IO_REPARSE_TAG_SYMLINK = unchecked((int)0xA000000CL);
        public const int IO_REPARSE_TAG_DFSR = unchecked((int)0x80000012L);
        public const int IO_REPARSE_TAG_DEDUP = unchecked((int)0x80000013L);
        public const int IO_REPARSE_TAG_NFS = unchecked((int)0x80000014L);
        public const int IO_REPARSE_TAG_FILE_PLACEHOLDER = unchecked((int)0x80000015L);
        public const int IO_REPARSE_TAG_WOF = unchecked((int)0x80000017L);
        public const int IO_REPARSE_TAG_WCI = unchecked((int)0x80000018L);
        public const int IO_REPARSE_TAG_WCI_1 = unchecked((int)0x90001018L);
        public const int IO_REPARSE_TAG_GLOBAL_REPARSE = unchecked((int)0xA0000019L);
        public const int IO_REPARSE_TAG_CLOUD = unchecked((int)0x9000001AL);
        public const int IO_REPARSE_TAG_CLOUD_1 = unchecked((int)0x9000101AL);
        public const int IO_REPARSE_TAG_CLOUD_2 = unchecked((int)0x9000201AL);
        public const int IO_REPARSE_TAG_CLOUD_3 = unchecked((int)0x9000301AL);
        public const int IO_REPARSE_TAG_CLOUD_4 = unchecked((int)0x9000401AL);
        public const int IO_REPARSE_TAG_CLOUD_5 = unchecked((int)0x9000501AL);
        public const int IO_REPARSE_TAG_CLOUD_6 = unchecked((int)0x9000601AL);
        public const int IO_REPARSE_TAG_CLOUD_7 = unchecked((int)0x9000701AL);
        public const int IO_REPARSE_TAG_CLOUD_8 = unchecked((int)0x9000801AL);
        public const int IO_REPARSE_TAG_CLOUD_9 = unchecked((int)0x9000901AL);
        public const int IO_REPARSE_TAG_CLOUD_A = unchecked((int)0x9000A01AL);
        public const int IO_REPARSE_TAG_CLOUD_B = unchecked((int)0x9000B01AL);
        public const int IO_REPARSE_TAG_CLOUD_C = unchecked((int)0x9000C01AL);
        public const int IO_REPARSE_TAG_CLOUD_D = unchecked((int)0x9000D01AL);
        public const int IO_REPARSE_TAG_CLOUD_E = unchecked((int)0x9000E01AL);
        public const int IO_REPARSE_TAG_CLOUD_F = unchecked((int)0x9000F01AL);
        public const int IO_REPARSE_TAG_CLOUD_MASK = 0x0000F000;
        public const int IO_REPARSE_TAG_APPEXECLINK = unchecked((int)0x8000001BL);
        public const int IO_REPARSE_TAG_PROJFS = unchecked((int)0x9000001CL);
        public const int IO_REPARSE_TAG_STORAGE_SYNC = unchecked((int)0x8000001EL);
        public const int IO_REPARSE_TAG_WCI_TOMBSTONE = unchecked((int)0xA000001FL);
        public const int IO_REPARSE_TAG_UNHANDLED = unchecked((int)0x80000020L);
        public const int IO_REPARSE_TAG_ONEDRIVE = unchecked((int)0x80000021L);
        public const int IO_REPARSE_TAG_PROJFS_TOMBSTONE = unchecked((int)0xA0000022L);
        public const int IO_REPARSE_TAG_AF_UNIX = unchecked((int)0x80000023L);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13200
        //======================= FSCTL_SCRUB_DATA =============================

        public const int SCRUB_DATA_INPUT_FLAG_RESUME = 0x00000001;
        public const int SCRUB_DATA_INPUT_FLAG_SKIP_IN_SYNC = 0x00000002;
        public const int SCRUB_DATA_INPUT_FLAG_SKIP_NON_INTEGRITY_DATA = 0x00000004;
        public const int SCRUB_DATA_INPUT_FLAG_IGNORE_REDUNDANCY = 0x00000008;
        public const int SCRUB_DATA_INPUT_FLAG_SKIP_DATA = 0x00000010;
        public const int SCRUB_DATA_INPUT_FLAG_SCRUB_BY_OBJECT_ID = 0x00000020;

        public const int SCRUB_DATA_OUTPUT_FLAG_INCOMPLETE = 0x00000001;

        public const int SCRUB_DATA_OUTPUT_FLAG_NON_USER_DATA_RANGE = 0x00010000;
        public const int SCRUB_DATA_OUTPUT_FLAG_PARITY_EXTENT_DATA_RETURNED = 0x00020000;
        public const int SCRUB_DATA_OUTPUT_FLAG_RESUME_CONTEXT_LENGTH_SPECIFIED = 0x00040000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13573
        //
        // =========================================
        // Define GUIDs which represent well-known power schemes
        // =========================================
        //

        /// <summary>
        /// Maximum Power Savings - indicates that very aggressive power savings measures will be used to help
        ///                         stretch battery life.
        /// </summary>
        public const string GUID_MAX_POWER_SAVINGS = @"{A1841308-3541-4FAB-BC81-F71556F20B4A}";

        /// <summary>
        /// No Power Savings - indicates that almost no power savings measures will be used.
        /// </summary>
        public const string GUID_MIN_POWER_SAVINGS = @"{8C5E7FDA-E8BF-4A96-9A85-A6E23A8C635C}";

        /// <summary>
        /// Typical Power Savings - indicates that fairly aggressive power savings measures will be used.
        /// </summary>
        public const string GUID_TYPICAL_POWER_SAVINGS = @"{381B4222-F694-41F0-9685-FF5BB260DF2E}";

        /// <summary>
        /// This is a special GUID that represents "no subgroup" of settings.  That is, it indicates
        /// that settings that are in the root of the power policy hierarchy as opposed to settings
        /// that are buried under a subgroup of settings.  This should be used when querying for
        /// power settings that may not fall into a subgroup.
        /// </summary>
        public const string NO_SUBGROUP_GUID = @"{FEA3413E-7E05-4911-9A71-700331F1C294}";

        /// <summary>
        /// This is a special GUID that represents "every power scheme".  That is, it indicates
        /// that any write to this power scheme should be reflected to every scheme present.
        /// This allows users to write a single setting once and have it apply to all schemes.  They
        /// can then apply custom settings to specific power schemes that they care about.
        /// </summary>
        public const string ALL_POWERSCHEMES_GUID = @"{68A1E95E-13EA-41E1-8011-0C496CA490B0}";

        /// <summary>
        /// This is a special GUID that represents a 'personality' that each power scheme will have.
        /// In other words, each power scheme will have this key indicating "I'm most like *this* base
        /// power scheme."
        /// </summary>
        /// <value>
        /// This individual setting will have one of three settings:
        /// <list type="bullet">
        /// <item><see cref="GUID_MAX_POWER_SAVINGS"/></item>
        /// <item><see cref="GUID_MIN_POWER_SAVINGS"/></item>
        /// <item><see cref="GUID_TYPICAL_POWER_SAVINGS"/></item>
        /// </list>
        /// </value>
        /// <remarks>
        /// This allows several features:
        /// <list type="number">
        /// <item>
        ///    Drivers and applications can register for notification of this GUID.  So when this power
        ///    scheme is activiated, this GUID's setting will be sent across the system and drivers/applications
        ///    can see "GUID_MAX_POWER_SAVINGS" which will tell them in a generic fashion "get real aggressive
        ///    about conserving power".
        /// </item>
        /// <item>
        ///    UserB may install a driver or application which creates power settings, and UserB may modify
        ///    those power settings.  Now UserA logs in.  How does he see those settings?  They simply don't
        ///    exist in his private power key.  Well they do exist over in the system power key.  When we
        ///    enumerate all the power settings in this system power key and don't find a corresponding entry
        ///    in the user's private power key, then we can go look at this "personality" key in the users
        ///    power scheme.  We can then go get a default value for the power setting, depending on which
        ///    "personality" power scheme is being operated on.  Here's an example:
        ///    <list type="number">
        ///    <item>
        ///       UserB installs an application that creates a power setting Seetting1
        ///    </item>
        ///    <item>
        ///       UserB changes Setting1 to have a value of 50 because that's one of the possible settings
        ///       available for setting1.
        ///    </item>
        ///    <item>
        ///       UserB logs out
        ///    </item>
        ///    <item>
        ///       UserA logs in and his active power scheme is some custom scheme that was derived from
        ///       the <see cref="GUID_TYPICAL_POWER_SAVINGS"/>.  But remember that UserA has no setting1 in his
        ///       private power key.
        ///    </item>
        ///    <item>
        ///       When activating UserA's selected power scheme, all power settings in the system power key will
        ///       be enumerated (including Setting1).
        ///    </item>
        ///    <item>
        ///       The power manager will see that UserA has no Setting1 power setting in his private power scheme.
        ///    </item>
        ///    <item>
        ///       The power manager will query UserA's power scheme for its personality and retrieve
        ///       <see cref="GUID_TYPICAL_POWER_SAVINGS"/>.
        ///    </item>
        ///    <item>
        ///       The power manager then looks in Setting1 in the system power key and looks in its set of default
        ///       values for the corresponding value for <see cref="GUID_TYPICAL_POWER_SAVINGS"/> power schemes.
        ///    </item>
        ///    <item>
        ///       This derived power setting is applied.
        ///    </item>
        ///    </list>
        /// </item>
        /// </list>
        /// </remarks>
        public const string GUID_POWERSCHEME_PERSONALITY = @"{245D8541-3943-4422-B025-13A784F679B7}";

        /// <summary>
        /// Define a special GUID which will be used to define the active power scheme.
        /// User will register for this power setting GUID, and when the active power
        /// scheme changes, they'll get a callback where the payload is the GUID
        /// representing the active powerscheme.
        /// </summary>
        public const string GUID_ACTIVE_POWERSCHEME = @"{31F9F286-5084-42FE-B720-2B0264993763}";

        //
        // =========================================
        // Define GUIDs which represent well-known power settings
        // =========================================
        //

        // Idle resiliency settings
        // -------------------------

        /// <summary>
        /// Specifies the subgroup which will contain all of the idle resiliency
        /// settings for a single policy.
        /// </summary>
        public const string GUID_IDLE_RESILIENCY_SUBGROUP = @"{2e601130-5351-4d9d-8e04-252966bad054}";

        /// <summary>
        /// Specifies the maximum clock interrupt period (in ms)
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public const string GUID_IDLE_RESILIENCY_PERIOD = @"{c42b79aa-aa3a-484b-a98f-2cf32aa90a28}";

        /// <summary>
        /// Specifies the deep sleep policy setting.
        /// This is intended to override the <see cref="GUID_IDLE_RESILIENCY_PERIOD"/>
        /// </summary>
        public const string GUID_DEEP_SLEEP_ENABLED = @"{d502f7ee-1dc7-4efd-a55d-f04b6f5c0545}";

        /// <summary>
        /// Specifies the platform idle state index associated with idle resiliency
        /// period.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public const string GUID_DEEP_SLEEP_PLATFORM_STATE = @"{d23f2fb8-9536-4038-9c94-1ce02e5c2152}";

        /// <summary>
        /// Specifies (in milliseconds) how long we wait after the last disk access
        /// before we power off the disk in case when IO coalescing is active.
        /// </summary>
        public const string GUID_DISK_COALESCING_POWERDOWN_TIMEOUT = @"{c36f0eb4-2988-4a70-8eee-0884fc2c2433}";

        /// <summary>
        /// Specifies (in seconds) how long we wait after the CS Enter before
        /// we deactivate execution required request.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0</term><description>implies execution power requests are disabled and have no effect</description></item>
        /// <item><term>-1</term><description>implies execution power requests are never deactivated</description></item>
        /// </list>
        /// </para>
        /// <note>
        /// Execution required power requests are mapped into system required
        /// power requests on non-AoAc machines and this value has no effect.
        /// </note>
        /// </remarks>
        public const string GUID_EXECUTION_REQUIRED_REQUEST_TIMEOUT = @"{3166bc41-7e98-4e03-b34e-ec0f5f2b218e}";


        // Video settings
        // --------------

        /// <summary>
        /// Specifies the subgroup which will contain all of the video
        /// settings for a single policy.
        /// </summary>
        public const string GUID_VIDEO_SUBGROUP = @"{7516B95F-F776-4464-8C53-06167F40CC99}";

        /// <summary>
        /// Specifies (in seconds) how long we wait after the last user input has been
        /// received before we power off the video.
        /// </summary>
        public const string GUID_VIDEO_POWERDOWN_TIMEOUT = @"{3C0BC021-C8A8-4E07-A973-6B14CBCB2B7E}";

        /// <summary>
        /// Specifies whether adaptive display dimming is turned on or off.
        /// </summary>
        [Obsolete("This setting is DEPRECATED in Windows 8.1")]
        public const string GUID_VIDEO_ANNOYANCE_TIMEOUT = @"{82DBCF2D-CD67-40C5-BFDC-9F1A5CCD4663}";

        /// <summary>
        /// Specifies how much adaptive dim time out will be increased by.
        /// </summary>
        [Obsolete("This setting is DEPRECATED in Windows 8.1")]
        public const string GUID_VIDEO_ADAPTIVE_PERCENT_INCREASE = @"{EED904DF-B142-4183-B10B-5A1197A37864}";

        /// <summary>
        /// Specifies (in seconds) how long we wait after the last user input has been
        /// received before we dim the video.
        /// </summary>
        public const string GUID_VIDEO_DIM_TIMEOUT = @"{17aaa29b-8b43-4b94-aafe-35f64daaf1ee}";

        /// <summary>
        /// Specifies if the operating system should use adaptive timers (based on
        /// previous behavior) to power down the video.
        /// </summary>
        public const string GUID_VIDEO_ADAPTIVE_POWERDOWN = @"{90959D22-D6A1-49B9-AF93-BCE885AD335B}";

        /// <summary>
        /// Specifies if the monitor is currently being powered or not.
        /// </summary>
        public const string GUID_MONITOR_POWER_ON = @"{02731015-4510-4526-99E6-E5A17EBD1AEA}";

        /// <summary>
        /// Monitor brightness policy when in normal state.
        /// </summary>
        public const string GUID_DEVICE_POWER_POLICY_VIDEO_BRIGHTNESS = @"{aded5e82-b909-4619-9949-f5d71dac0bcb}";

        /// <summary>
        /// Monitor brightness policy when in dim state.
        /// </summary>
        public const string GUID_DEVICE_POWER_POLICY_VIDEO_DIM_BRIGHTNESS = @"{f1fbfde2-a960-4165-9f88-50667911ce96}";

        /// <summary>
        /// Current monitor brightness.
        /// </summary>
        public const string GUID_VIDEO_CURRENT_MONITOR_BRIGHTNESS = @"{8ffee2c6-2d01-46be-adb9-398addc5b4ff}";

        /// <summary>
        /// Specifies if the operating system should use ambient light sensor to change
        /// adaptively the display's brightness.
        /// </summary>
        public const string GUID_VIDEO_ADAPTIVE_DISPLAY_BRIGHTNESS = @"{FBD9AA66-9553-4097-BA44-ED6E9D65EAB8}";

        /// <summary>
        /// Specifies a change in the current monitor's display state.
        /// </summary>
        public const string GUID_CONSOLE_DISPLAY_STATE = @"{6fe69556-704a-47a0-8f24-c28d936fda47}";

        /// <summary>
        /// Defines a guid for enabling/disabling the ability to create display required
        /// power requests.
        /// </summary>
        public const string GUID_ALLOW_DISPLAY_REQUIRED = @"{A9CEB8DA-CD46-44FB-A98B-02AF69DE4623}";

        /// <summary>
        /// Specifies the video power down timeout (in seconds) after the interactive
        /// console is locked (and sensors indicate UserNotPresent). Value 0
        /// effectively disables this feature.
        /// </summary>
        public const string GUID_VIDEO_CONSOLE_LOCK_TIMEOUT = @"{8ec4b3a5-6868-48c2-be75-4f3044be88a7}";


        // Adaptive power behavior settings
        // --------------------------------

        public const string GUID_ADAPTIVE_POWER_BEHAVIOR_SUBGROUP = @"{8619b916-e004-4dd8-9b66-dae86f806698}";

        /// <summary>
        /// Specifies the input timeout (in seconds) to be used to indicate UserUnkown.
        /// Value 0 effectively disables this feature.
        /// </summary>
        public const string GUID_NON_ADAPTIVE_INPUT_TIMEOUT = @"{5adbbfbc-074e-4da1-ba38-db8b36b2c8f3}";

        /// <summary>
        /// Specifies a change in the input controller(s) global system's state:
        /// e.g. enabled, suppressed, filtered.
        /// </summary>
        public const string GUID_ADAPTIVE_INPUT_CONTROLLER_STATE = @"{0e98fae9-f45a-4de1-a757-6031f197f6ea}";

        // Harddisk settings
        // -----------------

        /// <summary>
        /// Specifies the subgroup which will contain all of the harddisk
        /// settings for a single policy.
        /// </summary>
        public const string GUID_DISK_SUBGROUP = @"{0012EE47-9041-4B5D-9B77-535FBA8B1442}";

        /// <summary>
        /// Specifies a maximum power consumption level.
        /// </summary>
        public const string GUID_DISK_MAX_POWER = @"{51dea550-bb38-4bc4-991b-eacf37be5ec8}";

        /// <summary>
        /// Specifies (in seconds) how long we wait after the last disk access
        /// before we power off the disk.
        /// </summary>
        public const string GUID_DISK_POWERDOWN_TIMEOUT = @"{6738E2C4-E8A5-4A42-B16A-E040E769756E}";

        /// <summary>
        /// Specifies (in milliseconds) how long we wait after the last disk access
        /// before we power off the disk taking into account if IO coalescing is active.
        /// </summary>
        public const string GUID_DISK_IDLE_TIMEOUT = @"{58E39BA8-B8E6-4EF6-90D0-89AE32B258D6}";

        /// <summary>
        /// Specifies the amount of contiguous disk activity time to ignore when
        /// calculating disk idleness.
        /// </summary>
        public const string GUID_DISK_BURST_IGNORE_THRESHOLD = @"{80e3c60e-bb94-4ad8-bbe0-0d3195efc663}";

        /// <summary>
        /// Specifies if the operating system should use adaptive timers (based on
        /// previous behavior) to power down the disk,
        /// </summary>
        public const string GUID_DISK_ADAPTIVE_POWERDOWN = @"{396A32E1-499A-40B2-9124-A96AFE707667}";

        // System sleep settings
        // ---------------------

        /// <summary>
        /// Specifies the subgroup which will contain all of the sleep
        /// settings for a single policy.
        /// </summary>
        public const string GUID_SLEEP_SUBGROUP = @"{238C9FA8-0AAD-41ED-83F4-97BE242C8F20}";

        /// <summary>
        /// Specifies an idle treshold percentage (0-100). The system must be this idle
        /// over a period of time in order to idle to sleep.
        /// </summary>
        [Obsolete("DEPRECATED IN WINDOWS 6.1")]
        public const string GUID_SLEEP_IDLE_THRESHOLD = @"{81cd32e0-7833-44f3-8737-7081f38d1f70}";

        /// <summary>
        /// Specifies (in seconds) how long we wait after the system is deemed
        /// "idle" before moving to standby (S1, S2 or S3).
        /// </summary>
        public const string GUID_STANDBY_TIMEOUT = @"{29F6C1DB-86DA-48C5-9FDB-F2B67B1F44DA}";

        /// <summary>
        /// Specifies (in seconds) how long the system should go back to sleep after
        /// waking unattended. 0 indicates that the standard standby/hibernate idle
        /// policy should be used instead.
        /// </summary>
        public const string GUID_UNATTEND_SLEEP_TIMEOUT = @"{7bc4a2f9-d8fc-4469-b07b-33eb785aaca0}";

        /// <summary>
        /// Specifies (in seconds) how long we wait after the system is deemed
        /// "idle" before moving to hibernate (S4).
        /// </summary>
        public const string GUID_HIBERNATE_TIMEOUT = @"{9D7815A6-7EE4-497E-8888-515A05F02364}";

        /// <summary>
        /// Specifies whether or not Fast S4 should be enabled if the system supports it
        /// </summary>
        public const string GUID_HIBERNATE_FASTS4_POLICY = @"{94AC6D29-73CE-41A6-809F-6363BA21B47E}";

        /// <summary>
        /// Define a GUID for controlling the criticality of sleep state transitions.
        /// Critical sleep transitions do not query applications, services or drivers
        /// before transitioning the platform to a sleep state.
        /// </summary>
        public const string GUID_CRITICAL_POWER_TRANSITION = @"{B7A27025-E569-46c2-A504-2B96CAD225A1}";

        /// <summary>
        /// Specifies if the system is entering or exiting 'away mode'.
        /// </summary>
        public const string GUID_SYSTEM_AWAYMODE = @"{98A7F580-01F7-48AA-9C0F-44352C29E5C0}";

        /// <summary>
        /// Specify whether away mode is allowed
        /// </summary>
        public const string GUID_ALLOW_AWAYMODE = @"{25dfa149-5dd1-4736-b5ab-e8a37b5b8187}";

        /// <summary>
        /// Defines a guid to control User Presence Prediction mode.
        /// </summary>
        public const string GUID_USER_PRESENCE_PREDICTION = @"{82011705-fb95-4d46-8d35-4042b1d20def}";

        /// <summary>
        /// Defines a guid to control Standby Budget Grace Period.
        /// </summary>
        public const string GUID_STANDBY_BUDGET_GRACE_PERIOD = @"{60c07fe1-0556-45cf-9903-d56e32210242}";

        /// <summary>
        /// Defines a guid to control Standby Budget Percent.
        /// </summary>
        public const string GUID_STANDBY_BUDGET_PERCENT = @"{9fe527be-1b70-48da-930d-7bcf17b44990}";

        /// <summary>
        /// Defines a guid to control Standby Reserve Grace Period.
        /// </summary>
        public const string GUID_STANDBY_RESERVE_GRACE_PERIOD = @"{c763ee92-71e8-4127-84eb-f6ed043a3e3d}";

        /// <summary>
        /// Defines a guid to control Standby Reserve Time.
        /// </summary>
        public const string GUID_STANDBY_RESERVE_TIME = @"{468FE7E5-1158-46EC-88bc-5b96c9e44fd0}";

        /// <summary>
        /// Defines a guid to control Standby Reset Percentage.
        /// </summary>
        public const string GUID_STANDBY_RESET_PERCENT = @"{49cb11a5-56e2-4afb-9d38-3df47872e21b}";

        /// <summary>
        /// Defines a guid for enabling/disabling standby (S1-S3) states. This does not
        /// affect hibernation (S4).
        /// </summary>
        public const string GUID_ALLOW_STANDBY_STATES = @"{abfc2519-3608-4c2a-94ea-171b0ed546ab}";

        /// <summary>
        /// Defines a guid for enabling/disabling the ability to wake via RTC.
        /// </summary>
        public const string GUID_ALLOW_RTC_WAKE = @"{BD3B718A-0680-4D9D-8AB2-E1D2B4AC806D}";

        /// <summary>
        /// Defines a guid for enabling/disabling legacy RTC mitigations.
        /// </summary>
        public const string GUID_LEGACY_RTC_MITIGATION = @"{1A34BDC3-7E6B-442E-A9D0-64B6EF378E84}";

        /// <summary>
        /// Defines a guid for enabling/disabling the ability to create system required
        /// power requests.
        /// </summary>
        public const string GUID_ALLOW_SYSTEM_REQUIRED = @"{A4B195F5-8225-47D8-8012-9D41369786E2}";

        // Energy Saver settings
        // ---------------------

        /// <summary>
        /// Indicates if Enegry Saver is ON or OFF.
        /// </summary>
        public const string GUID_POWER_SAVING_STATUS = @"{e00958c0-c213-4ace-ac77-fecced2eeea5}";

        /// <summary>
        /// Specifies the subgroup which will contain all of the Energy Saver settings
        /// for a single policy.
        /// </summary>
        public const string GUID_ENERGY_SAVER_SUBGROUP = @"{DE830923-A562-41AF-A086-E3A2C6BAD2DA}";

        /// <summary>
        /// Defines a guid to engage Energy Saver at specific battery charge level
        /// </summary>
        public const string GUID_ENERGY_SAVER_BATTERY_THRESHOLD = @"{E69653CA-CF7F-4F05-AA73-CB833FA90AD4}";

        /// <summary>
        /// Defines a guid to specify display brightness weight when Energy Saver is engaged
        /// </summary>
        public const string GUID_ENERGY_SAVER_BRIGHTNESS = @"{13D09884-F74E-474A-A852-B6BDE8AD03A8}";

        /// <summary>
        /// Defines a guid to specify the Energy Saver policy
        /// </summary>
        public const string GUID_ENERGY_SAVER_POLICY = @"{5c5bb349-ad29-4ee2-9d0b-2b25270f7a81}";

        // System button actions
        // ---------------------

        /// <summary>
        /// Specifies the subgroup which will contain all of the system button
        /// settings for a single policy.
        /// </summary>
        public const string GUID_SYSTEM_BUTTON_SUBGROUP = @"{4F971E89-EEBD-4455-A8DE-9E59040E7347}";

        public const int POWERBUTTON_ACTION_INDEX_NOTHING = 0;
        public const int POWERBUTTON_ACTION_INDEX_SLEEP = 1;
        public const int POWERBUTTON_ACTION_INDEX_HIBERNATE = 2;
        public const int POWERBUTTON_ACTION_INDEX_SHUTDOWN = 3;
        public const int POWERBUTTON_ACTION_INDEX_TURN_OFF_THE_DISPLAY = 4;

        //
        // System button values which contain the PowerAction* value for each action.
        //

        public const int POWERBUTTON_ACTION_VALUE_NOTHING = 0;
        public const int POWERBUTTON_ACTION_VALUE_SLEEP = 2;
        public const int POWERBUTTON_ACTION_VALUE_HIBERNATE = 3;
        public const int POWERBUTTON_ACTION_VALUE_SHUTDOWN = 6;
        public const int POWERBUTTON_ACTION_VALUE_TURN_OFF_THE_DISPLAY = 8;

        public const string GUID_POWERBUTTON_ACTION = @"{7648EFA3-DD9C-4E3E-B566-50F929386280}";
        public const string GUID_SLEEPBUTTON_ACTION = @"{96996BC0-AD50-47EC-923B-6F41874DD9EB}";
        public const string GUID_USERINTERFACEBUTTON_ACTION = @"{A7066653-8D6C-40A8-910E-A1F54B84C7E5}";
        public const string GUID_LIDCLOSE_ACTION = @"{5CA83367-6E45-459F-A27B-476B1D01C936}";
        public const string GUID_LIDOPEN_POWERSTATE = @"{99FF10E7-23B1-4C07-A9D1-5C3206D741B4}";


        // Battery Discharge Settings
        // --------------------------

        /// <summary>
        /// Specifies the subgroup which will contain all of the battery discharge
        /// settings for a single policy.
        /// </summary>
        public const string GUID_BATTERY_SUBGROUP = @"{E73A048D-BF27-4F12-9731-8B2076E8891F}";

        //
        // 4 battery discharge alarm settings.
        //
        // GUID_BATTERY_DISCHARGE_ACTION_x - This is the action to take.  It is a value
        //                                   of type POWER_ACTION
        // GUID_BATTERY_DISCHARGE_LEVEL_x  - This is the battery level (%)
        // GUID_BATTERY_DISCHARGE_FLAGS_x  - Flags defined below:
        //                                   POWER_ACTION_POLICY->EventCode flags
        //                                   BATTERY_DISCHARGE_FLAGS_EVENTCODE_MASK
        //                                   BATTERY_DISCHARGE_FLAGS_ENABLE

        public const string GUID_BATTERY_DISCHARGE_ACTION_0 = @"{637EA02F-BBCB-4015-8E2C-A1C7B9C0B546}";
        public const string GUID_BATTERY_DISCHARGE_LEVEL_0 = @"{9A66D8D7-4FF7-4EF9-B5A2-5A326CA2A469}";
        public const string GUID_BATTERY_DISCHARGE_FLAGS_0 = @"{5dbb7c9f-38e9-40d2-9749-4f8a0e9f640f}";

        public const string GUID_BATTERY_DISCHARGE_ACTION_1 = @"{D8742DCB-3E6A-4B3C-B3FE-374623CDCF06}";
        public const string GUID_BATTERY_DISCHARGE_LEVEL_1 = @"{8183BA9A-E910-48DA-8769-14AE6DC1170A}";
        public const string GUID_BATTERY_DISCHARGE_FLAGS_1 = @"{bcded951-187b-4d05-bccc-f7e51960c258}";

        public const string GUID_BATTERY_DISCHARGE_ACTION_2 = @"{421CBA38-1A8E-4881-AC89-E33A8B04ECE4}";
        public const string GUID_BATTERY_DISCHARGE_LEVEL_2 = @"{07A07CA2-ADAF-40D7-B077-533AADED1BFA}";
        public const string GUID_BATTERY_DISCHARGE_FLAGS_2 = @"{7fd2f0c4-feb7-4da3-8117-e3fbedc46582}";

        public const string GUID_BATTERY_DISCHARGE_ACTION_3 = @"{80472613-9780-455E-B308-72D3003CF2F8}";
        public const string GUID_BATTERY_DISCHARGE_LEVEL_3 = @"{58AFD5A6-C2DD-47D2-9FBF-EF70CC5C5965}";
        public const string GUID_BATTERY_DISCHARGE_FLAGS_3 = @"{73613ccf-dbfa-4279-8356-4935f6bf62f3}";

        // Processor power settings
        // ------------------------
        //

        /// <summary>
        /// Specifies the subgroup which will contain all of the processor
        /// settings for a single policy.
        /// </summary>
        public const string GUID_PROCESSOR_SETTINGS_SUBGROUP = @"{54533251-82BE-4824-96C1-47B60B740D00}";

        /// <summary>
        /// Specifies various attributes that control processor performance/throttle
        /// states.
        /// </summary>
        public const string GUID_PROCESSOR_THROTTLE_POLICY = @"{57027304-4AF6-4104-9260-E3D95248FC36}";

        public const int PERFSTATE_POLICY_CHANGE_IDEAL = 0;
        public const int PERFSTATE_POLICY_CHANGE_SINGLE = 1;
        public const int PERFSTATE_POLICY_CHANGE_ROCKET = 2;
        public const int PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE = 3;

        public const int PERFSTATE_POLICY_CHANGE_DECREASE_MAX = PERFSTATE_POLICY_CHANGE_ROCKET;
        public const int PERFSTATE_POLICY_CHANGE_INCREASE_MAX = PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE;

        /// <summary>
        /// Specifies a percentage (between 0 and 100) that the processor frequency
        /// should never go above.  For example, if this value is set to 80, then
        /// the processor frequency will never be throttled above 80 percent of its
        /// maximum frequency by the system.
        /// </summary>
        public const string GUID_PROCESSOR_THROTTLE_MAXIMUM = @"{BC5038F7-23E0-4960-96DA-33ABAF5935EC}";

        /// <summary>
        /// Specifies a percentage (between 0 and 100) that the processor frequency
        /// should never go above for Processor Power Efficiency Class 1.
        /// For example, if this value is set to 80, then the processor frequency will
        /// never be throttled above 80 percent of its maximum frequency by the system.
        /// </summary>
        public const string GUID_PROCESSOR_THROTTLE_MAXIMUM_1 = @"{BC5038F7-23E0-4960-96DA-33ABAF5935ED}";

        /// <summary>
        /// Specifies a percentage (between 0 and 100) that the processor frequency
        /// should not drop below.  For example, if this value is set to 50, then the
        /// processor frequency will never be throttled below 50 percent of its
        /// maximum frequency by the system.
        /// </summary>
        public const string GUID_PROCESSOR_THROTTLE_MINIMUM = @"{893DEE8E-2BEF-41E0-89C6-B55D0929964C}";

        /// <summary>
        /// Specifies a percentage (between 0 and 100) that the processor frequency
        /// should not drop below for Processor Power Efficiency Class 1.
        /// For example, if this value is set to 50, then the processor frequency will
        /// never be throttled below 50 percent of its maximum frequency by the system.
        /// </summary>
        public const string GUID_PROCESSOR_THROTTLE_MINIMUM_1 = @"{893DEE8E-2BEF-41E0-89C6-B55D0929964D}";

        /// <summary>
        /// Specifies the maximum processor frequency (expresssed in MHz).
        /// </summary>
        public const string GUID_PROCESSOR_FREQUENCY_LIMIT = @"{75b0ae3f-bce0-45a7-8c89-c9611c25e100}";

        public const string GUID_PROCESSOR_FREQUENCY_LIMIT_1 = @"{75b0ae3f-bce0-45a7-8c89-c9611c25e101}";

        /// <summary>
        /// Specifies whether throttle states are allowed to be used even when
        /// performance states are available.
        /// </summary>
        public const string GUID_PROCESSOR_ALLOW_THROTTLING = @"{3b04d4fd-1cc7-4f23-ab1c-d1337819c4bb}";

        public const int PROCESSOR_THROTTLE_DISABLED = 0;
        public const int PROCESSOR_THROTTLE_ENABLED = 1;
        public const int PROCESSOR_THROTTLE_AUTOMATIC = 2;

        /// <summary>
        /// Specifies processor power settings for CState policy data
        /// </summary>
        public const string GUID_PROCESSOR_IDLESTATE_POLICY = @"{68f262a7-f621-4069-b9a5-4874169be23c}";

        /// <summary>
        /// Specifies processor power settings for PerfState policy data
        /// </summary>
        public const string GUID_PROCESSOR_PERFSTATE_POLICY = @"{BBDC3814-18E9-4463-8A55-D197327C45C0}";

        /// <summary>
        /// Specifies the increase busy percentage threshold that must be met before
        /// increasing the processor performance state.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_INCREASE_THRESHOLD = @"{06cadf0e-64ed-448a-8927-ce7bf90eb35d}";

        /// <summary>
        /// Specifies the increase busy percentage threshold that must be met before
        /// increasing the processor performance state for Processor Power Efficiency
        /// Class 1.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_INCREASE_THRESHOLD_1 = @"{06cadf0e-64ed-448a-8927-ce7bf90eb35e}";

        /// <summary>
        /// Specifies the decrease busy percentage threshold that must be met before
        /// decreasing the processor performance state.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_DECREASE_THRESHOLD = @"{12a0ab44-fe28-4fa9-b3bd-4b64f44960a6}";

        /// <summary>
        /// Specifies the decrease busy percentage threshold that must be met before
        /// decreasing the processor performance state for Processor Power Efficiency
        /// Class 1.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_DECREASE_THRESHOLD_1 = @"{12a0ab44-fe28-4fa9-b3bd-4b64f44960a7}";

        /// <summary>
        /// Specifies, either as ideal, single or rocket, how aggressive performance
        /// states should be selected when increasing the processor performance state.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_INCREASE_POLICY = @"{465e1f50-b610-473a-ab58-00d1077dc418}";

        /// <summary>
        /// Specifies, either as ideal, single or rocket, how aggressive performance
        /// states should be selected when increasing the processor performance state
        /// for Processor Power Efficiency Class 1.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_INCREASE_POLICY_1 = @"{465e1f50-b610-473a-ab58-00d1077dc419}";

        /// <summary>
        /// Specifies, either as ideal, single or rocket, how aggressive performance
        /// states should be selected when decreasing the processor performance state.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_DECREASE_POLICY = @"{40fbefc7-2e9d-4d25-a185-0cfd8574bac6}";

        /// <summary>
        /// Specifies, either as ideal, single or rocket, how aggressive performance
        /// states should be selected when decreasing the processor performance state for
        /// Processor Power Efficiency Class 1.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_DECREASE_POLICY_1 = @"{40fbefc7-2e9d-4d25-a185-0cfd8574bac7}";

        /// <summary>
        /// Specifies, in milliseconds, the minimum amount of time that must elapse after
        /// the last processor performance state change before increasing the processor
        /// performance state.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_INCREASE_TIME = @"{984cf492-3bed-4488-a8f9-4286c97bf5aa}";

        /// <summary>
        /// Specifies, in milliseconds, the minimum amount of time that must elapse after
        /// the last processor performance state change before increasing the processor
        /// performance state for Processor Power Efficiency Class 1.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_INCREASE_TIME_1 = @"{984cf492-3bed-4488-a8f9-4286c97bf5ab}";

        /// <summary>
        /// Specifies, in milliseconds, the minimum amount of time that must elapse after
        /// the last processor performance state change before increasing the processor
        /// performance state.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_DECREASE_TIME = @"{d8edeb9b-95cf-4f95-a73c-b061973693c8}";

        /// <summary>
        /// Specifies, in milliseconds, the minimum amount of time that must elapse after
        /// the last processor performance state change before increasing the processor
        /// performance state for Processor Power Efficiency Class 1.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_DECREASE_TIME_1 = @"{d8edeb9b-95cf-4f95-a73c-b061973693c9}";

        /// <summary>
        /// Specifies the time, in milliseconds, that must expire before considering
        /// a change in the processor performance states or parked core set.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_TIME_CHECK = @"{4d2b0152-7d5c-498b-88e2-34345392a2c5}";

        /// <summary>
        /// Specifies how the processor should manage performance and efficiency
        /// tradeoffs when boosting frequency above the maximum.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_BOOST_POLICY = @"{45bcc044-d885-43e2-8605-ee0ec6e96b59}";

        public const int PROCESSOR_PERF_BOOST_POLICY_DISABLED = 0;
        public const int PROCESSOR_PERF_BOOST_POLICY_MAX = 100;

        /// <summary>
        /// Specifies how a processor opportunistically increases frequency above
        /// the maximum when operating contitions allow it to do so safely.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_BOOST_MODE = @"{be337238-0d82-4146-a960-4f3749d470c7}";

        public const int PROCESSOR_PERF_BOOST_MODE_DISABLED = 0;
        public const int PROCESSOR_PERF_BOOST_MODE_ENABLED = 1;
        public const int PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE = 2;
        public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_ENABLED = 3;
        public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE = 4;
        public const int PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE_AT_GUARANTEED = 5;
        public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED = 6;
        public const int PROCESSOR_PERF_BOOST_MODE_MAX = PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED;

        /// <summary>
        /// Specifies whether or not a procesor should autonomously select its
        /// operating performance state.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_AUTONOMOUS_MODE = @"{8baa4a8a-14c6-4451-8e8b-14bdbd197537}";

        public const int PROCESSOR_PERF_AUTONOMOUS_MODE_DISABLED = 0;
        public const int PROCESSOR_PERF_AUTONOMOUS_MODE_ENABLED = 1;

        /// <summary>
        /// Specifies the tradeoff between performance and energy the processor should
        /// make when operating in autonomous mode.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE = @"{36687f9e-e3a5-4dbf-b1dc-15eb381c6863}";

        public const int PROCESSOR_PERF_PERFORMANCE_PREFERENCE = 0xff;
        public const int PROCESSOR_PERF_ENERGY_PREFERENCE = 0;

        /// <summary>
        /// Specifies the window over which the processor should observe utilization when
        /// operating in autonomous mode, in microseconds.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_AUTONOMOUS_ACTIVITY_WINDOW = @"{cfeda3d0-7697-4566-a922-a9086cd49dfa}";

        public const int PROCESSOR_PERF_MINIMUM_ACTIVITY_WINDOW = 0;
        public const int PROCESSOR_PERF_MAXIMUM_ACTIVITY_WINDOW = 1270000000;

        /// <summary>
        /// Specifies whether the processor should perform duty cycling.
        /// </summary>
        public const string GUID_PROCESSOR_DUTY_CYCLING = @"{4e4450b3-6179-4e91-b8f1-5bb9938f81a1}";

        public const int PROCESSOR_DUTY_CYCLING_DISABLED = 0;
        public const int PROCESSOR_DUTY_CYCLING_ENABLED = 1;

        /// <summary>
        /// Specifies if idle state promotion and demotion values should be scaled based
        /// on the current peformance state.
        /// </summary>
        public const string GUID_PROCESSOR_IDLE_ALLOW_SCALING = @"{6c2993b0-8f48-481f-bcc6-00dd2742aa06}";

        /// <summary>
        /// Specifies if idle states should be disabled.
        /// </summary>
        public const string GUID_PROCESSOR_IDLE_DISABLE = @"{5d76a2ca-e8c0-402f-a133-2158492d58ad}";

        /// <summary>
        /// Specifies the deepest idle state type that should be used. If this value is
        /// set to zero, this setting is ignored. Values higher than supported by the
        /// processor then this setting has no effect.
        /// </summary>
        public const string GUID_PROCESSOR_IDLE_STATE_MAXIMUM = @"{9943e905-9a30-4ec1-9b99-44dd3b76f7a2}";

        /// <summary>
        /// Specifies the time that elapsed since the last idle state promotion or
        /// demotion before idle states may be promoted or demoted again (in
        /// microseconds).
        /// </summary>
        public const string GUID_PROCESSOR_IDLE_TIME_CHECK = @"{c4581c31-89ab-4597-8e2b-9c9cab440e6b}";

        /// <summary>
        /// Specifies the upper busy threshold that must be met before demoting the
        /// processor to a lighter idle state (in percentage).
        /// </summary>
        public const string GUID_PROCESSOR_IDLE_DEMOTE_THRESHOLD = @"{4b92d758-5a24-4851-a470-815d78aee119}";

        /// <summary>
        /// Specifies the lower busy threshold that must be met before promoting the
        /// processor to a deeper idle state (in percentage).
        /// </summary>
        public const string GUID_PROCESSOR_IDLE_PROMOTE_THRESHOLD = @"{7b224883-b3cc-4d79-819f-8374152cbe7c}";

        /// <summary>
        /// Specifies the utilization threshold in percent that must be crossed in order to un-park cores.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public const string GUID_PROCESSOR_CORE_PARKING_INCREASE_THRESHOLD = @"{df142941-20f3-4edf-9a4a-9c83d3d717d1}";

        /// <summary>
        /// Specifies the utilization threshold in percent that must be crossed in order to park cores.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public const string GUID_PROCESSOR_CORE_PARKING_DECREASE_THRESHOLD = @"{68dd2f27-a4ce-4e11-8487-3794e4135dfa}";

        /// <summary>
        /// Specifies, either as ideal, single or rocket, how aggressive core parking is when cores must be unparked.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_INCREASE_POLICY = @"{c7be0679-2817-4d69-9d02-519a537ed0c6}";

        public const int CORE_PARKING_POLICY_CHANGE_IDEAL = 0;
        public const int CORE_PARKING_POLICY_CHANGE_SINGLE = 1;
        public const int CORE_PARKING_POLICY_CHANGE_ROCKET = 2;
        public const int CORE_PARKING_POLICY_CHANGE_MULTISTEP = 3;
        public const int CORE_PARKING_POLICY_CHANGE_MAX = CORE_PARKING_POLICY_CHANGE_MULTISTEP;

        //
        // Specifies, either as ideal, single or rocket, how aggressive core parking is when cores must be parked.
        //
        // {71021b41-c749-4d21-be74-a00f335d582b}
        //
        public const string GUID_PROCESSOR_CORE_PARKING_DECREASE_POLICY = @"{71021b41-c749-4d21-be74-a00f335d582b}";

        /// <summary>
        /// Specifies, either as ideal, single or rocket, how aggressive core parking is when cores must be parked.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_MAX_CORES = @"{ea062031-0e34-4ff1-9b6d-eb1059334028}";

        /// <summary>
        /// Specifies, on a per processor group basis, the maximum number of cores that
        /// can be kept unparked for Processor Power Efficiency Class 1.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_MAX_CORES_1 = @"{ea062031-0e34-4ff1-9b6d-eb1059334029}";

        /// <summary>
        /// Specifies, on a per processor group basis, the minimum number of cores that must be kept unparked.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_MIN_CORES = @"{0cc5b647-c1df-4637-891a-dec35c318583}";

        /// <summary>
        /// Specifies, on a per processor group basis, the minimum number of cores that
        /// must be kept unparked in Processor Power Efficiency Class 1.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_MIN_CORES_1 = @"{0cc5b647-c1df-4637-891a-dec35c318584}";

        /// <summary>
        /// Specifies, in milliseconds, the minimum amount of time a core must be parked before it can be unparked.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_INCREASE_TIME = @"{2ddd5a84-5a71-437e-912a-db0b8c788732}";

        /// <summary>
        /// Specifies, in milliseconds, the minimum amount of time a core must be unparked before it can be parked.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_DECREASE_TIME = @"{dfd10d17-d5eb-45dd-877a-9a34ddd15c82}";

        /// <summary>
        /// Specifies the factor by which to decrease affinity history on each core after each check.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_DECREASE_FACTOR = @"{8f7b45e3-c393-480a-878c-f67ac3d07082}";

        /// <summary>
        /// Specifies the threshold above which a core is considered to have had significant affinitized work scheduled to it while parked.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_THRESHOLD = @"{5b33697b-e89d-4d38-aa46-9e7dfb7cd2f9}";

        /// <summary>
        /// Specifies the weighting given to each occurence where affinitized work was scheduled to a parked core.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_AFFINITY_WEIGHTING = @"{e70867f1-fa2f-4f4e-aea1-4d8a0ba23b20}";

        /// <summary>
        /// Specifies the factor by which to decrease the over utilization history on each core after the current performance check.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_DECREASE_FACTOR = @"{1299023c-bc28-4f0a-81ec-d3295a8d815d}";

        /// <summary>
        /// Specifies the threshold above which a core is considered to have been recently over utilized while parked.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_THRESHOLD = @"{9ac18e92-aa3c-4e27-b307-01ae37307129}";

        /// <summary>
        /// Specifies the weighting given to each occurence where a parked core is found to be over utilized.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_WEIGHTING = @"{8809c2d8-b155-42d4-bcda-0d345651b1db}";

        /// <summary>
        /// Specifies, in percentage, the busy threshold that must be met before a parked core is considered over utilized.
        /// </summary>
        public const string GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_THRESHOLD = @"{943c8cb6-6f93-4227-ad87-e9a3feec08d1}";

        /// <summary>
        /// Specifies if at least one processor per core should always remain unparked.
        /// </summary>
        public const string GUID_PROCESSOR_PARKING_CORE_OVERRIDE = @"{a55612aa-f624-42c6-a443-7397d064c04f}";

        /// <summary>
        /// Specifies what performance state a processor should enter when first parked.
        /// </summary>
        public const string GUID_PROCESSOR_PARKING_PERF_STATE = @"{447235c7-6a8d-4cc0-8e24-9eaf70b96e2b}";

        /// <summary>
        /// Specifies what performance state a processor should enter when first parked
        /// for Processor Power Efficiency Class 1.
        /// </summary>
        public const string GUID_PROCESSOR_PARKING_PERF_STATE_1 = @"{447235c7-6a8d-4cc0-8e24-9eaf70b96e2c}";

        /// <summary>
        /// Specify the busy threshold that must be met when calculating the concurrency of a node's workload.
        /// </summary>
        public const string GUID_PROCESSOR_PARKING_CONCURRENCY_THRESHOLD = @"{2430ab6f-a520-44a2-9601-f7f23b5134b1}";

        /// <summary>
        /// Specify the busy threshold that must be met by all cores in a concurrency set to unpark an extra core.
        /// </summary>
        public const string GUID_PROCESSOR_PARKING_HEADROOM_THRESHOLD = @"{f735a673-2066-4f80-a0c5-ddee0cf1bf5d}";

        /// <summary>
        /// Specify the percentage utilization used to calculate the distribution concurrency.
        /// </summary>
        public const string GUID_PROCESSOR_PARKING_DISTRIBUTION_THRESHOLD = @"{4bdaf4e9-d103-46d7-a5f0-6280121616ef}";

        /// <summary>
        /// Specifies the number of perf time check intervals to average utility over.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_HISTORY = @"{7d24baa7-0b84-480f-840c-1b0743c00f5f}";

        /// <summary>
        /// Specifies the number of perf time check intervals to average utility over in
        /// Processor Power Efficiency Class 1.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_HISTORY_1 = @"{7d24baa7-0b84-480f-840c-1b0743c00f60}";

        /// <summary>
        /// Specifies the number of perf time check intervals to average utility over to
        /// determine performance increase.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public const string GUID_PROCESSOR_PERF_INCREASE_HISTORY = @"{99b3ef01-752f-46a1-80fb-7730011f2354}";

        /// <summary>
        /// Specifies the number of perf time check intervals to average utility over to
        /// determine performance decrease.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public const string GUID_PROCESSOR_PERF_DECREASE_HISTORY = @"{0300f6f8-abd6-45a9-b74f-4908691a40b5}";

        /// <summary>
        /// Specifies the number of perf time check intervals to average utility over for
        /// core parking.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public const string GUID_PROCESSOR_PERF_CORE_PARKING_HISTORY = @"{77d7f282-8f1a-42cd-8537-45450a839be8}";

        /// <summary>
        /// Specifies whether latency sensitivity hints should be taken into account by
        /// the perf state engine.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public const string GUID_PROCESSOR_PERF_LATENCY_HINT = @"{0822df31-9c83-441c-a079-0de4cf009c7b}";

        /// <summary>
        /// Specifies the processor performance state in response to latency sensitivity hints.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_LATENCY_HINT_PERF = @"{619b7505-003b-4e82-b7a6-4dd29c300971}";

        /// <summary>
        /// Specifies the processor performance state in response to latency sensitivity
        /// hints for Processor Power Efficiency Class 1.
        /// </summary>
        public const string GUID_PROCESSOR_PERF_LATENCY_HINT_PERF_1 = @"{619b7505-003b-4e82-b7a6-4dd29c300972}";

        /// <summary>
        /// Specifies the minimum unparked processors when a latency hint is active
        /// (in a percentage).
        /// </summary>
        public const string GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK = @"{616cdaa5-695e-4545-97ad-97dc2d1bdd88}";

        /// <summary>
        /// Specifies the minimum unparked processors when a latency hint is active
        /// for Processor Power Efficiency Class 1 (in a percentage).
        /// </summary>
        public const string GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK_1 = @"{616cdaa5-695e-4545-97ad-97dc2d1bdd89}";

        /// <summary>
        /// Specifies whether the core parking engine should distribute processor
        /// utility.
        /// </summary>
        public const string GUID_PROCESSOR_DISTRIBUTE_UTILITY = @"{e0007330-f589-42ed-a401-5ddb10e785d3}";

        //
        // GUIDS to control PPM settings on computer system with more than one
        // Processor Power Efficiency Classes (heterogeneous system).
        // -----------------

        /// <summary>
        /// Specifies the current active heterogeneous policy.
        /// </summary>
        public const string GUID_PROCESSOR_HETEROGENEOUS_POLICY = @"{7f2f5cfa-f10c-4823-b5e1-e93ae85f46b5}";

        /// <summary>
        /// Specifies the number of perf check cycles required to decrease the number of
        /// Processor Power Efficiency Class 1 processors.
        /// </summary>
        public const string GUID_PROCESSOR_HETERO_DECREASE_TIME = @"{7f2492b6-60b1-45e5-ae55-773f8cd5caec}";

        /// <summary>
        /// Specifies the number of perf check cycles required to increase the number of
        /// Processor Power Efficiency Class 1 processors.
        /// </summary>
        public const string GUID_PROCESSOR_HETERO_INCREASE_TIME = @"{4009efa7-e72d-4cba-9edf-91084ea8cbc3}";

        /// <summary>
        /// Specifies the performance level (in units of Processor Power Efficiency
        /// Class 0 processor performance) at which the number of Processor Power
        /// Efficiency Class 1 processors is decreased.
        /// </summary>
        public const string GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD = @"{f8861c27-95e7-475c-865b-13c0cb3f9d6b}";

        /// <summary>
        /// Specifies the performance level (in units of Processor Power Efficiency
        /// Class 0 processor performance) at which the number of Processor Power
        /// Efficiency Class 1 processors is increased.
        /// </summary>
        public const string GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD = @"{b000397d-9b0b-483d-98c9-692a6060cfbf}";

        /// <summary>
        /// Specifies the performance target floor of a Processor Power Efficiency
        /// Class 0 processor when the system unparks Processor Power Efficiency Class 1
        /// processor(s).
        /// </summary>
        public const string GUID_PROCESSOR_CLASS0_FLOOR_PERF = @"{fddc842b-8364-4edc-94cf-c17f60de1c80}";

        /// <summary>
        /// Specifies the initial performance target of a Processor Power Efficiency
        /// Class 1 processor when the system makes a transition up from zero Processor
        /// Power Efficiency Class 1 processors.
        /// </summary>
        public const string GUID_PROCESSOR_CLASS1_INITIAL_PERF = @"{1facfc65-a930-4bc5-9f38-504ec097bbc0}";

        /// <summary>
        /// Specifies the scheduling policy for threads in a given QoS class.
        /// </summary>
        public const string GUID_PROCESSOR_THREAD_SCHEDULING_POLICY = @"{93b8b6dc-0698-4d1c-9ee4-0644e900c85d}";

        /// <summary>
        /// Specifies the scheduling policy for short running threads in a given QoS
        /// class.
        /// </summary>
        public const string GUID_PROCESSOR_SHORT_THREAD_SCHEDULING_POLICY = @"{bae08b81-2d5e-4688-ad6a-13243356654b}";

        /// <summary>
        /// Specifies active vs passive cooling.  Although not directly related to
        /// processor settings, it is the processor that gets throttled if we're doing
        /// passive cooling, so it is fairly strongly related.
        /// </summary>
        public const string GUID_SYSTEM_COOLING_POLICY = @"{94D3A615-A899-4AC5-AE2B-E4D8F634367F}";

        // Lock Console on Wake
        // --------------------
        //

        /// <summary>
        /// Specifies the behavior of the system when we wake from standby or
        /// hibernate.  If this is set, then we will cause the console to lock
        /// after we resume.
        /// </summary>
        public const string GUID_LOCK_CONSOLE_ON_WAKE = @"{0E796BDB-100D-47D6-A2D5-F7D2DAA51F51}";

        // Device idle characteristics
        // ---------------------------

        /// <summary>
        /// Specifies whether to use the "performance" or "conservative" timeouts for
        /// device idle management.
        /// </summary>
        public const string GUID_DEVICE_IDLE_POLICY = @"{4faab71a-92e5-4726-b531-224559672d19}";

        public const int POWER_DEVICE_IDLE_POLICY_PERFORMANCE = 0;
        public const int POWER_DEVICE_IDLE_POLICY_CONSERVATIVE = 1;

        /// <summary>
        /// Specifies standby connectivity preference.
        /// </summary>
        public const string GUID_CONNECTIVITY_IN_STANDBY = @"{F15576E8-98B7-4186-B944-EAFA664402D9}";

        public const int POWER_CONNECTIVITY_IN_STANDBY_DISABLED = 0;
        public const int POWER_CONNECTIVITY_IN_STANDBY_ENABLED = 1;
        public const int POWER_CONNECTIVITY_IN_STANDBY_SYSTEM_MANAGED = 2;

        /// <summary>
        /// Specifies the mode for disconnected standby.
        /// </summary>
        public const string GUID_DISCONNECTED_STANDBY_MODE = @"{68AFB2D9-EE95-47A8-8F50-4115088073B1}";

        public const int POWER_DISCONNECTED_STANDBY_MODE_NORMAL = 0;
        public const int POWER_DISCONNECTED_STANDBY_MODE_AGGRESSIVE = 1;

        // AC/DC power source
        // ------------------
        //

        /// <summary>
        /// Specifies the power source for the system.
        /// </summary>
        /// <remarks>
        /// Consumers may register for
        /// notification when the power source changes and will be notified with
        /// one of 3 values:
        /// 0 - Indicates the system is being powered by an AC power source.
        /// 1 - Indicates the system is being powered by a DC power source.
        /// 2 - Indicates the system is being powered by a short-term DC power
        ///     source.  For example, this would be the case if the system is
        ///     being powed by a short-term battery supply in a backing UPS
        ///     system.  When this value is recieved, the consumer should make
        ///     preparations for either a system hibernate or system shutdown.
        /// </remarks>
        public const string GUID_ACDC_POWER_SOURCE = @"{5D3E9A59-E9D5-4B00-A6BD-FF34FF516548}";

        // Lid state changes
        // -----------------

        /// <summary>
        /// Specifies the current state of the lid (open or closed). The callback won't
        /// be called at all until a lid device is found and its current state is known.
        /// </summary>
        /// <remarks>
        /// Values:
        /// 0 - closed
        /// 1 - opened
        /// </remarks>
        public const string GUID_LIDSWITCH_STATE_CHANGE = @"{BA3E0F4D-B817-4094-A2D1-D56379E6A0F3}";

        // Battery status changes
        // ----------------------
        //

        /// <summary>
        /// <para>
        /// Specifies the percentage of battery life remaining.  The consumer
        /// may register for notification in order to track battery life in
        /// a fine-grained manner.
        /// </para>
        /// <para>
        /// Once registered, the consumer can expect to be notified as the battery
        /// life percentage changes.
        /// </para>
        /// <para>
        /// The consumer will recieve a value between 0 and 100 (inclusive) which
        /// indicates percent battery life remaining.
        /// </para>
        /// </summary>
        public const string GUID_BATTERY_PERCENTAGE_REMAINING = @"{A7AD8041-B45A-4CAE-87A3-EECBB468A9E1}";

        /// <summary>
        /// <para>
        /// Specifies change in number of batteries present on the system. The consumer
        /// may register for notification in order to track change in number of batteries
        /// available on a system.
        /// </para>
        /// <para>
        /// Once registered, the consumer can expect to be notified whenever the
        /// batteries are added or removed from the system.
        /// </para>
        /// <para>
        /// The consumer will recieve a value indicating number of batteries currently
        /// present on the system.
        /// </para>
        /// </summary>
        public const string GUID_BATTERY_COUNT = @"{7d263f15-fca4-49e5-854b-a9f2bfbd5c24}";

        /// <summary>
        /// Global notification indicating to listeners user activity/presence accross
        /// all sessions in the system (Present, NotPresent, Inactive)
        /// </summary>
        public const string GUID_GLOBAL_USER_PRESENCE = @"{786e8a1d-b427-4344-9207-09e70bdcbea9}";

        /// <summary>
        /// Session specific notification indicating to listeners whether or not the display
        /// related to the given session is on/off/dim
        /// </summary>
        /// <remarks>
        /// This is a session-specific notification, sent only to interactive
        /// session registrants. Session 0 and kernel mode consumers do not receive
        /// this notification.
        /// </remarks>
        public const string GUID_SESSION_DISPLAY_STATUS = @"{2b84c20e-ad23-4ddf-93db-05ffbd7efca5}";

        /// <summary>
        /// Session specific notification indicating to listeners user activity/presence
        /// (Present, NotPresent, Inactive)
        /// </summary>
        /// <remarks>
        /// <note>
        ///      This is a session-specific notification, sent only to interactive
        ///      session registrants. Session 0 and kernel mode consumers do not receive
        ///      this notification.
        /// </note>
        /// </remarks>
        public const string GUID_SESSION_USER_PRESENCE = @"{3c0f4548-c03f-4c4d-b9f2-237ede686376}";

        /// <summary>
        /// Notification to listeners that the system is fairly busy and won't be moving
        /// into an idle state any time soon.  This can be used as a hint to listeners
        /// that now might be a good time to do background tasks.
        /// </summary>
        public const string GUID_IDLE_BACKGROUND_TASK = @"{515C31D8-F734-163D-A0FD-11A08C91E8F1}";

        /// <summary>
        /// Notification to listeners that the system is fairly busy and won't be moving
        /// into an idle state any time soon.  This can be used as a hint to listeners
        /// that now might be a good time to do background tasks.
        /// </summary>
        public const string GUID_BACKGROUND_TASK_NOTIFICATION = @"{CF23F240-2A54-48D8-B114-DE1518FF052E}";

        /// <summary>
        /// Define a GUID that will represent the action of a direct experience button
        /// on the platform.  Users will register for this DPPE setting and recieve
        /// notification when the h/w button is pressed.
        /// </summary>
        public const string GUID_APPLAUNCH_BUTTON = @"{1A689231-7399-4E9A-8F99-B71F999DB3FA}";

        // PCI Express power settings
        // ------------------------
        //

        /// <summary>
        /// Specifies the subgroup which will contain all of the PCI Express
        /// settings for a single policy.
        /// </summary>
        public const string GUID_PCIEXPRESS_SETTINGS_SUBGROUP = @"{501a4d13-42af-4429-9fd1-a8218c268e20}";

        /// <summary>
        /// Specifies the PCI Express ASPM power policy.
        /// </summary>
        public const string GUID_PCIEXPRESS_ASPM_POLICY = @"{ee12f906-d277-404b-b6da-e5fa1a576df5}";

        // POWER Shutdown settings
        // ------------------------
        //

        /// <summary>
        /// Specifies if forced shutdown should be used for all button and lid initiated
        /// shutdown actions.
        /// </summary>
        public const string GUID_ENABLE_SWITCH_FORCED_SHUTDOWN = @"{833a6b62-dfa4-46d1-82f8-e09e34d029d6}";

        // Interrupt Steering power settings
        // ------------------------
        //

        public const string GUID_INTSTEER_SUBGROUP = @"{48672f38-7a9a-4bb2-8bf8-3d85be19de4e}";

        public const string GUID_INTSTEER_MODE = @"{2bfc24f9-5ea2-4801-8213-3dbae01aa39d}";

        public const string GUID_INTSTEER_LOAD_PER_PROC_TRIGGER = @"{73cde64d-d720-4bb2-a860-c755afe77ef2}";

        public const string GUID_INTSTEER_TIME_UNPARK_TRIGGER = @"{d6ba4903-386f-4c2c-8adb-5c21b3328d25}";

        // Graphics power settings
        // ------------------------
        //

        /// <summary>
        /// Specified the subgroup which contains all inbox graphics settings.
        /// </summary>
        public const string GUID_GRAPHICS_SUBGROUP = @"{5fb4938d-1ee8-4b0f-9a3c-5036b0ab995c}";

        /// <summary>
        /// Specifies the GPU preference policy.
        /// </summary>
        public const string GUID_GPU_PREFERENCE_POLICY = @"{dd848b2a-8a5d-4451-9ae2-39cd41658f6c}";

        // Other miscellaneous power notification GUIDs
        // ------------------------
        //

        /// <summary>
        /// Specifies whether mixed reality mode is engaged.
        /// </summary>
        public const string GUID_MIXED_REALITY_MODE = @"{1e626b4e-cf04-4f8d-9cc7-c97c5b0f2391}";

        /// <summary>
        /// Specifies a change (start/end) in System Power Report's Active Session.
        /// </summary>
        public const string GUID_SPR_ACTIVE_SESSION_CHANGE = @"{0e24ce38-c393-4742-bdb1-744f4b9ee08e}";

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13503
        //
        // I/O Completion Specific Access Rights.
        //

        public const int IO_COMPLETION_MODIFY_STATE = 0x0002;
        public const int IO_COMPLETION_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3;

        public const ulong IO_QOS_MAX_RESERVATION = 1000000000UL;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13513
        //
        // Some applications include both ntioapi_x.h and winioctl.h
        //

        public const string SMB_CCF_APP_INSTANCE_EA_NAME = "ClusteredApplicationInstance";

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13526
        //
        // Define the SMB Cluster Client Failover AppInstance Extended Attribute name
        // newer version of input payload assumes that EA is not just a GUID,
        // but instead is a structure that contains additional information
        //

        //
        // Is used only when file is opened directly on CSVFS. This flag is ignored when file
        // is opened over SMB.
        // Tells CSVFS that this file open should be valid only on coordinating node.
        // If open comes to CSVFS, and this node is not a coordinating then open would fail.
        // If file is opened, and coordinating node is moved then file open will be invalidated
        //
        public const int NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR = 0x00000001;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15108
        public const int POWER_SYSTEM_MAXIMUM = 7;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15147
        public const int ES_SYSTEM_REQUIRED = 0x00000001;
        public const int ES_DISPLAY_REQUIRED = 0x00000002;
        public const int ES_USER_PRESENT = 0x00000004;
        public const int ES_AWAYMODE_REQUIRED = 0x00000040;
        public const int ES_CONTINUOUS = unchecked((int)0x80000000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15160
        public const int DIAGNOSTIC_REASON_VERSION = 0;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15160
        public const int DIAGNOSTIC_REASON_SIMPLE_STRING = 0x00000001;
        public const int DIAGNOSTIC_REASON_DETAILED_STRING = 0x00000002;
        public const int DIAGNOSTIC_REASON_NOT_SPECIFIED = unchecked((int)0x80000000);
        public const int DIAGNOSTIC_REASON_INVALID_FLAGS = unchecked((int)~0x80000007);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15168
        //
        // Defines for power request APIs
        //

        public const int POWER_REQUEST_CONTEXT_VERSION = DIAGNOSTIC_REASON_VERSION;

        public const int POWER_REQUEST_CONTEXT_SIMPLE_STRING = DIAGNOSTIC_REASON_SIMPLE_STRING;
        public const int POWER_REQUEST_CONTEXT_DETAILED_STRING = DIAGNOSTIC_REASON_DETAILED_STRING;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15188
        //-----------------------------------------------------------------------------
        // Device Power Information
        // Accessable via CM_Get_DevInst_Registry_Property_Ex(CM_DRP_DEVICE_POWER_DATA)
        //-----------------------------------------------------------------------------

        public const int PDCAP_D0_SUPPORTED = 0x00000001;
        public const int PDCAP_D1_SUPPORTED = 0x00000002;
        public const int PDCAP_D2_SUPPORTED = 0x00000004;
        public const int PDCAP_D3_SUPPORTED = 0x00000008;
        public const int PDCAP_WAKE_FROM_D0_SUPPORTED = 0x00000010;
        public const int PDCAP_WAKE_FROM_D1_SUPPORTED = 0x00000020;
        public const int PDCAP_WAKE_FROM_D2_SUPPORTED = 0x00000040;
        public const int PDCAP_WAKE_FROM_D3_SUPPORTED = 0x00000080;
        public const int PDCAP_WARM_EJECT_SUPPORTED = 0x00000100;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15492
        public const int POWER_SETTING_VALUE_VERSION = 0x1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15541
        public const int POWER_PLATFORM_ROLE_V1 = 0x00000001;

        public const int POWER_PLATFORM_ROLE_V2 = 0x00000002;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15683
        public const int PROC_IDLE_BUCKET_COUNT = 6;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15705
        public const int PROC_IDLE_BUCKET_COUNT_EX = 16;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15734
        //
        // Definitions of coordination types for _PSD, _TSD, and _CSD BIOS objects from
        // the Acpi 3.0 specification
        //

        public const int ACPI_PPM_SOFTWARE_ALL = 0xFC;
        public const int ACPI_PPM_SOFTWARE_ANY = 0xFD;
        public const int ACPI_PPM_HARDWARE_ALL = 0xFE;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15743
        //
        // Definition of Microsoft PPM coordination types.
        //

        public const int MS_PPM_SOFTWARE_ALL = 0x1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15749
        //
        // Processor firmware rundown feature bit definitions.
        //

        public const int PPM_FIRMWARE_ACPI1C2 = 0x00000001;
        public const int PPM_FIRMWARE_ACPI1C3 = 0x00000002;
        public const int PPM_FIRMWARE_ACPI1TSTATES = 0x00000004;
        public const int PPM_FIRMWARE_CST = 0x00000008;
        public const int PPM_FIRMWARE_CSD = 0x00000010;
        public const int PPM_FIRMWARE_PCT = 0x00000020;
        public const int PPM_FIRMWARE_PSS = 0x00000040;
        public const int PPM_FIRMWARE_XPSS = 0x00000080;
        public const int PPM_FIRMWARE_PPC = 0x00000100;
        public const int PPM_FIRMWARE_PSD = 0x00000200;
        public const int PPM_FIRMWARE_PTC = 0x00000400;
        public const int PPM_FIRMWARE_TSS = 0x00000800;
        public const int PPM_FIRMWARE_TPC = 0x00001000;
        public const int PPM_FIRMWARE_TSD = 0x00002000;
        public const int PPM_FIRMWARE_PCCH = 0x00004000;
        public const int PPM_FIRMWARE_PCCP = 0x00008000;
        public const int PPM_FIRMWARE_OSC = 0x00010000;
        public const int PPM_FIRMWARE_PDC = 0x00020000;
        public const int PPM_FIRMWARE_CPC = 0x00040000;
        public const int PPM_FIRMWARE_LPI = 0x00080000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15774
        //
        // Processor performance and idle controls implementations.
        //

        public const int PPM_PERFORMANCE_IMPLEMENTATION_NONE = 0x00000000;
        public const int PPM_PERFORMANCE_IMPLEMENTATION_PSTATES = 0x00000001;
        public const int PPM_PERFORMANCE_IMPLEMENTATION_PCCV1 = 0x00000002;
        public const int PPM_PERFORMANCE_IMPLEMENTATION_CPPC = 0x00000003;
        public const int PPM_PERFORMANCE_IMPLEMENTATION_PEP = 0x00000004;

        public const int PPM_IDLE_IMPLEMENTATION_NONE = 0x00000000;
        public const int PPM_IDLE_IMPLEMENTATION_CSTATES = 0x00000001;
        public const int PPM_IDLE_IMPLEMENTATION_PEP = 0x00000002;
        public const int PPM_IDLE_IMPLEMENTATION_MICROPEP = 0x00000003;
        public const int PPM_IDLE_IMPLEMENTATION_LPISTATES = 0x00000004;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15790
        //
        // Processor Power Management WMI interface.
        //

        public const string PPM_PERFSTATE_CHANGE_GUID = "{a5b32ddd-7f39-4abc-b892-900e43b59ebb}";

        public const string PPM_PERFSTATE_DOMAIN_CHANGE_GUID = "{995e6b7f-d653-497a-b978-36a30c29bf01}";

        public const string PPM_IDLESTATE_CHANGE_GUID = "{4838fe4f-f71c-4e51-9ecc-8430a7ac4c6c}";

        public const string PPM_PERFSTATES_DATA_GUID = "{5708cc20-7d40-4bf4-b4aa-2b01338d0126}";

        public const string PPM_IDLESTATES_DATA_GUID = "{ba138e10-e250-4ad7-8616-cf1a7ad410e7}";

        public const string PPM_IDLE_ACCOUNTING_GUID = "{e2a26f78-ae07-4ee0-a30f-ce54f55a94cd}";

        public const string PPM_IDLE_ACCOUNTING_EX_GUID = "{d67abd39-81f8-4a5e-8152-72e31ec912ee}";

        public const string PPM_THERMALCONSTRAINT_GUID = "{a852c2c8-1a4c-423b-8c2c-f30d82931a88}";

        public const string PPM_PERFMON_PERFSTATE_GUID = "{7fd18652-0cfe-40d2-b0a1-0b066a87759e}";

        public const string PPM_THERMAL_POLICY_CHANGE_GUID = "{48f377b8-6880-4c7b-8bdc-380176c6654d}";

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15880
        // POWER_ACTION_POLICY->Flags:
        public const int POWER_ACTION_QUERY_ALLOWED = 0x00000001;
        public const int POWER_ACTION_UI_ALLOWED = 0x00000002;
        public const int POWER_ACTION_OVERRIDE_APPS = 0x00000004;
        public const int POWER_ACTION_HIBERBOOT = 0x00000008;
        public const int POWER_ACTION_USER_NOTIFY = 0x00000010;  // Indicate User-mode of an impending action.
        public const int POWER_ACTION_DOZE_TO_HIBERNATE = 0x00000020;
        public const int POWER_ACTION_ACPI_CRITICAL = 0x01000000;
        public const int POWER_ACTION_ACPI_USER_NOTIFY = 0x02000000;
        public const int POWER_ACTION_DIRECTED_DRIPS = 0x04000000;
        public const int POWER_ACTION_PSEUDO_TRANSITION = 0x08000000;
        public const int POWER_ACTION_LIGHTEST_FIRST = 0x10000000;
        public const int POWER_ACTION_LOCK_CONSOLE = 0x20000000;
        public const int POWER_ACTION_DISABLE_WAKES = 0x40000000;
        public const int POWER_ACTION_CRITICAL = unchecked((int)0x80000000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15896
        // POWER_ACTION_POLICY->EventCode flags
        public const int POWER_LEVEL_USER_NOTIFY_TEXT = 0x00000001;
        public const int POWER_LEVEL_USER_NOTIFY_SOUND = 0x00000002;
        public const int POWER_LEVEL_USER_NOTIFY_EXEC = 0x00000004;
        public const int POWER_USER_NOTIFY_BUTTON = 0x00000008;
        public const int POWER_USER_NOTIFY_SHUTDOWN = 0x00000010; // Application and Services are intimated of shutdown.
        public const int POWER_USER_NOTIFY_FORCED_SHUTDOWN = 0x00000020; // Immediate shutdown - Application and Services are not intimated.
        public const int POWER_FORCE_TRIGGER_RESET = unchecked((int)0x80000000);

        // Note: for battery alarm EventCodes, the ID of the battery alarm << 16 is ORed
        // into the flags.  For example: DISCHARGE_POLICY_LOW << 16

        //
        // The GUID_BATTERY_DISCHARGE_FLAGS_x power settings use a subset of EventCode
        // flags.  The POWER_FORCE_TRIGGER_RESET flag doesn't make sense for a battery
        // alarm so it is overloaded for other purposes (gerneral enable/disable).
        public const int BATTERY_DISCHARGE_FLAGS_EVENTCODE_MASK = 0x00000007;
        public const int BATTERY_DISCHARGE_FLAGS_ENABLE = unchecked((int)0x80000000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15924
        // Discharge policy constants
        public const int NUM_DISCHARGE_POLICIES = 4;
        public const int DISCHARGE_POLICY_CRITICAL = 0;
        public const int DISCHARGE_POLICY_LOW = 1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15985
        //
        // Processor Idle State Policy.
        //

        public const int PROCESSOR_IDLESTATE_POLICY_COUNT = 0x3;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16013
        //
        // Legacy Processor Policy.  This is only provided to allow legacy
        // applications to compile.  New applications must use
        // PROCESSOR_IDLESTATE_POLICY.
        //

        public const int PO_THROTTLE_NONE = 0;
        public const int PO_THROTTLE_CONSTANT = 1;
        public const int PO_THROTTLE_DEGRADE = 2;
        public const int PO_THROTTLE_ADAPTIVE = 3;
        public const int PO_THROTTLE_MAXIMUM = 4;   // not a policy, just a limit

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16122
        public const int HIBERFILE_TYPE_NONE = 0x00;
        public const int HIBERFILE_TYPE_REDUCED = 0x01;
        public const int HIBERFILE_TYPE_FULL = 0x02;
        public const int HIBERFILE_TYPE_MAX = 0x03;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16363
        public const int IMAGE_SIZEOF_FILE_HEADER = 20;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16365
        /// <summary>Relocation info stripped from file.</summary>
        public const short IMAGE_FILE_RELOCS_STRIPPED = 0x0001;
        /// <summary>File is executable (i.e. no unresolved external references).</summary>
        public const short IMAGE_FILE_EXECUTABLE_IMAGE = 0x0002;
        /// <summary>Line nunbers stripped from file.</summary>
        public const short IMAGE_FILE_LINE_NUMS_STRIPPED = 0x0004;
        /// <summary>Local symbols stripped from file.</summary>
        public const short IMAGE_FILE_LOCAL_SYMS_STRIPPED = 0x0008;
        /// <summary>Aggressively trim working set</summary>
        public const short IMAGE_FILE_AGGRESIVE_WS_TRIM = 0x0010;
        /// <summary>App can handle &gt;2gb addresses</summary>
        public const short IMAGE_FILE_LARGE_ADDRESS_AWARE = 0x0020;
        /// <summary>Bytes of machine word are reversed.</summary>
        public const short IMAGE_FILE_BYTES_REVERSED_LO = 0x0080;
        /// <summary>32 bit word machine.</summary>
        public const short IMAGE_FILE_32BIT_MACHINE = 0x0100;
        /// <summary>Debugging info stripped from file in .DBG file</summary>
        public const short IMAGE_FILE_DEBUG_STRIPPED = 0x0200;
        /// <summary>If Image is on removable media, copy and run from the swap file.</summary>
        public const short IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP = 0x0400;
        /// <summary>If Image is on Net, copy and run from the swap file.</summary>
        public const short IMAGE_FILE_NET_RUN_FROM_SWAP = 0x0800;
        /// <summary>System File.</summary>
        public const short IMAGE_FILE_SYSTEM = 0x1000;
        /// <summary>File is a DLL.</summary>
        public const short IMAGE_FILE_DLL = 0x2000;
        /// <summary>File should only be run on a UP machine</summary>
        public const short IMAGE_FILE_UP_SYSTEM_ONLY = 0x4000;
        /// <summary>Bytes of machine word are reversed.</summary>
        public const short IMAGE_FILE_BYTES_REVERSED_HI = unchecked((short)0x8000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16381
        public const short IMAGE_FILE_MACHINE_UNKNOWN = 0;
        /// <summary>Useful for indicating we want to interact with the host and not a WoW guest.</summary>
        public const short IMAGE_FILE_MACHINE_TARGET_HOST = 0x0001;
        /// <summary>Intel 386.</summary>
        public const short IMAGE_FILE_MACHINE_I386 = 0x014c;
        /// <summary>MIPS little-endian, 0x160 big-endian</summary>
        public const short IMAGE_FILE_MACHINE_R3000 = 0x0162;
        /// <summary>MIPS little-endian</summary>
        public const short IMAGE_FILE_MACHINE_R4000 = 0x0166;
        /// <summary>MIPS little-endian</summary>
        public const short IMAGE_FILE_MACHINE_R10000 = 0x0168;
        /// <summary>MIPS little-endian WCE v2</summary>
        public const short IMAGE_FILE_MACHINE_WCEMIPSV2 = 0x0169;
        /// <summary>Alpha_AXP</summary>
        public const short IMAGE_FILE_MACHINE_ALPHA = 0x0184;
        /// <summary>SH3 little-endian</summary>
        public const short IMAGE_FILE_MACHINE_SH3 = 0x01a2;
        public const short IMAGE_FILE_MACHINE_SH3DSP = 0x01a3;
        /// <summary>SH3E little-endian</summary>
        public const short IMAGE_FILE_MACHINE_SH3E = 0x01a4;
        /// <summary>SH4 little-endian</summary>
        public const short IMAGE_FILE_MACHINE_SH4 = 0x01a6;
        /// <summary>SH5</summary>
        public const short IMAGE_FILE_MACHINE_SH5 = 0x01a8;
        /// <summary>ARM Little-Endian</summary>
        public const short IMAGE_FILE_MACHINE_ARM = 0x01c0;
        /// <summary>ARM Thumb/Thumb-2 Little-Endian</summary>
        public const short IMAGE_FILE_MACHINE_THUMB = 0x01c2;
        /// <summary>ARM Thumb-2 Little-Endian</summary>
        public const short IMAGE_FILE_MACHINE_ARMNT = 0x01c4;
        public const short IMAGE_FILE_MACHINE_AM33 = 0x01d3;
        /// <summary>IBM PowerPC Little-Endian</summary>
        public const short IMAGE_FILE_MACHINE_POWERPC = 0x01F0;
        public const short IMAGE_FILE_MACHINE_POWERPCFP = 0x01f1;
        /// <summary>Intel 64</summary>
        public const short IMAGE_FILE_MACHINE_IA64 = 0x0200;
        /// <summary>MIPS</summary>
        public const short IMAGE_FILE_MACHINE_MIPS16 = 0x0266;
        /// <summary>ALPHA64</summary>
        public const short IMAGE_FILE_MACHINE_ALPHA64 = 0x0284;
        /// <summary>MIPS</summary>
        public const short IMAGE_FILE_MACHINE_MIPSFPU = 0x0366;
        /// <summary>MIPS</summary>
        public const short IMAGE_FILE_MACHINE_MIPSFPU16 = 0x0466;
        public const short IMAGE_FILE_MACHINE_AXP64 = IMAGE_FILE_MACHINE_ALPHA64;
        /// <summary>Infineon</summary>
        public const short IMAGE_FILE_MACHINE_TRICORE = 0x0520;
        public const short IMAGE_FILE_MACHINE_CEF = 0x0CEF;
        /// <summary>EFI Byte Code</summary>
        public const short IMAGE_FILE_MACHINE_EBC = 0x0EBC;
        /// <summary>AMD64 (K8)</summary>
        public const short IMAGE_FILE_MACHINE_AMD64 = unchecked((short)0x8664);
        /// <summary>M32R little-endian</summary>
        public const short IMAGE_FILE_MACHINE_M32R = unchecked((short)0x9041);
        /// <summary>ARM64 Little-Endian</summary>
        public const short IMAGE_FILE_MACHINE_ARM64 = unchecked((short)0xAA64);
        public const short IMAGE_FILE_MACHINE_CEE = unchecked((short)0xC0EE);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16424
        public const int IMAGE_NUMBEROF_DIRECTORY_ENTRIES = 16;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16522
        public const short IMAGE_NT_OPTIONAL_HDR32_MAGIC = 0x10b;
        public const short IMAGE_NT_OPTIONAL_HDR64_MAGIC = 0x20b;
        public const short IMAGE_ROM_OPTIONAL_HDR_MAGIC = 0x107;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16569
        // Subsystem Values

        /// <summary>Unknown subsystem.</summary>
        public const int IMAGE_SUBSYSTEM_UNKNOWN = 0;
        /// <summary>Image doesn't require a subsystem.</summary>
        public const int IMAGE_SUBSYSTEM_NATIVE = 1;
        /// <summary>Image runs in the Windows GUI subsystem.</summary>
        public const int IMAGE_SUBSYSTEM_WINDOWS_GUI = 2;
        /// <summary>Image runs in the Windows character subsystem.</summary>
        public const int IMAGE_SUBSYSTEM_WINDOWS_CUI = 3;
        /// <summary>image runs in the OS/2 character subsystem.</summary>
        public const int IMAGE_SUBSYSTEM_OS2_CUI = 5;
        /// <summary>image runs in the Posix character subsystem.</summary>
        public const int IMAGE_SUBSYSTEM_POSIX_CUI = 7;
        /// <summary>image is a native Win9x driver.</summary>
        public const int IMAGE_SUBSYSTEM_NATIVE_WINDOWS = 8;
        /// <summary>Image runs in the Windows CE subsystem.</summary>
        public const int IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = 9;
        public const int IMAGE_SUBSYSTEM_EFI_APPLICATION = 10;
        public const int IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER = 11;
        public const int IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER = 12;
        public const int IMAGE_SUBSYSTEM_EFI_ROM = 13;
        public const int IMAGE_SUBSYSTEM_XBOX = 14;
        public const int IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION = 16;
        public const int IMAGE_SUBSYSTEM_XBOX_CODE_CATALOG = 17;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16587
        // DllCharacteristics Entries

        /// <summary>Reserved.</summary>
        [Obsolete("Reserved.")]
        public const int IMAGE_LIBRARY_PROCESS_INIT = 0x0001;
        /// <summary>Reserved.</summary>
        [Obsolete("Reserved.")]
        public const int IMAGE_LIBRARY_PROCESS_TERM = 0x0002;
        /// <summary>Reserved.</summary>
        [Obsolete("Reserved.")]
        public const int IMAGE_LIBRARY_THREAD_INIT = 0x0004;
        /// <summary>Reserved.</summary>
        [Obsolete("Reserved.")]
        public const int IMAGE_LIBRARY_THREAD_TERM = 0x0008;
        /// <summary>Image can handle a high entropy 64-bit virtual address space.</summary>
        public const int IMAGE_DLLCHARACTERISTICS_HIGH_ENTROPY_VA = 0x0020;
        /// <summary>DLL can move.</summary>
        public const int IMAGE_DLLCHARACTERISTICS_DYNAMIC_BASE = 0x0040;
        /// <summary>Code Integrity Image</summary>
        public const int IMAGE_DLLCHARACTERISTICS_FORCE_INTEGRITY = 0x0080;
        /// <summary>Image is NX compatible</summary>
        public const int IMAGE_DLLCHARACTERISTICS_NX_COMPAT = 0x0100;
        /// <summary>Image understands isolation and doesn't want it</summary>
        public const int IMAGE_DLLCHARACTERISTICS_NO_ISOLATION = 0x0200;
        /// <summary>Image does not use SEH.  No SE handler may reside in this image</summary>
        public const int IMAGE_DLLCHARACTERISTICS_NO_SEH = 0x0400;
        /// <summary>Do not bind this image.</summary>
        public const int IMAGE_DLLCHARACTERISTICS_NO_BIND = 0x0800;
        /// <summary>Image should execute in an AppContainer</summary>
        public const int IMAGE_DLLCHARACTERISTICS_APPCONTAINER = 0x1000;
        /// <summary>Driver uses WDM model</summary>
        public const int IMAGE_DLLCHARACTERISTICS_WDM_DRIVER = 0x2000;
        /// <summary>Image supports Control Flow Guard.</summary>
        public const int IMAGE_DLLCHARACTERISTICS_GUARD_CF = 0x4000;
        public const int IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE = 0x8000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16605
        // Directory Entries

        /// <summary>Export Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_EXPORT = 0;
        /// <summary>Import Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_IMPORT = 1;
        /// <summary>Resource Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_RESOURCE = 2;
        /// <summary>Exception Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_EXCEPTION = 3;
        /// <summary>Security Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_SECURITY = 4;
        /// <summary>Base Relocation Table</summary>
        public const int IMAGE_DIRECTORY_ENTRY_BASERELOC = 5;
        /// <summary>Debug Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_DEBUG = 6;
        /// <summary>(X86 usage)</summary>
        public const int IMAGE_DIRECTORY_ENTRY_COPYRIGHT = 7;
        /// <summary>Architecture Specific Data</summary>
        public const int IMAGE_DIRECTORY_ENTRY_ARCHITECTURE = 7;
        /// <summary>RVA of GP</summary>
        public const int IMAGE_DIRECTORY_ENTRY_GLOBALPTR = 8;
        /// <summary>TLS Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_TLS = 9;
        /// <summary>Load Configuration Directory</summary>
        public const int IMAGE_DIRECTORY_ENTRY_LOAD_CONFIG = 10;
        /// <summary>Bound Import Directory in headers</summary>
        public const int IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT = 11;
        /// <summary>Import Address Table</summary>
        public const int IMAGE_DIRECTORY_ENTRY_IAT = 12;
        /// <summary>Delay Load Import Descriptors</summary>
        public const int IMAGE_DIRECTORY_ENTRY_DELAY_IMPORT = 13;
        /// <summary>COM Runtime descriptor</summary>
        public const int IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR = 14;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16674
        public const int IMAGE_SIZEOF_SHORT_NAME = 8;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16692
        public const int IMAGE_SIZEOF_SECTION_HEADER = 40;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16694
        //
        // Section characteristics.
        //
        /// <summary>Reserved.</summary>
        public const int IMAGE_SCN_TYPE_REG = 0x00000000;
        /// <summary>Reserved.</summary>
        public const int IMAGE_SCN_TYPE_DSECT = 0x00000001;
        /// <summary>Reserved.</summary>
        public const int IMAGE_SCN_TYPE_NOLOAD = 0x00000002;
        /// <summary>Reserved.</summary>
        public const int IMAGE_SCN_TYPE_GROUP = 0x00000004;
        /// <summary>Reserved.</summary>
        public const int IMAGE_SCN_TYPE_NO_PAD = 0x00000008;
        /// <summary>Reserved.</summary>
        public const int IMAGE_SCN_TYPE_COPY = 0x00000010;

        /// <summary>Section contains code.</summary>
        public const int IMAGE_SCN_CNT_CODE = 0x00000020;
        /// <summary>Section contains initialized data.</summary>
        public const int IMAGE_SCN_CNT_INITIALIZED_DATA = 0x00000040;
        /// <summary>Section contains uninitialized data.</summary>
        public const int IMAGE_SCN_CNT_UNINITIALIZED_DATA = 0x00000080;

        /// <summary>Reserved.</summary>
        public const int IMAGE_SCN_LNK_OTHER = 0x00000100;
        /// <summary>Section contains comments or some other type of information.</summary>
        public const int IMAGE_SCN_LNK_INFO = 0x00000200;
        /// <summary>Reserved.</summary>
        public const int IMAGE_SCN_TYPE_OVER = 0x00000400;
        /// <summary>Section contents will not become part of image.</summary>
        public const int IMAGE_SCN_LNK_REMOVE = 0x00000800;
        /// <summary>Section contents comdat.</summary>
        public const int IMAGE_SCN_LNK_COMDAT = 0x00001000;
        //                                           0x00002000  // Reserved.
        [Obsolete("Obsolete")]
        public const int IMAGE_SCN_MEM_PROTECTED = 0x00004000;
        /// <summary>Reset speculative exceptions handling bits in the TLB entries for this section.</summary>
        public const int IMAGE_SCN_NO_DEFER_SPEC_EXC = 0x00004000;
        /// <summary>Section content can be accessed relative to GP</summary>
        public const int IMAGE_SCN_GPREL = 0x00008000;
        public const int IMAGE_SCN_MEM_FARDATA = 0x00008000;
        [Obsolete("Obsolete")]
        public const int IMAGE_SCN_MEM_SYSHEAP = 0x00010000;
        public const int IMAGE_SCN_MEM_PURGEABLE = 0x00020000;
        public const int IMAGE_SCN_MEM_16BIT = 0x00020000;
        public const int IMAGE_SCN_MEM_LOCKED = 0x00040000;
        public const int IMAGE_SCN_MEM_PRELOAD = 0x00080000;

        public const int IMAGE_SCN_ALIGN_1BYTES = 0x00100000;
        public const int IMAGE_SCN_ALIGN_2BYTES = 0x00200000;
        public const int IMAGE_SCN_ALIGN_4BYTES = 0x00300000;
        public const int IMAGE_SCN_ALIGN_8BYTES = 0x00400000;
        /// <summary>Default alignment if no others are specified.</summary>
        public const int IMAGE_SCN_ALIGN_16BYTES = 0x00500000;
        public const int IMAGE_SCN_ALIGN_32BYTES = 0x00600000;
        public const int IMAGE_SCN_ALIGN_64BYTES = 0x00700000;
        public const int IMAGE_SCN_ALIGN_128BYTES = 0x00800000;
        public const int IMAGE_SCN_ALIGN_256BYTES = 0x00900000;
        public const int IMAGE_SCN_ALIGN_512BYTES = 0x00A00000;
        public const int IMAGE_SCN_ALIGN_1024BYTES = 0x00B00000;
        public const int IMAGE_SCN_ALIGN_2048BYTES = 0x00C00000;
        public const int IMAGE_SCN_ALIGN_4096BYTES = 0x00D00000;
        public const int IMAGE_SCN_ALIGN_8192BYTES = 0x00E00000;
        // Unused                                    0x00F00000
        public const int IMAGE_SCN_ALIGN_MASK = 0x00F00000;

        /// <summary>Section contains extended relocations.</summary>
        public const int IMAGE_SCN_LNK_NRELOC_OVFL = 0x01000000;
        /// <summary>Section can be discarded.</summary>
        public const int IMAGE_SCN_MEM_DISCARDABLE = 0x02000000;
        /// <summary>Section is not cachable.</summary>
        public const int IMAGE_SCN_MEM_NOT_CACHED = 0x04000000;
        /// <summary>Section is not pageable.</summary>
        public const int IMAGE_SCN_MEM_NOT_PAGED = 0x08000000;
        /// <summary>Section is shareable.</summary>
        public const int IMAGE_SCN_MEM_SHARED = 0x10000000;
        /// <summary>Section is executable.</summary>
        public const int IMAGE_SCN_MEM_EXECUTE = 0x20000000;
        /// <summary>Section is readable.</summary>
        public const int IMAGE_SCN_MEM_READ = 0x40000000;
        /// <summary>Section is writeable.</summary>
        public const int IMAGE_SCN_MEM_WRITE = unchecked((int)0x80000000);

        //
        // TLS Characteristic Flags
        //
        /// <summary>Tls index is scaled</summary>
        public const int IMAGE_SCN_SCALE_INDEX = 0x00000001;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16780
        public const int IMAGE_SIZEOF_SYMBOL = 18;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16799
        //
        // Section values.
        //
        // Symbols have a section number of the section in which they are
        // defined. Otherwise, section numbers have the following meanings:
        //

        /// <summary>Symbol is undefined or is common.</summary>
        public const short IMAGE_SYM_UNDEFINED = 0;
        /// <summary>Symbol is an absolute value.</summary>
        public const short IMAGE_SYM_ABSOLUTE = -1;
        /// <summary>Symbol is a special debug item.</summary>
        public const short IMAGE_SYM_DEBUG = -2;
        /// <summary>Values 0xFF00-0xFFFF are special</summary>
        public const short IMAGE_SYM_SECTION_MAX = unchecked((short)0xFEFF);
        public const int IMAGE_SYM_SECTION_MAX_EX = int.MaxValue;

        //
        // Type (fundamental) values.
        //

        /// <summary>no type.</summary>
        public const short IMAGE_SYM_TYPE_NULL = 0x0000;
        public const short IMAGE_SYM_TYPE_VOID = 0x0001;
        /// <summary>type character.</summary>
        public const short IMAGE_SYM_TYPE_CHAR = 0x0002;
        /// <summary>type short integer.</summary>
        public const short IMAGE_SYM_TYPE_SHORT = 0x0003;
        public const short IMAGE_SYM_TYPE_INT = 0x0004;
        public const short IMAGE_SYM_TYPE_LONG = 0x0005;
        public const short IMAGE_SYM_TYPE_FLOAT = 0x0006;
        public const short IMAGE_SYM_TYPE_DOUBLE = 0x0007;
        public const short IMAGE_SYM_TYPE_STRUCT = 0x0008;
        public const short IMAGE_SYM_TYPE_UNION = 0x0009;
        /// <summary>enumeration.</summary>
        public const short IMAGE_SYM_TYPE_ENUM = 0x000A;
        /// <summary>member of enumeration.</summary>
        public const short IMAGE_SYM_TYPE_MOE = 0x000B;
        public const short IMAGE_SYM_TYPE_BYTE = 0x000C;
        public const short IMAGE_SYM_TYPE_WORD = 0x000D;
        public const short IMAGE_SYM_TYPE_UINT = 0x000E;
        public const short IMAGE_SYM_TYPE_DWORD = 0x000F;
        public const short IMAGE_SYM_TYPE_PCODE = unchecked((short)0x8000);
        //
        // Type (derived) values.
        //

        /// <summary>no derived type.</summary>
        public const int IMAGE_SYM_DTYPE_NULL = 0;
        /// <summary>pointer.</summary>
        public const int IMAGE_SYM_DTYPE_POINTER = 1;
        /// <summary>function.</summary>
        public const int IMAGE_SYM_DTYPE_FUNCTION = 2;
        /// <summary>array.</summary>
        public const int IMAGE_SYM_DTYPE_ARRAY = 3;

        //
        // Storage classes.
        //
        public const byte IMAGE_SYM_CLASS_END_OF_FUNCTION = unchecked((byte)-1);
        public const byte IMAGE_SYM_CLASS_NULL = 0x0000;
        public const byte IMAGE_SYM_CLASS_AUTOMATIC = 0x0001;
        public const byte IMAGE_SYM_CLASS_EXTERNAL = 0x0002;
        public const byte IMAGE_SYM_CLASS_STATIC = 0x0003;
        public const byte IMAGE_SYM_CLASS_REGISTER = 0x0004;
        public const byte IMAGE_SYM_CLASS_EXTERNAL_DEF = 0x0005;
        public const byte IMAGE_SYM_CLASS_LABEL = 0x0006;
        public const byte IMAGE_SYM_CLASS_UNDEFINED_LABEL = 0x0007;
        public const byte IMAGE_SYM_CLASS_MEMBER_OF_STRUCT = 0x0008;
        public const byte IMAGE_SYM_CLASS_ARGUMENT = 0x0009;
        public const byte IMAGE_SYM_CLASS_STRUCT_TAG = 0x000A;
        public const byte IMAGE_SYM_CLASS_MEMBER_OF_UNION = 0x000B;
        public const byte IMAGE_SYM_CLASS_UNION_TAG = 0x000C;
        public const byte IMAGE_SYM_CLASS_TYPE_DEFINITION = 0x000D;
        public const byte IMAGE_SYM_CLASS_UNDEFINED_STATIC = 0x000E;
        public const byte IMAGE_SYM_CLASS_ENUM_TAG = 0x000F;
        public const byte IMAGE_SYM_CLASS_MEMBER_OF_ENUM = 0x0010;
        public const byte IMAGE_SYM_CLASS_REGISTER_PARAM = 0x0011;
        public const byte IMAGE_SYM_CLASS_BIT_FIELD = 0x0012;

        public const byte IMAGE_SYM_CLASS_FAR_EXTERNAL = 0x0044;

        public const byte IMAGE_SYM_CLASS_BLOCK = 0x0064;
        public const byte IMAGE_SYM_CLASS_FUNCTION = 0x0065;
        public const byte IMAGE_SYM_CLASS_END_OF_STRUCT = 0x0066;
        public const byte IMAGE_SYM_CLASS_FILE = 0x0067;
        // new
        public const byte IMAGE_SYM_CLASS_SECTION = 0x0068;
        public const byte IMAGE_SYM_CLASS_WEAK_EXTERNAL = 0x0069;

        public const byte IMAGE_SYM_CLASS_CLR_TOKEN = 0x006B;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16878
        // type packing constants

        public const short N_BTMASK = 0x000F;
        public const short N_TMASK = 0x0030;
        public const short N_TMASK1 = 0x00C0;
        public const short N_TMASK2 = 0x00F0;
        public const int N_BTSHFT = 4;
        public const int N_TSHIFT = 2;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17014
        //
        // Communal selection types.
        //

        public const int IMAGE_COMDAT_SELECT_NODUPLICATES = 1;
        public const int IMAGE_COMDAT_SELECT_ANY = 2;
        public const int IMAGE_COMDAT_SELECT_SAME_SIZE = 3;
        public const int IMAGE_COMDAT_SELECT_EXACT_MATCH = 4;
        public const int IMAGE_COMDAT_SELECT_ASSOCIATIVE = 5;
        public const int IMAGE_COMDAT_SELECT_LARGEST = 6;
        public const int IMAGE_COMDAT_SELECT_NEWEST = 7;

        public const int IMAGE_WEAK_EXTERN_SEARCH_NOLIBRARY = 1;
        public const int IMAGE_WEAK_EXTERN_SEARCH_LIBRARY = 2;
        public const int IMAGE_WEAK_EXTERN_SEARCH_ALIAS = 3;
        public const int IMAGE_WEAK_EXTERN_ANTI_DEPENDENCY = 4;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17045
        //
        // I386 relocation types.
        //
        /// <summary>Reference is absolute, no relocation is necessary</summary>
        public const short IMAGE_REL_I386_ABSOLUTE = 0x0000;
        /// <summary>Direct 16-bit reference to the symbols virtual address</summary>
        public const short IMAGE_REL_I386_DIR16 = 0x0001;
        /// <summary>PC-relative 16-bit reference to the symbols virtual address</summary>
        public const short IMAGE_REL_I386_REL16 = 0x0002;
        /// <summary>Direct 32-bit reference to the symbols virtual address</summary>
        public const short IMAGE_REL_I386_DIR32 = 0x0006;
        /// <summary>Direct 32-bit reference to the symbols virtual address, base not included</summary>
        public const short IMAGE_REL_I386_DIR32NB = 0x0007;
        /// <summary>Direct 16-bit reference to the segment-selector bits of a 32-bit virtual address</summary>
        public const short IMAGE_REL_I386_SEG12 = 0x0009;
        public const short IMAGE_REL_I386_SECTION = 0x000A;
        public const short IMAGE_REL_I386_SECREL = 0x000B;
        /// <summary>clr token</summary>
        public const short IMAGE_REL_I386_TOKEN = 0x000C;
        /// <summary>7 bit offset from base of section containing target</summary>
        public const short IMAGE_REL_I386_SECREL7 = 0x000D;
        /// <summary>PC-relative 32-bit reference to the symbols virtual address</summary>
        public const short IMAGE_REL_I386_REL32 = 0x0014;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17060
        //
        // MIPS relocation types.
        //
        /// <summary>Reference is absolute, no relocation is necessary</summary>
        public const short IMAGE_REL_MIPS_ABSOLUTE = 0x0000;
        public const short IMAGE_REL_MIPS_REFHALF = 0x0001;
        public const short IMAGE_REL_MIPS_REFWORD = 0x0002;
        public const short IMAGE_REL_MIPS_JMPADDR = 0x0003;
        public const short IMAGE_REL_MIPS_REFHI = 0x0004;
        public const short IMAGE_REL_MIPS_REFLO = 0x0005;
        public const short IMAGE_REL_MIPS_GPREL = 0x0006;
        public const short IMAGE_REL_MIPS_LITERAL = 0x0007;
        public const short IMAGE_REL_MIPS_SECTION = 0x000A;
        public const short IMAGE_REL_MIPS_SECREL = 0x000B;
        /// <summary>Low 16-bit section relative referemce (used for >32k TLS)</summary>
        public const short IMAGE_REL_MIPS_SECRELLO = 0x000C;
        /// <summary>High 16-bit section relative reference (used for >32k TLS)</summary>
        public const short IMAGE_REL_MIPS_SECRELHI = 0x000D;
        /// <summary>clr token</summary>
        public const short IMAGE_REL_MIPS_TOKEN = 0x000E;
        public const short IMAGE_REL_MIPS_JMPADDR16 = 0x0010;
        public const short IMAGE_REL_MIPS_REFWORDNB = 0x0022;
        /// <summary>C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17080</summary>
        public const short IMAGE_REL_MIPS_PAIR = 0x0025;

        //
        // Alpha Relocation types.
        //
        public const short IMAGE_REL_ALPHA_ABSOLUTE = 0x0000;
        public const short IMAGE_REL_ALPHA_REFLONG = 0x0001;
        public const short IMAGE_REL_ALPHA_REFQUAD = 0x0002;
        public const short IMAGE_REL_ALPHA_GPREL32 = 0x0003;
        public const short IMAGE_REL_ALPHA_LITERAL = 0x0004;
        public const short IMAGE_REL_ALPHA_LITUSE = 0x0005;
        public const short IMAGE_REL_ALPHA_GPDISP = 0x0006;
        public const short IMAGE_REL_ALPHA_BRADDR = 0x0007;
        public const short IMAGE_REL_ALPHA_HINT = 0x0008;
        public const short IMAGE_REL_ALPHA_INLINE_REFLONG = 0x0009;
        public const short IMAGE_REL_ALPHA_REFHI = 0x000A;
        public const short IMAGE_REL_ALPHA_REFLO = 0x000B;
        public const short IMAGE_REL_ALPHA_PAIR = 0x000C;
        public const short IMAGE_REL_ALPHA_MATCH = 0x000D;
        public const short IMAGE_REL_ALPHA_SECTION = 0x000E;
        public const short IMAGE_REL_ALPHA_SECREL = 0x000F;
        public const short IMAGE_REL_ALPHA_REFLONGNB = 0x0010;
        /// <summary>Low 16-bit section relative reference</summary>
        public const short IMAGE_REL_ALPHA_SECRELLO = 0x0011;
        /// <summary>High 16-bit section relative reference</summary>
        public const short IMAGE_REL_ALPHA_SECRELHI = 0x0012;
        /// <summary>High 16 bits of 48 bit reference</summary>
        public const short IMAGE_REL_ALPHA_REFQ3 = 0x0013;
        /// <summary>Middle 16 bits of 48 bit reference</summary>
        public const short IMAGE_REL_ALPHA_REFQ2 = 0x0014;
        /// <summary>Low 16 bits of 48 bit reference</summary>
        public const short IMAGE_REL_ALPHA_REFQ1 = 0x0015;
        /// <summary>Low 16-bit GP relative reference</summary>
        public const short IMAGE_REL_ALPHA_GPRELLO = 0x0016;
        /// <summary>High 16-bit GP relative reference</summary>
        public const short IMAGE_REL_ALPHA_GPRELHI = 0x0017;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17108
        //
        // IBM PowerPC relocation types.
        //
        /// <summary>NOP</summary>
        public const short IMAGE_REL_PPC_ABSOLUTE = 0x0000;
        /// <summary>64-bit address</summary>
        public const short IMAGE_REL_PPC_ADDR64 = 0x0001;
        /// <summary>32-bit address</summary>
        public const short IMAGE_REL_PPC_ADDR32 = 0x0002;
        /// <summary>26-bit address, shifted left 2 (branch absolute)</summary>
        public const short IMAGE_REL_PPC_ADDR24 = 0x0003;
        /// <summary>16-bit address</summary>
        public const short IMAGE_REL_PPC_ADDR16 = 0x0004;
        /// <summary>16-bit address, shifted left 2 (load doubleword)</summary>
        public const short IMAGE_REL_PPC_ADDR14 = 0x0005;
        /// <summary>26-bit PC-relative offset, shifted left 2 (branch relative)</summary>
        public const short IMAGE_REL_PPC_REL24 = 0x0006;
        /// <summary>16-bit PC-relative offset, shifted left 2 (br cond relative)</summary>
        public const short IMAGE_REL_PPC_REL14 = 0x0007;
        /// <summary>16-bit offset from TOC base</summary>
        public const short IMAGE_REL_PPC_TOCREL16 = 0x0008;
        /// <summary>16-bit offset from TOC base, shifted left 2 (load doubleword)</summary>
        public const short IMAGE_REL_PPC_TOCREL14 = 0x0009;

        /// <summary>32-bit addr w/o image base</summary>
        public const short IMAGE_REL_PPC_ADDR32NB = 0x000A;
        /// <summary>va of containing section (as in an image sectionhdr)</summary>
        public const short IMAGE_REL_PPC_SECREL = 0x000B;
        /// <summary>sectionheader number</summary>
        public const short IMAGE_REL_PPC_SECTION = 0x000C;
        /// <summary>substitute TOC restore instruction iff symbol is glue code</summary>
        public const short IMAGE_REL_PPC_IFGLUE = 0x000D;
        /// <summary>symbol is glue code; virtual address is TOC restore instruction</summary>
        public const short IMAGE_REL_PPC_IMGLUE = 0x000E;
        /// <summary>va of containing section (limited to 16 bits)</summary>
        public const short IMAGE_REL_PPC_SECREL16 = 0x000F;
        public const short IMAGE_REL_PPC_REFHI = 0x0010;
        public const short IMAGE_REL_PPC_REFLO = 0x0011;
        public const short IMAGE_REL_PPC_PAIR = 0x0012;
        /// <summary>Low 16-bit section relative reference (used for >32k TLS)</summary>
        public const short IMAGE_REL_PPC_SECRELLO = 0x0013;
        /// <summary>High 16-bit section relative reference (used for >32k TLS)</summary>
        public const short IMAGE_REL_PPC_SECRELHI = 0x0014;
        public const short IMAGE_REL_PPC_GPREL = 0x0015;
        /// <summary>clr token</summary>
        public const short IMAGE_REL_PPC_TOKEN = 0x0016;

        /// <summary>mask to isolate above values in IMAGE_RELOCATION.Type</summary>
        public const short IMAGE_REL_PPC_TYPEMASK = 0x00FF;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17138
        // Flag bits in IMAGE_RELOCATION.TYPE

        /// <summary>subtract reloc value rather than adding it</summary>
        public const short IMAGE_REL_PPC_NEG = 0x0100;
        /// <summary>fix branch prediction bit to predict branch taken</summary>
        public const short IMAGE_REL_PPC_BRTAKEN = 0x0200;
        /// <summary>fix branch prediction bit to predict branch not taken</summary>
        public const short IMAGE_REL_PPC_BRNTAKEN = 0x0400;
        /// <summary>toc slot defined in file (or, data in toc)</summary>
        public const short IMAGE_REL_PPC_TOCDEFN = 0x0800;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17145
        //
        // Hitachi SH3 relocation types.
        //
        /// <summary>No relocation</summary>
        public const short IMAGE_REL_SH3_ABSOLUTE = 0x0000;
        /// <summary>16 bit direct</summary>
        public const short IMAGE_REL_SH3_DIRECT16 = 0x0001;
        /// <summary>32 bit direct</summary>
        public const short IMAGE_REL_SH3_DIRECT32 = 0x0002;
        /// <summary>8 bit direct, -128..255</summary>
        public const short IMAGE_REL_SH3_DIRECT8 = 0x0003;
        /// <summary>8 bit direct .W (0 ext.)</summary>
        public const short IMAGE_REL_SH3_DIRECT8_WORD = 0x0004;
        /// <summary>8 bit direct .L (0 ext.)</summary>
        public const short IMAGE_REL_SH3_DIRECT8_LONG = 0x0005;
        /// <summary>4 bit direct (0 ext.)</summary>
        public const short IMAGE_REL_SH3_DIRECT4 = 0x0006;
        /// <summary>4 bit direct .W (0 ext.)</summary>
        public const short IMAGE_REL_SH3_DIRECT4_WORD = 0x0007;
        /// <summary>4 bit direct .L (0 ext.)</summary>
        public const short IMAGE_REL_SH3_DIRECT4_LONG = 0x0008;
        /// <summary>8 bit PC relative .W</summary>
        public const short IMAGE_REL_SH3_PCREL8_WORD = 0x0009;
        /// <summary>8 bit PC relative .L</summary>
        public const short IMAGE_REL_SH3_PCREL8_LONG = 0x000A;
        /// <summary>12 LSB PC relative .W</summary>
        public const short IMAGE_REL_SH3_PCREL12_WORD = 0x000B;
        /// <summary>Start of EXE section</summary>
        public const short IMAGE_REL_SH3_STARTOF_SECTION = 0x000C;
        /// <summary>Size of EXE section</summary>
        public const short IMAGE_REL_SH3_SIZEOF_SECTION = 0x000D;
        /// <summary>Section table index</summary>
        public const short IMAGE_REL_SH3_SECTION = 0x000E;
        /// <summary>Offset within section</summary>
        public const short IMAGE_REL_SH3_SECREL = 0x000F;
        /// <summary>32 bit direct not based</summary>
        public const short IMAGE_REL_SH3_DIRECT32_NB = 0x0010;
        /// <summary>GP-relative addressing</summary>
        public const short IMAGE_REL_SH3_GPREL4_LONG = 0x0011;
        /// <summary>clr token</summary>
        public const short IMAGE_REL_SH3_TOKEN = 0x0012;
        /// <summary>
        /// Offset from current
        /// instruction in longwords
        /// if not NOMODE, insert the
        /// inverse of the low bit at
        /// bit 32 to select PTA/PTB
        /// </summary>
        public const short IMAGE_REL_SHM_PCRELPT = 0x0013;
        /// <summary>Low bits of 32-bit address</summary>
        public const short IMAGE_REL_SHM_REFLO = 0x0014;
        /// <summary>High bits of 32-bit address</summary>
        public const short IMAGE_REL_SHM_REFHALF = 0x0015;
        /// <summary>Low bits of relative reference</summary>
        public const short IMAGE_REL_SHM_RELLO = 0x0016;
        /// <summary>High bits of relative reference</summary>
        public const short IMAGE_REL_SHM_RELHALF = 0x0017;
        /// <summary>offset operand for relocation</summary>
        public const short IMAGE_REL_SHM_PAIR = 0x0018;

        /// <summary>relocation ignores section mode</summary>
        public const short IMAGE_REL_SH_NOMODE = unchecked((short)0x8000);


        /// <summary>No relocation required</summary>
        public const short IMAGE_REL_ARM_ABSOLUTE = 0x0000;
        /// <summary>32 bit address</summary>
        public const short IMAGE_REL_ARM_ADDR32 = 0x0001;
        /// <summary>32 bit address w/o image base</summary>
        public const short IMAGE_REL_ARM_ADDR32NB = 0x0002;
        /// <summary>24 bit offset &lt;&lt; 2 &amp; sign ext.</summary>
        public const short IMAGE_REL_ARM_BRANCH24 = 0x0003;
        /// <summary>Thumb: 2 11 bit offsets</summary>
        public const short IMAGE_REL_ARM_BRANCH11 = 0x0004;
        /// <summary>clr token</summary>
        public const short IMAGE_REL_ARM_TOKEN = 0x0005;
        /// <summary>GP-relative addressing (ARM)</summary>
        public const short IMAGE_REL_ARM_GPREL12 = 0x0006;
        /// <summary>GP-relative addressing (Thumb)</summary>
        public const short IMAGE_REL_ARM_GPREL7 = 0x0007;
        public const short IMAGE_REL_ARM_BLX24 = 0x0008;
        public const short IMAGE_REL_ARM_BLX11 = 0x0009;
        /// <summary>Section table index</summary>
        public const short IMAGE_REL_ARM_SECTION = 0x000E;
        /// <summary>Offset within section</summary>
        public const short IMAGE_REL_ARM_SECREL = 0x000F;
        /// <summary>ARM: MOVW/MOVT</summary>
        public const short IMAGE_REL_ARM_MOV32A = 0x0010;
        /// <summary>ARM: MOVW/MOVT (deprecated)</summary>
        public const short IMAGE_REL_ARM_MOV32 = 0x0010;
        /// <summary>Thumb: MOVW/MOVT</summary>
        public const short IMAGE_REL_ARM_MOV32T = 0x0011;
        /// <summary>Thumb: MOVW/MOVT (deprecated)</summary>
        public const short IMAGE_REL_THUMB_MOV32 = 0x0011;
        /// <summary>Thumb: 32-bit conditional B</summary>
        public const short IMAGE_REL_ARM_BRANCH20T = 0x0012;
        /// <summary>Thumb: 32-bit conditional B (deprecated)</summary>
        public const short IMAGE_REL_THUMB_BRANCH20 = 0x0012;
        /// <summary>Thumb: 32-bit B or BL</summary>
        public const short IMAGE_REL_ARM_BRANCH24T = 0x0014;
        /// <summary>Thumb: 32-bit B or BL (deprecated)</summary>
        public const short IMAGE_REL_THUMB_BRANCH24 = 0x0014;
        /// <summary>Thumb: BLX immediate</summary>
        public const short IMAGE_REL_ARM_BLX23T = 0x0015;
        /// <summary>Thumb: BLX immediate (deprecated)</summary>
        public const short IMAGE_REL_THUMB_BLX23 = 0x0015;

        public const short IMAGE_REL_AM_ABSOLUTE = 0x0000;
        public const short IMAGE_REL_AM_ADDR32 = 0x0001;
        public const short IMAGE_REL_AM_ADDR32NB = 0x0002;
        public const short IMAGE_REL_AM_CALL32 = 0x0003;
        public const short IMAGE_REL_AM_FUNCINFO = 0x0004;
        public const short IMAGE_REL_AM_REL32_1 = 0x0005;
        public const short IMAGE_REL_AM_REL32_2 = 0x0006;
        public const short IMAGE_REL_AM_SECREL = 0x0007;
        public const short IMAGE_REL_AM_SECTION = 0x0008;
        public const short IMAGE_REL_AM_TOKEN = 0x0009;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17215
        //
        // ARM64 relocations types.
        //

        /// <summary>No relocation required</summary>
        public const short IMAGE_REL_ARM64_ABSOLUTE = 0x0000;
        /// <summary>32 bit address. Review! do we need it?</summary>
        public const short IMAGE_REL_ARM64_ADDR32 = 0x0001;
        /// <summary>32 bit address w/o image base (RVA: for Data/PData/XData)</summary>
        public const short IMAGE_REL_ARM64_ADDR32NB = 0x0002;
        /// <summary>26 bit offset &lt;&lt; 2 &amp; sign ext. for B &amp; BL</summary>
        public const short IMAGE_REL_ARM64_BRANCH26 = 0x0003;
        /// <summary>ADRP</summary>
        public const short IMAGE_REL_ARM64_PAGEBASE_REL21 = 0x0004;
        /// <summary>ADR</summary>
        public const short IMAGE_REL_ARM64_REL21 = 0x0005;
        /// <summary>ADD/ADDS (immediate) with zero shift, for page offset</summary>
        public const short IMAGE_REL_ARM64_PAGEOFFSET_12A = 0x0006;
        /// <summary>LDR (indexed, unsigned immediate), for page offset</summary>
        public const short IMAGE_REL_ARM64_PAGEOFFSET_12L = 0x0007;
        /// <summary>Offset within section</summary>
        public const short IMAGE_REL_ARM64_SECREL = 0x0008;
        /// <summary>ADD/ADDS (immediate) with zero shift, for bit 0:11 of section offset</summary>
        public const short IMAGE_REL_ARM64_SECREL_LOW12A = 0x0009;
        /// <summary>ADD/ADDS (immediate) with zero shift, for bit 12:23 of section offset</summary>
        public const short IMAGE_REL_ARM64_SECREL_HIGH12A = 0x000A;
        /// <summary>LDR (indexed, unsigned immediate), for bit 0:11 of section offset</summary>
        public const short IMAGE_REL_ARM64_SECREL_LOW12L = 0x000B;
        public const short IMAGE_REL_ARM64_TOKEN = 0x000C;
        /// <summary>Section table index</summary>
        public const short IMAGE_REL_ARM64_SECTION = 0x000D;
        /// <summary>64 bit address</summary>
        public const short IMAGE_REL_ARM64_ADDR64 = 0x000E;
        /// <summary>19 bit offset &lt;&lt; 2 &amp; sign ext. for conditional B</summary>
        public const short IMAGE_REL_ARM64_BRANCH19 = 0x000F;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17236
        //
        // x64 relocations
        //
        /// <summary>Reference is absolute, no relocation is necessary</summary>
        public const short IMAGE_REL_AMD64_ABSOLUTE = 0x0000;
        /// <summary>64-bit address (VA).</summary>
        public const short IMAGE_REL_AMD64_ADDR64 = 0x0001;
        /// <summary>32-bit address (VA).</summary>
        public const short IMAGE_REL_AMD64_ADDR32 = 0x0002;
        /// <summary>32-bit address w/o image base (RVA).</summary>
        public const short IMAGE_REL_AMD64_ADDR32NB = 0x0003;
        /// <summary>32-bit relative address from byte following reloc</summary>
        public const short IMAGE_REL_AMD64_REL32 = 0x0004;
        /// <summary>32-bit relative address from byte distance 1 from reloc</summary>
        public const short IMAGE_REL_AMD64_REL32_1 = 0x0005;
        /// <summary>32-bit relative address from byte distance 2 from reloc</summary>
        public const short IMAGE_REL_AMD64_REL32_2 = 0x0006;
        /// <summary>32-bit relative address from byte distance 3 from reloc</summary>
        public const short IMAGE_REL_AMD64_REL32_3 = 0x0007;
        /// <summary>32-bit relative address from byte distance 4 from reloc</summary>
        public const short IMAGE_REL_AMD64_REL32_4 = 0x0008;
        /// <summary>32-bit relative address from byte distance 5 from reloc</summary>
        public const short IMAGE_REL_AMD64_REL32_5 = 0x0009;
        /// <summary>Section index</summary>
        public const short IMAGE_REL_AMD64_SECTION = 0x000A;
        /// <summary>32 bit offset from base of section containing target</summary>
        public const short IMAGE_REL_AMD64_SECREL = 0x000B;
        /// <summary>7 bit unsigned offset from base of section containing target</summary>
        public const short IMAGE_REL_AMD64_SECREL7 = 0x000C;
        /// <summary>32 bit metadata token</summary>
        public const short IMAGE_REL_AMD64_TOKEN = 0x000D;
        /// <summary>32 bit signed span-dependent value emitted into object</summary>
        public const short IMAGE_REL_AMD64_SREL32 = 0x000E;
        public const short IMAGE_REL_AMD64_PAIR = 0x000F;
        /// <summary>32 bit signed span-dependent value applied at link time</summary>
        public const short IMAGE_REL_AMD64_SSPAN32 = 0x0010;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17257
        //
        // IA64 relocation types.
        //
        public const short IMAGE_REL_IA64_ABSOLUTE = 0x0000;
        public const short IMAGE_REL_IA64_IMM14 = 0x0001;
        public const short IMAGE_REL_IA64_IMM22 = 0x0002;
        public const short IMAGE_REL_IA64_IMM64 = 0x0003;
        public const short IMAGE_REL_IA64_DIR32 = 0x0004;
        public const short IMAGE_REL_IA64_DIR64 = 0x0005;
        public const short IMAGE_REL_IA64_PCREL21B = 0x0006;
        public const short IMAGE_REL_IA64_PCREL21M = 0x0007;
        public const short IMAGE_REL_IA64_PCREL21F = 0x0008;
        public const short IMAGE_REL_IA64_GPREL22 = 0x0009;
        public const short IMAGE_REL_IA64_LTOFF22 = 0x000A;
        public const short IMAGE_REL_IA64_SECTION = 0x000B;
        public const short IMAGE_REL_IA64_SECREL22 = 0x000C;
        public const short IMAGE_REL_IA64_SECREL64I = 0x000D;
        //
        public const short IMAGE_REL_IA64_DIR32NB = 0x0010;
        public const short IMAGE_REL_IA64_SECREL32 = 0x000E;
        public const short IMAGE_REL_IA64_SREL14 = 0x0011;
        public const short IMAGE_REL_IA64_SREL22 = 0x0012;
        public const short IMAGE_REL_IA64_SREL32 = 0x0013;
        public const short IMAGE_REL_IA64_UREL32 = 0x0014;
        /// <summary>This is always a BRL and never converted</summary>
        public const short IMAGE_REL_IA64_PCREL60X = 0x0015;
        /// <summary>If possible, convert to MBB bundle with NOP.B in slot 1</summary>
        public const short IMAGE_REL_IA64_PCREL60B = 0x0016;
        /// <summary>If possible, convert to MFB bundle with NOP.F in slot 1</summary>
        public const short IMAGE_REL_IA64_PCREL60F = 0x0017;
        /// <summary>If possible, convert to MIB bundle with NOP.I in slot 1</summary>
        public const short IMAGE_REL_IA64_PCREL60I = 0x0018;
        /// <summary>If possible, convert to MMB bundle with NOP.M in slot 1</summary>
        public const short IMAGE_REL_IA64_PCREL60M = 0x0019;
        public const short IMAGE_REL_IA64_IMMGPREL64 = 0x001A;
        /// <summary>clr token</summary>
        public const short IMAGE_REL_IA64_TOKEN = 0x001B;
        public const short IMAGE_REL_IA64_GPREL32 = 0x001C;
        /// <summary>C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17291</summary>
        public const short IMAGE_REL_IA64_ADDEND = 0x001F;
        //
        // CEF relocation types.
        //
        /// <summary>Reference is absolute, no relocation is necessary</summary>
        public const short IMAGE_REL_CEF_ABSOLUTE = 0x0000;
        /// <summary>32-bit address (VA).</summary>
        public const short IMAGE_REL_CEF_ADDR32 = 0x0001;
        /// <summary>64-bit address (VA).</summary>
        public const short IMAGE_REL_CEF_ADDR64 = 0x0002;
        /// <summary>32-bit address w/o image base (RVA).</summary>
        public const short IMAGE_REL_CEF_ADDR32NB = 0x0003;
        /// <summary>Section index</summary>
        public const short IMAGE_REL_CEF_SECTION = 0x0004;
        /// <summary>32 bit offset from base of section containing target</summary>
        public const short IMAGE_REL_CEF_SECREL = 0x0005;
        /// <summary>32 bit metadata token</summary>
        public const short IMAGE_REL_CEF_TOKEN = 0x0006;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17302
        //
        // clr relocation types.
        //
        /// <summary>Reference is absolute, no relocation is necessary</summary>
        public const short IMAGE_REL_CEE_ABSOLUTE = 0x0000;
        /// <summary>32-bit address (VA).</summary>
        public const short IMAGE_REL_CEE_ADDR32 = 0x0001;
        /// <summary>64-bit address (VA).</summary>
        public const short IMAGE_REL_CEE_ADDR64 = 0x0002;
        /// <summary>32-bit address w/o image base (RVA).</summary>
        public const short IMAGE_REL_CEE_ADDR32NB = 0x0003;
        /// <summary>Section index</summary>
        public const short IMAGE_REL_CEE_SECTION = 0x0004;
        /// <summary>32 bit offset from base of section containing target</summary>
        public const short IMAGE_REL_CEE_SECREL = 0x0005;
        /// <summary>32 bit metadata token</summary>
        public const short IMAGE_REL_CEE_TOKEN = 0x0006;


        /// <summary>No relocation required</summary>
        public const short IMAGE_REL_M32R_ABSOLUTE = 0x0000;
        /// <summary>32 bit address</summary>
        public const short IMAGE_REL_M32R_ADDR32 = 0x0001;
        /// <summary>32 bit address w/o image base</summary>
        public const short IMAGE_REL_M32R_ADDR32NB = 0x0002;
        /// <summary>24 bit address</summary>
        public const short IMAGE_REL_M32R_ADDR24 = 0x0003;
        /// <summary>GP relative addressing</summary>
        public const short IMAGE_REL_M32R_GPREL16 = 0x0004;
        /// <summary>24 bit offset &lt;&lt; 2 &amp; sign ext.</summary>
        public const short IMAGE_REL_M32R_PCREL24 = 0x0005;
        /// <summary>16 bit offset &lt;&lt; 2 &amp; sign ext.</summary>
        public const short IMAGE_REL_M32R_PCREL16 = 0x0006;
        /// <summary>8 bit offset &lt;&lt; 2 &amp; sign ext.</summary>
        public const short IMAGE_REL_M32R_PCREL8 = 0x0007;
        /// <summary>16 MSBs</summary>
        public const short IMAGE_REL_M32R_REFHALF = 0x0008;
        /// <summary>16 MSBs; adj for LSB sign ext.</summary>
        public const short IMAGE_REL_M32R_REFHI = 0x0009;
        /// <summary>16 LSBs</summary>
        public const short IMAGE_REL_M32R_REFLO = 0x000A;
        /// <summary>Link HI and LO</summary>
        public const short IMAGE_REL_M32R_PAIR = 0x000B;
        /// <summary>Section table index</summary>
        public const short IMAGE_REL_M32R_SECTION = 0x000C;
        /// <summary>32 bit section relative reference</summary>
        public const short IMAGE_REL_M32R_SECREL32 = 0x000D;
        /// <summary>clr token</summary>
        public const short IMAGE_REL_M32R_TOKEN = 0x000E;

        /// <summary>No relocation required</summary>
        public const short IMAGE_REL_EBC_ABSOLUTE = 0x0000;
        /// <summary>32 bit address w/o image base</summary>
        public const short IMAGE_REL_EBC_ADDR32NB = 0x0001;
        /// <summary>32-bit relative address from byte following reloc</summary>
        public const short IMAGE_REL_EBC_REL32 = 0x0002;
        /// <summary>Section table index</summary>
        public const short IMAGE_REL_EBC_SECTION = 0x0003;
        /// <summary>Offset within section</summary>
        public const short IMAGE_REL_EBC_SECREL = 0x0004;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17343
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM7B_INST_WORD_X = 3;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM7B_SIZE_X = 7;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM7B_INST_WORD_POS_X = 4;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM7B_VAL_POS_X = 0;

        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM9D_INST_WORD_X = 3;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM9D_SIZE_X = 9;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM9D_INST_WORD_POS_X = 18;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM9D_VAL_POS_X = 7;

        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM5C_INST_WORD_X = 3;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM5C_SIZE_X = 5;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM5C_INST_WORD_POS_X = 13;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM5C_VAL_POS_X = 16;

        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IC_INST_WORD_X = 3;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IC_SIZE_X = 1;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IC_INST_WORD_POS_X = 12;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IC_VAL_POS_X = 21;

        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM41a_INST_WORD_X = 1;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM41a_SIZE_X = 10;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM41a_INST_WORD_POS_X = 14;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM41a_VAL_POS_X = 22;

        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM41b_INST_WORD_X = 1;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM41b_SIZE_X = 8;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM41b_INST_WORD_POS_X = 24;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM41b_VAL_POS_X = 32;

        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM41c_INST_WORD_X = 2;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM41c_SIZE_X = 23;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM41c_INST_WORD_POS_X = 0;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_IMM41c_VAL_POS_X = 40;

        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_SIGN_INST_WORD_X = 3;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_SIGN_SIZE_X = 1;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_SIGN_INST_WORD_POS_X = 27;
        /// <summary>Intel-IA64-Filler</summary>
        public const int EMARCH_ENC_I17_SIGN_VAL_POS_X = 63;

        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_OPCODE_INST_WORD_X = 3;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_OPCODE_SIZE_X = 4;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_OPCODE_INST_WORD_POS_X = 28;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_OPCODE_SIGN_VAL_POS_X = 0;

        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_I_INST_WORD_X = 3;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_I_SIZE_X = 1;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_I_INST_WORD_POS_X = 27;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_I_SIGN_VAL_POS_X = 59;

        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_D_WH_INST_WORD_X = 3;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_D_WH_SIZE_X = 3;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_D_WH_INST_WORD_POS_X = 24;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_D_WH_SIGN_VAL_POS_X = 0;

        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_IMM20_INST_WORD_X = 3;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_IMM20_SIZE_X = 20;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_IMM20_INST_WORD_POS_X = 4;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_IMM20_SIGN_VAL_POS_X = 0;

        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_IMM39_1_INST_WORD_X = 2;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_IMM39_1_SIZE_X = 23;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_IMM39_1_INST_WORD_POS_X = 0;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_IMM39_1_SIGN_VAL_POS_X = 36;

        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_IMM39_2_INST_WORD_X = 1;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_IMM39_2_SIZE_X = 16;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_IMM39_2_INST_WORD_POS_X = 16;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_IMM39_2_SIGN_VAL_POS_X = 20;

        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_P_INST_WORD_X = 3;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_P_SIZE_X = 4;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_P_INST_WORD_POS_X = 0;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_P_SIGN_VAL_POS_X = 0;

        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_TMPLT_INST_WORD_X = 0;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_TMPLT_SIZE_X = 4;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_TMPLT_INST_WORD_POS_X = 0;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_TMPLT_SIGN_VAL_POS_X = 0;

        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_BTYPE_QP_INST_WORD_X = 2;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_BTYPE_QP_SIZE_X = 9;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_BTYPE_QP_INST_WORD_POS_X = 23;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_BTYPE_QP_INST_VAL_POS_X = 0;

        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_EMPTY_INST_WORD_X = 1;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_EMPTY_SIZE_X = 2;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_EMPTY_INST_WORD_POS_X = 14;
        /// <summary>Intel-IA64-Filler</summary>
        public const int X3_EMPTY_INST_VAL_POS_X = 0;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17461
        //
        // Based relocation types.
        //

        public const int IMAGE_REL_BASED_ABSOLUTE = 0;
        public const int IMAGE_REL_BASED_HIGH = 1;
        public const int IMAGE_REL_BASED_LOW = 2;
        public const int IMAGE_REL_BASED_HIGHLOW = 3;
        public const int IMAGE_REL_BASED_HIGHADJ = 4;
        public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_5 = 5;
        public const int IMAGE_REL_BASED_RESERVED = 6;
        public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_7 = 7;
        public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_8 = 8;
        public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_9 = 9;
        public const int IMAGE_REL_BASED_DIR64 = 10;

        //
        // Platform-specific based relocation types.
        //

        public const int IMAGE_REL_BASED_IA64_IMM64 = 9;

        public const int IMAGE_REL_BASED_MIPS_JMPADDR = 5;
        public const int IMAGE_REL_BASED_MIPS_JMPADDR16 = 9;

        public const int IMAGE_REL_BASED_ARM_MOV32 = 5;
        public const int IMAGE_REL_BASED_THUMB_MOV32 = 7;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17490
        //
        // Archive format.
        //

        public const int IMAGE_ARCHIVE_START_SIZE = 8;
        public const string IMAGE_ARCHIVE_START = "!<arch>\n";
        public const string IMAGE_ARCHIVE_END = "`\n";
        public const string IMAGE_ARCHIVE_PAD = "\n";
        public const string IMAGE_ARCHIVE_LINKER_MEMBER = "/               ";
        public const string IMAGE_ARCHIVE_LONGNAMES_MEMBER = "//              ";
        public const string IMAGE_ARCHIVE_HYBRIDMAP_MEMBER = "/<HYBRIDMAP>/   ";

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17513
        public const int IMAGE_SIZEOF_ARCHIVE_MEMBER_HDR = 60;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17570
        public const long IMAGE_ORDINAL_FLAG64 = unchecked((long)0x8000000000000000);
        public const int IMAGE_ORDINAL_FLAG32 = unchecked((int)0x80000000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17726
        public const int IMAGE_RESOURCE_NAME_IS_STRING = unchecked((int)0x80000000);
        public const int IMAGE_RESOURCE_DATA_IS_DIRECTORY = unchecked((int)0x80000000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17726
        public const int IMAGE_DYNAMIC_RELOCATION_GUARD_RF_PROLOGUE = 0x00000001;
        public const int IMAGE_DYNAMIC_RELOCATION_GUARD_RF_EPILOGUE = 0x00000002;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18030
        public const int IMAGE_HOT_PATCH_BASE_OBLIGATORY = 0x00000001;

        public const int IMAGE_HOT_PATCH_CHUNK_INVERSE = unchecked((int)0x80000000);
        public const int IMAGE_HOT_PATCH_CHUNK_OBLIGATORY = 0x40000000;
        public const int IMAGE_HOT_PATCH_CHUNK_RESERVED = 0x3FF03000;
        public const int IMAGE_HOT_PATCH_CHUNK_TYPE = 0x000FC000;
        public const int IMAGE_HOT_PATCH_CHUNK_SOURCE_RVA = 0x00008000;
        public const int IMAGE_HOT_PATCH_CHUNK_TARGET_RVA = 0x00004000;
        public const int IMAGE_HOT_PATCH_CHUNK_SIZE = 0x00000FFF;

        public const int IMAGE_HOT_PATCH_NONE = 0x00000000;
        public const int IMAGE_HOT_PATCH_FUNCTION = 0x0001C000;
        public const int IMAGE_HOT_PATCH_ABSOLUTE = 0x0002C000;
        public const int IMAGE_HOT_PATCH_REL32 = 0x0003C000;
        public const int IMAGE_HOT_PATCH_CALL_TARGET = 0x00044000;
        public const int IMAGE_HOT_PATCH_INDIRECT = 0x0005C000;
        public const int IMAGE_HOT_PATCH_NO_CALL_TARGET = 0x00064000;
        public const int IMAGE_HOT_PATCH_DYNAMIC_VALUE = 0x00078000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18049
        /// <summary>Module performs control flow integrity checks using system-supplied support</summary>
        public const int IMAGE_GUARD_CF_INSTRUMENTED = 0x00000100;
        /// <summary>Module performs control flow and write integrity checks</summary>
        public const int IMAGE_GUARD_CFW_INSTRUMENTED = 0x00000200;
        /// <summary>Module contains valid control flow target metadata</summary>
        public const int IMAGE_GUARD_CF_FUNCTION_TABLE_PRESENT = 0x00000400;
        /// <summary>Module does not make use of the /GS security cookie</summary>
        public const int IMAGE_GUARD_SECURITY_COOKIE_UNUSED = 0x00000800;
        /// <summary>Module supports read only delay load IAT</summary>
        public const int IMAGE_GUARD_PROTECT_DELAYLOAD_IAT = 0x00001000;
        /// <summary>Delayload import table in its own .didat section (with nothing else in it) that can be freely reprotected</summary>
        public const int IMAGE_GUARD_DELAYLOAD_IAT_IN_ITS_OWN_SECTION = 0x00002000;
        /// <summary>
        /// Module contains suppressed export information. This also infers that the address
        /// taken IAT table is also present in the load config.
        /// </summary>
        public const int IMAGE_GUARD_CF_EXPORT_SUPPRESSION_INFO_PRESENT = 0x00004000;
        /// <summary>Module enables suppression of exports</summary>
        public const int IMAGE_GUARD_CF_ENABLE_EXPORT_SUPPRESSION = 0x00008000;
        /// <summary>Module contains longjmp target information</summary>
        public const int IMAGE_GUARD_CF_LONGJUMP_TABLE_PRESENT = 0x00010000;
        /// <summary>Module contains return flow instrumentation and metadata</summary>
        public const int IMAGE_GUARD_RF_INSTRUMENTED = 0x00020000;
        /// <summary>Module requests that the OS enable return flow protection</summary>
        public const int IMAGE_GUARD_RF_ENABLE = 0x00040000;
        /// <summary>Module requests that the OS enable return flow protection in strict mode</summary>
        public const int IMAGE_GUARD_RF_STRICT = 0x00080000;
        /// <summary>Stride of Guard CF function table encoded in these bits (additional count of bytes per element)</summary>
        public const int IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_MASK = unchecked((int)0xF0000000);
        /// <summary>Shift to right-justify Guard CF function table stride</summary>
        public const int IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_SHIFT = 28;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18065
        //
        // GFIDS table entry flags.
        //

        /// <summary>The containing GFID entry is suppressed</summary>
        public const int IMAGE_GUARD_FLAG_FID_SUPPRESSED = 0x01;
        /// <summary>The containing GFID entry is export suppressed</summary>
        public const int IMAGE_GUARD_FLAG_EXPORT_SUPPRESSED = 0x02;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18184
        public const int IMAGE_ENCLAVE_LONG_ID_LENGTH = 32;
        public const int IMAGE_ENCLAVE_SHORT_ID_LENGTH = 16;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18229
        public const int IMAGE_ENCLAVE_POLICY_DEBUGGABLE = 0x00000001;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18231
        public const int IMAGE_ENCLAVE_FLAG_PRIMARY_IMAGE = 0x00000001;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18243
        public const int IMAGE_ENCLAVE_IMPORT_MATCH_NONE = 0x00000000;
        public const int IMAGE_ENCLAVE_IMPORT_MATCH_UNIQUE_ID = 0x00000001;
        public const int IMAGE_ENCLAVE_IMPORT_MATCH_AUTHOR_ID = 0x00000002;
        public const int IMAGE_ENCLAVE_IMPORT_MATCH_FAMILY_ID = 0x00000003;
        public const int IMAGE_ENCLAVE_IMPORT_MATCH_IMAGE_ID = 0x00000004;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18264
        public const int IMAGE_DEBUG_TYPE_UNKNOWN = 0;
        public const int IMAGE_DEBUG_TYPE_COFF = 1;
        public const int IMAGE_DEBUG_TYPE_CODEVIEW = 2;
        public const int IMAGE_DEBUG_TYPE_FPO = 3;
        public const int IMAGE_DEBUG_TYPE_MISC = 4;
        public const int IMAGE_DEBUG_TYPE_EXCEPTION = 5;
        public const int IMAGE_DEBUG_TYPE_FIXUP = 6;
        public const int IMAGE_DEBUG_TYPE_OMAP_TO_SRC = 7;
        public const int IMAGE_DEBUG_TYPE_OMAP_FROM_SRC = 8;
        public const int IMAGE_DEBUG_TYPE_BORLAND = 9;
        public const int IMAGE_DEBUG_TYPE_RESERVED10 = 10;
        public const int IMAGE_DEBUG_TYPE_CLSID = 11;
        public const int IMAGE_DEBUG_TYPE_VC_FEATURE = 12;
        public const int IMAGE_DEBUG_TYPE_POGO = 13;
        public const int IMAGE_DEBUG_TYPE_ILTCG = 14;
        public const int IMAGE_DEBUG_TYPE_MPX = 15;
        public const int IMAGE_DEBUG_TYPE_REPRO = 16;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18294
        public const short FRAME_FPO = 0;
        public const short FRAME_TRAP = 1;
        public const short FRAME_TSS = 2;
        public const short FRAME_NONFPO = 3;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18311
        public const int SIZEOF_RFPO_DATA = 16;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18314
        public const int IMAGE_DEBUG_MISC_EXENAME = 1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18409
        public const short IMAGE_SEPARATE_DEBUG_FLAGS_MASK = unchecked((short)0x8000);
        /// <summary>
        /// when DBG was updated, the
        /// old checksum didn't match.
        /// </summary>
        public const short IMAGE_SEPARATE_DEBUG_MISMATCH = unchecked((short)0x8000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18442
        public const short IMPORT_OBJECT_HDR_SIG2 = unchecked((short)0xffff);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19348
        //
        // Fast fail failure codes.
        //
        // N.B.  Failure code zero should not be used, but is required to be reserved
        //       for compatibility with previous handling of the
        //       STATUS_STACK_BUFFER_OVERRUN exception status code.
        //

        public const int FAST_FAIL_LEGACY_GS_VIOLATION = 0;
        public const int FAST_FAIL_VTGUARD_CHECK_FAILURE = 1;
        public const int FAST_FAIL_STACK_COOKIE_CHECK_FAILURE = 2;
        public const int FAST_FAIL_CORRUPT_LIST_ENTRY = 3;
        public const int FAST_FAIL_INCORRECT_STACK = 4;
        public const int FAST_FAIL_INVALID_ARG = 5;
        public const int FAST_FAIL_GS_COOKIE_INIT = 6;
        public const int FAST_FAIL_FATAL_APP_EXIT = 7;
        public const int FAST_FAIL_RANGE_CHECK_FAILURE = 8;
        public const int FAST_FAIL_UNSAFE_REGISTRY_ACCESS = 9;
        public const int FAST_FAIL_GUARD_ICALL_CHECK_FAILURE = 10;
        public const int FAST_FAIL_GUARD_WRITE_CHECK_FAILURE = 11;
        public const int FAST_FAIL_INVALID_FIBER_SWITCH = 12;
        public const int FAST_FAIL_INVALID_SET_OF_CONTEXT = 13;
        public const int FAST_FAIL_INVALID_REFERENCE_COUNT = 14;
        public const int FAST_FAIL_INVALID_JUMP_BUFFER = 18;
        public const int FAST_FAIL_MRDATA_MODIFIED = 19;
        public const int FAST_FAIL_CERTIFICATION_FAILURE = 20;
        public const int FAST_FAIL_INVALID_EXCEPTION_CHAIN = 21;
        public const int FAST_FAIL_CRYPTO_LIBRARY = 22;
        public const int FAST_FAIL_INVALID_CALL_IN_DLL_CALLOUT = 23;
        public const int FAST_FAIL_INVALID_IMAGE_BASE = 24;
        public const int FAST_FAIL_DLOAD_PROTECTION_FAILURE = 25;
        public const int FAST_FAIL_UNSAFE_EXTENSION_CALL = 26;
        public const int FAST_FAIL_DEPRECATED_SERVICE_INVOKED = 27;
        public const int FAST_FAIL_INVALID_BUFFER_ACCESS = 28;
        public const int FAST_FAIL_INVALID_BALANCED_TREE = 29;
        public const int FAST_FAIL_INVALID_NEXT_THREAD = 30;
        /// <summary>Telemetry, nonfatal</summary>
        public const int FAST_FAIL_GUARD_ICALL_CHECK_SUPPRESSED = 31;
        public const int FAST_FAIL_APCS_DISABLED = 32;
        public const int FAST_FAIL_INVALID_IDLE_STATE = 33;
        public const int FAST_FAIL_MRDATA_PROTECTION_FAILURE = 34;
        public const int FAST_FAIL_UNEXPECTED_HEAP_EXCEPTION = 35;
        public const int FAST_FAIL_INVALID_LOCK_STATE = 36;
        /// <summary>Known to compiler, must retain value 37</summary>
        public const int FAST_FAIL_GUARD_JUMPTABLE = 37;
        public const int FAST_FAIL_INVALID_LONGJUMP_TARGET = 38;
        public const int FAST_FAIL_INVALID_DISPATCH_CONTEXT = 39;
        public const int FAST_FAIL_INVALID_THREAD = 40;
        /// <summary>Telemetry, nonfatal</summary>
        public const int FAST_FAIL_INVALID_SYSCALL_NUMBER = 41;
        /// <summary>Telemetry, nonfatal</summary>
        public const int FAST_FAIL_INVALID_FILE_OPERATION = 42;
        /// <summary>Telemetry, nonfatal</summary>
        public const int FAST_FAIL_LPAC_ACCESS_DENIED = 43;
        public const int FAST_FAIL_GUARD_SS_FAILURE = 44;
        /// <summary>Telemetry, nonfatal</summary>
        public const int FAST_FAIL_LOADER_CONTINUITY_FAILURE = 45;
        public const int FAST_FAIL_GUARD_EXPORT_SUPPRESSION_FAILURE = 46;
        public const int FAST_FAIL_INVALID_CONTROL_STACK = 47;
        public const int FAST_FAIL_SET_CONTEXT_DENIED = 48;
        public const int FAST_FAIL_INVALID_IAT = 49;
        public const int FAST_FAIL_HEAP_METADATA_CORRUPTION = 50;
        public const int FAST_FAIL_PAYLOAD_RESTRICTION_VIOLATION = 51;
        /// <summary>Telemetry, nonfatal</summary>
        public const int FAST_FAIL_LOW_LABEL_ACCESS_DENIED = 52;
        public const int FAST_FAIL_ENCLAVE_CALL_FAILURE = 53;
        public const int FAST_FAIL_UNHANDLED_LSS_EXCEPTON = 54;
        /// <summary>Telemetry, nonfatal</summary>
        public const int FAST_FAIL_ADMINLESS_ACCESS_DENIED = 55;
        public const int FAST_FAIL_UNEXPECTED_CALL = 56;
        public const int FAST_FAIL_INVALID_FAST_FAIL_CODE = unchecked((int)0xFFFFFFFF);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19775
        public const int RTL_UMS_VERSION = 0x0100;
    }
}

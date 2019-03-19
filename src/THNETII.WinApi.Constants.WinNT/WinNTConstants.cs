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
        public const int CONTEXT_CONTROL = CONTEXT_i386 | 0x00000001;
        /// <summary>AX, BX, CX, DX, SI, DI</summary>
        public const int CONTEXT_INTEGER = CONTEXT_i386 | 0x00000002;
        /// <summary>DS, ES, FS, GS</summary>
        public const int CONTEXT_SEGMENTS = CONTEXT_i386 | 0x00000004;
        /// <summary>387 state</summary>
        public const int CONTEXT_FLOATING_POINT = CONTEXT_i386 | 0x00000008;
        /// <summary>DB 0-3,6,7</summary>
        public const int CONTEXT_DEBUG_REGISTERS = CONTEXT_i386 | 0x00000010;
        /// <summary>cpu specific extensions</summary>
        public const int CONTEXT_EXTENDED_REGISTERS = CONTEXT_i386 | 0x00000020;

        public const int CONTEXT_FULL = CONTEXT_CONTROL | CONTEXT_INTEGER |
                                         CONTEXT_SEGMENTS;

        public const int CONTEXT_ALL = CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_SEGMENTS |
                                        CONTEXT_FLOATING_POINT | CONTEXT_DEBUG_REGISTERS |
                                        CONTEXT_EXTENDED_REGISTERS;

        public const int CONTEXT_XSTATE = CONTEXT_i386 | 0x00000040;

        public const int CONTEXT_EXCEPTION_ACTIVE = 0x08000000;
        public const int CONTEXT_SERVICE_ACTIVE = 0x10000000;
        public const int CONTEXT_EXCEPTION_REQUEST = 0x40000000;
        public const int CONTEXT_EXCEPTION_REPORTING = unchecked((int)0x80000000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 7512
        public const int MAXIMUM_SUPPORTED_EXTENSION = 512;

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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19775
        public const int RTL_UMS_VERSION = 0x0100;
    }
}

namespace THNETII.WinApi.WinNT
{
    public static class WinNTMacros
    {
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        //  DEPRECATED: The LCID/LANGID/SORTID concept is deprecated, please use
        //  Locale Names instead, eg: "en-US" instead of an LCID like 0x0409.
        //  See the documentation for GetLocaleInfoEx.
        //
        //  A language ID is a 16 bit value which is the combination of a
        //  primary language ID and a secondary language ID.  The bits are
        //  allocated as follows:
        //
        //       +-----------------------+-------------------------+
        //       |     Sublanguage ID    |   Primary Language ID   |
        //       +-----------------------+-------------------------+
        //        15                   10 9                       0   bit
        //
        //  WARNING:  This pattern is broken and not followed for all languages.
        //            Serbian, Bosnian & Croatian are a few examples.
        //
        //  WARNING:  There are > 6000 human languages.  The PRIMARYLANGID construct
        //            cannot support all languages your application may encounter.
        //            Please use Language Names, such as "en".
        //
        //  WARNING:  There are > 200 country-regions.  The SUBLANGID construct cannot
        //            represent all valid dialects of languages such as English.
        //            Please use Locale Names, such as "en-US".
        //
        //  WARNING:  Some languages may have more than one PRIMARYLANGID.  Please
        //            use Locale Names, such as "en-FJ".
        //
        //  WARNING:  Some languages do not have assigned LANGIDs.  Please use
        //            Locale Names, such as "tlh-Piqd".
        //
        //  It is recommended that applications test for locale names rather than
        //  attempting to construct/deconstruct LANGID/PRIMARYLANGID/SUBLANGID
        //
        //  Language ID creation/extraction macros:
        //
        //    MAKELANGID    - construct language id from a primary language id and
        //                    a sublanguage id.
        //    PRIMARYLANGID - extract primary language id from a language id.
        //    SUBLANGID     - extract sublanguage id from a language id.
        //
        //  Note that the LANG, SUBLANG construction is not always consistent.
        //  The named locale APIs (eg GetLocaleInfoEx) are recommended.
        //
        //  DEPRECATED: Language IDs do not exist for all locales
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        public static int MAKELANGID(int p, int s) => (((ushort)s) << 10) | (ushort)p;
        public static int PRIMARYLANGID(int lgid) => (short)lgid & 0x3ff;
        public static int SUBLANGID(int lgid) => ((short)lgid >> 10);

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
        public static int MAKELCID(int lgid, int srtid) => ((ushort)srtid << 16) | (ushort)lgid;
        public static int MAKESORTLCID(int lgid, int srtid, int ver) => (MAKELCID(lgid, srtid)) | ((ushort)ver << 20);
        public static int LANGIDFROMLCID(int lcid) => (ushort)lcid;
        public static int SORTIDFROMLCID(int lcid) => (ushort)((lcid >> 16) & 0xf);
        public static int SORTVERSIONFROMLCID(int lcid) => (ushort)((lcid >> 20) & 0xf);
    }
}

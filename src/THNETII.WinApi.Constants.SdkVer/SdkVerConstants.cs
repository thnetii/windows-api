namespace THNETII.WinApi.SdkVer
{
    public static class SdkVerConstants
    {
        //
        // _WIN32_WINNT version constants
        //
        public const int WIN32_WINNT_NT4 = 0x0400;
        public const int WIN32_WINNT_WIN2K = 0x0500;
        public const int WIN32_WINNT_WINXP = 0x0501;
        public const int WIN32_WINNT_WS03 = 0x0502;
        public const int WIN32_WINNT_WIN6 = 0x0600;
        public const int WIN32_WINNT_VISTA = 0x0600;
        public const int WIN32_WINNT_WS08 = 0x0600;
        public const int WIN32_WINNT_LONGHORN = 0x0600;
        public const int WIN32_WINNT_WIN7 = 0x0601;
        public const int WIN32_WINNT_WIN8 = 0x0602;
        public const int WIN32_WINNT_WINBLUE = 0x0603;
        public const int WIN32_WINNT_WINTHRESHOLD = 0x0A00; /* ABRACADABRA_THRESHOLD*/
        public const int WIN32_WINNT_WIN10 = 0x0A00; /* ABRACADABRA_THRESHOLD*/

        //
        // _WIN32_IE_ version constants
        //
        public const int WIN32_IE_IE20 = 0x0200;
        public const int WIN32_IE_IE30 = 0x0300;
        public const int WIN32_IE_IE302 = 0x0302;
        public const int WIN32_IE_IE40 = 0x0400;
        public const int WIN32_IE_IE401 = 0x0401;
        public const int WIN32_IE_IE50 = 0x0500;
        public const int WIN32_IE_IE501 = 0x0501;
        public const int WIN32_IE_IE55 = 0x0550;
        public const int WIN32_IE_IE60 = 0x0600;
        public const int WIN32_IE_IE60SP1 = 0x0601;
        public const int WIN32_IE_IE60SP2 = 0x0603;
        public const int WIN32_IE_IE70 = 0x0700;
        public const int WIN32_IE_IE80 = 0x0800;
        public const int WIN32_IE_IE90 = 0x0900;
        public const int WIN32_IE_IE100 = 0x0A00;
        public const int WIN32_IE_IE110 = 0x0A00; /* ABRACADABRA_THRESHOLD */

        //
        // IE <-> OS version mapping
        //
        // NT4 supports IE versions 2.0 -> 6.0 SP1
        public const int WIN32_IE_NT4 = WIN32_IE_IE20;
        public const int WIN32_IE_NT4SP1 = WIN32_IE_IE20;
        public const int WIN32_IE_NT4SP2 = WIN32_IE_IE20;
        public const int WIN32_IE_NT4SP3 = WIN32_IE_IE302;
        public const int WIN32_IE_NT4SP4 = WIN32_IE_IE401;
        public const int WIN32_IE_NT4SP5 = WIN32_IE_IE401;
        public const int WIN32_IE_NT4SP6 = WIN32_IE_IE50;
        // Win98 supports IE versions 4.01 -> 6.0 SP1
        public const int WIN32_IE_WIN98 = WIN32_IE_IE401;
        // Win98SE supports IE versions 5.0 -> 6.0 SP1
        public const int WIN32_IE_WIN98SE = WIN32_IE_IE50;
        // WinME supports IE versions 5.5 -> 6.0 SP1
        public const int WIN32_IE_WINME = WIN32_IE_IE55;
        // Win2k supports IE versions 5.01 -> 6.0 SP1
        public const int WIN32_IE_WIN2K = WIN32_IE_IE501;
        public const int WIN32_IE_WIN2KSP1 = WIN32_IE_IE501;
        public const int WIN32_IE_WIN2KSP2 = WIN32_IE_IE501;
        public const int WIN32_IE_WIN2KSP3 = WIN32_IE_IE501;
        public const int WIN32_IE_WIN2KSP4 = WIN32_IE_IE501;
        public const int WIN32_IE_XP = WIN32_IE_IE60;
        public const int WIN32_IE_XPSP1 = WIN32_IE_IE60SP1;
        public const int WIN32_IE_XPSP2 = WIN32_IE_IE60SP2;
        public const int WIN32_IE_WS03 = 0x0602;
        public const int WIN32_IE_WS03SP1 = WIN32_IE_IE60SP2;
        public const int WIN32_IE_WIN6 = WIN32_IE_IE70;
        public const int WIN32_IE_LONGHORN = WIN32_IE_IE70;
        public const int WIN32_IE_WIN7 = WIN32_IE_IE80;
        public const int WIN32_IE_WIN8 = WIN32_IE_IE100;
        public const int WIN32_IE_WINBLUE = WIN32_IE_IE100;
        public const int WIN32_IE_WINTHRESHOLD = WIN32_IE_IE110; /* ABRACADABRA_THRESHOLD */
        public const int WIN32_IE_WIN10 = WIN32_IE_IE110; /* ABRACADABRA_THRESHOLD */


        //
        // NTDDI version constants
        //
        public const int NTDDI_WIN2K = 0x05000000;
        public const int NTDDI_WIN2KSP1 = 0x05000100;
        public const int NTDDI_WIN2KSP2 = 0x05000200;
        public const int NTDDI_WIN2KSP3 = 0x05000300;
        public const int NTDDI_WIN2KSP4 = 0x05000400;

        public const int NTDDI_WINXP = 0x05010000;
        public const int NTDDI_WINXPSP1 = 0x05010100;
        public const int NTDDI_WINXPSP2 = 0x05010200;
        public const int NTDDI_WINXPSP3 = 0x05010300;
        public const int NTDDI_WINXPSP4 = 0x05010400;

        public const int NTDDI_WS03 = 0x05020000;
        public const int NTDDI_WS03SP1 = 0x05020100;
        public const int NTDDI_WS03SP2 = 0x05020200;
        public const int NTDDI_WS03SP3 = 0x05020300;
        public const int NTDDI_WS03SP4 = 0x05020400;

        public const int NTDDI_WIN6 = 0x06000000;
        public const int NTDDI_WIN6SP1 = 0x06000100;
        public const int NTDDI_WIN6SP2 = 0x06000200;
        public const int NTDDI_WIN6SP3 = 0x06000300;
        public const int NTDDI_WIN6SP4 = 0x06000400;

        public const int NTDDI_VISTA = NTDDI_WIN6;
        public const int NTDDI_VISTASP1 = NTDDI_WIN6SP1;
        public const int NTDDI_VISTASP2 = NTDDI_WIN6SP2;
        public const int NTDDI_VISTASP3 = NTDDI_WIN6SP3;
        public const int NTDDI_VISTASP4 = NTDDI_WIN6SP4;

        public const int NTDDI_LONGHORN = NTDDI_VISTA;

        public const int NTDDI_WS08 = NTDDI_WIN6SP1;
        public const int NTDDI_WS08SP2 = NTDDI_WIN6SP2;
        public const int NTDDI_WS08SP3 = NTDDI_WIN6SP3;
        public const int NTDDI_WS08SP4 = NTDDI_WIN6SP4;

        public const int NTDDI_WIN7 = 0x06010000;
        public const int NTDDI_WIN8 = 0x06020000;
        public const int NTDDI_WINBLUE = 0x06030000;
        public const int NTDDI_WINTHRESHOLD = 0x0A000000; /* ABRACADABRA_THRESHOLD */
        public const int NTDDI_WIN10 = 0x0A000000; /* ABRACADABRA_THRESHOLD */
        public const int NTDDI_WIN10_TH2 = 0x0A000001; /* ABRACADABRA_WIN10_TH2 */
        public const int NTDDI_WIN10_RS1 = 0x0A000002; /* ABRACADABRA_WIN10_RS1 */
        public const int NTDDI_WIN10_RS2 = 0x0A000003; /* ABRACADABRA_WIN10_RS2 */
        public const int NTDDI_WIN10_RS3 = 0x0A000004; /* ABRACADABRA_WIN10_RS3 */
        public const int NTDDI_WIN10_RS4 = 0x0A000005; /* ABRACADABRA_WIN10_RS4 */

        public const int WDK_NTDDI_VERSION = NTDDI_WIN10_RS4; /* ABRACADABRA_WIN10_RS4 */


        //
        // masks for version macros
        //
        public const int OSVERSION_MASK = unchecked((int)0xFFFF0000);
        public const int SPVERSION_MASK = 0x0000FF00;
        public const int SUBVERSION_MASK = 0x000000FF;
    }
}

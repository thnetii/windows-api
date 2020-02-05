using THNETII.WinApi.Native.WinSmcrd;

namespace THNETII.WinApi.Native.WinSCard.Test
{
    public static class SCARD_PCI_RAW
    {
        [FactWindowsOS]
        public static void Can_access_external_variable()
        {
            ref readonly SCARD_IO_REQUEST req = ref WinSCardConstants.SCARD_PCI_RAW;
            _ = req.dwProtocol;
            _ = req.cbPciLength;
            foreach (ref byte bPic in req.PciTrailer)
            {
                _ = bPic;
            }
        }
    }
}

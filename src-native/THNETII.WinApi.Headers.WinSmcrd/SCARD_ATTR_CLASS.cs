namespace THNETII.WinApi.Native.WinSmcrd
{
    public enum SCARD_ATTR_CLASS
    {
        /// <summary>Vendor information definitions</summary>
        SCARD_CLASS_VENDOR_INFO = WinSmcrdConstants.SCARD_CLASS_VENDOR_INFO,
        /// <summary>Communication definitions</summary>
        SCARD_CLASS_COMMUNICATIONS = WinSmcrdConstants.SCARD_CLASS_COMMUNICATIONS,
        /// <summary>Protocol definitions</summary>
        SCARD_CLASS_PROTOCOL = WinSmcrdConstants.SCARD_CLASS_PROTOCOL,
        /// <summary>Power Management definitions</summary>
        SCARD_CLASS_POWER_MGMT = WinSmcrdConstants.SCARD_CLASS_POWER_MGMT,
        /// <summary>Security Assurance definitions</summary>
        SCARD_CLASS_SECURITY = WinSmcrdConstants.SCARD_CLASS_SECURITY,
        /// <summary>Mechanical characteristic definitions</summary>
        SCARD_CLASS_MECHANICAL = WinSmcrdConstants.SCARD_CLASS_MECHANICAL,
        /// <summary>Vendor specific definitions</summary>
        SCARD_CLASS_VENDOR_DEFINED = WinSmcrdConstants.SCARD_CLASS_VENDOR_DEFINED,
        /// <summary>Interface Device Protocol options</summary>
        SCARD_CLASS_IFD_PROTOCOL = WinSmcrdConstants.SCARD_CLASS_IFD_PROTOCOL,
        /// <summary>ICC State specific definitions</summary>
        SCARD_CLASS_ICC_STATE = WinSmcrdConstants.SCARD_CLASS_ICC_STATE,
        /// <summary>performace counters</summary>
        SCARD_CLASS_PERF = WinSmcrdConstants.SCARD_CLASS_PERF,
        /// <summary>System-specific definitions</summary>
        SCARD_CLASS_SYSTEM = WinSmcrdConstants.SCARD_CLASS_SYSTEM,
    }
}

using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 998
    /// <summary>
    /// The <see cref="SecPkgContext_NegotiationInfoA"/> structure contains information on the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a> that is being set up or has been set up, and also gives the status on the negotiation to set up the security package.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_negotiationinfoa">SecPkgContext_NegotiationInfoA structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_NegotiationInfoA
    {
        /// <summary>
        /// Pointer to a <see cref="SecPkgInfoA"/> structure that provides general information about the security package chosen in the negotiate process, such as the name and capabilities of the package.
        /// </summary>
        public SecPkgInfoA* PackageInfo;
        internal int NegotiationStateField;
        /// <summary>
        /// Indicator of the state of the negotiation for the security package identified in the <see cref="PackageInfo"/> member. This attribute can be queried from the context handle before the setup is complete, such as when ISC returns <see cref="SEC_I_CONTINUE_NEEDED"/>.
        /// </summary>
        public SECPKG_NEGOTIATION_STATE NegotiationState
        {
            get => (SECPKG_NEGOTIATION_STATE)NegotiationStateField;
            set => NegotiationStateField = (int)value;
        }
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1005
    /// <summary>
    /// The <see cref="SecPkgContext_NegotiationInfoW"/> structure contains information on the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a> that is being set up or has been set up, and also gives the status on the negotiation to set up the security package.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_negotiationinfow">SecPkgContext_NegotiationInfoW structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_NegotiationInfoW
    {
        /// <summary>
        /// Pointer to a <see cref="SecPkgInfoW"/> structure that provides general information about the security package chosen in the negotiate process, such as the name and capabilities of the package.
        /// </summary>
        public SecPkgInfoW* PackageInfo;
        internal int NegotiationStateField;
        /// <summary>
        /// Indicator of the state of the negotiation for the security package identified in the <see cref="PackageInfo"/> member. This attribute can be queried from the context handle before the setup is complete, such as when ISC returns <see cref="SEC_I_CONTINUE_NEEDED"/>.
        /// </summary>
        public SECPKG_NEGOTIATION_STATE NegotiationState
        {
            get => (SECPKG_NEGOTIATION_STATE)NegotiationStateField;
            set => NegotiationStateField = (int)value;
        }
    }
}

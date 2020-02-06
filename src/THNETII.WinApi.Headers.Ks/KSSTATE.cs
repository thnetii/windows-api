namespace THNETII.WinApi.Native.Ks
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\ks.h, line 89
    /// <summary>
    /// The <see cref="KSSTATE"/> enumeration lists possible states of a kernel streaming object.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/ks/ne-ks-ksstate">KSSTATE enumeration</a></para>
    /// </remarks>
    public enum KSSTATE
    {
        /// <summary>Indicates that the object is in minimum resource consumption mode.</summary>
        KSSTATE_STOP,
        /// <summary>Indicates that the object is acquiring resources.</summary>
        KSSTATE_ACQUIRE,
        /// <summary>Indicates that the object is preparing to make instant transition to Run state.</summary>
        KSSTATE_PAUSE,
        /// <summary>Indicates that the object is actively streaming.</summary>
        KSSTATE_RUN
    }
}

namespace THNETII.WinApi.Native.Ks
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\ks.h, line 96
    public enum KSPRIORITY_CLASS
    {
        /// <summary>Specifies the lowest priority. </summary>
        KSPRIORITY_LOW = KsConstants.KSPRIORITY_LOW,
        /// <summary>Specifies normal priority. </summary>
        KSPRIORITY_NORMAL = KsConstants.KSPRIORITY_NORMAL,
        /// <summary>Specifies an elevated priority. </summary>
        KSPRIORITY_HIGH = KsConstants.KSPRIORITY_HIGH,
        /// <summary>Specifies the highest priority, which implies exclusive access to resources. </summary>
        KSPRIORITY_EXCLUSIVE = KsConstants.KSPRIORITY_EXCLUSIVE,
    }
}

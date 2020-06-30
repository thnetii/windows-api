namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11772
    public enum JOBOBJECT_RATE_CONTROL_TOLERANCE
    {
        /// <summary>
        /// The job can exceed its CPU rate control limits for 20% of the tolerance interval. 
        /// </summary>
        ToleranceLow = 1,
        /// <summary>
        /// The job can exceed its CPU rate control limits for 40% of the tolerance interval. 
        /// </summary>
        ToleranceMedium,
        /// <summary>
        /// The job can exceed its CPU rate control limits for 60% of the tolerance interval. 
        /// </summary>
        ToleranceHigh
    }
}

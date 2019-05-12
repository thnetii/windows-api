using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum FPO_FRAME_TYPE : short
    {
        /// <summary>
        ///  FPO frame 
        /// </summary>
        FRAME_FPO = WinNTConstants.FRAME_FPO,
        /// <summary>
        /// Trap frame 
        /// </summary>
        FRAME_TRAP = WinNTConstants.FRAME_TRAP,
        /// <summary>
        /// TSS frame 
        /// </summary>
        FRAME_TSS = WinNTConstants.FRAME_TSS,
        /// <summary>
        /// Non-FPO frame 
        /// </summary>
        FRAME_NONFPO = WinNTConstants.FRAME_NONFPO,
    }
}

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum FRAME_TYPE : short
    {
        /// <summary>FPO frame</summary>
        FRAME_FPO = 0,
        /// <summary>Trap frame</summary>
        FRAME_TRAP = 1,
        /// <summary>TSS frame</summary>
        FRAME_TSS = 2,
        /// <summary>Non-FPO frame</summary>
        FRAME_NONFPO = 3,

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
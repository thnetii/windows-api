using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum NETWORK_APP_INSTANCE_CSV_FLAGS : int
    {
        /// <summary>
        /// Is used only when file is opened directly on CSVFS. This flag is ignored when file
        /// is opened over SMB.
        /// <para>
        /// Tells CSVFS that this file open should be valid only on coordinating node.
        /// </para>
        /// <para>
        /// If open comes to CSVFS, and this node is not a coordinating then open would fail.
        /// If file is opened, and coordinating node is moved then file open will be invalidated
        /// </para>
        /// </summary>
        NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR = WinNTConstants.NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR,
    }
}

using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    using static SCRUB_DATA_OUTPUT_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13312
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SCRUB_DATA_OUTPUT
    {
        /// <summary>
        /// Set to the static <see cref="SizeOf{SCRUB_DATA_OUTPUT}.Bytes"/>
        /// property of the <see cref="SizeOf{SCRUB_DATA_OUTPUT}"/> type.
        /// </summary>
        public short Size;

        /// <summary>
        /// Output Flags
        /// <para>
        /// <see cref="SCRUB_DATA_OUTPUT_FLAG_INCOMPLETE"/> will be set if there are
        /// remaining ranges. <see cref="ResumeContext"/> provided for the subsequent
        /// call.
        /// </para>
        /// </summary>
        public SCRUB_DATA_OUTPUT_FLAGS Flags;

        /// <summary>
        /// Operational status
        /// </summary>
        public int Status;

        /// <summary>
        /// Offset of the error range of the user data where the operational errors were found.
        /// This value may be <c>-1</c> if the error were found in non-user data area
        /// </summary>
        public long ErrorFileOffset;

        /// <summary>
        /// Length of the error range of the user data where the operational errors were found.
        /// This value may be 0 if the error were found in non-user data area
        /// </summary>
        public long ErrorLength;

        /// <summary>
        /// Number of bytes successfully repaired in the operational error range
        /// </summary>
        public long NumberOfBytesRepaired;

        /// <summary>
        /// Number of bytes failed due to an error in the operational error range
        /// </summary>
        public long NumberOfBytesFailed;

        /// <summary>
        /// Reference number for the file system specific internal file
        /// </summary>
        public long InternalFileReference;

        /// <summary>
        /// Resume context length
        /// <para>
        /// Only valid if <see cref="SCRUB_DATA_OUTPUT_FLAG_RESUME_CONTEXT_LENGTH_SPECIFIED"/>
        /// is specified in the <see cref="Flags"/>.
        /// </para>
        /// </summary>
        public short ResumeContextLength;

        /// <summary>
        /// Offset for the parity extent data in the output buffer
        /// Only valid if <see cref="SCRUB_DATA_OUTPUT_FLAG_PARITY_EXTENT_DATA_RETURNED"/>
        /// is specified in the <see cref="Flags"/>.
        /// </summary>
        public short ParityExtentDataOffset;

        /// <summary>Reserved</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed int Reserved[5];

        /// <summary>
        /// <para>
        /// Opaque data that the file system returns to the user so that
        /// subsequent call can use this data to resume from the previous
        /// point for the operation.
        /// </para>
        /// <para>
        /// Resume operation can be requested on a different handle and
        /// across the reboot. However, file system may not honor the
        /// resume context if not feasible and start from the beginning.
        /// </para>
        /// <para>
        /// This field is only valid when <see cref="SCRUB_DATA_OUTPUT_FLAG_INCOMPLETE"/>
        /// is set in <see cref="Flags"/>.
        /// </para>
        /// </summary>
        public fixed byte ResumeContext[816];
    }
}

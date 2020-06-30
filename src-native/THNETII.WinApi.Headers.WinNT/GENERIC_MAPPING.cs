using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8918
    /// <summary>
    /// The <see cref="GENERIC_MAPPING"/> structure defines the mapping of generic access rights to specific and standard access rights for an object. When a client application requests generic access to an object, that request is mapped to the access rights defined in this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-_generic_mapping">GENERIC_MAPPING structure</a></para>
    /// </remarks>
    /// <seealso cref="ACCESS_MASK"/>
    /// <seealso cref="AccessCheck"/>
    /// <seealso cref="AccessCheckAndAuditAlarm"/>
    /// <seealso cref="CreatePrivateObjectSecurity"/>
    /// <seealso cref="MapGenericMask"/>
    /// <seealso cref="SetPrivateObjectSecurity"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct GENERIC_MAPPING
    {
        /// <summary>
        /// Specifies an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access mask</a> defining read access to an object.
        /// </summary>
        public ACCESS_MASK GenericRead;
        /// <summary>
        /// Specifies an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access mask</a> defining write access to an object.
        /// </summary>
        public ACCESS_MASK GenericWrite;
        /// <summary>
        /// Specifies an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access mask</a> defining execute access to an object.
        /// </summary>
        public ACCESS_MASK GenericExecute;
        /// <summary>
        /// Specifies an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access mask</a> defining all possible types of access to an object.
        /// </summary>
        public ACCESS_MASK GenericAll;
    }
}

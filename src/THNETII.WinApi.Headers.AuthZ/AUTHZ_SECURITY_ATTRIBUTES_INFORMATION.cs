using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Headers.AuthZ
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 496
    //
    //  Set of security attributes.
    //

    /// <summary>
    /// The <see cref="AUTHZ_SECURITY_ATTRIBUTES_INFORMATION"/> structure specifies one or more security attributes.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/authz/ns-winnt-authz_security_attributes_information">AUTHZ_SECURITY_ATTRIBUTES_INFORMATION structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AUTHZ_SECURITY_ATTRIBUTES_INFORMATION
    {
        //
        //  Versioning. The interpretation of the pointers in the
        //  Attribute field below is dependent on the version field.
        //
        //  Get operations return the version while the set operation
        //  MUST specify the version of the data structure passed in.
        //

        //
        //  MUST BE first.
        //

        public ushort Version;

        //
        //  Pass 0 in set operations and ignore on get operations.
        //

        [EditorBrowsable(EditorBrowsableState.Never)]
        public ushort Reserved;

        public int AttributeCount;

        #region public AUTHZ_SECURITY_ATTRIBUTE_V1 Attribute;
        internal AUTHZ_SECURITY_ATTRIBUTE_V1* pAttributeV1;
        public ref AUTHZ_SECURITY_ATTRIBUTE_V1 Attribute =>
            ref Unsafe.AsRef<AUTHZ_SECURITY_ATTRIBUTE_V1>(pAttributeV1);
        #endregion
    }
}

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.AuthZ;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 753
    /// <summary>
    /// The <see cref="SecPkgContext_SubjectAttributes"/> structure returns the security attribute information.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_subjectattributes">SecPkgContext_SubjectAttributes structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_SubjectAttributes
    {
        #region public void* AttributeInfo;
        /// <summary>
        /// Pointer to the attribute information stored in a <see cref="AUTHZ_SECURITY_ATTRIBUTES_INFORMATION"/> structure.
        /// </summary>
        public AUTHZ_SECURITY_ATTRIBUTES_INFORMATION* AttributeInfoPtr;
        /// <summary>
        /// A reference to the attribute information stored in a <see cref="AUTHZ_SECURITY_ATTRIBUTES_INFORMATION"/> structure.
        /// </summary>
        public ref AUTHZ_SECURITY_ATTRIBUTES_INFORMATION AttributeInfo =>
            ref Unsafe.AsRef<AUTHZ_SECURITY_ATTRIBUTES_INFORMATION>(AttributeInfoPtr);
        #endregion
    }
}

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.AccCtrl
{
    using static ACCESS_MODE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 303
    //
    // Definition: EXPLICIT_ACCESS
    // This structure is used to pass access control entry information into and out
    // of the system using the API defined in this document.
    // grfAccessPermissions - This contains the access permissions to assign for the
    //                     trustee.  It is in the form of an NT access mask.
    // grfAccessMode - This field defines how the permissions are to be applied for
    //                 the trustee.
    // grfInheritance - For containers, this field defines how the access control
    //                  entry is/(is requested) to be inherited on
    //                  objects/sub-containers created within the container.
    // Trustee - This field contains the definition of the trustee account the
    //           explicit access applies to.
    //

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 318
    /// <inheritdoc cref="EXPLICIT_ACCESS"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EXPLICIT_ACCESS_A
    {
        /// <inheritdoc cref="EXPLICIT_ACCESS.grfAccessPermissions"/>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_MASK grfAccessPermissions;
        /// <inheritdoc cref="EXPLICIT_ACCESS.grfAccessMode"/>
        public ACCESS_MODE grfAccessMode;
        /// <inheritdoc cref="EXPLICIT_ACCESS.grfInheritance"/>
        [MarshalAs(UnmanagedType.U4)]
        public AceFlags grfInheritance;
        /// <inheritdoc cref="EXPLICIT_ACCESS.Trustee"/>
        public TRUSTEE_A Trustee;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 325
    /// <inheritdoc cref="EXPLICIT_ACCESS"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct EXPLICIT_ACCESS_W
    {
        /// <inheritdoc cref="EXPLICIT_ACCESS.grfAccessPermissions"/>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_MASK grfAccessPermissions;
        /// <inheritdoc cref="EXPLICIT_ACCESS.grfAccessMode"/>
        public ACCESS_MODE grfAccessMode;
        /// <inheritdoc cref="EXPLICIT_ACCESS.grfInheritance"/>
        [MarshalAs(UnmanagedType.U4)]
        public AceFlags grfInheritance;
        /// <inheritdoc cref="EXPLICIT_ACCESS.Trustee"/>
        public TRUSTEE_W Trustee;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 318
    /// <summary>
    /// The <see cref="EXPLICIT_ACCESS"/> structure defines access control information for a specified trustee. Access control functions, such as <see cref="SetEntriesInAcl"/> and <see cref="GetExplicitEntriesFromAcl"/>, use this structure to describe the information in an <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">access control entry</a> (ACE) of an <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">access control list</a> (ACL).
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ns-accctrl-explicit_access_w">EXPLICIT_ACCESS_W structure</a></para>
    /// </remarks>
    /// <seealso cref="ACCESS_MASK"/>
    /// <seealso cref="ACCESS_MODE"/>
    /// <seealso cref="GenericAce"/>
    /// <seealso cref="ACL"/>
    /// <seealso cref="BuildExplicitAccessWithName"/>
    /// <seealso cref="BuildSecurityDescriptor"/>
    /// <seealso cref="GetExplicitEntriesFromAcl"/>
    /// <seealso cref="LookupSecurityDescriptorParts"/>
    /// <seealso cref="SetEntriesInAcl"/>
    /// <seealso cref="TRUSTEE"/>
#if !NETSTANDARD1_6
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif
    public struct EXPLICIT_ACCESS
    {
        /// <summary>
        /// A set of bit flags that use the <see cref="ACCESS_MASK"/> format to specify the access rights that an ACE allows, denies, or audits for the trustee. The functions that use the <see cref="EXPLICIT_ACCESS"/> structure do not convert, interpret, or validate the bits in this mask.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_MASK grfAccessPermissions;
        /// <summary>
        /// A value from the <see cref="ACCESS_MODE"/> enumeration. For a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/d-gly">discretionary access control list</a> (DACL), this flag indicates whether the ACL allows or denies the specified access rights. For a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">system access control list</a> (SACL), this flag indicates whether the ACL generates audit messages for successful attempts to use the specified access rights, or failed attempts, or both. When modifying an existing ACL, you can specify the <see cref="REVOKE_ACCESS"/> flag to remove any existing ACEs for the specified trustee.
        /// </summary>
        public ACCESS_MODE grfAccessMode;
        /// <summary>
        /// A set of bit flags that determines whether other containers or objects can inherit the ACE from the primary object to which the ACL is attached. The value of this member corresponds to the inheritance portion (low-order byte) of the <see cref="GenericAce.AceFlags"/> member of the <see cref="GenericAce"/> structure.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        [SuppressMessage("Usage", "PC001: API not supported on all platforms")]
        public AceFlags grfInheritance;
        /// <summary>
        /// A <see cref="TRUSTEE"/> structure that identifies the user, group, or program (such as a Windows service) to which the ACE applies.
        /// </summary>
        public TRUSTEE Trustee;
    }
}

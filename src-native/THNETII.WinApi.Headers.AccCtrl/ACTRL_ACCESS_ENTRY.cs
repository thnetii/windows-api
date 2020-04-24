using System.Runtime.InteropServices;
using System.Security.AccessControl;

using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.AccCtrl
{
    using static ACCESS_FLAGS;
    using static ACCESS_RIGHTS;
    using static WinNTRuntimeConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 378
    //
    // Access / Audit structures
    //
    /// <inheritdoc cref="ACTRL_ACCESS_ENTRY" />
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACTRL_ACCESS_ENTRYA
    {
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY.Trustee"/>
        public TRUSTEE_A Trustee;
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY.fAccessFlags"/>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_FLAGS fAccessFlags;
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY.Access"/>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_RIGHTS Access;
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY.ProvSpecificAccess"/>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_RIGHTS ProvSpecificAccess;
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY.Inheritance"/>
        [MarshalAs(UnmanagedType.U4)]
        public InheritanceFlags Inheritance;
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY.lpInheritProperty"/>
        public LPSTR lpInheritProperty;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 390
    //
    // Access / Audit structures
    //
    /// <inheritdoc cref="ACTRL_ACCESS_ENTRY" />
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ACTRL_ACCESS_ENTRYW
    {
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY.Trustee"/>
        public TRUSTEE_W Trustee;
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY.fAccessFlags"/>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_FLAGS fAccessFlags;
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY.Access"/>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_RIGHTS Access;
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY.ProvSpecificAccess"/>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_RIGHTS ProvSpecificAccess;
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY.Inheritance"/>
        [MarshalAs(UnmanagedType.U4)]
        public InheritanceFlags Inheritance;
        /// <inheritdoc cref="ACTRL_ACCESS_ENTRY.lpInheritProperty"/>
        public LPWSTR lpInheritProperty;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 390
    //
    // Access / Audit structures
    //
    /// <summary>
    /// Contains access-control information for a specified trustee. This structure stores information equivalent to the access-control information stored in an <see cref="GenericAce"/>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ns-accctrl-actrl_access_entryw">ACTRL_ACCESS_ENTRYW structure</a></para>
    /// </remarks>
    /// <seealso cref="ACTRL_ACCESS_ENTRY_LIST"/>
    /// <seealso cref="TRUSTEE"/>
#if !(NETSTANDARD1_3 || NETSTANDARD1_6)
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif
    public struct ACTRL_ACCESS_ENTRY
    {
        /// <summary>
        /// A <see cref="TRUSTEE"/> structure that identifies the user, group, or program (such as a service) to which the access-control entry applies.
        /// </summary>
        public TRUSTEE Trustee;
        /// <summary>
        /// Indicates how the access rights specified by the <see cref="Access"/> and <see cref="ProvSpecificAccess"/> members apply to the trustee. If you are using this structure with the COM implementation of <see cref="IAccessControl"/>, this member must be <see cref="ACTRL_ACCESS_ALLOWED"/> or <see cref="ACTRL_ACCESS_DENIED"/>.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_FLAGS fAccessFlags;
        /// <summary>
        /// <para>A bitmask that specifies the access rights that the entry allows, denies, or audits for the trustee.</para>
        /// <para>This member must use the provider-independent access flags, such as <see cref="ACTRL_READ_CONTROL"/>, rather than access flags such as <see cref="READ_CONTROL"/>. The provider for the object type converts these provider-independent flags to the corresponding provider-specific flags.</para>
        /// <para>If you are using this structure with the COM implementation of <see cref="IAccessControl"/>, this member must be <see cref="COM_RIGHTS_EXECUTE"/>.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_RIGHTS Access;
        /// <summary>
        /// A bitmask that specifies access rights specific to the provider type. The functions that use the <see cref="ACTRL_ACCESS_ENTRY"/> structure pass these bits on to the provider without interpreting them. In most cases, this member should be <see langword="default"/>.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_RIGHTS ProvSpecificAccess;
        /// <summary>
        /// A set of bit flags that determines whether other containers or objects can inherit the access-control entry from the primary object to which the access list is attached. If you are using this structure with the COM implementation of <see cref="IAccessControl"/>, this value must be <see cref="NO_INHERITANCE"/>, which indicates that the access-control entry is not inheritable.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public InheritanceFlags Inheritance;
        /// <summary>
        /// A pointer to a null-terminated string that identifies the object types that can inherit the entry. If you are using this structure with the COM implementation of <see cref="IAccessControl"/>, this member must be <see langword="default"/>.
        /// </summary>
        public LPTSTR lpInheritProperty;
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.AccCtrl
{
    using static ACE_OBJECT_TYPE_PRESENT_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 131
    /// <inheritdoc cref="OBJECTS_AND_NAME"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OBJECTS_AND_NAME_A
    {
        /// <inheritdoc cref="OBJECTS_AND_NAME.ObjectsPresent"/>
        [MarshalAs(UnmanagedType.U4)]
        public ACE_OBJECT_TYPE_PRESENT_FLAGS ObjectsPresent;
        /// <inheritdoc cref="OBJECTS_AND_NAME.ObjectType"/>
        public SE_OBJECT_TYPE ObjectType;
        /// <inheritdoc cref="OBJECTS_AND_NAME.ObjectTypeName"/>
        public LPSTR ObjectTypeName;
        /// <inheritdoc cref="OBJECTS_AND_NAME.InheritedObjectTypeName"/>
        public LPSTR InheritedObjectTypeName;
        /// <inheritdoc cref="OBJECTS_AND_NAME.ptstrName"/>
        public LPSTR ptstrName;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 139
    /// <inheritdoc cref="OBJECTS_AND_NAME"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct OBJECTS_AND_NAME_W
    {
        /// <inheritdoc cref="OBJECTS_AND_NAME.ObjectsPresent"/>
        [MarshalAs(UnmanagedType.U4)]
        public ACE_OBJECT_TYPE_PRESENT_FLAGS ObjectsPresent;
        /// <inheritdoc cref="OBJECTS_AND_NAME.ObjectType"/>
        public SE_OBJECT_TYPE ObjectType;
        /// <inheritdoc cref="OBJECTS_AND_NAME.ObjectTypeName"/>
        public LPWSTR ObjectTypeName;
        /// <inheritdoc cref="OBJECTS_AND_NAME.InheritedObjectTypeName"/>
        public LPWSTR InheritedObjectTypeName;
        /// <inheritdoc cref="OBJECTS_AND_NAME.ptstrName"/>
        public LPWSTR ptstrName;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 147
    /// <summary>
    /// The <see cref="OBJECTS_AND_NAME"/> structure contains a string that identifies a trustee by name and additional strings that identify the object types of an object-specific <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">access control entry</a> (ACE).
    /// </summary>
    /// <remarks>
    /// The <see cref="TRUSTEE.ptstrName"/> member of a <see cref="TRUSTEE"/> structure can be a pointer to an <see cref="OBJECTS_AND_NAME"/> structure. This enables functions such as <see cref="SetEntriesInAcl"/> and <see cref="GetExplicitEntriesFromAcl"/> to store object-specific ACE information in the <see cref="EXPLICIT_ACCESS.Trustee"/> member of an <see cref="EXPLICIT_ACCESS"/> structure.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ns-accctrl-objects_and_name">OBJECTS_AND_NAME_W structure</a></para>
    /// </remarks>
    /// <seealso cref="ACE_HEADER"/>
    /// <seealso cref="EXPLICIT_ACCESS"/>
    /// <seealso cref="GetExplicitEntriesFromAcl"/>
    /// <seealso cref="OBJECTS_AND_SID"/>
    /// <seealso cref="SE_OBJECT_TYPE"/>
    /// <seealso cref="SetEntriesInAcl"/>
    /// <seealso cref="TRUSTEE"/>
#if !(NETSTANDARD1_3 || NETSTANDARD1_6)
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)] 
#endif
    public struct OBJECTS_AND_NAME
    {
        /// <summary>
        /// Indicates whether the <see cref="ObjectTypeName"/> and <see cref="InheritedObjectTypeName"/> members contain strings. This parameter can be a combination of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="ACE_OBJECT_TYPE_PRESENT"/><br/><c>0x1</c></term><description>The <see cref="ObjectTypeName"/> member contains a string.</description></item>
        /// <item><term><see cref="ACE_INHERITED_OBJECT_TYPE_PRESENT"/><br/><c>0x2</c></term><description>The <see cref="InheritedObjectTypeName"/> member contains a string.</description></item>
        /// </list>
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public ACE_OBJECT_TYPE_PRESENT_FLAGS ObjectsPresent;
        /// <summary>
        /// Specifies a value from the <see cref="SE_OBJECT_TYPE"/> enumeration that indicates the type of object.
        /// </summary>
        public SE_OBJECT_TYPE ObjectType;
        /// <summary>
        /// <para>A pointer to a null-terminated string that identifies the type of object to which the ACE applies.</para>
        /// <para>This string must be a valid <a href="https://docs.microsoft.com/windows/desktop/SecGloss/l-gly">LDAP</a> display name in the Active Directory schema.</para>
        /// </summary>
        public LPTSTR ObjectTypeName;
        /// <summary>
        /// <para>A pointer to a null-terminated string that identifies the type of object that can inherit the ACE.</para>
        /// <para>This string must be a valid <a href="https://docs.microsoft.com/windows/desktop/SecGloss/l-gly">LDAP</a> display name in the Active Directory schema.</para>
        /// <para>If the <see cref="ACE_INHERITED_OBJECT_TYPE_PRESENT"/> bit is not set in the <see cref="ObjectsPresent"/> member, the <see cref="InheritedObjectTypeName"/> member is ignored, and all types of child objects can inherit the ACE. Otherwise, only the specified object type can inherit the ACE. In either case, inheritance is also controlled by the inheritance flags in the <see cref="ACE_HEADER"/> structure as well as by any protection against inheritance placed on the child objects.</para>
        /// </summary>
        public LPTSTR InheritedObjectTypeName;
        /// <summary>
        /// A pointer to a null-terminated string that contains the name of the trustee.
        /// </summary>
        public LPTSTR ptstrName;
    }
}

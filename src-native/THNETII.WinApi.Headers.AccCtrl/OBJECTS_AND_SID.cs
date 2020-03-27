using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.AccCtrl
{
    using static ACE_OBJECT_TYPE_PRESENT_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 107
    /// <summary>
    /// The <see cref="OBJECTS_AND_SID"/> structure contains a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security identifier</a> (SID) that identifies a trustee and GUIDs that identify the object types of an object-specific <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">access control entry</a> (ACE).
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="TRUSTEE.ptstrName"/> member of a <see cref="TRUSTEE"/> structure can be a pointer to an <see cref="OBJECTS_AND_SID"/> structure. This enables functions such as <see cref="SetEntriesInAcl"/> and <see cref="GetExplicitEntriesFromAcl"/> to store object-specific ACE information in the <see cref="EXPLICIT_ACCESS.Trustee"/> member of an <see cref="EXPLICIT_ACCESS"/> structure.</para>
    /// <para>When you use this structure in a call to <see cref="SetEntriesInAcl"/>, <see cref="ObjectTypeGuid"/> and <see cref="InheritedObjectTypeGuid"/> must be valid schema identifiers in the Active Directory schema. The system does not verify the GUIDs; they are used as is.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ns-accctrl-objects_and_sid">OBJECTS_AND_SID structure</a></para>
    /// </remarks>
    /// <seealso cref="ACE_HEADER"/>
    /// <seealso cref="EXPLICIT_ACCESS"/>
    /// <seealso cref="Guid"/>
    /// <seealso cref="GetExplicitEntriesFromAcl"/>
    /// <seealso cref="OBJECTS_AND_NAME"/>
    /// <seealso cref="SetEntriesInAcl"/>
    /// <seealso cref="TRUSTEE"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct OBJECTS_AND_SID
    {
        /// <summary>
        /// Indicates whether the <see cref="ObjectTypeGuid"/> and <see cref="InheritedObjectTypeGuid"/> members contain GUIDs. This parameter can be a combination of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="ACE_OBJECT_TYPE_PRESENT"/><br/><c>0x1</c></term><description>The <see cref="ObjectTypeGuid"/> member contains a GUID.</description></item>
        /// <item><term><see cref="ACE_INHERITED_OBJECT_TYPE_PRESENT"/><br/><c>0x2</c></term><description>The <see cref="InheritedObjectTypeGuid"/> member contains a GUID.</description></item>
        /// </list>
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public ACE_OBJECT_TYPE_PRESENT_FLAGS ObjectsPresent;
        /// <summary>
        /// <para>A <see cref="Guid"/> structure that identifies the type of object, property set, or property protected by the ACE. If this ACE is inherited, the GUID identifies the type of object, property set, or property protected by the inherited ACE. This GUID must be a valid schema identifier in the Active Directory schema.</para>
        /// <para>If the <see cref="ACE_OBJECT_TYPE_PRESENT"/> bit is not set in the <see cref="ObjectsPresent"/> member, the <see cref="ObjectTypeGuid"/> member is ignored, and the ACE protects the object to which the ACL is assigned.</para>
        /// </summary>
        public Guid ObjectTypeGuid;
        /// <summary>
        /// <para>A <see cref="Guid"/> structure that identifies the type of object that can inherit the ACE. This GUID must be a valid schema identifier in the Active Directory schema.</para>
        /// <para>If the <see cref="ACE_INHERITED_OBJECT_TYPE_PRESENT"/> bit is not set in the <see cref="ObjectsPresent"/> member, the <see cref="InheritedObjectTypeGuid"/> member is ignored, and all types of child objects can inherit the ACE. Otherwise, only the specified object type can inherit the ACE. In either case, inheritance is also controlled by the inheritance flags in the <see cref="ACE_HEADER"/> structure as well as by any protection against inheritance placed on the child objects.</para>
        /// </summary>
        public Guid InheritedObjectTypeGuid;
        /// <summary>
        /// A pointer to the SID of the trustee to whom the ACE applies.
        /// </summary>
        public SID* pSid;
    }
}

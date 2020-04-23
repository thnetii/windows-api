using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10272
    /// <summary>
    /// The <see cref="OBJECT_TYPE_LIST"/> structure identifies an object type element in a hierarchy of object types. The <see cref="AccessCheckByType"/> functions use an array of <see cref="OBJECT_TYPE_LIST"/> structures to define a hierarchy of an object and its subobjects, such as property sets and properties.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-object_type_list">OBJECT_TYPE_LIST structure</a></para>
    /// </remarks>
    /// <seealso cref="AccessCheckByType"/>
    /// <seealso cref="AccessCheckByTypeAndAuditAlarm"/>
    /// <seealso cref="AccessCheckByTypeResultList"/>
    /// <seealso cref="AccessCheckByTypeResultListAndAuditAlarm"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct OBJECT_TYPE_LIST
    {
        /// <summary>
        /// Specifies the level of the object type in the hierarchy of an object and its subobjects. Level zero indicates the object itself. Level one indicates a subobject of the object, such as a property set. Level two indicates a subobject of the level one subobject, such as a property. There can be a maximum of five levels numbered zero through four.
        /// </summary>
        public OBJECT_TYPE_LEVEL Level;
        /// <summary>
        /// Should be zero. Reserved for future use.
        /// </summary>
        public ushort Sbz;
        /// <summary>
        /// A pointer to the <see cref="Guid"/> for the object or subobject.
        /// </summary>
        public Guid* ObjectType;
    }
}

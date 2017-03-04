using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="OBJECT_TYPE_LIST"/> structure identifies an object type element in a hierarchy of object types. The <see cref="AccessCheckByType"/> functions use an array of <see cref="OBJECT_TYPE_LIST"/> structures to define a hierarchy of an object and its subobjects, such as property sets and properties.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379294.aspx">OBJECT_TYPE_LIST structure</a></para>
    /// </remarks>
    /// <seealso cref="AccessCheckByType"/>
    /// <seealso cref="AccessCheckByTypeAndAuditAlarm"/>
    /// <seealso cref="AccessCheckByTypeResultList"/>
    /// <seealso cref="AccessCheckByTypeResultListAndAuditAlarm"/>
    [StructLayout(LayoutKind.Sequential)]
    public class OBJECT_TYPE_LIST
    {
        /// <summary>
        /// Specifies the level of the object type in the hierarchy of an object and its subobjects. Level zero indicates the object itself. Level one indicates a subobject of the object, such as a property set. Level two indicates a subobject of the level one subobject, such as a property. There can be a maximum of five levels numbered zero through four.
        /// </summary>
        public short Level;
        /// <summary>Should be zero. Reserved for future use.</summary>
        public short Sbz;
        /// <summary>
        /// A pointer to the GUID for the object or subobject.
        /// </summary>
        public GuidAnySafeHandle ObjectType;
    }

    public class ObjectTypeListArrayAnySafeHandle : AnySafeHandle, ISafeHandleReadableAsSimpleStructureArray<OBJECT_TYPE_LIST>
    {
        protected ObjectTypeListArrayAnySafeHandle() : base() { }
        protected ObjectTypeListArrayAnySafeHandle(bool ownsHandle) : base(ownsHandle) { }
        protected ObjectTypeListArrayAnySafeHandle(IntPtr invalidHandleValue, bool ownsHandle = false) : base(invalidHandleValue, ownsHandle) { }
        public ObjectTypeListArrayAnySafeHandle(IntPtr invalidHandleValue, SafeHandle owningHandle) : base(invalidHandleValue, owningHandle) { }
    }
}
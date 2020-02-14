using System.Security.AccessControl;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h
    public static class AccCtrlConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 262
        //
        // Definition: Inheritance flags
        // These bit masks are provided to allow simple application of inheritance in
        // explicit access requests on containers.
        //
        /// <summary>
        /// The specific access permissions will only be applied to
        /// the container, and will not be inherited by objects created
        /// within the container.
        /// </summary>
        public const AceFlags NO_INHERITANCE = 0x0;
        /// <summary>
        /// The specific access permissions will only be inherited
        /// by objects created within the specific container.
        /// The access permissions will not be applied to the
        /// container itself.
        /// </summary>
        public const AceFlags SUB_OBJECTS_ONLY_INHERIT = (AceFlags)0x1;
        /// <summary>
        /// The specific access permissions will be inherited
        /// and applied to sub containers created within the
        /// container, and will be applied to the container
        /// itself.
        /// </summary>
        public const AceFlags SUB_CONTAINERS_ONLY_INHERIT = (AceFlags)0x2;
        /// <summary>
        /// The specific access permissions will be
        /// inherited by containers created within the
        /// specific container, will be applied to
        /// objects created within the container, but
        /// will not be applied to the container itself.
        /// </summary>
        public const AceFlags SUB_CONTAINERS_AND_OBJECTS_INHERIT = (AceFlags)0x3;
        /// <summary>
        /// Inherit but do not propagate.
        /// </summary>
        public const AceFlags INHERIT_NO_PROPAGATE = (AceFlags)0x4;
        /// <summary>
        /// Inherit only.
        /// </summary>
        public const AceFlags INHERIT_ONLY = (AceFlags)0x8;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 290
        //
        // Informational bit that is returned
        //
        public const int INHERITED_ACCESS_ENTRY = 0x10;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 295
        //
        // Informational bit that tells where a node was inherited from.  Valid only
        // for NT 5 APIs
        //
        public const int INHERITED_PARENT = 0x10000000;
        public const int INHERITED_GRANDPARENT = 0x20000000;
    }
}

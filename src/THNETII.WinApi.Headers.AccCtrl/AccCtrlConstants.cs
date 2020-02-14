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
        // NO_INHERITANCE       The specific access permissions will only be applied to
        //                  the container, and will not be inherited by objects created
        //                  within the container.
        // SUB_CONTAINERS_ONLY_INHERIT  The specific access permissions will be inherited
        //                              and applied to sub containers created within the
        //                              container, and will be applied to the container
        //                              itself.
        // SUB_OBJECTS_ONLY_INHERIT     The specific access permissions will only be inherited
        //                              by objects created within the specific container.
        //                              The access permissions will not be applied to the
        //                              container itself.
        // SUB_CONTAINERS_AND_OBJECTS_INHERIT   The specific access permissions will be
        //                                      inherited by containers created within the
        //                                      specific container, will be applied to
        //                                      objects created within the container, but
        //                                      will not be applied to the container itself.
        //
        public const int NO_INHERITANCE = 0x0;
        public const int SUB_OBJECTS_ONLY_INHERIT = 0x1;
        public const int SUB_CONTAINERS_ONLY_INHERIT = 0x2;
        public const int SUB_CONTAINERS_AND_OBJECTS_INHERIT = 0x3;
        public const int INHERIT_NO_PROPAGATE = 0x4;
        public const int INHERIT_ONLY = 0x8;

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

using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 751
    //
    // New Object Type function pointers.  TBD.
    // To support additional object resource managers generically, the
    // resource manager must provide it's own functions for operations
    // like:
    // GetAncestorAcl(IN ObjName, IN GenerationGap, IN DaclOrSacl?, ...)
    // GetAncestorName(...)
    // FreeNameStructure(...)
    //
    [StructLayout(LayoutKind.Sequential)]
    public struct FN_OBJECT_MGR_FUNCTS
    {
        public int Placeholder;
    }
}

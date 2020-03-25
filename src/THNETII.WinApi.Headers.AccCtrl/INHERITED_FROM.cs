using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 766
    //
    // Name of ancestor and number of generations between
    // ancestor and inheriting object.
    //
    // AncestorName:
    //     Name of ancestor from which ACE was inherited.
    //     NULL for explicit ACE.
    //
    // GenerationGap:
    //     Number of levels (or generations) between the object and the ancestor.
    //     Parent, gap=1.
    //     Grandparent, gap=2.
    //     Set to 0 for explicit ACE on object.
    //

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 781
    /// <inheritdoc cref="INHERITED_FROM"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct INHERITED_FROMA
    {
        /// <inheritdoc cref="INHERITED_FROM.GenerationGap"/>
        public int GenerationGap;
        /// <inheritdoc cref="INHERITED_FROM.AncestorName"/>
        public LPSTR AncestorName;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 693
    /// <inheritdoc cref="INHERITED_FROM"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct INHERITED_FROMW
    {
        /// <inheritdoc cref="INHERITED_FROM.GenerationGap"/>
        public int GenerationGap;
        /// <inheritdoc cref="INHERITED_FROM.AncestorName"/>
        public LPWSTR AncestorName;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 698
    /// <summary>
    /// The <see cref="INHERITED_FROM"/> structure provides information about an object's inherited <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">access control entry</a> (ACE).
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ns-accctrl-inherited_fromw">INHERITED_FROMW structure</a></para>
    /// </remarks>
    /// <seealso cref="FreeInheritedFromArray"/>
    /// <seealso cref="GetInheritanceSource"/>
#if !NETSTANDARD1_6
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif
    public struct INHERITED_FROM
    {
        /// <summary>
        /// Number of levels, or generations, between the object and the ancestor. Set this to zero for an explicit ACE. If the ancestor cannot be determined for the inherited ACE, set this member to <c>–1</c>.
        /// </summary>
        public int GenerationGap;
        /// <summary>
        /// Name of the ancestor from which the ACE was inherited. For an explicit ACE, set this to <see langword="null"/>.
        /// </summary>
        public LPTSTR AncestorName;
    }
}

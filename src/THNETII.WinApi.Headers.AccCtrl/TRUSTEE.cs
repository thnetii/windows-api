using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.AccCtrl
{
    using static TRUSTEE_FORM;
    using static MULTIPLE_TRUSTEE_OPERATION;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 155
    //
    // Definition: TRUSTEE
    // This structure is used to pass account information into and out of the system
    // using the API defined in this document.
    // PMultipleTrustee     - if NON-NULL, points to another trustee structure, as
    //                    defined by the multiple trustee operation field.
    // MultipleTrusteeOperation - Defines the multiple trustee operation/type.
    // TrusteeForm - defines if the trustee is defined by name or SID.
    // TrusteeType - defines if the trustee type is unknown, a user or a group.
    // PwcsName     - points to the trustee name or the trustee SID.
    //

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 167
    /// <inheritdoc cref="TRUSTEE"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct TRUSTEE_A
    {
        /// <inheritdoc cref="TRUSTEE.pMultipleTrustee"/>
        public TRUSTEE_A* pMultipleTrustee;
        /// <inheritdoc cref="TRUSTEE.MultipleTrusteeOperation"/>
        public MULTIPLE_TRUSTEE_OPERATION MultipleTrusteeOperation;
        /// <inheritdoc cref="TRUSTEE.TrusteeForm"/>
        public TRUSTEE_FORM TrusteeForm;
        /// <inheritdoc cref="TRUSTEE.TrusteeType"/>
        public TRUSTEE_TYPE TrusteeType;
        internal IntPtr pValue;
        /// <inheritdoc cref="TRUSTEE.ptstrName"/>
        public LPSTR ptstrName
        {
            get => TrusteeForm == TRUSTEE_IS_NAME
                ? Pointer.Create<LPSTR>(pValue)
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(ptstrName), TRUSTEE_IS_NAME, TrusteeForm));
            set => pValue = TrusteeForm == TRUSTEE_IS_NAME
                ? value.Pointer
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(ptstrName), TRUSTEE_IS_NAME, TrusteeForm));
        }
        /// <inheritdoc cref="TRUSTEE.pSid"/>
        public SID* pSid
        {
            get => TrusteeForm == TRUSTEE_IS_SID
                ? (SID*)pValue
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(pSid), TRUSTEE_IS_SID, TrusteeForm));
            set => pValue = TrusteeForm == TRUSTEE_IS_SID
                ? (IntPtr)value
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(pSid), TRUSTEE_IS_SID, TrusteeForm));
        }
        /// <inheritdoc cref="TRUSTEE.pObjectsAndSid"/>
        public OBJECTS_AND_SID* pObjectsAndSid
        {
            get => TrusteeForm == TRUSTEE_IS_OBJECTS_AND_SID
                ? (OBJECTS_AND_SID*)pValue
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(pObjectsAndSid), TRUSTEE_IS_OBJECTS_AND_SID, TrusteeForm));
            set => pValue = TrusteeForm == TRUSTEE_IS_OBJECTS_AND_SID
                ? (IntPtr)value
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(pObjectsAndSid), TRUSTEE_IS_OBJECTS_AND_SID, TrusteeForm));
        }
        /// <inheritdoc cref="TRUSTEE.pObjectsAndName"/>
        public OBJECTS_AND_NAME_A* pObjectsAndName
        {
            get => TrusteeForm == TRUSTEE_IS_OBJECTS_AND_NAME
                ? (OBJECTS_AND_NAME_A*)pValue
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(pObjectsAndName), TRUSTEE_IS_OBJECTS_AND_NAME, TrusteeForm));
            set => pValue = TrusteeForm == TRUSTEE_IS_OBJECTS_AND_NAME
                ? (IntPtr)value
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(pObjectsAndName), TRUSTEE_IS_OBJECTS_AND_NAME, TrusteeForm));
        }
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 167
    /// <inheritdoc cref="TRUSTEE"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct TRUSTEE_W
    {
        /// <inheritdoc cref="TRUSTEE.pMultipleTrustee"/>
        public TRUSTEE_W* pMultipleTrustee;
        /// <inheritdoc cref="TRUSTEE.MultipleTrusteeOperation"/>
        public MULTIPLE_TRUSTEE_OPERATION MultipleTrusteeOperation;
        /// <inheritdoc cref="TRUSTEE.TrusteeForm"/>
        public TRUSTEE_FORM TrusteeForm;
        /// <inheritdoc cref="TRUSTEE.TrusteeType"/>
        public TRUSTEE_TYPE TrusteeType;
        internal IntPtr pValue;
        /// <inheritdoc cref="TRUSTEE.ptstrName"/>
        public LPWSTR ptstrName
        {
            get => TrusteeForm == TRUSTEE_IS_NAME
                ? Pointer.Create<LPWSTR>(pValue)
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(ptstrName), TRUSTEE_IS_NAME, TrusteeForm));
            set => pValue = TrusteeForm == TRUSTEE_IS_NAME
                ? value.Pointer
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(ptstrName), TRUSTEE_IS_NAME, TrusteeForm));
        }
        /// <inheritdoc cref="TRUSTEE.pSid"/>
        public SID* pSid
        {
            get => TrusteeForm == TRUSTEE_IS_SID
                ? (SID*)pValue
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(pSid), TRUSTEE_IS_SID, TrusteeForm));
            set => pValue = TrusteeForm == TRUSTEE_IS_SID
                ? (IntPtr)value
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(pSid), TRUSTEE_IS_SID, TrusteeForm));
        }
        /// <inheritdoc cref="TRUSTEE.pObjectsAndSid"/>
        public OBJECTS_AND_SID* pObjectsAndSid
        {
            get => TrusteeForm == TRUSTEE_IS_OBJECTS_AND_SID
                ? (OBJECTS_AND_SID*)pValue
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(pObjectsAndSid), TRUSTEE_IS_OBJECTS_AND_SID, TrusteeForm));
            set => pValue = TrusteeForm == TRUSTEE_IS_OBJECTS_AND_SID
                ? (IntPtr)value
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(pObjectsAndSid), TRUSTEE_IS_OBJECTS_AND_SID, TrusteeForm));
        }
        /// <inheritdoc cref="TRUSTEE.pObjectsAndName"/>
        public OBJECTS_AND_NAME_W* pObjectsAndName
        {
            get => TrusteeForm == TRUSTEE_IS_OBJECTS_AND_NAME
                ? (OBJECTS_AND_NAME_W*)pValue
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(pObjectsAndName), TRUSTEE_IS_OBJECTS_AND_NAME, TrusteeForm));
            set => pValue = TrusteeForm == TRUSTEE_IS_OBJECTS_AND_NAME
                ? (IntPtr)value
                : throw new InvalidOperationException(TRUSTEE.GetTrusteeFormExceptionMessage(nameof(pObjectsAndName), TRUSTEE_IS_OBJECTS_AND_NAME, TrusteeForm));
        }
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 167
    /// <summary>
    /// <para>The <see cref="TRUSTEE"/> structure identifies the user account, group account, or <a href="https://docs.microsoft.com/windows/desktop/SecGloss/l-gly">logon session</a> to which an <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">access control entry</a> (ACE) applies. The structure can use a name or a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security identifier</a> (SID) to identify the trustee.</para>
    /// <para>Access control functions, such as <see cref="SetEntriesInAcl"/> and <see cref="GetExplicitEntriesFromAcl"/>, use this structure to identify the logon account associated with the access control or audit control information in an <see cref="EXPLICIT_ACCESS"/> structure.</para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// A trustee name can have any of the following formats:
    /// <list type="bullet">
    /// <item>A fully qualified name, such as "g:\remotedir\abc".</item>
    /// <item>A domain account, such as "domain1\xyz".</item>
    /// <item>One of the predefined group names, such as "EVERYONE" or "GUEST".</item>
    /// <item>
    /// One of the following special names.
    /// <list type="table">
    /// <listheader><term>Name</term><description>Meaning</description></listheader>
    /// <item><term><c>CREATOR_GROUP</c></term><description>The <c>CREATOR_GROUP</c> SID is a SID used in inheritable ACEs. When a new object is created, the system replaces this SID with the primary group SID of the user who created the object.</description></item>
    /// <item><term><c>CREATOR_OWNER</c></term><description>The <c>CREATOR_OWNER</c> SID is a SID used in inheritable ACEs. When a new object is created, the system replaces this SID with the SID of the user who created the object.</description></item>
    /// <item><term><c>CURRENT_USER</c></term><description>The owner of the calling thread or process.</description></item>
    /// </list>
    /// </item>
    /// </list>
    /// </para>
    /// <para>A trustee SID can be any user or group SID. It can also be any of the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/u-gly">universal, well-known SIDs</a>. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthZ/security-identifiers">Security Identifiers</a>.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ns-accctrl-trustee_w">TRUSTEE_W structure</a></para>
    /// </remarks>
    /// <seealso cref="ACL"/>
    /// <seealso cref="EXPLICIT_ACCESS"/>
    /// <seealso cref="GetExplicitEntriesFromAcl"/>
    /// <seealso cref="MULTIPLE_TRUSTEE_OPERATION"/>
    /// <seealso cref="OBJECTS_AND_NAME"/>
    /// <seealso cref="OBJECTS_AND_SID"/>
    /// <seealso cref="SID"/>
    /// <seealso cref="SetEntriesInAcl"/>
    /// <seealso cref="TRUSTEE_FORM"/>
    /// <seealso cref="TRUSTEE_TYPE"/>
#if !NETSTANDARD1_6
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif
    public unsafe struct TRUSTEE
    {
        /// <summary>
        /// A pointer to a <see cref="TRUSTEE"/> structure that identifies a server account that can impersonate the user identified by the <see cref="ptstrName"/> member. This member is not currently supported and must be <see langword="null"/>.
        /// </summary>
        public TRUSTEE* pMultipleTrustee;
        /// <summary>
        /// A value of the <see cref="MULTIPLE_TRUSTEE_OPERATION"/> enumeration type. Currently, this member must be <see cref="NO_MULTIPLE_TRUSTEE"/>.
        /// </summary>
        public MULTIPLE_TRUSTEE_OPERATION MultipleTrusteeOperation;
        /// <summary>
        /// A value from the <see cref="TRUSTEE_FORM"/> enumeration type that indicates the type of data pointed to by the <see cref="ptstrName"/> member.
        /// </summary>
        public TRUSTEE_FORM TrusteeForm;
        /// <summary>
        /// A value from the <see cref="TRUSTEE_TYPE"/> enumeration type that indicates whether the trustee is a user account, a group account, or an unknown account type.
        /// </summary>
        public TRUSTEE_TYPE TrusteeType;
        internal IntPtr pValue;
        /// <summary>
        /// A pointer to a null-terminated string that contains the name of the trustee.
        /// <para>This member can only be accessed when <see cref="TrusteeForm"/> is <see cref="TRUSTEE_IS_NAME"/>.</para>
        /// </summary>
        public LPTSTR ptstrName
        {
            get => TrusteeForm == TRUSTEE_IS_NAME
                ? Pointer.Create<LPTSTR>(pValue)
                : throw new InvalidOperationException(GetTrusteeFormExceptionMessage(nameof(ptstrName), TRUSTEE_IS_NAME, TrusteeForm));
            set => pValue = TrusteeForm == TRUSTEE_IS_NAME
                ? value.Pointer
                : throw new InvalidOperationException(GetTrusteeFormExceptionMessage(nameof(ptstrName), TRUSTEE_IS_NAME, TrusteeForm));
        }
        /// <summary>
        /// Pointer to the SID of the trustee.
        /// <para>This member can only be accessed when <see cref="TrusteeForm"/> is <see cref="TRUSTEE_IS_SID"/>.</para>
        /// </summary>
        public SID* pSid
        {
            get => TrusteeForm == TRUSTEE_IS_SID
                ? (SID*)pValue
                : throw new InvalidOperationException(GetTrusteeFormExceptionMessage(nameof(pSid), TRUSTEE_IS_SID, TrusteeForm));
            set => pValue = TrusteeForm == TRUSTEE_IS_SID
                ? (IntPtr)value
                : throw new InvalidOperationException(GetTrusteeFormExceptionMessage(nameof(pSid), TRUSTEE_IS_SID, TrusteeForm));
        }
        /// <summary>
        /// A pointer to an <see cref="OBJECTS_AND_SID"/> structure that contains the SID of the trustee and the GUIDs of the object types in an object-specific ACE.
        /// <para>This member can only be accessed when <see cref="TrusteeForm"/> is <see cref="TRUSTEE_IS_OBJECTS_AND_SID"/>.</para>
        /// </summary>
        public OBJECTS_AND_SID* pObjectsAndSid
        {
            get => TrusteeForm == TRUSTEE_IS_OBJECTS_AND_SID
                ? (OBJECTS_AND_SID*)pValue
                : throw new InvalidOperationException(GetTrusteeFormExceptionMessage(nameof(pObjectsAndSid), TRUSTEE_IS_OBJECTS_AND_SID, TrusteeForm));
            set => pValue = TrusteeForm == TRUSTEE_IS_OBJECTS_AND_SID
                ? (IntPtr)value
                : throw new InvalidOperationException(GetTrusteeFormExceptionMessage(nameof(pObjectsAndSid), TRUSTEE_IS_OBJECTS_AND_SID, TrusteeForm));
        }
        /// <summary>
        /// A pointer to an <see cref="OBJECTS_AND_NAME"/> structure that contains the name of the trustee and the names of the object types in an object-specific ACE.
        /// <para>This member can only be accessed when <see cref="TrusteeForm"/> is <see cref="TRUSTEE_IS_OBJECTS_AND_NAME"/>.</para>
        /// </summary>
        public OBJECTS_AND_NAME* pObjectsAndName
        {
            get => TrusteeForm == TRUSTEE_IS_OBJECTS_AND_NAME
                ? (OBJECTS_AND_NAME*)pValue
                : throw new InvalidOperationException(GetTrusteeFormExceptionMessage(nameof(pObjectsAndName), TRUSTEE_IS_OBJECTS_AND_NAME, TrusteeForm));
            set => pValue = TrusteeForm == TRUSTEE_IS_OBJECTS_AND_NAME
                ? (IntPtr)value
                : throw new InvalidOperationException(GetTrusteeFormExceptionMessage(nameof(pObjectsAndName), TRUSTEE_IS_OBJECTS_AND_NAME, TrusteeForm));
        }

        internal static string GetTrusteeFormExceptionMessage(string field, TRUSTEE_FORM expectedForm, TRUSTEE_FORM currentForm) =>
            $"{field} may only be access when {nameof(TrusteeForm)} is {expectedForm}, but {nameof(TrusteeForm)} is {currentForm}";
    }
}

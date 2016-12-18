using System.Runtime.InteropServices;
using System.Security.AccessControl;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.ACCESS_MASK;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="SECURITY_INFORMATION"/> data type identifies the object-related security information being set or queried. This security information includes: 
    /// <list type="bullet">
    /// <item>The owner of an object.</item>
    /// <item>The primary group of an object.</item>
    /// <item>The <em><a href="https://msdn.microsoft.com/en-us/library/ms721573.aspx#_security_discretionary_access_control_list_gly">discretionary access control list</a></em> (DACL) of an object</item>
    /// <item>The <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_system_access_control_list_gly">system access control list</a></em> (SACL) of an object</item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>Some <see cref="SECURITY_INFORMATION"/> members work only with the <see cref="SetNamedSecurityInfo"/> function. These members are not returned in the structure returned by other security functions such as <see cref="GetNamedSecurityInfo"/> or <see cref="ConvertStringSecurityDescriptorToSecurityDescriptor"/>.</para>
    /// <para>Each item of security information is designated by a bit flag. For more information, see the <see cref="SetSecurityAccessMask"/> and <see cref="QuerySecurityAccessMask"/> functions.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379573.aspx">SECURITY_INFORMATION</a></para>
    /// </remarks>
    /// <seealso cref="ConvertSecurityDescriptorToStringSecurityDescriptor"/>
    /// <seealso cref="ConvertStringSecurityDescriptorToSecurityDescriptor"/>
    /// <seealso cref="GetFileSecurity"/>
    /// <seealso cref="GetKernelObjectSecurity"/>
    /// <seealso cref="GetNamedSecurityInfo"/>
    /// <seealso cref="GetPrivateObjectSecurity"/>
    /// <seealso cref="GetSecurityInfo"/>
    /// <seealso cref="GetUserObjectSecurity"/>
    /// <seealso cref="QuerySecurityAccessMask"/>
    /// <seealso cref="SetFileSecurity"/>
    /// <seealso cref="SetKernelObjectSecurity"/>
    /// <seealso cref="SetNamedSecurityInfo"/>
    /// <seealso cref="SetPrivateObjectSecurity"/>
    /// <seealso cref="SetSecurityAccessMask"/>
    /// <seealso cref="SetSecurityInfo"/>
    /// <seealso cref="SetUserObjectSecurity"/>
    /// <seealso cref="TreeResetNamedSecurityInfo"/>
    /// <seealso cref="TreeSetNamedSecurityInfo"/>
    /// <seealso cref="SecurityInfos"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_INFORMATION
    {
        /// <summary>
        /// The owner identifier of the object is being referenced.
        /// <para>Right required to query: <see cref="READ_CONTROL"/> <br/> Right required to set: <see cref="WRITE_OWNER"/></para>
        /// </summary>
        public static readonly SECURITY_INFORMATION OWNER_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)0x00000001 };
        /// <summary>
        /// The primary group identifier of the object is being referenced.
        /// <para>Right required to query: <see cref="READ_CONTROL"/> <br/> Right required to set: <see cref="WRITE_OWNER"/></para>
        /// </summary>
        public static readonly SECURITY_INFORMATION GROUP_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)0x00000002 };
        /// <summary>
        /// The DACL of the object is being referenced.
        /// <para>Right required to query: <see cref="READ_CONTROL"/> <br/> Right required to set: <see cref="WRITE_DAC"/></para>
        /// </summary>
        public static readonly SECURITY_INFORMATION DACL_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)0x00000004 };
        /// <summary>
        /// The SACL of the object is being referenced.
        /// <para>Right required to query: <see cref="ACCESS_SYSTEM_SECURITY"/> <br/> Right required to set: <see cref="ACCESS_SYSTEM_SECURITY"/></para>
        /// </summary>
        public static readonly SECURITY_INFORMATION SACL_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)0x00000008 };
        /// <summary>
        /// <para>The mandatory integrity label is being referenced.</para>
        /// <para>The mandatory integrity label is an ACE in the SACL of the object.</para>
        /// <para><strong>Windows Server 2003 and Windows XP:</strong> This bit flag is not available.</para>
        /// <para>Right required to query: <see cref="READ_CONTROL"/> <br/> Right required to set: <see cref="WRITE_OWNER"/></para>
        /// </summary>
        public static readonly SECURITY_INFORMATION LABEL_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)0x00000010 };
        /// <summary>
        /// The resource properties of the object being referenced. The resource properties are stored in SYSTEM_RESOURCE_ATTRIBUTE_ACE types in the SACL of the security descriptor.
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This bit flag is not available.</para>
        /// <para>Right required to query: <see cref="READ_CONTROL"/> <br/> Right required to set: <see cref="WRITE_DAC"/></para>
        /// </summary>
        public static readonly SECURITY_INFORMATION ATTRIBUTE_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)0x00000020 };
        /// <summary>
        /// The Central Access Policy (CAP) identifier applicable on the object that is being referenced. Each CAP identifier is stored in a SYSTEM_SCOPED_POLICY_ID_ACE type in the SACL of the SD.
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This bit flag is not available.</para>
        /// <para>Right required to query: <see cref="READ_CONTROL"/> <br/> Right required to set: <see cref="ACCESS_SYSTEM_SECURITY"/></para>
        /// </summary>
        public static readonly SECURITY_INFORMATION SCOPE_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)0x00000040 };
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly SECURITY_INFORMATION PROCESS_TRUST_LABEL_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)0x00000080 };
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        /// <summary>
        /// All parts of the security descriptor. This is useful for backup and restore software that needs to preserve the entire security descriptor.
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong>  This bit flag is not available.</para>
        /// <para>Right required to query: <see cref="READ_CONTROL"/> and <see cref="ACCESS_SYSTEM_SECURITY"/> <br/> Right required to set: <see cref="WRITE_DAC"/> and <see cref="WRITE_OWNER"/> and <see cref="ACCESS_SYSTEM_SECURITY"/></para>
        /// </summary>
        public static readonly SECURITY_INFORMATION BACKUP_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)0x00010000 };

        /// <summary>
        /// The DACL cannot inherit <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_entry_gly">access control entries</a></em> (ACEs).
        /// <para>Right required to query: Not available <br/> Right required to set: <see cref="WRITE_DAC"/></para>
        /// </summary>
        public static readonly SECURITY_INFORMATION PROTECTED_DACL_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)unchecked((int)0x80000000) };
        /// <summary>
        /// The SACL cannot inherit ACEs.
        /// <para>Right required to query: Not available <br/> Right required to set: <see cref="ACCESS_SYSTEM_SECURITY"/></para>
        /// </summary>
        public static readonly SECURITY_INFORMATION PROTECTED_SACL_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)0x40000000 };
        /// <summary>
        /// The DACL inherits ACEs from the parent object.
        /// <para>Right required to query: Not available <br/> Right required to set: <see cref="WRITE_DAC"/></para>
        /// </summary>
        public static readonly SECURITY_INFORMATION UNPROTECTED_DACL_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)0x20000000 };
        /// <summary>
        /// The SACL inherits ACEs from the parent object.
        /// <para>Right required to query: Not available <br/> Right required to set: <see cref="ACCESS_SYSTEM_SECURITY"/></para>
        /// </summary>
        public static readonly SECURITY_INFORMATION UNPROTECTED_SACL_SECURITY_INFORMATION = new SECURITY_INFORMATION { value = (SecurityInfos)0x10000000 };

        [MarshalAs(UnmanagedType.I4)]
        private SecurityInfos value;

        /// <inheritdoc />
        public override int GetHashCode() => value.GetHashCode();
        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
                return false;
            try { return ((SECURITY_INFORMATION)obj).value == value; }
            catch { return false; }
        }

        /// <summary>Checks two <see cref="SECURITY_INFORMATION"/> values for equality.</summary>
        /// <param name="l">The left operand</param>
        /// <param name="r">The right operand</param>
        /// <returns><c>true</c> if <paramref name="l"/> is equal to <paramref name="r"/>; otherwise, <c>false</c>.</returns>
        public static bool operator ==(SECURITY_INFORMATION l, SECURITY_INFORMATION r) => l.value == r.value;
        /// <summary>Checks two <see cref="SECURITY_INFORMATION"/> values for inequality.</summary>
        /// <param name="l">The left operand</param>
        /// <param name="r">The right operand</param>
        /// <returns><c>true</c> if <paramref name="l"/> is not equal to <paramref name="r"/>; otherwise, <c>false</c>.</returns>
        public static bool operator !=(SECURITY_INFORMATION l, SECURITY_INFORMATION r) => l.value != r.value;
        /// <summary>Checks a <see cref="SECURITY_INFORMATION"/> value and a <see cref="SecurityInfos"/> value for equality.</summary>
        /// <param name="l">The left operand</param>
        /// <param name="r">The right operand</param>
        /// <returns><c>true</c> if <paramref name="l"/> is equal to <paramref name="r"/>; otherwise, <c>false</c>.</returns>
        public static bool operator ==(SECURITY_INFORMATION l, SecurityInfos r) => l.value == r;
        /// <summary>Checks a <see cref="SECURITY_INFORMATION"/> value and a <see cref="SecurityInfos"/> value for inequality.</summary>
        /// <param name="l">The left operand</param>
        /// <param name="r">The right operand</param>
        /// <returns><c>true</c> if <paramref name="l"/> is not equal to <paramref name="r"/>; otherwise, <c>false</c>.</returns>
        public static bool operator !=(SECURITY_INFORMATION l, SecurityInfos r) => l.value != r;
        /// <summary>Checks a <see cref="SecurityInfos"/> value and a <see cref="SECURITY_INFORMATION"/> value for equality.</summary>
        /// <param name="l">The left operand</param>
        /// <param name="r">The right operand</param>
        /// <returns><c>true</c> if <paramref name="l"/> is equal to <paramref name="r"/>; otherwise, <c>false</c>.</returns>
        public static bool operator ==(SecurityInfos l, SECURITY_INFORMATION r) => l == r.value;
        /// <summary>Checks a <see cref="SecurityInfos"/> value and a <see cref="SECURITY_INFORMATION"/> value for inequality.</summary>
        /// <param name="l">The left operand</param>
        /// <param name="r">The right operand</param>
        /// <returns><c>true</c> if <paramref name="l"/> is not equal to <paramref name="r"/>; otherwise, <c>false</c>.</returns>
        public static bool operator !=(SecurityInfos l, SECURITY_INFORMATION r) => l != r.value;
        /// <summary>Provides the implicit casting operator to convert a <see cref="SECURITY_INFORMATION"/> value into a <see cref="SecurityInfos"/> value.</summary>
        /// <param name="v">A <see cref="SECURITY_INFORMATION"/> value to be converted into a <see cref="SecurityInfos"/> value.</param>
        public static implicit operator SecurityInfos(SECURITY_INFORMATION v) => v.value;
        /// <summary>Provides the implicit casting operator to convert a <see cref="SecurityInfos"/> value into a <see cref="SECURITY_INFORMATION"/> value.</summary>
        /// <param name="v">A <see cref="SecurityInfos"/> value to be converted into a <see cref="SECURITY_INFORMATION"/> value.</param>
        public static implicit operator SECURITY_INFORMATION(SecurityInfos v) => new SECURITY_INFORMATION { value = v };
    }
}

using Microsoft.Win32.WinApi.WinError;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NET_VALIDATE_PASSWORD_TYPE;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="NET_VALIDATE_OUTPUT_ARG"/> structure contains information about persistent password-related data that has changed since the user's last logon as well as the result of the function's password validation check.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="NetValidatePasswordPolicy"/> function outputs the <see cref="NET_VALIDATE_OUTPUT_ARG"/> structure. </para>
    /// <para>Note that it is the application's responsibility to save all the data in the <see cref="ChangedPersistedFields"/> member of the <see cref="NET_VALIDATE_OUTPUT_ARG"/> structure as well as any User object information. The next time the application calls <see cref="NetValidatePasswordPolicy"/> on the same instance of the User object, the application must provide the required fields from the persistent information.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370686.aspx">NET_VALIDATE_OUTPUT_ARG structure</a></para>
    /// </remarks>
    /// <seealso cref="NetValidatePasswordPolicy"/>
    [StructLayout(LayoutKind.Sequential)]
    public class NET_VALIDATE_OUTPUT_ARG
    {
        /// <summary>
        /// A structure that contains changes to persistent information about the account being logged on. For more information, see the following Remarks section.
        /// </summary>
        public NET_VALIDATE_PERSISTED_FIELDS ChangedPersistedFields;
        /// <summary>
        /// The result of the password validation check performed by the <see cref="NetValidatePasswordPolicy"/> function.
        /// </summary>
        /// <remarks>
        /// The status depends on the value specified in the <em>ValidationType</em> parameter to that function.
        /// <para>
        /// <strong>Authentication</strong>. When you call <see cref="NetValidatePasswordPolicy"/> and specify the <em>ValidationType</em> parameter as <see cref="NetValidateAuthentication"/>, this member can be one of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><see cref="NERR_AccountLockedOut"/></term> <description>Validation failed. The account is locked out. </description>
        /// <term><see cref="NERR_PasswordMustChange"/></term> <description>Validation failed. The password must change at the next logon. </description>
        /// <term><see cref="NERR_PasswordExpired"/></term> <description>Validation failed. The password has expired. </description>
        /// <term><see cref="NERR_BadPassword"/></term> <description>Validation failed. The password is invalid. </description>
        /// <term><see cref="NERR_Success"/></term> <description>The password passes the validation check.</description>
        /// </list>
        /// </para>
        /// <para>
        /// <strong>Password change</strong>. When you call <see cref="NetValidatePasswordPolicy"/> and specify the <em>ValidationType</em> parameter as <see cref="NetValidatePasswordChange"/>, this member can be one of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><see cref="NERR_AccountLockedOut"/></term> <description>Validation failed. The account is locked out. </description>
        /// <term><see cref="NERR_PasswordTooRecent"/></term> <description>Validation failed. The password for the user is too recent to change. </description>
        /// <term><see cref="NERR_BadPassword"/></term> <description>Validation failed. The password is invalid. </description>
        /// <term><see cref="NERR_PasswordHistConflict"/></term> <description>Validation failed. The password cannot be used at this time. </description>
        /// <term><see cref="NERR_PasswordTooShort"/></term> <description>Validation failed. The password does not meet policy requirements because it is too short. </description>
        /// <term><see cref="NERR_PasswordTooLong"/></term> <description>Validation failed. The password does not meet policy requirements because it is too long. </description>
        /// <term><see cref="NERR_PasswordNotComplexEnough"/></term> <description>Validation failed. The password does not meet policy requirements because it is not complex enough. </description>
        /// <term><see cref="NERR_PasswordFilterError"/></term> <description>Validation failed. The password does not meet the requirements of the password filter DLL. </description>
        /// <term><see cref="NERR_Success"/></term> <description>The password passes the validation check.</description>
        /// </list>
        /// </para>
        /// <para>
        /// <strong>Password reset</strong>. When you call <see cref="NetValidatePasswordPolicy"/> and specify the <em>ValidationType</em> parameter as <see cref="NetValidatePasswordReset"/>, this member can be one of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><see cref="NERR_PasswordTooShort"/></term> <description>Validation failed. The password does not meet policy requirements because it is too short. </description>
        /// <term><see cref="NERR_PasswordTooLong"/></term> <description>Validation failed. The password does not meet policy requirements because it is too long. </description>
        /// <term><see cref="NERR_PasswordNotComplexEnough"/></term> <description>Validation failed. The password does not meet policy requirements because it is not complex enough. </description>
        /// <term><see cref="NERR_PasswordFilterError"/></term> <description>Validation failed. The password does not meet the requirements of the password filter DLL. </description>
        /// <term><see cref="NERR_Success"/></term> <description>The password passes the validation check.</description>
        /// </list>
        /// </para>
        /// </remarks>
        [MarshalAs(UnmanagedType.I4)]
        public Win32ErrorCode ValidationStatus;
    }
}

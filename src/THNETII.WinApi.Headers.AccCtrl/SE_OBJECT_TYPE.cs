using System.Security.AccessControl;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 40
    //
    // Definition:
    // This enumerated type defines the objects supported by the get/set API within
    // this document.  See section 3.1, Object Types for a detailed definition of the
    // supported object types, and their name formats.
    //
    /// <summary>
    /// The <see cref="SE_OBJECT_TYPE"/> enumeration contains values that correspond to the types of Windows objects that support security. The functions, such as <see cref="GetSecurityInfo"/> and <see cref="SetSecurityInfo"/>, that set and retrieve the security information of an object, use these values to indicate the type of object.
    /// <para>This is the native type definition that is identical to <see cref="ResourceType"/> in managed code.</para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ne-accctrl-se_object_type">SE_OBJECT_TYPE enumeration</a></para>
    /// </remarks>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthZ/access-control">Access Control Overview</seealso>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthZ/authorization-enumerations">Authorization Enumerations</seealso>
    /// <seealso cref="GetNamedSecurityInfo"/>
    /// <seealso cref="GetSecurityInfo"/>
    /// <seealso cref="SetNamedSecurityInfo"/>
    /// <seealso cref="SetSecurityInfo"/>
    /// <seealso cref="ResourceType"/>
    public enum SE_OBJECT_TYPE
    {
        /// <summary>
        /// Unknown object type.
        /// </summary>
        SE_UNKNOWN_OBJECT_TYPE = 0,
        /// <summary>
        /// Indicates a file or directory. The name string that identifies a file or directory object can be in one of the following formats:
        /// <list type="bullet">
        /// <item>A relative path, such as <em>FileName.dat</em> or <em>..\FileName.dat</em></item>
        /// <item>An absolute path, such as <em>FileName.dat</em>, <em>C:\DirectoryName\FileName.dat</em>, or <em>G:\RemoteDirectoryName\FileName.dat</em>.</item>
        /// <item>A UNC name, such as <em>\\ComputerName\ShareName\FileName.dat</em>.</item>
        /// </list>
        /// </summary>
        SE_FILE_OBJECT,
        /// <summary>
        /// Indicates a Windows service. A service object can be a local service, such as <em>ServiceName</em>, or a remote service, such as <em>\\ComputerName\ServiceName</em>.
        /// </summary>
        SE_SERVICE,
        /// <summary>
        /// Indicates a printer. A printer object can be a local printer, such as <em>PrinterName</em>, or a remote printer, such as <em>\\ComputerName\PrinterName</em>.
        /// </summary>
        SE_PRINTER,
        /// <summary>
        /// Indicates a registry key. A registry key object can be in the local registry, such as <em><strong>CLASSES_ROOT</strong>\SomePath</em> or in a remote registry, such as <em>\\ComputerName\<strong>CLASSES_ROOT</strong>\SomePath</em>.
        /// <para>
        /// The names of registry keys must use the following literal strings to identify the predefined registry keys: <c>"CLASSES_ROOT"</c>, <c>"CURRENT_USER"</c>, <c>"MACHINE"</c>, and <c>"USERS"</c>.
        /// </para>
        /// </summary>
        SE_REGISTRY_KEY,
        /// <summary>
        /// Indicates a network share. A share object can be local, such as <em>ShareName</em>, or remote, such as <em>\\ComputerName\ShareName</em>.
        /// </summary>
        SE_LMSHARE,
        /// <summary>
        /// Indicates a local <a href="https://docs.microsoft.com/windows/desktop/SysInfo/kernel-objects">kernel object</a>.
        /// <para>The <see cref="GetSecurityInfo"/> and <see cref="SetSecurityInfo"/> functions support all types of kernel objects. The <see cref="GetNamedSecurityInfo"/> and <see cref="SetNamedSecurityInfo"/> functions work only with the following kernel objects: semaphore, event, mutex, waitable timer, and file mapping.</para>
        /// </summary>
        SE_KERNEL_OBJECT,
        /// <summary>
        /// Indicates a window station or desktop object on the local computer. You cannot use
        /// <see cref="GetNamedSecurityInfo"/> and
        /// <see cref="SetNamedSecurityInfo"/> with these objects because the names of window stations or desktops are not unique.
        /// </summary>
        SE_WINDOW_OBJECT,
        /// <summary>
        /// <para>Indicates a directory service object or a property set or property of a directory service object.</para>
        /// <para>
        /// The name string for a directory service object must be in X.500 form, for example:
        /// <code>
        /// CN=SomeObject,OU=ou2,OU=ou1,DC=DomainName,DC=CompanyName,DC=com,O=internet
        /// </code>
        /// </para>
        /// </summary>
        SE_DS_OBJECT,
        /// <summary>
        /// Indicates a directory service object and all of its property sets and properties.
        /// </summary>
        SE_DS_OBJECT_ALL,
        /// <summary>
        /// Indicates a provider-defined object.
        /// </summary>
        SE_PROVIDER_DEFINED_OBJECT,
        /// <summary>
        /// Indicates a WMI object.
        /// </summary>
        SE_WMIGUID_OBJECT,
        /// <summary>
        /// Indicates an object for a registry entry under WOW64.
        /// </summary>
        SE_REGISTRY_WOW64_32KEY,
        SE_REGISTRY_WOW64_64KEY,
    }
}

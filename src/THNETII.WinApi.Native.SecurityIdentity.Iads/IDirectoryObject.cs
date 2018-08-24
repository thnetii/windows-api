using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="IDirectoryObject"/> interface is a non-Automation COM interface that provides clients with direct access to directory service objects. The interface enables access by means of a direct over-the-wire protocol, rather than through the ADSI attribute cache. Using the over-the-wire protocol optimizes performance. With <see cref="IDirectoryObject"/>, a client can get, or set, any number of object attributes with one method call. Unlike the corresponding Automation methods, which are invoked in batch, those of <see cref="IDirectoryObject"/> are executed when they are called. <see cref="IDirectoryObject"/> performs no attribute caching.
    /// <para>Non-Automation clients can call the methods of <see cref="IDirectoryObject"/> to optimize performance and take advantage of native directory service interfaces. Automation clients cannot use <see cref="IDirectoryObject"/>. Instead, they should use the <see cref="IADs"/> interface.</para>
    /// <para>Of the ADSI system-supplied providers, only the LDAP provider supports this interface.</para>
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/adsprop/ns-adsprop-idirectoryobject">IDirectoryObject interface</a></para>
    /// </remarks>
    /// <seealso cref="IADs"/>
    [Guid("e798de2c-22e4-11d0-84fe-00c04fd8d503")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDirectoryObject
    {

    }
}

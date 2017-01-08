using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
	/// <summary>
	///	The <see cref="LOCALGROUP_USERS_INFO_0"/> structure contains local group member information.
	/// </summary>
	/// <remarks>
    /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
	/// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370282.aspx">LOCALGROUP_USERS_INFO_0 structure</a></para>
	/// </remarks>
	/// <seealso cref="NetUserGetLocalGroups"/>
	[StructLayout(LayoutKind.Sequential)]
	public class LOCALGROUP_USERS_INFO_0
	{
		/// <summary>
		///	A Unicode string specifying the name of a local group to which the user belongs.
		/// </summary>
		[MarshalAs(UnmanagedType.LPWStr)]
		public string lgrui0_name;
	}
}

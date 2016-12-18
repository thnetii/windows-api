namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="SI_PAGE_TYPE"/> enumeration contains values that indicate the types of property pages in an access control editor property sheet.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379606.aspx">SI_PAGE_TYPE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="ISecurityInformation.PropertySheetPageCallback"/>
    public enum SI_PAGE_TYPE
    {
        /// <summary>The <a href="https://msdn.microsoft.com/en-us/library/aa376377.aspx">basic security property page</a> for editing the object's DACL.</summary>
        SI_PAGE_PERM = 0,
        /// <summary>The <a href="https://msdn.microsoft.com/en-us/library/aa379301.aspx">Permissions</a> tab for advanced editing of the object's DACL, such as editing object-specific ACEs.</summary>
        SI_PAGE_ADVPERM,
        /// <summary>The <a href="https://msdn.microsoft.com/en-us/library/aa375663.aspx">Auditing</a> tab for editing the object's SACL.</summary>
        SI_PAGE_AUDIT,
        /// <summary>The <a href="https://msdn.microsoft.com/en-us/library/aa379300.aspx">Owner</a> tab for editing the object's owner.</summary>
        SI_PAGE_OWNER,
        /// <summary>The <strong>Effective Permission</strong> tab that displays the effective permissions granted to a specified user or group for access to the object.</summary>
        SI_PAGE_EFFECTIVE,
        /// <summary>A dialog box for changing the owner of the object.</summary>
        SI_PAGE_TAKEOWNERSHIP
    }
}

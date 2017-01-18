using Xunit;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace THNETII.WinApi.Native.Test.Authorization
{
    public class AuditEnumerateTest
    {
        [Fact]
        public void CanEnumerateAuditCategories()
        {
            var apiResult = AuditEnumerateCategories(out var auditCategories, out int categoriesReturned);
            Assert.True(apiResult);
            using (auditCategories)
            {
                var auditCategoriesGuids = auditCategories.MarshalToManagedArray(categoriesReturned);
            }
        }
    }
}

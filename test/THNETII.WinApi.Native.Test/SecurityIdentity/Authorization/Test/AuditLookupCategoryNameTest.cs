using Microsoft.Win32.WinApi.SecurityIdentity.Authorization;
using Microsoft.Win32.WinApi.WinError;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using THNETII.InteropServices.SafeHandles;
using Xunit;
using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace THNETII.WinApi.Native.SecurityIdentity.Authorization.Test
{
    public class AuditLookupCategoryNameTest
    {
        [Fact]
        public void CanLookupCategoryNameForAllEnumeratedAuditRootGuids()
        {
            var apiResult = AuditEnumerateCategories(out var auditCategoriesHandle, out int categoriesReturned);
            using (auditCategoriesHandle)
            {
                var auditCategoriesGuids = auditCategoriesHandle.ReadValue(categoriesReturned);
                foreach (var auditCategoryGuidIter in auditCategoriesGuids)
                {
                    var auditCategoryGuidVal = auditCategoryGuidIter;
                    apiResult = AuditLookupCategoryName(ref auditCategoryGuidVal, out var auditCategoryNameHandle);
                    Assert.True(apiResult, ((Win32ErrorCode)Marshal.GetLastWin32Error()).ToString());
                    using (auditCategoryNameHandle)
                    {
                        string auditCategoryName = auditCategoryNameHandle.ReadValue();
                    }
                }
            }
        }

        [Fact]
        public void CanLookupCategoryNameForAllEnumeratedAuditSubGuids()
        {
            var ignoredRootCategory = Guid.Empty;
            var apiResult = AuditEnumerateSubCategories(ref ignoredRootCategory, true, out var auditSubCategoriesHandle, out int categoriesReturned);
            using (auditSubCategoriesHandle)
            {
                var auditSubCategories = auditSubCategoriesHandle.ReadValue(categoriesReturned);
                foreach (var auditSubCategoryGuidIter in auditSubCategories)
                {
                    Guid auditSubCategoryVal = auditSubCategoryGuidIter;
                    apiResult = AuditLookupSubCategoryName(ref auditSubCategoryVal, out var auditCategoryNameHandle);
                    Assert.True(apiResult, ((Win32ErrorCode)Marshal.GetLastWin32Error()).ToString());
                    using (auditCategoryNameHandle)
                    {
                        string auditCategoryName = auditCategoryNameHandle.ReadValue();
                    }
                }
            }
        }
    }
}

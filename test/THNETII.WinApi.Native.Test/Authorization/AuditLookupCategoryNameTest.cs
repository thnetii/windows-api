using Microsoft.Win32.WinApi.SecurityIdentity.Authorization;
using Microsoft.Win32.WindowsProtocols.MsErrRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Xunit;
using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace THNETII.WinApi.Native.Test.Authorization
{
    public class AuditLookupCategoryNameTest
    {
        [Fact]
        public void CanLookupCategoryNameForAllEnumeratedAuditRootGuids()
        {
            GuidArrayAuditSafeHandle auditCategoriesHandle;
            int categoriesReturned;
            var apiResult = AuditEnumerateCategories(out auditCategoriesHandle, out categoriesReturned);
            using (auditCategoriesHandle)
            {
                var auditCategoriesGuids = auditCategoriesHandle.MarshalToManagedArray(categoriesReturned);
                foreach (var auditCategoryGuidIter in auditCategoriesGuids)
                {
                    var auditCategoryGuidVal = auditCategoryGuidIter;
                    WideStringAuditSafeHandle auditCategoryNameHandle;
                    apiResult = AuditLookupCategoryName(ref auditCategoryGuidVal, out auditCategoryNameHandle);
                    Assert.True(apiResult, ((Win32ErrorCode)Marshal.GetLastWin32Error()).ToString());
                    using (auditCategoryNameHandle)
                    {
                        string auditCategoryName = auditCategoryNameHandle.MarshalToManagedInstance();
                    }
                }
            }
        }

        [Fact]
        public void CanLookupCategoryNameForAllEnumeratedAuditSubGuids()
        {
            var ignoredRootCategory = Guid.Empty;
            GuidArrayAuditSafeHandle auditSubCategoriesHandle;
            int categoriesReturned;
            var apiResult = AuditEnumerateSubCategories(ref ignoredRootCategory, true, out auditSubCategoriesHandle, out categoriesReturned);
            using (auditSubCategoriesHandle)
            {
                var auditSubCategories = auditSubCategoriesHandle.MarshalToManagedArray(categoriesReturned);
                foreach (var auditSubCategoryGuidIter in auditSubCategories)
                {
                    Guid auditSubCategoryVal = auditSubCategoryGuidIter;
                    WideStringAuditSafeHandle auditCategoryNameHandle;
                    apiResult = AuditLookupSubCategoryName(ref auditSubCategoryVal, out auditCategoryNameHandle);
                    Assert.True(apiResult, ((Win32ErrorCode)Marshal.GetLastWin32Error()).ToString());
                    using (auditCategoryNameHandle)
                    {
                        string auditCategoryName = auditCategoryNameHandle.MarshalToManagedInstance();
                    }
                }
            }
        }
    }
}

using Microsoft.Win32.WinApi.SecurityIdentity.Authorization;
using Microsoft.Win32.WinApi.WinError;
using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;
using Xunit;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace THNETII.WinApi.Native.Test.Authorization
{
    public class AuditEnumerateTest
    {
        [Fact]
        public void CanEnumerateAuditCategories()
        {
            GuidArrayAuditSafeHandle auditCategoriesHandle;
            int categoriesReturned;
            var apiResult = AuditEnumerateCategories(out auditCategoriesHandle, out categoriesReturned);
            Assert.True(apiResult, ((Win32ErrorCode)Marshal.GetLastWin32Error()).ToString());
            using (auditCategoriesHandle)
            {
                var auditCategoriesGuids = auditCategoriesHandle.ReadValue(categoriesReturned);
            }
        }

        [Fact]
        public void CanEnumeratePerUserPolicyAudits()
        {
            PolicyAuditSidArrayAuditSafeHandle auditCategoriesHandle;
            var apiResult = AuditEnumeratePerUserPolicy(out auditCategoriesHandle);
            Assert.True(apiResult, ((Win32ErrorCode)Marshal.GetLastWin32Error()).ToString());
            using (auditCategoriesHandle)
            {
                var auditPolicySids = auditCategoriesHandle.ReadValue();
                Assert.NotNull(auditPolicySids);
            }
        }

        [Fact]
        public void CanEnumerateAuditSubCategories()
        {
            GuidArrayAuditSafeHandle auditCategoriesHandle;
            int categoriesReturned;
            var apiResult = AuditEnumerateCategories(out auditCategoriesHandle, out categoriesReturned);
            Assert.True(apiResult, ((Win32ErrorCode)Marshal.GetLastWin32Error()).ToString());
            using (auditCategoriesHandle)
            {
                var auditCategories = auditCategoriesHandle.ReadValue(categoriesReturned);
                foreach (var auditRootCategory in auditCategories)
                {
                    var currentAuditRootCategory = auditRootCategory;
                    GuidArrayAuditSafeHandle auditSubCategoriesHandle;
                    apiResult = AuditEnumerateSubCategories(ref currentAuditRootCategory, false, out auditSubCategoriesHandle, out categoriesReturned);
                    Assert.True(apiResult, ((Win32ErrorCode)Marshal.GetLastWin32Error()).ToString());
                    using (auditSubCategoriesHandle)
                    {
                        var auditSubCategories = auditSubCategoriesHandle.ReadValue(categoriesReturned);
                    }
                }
            }
        }

        [Fact]
        public void CanEnumerateAllAuditSubCategories()
        {
            var ignoredRootCategory = Guid.Empty;
            GuidArrayAuditSafeHandle auditSubCategoriesHandle;
            int categoriesReturned;
            var apiResult = AuditEnumerateSubCategories(ref ignoredRootCategory, true, out auditSubCategoriesHandle, out categoriesReturned);
            Assert.True(apiResult, ((Win32ErrorCode)Marshal.GetLastWin32Error()).ToString());
            using (auditSubCategoriesHandle)
            {
                var auditSubCategories = auditSubCategoriesHandle.ReadValue(categoriesReturned);
            }
        }
    }
}

using Microsoft.Win32.WinApi.SecurityIdentity.Authorization;
using Microsoft.Win32.WinApi.WinError;
using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;
using Xunit;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace THNETII.WinApi.Native.SecurityIdentity.Authorization.Test
{
    public class AuditEnumerateTest
    {
        [Fact]
        public void CanEnumerateAuditCategories()
        {
            var apiResult = AuditEnumerateCategories(out GuidArrayAuditSafeHandle auditCategoriesHandle, out int categoriesReturned);
            Assert.True(apiResult, ((Win32ErrorCode)Marshal.GetLastWin32Error()).ToString());
            using (auditCategoriesHandle)
            {
                var auditCategoriesGuids = auditCategoriesHandle.ReadValue(categoriesReturned);
            }
        }

        [Fact]
        public void CanEnumeratePerUserPolicyAudits()
        {
            var apiResult = AuditEnumeratePerUserPolicy(out PolicyAuditSidArrayAuditSafeHandle auditCategoriesHandle);
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
            var apiResult = AuditEnumerateCategories(out GuidArrayAuditSafeHandle auditCategoriesHandle, out int categoriesReturned);
            Assert.True(apiResult, ((Win32ErrorCode)Marshal.GetLastWin32Error()).ToString());
            using (auditCategoriesHandle)
            {
                var auditCategories = auditCategoriesHandle.ReadValue(categoriesReturned);
                foreach (var auditRootCategory in auditCategories)
                {
                    var currentAuditRootCategory = auditRootCategory;
                    apiResult = AuditEnumerateSubCategories(ref currentAuditRootCategory, false, out var auditSubCategoriesHandle, out categoriesReturned);
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
            var apiResult = AuditEnumerateSubCategories(ref ignoredRootCategory, true, out GuidArrayAuditSafeHandle auditSubCategoriesHandle, out int categoriesReturned);
            Assert.True(apiResult, ((Win32ErrorCode)Marshal.GetLastWin32Error()).ToString());
            using (auditSubCategoriesHandle)
            {
                var auditSubCategories = auditSubCategoriesHandle.ReadValue(categoriesReturned);
            }
        }
    }
}

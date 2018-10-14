using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using THNETII.InteropServices.Bitwise;
using THNETII.WindowsProtocols.WindowsErrorCodes.Constants;
using Xunit;

namespace THNETII.WindowsProtocols.WindowsErrorCodes.Test
{
    public static class HResultTest
    {
        public static IEnumerable<object[]> GetHResultConstants()
        {
            return typeof(HResultConstants).GetFields()
                .Where(fi => fi.IsStatic && fi.IsLiteral)
                .Select(fi => new object[] { fi.Name, fi.GetValue(null) });
        }

        [Theory, MemberData(nameof(Win32ErrorCodeTest.GetHResultConstants), MemberType = typeof(Win32ErrorCodeTest))]
        [SuppressMessage("Testing", "xUnit1026: Theory methods should use all of their parameters")]
        [SuppressMessage("Usage", "CA1801: Unused formal parameter")]
        public static void FromWin32ErrorHasSameCode(string name, int win32ErrorCode)
        {
            var lower16Bits = Bitfield32.DefineLowerBits(16);
            var win32Lower = lower16Bits.Read(win32ErrorCode);

            HRESULT hr = HRESULT.FromWin32(win32ErrorCode);

            Assert.Equal(win32Lower, hr.Code);
        }

        [Theory, MemberData(nameof(Win32ErrorCodeTest.GetHResultConstants), MemberType = typeof(Win32ErrorCodeTest))]
        [SuppressMessage("Testing", "xUnit1026: Theory methods should use all of their parameters")]
        [SuppressMessage("Usage", "CA1801: Unused formal parameter")]
        public static void FromWin32ErrorHasWin32Facility(string name, int win32ErrorCode)
        {
            HRESULT hr = HRESULT.FromWin32(win32ErrorCode);

            Assert.Equal(HResultFacility.Win32, hr.Facility);
        }
    }
}

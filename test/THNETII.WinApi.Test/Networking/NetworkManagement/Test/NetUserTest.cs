using System;
using System.Linq;
using Xunit;

namespace THNETII.WinApi.Networking.NetworkManagement.Test
{
    public class NetUserTest
    {
        [Fact]
        public void NetUserConstructorThrowsWithNullUsername() => Assert.Throws<ArgumentNullException>(() => new NetUser(null));

        [Fact]
        public void NetUserConstructorThrowsWithEmptyUsername() => Assert.Throws<ArgumentNullException>(() => new NetUser(string.Empty));

        [Fact]
        public void NetUserConstructorThrowsWithLiterallyEmptyUsername() => Assert.Throws<ArgumentNullException>(() => new NetUser(""));

        [Theory]
        [InlineData(" ")]
        [InlineData("  ")]
        [InlineData("\t")]
        [InlineData("\n")]
        [InlineData("\r\n")]
        [InlineData("\r")]
        public void NetUserConstructorThrowsWithWhiteSpaceOnlyUsername(string whitespaceUsername) => Assert.Throws<ArgumentNullException>(() => new NetUser(whitespaceUsername));

        [Fact]
        public void NetUserConstructorCanCreateWithTestRunnerUsername()
        {
            var username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            var user = new NetUser(username);
        }

        [Fact]
        public void NetUserConstructedInstanceHasMinusOneLevel()
        {
            var username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            var user = new NetUser(username);
            Assert.Equal(-1, user.CurrentLevel);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(20)]
        [InlineData(21)]
        [InlineData(22)]
        [InlineData(23)]
        [InlineData(24)]
        public void NetUserEnumerateAllReturnedHaveCorrectLevel(int level)
        {
            Assert.All(NetUser.Enumerate(level: level).ToArray(), user => Assert.Equal(level, user.CurrentLevel));
        }
    }
}

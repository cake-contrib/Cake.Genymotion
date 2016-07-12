using Cake.Genymotion.Tests.Fixtures.License;
using FluentAssertions;
using Xunit;

namespace Cake.Genymotion.Tests.Unit.Admin
{
    public class GenymotionAdminListTests
    {
        [Theory]
        [InlineData(true, "admin list --verbose")]
        [InlineData(false, "admin list")]
        public void Should_Add_Verbose_Flag_To_Arguments_If_Set(bool verbose, string expected)
        {
            // Given
            var fixture = new GenymotionLicenseInfoFixture();
            fixture.Settings.Verbose = verbose;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Fact]
        public void Should_Add_Admin_List_Argument()
        {
            // Given
            var fixture = new GenymotionLicenseInfoFixture();

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be("admin list");
        }
    }
}
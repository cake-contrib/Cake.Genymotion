using Cake.Genymotion.Tests.Fixtures.License;
using FluentAssertions;
using Xunit;

namespace Cake.Genymotion.Tests.Unit.Admin
{
    public class GenymotionAdminStartTests
    {
        [Theory]
        [InlineData(true, "admin start --verbose")]
        [InlineData(false, "admin start")]
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

        [Theory]
        [InlineData("8c983780-1339-4162-a0f7-da19f1ded7ee", "admin start 8c983780-1339-4162-a0f7-da19f1ded7ee")]
        public void Should_Add_Admin_Stop_Argument_With_DeviceIdentifier(string deviceId, string expected)
        {
            // Given
            var fixture = new GenymotionLicenseInfoFixture();

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }
    }
}
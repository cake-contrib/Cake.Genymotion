using Cake.Core;
using Cake.Genymotion.Tests.Fixtures.Admin;
using Cake.Genymotion.Tests.Fixtures.License;
using Cake.Testing;
using FluentAssertions;
using Xunit;

namespace Cake.Genymotion.Tests.Unit.Admin
{
    public class GenymotionAdminStartTests
    {
        [Theory]
        [InlineData(10, "--timeout 10 admin start")]
        [InlineData(null, "admin start")]
        public void Should_Add_Timeout_Flag_To_Arguments_If_Set(int? timeout, string expected)
        {
            // Given
            var fixture = new GenymotionAdminStartFixture();
            fixture.Settings.Timeout = timeout;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData(true, "--verbose admin start")]
        [InlineData(false, "admin start")]
        public void Should_Add_Verbose_Flag_To_Arguments_If_Set(bool verbose, string expected)
        {
            // Given
            var fixture = new GenymotionAdminStartFixture();
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
            var fixture = new GenymotionAdminStartFixture();

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Fact]
        public void Should_Throw_If_Has_A_Non_Zero_Exit_Code()
        {
            // Given
            var fixture = new GenymotionAdminStartFixture();
            fixture.GivenProcessExitsWithCode(1);

            // When
            fixture.Invoking(x => x.Run())

            // Then
                .ShouldThrow<CakeException>()
                .WithMessage("Genymotion: Process returned an error (exit code 1).");
        }

        [Fact]
        public void Should_Throw_If_Process_Was_Not_Started()
        {
            // Given
            var fixture = new GenymotionAdminStartFixture();
            fixture.GivenProcessCannotStart();

            // When
            fixture.Invoking(x => x.Run())

            // Then
                .ShouldThrow<CakeException>()
                .WithMessage("Genymotion: Process was not started.");
        }

    }
}
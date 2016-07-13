using Cake.Core;
using Cake.Genymotion.Tests.Fixtures.Admin;
using Cake.Genymotion.Tests.Fixtures.License;
using Cake.Testing;
using FluentAssertions;
using Xunit;

namespace Cake.Genymotion.Tests.Unit.License
{
    public class GenymotionLicenseCountTests
    {
        [Theory]
        [InlineData(true, "--verbose license count")]
        [InlineData(false, "license count")]
        public void Should_Add_Verbose_Flag_To_Arguments_If_Set(bool verbose, string expected)
        {
            // Given
            var fixture = new GenymotionLicenseCountFixture();
            fixture.Settings.Verbose = verbose;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData(10, "--timeout 10 license count")]
        [InlineData(null, "license count")]
        public void Should_Add_Timeout_Flag_To_Arguments_If_Set(int? timeout, string expected)
        {
            // Given
            var fixture = new GenymotionLicenseCountFixture();
            fixture.Settings.Timeout = timeout;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }


        [Fact]
        public void Should_Add_License_Count_Argument()
        {
            // Given
            var fixture = new GenymotionLicenseCountFixture();

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be("license count");
        }


        [Fact]
        public void Should_Throw_If_Has_A_Non_Zero_Exit_Code()
        {
            // Given
            var fixture = new GenymotionLicenseCountFixture();
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
            var fixture = new GenymotionLicenseCountFixture();
            fixture.GivenProcessCannotStart();

            // When
            fixture.Invoking(x => x.Run())

            // Then
                .ShouldThrow<CakeException>()
                .WithMessage("Genymotion: Process was not started.");
        }

    }
}
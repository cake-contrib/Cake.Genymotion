using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Genymotion.Tests.Fixtures.License;
using FluentAssertions;
using Xunit;

namespace Cake.Genymotion.Tests.Unit.License
{
    public class GenymotionLicenseRegisterTests
    {
        [Theory]
        [InlineData(true, "license register --verbose")]
        [InlineData(false, "license register")]
        public void Should_Add_Verbose_Flag_To_Arguments_If_Set(bool verbose, string expected)
        {
            // Given
            var fixture = new GenymotionLicenseRegisterFixture();
            fixture.Settings.Verbose = verbose;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData("239jd-231kd0-nope-d123123d011", "license register 239jd-231kd0-nope-d123123d011")]
        public void Should_Add_License_Register_Argument_With_LicenseKey(string licenseKey, string expected)
        {
            // Given
            var fixture = new GenymotionLicenseRegisterFixture();

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }
    }
}

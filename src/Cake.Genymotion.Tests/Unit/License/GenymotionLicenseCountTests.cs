using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Genymotion.Tests.Fixtures.License;
using FluentAssertions;
using NSubstitute.Core;
using Xunit;

namespace Cake.Genymotion.Tests.Unit.License
{
    public class GenymotionLicenseCountTests
    {
        [Theory]
        [InlineData(true, "license count --verbose")]
        [InlineData(false, "license count")]
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
        public void Should_Add_License_Count_Argument()
        {
            // Given
            var fixture = new GenymotionLicenseInfoFixture();

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be("license count");
        }
    }
}
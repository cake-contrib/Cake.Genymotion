using Cake.Genymotion.Tests.Fixtures.License;
using Xunit;

namespace Cake.Genymotion.Tests.Unit.License
{
	public class GenymotionLicenseInfoTests
	{
        //[Theory]
        //[InlineData(true, "upgrade \\"Cake\" -v -y")]
        //[InlineData(false, "upgrade \\"Cake\" -y")]
        public void Should_Add_Verbose_Flag_To_Arguments_If_Set(bool verbose, string expected)
        {
            // Given
            var fixture = new GenymotionLicenseInfoFixture();
            fixture.Settings.Verbose = verbose;

            // When
            var result = fixture.Run();

            // Then
            Assert.Equal(expected, result.Args);
        }
    }
}


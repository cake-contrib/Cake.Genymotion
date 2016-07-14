using Cake.Core;
using Cake.Genymotion.Admin;
using Cake.Genymotion.Tests.Fixtures.Admin;
using Cake.Testing;
using FluentAssertions;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace Cake.Genymotion.Tests.Unit.Admin
{
    public class GenymotionAdminListTests
    {
        [Fact]
        public void Should_Return_Correct_Simulator_Details()
        {
            // Given
            var fixture = new GenymotionAdminListFixture();

            // When
            var result = fixture.Run();

            // Then
            fixture.ToolResult.Should().HaveCount(7);

            fixture.ToolResult.First().State.Should().Be(GenymotionSimulatorState.On);
            fixture.ToolResult.First().IpAddress.Should().Be("123.123.123.123");
            fixture.ToolResult.First().UUID.Should().Be("cba69bf3-1658-4027-80e7-df5c37a35db5");
            fixture.ToolResult.First().Name.Should().Be("Google Nexus 6 - 6.0.0 - API 23 - 1440x2560");

            fixture.ToolResult.Skip(1).First().State.Should().Be(GenymotionSimulatorState.Off);

            fixture.ToolResult.Last().State.Should().Be(GenymotionSimulatorState.Aborted);
            fixture.ToolResult.Last().IpAddress.Should().Be("0.0.0.0");
            fixture.ToolResult.Last().UUID.Should().Be("bf73467f-3bdc-40b9-8e8f-30f7ba7da740");
            fixture.ToolResult.Last().Name.Should().Be("Google Nexus 4 - 4.1.1 - API 16 - 768x1280");
        }

        [Fact]
        public void Should_Add_Admin_List_Argument()
        {
            // Given
            var fixture = new GenymotionAdminListFixture();

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be("admin list");
        }

        [Theory]
        [InlineData(10, "--timeout 10 admin list")]
        [InlineData(null, "admin list")]
        public void Should_Add_Timeout_Flag_To_Arguments_If_Set(int? timeout, string expected)
        {
            // Given
            var fixture = new GenymotionAdminListFixture();
            fixture.Settings.Timeout = timeout;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData(true, "--verbose admin list")]
        [InlineData(false, "admin list")]
        public void Should_Add_Verbose_Flag_To_Arguments_If_Set(bool verbose, string expected)
        {
            // Given
            var fixture = new GenymotionAdminListFixture();
            fixture.Settings.Verbose = verbose;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Fact]
        public void Should_Find_Genymotion_If_Tool_Path_Not_Provided()
        {
            // Given
            var fixture = new GenymotionAdminListFixture();

            // When
            var result = fixture.Run();

            // Then
            Assert.Equal("/Working/tools/gmtool.exe", result.Path.FullPath);
        }

        [Fact]
        public void Should_Set_Working_Directory()
        {
            // Given
            var fixture = new GenymotionAdminListFixture();

            // When
            var result = fixture.Run();

            // Then
            Assert.Equal("/Working", result.Process.WorkingDirectory.FullPath);
        }

        [Fact]
        public void Should_Throw_If_Genymotion_Was_Not_Found()
        {
            // Given
            var fixture = new GenymotionAdminListFixture();
            fixture.GivenDefaultToolDoNotExist();

            // When
            fixture.Invoking(x => x.Run())

            // Then
                .ShouldThrow<CakeException>()
                .WithMessage("Genymotion: Could not locate executable.");
        }

        [Fact]
        public void Should_Throw_If_Has_A_Non_Zero_Exit_Code()
        {
            // Given
            var fixture = new GenymotionAdminListFixture();
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
            var fixture = new GenymotionAdminListFixture();
            fixture.GivenProcessCannotStart();

            // When
            fixture.Invoking(x => x.Run())

            // Then
                .ShouldThrow<CakeException>()
                .WithMessage("Genymotion: Process was not started.");
        }

        [Theory]
        [InlineData(@"c:/Program Files/Genymobile/Genymotion/gmtool.exe", @"c:/Program Files/Genymobile/Genymotion/gmtool.exe")]
        [InlineData("/Applications/Genymotion.app/Contents/MacOS/gmtool", "/Applications/Genymotion.app/Contents/MacOS/gmtool")]
        public void Should_Use_Genymotion_Runner_From_Tool_Path_If_Provided(string toolPath, string expected)
        {
            // Given
            var fixture = new GenymotionAdminListFixture { Settings = { ToolPath = toolPath } };
            fixture.GivenSettingsToolPathExist();

            // When
            var result = fixture.Run();

            // Then
            result.Path.FullPath.Should().Be(expected);
        }
    }
}
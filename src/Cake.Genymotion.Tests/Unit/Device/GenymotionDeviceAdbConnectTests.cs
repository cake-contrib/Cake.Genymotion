using Cake.Core;
using Cake.Genymotion.Tests.Fixtures.Admin;
using Cake.Genymotion.Tests.Fixtures.Device;
using Cake.Testing;
using FluentAssertions;
using Xunit;

namespace Cake.Genymotion.Tests.Unit.Device
{
    public class GenymotionDeviceAdbConnectTests
    {
        [Theory]
        [InlineData("8c983780-1339-4162-a0f7-da19f1ded7ee", "device adbconnect \"8c983780-1339-4162-a0f7-da19f1ded7ee\"")]
        public void Should_Add_Device_AdbConnect_Argument_With_DeviceIdentifier(string deviceIdentifier, string expected)
        {
            // Given
            var fixture = new GenymotionDeviceAdbConnectFixture();
            fixture.DeviceIdentifier = deviceIdentifier;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData(10, "--timeout 10 device adbconnect")]
        [InlineData(null, "device adbconnect")]
        public void Should_Add_Timeout_Flag_To_Arguments_If_Set(int? timeout, string expected)
        {
            // Given
            var fixture = new GenymotionDeviceAdbConnectFixture();
            fixture.Settings.Timeout = timeout;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData(true, "--verbose device adbconnect")]
        [InlineData(false, "device adbconnect")]
        public void Should_Add_Verbose_Flag_To_Arguments_If_Set(bool verbose, string expected)
        {
            // Given
            var fixture = new GenymotionDeviceAdbConnectFixture();
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
            var fixture = new GenymotionDeviceAdbConnectFixture();

            // When
            var result = fixture.Run();

            // Then
            Assert.Equal("/Working/tools/gmtool.exe", result.Path.FullPath);
        }

        [Fact]
        public void Should_Set_Working_Directory()
        {
            // Given
            var fixture = new GenymotionDeviceAdbConnectFixture();

            // When
            var result = fixture.Run();

            // Then
            Assert.Equal("/Working", result.Process.WorkingDirectory.FullPath);
        }

        [Fact]
        public void Should_Throw_If_Genymotion_Was_Not_Found()
        {
            // Given
            var fixture = new GenymotionDeviceAdbConnectFixture();
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
            var fixture = new GenymotionDeviceAdbConnectFixture();
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
            var fixture = new GenymotionDeviceAdbConnectFixture();
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
            var fixture = new GenymotionDeviceAdbConnectFixture { Settings = { ToolPath = toolPath } };
            fixture.GivenSettingsToolPathExist();

            // When
            var result = fixture.Run();

            // Then
            result.Path.FullPath.Should().Be(expected);
        }
    }
}
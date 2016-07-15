using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Core;
using Cake.Genymotion.Tests.Fixtures.Admin;
using Cake.Genymotion.Tests.Fixtures.Config;
using Cake.Testing;
using FluentAssertions;
using Xunit;

namespace Cake.Genymotion.Tests.Unit.Config
{
    public class GenymotionConfigTests
    {
        [Theory]
        [InlineData("MyCoolPassword", "config proxy_password \"MyCoolPassword\"")]
        [InlineData("", "config")]
        public void Should_Add_Config_ProxyPassword_Argument(string value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.ProxyPassword = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }


        [Theory]
        [InlineData("ghuntley", "config proxy_username \"ghuntley\"")]
        [InlineData("", "config")]
        public void Should_Add_Config_ProxyUsername_Argument(string value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.ProxyUsername = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData(true, "config proxy_auth on")]
        [InlineData(false, "config proxy_auth off")]
        public void Should_Add_Config_ProxyAuth_Argument(bool value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.EnableProxyAuth = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }


        [Theory]
        [InlineData("3128", "config proxy_port \"3128\"")]
        [InlineData("", "config")]
        public void Should_Add_Config_ProxyPort_Argument(string value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.ProxyPort = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData("127.0.0.1", "config proxy_address \"127.0.0.1\"")]
        [InlineData("", "config")]
        public void Should_Add_Config_ProxyAddress_Argument(string value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.ProxyAddress = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }


        [Theory]
        [InlineData(true, "config proxy on")]
        [InlineData(false, "config proxy off")]
        public void Should_Add_Config_Proxy_Argument(bool value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.EnableProxy = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData("/tmp/captures", "config screen_capture_path \"/tmp/captures\"")]
        [InlineData("", "config")]
        public void Should_Add_Config_ScreenCapturePath_Argument(string value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.ScreenCapturePath = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData(true, "config use_custom_sdk on")]
        [InlineData(false, "config use_custom_sdk off")]
        public void Should_Add_Config_UseCustomSDK_Argument(bool value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.UseCustomSdk = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData("/opt/sdk", "config sdk_path \"/opt/sdk\"")]
        [InlineData("", "config")]
        public void Should_Add_Config_SdkPath_Argument(string value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.SdkPath = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData("/opt/emulators", "config virtual_device_path \"/opt/emulators\"")]
        [InlineData("", "config")]
        public void Should_Add_Config_VirtualDevicePath_Argument(string value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.VirtualDevicePath = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData(true, "config license_server on")]
        [InlineData(false, "config license_server off")]
        public void Should_Add_Config_LicenseServer_Argument(bool value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.EnableLicenseServer = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }


        [Theory]
        [InlineData("MyCoolPassword", "config password \"MyCoolPassword\"")]
        [InlineData("", "config")]
        public void Should_Add_Config_Password_Argument(string value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.Password = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData("ghuntley", "config username \"ghuntley\"")]
        [InlineData("", "config")]
        public void Should_Add_Config_Username_Argument(string value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.Username = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData(true, "config statistics on")]
        [InlineData(false, "config statistics off")]
        public void Should_Add_Config_Statistics_Argument(bool value, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.EnableStatistics = value;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Fact]
        public void Should_Add_Config_Argument()
        {
            // Given
            var fixture = new GenymotionConfigFixture();

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be("config");
        }
        [Theory]
        [InlineData(10, "--timeout 10 config")]
        [InlineData(null, "config")]
        public void Should_Add_Timeout_Flag_To_Arguments_If_Set(int? timeout, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
            fixture.Settings.Timeout = timeout;

            // When
            var result = fixture.Run();

            // Then
            result.Args.Should().Be(expected);
        }

        [Theory]
        [InlineData(true, "--verbose config")]
        [InlineData(false, "config")]
        public void Should_Add_Verbose_Flag_To_Arguments_If_Set(bool verbose, string expected)
        {
            // Given
            var fixture = new GenymotionConfigFixture();
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
            var fixture = new GenymotionConfigFixture();

            // When
            var result = fixture.Run();

            // Then
            Assert.Equal("/Working/tools/gmtool.exe", result.Path.FullPath);
        }

        [Fact]
        public void Should_Set_Working_Directory()
        {
            // Given
            var fixture = new GenymotionConfigFixture();

            // When
            var result = fixture.Run();

            // Then
            Assert.Equal("/Working", result.Process.WorkingDirectory.FullPath);
        }

        [Fact]
        public void Should_Throw_If_Genymotion_Was_Not_Found()
        {
            // Given
            var fixture = new GenymotionConfigFixture();
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
            var fixture = new GenymotionConfigFixture();
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
            var fixture = new GenymotionConfigFixture();
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
            var fixture = new GenymotionConfigFixture { Settings = { ToolPath = toolPath } };
            fixture.GivenSettingsToolPathExist();

            // When
            var result = fixture.Run();

            // Then
            result.Path.FullPath.Should().Be(expected);
        }

    }
}

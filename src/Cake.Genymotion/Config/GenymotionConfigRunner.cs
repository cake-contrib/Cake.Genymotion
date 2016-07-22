using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion.Config
{
    internal sealed class GenymotionConfigRunner : GenymotionTool<GenymotionConfigSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionConfigRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools, GenymotionConfigSettings settings) : base(fileSystem, environment, processRunner, tools, settings)
        {
            _environment = environment;
        }

        public void ClearCache()
        {
            var arguments = CreateArgumentBuilder(Settings).Append("clearcache");
            Run(Settings, arguments);
        }

        public void Config()
        {
            var arguments = CreateArgumentBuilder(Settings);
            Run(Settings, arguments);
        }

        public void Print()
        {
            var arguments = CreateArgumentBuilder(Settings).Append("print");
            Run(Settings, arguments);
        }

        public void Reset()
        {
            var arguments = CreateArgumentBuilder(Settings).Append("reset");
            Run(Settings, arguments);
        }

        public void SignOut()
        {
            var arguments = CreateArgumentBuilder(Settings).Append("signout");
            Run(Settings, arguments);
        }

        private new ProcessArgumentBuilder CreateArgumentBuilder(GenymotionConfigSettings settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            var builder = new ProcessArgumentBuilder();

            if (settings.Verbose)
            {
                builder.Append("--verbose");
            }

            if (settings.Timeout.HasValue)
            {
                builder.Append($"--timeout {settings.Timeout}");
            }

            builder.Append("config");

            //  config [username USERNAME] [password PASSWORD] [license_server on | off] [license_server_address LICENSE_SERVER_ADDRESS]
            //         [statistics on | off] [virtual_device_path LOG_ARCHIVE_PATH][sdk_path LOG_ARCHIVE_PATH] [use_custom_sdk on | off]
            //         [screen_capture_path LOG_ARCHIVE_PATH] [proxy on | off] [proxy_address PROXY_ADDRESS] [proxy_port PROXY_PORT]
            //         [proxy_auth on | off] [proxy_username PROXY_USERNAME] [proxy_password PROXY_PASSWORD]

            builder.AppendQuotedUnlessNullWhitespaceOrEmpty("username", settings.Username);
            builder.AppendQuotedSecretUnlessNullWhitespaceOrEmpty("password", settings.Password);
            builder.AppendOnOffIfBooleanHasValue("license_server", settings.EnableLicenseServer);
            builder.AppendQuotedUnlessNullWhitespaceOrEmpty("license_server_address", settings.LicenseServerAddress);

            builder.AppendOnOffIfBooleanHasValue("statistics", settings.EnableStatistics);
            builder.AppendQuotedUnlessNullWhitespaceOrEmpty("virtual_device_path", settings.VirtualDevicePath);
            builder.AppendQuotedUnlessNullWhitespaceOrEmpty("log_archive_path", settings.LogArchivePath);
            builder.AppendQuotedUnlessNullWhitespaceOrEmpty("sdk_path", settings.SdkPath);
            builder.AppendOnOffIfBooleanHasValue("use_custom_sdk", settings.UseCustomSdk);

            builder.AppendQuotedUnlessNullWhitespaceOrEmpty("screen_capture_path", settings.ScreenCapturePath);
            builder.AppendOnOffIfBooleanHasValue("proxy", settings.EnableProxy);
            builder.AppendQuotedUnlessNullWhitespaceOrEmpty("proxy_address", settings.ProxyAddress);
            builder.AppendQuotedUnlessNullWhitespaceOrEmpty("proxy_port", settings.ProxyPort);

            builder.AppendOnOffIfBooleanHasValue("proxy_auth", settings.EnableProxyAuth);
            builder.AppendQuotedUnlessNullWhitespaceOrEmpty("proxy_username", settings.ProxyUsername);
            builder.AppendQuotedSecretUnlessNullWhitespaceOrEmpty("proxy_password", settings.ProxyPassword);

            return builder;
        }
    }
}
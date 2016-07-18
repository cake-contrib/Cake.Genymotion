using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using System;

namespace Cake.Genymotion
{
    public sealed class GenymotionDeviceRunner : GenymotionTool<GenymotionDeviceSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionDeviceRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools, GenymotionDeviceSettings settings) : base(fileSystem, environment, processRunner, tools, settings)
        {
            _environment = environment;
        }

        public void AdbConnect(string deviceIdentifier)
        {
            if (string.IsNullOrWhiteSpace(deviceIdentifier))
            {
                throw new ArgumentException(nameof(deviceIdentifier));
            }

            var arguments = CreateArgumentBuilder(Settings).Append("device adbconnect").AppendQuotedUnlessNullWhitespaceOrEmpty(deviceIdentifier);
            Run(Settings, arguments);
        }

        public void AdbDisconnect(string deviceIdentifier)
        {
            if (string.IsNullOrWhiteSpace(deviceIdentifier))
            {
                throw new ArgumentException(nameof(deviceIdentifier));
            }

            var arguments = CreateArgumentBuilder(Settings).Append("device adbdisconnect").AppendQuotedUnlessNullWhitespaceOrEmpty(deviceIdentifier);
            Run(Settings, arguments);
        }

        public void Flash(string archivePath)
        {
            if (string.IsNullOrWhiteSpace(archivePath))
            {
                throw new ArgumentException(nameof(archivePath));
            }

            var arguments = CreateArgumentBuilder(Settings).Append("device flash").AppendQuotedUnlessNullWhitespaceOrEmpty(archivePath);
            Run(Settings, arguments);
        }

        public void Install(string apkFilePath)
        {
            if (string.IsNullOrWhiteSpace(apkFilePath))
            {
                throw new ArgumentException(nameof(apkFilePath));
            }

            var arguments = CreateArgumentBuilder(Settings).Append("device install").AppendQuotedUnlessNullWhitespaceOrEmpty(apkFilePath);
            Run(Settings, arguments);
        }

        public void LogCatClear()
        {
            var arguments = CreateArgumentBuilder(Settings).Append("device logcatclear");
            Run(Settings, arguments);
        }

        public void LogCatDump(string destinationFilePath)
        {
            if (string.IsNullOrWhiteSpace(destinationFilePath))
            {
                throw new ArgumentException(nameof(destinationFilePath));
            }

            var arguments = CreateArgumentBuilder(Settings).Append("device logcatdump").AppendQuotedUnlessNullWhitespaceOrEmpty(destinationFilePath);
            Run(Settings, arguments);
        }

        public void Pull(string sourcePath, string destinationDirectoryPath)
        {
            if (string.IsNullOrWhiteSpace(sourcePath))
            {
                throw new ArgumentException(nameof(sourcePath));
            }

            if (string.IsNullOrWhiteSpace(destinationDirectoryPath))
            {
                throw new ArgumentException(nameof(destinationDirectoryPath));
            }

            var arguments = CreateArgumentBuilder(Settings).Append("device pull").AppendQuotedUnlessNullWhitespaceOrEmpty(sourcePath).AppendQuotedUnlessNullWhitespaceOrEmpty(destinationDirectoryPath);
            Run(Settings, arguments);
        }

        public void Push(string sourcePath, string destinationDirectoryPath)
        {
            if (string.IsNullOrWhiteSpace(sourcePath))
            {
                throw new ArgumentException(nameof(sourcePath));
            }

            if (string.IsNullOrWhiteSpace(destinationDirectoryPath))
            {
                throw new ArgumentException(nameof(destinationDirectoryPath));
            }

            var arguments = CreateArgumentBuilder(Settings).Append("device push").AppendQuotedUnlessNullWhitespaceOrEmpty(sourcePath).AppendQuotedUnlessNullWhitespaceOrEmpty(destinationDirectoryPath);
            Run(Settings, arguments);
        }
    }
}
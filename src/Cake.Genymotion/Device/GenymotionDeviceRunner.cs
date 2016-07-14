using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using System;

namespace Cake.Genymotion.Device
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
            var arguments = CreateArgumentBuilder(Settings).Append("device adbconnect").AppendQuotedUnlessNullWhitespaceOrEmpty(deviceIdentifier);
            Run(Settings, arguments);
        }

        public void AdbDisconnect(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("device adbdisconnect").AppendQuotedUnlessNullWhitespaceOrEmpty(deviceIdentifier);
            Run(Settings, arguments);
        }

        public void Flash(string archivePath)
        {
            throw new NotImplementedException();
        }

        public void Install(string apkFilePath)
        {
            throw new NotImplementedException();
        }

        public void LogCatClear()
        {
            throw new NotImplementedException();
        }

        public void LogCatDump(string destinationFilePath)
        {
            throw new NotImplementedException();
        }

        public void Pull(string sourcePath, string destinationDirectoryPath)
        {
            throw new NotImplementedException();
        }

        public void Push(string sourcePath, string destinationDirectoryPath)
        {
            throw new NotImplementedException();
        }
    }
}
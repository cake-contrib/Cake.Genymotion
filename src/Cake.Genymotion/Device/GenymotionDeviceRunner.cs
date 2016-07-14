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

        public GenymotionReturnCode AdbConnect(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("device adbconnect").AppendQuotedUnlessNullWhitespaceOrEmpty(deviceIdentifier);
            return (GenymotionReturnCode)RunProcess(Settings, arguments).GetExitCode();
        }

        public GenymotionReturnCode AdbDisconnect(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("device adbdisconnect").AppendQuotedUnlessNullWhitespaceOrEmpty(deviceIdentifier);
            return (GenymotionReturnCode)RunProcess(Settings, arguments).GetExitCode();
        }

        public GenymotionReturnCode Flash(string archivePath)
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode Install(string apkFilePath)
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode LogCatClear()
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode LogCatDump(string destinationFilePath)
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode Pull(string sourcePath, string destinationDirectoryPath)
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode Push(string sourcePath, string destinationDirectoryPath)
        {
            throw new NotImplementedException();
        }
    }
}
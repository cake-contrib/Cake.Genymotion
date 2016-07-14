using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using System;

namespace Cake.Genymotion.Device
{
    public sealed class GenymotionConfigRunner : GenymotionTool<GenymotionDeviceSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionConfigRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
        {
            _environment = environment;
        }

        public GenymotionReturnCode AdbConnect()
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode AdbDisconnect()
        {
            throw new NotImplementedException();
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
﻿using System;
using System.Collections;
using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion.Admin
{

    public sealed class GenymotionAdminRunner : GenymotionTool<GenymotionAdminSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionAdminRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
        {
            _environment = environment;
        }

        public GenymotionReturnCode Clone(string deviceName, string newDeviceName)
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode Delete(string deviceName)
        {
            throw new NotImplementedException();
        }

        public GenymotionDetailsResult Details(string deviceName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenymotionDetailsResult> Details(IEnumerable<string> deviceNames)
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode FactoryReset(string deviceName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenymotionListResult> List()
        {
            throw new NotImplementedException();

        }


        public GenymotionReturnCode LogZip(string deviceName, string logArchivePath)
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode Start(string deviceName)
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode Stop(string deviceName)
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode StopAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenymotionTemplateResult> Templates(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

    }
}

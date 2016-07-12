using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion.Version
{
    public sealed class GenymotionVersionRunner : GenymotionTool<GenymotionVersionSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionVersionRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
        {
            _environment = environment;
        }

        public GenymotionVersion Version()
        {
            throw new NotImplementedException();
        }
    }
}

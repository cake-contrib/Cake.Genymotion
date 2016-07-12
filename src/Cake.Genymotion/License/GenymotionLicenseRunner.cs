using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion.License
{
    public sealed class GenymotionLicenseRunner : GenymotionTool<GenymotionLicenseSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionLicenseRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
        {
            _environment = environment;
        }

        public void Count()
        {
            
        }

        public void Info()
        {
            
        }

        public void Register(string licenseKey)
        {
            
        }

        public void Validity()
        {
            
        }
    }
}

